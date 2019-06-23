using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormComprasAprobarAnularR : WinControl_ELR_NET.ELRFormRegistro
    {
        public string modulo = "";
        public int Id = 0;

        bool esAprobada = false;

        public FormComprasAprobarAnularR()
        {
            InitializeComponent();
        }

        private void FormComprasAprobarAnularR_Load(object sender, EventArgs e)
        {

            this.rpvReporte.RefreshReport();
            btnSiguientePage.Visible = true;
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataTable DTData = null;
            string pathReporte = "";
            DataRow fila0;
            //return base.GetData();
            try
            {
                rpvReporte.ShowPrintButton = esAprobada;
                
                //Buscamos el Encabezado
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("CXP_Id", Id.ToString());
                if (modulo == "REQ")
                {
                    DTData = objDB.GetAll("VCOMPRAS_REQUISICIONES", 1, objDB.Filtros);
                    pathReporte = objUtil.GetPathReportRDLC("RptCompra_Requisicion");
                }
                else if (modulo == "ORD")
                {
                    DTData = objDB.GetAll("TCXP", 1, objDB.Filtros);
                    pathReporte = objUtil.GetPathReportRDLC("RptCompra_Orden");
                }

                fila0 = DTData.Rows[0];
                esAprobada = !(fila0["Fecha_Aprobado"] is DBNull); 

                //Buscamos el Detalle
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Identificador_Id", Id.ToString());
                DTDetalle = objDB.GetAll("TCXP_DETALLES", -1, objDB.Filtros);

                //Agregamos los Datasorce para el Reporte
                if (MyParametrosDS != null) MyParametrosDS.Clear();
                else MyParametrosDS = new List<WinControl_ELR_NET.ReportesDS>();

                MyParametrosDS.Add(new WinControl_ELR_NET.ReportesDS("DSData", DTData));
                MyParametrosDS.Add(new WinControl_ELR_NET.ReportesDS("DSDetalle", DTDetalle));

                ShowReport(pathReporte);
                rpvReporte.ShowPrintButton = esAprobada;
                btnGrabar.Enabled = !esAprobada;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Button btn;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string accion = "A";
            int spReturn = 0;
            DialogResult resp;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                btn = (Button)sender;
                if (btn != btnGrabar) accion = "R";

                if (accion == "A") resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Aprobar?");
                else resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Rechazar?");

                if(resp != DialogResult.Yes)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                temporalID = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parms.Add(new DataDB_ELR_NET.Parametro("Id", Id));
                parms.Add(new DataDB_ELR_NET.Parametro("Accion", accion));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_COMPRAS_APROBAR_RECHAZAR", parms);
                if (spReturn < 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    esAprobada = (accion == "A");
                    rpvReporte.ShowPrintButton = esAprobada;

                    if (esAprobada) objUtil.MostrarMensajeInformacion("APROBACION REALIZADA DE FORMA SATISFACTORIA");
                    else objUtil.MostrarMensajeInformacion("RECHAZO REALIZADO DE FORMA SATISFACTORIA");

                    GetData();
                    lOK = true;
                   
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

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            return 1;
        }

        public override void IrAPageSiguiente()
        {
            //base.IrAPageSiguiente();
        }
    }
}
