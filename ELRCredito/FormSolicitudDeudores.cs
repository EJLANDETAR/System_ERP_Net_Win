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
    public partial class FormSolicitudDeudores : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSolicitudDeudores()
        {
            InitializeComponent();
        }

        public override void Modificar()
        {
            //base.Modificar();
            string valorUnico;
            DataRow fila0 = null;
            int index = 0;
            int solicitudId = 0;
            FormSolicitudDeudores2 frm = new FormSolicitudDeudores2();

            try
            {
                if (DataGridConsulta.RowCount <= 0) return;

                this.Cursor = Cursors.WaitCursor;

                index = DataGridConsulta.CurrentRow.Index;
                
                //TODO - Button Clicked - Execute Code Here
                valorUnico = DataGridConsulta["unico", index].Value.ToString();

                //BUSCO LA FILA SELECCIONADA POS SU UNICO
                fila0 = MyData.Select("Unico = " + valorUnico.ToString())[0];
                solicitudId = objUtil.GetAsInt("Solicitud_Id", fila0);

                frm.solicitudId = solicitudId;
                frm.ANombre = objUtil.GetAsString("Nombre_Completo", fila0);
                frm.FiltroEstatico = "Solicitud_Id = " + solicitudId.ToString() + " And Fecha_Deleted Is Null And EsNulo = 0";
                frm.empresaID = empresaID;
                frm.oficinaID = oficinaID;
                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
                fila0 = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {

                    Modificar();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            
        }

        private void FormSolicitudDeudores_Load(object sender, EventArgs e)
        {

        }
    }
}
