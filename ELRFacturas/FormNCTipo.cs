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
    public partial class FormNCTipo : Form
    {
        public int tipo = -1;

        public FormNCTipo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tipo = -1;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbDevolucion.Checked) tipo = 1;
            else tipo = 2;

            Close();
        }
    }
}
