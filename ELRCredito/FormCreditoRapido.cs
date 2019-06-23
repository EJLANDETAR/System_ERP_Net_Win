using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormCreditoRapido : WinControl_ELR_NET.ELRFormRegistro
    {
        ELRLogicaNegocio.Prestamos objPrestamo = new ELRLogicaNegocio.Prestamos();
        double tasaAnual = 0, tasaMinima = 0, tasaDemora = 0;
        public FormCreditoRapido()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataTable DTOficinas = null;
            try
            {
                resultado = base.GetData();
                if (resultado)
                {
                    cboTipo.SelectedValue = "P";
                    DTOficinas = objDB.GetById("VEMPRESAS_OFICINAS", EMPRESA_ID.ToString(), "Empresa_Id");
                    cboOficina.DataSource = DTOficinas.DefaultView;
                    cboOficina.SelectedValue = OFICINA_ID;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;

        }

        void GetEntidad(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)", cedulaRNC = "000000000";
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Entidad_Id, Nombres, Apellidos, CedulaRNC FROM TCLASIFICADOR_ENTIDADES";
                    SSQL += " WHERE Cast(Entidad_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = true;
                    frm.EsModificar = true;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "EsActivo = 1";


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Entidad_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);
                }

                txtEntidadId.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);
                txtCedulaRNC.Text = cedulaRNC;

                SetValorEncabezado("Entidad_Id", id);
                SetValorEncabezado("CedulaRNC", cedulaRNC);
                SetValorEncabezado("Nombre_Entidad", nombre);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            GetEntidad();
        }

        private void txtEntidadId_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtEntidadId.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEntidad();

            else if (e.KeyCode == Keys.Enter && codigo != "") GetEntidad(codigo);
        }

        void Generar()
        {
            double monto = 0;
            double montoCuota = 0;
            double tasaAnual = 0;
            int plazo = 0;
            string tipoSaldo;
            string formaPago = "M";
            string concepto = "";
            DataRow MyFila;
            DateTime fecha;
            double saldoInicial = 0;
            double saldoFinal = 0;
            double interes = 0;
            double capital = 0;
            double tasa = 0;
            double total = 0.00;
            double totalCapital = 0;
            double diferencia = 0;
            double montoInicial = 0;
            int metodo = 0;
            double dias = 0;

            try
            {
                btnGrabar.Enabled = false;
                usaCliente0 = true;

                //VALIDAMOS QUE LA FECHA DE PRIMER PAGO SEA MAYOR A FECHA ACTUAL
                fecha = dtpFechaPrimerPago.Value.Date;
                metodo = cboMetodo.SelectedIndex;
                monto = objUtil.ConvertirANumero(txtMonto.Text);
                plazo = int.Parse(txtPlazo.Text);
                tasaAnual = double.Parse(txtTasa.Text);
                tipoSaldo = cboTipoSaldo.SelectedValue.ToString();
                formaPago = cboFrecuenciaPago.SelectedValue.ToString();

                if (monto <= 0) objUtil.MostrarMensajeAdvertencia("Debe Indicar El Monto del Prestamo");
                else if (txtTasa.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Indicar la Tasa de Interes");
                else if (txtPlazo.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Indicar el Plazo o Cantidad de Cuota");
                else if (cboTipoSaldo.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Indicar el tipo de Saldo");
                else if (cboFrecuenciaPago.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Indicar La Frecuencia o Forma de Pago");
                else if (tasaMinima > 0 && tasaAnual < tasaMinima) objUtil.MostrarMensajeError("La Tasa de Interes No Puede Ser Menor A: " + tasaMinima.ToString("N2"));
                else
                {
                    SetValorEncabezado("Monto_Aprobado", monto);
                    SetValorEncabezado("Monto_Inicial", montoInicial);

                    saldoInicial = monto;

                    if (formaPago == "M") dias = 30;
                    else if (formaPago == "T") dias = 360;
                    else if (formaPago == "Q") dias = 15;
                    else if (formaPago == "S") dias = 7;
                    else if (formaPago == "D") dias = 1;

                    if ((tasaAnual < 0) || (plazo <= 0))
                    {
                        throw new Exception("Error La Tasa No Puede Ser Menor a Cero, Plazo o Cuota debe Ser Mayor a Cero");
                    }


                    if (metodo > 0)
                    {
                        montoCuota = objPrestamo.GetCuota(monto, plazo, tasaAnual, "I");

                        tasa = (tasaAnual / 12.0) / 100.0;
                        if (montoCuota == 0) montoCuota = monto / plazo;
                    }
                    else
                    {
                        interes = monto * (tasaAnual / 100.0) * (dias / 360);
                        montoCuota = (monto / plazo) + interes;
                    }

                    //LIMPIAMOS EL DETALLE TEMPORAL
                    LimpiarDetalleTemporal();

                    totalCapital = 0;
                    diferencia = 0;

                    for (int i = 1; i <= plazo; i++)
                    {
                        concepto = "CUOTA " + i.ToString() + " DE " + plazo.ToString();
                        MyFila = null;

                        MyFila = DTDetalle.NewRow();
                        MyFila["ItemNumero"] = i;
                        MyFila["Cuota_No"] = i;
                        MyFila["Concepto"] = concepto;


                        if (i > 1)
                        {
                            if (formaPago == "M") fecha = fecha.AddMonths(1);
                            else if (formaPago == "T") fecha = fecha.AddMonths(1);
                            else if (formaPago == "Q") fecha = fecha.AddDays(15);
                            else if (formaPago == "S") fecha = fecha.AddDays(7);
                            else if (formaPago == "D") fecha = fecha.AddDays(1);
                            else throw new Exception("Forma de Pago No Existe");
                        }

                        MyFila["Fecha"] = fecha;


                        if (montoInicial > 0 && metodo > 0)
                        {
                            if (i == 1)
                            {
                                interes = (saldoInicial * (tasaAnual / 12.0)) / 100;
                                capital = montoCuota - interes;
                            }
                        }
                        else if (metodo > 0)
                        {
                            interes = saldoInicial * tasa;

                            if (saldoInicial > montoCuota) capital = montoCuota - interes;
                            else if (saldoInicial < montoCuota) capital = saldoInicial;
                            else capital = saldoInicial - interes;
                        }
                        else
                        {
                            capital = monto / plazo;
                        }

                        totalCapital += capital;

                        //VALIDAMOS QUE EL TOTAL DE CAPITAL = MONTO DEL PRESTAMO
                        if ((i == plazo) && (montoInicial <= 0))
                        {
                            diferencia = monto - totalCapital;
                            if (diferencia > 0)
                            {
                                capital += diferencia;
                                interes -= diferencia;
                            }
                            else
                            {
                                capital -= diferencia;
                                interes += diferencia;
                            }
                        }

                        MyFila["Saldo_Inicial"] = saldoInicial;
                        MyFila["Capital"] = capital;
                        MyFila["Interes"] = interes;
                        MyFila["Monto"] = (capital + interes);

                        if (saldoInicial > montoCuota) saldoFinal = saldoInicial - capital;
                        else saldoFinal = saldoInicial - (capital + interes);

                        if (saldoFinal < 0) saldoFinal = 0;

                        MyFila["Saldo_Final"] = saldoFinal;

                        saldoInicial = saldoFinal;

                        AgregarLineaDetalle(MyFila);
                    }

                    capital = GetSumDetalle("Capital");
                    interes = GetSumDetalle("Interes");

                    total = capital + interes;

                    lblTotalCapital.Text = capital.ToString("N2");
                    lblTotalInteres.Text = interes.ToString("N2");
                    lblTotal.Text = total.ToString("N2");
                    lblMontoCuota.Text = montoCuota.ToString("N2");

                    //GUARDAMOS DATOS DEL ENCABEZADO
                    SetValorEncabezado("Tipo_Saldo", tipoSaldo);
                    SetValorEncabezado("Tasa_Interes", tasaAnual);
                    SetValorEncabezado("Frecuencia_Pago", formaPago);
                    SetValorEncabezado("Plazo", plazo);
                    SetValorEncabezado("Monto_Cuota", montoCuota);
                    SetValorEncabezado("Monto_Prestamo", monto);
                    SetValorEncabezado("Fecha_Termino", fecha);
                    SetValorEncabezado("Fecha_Primer_Pago", dtpFechaPrimerPago.Value);



                    PostEncabezadoTemp();


                    btnGrabar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void FormCreditoRapido_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha.Value = fecha;
            dtpFechaPrimerPago.Value = fecha;
            cboMetodo.SelectedIndex = 0;
        }

        private void cboTipoSaldo_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        void GetEmpleado(String codigo = "", bool esSupervisor = false)
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            int empleadoId = 0;
            string nombre = "(NO ASIGNADO)";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();
            String SSQL = "";
            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Empleado_Id, Nombres, Apellidos FROM TRRHH_EMPLEADOS";
                    SSQL += " WHERE ( Cast(Empleado_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "') ";
                    SSQL += "  And EsActivo = 1 And Fecha_Baja Is Null ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.esBusqueda = true;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "EsActivo = 1 And EsVendedor = 1";
                    frm.Text = esSupervisor ? "ELEGIR SUPERVISOR DE CREDITO" : "ELEGIR OFICIAL DE CREDITO";
                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                //COLOCAMOS DATOS DEL OFICIAL DE CREDITO
                if (fila0 != null)
                {
                    empleadoId = objUtil.GetAsInt("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0, "");
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0, "");
                }

                if (!esSupervisor)
                {
                    txtOficial.Text = empleadoId.ToString();
                    lblOficialNombre.Text = nombre;

                    SetValorEncabezado("Oficial_Id", empleadoId);
                    SetValorEncabezado("Evaluador_Id", empleadoId);
                    SetValorEncabezado("Oficial_Nombre", nombre);
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
                DTData = null;
            }
        }

        private void btnBuscarOficialCredito_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void btnBuscarSupervisor_Click(object sender, EventArgs e)
        {
            GetEmpleado("", true);
        }

        private void txtOficial_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string codigo = txt.Text.Trim();

            if (e.KeyCode == Keys.F9)
            {
                if (txt == txtOficial) GetEmpleado();
                
            }
            else if (e.KeyCode == Keys.Enter && codigo != "")
            {
                if (txt == txtOficial) GetEmpleado(codigo);
                
            }
        }

        public override bool Imprimir(string valorId = "", int tipoImp = 0)
        {
            bool resultado = false;
            string pathReporte = "";
            DataTable DTTabla1 = null, DTTabla2 = null;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCredito");

                DTTabla1 = objDB.GetById("VPRESTAMOS", valorId, "Prestamo_Id");

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Prestamo_Id", valorId);
                objDB.AddFiltroIgualA("EsNulo", "0");
                DTTabla2 = objDB.GetAll("TPRESTAMOS_DETALLE", -1, objDB.Filtros);

                frm.AddParm("PRESTAMO_ID", valorId);

                frm.AddDS("DSData", DTTabla1);
                frm.AddDS("DSDetalle", DTTabla2);

                frm.pathReporte = pathReporte;

                frm.oficinaId = OFICINA_ID;
                frm.empresaId = EMPRESA_ID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "PRESTAMO NO.: " + valorId.PadLeft(7, '0');

                frm.ShowDialog();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DTTabla1 = null;
                DTTabla2 = null;
            }

            return resultado;
        }

        private void cboTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            string tipo = "P";

            if (cboTipo.SelectedValue != null) tipo = cboTipo.SelectedValue.ToString().ToUpper();
            GetTasaInteres();
            SetValorEncabezado("Tipo_Garantia", tipo);
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) GetTasaInteres();
        }

        private void cboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            if (cboMetodo.SelectedIndex == 0) SetValorEncabezado("Formula", "D");
            else SetValorEncabezado("Formula", "A");
        }

        private void cboTipoSaldo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void cboFrecuenciaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = "M";
            DateTime fecha = DateTime.Now.Date;
            try
            {
                fecha = dtpFecha.Value.Date;
                if (cboFrecuenciaPago.SelectedValue != null) valor = cboFrecuenciaPago.SelectedValue.ToString().ToUpper();

                if (valor == "M") fecha = fecha.AddDays(30);
                else if (valor == "Q") fecha = fecha.AddDays(15);
                else if (valor == "S") fecha = fecha.AddDays(7);
                else if (valor == "I") fecha = fecha.AddDays(2);
                else if (valor == "D") fecha = fecha.AddDays(1);

                dtpFechaPrimerPago.Value = fecha;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtpFechaPrimerPago_ValueChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
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
            txtTasaMensual.Text = (valor/12.0).ToString("N2");
        }

        void GetTasaInteres()
        {

            Double monto = 0;
            string tipoId = "P";
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

                if (cboTipo.SelectedValue != null) tipoId = cboTipo.SelectedValue.ToString();
                monto = objUtil.ConvertirANumero(txtMonto.Text);
                objDB.LimpiarFiltros();
                objDB.AddFiltroIsNull("FechaDeleted");
                objDB.AddFiltroBetweenCampo(monto.ToString(), "Monto_Desde", "Monto_Hasta");
                objDB.AddFiltroIgualA("Tipo_Garantia_Id", tipoId);
                DTTasa = objDB.GetAll("TPRESTAMOS_TASA_INTERES", 1, objDB.Filtros);

                if (DTTasa.Rows.Count > 0)
                {
                    fila0 = DTTasa.Rows[0];
                    tasaAnual = objUtil.GetAsDouble("Tasa_Interes_Anual", fila0);
                    tasaMinima = objUtil.GetAsDouble("Tasa_Interes_Anual_Minima", fila0);
                    tasaDemora = objUtil.GetAsDouble("Tasa_Demora_Mensual", fila0);
                    frecuenciaPago = objUtil.GetAsString("Frecuencia_Pago", fila0);
                    plazo = objUtil.GetAsInt("Plazo", fila0);
                }

                if (tasaAnual <= 0)
                {
                    valor = objUtil.GetValorVariable("TASA_INTERES_ANUAL", DTVariablesSYS, "0");
                    tasaAnual = objUtil.ConvertirANumero(valor);
                    if (tasaAnual <= 0) tasaAnual = 48;
                    tasaMinima = tasaAnual;
                }
                if (tasaDemora <= 0)
                {
                    valor = objUtil.GetValorVariable("TASA_DEMORA_MENSUAL", DTVariablesSYS, "0");
                    tasaDemora = objUtil.ConvertirANumero(valor);
                    if (tasaDemora <= 0) tasaDemora = 10;
                }
                if (plazo <= 0) plazo = 10;

                txtPlazo.Text = plazo.ToString();
                txtTasa.Text = tasaAnual.ToString("N2");
                txtTasaMensual.Text = (tasaAnual / 12.0).ToString("N2");
                cboFrecuenciaPago.SelectedValue = frecuenciaPago;

                if (frecuenciaPago == "M") fePrimerPago = fePrimerPago.AddMonths(1);
                else if (frecuenciaPago == "Q") fePrimerPago = fePrimerPago.AddDays(15);
                else fePrimerPago = fePrimerPago.AddDays(7);

                dtpFechaPrimerPago.Value = fePrimerPago;

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
            int entidadId = 0;
            int fecha, fePrimerPago;

            try
            {
                resultado = base.ValidarDatos();
                monto = objUtil.ConvertirANumero(txtMonto.Text);
                tasa = objUtil.ConvertirANumero(txtTasa.Text);
                int.TryParse(txtEntidadId.Text, out entidadId);
                fecha = objUtil.DateToInt(dtpFecha.Value);
                fePrimerPago = objUtil.DateToInt(dtpFechaPrimerPago.Value); 

                if (resultado)
                {
                    if (monto <= 0)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("Debe Indicar el Monto del Prestamo");
                    }
                    else if (tasa <= 0)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("Debe Indicar La Tasa Interes");
                    }
                    else if(entidadId <= 0)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("Debe Seleccionar un Cliente...");
                    }
                    else if(fePrimerPago <= fecha)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("La Fecha de Primer Pago debe Ser Mayor a la Fecha del Credito...");
                        dtpFechaPrimerPago.Focus();
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
