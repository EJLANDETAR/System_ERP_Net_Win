using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormSolicitudCredito : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSolicitudCredito()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int solicitudId = 0;
            DataRow fila0 = null;
            ELRPrintDocument.ELRDocument pd = new ELRPrintDocument.ELRDocument();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    Modificar();
                }
                else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //Imprimimos la solicitud
                    valorUnico = senderGrid["Unico", senderGrid.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    solicitudId = objDB.GetAsInt("Solicitud_Id", fila0);
                    pd.GenerarContractoPDF(solicitudId, "SOL", nombreUsuario);
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
    }
}
