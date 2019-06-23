using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormSuCambio : Form
    {

        public double montoADevolver = 0.0;
        public bool mostrarImprimir = false;
        public bool esSuCambio = true;
        public bool esTicket = false;
        public bool esMatricial = false;
        
        public int metodoImp = -1;

        public FormSuCambio()
        {
            InitializeComponent();
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            metodoImp = -1;
            Close();
        }

        private void FormSuCambio_Load(object sender, EventArgs e)
        {
            lblSuCambio.Text = "Su Cambio: " + montoADevolver.ToString("N2");
            if (!esSuCambio) lblSuCambio.Text = "Elija opcion para imprimir!";
            btnPreview.Visible = (mostrarImprimir && metodoImp == 3);
            btnTicket.Visible = esTicket;
            btnMatricial.Visible = esMatricial;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Button btn;
            try
            {
                btn = (Button)sender;
                if (btn == btnTicket) metodoImp = 1;
                else if (btn == btnMatricial) metodoImp = 2;
                else metodoImp = 3;

                Close();
                
            }
            catch (Exception)
            {

                
            }
        }
    }
}
