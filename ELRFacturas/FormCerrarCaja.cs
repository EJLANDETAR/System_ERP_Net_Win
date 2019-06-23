using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormCerrarCaja : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormCerrarCaja()
        {
            InitializeComponent();
        }

        private void btnDesgloseCierre_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormDesgloseEfectivo frm = new WinControl_ELR_NET.ELRFormDesgloseEfectivo();
            
            try
            {
                lblEfectivo.Text = "-1";
                DSDatos.Tables[0].Rows[0]["Desglose_Cierre"] = "";

                frm.ShowDialog();

                if (frm.lOK)
                {

                    lblEfectivo.Text = frm.montoDesglose.ToString("N2");
                    DSDatos.Tables[0].Rows[0]["Desglose_Cierre"] = frm.desglose;

                    CalcularDiferencia();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }

        }

        private void CalcularDiferencia()
        {
            double totalEsperado = 0; double totalEnCaja = 0;
            double enEfectivo = 0; double enCheques = 0; double enTarjetaC;
            double faltante = 0; double sobrante = 0;
            DataRow fila0 = null;

            try
            {
                fila0 = DSDatos.Tables[0].Rows[0];
                totalEsperado = objUtil.GetAsDouble("Total_Esperado", fila0);

                enEfectivo = double.Parse(lblEfectivo.Text);
                enCheques = double.Parse(txtChequesEnCaja.Text);
                enTarjetaC = double.Parse(txtTarjeta.Text);

                totalEnCaja = enEfectivo + enTarjetaC + enCheques;

                if (totalEnCaja > totalEsperado) sobrante = totalEnCaja - totalEsperado;
                else faltante = totalEsperado - totalEnCaja;

                lblTotalEsperado.Text = totalEsperado.ToString("N2");
                lblTotalEnCaja.Text = totalEnCaja.ToString("N2");
                lblSobrante.Text = sobrante.ToString("N2");
                lblFaltante.Text = Math.Abs(faltante).ToString("N2");

                fila0["Sobrante"] = sobrante;
                fila0["Faltante"] = Math.Abs(faltante);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void txtChequesEnCaja_Leave(object sender, EventArgs e)
        {
            try
            {
                CalcularDiferencia();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            bool resultado = false;

            try
            {
                resultado = base.GetData();
                if (resultado)
                {
                    CalcularDiferencia();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }

            return resultado;
        }
    }
}
