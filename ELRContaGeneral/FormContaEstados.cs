using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaEstados : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaEstados()
        {
            InitializeComponent();
        }

        private void FormContaEstados_Load(object sender, EventArgs e)
        {
            DataGridConsulta.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow fila0 = null;
            int estadoId = 0;
            string descripcion = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                   e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    estadoId = objUtil.GetAsInt("Estado_Id", fila0);
                    descripcion = objUtil.GetAsString("Descripcion", fila0); 

                    FormContaEstadosFormatos frm = new FormContaEstadosFormatos();
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.DTVariablesSYS = DTVariablesSYS;
                    frm.FiltroEstatico = "Estado_Id = " + estadoId.ToString();
                    frm.estadoId = estadoId;
                    frm.titulo = descripcion.ToUpper();
                    frm.EnEjecusion = true;

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
            }
        }
    }
}
