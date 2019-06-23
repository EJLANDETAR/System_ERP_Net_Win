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
    public partial class FormContaEstadosFormatosCuentasR : WinControl_ELR_NET.ELRFormRegistro
    {

        public int formulaId = 0;

        public FormContaEstadosFormatosCuentasR()
        {
            InitializeComponent();
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            try
            {
                frm.titulo = @"CUENTAS CONTABLES";
                frm.TablaOVista = "TCONTA_CATALOGO";
                frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString();
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

                frm.DefaultColumnaBusqueda = "Cuenta_Contable";
                frm.ShowDialog();

                if (frm.FilaSelecionada != null)
                {
                    txtCuentaContable.Text = objUtil.GetAsString("Cuenta_Contable", frm.FilaSelecionada);
                    txtDescripcion.Text = objUtil.GetAsString("Descripcion", frm.FilaSelecionada);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

     

        public override bool ValidarDatos()
        {

            bool resultado = false;
            string SSQL = "";
            string cuentaContable = "";
            DataTable DTValida = null;
            int valorUnico = 0, conteo = 0;

            try
            {
                resultado = base.ValidarDatos();

                if(resultado)
                {
                    //Validamos la cuenta No esta ya registrada
                    cuentaContable = txtCuentaContable.Text.Trim();

                    SSQL = "SELECT Count(*) Conteo FROM " + TablaEncabezado;
                    SSQL += " WHERE Fecha_Deleted Is Null And Formula_Id = " + formulaId.ToString();
                    SSQL += " And '" + cuentaContable + "' Like Cuenta_Contable + '%' ";
                    
                    if(!esNuevo)
                    {
                        valorUnico = objUtil.GetAsInt("Unico", DSDatos.Tables[0].Rows[0]);
                        SSQL += " And Unico <> " + valorUnico.ToString();
                    }

                    DTValida = objDB.GetSQL(SSQL);
                    conteo = objUtil.GetAsInt("Conteo", DTValida.Rows[0]);

                    resultado = (conteo == 0);

                    if (resultado == false) objUtil.MostrarMensajeError("Ya Esta Cuenta o su correspondiente Cuenta Control Esta Registrada en esta Formula");
                }

                if(resultado) SetValorEncabezado("Formula_Id", formulaId);
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;


            
        }
    }
}
