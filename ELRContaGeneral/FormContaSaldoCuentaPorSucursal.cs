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
    public partial class FormContaSaldoCuentaPorSucursal : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaSaldoCuentaPorSucursal()
        {
            InitializeComponent();
        }

        private void FormContaSaldoCuentaPorSucursal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date.AddMonths(-1);
            txtAnio.Text = fecha.Year.ToString();
            cboMes.SelectedIndex = fecha.Month - 1;
        }

        public override void GetData(int opcion = 0)
        {
            int anio = 0, mes = 0, codigoAuxiliar = 0 ;
            string cuentaContable, SSQL = "";
            double saldoAnioAnt = 0, debitoAcumulado = 0, creditoAcumulado = 0, saldoAcumulado = 0;
            double saldoMesAnt = 0, debitoMes = 0, creditoMes = 0, saldoActual = 0, diferencia = 0;
            DataRow fila0 = null;

            try
            {
                Cursor = Cursors.WaitCursor;

                mes = cboMes.SelectedIndex + 1;
                int.TryParse(txtAnio.Text, out anio);
                int.TryParse(txtCentroCosto.Text, out codigoAuxiliar);
                cuentaContable = txtABuscar.Text.Trim();

                SSQL = "SELECT * FROM FN_CONTA_SALDO_POR_CUENTAS(";
                SSQL += empresaID.ToString() + ", ";
                SSQL += "'" + cuentaContable + "', ";
                SSQL += anio.ToString() + ", ";
                SSQL += mes.ToString() + ", ";
                SSQL += codigoAuxiliar.ToString() + ")";

                MyData = objDB.GetSQL(SSQL);
                if(MyData.Rows.Count > 0)
                {
                    fila0 = MyData.Rows[0];
                    saldoAnioAnt = objUtil.GetAsDouble("Saldo_Anio_Anterior", fila0);
                    debitoAcumulado = objUtil.GetAsDouble("Debito_Acumulado", fila0);
                    creditoAcumulado = objUtil.GetAsDouble("Credito_Acumulado", fila0);
                    saldoAcumulado = saldoAnioAnt + ( debitoAcumulado - creditoAcumulado);

                    saldoMesAnt = objUtil.GetAsDouble("Saldo_Mes_Anterior", fila0);
                    debitoMes = objUtil.GetAsDouble("Debito_Mes", fila0);
                    creditoMes = objUtil.GetAsDouble("Credito_Mes", fila0);
                    saldoActual = objUtil.GetAsDouble("Saldo_Actual", fila0);
                }

                txtSaldoAnioAnt.Text = saldoAnioAnt.ToString("N2");
                txtDebitoAcum.Text = debitoAcumulado.ToString("N2");
                txtCreditoAcumulado.Text = creditoAcumulado.ToString("N2");
                txtSaldoActual.Text = saldoAcumulado.ToString("N2");

                txtSaldoMesAnt.Text = saldoMesAnt.ToString("N2");
                txtDebitoMes.Text = debitoMes.ToString("N2");
                txtCreditoMes.Text = creditoMes.ToString("N2");
                txtSaldoMes.Text = saldoActual.ToString("N2");

                diferencia = saldoAcumulado - saldoActual;
                lblCantidadRegistro.Text = "Diferencia: " + diferencia.ToString("N2");

                lblCantidadRegistro.ForeColor = diferencia != 0 ? Color.Red : Color.Black;
                txtSaldoActual.ForeColor = diferencia != 0 ? Color.Red : Color.Black;
                txtSaldoMes.ForeColor = diferencia != 0 ? Color.Red : Color.Black;

                MostrarCantidadFilas();

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

        void GetCuenta(string aBuscar = "")
        {
            string SSQL = "", cuentaContable = "", descripcion = "(TODOS)";
            DataTable DTData = null;
            DataRow fila0 = null;
            FormContaCatalogoEdit frm = new FormContaCatalogoEdit();
            try
            {
                if(aBuscar.Trim() != "")
                {
                    SSQL = "SELECT TOP 1 Cuenta_Contable, Descripcion FROM TCONTA_CATALOGO ";
                    SSQL += " WHERE Empresa_Id = " + empresaID.ToString();
                    SSQL += "       And Cuenta_Contable Like '" + aBuscar.Trim() + "%'";
                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.FiltroEstatico = "Empresa_Id = " + empresaID.ToString();
                    frm.EnEjecusion = true;
                    frm.esBusqueda = true;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.Text = "BUSCAR CUENTA CONTABLE";
                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                if(fila0 != null)
                {
                    cuentaContable = objUtil.GetAsString("Cuenta_Contable", fila0);
                    descripcion = objUtil.GetAsString("Descripcion", fila0);
                }

                txtABuscar.Text = cuentaContable;
                lblDescripcionCuenta.Text = descripcion;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        void GetCentroCosto(string codigo = "")
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", codigoAuxiliar = "0", descripcion = "(TODOS)";

            try
            {
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
                    frm.FiltroEstatico = "Empresa_Id  = " + empresaID.ToString() + " And EsActivo = 1";
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
                    codigoAuxiliar = objUtil.GetAsString("Codigo_Auxiliar", fila0, "0");
                    descripcion = objUtil.GetAsString("Descripcion", fila0);
                }

                txtCentroCosto.Text = codigoAuxiliar;
                lblDescripcionCentroCosto.Text = descripcion;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscaCuenta_Click(object sender, EventArgs e)
        {
            GetCuenta();
        }

        private void txtABuscar_Leave(object sender, EventArgs e)
        {
            string aBuscar = txtABuscar.Text.Trim();
            if (aBuscar != "") GetCuenta(aBuscar);
        }

        private void btnBuscarAuxiliar_Click(object sender, EventArgs e)
        {
            GetCentroCosto();
        }

        private void txtCentroCosto_Leave(object sender, EventArgs e)
        {
            string aBuscar = txtCentroCosto.Text.Trim();
            if(aBuscar != "") GetCentroCosto(aBuscar);
        }
    }
}
