using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsultaHistoricoCliente : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaHistoricoCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow MyFila = null;
            FormConsultaHistoricoClienteDetalle frmDetalle = new FormConsultaHistoricoClienteDetalle();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];

                    frmDetalle.MOSTRAR_COLUMNA_PRESTAMO = MOSTRAR_COLUMNA_PRESTAMO;
                    frmDetalle.MOSTRAR_COLUMNA_FACTURA = MOSTRAR_COLUMNA_FACTURA;

                    frmDetalle.filaEntidad = MyFila;
                    frmDetalle.nombreUsuario = nombreUsuario;
                    frmDetalle.empresaId = empresaID;
                    frmDetalle.oficinaId = oficinaID;

                    frmDetalle.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmDetalle.Dispose();
                MyFila = null;
            }
        }
    }
}
