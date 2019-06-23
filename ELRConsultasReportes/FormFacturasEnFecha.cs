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
    public partial class FormFacturasEnFecha : WinControl_ELR_NET.FormPlantillaIndex
    {
        public DataRow fila0 = null;

        int fechaId = 0;
        DateTime fecha = DateTime.Now.Date;
        public FormFacturasEnFecha()
        {
            InitializeComponent();
        }

        private void FormFacturasEnFecha_Load(object sender, EventArgs e)
        {
            try
            {
                if (fila0 != null) fecha = objUtil.GetAsDate("Fecha", fila0);

                fechaId = objUtil.DateToInt(fecha);
                Text = "FACTURAS EN FECHA: " + objUtil.GetDateAsString(fecha);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            double total = 0, costo = 0, ganancia = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroIgualA("Fecha",fechaId.ToString() );
                

                MyData = objDB.GetAll("VVENTAS", -1, objDB.Filtros);
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
                pathReporte = objUtil.GetPathReportRDLC("RptVentasEnFecha");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = Text;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int index = 0;
            DataRow fila0 = null;
            FormFacturaDetalle frm = new FormFacturaDetalle();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];

                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Cursor = Cursors.WaitCursor;
                    frm.fila0 = fila0;
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
    }
}
