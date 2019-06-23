using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormFactura : WinControl_ELR_NET.ELRFormRegistro
    {

        int tipoNCF = 0;
        string nombreNCF = "";
        string telefonos = "";
        string cedulaRNC = "";
        string direccion = "";
        bool isChangeCodigoP = false;

        public FormFactura()
        {
            InitializeComponent();
        }

        private void addItem()
        {
            DataRow MyFila;
            double precioLista = 0, precioSinItbis = 0, tasaItbis = 0, itbis = 0, cantidad = 1;
            double subTotal = 0, total = 0;
            bool esPrecioConItbis = true, esExcentoItbis = false, esOferta = false;
            string nivelPrecio = "R";

            try
            {
                nivelPrecio = "R";
                if (drCliente != null) nivelPrecio = nivelPrecio = objUtil.GetAsString("Nivel_Precio", drCliente).ToUpper(); ;
                cantidad = objUtil.ConvertirANumero(txtCantidad.Text);

                if (drProducto != null)
                {
                    tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", drProducto);

                    if(nivelPrecio == "A") precioLista = objUtil.GetAsDouble("PrecioA", drProducto);
                    else if (nivelPrecio == "B") precioLista = objUtil.GetAsDouble("PrecioB", drProducto);
                    else if (nivelPrecio == "C") precioLista = objUtil.GetAsDouble("PrecioC", drProducto);

                    if (nivelPrecio == "R" || precioLista <= 0) precioLista = objUtil.GetAsDouble("PrecioR", drProducto);

                    esExcentoItbis = objUtil.GetAsBoolean("EsExcentoItbis", drProducto);
                    esOferta = objUtil.GetAsBoolean("EsOferta", drProducto);
                    if (esOferta)
                    {
                        precioLista = objUtil.GetAsDouble("PrecioO", drProducto);
                        nivelPrecio = "O";
                    }

                    precioSinItbis = precioLista;

                    if (cantidad <= 0)
                    {
                        objUtil.MostrarMensajeAdvertencia("LA CANTIDAD DEBE SER MAYOR A CERO(0)");
                        txtCantidad.Focus();
                        return;
                    }

                    if (tipoNCF <= 0 || esExcentoItbis) tasaItbis = 0;

                    //CALCULAMOS PRECIO SIN EL ITEBIS
                    if (tasaItbis > 0)
                    {
                        precioSinItbis = Math.Round(precioLista / (1 + tasaItbis / 100.0), 2);
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
                    MyFila["Precio_Sin_Itbis"] = Math.Round(precioSinItbis, 2);
                    MyFila["Precio"] = Math.Round(precioLista, 2);
                    MyFila["Sub_Total"] = Math.Round(subTotal, 2);
                    MyFila["Descuento"] = 0;
                    MyFila["Tasa_Itbis"] = Math.Round(tasaItbis, 2);
                    MyFila["Itbis"] = Math.Round(itbis, 2);
                    MyFila["Monto"] = Math.Round(total, 2);
                    MyFila["EsOferta"] = esOferta;
                    MyFila["Nivel_Precio"] = nivelPrecio;
                    MyFila["EsExcentoItbis"] = esExcentoItbis;
                    MyFila["PrecioConItbis"] = esPrecioConItbis;

                    AgregarLineaDetalle(MyFila);
                    

                    txtBusquedaProducto.Text = "";
                    txtCantidad.Text = "1";

                    drProducto = null;

                    txtBusquedaProducto.Focus();

                }

            }
            catch (Exception ex)
            {

                lblMensajeError.Visible = true;
                lblMensajeError.Text = "ERROR: " + ex.Message;
                toolTip1.SetToolTip(lblMensajeError, lblMensajeError.Text);
            }
            finally
            {
                txtBusquedaProducto.Focus();
            }

        }

        void getProducto(int tipo = 0)
        {
            DataTable DTProducto = null;
            string aBuscar = "";
            double gramos = 0, cantidad = 1;
            float codigoNumeric = 0;
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();
            string codigo = "";

            try
            {
                lblMensajeError.Visible = false;
                isChangeCodigoP = false;
                codigo = txtBusquedaProducto.Text.Trim();
                float.TryParse(codigo, out codigoNumeric);
                drProducto = null;
                aBuscar = codigo.Trim();
                objDB.LimpiarFiltros();

                if (tipo == 0)
                {
                    objDB.AddFiltroIgualA("EsVenta", "1");
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    if (codigo.Length > 5 && codigoNumeric > 0)
                    {
                        if (codigo.Substring(0, 2) == "20")
                        {
                            aBuscar = codigo.Substring(2, 5);
                            gramos = double.Parse(codigo.Substring(7, 5));
                            cantidad = gramos * 0.00220462262;
                            txtCantidad.Text = cantidad.ToString("N2");
                        }
                    }

                    if (aBuscar != "")
                    {
                        objDB.AddFiltroPersonalizado("( Cast(Producto_Id as Varchar) = '" + aBuscar + "' Or Codigo_Barra = '" + aBuscar + "' )");
                        DTProducto = objDB.GetAll("VCATEGORIA_PRODUCTOS", 1, objDB.Filtros);
                    }

                    if (DTProducto != null)
                    {
                        if (DTProducto.Rows.Count > 0) drProducto = DTProducto.Rows[0];
                    }
                }

                if (tipo == 1 || (tipo == 0 && codigo != "" && drProducto == null && codigoNumeric <= 0))
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.FiltroEstatico = "EsActivo = 1 And EsVenta = 1";
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.textoABuscar = txtBusquedaProducto.Text.Trim();
                    frm.ShowDialog();

                    if (frm.filaSelecionada != null)
                    {
                        drProducto = frm.filaSelecionada;
                        txtBusquedaProducto.Text = objUtil.GetAsString("Producto_Id", drProducto, "0");
                    }
                }


                if (drProducto != null) addItem();
                else if (codigo.Trim() != "")
                {
                    lblMensajeError.Visible = true;
                    lblMensajeError.Text = " ITEM CON CODIGO: " + codigo + ", NO EXISTE";
                    toolTip1.SetToolTip(lblMensajeError, lblMensajeError.Text);
                }

            }
            catch (Exception ex)
            {
                lblMensajeError.Visible = true;
                lblMensajeError.Text = " ERROR: " + ex.Message;
                toolTip1.SetToolTip(lblMensajeError, lblMensajeError.Text);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

            getProducto(1);
        }

        public override void OnEdit(string titulo)
        {
            FormBusqFacturaEdit frm = new FormBusqFacturaEdit();
            string id = "";
            try
            {
                frm.nombreUsuario = nombreUsuario;
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.cajaNo = cajaId;
                frm.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;

                frm.ShowDialog();
                VALOR_ID = "0";
                if (frm.filaSelecionada != null)
                {
                    id = objDB.GetAsString("Identificador_Id", frm.filaSelecionada);
                    if (CargarATemporal(id)) VALOR_ID = id;
                }
                else BorrarTemporales();

                GetData();
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

        private void FormFactura_Load(object sender, EventArgs e)
        {
            try
            {
                if (EnEjecusion)
                {
                    NombreReporte = "rptFactura";

                    lblNombreEmpresa.BackColor = coloP;
                    lblNombreEmpresa.Text = NOMBRE_EMPRESA_OFICINA;
                    btnAplicarDevolucion.BackColor = coloP;
                    
                    //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
                    addBtnLateralThis("NUEVA FACTURA");
                    addButtonAMenuLateral("ELRConsultasReportes.FormConsultaPrecioVenta");
                    addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto");
                    addButtonAMenuLateral("ELRMaestros.FormProductos");
                    addButtonAMenuLateral("ELRMaestros.FormEntidadesIndex", "Clientes");
                    addButtonAMenuLateral("ELRFacturas.FormFacturaReImprimir");
                    addButtonAMenuLateral("ELRFacturas.FormAnularFactura");
                    addButtonAMenuLateral("ELRFacturas.FormFactCobroPorGrupo", "Abono o pago");
                    addButtonAMenuLateral("ELRFacturas.FormCajaReciboOtrosIngresos");
                    addButtonAMenuLateral("ELRMaestros.FormEmpleados", "Empleados - Vendedores");
                    addButtonAMenuLateral("ELRFacturas.FormCotizaciones");
                    addButtonAMenuLateral("ELRFacturas.FormVentasNotasCreditos");
                    addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII607", "607 DGII");
                    addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII608", "608 DGII");
                    addButtonAMenuLateral("ELRConsultasReportes.FormVentasPorFecha");
                    addButtonAMenuLateral("ELRConsultasReportes.FormVentasConBeneficios");
                    addButtonAMenuLateral("ELRConsultasReportes.FormVentasPorProductos");
                    addButtonAMenuLateral("ELRConsultasReportes.FormVentasDetallePorCliente");
                    addButtonAMenuLateral("ELRConsultasReportes.FormDashboardVentas");
                    addBtnLateralEdit("Modificar Factura");

                    txtCantidad.Focus();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorItemNumero = 0;
            DataRow MyFila = null;
            FormFacturaEditItem frmEdit = new FormFacturaEditItem();

            try
            {
                var senderGrid = (DataGridView)sender;

                if (e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorItemNumero = int.Parse(senderGrid["ItemNumero", senderGrid.CurrentRow.Index].Value.ToString());

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) EliminarLineaDetalleTemp();
                    else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                    {
                        MyFila = DTDetalle.Select("ItemNumero = " + valorItemNumero.ToString())[0];
                        frmEdit.MyFila = MyFila;

                        frmEdit.ShowDialog();

                        if (frmEdit.lOK)
                        {
                            if (ActualizarDetalleFormRow(MyFila, "ItemNumero")) TotalizarDetalle();
                            else MyFila.RejectChanges();
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override int GrabarDatos()
        {
            int resultado = -1;
            FormAmortizacionR frm = null;
            ELRLogicaNegocio.Prestamos objPrestamo = null;
            DataRow MyFila = null;
            string cedulaRNC = "";
            int entidadId = 0;
            string amortAutom = "";
            string valorVariable = "";
            bool noAmortizacion = false;

            try
            {

                if (drCliente != null)
                {
                    cedulaRNC = drCliente["CedulaRNC"].ToString();
                    entidadId = objUtil.GetAsInt("Entidad_Id", drCliente);
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", drCliente);
                    direccion = objUtil.GetAsString("Direccion", drCliente);
                    PermiteACredito = objUtil.GetAsBoolean("EsCreditoDisponible", drCliente);
                }

                SetValorEncabezado("Entidad_Id", entidadId);
                SetValorEncabezado("CedulaRNC", cedulaRNC);
                SetValorEncabezado("Tipo_NCF", tipoNCF);
                SetValorEncabezado("Telefonos", telefonos.Trim());
                SetValorEncabezado("Direccion", direccion);

                resultado = base.GrabarDatos();

                //MOSTRAMOS EL FORMULARIO PARA REALIZAR AMORTIZACION
                if ((resultado > 0) && (aCredito > 0))
                {
                    //SI SE VA A AMORTIZAR LA FACTURA DE FORMA AUTOMATICO
                    amortAutom = objUtil.GetValorVariable("AMORTIZA_FACTURA_AUTOMATICA", DTVariablesSYS, "0").ToUpper();
                    valorVariable = objUtil.GetValorVariable("NO_REQUIERE_AMORTIZACION", DTVariablesSYS, "0").ToUpper();
                    noAmortizacion = (valorVariable == "1") || (valorVariable == "TRUE");

                    if (noAmortizacion == true) amortAutom = "NO APLICA";

                    if ((amortAutom == "1") || (amortAutom == "TRUE"))
                    {
                        objPrestamo = new ELRLogicaNegocio.Prestamos();
                        MyFila = objPrestamo.GetDocumentoPorAmortizar(objDB, resultado, "VC");

                        frm = new FormAmortizacionR();

                        frm.cajaId = 0;
                        frm.nombreUsuario = nombreUsuario;
                        frm.EsConTemporal = true;
                        frm.VALOR_ID = resultado.ToString();
                        frm.EMPRESA_ID = EMPRESA_ID;
                        frm.OFICINA_ID = OFICINA_ID;
                        frm.ValorParmTipo = "VC";

                        frm.drRegistroSel = MyFila;

                        frm.EnEjecusion = true;

                        frm.ShowDialog();
                    }
                }

                if (resultado > 0)
                {

                    drCliente = null;
                    GetEntidad("1");
                    lblMontoDevolucion.Text = "0.00";
                    lblAPagar.Text = "0.00";
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message, "ERROR AL CARGAR AMORTIZACION");
            }
            finally
            {
                if (frm != null) frm.Dispose();
                MyFila = null;
                objPrestamo = null;
            }
            return resultado;
        }

        private void txtBusquedaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public override void ImprimirTicket()
        {
            ELRLogicaNegocio.Facturas lFactura = new ELRLogicaNegocio.Facturas();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lFactura.MyData = DTVistaData;
                lFactura.NombreImpresora = impresoraDefault;
                lFactura.numeroCopias = IMPRIME_TICKET_COPIA;

                //IMPRIMIMOS EL TICKET
                lFactura.ImprimirTicket();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Imprimir: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                lFactura = null;
            }

        }

        public override void ImprimirEnMatricial()
        {
            ELRLogicaNegocio.Facturas lFactura = new ELRLogicaNegocio.Facturas();
            try
            {
                lFactura.MyData = DTVistaData;
                lFactura.NombreImpresora = impresoraDefault;
                lFactura.logo = logoEmpresa;

                //MANDAMOS a Imprimir en un Thread
                Thread tAux = new Thread(new ThreadStart(lFactura.PrintMatricial80));
                tAux.Start();

                while (!tAux.IsAlive) ;


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            string ncf = "";
            bool resultado = false;

            try
            {
                resultado = base.GetData();

                if (resultado)
                {
                   
                    DSDatos.Tables[0].Rows[0]["Vendedor_Id"] = 0;
                    ncf = objDB.GetAsString("NCF", DSDatos.Tables[0].Rows[0]);
                    txtCodigoCliente.Enabled = (ncf.Trim() == "");
                    btnBuscarEntidad.Enabled = (ncf.Trim() == "");
                    if (esNuevo)
                    {
                        GetEntidad("1");

                        txtCantidad.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);

                Close();
            }

            return resultado;
        }

        private void dtgvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Tab)
                {
                    if (dtgvDetalle.RowCount <= 0) txtBusquedaProducto.Focus();
                    else if (txtDireccion.Enabled) txtDireccion.Focus();
                    else if (btnGrabar.Enabled) btnGrabar.Focus();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void btnAplicarDevolucion_Click(object sender, EventArgs e)
        {
            FormFacturaAplicarDevolucion frm = new FormFacturaAplicarDevolucion();
            try
            {
                frm.ShowDialog();

                txtDevolucionNo.Text = frm.Id.ToString();
                lblMontoDevolucion.Text = frm.monto.ToString("N2");

                SetValorEncabezado("Nota_Credito_No", frm.Id);
                SetValorEncabezado("Nota_Credito_Monto", frm.monto);

                TotalizarDetalle();

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

        public override void TotalizarDetalle()
        {
            double monto = 0, montoNotaCredito = 0, montoAPagar;
            try
            {
                base.TotalizarDetalle();
                monto = GetSumDetalle("Monto", "ItemNumero > 0");
                montoNotaCredito = objUtil.GetAsDouble("Nota_Credito_Monto", DSDatos.Tables[0].Rows[0]);
                montoAPagar = monto - montoNotaCredito;
                lblAPagar.Text = montoAPagar.ToString("N2");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgvDetalle_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9) GetEntidad("");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetEntidad(string codigo = "")
        {
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();
            DataTable DTEntidades;
            string aBuscar = "";

            try
            {
                codigo = codigo.Trim();
                if (codigo != "")
                {
                    aBuscar = "(Cast(Entidad_Id as Varchar) = '" + codigo + "'";
                    aBuscar += " Or Replace(CedulaRNC, '-', '') = '" + codigo.Replace('-', ' ') + "'";
                    aBuscar += ")";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroPersonalizado(aBuscar);
                    DTEntidades = objDB.GetAll("VENTIDADES", 1, objDB.Filtros);
                    if (DTEntidades.Rows.Count > 0) drCliente = DTEntidades.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "EsActivo = 1";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) drCliente = frm.filaSelecionada;
                }

                if (drCliente != null)
                {
                    txtCodigoCliente.Text = objDB.GetAsString("Entidad_Id", drCliente, "0");
                    tipoNCF = int.Parse(drCliente["Tipo_NCF"].ToString());
                    nombreNCF = drCliente["NombreNCF"].ToString();
                    cedulaRNC = drCliente["CedulaRNC"].ToString();
                    direccion = drCliente["Direccion"].ToString();

                    if (cedulaRNC.Trim() == "") cedulaRNC = "00000000000";

                    lblTipoNCF.Text = nombreNCF.ToUpper();

                    txtCodigoCliente.Text = drCliente["Entidad_Id"].ToString();
                    txtDireccion.Text = direccion;
                    lblNombreCliente.Text = drCliente["Nombre_Completo"].ToString();
                    lblCedulaRNC.Text = cedulaRNC;

                    if (!(drCliente["Telefono1"] is DBNull)) telefonos = drCliente["Telefono1"].ToString().Trim() + " ";
                    if (!(drCliente["Telefono2"] is DBNull)) telefonos = telefonos + drCliente["Telefono2"].ToString().Trim();

                    txtBusquedaProducto.Focus();

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

        private void txtCodigoCliente_Leave(object sender, EventArgs e)
        {
            string codigo = "";
            try
            {
                codigo = txtCodigoCliente.Text.Trim();
                if (codigo != "") GetEntidad(codigo);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            GetEntidad("");
        }

        private void txtBusquedaProducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) getProducto(0);
                else if (e.KeyCode == Keys.F9) getProducto(1);
                else isChangeCodigoP = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtBusquedaProducto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (isChangeCodigoP) getProducto(0);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormFactura_Activated(object sender, EventArgs e)
        {
            try
            {
                if (txtBusquedaProducto.Text.Trim() != "") txtBusquedaProducto.SelectAll();

                txtBusquedaProducto.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void ClickBotonLateral(string btnText = "")
        {
            try
            {
                base.ClickBotonLateral();
                txtBusquedaProducto.Text = "";
                txtBusquedaProducto.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }
    }
}
