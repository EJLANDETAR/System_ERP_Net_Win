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
    public partial class FormPrestamosDescuentosR : Form
    {

        public DataRow Fila = null;
        public bool LOK = false;

        double interesP, demoraP, otrosP;
        WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();

        public FormPrestamosDescuentosR()
        {
            InitializeComponent();
        }

        private void FormPrestamosDescuentosR_Load(object sender, EventArgs e)
        {
            
            try
            {
                interesP = objUtil.GetAsDouble("Interes_Pendiente", Fila);
                demoraP = objUtil.GetAsDouble("Demora_Pendiente", Fila);
                otrosP = objUtil.GetAsDouble("Otros_Pendiente", Fila);
                lblConcepto.Text = objUtil.GetAsString("Descripcion", Fila);

                txtInteres.Enabled = (interesP > 0);
                txtDemora.Enabled = (demoraP > 0);
                txtOtros.Enabled = (otrosP > 0);

                if (txtInteres.Enabled) txtInteres.Focus();
                else if (txtDemora.Enabled) txtDemora.Focus();
                else if (txtOtros.Enabled) txtOtros.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LOK = false;
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            double interes, demora, otros;
            bool resultado = true;

            try
            {
                interes = double.Parse(txtInteres.Text);
                demora = double.Parse(txtDemora.Text);
                otros = double.Parse(txtOtros.Text);

                if ((interes < 0) || (interes > interesP))
                {
                    objUtil.MostrarMensajeAdvertencia("El Interes a Descontar no puede ser Menor a 0 Ni Mayor A " + interesP.ToString("N2"));
                    resultado = false;
                }

                if (resultado)
                {
                    if ((demora < 0) || (demora > demoraP))
                    {
                        objUtil.MostrarMensajeAdvertencia("La Demora a Descontar no puede ser Menor a 0 Ni Mayor A " + demoraP.ToString("N2"));
                        resultado = false;
                    }
                }

                if (resultado)
                {
                    if ((otros < 0) || (otros > otrosP))
                    {
                        objUtil.MostrarMensajeAdvertencia("Otros a Descontar no puede ser Menor a 0 Ni Mayor A " + otrosP.ToString("N2"));
                        resultado = false;
                    }
                }

                if (resultado)
                {
                    Fila["D_Interes"] = interes;
                    Fila["D_Demora"] = demora;
                    Fila["D_Otros"] = otros;

                    LOK = true;
                    Close();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
