using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRBanco
{
    public partial class FormBancosDepositosR : WinControl_ELR_NET.ELRFormRegistro
    {
        DataRow DRCuentasContables;
        DataRow DRAuxiliares;
        string descripcionCuenta = "";
        string descripcionAuxiliar = "";

        public FormBancosDepositosR()
        {
            InitializeComponent();
        }

        public override void HandleCellKeyDown(object sender, KeyEventArgs e)
        {
            //base.HandleCellKeyDown(sender, e);
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;
            bool esCol1 = false;

            try
            {
                if (COLUMNA_ACTUAL_GRID_DETALLE == "CUENTA_CONTABLE")
                {
                    esCol1 = true;

                    if (e.KeyCode == Keys.F9)
                    {
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

                        if (frm.FilaSelecionada != null)
                        {
                            DRCuentasContables = frm.FilaSelecionada;
                            //Mandamos el Focus a la columna Cantidad
                            DataGridDetalle.CurrentCell = DataGridDetalle["Codigo_Auxiliar", DataGridDetalle.CurrentRow.Index];
                            DataGridDetalle.BeginEdit(true);
                        }

                    }
                }

                if ((COLUMNA_ACTUAL_GRID_DETALLE == "CODIGO_AUXILIAR") && (esCol1 == false))
                {
                    if (e.KeyCode == Keys.F9)
                    {
                        //Vamos a Buscar el Producto
                        frm.titulo = @"0FICINA 0 CENTRO DE COSOTO";
                        frm.TablaOVista = "VCONTA_AUXILIARES";
                        frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString();
                        frm.columnas = new WinControl_ELR_NET.MyColumna[2];


                        col = new WinControl_ELR_NET.MyColumna();
                        col.NombreCampo = "Codigo_Auxiliar";
                        col.HeaderText = "Codigo";
                        col.Ancho = 120;
                        frm.columnas[0] = col;

                        col = new WinControl_ELR_NET.MyColumna();
                        col.NombreCampo = "Descripcion";
                        col.HeaderText = "Descripcion";
                        col.Ancho = -1;
                        frm.columnas[1] = col;

                        frm.ShowDialog();

                        if (frm.FilaSelecionada != null)
                        {
                            DRAuxiliares = frm.FilaSelecionada;
                            //Mandamos el Focus a la columna Cantidad
                            DataGridDetalle.CurrentCell = DataGridDetalle["Debito", DataGridDetalle.CurrentRow.Index];
                        }

                    }

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

        public override void MostrarDataEnGrid()
        {
            //base.MostrarDataEnGrid();
            int index = 0;

            try
            {
                descripcionAuxiliar = "";

                if (DRAuxiliares != null)
                {
                    descripcionAuxiliar = DRAuxiliares["Descripcion"].ToString();
                    DataGridDetalle["Codigo_Auxiliar", index].Value = DRAuxiliares["Codigo_Auxiliar"];
                    DataGridDetalle["Descripcion", index].Value = descripcionCuenta + ", " + descripcionAuxiliar;

                    DRAuxiliares = null;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
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

                

                SetValorEncabezado("Monto", totalCredito);
                txtMonto.Text = totalCredito.ToString("N2");
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

        public override bool GetData()
        {
            bool resultado = false;

            try
            {
                resultado = base.GetData();
                if (esNuevo)
                {
                    dtpFecha.Value = objDB.FECHA_CONTABLE;
                    SetValorEncabezado("Tipo", "DEP");
                }

                dtpFecha.Enabled = EsCambiarFecha;

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        private void cboCuenta_SelectedValueChanged(object sender, EventArgs e)
        {
            int valorId = 0;
            string cuentaNumero = "";
            DataRow fila0 = null;
            try
            {
                if (cboCuenta.SelectedValue != null)
                {
                    valorId = int.Parse(cboCuenta.SelectedValue.ToString());
                    fila0 = cboCuenta.data.Select("Cuenta_Id = " + valorId.ToString())[0];
                    cuentaNumero = fila0["Numero"].ToString();
                }

                SetValorEncabezado("Cuenta_Numero", cuentaNumero);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridDetalle.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (DataGridDetalle.RowCount > 0) EliminarLineaDetalleTemp();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
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
                    DataGridDetalle["Cuenta_Contable", index].Value = DRCuentasContables["Cuenta_Contable"];

                    DRCuentasContables = null;

                    DataGridDetalle.CurrentCell = DataGridDetalle["Credito", index];

                    DataGridDetalle.BeginEdit(true);

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

        private void btnAgregarLineaVacia_Click(object sender, EventArgs e)
        {
            AgregarLineaVacia();
        }

        public override void PasarValorADS()
        {
            try
            {
                base.PasarValorADS();
                SetValorEncabezado("Beneficiario", cboCuenta.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormBancosDepositosR_Load(object sender, EventArgs e)
        {
            try
            {
                if (EnEjecusion)
                {
                    addButtonAMenuLateral("ELRBanco.FormBancos");
                    addButtonAMenuLateral("ELRBanco.FormBancosCuentas");
                    addButtonAMenuLateral("ELRBanco.FormBancoTiposTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancosCheques");
                    addButtonAMenuLateral("ELRBanco.FormImprimirCheques");
                    addButtonAMenuLateral("ELRBanco.FormOtrasTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancosConsTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancoAnularTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancoConciliaciones");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
