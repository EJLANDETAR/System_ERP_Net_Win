using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormSolicitudAprobarR : Form
    {

        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();
        DataRow drFila;
        int empresaId = 0, oficinaId = 0;
        bool esInicio = true;

        public int solicitudId = 0;
        public string nombreUsuario = "";

        public FormSolicitudAprobarR()
        {
            InitializeComponent();
        }

        private void FormSolicitudAprobarR_Load(object sender, EventArgs e)
        {
            DataTable data;
            DataTable DTDeudores = null;
            DataTable DTGarantias = null;
            DataTable DTAmortizacion = null;
            double montoSolicitado = 0, montoAprobado = 0, tasaInteres = 0, tasaMensual = 0;
            double montoPrestamo = 0, capital = 0, totalInteres = 0, cuotaAPagar = 0, montoLeg = 0;
            int plazo = 0;
            string formaPagoDescripcion = "", nombre = "", oficinaNombre = "", oficialCredito = "", tipoSolicitud = "";

            try
            {
                data = db.GetById("VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION", solicitudId.ToString(), "Solicitud_Id");
                if (data.Rows.Count > 0)
                {
                    drFila = data.Rows[0];
                    empresaId = objUtil.GetAsInt("Empresa_Id", drFila);
                    oficinaId = objUtil.GetAsInt("Oficina_Id", drFila);
                    montoSolicitado = objUtil.GetAsDouble("Monto_Solicitado", drFila);
                    montoAprobado = objUtil.GetAsDouble("Monto_Aprobado", drFila);
                    montoPrestamo = objUtil.GetAsDouble("Monto_Prestamo", drFila);
                    montoLeg = objUtil.GetAsDouble("Costo_Legalizacion", drFila);
                    cuotaAPagar = objUtil.GetAsDouble("Monto_Cuota", drFila);
                    tasaInteres = objUtil.GetAsDouble("Tasa_Interes", drFila);
                    tasaMensual = tasaInteres / 12.0;
                    plazo = objUtil.GetAsInt("Plazo", drFila);
                    formaPagoDescripcion = objUtil.GetAsString("Forma_Pago_Descipcion", drFila);
                    nombre = objUtil.GetAsString("Nombre", drFila);
                    oficinaNombre = objUtil.GetAsString("Oficina_Nombre", drFila);
                    oficialCredito = objUtil.GetAsString("OficialCredito", drFila);
                    tipoSolicitud = objUtil.GetAsString("Tipo_Solicitud", drFila);

                    lblANombre.Text = nombre;
                    lblSolicitudNo.Text = solicitudId.ToString().PadLeft(8, '0');
                    lblTipoSolicitud.Text = tipoSolicitud;

                    lblMontoSolicitado.Text = montoSolicitado.ToString("N2");
                    lblMontoAprobado.Text = montoAprobado.ToString("N2");
                    lblTasaInteres.Text = tasaInteres.ToString("N2") + "% (" + tasaMensual.ToString("N2") + "% MENSUAL)";
                    lblPlazo.Text = plazo.ToString() + " CUOTAS " + formaPagoDescripcion;
                    lblOficina.Text = oficinaNombre;
                    lblOficialCredito.Text = oficialCredito;

                    //Buscamos Deudores
                    db.LimpiarFiltros();
                    db.AddFiltroIgualA("Solicitud_Id", solicitudId.ToString());
                    db.AddFiltroIsNull("Fecha_Deleted");
                    DTDeudores = db.GetAll("VPRESTAMOS_SOLICITUD_DEUDORES", -1, db.Filtros);
                    dtgDeudores.AutoGenerateColumns = false;
                    dtgDeudores.DataSource = DTDeudores.DefaultView;

                    //Buscamos Garantias
                    db.LimpiarFiltros();
                    db.AddFiltroIgualA("Solicitud_Id", solicitudId.ToString());
                    db.AddFiltroIsNull("Fecha_Deleted");
                    DTGarantias = db.GetAll("VPRESTAMOS_SOLICITUD_GARANTIAS", -1, db.Filtros);
                    dtgGarantias.AutoGenerateColumns = false;
                    dtgGarantias.DataSource = DTGarantias.DefaultView;

                    //Buscamos Tabla amortizacion
                    db.LimpiarFiltros();
                    db.AddFiltroIgualA("Identificador_Id", solicitudId.ToString());
                    db.AddFiltroIgualA("Tipo", "SC");
                    db.AddFiltroIsNull("FechaDeleted");
                    db.AddFiltroOrderBY("Cuota_No");
                    DTAmortizacion = db.GetAll("TPRESTAMOS_AMORTIZACION_DETALLE", -1, db.Filtros);
                    dtgAmortizacion.AutoGenerateColumns = false;
                    dtgAmortizacion.DataSource = DTAmortizacion.DefaultView;

                    capital = objUtil.GetSum("Capital", DTAmortizacion);
                    totalInteres = objUtil.GetSum("Interes", DTAmortizacion);

                    lblMontoPrestamo.Text = montoPrestamo.ToString("N2");
                    lblCapital.Text = capital.ToString("N2");
                    lblInteres.Text = totalInteres.ToString("N2");
                    lblCuotaAPagar.Text = cuotaAPagar.ToString("N2");
                    lblCostoLeg.Text = montoLeg.ToString("N2");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int resultado = 0;
            WinControl_ELR_NET.ELRFormMensajeErrores frmError = new WinControl_ELR_NET.ELRFormMensajeErrores();
            try
            {
                resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Aprobar y Generar Contractos?");
                if(resp == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    temporalId = objUtil.GetTemporalID();
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorId", solicitudId));
                    parms.Add(new DataDB_ELR_NET.Parametro("tipo", "SC"));
                    parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));

                    db.NOMBRE_USUARIO = nombreUsuario;
                    db.iniciarTransaccion();
                    resultado = db.EjecutarSP("SP_PRESTAMOS_APROBAR_GENERAR_CONTRACTOS", parms);
                    if(resultado > 0)
                    {
                        db.confirmarTransaccion();
                        Cursor = Cursors.Default;
                        objUtil.MostrarMensajeInformacion("CREDITO APROBADO DE FORMA SATISFACTORIA...");

                        Close();
                    }
                    else
                    {
                        Cursor = Cursors.Default;

                        //Mostramos mensaje error
                        frmError.objDB = db;
                        frmError.TemporalId = temporalId;
                        frmError.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                db.cancelarTransaccion();
            }
        }

        private void FormSolicitudAprobarR_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnReptValidacion_Click(object sender, EventArgs e)
        {
            validarRestrinciones();
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
    }
}
