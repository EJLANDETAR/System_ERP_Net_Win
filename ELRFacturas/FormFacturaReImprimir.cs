using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormFacturaReImprimir : WinControl_ELR_NET.FormPlantillaIndex
    {
        

        public FormFacturaReImprimir()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            string valorUnico = "0";
            string valorId = "0";
            string nombreReporte = "";
            DataRow MyFila = null;
            DataTable DTVistaData = null;
            ELRLogicaNegocio.Facturas lFactura = new ELRLogicaNegocio.Facturas();
            int tipoNCF = 0;
            int diasCredito = 0;
            double montoACredito = 0;
            WinControl_ELR_NET.FormSuCambio frmSuCambio = new WinControl_ELR_NET.FormSuCambio();

            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("Identificador_Id", MyFila, "0");

                    DTVistaData = objDB.GetById("VVENTAS_DETALLE", valorId, "Identificador_Id");
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", DTVistaData.Rows[0]);
                    diasCredito = objUtil.GetAsInt("Dias_Credito", DTVistaData.Rows[0]);
                    montoACredito = objUtil.GetAsDouble("Monto_ACredito", DTVistaData.Rows[0]);

                    lFactura.MyData = DTVistaData;
                    lFactura.NombreImpresora = impresoraDefault;
                    lFactura.numeroCopias = IMPRIME_TICKET_COPIA;
                    lFactura.logo = logoEmpresa;

                    if (tipoNCF > 0) nombreReporte = "rptFacturaB";
                    else nombreReporte = "rptFactura";

                    frmSuCambio.mostrarImprimir = true;
                    frmSuCambio.esTicket = true;
                    frmSuCambio.esMatricial = true;
                    frmSuCambio.metodoImp = metodoImp;
                    frmSuCambio.ShowDialog();

                    if (frmSuCambio.metodoImp <= 1) lFactura.ImprimirTicket();
                    else if (frmSuCambio.metodoImp == 2) lFactura.PrintMatricial80();
                    else if(frmSuCambio.metodoImp == 3) ImprimirPreviewRDLC(nombreReporte, "VVENTAS_DETALLE", valorId, "Identificador_Id");
                                        
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0) Imprimir();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }


        }

        public override void ShowPreview()
        {
            string valorUnico = "0";
            DataRow fila0;
            string valorId = "0", nombreReporte = "rptFactura";
            int tipoNCF = 0;
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", fila0);
                    valorId = objUtil.GetAsString("Identificador_Id", fila0, "0");

                    if (tipoNCF > 0) nombreReporte = "rptFacturaB";

                    ImprimirPreviewRDLC(nombreReporte, "VVENTAS_DETALLE", valorId, "Identificador_Id");
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


        private void FormFacturaReImprimir_Load(object sender, EventArgs e)
        {
           
        }
    }
}
