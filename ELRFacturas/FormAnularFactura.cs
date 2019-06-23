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
    public partial class FormAnularFactura : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormAnularFactura()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WinControl_ELR_NET.ELRFormAnular frm = new WinControl_ELR_NET.ELRFormAnular();
            string valorUnico = "0";
            DataRow myFila = null;

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
                    myFila = MyData.Select("Unico = " + valorUnico)[0];

                    frm.nombreCampoId = "Identificador_Id";
                    frm.drFilaSel = myFila;
                    frm.Text = this.Text;
                    frm.SP_ANULA = "SP_VENTAS_ANULA_FACTURA";
                    frm.NOMBRE_USUARIO = nombreUsuario;

                    frm.ShowDialog();

                    if (frm.lOK) GetData(1);



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

                myFila = null;
            }
        }
    }
}
