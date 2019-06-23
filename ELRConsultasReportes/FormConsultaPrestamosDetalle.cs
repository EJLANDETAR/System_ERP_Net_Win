using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsultaPrestamosDetalle : Form
    {
        public string prestamoId = "0";
        public string nombreUsuario = "NOMBRE.USUARIO";

        WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        DataSet DSData = new DataSet();
        DateTime fechaActual;

        public FormConsultaPrestamosDetalle()
        {
            InitializeComponent();
        }

        void GetData()
        {
            DataTable MyTabla;
            DataRow MyFila;

            double totalCapital = 0, totalInteres = 0, totalDemora = 0, totalOtros = 0, total;
            double monto = 0, tasaInteres = 0, montoCuota = 0, balance = 0;
            int plazo = 0;
            DateTime fecha, fechaCuota;
            string diasAtrazo = "0";
            int solicitudId = 0;
            string facturaNo = "0";
            string tipoGarantia = "";
            string garantiaId = "";

            int id = 0;

            object calcObject; 

            try
            {
                fechaActual = DateTime.Now.Date;
                MyTabla = db.GetById("VPRESTAMOS", prestamoId, "Prestamo_Id");
                MyFila = MyTabla.Rows[0];

                //Mostramos los datos del Prestamo
                solicitudId = objUtil.GetAsInt("Solicitud_Id", MyFila, 0);
                facturaNo = objUtil.GetAsString("Factura_No", MyFila, "0");
                tipoGarantia = objUtil.GetAsString("Tipo_Garantia", MyFila);
                garantiaId = objUtil.GetAsString("Garantia_Id", MyFila, "0");
                monto = objUtil.GetAsDouble ("Monto", MyFila );
                montoCuota = objUtil.GetAsDouble ("Monto_Cuota", MyFila);
                tasaInteres = objUtil.GetAsDouble ("Tasa_Interes_Anual", MyFila );  
                plazo = objUtil.GetAsInt ("Plazo", MyFila);  
                balance = objUtil.GetAsDouble ("Balance", MyFila);
                diasAtrazo = objUtil.GetAsString("Dias_Atrazo", MyFila, "0");
                if (diasAtrazo.Trim() == "") diasAtrazo = "0";

                lblPrestamoId.Text = prestamoId.PadLeft(7, '0');
                lblSolicitudId.Text = solicitudId.ToString().PadLeft(7, '0');  
                lblTipoGarantia.Text = objUtil.GetValorFromDR("Descripcion_Tipo_Garantia", MyFila, "NO GARANTIA");  
                lblNombreOficial.Text = objUtil.GetValorFromDR("Oficial_Nombre", MyFila, "N");
                lblFacturaNo.Text = facturaNo.PadLeft(8, '0');
                 
                lblFecha.Text = objUtil.GetDateAsString("Fecha_Otorgado", MyFila);
                lblFechaProximoPago.Text = objUtil.GetDateAsString("Fecha_Proximo_Pago", MyFila);
                lblFechaPagoAnterior.Text = objUtil.GetDateAsString("Fecha_Ultimo_Abono", MyFila);
                lblMonto.Text = monto.ToString("N2");
                lblMontoCuota.Text = montoCuota.ToString("N2");
                lblInteresAnual.Text = tasaInteres.ToString("N2") + " %";
                lblPlazo.Text = plazo.ToString();
                lblBalance.Text = balance.ToString("N2");

                uscEntidad.GetEntidadById(int.Parse(MyFila["Entidad_Id"].ToString()));
                if (tipoGarantia.Trim().ToUpper() == "P")
                {
                    id = 0;
                    int.TryParse(garantiaId, out id);
                    uscGarante.GetEntidadById(id);
                }
                else uscGarante.GetEntidad("");

                //OBTENEMOS LO QUE ESTE PENDIENTE YA CON FECHA VENCIDAD
                db.LimpiarFiltros();
                db.AddFiltroIgualA("Prestamo_Id", prestamoId);
                db.AddFiltroPersonalizado(" ( Capital_Pendiente > 0 Or Interes_Pendiente > 0 Or Demora_Pendiente > 0 Or Otros_Pendiente > 0 )");
                MyTabla = db.GetAll("TPRESTAMOS_DETALLE", -1, db.Filtros);
                MyTabla.TableName = "Detalle_Pendiente";
                DSData.Tables.Add(MyTabla);

                totalCapital = 0; totalInteres = 0; totalDemora = 0; totalOtros = 0;
                foreach (DataRow item in MyTabla.Rows)
                {
                    fecha = DateTime.Now.Date;
                    fechaCuota = (DateTime)item["Fecha"];

                    if (db.DateToInt(fechaCuota) <= db.DateToInt(fecha))
                    {
                        totalCapital += double.Parse(item["Capital_Pendiente"].ToString());
                        totalInteres += double.Parse(item["Interes_Pendiente"].ToString());
                        totalDemora += double.Parse(item["Demora_Pendiente"].ToString());
                        totalOtros += double.Parse(item["Otros_Pendiente"].ToString());
                    }
                }

                dtgCuotasPendientes.AutoGenerateColumns = false;
                dtgCuotasPendientes.DataSource = DSData.Tables["Detalle_Pendiente"].DefaultView;

                lblCapitalPendiente.Text = totalCapital.ToString("N2");
                lblInteresPendiente.Text = totalInteres.ToString("N2");
                lblDemoraPendiente.Text = totalDemora.ToString("N2");
                lblOtrosPendiente.Text = totalOtros.ToString("N2");

                lblTotalPendiente.Text = (totalCapital + totalInteres + totalDemora + totalOtros).ToString("N2") + "  (" + diasAtrazo + " dias Atrazo)";


                //OBTENEMOS LA TABLA DE AMORTIZACION
                db.LimpiarFiltros();
                MyTabla = db.GetById("TPRESTAMOS_AMORTIZACION_DETALLE", prestamoId, "Prestamo_Id");
                MyTabla.TableName = "Detalle_Amortizacion";
                DSData.Tables.Add(MyTabla);

                totalCapital = 0; totalInteres = 0; totalDemora = 0; totalOtros = 0;
                foreach (DataRow item in MyTabla.Rows)
                {
                    totalCapital += double.Parse(item["Capital"].ToString());
                    totalInteres += double.Parse(item["Interes"].ToString());

                }


                dtgAmortizacion.AutoGenerateColumns = false;
                dtgAmortizacion.DataSource = DSData.Tables["Detalle_Amortizacion"].DefaultView;
                lblTotalAmortizacion.Text = "Total Capital: " + totalCapital.ToString("N2") + "                Total Interes: " + totalInteres.ToString("N2");

                //OBTENEMOS EL DETALLE COBRADO
                db.LimpiarFiltros();
                db.AddFiltroIgualA("Prestamo_Id", prestamoId);
                db.AddFiltroIgualA("EsNulo", "0");

                MyTabla = db.GetAll("TPRESTAMOS_DETALLE_COBRADO", -1, db.Filtros);
                MyTabla.TableName = "Detalle_Cobrado";
                DSData.Tables.Add(MyTabla);

                totalCapital = 0; totalInteres = 0; totalDemora = 0; totalOtros = 0;
                foreach (DataRow item in MyTabla.Rows)
                {
                    totalCapital += double.Parse(item["Capital"].ToString());
                    totalInteres += double.Parse(item["Interes"].ToString());
                    totalDemora += double.Parse(item["Demora"].ToString());
                    totalOtros += double.Parse(item["Otros"].ToString());
                }


                dtgDetalleCobrado.AutoGenerateColumns = false;
                dtgDetalleCobrado.DataSource = DSData.Tables["Detalle_Cobrado"].DefaultView;

                lblCapitalCobrado.Text = totalCapital.ToString("N2");
                lblInteresCobrado.Text = totalInteres.ToString("N2");
                lblDemoraCobrada.Text = totalDemora.ToString("N2");
                lblOtrosCobrado.Text = totalOtros.ToString("N2");


                //OBTENEMOS LOS DEUDORES DEL PRESTAMO
                db.LimpiarFiltros();
                MyTabla = db.GetById("VPRESTAMOS_SOLICITUD_DEUDORES", solicitudId.ToString(), "Solicitud_Id");
                MyTabla.TableName = "Deudores";
                DSData.Tables.Add(MyTabla);
                dtgDeudores.AutoGenerateColumns = false;
                dtgDeudores.DataSource = DSData.Tables["Deudores"].DefaultView;

                //OBTENEMOS LAS GARANTIAS
                db.LimpiarFiltros();
                MyTabla = db.GetById("VPRESTAMOS_SOLICITUD_GARANTIAS", solicitudId.ToString(), "Solicitud_Id");
                MyTabla.TableName = "Garantias";
                DSData.Tables.Add(MyTabla);
                dtgGarantias.AutoGenerateColumns = false;
                dtgGarantias.DataSource = DSData.Tables["Garantias"].DefaultView;

                //OBTENEMOS LOS DESCUENTOS APLICADOS
                db.LimpiarFiltros();
                MyTabla = db.GetById("TPRESTAMOS_DESCUENTOS_DETALLES", prestamoId, "Prestamo_Id");
                MyTabla.TableName = "Descuentos";
                DSData.Tables.Add(MyTabla);
                dtgDescuento.AutoGenerateColumns = false;
                dtgDescuento.DataSource = DSData.Tables["Descuentos"].DefaultView;

                //TOTALIZAMOS EL DESCUENTO
                totalInteres = 0; totalDemora = 0; totalOtros = 0;
                calcObject = DSData.Tables["Descuentos"].Compute("Sum(D_Interes)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalInteres = double.Parse(calcObject.ToString());
                }

                calcObject = DSData.Tables["Descuentos"].Compute("Sum(D_Demora)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalDemora = double.Parse(calcObject.ToString());
                }

                calcObject = DSData.Tables["Descuentos"].Compute("Sum(D_Otros)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalOtros = double.Parse(calcObject.ToString());
                }

                total = totalInteres + totalDemora + totalOtros;
                lblTotalInteresD.Text = totalInteres.ToString("C2");
                lblTotalDemoraD.Text = totalDemora.ToString("C2");
                lblTotalOtrosD.Text = totalOtros.ToString("C2");
                lblTotalD.Text = total.ToString("C2");


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormConsultaPrestamo_Load(object sender, EventArgs e)
        {
            tslNombreUsuario.Text = nombreUsuario;
            GetData();
        }

        private void dtgDetalleCobrado_SelectionChanged(object sender, EventArgs e)
        {
            int index = 0;
            string valorUnico = "0";
            DataRow MyFila;

            try
            {
                if (dtgDetalleCobrado.CurrentRow != null)
                {
                    index = dtgDetalleCobrado.CurrentRow.Index;
                    valorUnico = dtgDetalleCobrado["UnicoCobrado", index].Value.ToString();
                    MyFila = DSData.Tables["Detalle_Cobrado"].Select("Unico = " + valorUnico)[0];

                    txtConceptoCobro.Text = MyFila["Concepto"].ToString();
                }


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgCuotasPendientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string valorUnico = "0";
            DataRow MyFila = null;
            DateTime fecha;

            try
            {
                for (int i = 0; i < dtgCuotasPendientes.RowCount; i++)
                {
                    valorUnico = dtgCuotasPendientes["Unico", i].Value.ToString();
                    MyFila = DSData.Tables["Detalle_Pendiente"].Select("Unico = " + valorUnico)[0];
                    fecha = (DateTime) MyFila["Fecha"];

                    if (db.DateToInt(fecha) < db.DateToInt(fechaActual)) dtgCuotasPendientes.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void dtgDetalleCobrado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string valorUnico = "0";
            DataRow MyFila = null;
            int diasAtrazo = 0;

            try
            {
                for (int i = 0; i < dtgDetalleCobrado.RowCount; i++)
                {
                    diasAtrazo = 0;
                    valorUnico = dtgDetalleCobrado["UnicoCobrado", i].Value.ToString();
                    MyFila = DSData.Tables["Detalle_Cobrado"].Select("Unico = " + valorUnico)[0];

                    if( MyFila["Dias_Atrazo"].ToString().Trim() != "" )  diasAtrazo = int.Parse(MyFila["Dias_Atrazo"].ToString());
                   

                    if (diasAtrazo > 0) dtgDetalleCobrado.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgGarantias_SelectionChanged(object sender, EventArgs e)
        {
            int filaId = 0;
            try
            {
                if (dtgGarantias.CurrentRow != null)
                {
                    filaId = dtgGarantias.CurrentRow.Index;
                    txtDescripcionGarantias.Text = dtgGarantias["DescripcionGarantia", filaId].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DataRow fila0;
            int empresaId = 0, oficinaId = 0; 
            DataTable DTData = null, DTDetalle = null;
            Button btn;

            try
            {
                
                btn = (Button)sender;

                DTData = db.GetById("VPRESTAMOS", prestamoId, "Prestamo_Id");
                fila0 = DTData.Rows[0];
                empresaId = objUtil.GetAsInt("Empresa_Id", fila0);
                oficinaId = objUtil.GetAsInt("Oficina_Id", fila0);

                if (btn == btnImprimir)
                {
                    pathReporte = objUtil.GetPathReportRDLC("RptCredito");

                    db.LimpiarFiltros();
                    db.AddFiltroIgualA("Prestamo_Id", prestamoId);
                    db.AddFiltroIgualA("EsNulo", "0");
                    DTDetalle = db.GetAll("TPRESTAMOS_DETALLE", -1, db.Filtros);

                    frm.AddParm("PRESTAMO_ID", prestamoId);

                    frm.AddDS("DSData", DTData);
                    frm.AddDS("DSDetalle", DTDetalle);
                }
                
                frm.pathReporte = pathReporte;

                frm.oficinaId = oficinaId;
                frm.empresaId = empresaId;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = Text;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                DTData = null;
                DTDetalle = null;
                frm.Dispose();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
