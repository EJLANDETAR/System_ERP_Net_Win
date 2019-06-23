using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormNCPorDescuentoR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormNCPorDescuentoR()
        {
            InitializeComponent();
        }

        private void txtPorcDescto_Leave(object sender, EventArgs e)
        {
            TextBox txtSender;
            double porcDescto = 0;
            double montoFactura = 0;
            double total = 0;

            try
            {
                txtSender = (TextBox)sender;

                montoFactura = objUtil.ConvertirANumero(txtFacturaMonto.Text);

                porcDescto = objUtil.ConvertirANumero(txtPorcDescto.Text);
                total = objUtil.ConvertirANumero(txtMonto.Text);

                if (txtSender == txtMonto) porcDescto = (total / montoFactura) * 100;
                else total = (montoFactura * porcDescto) / 100.0;

                txtPorcDescto.Text = porcDescto.ToString("N2");
                txtMonto.Text = total.ToString("N2");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
