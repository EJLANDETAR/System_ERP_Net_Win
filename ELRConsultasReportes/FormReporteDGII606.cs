using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRConsultasReportes
{
    public partial class FormReporteDGII606 : WinControl_ELR_NET.FormPlantillaIndex
    {
        int conteo = 0, nErrores = 0;
        double totalItbis = 0, totalMonto = 0, totalRetItbis = 0, totalRetRenta = 0, totalFacturado = 0;

        private void FormReporteDGII606_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (temporalId != "") objDB.LimpiarTemporal("TTEMPORAL_DGII_606", "", temporalId);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarData606();
        }

        string temporalId = ""; 

        public FormReporteDGII606()
        {
            InitializeComponent();
        }

        private void dtg606_SelectionChanged(object sender, EventArgs e)
        {
            string _estatus = "";
            string valor = "";
            int index = 0;
            try
            {
                txtEstatus.Text = "";
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                if (dtg606.RowCount > 0)
                {
                    index = dtg606.CurrentRow.Index;
                    valor = dtg606["Estatus", index].Value.ToString();
                    if (valor.Trim() != "") _estatus = "Fila No: " + (index + 1).ToString() + ", " + valor;
                }

                txtEstatus.Text = _estatus;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void FormReporteDGII606_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date.AddMonths(-1);
            tsbExcel.Enabled = false;
            tsbTXT.Enabled = false;
            dtpFecha1.Value = objUtil.getPrimeraFechaMes(fecha);
            dtpFecha2.Value = objUtil.getUltimaFechaMes(fecha);

            tsbBusquedaAvanzada.Enabled = false;
            tsmFilasAMostrar.Enabled = false;
            tsmFilasAMostrar.Visible = false;

            MostrarCantidadFilas();
        }

        void GenerarData606()
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            int fechaDesde = 0;
            int fechaHasta = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                tsProgressBar.Visible = false;
                conteo = 0; totalItbis = 0; totalMonto = 0; totalFacturado = 0; nErrores = 0;
                tsbExcel.Enabled = false;
                tsbTXT.Enabled = false;

                if (temporalId == "") temporalId = objUtil.GetTemporalID();

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                if (MyData != null)
                {
                    MyData.Clear();
                }

                //EJECUTAMOS EL STORE PROCEDURE
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                parms.Add(new DataDB_ELR_NET.Parametro("fechaDesde", fechaDesde));
                parms.Add(new DataDB_ELR_NET.Parametro("fechaHasta", fechaHasta));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", empresaID));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_DGII_GENERAR_606", parms);

                if (spReturn < 0) MostrarErrorTemporal(temporalId);
                else
                {
                    objDB.confirmarTransaccion();

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalId);
                    objDB.AddFiltroOrderBY("Fecha_Comprobante, Unico, Tipo");

                    MyData = objDB.GetAll("TTEMPORAL_DGII_606", -1, objDB.Filtros);
                    dtg606.AutoGenerateColumns = false;
                    dtg606.DataSource = MyData.DefaultView;

                    conteo = MyData.Rows.Count;
                    totalItbis = GetSum("Itbis");
                    totalRetItbis = GetSum("Itbis_Retenido");
                    totalRetRenta = GetSum("Renta_Retenida");
                    totalMonto = GetSum("Monto");
                    nErrores = GetCount("Unico", "Estatus <> ''");

                    tsbExcel.Enabled = (conteo > 0);
                    tsbTXT.Enabled = (conteo > 0 && nErrores == 0);

                    if(nErrores > 0) tsbTXT.ToolTipText = "No es Posible Generar Archivo de Texto, Existen " + nErrores.ToString() + " Errores";
                    else tsbTXT.ToolTipText = "Generar Archivo de Texto";
                    
                }

                totalFacturado = totalItbis + totalMonto;
                lblConteo.Text = "Cantidad Registro: " + conteo.ToString() +
                                 "       Total Facturado: " + totalFacturado.ToString("N2");

                lblTotal1.Text = "Monto Facturado: " + totalMonto.ToString("N2") +
                                "        ITBIS Facturado: " + totalItbis.ToString("N2");

                lblTotal2.Text = "ITBIS Retenido: " + totalRetItbis.ToString("N2") +
                                "        Retencion Renta: " + totalRetRenta.ToString("N2");

                MostrarCantidadFilas();
                Imprimir();

            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                parms = null;
            }
        }

        public override void Imprimir()
        {
            // base.Imprimir();
            string pathReporte = "";
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();
            try
            {
                if (MyData == null) return;
                
                Cursor = Cursors.WaitCursor;

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptDGIIReporte606");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = MyData;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "REPORTE 606";
                    frmPreview.pathReporte = pathReporte.Trim();
                    frmPreview.montoLetras = montoLetras;

                    frmPreview.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                frmPreview.Dispose();
            }
        }

        public override void GenerarTXT()
        {
            DataRow fila0;
            string pathFile = "";
            string encabezado = "606";
            string detalle = "";
            string rnc = "", periodo = "";
            string cedulaRNC = "", tipoId = "", ncf = "", ncfModificado = "", feComprobante = "", fePago = "";
            DateTime fecha = DateTime.Now;
            string sItbis = "", sMonto = "", sRetItbis = "", sRetRenta = "";
            string tipoGastos = "";
            try
            {
                if (MyData == null) return;

                tsProgressBar.Value = 0;
                tsProgressBar.Maximum = MyData.Rows.Count;
                tsProgressBar.Width = 350;
                tsProgressBar.Step = 1;

                pathFile = GetFolderDocGenerados("DGII");

                fila0 = MyData.Rows[0];
                rnc = objUtil.GetAsString("EmpresaRNC", fila0).Replace("-", "");
                periodo = objUtil.GetAsString("Periodo", fila0);
                pathFile += @"\DGII_F_606_" + rnc + "_" + periodo + ".txt";

                //FORMAMOS EL ENCABEZADO
                encabezado += rnc.PadRight(11, ' ');
                encabezado += periodo;
                encabezado += conteo.ToString().PadLeft(12, '0');
                encabezado += totalMonto.ToString("N2").Replace(",", "").PadLeft(16, '0');
                encabezado += totalRetRenta.ToString("N2").Replace(",", "").PadLeft(16, '0');

                System.IO.StreamWriter sw = new System.IO.StreamWriter(pathFile);

                sw.WriteLine(encabezado);

                //AGREGAMOS LINEA DETALLE
                tsProgressBar.Visible = true;
                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    cedulaRNC = objUtil.GetAsString("CedulaRNC", item).Replace("-", "");
                    tipoId = objUtil.GetAsString("Tipo_Id", item);
                    tipoGastos = objUtil.GetAsString("Tipo_Gastos", item).Trim().Substring(0, 2);
                    ncf = objUtil.GetAsString("NCF", item);
                    ncfModificado = objUtil.GetAsString("NCF_Modificado", item);
                    fecha = objUtil.GetAsDate("Fecha_Comprobante", item);
                    feComprobante = objUtil.DateToInt(fecha).ToString();
                    fecha = objUtil.GetAsDate("Fecha_Pago", item);
                    fePago = objUtil.DateToInt(fecha).ToString();

                    sItbis = objUtil.GetAsDouble("Itbis", item).ToString("N2").Replace(",", "");
                    sMonto = objUtil.GetAsDouble("Monto", item).ToString("N2").Replace(",", "");

                    sRetItbis = objUtil.GetAsDouble("Itbis_Retenido", item).ToString("N2").Replace(",", "");
                    sRetRenta = objUtil.GetAsDouble("Renta_Retenida", item).ToString("N2").Replace(",", "");

                    detalle = cedulaRNC.PadRight(11, ' ');
                    detalle += tipoId;
                    detalle += tipoGastos;
                    detalle += ncf.PadRight(19, ' ');
                    detalle += ncfModificado.PadRight(19, ' ');
                    detalle += feComprobante;
                    detalle += fePago;
                    detalle += sItbis.PadLeft(12, '0');
                    detalle += sRetItbis.PadLeft(12, '0');
                    detalle += sMonto.PadLeft(12, '0');
                    detalle += sRetRenta.PadLeft(12, '0');

                    sw.WriteLine(detalle);
                    tsProgressBar.PerformStep();
                    Cursor = Cursors.Default;

                }

                sw.Close();
                objUtil.MostrarMensajeInformacion(pathFile.ToUpper(), "ARCHIVO GENERADO");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public override void GenerarEXCEL(string titulo = "")
        {
            DataRow fila0;
            string pathFile = "";
            string pathPlantilla = "";
            string cedulaRNC = "";
            string periodo = "";
            string tipoId = "", ncf = "", ncfModificado = "";
            DateTime fecha = DateTime.Now;
            string feComprobante = "", fePago = "";
            double itbis = 0, monto = 0, retItbis = 0, retRenta = 0;
            double enServicios = 0, enBienes = 0;
            int lineaNo = 12;
            string tipoGastos = "";


            OfficeDriver.ExcelDriver objExcel = null;

            try
            {
                if (MyData == null) return;

                if (!objUtil.IsMSExcelIntalled()) throw new Exception("MICROSOFT EXCEL NO ESTA INSTALADO...");

                objExcel = new OfficeDriver.ExcelDriver();
                objExcel.isOpenOffice = false;

                Cursor = Cursors.WaitCursor;

                //CREAMOS Directorio para Ubicar Archivos

                //Buscamos la Plantilla de excel
                pathPlantilla = System.Environment.CurrentDirectory + @"\Files\plantilla606.xls";
                if (!File.Exists(pathPlantilla)) pathPlantilla = GetFolderDocGenerados("DGII") + @"\plantilla606.xls";

                if (File.Exists(pathPlantilla))
                {
                    pathFile = GetFolderDocGenerados("DGII") + @"\temp_plantilla606.xls";
                    if (File.Exists(pathFile)) File.Delete(pathFile);

                    File.Copy(pathPlantilla, pathFile);
                }
                else
                {
                    objUtil.MostrarMensajeError("NO EXISTE PALNTILLA606.xls");
                    Cursor = Cursors.Default;
                    return;
                }

                tsProgressBar.Value = 0;
                tsProgressBar.Maximum = MyData.Rows.Count + 1;
                tsProgressBar.Width = 350;
                tsProgressBar.Step = 1;
                tsProgressBar.Visible = true;

                fila0 = MyData.Rows[0];
                cedulaRNC = objUtil.GetAsString("EmpresaRNC", fila0).Replace("-", "");
                periodo = objUtil.GetAsString("Periodo", fila0);

                //ABRIMOS EL ARCHIVO
                objExcel.OpenWorkBook(pathFile);

                objExcel.SetCellValue("C4", cedulaRNC);
                objExcel.SetCellValue("C5", periodo);
                objExcel.SetCellValue("C6", conteo);

                tsProgressBar.PerformStep();

                //EJECUTAMOS LA MACRO
                objExcel.RunMacro("'Formato606.cmdDataEntry_Click'");

                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    cedulaRNC = objUtil.GetAsString("CedulaRNC", item).Replace("-", "");
                    tipoId = objUtil.GetAsString("Tipo_Id", item);
                    tipoGastos = objUtil.GetAsString("Tipo_Gastos", item);
                    ncf = objUtil.GetAsString("NCF", item);
                    ncfModificado = objUtil.GetAsString("NCF_Modificado", item);
                    fecha = objUtil.GetAsDate("Fecha_Comprobante", item);
                    feComprobante = objUtil.DateToInt(fecha).ToString();
                    fecha = objUtil.GetAsDate("Fecha_Pago", item);
                    fePago = objUtil.DateToInt(fecha).ToString();
                    enServicios = objUtil.GetAsDouble("EnServicios", item);
                    enBienes = objUtil.GetAsDouble("EnBienes", item);
                    monto = objUtil.GetAsDouble("Monto", item);                    
                    itbis = objUtil.GetAsDouble("Itbis", item);
                    retItbis = objUtil.GetAsDouble("Itbis_Retenido", item);
                    retRenta = objUtil.GetAsDouble("Renta_Retenida", item);
                    if (enServicios <= 0 && enBienes <= 0) enBienes = monto;

                    objExcel.SetCellValue("B" + lineaNo.ToString(), cedulaRNC);                    
                    objExcel.SetCellValue("D" + lineaNo.ToString(), tipoGastos);
                    objExcel.SetCellValue("E" + lineaNo.ToString(), ncf);
                    objExcel.SetCellValue("F" + lineaNo.ToString(), ncfModificado);
                    objExcel.SetCellValue("G" + lineaNo.ToString(), feComprobante.Substring(0, 6));
                    objExcel.SetCellValue("H" + lineaNo.ToString(), feComprobante.Substring(6, 2));
                    objExcel.SetCellValue("I" + lineaNo.ToString(), fePago.Substring(0, 6));
                    objExcel.SetCellValue("J" + lineaNo.ToString(), fePago.Substring(6, 2));
                    objExcel.SetCellValue("K" + lineaNo.ToString(), enServicios);
                    objExcel.SetCellValue("L" + lineaNo.ToString(), enBienes);
                    objExcel.SetCellValue("M" + lineaNo.ToString(), monto);
                    objExcel.SetCellValue("N" + lineaNo.ToString(), itbis);
                    objExcel.SetCellValue("O" + lineaNo.ToString(), retItbis);
                    objExcel.SetCellValue("P" + lineaNo.ToString(), objUtil.GetAsDouble("Itbis_Proporcionalidad", item));
                    objExcel.SetCellValue("Q" + lineaNo.ToString(), objUtil.GetAsDouble("Itbis_Costo", item));
                    objExcel.SetCellValue("R" + lineaNo.ToString(), objUtil.GetAsDouble("Itbis_Por_Adelantar", item));
                    objExcel.SetCellValue("S" + lineaNo.ToString(), objUtil.GetAsDouble("Itbis_Percivido", item));
                    objExcel.SetCellValue("T" + lineaNo.ToString(), objUtil.GetAsString("Tipo_Retencion_Descripcion", item));
                    objExcel.SetCellValue("U" + lineaNo.ToString(), objUtil.GetAsDouble("Renta_Retenida", item));
                    objExcel.SetCellValue("V" + lineaNo.ToString(), objUtil.GetAsDouble("ISR_Percivido", item));
                    objExcel.SetCellValue("W" + lineaNo.ToString(), objUtil.GetAsDouble("Impuesto_Selectivo_Consumo", item));
                    objExcel.SetCellValue("X" + lineaNo.ToString(), objUtil.GetAsDouble("Otros_Impuestos", item));
                    objExcel.SetCellValue("Y" + lineaNo.ToString(), objUtil.GetAsDouble("Propina_Legal", item));
                    objExcel.SetCellValue("Z" + lineaNo.ToString(), objUtil.GetAsString("Forma_Pago_Descripcion", item));

                    
                    tsProgressBar.PerformStep();

                    lineaNo++;

                    Cursor = Cursors.Default;
                }

                objExcel.ShowBook();
            }
            catch (Exception ex)
            {
                if(objExcel != null)  objExcel.CloseBook();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
               
                objExcel = null;
                Cursor = Cursors.Default;
            }

        }
    }
}
