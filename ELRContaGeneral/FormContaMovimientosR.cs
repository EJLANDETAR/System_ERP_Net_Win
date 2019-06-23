using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaMovimientosR : WinControl_ELR_NET.ELRFormRegistro
    {

        DataRow DRCuentasContables;
        int codigoAuxiliar = 0;
        string descripcionCuenta = "";
        bool esSistema = false;

        public FormContaMovimientosR()
        {
            InitializeComponent();
        }

        void GenerarReferencia()
        {
            string tipo = "ED";
            string referencia = "";

            try
            {
                if (esNuevo)
                {
                    if (cboTipoDocumento.SelectedValue != null) tipo = cboTipoDocumento.SelectedValue.ToString();
                    referencia = tipo + objUtil.DateToInt(dtpFecha.Value).ToString();
                    txtDocumentoNo.Text = referencia;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            GenerarReferencia();
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarReferencia();
        }

        public override bool GetData()
        {
            bool resultado = false;
            try
            {
                resultado = base.GetData();
                codigoAuxiliar = OFICINA_ID;
                if (esNuevo )
                {
                    esSistema = false;
                    txtDocumentoNo.Enabled = true;
                    cboTipoDocumento.Enabled = true;

                    GenerarReferencia();

                    if (objDB.FECHA_CONTABLE == null) dtpFecha.Value = DateTime.Now;
                    else dtpFecha.Value = objDB.FECHA_CONTABLE;
                }
                else
                {
                    esSistema = objUtil.GetAsBoolean("EsSistema", DSDatos.Tables[0].Rows[0]);
                    codigoAuxiliar = objUtil.GetAsInt("Oficina_Id", DSDatos.Tables[0].Rows[0]);
                    txtDocumentoNo.Enabled = (!esSistema);
                    cboTipoDocumento.Enabled = (!esSistema);
                }

                dtpFecha.Enabled = EsCambiarFecha;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void btnVerPanelDetalle_Click(object sender, EventArgs e)
        {
            AgregarLineaVacia();
        }

        private void GetCuentaContable(string cuentaNo = "")
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            //Vamos a Buscar el Producto
            frm.titulo = @"CUENTAS CONTABLES";
            frm.TablaOVista = "TCONTA_CATALOGO";
            frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString() + " And EsControl = 0 And EsMovimiento = 1";
            frm.columnas = new WinControl_ELR_NET.MyColumna[2];


            col = new WinControl_ELR_NET.MyColumna();
            col.NombreCampo = "Cuenta_Contable";
            col.HeaderText = "Cuenta Contable";
            col.Ancho = 140;
            frm.columnas[0] = col;

            col = new WinControl_ELR_NET.MyColumna();
            col.NombreCampo = "Descripcion";
            col.HeaderText = "Descripcion";
            col.Ancho = -1;
            frm.columnas[1] = col;

            frm.ShowDialog();

            if (frm.FilaSelecionada != null) DRCuentasContables = frm.FilaSelecionada;
        }

        void GetCentroCosto(string codigo = "")
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "";
            int index = 0;
            double debito = 0;
            string descripcionCuenta = "", descripcionAuxiliar = "", valorUnico = "0";
          
            try
            {
                if (DTDetalle == null) return;
                if (DTDetalle.Rows.Count <= 0) return;

                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Codigo_Auxiliar, Descripcion FROM VCONTA_AUXILIARES ";
                    SSQL += " WHERE Cast(Codigo_Auxiliar as Varchar) Like '" + codigo + "%' ";
                    SSQL += " Order by Codigo_Auxiliar";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    //Vamos a Buscar el Producto
                    frm.titulo = @"OFICINA O CENTRO DE COSTO";
                    frm.TablaOVista = "VCONTA_AUXILIARES";
                    frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString() + " And EsActivo = 1";
                    frm.columnas = new WinControl_ELR_NET.MyColumna[2];
                    frm.CondicionOrderBY = "Codigo_Auxiliar";


                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "Codigo_Auxiliar";
                    col.HeaderText = "Codigo";
                    col.Ancho = 140;
                    frm.columnas[0] = col;

                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "Descripcion";
                    col.HeaderText = "Descripcion";
                    col.Ancho = -1;
                    frm.columnas[1] = col;
                    frm.DefaultColumnaBusqueda = "Descripcion";

                    frm.ShowDialog();

                    if (frm.FilaSelecionada != null) fila0 = frm.FilaSelecionada;
                }

                if (fila0 != null)
                {
                    codigoAuxiliar = objUtil.GetAsInt("Codigo_Auxiliar", fila0);
                    descripcionAuxiliar = objUtil.GetAsString("Descripcion", fila0);

                    index = DataGridDetalle.CurrentRow.Index;
                    valorUnico = DataGridDetalle["ItemNumero", index].Value.ToString();
                    fila0 = DTDetalle.Select("ItemNumero = " + valorUnico)[0];
                    descripcionCuenta = objUtil.GetAsString("Descripcion_Cuenta", fila0);
                    debito = objUtil.GetAsDouble("Debito", fila0);
                    fila0["Codigo_Auxiliar"] = codigoAuxiliar;
                    fila0["Descripcion"] = descripcionCuenta + ", " + descripcionAuxiliar;
                    DataGridDetalle.Refresh();

                    DataGridDetalle["Cuenta_Contable", index].Selected = true;

                    if (debito > 0) DataGridDetalle.CurrentCell = DataGridDetalle["Credito", index];
                    else DataGridDetalle.CurrentCell = DataGridDetalle["Debito", index];

                    DataGridDetalle.BeginEdit(false);
                }
  
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void HandleCellKeyDown(object sender, KeyEventArgs e)
        {
            //base.HandleCellKeyDown(sender, e);
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            bool esCol1 = false;

            try
            {
                if (COLUMNA_ACTUAL_GRID_DETALLE == "CUENTA_CONTABLE")
                {
                    esCol1 = true;

                    if (e.KeyCode == Keys.F9) GetCuentaContable();

                }

                if ((COLUMNA_ACTUAL_GRID_DETALLE == "CODIGO_AUXILIAR") && (esCol1 == false))
                {
                    if (e.KeyCode == Keys.F9) GetCentroCosto();

                }

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

        public override void CalcularLineaDetalle()
        {
            //base.CalcularLineaDetalle();
            TotalizarDetalle();
        }

        public override void TotalizarDetalle()
        {
            object calcObject;
            double totalDebito = 0;
            double totalCredito = 0;
            double diferencia = 0;

            try
            {
                //base.TotalizarDetalle();

                calcObject = DTDetalle.Compute("Sum(Debito)", "itemNumero > 0");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalDebito = double.Parse(calcObject.ToString());
                }

                calcObject = DTDetalle.Compute("Sum(Credito)", "itemNumero > 0");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalCredito = double.Parse(calcObject.ToString());
                }

                diferencia = totalDebito - totalCredito;

                SetValorEncabezado("Monto", totalDebito);
                SetValorEncabezado("Total_Debito", totalDebito);
                SetValorEncabezado("Total_Credito", totalCredito);
                SetValorEncabezado("Diferencia", diferencia);

                lblTotalDebito.Text = totalDebito.ToString("N2");
                lblTotalCredito.Text = totalCredito.ToString("N2");
                lblDiferencia.Text = diferencia.ToString("N2");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                calcObject = null;
            }

        }

        public override void AgregarLineaVacia()
        {
            double totalDebito = 0;
            double totalCredito = 0;
            int index = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DataGridDetalle.RowCount > 0) PostLineaDetalle();

                totalDebito = GetSum("Debito", DTDetalle);
                totalCredito = GetSum("Credito", DTDetalle);

                GetCuentaContable("");

                if (DRCuentasContables != null)
                {
                    base.AgregarLineaVacia();

                    index = DataGridDetalle.RowCount - 1;

                    descripcionCuenta = DRCuentasContables["Descripcion"].ToString();
                    DataGridDetalle["Descripcion", index].Value = descripcionCuenta;
                    DataGridDetalle["Descripcion_Cuenta", index].Value = descripcionCuenta;
                    DataGridDetalle["Cuenta_Contable", index].Value = DRCuentasContables["Cuenta_Contable"];

                    DRCuentasContables = null;

                    GetCentroCosto(codigoAuxiliar.ToString());

                   /* DataGridDetalle["Cuenta_Contable", index].Selected = true;

                    if (totalDebito > totalCredito) DataGridDetalle.CurrentCell = DataGridDetalle["Credito", index];
                    else DataGridDetalle.CurrentCell = DataGridDetalle["Debito", index];

                    DataGridDetalle.BeginEdit(false); */

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (DataGridDetalle.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (DataGridDetalle.RowCount > 0) EliminarLineaDetalleTemp();

                    DataGridDetalle.Columns["Descripcion"].ReadOnly = true;
                    DataGridDetalle.Columns["Cuenta_Contable"].ReadOnly = true;
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtConcepto_Click(object sender, EventArgs e)
        {
            DataGridDetalle.EndEdit();

        }

        public override void ImprimirEnMatricial()
        {
            //base.ImprimirEnMatricial();
            ImprimirPreviewRDLC();
        }

        public override void ImprimirTicket()
        {
            //base.ImprimirTicket();
            ImprimirPreviewRDLC();
        }

        public override void ImprimirEnOtroFormato()
        {
            //base.ImprimirEnOtroFormato()
            ImprimirPreviewRDLC();
        }

        private void btnCentroCosto_Click(object sender, EventArgs e)
        {
            GetCentroCosto();
        }

        private void FormContaMovimientosR_Load(object sender, EventArgs e)
        {
            try
            {
                addButtonAMenuLateral("ELRContaGeneral.FormContaCatalogoEdit");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCentroCostos");
                addButtonAMenuLateral("ELRBanco.FormBancosCheques", "Digitar cheques");
                addButtonAMenuLateral("ELRBanco.FormImprimirCheques");
                addButtonAMenuLateral("ELRContaGeneral.FormContaMovimientosAnular");
                addButtonAMenuLateral("ELRContaGeneral.FormContaMovimientosContrapartidas");
                addButtonAMenuLateral("ELRContaGeneral.FormContaGenerarAsientos");
                addButtonAMenuLateral("ELRContaGeneral.FormContaEstadosAGenerar");
                
                addButtonAMenuLateral("ELRContaGeneral.FormContaPaseAlMayor");
                addButtonAMenuLateral("ELRContaGeneral.FormContaPaseRevertir");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCierreDiarioMensual");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCierrePeriodo");

                addButtonAMenuLateral("ELRContaGeneral.FormContaMovimientosPorCuenta");
                addButtonAMenuLateral("ELRContaGeneral.FormContaCatalogoACierre");
                addButtonAMenuLateral("ELRContaGeneral.FormContaSaldoCuentaPorSucursal");
                addButtonAMenuLateral("ELRContaGeneral.FormContaConsultaCierre");
                addButtonAMenuLateral("ELRContaGeneral.FormContaEstadosGenerados");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII606");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII607");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII608");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
