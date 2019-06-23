using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormOtrosGastos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormOtrosGastos()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            double totalItbis = 0, totalNeto = 0, total = 0;
            try
            {
                base.GetData(opcion);

                totalItbis = GetSum("Itbis");
                totalNeto = GetSum("Neto");
                total = GetSum("Total");

                lblTotalNeto.Text = totalNeto.ToString("N2");
                lblTotalItbis.Text = totalItbis.ToString("N2");
                lblTotal.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0) Modificar();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frmReporte = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                frmReporte.titulo = "RELACION DE GASTOS";

                if (chkRangoFecha.Checked) frmReporte.titulo +=  ", FECHA [ " + objUtil.GetDateAsString(dtpFechaDesde.Value.Date) + " - " +
                                          objUtil.GetDateAsString(dtpFechaHasta.Value.Date) + "]";

                frmReporte.pathReporte = "RptGastos";
                frmReporte.nombreUsuario = nombreUsuario;
                frmReporte.oficinaId = oficinaID;
                frmReporte.empresaId = empresaID;

                frmReporte.AddDS("DSData", MyData);

                frmReporte.ShowDialog();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int filaId = 0;
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    filaId = dataGridView1.CurrentRow.Index;
                    txtConcepto.Text = dataGridView1["Concepto", filaId].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
