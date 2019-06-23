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
    public partial class FormParamReportes : Form
    {
        public bool lOK = false;

        public bool esPorOficina = false;
        public bool esPorEvaluador = false;
        public bool esPorOficialCredito = false;
        public bool esPorCaja = false;
        public bool esPorVendedor = false;
        public bool esHastaFecha = false;
        public bool esRangoFecha = false;
        public bool esPorCampoId = false;
        public bool esPorZona = false;
        public bool esAUnaFecha = false;
       

        ELRUtils objUtil = new ELRUtils();

       public int evaluadorId = 0;
       public  int oficialCreditoId = 0;
       public  int vendedorId = 0;
       public  int cajaId = 0;
       public int oficinaId = 0;
       public int zonaId = 0;
       public string valorId = "";

        public FormParamReportes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {

                lOK = true;
                Close();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormRangoFecha_Load(object sender, EventArgs e)
        {
            int alto = 0;
            int ancho = 500;
           

            try
            {
                DateTime fecha = DateTime.Now.Date;
                dtpFechaHasta.Value = fecha;
                dtpAFecha.Value = fecha;
                dtpFechaDesde.Value = fecha.AddDays((fecha.Day - 1) * -1);

                alto = this.Height;

                pnOficina.Visible = esPorOficina;
                chkPorOficina.Checked = esPorOficina;
                if (esPorOficina == false) alto -= pnOficina.Height;
                else ancho = 624;

                pnPorEvaluador.Visible = esPorEvaluador;
                chkPorEvaluador.Checked = esPorEvaluador;
                if (esPorEvaluador == false) alto -= pnPorEvaluador.Height;
                else ancho = 624;

                pnPorOficialCredito.Visible = esPorOficialCredito;
                chkPorOficialCredito.Checked = esPorOficialCredito;
                if (esPorOficialCredito == false) alto -= pnPorOficialCredito.Height;
                else ancho = 624;

                pnPorCajaId.Visible = esPorCaja;
                chkPorCajaId.Checked = esPorCaja;
                if (esPorCaja == false) alto -= pnPorCajaId.Height;
                else ancho = 624;

                pnVendedor.Visible = esPorVendedor;
                chkPorVendedor.Checked = esPorVendedor;
                if (esPorVendedor == false) alto -= pnVendedor.Height;
                else ancho = 624;

                pnFechaHasta.Visible = esAUnaFecha;
                if (esAUnaFecha == false) alto -= pnFechaHasta.Height;

                pnPorRangoFecha.Visible = esRangoFecha;
                if (esRangoFecha == false) alto -= pnPorRangoFecha.Height;

                this.Width = ancho;
                this.Height = alto;

                if (esPorOficina) cboOficina.LlenarCombo();
                if (esPorCaja) cboCaja.LlenarCombo();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }

        }

        private void btnBusquedaEvaluador_Click(object sender, EventArgs e)
        {
            DataRow fila = null;
            try
            {
                fila = btnBusquedaEvaluador.filaSelecionada;

                if (fila != null)
                {
                    evaluadorId = int.Parse( fila["Empleado_Id"].ToString());
                    lblEvaluadorId.Text = evaluadorId.ToString().PadLeft(6, '0');

                    lblNombreEvaluador.Text = fila["Nombre_Completo"].ToString();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

      

        private void Opcion_Cheched(object sender, EventArgs e)
        {
            CheckBox chk = null;

            try
            {
                chk = (CheckBox)sender;

                if (chk == chkPorOficina)
                {
                    cboOficina.Enabled = chk.Checked;
                    if (!chk.Checked)
                    {
                        oficinaId = 0;
                        cboOficina.SelectedValue = 0;
                    }
                }

                if (chk == chkPorCajaId)
                {
                    cboCaja.Enabled = chk.Checked;
                    if (!chk.Checked)
                    {
                        cajaId = 0;
                        cboCaja.SelectedValue = 0;
                    }
                }

                if (chk == chkPorEvaluador)
                {
                    btnBusquedaEvaluador.Enabled = chk.Checked;
                    if (!chk.Checked)
                    {
                        evaluadorId = 0;
                        lblEvaluadorId.Text = "000000";
                        lblNombreEvaluador.Text = "(TODOS)";
                    }
                }

                if (chk == chkPorOficialCredito)
                {
                    btnPorOficialCredito.Enabled = chk.Checked;
                    if (!chk.Checked)
                    {
                        oficialCreditoId = 0;
                        lblOficialId.Text = "000000";
                        lblNombreOficial.Text = "(TODOS)";
                    }
                }

                if (chk == chkPorVendedor)
                {
                    btnPorVendedor.Enabled = chk.Checked;
                    if (!chk.Checked)
                    {
                        vendedorId = 0;
                        lblVendedorId.Text = "000000";
                        lblNombreVendedor.Text = "(TODOS)";
                    }
                }


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnPorOficialCredito_Click(object sender, EventArgs e)
        {
            DataRow fila = null;
            try
            {
                fila = btnPorOficialCredito.filaSelecionada;

                if (fila != null)
                {
                    oficialCreditoId = int.Parse(fila["Empleado_Id"].ToString());
                    lblOficialId.Text = oficialCreditoId.ToString().PadLeft(6, '0');

                    lblNombreOficial.Text = fila["Nombre_Completo"].ToString();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnPorVendedor_Click(object sender, EventArgs e)
        {
            DataRow fila = null;
            try
            {
                fila = btnPorVendedor.filaSelecionada;

                if (fila != null)
                {
                    vendedorId = int.Parse(fila["Empleado_Id"].ToString());
                    lblVendedorId.Text = vendedorId.ToString().PadLeft(6, '0');

                    lblNombreVendedor.Text = fila["Nombre_Completo"].ToString();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
