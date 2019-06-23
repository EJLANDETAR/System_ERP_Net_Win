using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRSmartPhones
{
    public partial class FormSmartPhones : WinControl_ELR_NET.FormPlantillaIndex
    {
        int valorUnico = 0;
        string smartUID = "";

        public FormSmartPhones()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = 0;
            string aprobadoPor = "";
            DataRow fila0;

            try
            {
                btnAprobar.Enabled = false;
                btnBorrar.Enabled = false;

                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta == null) return;
                if (DataGridConsulta.RowCount <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = int.Parse( DataGridConsulta["Unico", index].Value.ToString());
                fila0 = MyData.Select("Unico = " + valorUnico.ToString())[0];
                aprobadoPor = objUtil.GetAsString("Aprobado_Por", fila0);
                smartUID = objUtil.GetAsString("SMart_UID", fila0);

                btnBorrar.Enabled = (valorUnico > 0);
                btnAprobar.Enabled = (valorUnico > 0 && aprobadoPor.Trim() == "");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            string SSQL = "";
            string valor = "0";
            
            try
            {
                if(objUtil.MostrarMensajePregunta("Esta Seguro de Aprobar el uso del Smart Phone con UID: " + smartUID + "?") == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    valor = valorUnico.ToString();



                    SSQL = "UPDATE TSMART_PHONES ";
                    SSQL += " SET Aprobado_Por = '" + nombreUsuario + "', ";
                    SSQL += "     Fecha_Aprobado = GetDate(), ";
                    SSQL += "      EsActivo       = 1 ";
                    SSQL += " WHERE Unico = " + valorUnico.ToString();

                    objDB.EjecutarSQL(SSQL);
                    RealizarBusquedaSencilla();

                    for (int i = 0; i < DataGridConsulta.RowCount; i++)
                    {
                        if (DataGridConsulta["Unico", i].Value.ToString() == valor)
                        {
                            DataGridConsulta.CurrentCell = DataGridConsulta["Aprobado_Por", i];
                            DataGridConsulta.Rows[i].Selected = true;
                            valorUnico = int.Parse(valor);

                            break;
                        }
                    }
                }  
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string SSQL = "";
            string valor = "0";
            try
            {
                if (objUtil.MostrarMensajePregunta("Esta Seguro de borrar el Smart Phone con UID: " + smartUID + "?") == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    valor = valorUnico.ToString();

                    SSQL = "UPDATE TSMART_PHONES ";
                    SSQL += " SET Fecha_Deleted = GetDate(), ";
                    SSQL += "     EsActivo      = 0 ";
                    SSQL += " WHERE Unico = " + valorUnico.ToString();

                    objDB.EjecutarSQL(SSQL);
                    RealizarBusquedaSencilla();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
