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
    public partial class FormCajasDisponible : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCajasDisponible()
        {
            InitializeComponent();
        }

        private void FormCajasDisponible_Load(object sender, EventArgs e)
        {
            
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            int cajaId = 0;
            FormAbrirCajaR frm = new FormAbrirCajaR();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    cajaId = int.Parse(senderGrid["Caja_Id", senderGrid.CurrentRow.Index].Value.ToString());

                    frm.cajaId = cajaId;
                    frm.nombreUsuario = nombreUsuario;
                    frm.VALOR_ID = "0";
                    frm.EMPRESA_ID = empresaID;
                    frm.OFICINA_ID = oficinaID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.lOK) GetData();

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
