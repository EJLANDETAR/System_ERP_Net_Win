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
    public partial class FormTasaInteres : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormTasaInteres()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            DialogResult resp = DialogResult.No;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    resp = objUtil.MostrarMensajePregunta("¿Esta Seguro que Desea Borrar Este Registro?");

                    if (resp == DialogResult.Yes)
                    {
                        if (objDB.MarcarRegistroEliminado("TPRESTAMOS_TASA_INTERES", valorUnico) > 0) GetData();
                    }
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

        private void FormTasaInteres_Activated(object sender, EventArgs e)
        {
            try
            {
                if (esInicio)
                {
                    WindowState = FormWindowState.Maximized;
                    esInicio = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
