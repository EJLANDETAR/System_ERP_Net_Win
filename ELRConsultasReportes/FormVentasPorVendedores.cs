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
    public partial class FormVentasPorVendedores : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormVentasPorVendedores()
        {
            InitializeComponent();
        }

        private void FormVentasPorVendedores_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        void GetEmpleado(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Empleado_Id, Nombres, Apellidos FROM TRRHH_EMPLEADOS";
                    SSQL += " WHERE Cast(Empleado_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";
                    frm.Text = "EMPLEADOS VENDEDORES";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCodigoEmp.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void txtCodigoEmp_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigoEmp.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEmpleado();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEmpleado(codigo);
        }

        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            int empleadoId = 0;
            double total = 0, aCredito = 0, aContado = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                int.TryParse(txtCodigoEmp.Text, out empleadoId);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());

                if (empleadoId > 0) objDB.AddFiltroIgualA("Vendedor_Id", empleadoId.ToString());

                MyData = objDB.GetAll("VVENTAS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("Monto");
                aCredito = GetSum("Monto_ACredito");
                aContado = GetSum("Monto_AlContado");

                lblCantidadRegistro.Text = "Total: " + total.ToString("N2");
                lblCantidadRegistro.Text += "        Al Contado: " + aContado.ToString("N2") + "        A Credito: " + aCredito.ToString("N2");

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
                pathReporte = objUtil.GetPathReportRDLC("RptVentasPorVendedores");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "VENTAS POR VENDEDORES, FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
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
