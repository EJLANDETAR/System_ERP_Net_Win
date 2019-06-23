using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormDashboardVentas : WinControl_ELR_NET.FormPlantillaIndex
    {
        string temporalId = "";

        public FormDashboardVentas()
        {
            InitializeComponent();
        }

        private void FormDashboardVentas_Load(object sender, EventArgs e)
        {
            int mes = 0, anio = 0;

            try
            {
                DateTime fecha = DateTime.Now.Date;
                dtpFecha2.Value = fecha;

                mes = fecha.Month;
                anio = fecha.Year;

                dtpFecha1.Value = new DateTime(anio, mes, 1);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                if(temporalId.Trim() == "") temporalId = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                parms.Add(new DataDB_ELR_NET.Parametro("fechaDesde", fechaDesde));
                parms.Add(new DataDB_ELR_NET.Parametro("fechaHasta", fechaHasta));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", empresaID));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_DASHBOARD_VENTAS", parms);
                if(spReturn <= 0)
                {
                    MostrarErrorTemporal(temporalId);
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    MyData = objDB.GetById("TTEMPORAL_DASHBOARD_VENTAS", temporalId, "IdentificadorTemp");
                    DataGridConsulta.AutoGenerateColumns = false;
                    DataGridConsulta.RowTemplate.Height = 33;
                    DataGridConsulta.DataSource = MyData.DefaultView;
                    MostrarCantidadFilas();

                    Imprimir();

                    objDB.LimpiarDetalleTemporal("TTEMPORAL_DASHBOARD_VENTAS", temporalId);
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
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptDashboardVentas");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "DASHBOARD(RESUMEN GRAFICO DE VENTAS), FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

    }
}
