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
    public partial class FormInventarioAjuste : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormInventarioAjuste()
        {
            InitializeComponent();
        }

        void GetProducto(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();
            Int32 codigoNum = 0;

            try
            {
                codigo = codigo.Trim();
                Int32.TryParse(codigo, out codigoNum);

                if (codigo != "" && codigo != "0")
                {
                    SSQL = "SELECT TOP 1 Producto_Id, Nombre_Corto FROM TCLASIFICADOR_PRODUCTOS";
                    SSQL += " WHERE Cast(Producto_Id as Varchar) = '" + codigoNum.ToString() + "' ";
                    SSQL += " Or Codigo_Barra = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1, productoId = 0, categoriaId = 0;
            DialogResult resp;
            try
            {

                //EJECUTAMOS EL STORE PROCEDURE PARA CARGAR A TEMPORAL
                resp = objUtil.MostrarMensajePregunta("Esta Seguro Desea Realizar Este Ajuste de Inventario?");

                if (resp == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    btnGrabar.Enabled = false;

                    int.TryParse(txtCodigoprod.Text, out productoId);
                    int.TryParse(txtCatCodigo.Text, out categoriaId);
                    temporalID = objUtil.GetTemporalID();

                    parms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                    parms.Add(new DataDB_ELR_NET.Parametro("categoriaId", categoriaId));
                    parms.Add(new DataDB_ELR_NET.Parametro("productoId", productoId));
                    parms.Add(new DataDB_ELR_NET.Parametro("esSoloNegativo", chkSoloExistenciaNegativa.Checked));
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_INVENTARIO_AJUSTE_TEMPORAL", parms);
                    if (spReturn < 0)
                    {
                        MostrarErrorTemporal();
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        objDB.confirmarTransaccion();
                        GetData();

                        txtCatCodigo.Enabled = false;
                        txtCodigoprod.Enabled = false;
                        chkSoloExistenciaNegativa.Enabled = false;
                        btnBuscarProducto.Enabled = false;
                        btnBuscarCaregoria.Enabled = false;
                        btnIniciar.Enabled = false;
                        btnLimpiar.Enabled = true;

                        if(DTDetalle != null) btnGrabar.Enabled = (DTDetalle.Rows.Count > 0);
                    }

                    Cursor = Cursors.Default;
                }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                txtCatCodigo.Enabled = true;
                txtCodigoprod.Enabled = true;
                chkSoloExistenciaNegativa.Enabled = true;
                btnBuscarCaregoria.Enabled = true;
                btnBuscarProducto.Enabled = true;
                btnIniciar.Enabled = true;
                btnGrabar.Enabled = false;
                btnLimpiar.Enabled = false;

                txtCodigoprod.Text = "0";
                txtDescProd.Text = "(TODOS)";
                chkSoloExistenciaNegativa.Checked = true;

                objDB.LimpiarDetalleTemporal(TablaDetalle, temporalID);
                GetData();
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

        public override bool GetData()
        {
            bool resultado = false;
            try
            {
                if(temporalID != "")
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                    DTDetalle = objDB.GetAll(TablaDetalle, -1, objDB.Filtros);

                    DataGridDetalle.AutoGenerateColumns = false;
                    DataGridDetalle.DataSource = DTDetalle.DefaultView;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void FormInventarioAjuste_Load(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = false;
            btnGrabar.Enabled = false;
        }

        public override int GrabarDatos()
        {
            int resultado = -1;
            int conteo = 0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                conteo = GetCount("Producto_Id", DTDetalle, "EnExistencia <> NuevaExistencia");
                if (conteo == 0) objUtil.MostrarMensajeAdvertencia("NO HA REALIZADO NINGUN AJUSTE");
                else
                {
                    resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Grabar este Ajuste?");
                    if(resp == DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;

                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_INVENTARIO_GRABA_AJUSTE", parms);
                        if(resultado <= 0)
                        {
                            MostrarErrorTemporal();
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            objUtil.MostrarMensajeInformacion("Ajuste Realizado de Forma Satisfactoria...");
                            btnLimpiar.PerformClick();
                        }

                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objDB.cancelarTransaccion();
                Cursor = Cursors.Default;
            }

            return resultado;
        }

        void GetCategoria(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormCategoriaProducto frm = new ELRMaestros.FormCategoriaProducto();

            try
            {
                codigo = codigo.Trim();
                if (codigo != "" && codigo != "0")
                {
                    SSQL = "SELECT TOP 1 Categoria_Id, Nombre FROM TCLASIFICADOR_PRODUCTOS_CATEGORIAS";
                    SSQL += " WHERE Cast(Categoria_Id as Varchar) = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Categoria_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre", fila0);
                }

                txtCatCodigo.Text = id;
                txtCategoria.Text = nombre;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarCaregoria_Click(object sender, EventArgs e)
        {
            GetCategoria();
        }

        private void txtCatCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCatCodigo.Text.Trim();

            if (e.KeyCode == Keys.F9) GetCategoria();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetCategoria(codigo);
        }
    }
}
