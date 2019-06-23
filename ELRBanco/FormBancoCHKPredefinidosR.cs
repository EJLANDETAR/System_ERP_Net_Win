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
    public partial class FormBancoCHKPredefinidosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormBancoCHKPredefinidosR()
        {
            InitializeComponent();
        }

        private void GetCuentaContable(string cuentaNo = "")
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            //Vamos a Buscar el Producto
            frm.titulo = @"CUENTAS CONTABLES";
            frm.TablaOVista = "TCONTA_CATALOGO";
            frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString() + " And EsControl = 0 And EsMovimiento = 1";
            frm.columnas = new WinControl_ELR_NET.MyColumna[2];


            col = new WinControl_ELR_NET.MyColumna();
            col.NombreCampo = "Cuenta_Contable";
            col.HeaderText = "Cuenta Contable";
            col.Ancho = 140;
            frm.columnas[0] = col;

            col = new WinControl_ELR_NET.MyColumna();
            col.NombreCampo = "Descripcion";
            col.HeaderText = "Descripcion";
            col.Ancho = -1;
            frm.columnas[1] = col;

            frm.ShowDialog();

            if (frm.FilaSelecionada != null) txtCuentaContable.Text = objUtil.GetAsString("Cuenta_Contable", frm.FilaSelecionada);
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            GetCuentaContable();
        }
    }
}
