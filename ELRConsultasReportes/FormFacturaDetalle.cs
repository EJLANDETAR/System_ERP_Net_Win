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
    public partial class FormFacturaDetalle : Form
    {
        public DataRow fila0 = null;
        public int facturaNo = 0;
        public FormFacturaDetalle()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFacturaDetalle_Load(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRUtils util = new WinControl_ELR_NET.ELRUtils();
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            string valorId = "0";
            DataTable DTDetalle = null;
            string numero = "0", cedulaRNC = "", nombre = "", ncf = "";
            DateTime fecha;
            double subTotal = 0, descuento = 0, itbis = 0, monto = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                if(fila0 == null && facturaNo > 0)
                {
                    db.LimpiarFiltros();
                    DTDetalle = db.GetById("TVENTAS", facturaNo.ToString(), "Numero");
                    if (DTDetalle.Rows.Count > 0) fila0 = DTDetalle.Rows[0];
                }

                valorId = util.GetAsString("Identificador_Id", fila0, "0");
                DTDetalle = db.GetById("TVENTAS_DETALLES", valorId, "Identificador_Id");
                dtgvDetalle.AutoGenerateColumns = false;
                dtgvDetalle.DataSource = DTDetalle.DefaultView;

                numero = util.GetAsString("Numero", fila0);
                cedulaRNC = util.GetAsString("CedulaRNC", fila0);
                nombre = util.GetAsString("Nombre", fila0);
                ncf = util.GetAsString("NCF", fila0);
                fecha = util.GetAsDate("Fecha", fila0);
                subTotal = util.GetAsDouble("Sub_Total", fila0);
                descuento = util.GetAsDouble("Descuento", fila0);
                itbis = util.GetAsDouble("Itbis", fila0);
                monto = util.GetAsDouble("Monto", fila0);

                lblFactura.Text = "Factura Numero: " + numero.PadLeft(7, '0');
                lblFactura.Text += "   Fecha: " + util.GetDateAsString(fecha);

                if (ncf.Trim() != "") lblFactura.Text += "   NCF: " + ncf;

                lblCliente.Text = @"Cedula\RNC: " + cedulaRNC;
                lblCliente.Text += "     " + nombre;

                lblMonto.Text = monto.ToString("N2");
                lblSubTotal.Text = "Sub Total: " + subTotal.ToString("N2");
                lblSubTotal.Text += "     Descto.: " + descuento.ToString("N2");
                lblSubTotal.Text += "     Itbis: " + itbis.ToString("N2");


                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
