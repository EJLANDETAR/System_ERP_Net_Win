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
    public partial class FormGastosFijosR : WinControl_ELR_NET.ELRFormRegistro
    {
        DataRow DRCuentasContables = null;
        int codigoAuxiliar = 0;
        double tasaItbis = 0.18;
        string descripcionCuenta = "";

        public FormGastosFijosR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0 = null;
            string SSQL = "";

            try
            {
                resultado = base.GetData();

                if (resultado && !esNuevo)
                {
                    fila0 = DSDatos.Tables[0].Rows[0];
                    lblNombre.Text = "Nombre o Razon Social: " + objUtil.GetAsString("Nombre", fila0);
                    lblCedulaRNC.Text = "Cedula o RNC:  " + objUtil.GetAsString("CedulaRNC", fila0);
                    
                }
                else
                {
                    lblNombre.Text = "Nombre o Razon Social:  Beneficiario";
                    lblCedulaRNC.Text = "Cedula o RNC:  00000000000";
                }

                if (resultado)
                {
                    //Buscamos la tasa del itbis
                    SSQL = " SELECT IsNull(Max(Tasa_Itbis), 0) as tasaItbis FROM TCLASIFICADOR_PRODUCTOS_CATEGORIAS ";
                    tasaItbis = objDB.GetAsDouble("tasaItbis", objDB.GetSQL(SSQL).Rows[0]);
                    if (tasaItbis <= 0) tasaItbis = 18.0;
                    
                    tasaItbis = tasaItbis / 100.0;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void GetCuentaContable(string cuentaNo = "")
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            try
            {
                //Vamos a Buscar el Producto
                frm.titulo = @"CUENTAS CONTABLES";
                frm.TablaOVista = "TCONTA_CATALOGO";
                frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString() + " And EsControl = 0 And EsMovimiento = 1 ";
                frm.FiltroEstatico += " And SUBSTRING(Cuenta_Contable, 1, 1) In ('5', '6' ) ";
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frm.Dispose();
            }
        }

        void GetCentroCosto(string codigo = "")
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "";
            int index = 0;
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
                    fila0["Codigo_Auxiliar"] = codigoAuxiliar;
                    fila0["Descripcion"] = descripcionCuenta + ", " + descripcionAuxiliar;
                    DataGridDetalle.Refresh();

                    DataGridDetalle["Cuenta_Contable", index].Selected = true;

                    DataGridDetalle.CurrentCell = DataGridDetalle["Total", index];

                    DataGridDetalle.BeginEdit(false);
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

        public override void AgregarLineaVacia()
        {

            int index = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DataGridDetalle.RowCount > 0) PostLineaDetalle();

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
                    if (index >= 0) DataGridDetalle.CurrentCell = DataGridDetalle["Total", index];

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

        void CalcularAPagar()
        {
            double total = 0, itbis = 0, subTotal = 0;
            double retItbis = 0, retISR = 0, aPagar = 0;
            try
            {
                total = objUtil.ConvertirANumero(txtMonto.Text);
                itbis = objUtil.ConvertirANumero(txtTotalItbis.Text);
                subTotal = total - itbis;
                retItbis = objUtil.ConvertirANumero(txtRetItbis.Text);
                retISR = objUtil.ConvertirANumero(txtRetISR.Text);
                aPagar = total - (retItbis + retISR);
                                
                
                SetValorEncabezado("Sub_Total", subTotal);
                SetValorEncabezado("Neto", subTotal);
                SetValorEncabezado("Monto_APagar", aPagar);
                txtAPagar.Text = aPagar.ToString("N2");              
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void TotalizarDetalle()
        {

            double total = 0, totalItbis = 0;

            try
            {
                //base.TotalizarDetalle();
                total = GetSumDetalle("Monto");
                totalItbis = GetSumDetalle("Itbis");
                txtMonto.Text = total.ToString("N2");
                txtTotalItbis.Text = totalItbis.ToString("N2");

                SetValorEncabezado("Total", total);
                SetValorEncabezado("Itbis", totalItbis);
                CalcularAPagar();
            
            }
            catch (Exception)
            {

                throw;
            }


        }

        public override void CalcularLineaDetalle()
        {
            //base.CalcularLineaDetalle();
            TotalizarDetalle();
        }

        public override bool ValidarDatos()
        {
            bool resultado = false;
            double itbisM = 0, total = 0, itbis = 0, diferencia = 0;
            double subTotal = 0, retItbis = 0, retISR = 0;
            string msg = "";
           
            try
            {
                resultado = base.ValidarDatos();

                if (resultado)
                {
                    itbis = objUtil.ConvertirANumero(txtTotalItbis.Text);
                    total = objUtil.ConvertirANumero(txtMonto.Text);
                    retItbis = objUtil.ConvertirANumero(txtRetItbis.Text);
                    retISR = objUtil.ConvertirANumero(txtRetISR.Text);
                    subTotal = total / (1 + tasaItbis);

                    if (itbis != 0)
                    {
                        itbisM = (total - subTotal);
                        if(itbis > itbisM) diferencia = Math.Abs( itbis - itbisM);
                        if ((diferencia > 1) || (itbis == total))
                        {
                            resultado = false;
                            msg = "EL ITBIS NO PUEDE SER MAYOR A: " + itbisM.ToString("N2");
                            msg += "\nITBIS DEBE SER MENOR A: " + total.ToString("N2");
                            objUtil.MostrarMensajeAdvertencia(msg);   
                        }

                    }

                    if (resultado)
                    {
                        if(retItbis > itbis)
                        {
                            objUtil.MostrarMensajeError("La retencion del itbis no puede ser mayor al itbis");
                            resultado = false;
                        }
                        else if (retISR >= subTotal)
                        {
                            objUtil.MostrarMensajeError("La retencion del ISR esta sobrepasada");
                            resultado = false;
                        }
                    }

                    if (resultado) CalcularAPagar();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void btnVerPanelDetalle_Click(object sender, EventArgs e)
        {
            AgregarLineaVacia();
        }

        private void btnCentroCosto_Click(object sender, EventArgs e)
        {
            GetCentroCosto();
        }

        private void dtgDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnElegirBeneficiario_Click(object sender, EventArgs e)
        {
            DataRow fila0 = null;
            try
            {
                showEditEntidad();

                fila0 = DSDatos.Tables[0].Rows[0];
                lblNombre.Text = "Nombre o Razon Social: " + objUtil.GetAsString("Nombre", fila0);
                lblCedulaRNC.Text = "Cedula o RNC:  " + objUtil.GetAsString("CedulaRNC", fila0);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            try
            {
                CalcularAPagar();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormGastosFijosR_Load(object sender, EventArgs e)
        {

        }
    }
}
