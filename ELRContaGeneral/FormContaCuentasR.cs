using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaCuentasR : WinControl_ELR_NET.ELRFormRegistro
    {

       
        public FormContaCuentasR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;

            resultado = base.GetData();

            if (esNuevo) txtCuentaContable.ReadOnly = false;
            else txtCuentaContable.ReadOnly = true;

            return resultado;
        }

        

    }
}
