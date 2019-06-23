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
    public partial class FormRequisiciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormRequisiciones()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            try
            {
                base.GetData(opcion);

                dataGridView1.Columns["btnAnular"].Visible = !esBusqueda;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                if (dataGridView1.RowCount > 0) concepto = dataGridView1["Concepto", dataGridView1.CurrentRow.Index].Value.ToString();

                txtConcepto.Text = concepto;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            string numero = "0";
            string SSQL = "";
            int index = 0;
            DialogResult resp;

            try
            {
                if(dataGridView1.RowCount > 0)
                {
                    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn && !esBusqueda) Modificar();
                    else if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn) SelectFila();
                    else if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        //PROCEDEMOS A ANULAR LA REQUISICION
                        index = dataGridView1.CurrentRow.Index;
                        numero = dataGridView1["Numero", index].Value.ToString();

                        resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Anular Requisicion Numero: " + numero + "?");

                        if (resp == DialogResult.Yes)
                        {
                            Cursor = Cursors.WaitCursor;

                            valorUnico = dataGridView1["Unico", index].Value.ToString();

                            SSQL = " UPDATE TCXP ";
                            SSQL += " SET EsNulo = 1, Fecha_Anulado = GetDate(), ";
                            SSQL += " Estatus_Id = 'N', Estatus = 'ANULADO' ";
                            SSQL += " WHERE Unico = " + valorUnico;

                            if (objDB.EjecutarSQL(SSQL) > 0)
                            {
                                GetData();
                                if (MyData.Rows.Count - 1 >= index) dataGridView1.CurrentCell = dataGridView1["Numero", index];
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
                Cursor = Cursors.Default;
            }
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            int index = 0;
            string valorUnico = "0";
            string valorId = "";
            DataRow fila0;
            DataTable DTData, DTDetalle;
            int oficina = 0;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                if(dataGridView1.RowCount > 0)
                {
                    index = dataGridView1.CurrentRow.Index;
                    valorUnico = dataGridView1["Unico", index].Value.ToString();

                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("CXP_Id", fila0, "0");
                    oficina = objUtil.GetAsInt("Oficina_Id", fila0);

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("CXP_ID", valorId);
                    DTData = objDB.GetAll("VCOMPRAS_REQUISICIONES", 1, objDB.Filtros);

                    //Buscamos el Detalle
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Identificador_Id", valorId);
                    DTDetalle = objDB.GetAll("TCXP_DETALLES", -1, objDB.Filtros);

                    frm.AddDS("DSData", DTData);
                    frm.AddDS("DSDetalle", DTDetalle);
                    frm.oficinaId = oficina;
                    frm.empresaId = empresaID;
                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = "Titulo";
                    frm.pathReporte = objUtil.GetPathReportRDLC("RptCompra_Requisicion");

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
