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
    public partial class FormFacturasListR : WinControl_ELR_NET.ELRFormRegistro
    {
        
        bool esInicio = true;
        bool NOTA_CREDITO_POR_ENTIDAD = false;
        bool isChangeCodigoP = false;
        

        public FormFacturasListR()
        {
            InitializeComponent();
        }


        private void FormFactura_Load(object sender, EventArgs e)
        {
            string valorVariable = "";
            if (EnEjecusion)
            {
                NombreReporte = "rptFactura";

                lblNombreEmpresa.Text = NOMBRE_EMPRESA_OFICINA;


                this.WindowState = FormWindowState.Maximized;

                valorVariable = objUtil.GetValorVariable("PERMITE_APLICAR_DESCUENTO", DTVariablesSYS, "0").ToUpper();
                grbDescto.Visible = (valorVariable == "TRUE" || valorVariable == "1");

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

        private void dtgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorItemNumero = 0;
            DataRow MyFila = null;
            FormFacturaEditItem frmEdit = new FormFacturaEditItem();
            int index = 0;
            string tipoItem = "";

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
                        tipoItem = objUtil.GetAsString("Tipo", MyFila, "P");

                        if (tipoItem != "NC")
                        {
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

                diasCredito = int.Parse(cboFormaPago.SelectedValue.ToString());
                PermiteACredito = (diasCredito > 0);

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
                    GetCliente("1");


                    txtCodigoVendedor.Text = "0";
                    txtNombreVendedor.Text = nombreUsuario.ToUpper();
                    lblMonto.Text = "0.00";
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

            try
            {
                cajaId = 0; aperturaCajaNo = 0;
                valorVariable = objUtil.GetValorVariable("REQUERRIR_CAJA_DESGLOSE_PAGO", DTVariablesSYS, "false").Trim().ToUpper();
                RequiereCajaAbierta = (valorVariable == "TRUE") || (valorVariable == "1");
                MostrarDesglosePago = (valorVariable == "TRUE") || (valorVariable == "1");

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

                        GetCliente("1");

                        txtCantidad.Focus();
                    }
                    else
                    {
                        fila0 = DSDatos.Tables[0].Rows[0];
                        ncf = objUtil.GetAsString("NCF", fila0);
                        porcDescto = objUtil.GetAsDouble("PorcDescto", fila0);

                        txtCodigoCliente.Enabled = (ncf == "");
                        btnBuscarCliente.Enabled = (ncf == "");
                        cboTipoNCF.Enabled = (ncf == "");
                        txtPorcDescto.Text = porcDescto.ToString("N2");
                        txtNombreCliente.Enabled = false;

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

        private void btnAplicarDevolucion_Click(object sender, EventArgs e)
        {
            FormFacturaAplicarDevolucion frm = new FormFacturaAplicarDevolucion();
            double monto = 0, itbis = 0, subtotal = 0;
            int codigo = 0;
            string concepto = "";
            DataRow MyFila;
            int entidadId = 0;

            try
            {
                int.TryParse(txtCodigoCliente.Text, out entidadId);
                frm.esPorEntidad = NOTA_CREDITO_POR_ENTIDAD;
                frm.entidadId = entidadId;

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

        public override void TotalizarDetalle()
        {
            double monto = 0, montoNotaCredito = 0, montoAPagar;
            double subTotal = 0, totalDescto = 0, totalItbis = 0;
            double totalUS = 0;
            double porcDescto = 0;
            try
            {
                base.TotalizarDetalle();

                porcDescto = objUtil.ConvertirANumero(txtPorcDescto.Text);
                monto = GetSumDetalle("Monto", "ItemNumero > 0");
                subTotal = GetSumDetalle("Sub_Total", "ItemNumero > 0");
                if (subTotal < 0) subTotal = 0;
                totalDescto = GetSumDetalle("Descuento", "ItemNumero > 0");
                totalItbis = GetSumDetalle("Itbis", "ItemNumero > 0");

                totalDescto = (monto * porcDescto) / 100.0;
                totalDescto = Math.Round(totalDescto);
                monto = monto - totalDescto;

                montoNotaCredito = objUtil.GetAsDouble("Nota_Credito_Monto", DSDatos.Tables[0].Rows[0]);
                montoAPagar = monto - montoNotaCredito;

                txtDescto.Text = totalDescto.ToString("N2");
                lblMonto.Text = monto.ToString("N2");
                lblSubTotal.Text = "Sub Total: " + subTotal.ToString("N2") + "     Descto.: " + totalDescto.ToString("N2") + "     Itbis: " + totalItbis.ToString("N2");

                if (tasaCambioUS > 0) totalUS = monto / tasaCambioUS;

                SetValorEncabezado("Monto_US", totalUS);
                //SetValorEncabezado("PorcDescto", porcDescto);
                SetValorEncabezado("Descuento", totalDescto);
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
            int tipoNCF = 0;
            string aBuscar = "";
            int id = 0;

            try
            {
                txtNombreCliente.Enabled = false;
                cboTipoNCF.Enabled = false;
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

                    cboTipoNCF.SelectedValue = tipoNCF;
                    cboTipoNCF.Enabled = (tipoNCF <= 0);

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

                    cboTipoNCF.SelectedValue = 0;
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
            if (esInicio)
            {
                if (tipo.Trim() == "") txtBusquedaProducto.Focus();
                else btnGrabar.Focus();
            }
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
                    resultado = base.Imprimir(valorId, tipoImp);
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
                if (cboTipoNCF.SelectedValue == null) tipoNCF = 0;
                else tipoNCF = int.Parse(cboTipoNCF.SelectedValue.ToString());

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
                fila0["Monto"] = total;
                fila0["Tasa_Itbis"] = tasaItbis;


                TotalizarDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Calcular Linea Detalle, " + ex.Message);
            }
        }

        private void txtPorcDescto_Leave(object sender, EventArgs e)
        {
            TotalizarDetalle();
        }

        private void txtDescto_Leave(object sender, EventArgs e)
        {
            double porcDescto = 0, totalDescto = 0, monto = 0;
            try
            {
                monto = GetSumDetalle("Monto");
                totalDescto = objUtil.ConvertirANumero(txtDescto.Text);
                if (monto > 0) porcDescto = (totalDescto / monto) * 100;

                txtPorcDescto.Text = porcDescto.ToString("N2");
                TotalizarDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAplicarDescuento_Click(object sender, EventArgs e)
        {
            FormAplicarDescuento frm = new FormAplicarDescuento();
            double montoTotal = 0, porcDescto = 0, descuento = 0, montoAPagar = 0;

            try
            {
                montoTotal = GetSumDetalle("Monto");
                porcDescto = objUtil.ConvertirANumero(txtPorcDescto.Text);
                descuento = objUtil.ConvertirANumero(txtDescto.Text);
                montoAPagar = montoTotal - descuento;

                frm.montoTotal = montoTotal;
                frm.porcDescto = porcDescto;
                frm.descuento = descuento;
                frm.montoAPagar = montoAPagar;

                frm.ShowDialog();

                if (frm.lOK)
                {
                    porcDescto = frm.porcDescto;
                    descuento = frm.descuento;

                    txtPorcDescto.Text = porcDescto.ToString("N2");
                    txtDescto.Text = descuento.ToString("N2");

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

                if (txtCantidad.Text.Trim() == "" || txtCantidad.Text.Trim() == "0") txtCantidad.Text = "1";

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
            int tipoNCF = 0;

            try
            {
                nivelPrecio = "R";
                if (drCliente != null) nivelPrecio = nivelPrecio = objUtil.GetAsString("Nivel_Precio", drCliente).ToUpper(); ;
                cantidad = objUtil.ConvertirANumero(txtCantidad.Text);

                if (cboTipoNCF.SelectedValue != null) tipoNCF = int.Parse(cboTipoNCF.SelectedValue.ToString());

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

    }
}
