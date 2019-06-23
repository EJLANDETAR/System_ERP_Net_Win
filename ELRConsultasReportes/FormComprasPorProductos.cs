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
    public partial class FormComprasPorProductos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormComprasPorProductos()
        {
            InitializeComponent();
        }

        private void FormComprasPorProductos_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        void GetProducto(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();

            try
            {
                codigo = codigo.Trim();
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Producto_Id, Nombre_Corto FROM TCLASIFICADOR_PRODUCTOS";
                    SSQL += " WHERE Cast(Producto_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(Codigo_Barra, '-', '') = '" + codigo + "' ";

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


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Producto_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre_Corto", fila0);
                }

                txtCodigo.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);
                toolTip1.SetToolTip(txtCodigo, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            GetProducto();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (e.KeyCode == Keys.F9) GetProducto();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetProducto(codigo);
        }

        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            int productoId = 0;
            double total = 0, subTotal = 0, itbis = 0, cantidad = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                int.TryParse(txtCodigo.Text, out productoId);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("Modulo", "COMP");
                objDB.AddFiltroMayorOIgualA("Factura_Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Factura_Fecha", fechaHasta.ToString());

                if (productoId > 0) objDB.AddFiltroIgualA("Producto_Id", productoId.ToString());

                MyData = objDB.GetAll("VCXP_DETALLES", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("DTotal");
                subTotal = GetSum("DSub_Total");
                itbis = GetSum("DItbis");
                cantidad = GetSum("Cantidad");

                lblCantidadRegistro.Text = "Cantidad: " + cantidad.ToString("N2");
                lblCantidadRegistro.Text += "   Sub Total: " + subTotal.ToString("N2");
                lblCantidadRegistro.Text += "   Itbis: " + itbis.ToString("N2");
                lblCantidadRegistro.Text += "   Total: " + total.ToString("N2");

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
                pathReporte = objUtil.GetPathReportRDLC("RptComprasPorProductos");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "COMPRAS POR PRODUCTOS, FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
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

        }

    }
}
