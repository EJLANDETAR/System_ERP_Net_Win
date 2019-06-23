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
    public partial class FormContaConfigurarCuentas : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTActivosTipos = null;
        DataTable DTActivos_Tabla = null;
        DataView DVActivosFijosCuentas = null;
        DataTable DTCuentasContables = null;
        DataTable DTCuentasBanco = null;
        DataTable DTTransCaja = null;
        DataTable DTCajas = null;
        DataTable DTEnlaces = null;
        DataTable DTEnlacesDetalle = null;
        DataView DVEnlacesDetalle = null;
        DataTable DTCategorias = null;
        DataTable DTCategorias_Tabla = null;
        DataView DVCategorias = null;

        public FormContaConfigurarCuentas()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            //return base.GetData();
            bool resultado = true;

            try
            {
                //Buscamos todas las Cuentas Auxiliares
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroIgualA("EsControl", "0");
                DTCuentasContables = objDB.GetAll("TCONTA_CATALOGO", -1);

                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                tabControl1.SelectedIndex = 0;



            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void cboTipoActivos_SelectedValueChanged(object sender, EventArgs e)
        {
            string tipoId = "0";
            try
            {
                DVActivosFijosCuentas.RowFilter = "";

                if (cboTipoActivos.SelectedValue != null)
                {
                    tipoId = cboTipoActivos.SelectedValue.ToString();
                    DVActivosFijosCuentas.RowFilter = "Tipo_Id = " + tipoId;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        private void GetCuentaContable(DataGridView senderGrid, string cuentaNo = "")
        {
            int index = 0;
            string nombreCampo = "";
            string cuentaContable = "";
            string SSQL = "";
            int valorUnico = 0;
            string nombreTabla = "";
            string columnaCuenta = "";
            string columnaUnico = "";


            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            //Vamos a Buscar la Cuenta Contable
            try
            {
                nombreTabla = "";

                frm.titulo = @"CUENTAS CONTABLES";
                frm.TablaOVista = "TCONTA_CATALOGO";
                frm.FiltroEstatico = "Empresa_Id  = " + EMPRESA_ID.ToString() + " And EsControl = 0";
                frm.columnas = new WinControl_ELR_NET.MyColumna[2];


                col = new WinControl_ELR_NET.MyColumna();
                col.NombreCampo = "Cuenta_Contable";
                col.HeaderText = "Cuenta Contable";
                col.Ancho = 140;
                frm.columnas[0] = col;
                frm.DefaultColumnaBusqueda = "Cuenta_Contable";

                col = new WinControl_ELR_NET.MyColumna();
                col.NombreCampo = "Descripcion";
                col.HeaderText = "Descripcion";
                col.Ancho = -1;
                frm.columnas[1] = col;

                frm.ShowDialog();

                if (frm.FilaSelecionada != null)
                {
                    this.Cursor = Cursors.WaitCursor;

                    //Buscamos la columna que Contiene la Fecha Contable
                    foreach (DataGridViewColumn item in senderGrid.Columns)
                    {
                        if (item.DataPropertyName.ToUpper() == "CUENTA_CONTABLE" && columnaCuenta.Trim() == "") columnaCuenta = item.Name;
                        if (item.DataPropertyName.ToUpper() == "UNICO" && columnaUnico.Trim() == "") columnaUnico = item.Name;

                        if (columnaCuenta != "" && columnaUnico != "") break;

                    }

                    cuentaContable = objUtil.GetAsString("Cuenta_Contable", frm.FilaSelecionada);
                    index = senderGrid.CurrentRow.Index;

                    senderGrid[columnaCuenta, index].Value = cuentaContable;

                    valorUnico = int.Parse(senderGrid[columnaUnico, index].Value.ToString());

                    if (senderGrid == dtgActivosFijosCuentas)
                    {
                        nombreCampo = senderGrid["Nombre_Campo", index].Value.ToString();

                        SSQL = " UPDATE TACTIVOS_FIJOS_TIPOS SET " + nombreCampo + " = '" + cuentaContable + "' ";
                        SSQL += " WHERE Unico = " + valorUnico.ToString();

                        objDB.EjecutarSQL(SSQL);
                    }
                    else if (senderGrid == dtgCategorias)
                    {
                        nombreCampo = senderGrid["Nombre_Campo_Categoria", index].Value.ToString();

                        SSQL = " UPDATE TCLASIFICADOR_PRODUCTOS_CATEGORIAS SET " + nombreCampo + " = '" + cuentaContable + "' ";
                        SSQL += " WHERE Unico = " + valorUnico.ToString();

                        objDB.EjecutarSQL(SSQL);
                    }
                    else if (senderGrid == dtgCuentasBanco) nombreTabla = "TBANCOS_CUENTAS_BANCARIAS";
                    else if (senderGrid == dtgTransCaja) nombreTabla = "TCAJAS_TIPO_TRANS";
                    else if (senderGrid == dtgCajas) nombreTabla = "TCAJAS";
                    else if (senderGrid == dtgEnlaceDetalle) nombreTabla = "TCONTA_ENLACES_CUENTAS";
                    else if (senderGrid == dtgTransBancarias) nombreTabla = "TBANCOS_TRANS_TIPOS";
                    

                    if (nombreTabla != "" && valorUnico > 0)
                    {

                        SSQL = " UPDATE " + nombreTabla + " Set Cuenta_Contable = '" + cuentaContable + "' ";
                        SSQL += " WHERE Unico = " + valorUnico.ToString();
                        objDB.EjecutarSQL(SSQL);
                    }

                    senderGrid.CurrentCell = senderGrid[columnaCuenta, index];

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        private void SenderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid;
            string valorUnico = "";
            DataRow fila0 = null;
            bool esSistema = false;
            int index = 0;

            try
            {
                senderGrid = (DataGridView)sender;

                if (senderGrid.RowCount > 0)
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) GetCuentaContable(senderGrid, "");
                    else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                    {
                        if (senderGrid == dtgEnlaceDetalle)
                        {
                            FormContaEnlaceCuentaR frm = new FormContaEnlaceCuentaR();

                            index = senderGrid.CurrentRow.Index;
                            valorUnico = senderGrid["UnicoEnlaceDetalle", index].Value.ToString();

                            fila0 = DTEnlacesDetalle.Select("Unico = " + valorUnico)[0];
                            esSistema = objUtil.GetAsBoolean("EsSistema", fila0);

                            if(esSistema && nombreUsuario.ToUpper() != "SYS.ADMIN")
                            {
                                objUtil.MostrarMensajeAdvertencia("CUENTAS INGRESADA POR EL USUARIO DEL SISTEMA, NO PODRA SER MODIFICADA POR OTRO USUARIO");
                                return;
                            }

                            frm.EMPRESA_ID = EMPRESA_ID;
                            frm.OFICINA_ID = OFICINA_ID;
                            frm.nombreUsuario = nombreUsuario;
                            frm.VALOR_ID = valorUnico;

                            frm.enlaceId = int.Parse(senderGrid["Enlace_Id", senderGrid.CurrentRow.Index].Value.ToString());

                            frm.EnEjecusion = true;

                            frm.ShowDialog();

                            if (frm.lOK)
                            {
                                RecargarEnlacesDetalles();
                                if (dtgEnlaceDetalle.RowCount - 1 >= index) dtgEnlaceDetalle.CurrentCell = dtgEnlaceDetalle["Codigo", index];
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgActivosFijosCuentas_SelectionChanged(object sender, EventArgs e)
        {
            string cuentaContable = "";
            string descripcionCuenta = "";

            try
            {
                if (dtgActivosFijosCuentas.RowCount > 0)
                {
                    cuentaContable = dtgActivosFijosCuentas["Cuenta_Contable", dtgActivosFijosCuentas.CurrentRow.Index].Value.ToString();
                    descripcionCuenta = GetDescripcionCuenta(cuentaContable);
                }
            }
            catch (Exception)
            {


            }

            txtActivosFijosDescripcion.Text = cuentaContable + " - " + descripcionCuenta;
        }

        string GetDescripcionCuenta(string cuentaContable)
        {
            string resultado = "";
            DataRow[] filas;

            try
            {
                if (DTCuentasContables != null)
                {
                    filas = DTCuentasContables.Select("Cuenta_Contable = '" + cuentaContable + "'");

                    if (filas.Count() > 0) resultado = objUtil.GetAsString("Descripcion", filas[0]);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tpActivosFijos) GetDataActivosFijos();
                if (tabControl1.SelectedTab == tpCuentasBancarias) GetDataCuentasBancarias();
                if (tabControl1.SelectedTab == tpTransCajas) GetTransCaja();
                if (tabControl1.SelectedTab == tpCuentasCajas) GetDataCajas();
                if (tabControl1.SelectedTab == tpCuentasEnlaces) GetDataEnlaces();
                if (tabControl1.SelectedTab == tpTransBancarias) GetTipoTrasBanco();
                if (tabControl1.SelectedTab == tpCategorias) GetDataCategorias();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetDataActivosFijos()
        {
            string SSQL = "";
            int valorUnico = 0;
            int tipoId = 0;
            string cuentaContable = "";
            DataRow nuevaFila = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DVActivosFijosCuentas != null) return;

                SSQL = " SELECT TOP 0 0 AS Unico, 0 as Tipo_Id, '' AS Nombre_Campo, '' as Descripcion, '' as Cuenta_Contable ";
                DTActivos_Tabla = objDB.GetSQL(SSQL);

                //Buscamos los tipos de activos fijos
                objDB.LimpiarFiltros();
                DTActivosTipos = objDB.GetAll("TACTIVOS_FIJOS_TIPOS", -1);

                foreach (DataRow fila in DTActivosTipos.Rows)
                {

                    valorUnico = objUtil.GetAsInt("Unico", fila);
                    tipoId = objUtil.GetAsInt("Tipo_Id", fila);

                    foreach (DataColumn item in DTActivosTipos.Columns)
                    {
                        if (!item.ColumnName.ToUpper().Contains("CUENTA_CONTABLE")) continue;
                        nuevaFila = DTActivos_Tabla.NewRow();
                        cuentaContable = objUtil.GetAsString(item.ColumnName, fila);
                        nuevaFila["Unico"] = valorUnico;
                        nuevaFila["Tipo_Id"] = tipoId;
                        nuevaFila["Nombre_Campo"] = item.ColumnName;
                        nuevaFila["Descripcion"] = item.ColumnName.Replace('_', ' ').ToUpper();
                        nuevaFila["Cuenta_Contable"] = cuentaContable;
                        DTActivos_Tabla.Rows.Add(nuevaFila);

                    }


                }

                dtgActivosFijosCuentas.RowTemplate.Height = 33;
                dtgActivosFijosCuentas.AutoGenerateColumns = false;
                DVActivosFijosCuentas = new DataView(DTActivos_Tabla);
                dtgActivosFijosCuentas.DataSource = DVActivosFijosCuentas;

                cboTipoActivos.DisplayMember = "Descripcion";
                cboTipoActivos.ValueMember = "Tipo_Id";
                cboTipoActivos.DataSource = DTActivosTipos.DefaultView;
                cboTipoActivos.DropDownStyle = ComboBoxStyle.DropDownList;
                cboTipoActivos.SelectedValue = "1";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void GetDataCuentasBancarias()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DTCuentasBanco != null) return;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTCuentasBanco = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1, objDB.Filtros);

                dtgCuentasBanco.RowTemplate.Height = 33;
                dtgCuentasBanco.AutoGenerateColumns = false;
                dtgCuentasBanco.DataSource = DTCuentasBanco.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void GetTransCaja()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DTTransCaja != null) return;

                objDB.LimpiarFiltros();
                DTTransCaja = objDB.GetAll("TCAJAS_TIPO_TRANS", -1);

                dtgTransCaja.RowTemplate.Height = 33;
                dtgTransCaja.AutoGenerateColumns = false;
                dtgTransCaja.DataSource = DTTransCaja.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void GetTipoTrasBanco()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DTTransCaja != null) return;

                objDB.LimpiarFiltros();
                DTTransCaja = objDB.GetAll("TBANCOS_TRANS_TIPOS", -1);

                dtgTransBancarias.RowTemplate.Height = 33;
                dtgTransBancarias.AutoGenerateColumns = false;
                dtgTransBancarias.DataSource = DTTransCaja.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void GetDataCajas()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DTCajas != null) return;

                objDB.LimpiarFiltros();
                DTCajas = objDB.GetAll("TCAJAS", -1);

                dtgCajas.RowTemplate.Height = 33;
                dtgCajas.AutoGenerateColumns = false;
                dtgCajas.DataSource = DTCajas.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void GetDataEnlaces()
        {
            string SSQL = "";
            try
            {
                if (DTEnlaces != null) return;

                SSQL = " SELECT 0 as Enlace_Id, '(TODOS)' as Descripcion ";
                SSQL += " UNION ALL";
                SSQL += " SELECT Enlace_Id, Descripcion From TCONTA_ENLACES where Enlace_Id > 0";

                DTEnlacesDetalle = objDB.GetAll("TCONTA_ENLACES_CUENTAS", -1);
                DVEnlacesDetalle = new DataView(DTEnlacesDetalle);
                dtgEnlaceDetalle.AutoGenerateColumns = false;
                dtgEnlaceDetalle.RowTemplate.Height = 33;
                dtgEnlaceDetalle.DataSource = DVEnlacesDetalle;

                DTEnlaces = objDB.GetSQL(SSQL);
                cboEnlace.DropDownStyle = ComboBoxStyle.DropDownList;
                cboEnlace.DisplayMember = "Descripcion";
                cboEnlace.ValueMember = "Enlace_Id";
                cboEnlace.DataSource = DTEnlaces;
                cboEnlace.SelectedValue = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        void RecargarEnlacesDetalles()
        {
            int valorId = 0;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DTEnlacesDetalle = objDB.GetAll("TCONTA_ENLACES_CUENTAS", -1);
                DVEnlacesDetalle = new DataView(DTEnlacesDetalle);
                dtgEnlaceDetalle.AutoGenerateColumns = false;
                dtgEnlaceDetalle.RowTemplate.Height = 33;
                dtgEnlaceDetalle.DataSource = DVEnlacesDetalle;

                if (cboEnlace.SelectedValue != null)
                {
                    valorId = int.Parse(cboEnlace.SelectedValue.ToString());
                    if (valorId > 0) DVEnlacesDetalle.RowFilter = "Enlace_Id = " + valorId;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboEnlace_SelectedValueChanged(object sender, EventArgs e)
        {
            filtrarCuentasEnlace();
        }

        void filtrarCuentasEnlace()
        {
            int valorId = 0;
            string filtro = "";
            string aBuscar = "";
            try
            {
                aBuscar = txtCodigoEnlace.Text.Trim();

                DVEnlacesDetalle.RowFilter = "";

                if (cboEnlace.SelectedValue != null)
                {
                    valorId = int.Parse(cboEnlace.SelectedValue.ToString());
                    if (valorId > 0) filtro = "Enlace_Id = " + valorId.ToString();
                }

                if(aBuscar != "")
                {
                    if (valorId > 0) filtro += " And Codigo like '%" + aBuscar + "%'";
                    else filtro = "Codigo like '%" + aBuscar + "%'";
                }

                if(filtro.Trim() != "")
                {
                    DVEnlacesDetalle.RowFilter = filtro;
                    if (dtgEnlaceDetalle.RowCount > 0)
                    {
                        dtgEnlaceDetalle.CurrentCell = dtgEnlaceDetalle["DescripcionEnlance", dtgEnlaceDetalle.CurrentRow.Index];
                        dtgEnlaceDetalle["DescripcionEnlance", dtgEnlaceDetalle.CurrentRow.Index].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormContaEnlaceCuentaR frm = new FormContaEnlaceCuentaR();
            string codigo = "";
            try
            {
                frm.EMPRESA_ID = EMPRESA_ID;
                frm.OFICINA_ID = OFICINA_ID;
                frm.nombreUsuario = nombreUsuario;

                if (cboEnlace.SelectedValue != null) frm.enlaceId = (int)cboEnlace.SelectedValue;

                frm.EnEjecusion = true;

                frm.ShowDialog();

                if (frm.lOK)
                {
                    RecargarEnlacesDetalles();
                    
                    //NOS POSICIONAMOS EN EL NUEVO REGISTRO
                    for (int i = 0; i < dtgEnlaceDetalle.RowCount; i++)
                    {
                        codigo = dtgEnlaceDetalle["Codigo", i].Value.ToString().ToUpper();

                        if(codigo.Equals(frm.codigo.Trim().ToUpper()))
                        {
                            dtgEnlaceDetalle.CurrentCell = dtgEnlaceDetalle["clnCuentaEnlace", i];
                            break;
                        }
                    }

                    
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormContaConfigurarCuentas_Load(object sender, EventArgs e)
        {
            btnGrabar.Visible = false;
        }

        private void cboCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            int categoriaId = 0;
            try
            {
                DVCategorias.RowFilter = "";

                if (cboCategorias.SelectedValue != null)
                {
                    categoriaId = int.Parse( cboCategorias.SelectedValue.ToString());

                    if(categoriaId > 0) DVCategorias.RowFilter = "Categoria_Id = " + categoriaId.ToString();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        void GetDataCategorias()
        {
            string SSQL = "";
            int valorUnico = 0;
            int categoriaId = 0;
            string cuentaContable = "";
            string descripcion = "";
            DataRow nuevaFila = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DVCategorias != null) return;

                SSQL = " SELECT TOP 0 0 AS Unico, 0 as Categoria_Id, '' AS Nombre_Campo, '' as Descripcion, '' as Cuenta_Contable ";
                DTCategorias_Tabla = objDB.GetSQL(SSQL);

                //Buscamos los tipos de Categias
                SSQL = " SELECT 0 as Unico, 0 as Categoria_Id, '(TODAS)' as Nombre, ";
                SSQL += " '' as Cuenta_Contable_Costo, '' as Cuenta_Contable_Gastos, '' as Cuenta_Contable_Inventario, '' Cuenta_Contable_Ingresos ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Unico, Categoria_Id, Nombre, ";
                SSQL += " Cuenta_Contable_Costo, Cuenta_Contable_Gastos, Cuenta_Contable_Inventario, Cuenta_Contable_Ingresos ";
                SSQL += " FROM [TCLASIFICADOR_PRODUCTOS_CATEGORIAS] ";
                DTCategorias = objDB.GetSQL(SSQL);

                foreach (DataRow fila in DTCategorias.Rows)
                {

                    valorUnico = objUtil.GetAsInt("Unico", fila);
                    categoriaId = objUtil.GetAsInt("Categoria_Id", fila);
                    descripcion = objUtil.GetAsString("Nombre", fila);

                    if (categoriaId > 0)
                    {
                        foreach (DataColumn item in DTCategorias.Columns)
                        {
                            if (!item.ColumnName.ToUpper().Contains("CUENTA_CONTABLE")) continue;
                            nuevaFila = DTCategorias_Tabla.NewRow();
                            cuentaContable = objUtil.GetAsString(item.ColumnName, fila);
                            nuevaFila["Unico"] = valorUnico;
                            nuevaFila["Categoria_Id"] = categoriaId;
                            nuevaFila["Nombre_Campo"] = item.ColumnName;
                            nuevaFila["Descripcion"] = descripcion + ", " + item.ColumnName.Replace('_', ' ').ToUpper();
                            nuevaFila["Cuenta_Contable"] = cuentaContable;
                            DTCategorias_Tabla.Rows.Add(nuevaFila);

                        }
                    }


                }

                dtgCategorias.RowTemplate.Height = 33;
                dtgCategorias.AutoGenerateColumns = false;
                DVCategorias = new DataView(DTCategorias_Tabla);
                dtgCategorias.DataSource = DVCategorias;

                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "Categoria_Id";
                cboCategorias.DataSource = DTCategorias.DefaultView;
                cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
                cboCategorias.SelectedValue = "0";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txtCodigoEnlace_TextChanged(object sender, EventArgs e)
        {
            filtrarCuentasEnlace();
        }
    }
}
