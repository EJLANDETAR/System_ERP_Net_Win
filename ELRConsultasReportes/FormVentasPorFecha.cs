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
    public partial class FormVentasPorFecha : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormVentasPorFecha()
        {
            InitializeComponent();
        }

        private void FormVentasPorFecha_Load(object sender, EventArgs e)
        {
            //INICIAMOS LAS FECHAS E INVOCAMOS AL METODO GetData
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        public override void GetData(int opcion = 0)
        {
            //EL METODO GETDATA HA SIDO SOBREESCRITO TOTALMENTE PARA PERSONALIZAR LA BUSQUEDA
            int fechaDesde = 0, fechaHasta = 0;
            string SSQL = "";
            double total = 0, costo = 0, ganancia = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                SSQL += " SELECT ROW_NUMBER() Over(Order by Fecha) as Unico, Fecha, Sum(Monto) as Monto, Sum(Total_Costo) as Total_Costo, Sum(Ganancia) as Ganancia ";
                SSQL += " FROM VVENTAS ";
                SSQL += " WHERE Empresa_Id = " + empresaID.ToString();
                SSQL += " And IsNull(EsNulo, 0) = 0 ";
                SSQL += "  and Fecha >= '" + fechaDesde.ToString() + "' ";
                SSQL += "  And Fecha <= '" + fechaHasta.ToString() + "' ";
                SSQL += " Group by Fecha ";



                MyData = objDB.GetSQL(SSQL);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("Monto");
                costo = GetSum("Total_Costo");
                ganancia = GetSum("Ganancia");

                lblCantidadRegistro.Text = "Total: " + total.ToString("N2");
                lblCantidadRegistro.Text += "        Costos: " + costo.ToString("N2") + "        Ganancia: " + ganancia.ToString("N2");

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //AL HACER CLIC EN UNA FECHA DEL DATAGRIDVIEW SE MOSTRARA OTRO FORMULARIO CON LAS VENTAS EN DETALLE EN DICHA FECHA
            string valorUnico = "0";
            int index = 0;
            DataRow fila0 = null;
            FormFacturasEnFecha frm = new FormFacturasEnFecha();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];

                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn || DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    Cursor = Cursors.WaitCursor;
                    frm.fila0 = fila0;
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();
                }

                Cursor = Cursors.Default;
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

        public override void Imprimir()
        {
            //EL METODO IMPRIMIR SE HA SOBRE ESCRITO PARA MOSTRAR EL REPORTE
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptVentasPorFechas2");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "VENTAS POR FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
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
