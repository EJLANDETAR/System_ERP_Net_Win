using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormAmortizacionR : WinControl_ELR_NET.ELRFormRegistro
    {
        int facturaNo = 0, solicitudNo = 0;
        double tasaAnual = 0, tasaMinima = 0, tasaDemora = 0;
        double sysPorcLeg = 0, sysMontoLeg = 0, montoSolicitado = 0;
        string tipoDocumento = "", tipoGarantia = "";
        ELRLogicaNegocio.Prestamos objPrestamo = new ELRLogicaNegocio.Prestamos();
        bool esRedondear = true;

        public FormAmortizacionR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar();
        }

        void CalcularMontoPrestamo()
        {
            double monto = 0, costoLeg = 0, residuo;
            double montoAprobado = 0;
            int opcionLegal = 0;

            try
            {

                monto = objUtil.ConvertirANumero(txtMonto.Text);
                montoAprobado = objUtil.ConvertirANumero(txtMonto.Text);
                if (cboOpcionLegal.Text.Trim() != "")
                {
                   if (facturaNo <= 0) opcionLegal = cboOpcionLegal.SelectedIndex;
                }

                if (sysMontoLeg > 0) costoLeg = sysMontoLeg;
                else costoLeg = (monto * sysPorcLeg) / 100.0;

                //REDONDEAMOS EL COSTO DE LA LEGALIZACION
                if (esRedondear)
                {
                    costoLeg = Math.Ceiling(costoLeg);
                    residuo = costoLeg % 100;
                    if (residuo < 50 && residuo != 0) costoLeg += (50 - residuo);
                    else if (residuo < 100 && residuo != 0) costoLeg += (100 - residuo);
                }

                if (opcionLegal == 0) monto += costoLeg;
                lblCostoLegal.Text = costoLeg.ToString("N2");
                lblMontoPrestamo.Text = monto.ToString("N2");
                lblMontoCuota.Text = "0.00";
                btnGrabar.Enabled = false;
                DTDetalle.Clear();
                //btnGenerar.Enabled = true;

                SetValorEncabezado("Monto_Aprobado", montoAprobado);
                SetValorEncabezado("Monto_Prestamo", monto);
                SetValorEncabezado("Costo_Legalizacion", costoLeg);
                SetValorEncabezado("Opcion_Legal", opcionLegal);
                if (opcionLegal <= 0) SetValorEncabezado("Descontar_Legalizacion", false);
                else SetValorEncabezado("Descontar_Legalizacion", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void Generar()
        {
            double monto = 0;
            double montoCuota = 0;
            double tasaAnual = 0;
            int plazo = 0, diaAPagar = 0, conteo = 0;
            string formaPago = "M", tipoSaldo = "I", SSQL = "";
            double totalCapital = 0, totalInteres = 0;
            DataTable DTData = null;
            DataRow MyFila = null;
            DateTime fechaIni = DateTime.Now;
            DateTime fechaFinal = DateTime.Now;

            try
            {
                btnGrabar.Enabled = false;
                usaCliente0 = true;

                if (cboTipoSaldo.SelectedValue != null) tipoSaldo = cboTipoSaldo.SelectedValue.ToString();

                int.TryParse(txtPlazo.Text, out plazo);
                tasaAnual = double.Parse(txtTasa.Text);
                monto = double.Parse(lblMontoPrestamo.Text);
                diaAPagar = (int) nudDiaAPagar.Value;
                if (cboFrecuenciaPago.SelectedValue != null)
                {
                    formaPago = cboFrecuenciaPago.SelectedValue.ToString();
                }

                if (monto <= 0) objUtil.MostrarMensajeAdvertencia("Debe Indicar El Monto del Prestamo");
                else if (tasaAnual <= 0) objUtil.MostrarMensajeAdvertencia("Debe Indicar la Tasa de Interes");
                else if (plazo <= 0) objUtil.MostrarMensajeAdvertencia("Debe Indicar el Plazo o Cantidad de Cuota");
                else if (cboFrecuenciaPago.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Indicar La Frecuencia o Forma de Pago");
                else
                {
                    
                    SetValorEncabezado("Monto_Prestamo", monto);
                    SetValorEncabezado("Dia_APagar", diaAPagar);

                    //GENERAMOS LA TABLA DE AMORTIZACION
                    SSQL = "select * from dbo.FN_TABLA_AMORTIZACION(";
                    SSQL += monto.ToString() + ", ";
                    SSQL += tasaAnual.ToString() + ", ";
                    SSQL += plazo.ToString() + ", ";
                    SSQL += "'" + formaPago.Trim() + "', ";
                    SSQL += "NULL, ";
                    SSQL += diaAPagar.ToString();
                    SSQL += ")";
                    DTData = objDB.GetSQL(SSQL);

                    //LIMPIAMOS EL DETALLE TEMPORAL
                    LimpiarDetalleTemporal();
                    foreach (DataRow item in DTData.Rows)
                    {
                        
                        if (conteo <= 0)
                        {
                            montoCuota = objDB.GetAsDouble("Cuota", item);
                            fechaIni = objDB.GetAsDate("Fecha", item);
                        }

                        fechaFinal = objDB.GetAsDate("Fecha", item);

                        MyFila = null;
                        MyFila = DTDetalle.NewRow();
                        MyFila["ItemNumero"] = conteo + 1;
                        MyFila["Cuota_No"] = objDB.GetAsInt("Id", item);
                        MyFila["Concepto"] = objDB.GetAsString("Concepto", item);
                        MyFila["Fecha"] = objDB.GetAsDate("Fecha", item);
                        MyFila["Saldo_Inicial"] = objDB.GetAsDouble("CapitalIni", item);
                        MyFila["Capital"] = objDB.GetAsDouble("Capital", item); 
                        MyFila["Interes"] = objDB.GetAsDouble("Interes", item); 
                        MyFila["Monto"] = (objDB.GetAsDouble("Capital", item) + objDB.GetAsDouble("Interes", item) );
                        MyFila["Saldo_Final"] = objDB.GetAsDouble("Saldo", item);

                        totalCapital += objDB.GetAsDouble("Capital", item);
                        totalInteres += objDB.GetAsDouble("Interes", item);

                        AgregarLineaDetalle(MyFila);
                        conteo++;
                    }

                    lblTotalDetalle.Text = "Capital: " + totalCapital.ToString("N2") + "             ";
                    lblTotalDetalle.Text += "Interes: " + totalInteres.ToString("N2");
                    lblTotalDetalle.Text += "             Cuota de: " + montoCuota.ToString("N2");
                    lblMontoCuota.Text = montoCuota.ToString("N2");

                    //GUARDAMOS DATOS DEL ENCABEZADO
                    SetValorEncabezado("Tipo_Saldo", tipoSaldo);
                    SetValorEncabezado("Tasa_Interes", tasaAnual);
                    SetValorEncabezado("Frecuencia_Pago", formaPago);
                    SetValorEncabezado("Plazo", plazo);
                    SetValorEncabezado("Monto_Cuota", montoCuota);
                    SetValorEncabezado("Monto_Prestamo", monto);
                    SetValorEncabezado("Fecha_Termino", fechaFinal);
                    SetValorEncabezado("Fecha_Primer_Pago", fechaIni);

                    PostEncabezadoTemp();

                    //btnGenerar.Focus();
                    btnGrabar.Enabled = true;
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
            int entidadId = 0, identificadorId = 0, plazo = 0, oficinaId = 0, evaluadorId = 0, opcionLegal = 0;
            string cedulaRNC = "", aNombre = "", tipo = "", oficialNombre = "", tipoSaldo = "I", formaPago = "M", titulo = "";
            double  montoAprobado = 0, montoInicial = 0, costoLegalizacion = 0, montoPrestamo = 0;
            DataRow fila0 = null;
            DateTime fechaPrimerPago = DateTime.Now.Date;
            string formula = "D", SSQL = "";
            DataTable DTData = null;
            int diaAPagar = 0;
            try
            {
                resultado = base.GetData();
                txtMonto.ReadOnly = true;

                if (resultado)
                {
                    MostrarDataEnControles(pnLateral);
                    opcionLegal = 0;
                    diaAPagar = DateTime.Now.Date.Day;
                    if (diaAPagar > 15) diaAPagar = 30;
                    else diaAPagar = 15;

                    tipoGarantia = objUtil.GetAsString("Tipo_Garantia", drRegistroSel, "P");
                    entidadId = objUtil.GetAsInt("Entidad_Id", drRegistroSel);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", drRegistroSel);
                    aNombre = objUtil.GetAsString("Nombre_Completo", drRegistroSel);
                    tipo = objUtil.GetAsString("Tipo", drRegistroSel, "NA");
                    facturaNo = objUtil.GetAsInt("FacturaNo", drRegistroSel);
                    solicitudNo = objUtil.GetAsInt("SolicitudNo", drRegistroSel);
                    tipoDocumento = objUtil.GetAsString("Tipo_Documento", drRegistroSel, "NA");
                    montoSolicitado = objUtil.GetAsDouble("Monto_Solicitado", drRegistroSel);
                    montoAprobado = objUtil.GetAsDouble("Monto_Aprobado", drRegistroSel);
                    plazo = objUtil.GetAsInt("Plazo", drRegistroSel);
                    oficinaId = objUtil.GetAsInt("Oficina_Id", drRegistroSel);
                    evaluadorId = objUtil.GetAsInt("Evaluador_Id", drRegistroSel);
                    oficialNombre = objUtil.GetAsString("Oficial_Nombre", drRegistroSel);
                    identificadorId = objUtil.GetAsInt("Identificador_Id", drRegistroSel);
                    formaPago = objUtil.GetAsString("Forma_Pago", drRegistroSel, "M");

                    //Buscamos los datos si ya estan registrados
                    SSQL = "SELECT * FROM TPRESTAMOS_AMORTIZACION ";
                    SSQL += "WHERE Identificador_Id = '" + identificadorId + "' ";
                    SSQL += " And Tipo = '" + tipo + "' ";
                    DTData = objDB.GetSQL(SSQL);
                    if(DTData.Rows.Count > 0)
                    {
                        fila0 = DTData.Rows[0];
                        plazo = objUtil.GetAsInt("Plazo", fila0, 12);
                        diaAPagar = objUtil.GetAsInt("Dia_APagar", fila0);
                        tasaAnual = objUtil.GetAsDouble("Tasa_Interes", fila0, 48);
                        tasaDemora = objUtil.GetAsDouble("Tasa_Demora", fila0, 5);
                        opcionLegal = objUtil.GetAsInt("Opcion_Legal", fila0);
                        tipoSaldo = objUtil.GetAsString("Tipo_Saldo", fila0, "I");
                        costoLegalizacion = objUtil.GetAsDouble("Costo_Legalizacion", fila0);
                        oficinaId = objUtil.GetAsInt("Oficina_Id", fila0);
                        evaluadorId = objUtil.GetAsInt("Evaluador_Id", fila0);
                        fechaPrimerPago = objUtil.GetAsDate("Fecha_Primer_Pago", fila0);
                        formaPago = objUtil.GetAsString("Frecuencia_Pago", fila0, "M");
                        formula = objUtil.GetAsString("Formula", fila0, "D").ToUpper();
                    }  

                    if (montoAprobado <= 0)
                    {
                        montoAprobado = montoSolicitado;
                        montoPrestamo = montoAprobado;
                    }

                    if (facturaNo > 0 && plazo <= 1)
                    {
                        plazo = ((int)montoAprobado / 1000);
                        if (plazo < 3) plazo = 3;
                        if (plazo > 24) plazo = 24;
                    }

                    titulo = tipoDocumento.ToUpper();
                    if (solicitudNo > 0) titulo += "         Solicitud No.: " + solicitudNo.ToString().PadLeft(7, '0');
                    if (facturaNo > 0) titulo += "         Factura No.: " + facturaNo.ToString().PadLeft(7, '0');

                    lblMontoSolicitado.Text = "Monto Solicitado: " + montoSolicitado.ToString("N2");
                    txtMonto.Text = montoAprobado.ToString("N2");
                    lblTitulo.Text = titulo;
                    lblAMombre.Text = aNombre.ToUpper();
                    cboOpcionLegal.SelectedIndex = opcionLegal;
                    txtMonto.Enabled = (facturaNo <= 0);

                    if (formula == "D") cboOpcionLegal.SelectedIndex = 0;
                    else cboOpcionLegal.SelectedIndex = 1;

                    cboTipoSaldo.SelectedValue = tipoSaldo;
                    cboFrecuenciaPago.SelectedValue = formaPago;

                    //Obtenemos la tasa de interes
                    GetTasaInteres();
                    txtPlazo.Text = plazo.ToString();
                    txtTasa.Text = tasaAnual.ToString();
                    txtTasaMensual.Text = (tasaAnual / 12.0).ToString("N2");
                    nudDiaAPagar.Value = diaAPagar;
                    if (oficinaId <= 0) oficinaId = OFICINA_ID;

                    //ESCRIBIMOS ALGUNOS VALORES EN EL ENCABEZADO
                    SetValorEncabezado("Identificador_Id", identificadorId);
                    SetValorEncabezado("Entidad_Id", entidadId);
                    SetValorEncabezado("Tipo", tipo);
                    //SetValorEncabezado("Monto_Solicitado", montoSolicitado);
                    SetValorEncabezado("Monto_Inicial", montoInicial);
                    SetValorEncabezado("Nombre_Entidad", aNombre);
                    SetValorEncabezado("CedulaRNC", cedulaRNC);
                    SetValorEncabezado("Factura_Numero", facturaNo);
                    SetValorEncabezado("Solicitud_Id", solicitudNo);
                    SetValorEncabezado("Tipo_Saldo", tipoSaldo);
                    SetValorEncabezado("Oficina_Id", oficinaId);
                    SetValorEncabezado("Empresa_Id", EMPRESA_ID);

                    CalcularMontoPrestamo();

                    txtMonto.ReadOnly = (facturaNo > 0);

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }

            return resultado;
        }

        private void FormAmortizacionR_Load(object sender, EventArgs e)
        {

        }

        public override bool Imprimir(string valorId = "", int tipoImp = 0)
        {
            DataTable DTData = null;
            bool resultado = false;
            string pathReporte = "";
            WinControl_ELR_NET.ELRFormPreviewRDLC frmPreview = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {


                objDB.LimpiarFiltros();
                if (facturaNo > 0)
                {
                    objDB.AddFiltroIgualA("Prestamo_Id", valorId);

                    DTData = objDB.GetAll("VPRESTAMOS_AMORTIZACION", -1, objDB.Filtros);

                    //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                    pathReporte = objUtil.GetPathReportRDLC("RptPrestamoAmortizacion");
                    if (pathReporte.Trim() != "")
                    {

                        frmPreview.DTOficina = DTOficina;
                        frmPreview.DTData = DTData;
                        frmPreview.nombreUsuario = nombreUsuario;
                        frmPreview.titulo = "AMORTIZACION";
                        frmPreview.pathReporte = pathReporte.Trim();
                        frmPreview.montoLetras = montoLetras;

                        frmPreview.ShowDialog();
                    }
                }

                resultado = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmPreview.Dispose();
            }


            return resultado;
        }

        private void txtOficial_Leave(object sender, EventArgs e)
        {
            int codigo = 0;
            try
            {
                //int.TryParse(txtOficial.Text.Trim(), out codigo);
                if (codigo > 0) GetEmpleado(codigo);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtOficial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9) GetEmpleado(0);
        }

        private void cboTipoSaldo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnGrabar.Enabled = false;
                lblMontoCuota.Text = "0.00";
                DTDetalle.Clear();
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnGrabar.Enabled = false;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            double monto = 0;
            try
            {
                monto = objUtil.ConvertirANumero(txtMonto.Text);
                //btnGenerar.Enabled = (monto > 0);
                btnGrabar.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtpFechaPrimerPago_ValueChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void btnBuscarOficialCredito_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void txtTasaMensual_Leave(object sender, EventArgs e)
        {
            double valor = 0;
            valor = objUtil.ConvertirANumero(txtTasaMensual.Text);
            txtTasa.Text = (valor * 12).ToString("N2");
        }

        private void txtTasa_Leave(object sender, EventArgs e)
        {
            double valor = 0;
            valor = objUtil.ConvertirANumero(txtTasa.Text);
            txtTasaMensual.Text = (valor / 12.0).ToString("N2");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void cboOpcionLegal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularMontoPrestamo();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            try
            {
                GetTasaInteres();
                CalcularMontoPrestamo();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarOficialCredito_Click_1(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTasa_TextChanged(object sender, EventArgs e)
        {
            double tasa = 0, plazo = 0;
            DataRow fila0 = null;
            try
            {
                if (DSDatos == null) return;
                if (DSDatos.Tables.Count <= 0) return;

                fila0 = DSDatos.Tables[0].Rows[0];
                plazo = objDB.GetAsDouble("Plazo", fila0);
                tasa = objDB.GetAsDouble("Tasa_Interes", fila0);

                if (plazo != objUtil.ConvertirANumero(txtPlazo.Text) || tasa != objUtil.ConvertirANumero(txtTasa.Text))
                {
                    SetValorEncabezado("Plazo", plazo);
                    SetValorEncabezado("Tasa_Interes", tasa);

                    //Deshabilitamos el boton guardar para obligar a volver a generar
                    btnGrabar.Enabled = false;
                    //btnGenerar.Enabled = true;
                    DTDetalle.Clear();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FormAmortizacionR_Activated(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        void GetEmpleado(int empleadoId = 0, bool esSupervisor = false)
        {
            DataTable DTEmpleado = null;
            DataRow fila0 = null;
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
                if (empleadoId > 0)
                {
                    objDB.AddFiltroIgualA("Empleado_Id", empleadoId.ToString());
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIgualA("EsVendedor", "1");
                    DTEmpleado = objDB.GetAll("VEMPLEADOS", 1, objDB.Filtros);
                    if (DTEmpleado.Rows.Count > 0) fila0 = DTEmpleado.Rows[0];
                }
                else
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "EsActivo = 1 And EsVendedor = 1";
                    frm.Text = esSupervisor ? "ELEGIR SUPERVISOR DE CREDITO" : "ELEGIR OFICIAL DE CREDITO";
                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                //COLOCAMOS DATOS DEL OFICIAL DE CREDITO
                if (fila0 != null && !esSupervisor)
                {
                    //txtOficial.Text = objUtil.GetAsString("Empleado_Id", fila0, "0");
                    //lblOficialNombre.Text = objUtil.GetAsString("Nombre_Completo", fila0, "");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
                fila0 = null;
                DTEmpleado = null;
            }
        }

        void GetTasaInteres()
        {

            Double monto = 0;
            DataTable DTTasa = null;
            DataRow fila0;
            string frecuenciaPago = "M";
            int plazo = 0;
            DateTime fePrimerPago = DateTime.Now;
            string valor = "";
            try
            {
                tasaAnual = 0;
                tasaMinima = 0;
                tasaDemora = 0;
                sysPorcLeg = 0;
                sysMontoLeg = 0;

                if(DTVariablesSYS == null)
                {
                    DTVariablesSYS = objDB.GetSQL("SELECT * FROM TSISTEMA_VARIABLES WHERE Fecha_Deleted Is Null");
                }

                monto = objUtil.ConvertirANumero(txtMonto.Text);
                if (facturaNo <= 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIsNull("FechaDeleted");
                    objDB.AddFiltroBetweenCampo(monto.ToString(), "Monto_Desde", "Monto_Hasta");
                    objDB.AddFiltroIgualA("Tipo_Garantia_Id", tipoGarantia);
                    DTTasa = objDB.GetAll("TPRESTAMOS_TASA_INTERES", 1, objDB.Filtros);
                    objDB.LimpiarFiltros();

                    if (DTTasa.Rows.Count > 0)
                    {
                        fila0 = DTTasa.Rows[0];
                        tasaAnual = objUtil.GetAsDouble("Tasa_Interes_Anual", fila0);
                        tasaMinima = objUtil.GetAsDouble("Tasa_Interes_Anual_Minima", fila0);
                        tasaDemora = objUtil.GetAsDouble("Tasa_Demora_Mensual", fila0);
                        sysPorcLeg = objUtil.GetAsDouble("Porc_Legalizacion", fila0);
                        sysMontoLeg = objUtil.GetAsDouble("Monto_Legalizacion", fila0);
                        frecuenciaPago = objUtil.GetAsString("Frecuencia_Pago", fila0);
                        plazo = objUtil.GetAsInt("Plazo", fila0);
                    }
                }

                if (tasaAnual <= 0 || facturaNo > 0)
                {
                    valor = objUtil.GetValorVariable("TASA_INTERES_ANUAL", DTVariablesSYS, "0");
                    tasaAnual = objUtil.ConvertirANumero(valor);
                    if (tasaAnual <= 0) tasaAnual = 48;
                    tasaMinima = tasaAnual;
                }
                if (tasaDemora <= 0 || facturaNo > 0)
                {
                    valor = objUtil.GetValorVariable("TASA_DEMORA_MENSUAL", DTVariablesSYS, "0");
                    tasaDemora = objUtil.ConvertirANumero(valor);
                    if (tasaDemora <= 0) tasaDemora = 10;
                }

                //BUSCAMOS LA LEGALIZACION EN LAS VARIABLES DEL SISTEMA
                if (sysMontoLeg <= 0 && sysPorcLeg <= 0)
                {
                    valor = objUtil.GetValorVariable("LEGALIZACION_MONTO_FIJO", DTVariablesSYS, "0");
                    sysMontoLeg = objUtil.ConvertirANumero(valor);

                    valor = objUtil.GetValorVariable("LEGALIZACION_PORCENTAJE", DTVariablesSYS, "0");
                    sysPorcLeg = objUtil.ConvertirANumero(valor);
                }

                if (plazo <= 0) plazo = 10;

                if (esNuevo) txtPlazo.Text = plazo.ToString();
                if (tasaAnual <= 0) tasaAnual = 48;
                txtTasa.Text = tasaAnual.ToString("N2");
                txtTasaMensual.Text = (tasaAnual / 12.0).ToString("N2");
                cboFrecuenciaPago.SelectedValue = frecuenciaPago;

                if (frecuenciaPago == "M") fePrimerPago = fePrimerPago.AddMonths(1);
                else if (frecuenciaPago == "Q") fePrimerPago = fePrimerPago.AddDays(15);
                else fePrimerPago = fePrimerPago.AddDays(7);

                //dtpFechaPrimerPago.Value = fePrimerPago;
                SetValorEncabezado("Tasa_Demora", tasaDemora);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool ValidarDatos()
        {
            bool resultado = false;
            double monto = 0, tasa = 0;
            
            try
            {
                resultado = base.ValidarDatos();
                monto = objUtil.ConvertirANumero(txtMonto.Text);
                tasa = objUtil.ConvertirANumero(txtTasa.Text);
                
                if (resultado)
                {
                    if (tasaMinima > 0 && tasa < tasaMinima)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("La Tasa de Interes No Puede Ser Menor A: " + tasaMinima.ToString("N2"));
                    }
                    else if (monto <= 0)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("Debe Indicar el Monto Aprobado");
                    }
                    else if (monto > montoSolicitado)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("El monto aprobado no puede ser mayor al monto solicitado");
                    }
                    

                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

    }
}
