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
    public partial class FormSolicitudCreditoRechazar : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSolicitudCreditoRechazar()
        {
            InitializeComponent();
        }

        private void FormSolicitudCreditoRechazar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow myFila = null;
            FormSolicitudCreditoRechazarR frmRechazar = new FormSolicitudCreditoRechazarR();
            try
            {
                 this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    frmRechazar.solicitudId = objUtil.GetAsInt("Solicitud_Id", myFila);
                    frmRechazar.monto = objUtil.GetAsDouble("Monto_Solicitado", myFila);
                    frmRechazar.ANombre = objUtil.GetAsString("Nombre_Completo", myFila);
                    frmRechazar.nombreUsuario = nombreUsuario;
                    frmRechazar.EnEjecusion = true;

                    frmRechazar.ShowDialog();
                    if (frmRechazar.lOK) GetData();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmRechazar.Dispose();
            }
        }
    }
}
