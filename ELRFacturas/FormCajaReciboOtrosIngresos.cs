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
    public partial class FormCajaReciboOtrosIngresos : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormCajaReciboOtrosIngresos()
        {
            InitializeComponent();
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            double monto = 0;
            try
            {
                lblMontoLetra.Text = "";

                monto = double.Parse(txtMonto.Text);
                lblMontoLetra.Text = Numalet.ToCardinal(monto).ToUpper();
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
                lCaja.logo = logoEmpresa;
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

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBuscarEntidad.filaSelecionada != null)
                {
                    txtCedulaRNC.Text = btnBuscarEntidad.filaSelecionada["CedulaRNC"].ToString();
                    txtNombreEntidad.Text = btnBuscarEntidad.filaSelecionada["Nombre_Completo"].ToString();

                    DSDatos.Tables[0].Rows[0]["Tipo_NCF"] = btnBuscarEntidad.filaSelecionada["Tipo_NCF"].ToString();

                    txtMonto.Focus();
                }
                else txtNombreEntidad.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
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

                //MANDAMOS a Imprimir en un Thread
                Thread tAux = new Thread(new ThreadStart(lCaja.ImprimirReciboOtrosMatricial80));
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

        private void FormCajaReciboOtrosIngresos_Load(object sender, EventArgs e)
        {
            if (EnEjecusion)
            {
                NombreReporte = "RptReciboCajaOtros";
            }
        }
    }
}
