using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRBanco
{
    public partial class FormBancosFormatoChequesR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormBancosFormatoChequesR()
        {
            InitializeComponent();
        }

        private void FormBancosFormatoChequesR_Activated(object sender, EventArgs e)
        {
            txtDiasPosX.Focus();
        }
    }
}
