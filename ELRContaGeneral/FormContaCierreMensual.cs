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
    public partial class FormContaCierreMensual : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormContaCierreMensual()
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
                btnCerrarMes.Enabled = false;

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

                btnCerrarMes.Enabled = (DTCatalogo.Rows.Count > 0 && diferencia == 0);
                if (estatus.ToUpper().Contains("DESACTUALIZADO")) lblEstatus.ForeColor = Color.Red;
                else lblEstatus.ForeColor = Color.Green;

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

        public override bool GetData()
        {
            bool resultado = true;
            int mes = 0;
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

        private void btnCerrarMes_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            int mes, anio;
            string nombreMes;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            int resultado = -1;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                mes = int.Parse(cboMes.SelectedValue.ToString());
                anio = int.Parse(txtAnio.Text.Trim());
                nombreMes = cboMes.Text.ToUpper();
                temporalID = objUtil.GetTemporalID();

                resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Realizar el Cierre?");

                if (resp == DialogResult.Yes)
                {
                    

                    parametros.Add(new DataDB_ELR_NET.Parametro("Mes", mes));
                    parametros.Add(new DataDB_ELR_NET.Parametro("NombreMes", nombreMes));
                    parametros.Add(new DataDB_ELR_NET.Parametro("Anio", anio));
                    parametros.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID.ToString()));
                    parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                    //EJECUTAMOS EL SP DENTRO DE UNA TRANSACCION
                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_CONTA_CERRAR_MES", parametros);

                    if (resultado > 0)
                    {
                        objDB.confirmarTransaccion();
                        GetCatalogoBalance();
                        objUtil.MostrarMensajeInformacion("CIERRE MENSUAL, Realizado de Forma Satisfactoria ...");
                        ImprimirCatalogo();
                    }
                    else MostrarErrorTemporal();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objDB.cancelarTransaccion();
                this.Cursor = Cursors.Default;
            }
        }

        private void FormContaCierreMensual_Load(object sender, EventArgs e)
        {
            int anio, mes;
            try
            {
                btnGrabar.Visible = false;

                cboMes.LlenarCombo();
                anio = DateTime.Now.Year;
                mes = DateTime.Now.Month - 1;

                if(mes== 0)
                {
                    anio--;
                    mes -= 1;
                }

                txtAnio.Text = anio.ToString();
                cboMes.SelectedValue = mes;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnImprimirCatalogo_Click(object sender, EventArgs e)
        {
            ImprimirCatalogo();
        }
    }
}
