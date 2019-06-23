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
    public partial class FormContaPaseRevertir : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormContaPaseRevertir()
        {
            InitializeComponent();
        }

        private void btnDesactualizar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string fechaDesde, fechaHasta;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            ELRFormMensajeErrores frmMsgERRORES = new ELRFormMensajeErrores();

            int resultado = -1;

            try
            {
                resp = objUtil.MostrarMensajePregunta("Esta Seguro que Desea DesActualizar el Catalogo?");

                if (resp == DialogResult.Yes)
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
                    resultado = objDB.EjecutarSP("SP_CONTA_DESACTUALIZAR_CATALOGO", parametros);

                    if (resultado > 0)
                    {
                        objDB.confirmarTransaccion();
                        GetCatalogoBalance();
                        objUtil.MostrarMensajeInformacion("DESACTUALIZACION DE CATALOGO, Realizado de Forma Satisfactoria ...");
                    }

                    if (resultado < 0)
                    {
                        frmMsgERRORES.TemporalId = temporalID;
                        frmMsgERRORES.objDB = objDB;

                        frmMsgERRORES.ShowDialog();
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
                frmMsgERRORES.Dispose();
            }

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
                btnDesactualizar.Enabled = false;

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

                btnDesactualizar.Enabled = (DTCatalogo.Rows.Count > 0);
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

        private void FormContaPaseRevertir_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.Date;
            dtpFechaHasta.Value = DateTime.Now.Date;

            btnGrabar.Visible = false;
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
