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
    public partial class FormContaAsientoPredefinidosR : WinControl_ELR_NET.ELRFormRegistro
    {
        DataRow DRCuentasContables = null;

        public FormContaAsientoPredefinidosR()
        {
            InitializeComponent();
        }

        private void GetCuentaContable(string cuentaNo = "")
        {
            
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            try
            {
                //Vamos a Buscar LA CUENTA
                DRCuentasContables = null;
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

                if (frm.FilaSelecionada != null) DRCuentasContables = frm.FilaSelecionada;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCtaDebito_Click(object sender, EventArgs e)
        {
            Button btn;
            string cuentaContable = "";
            try
            {
                btn = (Button)sender;
                GetCuentaContable();

                if(DRCuentasContables != null)
                {
                    cuentaContable = objUtil.GetAsString("Cuenta_Contable", DRCuentasContables);
                    if (btn == btnCtaDebito) txtCuentaDebito.Text = cuentaContable;
                    else if (btn == btnCtaCredito) txtCuentaCredito.Text = cuentaContable;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
