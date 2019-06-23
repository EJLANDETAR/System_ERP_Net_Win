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
    public partial class FormContaPaseAlMayor : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormContaPaseAlMayor()
        {
            InitializeComponent();
        }

        void GetCatalogoBalance()
        {
            DataTable DTCatalogo = null;
            double diferencia = 0;
            object calcObject;
            string estatus = "DESACTUALIZADO; NO DATA";

            try
            {
                lblEstatus.Text = estatus;
                btnRealizarPase.Enabled = false;

                objDB.LimpiarFiltros();
                objDB.AddFiltroPersonalizado(" Len(Cuenta_Contable) = 1 ");
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTCatalogo = objDB.GetAll("TCONTA_CATALOGO", -1, objDB.Filtros);

                dtgCatalogoBalance.AutoGenerateColumns = false;
                dtgCatalogoBalance.DataSource = DTCatalogo.DefaultView;

                //VAMOS A BUSCAR LA DIFERENCIA SI EXISTEN
                calcObject = DTCatalogo.Compute("Sum(Saldo_Actual)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") diferencia = double.Parse(calcObject.ToString());
                }

                lblDiferencia.Text = "Diferencia: " + diferencia.ToString("N2");

                if (DTCatalogo.Rows.Count > 0)
                {
                    //MOSTRAMOS EL ESTATUS DEL CATALOGO Y HASTA QUE FECHA ESTA POSTEADO
                    estatus = objUtil.GetAsString("Estatus", DTCatalogo.Rows[0], "DESACTUALIZADO; NO POSTEADO");

                    lblEstatus.Text = estatus + " A FECHA:";

                    if (DTCatalogo.Rows[0]["Fecha_Actualizado"] is DBNull) lblFechaActualizado.Text = "00/00/0000";
                    else
                    {
                        DateTime fecha = objUtil.GetAsDate("Fecha_Actualizado", DTCatalogo.Rows[0]);
                        lblFechaActualizado.Text = objUtil.GetDateAsString(fecha) + "(" + fecha.ToLongDateString() + ")";
                    }
                }

                btnRealizarPase.Enabled = (DTCatalogo.Rows.Count > 0);
                if (estatus.ToUpper().Contains("DESACTUALIZADO")) lblEstatus.ForeColor = Color.Red;
                else lblEstatus.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            bool resultado = true;
            try
            {
                //return base.GetData();
                GetCatalogoBalance();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void FormContaPaseAlMayor_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = objUtil.getPrimeraFechaMes(DateTime.Now.Date);
            dtpFechaHasta.Value = DateTime.Now.Date;

            btnGrabar.Visible = false;
        }

        private void btnRealizarPase_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string fechaDesde, fechaHasta;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            ELRFormMensajeErrores frmMsgERRORES = new ELRFormMensajeErrores();

            int resultado = -1;

            try
            {
                
                this.Cursor = Cursors.WaitCursor;
                fechaDesde = objDB.DateToInt(dtpFechaDesde.Value).ToString();
                fechaHasta = objDB.DateToInt(dtpFechaHasta.Value).ToString();
                temporalID = objUtil.GetTemporalID();

                parametros.Add(new DataDB_ELR_NET.Parametro("pFechaDesde", fechaDesde));
                parametros.Add(new DataDB_ELR_NET.Parametro("pFechaHasta", fechaHasta));
                parametros.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID.ToString()));
                parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                //EJECUTAMOS EL SP DENTRO DE UNA TRANSACCION
                objDB.iniciarTransaccion();
                resultado = objDB.EjecutarSP("SP_CONTA_ACTUALIZAR_CATALOGO", parametros);

                if (resultado > 0)
                {
                    objDB.confirmarTransaccion();
                    GetCatalogoBalance();
                    objUtil.MostrarMensajeInformacion("ACTUALIZACION\\POSTEO DE ASIENTOS, REALIZADO DE FORMA SATISFACTORIA");

                    if (chkGenerarEstados.Checked) GenerarEstadosFinancieros();
                }

                if (resultado < 0)
                {
                    frmMsgERRORES.TemporalId = temporalID;
                    frmMsgERRORES.objDB = objDB;

                    frmMsgERRORES.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmMsgERRORES.Dispose();
            }
        }

        void GenerarEstadosFinancieros()
        {
            DataTable DTEstados = null;
            int resultado = 0;
            bool esAplicar = false;
            bool esConAnexo = false;
            int estadoId = 0;
            List<DataDB_ELR_NET.Parametro> myParm = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                DTEstados = objDB.GetAll("TCONTA_ESTADOS");

                temporalID = objUtil.GetTemporalID();

                foreach (DataRow fila in DTEstados.Rows)
                {
                    estadoId = objUtil.GetAsInt("Estado_Id", fila);
                    esConAnexo = objUtil.GetAsBoolean("EsConAnexo", fila);

                    this.Cursor = Cursors.WaitCursor;

                    //Procedemos a Generar Estados
                    myParm = new List<DataDB_ELR_NET.Parametro>();
                    myParm.Add(new DataDB_ELR_NET.Parametro("estadoId", estadoId));
                    myParm.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    myParm.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalID));

                    //Generamos el Acumulado
                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_ACUMULADO", myParm);
                    if ((esConAnexo) && (resultado > 0))
                    {
                        //Generamos Anexos Acumulados
                        myParm.Add(new DataDB_ELR_NET.Parametro("reporteId", resultado));
                        resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_ACUMULADO_ANEXOS", myParm);
                    }

                    if (resultado < 0)
                    {
                        objDB.cancelarTransaccion();
                        break;
                    }
                    else objDB.confirmarTransaccion();


                    //Generamos el Mensual
                    myParm = new List<DataDB_ELR_NET.Parametro>();
                    myParm.Add(new DataDB_ELR_NET.Parametro("estadoId", estadoId));
                    myParm.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    myParm.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalID));

                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_MENSUAL", myParm);
                    if ((esConAnexo) && (resultado > 0))
                    {
                        //Generamos Anexos Acumulados
                        myParm.Add(new DataDB_ELR_NET.Parametro("reporteId", resultado));
                        resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_MENSUAL_ANEXOS", myParm);
                    }

                    if (resultado < 0)
                    {
                        objDB.cancelarTransaccion();
                        break;
                    }
                    else objDB.confirmarTransaccion();

                    this.Cursor = Cursors.Default;

                }

                this.Cursor = Cursors.Default;

                if (resultado > 0)
                {

                    objUtil.MostrarMensajeInformacion("Estados Generados de Forma Satisfactoria...");
                    FormContaEstadosGenerados frm = new FormContaEstadosGenerados();
                    frm.nombreUsuario = nombreUsuario;
                    frm.oficinaID = OFICINA_ID;
                    frm.empresaID = EMPRESA_ID;
                    frm.EsAgregar = false;
                    frm.FiltroEstatico = "Anio = " + dtpFechaHasta.Value.Year.ToString() + " And Mes = " + dtpFechaHasta.Value.Month.ToString();
                    frm.EnEjecusion = true;
                    frm.ShowDialog();

                    frm.Dispose();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
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

        private void btnImprimirCatalogo_Click(object sender, EventArgs e)
        {
            ImprimirCatalogo();
        }
    }
}
