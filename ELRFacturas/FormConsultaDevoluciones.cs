using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormConsultaDevoluciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaDevoluciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int filaId = 0;
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    filaId = dataGridView1.CurrentRow.Index;
                    txtComentario.Text = dataGridView1["Comentario", filaId].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objUtil = null;
            }
        }

        public override void GetData(int opcion = 0)
        {
            try
            {
                txtComentario.Text = "";
                base.GetData(opcion);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            string valorId = "0";
            DataRow MyFila = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                objUtil = new WinControl_ELR_NET.ELRUtils();

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("Identificador_Id", MyFila, "0");

                    ImprimirPreviewRDLC("rptDevolucion", "VDEVOLUCIONES_DETALLES", valorId, "Identificador_Id");

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                MyFila = null;
            }
        }
    }
}
