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
    public partial class FormFacturasCompras : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormFacturasCompras()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            int index = 0;
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    index = dataGridView1.CurrentRow.Index;
                    concepto = "FACTURA NO.: " + dataGridView1["Factrura_Numero", index].Value.ToString();
                    concepto += "; SUPLIDOR: " + dataGridView1["Nombre", index].Value.ToString();
                    concepto += "; CONCEPTO: " + dataGridView1["Concepto", index].Value.ToString();
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn) Modificar();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DataTable DTData = null;
            string valorId = "0";
            int index = 0;
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.CurrentRow == null) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorId = DataGridConsulta["CXP_Id", index].Value.ToString();
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Identificador_Id", valorId);
                DTData = objDB.GetAll("VCXP_DETALLES", -1, objDB.Filtros);

                pathReporte = objUtil.GetPathReportRDLC("RPTCompraFactura");

                frm.pathReporte = pathReporte;
                frm.DTData = DTData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "FACTURA DE COMPRA";

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

        private void FormFacturasCompras_Load(object sender, EventArgs e)
        {
            try
            {
                objDB.GetFechasOficina();
                dtpFecha1.Value = objUtil.getPrimeraFechaMes(objDB.FECHA_TRABAJO);
                dtpFecha2.Value = objDB.FECHA_TRABAJO;
                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void RealizarBusquedaSencilla()
        {
            //base.RealizarBusquedaSencilla();
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (txtABuscar.Text.Trim() != "") objDB.AddFiltroContengaA("Nombre", txtABuscar.Text.Trim());

                GetData();
                pnOpcionesBusqueda.Visible = false;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            double  itbis = 0, total = 0;
            try
            {
                
                base.GetData(opcion);

                itbis = GetSum("Itbis");
                total = GetSum("Total");
                

                lblTotal.Text = "Total: " +  total.ToString("N2") + " ";
                lblItbis.Text = "Itbis" + itbis.ToString("N2") + " ";
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

    }
}
