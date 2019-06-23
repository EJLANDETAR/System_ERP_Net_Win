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
    public partial class FormMovimientosPorProducto : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormMovimientosPorProducto()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string comentario = "";
            int index = 0;
            try
            {
                txtComentario.Text = "";

                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                if(DataGridConsulta.Rows.Count > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    comentario = DataGridConsulta["Tipo", index].Value.ToString();
                    comentario += ", " + DataGridConsulta["Concepto", index].Value.ToString();
                    comentario += ", USUARIO: " + DataGridConsulta["Adicionado_Por", index].Value.ToString();
                }

                txtComentario.Text = comentario;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetProducto(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id= "0", nombre = "(TODOS)";
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();

            try
            {
                codigo = codigo.Trim();
                if(codigo != "")
                {
                    SSQL = "SELECT TOP 1 Producto_Id, Nombre_Corto FROM TCLASIFICADOR_PRODUCTOS";
                    SSQL += " WHERE Cast(Producto_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or Codigo_Barra = '" + codigo + "' ";

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

                if(fila0 != null)
                {
                    id = objUtil.GetAsString("Producto_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre_Corto", fila0);
                }

                txtCodigoprod.Text = id;
                txtDescProd.Text = nombre;

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            GetProducto();
        }

        private void txtCodigoprod_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigoprod.Text.Trim();

            if (e.KeyCode == Keys.F9) GetProducto();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetProducto(codigo);
        }

        public override void GetData(int opcion = 0)
        {
            String SSQL = "";
            int fechaDesde = 0, fechaHasta = 0;
            int productoId = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                int.TryParse(txtCodigoprod.Text, out productoId);
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                SSQL = "SELECT * FROM FMOVIMIENTOS_POR_PRODUCTO(" + empresaID.ToString();
                SSQL += ", " + fechaDesde.ToString();
                SSQL += ", " + fechaHasta.ToString();
                SSQL += ")";
                SSQL += " WHERE 1= 1";

                if (productoId > 0) SSQL += " and Producto_Id = " + productoId.ToString();
                SSQL += " Order by Fecha";

                MyData = objDB.GetSQL(SSQL);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

                MostrarCantidadFilas();
                TotalizarData();
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

        private void FormMovimientosPorProducto_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        public override void TotalizarData()
        {
            double totalEntrada = 0, totalSalida = 0, total = 0;
            try
            {
                if(MyData != null)
                {
                    totalEntrada = GetSum("Cantidad", "Cantidad > 0");
                    totalSalida = GetSum("Cantidad", "Cantidad < 0");
                    total = GetSum("Cantidad");
                }

                txtTotalEntrada.Text = totalEntrada.ToString("N2");
                txtTotalSalida.Text = totalSalida.ToString("N2");
                txtTotal.Text = total.ToString("N2");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptMovimientosPorProductos");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "MOVIMIENTO DE PRODUCTOS, FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
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
