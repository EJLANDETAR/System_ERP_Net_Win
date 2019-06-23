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
    public partial class FormGastosMenores : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormGastosMenores()
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
                    concepto += "Concepto: " + dataGridView1["Concepto", index].Value.ToString();
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception)
            {

                //throw;
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
    }
}
