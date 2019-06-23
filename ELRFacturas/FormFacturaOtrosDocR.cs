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
    public partial class FormFacturasOtrosDocR : WinControl_ELR_NET.ELRFormRegistro
    {

        public string tipo = "CONDUCE";

        int tipoNCF = 0;
        bool isChangeCodigoP = false;

        public FormFacturasOtrosDocR()
        {
            InitializeComponent();
        }


        private void FormFactura_Load(object sender, EventArgs e)
        {
            string valorVariable = "";

            if (EnEjecusion)
            {
                if (tipo == "CONDUCE")
                {
                    NombreReporte = "rptConduce";
                    Text = "REGISTRAR CONDUCE";
                }
                else if (tipo == "COTIZACION")
                {
                    NombreReporte = "rptCotizacion";
                    Text = "REGISTRAR COTIZACION";
                }

                lblNombreEmpresa.Text = NOMBRE_EMPRESA_OFICINA + ", " + tipo.ToUpper();
                valorVariable = objUtil.GetValorVariable("PERMITE_APLICAR_DESCUENTO", DTVariablesSYS, "0").ToUpper();
                

                //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
                addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto");
                addButtonAMenuLateral("ELRMaestros.FormProductos");
                addButtonAMenuLateral("ELRMaestros.FormEntidadesIndex", "Clientes");
                addButtonAMenuLateral("ELRFacturas.FormFacturaReImprimir");
                addButtonAMenuLateral("ELRFacturas.FormAnularFactura");
                addButtonAMenuLateral("ELRFacturas.FormFactCobroPorGrupo", "Abono o pago");
                addButtonAMenuLateral("ELRMaestros.FormEmpleados", "Empleados - Vendedores");
                addButtonAMenuLateral("ELRFacturas.FormVentasNotasCreditos");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII607", "607 DGII");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII608", "608 DGII");

                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void dtgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorItemNumero = 0;
            DataRow MyFila = null;
            FormFacturaEditItem frmEdit = new FormFacturaEditItem();
            int index = 0;

            try
            {
                var senderGrid = (DataGridView)sender;

                if (e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    index = senderGrid.CurrentRow.Index;
                    valorItemNumero = int.Parse(senderGrid["ItemNumero", index].Value.ToString());

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        EliminarLineaDetalleTemp();

                        if (dtgvDetalle.RowCount - 1 >= index) dtgvDetalle.CurrentCell = dtgvDetalle["clnEliminar", index];
                        else if (dtgvDetalle.RowCount > 0)
                        {
                            index = dtgvDetalle.RowCount - 1;
                            dtgvDetalle.CurrentCell = dtgvDetalle["clnEliminar", index];
                        }
                    }
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

        public override void ImprimirTicket()
        {
            ELRLogicaNegocio.VentasOtrosDocumentos lOtros = new ELRLogicaNegocio.VentasOtrosDocumentos();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lOtros.MyData = DTVistaData;
                lOtros.NombreImpresora = impresoraDefault;
                lOtros.numeroCopias = IMPRIME_TICKET_COPIA;

                //IMPRIMIMOS EL TICKET
                lOtros.ImprimirTicket();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                lOtros = null;
            }

        }

        public override void ImprimirEnMatricial()
        {
            ELRLogicaNegocio.VentasOtrosDocumentos lOtros = new ELRLogicaNegocio.VentasOtrosDocumentos();
            try
            {
                lOtros.MyData = DTVistaData;
                lOtros.NombreImpresora = impresoraDefault;
                lOtros.logo = logoEmpresa;

                //MANDAMOS a Imprimir en un Thread
                Thread tAux = new Thread(new ThreadStart(lOtros.PrintMatricial80));
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

            bool resultado = false;
            double porcDescto = 0;

            try
            {
                cajaId = 0; aperturaCajaNo = 0;


                resultado = base.GetData();

                if (resultado)
                {
                    if (esNuevo)
                    {
                        dtpFecha.Value = DateTime.Now.Date;
                        dtpFechaVence.Value = DateTime.Now.Date;

                        txtCodigoVendedor.Text = "000000";
                        txtNombreVendedor.Text = nombreUsuario.ToUpper();

                        DSDatos.Tables[0].Rows[0]["Vendedor_Id"] = 0;
                        SetValorEncabezado("Tipo", tipo);

                        GetCliente("1");

                        txtCantidad.Focus();
                    }
                    else
                    {
                        tipo = objUtil.GetAsString("Tipo", DSDatos.Tables[0].Rows[0], "DOCUMENTO");
                        porcDescto = objUtil.GetAsDouble("PorcDescto", DSDatos.Tables[0].Rows[0]);
                        

                        TotalizarDetalle();
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
                    else if (txtCodigoVendedor.Enabled) txtCodigoVendedor.Focus();
                    else if (txtDireccion.Enabled) txtDireccion.Focus();
                    else if (btnGrabar.Enabled) btnGrabar.Focus();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        public override void TotalizarDetalle()
        {
            double monto = 0;
            double subTotal = 0, totalDescto = 0, totalItbis = 0;
            double totalUS = 0;
            double porcDescto = 0;
            try
            {
                //base.TotalizarDetalle();    
                monto = GetSumDetalle("Monto", "ItemNumero > 0");
                subTotal = GetSumDetalle("Sub_Total", "ItemNumero > 0");
                totalDescto = GetSumDetalle("Descuento", "ItemNumero > 0");
                totalItbis = GetSumDetalle("Itbis", "ItemNumero > 0");

                totalDescto = (monto * porcDescto) / 100.0;
                totalDescto = Math.Round(totalDescto);
                monto = monto - totalDescto;

                lblMonto.Text = monto.ToString("N2");
                lblSubTotal.Text = "Sub Total: " + subTotal.ToString("N2") + "     Descto.: " + totalDescto.ToString("N2") + "     Itbis: " + totalItbis.ToString("N2");

                if (tasaCambioUS > 0) totalUS = monto / tasaCambioUS;

                SetValorEncabezado("Monto_US", totalUS);
                SetValorEncabezado("Sub_Total", subTotal);
                SetValorEncabezado("Total_Itbis", totalItbis);
                SetValorEncabezado("Total_Descuento", totalDescto);
                SetValorEncabezado("Monto", monto);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboMoneda_SelectedValueChanged(object sender, EventArgs e)
        {
            double tasaCambio = 0;
            string codigo = "";
            DataRow fila0 = null;

            try
            {
                if (cboMoneda.data.Rows.Count > 0)
                {
                    if (cboMoneda.SelectedValue != null)
                    {
                        codigo = cboMoneda.SelectedValue.ToString();
                        fila0 = cboMoneda.data.Select("Codigo = '" + codigo + "'")[0];
                        tasaCambio = objUtil.GetAsDouble("Valor_Compra", fila0);
                    }
                }

                txtTasaCambio.Text = tasaCambio.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            int diasCredito = 0;
            DateTime fecha = dtpFecha.Value.Date;

            try
            {
                if (cboFormaPago.SelectedValue != null) diasCredito = int.Parse(cboFormaPago.SelectedValue.ToString());

                fecha = fecha.AddDays(diasCredito);

                dtpFechaVence.Value = fecha;
                dtpFechaVence.Enabled = (diasCredito > 60);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void txtCodigoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9) GetCliente("");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetCliente(string codigo)
        {
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();
            DataTable DTClientes;
            int diasCredito = 0;
            string aBuscar = "";
            int id = 0;

            try
            {
                tipoNCF = 0;
                txtNombreCliente.Enabled = false;

                codigo = codigo.Trim();

                if (codigo != "")
                {
                    aBuscar = "( Cast(Entidad_Id as Varchar) = '" + codigo + "'";
                    aBuscar += " Or Replace(CedulaRNC, '-', '') = '" + codigo.Replace('-', ' ') + "'";
                    aBuscar += ")";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroPersonalizado(aBuscar);
                    DTClientes = objDB.GetAll("VENTIDADES", 1, objDB.Filtros);
                    if (DTClientes.Rows.Count > 0) drCliente = DTClientes.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.FiltroEstatico = "EsActivo = 1";
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.nombreUsuario = nombreUsuario;
                    frm.EnEjecusion = true;
                    frm.esBusqueda = true;


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) drCliente = frm.filaSelecionada;
                }

                if (drCliente != null)
                {

                    id = objUtil.GetAsInt("Entidad_Id", drCliente);
                    txtCodigoCliente.Text = drCliente["Entidad_Id"].ToString();
                    txtNombreCliente.Text = drCliente["Nombre_Completo"].ToString();
                    txtCedulaRNC.Text = drCliente["CedulaRNC"].ToString().Trim().Replace("-", "");
                    txtTelefonos.Text = drCliente["Telefono1"].ToString().Trim();
                    txtDireccion.Text = drCliente["Direccion"].ToString().Trim();

                    //Buscamos el Tipo de Comprobante asignado al Cliente
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", drCliente);
                    if (tipoNCF < 0) tipoNCF = 0;

                    //Buscamos dias de Credito
                    diasCredito = objUtil.GetAsInt("Dias_Credito", drCliente);
                    if (diasCredito < 0) diasCredito = 0;
                    cboFormaPago.SelectedValue = diasCredito;

                    txtNombreCliente.Enabled = (id <= 1);

                    txtBusquedaProducto.Focus();
                }
                else
                {
                    txtCodigoCliente.Text = "0";
                    txtNombreCliente.Text = "";
                    txtCedulaRNC.Text = "";
                    txtTelefonos.Text = "";
                    txtDireccion.Text = "";

                    cboFormaPago.SelectedValue = 0;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Cliente, " + ex.Message);
            }
            finally
            {
                frm.Dispose();

            }
        }

        void GetVendedor(int id = 0)
        {
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;
            DataTable DTVendedores = null;
            DataRow DRVendedor = null;

            try
            {
                if (id > 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Empleado_Id", id.ToString());
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIgualA("EsVendedor", "1");
                    DTVendedores = objDB.GetAll("VVENDEDORES", 1, objDB.Filtros);
                    if (DTVendedores.Rows.Count > 0) DRVendedor = DTVendedores.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.titulo = "VENDEDORES";
                    frm.TablaOVista = "VVENDEDORES";
                    frm.FiltroEstatico = "EsActivo = 1 And EsVendedor = 1";
                    frm.columnas = new WinControl_ELR_NET.MyColumna[3];


                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "Empleado_Id";
                    col.HeaderText = "Codigo";
                    col.Ancho = 120;
                    frm.columnas[0] = col;

                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "CedulaRNC";
                    col.HeaderText = @"Cedula\RNC";
                    col.Ancho = 130;
                    frm.columnas[1] = col;

                    col = new WinControl_ELR_NET.MyColumna();
                    col.NombreCampo = "Nombre_Completo";
                    col.HeaderText = "Nombre";
                    col.Ancho = -1;
                    frm.columnas[2] = col;
                    frm.DefaultColumnaBusqueda = "Nombre_Completo";

                    frm.ShowDialog();

                    if (frm.FilaSelecionada != null) DRVendedor = frm.FilaSelecionada;
                }

                if (DRVendedor != null)
                {
                    txtCodigoVendedor.Text = DRVendedor["Empleado_Id"].ToString();
                    txtNombreVendedor.Text = DRVendedor["Nombre_Completo"].ToString();

                    txtBusquedaProducto.Focus();
                }
                else
                {
                    txtCodigoVendedor.Text = "0";
                    txtNombreVendedor.Text = nombreUsuario.ToUpper();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Cliente, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                col = null;
                DTVendedores = null;
                DRVendedor = null;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            GetCliente("");
        }

        private void txtCodigoCliente_Leave(object sender, EventArgs e)
        {
            string valor = "";
            try
            {
                valor = txtCodigoCliente.Text.Trim();
                if (valor != "") GetCliente(valor);
                else GetCliente("1");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormFacturasListR_Activated(object sender, EventArgs e)
        {
            txtBusquedaProducto.Focus();
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
                codigo = txtBusquedaProducto.Text.Trim();
                float.TryParse(codigo, out codigoNumeric);
                lblMensajeError.Visible = false;
                drProducto = null;
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
                    lblMensajeError.BackColor = Color.Red;
                    lblMensajeError.Text = "ITEM CON CODIGO: " + codigo + ", NO EXISTE O NO ESTA DISPONIBLE PARA VENTA";
                }

            }
            catch (Exception ex)
            {
                lblMensajeError.Visible = true;
                lblMensajeError.Text = "ERROR: " + ex.Message;
                lblMensajeError.BackColor = Color.Red;
            }
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

                    if (nivelPrecio == "A") precioLista = objUtil.GetAsDouble("PrecioA", drProducto);
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


        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            getProducto(1);
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            GetVendedor();
        }

        private void txtCodigoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9) GetVendedor(0);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigoVendedor_Leave(object sender, EventArgs e)
        {
            int valorId = 0;
            try
            {
                int.TryParse(txtCodigoVendedor.Text, out valorId);

                if (valorId > 0) GetVendedor(valorId);
                else txtNombreVendedor.Text = nombreUsuario.ToUpper();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool Imprimir(string valorId = "", int tipoImp = 0)
        {
            bool resultado = true;

            try
            {
                if ((RequiereCajaAbierta) || (MostrarDesglosePago))
                {
                    resultado = base.Imprimir(valorId);
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
                if (dtgvDetalle.RowCount > 0)
                {
                    for (int i = 0; i < dtgvDetalle.RowCount; i++)
                    {
                        dtgvDetalle.CurrentCell = dtgvDetalle["Cantidad", i];
                        CalcularLineaDetalle();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void CalcularLineaDetalle()
        {
            double cantidad = 0, precio = 0, tasaItbis = 0, itbis = 0, subTotal = 0, total = 0;
            int index = 0;
            int valorId = 0;
            DataRow fila0;
            bool esExcentoItbis, esPrecioConItbis;
            int tipoNCF = 0;

            try
            {

                index = DataGridDetalle.CurrentRow.Index;
                valorId = int.Parse(DataGridDetalle["ItemNumero", index].Value.ToString());
                fila0 = DTDetalle.Select("ItemNumero = " + valorId)[0];

                cantidad = double.Parse(DataGridDetalle["Cantidad", index].Value.ToString());
                precio = double.Parse(DataGridDetalle["Precio", index].Value.ToString());

                if (tipoNCF > 0) tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", fila0);
                else tasaItbis = 0;

                esExcentoItbis = objUtil.GetAsBoolean("EsExcentoItbis", fila0);
                esPrecioConItbis = objUtil.GetAsBoolean("PrecioConItbis", fila0);

                if (esExcentoItbis) tasaItbis = 0;


                subTotal = cantidad * precio;
                if ((esPrecioConItbis) && (tasaItbis > 0))
                {
                    itbis = precio - (precio / (1 + tasaItbis / 100.0));
                    precio = precio - itbis;
                    subTotal = cantidad * precio;
                    itbis = cantidad * itbis;
                }
                else itbis = (subTotal * tasaItbis) / 100.0;
                total = subTotal + itbis;

                fila0["Sub_Total"] = subTotal;
                fila0["Itbis"] = itbis;
                fila0["Total"] = total;
                fila0["Tasa_Itbis"] = tasaItbis;

                TotalizarDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Calcular Linea Detalle, " + ex.Message);
            }
        }

        public override void AgregarLineaVacia()
        {
            //base.AgregarLineaVacia();
            btnBuscarProducto.PerformClick();
        }

        private void txtPorcDescto_Leave(object sender, EventArgs e)
        {
            TotalizarDetalle();
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
    }
}
