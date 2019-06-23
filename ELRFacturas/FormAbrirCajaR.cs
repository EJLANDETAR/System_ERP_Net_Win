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
    public partial class FormAbrirCajaR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormAbrirCajaR()
        {
            InitializeComponent();
        }

        private void btnDesglosar_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormDesgloseEfectivo frm = new WinControl_ELR_NET.ELRFormDesgloseEfectivo();

            try
            {
                frm.monedaId = 1;
                frm.ShowDialog();

                if (frm.lOK)
                {
                    //PASAMOS EL DESGLOSE
                    txtMontoApertura.SetValor(frm.montoDesglose.ToString(), 0);
                    objUtil.SetValorDT("Desglose_Apertura", frm.desglose, DSDatos.Tables[0], 0);
                }
            }
            catch (Exception ex)
            {

                txtMontoApertura.SetValor("-1");
                objUtil.SetValorDT("Desglose_Apertura", "", DSDatos.Tables[0], 0);
                objUtil.MostrarMensajeError(ex.Message);
            }
        }

      
        private void FormAbrirCajaR_Load(object sender, EventArgs e)
        {
            try
            {
                if (EnEjecusion)
                {
                    lblCajaId.Text = cajaId.ToString();
                    lblUsuario.Text = nombreUsuario.ToUpper();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                this.Close();
            }
        }

       
    }
}
