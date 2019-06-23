using FastReport;
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
    public partial class FormFacturasList : WinControl_ELR_NET.FormPlantillaIndex
    {
        int tipoFormFactura = 2;
        bool esTicket = false,  esMatricial = false;

        public FormFacturasList()
        {
            InitializeComponent();
        }

        private void FormFacturasList_Load(object sender, EventArgs e)
        {
            string valor = "";
            try
            {
                //ASIGNAMOS LOS TIPO DE FORMULARIOS A USAR
                valor = objUtil.GetValorVariable("TIPO_FORM_FACTURA", DTVariablesSYS);
                int.TryParse(valor, out tipoFormFactura);

                if (tipoFormFactura <= 1) FormularioRegistro = "ELRFacturas.FormFactura";
                else if (tipoFormFactura == 2) FormularioRegistro = "ELRFacturas.FormFactura2";
                else FormularioRegistro = "ELRFacturas.FormFacturasListR";

                //buscamos el metodos a imprimir
                esTicket = objUtil.GetValorVariableAsBool("FACTURA_TIPO_TICKET", DTVariablesSYS);
                esMatricial = objUtil.GetValorVariableAsBool("FACTURA_TIPO_MATRICIAL", DTVariablesSYS);

                objDB.GetFechasOficina();
                dtpFecha1.Value = objUtil.getPrimeraFechaMes(objDB.FECHA_TRABAJO);
                dtpFecha2.Value = objDB.FECHA_TRABAJO;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void RealizarBusquedaSencilla()
        {
            //base.RealizarBusquedaSencilla();
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (txtABuscar.Text.Trim() != "") objDB.AddFiltroContengaA("Nombre", txtABuscar.Text.Trim());

                GetData();
                pnOpcionesBusqueda.Visible = false;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            double subTotal = 0, itbis = 0, total = 0;
            double aCredito = 0, aContado = 0;
            try
            {
                if (cajaNo > 0) objDB.AddFiltroIgualA("Caja_Id", cajaNo.ToString());

                base.GetData(opcion);

                subTotal = GetSum("Sub_Total");
                itbis = GetSum("Itbis");
                total = GetSum("Monto");
                aCredito = GetSum("Monto_ACredito");
                aContado = GetSum("Monto_AlContado");

                lblCantidadRegistro.Text = "Sub Total: " + subTotal.ToString("N2") + "        Itbis: " + itbis.ToString("N2") + "        Total: " + total.ToString("N2");
                lblCantidadRegistro.Text += "        Al Contado: " + aContado.ToString("N2") + "        A Credito: " + aCredito.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            string valorUnico = "0";
            string valorId = "0";
            string nombreReporte = "";
            DataRow MyFila = null;
            DataTable DTVistaData = null;
            ELRLogicaNegocio.Facturas lFactura = new ELRLogicaNegocio.Facturas();
            int tipoNCF = 0;
            int diasCredito = 0;
            double montoACredito = 0;
            WinControl_ELR_NET.FormSuCambio frmSuCambio = new WinControl_ELR_NET.FormSuCambio();
            Thread t;

            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("Identificador_Id", MyFila, "0");

                    DTVistaData = objDB.GetById("VVENTAS_DETALLE", valorId, "Identificador_Id");
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", DTVistaData.Rows[0]);
                    diasCredito = objUtil.GetAsInt("Dias_Credito", DTVistaData.Rows[0]);
                    montoACredito = objUtil.GetAsDouble("Monto_ACredito", DTVistaData.Rows[0]);

                    lFactura.MyData = DTVistaData;
                    lFactura.NombreImpresora = impresoraDefault;
                    lFactura.numeroCopias = IMPRIME_TICKET_COPIA;
                    lFactura.logo = logoEmpresa;

                    if (tipoNCF > 0) nombreReporte = "rptFacturaB";
                    else nombreReporte = "rptFactura";

                    frmSuCambio.mostrarImprimir = true;
                    frmSuCambio.esTicket = true;
                    frmSuCambio.esMatricial = true;
                    frmSuCambio.metodoImp = metodoImp;
                    frmSuCambio.ShowDialog();

                    if (frmSuCambio.metodoImp == 1)
                    {
                        t = new Thread(lFactura.ImprimirTicket);
                        t.Start();   
                    }
                    else if (frmSuCambio.metodoImp == 2)
                    {
                        t = new Thread(lFactura.PrintMatricial80);
                        t.Start();
                    }
                    else if (frmSuCambio.metodoImp == 3) ImprimirPreviewRDLC(nombreReporte, "VVENTAS_DETALLE", valorId, "Identificador_Id");
                                       
                }
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

        public override void ShowPreview()
        {
            string valorUnico = "0";
            DataRow fila0;
            string valorId = "0", nombreReporte = "rptFactura";
            int tipoNCF = 0;
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    tipoNCF = objUtil.GetAsInt("Tipo_NCF", fila0);
                    valorId = objUtil.GetAsString("Identificador_Id", fila0, "0");

                    if (tipoNCF > 0) nombreReporte = "rptFacturaB";

                    ImprimirPreviewRDLC(nombreReporte, "VVENTAS_DETALLE", valorId, "Identificador_Id");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
