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
    public partial class FormComprasPorSuplidores : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormComprasPorSuplidores()
        {
            InitializeComponent();
        }

        private void FormComprasPorSuplidores_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        void GetEntidad(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Entidad_Id, Nombres, Apellidos FROM TCLASIFICADOR_ENTIDADES";
                    SSQL += " WHERE Cast(Entidad_Id as Varchar) = '" + codigo + "' ";
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
                    frm.FiltroEstatico = "EsSuplidor = 1";


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Entidad_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCodigo.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            GetEntidad();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEntidad();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEntidad(codigo);
        }

        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            int entidadId = 0;
            double total = 0, totalRet = 0, totalAPagar = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                int.TryParse(txtCodigo.Text, out entidadId);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroMayorOIgualA("Factura_Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Factura_Fecha", fechaHasta.ToString());
                objDB.AddFiltroIgualA("Modulo", "COMP");

                if (entidadId > 0) objDB.AddFiltroIgualA("Suplidor_Id", entidadId.ToString());

                MyData = objDB.GetAll("TCXP", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("Total");
                totalRet = GetSum("Retencion_Itbis") + GetSum("Retencion_Neto");
                totalAPagar = GetSum("Monto_APagar");

                lblCantidadRegistro.Text = "Total: " + total.ToString("N2");
                lblCantidadRegistro.Text += "   -Total Ret.: " + totalRet.ToString("N2");
                lblCantidadRegistro.Text += "   =A Pagar: " + totalAPagar.ToString("N2");

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
                pathReporte = objUtil.GetPathReportRDLC("RptComprasPorSuplidores");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "COMPRAS POR SUPLIDORES, FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
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
