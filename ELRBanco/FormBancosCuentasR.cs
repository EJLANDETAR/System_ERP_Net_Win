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
    public partial class FormBancosCuentasR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormBancosCuentasR()
        {
            InitializeComponent();
        }

        private void txtCuentaContable_Leave(object sender, EventArgs e)
        {
            string valor = "";
            try
            {
                if (txtCuentaContable.drFilaSel == null)
                {
                    valor = txtCuentaContable.Text.Trim();
                    if (valor != "") GetCuentaContable(valor);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCuentaContable_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F9)) GetCuentaContable();
            else if ((e.KeyCode != Keys.Tab) && (e.KeyCode != Keys.Enter)) txtCuentaContable.drFilaSel = null;
        }

        void GetCuentaContable(string aBuscar = "")
        {
            DataTable DTData;
            DataRow fila0 = null;
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            try
            {
                

                if ( (aBuscar.Trim() != "") && (aBuscar.Trim() != "") )
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Cuenta_Contable", aBuscar.Trim() );
                    objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                    objDB.AddFiltroIgualA("EsControl", "0");
                    DTData = objDB.GetAll("TCONTA_CATALOGO", 1, objDB.Filtros);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.titulo = @"CUENTAS CONTABLE";
                    frm.TablaOVista = "TCONTA_CATALOGO";
                    frm.FiltroEstatico = "Empresa_Id = " + EMPRESA_ID.ToString() + " And EsControl = 0";
                    frm.columnas = new WinControl_ELR_NET.MyColumna[2];


                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "Cuenta_Contable";
                    col.HeaderText = "Cuenta Contable";
                    col.Ancho = 150;
                    frm.columnas[0] = col;

                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "Descripcion";
                    col.HeaderText = "Descripcion";
                    col.Ancho = -1;
                    frm.columnas[1] = col;

                    frm.ShowDialog();

                    if (frm.FilaSelecionada != null)
                    {
                        fila0 = frm.FilaSelecionada;
                        txtCuentaContable.drFilaSel = fila0;
                    }
                }

                if (fila0 != null) txtCuentaContable.Text = objUtil.GetAsString("Cuenta_Contable", fila0);
                
                

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarCtaContable_Click(object sender, EventArgs e)
        {
            GetCuentaContable();
        }
    }
}
