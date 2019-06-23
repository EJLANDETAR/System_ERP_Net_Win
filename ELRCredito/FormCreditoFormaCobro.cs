using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormCreditoFormaCobro : WinControl_ELR_NET.ELRFormRegistro
    {
        
        public FormCreditoFormaCobro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public override bool GetData()
        {
            bool resultado = false;
            DataTable MyData = null;
            int formaCobro = 0;

            try
            {
                //return base.GetData();
                MyData = objDB.GetById("TEMPRESAS", EMPRESA_ID.ToString(), "Empresa_Id");
               

                if (MyData.Rows.Count <= 0)
                {
                    resultado = false;
                    objUtil.MostrarMensajeError("No se ha Encontrado Ninguna Empresa Con Codigo: " + EMPRESA_ID.ToString());
                    Close();
                }
                else
                {
                    MyData.TableName = "Encabezado";
                    DSDatos.Tables.Add(MyData);
                    formaCobro = objUtil.GetAsInt("Forma_Cobro", MyData.Rows[0]);
                    
                    if (formaCobro <= 1) cboFormaCobro.SelectedIndex = 0;
                    else cboFormaCobro.SelectedIndex = 1;

                    rdbSoloNuevos.Checked = true;

                    resultado = true;
                }
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        public override int GrabarDatos()
        {
            int resultado = -1;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            int formaCobro = 1;
            bool soloNuevos = false;

            try
            {
                //return base.GrabarDatos();
                resp = objUtil.MostrarMensajePregunta("Esta Seguro que Desea Aplicar Este Cambio?");
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {

                    this.Cursor = Cursors.WaitCursor;

                    
                    temporalID = objUtil.GetTemporalID();
                    formaCobro = cboFormaCobro.SelectedIndex + 1;
                    soloNuevos = rdbSoloNuevos.Checked;

                    MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("formaCobro", formaCobro));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("soloNuevos", soloNuevos));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP(SPGraba, MyParametros);
                    if (resultado < 0)
                    {
                        MostrarErrorTemporal();
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        objDB.confirmarTransaccion();
                        objUtil.MostrarMensajeInformacion("Proceso Realizado de Forma Satisfactoria ...");
                        Close();
                    }


                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;

                objDB.cancelarTransaccion();
                objDB.CerrarConeccion();
            }

            return resultado;
        }
    }
}
