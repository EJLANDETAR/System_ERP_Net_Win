using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormDesglosePago : Form
    {
        public bool LOK = false;
        public double monto = 0;
        public double montoUS = 0;
        public double enEfectivo = 0;
        public double enCheques = 0;
        public double enTarjetas = 0;
        public double aDevolver = 0;
        public double montoDeduda = 0;
        public double aPagar = 0;
        public bool PermiteCredito = false;
        public int diasCredito = 15;
        public DateTime fechaVence;

        public DataTable DTVariablesSYS;

        public int metodoImp = -1;

        bool esInicio = false;

        //VARIABLES PRIVADAS
        ELRUtils objUtil = new ELRUtils();

        public ELRFormDesglosePago()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LOK = false;
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ELRFormDesglosePago_Load(object sender, EventArgs e)
        {
            bool permiteCheques = false;
            bool permiteTarjetaC = false;

            string sValor  = "";
            int valor = 0;

            try
            {
                btnAceptar.Enabled = false;
    
                montoDeduda = monto;
                txtADevolver.Enabled = false;

                lbTotal.Text = monto.ToString("N2");
                txtAPagar.Text = monto.ToString("N2");
                txtAPagar.ReadOnly = !PermiteCredito;
                txtEnEfectivo.Text = "0.00";
                txtEnCheques.Text = "0.00";
                txtEnTarjeta.Text = "0.00";
                txtADevolver.Text = "0.00";
                lblACredito.Text = "A Deber: " + montoDeduda.ToString("N2");
                lblACredito.Visible = PermiteCredito;

                //BUSCAMOS LA VARIABLES PARA PERMITIR COBRO EN CHEQUES
                valor = -1;
                sValor = "";
                sValor = objUtil.GetValorVariable("COBRO_EN_CHEQUES", DTVariablesSYS, "0").Trim().ToUpper();
                int.TryParse(sValor, out valor);
                if (valor > 0) permiteCheques = true;
                else permiteCheques = (sValor == "TRUE");

                //BUSCAMOS LA VARIABLES PARA PERMITIR COBRO EN TARJETA CREDITO
                valor = -1;
                sValor = "";
                sValor = objUtil.GetValorVariable("COBRO_EN_TARJETA_C", DTVariablesSYS, "0").Trim().ToUpper();
                int.TryParse(sValor, out valor);
                if (valor > 0) permiteTarjetaC = true;
                else permiteTarjetaC = (sValor == "TRUE");

                txtEnCheques.Enabled = permiteCheques;
                txtEnTarjeta.Enabled = permiteTarjetaC;

                txtEnEfectivo.Focus();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool Calcular()
        {
            bool resultado = false;
            double total;
            try
            {
                btnAceptar.Enabled = false;

                montoDeduda = 0;
                enEfectivo = objUtil.ConvertirANumero(txtEnEfectivo.Text);
                enCheques = objUtil.ConvertirANumero(txtEnCheques.Text);
                enTarjetas = objUtil.ConvertirANumero(txtEnTarjeta.Text);
                aPagar = objUtil.ConvertirANumero(txtAPagar.Text);

                aDevolver = enEfectivo - aPagar;
                if(aDevolver < 0) aDevolver = 0;

                total = (enEfectivo - aDevolver) + enCheques + enTarjetas;
                if ((enEfectivo < 0) || (enCheques < 0) || (enTarjetas < 0) || (aPagar < 0))
                {
                    if (aPagar < 0)
                    {
                        txtAPagar.SelectAll();
                        txtAPagar.Focus();
                    }
                    else if(enEfectivo < 0)
                    {
                        txtEnEfectivo.SelectAll();
                        txtEnEfectivo.Focus();
                    }
                    else if (enCheques < 0)
                    {
                        txtEnCheques.SelectAll();
                        txtEnCheques.Focus();
                    }
                    else
                    {
                        txtEnTarjeta.SelectAll();
                        txtEnTarjeta.Focus();
                    }

                    throw new Exception("No Puede Digitar Valores Negativos");
                }
                if (total > aPagar) throw new Exception("El Desglose de Pago no Puede Superar el Monto a Cobrar");
                else
                {
                    montoDeduda = monto - aPagar;

                    //Mostramos los Datos
                    txtADevolver.Text = aDevolver.ToString("n2");
                    lblACredito.Text = "A Deber: " + montoDeduda.ToString("N2");
                    lblACredito.Visible = ((PermiteCredito) && (montoDeduda > 0));

                    btnAceptar.Enabled = (total == aPagar);
                   
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void txtEnCheques_Leave(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            double total = 0;
            Button btn = null;

            LOK = false;
            try
            {
                if (Calcular())
                {
                    //VALIDAMOS CONDICION A CREDITO
                    if ((montoDeduda > 0) && (!PermiteCredito)) objUtil.MostrarMensajeAdvertencia("El Credito No esta Permitido");
                    else if ((montoDeduda > 0) && (PermiteCredito))
                    {
                        respuesta = objUtil.MostrarMensajePregunta("SE REGISTRARA UNA CUENTA POR COBRAR DE: " + montoDeduda.ToString("N2") + "\r" +
                                                        "ESTA SEGURO DE REGISTRAR LOS DATOS?"
                                                  );
                        if (respuesta == System.Windows.Forms.DialogResult.Yes) LOK = true;
                    }
                    else
                    {
                        total = (enEfectivo - aDevolver) + enCheques + enTarjetas;
                        if (total <= 0) objUtil.MostrarMensajeAdvertencia("El Desglose de Pagoo Debe Ser Mayor a Cero");
                        else if ((total - monto) > 1) objUtil.MostrarMensajeAdvertencia("El Desglose de Pagoo No Puede ser Mayor al Monto a Pagar");
                        else LOK = true;
                    }

                    if (LOK)
                    {
                        btn = (Button)sender;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void ELRFormDesglosePago_Shown(object sender, EventArgs e)
        {
            try
            {
                if (txtAPagar.ReadOnly) txtEnEfectivo.Focus();
                else txtAPagar.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void ELRFormDesglosePago_Activated(object sender, EventArgs e)
        {
            if (esInicio && txtEnEfectivo.Enabled && txtEnEfectivo.Visible)
            {
                txtEnEfectivo.Focus();
            }

            esInicio = false;
        }
    }
}
