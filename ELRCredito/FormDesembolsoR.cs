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
    public partial class FormDesembolsoR : WinControl_ELR_NET.ELRFormRegistro
    {

        int solicitudId = 0;
        bool esInicio = true;

        public FormDesembolsoR()
        {
            InitializeComponent();
        }

        public override void MostrarDataRegistroSel()
        {
            int clienteId = 0;
            int plazo = 0;
            double tasaInteres = 0;
            double montoCuota = 0;
            double monto = 0, total = 0, totalCapital = 0, totalInteres = 0;
            string aNombre = "", frecuenciaPago = "M", formula= "";
            DataTable DTGarantias;
            DataTable DTDeudores;
            DataTable DTAmortizacion;

            try
            {
                base.MostrarDataRegistroSel();
                solicitudId = objUtil.GetAsInt("Solicitud_Id", drRegistroSel);
                clienteId = objUtil.GetAsInt("Entidad_Id", drRegistroSel);
                monto = objUtil.GetAsDouble("Monto_Aprobado", drRegistroSel);
                aNombre = objUtil.GetAsString("Nombre", drRegistroSel);
                frecuenciaPago = objUtil.GetAsString("Frecuencia_Pago", drRegistroSel, "M");
                plazo = objUtil.GetAsInt("Plazo", drRegistroSel);
                tasaInteres = objUtil.GetAsDouble("Tasa_Interes", drRegistroSel);
                montoCuota = objUtil.GetAsDouble("Monto_Cuota", drRegistroSel);
                formula = objUtil.GetAsString("Descripcion_Formula", drRegistroSel, "");

                lblSolicitudNo.Text = solicitudId.ToString().PadLeft(7, '0');
                lblANombre.Text = aNombre;
                txtBeneficiario.Text = aNombre;
                lblMonto.Text = monto.ToString("N2");
                lblPlazo.Text = plazo.ToString() + " CUOTAS ";

                if (frecuenciaPago == "M") lblPlazo.Text += "MENSUALES";
                if (frecuenciaPago == "Q") lblPlazo.Text += "QUINCENALES";
                if (frecuenciaPago == "S") lblPlazo.Text += "SEMANALES";
                if (frecuenciaPago == "I") lblPlazo.Text += "INTERDIARIO";
                if (frecuenciaPago == "D") lblPlazo.Text += "DIARIO";

                lblTasaInteres.Text = tasaInteres.ToString("N2") + "%";
                lblMontoCuota.Text = montoCuota.ToString("N2");
                lblFormula.Text = formula;

                //Cargamos las Garantia
                dtgGarantias.AutoGenerateColumns = false;
                DTGarantias = objDB.GetById("VPRESTAMOS_SOLICITUD_GARANTIAS", solicitudId.ToString(), "Solicitud_Id");
                dtgGarantias.DataSource = DTGarantias.DefaultView;

                //Cargamos LOS DEUDORES
                dtgDeudores.AutoGenerateColumns = false;
                DTDeudores = objDB.GetById("VPRESTAMOS_SOLICITUD_DEUDORES", solicitudId.ToString(), "Solicitud_Id");
                dtgDeudores.DataSource = DTDeudores.DefaultView;

                txtMonto.Text = monto.ToString("N2");
                txtMonto.Enabled = false;

                txtConcepto.Text = "PARA GENERAR EL PRESTAMO CORRESPONDIENTE A SOLICITUD NO.: " + solicitudId.ToString().PadLeft(7, '0') + " A NOMBRE DE " + aNombre;

                //ESCRIBIMOS EN EL ENCABEZADO
                SetValorEncabezado("Solicitud_Id", solicitudId);
                SetValorEncabezado("Entidad_Id", clienteId);
                SetValorEncabezado("ANombre", aNombre);

                //CARGAMOS LA TABLA DE AMORTIZACION
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Identificador_Id", solicitudId.ToString());
                objDB.AddFiltroIgualA("Tipo", "SC");
                DTAmortizacion = objDB.GetAll("TPRESTAMOS_AMORTIZACION_DETALLE", -1, objDB.Filtros);
                dtgAmortizacion.AutoGenerateColumns = false;
                dtgAmortizacion.DataSource = DTAmortizacion.DefaultView;

                totalCapital = GetSum("Capital", DTAmortizacion);
                totalInteres = GetSum("Interes", DTAmortizacion);
                total = totalCapital + totalInteres;

                txtTotalCapital.Text = totalCapital.ToString("N2");
                txtTotalInteres.Text = totalInteres.ToString("N2");
                txtTotal.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                this.Close();
            }
        }

        public override int GrabarDatos()
        {
            int resultado = -1;
            DialogResult resp;

            try
            {
                if (objDB.ValidarFechaTrabajo() )
                {
                    resp = System.Windows.Forms.DialogResult.Yes;
                    if (dtgGarantias.RowCount <= 0) resp = objUtil.MostrarMensajePregunta("Desea Generar el Prestamos Sin Indicar Ningun Tipo de Garantias?");

                    if (resp == System.Windows.Forms.DialogResult.Yes) resultado = base.GrabarDatos();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
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

        private void dtgGarantias_SelectionChanged(object sender, EventArgs e)
        {
            int filaId = 0;
            try
            {
                if (dtgGarantias.CurrentRow != null)
                {
                    filaId = dtgGarantias.CurrentRow.Index;
                    txtDescripcionGarantia.Text = dtgGarantias["Descripcion", filaId].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormDesembolsoR_Load(object sender, EventArgs e)
        {

        }

        void validarRestrinciones()
        {
            FormValidarSolicitud frm = new FormValidarSolicitud();
            try
            {
                frm.solicitudId = solicitudId;
                frm.nombreUsuario = nombreUsuario;

                frm.ShowDialog();
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

        private void FormDesembolsoR_Activated(object sender, EventArgs e)
        {
            try
            {
                if(esInicio)
                {
                    esInicio = false;
                    validarRestrinciones();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validarRestrinciones();
        }
    }
}
