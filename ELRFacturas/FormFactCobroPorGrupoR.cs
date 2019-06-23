using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormFactCobroPorGrupoR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormFactCobroPorGrupoR()
        {
            InitializeComponent();
        }

        public override void TotalizarDetalle()
        {
            //base.TotalizarDetalle();
            double monto = 0;
            double montoAPagar = 0;
            string concepto = "";
           
            try
            {
                txtConcepto.Text = "";

                monto = GetSum("Monto_APagar", DSDatos.Tables["Detalle"]);
                lblMontoLetra.Text = Numalet.ToCardinal(monto).ToUpper();

                btnGrabar.Enabled = (monto > 0);

                foreach (DataRow item in DSDatos.Tables["Detalle"].Rows)
                {
                    monto = objUtil.GetAsDouble("Monto_Pendiente", item);
                    montoAPagar = objUtil.GetAsDouble("Monto_APagar", item);

                    if(montoAPagar > 0)
                    {
                        if (concepto.Trim().Length > 0) concepto += ", ";
                        if (montoAPagar >= monto) concepto += "SALDO " + objUtil.GetAsString("Concepto", item);
                        else concepto += "ABONO A " + objUtil.GetAsString("Concepto", item);
                    }
                }

                txtConcepto.Text = concepto;

                if (concepto.Trim() != "") btnGrabar.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAplicarTodo_Click(object sender, EventArgs e)
        {
            string valorUnico = "0";
            string SSQL = "";
            double monto = 0;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                foreach (DataRow item in DSDatos.Tables["Detalle"].Rows)
                {
                    valorUnico = objUtil.GetAsString("Unico", item);
                    monto = objUtil.GetAsDouble("Monto_Pendiente", item);

                    SSQL = "UPDATE " + TablaDetalle + " Set Monto_APagar = " + monto.ToString() + " Where Unico = " + valorUnico;
                    objDB.EjecutarSQL(SSQL);

                    item["Monto_APagar"] = monto;
                }

                monto = GetSum("Monto_APagar", DSDatos.Tables["Detalle"]);
                txtMonto.Text = monto.ToString("N2");

                TotalizarDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string valorUnico = "0";
            string SSQL = "";
            
            try
            {
                this.Cursor = Cursors.WaitCursor;

                foreach (DataRow item in DSDatos.Tables["Detalle"].Rows)
                {
                    valorUnico = objUtil.GetAsString("Unico", item);

                    SSQL = "UPDATE " + TablaDetalle + " Set Monto_APagar = 0 " + " Where Unico = " + valorUnico;
                    objDB.EjecutarSQL(SSQL);

                    item["Monto_APagar"] = 0;
                }

                TotalizarDetalle();
                txtMonto.Text = "0";
                txtMonto.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public override void PostLineaDetalle(DataGridView senderGrid = null, string nombreColumnaUnico = "Unico")
        {
            base.PostLineaDetalle(senderGrid, nombreColumnaUnico);
        }

        private void FormFactCobroPorGrupoR_Load(object sender, EventArgs e)
        {
            if (EnEjecusion)
            {
                if (metodoImprimir == 1) NombreReporte = "RptReciboCajaMatricial";
                else NombreReporte = "RptReciboCaja";     
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

        public override int GrabarDatos()
        {
            int resultado = 0;
            string valor = "0";
            bool esNCF = false;
            try
            {
                SetValorEncabezado("Empresa_Id", EMPRESA_ID);
                SetValorEncabezado("Oficina_Id", OFICINA_ID);

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

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            double monto = 0, montoAPagar = 0;
            double montoPendiente = 0;
            string valorUnico = "0";
            DataRow fila0;
           

            try
            {
                if (txtMonto.Text.Trim() == "") txtMonto.Text = "0";

                double.TryParse(txtMonto.Text, out monto);
                montoPendiente = GetSum("Monto_Pendiente", DSDatos.Tables["Detalle"]);
                montoAPagar = monto;

                if(monto >  montoPendiente)
                {
                    objUtil.MostrarMensajeAdvertencia("EL MONTO A PAGAR NO PUEDE SER MAYOR A: " + montoPendiente.ToString("N2"));
                    txtMonto.Text = montoPendiente.ToString();
                    montoAPagar = montoPendiente;
                }

                string SSQL = "";


                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < DataGridDetalle.RowCount; i++)
                {
                    valorUnico = DataGridDetalle["Unico", i].Value.ToString();
                    fila0 = DSDatos.Tables["Detalle"].Select("Unico = " + valorUnico)[0];
                    montoPendiente = objUtil.GetAsDouble("Monto_Pendiente", fila0);

                    SSQL = "UPDATE " + TablaDetalle + " Set Monto_APagar = "; 
                    if (montoPendiente >= montoAPagar)
                    {
                        fila0["Monto_APagar"] = montoAPagar;
                        SSQL += montoAPagar.ToString();
                        montoAPagar = 0;
                    }
                    else if(montoAPagar > montoPendiente)
                    {
                        fila0["Monto_APagar"] = montoPendiente;
                        SSQL += montoPendiente.ToString();
                        montoAPagar -= montoPendiente;
                    }
                    else
                    {
                        fila0["Monto_APagar"] = 0;
                        SSQL += " 0";
                    }


                    //APLICAMOS LOS CAMBIOS EN EL TEMPORAL;
                    SSQL += " WHERE Unico = " + valorUnico;
                    objDB.EjecutarSQL(SSQL);

                }

                TotalizarDetalle();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void FormFactCobroPorGrupoR_Activated(object sender, EventArgs e)
        {
            txtMonto.Focus();
        }
    }
}
