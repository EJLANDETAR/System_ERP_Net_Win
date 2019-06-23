using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormNominaTipoMovimientosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormNominaTipoMovimientosR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = base.GetData();

            txtCodigo.Enabled = (resultado && esNuevo);

            return resultado;
        }
    }
}
