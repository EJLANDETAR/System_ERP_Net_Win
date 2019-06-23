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
    public partial class FormCajaReciboCXC : WinControl_ELR_NET.ELRFormRegistro
    {
        double saldo = 0, montoCuota, totalVP = 0;

        public FormCajaReciboCXC()
        {
            InitializeComponent();
        }

        public override void MostrarDataRegistroSel()
        {
            double capital = 0, interes = 0, demora = 0, otros = 0;
            string prestamoId = "0";
            int diasAtrazo = 0;
            try
            {
                base.MostrarDataRegistroSel();
                prestamoId = objUtil.GetAsString("Prestamo_Id", drRegistroSel);
                lblDocumentoId.Text = prestamoId.PadLeft(7, '0');
                SetValorEncabezado("Documento_Id", prestamoId);

                lblNombreCliente.Text = objUtil.GetAsString("ANombre", drRegistroSel);

                lblTipoDocumento.Text = objUtil.GetAsString("Descripcion_Tipo_Garantia", drRegistroSel);
                lblFecha.Text = objUtil.GetDateAsString("Fecha", drRegistroSel);
                lblFechaPagoAnt.Text = objUtil.GetDateAsString("Fecha_Ultimo_Abono", drRegistroSel);
                lblFechaProxPago.Text = objUtil.GetDateAsString("Fecha_Proximo_Pago", drRegistroSel);
                lblFechaVence.Text = objUtil.GetDateAsString("Fecha_Termino", drRegistroSel);
                diasAtrazo = objUtil.GetAsInt("Dias_Atrazo", drRegistroSel);
                lblDiasAtrazo.Text = diasAtrazo.ToString("N0");

                capital = objUtil.GetAsDouble("Capital_Pendiente", drRegistroSel);
                interes = objUtil.GetAsDouble("Interes_Pendiente", drRegistroSel);
                demora = objUtil.GetAsDouble("Demora_Pendiente", drRegistroSel);
                otros = objUtil.GetAsDouble("Otros_Pendiente", drRegistroSel);
                totalVP = objUtil.GetAsDouble("Total_VP", drRegistroSel);
                montoCuota = objUtil.GetAsDouble("Monto_Cuota", drRegistroSel);
                lblMontoCuota.Text = montoCuota.ToString("N2");

                saldo = capital + interes + demora + otros;

                lblCapital.Text = capital.ToString("N2");
                lblInteres.Text = interes.ToString("N2");
                lblDemora.Text = demora.ToString("N2");
                lblOtros.Text = otros.ToString("N2");
                lblBalancePendiente.Text = saldo.ToString("N2");
                lblMontoVP.Text = totalVP.ToString("N2");

                rdbPonerseAldia.Enabled = (totalVP > 0);
                if (totalVP > 0) toolTip1.SetToolTip(rdbPonerseAldia, totalVP.ToString("N2") + " " + Numalet.ToCardinal(totalVP).ToUpper());
                toolTip1.SetToolTip(rdbSaldar, saldo.ToString("N2") + " " + Numalet.ToCardinal(saldo).ToUpper());

                if (saldo < montoCuota)
                {
                    montoCuota = saldo;
                    rdbSaldar.Checked = true;
                }


                SetValorEncabezado("Tipo_NCF", drRegistroSel["Tipo_NCF"].ToString());
                SetValorEncabezado("CedulaRNC", drRegistroSel["CedulaRNC"].ToString());
                SetValorEncabezado("Entidad_Id", drRegistroSel["Entidad_Id"].ToString());
                SetValorEncabezado("Capital_PAnterior", drRegistroSel["Capital_Pendiente"].ToString());

               

                rdbPonerseAldia.Checked = false;
                rdbSaldar.Checked = false;
                rdbAbono.Checked = true;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                this.Close();
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            double monto = 0;
            try
            {
                monto = double.Parse(txtMonto.Text);
                txtMontoLetra.Text = Numalet.ToCardinal(monto).ToUpper();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            ELRConsultasReportes.FormConsultaPrestamosDetalle frm = new ELRConsultasReportes.FormConsultaPrestamosDetalle();
            try
            {
                frm.prestamoId = lblDocumentoId.Text;
                frm.nombreUsuario = nombreUsuario;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void ImprimirTicket()
        {
            ELRLogicaNegocio.Cajas lCaja = new ELRLogicaNegocio.Cajas();
            try
            {

                this.Cursor = Cursors.WaitCursor;
                lCaja.DTDataCXC = DTVistaData;
                lCaja.NombreImpresora = impresoraDefault;
                lCaja.montoLetra = montoLetras;
                lCaja.numeroCopias = IMPRIME_TICKET_COPIA;
                lCaja.logo = logoEmpresa;
                lCaja.MOSTRAR_DETALLE_FACTURAS_PAGADAS = MOSTRAR_DETALLE_FACTURAS_PAGADAS;

                lCaja.ImprimirTicketReciboCXC();
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

        public override void ImprimirEnMatricial()
        {
            ELRLogicaNegocio.Cajas lCaja = new ELRLogicaNegocio.Cajas();
            double monto = 0;
            try
            {

                this.Cursor = Cursors.WaitCursor;

                monto = objUtil.GetAsDouble("Monto", DTVistaData.Rows[0]);

                lCaja.DTDataCXC = DTVistaData;
                lCaja.NombreImpresora = impresoraDefault;
                lCaja.montoLetra = Numalet.ToCardinal(monto);
                lCaja.logo = logoEmpresa;
                lCaja.MOSTRAR_DETALLE_FACTURAS_PAGADAS = MOSTRAR_DETALLE_FACTURAS_PAGADAS;

                //MANDAMOS a Imprimir en un Thread
                Thread tAux = new Thread(new ThreadStart(lCaja.ImprimirReciboMatricial80));
                tAux.Start();

                while (!tAux.IsAlive) ;


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

        private void rdbAbono_CheckedChanged(object sender, EventArgs e)
        {
            double monto = 0;
            try
            {
                if (rdbSaldar.Checked)
                {
                    txtMonto.SetValor(saldo.ToString("N2"));
                    txtMonto.ReadOnly = true;
                    txtMontoLetra.Text = Numalet.ToCardinal(saldo).ToUpper();
                }
                else if(rdbPonerseAldia.Checked)
                {
                    txtMonto.SetValor(totalVP.ToString("N2"));
                    txtMonto.ReadOnly = true;
                    txtMontoLetra.Text = Numalet.ToCardinal(totalVP).ToUpper();
                }
                else
                {
                    txtMonto.SetValor(montoCuota.ToString("N2"));
                    txtMonto.ReadOnly = false;
                    txtMontoLetra.Text = Numalet.ToCardinal(montoCuota).ToUpper();
                    txtMonto.Focus();
                }

                monto = objUtil.ConvertirANumero(txtMonto.Text);
                SetValorEncabezado("Monto", monto);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormCajaReciboCXC_Activated(object sender, EventArgs e)
        {
            if (txtMonto.Enabled) txtMonto.Focus();
        }

        public override void ImprimirPreviewRDLC()
        {
            double monto = 0;
            string valorId = "0", pathReporte = "";
            DataRow fila0 = null;
            DataTable DTDetalle = null;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                fila0 = DTVistaData.Rows[0];
                valorId = objUtil.GetAsString("Recibo_Id", fila0, "0");
                monto = objUtil.GetAsDouble("Monto", fila0);
                montoLetras = Numalet.ToCardinal(monto);
                pathReporte = objUtil.GetPathReportRDLC("RptCreditoRecibo");

                
                DTDetalle = objDB.GetById("TPRESTAMOS_DETALLE_COBRADO", valorId, "Recibo_Id");

                frm.pathReporte = pathReporte;
                frm.DTOficina = DTOficina;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "RECIBO NO.: " + valorId.PadLeft(7, '0');
                frm.AddDS("DSData", DTVistaData);
                frm.AddDS("DSDetalle", DTDetalle);
                frm.AddParm("MONTO_LETRAS", montoLetras.ToUpper());

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                DTDetalle = null;
                frm.Dispose();
            }

        }

        private void FormCajaReciboCXC_Load(object sender, EventArgs e)
        {
            if (EnEjecusion)
            {
                if (metodoImprimir == 1) NombreReporte = "RptReciboCajaMatricial";
                else NombreReporte = "RptReciboCaja";
            }
        }

        public override int GrabarDatos()
        {
            string valor = "";
            bool esNCF = false;
            int resultado = -1;

            try
            {
                valor = objUtil.GetValorVariable("CAJA_RECIBO_GENERA_NCF", DTVariablesSYS, "0").ToUpper();
                esNCF = (valor == "1" || valor == "TRUE");
                if (esNCF == false) SetValorEncabezado("Tipo_NCF", 0);
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
