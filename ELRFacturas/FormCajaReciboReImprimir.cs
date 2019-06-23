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
    public partial class FormCajaReciboReImprimir : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCajaReciboReImprimir()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            string valorUnico = "0";
            string valorId = "0";
            string nombreReporte = "";
            int tipoTrans = 0;
            DataRow MyFila = null;
            DataTable DTVistaData = null;
            ELRLogicaNegocio.Cajas lCaja = new ELRLogicaNegocio.Cajas();
            double monto = 0;
            string nombreArchivo = "";
            string logoURL;
            Bitmap imgLogo;

            try
            {
                objUtil = new WinControl_ELR_NET.ELRUtils();

                if (dataGridView1.RowCount > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("Recibo_Id", MyFila, "0");
                    tipoTrans = objUtil.GetAsInt("Tipo_Trans", MyFila);
                    monto = objUtil.GetAsDouble("Monto", MyFila);
                    montoLetras = Numalet.ToCardinal(monto);

                    DTVistaData = objDB.GetById("VCAJAS_RECIBOS", valorId, "Recibo_Id");

                    lCaja.DTDataCXC = DTVistaData;
                    lCaja.montoLetra = montoLetras;
                    lCaja.numeroCopias = IMPRIME_TICKET_COPIA;
                    lCaja.NombreImpresora = impresoraDefault;
                    lCaja.logo = logoEmpresa;
                    lCaja.MOSTRAR_DETALLE_FACTURAS_PAGADAS = MOSTRAR_DETALLE_FACTURAS_PAGADAS;

                    if (tipoTrans == 1) 
                    {
                        nombreReporte = "RptReciboCaja";

                        
                        if(metodoImp == 1) lCaja.ImprimirTicketReciboCXC();
                        else if (metodoImp == 2) lCaja.ImprimirReciboMatricial80();
                        else  ImprimirPreviewRDLC(nombreReporte, "VCAJAS_RECIBOS", valorId, "Recibo_Id");
                    }
                    else
                    {
                        nombreReporte = "RptReciboCajaOtros";

                        if (metodoImp == 1) lCaja.ImprimirTicketOtrosIngresos(DTVistaData, IMPRIME_TICKET_COPIA, impresoraDefault);
                        else if (metodoImp == 2) lCaja.ImprimirReciboOtrosMatricial80();
                        else ImprimirPreviewRDLC(nombreReporte, "VCAJAS_RECIBOS", valorId, "Recibo_Id");
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


    }
}
