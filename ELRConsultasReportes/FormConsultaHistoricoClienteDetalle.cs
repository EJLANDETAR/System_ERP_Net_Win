using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsultaHistoricoClienteDetalle : Form
    {

        public DataRow filaEntidad;
        public string nombreUsuario = "";
        public int empresaId = 0;
        public int oficinaId = 0;

        public bool MOSTRAR_COLUMNA_PRESTAMO = false;
        public bool MOSTRAR_COLUMNA_FACTURA = false;
  

        WinControl_ELR_NET.ELRUtils util = new WinControl_ELR_NET.ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();

        DataTable DTPrestamos;
        DataTable DTFacturas;
        DataTable DTDetallePago;

        public FormConsultaHistoricoClienteDetalle()
        {
            InitializeComponent();
        }

        private void FormConsultaHistoricoClienteDetalle_Load(object sender, EventArgs e)
        {
            int entidadId = 0;
            string cedulaRNC;
            string nombre;
            int prestamoId = 0;
            string telefono1, telefono2;

            try
            {
                //Buscamos los Datos de la Entidad o Cliente
                entidadId = util.GetAsInt("Entidad_Id", filaEntidad);
                cedulaRNC = util.GetAsString("CedulaRNC", filaEntidad);
                nombre = util.GetAsString("Nombre_Completo", filaEntidad);
                telefono1 = util.GetAsTelefono("Telefono1", filaEntidad);
                telefono2 = util.GetAsTelefono("Telefono2", filaEntidad);

                dtgPrestamos.Columns["Prestamo_Id"].Visible = MOSTRAR_COLUMNA_PRESTAMO;
                dtgPrestamos.Columns["Factura_No"].Visible = MOSTRAR_COLUMNA_FACTURA;

                lblCodigo.Text = entidadId.ToString().PadLeft(8, '0');
                lblCedulaRNC.Text = cedulaRNC;
                lblNombreCompleto.Text = nombre;
                
                lblTelefonos.Text = telefono1.Trim();
                if (telefono2.Trim() != "")
                {
                    if (telefono1.Trim() != "") lblTelefonos.Text += ", " + telefono2;
                    else lblTelefonos.Text = telefono2;
                }
                
                //Buscamos los Prestamos
                db.LimpiarFiltros();
                db.AddFiltroIgualA("Entidad_Id", entidadId.ToString());
                db.AddFiltroIgualA("Empresa_Id", empresaId.ToString());
                db.AddFiltroOrderBY("Prestamo_Id Desc");
                db.AddFiltroNoIgualA("Estatus_Id", "R");
                DTPrestamos = db.GetAll("VPRESTAMOS", 10, db.Filtros);
                dtgPrestamos.AutoGenerateColumns = false;
                dtgPrestamos.DataSource = DTPrestamos.DefaultView;

                //BUSCAMOS DESGLOSE DE PAGO DEL ULTIMO PRESTAMO
                if (DTPrestamos.Rows.Count > 0) prestamoId = util.GetAsInt("Prestamo_Id", DTPrestamos.Rows[0]);

                db.LimpiarFiltros();
                db.AddFiltroIgualA("Prestamo_Id", prestamoId.ToString());
                db.AddFiltroIgualA("EsNulo", "0");
                db.AddFiltroIsNull("FechaDeleted");
                DTDetallePago = db.GetAll("TPRESTAMOS_DETALLE_COBRADO", -1, db.Filtros);
                dtgDetalleCobrado.AutoGenerateColumns = false;
                dtgDetalleCobrado.DataSource = DTDetallePago.DefaultView;


                //Buscamos la Factura
                db.LimpiarFiltros();
                db.AddFiltroIgualA("Entidad_Id", entidadId.ToString());
                db.AddFiltroIgualA("Empresa_Id", empresaId.ToString());
                db.AddFiltroOrderBY("Numero Desc");
                DTFacturas =  db.GetAll("VVENTAS", 50, db.Filtros);
                dtgFactura.AutoGenerateColumns = false;
                dtgFactura.DataSource = DTFacturas.DefaultView;


            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frmReporte = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                frmReporte.titulo = "HISTORICO CLIENTE: " + lblCodigo.Text + " - " + lblCedulaRNC.Text + " " +  lblNombreCompleto.Text;
                frmReporte.pathReporte = "RptClienteHistorico";
                frmReporte.nombreUsuario = nombreUsuario;
                frmReporte.oficinaId = oficinaId;
                frmReporte.empresaId = empresaId;

                frmReporte.AddDS("DSPrestamos", DTPrestamos);
                frmReporte.AddDS("DSDetalleCobrado", DTDetallePago);

                frmReporte.ShowDialog();


            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmReporte.Dispose();
            }
        }

        private void dtgPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormConsultaPrestamosDetalle frm = new FormConsultaPrestamosDetalle();
            string valorUnico = "0";
            DataRow MyFila = null;
            string prestamoId = "0";

            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = dtgPrestamos["unico", dtgPrestamos.CurrentRow.Index].Value.ToString();
                    MyFila = DTPrestamos.Select("Unico = " + valorUnico)[0];
                    prestamoId = util.GetAsString("Prestamo_Id", MyFila, "0");

                    frm.prestamoId = prestamoId;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        private void dtgPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            string valorUnico = "0";
            string prestamoId = "0";
            DataRow MyFila = null;
            double montoCapital, montoInteres, montoDemora, montoOtros;
           
            try
            {
                montoCapital = 0; montoInteres = 0; montoDemora = 0; montoOtros = 0;

                if (DTPrestamos != null)
                {
                    if (DTPrestamos.Rows.Count > 0)
                    {
                        valorUnico = dtgPrestamos["Unico", dtgPrestamos.CurrentRow.Index].Value.ToString();
                        MyFila = DTPrestamos.Select("Unico = " + valorUnico)[0];
                        prestamoId = util.GetAsString("Prestamo_Id", MyFila, "0");
                        montoCapital = util.GetAsDouble("Capital_Pendiente", MyFila);
                        montoInteres = util.GetAsDouble("Interes_Pendiente", MyFila);
                        montoDemora = util.GetAsDouble("Demora_Pendiente", MyFila);
                        montoOtros = util.GetAsDouble("Otros_Pendiente", MyFila);
                    }
                }

                lblPrestamoId.Text = prestamoId.PadLeft(8, '0');
                lblCapital.Text = montoCapital.ToString("N2");
                lblInteres.Text = montoInteres.ToString("N2");
                lblDemora.Text = montoDemora.ToString("N2");
                lblOtros.Text = montoOtros.ToString("N2");
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }
    }
}
