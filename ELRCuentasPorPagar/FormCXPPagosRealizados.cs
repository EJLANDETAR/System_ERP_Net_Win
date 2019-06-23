using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormCXPPagosRealizados : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCXPPagosRealizados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resp;
            bool esNulo;
            string valorUnico = "0";
            DataRow fila0;
            int index = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            int pagoId = 0;
            string temporalId = "";

            try
            {
                if(dataGridView1.RowCount > 0)
                {
                    if(dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        index = dataGridView1.CurrentRow.Index;
                        valorUnico = dataGridView1["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        esNulo = objUtil.GetAsBoolean("EsNulo", fila0);
                        pagoId = objUtil.GetAsInt("Pago_Id", fila0);

                        if(!esNulo)
                        {
                            resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Anular Este Pago?");

                            if(resp == DialogResult.Yes)
                            {
                                this.Cursor = Cursors.WaitCursor;

                                temporalId = objUtil.GetTemporalID();
                                parms.Add(new DataDB_ELR_NET.Parametro("pagoId", pagoId.ToString()));
                                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                                objDB.iniciarTransaccion();
                                spReturn = objDB.EjecutarSP("SP_CXP_ANULAR_PAGO", parms);

                                if (spReturn < 0) MostrarErrorTemporal(temporalId);
                                else
                                {
                                    objDB.confirmarTransaccion();
                                    GetData(0);

                                    if (index <= dataGridView1.RowCount - 1) dataGridView1.CurrentCell = dataGridView1["btnAnular", index];
                                }
                            }
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
                this.Cursor = Cursors.Default;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";

            try
            {
                if(dataGridView1.RowCount > 0)
                {
                    concepto = dataGridView1["Concepto", dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                concepto = ex.Message;
                objUtil.MostrarMensajeError(ex.Message);
            }

            txtConcepto.Text = concepto;
        }
    }
}
