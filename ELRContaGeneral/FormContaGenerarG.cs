using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRContaGeneral
{
    public partial class FormContaGenerarG : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTCatalogo = null, DTFecha = null;

        public FormContaGenerarG()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            //return base.GetData();
            DateTime fecha = DateTime.Now.Date;
            
            object calcObject;
            string estatus = "DESACTUALIZADO; NO DATA";
            double diferencia = 0;

            try
            {
                lblTotal.BackColor = Color.Red;
                lblTotal.ForeColor = Color.White;

                Cursor = Cursors.WaitCursor;
                lblEstatus.Text = estatus;
                fecha = fecha.AddDays(-1);
                //Buscamos la fecha del ultimo cierre
                objDB.LimpiarFiltros();
                objDB.AddFiltroIsNoNull("Fecha_Cierre");
                objDB.AddFiltroOrderBY("Fecha Desc");
                DTFecha = objDB.GetAll("TSISTEMA_PROCESOS_CONTROL", 1, objDB.Filtros);
                if (DTFecha.Rows.Count > 0) fecha = objDB.GetAsDate("Fecha", DTFecha.Rows[0]);
                dtpFechaCierre.Value = fecha;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroPersonalizado("(Saldo_Actual <> 0 Or Saldo_Mes_Anterior <> 0 Or Debito_Mes <> 0 Or Credito_Mes <> 0)");
                objDB.AddFiltroOrderBY("Cuenta_Contable, Codigo_Auxiliar");

                DTCatalogo = objDB.GetAll("VCONTA_CATALOGO", -1, objDB.Filtros);
                DataGridDetalle.AutoGenerateColumns = false;
                DataGridDetalle.DataSource = DTCatalogo.DefaultView;
                //VAMOS A BUSCAR LA DIFERENCIA SI EXISTEN
                calcObject = DTCatalogo.Compute("Sum(Saldo_Actual)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") diferencia = double.Parse(calcObject.ToString());
                }

                lblTotal.Text = "Diferencia: " + diferencia.ToString("N2") + "   ";

                //MOSTRAMOS EL ESTATUS DEL CATALOGO Y HASTA QUE FECHA ESTA POSTEADO
                if (DTCatalogo.Rows.Count > 0)
                {
                    estatus = objUtil.GetAsString("Estatus", DTCatalogo.Rows[0], "DESACTUALIZAO; NO POSTEADO");

                    lblEstatus.Text = estatus + " A FECHA:";

                    if (DTCatalogo.Rows[0]["Fecha_Actualizado"] is DBNull) lblFechaActualizado.Text = "00/00/0000";
                    else
                    {
                        fecha = objUtil.GetAsDate("Fecha_Actualizado", DTCatalogo.Rows[0]);
                        lblFechaActualizado.Text = objUtil.GetDateAsString(fecha) + "(" + fecha.ToLongDateString() + ")";
                    }
                }

                if (estatus.ToUpper().Contains("DESACTUALIZADO")) lblEstatus.ForeColor = Color.Red;
                else lblEstatus.ForeColor = Color.Green;

                if(diferencia == 0)
                {
                    lblTotal.BackColor = SystemColors.Control;
                    lblTotal.ForeColor = SystemColors.ControlText;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            return true;
        }

        void ImprimirCatalogo()
        {
            string pathReporte = "";
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();
            try
            {
                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptContaCatalogo");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = DTCatalogo;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "Catalogo de Cuentas";
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

        public override int GrabarDatos()
        {
            int result = 0;
            DialogResult resp;
            DateTime fecha;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                //return base.GrabarDatos();
                resp = objUtil.MostrarMensajePregunta("Esta seguro que desea generar la contabilidad?");
                if (resp != DialogResult.Yes) return 0;

                Cursor = Cursors.WaitCursor;
                fecha = dtpFechaCierre.Value;
                temporalID = objUtil.GetTemporalID();
                parms.Add(new DataDB_ELR_NET.Parametro("Fecha", objUtil.DateToInt(fecha)));
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                objDB.iniciarTransaccion();
                result = objDB.EjecutarSP("SP_CONTA_GENERAR_CONTABILIDAD_ALL", parms);
                if(result > 0)
                {
                    objDB.confirmarTransaccion();
                    objUtil.MostrarMensajeInformacion("Proceso realizado de forma satisfactoria");
                    GetData();
                }
                else
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }

            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            return result;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void FormContaGenerarG_Load(object sender, EventArgs e)
        {
            try
            {
                FormatearGridDetalle();

                addButtonAMenuLateral("ELRContaGeneral.FormContaConfigurarCuentas"); 
                addButtonAMenuLateral("ELRContaGeneral.FormContaCatalogoEdit");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCentroCostos");
                addButtonAMenuLateral("ELRBanco.FormBancosCheques", "Digitar cheques");
                addButtonAMenuLateral("ELRBanco.FormImprimirCheques");
                addButtonAMenuLateral("ELRContaGeneral.FormContaMovimientosAnular");
                addButtonAMenuLateral("ELRContaGeneral.FormContaMovimientosContrapartidas");
                addButtonAMenuLateral("ELRContaGeneral.FormContaGenerarAsientos");
                addButtonAMenuLateral("ELRContaGeneral.FormContaEstadosAGenerar");

                addButtonAMenuLateral("ELRContaGeneral.FormContaPaseAlMayor");
                addButtonAMenuLateral("ELRContaGeneral.FormContaPaseRevertir");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCierreDiarioMensual");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCierrePeriodo");

                addButtonAMenuLateral("ELRContaGeneral.FormContaMovimientosPorCuenta");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCatalogoACierre");
                addButtonAMenuLateral("ELRContaGeneral.FormContaSaldoCuentaPorSucursal");
                addButtonAMenuLateral("ELRContaGeneral.FormContaConsultaCierre");
                addButtonAMenuLateral("ELRContaGeneral.FormContaEstadosGenerados");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII606");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII607");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII608");

                dtpFechaCierre.Value = DateTime.Now.AddDays(-1);
                dtpFechaCierre.Enabled = false;
                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FormExportToExcel frmExcel = new FormExportToExcel();
            try
            {
                frmExcel.titulo = "CATALOGO DE CUENTAS, POSTEADO A FECHA: " + lblFechaActualizado.Text;
                frmExcel.DTData = DTCatalogo;
                frmExcel.colList = GetColList();
                frmExcel.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmExcel.Dispose();
            }
        }

        private void btnImprimirCatalogo_Click(object sender, EventArgs e)
        {
            ImprimirCatalogo();
        }
    }
}
