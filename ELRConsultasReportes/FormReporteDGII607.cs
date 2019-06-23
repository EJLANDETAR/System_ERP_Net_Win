using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinControl_ELR_NET;

namespace ELRConsultasReportes
{
    public partial class FormReporteDGII607 : WinControl_ELR_NET.FormPlantillaIndex
    {
        string temporalId = "";
        int conteo = 0;
        int nErrores = 0;
        double totalItbis = 0, totalMonto = 0, totalFacturado = 0;
        DataTable DTRFC = null;

        public FormReporteDGII607()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            //base.GetData(opcion);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarData607();
        }

        private void FormReporteDGII607_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (temporalId != "") objDB.LimpiarTemporal("TTEMPORAL_DGII_607", "", temporalId);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void FormReporteDGII607_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date.AddMonths(-1);
            tsbExcel.Enabled = false;
            tsbTXT.Enabled = false;
            dtpFecha1.Value = objUtil.getPrimeraFechaMes(fecha);
            dtpFecha2.Value = objUtil.getUltimaFechaMes(fecha);
            btnResumenFC.Enabled = false;
            tsbBusquedaAvanzada.Enabled = false;
            tsmFilasAMostrar.Enabled = false;
            tsmFilasAMostrar.Visible = false;

            MostrarCantidadFilas();

        }

        void GenerarData607()
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            int fechaDesde = 0;
            int fechaHasta = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                btnResumenFC.Enabled = false;
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
                spReturn = objDB.EjecutarSP("SP_DGII_GENERAR_607", parms);

                if (spReturn < 0) MostrarErrorTemporal(temporalId);
                else
                {
                    objDB.confirmarTransaccion();

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalId);

                    //Buscamos el resumen de factura de consumo
                    DTRFC = objDB.GetAll("TTEMPORAL_DGII_607_RESUMEN_FC", -1, objDB.Filtros);

                    objDB.AddFiltroOrderBY("Fecha_Comprobante, Unico, Tipo");

                    MyData = objDB.GetAll("TTEMPORAL_DGII_607", -1, objDB.Filtros);
                    dtg607.AutoGenerateColumns = false;
                    dtg607.DataSource = MyData.DefaultView;

                    conteo = MyData.Rows.Count;
                    totalItbis = GetSum("Itbis");
                    totalMonto = GetSum("Monto");
                    nErrores = GetCount("Unico", "Estatus <> ''");

                    btnResumenFC.Enabled = true;
                    tsbExcel.Enabled = (conteo > 0);
                    tsbTXT.Enabled = (conteo > 0 && nErrores == 0); // && nErrores == 0);

                    if (nErrores > 0) tsbTXT.ToolTipText = "No es Posible Generar Archivo de Texto, Existen " + nErrores.ToString() + " Errores";
                    else tsbTXT.ToolTipText = "Generar Archivo de Texto";
                }

                totalFacturado = totalItbis + totalMonto;
                lblConteo.Text = "Cantidad Registro: " + conteo.ToString();
                lblTotal.Text = "Valor Calculado: " + totalMonto.ToString("N2") +
                                "        ITBIS Calculado: " + totalItbis.ToString("N2");

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

        private void mostrarRFC()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DateTime fecha = DateTime.Now.Date;
            
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptDGII607_RFC");

                frm.pathReporte = pathReporte;
                frm.DTData = DTRFC;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "607 - RESUMEN FACTURA DE CONSUMO, FECHAS: [";
                frm.titulo += objUtil.GetDateAsString(dtpFecha1.Value) + " - ";
                frm.titulo += objUtil.GetDateAsString(dtpFecha2.Value) + "]";

                frm.ShowDialog();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frm.Dispose();
            }
        }

        public override void GenerarTXT()
        {
            DataRow fila0;
            string pathFile = "";
            string encabezado = "607";
            string detalle = "";
            string rnc = "", periodo = "";
            string cedulaRNC = "", tipoId = "", ncf = "", ncfModificado = "", feComprobante = "";
            DateTime fecha = DateTime.Now;
            string sItbis = "", sMonto = "";
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
                pathFile += @"\DGII_F_607_" + rnc + "_" + periodo + ".txt";

                //FORMAMOS EL ENCABEZADO
                encabezado += rnc.PadRight(11, ' ');
                encabezado += periodo;
                encabezado += conteo.ToString().PadLeft(12, '0');
                encabezado += totalMonto.ToString("N2").Replace(",", "").PadLeft(16, '0');

                System.IO.StreamWriter sw = new System.IO.StreamWriter(pathFile);

                sw.WriteLine(encabezado);

                //AGREGAMOS LINEA DETALLE
                tsProgressBar.Visible = true;
                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    cedulaRNC = objUtil.GetAsString("CedulaRNC", item).Replace("-", "").Trim();
                    tipoId = objUtil.GetAsString("Tipo_Identificacion", item).Trim();
                    ncf = objUtil.GetAsString("NCF", item).Trim();
                    ncfModificado = objUtil.GetAsString("NCF_Modificado", item).Trim();
                    fecha = objUtil.GetAsDate("Fecha_Comprobante", item);
                    feComprobante = objUtil.DateToInt(fecha).ToString().Trim();

                    sItbis = objUtil.GetAsDouble("Itbis", item).ToString("N2").Replace(",", "").Trim();
                    sMonto = objUtil.GetAsDouble("Monto", item).ToString("N2").Replace(",", "").Trim();

                    detalle = cedulaRNC.PadRight(11, ' ');
                    detalle += tipoId;
                    detalle += ncf.PadRight(19, ' ');
                    detalle += ncfModificado.PadRight(19, ' ');
                    detalle += feComprobante;
                    detalle += sItbis.PadLeft(12, '0');
                    detalle += sMonto.PadLeft(12, '0');

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

        private void dtg607_SelectionChanged(object sender, EventArgs e)
        {
            string _estatus = "";
            string valor = "";
            int index = 0;
            try
            {
                txtEstatus.Text = "";
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                if (dtg607.RowCount > 0)
                {
                    index = dtg607.CurrentRow.Index;
                    valor = dtg607["Estatus", index].Value.ToString();
                    if (valor.Trim() != "") _estatus = "Fila No: " + (index + 1).ToString() + ", " + valor;
                }

                txtEstatus.Text = _estatus;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnResumenFC_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (DTRFC != null) mostrarRFC();
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
            string feComprobante = "";
            double itbis = 0, monto = 0;
            int lineaNo = 12;


            OfficeDriver.ExcelDriver objExcel = null;

            try
            {
                if (MyData == null) return;

                if (!objUtil.IsMSExcelIntalled()) throw new Exception("MICROSOFT EXCEL NO ESTA INSTALADO...");

                Cursor = Cursors.WaitCursor;
                objExcel = new OfficeDriver.ExcelDriver();
                objExcel.isOpenOffice = false;

                //CREAMOS Directorio para Ubicar Archivos

                //Buscamos la Plantilla de excel
                pathPlantilla = System.Environment.CurrentDirectory + @"\Files\plantilla607.xls";
                if (!File.Exists(pathPlantilla)) pathPlantilla = GetFolderDocGenerados("DGII") + @"\plantilla607.xls";

                if (File.Exists(pathPlantilla))
                {
                    pathFile = GetFolderDocGenerados("DGII") + @"\temp_plantilla607.xls";
                    if (File.Exists(pathFile)) File.Delete(pathFile);

                    File.Copy(pathPlantilla, pathFile);
                }
                else
                {
                    objUtil.MostrarMensajeError("NO EXISTE PALNTILLA607.xls");
                    Cursor = Cursors.Default;
                    return;
                }

                tsProgressBar.Value = 0;
                tsProgressBar.Maximum = MyData.Rows.Count + 1;
                tsProgressBar.Width = 350;
                tsProgressBar.Step = 1;
                tsProgressBar.Visible = true;

                fila0 = MyData.Rows[0];
                cedulaRNC = objUtil.GetAsString("EmpresaRNC", fila0).Replace("-", "").Trim();
                periodo = objUtil.GetAsString("Periodo", fila0).Trim();

                //ABRIMOS EL ARCHIVO
                objExcel.OpenWorkBook(pathFile);

                objExcel.SetCellValue("C4", cedulaRNC);
                objExcel.SetCellValue("C5", periodo);
                objExcel.SetCellValue("C6", conteo);
                //objExcel.SetCellValue("C7", totalMonto);

                tsProgressBar.PerformStep();

                //EJECUTAMOS LA MACRO
                objExcel.RunMacro("'Formato607.cmdDataEntry_Click'");

                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    cedulaRNC = objUtil.GetAsString("CedulaRNC", item).Replace("-", "").Trim();
                    tipoId = objUtil.GetAsString("Tipo_Identificacion", item).Trim();
                    ncf = objUtil.GetAsString("NCF", item).Trim();
                    ncfModificado = objUtil.GetAsString("NCF_Modificado", item).Trim();
                    fecha = objUtil.GetAsDate("Fecha_Comprobante", item);
                    feComprobante = objUtil.DateToInt(fecha).ToString().Trim();

                    itbis = objUtil.GetAsDouble("Itbis", item);
                    monto = objUtil.GetAsDouble("Monto", item);

                    objExcel.SetCellValue("B" + lineaNo.ToString(), cedulaRNC);
                    objExcel.SetCellValue("C" + lineaNo.ToString(), tipoId);
                    objExcel.SetCellValue("D" + lineaNo.ToString(), ncf);
                    objExcel.SetCellValue("E" + lineaNo.ToString(), ncfModificado);
                    objExcel.SetCellValue("F" + lineaNo.ToString(), objUtil.GetAsString("Tipo_Ingreso_DGII", item));
                    objExcel.SetCellValue("G" + lineaNo.ToString(), feComprobante);

                    if(item["Fecha_Retencion"] is DBNull) objExcel.SetCellValue("H" + lineaNo.ToString(), "");
                    else
                    {
                        fecha = objUtil.GetAsDate("Fecha_Retencion", item);
                        objExcel.SetCellValue("H" + lineaNo.ToString(), objUtil.DateToInt(fecha));
                    }
                    objExcel.SetCellValue("I" + lineaNo.ToString(), monto);
                    objExcel.SetCellValue("J" + lineaNo.ToString(), itbis);
                    objExcel.SetCellValue("K" + lineaNo.ToString(), objUtil.GetAsDouble("Itbis_Retenido", item));
                    objExcel.SetCellValue("L" + lineaNo.ToString(), objUtil.GetAsDouble("Itbis_Percibido", item));
                    objExcel.SetCellValue("M" + lineaNo.ToString(), objUtil.GetAsDouble("Retencion_Renta", item));
                    objExcel.SetCellValue("N" + lineaNo.ToString(), objUtil.GetAsDouble("ISR_Percibido", item));
                    objExcel.SetCellValue("O" + lineaNo.ToString(), objUtil.GetAsDouble("Impuesto_Selectivo_Consumo", item));
                    objExcel.SetCellValue("P" + lineaNo.ToString(), objUtil.GetAsDouble("Otros_Impuestos", item));
                    objExcel.SetCellValue("Q" + lineaNo.ToString(), objUtil.GetAsDouble("Propina_Legal", item));
                    objExcel.SetCellValue("R" + lineaNo.ToString(), objUtil.GetAsDouble("EnEfectivo", item));
                    objExcel.SetCellValue("S" + lineaNo.ToString(), objUtil.GetAsDouble("EnChequesODep", item));
                    objExcel.SetCellValue("T" + lineaNo.ToString(), objUtil.GetAsDouble("EnTarjeta", item));
                    objExcel.SetCellValue("U" + lineaNo.ToString(), objUtil.GetAsDouble("EnVentaACredito", item));
                    objExcel.SetCellValue("V" + lineaNo.ToString(), objUtil.GetAsDouble("EnBonos", item));
                    objExcel.SetCellValue("W" + lineaNo.ToString(), objUtil.GetAsDouble("EnPermuta", item));
                    objExcel.SetCellValue("X" + lineaNo.ToString(), objUtil.GetAsDouble("EnOtros", item));

                    tsProgressBar.PerformStep();

                    lineaNo++;

                    Cursor = Cursors.Default;
                }

                objExcel.ShowBook();
            }
            catch (Exception ex)
            {
                if (objExcel != null) objExcel.CloseBook();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objExcel = null;
                Cursor = Cursors.Default;
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

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptDGIIReporte607");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.AddDS("DSResumen", DTRFC);
                    frmPreview.AddDS("DSData", DTRFC);
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "REPORTE 607";
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
                frmPreview.Dispose();
            }
        }
    }
}
