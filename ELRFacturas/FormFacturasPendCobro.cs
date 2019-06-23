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

namespace ELRFacturas
{
    public partial class FormFacturasPendCobro : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTVistaData = null;

        public FormFacturasPendCobro()
        {
            InitializeComponent();
        }

        private void FormFacturasPendCobro_Load(object sender, EventArgs e)
        {
           
            try
            {
                dtpFecha1.Value = DateTime.Now.Date;
                dtpFecha2.Value = DateTime.Now.Date;

                RealizarBusquedaSencilla();

                Valida();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        public override void RealizarBusquedaSencilla()
        {
            //base.RealizarBusquedaSencilla();
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (txtABuscar.Text.Trim() != "") objDB.AddFiltroContengaA("Nombre", txtABuscar.Text.Trim());

                GetData();
                pnOpcionesBusqueda.Visible = false;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            double subTotal = 0, itbis = 0, total = 0;
            double aCredito = 0, aContado = 0;
            int conteo = 0;

            try
            {
                base.GetData(opcion);

                DataGridConsulta.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                DataGridConsulta.MultiSelect = false;

                subTotal = GetSum("Sub_Total");
                itbis = GetSum("Itbis");
                total = GetSum("Monto");
                aCredito = GetSum("Monto_ACredito");
                aContado = GetSum("Monto_AlContado");
                conteo = MyData.Rows.Count;

                lblCantidadRegistro.Text = "Cant. " + conteo.ToString() + "                Sub Total: " + subTotal.ToString("N2") + "        Itbis: " 
                                            + itbis.ToString("N2") + "        Total: " + total.ToString("N2");
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
                    e.RowIndex >= 0)
                {
                    Imprimir();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            

        }

        public override void Imprimir()
        {
            string valorUnico = "0", temporalId = "";
            int id = 0;
            DataRow fila0 = null;
            double monto = 0, aCredito = 0, aContado = 0;
            int diasCredito = 0;
            WinControl_ELR_NET.ELRFormDesglosePago frm = new WinControl_ELR_NET.ELRFormDesglosePago();
            List<DataDB_ELR_NET.Parametro> myParametros = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;

            bool esValido = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DataGridConsulta.RowCount > 0)
                {
                    if (!REQUIERE_CIERRE_OPERACIONES) esValido = true;
                    else if (cajaNo > 0) esValido = true;
                    else objUtil.MostrarMensajeAdvertencia("No tiene Caja Abierta");

                    if(esValido)
                    {
                        valorUnico = DataGridConsulta["unico", DataGridConsulta.CurrentRow.Index].Value.ToString();

                        //BUSCO LA FILA SELECCIONADA POS SU UNICO
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        id = objUtil.GetAsInt("Identificador_Id", fila0);
                        monto = objUtil.GetAsDouble("Monto", fila0);
                        diasCredito = objUtil.GetAsInt("Dias_Credito", fila0);

                        frm.monto = monto;
                        frm.PermiteCredito = (diasCredito > 0);
                        frm.DTVariablesSYS = DTVariablesSYS;

                        if (tasaCambioUS > 0) frm.montoUS = (monto / tasaCambioUS);

                        frm.ShowDialog();

                        if (frm.LOK)
                        {
                            this.Cursor = Cursors.WaitCursor;

                            aContado = frm.monto - frm.montoDeduda;
                            aCredito = frm.montoDeduda;
                            temporalId = objUtil.GetTemporalID();

                            myParametros.Add(new DataDB_ELR_NET.Parametro("Id", id));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("CajaNo", cajaNo));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));

                            myParametros.Add(new DataDB_ELR_NET.Parametro("EnEfectivo", frm.enEfectivo));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("EnCheques", frm.enCheques));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("EnTarjetas", frm.enTarjetas));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("ADevolver", frm.aDevolver));

                            myParametros.Add(new DataDB_ELR_NET.Parametro("AContado", aContado));
                            myParametros.Add(new DataDB_ELR_NET.Parametro("ACredito", aCredito));

                            //Procedemos a Ejecutar el Store Procedure
                            objDB.iniciarTransaccion();
                            spReturn = objDB.EjecutarSP("SP_VENTAS_GRABA_COBRO_FACTURA", myParametros);

