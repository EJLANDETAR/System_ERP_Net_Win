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
    public partial class FormNotaDebitoCreditoACXPR : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTCuentaPagar = null;

        public FormNotaDebitoCreditoACXPR()
        {
            InitializeComponent();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTipo.SelectedIndex == 0) SetValorEncabezado("Modulo", "NC");
                else SetValorEncabezado("Modulo", "ND");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void getSuplidor(string cedulaRNC = "")
        {
            string SSQL = "", nombre = "(NO SE ENCONTRO EL SUPLIDOR)";
            int entidadId = 0;
            DataTable DTSuplidor = null;
            DataRow fila0 = null;
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();
            try
            {
                Cursor = Cursors.WaitCursor;

                if (cedulaRNC.Trim() != "")
                {
                    cedulaRNC.Replace('-', ' ');
                    SSQL = "SELECT TOP 1 Entidad_Id, CedulaRNC, dbo.FCOMBINA_NOMBRES_APELLIDOS(Nombres, Apellidos, Apodos) as Nombre_Completo ";
                    SSQL += " FROM TCLASIFICADOR_ENTIDADES ";
                    SSQL += " WHERE Replace(CedulaRNC, '-', '') like '%" + cedulaRNC + "%' ";
                    SSQL += " Order by unico desc ";

                    DTSuplidor = objDB.GetSQL(SSQL);
                    if (DTSuplidor.Rows.Count > 0) fila0 = DTSuplidor.Rows[0];
                }
                else
                {
                    //MOSTRAMOS EL FORMULARIO PARA BUSCAR LA ENTIDAD
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.nombreUsuario = nombreUsuario;

                    frm.ShowDialog();
                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                if (fila0 != null)
                {
                    entidadId = objUtil.GetAsInt("Entidad_Id", fila0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0, "000000000");
                    nombre = objUtil.GetAsString("Nombre_Completo", fila0);
                }

                if (cedulaRNC.Trim() == "") cedulaRNC = "000000000";

                txtCedulaRNC.Text = cedulaRNC;
                txtNombreSuplidor.Text = nombre;
                SetValorEncabezado("Suplidor_Id", entidadId);

                GetCXP(entidadId);
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

        void GetCXP(int entidadId)
        {
            string SSQL = ""; 
            try
            {
                cboTipo.Enabled = false;
                txtMonto.Enabled = false;
                txtConcepto.Enabled = false;
                txtNumero.Enabled = false;
                dtpFecha.Enabled = false;

                SetValorEncabezado("CXP_OrigenId", 0);
                SSQL = " SELECT * FROM TCXP";
                SSQL += " WHERE Empresa_Id = " + EMPRESA_ID.ToString();
                SSQL += " and IsNull(EsNulo, 0) = 0 ";
                SSQL += " And Proximo = 'CXP' ";
                SSQL += " And Suplidor_Id = " + entidadId.ToString();
                SSQL += " And Monto_Pendiente > 0 ";
                SSQL += " Order by Unico Desc ";

                DTCuentaPagar = objDB.GetSQL(SSQL);
                dtgCXP.AutoGenerateColumns = false;
                dtgCXP.DataSource = DTCuentaPagar.DefaultView;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCedulaRNC_Leave(object sender, EventArgs e)
        {
            string codigo = txtCedulaRNC.Text.Trim();
            getSuplidor(codigo);
        }

        private void txtCedulaRNC_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCedulaRNC.Text.Trim();
            if (e.KeyCode == Keys.Enter && codigo != "") getSuplidor(codigo);
        }

        private void dtgCXP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0, cxpId = 0;
            string valorUnico = "0", facturaNo = "", numeroNCF = "";
            DataRow fila0;
            try
            {
                if (dtgCXP.RowCount <= 0) return;
                if (DTCuentaPagar == null) return;
                if (DTCuentaPagar.Rows.Count <= 0) return;

                index = dtgCXP.CurrentRow.Index;
                if(dtgCXP.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    valorUnico = dtgCXP["Unico", index].Value.ToString();
                    fila0 = DTCuentaPagar.Select("Unico = " + valorUnico)[0];
                    cxpId = objUtil.GetAsInt("CXP_Id", fila0);
                    facturaNo = objUtil.GetAsString("Factura_Numero", fila0);
                    numeroNCF = objUtil.GetAsString("NCF", fila0);
                    SetValorEncabezado("CXP_OrigenId", cxpId);

                    lblFacturaNo.Text = "Aplicar a Factura No.: " + facturaNo + "      NCF: " + numeroNCF;

                    cboTipo.Enabled = (cxpId > 0);
                    txtMonto.Enabled = (cxpId > 0);
                    txtConcepto.Enabled = (cxpId > 0);
                    dtpFecha.Enabled = (cxpId > 0);
                    txtNumero.Enabled = (cxpId > 0);
                    txtItbis.Enabled = (cxpId > 0);
                    txtNCF.Enabled = (cxpId > 0);

                    btnGrabar.Enabled = (cxpId > 0);

                   if(esNuevo) dtpFecha.Value = DateTime.Now.Date;

                    if (cxpId > 0) cboTipo.Focus();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            bool resultado = false;
            int entidadId = 0, origenId = 0;
            string modulo = "";
            try
            {
                btnGrabar.Enabled = false;
               resultado = base.GetData();

                if(resultado)
                {
                    entidadId = objUtil.GetAsInt("Suplidor_Id", DSDatos.Tables[0].Rows[0], 0);
                    origenId  = objUtil.GetAsInt("CXP_OrigenId", DSDatos.Tables[0].Rows[0], 0);
                    modulo = objUtil.GetAsString("Modulo", DSDatos.Tables[0].Rows[0]).ToUpper();

                    if (esNuevo)
                    {
                        modulo = "NC";
                        SetValorEncabezado("Modulo", "NC");
                    }

                    GetCXP(entidadId);
                }              

                if (modulo == "NC") cboTipo.SelectedIndex = 0;
                if (modulo == "ND") cboTipo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void btnBuscarSuplidor_Click(object sender, EventArgs e)
        {
            getSuplidor();
        }

        private void FormNotaDebitoCreditoACXPR_Load(object sender, EventArgs e)
        {

        }
    }
}
