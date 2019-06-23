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
    public partial class FormReporteDGII608 : WinControl_ELR_NET.FormPlantillaIndex
    {
        int conteo = 0, nErrores = 0;
        string temporalId = "";

        public FormReporteDGII608()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarData608();
        }

        private void FormReporteDGII608_Load(object sender, EventArgs e)
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

        void GenerarData608()
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            int fechaDesde = 0;
            int fechaHasta = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                tsProgressBar.Visible = false;
                conteo = 0; nErrores = 0;
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
                spReturn = objDB.EjecutarSP("SP_DGII_GENERAR_608", parms);

                if (spReturn < 0) MostrarErrorTemporal(temporalId);
                else
                {
                    objDB.confirmarTransaccion();

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalId);
                    objDB.AddFiltroOrderBY("Fecha_Comprobante, Unico, Tipo");

                    MyData = objDB.GetAll("TTEMPORAL_DGII_608", -1, objDB.Filtros);
                    dtg608.AutoGenerateColumns = false;
                    dtg608.DataSource = MyData.DefaultView;

                    conteo = MyData.Rows.Count;
                    nErrores = GetCount("Unico", "Estatus <> ''");

                    tsbExcel.Enabled = (conteo > 0);
                    tsbTXT.Enabled = (conteo > 0 && nErrores == 0); // && nErrores == 0);

                    if (nErrores > 0) tsbTXT.ToolTipText = "No es Posible Generar Archivo de Texto, Existen " + nErrores.ToString() + " Errores";
                    else tsbTXT.ToolTipText = "Generar Archivo de Texto";
                }

                MostrarCantidadFilas();

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

        public override void GenerarTXT()
        {
            DataRow fila0;
            string pathFile ="";
            string encabezado = "608";
            string detalle = "";
            string rnc = "", periodo = "";
            string ncf = "", feComprobante = "";
            string tipoAnulacion = "";
            DateTime fecha = DateTime.Now;

            try
            {
                if (MyData == null) return;

                tsProgressBar.Value = 0;
                tsProgressBar.Maximum = MyData.Rows.Count;
                tsProgressBar.Width = 350;
                tsProgressBar.Step = 1;

                pathFile = GetFolderDocGenerados("DGII");

                fila0 = MyData.Rows[0];
                rnc = objUtil.GetAsString("EmpresaRNC", fila0);
                periodo = objUtil.GetAsString("Periodo", fila0);
                pathFile += @"\DGII_F_608_" + rnc + "_" + periodo + ".txt";

                //FORMAMOS EL ENCABEZADO
                encabezado += rnc.PadRight(11, ' ');
                encabezado += periodo;
                encabezado += conteo.ToString().PadLeft(6, '0');

                System.IO.StreamWriter sw = new System.IO.StreamWriter(pathFile);

                sw.WriteLine(encabezado);

                //AGREGAMOS LINEA DETALLE
                tsProgressBar.Visible = true;
                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;
                    ncf = objUtil.GetAsString("NCF", item);

                    tipoAnulacion = objUtil.GetAsString("Tipo_Anulacion", item);
                    
                    fecha = objUtil.GetAsDate("Fecha_Comprobante", item);
                    feComprobante = objUtil.DateToInt(fecha).ToString();

                    detalle = ncf.PadRight(19, ' ');
                    detalle += feComprobante;
                    detalle += tipoAnulacion.Substring(0, 2);

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

        private void FormReporteDGII608_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (temporalId != "") objDB.LimpiarTemporal("TTEMPORAL_DGII_608", "", temporalId);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public override void GenerarEXCEL(string titulo = "")
        {
            DataRow fila0;
            string pathFile = "";
            string pathPlantilla = "";
            string cedulaRNC = "";
            string periodo = "";
            string ncf = "";
            DateTime fecha = DateTime.Now;
            string feComprobante = "";
            string tipoAnulacion;
            int lineaNo = 12;


            OfficeDriver.ExcelDriver objExcel = new OfficeDriver.ExcelDriver();

            try
            {
                if (MyData == null) return;
                if (!objUtil.IsMSExcelIntalled()) throw new Exception("MICROSOFT EXCEL NO ESTA INSTALADO...");

                Cursor = Cursors.WaitCursor;
                objExcel.isOpenOffice = false;

                //Buscamos la Plantilla de excel
                pathPlantilla = System.Environment.CurrentDirectory + @"\Files\plantilla608.xls";
                if (!File.Exists(pathPlantilla)) pathPlantilla = GetFolderDocGenerados("DGII") + @"\plantilla608.xls";

                if (File.Exists(pathPlantilla))
                {
                    pathFile = GetFolderDocGenerados("DGII") + @"\temp_plantilla608.xls";
                    if (File.Exists(pathFile)) File.Delete(pathFile);

                    File.Copy(pathPlantilla, pathFile);
                }
                else
                {
                    objUtil.MostrarMensajeError("NO EXISTE PALNTILLA608.xls");
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

                objExcel.SetCellValue ("C5", cedulaRNC);
                objExcel.SetCellValue("C6", periodo);
                objExcel.SetCellValue("C7", conteo);


                tsProgressBar.PerformStep();

                //EJECUTAMOS LA MACRO
                objExcel.RunMacro("'Formato608.cmdDataEntry_Click'");

                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    ncf = objUtil.GetAsString("NCF", item);
                    fecha = objUtil.GetAsDate("Fecha_Comprobante", item);
                    feComprobante = objUtil.DateToInt(fecha).ToString();

                    tipoAnulacion = objUtil.GetAsString("Tipo_Anulacion", item);
                   
                    objExcel.SetCellValue("B" + lineaNo.ToString(), ncf);
                    objExcel.SetCellValue("D" + lineaNo.ToString(), feComprobante);
                    objExcel.SetCellValue("E" + lineaNo.ToString(), tipoAnulacion);
                    
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

        private void dtg608_SelectionChanged(object sender, EventArgs e)
        {
            string _estatus = "";
            string valor = "";
            int index = 0;
            try
            {
                if (dtg608.RowCount > 0)
                {
                    index = dtg608.CurrentRow.Index;
                    valor = dtg608["Estatus", index].Value.ToString();
                    if (valor.Trim() != "") _estatus = "Fila No: " + (index + 1).ToString() + ", " + valor;
                }

                txtEstatus.Text = _estatus;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void dtg608_SelectionChanged_1(object sender, EventArgs e)
        {
            string _estatus = "";
            string valor = "";
            int index = 0;
            try
            {
                txtEstatus.Text = "";
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                if (dtg608.RowCount > 0)
                {
                    index = dtg608.CurrentRow.Index;
                    valor = dtg608["Estatus", index].Value.ToString();
                    if (valor.Trim() != "") _estatus = "Fila No: " + (index + 1).ToString() + ", " + valor;
                }

                txtEstatus.Text = _estatus;
            }
            catch (Exception)
            {

                //throw;
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
                if (MyData.Rows.Count <= 0) return;

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptDGIIReporte608");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = MyData;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "REPORTE 608";
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
