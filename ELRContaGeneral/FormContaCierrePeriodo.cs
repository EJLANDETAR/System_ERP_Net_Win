using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRContaGeneral
{
    public partial class FormContaCierrePeriodo : WinControl_ELR_NET.ELRFormRegistro
    {
        
        public FormContaCierrePeriodo()
        {
            InitializeComponent();
        }

        private void FormContaCierrePeriodo_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            dtpFechaCierre.Value = DateTime.Now.Date.AddDays(-1);

        }

        public override bool GetData()
        {
            //return base.GetData();
            temporalID = objUtil.GetTemporalID();

            DataTable DTCatalogo = null;
            object calcObject;
            string estatus = "DESACTUALIZADO; NO DATA";
            double diferencia = 0;

            try
            {
                btnGrabar.Enabled = false;
                lblEstatus.Text = estatus;
                btnPreCierre.Enabled = false;
                temporalID = objUtil.GetTemporalID();

                objDB.LimpiarFiltros();
                objDB.AddFiltroPersonalizado(" Len(Cuenta_Contable) = 1 ");
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTCatalogo = objDB.GetAll("TCONTA_CATALOGO", -1, objDB.Filtros);

                //VAMOS A BUSCAR LA DIFERENCIA SI EXISTEN
                calcObject = DTCatalogo.Compute("Sum(Saldo_Actual)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") diferencia = double.Parse(calcObject.ToString());
                }

                lblTotal.Text = "Total Debito:  0.00               Total Credito: 0.00               Diferencia: " + diferencia.ToString("N2");

                //MOSTRAMOS EL ESTATUS DEL CATALOGO Y HASTA QUE FECHA ESTA POSTEADO
                if(DTCatalogo.Rows.Count > 0)
                {
                    estatus = objUtil.GetAsString("Estatus", DTCatalogo.Rows[0], "DESACTUALIZAO; NO POSTEADO");

                    lblEstatus.Text = estatus + " A FECHA:";

                    if (DTCatalogo.Rows[0]["Fecha_Actualizado"] is DBNull) lblFechaActualizado.Text = "00/00/0000";
                    else
                    {
                        DateTime fecha = objUtil.GetAsDate("Fecha_Actualizado", DTCatalogo.Rows[0]);
                        lblFechaActualizado.Text = objUtil.GetDateAsString(fecha) + "(" + fecha.ToLongDateString() + ")";
                    }
                }

                if (estatus.ToUpper().Contains("DESACTUALIZADO")) lblEstatus.ForeColor = Color.Red;
                else lblEstatus.ForeColor = Color.Green;

                btnPreCierre.Enabled = (diferencia == 0 && DTCatalogo.Rows.Count > 0);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return true;
        }

        void ImprimirCatalogo()
        {
            DataTable DTCatalogo = null;
            string pathReporte = "";
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();

            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroPersonalizado("(Saldo_Actual <> 0 Or Saldo_Mes_Anterior <> 0 Or Debito_Mes <> 0 Or Credito_Mes <> 0)");
                objDB.AddFiltroOrderBY("Cuenta_Contable, Codigo_Auxiliar");

                DTCatalogo = objDB.GetAll("VCONTA_CATALOGO", -1, objDB.Filtros);

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

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataDB_ELR_NET.Parametro> myParams = new List<DataDB_ELR_NET.Parametro>();
            int resultado = 0;
            double totalDebito = 0, totalCredito = 0, diferencia = 0;
            int fechaCierre = 0, fechaActual = 0;
            try
            {
                fechaActual = objUtil.DateToInt(DateTime.Now.Date);
                fechaCierre = objUtil.DateToInt(dtpFechaCierre.Value);
                btnGrabar.Enabled = false;

               

                Cursor = Cursors.WaitCursor;
                
                lblTotal.Text = "Total Debito:  0.00               Total Credito: 0.00               Diferencia: 0.00";
                btnGrabar.Enabled = false;
                Refresh();

                //Procedemos a Generar los datos del Cierre
                dtgCierre.DataSource = null;
                myParams.Add(new DataDB_ELR_NET.Parametro("fecha", fechaCierre));
                myParams.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                myParams.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                myParams.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                objDB.iniciarTransaccion();
                resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_TEMPORAL_CIERRE", myParams);
                if (resultado < 0) MostrarErrorTemporal();
                else
                {
                    objDB.confirmarTransaccion();
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                    DTDetalle = objDB.GetAll("TTEMPORAL_CONTA_CIERRE_PERIODO", -1, objDB.Filtros);

                    dtgCierre.AutoGenerateColumns = false;
                    dtgCierre.DataSource = DTDetalle.DefaultView;

                    totalDebito = GetSum("Debito", DTDetalle);
                    totalCredito = GetSum("Credito", DTDetalle);
                    diferencia = (totalDebito - totalCredito);

                    lblTotal.Text = "Total Debito:  " + totalDebito.ToString("N2") +
                                    "               Total Credito: " + totalCredito.ToString("N2") +
                                    "               Diferencia: " + diferencia.ToString("N2");

                    btnGrabar.Enabled = (diferencia == 0 && DTDetalle.Rows.Count  > 0);
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                objDB.cancelarTransaccion();
            }
        }

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            DialogResult resp;
            int resultado = -1;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                //Procedemos a Realizar el Cierre del Periodo
                Cursor = Cursors.WaitCursor;

                resp = objUtil.MostrarMensajePregunta("ESTA SEGURO DE REALIZAR EL CIERRE?");
                if (resp == DialogResult.Yes)
                {
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_CONTA_GRABA_CIERRE_PERIODO", parms);

                    if (resultado < 0) MostrarErrorTemporal();
                    else
                    {
                        objDB.confirmarTransaccion();
                        objUtil.MostrarMensajeInformacion("PROCESO DE CIERRE REALIZADO DE FORMA SATISFACTORIA, ASIENTO ID: " + resultado.ToString());

                        ImprimirCatalogo();
                        
                    }
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

            return resultado;
        }

        private void btnImprimirCatalogo_Click(object sender, EventArgs e)
        {
            ImprimirCatalogo();
        }

    }
}
