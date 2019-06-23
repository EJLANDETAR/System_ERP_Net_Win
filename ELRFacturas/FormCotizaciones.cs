using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormCotizaciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCotizaciones()
        {
            InitializeComponent();
        }

        public override void Agregar()
        {
            //base.Agregar();
            FormFacturasOtrosDocR frm = new FormFacturasOtrosDocR();

            try
            {
                frm.tipo = "COTIZACION";
                frm.nombreUsuario = nombreUsuario;
                frm.EMPRESA_ID = empresaID;
                frm.OFICINA_ID = oficinaID;
                frm.DTVariablesSYS = DTVariablesSYS;
                frm.DTMenu = DTMenu;
                frm.EnEjecusion = true;

                frm.ShowDialog();

                RealizarBusquedaSencilla();

                if (frm.lOK) Imprimir();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            string valorUnico = "0";
            DataRow fila0;
            int valorId = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0, tipoFormFactura = 0;
            string temporalId = "", valor = "";
            WinControl_ELR_NET.ELRFormRegistro frm = null;
            bool resultado = false;

            try
            {
                if (DataGridConsulta.RowCount > 0)
                {
                    if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn) Modificar();
                    else if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        //Validamos el Usuario Tenga Caja Abierta
                        if (cajaNo <= 0 && REQUIERE_CIERRE_OPERACIONES) return;

                        Cursor = Cursors.WaitCursor;

                        index = DataGridConsulta.CurrentRow.Index;
                        valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        valorId = objUtil.GetAsInt("Identificador_Id", fila0);

                        //MEDIANTE UN STORE PROCEDURE CARGAMOS LA FACTURA
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Id", valorId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_VENTAS_CARGAR_DOCUMENTO_AFACTURAR", parms);
                        if (spReturn < 0) MostrarErrorTemporal(temporalId);
                        else
                        {
                            objDB.confirmarTransaccion();

                            valor = objDB.GetValorVariable("TIPO_FORM_FACTURA");
                            int.TryParse(valor, out tipoFormFactura);

                            if (tipoFormFactura <= 1) frm = new FormFactura();
                            else if (tipoFormFactura == 2) frm = new FormFactura2();
                            else frm = new FormFacturasListR();

                            frm.tipo = "COTIZACION";
                            frm.EMPRESA_ID = empresaID;
                            frm.OFICINA_ID = oficinaID;
                            frm.nombreUsuario = nombreUsuario;
                            frm.DTVariablesSYS = DTVariablesSYS;
                            frm.temporalID = temporalId;
                            frm.DTMenu = DTMenu;
                            frm.EnEjecusion = true;
                            frm.NuevoRegistroAlGrabar = false;

                            frm.ShowDialog();

                            RealizarBusquedaSencilla();

                        }

                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                if (frm != null) frm.Dispose();
            }
        }

        private void FormCotizaciones_Load(object sender, EventArgs e)
        {
            ELRLogicaNegocio.Cajas objCaja = new ELRLogicaNegocio.Cajas();
            try
            {
                cajaNo = objCaja.getCajaAbierta(nombreUsuario);

                DataGridConsulta.Columns["btnFacturar"].Visible = (cajaNo > 0 || !REQUIERE_CIERRE_OPERACIONES);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string info = "COTIZACION N0.: 000000,   Sub Total: 0.00  Itbis: 0.00   Descuento: 0.00  Total: 0.00";
            DataRow fila0;
            string valorUnico = "0";
            int numero = 0;
            double subTotal = 0, totalItbis = 0, totalDescto = 0, total = 0;
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    numero = objUtil.GetAsInt("Numero", fila0);
                    subTotal = objUtil.GetAsDouble("Sub_Total", fila0);
                    totalItbis = objUtil.GetAsDouble("Total_Itbis", fila0);
                    totalDescto = objUtil.GetAsDouble("Total_Descuento", fila0);
                    total = objUtil.GetAsDouble("Monto", fila0);

                    info = "COTIZACION NO.: " + numero.ToString().PadLeft(6, '0') + ",";
                    info += "     Sub Total: " + subTotal.ToString("N2");
                    info += "     Itbis: " + totalItbis.ToString("N2");
                    info += "     Descuento: " + totalDescto.ToString("N2");
                    info += "      Total: " + total.ToString("N2");
                }

                lblInfo.Text = info;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            ELRLogicaNegocio.VentasOtrosDocumentos lVentasOtros = new ELRLogicaNegocio.VentasOtrosDocumentos();
            DataTable DTData = null;
            string valorUnico = "0", valorId = "0";
            DataRow fila0;

            try
            {
                if (DataGridConsulta.RowCount > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("Identificador_Id", fila0);

                    if (metodoImp > 0) DTData = objDB.GetById("VVENTAS_OTROS_DOCUMENTOS_DETALLES", valorId, "Identificador_Id");

                    lVentasOtros.MyData = DTData;
                    lVentasOtros.NombreImpresora = impresoraDefault;
                    lVentasOtros.numeroCopias = IMPRIME_TICKET_COPIA;
                    lVentasOtros.logo = logoEmpresa;

                    if (metodoImp <= 1) lVentasOtros.ImprimirTicket();
                    else if (metodoImp == 2) lVentasOtros.PrintMatricial80();
                    else ImprimirPreviewRDLC("rptVentas_Otros_Documentos", "VVENTAS_OTROS_DOCUMENTOS_DETALLES", valorId, "Identificador_Id");
                                        
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
    }
}
