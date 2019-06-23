using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaCatalogoACierre : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaCatalogoACierre()
        {
            InitializeComponent();
        }

        private void FormContaCatalogoACierre_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date.AddMonths(-1);
            txtAnio.Text = fecha.Year.ToString();
            cboMes.SelectedIndex = fecha.Month - 1;

            GetData();
        }

        public override void GetData(int opcion = 0)
        {
            int anio = 0, mes = 0, codigoAuxiliar = 0;
            string cuentaContable, SSQL = "";

            try
            {
                Cursor = Cursors.WaitCursor;
                tsbImprimir.Enabled = false;

                mes = cboMes.SelectedIndex + 1;
                int.TryParse(txtAnio.Text, out anio);
                int.TryParse(txtCentroCosto.Text, out codigoAuxiliar);
                cuentaContable = txtABuscar.Text.Trim();

                SSQL = "SELECT * FROM FN_CONTA_CATALOGO_SALDO(";
                SSQL += empresaID.ToString() + ", ";
                SSQL += anio.ToString() + ", ";
                SSQL += mes.ToString() + ")";
                SSQL += " WHERE 1=1 ";

                if (cuentaContable != "") SSQL += " and Cuenta_Contable like '" + cuentaContable + "%' ";
                if (codigoAuxiliar > 0) SSQL += " and Codigo_Auxiliar like '" + codigoAuxiliar.ToString() + "%' ";

                SSQL += " Order by Cuenta_Contable ";

                MyData = objDB.GetSQL(SSQL);
                MostrarCantidadFilas();
                tsbImprimir.Enabled = MyData.Rows.Count > 0;

                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

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
                if (aBuscar.Trim() != "")
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

                if (fila0 != null)
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

        private void btnBuscarAuxiliar_Click(object sender, EventArgs e)
        {
            GetCentroCosto();
        }

        private void txtABuscar_Leave(object sender, EventArgs e)
        {
            string aBuscar = txtABuscar.Text.Trim();
            if (aBuscar != "") GetCuenta(aBuscar);
        }

        private void txtCentroCosto_Leave(object sender, EventArgs e)
        {
            string aBuscar = txtCentroCosto.Text.Trim();
            if (aBuscar != "") GetCentroCosto(aBuscar);
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            try
            {
                if(MyData.Rows.Count > 0)
                {
                    frm.pathReporte = objUtil.GetPathReportRDLC("RptContaCatalogo");
                    frm.empresaId = empresaID;
                    frm.oficinaId = oficinaID;
                    frm.DTData = MyData;
                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = "CATALOGO DE CUENTAS A " + cboMes.Text + " " + txtAnio.Text;
                    frm.AddParm("EsCierre", "true");

                    frm.ShowDialog();
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
    }
}
