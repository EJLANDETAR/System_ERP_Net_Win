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
    public partial class FormOpeCXP : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTTipo = null;

        public FormOpeCXP()
        {
            InitializeComponent();
        }

        private void FormOpeCXP_Load(object sender, EventArgs e)
        {
            string SSQL = "";
            try
            {
                btnGrabar.Visible = false;

                objDB.GetFechasOficina();
                dtpFeHasta.Value = objDB.FECHA_TRABAJO;
                dtpFeDesde.Value = objUtil.getPrimeraFechaMes(objDB.FECHA_TRABAJO);

                SSQL = " SELECT '' as Codigo, '(TODOS)' as Nombre ";
                SSQL += " Union All ";
                SSQL += " SELECT Codigo, Nombre FROM TSISTEMA_MODULOS_TRANSACCIONES ";
                SSQL += " WHERE Modulo = 'COMP' ";
                DTTipo = objDB.GetSQL(SSQL);
                cboTipo.ValueMember = "Codigo";
                cboTipo.DisplayMember = "Nombre";
                cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                cboTipo.DataSource = DTTipo.DefaultView;

                //Aplicamos formato al datagridDetalle
                FormatearGridDetalle();

                //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
                addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto");
                addButtonAMenuLateral("ELRMaestros.FormProductos", "Productos/Servicios");
                addButtonAMenuLateral("ELRMaestros.FormEntidadesIndex", "Suplidores");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormFacturasCompras", "Registrar Compra");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormGastosFijosGenerar");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormGastosMenores");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormOtrosGastos");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormAnularFacturaCompra", "Anular compra");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormInventarioAjuste", "Ajuste Inventario");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormCXP", "Abono o pago CXP");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormNotaCreditoACompra", "Nota Credito a Cuenta Pagar");
                
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII606", "606 DGII");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            //base.GetData(opcion);
            string tipo = "";
            DateTime fecha;
            string aBuscar = "";
            string filtro = "";
            bool resultado = false;
            int conteo = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnImpListado.Enabled = false;
                btnExcel.Enabled = false;
                btnImpFactura.Enabled = false;

                objDB.LimpiarFiltros();
                objDB.AddFiltroPersonalizado("IsNull(EsNulo, 0) = 0");
                if (cboTipo.SelectedValue != null) tipo = cboTipo.SelectedValue.ToString().ToUpper();

                if (tipo == "CXP") objDB.AddFiltroEmpieceEN("Proximo", tipo);
                else if (tipo != "") objDB.AddFiltroEmpieceEN("Modulo", tipo);

                fecha = dtpFeDesde.Value.Date;
                objDB.AddFiltroMayorOIgualA("Factura_Fecha", objDB.DateToInt(fecha).ToString());

                fecha = dtpFeHasta.Value.Date;
                objDB.AddFiltroMenorOIgualA("Factura_Fecha", objDB.DateToInt(fecha).ToString());

                aBuscar = txtABuscar.Text.Trim();

                if (aBuscar != "")
                {
                    filtro = "Replace(IsNull(Nombre, '') + IsNull(CedulaRNC, '') + IsNull(NCF, '') + IsNull(NCF_AModificar, '') + IsNull(Factura_Numero, ''), '-', '') ";
                    aBuscar = aBuscar.Replace("-", "");
                    objDB.AddFiltroContengaA(filtro, aBuscar);
                }

                objDB.AddFiltroOrderBY("Unico Desc");

                DTDetalle = objDB.GetAll("VCXP", -1, objDB.Filtros);
                DataGridDetalle.AutoGenerateColumns = false;
                DataGridDetalle.DataSource = DTDetalle.DefaultView;

                TotalizarDetalle();
                conteo = DTDetalle.Rows.Count;
                btnImpListado.Enabled = (conteo > 0);
                btnExcel.Enabled = (conteo > 0);
                btnImpFactura.Enabled = (conteo > 0);

                resultado = true;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            return resultado;
        }

        public override void TotalizarDetalle()
        {
            double total = 0, ret = 0, aPagar = 0;
            try
            {
                lblTotal.Text = "Total: 0.00                         APagar: 0.00     ";
                if(DTDetalle != null)
                {
                    total = GetSumDetalle("Total");
                    ret = GetSumDetalle("TotalRet");
                    aPagar = GetSumDetalle("Monto_Pendiente");

                    lblTotal.Text = "Total: " + total.ToString("N2");
                    lblTotal.Text += "                         APagar P.: " + aPagar.ToString("N2") + "     ";
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnImpFactura_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DataTable DTData = null;
            string valorId = "0";
            int index = 0;
            try
            {
                if (DTDetalle == null) return;
                if (DTDetalle.Rows.Count <= 0) return;
                if (dtgDetalle.CurrentRow == null) return;

                index = dtgDetalle.CurrentRow.Index;
                valorId = dtgDetalle["CXP_Id", index].Value.ToString();
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Identificador_Id", valorId);
                DTData = objDB.GetAll("VCXP_DETALLES", -1, objDB.Filtros);

                pathReporte = objUtil.GetPathReportRDLC("RPTCompraFactura");

                frm.pathReporte = pathReporte;
                frm.DTData = DTData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = OFICINA_ID;
                frm.empresaId = EMPRESA_ID;
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarAEXCEL(null, "OPERACIONES DE COMPRAS");
        }
    }
}
