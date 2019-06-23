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
    public partial class FormContaEnlaceCuentaR : WinControl_ELR_NET.ELRFormRegistro
    {
        public int enlaceId = 0;
        public string codigo;

        public FormContaEnlaceCuentaR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            string SSQL = "";
            DataTable DTEnlaces = null;
            bool esDebito = false;

            try
            {
                
                SSQL = " SELECT 0 as Enlace_Id, '(TODOS)' as Descripcion ";
                SSQL += " UNION ALL";
                SSQL += " SELECT Enlace_Id, Descripcion From TCONTA_ENLACES where Enlace_Id > 0";

                DTEnlaces = objDB.GetSQL(SSQL);
                cboEnlace.DataSource = DTEnlaces.DefaultView;

                resultado = base.GetData();

                if (!esNuevo)
                {
                    enlaceId = objUtil.GetAsInt("Enlace_Id", DSDatos.Tables[0].Rows[0]);
                    esDebito = objUtil.GetAsBoolean("EsDebito", DSDatos.Tables[0].Rows[0]);

                    cboEnlace.SelectedValue = enlaceId;
                    
                }
            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        public override void PasarValorADS()
        {
            try
            {
                base.PasarValorADS();
                codigo = txtCodigo.Text.Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetCuentaContable(string cuentaNo = "")
        {
            string cuentaContable = "";
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            //Vamos a Buscar la Cuenta Contable
            try
            {
                frm.titulo = @"CUENTAS CONTABLES";
                frm.TablaOVista = "TCONTA_CATALOGO";
                frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString() + " And EsControl = 0";
                frm.columnas = new WinControl_ELR_NET.MyColumna[2];


                col = new WinControl_ELR_NET.MyColumna();
                col.NombreCampo = "Cuenta_Contable";
                col.HeaderText = "Cuenta Contable";
                col.Ancho = 140;
                frm.columnas[0] = col;
                frm.DefaultColumnaBusqueda = "Cuenta_Contable";

                col = new WinControl_ELR_NET.MyColumna();
                col.NombreCampo = "Descripcion";
                col.HeaderText = "Descripcion";
                col.Ancho = -1;
                frm.columnas[1] = col;

                frm.ShowDialog();

                if (frm.FilaSelecionada != null)
                {
                    cuentaContable = objUtil.GetAsString("Cuenta_Contable", frm.FilaSelecionada);
                    txtCuentaContable.Text = cuentaContable;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            GetCuentaContable();
        }
    }
}
