using Microsoft.Reporting.WinForms;
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
using System.Transactions;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    //CREAMOS STRUTURA PARA LOS TIPOS DE VALIDACION
    public enum tbTipoValidacion
    {
        NoVacio,
        MayorOIgualA,
        MenorOIgualA,
        DiferenteA,
        EnRango,
        IgualFechaTrabajo,
        LongitudMinima,
        NumeroTelefono,
        EMail,
        SoloNumero,
        Decimal
    }

    public enum tbTipoTotaliza
    {
        Sum,
        Count,
        Avg,
        Min,
        Max,
        StDev,
        Var
    }

    public enum tbTipoFecha
    {
        FechaSistema,
        FechaTrabajo,
        FechaContable
    }

    public enum tbTipoImpresion
    {
        NoImprimir,
        TicketRDLC,
        PreviewRDLC,
        Ticket,
        TicketEnLinea
    }



    public partial class ELRFormRegistro : Form
    {

        //DECLARAMOS NUEVAS PROPIEDADES
        [Category("PropiedadesELR")]
        public int CodigoOperacion { get; set; }

        [Category("PropiedadesELR")]
        public string TablaEncabezado { get; set; }

        [Category("PropiedadesELR")]
        public string CamposAExcluirEnc { get; set; }

        [Category("PropiedadesELR")]
        public string TablaDetalle { get; set; }

        [Category("PropiedadesELR")]
        public string CamposAExcluirDet { get; set; }

        [Category("PropiedadesELR")]
        public string NombreCampoID { get; set; }

        [Category("PropiedadesELR")]
        public bool EsConTemporal { get; set; }

        [Category("PropiedadesELR")]
        public string SPCargaATemporal { get; set; }

        [Category("PropiedadesELR")]
        public string SPGraba { get; set; }

        [Category("PropiedadesELR")]
        public bool MensajeAlGrabar { get; set; }

        [Category("PropiedadesELR")]
        public bool NuevoRegistroAlGrabar { get; set; }

        [Category("PropiedadesELR")]
        public DataGridView DataGridDetalle { get; set; }

        [Category("PropiedadesELR")]
        public Valida[] AValidar { get; set; }

        [Category("PropiedadesELR")]
        public Totaliza[] ATotalizar { get; set; }

        [Category("PropiedadesELR")]
        public bool MostrarDesglosePago { get; set; }

        [Category("PropiedadesELR")]
        public bool EditarClienteDesglose { get; set; }


        [Category("PropiedadesELR")]
        public bool PermiteACredito { get; set; }

        [Category("PropiedadesELR")]
        public bool EnEjecusion { get; set; }

        [Category("PropiedadesELR")]
        public bool RequiereCliente { get; set; }

        [Category("PropiedadesELR")]
        public tbTipoFecha TipoFecha { get; set; }

        [Category("PropiedadesELR")]
        public bool RequiereCajaAbierta { get; set; }

        [Category("PropiedadesELR")]
        public string ValorParmTipo { get; set; }

        [Category("PropiedadesELR")]
        public string LCamposPostearDetalle { get; set; }

        [Category("PropiedadesELR")]
        public string MensajePregunta { get; set; }

        [Category("PropiedadesELR")]
        public string TablaProducto { get; set; }

        [Category("PropiedadesELR")]
        public string TablaCuentasDetalles { get; set; }

        [Category("PropiedadesELR")]
        public bool OmitirMetodosDataGrid { get; set; }

        [Category("PropiedadesELR")]
        public bool ExcluirValidacionCierre { get; set; }

        [Category("PropiedadesELR")]
        public bool EsAgregarLineaVacia { get; set; }

        [Category("ImprimirELR")]
        public tbTipoImpresion FormaImprimir { get; set; }

        [Category("ImprimirELR")]
        public string NombreReporte { get; set; }

        [Category("ImprimirELR")]
        public string TituloReporte { get; set; }

        [Category("ImprimirELR")]
        public string NombreVistaImprimir { get; set; }

        [Category("ImprimirELR")]
        public bool ImprimirAlGrabar { get; set; }

        [Category("ImprimirELR")]
        public string CampoIdImprimir { get; set; }

        [Category("ImprimirELR")]
        public TabControl TabRegistro { get; set; }

        [Category("PropiedadesELR")]
        public bool RequiereLineaDetalle { get; set; }

        [Category("PropiedadesELR")]
        public bool EsCambiarFecha { get; set; }

        [Category("PropiedadesELR")]
        public ReportViewer MyReport { get; set; }

        [Category("PropiedadesELR")]
        public bool EsCopia { get; set; }

        [Category("PropiedadesELR")]
        public FlowLayoutPanel MenuPanel { get; set; }

        [Category("PropiedadesELR")]
        public bool MenuLateral { get; set; }

        [Category("PropiedadesELR")]
        public bool MenuLateralBringToFront { get; set; }

        [Category("EditEntidadOpciones")]
        public bool EsEditEntidad { get; set; }

        [Category("EditEntidadOpciones")]
        public string TituloEditEntidad { get; set; }

        [Category("EditEntidadOpciones")]
        public bool PermiteCambiarEntidad { get; set; }

        //FINAL DECLARACION DE PROPIEDADES


        //VARIABLES PRIVADAS
        public string temporalID;
        DateTime fechaCajaAbierta;
        public DataTable DTOficina = null;
        public bool esLicenciaActiva = false;
        int diasLimiteSinLicensia = 0;
        public bool REQUIERE_CIERRE_OPERACIONES = false;
        public bool REQUIERE_CAJA_ABIERTA = false;
        public bool REQUIERE_CONVERTIR_ADOLARES = false;
        public bool MOSTRAR_DETALLE_FACTURAS_PAGADAS = false;
        public DataRow detalleFilaActual;
        public List<ReportesDS> MyParametrosDS;

        //FINAL VARIABLES PRIVADAS

        //VARIABLES PUBLICAS
        public bool esNuevo = false;
        public string VALOR_ID;
        public int EMPRESA_ID = 0;
        public int OFICINA_ID = 0;
        public string impresoraDefault = "";
        public bool usaCliente0 = false;
        public string nombreMenu = "";
        public string tipo = "";

        public bool lOK = false;
        public DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();

        public ELRUtils objUtil = new ELRUtils();
        public DataRow drCliente;
        public DataRow drProducto;

        public DataTable DTVistaData = null;
        public DataTable DTVariablesSYS = null;
        public DataSet DSGlobal = null;
        public DataTable DTLicense = null;

        public string nombreUsuario;
        public int cajaId = -1;
        public int aperturaCajaNo = -1;
        public DataRow drRegistroSel;
        public double aCredito = 0;

        public string NOMBRE_EMPRESA_OFICINA = "";
        public string EMPRESA_SLOGAN = "";
        public string NOMBRE_OFICINA = "";
        public string DIRECCION_OFICINA = "";
        public string TELEFONOS_OFICINA = "";
        public string RNC_EMPRESA = "";
        public DateTime FECHA_TRABAJO;

        public int IMPRIME_TICKET_COPIA = 0;
        public string montoLetras = "";

        public DirectoryInfo dirPath;
        public DirectoryInfo dirImage;

        public DataTable DTMonedaUS;
        public double tasaCambioUS = 0;
        public int metodoImprimir = 0;
        public int defPaisId = 0, defProvinciaId = 0, defMunicipioId = 0;
        public bool isError = false;


        public string COLUMNA_ACTUAL_GRID_DETALLE = "";
        public Image logoEmpresa = null;
        public bool esCopia = false;
        public bool esSolicitudCredito = false;
        public bool esGarantiaPersonal = false;
        public bool esCoDeudor = false;
        public int entidadId = 0;
        public int solicitudId = 0;
        public int metodoImp = 0;
        public int nivelForm = 0;
        public Color coloP = Color.FromArgb(0, 100, 182);
        public Color colorV = Color.FromArgb(50, 205, 50);
        public Color colorR = Color.FromArgb(178, 34, 34);

        public DataTable DTDetalle = null;

        private bool imprimeEnSuCambio = false;

        bool esLoad;

        public DataTable DTMenu = null;

        public int diasCredito = 0;

        //Agregamos un panel lateral
        FlowLayoutPanel panelLateral = new FlowLayoutPanel();

        public List<MyColumna> GetColList(DataGridView dtg = null)
        {
            List<MyColumna> colList = new List<MyColumna>();
            try
            {
                if (dtg == null) dtg = DataGridDetalle;

                if (dtg != null)
                {
                    foreach (DataGridViewColumn item in dtg.Columns)
                    {
                        if (item.Visible && item.DataPropertyName != "")
                        {
                            colList.Add(new MyColumna(item.HeaderText, item.DataPropertyName));
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return colList;
        }

        public bool CargarATemporal(string value)
        {
            bool resultado = false;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            try
            {
                if (SPCargaATemporal != null)
                {
                    if (SPCargaATemporal.Trim() != "")
                    {
                        objDB.iniciarTransaccion();
                        if (temporalID != "") BorrarTemporales();
                        temporalID = objUtil.GetTemporalID();
                        //Agregamos Parametros Para Ejecutar el SP PARA CARGAR A TEMPORAL
                        parms.Add(new DataDB_ELR_NET.Parametro("Id", value));
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        spReturn = objDB.EjecutarSP(SPCargaATemporal.Trim(), parms);
                        if (spReturn < 0)
                        {
                            //MOSTRAMOS ERRORES DEL SISTEMA
                            ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

                            objMsgERRORES.TemporalId = temporalID;
                            objMsgERRORES.objDB = objDB;

                            objMsgERRORES.ShowDialog();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public virtual void ExportarAEXCEL(DataTable DTData = null, string titulo = "", string subTitulo = "")
        {
            FormExportToExcel frmExcel = new FormExportToExcel();
            List<MyColumna> colList = new List<MyColumna>();
            try
            {
                if (DataGridDetalle != null)
                {
                    foreach (DataGridViewColumn item in DataGridDetalle.Columns)
                    {
                        if (item.Visible && item.DataPropertyName != "")
                        {
                            colList.Add(new MyColumna(item.HeaderText, item.DataPropertyName));
                        }
                    }
                }

                if (DTData == null) frmExcel.DTData = DTDetalle;
                else frmExcel.DTData = DTData;

                if (titulo.Trim() == "") titulo = Text.ToUpper();

                frmExcel.titulo = titulo;
                frmExcel.subTitulo1 = subTitulo;
                frmExcel.colList = colList;
                frmExcel.ShowDialog();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmExcel.Dispose();
            }

        }

        public void BorrarTemporales()
        {
            string SSQL = "";
            try
            {
                if (TablaEncabezado == null) TablaEncabezado = "";
                if (TablaDetalle == null) TablaDetalle = "";

                if (TablaEncabezado.ToUpper().Contains("TTEMPORAL")) SSQL += " DELETE FROM " + TablaEncabezado + " WHERE IdentificadorTemp = '" + temporalID + "'; ";
                if (TablaDetalle.ToUpper().Contains("TTEMPORAL")) SSQL += " DELETE FROM " + TablaDetalle + " WHERE IdentificadorTemp = '" + temporalID + "'; ";

                if (SSQL.Trim() != "") objDB.EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual bool showEditEntidad()
        {
            bool resultado = false;
            ELRFormEditCliente frm = new ELRFormEditCliente();

            try
            {
                frm.temporalId = temporalID;
                frm.titulo = TituloEditEntidad;

                if (DSDatos.Tables[0].Columns.Contains("Entidad_Id"))
                {
                    frm.entidadId = objDB.GetAsInt("Entidad_Id", DSDatos.Tables[0].Rows[0]);
                }
                else if (DSDatos.Tables[0].Columns.Contains("Suplidor_Id"))
                {
                    frm.entidadId = objDB.GetAsInt("Suplidor_Id", DSDatos.Tables[0].Rows[0]);
                }

                if (DSDatos.Tables[0].Columns.Contains("CedulaRNC"))
                {
                    frm.cedulaRNC = objDB.GetAsString("CedulaRNC", DSDatos.Tables[0].Rows[0]);
                }

                frm.esEdit = PermiteCambiarEntidad;
                frm.nombreUsuario = nombreUsuario;
                frm.oficinaId = OFICINA_ID;
                frm.ShowDialog();

                if (frm.lOK)
                {
                    //ASIGNAMOS LOS DATOS DEL CLIENTE
                    if (DSDatos.Tables[0].Columns.Contains("Entidad_Id")) SetValorEncabezado("Entidad_Id", frm.entidadId);
                    if (DSDatos.Tables[0].Columns.Contains("Suplidor_Id")) SetValorEncabezado("Suplidor_Id", frm.entidadId);
                    if (DSDatos.Tables[0].Columns.Contains("Cliente_Id")) SetValorEncabezado("Cliente_Id", frm.entidadId);
                    if (DSDatos.Tables[0].Columns.Contains("CedulaRNC")) SetValorEncabezado("CedulaRNC", frm.cedulaRNC);
                    if (DSDatos.Tables[0].Columns.Contains("Nombres")) SetValorEncabezado("Nombres", frm.nombreCompleto);
                    if (DSDatos.Tables[0].Columns.Contains("Nombre")) SetValorEncabezado("Nombre", frm.nombreCompleto);
                    if (DSDatos.Tables[0].Columns.Contains("ANombre")) SetValorEncabezado("ANombre", frm.nombreCompleto);
                    if (DSDatos.Tables[0].Columns.Contains("ANombres")) SetValorEncabezado("ANombres", frm.nombreCompleto);
                    if (DSDatos.Tables[0].Columns.Contains("Apellidos")) SetValorEncabezado("Apellidos", frm.apellidos);
                    if (DSDatos.Tables[0].Columns.Contains("Telefono")) SetValorEncabezado("Telefono", frm.telefonos);
                    if (DSDatos.Tables[0].Columns.Contains("Telefonos")) SetValorEncabezado("Telefonos", frm.telefonos);
                    if (DSDatos.Tables[0].Columns.Contains("Direccion")) SetValorEncabezado("Direccion", frm.direccion);
                    if (DSDatos.Tables[0].Columns.Contains("Telefono1")) SetValorEncabezado("Telefono1", frm.telefono1);
                    if (DSDatos.Tables[0].Columns.Contains("Telefono2")) SetValorEncabezado("Telefono2", frm.telefono2);
                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frm.Dispose();
            }

            return resultado;
        }

        //Definimos Algunos Handler para ediccion DataGridView
        public virtual void HandleValidarFila(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if ((DataGridDetalle.ReadOnly == false) && (esLoad == false)) PostLineaDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandleValidarFila], " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public void PostearFilaGrid()
        {
            try
            {
                DataRow fila0;
                int itemNumero = 0;
                int valorUnico = 0;

                if (DataGridDetalle != null)
                {
                    if (DataGridDetalle.RowCount > 0)
                    {
                        DataGridDetalle.EndEdit();

                        if (DataGridDetalle.Columns.Contains("ItemNumero")) itemNumero = int.Parse(DataGridDetalle["ItemNumero", DataGridDetalle.CurrentRow.Index].Value.ToString());
                        if (DataGridDetalle.Columns.Contains("Unico")) valorUnico = int.Parse(DataGridDetalle["Unico", DataGridDetalle.CurrentRow.Index].Value.ToString());

                        if ((EsConTemporal) && (itemNumero > 0))
                        {

                            fila0 = DTDetalle.Select("ItemNumero = " + itemNumero.ToString())[0];

                            ActualizarDetalleFormRow(fila0, "ItemNumero");
                        }
                        else if ((EsConTemporal) && (valorUnico > 0))
                        {

                            fila0 = DTDetalle.Select("Unico = " + valorUnico.ToString())[0];

                            ActualizarDetalleFormRow(fila0, "Unico");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("PostearFilaGrid, " + ex.Message);
            }
        }

        public void addBtnLateralThis(string titulo = "")
        {
            Button btn = new Button();
            int noOrden = 0;
            try
            {
                if (nivelForm <= 1)
                {
                    noOrden = panelLateral.Controls.Count;
                    btn.Name = "btnpnLO" + noOrden.ToString();
                    btn.Size = new Size(290, 65);
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Dock = DockStyle.Top;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    var m = btn.Margin;
                    m.Top = 0;
                    m.Left = 0;
                    m.Right = 0;
                    btn.Margin = m;
                    btn.BackColor = colorV;
                    btn.ForeColor = Color.White;
                    btn.Tag = this.ProductName + "." + this.Name;
                    btn.TabIndex = noOrden;
                    btn.Image = Properties.Resources.Plus_26px;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.Click += new EventHandler(btnLateral_Click);
                    if (titulo.Trim() == "") btn.Text = Text.Trim();
                    else btn.Text = titulo;

                    toolTipInfo.SetToolTip(btn, "ABRIR NUEVO PROCESO (" + btn.Text.ToUpper() + ")");

                    btn.Text += "   Ctrl + O";

                    panelLateral.Controls.Add(btn);
                    btnmenu.Visible = panelLateral.Controls.Count > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void addBtnLateralEdit(string titulo)
        {
            Button btn = new Button();
            int noOrden = 0;
            try
            {
                if (nivelForm <= 1)
                {
                    noOrden = panelLateral.Controls.Count;
                    btn.Name = "btnEditpn" + noOrden.ToString();
                    btn.Size = new Size(290, 65);
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Dock = DockStyle.Top;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = coloP;
                    btn.ForeColor = Color.White;
                    btn.TabIndex = noOrden;
                    btn.Image = Properties.Resources.ViewEdit_26px;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.Click += new EventHandler(btnLateral_Click);
                    btn.Text = titulo;
                    toolTipInfo.SetToolTip(btn, titulo);
                                      
                    panelLateral.Controls.Add(btn);
                    btnmenu.Visible = panelLateral.Controls.Count > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void addButtonAMenuLateral(string formularioEjecutar, string titulo = "", bool esReport = false)
        {
            DataRow[] filas = null;
            int noOrden = 0;
            bool esConsulta = false;
            try
            {
                if (DTMenu == null) return;

                filas = DTMenu.Select("Formulario_AEjecutar = '" + formularioEjecutar + "'");
                if (filas.Length > 0)
                {
                    esConsulta = objDB.GetAsBoolean("EsMenuConsulta", filas[0]);
                    noOrden = panelLateral.Controls.Count;
                    Button btn = new Button();
                    btn.Name = "btnpnL" + noOrden.ToString();
                    btn.Size = new Size(290, 65);
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Dock = DockStyle.Top;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = coloP;

                    btn.ForeColor = Color.White;

                    if (titulo.Trim() != "") btn.Text = titulo;
                    else btn.Text = filas[0]["Nombre"].ToString();
                    toolTipInfo.SetToolTip(btn, (esConsulta ? "REPORTE: " : "") + btn.Text);

                    btn.Tag = filas[0]["Formulario_AEjecutar"].ToString();
                    btn.TabIndex = noOrden;
                    btn.Click += new EventHandler(btnLateral_Click);

                    //ASIGNAMOS LA IMAGEN
                    titulo = btn.Text.ToUpper();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;

                    if (esReport) btn.Image = Properties.Resources.Report_Card_26px;
                    else if (titulo.Contains("CONSULTA")) btn.Image = Properties.Resources.Report_Card_26px;
                    else if (titulo.Contains("DASHBOARD")) btn.Image = Properties.Resources.Pie_Chart_26px;
                    else if (titulo.Contains("GRAFICO")) btn.Image = Properties.Resources.Pie_Chart_26px;
                    else if (titulo == "CLIENTES") btn.Image = Properties.Resources.Customer_26px;
                    else if (titulo == "SUPLIDORES") btn.Image = Properties.Resources.Customer_26px;
                    else if (titulo == "SUPLIDORES") btn.Image = Properties.Resources.Customer_26px;
                    else if (titulo.Contains("CATEGORIA") && !esConsulta) btn.Image = Properties.Resources.List_26px;
                    else if (titulo.Contains("PRODUCTO") && !esConsulta) btn.Image = Properties.Resources.Product_26px;
                    else if (titulo.Contains("IMPRIMIR") && !esConsulta) btn.Image = Properties.Resources.Print_26px;
                    else if (titulo.Contains("ANULAR") && !esConsulta) btn.Image = Properties.Resources.Delete_Document_26px;
                    else if (titulo.Contains("RECHAZAR") && !esConsulta) btn.Image = Properties.Resources.Trash_26px;
                    else if (titulo.Contains("BORRAR") && !esConsulta) btn.Image = Properties.Resources.Trash_26px;
                    else if (titulo.Contains("DAR BAJA") && !esConsulta) btn.Image = Properties.Resources.Trash_26px;
                    else if (titulo.Contains("DESPEDIR") && !esConsulta) btn.Image = Properties.Resources.Trash_26px;
                    else if (titulo.Contains("REVERTIR") && !esConsulta) btn.Image = Properties.Resources.Undo_26px;
                    else if (titulo.Contains("REVERSAR") && !esConsulta) btn.Image = Properties.Resources.Undo_26px;
                    else if (titulo.Contains("DESHACER") && !esConsulta) btn.Image = Properties.Resources.Undo_26px;
                    else if (titulo.Contains("APROBAR") && !esConsulta) btn.Image = Properties.Resources.Checked_Checkbox_26px;
                    else if (titulo.Contains("APLICAR") && !esConsulta) btn.Image = Properties.Resources.Checked_Checkbox_26px;
                    else if (titulo.Contains("POSTEAR") && !esConsulta) btn.Image = Properties.Resources.Checked_Checkbox_26px;
                    else if (titulo.Contains("ACTUALIZAR") && !esConsulta) btn.Image = Properties.Resources.Checked_Checkbox_26px;
                    else if (titulo.Contains("DGII")) btn.Image = Properties.Resources.Microsoft_Excel_26px;
                    else if (titulo.Contains("CHEQUE")) btn.Image = Properties.Resources.Bank_26px;
                    else if (titulo.Contains("DEPOSITO") && !esConsulta) btn.Image = Properties.Resources.Money_Box_26px;
                    else if (titulo.Contains("PAGO") && !esConsulta) btn.Image = Properties.Resources.Money_26px;
                    else if (titulo.Contains("ABONO") && !esConsulta) btn.Image = Properties.Resources.Money_26px;
                    else if (titulo.Contains("DIARIO") && !esConsulta) btn.Image = Properties.Resources.General_Ledger_26px;
                    else if (titulo.Contains("CUENTAS BANCARIAS") && !esConsulta) btn.Image = Properties.Resources.General_Ledger_26px;
                    else if (titulo.Contains("CUENTA") && !esConsulta) btn.Image = Properties.Resources.View_Details_26px;
                    else if (titulo.Contains("EMPLEADO") && !esConsulta) btn.Image = Properties.Resources.Worker_26px;
                    else if (titulo.Contains("SALARI") && !esConsulta) btn.Image = Properties.Resources.Bank_26px;
                    else if (titulo.Contains("VACACION") && !esConsulta) btn.Image = Properties.Resources.Beach_26px;
                    else if (titulo.Contains("CONFIGURA") && !esConsulta) btn.Image = Properties.Resources.Automation_26px;
                    else if (titulo.Contains("TABLA") && !esConsulta) btn.Image = Properties.Resources.Automation_26px;
                    else if (titulo.Contains("TRANSAC") && !esConsulta) btn.Image = Properties.Resources.Process_26px;
                    else if (titulo.Contains("PROCESO") && !esConsulta) btn.Image = Properties.Resources.Process_26px;
                    else if (titulo.Contains("GENERA") && !esConsulta) btn.Image = Properties.Resources.Process_26px;
                    else if (esConsulta) btn.Image = Properties.Resources.Report_Card_26px;
                    else btn.Image = Properties.Resources.Play_26px1;

                    panelLateral.Controls.Add(btn);
                }

                btnmenu.Visible = panelLateral.Controls.Count > 0;
                panelLateral.Visible = (panelLateral.Controls.Count > 0 && !MenuLateralBringToFront) ;
                if (panelLateral.Visible && !MenuLateralBringToFront) WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public void MostrarMenuLateral(bool value)
        {
            try
            {
                if (panelLateral.Controls.Count > 0) panelLateral.Visible = value;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void ClickBotonLateral(string btnText = "")
        {

        }

        public virtual void OnEdit(string titulo)
        {
            objUtil.MostrarMensajeInformacion(titulo);
        }

        private void btnLateral_Click(object sender, EventArgs e)
        {
            Button btn = null;
            try
            {
                if (!(sender is Button)) return;
                btn = (Button)sender;
                if (btn.Name.ToUpper().Contains("BTNEDITPN")) OnEdit(btn.Text);
                else if (btn.Tag == null) return;
                else
                {
                    ejecutaForm(btn.Tag.ToString());
                    if (MenuLateralBringToFront) panelLateral.Visible = false;

                    //EJECUTAMOS METODO POST CLICK EN BOTON LATERAL
                    ClickBotonLateral(btn.Text);
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public void ejecutaForm(string valor, string nombreMenu = "")
        {
            string MyAsembly = "";
            string formulario;
            int menuId = 0;
            int modal = 0;
            string tipoFormulario = "";
            string[] MyArray;
            FormPlantillaIndex frmCons = null;
            ELRFormRegistro frmRegistro = null;
            DataRow fila0 = null;
            bool conCaja = false, esValido = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                MyArray = valor.Split(';');
                formulario = MyArray[0];
                MyAsembly = formulario.Split('.')[0];

                if (objUtil.getNivelForm(formulario) > 2)
                {
                    objUtil.MostrarMensajeAdvertencia("Proceso Rechazado, Usted tiene tres o mas formulario ejecutandose");
                    return;
                }

                if (MyArray.Length > 1)
                {
                    menuId = int.Parse(MyArray[1]);
                    modal = int.Parse(MyArray[2]);
                    tipoFormulario = MyArray[3].Trim().ToUpper();
                }
                else
                {
                    fila0 = DTMenu.Select("Formulario_AEjecutar = '" + formulario + "' ")[0];
                    menuId = objUtil.GetAsInt("Menu_Id", fila0);
                    tipoFormulario = objUtil.GetAsString("TipoFormulario", fila0).ToUpper();
                    nombreMenu = objUtil.GetAsString("Nombre", fila0).ToUpper();

                    if (objUtil.GetAsBoolean("EsModal", fila0)) modal = 1;
                    else modal = 0;
                }


                if (tipoFormulario == "C")
                {
                    frmCons = (FormPlantillaIndex)Activator.CreateInstance(MyAsembly, formulario).Unwrap();
                    frmCons.nivelForm = objUtil.getNivelForm(formulario);
                    frmCons.menuId = menuId;
                    frmCons.empresaID = EMPRESA_ID;
                    frmCons.oficinaID = OFICINA_ID;
                    frmCons.REQUIERE_CAJA_ABIERTA = REQUIERE_CAJA_ABIERTA;
                    frmCons.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                    frmCons.REQUIERE_CONVERTIR_ADOLARES = REQUIERE_CONVERTIR_ADOLARES;

                    frmCons.NOMBRE_EMPRESA = NOMBRE_EMPRESA_OFICINA;
                    frmCons.NOMBRE_OFICINA = NOMBRE_OFICINA;
                    frmCons.nombreUsuario = nombreUsuario;
                    frmCons.FECHA_TRABAJO = FECHA_TRABAJO;

                    frmCons.DTVariablesSYS = DTVariablesSYS;
                    frmCons.DTEmpresaOficinas = DTOficina;
                    frmCons.DSGlobal = DSGlobal;

                    frmCons.DTMenu = DTMenu;
                    frmCons.EnEjecusion = true;
                    frmCons.WindowState = FormWindowState.Maximized;
                    frmCons.ShowDialog();
                }
                else
                {
                    frmRegistro = (ELRFormRegistro)Activator.CreateInstance(MyAsembly, formulario).Unwrap();
                    frmRegistro.nivelForm = objUtil.getNivelForm(formulario);
                    frmRegistro.EMPRESA_ID = EMPRESA_ID;
                    frmRegistro.OFICINA_ID = OFICINA_ID;
                    frmRegistro.REQUIERE_CAJA_ABIERTA = REQUIERE_CAJA_ABIERTA;
                    frmRegistro.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                    frmRegistro.REQUIERE_CONVERTIR_ADOLARES = REQUIERE_CONVERTIR_ADOLARES;
                    conCaja = (frmRegistro.RequiereCajaAbierta && REQUIERE_CAJA_ABIERTA);

                    //VALIDAMOS LA FECHA DE OPERACIONES
                    if (frmRegistro.ExcluirValidacionCierre) esValido = true;
                    else if (frmRegistro.DataGridDetalle != null) esValido = objDB.ValidarFechaOperaciones(OFICINA_ID, conCaja);
                    else if (REQUIERE_CIERRE_OPERACIONES) esValido = objDB.ValidarFechaOperaciones(OFICINA_ID, conCaja);

                    frmRegistro.NOMBRE_EMPRESA_OFICINA = NOMBRE_EMPRESA_OFICINA;
                    frmRegistro.NOMBRE_OFICINA = NOMBRE_OFICINA;
                    frmRegistro.nombreUsuario = nombreUsuario;
                    frmRegistro.FECHA_TRABAJO = FECHA_TRABAJO;

                    frmRegistro.DTVariablesSYS = DTVariablesSYS;
                    frmRegistro.DSGlobal = DSGlobal;

                    frmRegistro.DTLicense = DTLicense;

                    frmRegistro.EnEjecusion = true;
                    frmRegistro.DTMenu = DTMenu;

                    frmRegistro.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;

                if ((frmCons != null) && (modal > 0)) frmCons.Dispose();
                if ((frmRegistro != null) && (modal > 0)) frmRegistro.Dispose();
            }
        }

        public void HandleKeyPressInteger(object sender, KeyPressEventArgs e)
        {
            //Ignora la tecla presionada si no es dígito o tecla de control      
            try
            {
                if (e.KeyChar == 13)
                {
                    SendKeys.Send("{TAB}");
                    return;
                }

                if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (Char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandleKeyPressInteger], " + ex.Message);
            }

        }

        public virtual void HandleCellKeyDown(object sender, KeyEventArgs e)
        {

        }
        public virtual void MostrarDataEnGrid()
        {

        }


        public void HandleKeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;
            TextBox txt;

            try
            {
                txt = (TextBox)sender;

                if (e.KeyChar == 13)
                {
                    SendKeys.Send("{TAB}");
                    return;
                }

                if (Char.IsControl(e.KeyChar)) e.Handled = false;
                else if ((txt.SelectionLength > 0) && (e.KeyChar >= 48 && e.KeyChar <= 57)) e.Handled = false;
                else
                {
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        if (txt.Text[i] == '.')
                            IsDec = true;

                        if (IsDec && nroDec++ >= 2)
                        {
                            e.Handled = true;
                            return;
                        }
                    }

                    if (e.KeyChar >= 48 && e.KeyChar <= 57)
                        e.Handled = false;
                    else if (txt.Text.Length >= 12)
                        e.Handled = false;
                    else if (e.KeyChar == 46)
                        e.Handled = (IsDec) ? true : false;
                    else
                        e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandleKeyPressDecimal], " + ex.Message);
            }

        }

        private void HandlerEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string nombreColumna = "";
            DataColumn item;

            try
            {
                nombreColumna = DataGridDetalle.Columns[DataGridDetalle.CurrentCell.ColumnIndex].Name;
                TextBox txt;
                txt = (TextBox)e.Control;

                txt.KeyDown -= HandleCellKeyDown;
                txt.KeyPress -= HandleKeyPressInteger;
                txt.KeyPress -= HandleKeyPressDecimal;

                if (DTDetalle.Columns.Contains(nombreColumna))
                {
                    item = DTDetalle.Columns[nombreColumna];

                    if (item.DataType == typeof(Int16)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressInteger);
                    else if (item.DataType == typeof(Int32)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressInteger);
                    else if (item.DataType == typeof(Int64)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressInteger);
                    else if (item.DataType == typeof(decimal)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressDecimal);
                    else if (item.DataType == typeof(double)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressDecimal);
                }

                txt.KeyDown += new KeyEventHandler(HandleCellKeyDown);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandlerEditingControlShowing], " + ex.Message);
            }

        }

        private void HandlerCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataColumn item;

            try
            {
                COLUMNA_ACTUAL_GRID_DETALLE = DataGridDetalle.Columns[DataGridDetalle.CurrentCell.ColumnIndex].Name.ToUpper();

                if (DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].ReadOnly == false)
                {
                    if (DTDetalle.Columns.Contains(COLUMNA_ACTUAL_GRID_DETALLE))
                    {

                        item = DTDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE];

                        if (item.DataType == typeof(decimal)) DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Format = "";
                        else if (item.DataType == typeof(double)) DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Format = "";

                        DataGridDetalle.BeginEdit(true);
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandlerCellEnter], " + ex.Message);
            }
        }

        private void HandlerCellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataColumn item;

                DataGridDetalle.EndEdit();

                if (COLUMNA_ACTUAL_GRID_DETALLE.Trim() != "")
                {
                    if (DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].ReadOnly == false)
                    {
                        if (DTDetalle.Columns.Contains(COLUMNA_ACTUAL_GRID_DETALLE))
                        {
                            item = DTDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE];

                            if (item.DataType == typeof(decimal))
                            {
                                DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Format = "N2";
                                DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            }
                            else if (item.DataType == typeof(double))
                            {
                                DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Format = "N2";
                                DataGridDetalle.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            }

                            MostrarDataEnGrid();
                            CalcularLineaDetalle();
                            TotalizarDetalle();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandlerCellLeave], " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void HandlerDataGridLeave(object sender, EventArgs e)
        {
            try
            {
                TotalizarDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[HandlerDataGridLeave] " + ex.Message);
            }
        }

        public virtual void CalcularLineaDetalle()
        {

        }

        //DEFINICION DE CONSTRUTORES
        public ELRFormRegistro()
        {
            InitializeComponent();

            VALOR_ID = "0";
            ImprimirAlGrabar = false;
            MensajeAlGrabar = true;
            NuevoRegistroAlGrabar = false;

            EsConTemporal = false;
            temporalID = "";
            SPGraba = "";
            SPCargaATemporal = "";
            CamposAExcluirEnc = "";
            CamposAExcluirDet = "";
            CodigoOperacion = 0;
            MostrarDesglosePago = false;
            EditarClienteDesglose = false;
            EnEjecusion = false;
            RequiereCliente = false;
            TipoFecha = tbTipoFecha.FechaSistema;
            fechaCajaAbierta = DateTime.Now.AddYears(-100);
            cajaId = -1;
            RequiereCajaAbierta = false;
            nombreUsuario = "USUARIO.PRUEBA";
            ValorParmTipo = "";

            FormaImprimir = tbTipoImpresion.NoImprimir;
            NombreReporte = "";
            NombreVistaImprimir = "";

            TituloReporte = "TITULO REPORTE RDLC";
            MensajePregunta = "¿Esta Seguro Que Desea Registrar Estos Datos?";
            CampoIdImprimir = "";

            TabRegistro = null;
            OmitirMetodosDataGrid = false;
            RequiereLineaDetalle = true;
            EsCambiarFecha = false;
            EsCopia = false;
            MenuLateral = false;
            MenuLateralBringToFront = false;
            EsEditEntidad = false;
            TituloEditEntidad = "SELECIONAR ENTIDAD";
            PermiteCambiarEntidad = true;
            EsAgregarLineaVacia = true;
            ExcluirValidacionCierre = false;
        }

        public virtual void MostrarErrorTemporal()
        {
            ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();
            try
            {
                objMsgERRORES.TemporalId = temporalID;
                objMsgERRORES.objDB = objDB;

                objMsgERRORES.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[MostrarErrorTemporal], " + ex.Message);
            }
            finally
            {
                objMsgERRORES.Dispose();
            }
        }

        public virtual int GetSiguienteItemNumero()
        {
            object calcObject;
            int itemNumero = 0;
            try
            {
                calcObject = DTDetalle.Compute("Max(ItemNumero)", "ItemNumero > 0");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") itemNumero = int.Parse(calcObject.ToString());
                }

                if (itemNumero < 0) itemNumero = 0;
                itemNumero++;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("[GetSiguienteItemNumero], " + ex.Message);
            }

            return itemNumero;
        }

        public void SetValorEncabezado(string nombreCampo, string valor)
        {
            try
            {
                if (DSDatos != null)
                {
                    if (DSDatos.Tables.Count > 0) DSDatos.Tables[0].Rows[0][nombreCampo] = valor;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValorEncabezado(string nombreCampo, int valor)
        {
            try
            {
                DSDatos.Tables[0].Rows[0][nombreCampo] = valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValorEncabezado(string nombreCampo, double valor)
        {
            try
            {
                DSDatos.Tables[0].Rows[0][nombreCampo] = valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValorEncabezado(string nombreCampo, decimal valor)
        {
            try
            {
                DSDatos.Tables[0].Rows[0][nombreCampo] = valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValorEncabezado(string nombreCampo, bool valor)
        {
            try
            {
                DSDatos.Tables[0].Rows[0][nombreCampo] = valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValorEncabezado(string nombreCampo, DateTime fecha)
        {
            try
            {
                DSDatos.Tables[0].Rows[0][nombreCampo] = fecha;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ELRFormRegistro(string valorID)
        {
            InitializeComponent();
            VALOR_ID = valorID;
        }
        //FINAL DE CONSTRUTORES


        //DEFINICION DE METODOS
        public DataRow GetById(string nombreTabla, string campoId, int Id)
        {
            DataRow dr = null;
            DataTable dt;
            try
            {
                dt = objDB.GetById(nombreTabla, Id.ToString(), campoId);
                if (dt.Rows.Count <= 0) throw new Exception("No se Encontro Datos con el Codigo Especificado");
                dr = dt.Rows[0];
            }
            catch (Exception)
            {

                throw;
            }

            return dr;
        }

        public virtual bool GetData()
        {
            DataTable MyTabla;
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            ELRFormMensajeErrores frmMensajes = new ELRFormMensajeErrores();
            bool resultado = false;
            DateTime fecha;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                esLoad = true;
                esNuevo = true;
                //VALIDAMOS LA CAJA
                fecha = DateTime.Now.Date;
                fechaCajaAbierta = DateTime.Now.Date.AddYears(-100);

                if (TablaEncabezado == null) TablaEncabezado = "";
                if (TablaDetalle == null) TablaDetalle = "";

                if (NombreCampoID == null) NombreCampoID = "";

                lblNombreUsuario.Text = nombreUsuario.Trim().ToUpper();

                if ((RequiereCajaAbierta) && (REQUIERE_CAJA_ABIERTA))
                {
                    cajaId = 0;
                    aperturaCajaNo = 0;

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Usuario_En_Caja", nombreUsuario);
                    objDB.AddFiltroIsNull("Fecha_Cierre");

                    MyTabla = objDB.GetAll("TCAJAS_APERTURA_CIERRE", 50, objDB.Filtros);

                    if (MyTabla.Rows.Count != 1 && REQUIERE_CIERRE_OPERACIONES == true)
                    {
                        resultado = false;
                        throw new Exception("EL USUARIO " + nombreUsuario + " TIENE " + MyTabla.Rows.Count.ToString() + " CAJAS ABIERTAS ");

                    }
                    else if (MyTabla.Rows.Count == 1)
                    {
                        cajaId = int.Parse(MyTabla.Rows[0]["Caja_Id"].ToString());
                        aperturaCajaNo = int.Parse(MyTabla.Rows[0]["Apertura_No"].ToString());
                        fechaCajaAbierta = (DateTime)MyTabla.Rows[0]["Fecha_Trabajo"];

                        lblNombreUsuario.Text += ", CAJA NO.: " + cajaId.ToString();
                    }

                    if (cajaId <= 0 && REQUIERE_CIERRE_OPERACIONES == true) throw new Exception("NO SE HA IDENTIFICADO UNA CAJA ABIERTA PARA ESTE USUARIO");

                }

                DSDatos.Clear();
                objDB.LimpiarFiltros();

                drCliente = null;
                drProducto = null;

                if ((esNuevo) && (temporalID.Trim() == "")) temporalID = objUtil.GetTemporalID();

                MyTabla = null;

                if (TablaEncabezado.Trim() != "")
                {
                    if (!EsConTemporal) MyTabla = objDB.GetById(TablaEncabezado, VALOR_ID, NombreCampoID);
                    else MyTabla = objDB.GetById(TablaEncabezado, temporalID, "IdentificadorTemp");
                }


                //AGREGAMOS LA TABLA DE ENCABEZADO
                if (MyTabla != null)
                {
                    esNuevo = (MyTabla.Rows.Count <= 0) || (VALOR_ID == "0") || (VALOR_ID == "");
                    //SI NO HAY REGISTRO AGREGAMOS UNA NUEVA FILA
                    if (MyTabla.Rows.Count <= 0)
                    {
                        MyTabla.Rows.Add(MyTabla.NewRow());

                        //AGREGAMOS CAMPOS EMPRESA_ID 
                        if (MyTabla.Columns.Contains("Empresa_Id"))
                        {
                            if (NombreCampoID.Trim().ToUpper() != "EMPRESA_ID")
                            {
                                if (EMPRESA_ID <= 0) throw new Exception("ERROR DE PROGRAMACION, NO ASIGNO VALOR VALIDO A LA VARIABLE EMPRESA_ID");
                                else objUtil.SetValorDT("Empresa_Id", EMPRESA_ID.ToString(), MyTabla);
                            }
                        }

                        //AGREGAMOS EL CAMPO OFICINA_ID
                        if (MyTabla.Columns.Contains("Oficina_Id"))
                        {
                            if (NombreCampoID.Trim().ToUpper() != "OFICINA_iD")
                            {
                                if (OFICINA_ID <= 0) OFICINA_ID = 100;
                                else objUtil.SetValorDT("Oficina_Id", OFICINA_ID.ToString(), MyTabla);
                            }
                        }

                        //ASIGANAMOS VALORES POR DEFECTO
                        if (EsConTemporal) MyTabla.Rows[0]["IdentificadorTemp"] = temporalID;

                        if (CodigoOperacion > 0)
                        {
                            if (MyTabla.Columns.Contains("CodigoOperacion")) MyTabla.Rows[0]["CodigoOperacion"] = CodigoOperacion;
                            if (MyTabla.Columns.Contains("Operacion")) MyTabla.Rows[0]["Operacion"] = CodigoOperacion;
                            if (MyTabla.Columns.Contains("Tipo_Operacion")) MyTabla.Rows[0]["Tipo_Operacion"] = CodigoOperacion;
                        }


                    }

                    //AGREGAMOS EL CAMPO CAJA_ID
                    if (EsConTemporal)
                    {
                        if (MyTabla.Columns.Contains("Caja_Id")) MyTabla.Rows[0]["Caja_Id"] = cajaId;
                        if (MyTabla.Columns.Contains("Apertura_Caja_No")) MyTabla.Rows[0]["Apertura_Caja_No"] = aperturaCajaNo;
                    }

                    if (DSDatos.Tables.Contains("Encabezado")) DSDatos.Tables.Remove("Encabezado");
                    MyTabla.TableName = "Encabezado";
                    DSDatos.Tables.Add(MyTabla);
                }


                //AGRWGAMOS el Detalle si es Necesario
                if (TablaDetalle.Trim() != "")
                {
                    if (!EsConTemporal) DTDetalle = objDB.GetById(TablaDetalle, VALOR_ID, NombreCampoID);
                    else DTDetalle = objDB.GetById(TablaDetalle, temporalID, "IdentificadorTemp");

                    if (DSDatos.Tables.Contains("Detalle")) DSDatos.Tables.Remove("Detalle");
                    DTDetalle.TableName = "Detalle";
                    DSDatos.Tables.Add(DTDetalle);

                    if (DataGridDetalle != null)
                    {
                        DataGridDetalle.RowTemplate.Height = 35;
                        DataGridDetalle.AutoGenerateColumns = false;
                        DataGridDetalle.DataSource = DTDetalle;
                        DataGridDetalle.Focus();
                    }

                    TotalizarDetalle();

                }



                //MOSTRAMOS LOS DATOS EN CONTROLES
                if (TablaEncabezado.Trim() != "")
                {
                    MostrarDataEnControles();
                    if ((EsConTemporal) && (esNuevo) && !esCopia) objDB.Insertar(TablaEncabezado, "", DSDatos.Tables[0], 0, CamposAExcluirEnc);
                    else if (EsConTemporal) objDB.Actualizar(TablaEncabezado, "IdentificadorTemp", DSDatos.Tables[0], 0, CamposAExcluirEnc);

                    MostrarDatosCliente();
                }


                resultado = ValidarFecha();

            }
            catch (Exception ex)
            {

                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);
                this.Close();
            }
            finally
            {
                esLoad = false;
                this.Cursor = Cursors.Default;
            }

            return resultado;
        }


        public bool ValidarFecha()
        {
            bool resultado = true;
            DataTable MyTabla = null;
            DateTime fecha;

            try
            {
                fecha = DateTime.Now.Date;

                if (REQUIERE_CIERRE_OPERACIONES == false)
                {
                    objDB.FECHA_CONTABLE = fecha;
                    objDB.FECHA_TRABAJO = fecha;
                }

                if (DSDatos.Tables.Contains("Encabezado"))
                {
                    //PASAMOS LA FECHA EN EL ENCABEZADO
                    MyTabla = DSDatos.Tables["Encabezado"];

                    if (MyTabla.Columns.Contains("Fecha"))
                    {
                        if (REQUIERE_CIERRE_OPERACIONES) objDB.GetFechasOficina(OFICINA_ID, EMPRESA_ID);

                        if ((TipoFecha == tbTipoFecha.FechaTrabajo))
                        {

                            MyTabla.Rows[0]["Fecha"] = objDB.FECHA_TRABAJO;

                            resultado = true;

                        }
                        else if ((TipoFecha == tbTipoFecha.FechaContable))
                        {
                            resultado = false;
                            //VALIDAMOS QUE FECHA CONTABLE NO SEA MAYOR A FECHA DE TRABAJO
                            if (objDB.DateToInt(objDB.FECHA_CONTABLE) > objDB.DateToInt(objDB.FECHA_TRABAJO)) throw new Exception("LA FECHA DE CONTABILIDAD NO PUEDE SER MAYOR A FECHA DE TRABAJO");

                            MyTabla.Rows[0]["Fecha"] = objDB.FECHA_CONTABLE;

                            resultado = true;

                        }
                        else if ((cajaId > 0) && (REQUIERE_CIERRE_OPERACIONES))
                        {
                            resultado = false;

                            //VALIDAMOS FECHA DE CAJA NO SEA DIFERENTE A LA FECHA DE LA OFICINA
                            if (objDB.DateToInt(fechaCajaAbierta) != objDB.DateToInt(objDB.FECHA_TRABAJO)) throw new Exception("LA CAJA ESTA ABIERTA A UNA FECHA DIFERENTE A LA FECHA DE TRABAJO DE LA OFICINA");

                            MyTabla.Rows[0]["Fecha"] = fechaCajaAbierta;

                            resultado = true;
                        }
                        else MyTabla.Rows[0]["Fecha"] = fecha;

                        fecha = (DateTime)MyTabla.Rows[0]["Fecha"];

                        //VALIDAMOS QUE LA FECHA DE CAJA NO SEA MENOR A FECHA ACTUAL
                        if ((cajaId > 0) && (REQUIERE_CIERRE_OPERACIONES))
                        {
                            if (objDB.DateToInt(fecha) < objDB.DateToInt(DateTime.Now.Date))
                            {
                                resultado = false;
                                throw new Exception("LA FECHA DE CAJA NO PUEDE SER MENOR A LA FECHA ACTUAL, DEBE CERRAR ESTA CAJA Y LUEGO ABRIRLA A LA FECHA DE TRABAJO...");
                            }
                        }


                        //VALIDAMOS LA FECHA DE TRABAJO NO ESTE CERRADA O EN UN PROCESO DE CIERRE
                        if (REQUIERE_CIERRE_OPERACIONES)
                        {
                            if ((TipoFecha == tbTipoFecha.FechaTrabajo) || (cajaId > 0))
                            {
                                if (objDB.EsFechaTrabajoEnCierre(fecha))
                                {
                                    resultado = false;
                                    throw new Exception("IMPOSIBLE REGISTRAR TRANSACCIONES EN UNA FECHA CERRADA O EN PROCESO DE CIERRE...");
                                }
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {

                resultado = false;
                throw;
            }

            return resultado;

        }


        public void PostEncabezadoTemp()
        {
            try
            {
                if (TablaEncabezado != null)
                {
                    if ((EsConTemporal) && (TablaEncabezado.Trim() != "")) objDB.Actualizar(TablaEncabezado, "IdentificadorTemp", DSDatos.Tables[0], 0, CamposAExcluirEnc);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void PostLineaDetalle(DataGridView senderGrid = null, string nombreColumnaUnico = "Unico")
        {
            int valorUnico = 0;
            int valorItemNumero = 0;
            int posicionActual;
            DataRow fila0 = null;
            DataRow[] filas = null;
            string nombreCampo = "";


            try
            {

                if ((senderGrid == null) && (DataGridDetalle != null)) senderGrid = DataGridDetalle;

                if (senderGrid != null)
                {

                    senderGrid.EndEdit();

                    posicionActual = senderGrid.CurrentRow.Index;

                    if (senderGrid.Columns.Contains("Unico")) valorUnico = int.Parse(senderGrid["Unico", posicionActual].Value.ToString());
                    else if (senderGrid.Columns.Contains(nombreColumnaUnico)) valorUnico = int.Parse(senderGrid[nombreColumnaUnico, posicionActual].Value.ToString());

                    if (senderGrid.Columns.Contains("ItemNumero"))
                    {
                        valorItemNumero = int.Parse(senderGrid["ItemNumero", posicionActual].Value.ToString());
                        nombreCampo = "ItemNumero";
                    }
                    else if (senderGrid.Columns.Contains("Item_Numero"))
                    {
                        valorItemNumero = int.Parse(senderGrid["Item_Numero", posicionActual].Value.ToString());
                        nombreCampo = "Item_Numero";
                    }


                    if (valorUnico > 0)
                    {
                        filas = DTDetalle.Select("Unico = " + valorUnico.ToString());
                        if (filas.Count() > 0)
                        {
                            fila0 = filas[0];
                            objDB.UpdateFromRow(TablaDetalle, fila0, "Unico");
                        }
                    }
                    else if (valorItemNumero > 0)
                    {
                        filas = DTDetalle.Select(nombreCampo + " = " + valorItemNumero.ToString());
                        if (filas.Count() > 0)
                        {
                            fila0 = filas[0];
                            objDB.UpdateFromRow(TablaDetalle, fila0, nombreCampo);
                        }
                    }

                    TotalizarDetalle();

                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message, "Error al Actualizar\\Postear Linea Detalle");
            }
        }



        public void ActualizarDetalle(int posicionActual, string campoId = "Unico")
        {



            try
            {

                objDB.Actualizar(TablaDetalle, campoId, DSDatos.Tables[0], posicionActual);
                TotalizarDetalle();


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message, "Error al Actualizar\\Postear Linea Detalle");
            }
        }

        public bool ActualizarDetalleFormRow(DataRow fila, string campoId = "Unico")
        {
            bool resultado = false;
            double precioSinItbis = 0, precio = 0, subtotal = 0, descuento = 0, neto = 0, itbis = 0, monto = 0;

            try
            {
                //Pasamos los datos en US
                if (tasaCambioUS > 0)
                {

                    if (fila.Table.Columns.Contains("Tasa_Cambio_US")) fila["Tasa_Cambio_US"] = tasaCambioUS;


                    if (fila.Table.Columns.Contains("Precio_Sin_Itbis"))
                    {
                        precioSinItbis = objUtil.GetAsDouble("Precio_Sin_Itbis", fila);
                        if (fila.Table.Columns.Contains("Precio_Sin_Itbis_US")) fila["Precio_Sin_Itbis_US"] = (precioSinItbis / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Precio"))
                    {
                        precio = objUtil.GetAsDouble("Precio", fila);
                        if (fila.Table.Columns.Contains("Precio_US")) fila["Precio_US"] = (precio / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Sub_Total"))
                    {
                        subtotal = objUtil.GetAsDouble("Sub_Total", fila);
                        if (fila.Table.Columns.Contains("Sub_Total_US")) fila["Sub_Total_US"] = (subtotal / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Descuento"))
                    {
                        descuento = objUtil.GetAsDouble("descuento", fila);
                        if (fila.Table.Columns.Contains("descuento_US")) fila["descuento_US"] = (descuento / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Itbis"))
                    {
                        itbis = objUtil.GetAsDouble("Itbis", fila);
                        if (fila.Table.Columns.Contains("Itbis_US")) fila["Itbis_US"] = (itbis / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Monto"))
                    {
                        monto = objUtil.GetAsDouble("Monto", fila);
                        if (fila.Table.Columns.Contains("Monto_US")) fila["Monto_US"] = (monto / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Debito"))
                    {
                        monto = objUtil.GetAsDouble("Debito", fila);
                        if (fila.Table.Columns.Contains("Debito_US")) fila["Debito_US"] = (monto / tasaCambioUS);
                    }

                    if (fila.Table.Columns.Contains("Credito_Us"))
                    {
                        monto = objUtil.GetAsDouble("Credito", fila);
                        if (fila.Table.Columns.Contains("Credito_US")) fila["Credito_US"] = (monto / tasaCambioUS);
                    }

                }
                resultado = (objDB.UpdateFromRow(TablaDetalle, fila, campoId) > 0);
                TotalizarDetalle();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message, "Error al Actualizar\\Postear Linea Detalle");
            }

            return resultado;
        }

        //METODOS PARA MOSTRAR VALOR EN CONTROLES
        public void MostrarDataEnControles()
        {
            ELRCombobox cbo = null;
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in this.Controls)
                {
                    if (item is ELRTextBox) ((ELRTextBox)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRLabel) ((ELRLabel)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRCheckBox) ((ELRCheckBox)item).GetValorFromDS(esNuevo, 0);

                    if (item is ELRCombobox)
                    {
                        cbo = ((ELRCombobox)item);
                        if (cbo.UsaDataGlobal) cbo.DSDataGlobal = DSGlobal;

                        cbo.GetValorFromDS(esNuevo, 0);
                    }

                    if (item is ELRDatePicker) ((ELRDatePicker)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).GetValorFromDS(esNuevo, 0);
                    if (item is Panel) MostrarDataEnControles((Panel)item);
                    if (item is GroupBox) MostrarDataEnControles((GroupBox)item);
                    if (item is TabControl) MostrarDataEnControles((TabControl)item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void MostrarDataEnControles(Panel pn)
        {
            ELRCombobox cbo = null;
            string nombreControl = "";
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in pn.Controls)
                {
                    nombreControl = item.Name;

                    if (item is ELRTextBox) ((ELRTextBox)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRLabel) ((ELRLabel)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRCheckBox) ((ELRCheckBox)item).GetValorFromDS(esNuevo, 0);


                    if (item is ELRCombobox)
                    {
                        cbo = ((ELRCombobox)item);
                        if (cbo.UsaDataGlobal) cbo.DSDataGlobal = DSGlobal;

                        cbo.GetValorFromDS(esNuevo, 0);
                    }

                    if (item is ELRDatePicker) ((ELRDatePicker)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).GetValorFromDS(esNuevo, 0);
                    if (item is Panel) MostrarDataEnControles((Panel)item);
                    if (item is GroupBox) MostrarDataEnControles((GroupBox)item);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(nombreControl + ", " + ex.Message);
            }
        }

        private void MostrarDataEnControles(GroupBox pn)
        {
            ELRCombobox cbo = null;

            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in pn.Controls)
                {
                    if (item is ELRTextBox) ((ELRTextBox)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRLabel) ((ELRLabel)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRCheckBox) ((ELRCheckBox)item).GetValorFromDS(esNuevo, 0);


                    if (item is ELRCombobox)
                    {
                        cbo = ((ELRCombobox)item);
                        if (cbo.UsaDataGlobal) cbo.DSDataGlobal = DSGlobal;

                        cbo.GetValorFromDS(esNuevo, 0);
                    }

                    if (item is ELRDatePicker) ((ELRDatePicker)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).GetValorFromDS(esNuevo, 0);
                    if (item is Panel) MostrarDataEnControles((Panel)item);
                    if (item is GroupBox) MostrarDataEnControles((GroupBox)item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDataEnControles(TabPage page)
        {
            ELRCombobox cbo = null;

            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in page.Controls)
                {
                    if (item is ELRTextBox) ((ELRTextBox)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRLabel) ((ELRLabel)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRCheckBox) ((ELRCheckBox)item).GetValorFromDS(esNuevo, 0);

                    if (item is ELRCombobox)
                    {
                        cbo = ((ELRCombobox)item);
                        if (cbo.UsaDataGlobal) cbo.DSDataGlobal = DSGlobal;

                        cbo.GetValorFromDS(esNuevo, 0);
                    }

                    if (item is ELRDatePicker) ((ELRDatePicker)item).GetValorFromDS(esNuevo, 0);
                    if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).GetValorFromDS(esNuevo, 0);
                    if (item is Panel) MostrarDataEnControles((Panel)item);
                    if (item is GroupBox) MostrarDataEnControles((GroupBox)item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void MostrarDataEnControles(TabControl tac)
        {
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (TabPage item in tac.TabPages)
                {
                    MostrarDataEnControles(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void LimpiarControles(TabPage page)
        {
            ELRCombobox cbo = null;
            ELRTextBox txt = null;
            ELRLabel lbl = null;
            ELRDatePicker dtp = null;
            ELRNumericUpdDown nmd = null;

            try
            {
                MyErrorProvider.Clear();
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in page.Controls)
                {
                    if (item is ELRTextBox)
                    {
                        txt = (ELRTextBox)item;
                        txt.Text = txt.ValorPorDefecto;
                    }
                    if (item is ELRLabel)
                    {
                        lbl = (ELRLabel)item;
                        lbl.Text = lbl.ValorPorDefecto;
                    }


                    if (item is ELRCombobox)
                    {
                        cbo = ((ELRCombobox)item);
                        if (cbo.ValueMember != "") cbo.SelectedValue = cbo.ValorPorDefecto;
                    }

                    if (item is ELRDatePicker)
                    {
                        dtp = (ELRDatePicker)item;
                        dtp.Value = dtp.ValorPorDefecto;
                    }

                    if (item is ELRNumericUpdDown)
                    {
                        nmd = (ELRNumericUpdDown)item;
                        nmd.Value = nmd.ValorPorDefecto;
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        // FIN METODOS MOSTRAR VALOR EN CONTROLES

        //METODOS PARA PASAR VALOR A DATASET
        public virtual void PasarValorADS()
        {
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                if (TablaEncabezado != null)
                {
                    if (TablaEncabezado.Trim() != "")
                    {
                        foreach (Control item in this.Controls)
                        {
                            if (item is ELRTextBox) ((ELRTextBox)item).SetValorEnDS(0);
                            if (item is ELRLabel) ((ELRLabel)item).SetValorEnDS(0);
                            if (item is ELRCheckBox) ((ELRCheckBox)item).SetValorEnDS(0);
                            if (item is ELRCombobox) ((ELRCombobox)item).SetValorEnDS(0);
                            if (item is ELRDatePicker) ((ELRDatePicker)item).SetValorEnDS(0);
                            if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).SetValorEnDS(0);
                            if (item is Panel) PasarValorADS((Panel)item);
                            if (item is GroupBox) PasarValorADS((GroupBox)item);
                            if (item is TabControl) PasarValorADS((TabControl)item);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void PasarValorADS(TabPage page)
        {
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                if (TablaEncabezado != null)
                {
                    if (TablaEncabezado.Trim() != "")
                    {
                        foreach (Control item in page.Controls)
                        {
                            if (item is ELRTextBox) ((ELRTextBox)item).SetValorEnDS(0);
                            if (item is ELRLabel) ((ELRLabel)item).SetValorEnDS(0);
                            if (item is ELRCheckBox) ((ELRCheckBox)item).SetValorEnDS(0);
                            if (item is ELRCombobox) ((ELRCombobox)item).SetValorEnDS(0);
                            if (item is ELRDatePicker) ((ELRDatePicker)item).SetValorEnDS(0);
                            if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).SetValorEnDS(0);
                            if (item is Panel) PasarValorADS((Panel)item);
                            if (item is GroupBox) PasarValorADS((GroupBox)item);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PasarValorADS(Panel pn)
        {
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in pn.Controls)
                {
                    if (item is ELRTextBox) ((ELRTextBox)item).SetValorEnDS(0);
                    if (item is ELRLabel) ((ELRLabel)item).SetValorEnDS(0);
                    if (item is ELRCheckBox) ((ELRCheckBox)item).SetValorEnDS(0);
                    if (item is ELRCombobox) ((ELRCombobox)item).SetValorEnDS(0);
                    if (item is ELRDatePicker) ((ELRDatePicker)item).SetValorEnDS(0);
                    if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).SetValorEnDS(0);
                    if (item is Panel) PasarValorADS((Panel)item);
                    if (item is GroupBox) PasarValorADS((GroupBox)item);
                    if (item is TabControl) PasarValorADS((TabControl)item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PasarValorADS(GroupBox pn)
        {
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in pn.Controls)
                {
                    if (item is ELRTextBox) ((ELRTextBox)item).SetValorEnDS(0);
                    if (item is ELRLabel) ((ELRLabel)item).SetValorEnDS(0);
                    if (item is ELRCheckBox) ((ELRCheckBox)item).SetValorEnDS(0);
                    if (item is ELRCombobox) ((ELRCombobox)item).SetValorEnDS(0);
                    if (item is ELRDatePicker) ((ELRDatePicker)item).SetValorEnDS(0);
                    if (item is ELRNumericUpdDown) ((ELRNumericUpdDown)item).SetValorEnDS(0);
                    if (item is Panel) PasarValorADS((Panel)item);
                    if (item is GroupBox) PasarValorADS((GroupBox)item);
                    if (item is TabControl) PasarValorADS((TabControl)item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void PasarValorADS(TabControl item)
        {
            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (TabPage page in item.TabPages)
                {
                    PasarValorADS(page);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual bool ValidarDatos()
        {
            bool resultado = true;
            string mensaje = "";
            string valor = "";
            double valorNumerico = 0;
            int cantErrores = 0;
            string nombreControl = "";
            ComboBox cbo;
            try
            {
                MyErrorProvider.Clear();

                if (AValidar != null)
                {
                    foreach (Valida item in AValidar)
                    {
                        resultado = true;

                        nombreControl = "";
                        if (item.comtrol != null) nombreControl = item.comtrol.Name;
                        if (item.comtrol is TextBox) item.comtrol.BackColor = Color.White;

                        //VALIDAMOS NO NULO
                        if (item.comtrol is ELRCombobox)
                        {
                            cbo = (ComboBox)item.comtrol;
                            if (cbo.DataSource != null)
                            {
                                if (cbo.SelectedValue == null)
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += item.NombreCampo + ", No Puede Estar Nulo" + "\r";
                                }
                            }
                        }

                        //Obtenemos el Valor
                        valor = objUtil.GetAsString(item.NombreCampo.Trim(), DSDatos.Tables[0].Rows[0]);

                        if (DSDatos.Tables[0].Rows[0][item.NombreCampo] is DBNull)
                        {
                            resultado = false;
                            cantErrores++;
                            mensaje += item.NombreCampo + ", No Puede Estar Nulo" + "\r";
                        }
                        else
                        {
                            //VALIDAMOS NO VACIO
                            if (((valor == "") || (valor.ToUpper() == "NULL")) && (item.TipoValidacion != tbTipoValidacion.EMail))
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += item.NombreCampo + ", No Puede Estar Vacio" + "\r";
                            }
                        }

                        //VALIDAMOS MAYOR O IGUAL A
                        if (item.TipoValidacion == tbTipoValidacion.MayorOIgualA)
                        {
                            valorNumerico = 0;
                            double.TryParse(valor, out valorNumerico);

                            if (!(valorNumerico >= double.Parse(item.Valor1)))
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += item.Mensaje + "\r";
                            }

                        }

                        //VALIDAMOS MENOR O IGUAL A
                        if (item.TipoValidacion == tbTipoValidacion.MenorOIgualA)
                        {
                            valorNumerico = double.Parse(valor);

                            if (!(valorNumerico <= double.Parse(item.Valor1)))
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += item.Mensaje + "\r";
                            }

                        }

                        //VALIDAMOS EN RANGO
                        if (item.TipoValidacion == tbTipoValidacion.EnRango)
                        {
                            valor = DSDatos.Tables[0].Rows[0][item.NombreCampo].ToString();
                            valorNumerico = double.Parse(valor);

                            if ((valorNumerico < double.Parse(item.Valor1)) || (valorNumerico > double.Parse(item.Valor2)))
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += item.Mensaje + "\r";
                            }

                        }

                        //VALIDAMOS LONGITUD MINIMA
                        if (item.TipoValidacion == tbTipoValidacion.LongitudMinima)
                        {
                            valor = DSDatos.Tables[0].Rows[0][item.NombreCampo].ToString();

                            if (valor.Trim().Length < int.Parse(item.Valor1))
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += item.Mensaje + "\r";
                            }

                        }

                        //Validamos Solo Numero
                        if (item.TipoValidacion == tbTipoValidacion.SoloNumero)
                        {
                            valor = DSDatos.Tables[0].Rows[0][item.NombreCampo].ToString();

                            if (objUtil.ValidaSoloNumero(valor) == false)
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += "Solo esta Permitido Numero" + "\r";
                            }

                        }

                        //Validamos Numero decimales
                        if (item.TipoValidacion == tbTipoValidacion.Decimal)
                        {
                            valor = DSDatos.Tables[0].Rows[0][item.NombreCampo].ToString();

                            if (objUtil.ValidaDecimal(valor) == false)
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += "No es un Decimal Valido" + "\r";
                            }

                        }

                        //Validamos Numero Telefono
                        if (item.TipoValidacion == tbTipoValidacion.NumeroTelefono)
                        {
                            valor = DSDatos.Tables[0].Rows[0][item.NombreCampo].ToString();
                            valor = valor.Replace("-", string.Empty);

                            if (objUtil.ValidaTelef(valor) == false)
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += "No es un Numero de Telefono Valido" + "\r";
                            }

                        }

                        //Validamos EMail
                        if (item.TipoValidacion == tbTipoValidacion.EMail)
                        {
                            valor = DSDatos.Tables[0].Rows[0][item.NombreCampo].ToString();

                            if (valor.Trim() != "")
                            {
                                if (objUtil.ValidaEMail(valor) == false)
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += "No es un EMail Valido" + "\r";
                                }
                            }

                        }

                        //Mostramos el Error en el Control
                        if ((item.comtrol != null) && (resultado == false))
                        {
                            MyErrorProvider.SetError(item.comtrol, item.Mensaje);
                            if (item.comtrol is TextBox) item.comtrol.BackColor = Color.FromArgb(255, 192, 192);
                        }

                    }
                }

                resultado = (cantErrores <= 0);
                if (cantErrores > 0) objUtil.MostrarMensajeAdvertencia(mensaje);
            }

            catch (Exception ex)
            {
                resultado = false;
                throw new Exception("Error Al Validar en " + nombreControl + ", " + ex.Message);
            }

            return resultado;
        }

        public virtual bool ValidarDatos(TabPage page)
        {
            bool resultado = true;
            string mensaje = "";
            string valor = "";
            string valorText = "";
            double valorNumerico = 0;
            int cantErrores = 0;

            Valida[] _aValidar = null;
            string _nombreCampo = "";

            try
            {
                MyErrorProvider.Clear();
                cantErrores = 0;
                mensaje = "";


                foreach (Control item in page.Controls)
                {
                    _aValidar = null;

                    if (item is ELRTextBox)
                    {
                        _aValidar = ((ELRTextBox)item).AValidar;
                        _nombreCampo = ((ELRTextBox)item).CampoData;
                        valorText = ((ELRTextBox)item).Text;
                    }
                    else if (item is ELRCombobox)
                    {
                        _aValidar = ((ELRCombobox)item).AValidar;
                        _nombreCampo = ((ELRCombobox)item).CampoData;
                        valorText = ((ELRCombobox)item).Text;
                    }
                    else if (item is ELRNumericUpdDown)
                    {
                        _aValidar = ((ELRNumericUpdDown)item).AValidar;
                        _nombreCampo = ((ELRNumericUpdDown)item).CampoData;
                        valorText = ((ELRNumericUpdDown)item).Value.ToString();
                    }
                    else if (item is ELRDatePicker)
                    {
                        _aValidar = ((ELRDatePicker)item).AValidar;
                        _nombreCampo = ((ELRDatePicker)item).CampoData;
                        valorText = "1";
                    }

                    if (_aValidar != null)
                    {
                        foreach (Valida OValida in _aValidar)
                        {
                            resultado = true;

                            if (OValida.NombreCampo == null) OValida.NombreCampo = _nombreCampo;
                            else if (OValida.NombreCampo.Trim() == "") OValida.NombreCampo = _nombreCampo;

                            //VALIDAMOS NO NULO
                            if (DSDatos.Tables[0].Rows[0][OValida.NombreCampo] is DBNull)
                            {
                                resultado = false;
                                cantErrores++;
                                mensaje += OValida.NombreCampo + ", No Puede Estar Nulo" + "\r";
                            }
                            else
                            {
                                //VALIDAMOS NO VACIO
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString().Trim();
                                if ((valor == "") || (valor.ToUpper() == "NULL") || (valorText.Trim() == ""))
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += OValida.NombreCampo + ", No Puede Estar Vacio" + "\r";
                                }
                            }

                            //VALIDAMOS MAYOR O IGUAL A
                            if (OValida.TipoValidacion == tbTipoValidacion.MayorOIgualA)
                            {
                                valorNumerico = double.Parse(valor);

                                if (!(valorNumerico >= double.Parse(OValida.Valor1)))
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += OValida.Mensaje + "\r";
                                }

                            }

                            //VALIDAMOS MENOR O IGUAL A
                            if (OValida.TipoValidacion == tbTipoValidacion.MenorOIgualA)
                            {
                                valorNumerico = double.Parse(valor);

                                if (!(valorNumerico <= double.Parse(OValida.Valor1)))
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += OValida.Mensaje + "\r";
                                }

                            }

                            //VALIDAMOS EN RANGO
                            if (OValida.TipoValidacion == tbTipoValidacion.EnRango)
                            {
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString();
                                valorNumerico = double.Parse(valor);

                                if ((valorNumerico < double.Parse(OValida.Valor1)) || (valorNumerico > double.Parse(OValida.Valor2)))
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += OValida.Mensaje + "\r";
                                }

                            }

                            //VALIDAMOS LONGITUD MINIMA
                            if (OValida.TipoValidacion == tbTipoValidacion.LongitudMinima)
                            {
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString();

                                if (valor.Trim().Length < int.Parse(OValida.Valor1))
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += OValida.Mensaje + "\r";
                                }

                            }

                            //Validamos Solo Numero
                            if (OValida.TipoValidacion == tbTipoValidacion.SoloNumero)
                            {
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString();

                                if (objUtil.ValidaSoloNumero(valor) == false)
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += "Solo esta Permitido Numero" + "\r";
                                }

                            }

                            //Validamos Numero decimales
                            if (OValida.TipoValidacion == tbTipoValidacion.Decimal)
                            {
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString();

                                if (objUtil.ValidaDecimal(valor) == false)
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += "No es un Decimal Valido" + "\r";
                                }

                            }

                            //Validamos Numero Telefono
                            if (OValida.TipoValidacion == tbTipoValidacion.NumeroTelefono)
                            {
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString();
                                valor = valor.Replace("-", string.Empty);

                                if (objUtil.ValidaTelef(valor) == false)
                                {
                                    resultado = false;
                                    cantErrores++;
                                    mensaje += "No es un Numero de Telefono Valido" + "\r";
                                }

                            }

                            //Validamos EMail
                            if (OValida.TipoValidacion == tbTipoValidacion.EMail)
                            {
                                valor = DSDatos.Tables[0].Rows[0][OValida.NombreCampo].ToString();

                                if (valor.Trim() != "")
                                {
                                    if (objUtil.ValidaEMail(valor) == false)
                                    {
                                        resultado = false;
                                        cantErrores++;
                                        mensaje += "No es un EMail Valido" + "\r";
                                    }
                                }

                            }

                            //Mostramos el Error en el Control
                            if (resultado == false) MyErrorProvider.SetError(item, OValida.Mensaje);
                        }
                    }

                }

                resultado = (cantErrores == 0);
                if (cantErrores > 0) objUtil.MostrarMensajeAdvertencia(mensaje);

            }

            catch (Exception)
            {
                resultado = false;
                throw;
            }

            return resultado;
        }

        public virtual int GrabarDatos()
        {
            int resultado = -1;
            bool valido = false;
            double aContado = 0;
            DateTime fecha = DateTime.Now;

            DialogResult resp;

            int id = 0;
            string variableValor = "";

            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            ELRFormDesglosePago objDesglose = new ELRFormDesglosePago();
            FormDesglosePagoCliente objDesgloseCliente = new FormDesglosePagoCliente();
            ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

            double monto = 0, montoNotaCredito = 0, montoAPagar = 0;
            double enEfectivo = 0, enCheques = 0, enTarjetas = 0, enOtros = 0, aDevolver = 0;
            double subTotal = 0, totalNeto = 0, totalDescuento = 0, totalItbis = 0;

            DataRow MyFila = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                lOK = false;
                isError = false;
                aCredito = 0;
                montoLetras = "";

                //BUSCAMOS ALGUNOS VALORES EN VARIABLES
                IMPRIME_TICKET_COPIA = 0;
                variableValor = objUtil.GetValorVariable("IMPRIME_TICKET_COPIA", DTVariablesSYS, "0");
                int.TryParse(variableValor, out IMPRIME_TICKET_COPIA);


                //ESCRIBIMOS LOS VALORES A DATASET
                if (TabRegistro == null) PasarValorADS();
                else PasarValorADS(TabRegistro.SelectedTab);


                //Posteamos la Ultima Fila Modificada del DataGrid
                if ((DataGridDetalle != null) && (EsConTemporal))
                {

                    if ((DataGridDetalle.RowCount > 0) && (DataGridDetalle.ReadOnly == false)) PostLineaDetalle();
                }
                // PostearFilaGrid();

                valido = true;

                //VALIDAMOS SI SE REQUIERE CLIENTE
                if ((drCliente == null) && (RequiereCliente) && (usaCliente0 == false) && (esNuevo))
                {
                    valido = false;
                    objUtil.MostrarMensajeError("DEBE SELECCIONAL EL CLIENTE");
                }


                //VALIDAMOS HAYA ESPECIFICADO LINEA DE DETALLE
                if (DSDatos.Tables.Contains("Detalle"))
                {
                    if (DTDetalle.Rows.Count <= 0 && RequiereLineaDetalle == true)
                    {
                        valido = false;
                        objUtil.MostrarMensajeError("Debe Indicar Por lo Menos una linea de Detalle");
                    }
                }

                //VALIDAMOS LA ENTRADA DE DATOS
                if (valido)
                {
                    if (TabRegistro == null) valido = ValidarDatos();
                    else valido = ValidarDatos(TabRegistro.SelectedTab);
                }

                //VALIDAMOS QUE HAYA INDICADO NOMBRE DEL SPGRABA
                if ((EsConTemporal) && (SPGraba.Trim() == "") && (valido))
                {
                    valido = false;
                    objUtil.MostrarMensajeError("No ha Especificado Nombre del SPGraba");
                }


                //PREGUNTAMOS ANTE DE GRABAR
                if (valido)
                {
                    if (MensajePregunta == null) MensajePregunta = "";

                    if ((MensajePregunta.Trim() != "") && (MostrarDesglosePago == false))
                    {
                        valido = false;
                        resp = objUtil.MostrarMensajePregunta(MensajePregunta);
                        valido = (resp == System.Windows.Forms.DialogResult.Yes);
                    }
                }

                if ((valido) && (EsConTemporal) && DSDatos.Tables.Contains("Encabezado")) PostEncabezadoTemp();

                //BUSCAMOS EL MONTO A PAGAR
                MyFila = DSDatos.Tables[0].Rows[0];
                if (MyFila.Table.Columns.Contains("Total")) monto = objUtil.GetAsDouble("Total", MyFila);
                else if (MyFila.Table.Columns.Contains("Monto")) monto = objUtil.GetAsDouble("Monto", MyFila);


                if (MyFila.Table.Columns.Contains("Monto"))
                {
                    if ((MyFila.Table.Columns.Contains("Monto_US")) && (tasaCambioUS > 0)) SetValorEncabezado("Monto_US", (monto / tasaCambioUS));
                }

                if (MyFila.Table.Columns.Contains("Total"))
                {
                    if ((MyFila.Table.Columns.Contains("Total_US")) && (tasaCambioUS > 0)) SetValorEncabezado("Total_US", (monto / tasaCambioUS));
                }

                //Buscamos SubTotal
                if (MyFila.Table.Columns.Contains("Sub_Total"))
                {
                    subTotal = objUtil.GetAsDouble("Sub_Total", MyFila);
                    if ((MyFila.Table.Columns.Contains("Sub_Total_US")) && (tasaCambioUS > 0)) SetValorEncabezado("Sub_Total_US", (subTotal / tasaCambioUS));
                }

                if (MyFila.Table.Columns.Contains("Descuento"))
                {
                    totalDescuento = objUtil.GetAsDouble("Descuento", MyFila);
                    if ((MyFila.Table.Columns.Contains("Descuento_US")) && (tasaCambioUS > 0)) SetValorEncabezado("Descuento_US", (totalDescuento / tasaCambioUS));
                }


                if (MyFila.Table.Columns.Contains("Neto"))
                {
                    totalNeto = objUtil.GetAsDouble("Neto", MyFila);
                    if ((MyFila.Table.Columns.Contains("Neto_US")) && (tasaCambioUS > 0)) SetValorEncabezado("Neto_US", (totalNeto / tasaCambioUS));
                }

                if (MyFila.Table.Columns.Contains("Itbis"))
                {
                    totalItbis = objUtil.GetAsDouble("Itbis", MyFila);
                    if ((MyFila.Table.Columns.Contains("Itbis_US")) && (tasaCambioUS > 0)) SetValorEncabezado("Itbis_US", (totalItbis / tasaCambioUS));
                }



                if (MyFila.Table.Columns.Contains("Nota_Credito_Monto")) montoNotaCredito = objUtil.GetAsDouble("Nota_Credito_Monto", MyFila);

                montoAPagar = monto - montoNotaCredito;
                aContado = 0;
                aCredito = 0;

                if (montoAPagar < 0)
                {
                    objUtil.MostrarMensajeAdvertencia("El Monto a Pagar: " + montoAPagar.ToString("N2") + " No Puede ser Menor a Cero");
                    valido = false;
                }

                if (EsEditEntidad)
                {
                    if (!showEditEntidad()) valido = false;
                }

                //REALIZAMOS EL DESGLOSE DE PAGO
                if ((valido) && (MostrarDesglosePago) && montoAPagar > 0)
                {
                    valido = false;

                    //PASAMOS EL CODIGO DE CAJA
                    if (DSDatos.Tables[0].Columns.Contains("Caja_Id")) SetValorEncabezado("Caja_Id", cajaId);

                    if (EditarClienteDesglose == false)
                    {
                        objDesglose.metodoImp = metodoImp;
                        objDesglose.monto = montoAPagar;
                        objDesglose.diasCredito = diasCredito;
                        objDesglose.PermiteCredito = PermiteACredito;
                        objDesglose.DTVariablesSYS = DTVariablesSYS;

                        if (tasaCambioUS > 0) objDesglose.montoUS = (montoAPagar / tasaCambioUS);

                        objDesglose.ShowDialog();

                        if (objDesglose.LOK)
                        {
                            enEfectivo = objDesglose.enEfectivo;
                            enCheques = objDesglose.enCheques;
                            enTarjetas = objDesglose.enTarjetas;
                            aDevolver = objDesglose.aDevolver;

                            //DESGLOSAMOS LA VENTA A CREDITO Y AL CONTADO
                            aContado = objDesglose.monto - objDesglose.montoDeduda;
                            aCredito = objDesglose.montoDeduda;

                            valido = objDesglose.LOK;
                        }
                    }
                    else
                    {
                        //MOSTRAMOS DESGLOSE EDITANDO DATOS DEL CLIENTE
                        lOK = false;
                        objDesgloseCliente.metodoImp = metodoImp;
                        objDesgloseCliente.monto = montoAPagar;
                        objDesgloseCliente.esCredito = PermiteACredito;
                        objDesgloseCliente.nombreUsuario = nombreUsuario;
                        objDesgloseCliente.temporalId = temporalID;
                        objDesgloseCliente.esNuevo = esNuevo;
                        if (tasaCambioUS > 0) objDesgloseCliente.montoUS = (montoAPagar / tasaCambioUS);
                        if (MyFila.Table.Columns.Contains("Entidad_Id")) objDesgloseCliente.entidadId = objUtil.GetAsInt("Entidad_Id", MyFila);
                        if (MyFila.Table.Columns.Contains("NCF")) objDesgloseCliente.ncf = objUtil.GetAsString("NCF", MyFila);
                        if (MyFila.Table.Columns.Contains("Dias_Credito")) objDesgloseCliente.diasCredito = objUtil.GetAsInt("Dias_Credito", MyFila);

                        objDesgloseCliente.ShowDialog();

                        if (objDesgloseCliente.LOK)
                        {
                            enEfectivo = objDesgloseCliente.enEfectivo;
                            enCheques = objDesgloseCliente.enCheques;
                            enTarjetas = objDesgloseCliente.enTarjetas;
                            aDevolver = objDesgloseCliente.aDevolver;

                            //DESGLOSAMOS LA VENTA A CREDITO Y AL CONTADO
                            aContado = objDesgloseCliente.monto - objDesgloseCliente.montoDeduda;
                            aCredito = objDesgloseCliente.montoDeduda;

                            //ASIGNAMOS LOS DATOS DEL CLIENTE
                            if (DSDatos.Tables[0].Columns.Contains("Entidad_Id")) SetValorEncabezado("Entidad_Id", objDesgloseCliente.entidadId);
                            if (DSDatos.Tables[0].Columns.Contains("CedulaRNC")) SetValorEncabezado("CedulaRNC", objDesgloseCliente.cedulaRNC);
                            if (DSDatos.Tables[0].Columns.Contains("Nombres")) SetValorEncabezado("Nombres", objDesgloseCliente.nombreCompleto);
                            if (DSDatos.Tables[0].Columns.Contains("ANombre")) SetValorEncabezado("ANombre", objDesgloseCliente.nombreCompleto);
                            if (DSDatos.Tables[0].Columns.Contains("ANombres")) SetValorEncabezado("Apellidos", objDesgloseCliente.apellidos);
                            if (DSDatos.Tables[0].Columns.Contains("Apellidos")) SetValorEncabezado("Telefono", objDesgloseCliente.telefonos);
                            if (DSDatos.Tables[0].Columns.Contains("Direccion")) SetValorEncabezado("Direccion", objDesgloseCliente.direccion);
                            if (DSDatos.Tables[0].Columns.Contains("Telefonos")) SetValorEncabezado("Telefonos", objDesgloseCliente.telefonos);
                            if (DSDatos.Tables[0].Columns.Contains("Telefono")) SetValorEncabezado("Telefono", objDesgloseCliente.telefonos);
                            if (DSDatos.Tables[0].Columns.Contains("Telefono1")) SetValorEncabezado("Telefono1", objDesgloseCliente.telefono1);
                            if (DSDatos.Tables[0].Columns.Contains("Telefono2")) SetValorEncabezado("Telefono2", objDesgloseCliente.telefono2);
                            if (DSDatos.Tables[0].Columns.Contains("Dias_Credito")) SetValorEncabezado("Dias_Credito", objDesgloseCliente.diasCredito);
                            if (DSDatos.Tables[0].Columns.Contains("Fecha_Vencimiento")) SetValorEncabezado("Fecha_Vencimiento", objDesgloseCliente.fechaVence);
                            if (DSDatos.Tables[0].Columns.Contains("Fecha_Vence")) SetValorEncabezado("Fecha_Vence", objDesgloseCliente.fechaVence);

                            valido = objDesgloseCliente.LOK;
                        }
                    }

                }


                if (valido)
                {

                    //ESCRIBIMOS EL DESGLOSE DEL PAGO O ABONO REALIZADO, MONEDA PESO DOMINICANO
                    if (DSDatos.Tables[0].Columns.Contains("EnEfectivo")) SetValorEncabezado("EnEfectivo", enEfectivo);
                    if (DSDatos.Tables[0].Columns.Contains("EnCheques")) SetValorEncabezado("EnCheques", enCheques);
                    if (DSDatos.Tables[0].Columns.Contains("EnTarjeta")) SetValorEncabezado("EnTarjeta", enTarjetas);

                    if (DSDatos.Tables[0].Columns.Contains("En_Efectivo")) SetValorEncabezado("En_Efectivo", enEfectivo);
                    if (DSDatos.Tables[0].Columns.Contains("En_Cheques")) SetValorEncabezado("En_Cheques", enCheques);
                    if (DSDatos.Tables[0].Columns.Contains("En_Tarjeta")) SetValorEncabezado("En_Tarjeta", enTarjetas);
                    if (DSDatos.Tables[0].Columns.Contains("En_Tarjetas")) SetValorEncabezado("En_Tarjetas", enTarjetas);
                    if (DSDatos.Tables[0].Columns.Contains("En_Otros")) SetValorEncabezado("En_Otros", enOtros);

                    if (DSDatos.Tables[0].Columns.Contains("ADevolver")) SetValorEncabezado("ADevolver", aDevolver);


                    if (DSDatos.Tables[0].Columns.Contains("aContado")) DSDatos.Tables[0].Rows[0]["aContado"] = aContado;
                    if (DSDatos.Tables[0].Columns.Contains("AlContado")) DSDatos.Tables[0].Rows[0]["AlContado"] = aContado;
                    if (DSDatos.Tables[0].Columns.Contains("Monto_AlContado")) DSDatos.Tables[0].Rows[0]["Monto_AlContado"] = aContado;

                    if (DSDatos.Tables[0].Columns.Contains("aCredito")) DSDatos.Tables[0].Rows[0]["aCredito"] = aCredito;
                    if (DSDatos.Tables[0].Columns.Contains("Monto_ACredito")) DSDatos.Tables[0].Rows[0]["Monto_ACredito"] = aCredito;


                    //ESCRIBIMOS EL DESGLOSE DEL PAGO O ABONO REALIZADO, MONEDA PESO DOLARES USA
                    if (DSDatos.Tables[0].Columns.Contains("Tasa_Cambio_US")) SetValorEncabezado("Tasa_Cambio_US", tasaCambioUS);
                    if (tasaCambioUS > 0)
                    {
                        if (DSDatos.Tables[0].Columns.Contains("EnEfectivo_US")) SetValorEncabezado("EnEfectivo_US", enEfectivo / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("EnCheques_US")) SetValorEncabezado("EnCheques_US", enCheques / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("EnTarjeta_US")) SetValorEncabezado("EnTarjeta_US", enTarjetas);

                        if (DSDatos.Tables[0].Columns.Contains("En_Efectivo_US")) SetValorEncabezado("En_Efectivo_US", enEfectivo / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("En_Cheques_US")) SetValorEncabezado("En_Cheques_US", enCheques / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("En_Tarjeta_US")) SetValorEncabezado("En_Tarjeta_US", enTarjetas / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("En_Tarjetas_US")) SetValorEncabezado("En_Tarjetas_US", enTarjetas / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("En_Otros_US")) SetValorEncabezado("En_Otros_US", enOtros / tasaCambioUS);

                        if (DSDatos.Tables[0].Columns.Contains("ADevolver_US")) SetValorEncabezado("ADevolver_US", aDevolver / tasaCambioUS);


                        if (DSDatos.Tables[0].Columns.Contains("aContado_US")) DSDatos.Tables[0].Rows[0]["aContado_US"] = (aContado / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("AlContado_US")) DSDatos.Tables[0].Rows[0]["AlContado_US"] = (aContado / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("Monto_AlContado_US")) DSDatos.Tables[0].Rows[0]["Monto_AlContado_US"] = (aContado / tasaCambioUS);

                        if (DSDatos.Tables[0].Columns.Contains("aCredito_US")) DSDatos.Tables[0].Rows[0]["aCredito_US"] = (aCredito / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("Monto_ACredito_US")) DSDatos.Tables[0].Rows[0]["Monto_ACredito_US"] = (aCredito / tasaCambioUS);
                    }

                }

                //ESCRIBIMOS VALORES EN LOS CAMPOS PARA SALDO
                if ((DSDatos.Tables.Contains("Encabezado")) && (valido))
                {
                    if (DSDatos.Tables[0].Columns.Contains("Capital_Pendiente")) DSDatos.Tables[0].Rows[0]["Capital_Pendiente"] = aCredito;
                    if (DSDatos.Tables[0].Columns.Contains("Interes_Pendiente")) DSDatos.Tables[0].Rows[0]["Interes_Pendiente"] = 0;
                    if (DSDatos.Tables[0].Columns.Contains("Demora_Pendiente")) DSDatos.Tables[0].Rows[0]["Demora_Pendiente"] = 0;
                    if (DSDatos.Tables[0].Columns.Contains("Otros_Pendiente")) DSDatos.Tables[0].Rows[0]["Otros_Pendiente"] = 0;

                    if (DSDatos.Tables[0].Columns.Contains("Saldo")) DSDatos.Tables[0].Rows[0]["Saldo"] = aCredito;
                    if (DSDatos.Tables[0].Columns.Contains("Balance")) DSDatos.Tables[0].Rows[0]["Balance"] = aCredito;
                    if (DSDatos.Tables[0].Columns.Contains("Balance_Pendiente")) DSDatos.Tables[0].Rows[0]["Balance_Pendiente"] = aCredito;
                    if (DSDatos.Tables[0].Columns.Contains("Balance_Actual")) DSDatos.Tables[0].Rows[0]["Balance_Actual"] = aCredito;

                    //Guardamos los Valores en Dolares US$
                    if (tasaCambioUS > 0)
                    {
                        if (DSDatos.Tables[0].Columns.Contains("Capital_Pendiente_US")) DSDatos.Tables[0].Rows[0]["Capital_Pendiente_US"] = (aCredito / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("Interes_Pendiente_US")) DSDatos.Tables[0].Rows[0]["Interes_Pendiente_US"] = 0;
                        if (DSDatos.Tables[0].Columns.Contains("Demora_Pendiente_US")) DSDatos.Tables[0].Rows[0]["Demora_Pendiente_US"] = 0;
                        if (DSDatos.Tables[0].Columns.Contains("Otros_Pendiente_US")) DSDatos.Tables[0].Rows[0]["Otros_Pendiente_US"] = 0;

                        if (DSDatos.Tables[0].Columns.Contains("Saldo_US")) DSDatos.Tables[0].Rows[0]["Saldo_US"] = (aCredito / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("Balance_US")) DSDatos.Tables[0].Rows[0]["Balance_US"] = (aCredito / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("Balance_Pendiente_US")) DSDatos.Tables[0].Rows[0]["Balance_Pendiente_US"] = (aCredito / tasaCambioUS);
                        if (DSDatos.Tables[0].Columns.Contains("Balance_Actual_US")) DSDatos.Tables[0].Rows[0]["Balance_Actual_US"] = (aCredito / tasaCambioUS);
                    }
                }

                //GRABAMOS LOS DATOS
                if (valido)
                {
                    valido = false;

                    //ACTUALIZAMOS EL ENCABEZADO TEMPORAL CON LOS VALORES ANTES DE EJECUTAR EL STORE PROCEDURE
                    if ((EsConTemporal) && (DSDatos.Tables.Contains("Encabezado"))) PostEncabezadoTemp();

                    objDB.iniciarTransaccion();

                    if ((EsConTemporal) && (SPGraba.Trim() != ""))
                    {
                        //EJECUTAMOS EL SP QUE PASA DEL TEMPORAL A LA TABLA DE OPERACIONES
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        if (EditarClienteDesglose) MyParametros.Add(new DataDB_ELR_NET.Parametro("editaEntidad", true));
                        //MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", objDB.NOMBRE_USUARIO));

                        resultado = objDB.EjecutarSP(SPGraba, MyParametros);
                        if (resultado < 0)
                        {
                            //MOSTRAMOS ERRORES DEL SISTEMA
                            valido = false;

                            objMsgERRORES.TemporalId = temporalID;
                            objMsgERRORES.objDB = objDB;

                            objMsgERRORES.ShowDialog();
                        }
                        else
                        {
                            id = resultado;
                            valido = true;
                        }

                    }
                    else if ((esNuevo) && (DSDatos.Tables.Contains("Encabezado")))
                    {
                        resultado = objDB.Insertar(TablaEncabezado, NombreCampoID, DSDatos.Tables[0], 0, CamposAExcluirEnc);
                        valido = (resultado > 0);
                    }
                    else if (DSDatos.Tables.Contains("Encabezado"))
                    {
                        resultado = objDB.Actualizar(TablaEncabezado, NombreCampoID, DSDatos.Tables[0], 0, CamposAExcluirEnc);
                        valido = (resultado > 0);
                    }
                    else
                    {
                        valido = false;
                        objUtil.MostrarMensajeError("No se ha Especificado Tabla Encabezado y/o Store Procedure Para Grabar desde Temporal");
                    }

                    if (valido) valido = EjecutaOtros();

                }


                if (valido)
                {
                    objDB.confirmarTransaccion();
                    lOK = true;
                }
                else objDB.cancelarTransaccion();



                //SI NO HUBO ERROR MOSTRAMOS UN MENSAJE Y SE IMPRIME
                if (valido)
                {
                    imprimeEnSuCambio = metodoImp >= 3;
                    if ((ImprimirAlGrabar) && (id > 0) && (metodoImp <= 2)) Imprimir(id.ToString(), metodoImp);

                    if (MostrarDesglosePago)
                    {
                        FormSuCambio frmSuCambio = new FormSuCambio();
                        frmSuCambio.metodoImp = metodoImp;
                        frmSuCambio.montoADevolver = aDevolver;
                        frmSuCambio.mostrarImprimir = (metodoImp >= 3);
                        frmSuCambio.ShowDialog();

                        if (imprimeEnSuCambio && ImprimirAlGrabar && frmSuCambio.metodoImp >= 3) Imprimir(id.ToString(), metodoImp);

                        frmSuCambio.Dispose();

                    }
                    else if (ImprimirAlGrabar && metodoImp == 3) Imprimir(id.ToString(), metodoImp);
                    else if (ImprimirAlGrabar == false) objUtil.MostrarMensajeInformacion("Datos Registrado de Forma Satisfactoria...");


                    //BORRAMOS O LIMPIAMOS EL TEMPORAL
                    if (EsConTemporal) objDB.LimpiarTemporal(TablaEncabezado, TablaDetalle, temporalID);

                    //ENVIAMOS UN MENSAJE
                    if ((EsConTemporal) || (SPGraba.Trim() != ""))
                    {
                        if ((esLicenciaActiva == false) && (nombreUsuario.ToUpper() != "SYS.ADMIN"))
                        {
                            objUtil.TITULO_MENSAJE = this.Name + "(" + Text + ")";
                            objUtil.MENSAJE = "PROCESO REALIZADO DE FORMA SATISFACTORIA, NUMERO: " + resultado.ToString();
                            Thread tAux = new Thread(new ThreadStart(objUtil.EnviarEMail));
                            tAux.Start();
                            while (!tAux.IsAlive) ;
                        }
                    }

                    if (NuevoRegistroAlGrabar)
                    {
                        LimpiarControles();
                        VALOR_ID = "0";
                        GetData();

                        MostrarDatosCliente();
                    }
                    else this.Close();

                }

            }
            catch (Exception ex)
            {
                resultado = -1;
                objUtil.MostrarMensajeError(ex.Message);

            }
            finally
            {
                this.Cursor = Cursors.Default;
                objDB.cancelarTransaccion();
                objDB.CerrarConeccion();
            }

            return resultado;
        }

        public virtual bool Imprimir(string valorId = "", int tipoImp = 0)
        {
            bool resultado = true;
            int tipoNCF = 0;
            Thread t;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DTVistaData = null;

                if (NombreReporte == null) NombreReporte = "";
                if (NombreVistaImprimir == null) NombreVistaImprimir = "";

                //OBTENEMOS LA DATA DE LA VISTA PARA IMPRIMIR, SI ASI SE INDICO
                if (NombreVistaImprimir.Trim() != "")
                {
                    if (NombreCampoID == null) NombreCampoID = "";

                    if (NombreCampoID.Trim() != "") DTVistaData = objDB.GetById(NombreVistaImprimir, valorId, NombreCampoID);
                    else DTVistaData = objDB.GetById(NombreVistaImprimir, valorId, CampoIdImprimir);
                }

                //MOSTRAMOS EL REPORTE
                if (DTVistaData != null)
                {
                    if (DTVistaData.Columns.Contains("Tipo_NCF"))
                    {
                        NombreReporte = NombreReporte.ToUpper().Trim();
                        if (NombreReporte == "RPTFACTURAB") NombreReporte = "RPTFACTURA";
                        tipoNCF = objUtil.GetAsInt("Tipo_NCF", DTVistaData.Rows[0]);
                        if (tipoNCF > 0 && NombreReporte == "RPTFACTURA") NombreReporte = "RPTFACTURAB";
                    }
                    if (tipoImp <= 1)
                    {
                        t = new Thread(ImprimirTicket);
                        t.Start();
                    }
                    else if (tipoImp == 2)
                    {
                        t = new Thread(ImprimirEnMatricial);
                        t.Start();
                    }
                    else ImprimirPreviewRDLC();
                }

            }
            catch (Exception ex)
            {

                resultado = false;
                objUtil.MostrarMensajeError("Error al Imprimir, " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }

            return resultado;

        }

        //DECLARAMOS METODOS VIRTUALES PARA IMPRIMIR
        public virtual void ImprimirEnOtroFormato()
        {

        }

        public virtual void ImprimirEnMatricial()
        {

        }

        public virtual void ImprimirTicket()
        {

        }

        public virtual void ImprimirPreviewRDLC()
        {
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();
            string pathReporte = "";

            try
            {
                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC(NombreReporte);
                if (pathReporte.Trim() != "")
                {
                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = DTVistaData;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = TituloReporte;
                    frmPreview.titulo = TituloReporte;
                    frmPreview.pathReporte = pathReporte.Trim();
                    frmPreview.montoLetras = montoLetras;

                    frmPreview.ShowDialog();
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frmPreview.Dispose();
            }
        }

        public virtual void ImprimirTicketRDLC()
        {

        }

        public virtual bool LimpiarControles()
        {
            bool resultado = false;
            try
            {
                esNuevo = true;
                VALOR_ID = "0";
                PermiteACredito = false;

                drCliente = null;
                drProducto = null;

                if ((EsConTemporal) && (temporalID.Trim() != ""))
                {
                    objDB.LimpiarTemporal(TablaEncabezado, TablaDetalle, temporalID);
                    temporalID = objUtil.GetTemporalID();
                }

                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            bool esCerrar = true;
            try
            {
                if (btnGrabar.Visible || btnSiguientePage.Visible || btnAnterior.Visible)
                {
                    resp = objUtil.MostrarMensajePregunta("ESTA SEGURO QUE DESEA CERRAR Y CANCELAR LA TRANSACCION?");
                    esCerrar = (resp == DialogResult.Yes);
                }

                if (esCerrar)
                {
                    Cursor = Cursors.WaitCursor;
                    lOK = false;
                    DSDatos.Clear();
                    BorrarTemporales();
                    Cursor = Cursors.Default;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                objUtil.MostrarMensajeError(ex.Message);
            }


        }

        public double GetSumDetalle(string nombreCampo, string filtro = "")
        {
            double resultado = 0;
            object calcObject;
            try
            {

                calcObject = DTDetalle.Compute("Sum(" + nombreCampo + ")", filtro);
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") resultado = double.Parse(calcObject.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public int GetCountDetalle(string nombreCampo, string filtro = "")
        {
            int resultado = 0;
            object calcObject;
            try
            {
                DataGridDetalle.EndEdit();

                calcObject = DTDetalle.Compute("Count(" + nombreCampo + ")", filtro);
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") resultado = int.Parse(calcObject.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public double GetSum(string nombreCampo, DataTable data, string filtro = "")
        {
            double resultado = 0;
            object calcObject;
            try
            {

                calcObject = data.Compute("Sum(" + nombreCampo + ")", filtro);
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") resultado = double.Parse(calcObject.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public int GetCount(string nombreCampo, DataTable data, string filtro = "")
        {
            int resultado = 0;
            object calcObject;
            try
            {

                calcObject = data.Compute("Count(" + nombreCampo + ")", filtro);
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") resultado = int.Parse(calcObject.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }


        public virtual void TotalizarDetalle()
        {

            try
            {
                if (ATotalizar != null)
                {
                    foreach (Totaliza item in ATotalizar)
                    {

                        double valor = 0;

                        // Declare an object variable.
                        object calcObject;
                        calcObject = DTDetalle.Compute(item.operacion + "(" + item.NombreCampoDet + ")", item.filtro);
                        if (calcObject != null)
                        {
                            if (calcObject.ToString().Trim() != "") valor = double.Parse(calcObject.ToString());
                        }

                        if (item.controlLabel != null) item.controlLabel.Text = valor.ToString(item.Formato);
                        if (item.NombreCampoEnc != "") DSDatos.Tables[0].Rows[0][item.NombreCampoEnc] = Math.Round(valor, item.Redondeo);

                    }
                }

                //GUARDAMOS LOS DATOS DEL ENCABEZADO
                PostEncabezadoTemp();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void AgregarLineaVacia()
        {

            int itemNumero = 1;
            int index = 0;

            try
            {
                detalleFilaActual = DTDetalle.NewRow();

                if (detalleFilaActual.Table.Columns.Contains("Unico")) detalleFilaActual["Unico"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("IdentificadorTemp")) detalleFilaActual["IdentificadorTemp"] = temporalID;
                if (detalleFilaActual.Table.Columns.Contains("Producto_Id")) detalleFilaActual["Producto_Id"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("ItemNumero"))
                {
                    object calcObject;
                    calcObject = DTDetalle.Compute("Max(ItemNumero)", "");
                    if (calcObject != null)
                    {
                        if (calcObject.ToString().Trim() != "")
                        {
                            itemNumero = int.Parse(calcObject.ToString());
                            itemNumero++;
                        }
                    }
                    detalleFilaActual["ItemNumero"] = itemNumero;
                }
                if (detalleFilaActual.Table.Columns.Contains("Cantidad")) detalleFilaActual["Cantidad"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Precio")) detalleFilaActual["Precio"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Precio_Sin_Itbis")) detalleFilaActual["Precio_Sin_Itbis"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Sub_Total")) detalleFilaActual["Sub_Total"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("SubTotal")) detalleFilaActual["SubTotal"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Descuento")) detalleFilaActual["Descuento"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Neto")) detalleFilaActual["Neto"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Tasa_Itbis")) detalleFilaActual["Tasa_Itbis"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Itbis")) detalleFilaActual["Itbis"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Importe")) detalleFilaActual["Importe"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Total")) detalleFilaActual["Total"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Monto")) detalleFilaActual["Monto"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Descripcion")) detalleFilaActual["Descripcion"] = "";

                if (detalleFilaActual.Table.Columns.Contains("Cuenta_Contable")) detalleFilaActual["Cuenta_Contable"] = "0";
                if (detalleFilaActual.Table.Columns.Contains("Debito")) detalleFilaActual["Debito"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Credito")) detalleFilaActual["Credito"] = 0;

                if (detalleFilaActual.Table.Columns.Contains("Codigo_Auxiliar")) detalleFilaActual["Codigo_Auxiliar"] = OFICINA_ID;
                if (detalleFilaActual.Table.Columns.Contains("Oficina_Id")) detalleFilaActual["Oficina_Id"] = OFICINA_ID;
                if (detalleFilaActual.Table.Columns.Contains("Empresa_Id")) detalleFilaActual["Empresa_Id"] = EMPRESA_ID;

                //Para Conversion en Dolares US$
                if (detalleFilaActual.Table.Columns.Contains("Tasa_Cambio_US")) detalleFilaActual["Tasa_Cambio_US"] = tasaCambioUS;
                if (detalleFilaActual.Table.Columns.Contains("Precio_US")) detalleFilaActual["Precio_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Precio_Sin_Itbis_US")) detalleFilaActual["Precio_Sin_Itbis_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Sub_Total_US")) detalleFilaActual["Sub_Total_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("SubTotal_US")) detalleFilaActual["SubTotal_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Descuento_US")) detalleFilaActual["Descuento_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Neto_US")) detalleFilaActual["Neto_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Itbis_US")) detalleFilaActual["Itbis_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Importe_US")) detalleFilaActual["Importe_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Total_US")) detalleFilaActual["Total_US"] = 0;
                if (detalleFilaActual.Table.Columns.Contains("Monto_US")) detalleFilaActual["Monto_US"] = 0;

                objDB.InsertarFromFila(detalleFilaActual, TablaDetalle, "");
                DTDetalle.Rows.Add(detalleFilaActual);

                index = DataGridDetalle.Rows.Count - 1;

                if (DataGridDetalle.Columns.Contains("Producto_Id")) DataGridDetalle.CurrentCell = DataGridDetalle["Producto_Id", index];
                else if (DataGridDetalle.Columns.Contains("Producto")) DataGridDetalle.CurrentCell = DataGridDetalle["Producto", index];
                else if (DataGridDetalle.Columns.Contains("Cuenta_Contable")) DataGridDetalle.CurrentCell = DataGridDetalle["Cuenta_Contable", index];
                else if (DataGridDetalle.Columns.Contains("Codigo")) DataGridDetalle.CurrentCell = DataGridDetalle["Codigo", index];

                DataGridDetalle.BeginEdit(true);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error Agregando Linea Vacia, " + ex.Message);
            }
        }

        public void IrAUltimaFilaDetalle()
        {
            int index = 0;

            try
            {
                if (DataGridDetalle != null)
                {
                    if (DataGridDetalle.RowCount > 0)
                    {
                        index = DataGridDetalle.Rows.Count - 1;
                        foreach (DataGridViewColumn item in DataGridDetalle.Columns)
                        {
                            if (item.Visible)
                            {
                                if (!DataGridDetalle.Focused) DataGridDetalle.Focus();

                                DataGridDetalle.CurrentCell = DataGridDetalle[item.Name, index];
                                break;
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public virtual void AgregarLineaDetalle(DataRow drDetalle, string campoDetalleId = "")
        {
            object calcObject;
            int itemNumero = 0;
            int posicion = 0;
            double precioSinItbis = 0, precio = 0, subtotal = 0, descuento = 0, neto = 0, itbis = 0, monto = 0;
            int index = 0;


            try
            {
                //IR A ULTIMA FILA DETALLE
                //IrAUltimaFilaDetalle();

                this.Cursor = Cursors.WaitCursor;

                //INSERTAMOS EL VALOR DEL CAMPO ID
                if (campoDetalleId != "") drDetalle[campoDetalleId] = VALOR_ID;
                else if (NombreCampoID != null)
                {
                    if (NombreCampoID.Trim() != "") drDetalle[NombreCampoID] = VALOR_ID;
                }
                drDetalle["Unico"] = 0;

                //AGREGAMOS EL VALOR DEL TEMPORAL_ID
                if (EsConTemporal) drDetalle["IdentificadorTemp"] = temporalID;

                //AGREGAMOS CAMPOS EMPRESA_ID Y OFICINA_ID
                if (DTDetalle.Columns.Contains("Empresa_Id")) drDetalle["Empresa_Id"] = EMPRESA_ID;
                if (DTDetalle.Columns.Contains("Oficina_Id")) drDetalle["Oficina_Id"] = OFICINA_ID;

                //ASIGNAMOS NUMERO DE CAJA
                if ((DTDetalle.Columns.Contains("Caja_Id"))) drDetalle["Caja_Id"] = cajaId;

                //NECESITAMOS EL SIGUIENTE ItemNumero
                if ((DTDetalle.Columns.Contains("ItemNumero"))) drDetalle["ItemNumero"] = GetSiguienteItemNumero();

                //SE AGREGA LA LINEA AL DATASET
                DTDetalle.Rows.Add(drDetalle);
                posicion = DTDetalle.Rows.Count - 1;

                //TOTALIZAMOS LOS DATOS
                TotalizarDetalle();

                //Pasamos los datos en US
                if (tasaCambioUS > 0)
                {

                    if (drDetalle.Table.Columns.Contains("Tasa_Cambio_US")) drDetalle["Tasa_Cambio_US"] = Math.Round(tasaCambioUS, 2);


                    if (drDetalle.Table.Columns.Contains("Precio_Sin_Itbis"))
                    {
                        precioSinItbis = objUtil.GetAsDouble("Precio_Sin_Itbis", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Precio_Sin_Itbis_US")) drDetalle["Precio_Sin_Itbis_US"] = Math.Round((precioSinItbis / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Precio"))
                    {
                        precio = objUtil.GetAsDouble("Precio", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Precio_US")) drDetalle["Precio_US"] = Math.Round((precio / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Sub_Total"))
                    {
                        subtotal = objUtil.GetAsDouble("Sub_Total", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Sub_Total_US")) drDetalle["Sub_Total_US"] = Math.Round((subtotal / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Descuento"))
                    {
                        descuento = objUtil.GetAsDouble("descuento", drDetalle);
                        if (drDetalle.Table.Columns.Contains("descuento_US")) drDetalle["descuento_US"] = Math.Round((descuento / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Itbis"))
                    {
                        itbis = objUtil.GetAsDouble("Itbis", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Itbis_US")) drDetalle["Itbis_US"] = Math.Round((itbis / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Monto"))
                    {
                        monto = objUtil.GetAsDouble("Monto", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Monto_US")) drDetalle["Monto_US"] = Math.Round((monto / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Debito"))
                    {
                        monto = objUtil.GetAsDouble("Debito", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Debito_US")) drDetalle["Debito_US"] = Math.Round((monto / tasaCambioUS), 2);
                    }

                    if (drDetalle.Table.Columns.Contains("Credito_Us"))
                    {
                        monto = objUtil.GetAsDouble("Credito", drDetalle);
                        if (drDetalle.Table.Columns.Contains("Credito_US")) drDetalle["Credito_US"] = Math.Round((monto / tasaCambioUS), 2);
                    }

                }

                //REGISTRAMOS LOS DATOS EN LA TABLA DE DETALLE
                DTDetalle.AcceptChanges();
                objDB.Insertar(TablaDetalle, "", DTDetalle, posicion); //INSERTAMOS EL DETALLE

                //Mandamos el Focus a la ultima fila del DataGrid
                IrAUltimaFilaDetalle();

                //IMPRIMIMOS LA LINEA DE DETALLE SI ASI ESTA CONDIGURADO

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                calcObject = null;
            }
        }

        public virtual void EliminarLineaDetalleTemp()
        {
            int resultado = -1;
            int valorItemNumero = 0;
            DataRow fila0 = null;

            int index = 0;
            bool esReadOnly = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;


                if (DataGridDetalle == null) throw new Exception("No Configuro la Propiedad DataGridDetalle");
                else
                {
                    if (!DataGridDetalle.Columns.Contains("ItemNumero")) throw new Exception("No Existe la Columna ItemNumero");

                    esReadOnly = DataGridDetalle.ReadOnly;
                    if (!esReadOnly)
                    {
                        DataGridDetalle.EndEdit();
                        DataGridDetalle.ReadOnly = true;
                    }

                    //ELIMINAMOS HANDLER VALIDA FILA
                    DataGridDetalle.RowValidated -= HandleValidarFila;

                    index = DataGridDetalle.CurrentRow.Index;

                    valorItemNumero = int.Parse(DataGridDetalle["ItemNumero", index].Value.ToString());
                    fila0 = DTDetalle.Select("ItemNumero = " + valorItemNumero.ToString())[0];

                    //ELIMINAMOS LA LINEA DE DETALLE EN EL TEMPORAL DE LA BASE DE DATOS
                    resultado = objDB.EliminarDetalleTemporal(TablaDetalle, temporalID, valorItemNumero);

                    DTDetalle = objDB.GetById(TablaDetalle, temporalID, "IdentificadorTemp");
                    //DataGridDetalle.DataSource = null;
                    DataGridDetalle.DataSource = DTDetalle;
                    DataGridDetalle.ReadOnly = esReadOnly;

                    //Mandamos el Focu a la Siguiente Linea
                    if ((DataGridDetalle.RowCount - 1 >= index) && (DataGridDetalle.RowCount > 0))
                    {
                        foreach (DataGridViewColumn item in DataGridDetalle.Columns)
                        {
                            if (item.Visible)
                            {
                                DataGridDetalle.CurrentCell = DataGridDetalle[item.Index, index];
                                break;
                            }
                        }
                    }

                    TotalizarDetalle();

                }
            }
            catch (Exception)
            {
                objDB.cancelarTransaccion();
                DTDetalle.RejectChanges();

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;

                //Agregamos el Handle Valida Fila
                if (DataGridDetalle != null) DataGridDetalle.RowValidated += new DataGridViewCellEventHandler(HandleValidarFila);
            }

        }

        public virtual void AnularLineaDetalleTemp()
        {
            int resultado = -1;
            int itemNumero = 0;
            DataRow[] drDetalles;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (!DataGridDetalle.Columns.Contains("ItemNumero")) throw new Exception("No Existe la Columna ItemNumero");
                if (DataGridDetalle.SelectedRows.Count <= 0) throw new Exception("No Ha Seleccionado Ninguna Fila para Eliminar");

                itemNumero = (int)DataGridDetalle.SelectedRows[0].Cells["ItemNumero"].Value;

                if (itemNumero < 0) throw new Exception("Esta Linea Ya se Encuenta Anulada");
                using (TransactionScope MyTrans = new TransactionScope())
                {
                    //ANULAMOS EN BASE DE DATOS
                    resultado = objDB.AnularLineaDetalleTemporal(TablaDetalle, temporalID, itemNumero);

                    //ANULAMOS EN EL DATASET
                    if (resultado > 0)
                    {
                        drDetalles = DTDetalle.Select("IdentificadorTemp = '" + temporalID + "' And ItemNumero = " + itemNumero.ToString());
                        foreach (DataRow item in drDetalles)
                        {
                            item["ItemNumero"] = itemNumero * -1;
                            if (DTDetalle.Columns.Contains("Cantidad")) item["Cantidad"] = Math.Abs((double)item["Cantidad"]) * -1;
                            if (DTDetalle.Columns.Contains("Itbis")) item["Itbis"] = Math.Abs((double)item["Itbis"]) * -1;
                            if (DTDetalle.Columns.Contains("Monto")) item["Monto"] = Math.Abs((double)item["Monto"]) * -1;
                            if (DTDetalle.Columns.Contains("Total")) item["Total"] = Math.Abs((double)item["Total"]) * -1;
                            if (DTDetalle.Columns.Contains("Importe")) item["Importe"] = Math.Abs((double)item["Importe"]) * -1;
                            if (DTDetalle.Columns.Contains("Debito")) item["Debito"] = Math.Abs((double)item["Debito"]) * -1;
                            if (DTDetalle.Columns.Contains("Credito")) item["Credito"] = Math.Abs((double)item["Credito"]) * -1;
                        }

                        //TOTALIZAMOS EL DETALLE
                        TotalizarDetalle();

                        //CONFIRMAMOS LA TRANSACCION
                        MyTrans.Complete();
                    }
                    else MyTrans.Dispose();

                }

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

        public virtual void MostrarBotones()
        {
            try
            {
                btnAnterior.Visible = false;
                btnSiguientePage.Visible = false;

                btnGrabar.Visible = true;

                if (TabRegistro != null)
                {
                    btnAnterior.Visible = (TabRegistro.SelectedIndex > 0);
                    btnSiguientePage.Visible = (TabRegistro.SelectedIndex != TabRegistro.TabCount - 1);

                    if (esNuevo) btnGrabar.Visible = (TabRegistro.SelectedIndex == TabRegistro.TabCount - 1);
                    else btnGrabar.Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ValidaLicencia()
        {
            string serialNumero;

            try
            {
                esLicenciaActiva = false;
                diasLimiteSinLicensia = 30;

                serialNumero = objUtil.GetSerialNumber();
                esLicenciaActiva = objDB.ValidarLicense(serialNumero, RNC_EMPRESA, "WIN32");
                diasLimiteSinLicensia = objDB.GetDiasRestanteSinLicencias();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ShowReport(string pathReporte, string titulo = "No Title")
        {
            ReportDataSource DSData;
            int cantParametros = 0;
            bool resultado = true;
            byte[] arrPicture;
            string logoBase64 = "";
            string pathLogo = "";

            try
            {
                pathReporte = pathReporte.ToUpper();

                //AGREGAMOS LA EXTENSION
                if (!pathReporte.Contains("RDLC")) pathReporte += ".rdlc";

                //CARGAMOS EL REPORTE LOCAL DESDE LA CARPETA REPORTES
                resultado = File.Exists(pathReporte);

                if (resultado == false) objUtil.MostrarMensajeError("El Archivo [" + pathReporte + "] No Existe");

                if (resultado)
                {
                    MyReport.LocalReport.ReportPath = pathReporte;
                    MyReport.LocalReport.DataSources.Clear();

                    //AGREGAMOS LOS DATASET
                    if (MyParametrosDS.Count > 0)
                    {
                        foreach (ReportesDS item in MyParametrosDS)
                        {
                            DSData = new ReportDataSource();
                            DSData.Name = item.Nombre;
                            DSData.Value = item.Valor;

                            MyReport.LocalReport.DataSources.Add(DSData);
                        }
                    }

                    //Array que contendrá los parámetros
                    if (montoLetras.Trim() == "") cantParametros = 7;
                    else cantParametros = 8;

                    ReportParameter[] parametros = new ReportParameter[cantParametros];

                    //Establecemos el valor de los parámetros
                    parametros[0] = new ReportParameter("NOMBRE_EMPRESA_OFICINA", NOMBRE_EMPRESA_OFICINA);
                    parametros[1] = new ReportParameter("RNC_EMPRESA", RNC_EMPRESA);
                    parametros[2] = new ReportParameter("DIRECCION_OFICINA", DIRECCION_OFICINA);
                    parametros[3] = new ReportParameter("TELEFONOS_OFICINAS", TELEFONOS_OFICINA);
                    parametros[4] = new ReportParameter("TITULO", titulo);
                    parametros[5] = new ReportParameter("NOMBRE_USUARIO", nombreUsuario);

                    //CARGAMOS EL LOGO
                    pathLogo = Environment.CurrentDirectory + @"\images\logo.png";
                    arrPicture = File.ReadAllBytes(pathLogo);
                    logoBase64 = Convert.ToBase64String(arrPicture);
                    parametros[6] = new ReportParameter("LOGO_EMPRESA", logoBase64);

                    if (montoLetras.Trim() != "") parametros[7] = new ReportParameter("MONTO_LETRAS", montoLetras.ToUpper());


                    MyReport.LocalReport.SetParameters(parametros);

                    //MOSTRAMOS VISTA EN DISENO DE IMPRESION
                    MyReport.SetDisplayMode(DisplayMode.PrintLayout);
                    MyReport.ZoomMode = ZoomMode.Percent;
                    MyReport.ZoomPercent = 100;

                    //POR ULTIMO UN REFRESH AL REPORTE
                    MyReport.RefreshReport();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void ELRFormRegistro_Load(object sender, EventArgs e)
        {
            bool resultado = true;
            DataRow MyFila = null;
            DateTime fecha;
            int diferencia = 0;
            string logoURL = "";
            string valor = "";
            try
            {
                impresoraDefault = "";
                objUtil = new ELRUtils(this);

                if (EnEjecusion)
                {
                    //Inicializamos el panel
                    btnmenu.Visible = MenuLateral;

                    if (nivelForm == 1) coloP = Color.FromArgb(178, 34, 34);
                    else if (nivelForm > 1) coloP = Color.FromArgb(255, 160, 122);

                    panelLateral.BackColor = coloP;
                    btnAnterior.BackColor = coloP;
                    btnSiguientePage.BackColor = coloP;
                    btnGrabar.BackColor = coloP;
                    btnCancelar.BackColor = coloP;
                    btnmenu.BackColor = coloP;

                    panelLateral.Size = new Size(300, 570);
                    panelLateral.AutoScroll = true;
                    panelLateral.Visible = false;
                    Controls.Add(panelLateral);
                    panelLateral.Dock = DockStyle.Left;
                    if (MenuLateralBringToFront) panelLateral.BringToFront();

                    this.Cursor = Cursors.WaitCursor;
                    btnGrabar.Font = new Font(btnGrabar.Font, FontStyle.Bold);

                    objUtil.FORM_NAME = Name + "(" + Text + ")";
                    objUtil.NOMBRE_USUARIO = nombreUsuario;
                    objDB.NOMBRE_USUARIO = nombreUsuario;

                    //VALIDAMOS VARIABLES PARA MOSTRAR DETALLE DE FACTURA COBRO
                    MOSTRAR_DETALLE_FACTURAS_PAGADAS = objUtil.GetValorVariableAsBool("MOSTRAR_DETALLE_FACTURAS_PAGADAS", DTVariablesSYS);

                    //buscamos el metodos a imprimir CAJA_METODO_IMPRIME <= 1 ticket    2 = matricial  3 = Preview
                    valor = objUtil.GetValorVariable("CAJA_METODO_IMPRIME_" + objUtil.GetSerialNumber(), DTVariablesSYS);
                    if (valor.Trim() == "") valor = objUtil.GetValorVariable("CAJA_METODO_IMPRIME", DTVariablesSYS);
                    int.TryParse(valor.Trim(), out metodoImp);
                    if (metodoImp <= 0) metodoImp = 3;

                    //buscamos el nombre de la impresora de caja
                    impresoraDefault = objUtil.GetValorVariable("CAJA_IMP_NOMBRE_" + objUtil.GetSerialNumber(), DTVariablesSYS).Trim();
                    if (impresoraDefault == "DEFAULT" || impresoraDefault == "") impresoraDefault = objUtil.getImpresoraPorDefecto();
                    else if (impresoraDefault == "MOSTRAR_CUADRO_DIALOGO") impresoraDefault = "";

                    //OBTENEMOS LA VARIABLE SI USA CLIENTE 0
                    usaCliente0 = objUtil.GetValorVariableAsBool("USAR_CLIENTE_0", DTVariablesSYS, "0");

                    dirPath = new DirectoryInfo(Application.StartupPath);
                    dirImage = new DirectoryInfo(Application.StartupPath + @"\images");

                    //BUSCAMOS LOS DATOS DE LA OFICINA
                    if (OFICINA_ID > 0)
                    {
                        DTOficina = objDB.GetById("VEMPRESAS_OFICINAS", OFICINA_ID.ToString(), "Oficina_Id");
                        MyFila = DTOficina.Rows[0];
                        NOMBRE_EMPRESA_OFICINA = MyFila["Empresa_Nombre"].ToString() + ", " + MyFila["Nombre"].ToString();
                        EMPRESA_SLOGAN = MyFila["Empresa_Slogan"].ToString();
                        DIRECCION_OFICINA = MyFila["Direccion"].ToString();

                        TELEFONOS_OFICINA = MyFila["Telefono1"].ToString();
                        if (!(MyFila["Telefono2"] is DBNull))
                        {
                            if (MyFila["Telefono2"].ToString().Trim() != "")
                            {
                                if (TELEFONOS_OFICINA.Trim() != "") TELEFONOS_OFICINA += ", ";
                                TELEFONOS_OFICINA += MyFila["Telefono2"].ToString().Trim();
                            }
                        }

                        RNC_EMPRESA = MyFila["Empresa_RNC"].ToString();

                        //PASAMOS DATOS DE LA EMPRESA AL OBJETO UTIL
                        objUtil.EMPRESA_NOMBRE = MyFila["Empresa_Nombre"].ToString();
                        objUtil.EMPRESA_OFICINA = MyFila["Nombre"].ToString();
                        objUtil.EMPRESA_EMAIL = MyFila["EMail"].ToString();
                        objUtil.EMPRESA_TELEFONO = TELEFONOS_OFICINA;

                        defPaisId = objUtil.GetAsInt("Pais_Id", MyFila);
                        defProvinciaId = objUtil.GetAsInt("Provincia_Id", MyFila);
                        defMunicipioId = objUtil.GetAsInt("Municipio_Id", MyFila);

                    }

                    //Buscamos Tasa de Cambio en Dolares US$
                    tasaCambioUS = 0;
                    if (REQUIERE_CONVERTIR_ADOLARES)
                    {
                        if (DTMonedaUS == null) DTMonedaUS = objDB.GetById("TSISTEMA_MONEDAS", "US$", "Codigo");

                        if (DTMonedaUS.Rows.Count > 0)
                        {
                            tasaCambioUS = objUtil.GetAsDouble("Valor_Compra", DTMonedaUS.Rows[0]);

                            if ((RequiereCajaAbierta) || (MostrarDesglosePago))
                            {
                                if (DTMonedaUS.Rows[0]["Fecha_Modificado"] is DBNull)
                                {
                                    objUtil.MostrarMensajeAdvertencia("Tasa Cambio Dolares US$ no Actualizada!!!. \r\r" +
                                                                      "El Sistema Requiere Actualizar Tasa de Cambio para Continuar.");
                                    Close();
                                }
                                else
                                {
                                    fecha = objUtil.GetAsDate("Fecha_Modificado", DTMonedaUS.Rows[0]);
                                    diferencia = objUtil.DateToInt(DateTime.Now.Date) - objUtil.DateToInt(fecha);
                                    if (diferencia > 5)
                                    {
                                        objUtil.MostrarMensajeAdvertencia("Han Pasado Mas de 5 Dias Sin Actualizar Tasa de Cambio Dolares US$. \r\r" +
                                                                    "El Sistema Requiere Actualizar Tasa de Cambio para Continuar.");
                                        Close();
                                    }
                                }
                            }
                        }
                    }




                    //BUSCAMOS EL LOGO DE LA EMPRESA
                    try
                    {
                        logoEmpresa = null;
                        logoURL = Environment.CurrentDirectory + @"\images\logo.png";
                        if (File.Exists(logoURL)) logoEmpresa = Image.FromFile(logoURL);
                    }
                    catch (Exception)
                    {

                        //throw;
                    }


                    if (cajaId < 0) cajaId = -1;
                    lblNombreUsuario.Text = "USUARIO: " + nombreUsuario.ToUpper();

                    if (resultado)
                    {
                        objDB.NOMBRE_USUARIO = nombreUsuario;

                        if (TablaEncabezado == null) TablaEncabezado = "";
                        if (TablaDetalle == null) TablaDetalle = "";

                        if ((TablaEncabezado.Trim() != "") || (TablaDetalle.Trim() != ""))
                        {
                            //CARGAMOS LOS DATOS
                            if (GetData())
                            {

                                //SI SE INDICO FILA SELECCIONADA SE INVOCA LA METODO VIRTUAL MOSTRAR DATA FILA
                                if (drRegistroSel != null) MostrarDataRegistroSel();
                            }

                            FormatearGridDetalle();
                        }

                    }
                    else this.Close();


                    if (TabRegistro != null && esNuevo)
                    {
                        //Ocultamos el Header del Tab
                        TabRegistro.ItemSize = new Size(0, 1);
                        TabRegistro.SizeMode = TabSizeMode.Fixed;
                    }

                    MostrarBotones();

                    //VALIDAMOS LA LICENSIA, EN CASO DE QUE LA VERSION DE PRUEBA HAYA EXPIRADO
                    ValidaLicencia();
                    if ((esLicenciaActiva == false) && (diasLimiteSinLicensia <= 0))
                    {
                        objUtil.MostrarMensajeError("VERSION DE PRUEBA HA EXPRIRADO... ");
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message, "ERROR INESPERADO");
                this.Close();
            }
            finally
            {
                this.Cursor = Cursors.Default;
                MyFila = null;
            }
        }

        public void FormatearGridDetalle()
        {
            try
            {
                if (DataGridDetalle != null)
                {
                    DataGridDetalle.RowTemplate.Height = 40;

                    if (OmitirMetodosDataGrid == false)
                    {
                        DataGridDetalle.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(HandlerEditingControlShowing);
                        DataGridDetalle.CellEnter += new DataGridViewCellEventHandler(HandlerCellEnter);
                        DataGridDetalle.CellLeave += new DataGridViewCellEventHandler(HandlerCellLeave);
                        DataGridDetalle.RowValidated += new DataGridViewCellEventHandler(HandleValidarFila);
                        DataGridDetalle.Leave += new EventHandler(HandlerDataGridLeave);
                    }

                    DataGridDetalle.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                    foreach (DataGridViewColumn item in DataGridDetalle.Columns)
                    {
                        //los link hacemos en negrita
                        if (item is DataGridViewLinkColumn)
                        {
                            item.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                            if (item.Width < 130) item.Width = 130;
                        }

                        if (item.DefaultCellStyle.Font == null) continue;
                        if (item.DefaultCellStyle.Font.Size < 11 && item.DefaultCellStyle.Font.Bold) item.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        else if (item.DefaultCellStyle.Font.Size < 11) item.DefaultCellStyle.Font = new Font("Segoe UI", 11);


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LimpiarDetalleTemporal()
        {

            try
            {
                objDB.LimpiarDetalleTemporal(TablaDetalle, temporalID);
                DTDetalle = objDB.GetById(TablaDetalle, temporalID, "IdentificadorTemp");

                if (DSDatos.Tables.Contains("Detalle")) DSDatos.Tables.Remove("Detalle");
                DTDetalle.TableName = "Detalle";
                DSDatos.Tables.Add(DTDetalle);

                if (DataGridDetalle != null) DataGridDetalle.DataSource = DTDetalle.DefaultView;

                TotalizarDetalle();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void MostrarDatosCliente()
        {

        }

        public virtual void MostrarDatosProducto()
        {

        }

        public virtual bool EjecutaOtros()
        {
            return true;
        }

        public virtual void MostrarDataRegistroSel()
        {

        }

        private void ELRFormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (EsConTemporal) objDB.LimpiarTemporal(TablaEncabezado, TablaDetalle, temporalID);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                IrAPageAnterior();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public virtual void IrAPageAnterior()
        {
            int index = 0;
            string esVisible = "";

            try
            {
                if (TabRegistro != null)
                {
                    if (TabRegistro.SelectedIndex > 0)
                    {

                        index = TabRegistro.SelectedIndex;
                        index--;

                        if (TabRegistro.TabPages[index].Tag != null)
                        {
                            esVisible = TabRegistro.TabPages[index].Tag.ToString().ToUpper().Trim();
                            if (esVisible == "FALSE") index--;
                        }

                        TabRegistro.SelectedIndex = index;

                        TabRegistro.SelectTab(index);

                        MostrarBotones();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public virtual void IrAPageSiguiente()
        {
            bool valido = false;
            int index = 0;
            string esVisible = "";
            try
            {
                if (TabRegistro != null)
                {
                    PasarValorADS(TabRegistro.SelectedTab);
                    valido = ValidarDatos(TabRegistro.SelectedTab);

                    if (valido)
                    {
                        index = TabRegistro.SelectedIndex;
                        index++;

                        if (TabRegistro.TabPages[index].Tag != null)
                        {
                            esVisible = TabRegistro.TabPages[index].Tag.ToString().ToUpper().Trim();
                            if (esVisible == "FALSE") index++;
                        }


                        TabRegistro.SelectedIndex = index;
                        TabRegistro.SelectTab(index);

                        MostrarBotones();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnSiguientePage_Click(object sender, EventArgs e)
        {
            try
            {
                IrAPageSiguiente();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void ELRFormRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (EsConTemporal) objDB.LimpiarTemporal(TablaEncabezado, TablaDetalle, temporalID);


            }
            catch (Exception)
            {


            }
        }

        private void ELRFormRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //ESC = CANCELAR
                if (e.KeyCode == Keys.Escape) btnCancelar.PerformClick();

                //CTRL + N = AGREGAR LINEA VACIA SI ES EsAgregarLineaVacia
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.N) && (EsConTemporal) && (DataGridDetalle != null) && (EsAgregarLineaVacia)) AgregarLineaVacia();

                //CTRL + G = GRABAR DATOS
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.G))
                {
                    if ((btnGrabar.Visible) && (btnGrabar.Enabled)) GrabarDatos();
                }

                //CTRL + S = SIGUIENTE PAGE
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.S))
                {
                    if (TabRegistro != null && btnSiguientePage.Enabled && btnSiguientePage.Visible) IrAPageSiguiente();
                }

                //CTRL + M = MOSTRAR MENU LATERAL
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.M))
                {
                    if ((panelLateral.Controls.Count > 0) && (btnmenu.Visible)) mostrarMenu();
                }

                //CTRL + A = ANTERIOR PAGE
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.A))
                {
                    if (TabRegistro != null && btnAnterior.Enabled && btnAnterior.Visible) IrAPageAnterior();
                }

                //CTRL + O = ABRE UN NUEVO FORMULARIO
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.O) && (panelLateral.Controls.Count > 0))
                {
                    foreach (var item in panelLateral.Controls)
                    {
                        if (item is Button)
                        {
                            Button btn = (Button)item;
                            if (btn.Tag != null)
                            {
                                if (btn.Tag.ToString().ToUpper() == (this.ProductName + "." + this.Name).ToUpper())
                                {
                                    btn.PerformClick();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        public virtual void HabilitarControles(TabPage page, bool modo)
        {
            ComboBox cbo = null;
            TextBox txt = null;
            RadioButton rdb = null;
            DateTimePicker dtp = null;
            NumericUpDown nmd = null;
            Button btn = null;


            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in page.Controls)
                {

                    if (item is ELRTextBox || item is TextBox)
                    {
                        txt = (TextBox)item;
                        txt.Enabled = modo;
                    }
                    else if (item is ELRCombobox || item is ComboBox)
                    {
                        cbo = ((ComboBox)item);
                        cbo.Enabled = modo;
                    }
                    else if (item is ELRDatePicker || item is DateTimePicker)
                    {
                        dtp = (DateTimePicker)item;
                        dtp.Enabled = modo;
                    }
                    else if (item is ELRNumericUpdDown || item is NumericUpDown)
                    {
                        nmd = (NumericUpDown)item;
                        nmd.Enabled = modo;
                    }
                    else if (item is Button || item is ELRBotonBuscar)
                    {
                        btn = (Button)item;
                        btn.Enabled = modo;
                    }
                    else if (item is RadioButton)
                    {
                        rdb = (RadioButton)item;
                        rdb.Enabled = modo;
                    }
                    else if (item is Panel) HabilitarControles((Panel)item, modo);
                    else if (item is GroupBox) HabilitarControles((GroupBox)item, modo);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            mostrarMenu();
        }

        public void mostrarMenu()
        {
            Button btn = null;
            try
            {
                panelLateral.Visible = !panelLateral.Visible;
                if (panelLateral.Visible && panelLateral.Controls.Count > 0)
                {
                    if (panelLateral.Controls[0] is Button)
                    {
                        btn = (Button)panelLateral.Controls[0];
                        btn.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public virtual void HabilitarControles(Panel panel, bool modo)
        {
            ComboBox cbo = null;
            TextBox txt = null;
            RadioButton rdb = null;
            DateTimePicker dtp = null;
            NumericUpDown nmd = null;
            Button btn = null;
            CheckBox chk = null;

            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in panel.Controls)
                {
                    if (item is ELRTextBox || item is TextBox)
                    {
                        txt = (TextBox)item;
                        txt.Enabled = modo;
                    }
                    else if (item is ELRCombobox || item is ComboBox)
                    {
                        cbo = ((ComboBox)item);
                        cbo.Enabled = modo;
                    }
                    else if (item is ELRDatePicker || item is DateTimePicker)
                    {
                        dtp = (DateTimePicker)item;
                        dtp.Enabled = modo;
                    }
                    else if (item is ELRNumericUpdDown || item is NumericUpDown)
                    {
                        nmd = (NumericUpDown)item;
                        nmd.Enabled = modo;
                    }
                    else if (item is Button || item is ELRBotonBuscar)
                    {
                        btn = (Button)item;
                        btn.Enabled = modo;
                    }
                    else if (item is CheckBox || item is ELRCheckBox)
                    {
                        chk = (CheckBox)item;
                        chk.Enabled = modo;
                    }
                    else if (item is RadioButton)
                    {
                        rdb = (RadioButton)item;
                        rdb.Enabled = modo;
                    }
                    else if (item is Panel) HabilitarControles((Panel)item, modo);
                    if (item is GroupBox) HabilitarControles((GroupBox)item, modo);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void HabilitarControles(GroupBox grb, bool modo)
        {
            ComboBox cbo = null;
            TextBox txt = null;
            RadioButton rdb = null;
            DateTimePicker dtp = null;
            NumericUpDown nmd = null;
            Button btn = null;
            CheckBox chk = null;

            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in grb.Controls)
                {
                    if (item is ELRTextBox || item is TextBox)
                    {
                        txt = (TextBox)item;
                        txt.Enabled = modo;
                    }
                    else if (item is ELRCombobox || item is ComboBox)
                    {
                        cbo = ((ComboBox)item);
                        cbo.Enabled = modo;
                    }
                    else if (item is ELRDatePicker || item is DateTimePicker)
                    {
                        dtp = (DateTimePicker)item;
                        dtp.Enabled = modo;
                    }
                    else if (item is ELRNumericUpdDown || item is NumericUpDown)
                    {
                        nmd = (NumericUpDown)item;
                        nmd.Enabled = modo;
                    }
                    else if (item is Button || item is ELRBotonBuscar)
                    {
                        btn = (Button)item;
                        btn.Enabled = modo;
                    }
                    else if (item is CheckBox || item is ELRCheckBox)
                    {
                        chk = (CheckBox)item;
                        chk.Enabled = modo;
                    }
                    else if (item is RadioButton)
                    {
                        rdb = (RadioButton)item;
                        rdb.Enabled = modo;
                    }
                    else if (item is Panel) HabilitarControles((Panel)item, modo);
                    if (item is GroupBox) HabilitarControles((GroupBox)item, modo);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void HabilitarControles(bool modo)
        {
            ComboBox cbo = null;
            TextBox txt = null;
            RadioButton rdb = null;
            DateTimePicker dtp = null;
            NumericUpDown nmd = null;
            Button btn = null;
            CheckBox chk = null;

            try
            {
                //RECORREMOS LOS CONTROLES DENTRO DEL FORMULARIO PARA MOSTRAR LOS DATOS
                foreach (Control item in Controls)
                {
                    if (item is ELRTextBox || item is TextBox)
                    {
                        txt = (TextBox)item;
                        txt.Enabled = modo;
                    }
                    else if (item is ELRCombobox || item is ComboBox)
                    {
                        cbo = ((ComboBox)item);
                        cbo.Enabled = modo;
                    }
                    else if (item is ELRDatePicker || item is DateTimePicker)
                    {
                        dtp = (DateTimePicker)item;
                        dtp.Enabled = modo;
                    }
                    else if (item is ELRNumericUpdDown || item is NumericUpDown)
                    {
                        nmd = (NumericUpDown)item;
                        nmd.Enabled = modo;
                    }
                    else if (item is Button || item is ELRBotonBuscar)
                    {
                        btn = (Button)item;
                        btn.Enabled = modo;
                    }
                    else if (item is CheckBox || item is ELRCheckBox)
                    {
                        chk = (CheckBox)item;
                        chk.Enabled = modo;
                    }
                    else if (item is RadioButton)
                    {
                        rdb = (RadioButton)item;
                        rdb.Enabled = modo;
                    }
                    else if (item is Panel) HabilitarControles((Panel)item, modo);
                    if (item is GroupBox) HabilitarControles((GroupBox)item, modo);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    //DEFINIMOS CLASE PARA VALIDACION
    public class Valida
    {
        public string NombreCampo { get; set; }
        public tbTipoValidacion TipoValidacion { get; set; }
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Mensaje { get; set; }
        public Control comtrol { get; set; }

    }

    //DEFINIMOS CLASE PARA SUMARIZAR COLUMNAS

}
