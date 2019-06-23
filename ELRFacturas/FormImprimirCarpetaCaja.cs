using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormImprimirCarpetaCaja : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormImprimirCarpetaCaja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            string aperturaNo = "0";
            DataRow myFila;
            DataTable DTData = null;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    aperturaNo = objUtil.GetAsString("Apertura_No", myFila);

                    DTData = objDB.GetById("VCAJAS_CARPETAS", aperturaNo, "Apertura_No");

                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = "CARPETA DE CAJA";
                    frm.DTData = DTData;
                    frm.DTOficina = DTOficina;
                    frm.pathReporte = "RptCarpetadeCaja";

                    frm.ShowDialog();
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
    }
}
