using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormCajaRecibosInicialR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormCajaRecibosInicialR()
        {
            InitializeComponent();
        }

        private void FormCajaRecibosInicialR_Load(object sender, EventArgs e)
        {

        }

        public override void MostrarDataRegistroSel()
        {
            string cedulaRNC, nombre;
            double monto = 0;
            int facturaNo = 0;
            int prestamoId = 0;

            try
            {
                cedulaRNC = objUtil.GetAsString("CedulaRNC", drRegistroSel);
                nombre = objUtil.GetAsString("Nombre_Entidad", drRegistroSel);
                monto = objUtil.GetAsDouble("Monto_Inicial", drRegistroSel);
                facturaNo = objUtil.GetAsInt("Factura_Numero", drRegistroSel);
                prestamoId = objUtil.GetAsInt("Prestamo_Id", drRegistroSel);

                txtCedulaRNC.Text = cedulaRNC;
                txtNombreEntidad.Text = nombre;
                txtMonto.Text = monto.ToString("N2");
                lblMontoLetra.Text = Numalet.ToCardinal(monto).ToUpper();
                txtConcepto.Text = "INICIAL FACTURA NO.: " + facturaNo.ToString().PadLeft(7, '0');

                Text = "INICIAL FACTURA NO.: " + facturaNo.ToString().PadLeft(7, '0');

                SetValorEncabezado("Factura_Numero", facturaNo);
                SetValorEncabezado("Documento_Id", prestamoId);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }
        }

        public override void ImprimirTicket()
        {
            ELRLogicaNegocio.Cajas lCaja = new ELRLogicaNegocio.Cajas();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lCaja.ImprimirTicketOtrosIngresos(DTVistaData, IMPRIME_TICKET_COPIA, impresoraDefault);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public override void ImprimirEnOtroFormato()
        {
            string nombreArchivo = "";
            string logoEmpresa = "";
            Bitmap imgLogo;
            double monto = 0;

            try
            {
                nombreArchivo = Environment.CurrentDirectory + @"\Reportes\cajaReciboOtros.frx";
                monto = objUtil.GetAsDouble("Monto", DTVistaData.Rows[0]);
                montoLetras = Numalet.ToCardinal(monto);

                using (FastReport.Report report = new FastReport.Report())
                {
                    report.Load(nombreArchivo);
                    report.RegisterData(DTVistaData, "VCAJAS_RECIBOS");
                    report.RegisterData(DTOficina, "VEMPRESAS_OFICINAS");

                    report.SetParameterValue("MONTO_LETRA", montoLetras);

                    //Vamos a asignar el logo
                    logoEmpresa = Environment.CurrentDirectory + @"\images\logo.png";

                    if (File.Exists(logoEmpresa))
                    {

                        imgLogo = (Bitmap)Image.FromFile(logoEmpresa);
                        FastReport.PictureObject ptLogo = report.FindObject("ptLogo") as FastReport.PictureObject;
                        ptLogo.Image = imgLogo;
                    }

                    report.PrintSettings.ShowDialog = false;
                    report.PrintSettings.Printer = impresoraDefault;
                    report.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void ImprimirPreviewRDLC()
        {
            double monto = 0;
            try
            {
                monto = objUtil.GetAsDouble("Monto", DTVistaData.Rows[0]);
                montoLetras = Numalet.ToCardinal(monto);

                base.ImprimirPreviewRDLC();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override int GrabarDatos()
        {
            int resultado = -1;
            try
            {
                SetValorEncabezado("Empresa_Id", EMPRESA_ID);
                SetValorEncabezado("Oficina_Id", OFICINA_ID);

                resultado = base.GrabarDatos();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }


    }
}
