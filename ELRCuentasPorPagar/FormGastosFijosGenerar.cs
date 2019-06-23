using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormGastosFijosGenerar : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormGastosFijosGenerar()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Generar();
        }

        public override void ImprimirPreviewRDLC()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            
            try
            {
                if (DTDetalle == null) return;
                if (DTDetalle.Rows.Count <= 0) return;              

                pathReporte = objUtil.GetPathReportRDLC("RPTGastosFijosAPagar");

                frm.pathReporte = pathReporte;
                frm.DTData = DTDetalle;
                frm.DTOficina = DTOficina;
                frm.oficinaId = OFICINA_ID;
                frm.empresaId = EMPRESA_ID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "GASTOS FIJOS A PAGAR, CORRESPONDIENTE A: ";
                frm.titulo += objUtil.GetNombreMes(objDB.FECHA_TRABAJO);
                frm.titulo += " " + objDB.FECHA_TRABAJO.Year.ToString();


                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

        void Generar()
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int conteo = 0;
            double total = 0, retItbis = 0, retISR = 0;
            double aPagar = 0;

            try
            {
                btnExcel.Enabled = false;
                btnGrabar.Enabled = false;
                btnGrabar2.Enabled = false;
                lblTotal.Text = "Cant.: 0         Total: 0.00           -Ret.: 0.00        APagar: 0.00";

                Cursor = Cursors.WaitCursor;
                if (temporalID.Trim() == "") temporalID = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                DTDetalle = objDB.GetFromSP("SP_GASTOS_FIJOS_PAGOS_ATEMPORAL", "", parms);
                DataGridDetalle.AutoGenerateColumns = false;
                DataGridDetalle.DataSource = DTDetalle.DefaultView;

                conteo = DTDetalle.Rows.Count;
                total = GetSumDetalle("Total");
                retItbis = GetSumDetalle("Retencion_Itbis");
                retISR = GetSumDetalle("Retencion_Neto");
                aPagar = GetSumDetalle("Monto_APagar");

                btnExcel.Enabled = ( conteo > 0);
                btnGrabar.Enabled = (conteo > 0);
                btnGrabar2.Enabled = (conteo > 0);

                lblTotal.Text = "Cant.: " + conteo.ToString();
                lblTotal.Text += "              Total: " + total.ToString("N2");
                lblTotal.Text += "              -Ret.: " + (retItbis + retISR).ToString("N2");
                lblTotal.Text += "              APagar: " + aPagar.ToString("N2");

                ImprimirPreviewRDLC();
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

        private void FormGastosFijosGenerar_Load(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            btnGrabar.Enabled = false;
            btnGrabar2.Enabled = false;
            lblTotal.Text = "Cant.: 0         Total: 0.00           -Ret.: 0.00        APagar: 0.00";
        }

        private void btnGrabar2_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        public override int GrabarDatos()
        {
            int spResult = -1;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                resp = objUtil.MostrarMensajePregunta("Esta seguro que desea aplicar el pago de gastos fijos");
                if(resp == DialogResult.Yes && DTDetalle.Rows.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    objDB.iniciarTransaccion();
                    spResult = objDB.EjecutarSP("SP_GASTOS_FIJOS_APLICAR_PAGOS", parms);
                    if(spResult <= 0)
                    {
                        //mostramos posibles errores
                        MostrarErrorTemporal();
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        BorrarTemporales();
                        objDB.confirmarTransaccion();
                        objUtil.MostrarMensajeInformacion("Proceso realizado de forma satisfactoria");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            return spResult;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarAEXCEL();
        }
    }
}
