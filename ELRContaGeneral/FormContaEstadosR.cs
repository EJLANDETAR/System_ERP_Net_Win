using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaEstadosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormContaEstadosR()
        {
            InitializeComponent();
        }

        private void FormContaEstadosR_Load(object sender, EventArgs e)
        {
           if(EnEjecusion)  txtNombre.CharacterCasing = CharacterCasing.Normal;
        }
    }
}
