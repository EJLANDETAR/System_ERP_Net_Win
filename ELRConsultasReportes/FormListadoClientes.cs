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
    public partial class FormListadoClientes : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormListadoClientes()
        {
            InitializeComponent();
        }

        private void FormListadoClientes_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            dtpFecha2.Enabled = false;
            dtpFecha1.Enabled = false;

            GetData();
        }

        private void chkPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecha1.Enabled = chkPorFecha.Checked;
            dtpFecha2.Enabled = chkPorFecha.Checked;

            GetData();
        }

        private void chkSoloCXC_CheckedChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            double total = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                if(chkPorFecha.Checked)
                {
                    objDB.AddFiltroMayorOIgualA("Fecha_Adicionado", fechaDesde.ToString());
                    objDB.AddFiltroMenorOIgualA("Fecha_Adicionado", fechaHasta.ToString());
                }

                if(chkSoloCXC.Checked) objDB.AddFiltroMayorOIgualA("Balance_CXC", "0");

                objDB.AddFiltroPersonalizado("(EsSuplidor = 0 Or Fecha_Ultima_Venta Is Not Null)");
                MyData = objDB.GetAll("VENTIDADES", -1, objDB.Filtros);
                dgvData.AutoGenerateColumns = false;
                dgvData.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();
                total = GetSum("Balance_CXC");

                lblCantidadRegistro.Text = "Total Por Cobrar: " + total.ToString("N2");

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
              Cursor =  Cursors.Default;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow fila0 = null;
            int index = 0;
            FormDetalleCXCCliente frm = new FormDetalleCXCCliente();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count == 0) return;

                index = dgvData.CurrentRow.Index;
                if(dgvData.Columns[e.ColumnIndex] is DataGridViewLinkColumn || dgvData.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    valorUnico = dgvData["Unico", index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.nombreUsuario = nombreUsuario;
                    frm.filaEntidad = fila0;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();
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
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptListadoClientes");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;

                frm.titulo = "LISTADO DE CLIENTES";
                if(chkPorFecha.Checked)
                {
                    frm.titulo += ", POR FECHA DE REGISTRO: ["  + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
                }

                if (chkSoloCXC.Checked) frm.titulo += " (CON CUENTA POR COBRAR PENDIENTE)";

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
