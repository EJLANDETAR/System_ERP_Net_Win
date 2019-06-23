using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRContaGeneral
{
    public partial class FormContaMovimientosPorCuenta : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataRow DRCuentaContable = null;
        string temporalId = "";

        public FormContaMovimientosPorCuenta()
        {
            InitializeComponent();
        }

        private void GetCuentaContable(string cuentaNo = "")
        {
            DataTable DTData = null;
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;
            try
            {
                DRCuentaContable = null;
                lblNombreCuenta.Text = "";

                if (cuentaNo.Trim() != "")
                {              
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                    objDB.AddFiltroEmpieceEN("Cuenta_Contable", cuentaNo.Trim());
                    objDB.AddFiltroOrderBY("Cuenta_Contable");

                    DTData = objDB.GetAll("TCONTA_CATALOGO", 1, objDB.Filtros);
                    if (DTData.Rows.Count > 0) DRCuentaContable = DTData.Rows[0];
                }
                else
                {
                    //Vamos a Buscar el Producto
                    frm.titulo = @"CUENTAS CONTABLES";
                    frm.TablaOVista = "TCONTA_CATALOGO";
                    frm.FiltroEstatico = "Empresa_Id  = " + empresaID.ToString();
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
                    if (frm.FilaSelecionada != null) DRCuentaContable = frm.FilaSelecionada; 
                }

                if(DRCuentaContable != null)
                {
                    txtABuscar.Text = objUtil.GetAsString("Cuenta_Contable", DRCuentaContable);
                    lblNombreCuenta.Text = objUtil.GetAsString("Descripcion", DRCuentaContable);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscaCuenta_Click(object sender, EventArgs e)
        {
            GetCuentaContable();
        }

        private void FormContaMovimientosPorCuenta_Load(object sender, EventArgs e)
        {
            dtpFecha1.Value = DateTime.Now.Date.AddDays(-15);
            dtpFecha2.Value = DateTime.Now.Date;
        }

        public override void GetData(int opcion = 0)
        {
            //base.GetData(opcion);
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string cuentaContable;
            int fechaDesde, fechaHasta;
            int spReturn = 0;

            try
            {
                if (MyData != null)
                {
                    MyData.Clear();
                    dtgData.DataSource = null;
                }

                if (DRCuentaContable != null)
                {
                    Cursor = Cursors.WaitCursor;
                    cuentaContable = objUtil.GetAsString("Cuenta_Contable", DRCuentaContable);
                    fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                    fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                    if (temporalId == "") temporalId = objUtil.GetTemporalID();


                    //Ejecutamos el Procedimiento para Cargar los Movimientos en el Temporal
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                    parms.Add(new DataDB_ELR_NET.Parametro("cuentaContable", cuentaContable));
                    parms.Add(new DataDB_ELR_NET.Parametro("fechaDesde", fechaDesde.ToString()));
                    parms.Add(new DataDB_ELR_NET.Parametro("fechaHasta", fechaHasta.ToString()));
                    parms.Add(new DataDB_ELR_NET.Parametro("empresaId", empresaID.ToString()));
                    parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_CONTA_MOVIMIENTOS_POR_CUENTA", parms);
                    if (spReturn < 0) MostrarErrorTemporal(temporalId);
                    else
                    {
                        objDB.confirmarTransaccion();
                        objDB.LimpiarFiltros();
                        objDB.AddFiltroIgualA("IdentificadorTemp", temporalId);
                        MyData = objDB.GetAll("TTEMPORAL_CONTA_MOVIMIENTOS_POR_CUENTA", -1, objDB.Filtros);
                        dtgData.AutoGenerateColumns = false;
                        dtgData.RowTemplate.Height = 33;

                        dtgData.DataSource = MyData.DefaultView;

                    }
                }

                MostrarCantidadFilas();
                TotalizarData();

            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FormContaMovimientosPorCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (temporalId != "") objDB.LimpiarTemporal("TTEMPORAL_CONTA_MOVIMIENTOS_POR_CUENTA", "", temporalId);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public override void TotalizarData()
        {
            //base.TotalizarData();
            double saldoInicial = 0;
            double totalDebito = 0;
            double totalCredito = 0;
            double saldoFinal = 0;
            DataRow fila = null;

            try
            {
                if(MyData != null)
                {
                    if(MyData.Rows.Count > 0)
                    {
                        fila = MyData.Rows[0];
                        saldoInicial = objUtil.GetAsDouble("Saldo_Anterior", fila);
                        totalDebito = GetSum("Debito");
                        totalCredito = GetSum("Credito");

                        fila = MyData.Rows[MyData.Rows.Count - 1];
                        saldoFinal = objUtil.GetAsDouble("Saldo", fila);
                    }
                }

                lblTotal.Text = "Saldo Inicial: " + saldoInicial.ToString("N2") + 
                                "     + Debito: " + totalDebito.ToString("N2") +
                                "     - Credito: " + totalCredito.ToString("N2") +
                                "     = Saldo Final: " + saldoFinal.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                if(dtgData.RowCount > 0)
                {
                    concepto = dtgData["Concepto", dtgData.CurrentRow.Index].Value.ToString();
                }

                txtConcepto.Text = concepto;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            
        }

        private void txtABuscar_Leave(object sender, EventArgs e)
        {
            GetCuentaContable(txtABuscar.Text);
        }

        private void txtABuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9) GetCuentaContable("");
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            string pathReporte = "";
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();
            try
            {
                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptContaMovimientosPorCuenta");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = MyData;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "Consulta Movimientos Por Cuenta";
                    frmPreview.pathReporte = pathReporte.Trim();
                    frmPreview.montoLetras = montoLetras;

                    frmPreview.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmPreview.Dispose();
            }
        }
    }
}
