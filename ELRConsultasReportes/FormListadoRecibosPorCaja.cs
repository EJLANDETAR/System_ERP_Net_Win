using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRConsultasReportes
{
    public partial class FormListadoRecibosPorCaja : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormListadoRecibosPorCaja()
        {
            InitializeComponent();
        }

        private void FormListadoRecibosPorCaja_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            int mes, anio;
            string SSQL = "";
            DataTable DTCajas = null;
            try
            {
                mes = fecha.Month;
                anio = fecha.Year;

                dtpFecha1.Value = new DateTime(anio, mes, 1);
                dtpFecha2.Value = fecha;

                //Buscamos las Cajas
                SSQL = " SELECT 0 as Caja_Id, '(TODAS)' as Nombre ";
                SSQL += " UNION ALL ";
                SSQL += "SELECT Caja_Id, Nombre From TCAJAS ";
                DTCajas = objDB.GetSQL(SSQL);
                cboCajas.DataSource = DTCajas.DefaultView;
                cboCajas.SelectedValue = 0;

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
            double total = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                cajaNo = 0;
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                if (cboCajas.SelectedValue != null) cajaNo = int.Parse(cboCajas.SelectedValue.ToString());

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");

                if (cajaNo > 0) objDB.AddFiltroIgualA("Caja_Id", cajaNo.ToString());

                MyData = objDB.GetAll("VCAJAS_RECIBOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("Monto");
                lblCantidadRegistro.Text = "Total: " + total.ToString("N2");

                Cursor = Cursors.Default;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            string valorId = "0";
            string pathReporte = "";
            DataRow fila0 = null;
            double monto = 0;
            DataTable DTDetalle = null, DTData = null;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count == 0) return;

                pathReporte = objUtil.GetPathReportRDLC("RptCreditoRecibo");
                
                valorUnico = DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];

                if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
                {
                    valorId = objUtil.GetAsString("Recibo_Id", fila0, "0");
                    monto = objUtil.GetAsDouble("Monto", fila0);
                    montoLetras = Numalet.ToCardinal(monto);

                    DTData = objDB.GetById("VCAJAS_RECIBOS", valorId, "Recibo_Id");
                    DTDetalle = objDB.GetById("TPRESTAMOS_DETALLE_COBRADO", valorId, "Recibo_Id");

                    frm.pathReporte = pathReporte;
                    frm.DTOficina = DTOficina;
                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = "RECIBO NO.: " + valorId.PadLeft(7, '0');
                    frm.AddDS("DSData", DTData);
                    frm.AddDS("DSDetalle", DTDetalle);
                    frm.AddParm("MONTO_LETRAS", montoLetras.ToUpper());

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
                DTData = null;
                DTDetalle = null;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                txtConcepto.Text = "";

                if (MyData == null) return;
                if (MyData.Rows.Count == 0) return;
                if (DataGridConsulta.Rows.Count <= 0) return;

                concepto = DataGridConsulta["Recibo_Id", DataGridConsulta.CurrentRow.Index].Value.ToString();
                concepto = "RECIBO NO.: " + concepto.PadLeft(7, '0') + "; ";
                concepto += DataGridConsulta["Concepto", DataGridConsulta.CurrentRow.Index].Value.ToString();

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            // base.Imprimir();
            string pathReporte = "";
            ELRFormPreviewRDLC frm = new ELRFormPreviewRDLC();
            try
            {
                if (MyData == null) return;
            
                Cursor = Cursors.WaitCursor;

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptCreditosListadoRecibos");
                if (pathReporte.Trim() != "")
                {

                    frm.DTOficina = DTOficina;
                    frm.DTData = MyData;
                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = "LISTADO DE RECIBOS DE CAJA";
                    frm.pathReporte = pathReporte.Trim();
                    frm.montoLetras = montoLetras;

                    frm.AddParm("FECHA_DESDE", objUtil.GetDateAsString(dtpFecha1.Value));
                    frm.AddParm("FECHA_HASTA", objUtil.GetDateAsString(dtpFecha2.Value));
                    frm.AddParm("NOMBRE_CAJA", "CAJA NO.: " + cajaNo.ToString().PadLeft(3, '0') + " " + cboCajas.Text);

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                frm.Dispose();
            }
        }
    }
}
