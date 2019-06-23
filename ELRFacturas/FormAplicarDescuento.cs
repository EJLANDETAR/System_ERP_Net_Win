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
    public partial class FormAplicarDescuento : Form
    {
        public double montoTotal = 0, porcDescto = 0, descuento = 0, montoAPagar = 0;
        public bool lOK = false;

        WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();
        bool esInicio = true;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lOK = true;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }

        private void FormAplicarDescuento_Activated(object sender, EventArgs e)
        {
            if(esInicio)
            {
                txtMontoAPagar.SelectAll();
                txtMontoAPagar.Focus();
                esInicio = false;
            }
        }

        private void txtMontoAPagar_Leave(object sender, EventArgs e)
        {
            TextBox txtSender;
            try
            {
                txtSender = (TextBox)sender;

                porcDescto = objUtil.ConvertirANumero(txtPorcDescto.Text);
                descuento = objUtil.ConvertirANumero(txtDescuento.Text);
                montoAPagar = objUtil.ConvertirANumero(txtMontoAPagar.Text);

                if (txtSender == txtMontoAPagar )
                {
                    descuento = (montoTotal - montoAPagar);
                    porcDescto = (descuento / montoTotal) * 100;
                }
                else if (txtSender == txtDescuento)
                {
                    montoAPagar = montoTotal - descuento;
                    porcDescto = (descuento / montoTotal) * 100;
                }
                else if(txtSender == txtPorcDescto)
                {
                    descuento = (montoTotal * porcDescto) / 100.0;
                    montoAPagar = (montoTotal - descuento);
                }

                txtPorcDescto.Text = porcDescto.ToString("N2");
                txtDescuento.Text = descuento.ToString("N2");
                txtMontoAPagar.Text = montoAPagar.ToString("N2");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        

        public FormAplicarDescuento()
        {
            InitializeComponent();
        }

        private void FormAplicarDescuento_Load(object sender, EventArgs e)
        {
            

            lblMontoTotal.Text = montoTotal.ToString("N2");
            txtPorcDescto.Text = porcDescto.ToString("N2");
            txtDescuento.Text = descuento.ToString("N2");
            txtMontoAPagar.Text = montoAPagar.ToString("N2");

            txtMontoAPagar.SelectAll();
            txtMontoAPagar.Focus();
        }
    }
}
