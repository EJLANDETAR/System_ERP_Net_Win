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
    public partial class FormSolicitudAprobar : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSolicitudAprobar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormSolicitudAprobarR frm = new FormSolicitudAprobarR();
            int solicitudId = 0, index = 0;

            try
            {

                if (MyData == null) return;
                if (DataGridConsulta == null) return;
                if (DataGridConsulta.RowCount <= 0) return;
                if (MyData.Rows.Count <= 0) return;

                this.Cursor = Cursors.WaitCursor;
                

                var senderGrid = (DataGridView)sender;
                index = senderGrid.CurrentRow.Index;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    solicitudId = int.Parse( senderGrid["Solicitud_Id", index].Value.ToString());
                    frm.solicitudId = solicitudId;
                    frm.nombreUsuario = nombreUsuario;
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
