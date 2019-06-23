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
    public partial class FormSolicitudGarantias : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSolicitudGarantias()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            FormSolicitudGarantias2 frm = new FormSolicitudGarantias2();
            int solicitudId = 0;
            string ANombre = "";
            DataRow MyFila = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;
                if (e.RowIndex < 0) return;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn || senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    solicitudId = objUtil.GetAsInt("Solicitud_Id", MyFila);
                    ANombre = objUtil.GetAsString("Nombre_Completo", MyFila);

                    frm.EnEjecusion = true;
                    frm.nombreUsuario = nombreUsuario;
                    frm.solicitudId = solicitudId;
                    frm.oficinaID = oficinaID;
                    frm.empresaID = empresaID;
                    frm.aNombre = ANombre;
                    frm.DTVariablesSYS = DTVariablesSYS;
                    frm.DTOficina = DTOficina;
                    frm.DTEmpresaOficinas = DTEmpresaOficinas;
                    frm.DSGlobal = DSGlobal;

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
