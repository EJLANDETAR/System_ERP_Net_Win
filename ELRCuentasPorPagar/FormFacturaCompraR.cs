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
    public partial class FormFacturaCompraR : WinControl_ELR_NET.ELRFormRegistro
    {

        int tipoEntidad = 0;
        int tipoNCF = 0;
        bool ORDEN_REQUIERRE_APROBACION = false;
        bool isChangeCodigoP = false;

        public FormFacturaCompraR()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public override void CalcularLineaDetalle()
        {
            //base.CalcularLineaDetalle();
            double cantidad = 0, precio = 0, tasaItbis = 0, itbis = 0, subTotal = 0, total = 0;
            bool esExcentoItbis = false;
            bool precioConItbis = false;
            string valor;
            int valorId = 0;
            DataRow fila0;

            int index = 0;
            try
            {
                index = DataGridDetalle.CurrentRow.Index;
                valorId = int.Parse(DataGridDetalle["ItemNumero", index].Value.ToString());
                fila0 = DTDetalle.Select("ItemNumero = " + valorId)[0];
                valorId = objUtil.GetAsInt("Producto_Id", fila0);

                if (valorId > 0)
                {

                    cantidad = objUtil.GetAsDouble("Cantidad", fila0);
                    precio = objUtil.GetAsDouble("Precio", fila0);

                    valor = DataGridDetalle["EsExcentoItbis", index].Value.ToString();
                    esExcentoItbis = objUtil.GetAsBoolean("EsExcentoItbis", fila0);
                    precioConItbis = objUtil.GetAsBoolean("PrecioConItbis", fila0);

                    if (esExcentoItbis) tasaItbis = 0;
                    else tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", fila0);

                    subTotal = Math.Round( cantidad * precio, 2);
                    if ((precioConItbis) && (tasaItbis > 0))
                    {
                        itbis = precio - Math.Round( (precio / (1 + tasaItbis / 100.0)), 2);
                        precio = precio - itbis;
                        subTotal = Math.Round(cantidad * precio, 2);
                        itbis = cantidad * itbis;
                    }
                    else itbis = (subTotal * tasaItbis) / 100.0;
                    total = subTotal + itbis;

                    fila0["Sub_Total"] = subTotal;
                    fila0["Itbis"] = itbis;
                    fila0["Total"] = total;
                }
                else
                {
                    fila0["Cantidad"] = 0;
                    fila0["Precio"] = 0;
                    fila0["Sub_Total"] = 0;
                    fila0["Itbis"] = 0;
                    fila0["Total"] = 0;
                }


                TotalizarDetalle();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Calcular Linea Detalle, " + ex.Message);
            }
        }

        public override void TotalizarDetalle()
        {
            //base.TotalizarDetalle();
            double subTotal = 0, itbis = 0, total = 0;
            try
            {
                subTotal = GetSumDetalle("Sub_Total");
                itbis = GetSumDetalle("Itbis");
                total = GetSumDetalle("Total");

                txtSubTotal.Text = subTotal.ToString("N2");
                txtTotalItbis.Text = itbis.ToString("N2");
                txtMonto.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Totalizar Detalle, " + ex.Message);
            }
        }

        void GetSuplidor(string codigo)
        {
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();
            DataTable DTSuplidores;
            DataRow DRSuplidor = null;
            string aBuscar = "";
            string cedulaRNC = "";


            try
            {
                //Limpiamos
                txtCodigoSup.Text = "0";
                txtNombreSuplidor.Text = "";

                SetValorEncabezado("Tipo_NCF", tipoNCF);


                if (codigo != "")
                {
                    aBuscar = "( Cast(Entidad_Id as Varchar) ='" + codigo + "'";
                    aBuscar += " Or Replace(cedulaRNC, '-', '') = '" + codigo.Replace('-', ' ') + "')";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsSuplidor", "1");
                    objDB.AddFiltroPersonalizado(aBuscar);
                    DTSuplidores = objDB.GetAll("VENTIDADES", 1, objDB.Filtros);
                    if (DTSuplidores.Rows.Count > 0) DRSuplidor = DTSuplidores.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.Limite = 200;
                    frm.esBusqueda = true;
                    frm.FiltroEstatico = "EsSuplidor = 1";

                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) DRSuplidor = frm.filaSelecionada;
                }

                if (DRSuplidor != null)
                {
                    tipoEntidad = int.Parse(DRSuplidor["Tipo_Entidad"].ToString());
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", DRSuplidor, 0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", DRSuplidor);

                    SetValorEncabezado("Tipo_NCF", tipoNCF);
                    SetValorEncabezado("CedulaRNC", cedulaRNC);

                    if ((tipoEntidad >= 2) && (tipoNCF <= 2)) SetValorEncabezado("Tipo_NCF", 1);
                    else if ( (tipoEntidad <= 1) && (tipoNCF <= 0) ) SetValorEncabezado("Tipo_NCF", 11);

                    txtCodigoSup.Text = DRSuplidor["Entidad_Id"].ToString();
                    txtNombreSuplidor.Text = DRSuplidor["Nombre_Completo"].ToString();
                    cboTipoNCF.SelectedValue = tipoNCF;
                    

                    if (txtFacturaNO.Enabled) txtFacturaNO.Focus();
                    else txtNombreSuplidor.Focus();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Suplidor, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                
            }
        }

        private void btnBuscarSuplidor_Click(object sender, EventArgs e)
        {
            GetSuplidor("");
        }

        private void txtCodigoSup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9) GetSuplidor("");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigoSup_Leave(object sender, EventArgs e)
        {
            string codigo = "";
            try
            {
                codigo = txtCodigoSup.Text.Trim();
                if (codigo != "") GetSuplidor(codigo);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboMoneda_SelectedValueChanged(object sender, EventArgs e)
        {
            double tasaCambio = 1.0;
            string codigo = "";
            DataRow fila0 = null;
            try
            {

                if (cboMoneda.SelectedValue != null)
                {
                    codigo = cboMoneda.SelectedValue.ToString();
                    fila0 = cboMoneda.data.Select("Codigo = '" + codigo + "'")[0];
                    tasaCambio = objUtil.GetAsDouble("Valor_Compra", fila0);
                }

                txtTasaCambio.Text = tasaCambio.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            GetProducto(1);

        }

        private void AddItem()
        {
            DataRow MyFila;
            double precioLista, precioSinItbis, tasaItbis, itbis = 0, cantidad = 1;
            double subTotal = 0, total = 0;
            bool esPrecioConItbis = true, esExcentoItbis = false;

            try
            {           
                cantidad = objUtil.ConvertirANumero(txtCantidad.Text);
                precioLista = objUtil.ConvertirANumero(txtPrecio.Text);
                precioSinItbis = precioLista;
                itbis = 0;

               
                if (drProducto != null)
                {
                    tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", drProducto);
                    esExcentoItbis = objUtil.GetAsBoolean("EsExcentoItbis", drProducto);
                    if (esExcentoItbis) tasaItbis = 0;

                    if (cantidad <= 0)
                    {
                        objUtil.MostrarMensajeAdvertencia("LA CANTIDAD DEBE SER MAYOR A CERO(0)");
                        txtCantidad.Focus();
                        return;
                    }

                    //CALCULAMOS PRECIO SIN EL ITEBIS
                    if (tasaItbis > 0)
                    {
                        precioSinItbis = Math.Round(precioSinItbis / (1 + tasaItbis / 100.0), 2);
                        itbis = precioLista - precioSinItbis;
                    }


                    subTotal = cantidad * precioSinItbis;
                    itbis = cantidad * itbis;
                    total = cantidad * precioLista;

                    MyFila = DTDetalle.NewRow();
                    MyFila["Producto_Id"] = drProducto["Producto_Id"];
                    MyFila["Descripcion"] = drProducto["Nombre_Corto"];
                    MyFila["Categoria_Id"] = drProducto["Categoria_Id"];
                    MyFila["UMedida_Id"] = drProducto["UMedida_Id"];
                    MyFila["Cantidad"] = cantidad;
                    MyFila["Precio"] = Math.Round(precioLista, 2);
                    MyFila["Sub_Total"] = Math.Round(subTotal, 2);
                    MyFila["Descuento"] = 0;
                    MyFila["Tasa_Itbis"] = Math.Round(tasaItbis, 2);
                    MyFila["Itbis"] = Math.Round(itbis, 2);
                    MyFila["Total"] = Math.Round(total, 2);
                    MyFila["EsExcentoItbis"] = esExcentoItbis;
                    MyFila["PrecioConItbis"] = esPrecioConItbis;

                    AgregarLineaDetalle(MyFila, "Identificador_Id");

                    txtCodigoProducto.Text = "";
                    txtCantidad.Text = "1";
                    txtPrecio.Text = "0.00";
                    drProducto = null;
                    btnAgregarItem.Enabled = false;
                    lblProdDescripcion.BackColor = SystemColors.Control;
                    lblProdDescripcion.Text = @"NOMBRE/DESCRIPCION ITEM VENTA";

                    txtCodigoProducto.Focus();

                }


            }
            catch (Exception ex)
            {

                lblProdDescripcion.Text = "ERROR: " + ex.Message;
                lblProdDescripcion.BackColor = Color.Red;
            }

        }

        void GetProducto(int tipo = 0)
        {
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();
            Int32 codigoNum = 0;
            DataTable DTProductos = null;
            string filtro = "";
            string codigo = "";
            try
            {
                Cursor = Cursors.WaitCursor;
                codigo = txtCodigoProducto.Text.Trim();
                Int32.TryParse(codigo, out codigoNum);
                lblProdDescripcion.BackColor = SystemColors.Control;
                isChangeCodigoP = false;
                drProducto = null;

                if (tipo == 0)
                {
                    codigo = codigo.Trim();
                    filtro = "(Cast(Producto_Id as Varchar) = '" + codigoNum.ToString() + "'";
                    filtro += " Or Codigo_Barra = '" + codigo + "')";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsCompra", "1");
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroPersonalizado(filtro);

                    DTProductos = objDB.GetAll("VCATEGORIA_PRODUCTOS", 1, objDB.Filtros);
                    if (DTProductos.Rows.Count > 0)
                    {
                        drProducto = DTProductos.Rows[0];
                        txtCodigoProducto.Text = "";
                    }
                }

                if (tipo == 1 || (tipo == 0 && codigo != "" && drProducto == null && codigoNum <= 0))
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.Limite = 200;
                    frm.esBusqueda = true;
                    frm.textoABuscar = codigo;
                    frm.FiltroEstatico = "EsActivo = 1 And EsCompra = 1";

                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) drProducto = frm.filaSelecionada;
                }

                if(drProducto != null)
                {
                    lblProdDescripcion.Text = objUtil.GetAsString("Nombre_Corto", drProducto);
                    txtCodigoProducto.Text = objUtil.GetAsString("Producto_Id", drProducto);
                    lblProdDescripcion.BackColor = Color.Green;
                    txtCantidad.Text = "1";
                    txtPrecio.Text = "0";
                    btnAgregarItem.Enabled = true;
                    txtCantidad.Focus();
                }
                else
                {
                    lblProdDescripcion.Text = " ITEM CON CODIGO: " + codigo + ", NO EXISTE O NO ESTA DISPONIBLE PARA COMPRA";
                    lblProdDescripcion.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {

                lblProdDescripcion.Text = " ERROR: " + ex.Message;
                lblProdDescripcion.BackColor = Color.Red;
            }
            finally
            {
                Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        public override bool ValidarDatos()
        {
            bool resultado = false;
            int tipoNCF = 0;
            FormFacturaCompraOtrosCampos frm = new FormFacturaCompraOtrosCampos();

            try
            {
                resultado = base.ValidarDatos();

                if (cboTipoNCF.SelectedValue != null) tipoNCF = int.Parse( cboTipoNCF.SelectedValue.ToString());

                if (txtFacturaNO.Enabled && txtFacturaNO.Text.Trim() == "")
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Indicar el Numero de Factura de Compra");
                    txtFacturaNO.Focus();
                    return false;
                }

                if (txtNCF.Enabled && txtNCF.Text.Trim().Length != 11 && tipoNCF > 0)
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Indicar el Numero de Comprobante Fiscal Valido");
                    txtNCF.Focus();
                    return false;
                }

                //COMPLETAMOS OTROS CAMPOS
                frm.nombreUsuario = nombreUsuario;
                frm.fila0 = DSDatos.Tables[0].Rows[0];
                frm.ShowDialog();
                if (!frm.lOK) return false;


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void dtgDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(DataGridDetalle.RowCount > 0)
                {
                    if(DataGridDetalle.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        EliminarLineaDetalleTemp();
                    }
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
            DateTime fecha = DateTime.Now.Date;
            try
            {
                resultado = base.GetData();

                if (resultado && esNuevo)
                {
                    dtpFechaFactura.Value = fecha;
                    dtpFechaVence.Value = fecha;
                    dtpFecha.Value = fecha;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void cboTipoNCF_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoNCF.SelectedValue != null)
                {
                    tipoNCF = int.Parse(cboTipoNCF.SelectedValue.ToString());
                }

                /*txtFacturaNO.Enabled = (tipoEntidad > 1) || (tipoNCF == 1);
                dtpFechaFactura.Enabled = (tipoEntidad > 1) || (tipoNCF <= 1);
                txtNCF.Enabled = (tipoEntidad > 1 || tipoNCF == 1);
                dtpFechaVence.Enabled = true;
                */
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (isChangeCodigoP) GetProducto(0);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter) GetProducto(0);
                else if (e.KeyCode == Keys.F9) GetProducto(1);
                else isChangeCodigoP = true;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void AgregarLineaVacia()
        {
            GetProducto();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            FormOrdCompras frm = new FormOrdCompras();
            int id = 0, index;
            int spReturn = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.EsAgregar = false;
                frm.EsModificar = false;
                frm.Limite = 200;
                frm.esBusqueda = true;
                frm.FiltroEstatico = "Modulo = 'ORD' and EsNulo = 0 And IsNull(Cantidad_Pendiente, 0) > 0 ";

                if (ORDEN_REQUIERRE_APROBACION) frm.FiltroEstatico += " And Fecha_Aprobado Is Not Null And Fecha_Rechazado Is Null";

                frm.EnEjecusion = true;

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    index = dtgDetalle.RowCount;

                    id = objUtil.GetAsInt("CXP_Id", frm.filaSelecionada);

                    //Ejecutamos el SP para Cargar al Temporal
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    parms.Add(new DataDB_ELR_NET.Parametro("Id", id));
                    parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_COMPRA_DETALLES_ATEMPORAL", parms);
                    if (spReturn < 0) MostrarErrorTemporal();
                    else
                    {
                        //RECARGAMOS DATA DETALLE
                        objDB.confirmarTransaccion();
                        objDB.LimpiarFiltros();
                        objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                        DTDetalle = objDB.GetAll(TablaDetalle, -1, objDB.Filtros);
                        
                        dtgDetalle.DataSource = DTDetalle;

                        for (int i = 0; i < dtgDetalle.RowCount; i++)
                        {
                            dtgDetalle.CurrentCell = dtgDetalle["Cantidad", i];
                            CalcularLineaDetalle();
                        }

                        TotalizarDetalle();

                        //Buscamos la Datos del suplidor
                        GetSuplidor(spReturn.ToString());
                    }


                }
            }
            catch (Exception ex)
            {

                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        private void FormFacturaCompraR_Load(object sender, EventArgs e)
        {
            string valorVariable = "";

            if (EnEjecusion)
            {
                //BUSCAMOS EL VALOR DE VARIABLE QUE INDICA SI ORDEN DE COMPRA REQUIERE APROBACION
                valorVariable = objUtil.GetValorVariable("ORDEN_COMPRA_REQUIERRE_APROBACION", DTVariablesSYS, "1");
                valorVariable = valorVariable.ToUpper();
                metodoImp = 3;

                ORDEN_REQUIERRE_APROBACION = (valorVariable == "1" || valorVariable == "TRUE");

                //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
                addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto");
                addButtonAMenuLateral("ELRMaestros.FormProductos", "Productos/Servicios");
                addButtonAMenuLateral("ELRMaestros.FormEntidadesIndex", "Suplidores");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormAnularFacturaCompra", "Anular compra");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormInventarioAjuste", "Ajuste Inventario");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormCXP", "Abono o pago CXP");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormOtrosGastos");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormGastosFijosGenerar");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormGastosMenores");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII606", "606 DGII");
            }
        }

        private void txtNCF_TextChanged(object sender, EventArgs e)
        {
            string valor = "";
            int tipo = 0;
            try
            {
                valor = txtNCF.Text.Trim();
                if(valor.Length >= 3)
                {
                    int.TryParse(valor.Substring(1, 2), out tipo);
                    cboTipoNCF.SelectedValue = tipo;
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showEditEntidad();
        }
    }
}