                            if (spReturn <= 0)
                            {
                                //MOSTRAMOS ERRORES DEL SISTEMA
                                ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

                                objMsgERRORES.TemporalId = temporalId;
                                objMsgERRORES.objDB = objDB;

                                objMsgERRORES.ShowDialog();
                            }
                            else
                            {
                                //Procedemos a Imprimir la Factura
                                objDB.confirmarTransaccion();

                                objDB.LimpiarFiltros();
                                objDB.AddFiltroIgualA("Identificador_Id", id.ToString());
                                DTVistaData = objDB.GetAll("VVENTAS_DETALLE", -1, objDB.Filtros);

                                if(metodoImp <= 1) ImprimirTicket();
                                else if (metodoImp == 2) ImprimirEnMatricial();
                                else ImprimirPreviewRDLC();
                                                                
                                RealizarBusquedaSencilla();
                            }

                        }
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

        void ImprimirTicket()
        {
            ELRLogicaNegocio.Facturas lFactura = new ELRLogicaNegocio.Facturas();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lFactura.MyData = DTVistaData;
                lFactura.NombreImpresora = impresoraDefault;
                lFactura.numeroCopias = IMPRIME_TICKET_COPIA;

                //IMPRIMIMOS EL TICKET
                lFactura.ImprimirTicket();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                lFactura = null;
            }

        }

        void ImprimirEnMatricial()
        {
            ELRLogicaNegocio.Facturas lFactura = new ELRLogicaNegocio.Facturas();
            try
            {
                lFactura.MyData = DTVistaData;
                lFactura.NombreImpresora = impresoraDefault;

                //MANDAMOS a Imprimir en un Thread
                /* Thread tAux = new Thread(new ThreadStart(lFactura.ImprimirMatricial80));
                 tAux.Start();

                 while (!tAux.IsAlive) ; */


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void ImprimirEnOtroFormato()
        {
            string nombreArchivo = "";
            string logoEmpresa = "";
            Bitmap imgLogo;
            FastReport.Base frBase;
            int tipoNCF = 0;
            int diasCredito = 0;
            double montoACredito = 0;

            try
            {
                nombreArchivo = Environment.CurrentDirectory + @"\Reportes\factura.frx";

                tipoNCF = objUtil.GetAsInt("Tipo_NCF", DTVistaData.Rows[0]);
                diasCredito = objUtil.GetAsInt("Dias_Credito", DTVistaData.Rows[0]);
                montoACredito = objUtil.GetAsDouble("Monto_ACredito", DTVistaData.Rows[0]);

                using (FastReport.Report report = new FastReport.Report())
                {
                    report.Load(nombreArchivo);
                    report.RegisterData(DTVistaData, "VVENTAS_DETALLE");
                    report.RegisterData(DTOficina, "VEMPRESAS_OFICINAS");

                    //Vamos a asignar el logo
                    logoEmpresa = Environment.CurrentDirectory + @"\images\logo.png";
                    if (File.Exists(logoEmpresa))
                    {

                        imgLogo = (Bitmap)Image.FromFile(logoEmpresa);
                        FastReport.PictureObject ptLogo = report.FindObject("ptLogo") as FastReport.PictureObject;
                        ptLogo.Image = imgLogo;
                    }

                    if (tipoNCF <= 0)
                    {
                        frBase = report.FindObject("txtNCF");
                        if (frBase != null)
                        {
                            FastReport.TextObject txt = (frBase as FastReport.TextObject);
                            txt.Visible = false;
                        }
                    }

                    if ((diasCredito <= 0) || (montoACredito <= 0))
                    {
                        frBase = report.FindObject("txtFechaVence");
                        if (frBase != null)
                        {
                            FastReport.TextObject txt = (frBase as FastReport.TextObject);
                            txt.Visible = false;
                        }
                    }

                    report.PrintSettings.PrintMode = FastReport.PrintMode.Default;
                    report.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ImprimirPreviewRDLC()
        {
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();
            string pathReporte = "";

            try
            {
                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("rptFactura");
                if (pathReporte.Trim() != "")
                {
                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = DTVistaData;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "IMPRIMIR REPORTE";
                    frmPreview.pathReporte = pathReporte.Trim();
                    frmPreview.montoLetras = montoLetras;

                    frmPreview.ShowDialog();
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frmPreview.Dispose();
            }
        }

    }
}
