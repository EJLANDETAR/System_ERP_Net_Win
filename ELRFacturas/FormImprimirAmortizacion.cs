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
    public partial class FormImprimirAmortizacion : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormImprimirAmortizacion()
        {
            InitializeComponent();
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            string prestamoId = "0";
            DataRow myFila;
            DataTable DTData = null;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                 this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    prestamoId = objUtil.GetAsString("Prestamo_Id", myFila);

                    DTData = objDB.GetById("VPRESTAMOS_AMORTIZACION", prestamoId, "Prestamo_Id");

                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = "AMORTIZACION DE PRESTAMO";
                    frm.DTData = DTData;
                    frm.DTOficina = DTOficina;
                    frm.pathReporte = "RptPrestamoAmortizacion";

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
