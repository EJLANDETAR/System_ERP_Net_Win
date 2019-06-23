using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormOtrosGastosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormOtrosGastosR()
        {
            InitializeComponent();
        }

        private void FormOtrosGastosR_Load(object sender, EventArgs e)
        {
           if ( (EnEjecusion) && (esNuevo == true) )  dtpFecha.Value = DateTime.Now.Date;
        }
    }
}
