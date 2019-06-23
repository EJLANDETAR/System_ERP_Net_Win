using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormFactura2 : WinControl_ELR_NET.ELRFormRegistro
    {
        int tipoNCF = 2;
        bool esInicio = true;
        bool NOTA_CREDITO_POR_ENTIDAD = false;
        bool isChangeCodigoP = false;
        bool isChangeVendodorId = false;

        public FormFactura2()
        {
            InitializeComponent();
            txtCodigo.Location = new Point(85, 16);
            txtCodigo.Width = 231;

            btnBuscarProducto.Location = new Point(322, 16);

            txtCantidad.Location = new Point(477, 16);
            txtCantidad.Width = 100;

            txtPrecio.Location = new Point(669, 17);
            txtPrecio.Width = 160;

            btnAgregarItem.Location = new Point(835, 17);
            btnAgregarItem.Width = 143;


            txtVendedorId.Location = new Point(11, 32);
            txtVendedorId.Width = 179;
            btnBuscarVendedor.Location = new Point(196, 32);

            txtVendedorNombre.Location = new Point(251, 32);
            txtVendedorNombre.Width = 727;
            cboTipoNCF.Width = 727;
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
                mostrarMenu();
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

        void getProducto(int tipo = 0)
        {
            DataTable DTProducto = null;
            string aBuscar = "";
            double gramos = 0, cantidad = 1, precio = 0;
            float codigoNumeric = 0;
            bool esOferta = false;
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();
            string codigo = "";
            try
            {

                isChangeCodigoP = false;
                codigo = txtCodigo.Text.Trim();
                float.TryParse(codigo, out codigoNumeric);
                lblProdDescripcion.BackColor = SystemColors.Control;
                btnAgregarItem.Enabled = false;
                drProducto = null;
                lblProdDescripcion.Text = "";
                txtCantidad.Text = "1";
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
                    frm.textoABuscar = txtCodigo.Text.Trim();
                    frm.ShowDialog();

                    if (frm.filaSelecionada != null)
                    {
                        drProducto = frm.filaSelecionada;
                        txtCodigo.Text = objUtil.GetAsString("Producto_Id", drProducto, "0");
                    }
                }

                if (drProducto != null)
                {
                    precio = objUtil.GetAsDouble("PrecioR", drProducto);
                    esOferta = objUtil.GetAsBoolean("EsOferta", drProducto);
                    if (esOferta) precio = objUtil.GetAsDouble("PrecioO", drProducto);

                    lblProdDescripcion.Text = objUtil.GetAsString("Nombre_Corto", drProducto);
                    txtCantidad.Text = cantidad.ToString("N2");
                    txtPrecio.Text = precio.ToString("N2");
                    btnAgregarItem.Enabled = true;
                    lblProdDescripcion.BackColor = Color.Green;

                    txtCantidad.Focus();
                }
                else if (codigo.Trim() != "")
                {
                    lblProdDescripcion.BackColor = Color.Red;
                    lblProdDescripcion.Text = "ITEM CON CODIGO: " + codigo + ", NO EXISTE O NO ESTA DISPONIBLE PARA VENTA";
                }

            }
            catch (Exception ex)
            {

                lblProdDescripcion.Text = "ERROR: " + ex.Message;
                lblProdDescripcion.BackColor = Color.Red;
            }
        }

        private void AgregarProducto()
        {
            DataRow MyFila;
            double precioLista, precioSinItbis, tasaItbis, itbis = 0, cantidad = 1, gramos = 0;
            double subTotal = 0, total = 0, precioMinimo = 0;
            bool esPrecioConItbis = true, esExcentoItbis = false, esOferta = false, continuar = true;
            string nivelPrecio = "R";

            try
            {
                nivelPrecio = "R";
                cantidad = objUtil.ConvertirANumero(txtCantidad.Text);
                continuar = true;
                precioLista = objUtil.ConvertirANumero(txtPrecio.Text);
                precioSinItbis = precioLista;
                itbis = 0;

                if (cboTipoNCF.SelectedValue == null) tipoNCF = 0;
                else tipoNCF = int.Parse(cboTipoNCF.SelectedValue.ToString());


                if (drProducto != null)
                {
                    tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", drProducto);
                    precioMinimo = objUtil.GetAsDouble("PrecioM", drProducto);
                    esExcentoItbis = objUtil.GetAsBoolean("EsExcentoItbis", drProducto);
                    esOferta = objUtil.GetAsBoolean("EsOferta", drProducto);
                    if (esOferta)
                    {
                        precioMinimo = objUtil.GetAsDouble("PrecioO", drProducto);
                        nivelPrecio = "O";
                    }

                    //VALIDAMOS EL PRECIO NO SEA MENOR O IGUAL A CERO NI MENOR AL PRECIO MINIMO
                    if (precioLista <= 0 || precioLista < precioMinimo)
                    {
                        objUtil.MostrarMensajeAdvertencia("EL PRECIO NO PUEDE SER MENOR AL PRECIO MINIMO: " + precioMinimo.ToString("N2"));
                        txtPrecio.Focus();
                        return;
                    }

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

                    txtCodigo.Text = "";
                    txtCantidad.Text = "1";
                    txtPrecio.Text = "0.00";
                    drProducto = null;
                    btnAgregarItem.Enabled = false;
                    lblProdDescripcion.BackColor = SystemColors.Control;
                    lblProdDescripcion.Text = @"NOMBRE/DESCRIPCION ITEM VENTA";

                    txtCodigo.Focus();

                }


            }
            catch (Exception ex)
            {

                lblProdDescripcion.Text = "ERROR: " + ex.Message;
                lblProdDescripcion.BackColor = Color.Red;
            }

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
            catch (Exception)
            {

                throw;
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

        public override void ImprimirEnOtroFormato()
        {
            string nombreArchivo = "";
            string logoEmpresa = "";
            Bitmap imgLogo;
            FastReport.Base frBase;
            int tipoNCF = 0;
            int diasCredito = 0;
            double montoACredito = 0;

            try
            {
                nombreArchivo = Environment.CurrentDirectory + @"\Reportes\factura.frx";

                tipoNCF = objUtil.GetAsInt("Tipo_NCF", DTVistaData.Rows[0]);
                diasCredito = objUtil.GetAsInt("Dias_Credito", DTVistaData.Rows[0]);
                montoACredito = objUtil.GetAsDouble("Monto_ACredito", DTVistaData.Rows[0]);

                using (FastReport.Report report = new FastReport.Report())
                {
                    report.Load(nombreArchivo);
                    report.RegisterData(DTVistaData, "VVENTAS_DETALLE");
                    report.RegisterData(DTOficina, "VEMPRESAS_OFICINAS");

                    //Vamos a asignar el logo
                    logoEmpresa = Environment.CurrentDirectory + @"\images\logo.png";
                    if (File.Exists(logoEmpresa))
                    {

                        imgLogo = (Bitmap)Image.FromFile(logoEmpresa);
                        FastReport.PictureObject ptLogo = report.FindObject("ptLogo") as FastReport.PictureObject;
                        ptLogo.Image = imgLogo;
                    }

                    if (tipoNCF <= 0)
                    {
                        frBase = report.FindObject("txtNCF");
                        if (frBase != null)
                        {
                            FastReport.TextObject txt = (frBase as FastReport.TextObject);
                            txt.Visible = false;
                        }
                    }

                    if ((diasCredito <= 0) || (montoACredito <= 0))
                    {
                        frBase = report.FindObject("txtFechaVence");
                        if (frBase != null)
                        {
                            FastReport.TextObject txt = (frBase as FastReport.TextObject);
                            txt.Visible = false;
                        }
                    }

                    report.PrintSettings.PrintMode = FastReport.PrintMode.Default;
                    report.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override bool GetData()
        {

            bool resultado = false;
            string ncf = "";
            string valorVariable = "";
            DataRow fila0 = null;
            double porcDescto = 0;
            int facturaNo = 0;

            try
            {
                cajaId = 0; aperturaCajaNo = 0;
                valorVariable = objUtil.GetValorVariable("REQUERRIR_CAJA_DESGLOSE_PAGO", DTVariablesSYS, "false").Trim().ToUpper();
                RequiereCajaAbierta = (valorVariable == "TRUE") || (valorVariable == "1");
                MostrarDesglosePago = (valorVariable == "TRUE") || (valorVariable == "1");

                resultado = base.GetData();

                if (resultado)
                {
                    
                    if (!esNuevo)
                    {
                        fila0 = DSDatos.Tables[0].Rows[0];
                        facturaNo = objUtil.GetAsInt("Numero", fila0);
                        tipoNCF = objUtil.GetAsInt("Tipo_NCF", fila0);
                        ncf = objUtil.GetAsString("NCF", fila0).Trim();
                        porcDescto = objUtil.GetAsDouble("PorcDescto", fila0);

                        TotalizarDetalle();
                    }
                    else
                    {
                        SetValorEncabezado("Entidad_Id", 0);
                        SetValorEncabezado("CedulaRNC", "000000000");
                        SetValorEncabezado("Nombre", "CLIENTE AL CONTADO");
                        SetValorEncabezado("Direccion", "");
                        SetValorEncabezado("Telefonos", "");
                    }

                    if (facturaNo > 0) Text = "MODIFICANDO FACTURA NO.: " + facturaNo.ToString().PadLeft(7, '0');
                    else Text = "REGISTRAR FACTURA";

                    cboTipoNCF.SelectedValue = tipoNCF;
                    cboTipoNCF.Enabled = (ncf == "");

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

        public override void TotalizarDetalle()
        {
            double monto = 0, montoNotaCredito = 0, montoAPagar;
            double subTotal = 0, totalDescto = 0, totalItbis = 0;
            double totalUS = 0, totalNeto = 0;
            try
            {
                base.TotalizarDetalle();

                monto = GetSumDetalle("Monto", "ItemNumero > 0");
                subTotal = GetSumDetalle("Sub_Total", "ItemNumero > 0");
                if (subTotal < 0) subTotal = 0;
                totalDescto = GetSumDetalle("Descuento", "ItemNumero > 0");
                totalItbis = GetSumDetalle("Itbis", "ItemNumero > 0");
                totalNeto = subTotal - totalDescto;

                montoNotaCredito = objUtil.GetAsDouble("Nota_Credito_Monto", DSDatos.Tables[0].Rows[0]);
                montoAPagar = monto - montoNotaCredito;

                lblMonto.Text = monto.ToString("N2");
                lblSubTotal.Text = "Sub Total: " + subTotal.ToString("N2") + "     Descto.: " + totalDescto.ToString("N2") + "     Itbis: " + totalItbis.ToString("N2");

                if (tasaCambioUS > 0) totalUS = monto / tasaCambioUS;

                SetValorEncabezado("Sub_Total", subTotal);
                SetValorEncabezado("Itbis", totalItbis);
                SetValorEncabezado("Monto_US", totalUS);
                SetValorEncabezado("Descuento", totalDescto);
                SetValorEncabezado("Neto", totalNeto);
                SetValorEncabezado("Monto", monto);

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
            string amortAutom = "";
            string valorVariable = "";
            bool noAmortizacion = false;

            try
            {
                this.PermiteACredito = true;
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
                    drProducto = null;
                    txtVendedorId.Text = "0";
                    txtVendedorNombre.Text = "";
                    lblMonto.Text = "0.00";
                    lblProdDescripcion.Text = @"NOMBRE/DESCRIPCION ITEM VENTA";
                    lblProdDescripcion.BackColor = SystemColors.Control;

                    txtVendedorId.Focus();
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

        void GetVendedor(int tipo = 0)
        {
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();
            DataTable DTVendedores = null;
            DataRow DRVendedor = null;
            string codigo = "";

            try
            {
                isChangeVendodorId = false;
                codigo = txtVendedorId.Text.Replace("-", "");

                if (tipo == 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIgualA("EsVendedor", "1");
                    objDB.AddFiltroPersonalizado("( Cast(Empleado_Id as Varchar) = '" + codigo + "' Or Replace(CedulaRNC, '-', '') = '" + codigo + "')");
                    DTVendedores = objDB.GetAll("VVENDEDORES", 1, objDB.Filtros);
                    if (DTVendedores.Rows.Count > 0) DRVendedor = DTVendedores.Rows[0];
                }

                if (tipo == 1 || (tipo == 0 && codigo != "" && DRVendedor == null))
                {
                    //Realizamos una Busqueda General
                    frm.Text = "VENDEDORES";
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.textoABuscar = codigo;
                    frm.FiltroEstatico = "EsActivo = 1 And EsVendedor = 1";


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) DRVendedor = frm.filaSelecionada;
                }

                if (DRVendedor != null)
                {
                    txtVendedorId.Text = DRVendedor["Empleado_Id"].ToString();
                    txtVendedorNombre.Text = DRVendedor["Nombre_Completo"].ToString();

                    txtCodigo.Focus();
                    txtCodigo.Focus();
                }
                else
                {
                    txtVendedorId.Text = "0";
                    txtVendedorNombre.Text = "";

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Vendedor, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                DTVendedores = null;
                DRVendedor = null;
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            GetVendedor(1);
        }

        private void txtVendedorId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9) GetVendedor(1);
                else if (e.KeyCode == Keys.Enter) GetVendedor(0);
                else isChangeVendodorId = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
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

        private void FormFactura2_Load(object sender, EventArgs e)
        {
            string valorVariable = "";
            try
            {
                if (EnEjecusion)
                {
                    NombreReporte = "rptFactura";
                    valorVariable = objUtil.GetValorVariable("NOTA_CREDITO_POR_ENTIDAD", DTVariablesSYS, "0").ToUpper();

                    NOTA_CREDITO_POR_ENTIDAD = (valorVariable == "TRUE" || valorVariable == "1");

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

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            getProducto(1);
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (drProducto != null) AgregarProducto();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
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

        private void FormFactura2_Activated(object sender, EventArgs e)
        { 
           try
            {
                if (esInicio)
                {
                    txtVendedorId.Focus();
                    esInicio = false;
                }
                else
                {
                    if (txtCodigo.Text.Trim() != "") txtCodigo.SelectAll();
                    txtCodigo.Focus();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBorrarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridDetalle == null) return;
                if (DataGridDetalle.RowCount <= 0) return;

                EliminarLineaDetalleTemp();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtVendedorId_Leave(object sender, EventArgs e)
        {
            
            try
            {
                if (isChangeVendodorId) GetVendedor(0);
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProducto();
                if (drProducto == null)
                {
                    txtCodigo.Focus();
                    txtCodigo.Focus();
                }
            }

        }

        private void dtgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorItemNumero = 0, index = 0;
            try
            {
                if (DataGridDetalle == null) return;
                if (DataGridDetalle.RowCount <= 0) return;

                if (DataGridDetalle.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    index = DataGridDetalle.CurrentRow.Index;
                    valorItemNumero = int.Parse(DataGridDetalle["ItemNumero", index].Value.ToString());

                    editarCantidadPrecio(valorItemNumero);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void editarCantidadPrecio(int itemNumero = 0)
        {
            DataRow fila0 = null;
            int index = 0;
            string tipo = "P";
            FormFacturaEditItem frmEdit = new FormFacturaEditItem();
            try
            {
                if (itemNumero <= 0)
                {
                    if (DataGridDetalle == null) return;
                    if (DataGridDetalle.RowCount <= 0) return;

                    index = DataGridDetalle.CurrentRow.Index;
                    itemNumero = int.Parse(DataGridDetalle["ItemNumero", index].Value.ToString());
                }

                fila0 = DTDetalle.Select("ItemNumero = " + itemNumero.ToString())[0];
                tipo = objUtil.GetAsString("Tipo", fila0, "P");
                if (tipo != "NC")
                {
                    frmEdit.MyFila = fila0;

                    frmEdit.ShowDialog();

                    if (frmEdit.lOK)
                    {
                        if (ActualizarDetalleFormRow(fila0, "ItemNumero")) TotalizarDetalle();
                        else fila0.RejectChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editarCantidadPrecio(0);
        }

        void aplicarNotaCredito()
        {
            FormFacturaAplicarDevolucion frm = new FormFacturaAplicarDevolucion();
            double monto = 0, itbis = 0, subtotal = 0;
            int codigo = 0;
            string concepto = "";
            DataRow MyFila;

            try
            {

                frm.esPorEntidad = NOTA_CREDITO_POR_ENTIDAD;
                frm.entidadId = 0;

                frm.ShowDialog();

                if (frm.lOK)
                {
                    monto = Math.Abs(frm.monto) * -1;
                    itbis = Math.Abs(frm.itbis) * -1;
                    subtotal = (Math.Abs(frm.monto) - Math.Abs(frm.itbis)) * -1;
                    codigo = frm.Id;
                    concepto = frm.concepto.Trim();
                    if (concepto == "") concepto = "DEVOLUCION DE PRODUCTOS Y/O SERVICIOS";

                    concepto = "NC " + frm.concepto.Trim();

                    //Validamos no exista ya dicha nota de credito
                    if (DTDetalle.Select("Producto_Id = " + codigo.ToString() + " AND Tipo = 'NC' ").Count() > 0)
                    {
                        objUtil.MostrarMensajeError("ESTA NOTA DE CREDITO YA FUE AGREGADA");
                        return;
                    }

                    //Agregamos al Detalle si no existe la Nota de Credito Ya Aplicada
                    MyFila = DTDetalle.NewRow();
                    MyFila["Producto_Id"] = codigo;
                    MyFila["Descripcion"] = concepto;
                    MyFila["Categoria_Id"] = 0;
                    MyFila["UMedida_Id"] = 0;
                    MyFila["Cantidad"] = 1;
                    MyFila["Precio_Sin_Itbis"] = 0;
                    MyFila["Precio"] = monto;
                    MyFila["Sub_Total"] = subtotal;
                    MyFila["Descuento"] = 0;
                    MyFila["Tasa_Itbis"] = 0;
                    MyFila["Itbis"] = itbis;
                    MyFila["Monto"] = monto;
                    MyFila["EsOferta"] = 0;
                    MyFila["Nivel_Precio"] = "R";
                    MyFila["EsExcentoItbis"] = false;
                    MyFila["PrecioConItbis"] = false;
                    MyFila["Tipo"] = "NC";

                    AgregarLineaDetalle(MyFila);
                    TotalizarDetalle();

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

        private void brnAplicarNotaCredito_Click(object sender, EventArgs e)
        {
            aplicarNotaCredito();
        }

        private void btnBuscarProducto_Enter(object sender, EventArgs e)
        {
            
        }

        public override void ClickBotonLateral(string btnText = "")
        {
            try
            {
                base.ClickBotonLateral();
                txtCodigo.Text = "";
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            
        }
    }
}
