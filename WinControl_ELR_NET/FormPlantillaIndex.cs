using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormPlantillaIndex : Form
    {
        //VARIABLES PRIVADAS
        int tipoBusqueda = 0;

        //DECLARAMOS VARIABLES PUBLICA
        public DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();
        public DataTable MyData;
        public DataTable DTOficina = null;
        public DataRow DRFilaModificar = null;
        public ELRUtils objUtil = new ELRUtils();
        public int empresaID = 0;
        public int oficinaID = 0;
        public int menuId = 0;
        public string nombreUsuario = "USUARIO.PRUEBA";
        public string NOMBRE_EMPRESA = "";
        public string NOMBRE_OFICINA = "";
        public string EMPRESA_RNC = "";
        public DateTime FECHA_TRABAJO;
        public string proximo = "";
        public string montoLetras;
        public int IMPRIME_TICKET_COPIA;
        public string impresoraDefault;
        public bool MOSTRAR_COLUMNA_PRESTAMO = false;
        public bool MOSTRAR_COLUMNA_FACTURA = false;
        public int metodoImp = 0;

        public DataTable DTVariablesSYS = null;
        public DataTable DTEmpresaOficinas = null;
        public DataSet DSGlobal = null;
        public Image logoEmpresa = null;

        bool esLicenciaActiva = false;
        int diasLimiteSinLicensia = 30;
        public double tasaCambioUS = 0;
        public int cajaNo = 0;
        public bool esBusqueda = false;
        public DataRow filaSelecionada;
        public bool esInicio = true;
        public string textoABuscar = "";
        public int sessionId = 0;
        public int nivelForm = 0;

        //DECLARAMOS PROPIEDADES PARA CONTROL SEGURIDAD
        [Category("Authorizacion")]
        public bool EsAgregar { get; set; }
        [Category("Authorizacion")]
        public bool EsModificar { get; set; }
        [Category("Authorizacion")]
        public bool EsImprimir { get; set; }
        [Category("Authorizacion")]
        public bool EsCambiarFecha { get; set; }
        [Category("Authorizacion")]
        public bool EsAnular { get; set; }
        [Category("Authorizacion")]
        public bool EsAprobar { get; set; }
        [Category("Authorizacion")]
        public bool EsRechazar { get; set; }
        [Category("Authorizacion")]
        public bool EsFilasAMostrar { get; set; }
        [Category("Authorizacion")]
        public bool EsExcel { get; set; }
        [Category("Authorizacion")]
        public bool EsTXT { get; set; }
        [Category("Authorizacion")]
        public bool EsCopiar { get; set; }
        [Category("Authorizacion")]
        public bool EsPreview { get; set; }

        //DECLARAMOS VARIABLES PRIVADA
        string TABLA_OPCIONES_MENU = "TACCESOS_OPCIONES_MENU";
        public bool REQUIERE_CIERRE_OPERACIONES = false;
        public bool REQUIERE_CONVERTIR_ADOLARES = false;
        public bool REQUIERE_CAJA_ABIERTA = false;
        public bool MOSTRAR_DETALLE_FACTURAS_PAGADAS = false;
        public DataTable DTMenu = null;

        //DECLARAMOS PROPIEDADES
        [Category("PropiedadesELR")]
        public string TablaOVista { get; set; }

        [Category("PropiedadesELR")]
        public int Limite { get; set; }

        [Category("PropiedadesELR")]
        public DataGridView DataGridConsulta { get; set; }

        [Category("PropiedadesELR")]
        public string NombreCampoID { get; set; }

        [Category("PropiedadesELR")]
        public string FiltroEstatico { get; set; }

        [Category("PropiedadesELR")]
        public string ClausulaOrderBY { get; set; }

        [Category("PropiedadesELR")]
        public string NombreCampoFecha { get; set; }

        [Category("PropiedadesELR")]
        public string FormularioRegistro { get; set; }

        [Category("PropiedadesELR")]
        public List<Totaliza> ATotalizar { get; set; }

        [Category("PropiedadesELR")]
        public bool EnEjecusion { get; set; }

        [Category("PropiedadesELR")]
        public bool CargarDataAlInicio { get; set; }

        [Category("PropiedadesELR")]
        public string SPCargarATemporal { get; set; }

        [Category("PropiedadesELR")]
        public string SPCopiarATemporal { get; set; }

        [Category("PropiedadesELR")]
        public bool ValidaCajaAbierta { get; set; }

        [Category("PropiedadesELR")]
        public bool ValidaMonedaUS { get; set; }

        [Category("CreditoELR")]
        public bool EsSolicitudCredito { get; set; }
        [Category("CreditoELR")]
        public bool EsGarantiaPersonal { get; set; }
        [Category("CreditoELR")]
        public bool EsCoDeudor { get; set; }

        public FormPlantillaIndex()
        {
            InitializeComponent();

            this.TablaOVista = "";
            this.Limite = 50;
            this.NombreCampoFecha = "Fecha";
            this.FiltroEstatico = "";
            this.EnEjecusion = false;

            pnOpcionesBusqueda.Visible = false;
            EsAgregar = true;
            EsModificar = true;
            EsImprimir = false;
            EsAprobar = false;
            EsRechazar = false;
            EsAnular = false;
            EsCambiarFecha = false;
            CargarDataAlInicio = true;
            ValidaCajaAbierta = false;
            ValidaMonedaUS = false;
            EsFilasAMostrar = true;
            EsExcel = false;
            EsTXT = false;
            EsCopiar = false;
            SPCopiarATemporal = "";
            EsPreview = false;
            EsSolicitudCredito = false;
            EsGarantiaPersonal = false;
            EsCoDeudor = false;
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
            try
            {
                this.Cursor = Cursors.WaitCursor;

                MyArray = valor.Split(';');
                formulario = MyArray[0];
                MyAsembly = formulario.Split('.')[0];

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
                    frmCons.menuId = menuId;
                    frmCons.empresaID = empresaID;
                    frmCons.oficinaID = oficinaID;

                    frmCons.NOMBRE_EMPRESA = NOMBRE_EMPRESA;
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
                    frmRegistro.EMPRESA_ID = empresaID;
                    frmRegistro.OFICINA_ID = oficinaID;

                    frmRegistro.NOMBRE_EMPRESA_OFICINA = NOMBRE_EMPRESA;
                    frmRegistro.NOMBRE_OFICINA = NOMBRE_OFICINA;
                    frmRegistro.nombreUsuario = nombreUsuario;
                    frmRegistro.FECHA_TRABAJO = FECHA_TRABAJO;

                    frmRegistro.DTVariablesSYS = DTVariablesSYS;
                    frmRegistro.DSGlobal = DSGlobal;

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


        public string GetFolderDocGenerados(string subFolder = "")
        {
            string resultado = @"C:\DocGenerados";

            try
            {
                if (!Directory.Exists(resultado)) Directory.CreateDirectory(resultado);
                
                if(subFolder.Trim() != "")
                {
                    resultado += @"\" + subFolder.Trim();
                    if (!Directory.Exists(resultado)) Directory.CreateDirectory(resultado);
                }

            }
            catch (Exception)
            {
                resultado = "";
                throw;
            }

            return resultado;
        }

        public virtual void MostrarErrorTemporal(string temporalID)
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

        public double GetSum(string nombreCampo, string filtro = "")
        {
            double resultado = 0;
            object calcObject;
            try
            {

                calcObject = MyData.Compute("Sum(" + nombreCampo + ")", filtro);
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

        public int GetCount(string nombreCampo, string filtro = "")
        {
            int resultado = 0;
            object calcObject;
            try
            {

                calcObject = MyData.Compute("Count(" + nombreCampo + ")", filtro);
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

        void ValidaLicencia()
        {
            string serialNumero, codigoActivacion;

            try
            {
                esLicenciaActiva = false;
                diasLimiteSinLicensia = 30;

                serialNumero = objUtil.GetSerialNumber();
                esLicenciaActiva = objDB.ValidarLicense(serialNumero, EMPRESA_RNC, "WIN32");
                
                if (esLicenciaActiva == false) diasLimiteSinLicensia = objDB.GetDiasRestanteSinLicencias();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void ImprimirPreviewRDLC(string nombreReporte, string vistaOTabla, string valorId, string campoId = "Unico", string tituloReporte = "PREVIEW REPORT")
        {
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();
            string pathReporte = "";
            DataTable DTVistaData = null;

            if (objUtil == null) objUtil = new ELRUtils();

            try
            {

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC(nombreReporte);
                if (pathReporte.Trim() != "")
                {

                    DTVistaData = objDB.GetById(vistaOTabla, valorId, campoId);

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = DTVistaData;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = tituloReporte;
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
                DTVistaData = null;
                frmPreview.Dispose();
            }
        }


        public virtual void Salir()
        {
            this.Close();
        }

        public void MostrarCantidadFilas(int cantidad = 0)
        {
            try
            {
                stlCantidadFilas.Text = "0 Filas";

                if (cantidad <= 0)
                {
                    if (MyData != null) stlCantidadFilas.Text = MyData.Rows.Count.ToString("N0") + " Filas";
                    else stlCantidadFilas.Text = "0 Filas";
                }
                else stlCantidadFilas.Text = cantidad.ToString("N0") + " Filas";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void GetData(int opcion = 0)
        {
            string MyCampoID = "";
            try
            {
                if (NombreCampoID != "") MyCampoID = NombreCampoID.Trim().ToUpper();

                if (TablaOVista != null)
                {
                    if (TablaOVista.Trim() != "")
                    {
                        tsbBusquedaAvanzada.Enabled = true;
                        //AGREGAMOS FILTRO POR EMPRESA
                        if ((empresaID > 0) && (MyCampoID != "EMPRESA_ID"))
                        {
                            MyData = objDB.GetAll(TablaOVista, 0);
                            if ((MyData.Columns.Contains("Empresa_Id")) && (opcion == 0)) objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                        }

                        if (FiltroEstatico == null) FiltroEstatico = "";
                        if (ClausulaOrderBY == null) ClausulaOrderBY = "";

                        if ((FiltroEstatico.Trim() != "") && (opcion == 0)) objDB.AddFiltroPersonalizado(FiltroEstatico);
                        if ((ClausulaOrderBY.Trim() != "") && (opcion == 0)) objDB.AddFiltroOrderBY(ClausulaOrderBY);

                        MyData = objDB.GetAll(TablaOVista, Limite, objDB.Filtros);

                        if (DataGridConsulta != null)
                        {
                            if (DataGridConsulta.ColumnCount > 0) DataGridConsulta.AutoGenerateColumns = false;
                            
                            
                            DataGridConsulta.DataSource = MyData.DefaultView;
                            DataGridConsulta.AllowUserToAddRows = false;

                            //evitamos seleccionar celda que sea 
                            

                        }

                        //MOSTRAMOS LA CANTIDAD DE FILAS
                        MostrarCantidadFilas();

                        //TOTALIZAMOS LOS DATOS
                        TotalizarData();

                        

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Realizar Consulta, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void TotalizarData()
        {
            double valor = 0;
            try
            {
                if (ATotalizar != null)
                {
                    foreach (Totaliza item in ATotalizar)
                    {
                        // Declare an object variable.
                        object calcObject;
                        calcObject = MyData.Compute(item.operacion + "(" + item.NombreCampoDet + ")", item.filtro);
                        valor = (double)calcObject;

                        if (item.controlLabel != null) item.controlLabel.Text = valor.ToString(item.Formato);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual string GetIdFromDataGrid()
        {
            string resultado = "";
            string unico;
            DataRow[] dr;

            try
            {
                if (DataGridConsulta.RowCount <= 0) throw new Exception("No Hay Registro Para Modificar....");
                if (NombreCampoID.Trim() == "") throw new Exception("Debe Especificar el Nombre del Campo Id");
                if (DataGridConsulta.CurrentRow == null) throw new Exception("No Hay Registro Seleccionado");

                unico = DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString();

                dr = MyData.Select("Unico = " + unico);
                if (dr.Count() > 0) resultado = dr[0][NombreCampoID].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public virtual bool Valida()
        {
            bool resultado = true;
            DataTable DTMonedaUS = null;
            DataTable DTCajas = null;
            DateTime fecha = DateTime.Now.Date;
            int diferencia = 0;

            try
            {
                resultado = true;

                //VALIDAMOS LA CAJA ABIERTA
                if ( ValidaCajaAbierta )
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Usuario_En_Caja", nombreUsuario);
                    objDB.AddFiltroIsNull("Fecha_Cierre");

                    DTCajas = objDB.GetAll("TCAJAS_APERTURA_CIERRE", 50, objDB.Filtros);

                    if ( (DTCajas.Rows.Count != 1) && (REQUIERE_CIERRE_OPERACIONES))
                    {
                        resultado = false;
                        objUtil.MostrarMensajeAdvertencia("EL USUARIO " + nombreUsuario + " TIENE " + DTCajas.Rows.Count.ToString() + " CAJAS ABIERTAS ");

                    }
                    else if (REQUIERE_CIERRE_OPERACIONES)
                    {
                        cajaNo = objUtil.GetAsInt("Caja_Id", DTCajas.Rows[0]);
                        
                        //VALIDAMOS FECHA DE CAJA NO SEA DIFERENTE A LA FECHA DE LA OFICINA
                        fecha = (DateTime)DTCajas.Rows[0]["Fecha_Trabajo"];
                        if (objDB.DateToInt(fecha) != objDB.DateToInt(objDB.FECHA_TRABAJO) && REQUIERE_CIERRE_OPERACIONES == false)
                        {
                            resultado = false;
                            objUtil.MostrarMensajeAdvertencia("LA CAJA ESTA ABIERTA A UNA FECHA DIFERENTE A LA FECHA DE TRABAJO DE LA OFICINA");
                        }

                    }
                }


                //VALIDAMOS DOLARES US$
                if ((ValidaMonedaUS) && (resultado == true) && REQUIERE_CONVERTIR_ADOLARES == true)
                {
                    if (DTMonedaUS == null) DTMonedaUS = objDB.GetById("TSISTEMA_MONEDAS", "US$", "Codigo");

                    if (DTMonedaUS.Rows.Count > 0)
                    {
                        tasaCambioUS = objUtil.GetAsDouble("Valor_Compra", DTMonedaUS.Rows[0]);

                        if (DTMonedaUS.Rows[0]["Fecha_Modificado"] is DBNull)
                        {
                            resultado = false;
                            objUtil.MostrarMensajeAdvertencia("Tasa Cambio Dolares US$ no Actualizada!!!. \r\r" +
                                                              "El Sistema Requiere Actualizar Tasa de Cambio para Continuar.");
                        }
                        else
                        {
                            fecha = objUtil.GetAsDate("Fecha_Modificado", DTMonedaUS.Rows[0]);
                            diferencia = objUtil.DateToInt(DateTime.Now.Date) - objUtil.DateToInt(fecha);
                            if (diferencia > 5)
                            {
                                resultado = false;
                                objUtil.MostrarMensajeAdvertencia("Han Pasado Mas de 5 Dias Sin Actualizar Tasa de Cambio Dolares US$. \r\r" +
                                                            "El Sistema Requiere Actualizar Tasa de Cambio para Continuar.");

                            }
                        }
                    }
                    else
                    {
                        objUtil.MostrarMensajeAdvertencia("El Sistema No Encontro Tasa de Cambio Dolares US$!!!");
                        Close();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public virtual void Agregar()
        {
            ELRFormRegistro frm = null;
            string myAsembly = "";
            string[] MyArray;
            DataTable DTData = null;
            string SSQL = "";
            bool conCaja = false, esValido = false;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (EsAgregar == false) objUtil.MostrarMensajeAdvertencia("NO TIENE PERMISOS PARA AGREGAR Y/O INSERTAR");
                else if (FormularioRegistro == null) objUtil.MostrarMensajeError("Debe Indicar la Clase del Formulario de Registro");
                else if (FormularioRegistro.Trim() == "") objUtil.MostrarMensajeError("Debe Indicar la Clase del Formulario de Registro");
                else if (Valida())
                {

                    MyArray = FormularioRegistro.Split('.');
                    myAsembly = MyArray[0];
                    frm = (ELRFormRegistro)Activator.CreateInstance(myAsembly, FormularioRegistro).Unwrap();

                    frm.VALOR_ID = "0";
                    frm.EMPRESA_ID = empresaID;
                    frm.OFICINA_ID = oficinaID;
                    frm.REQUIERE_CAJA_ABIERTA = REQUIERE_CAJA_ABIERTA;
                    frm.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                    frm.REQUIERE_CONVERTIR_ADOLARES = REQUIERE_CONVERTIR_ADOLARES;
                    conCaja = (frm.RequiereCajaAbierta && REQUIERE_CAJA_ABIERTA);
                    frm.nombreUsuario = nombreUsuario;

                    //VALIDAMOS LA FECHA DE OPERACIONES
                    if (frm.ExcluirValidacionCierre) esValido = true;
                        else if (frm.DataGridDetalle != null) esValido = objDB.ValidarFechaOperaciones(oficinaID, conCaja);
                    else if (REQUIERE_CIERRE_OPERACIONES) esValido = objDB.ValidarFechaOperaciones(oficinaID, conCaja);

                    frm.DSGlobal = DSGlobal;
                    frm.DTVariablesSYS = DTVariablesSYS;
                    frm.EsCambiarFecha = EsCambiarFecha;
                    frm.DTMenu = DTMenu;

                    frm.EnEjecusion = true;
                    frm.esSolicitudCredito = EsSolicitudCredito;
                    frm.esGarantiaPersonal = EsGarantiaPersonal;
                    frm.esCoDeudor = EsCoDeudor;

                    if (EsSolicitudCredito) frm.solicitudId = 0;

                    frm.ShowDialog();

                    if (esBusqueda && frm.lOK)
                    {
                        SSQL = "SELECT TOP 1 * FROM " + TablaOVista + " Order by Unico Desc";
                        DTData = objDB.GetSQL(SSQL);
                        if(DTData.Rows.Count > 0)
                        {
                            filaSelecionada = DTData.Rows[0];
                            Close();
                        }
                    }
                    else RealizarBusquedaSencilla();
                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);

            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (frm != null)
                {
                    frm.Dispose();
                    GC.SuppressFinalize(frm);
                }
            }
        }

        public void MostrarErroresSys(string temporalId)
        {
            try
            {
                //MOSTRAMOS ERRORES DEL SISTEMA
                ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

                objMsgERRORES.TemporalId = temporalId;
                objMsgERRORES.objDB = objDB;

                objMsgERRORES.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Modificar()
        {
            ELRFormRegistro frm = null;
            string myAsembly = "";
            string[] MyArray;
            string valorId = "";
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            int index = 0;
            DataGridViewSelectionMode modoSele;
            string SSQL = "";
            DataTable DTData = null;
            bool conCaja = false, esValido = false;

            try
            {
                if (objUtil == null) objUtil = new ELRUtils();

                this.Cursor = Cursors.WaitCursor;

                if (EsModificar == false) objUtil.MostrarMensajeAdvertencia("NO TIENE PERMISO PARA MODIFICAR");
                else if (FormularioRegistro == null) objUtil.MostrarMensajeError("Debe Indicar la Clase del Formulario de Registro");
                else if (FormularioRegistro.Trim() == "") objUtil.MostrarMensajeError("Debe Indicar la Clase del Formulario de Registro");
                else if (DataGridConsulta.CurrentRow == null) objUtil.MostrarMensajeError("No Hay Ningun Reistro Seleccionado");
                else if (Valida())
                {

                    index = DataGridConsulta.CurrentRow.Index;

                    if (SPCargarATemporal != null)
                    {
                        if (SPCargarATemporal.Trim() != "")
                        {
                            valorId = DataGridConsulta[NombreCampoID, DataGridConsulta.CurrentRow.Index].Value.ToString();
                            temporalId = objUtil.GetTemporalID();
                            //Agregamos Parametros Para Ejecutar el SP PARA CARGAR A TEMPORAL
                            MyParametros.Add(new DataDB_ELR_NET.Parametro("Id", valorId));
                            MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                            MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                            if (EsSolicitudCredito) MyParametros.Add(new DataDB_ELR_NET.Parametro("solicitudId", valorId));

                            objDB.iniciarTransaccion();
                            spReturn = objDB.EjecutarSP(SPCargarATemporal.Trim(), MyParametros);
                            if (spReturn < 0)
                            {
                                //MOSTRAMOS ERRORES DEL SISTEMA
                                ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

                                objMsgERRORES.TemporalId = temporalId;
                                objMsgERRORES.objDB = objDB;

                                objMsgERRORES.ShowDialog();
                            }
                            else objDB.confirmarTransaccion();
                        }
                    }


                    if (spReturn >= 0)
                    {
                        MyArray = FormularioRegistro.Split('.');
                        myAsembly = MyArray[0];
                        frm = (ELRFormRegistro)Activator.CreateInstance(myAsembly, FormularioRegistro).Unwrap();

                        frm.VALOR_ID = GetIdFromDataGrid();
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.REQUIERE_CAJA_ABIERTA = REQUIERE_CAJA_ABIERTA;
                        frm.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                        frm.REQUIERE_CONVERTIR_ADOLARES = REQUIERE_CONVERTIR_ADOLARES;
                        conCaja = (frm.RequiereCajaAbierta && REQUIERE_CAJA_ABIERTA);

                        //VALIDAMOS LA FECHA DE OPERACIONES
                        if (frm.ExcluirValidacionCierre) esValido = true;
                        else if (frm.DataGridDetalle != null) esValido = objDB.ValidarFechaOperaciones(oficinaID, conCaja);
                        else if (REQUIERE_CIERRE_OPERACIONES) esValido = objDB.ValidarFechaOperaciones(oficinaID, conCaja);


                        frm.nombreUsuario = nombreUsuario;
                        frm.DSGlobal = DSGlobal;
                        frm.esNuevo = false;
                        frm.EsCambiarFecha = EsCambiarFecha;
                        frm.temporalID = temporalId;
                        frm.DTVariablesSYS = DTVariablesSYS;
                        
                        frm.DTMenu = DTMenu;

                        frm.EnEjecusion = true;
                        frm.esSolicitudCredito = EsSolicitudCredito;
                        frm.esGarantiaPersonal = EsGarantiaPersonal;
                        frm.esCoDeudor = EsCoDeudor;

                        if (EsSolicitudCredito) frm.solicitudId = int.Parse(frm.VALOR_ID);

                        frm.ShowDialog();

                        if (esBusqueda && frm.lOK)
                        {
                            SSQL = "SELECT TOP 1 * FROM " + TablaOVista + " where " + NombreCampoID + " = '" + frm.VALOR_ID + "'  Order by Unico Desc";
                            DTData = objDB.GetSQL(SSQL);
                            if (DTData.Rows.Count > 0)
                            {
                                filaSelecionada = DTData.Rows[0];
                                Close();
                            }
                        }
                        else
                        {
                            RealizarBusquedaSencilla();

                            modoSele = DataGridConsulta.SelectionMode;

                            if (modoSele != DataGridViewSelectionMode.FullRowSelect) DataGridConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                            if (DataGridConsulta.RowCount >= index)
                            {
                                DataGridConsulta.Rows[index].Selected = true;

                                foreach (DataGridViewColumn item in DataGridConsulta.Columns)
                                {
                                    if (item.Visible)
                                    {

                                        DataGridConsulta.CurrentCell = DataGridConsulta[item.Name, index];
                                        break;
                                    }
                                }
                            }

                            if (modoSele != DataGridViewSelectionMode.FullRowSelect) DataGridConsulta.SelectionMode = modoSele;
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
                this.Cursor = Cursors.Default;

                if (frm != null)
                {
                    frm.Dispose();
                    GC.SuppressFinalize(frm);
                }
            }
        }

        public virtual void CopiarATemporal()
        {
            ELRFormRegistro frm = null;
            string myAsembly = "";
            string[] MyArray;
            string valorId = "";
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            int index = 0;
            DataGridViewSelectionMode modoSele;

            try
            {
                if (objUtil == null) objUtil = new ELRUtils();

                this.Cursor = Cursors.WaitCursor;

                if (EsAgregar == false) objUtil.MostrarMensajeAdvertencia("No Tiene Permiso Para Agregar");
                else if (FormularioRegistro == null) objUtil.MostrarMensajeError("Debe Indicar la Clase del Formulario de Registro");
                else if (FormularioRegistro.Trim() == "") objUtil.MostrarMensajeError("Debe Indicar la Clase del Formulario de Registro");
                else if (DataGridConsulta.CurrentRow == null) objUtil.MostrarMensajeError("No Hay Ningun Reistro Seleccionado");
                else if (Valida())
                {

                    index = DataGridConsulta.CurrentRow.Index;

                    if (SPCopiarATemporal != null)
                    {
                        if (SPCopiarATemporal.Trim() != "")
                        {
                            valorId = DataGridConsulta[NombreCampoID, DataGridConsulta.CurrentRow.Index].Value.ToString();
                            temporalId = objUtil.GetTemporalID();
                            //Agregamos Parametros Para Ejecutar el SP PARA CARGAR A TEMPORAL
                            MyParametros.Add(new DataDB_ELR_NET.Parametro("Id", valorId));
                            MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                            MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                            objDB.iniciarTransaccion();
                            spReturn = objDB.EjecutarSP(SPCopiarATemporal.Trim(), MyParametros);
                            if (spReturn < 0)
                            {
                                //MOSTRAMOS ERRORES DEL SISTEMA
                                ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

                                objMsgERRORES.TemporalId = temporalId;
                                objMsgERRORES.objDB = objDB;

                                objMsgERRORES.ShowDialog();
                            }
                            else objDB.confirmarTransaccion();
                        }
                    }


                    if (spReturn >= 0)
                    {
                        MyArray = FormularioRegistro.Split('.');
                        myAsembly = MyArray[0];
                        frm = (ELRFormRegistro)Activator.CreateInstance(myAsembly, FormularioRegistro).Unwrap();

                        frm.VALOR_ID = GetIdFromDataGrid();
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.nombreUsuario = nombreUsuario;
                        frm.DSGlobal = DSGlobal;
                        frm.esNuevo = true;
                        frm.esCopia = true;
                        frm.temporalID = temporalId;
                        frm.DTVariablesSYS = DTVariablesSYS;
                        frm.EsCambiarFecha = EsCambiarFecha;

                        frm.EnEjecusion = true;
                        frm.esSolicitudCredito = EsSolicitudCredito;
                        frm.esGarantiaPersonal = EsGarantiaPersonal;
                        frm.esCoDeudor = EsCoDeudor;

                        frm.ShowDialog();

                        RealizarBusquedaSencilla();

                        modoSele = DataGridConsulta.SelectionMode;

                        if (modoSele != DataGridViewSelectionMode.FullRowSelect) DataGridConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (DataGridConsulta.RowCount >= index)
                        {
                            DataGridConsulta.Rows[index].Selected = true;

                            foreach (DataGridViewColumn item in DataGridConsulta.Columns)
                            {
                                if (item.Visible)
                                {

                                    DataGridConsulta.CurrentCell = DataGridConsulta[item.Name, index];
                                    break;
                                }
                            }
                        }

                        if (modoSele != DataGridViewSelectionMode.FullRowSelect) DataGridConsulta.SelectionMode = modoSele;

                    }

                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);

            }
            finally
            {
                this.Cursor = Cursors.Default;

                if (frm != null)
                {
                    frm.Dispose();
                    GC.SuppressFinalize(frm);
                }
            }
        }

        public virtual void Aprobar()
        {

        }

        public virtual void Rechazar()
        {

        }

        public virtual void Anular()
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        public virtual void CargarOpcionesBusqueda()
        {
            string nombreCampo = "";
            List<MyColumna> columnas = new List<MyColumna>();
            try
            {
                //DESHABILITAMOS LOS CONTROLES
                chkPorOficina.Enabled = false;
                cboOficina.Enabled = false;

                chkRangoFecha.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;

                cboEstatus.Enabled = false;
                chkPorEstatus.Enabled = false;

                cboCampos.Enabled = false;
                chkPorCampo.Enabled = false;
                cboCondicion.Enabled = false;
                txtABuscar2.Enabled = false;

                //CARGAMOS LA STRTURA DE LA TABLA O VISTA
                if (MyData == null) MyData = objDB.GetData(TablaOVista, 0);

                //CARGAMOS LOS DATOS DE LAS OFICINAS
                if (MyData.Columns.Contains("Oficina_Id"))
                {
                    chkPorOficina.Enabled = true;
                    cboOficina.LlenarCombo();
                }


                //ACTIVAMOS O DESACTIVAMOS LA BUSQUEDA POR FECHA
                if (MyData.Columns.Contains(NombreCampoFecha)) chkRangoFecha.Enabled = true;


                //CARGAMOS PARA FILTRAR POR ESTATUS
                cboEstatus.Items.Clear();
                if (MyData.Columns.Contains("Estatus_Id"))
                {
                    cboEstatus.Items.Add("VIGENTE");
                    cboEstatus.Items.Add("CASTIGADO");
                }

                if (MyData.Columns.Contains("Fecha_Aprobado"))
                {
                    cboEstatus.Items.Add("APROBADO");
                    cboEstatus.Items.Add("PENDIENTE APROBAR");
                }

                if (MyData.Columns.Contains("Fecha_Rechazado"))
                {
                    cboEstatus.Items.Add("RECHAZADO");
                    cboEstatus.Items.Add("NO RECHAZADO");
                }

                if ((MyData.Columns.Contains("Fecha_Posteado")) || (MyData.Columns.Contains("Fecha_Actualizado")))
                {
                    cboEstatus.Items.Add("POSTEADO");
                    cboEstatus.Items.Add("NO POSTEADO");
                }

                if (MyData.Columns.Contains("Fecha_Cancelado"))
                {
                    cboEstatus.Items.Add("CANCELADO");
                    cboEstatus.Items.Add("NO CANCELADO");
                }

                chkPorEstatus.Enabled = (cboEstatus.Items.Count > 0);


                //CARGAMOS LAS COLUMNAS DEL DATAGRID VIEW
                if (DataGridConsulta != null)
                {
                    chkPorCampo.Enabled = true;

                    foreach (DataGridViewColumn item in DataGridConsulta.Columns)
                    {
                        if (item.DataPropertyName != "")
                        {
                            nombreCampo = item.DataPropertyName.ToUpper();
                            if ((nombreCampo != "OFICINA_ID") && (nombreCampo != "ESTATUS_ID") && (nombreCampo != NombreCampoFecha.ToUpper())) columnas.Add(new MyColumna(item.HeaderText, item.DataPropertyName));
                        }
                    }

                    cboCampos.DataSource = columnas;
                    cboCampos.DisplayMember = "HeaderText";
                    cboCampos.ValueMember = "NombreCampo";
                }


                //OCULTAMOS O MOSTRAMOS SI ES NULO
                chkNulos.Enabled = ((MyData.Columns.Contains("EsNulo")) || (MyData.Columns.Contains("Nulo")));
                chkNulos.Visible = ((MyData.Columns.Contains("EsNulo")) || (MyData.Columns.Contains("Nulo")));

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void HabilitarOpcionesBusqueda()
        {
            try
            {
                cboOficina.Enabled = chkPorOficina.Checked;
                dtpFechaDesde.Enabled = chkRangoFecha.Checked;
                dtpFechaHasta.Enabled = chkRangoFecha.Checked;
                cboEstatus.Enabled = chkPorEstatus.Checked;
                cboCampos.Enabled = chkPorCampo.Checked;
                cboCondicion.Enabled = chkPorCampo.Checked;
                txtABuscar2.Enabled = chkPorCampo.Checked;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void RealizarBusquedaAvanzada()
        {
            String estatus = "";
            string condicion = "";
            string campo = "";
            string aBuscar = "";

            try
            {
                objDB.Filtros.Clear();
                tipoBusqueda = 2;

                if ((chkPorOficina.Checked) && (cboOficina.SelectedValue != null)) objDB.AddFiltroOficina((int)cboOficina.SelectedValue);
                if (chkRangoFecha.Checked) objDB.AddFiltroRangoFecha(NombreCampoFecha, dtpFechaDesde.Value, dtpFechaHasta.Value);

                //FILTRO POR ESTATUS
                if ((chkPorEstatus.Checked) && (cboEstatus.Text != ""))
                {
                    estatus = cboEstatus.Text.ToUpper();
                    if (estatus == "VIGENTE")
                    {
                        objDB.AddFiltroEmpieceEN("Estatus_Id", "V");
                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }
                    if (estatus == "CASTIGADO")
                    {
                        objDB.AddFiltroIgualA("Estatus_Id", "VZ");
                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }
                    if (estatus == "APROBADO")
                    {
                        objDB.AddFiltroIsNoNull("Fecha_Aprobado");
                        objDB.AddFiltroEmpieceEN("Estatus_Id", "V");
                    }
                    if (estatus == "PENDIENTE APROBAR")
                    {
                        objDB.AddFiltroEmpieceEN("Estatus_Id", "V");
                        objDB.AddFiltroIsNull("Fecha_Aprobado");
                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }

                    if (estatus == "RECHAZADO") objDB.AddFiltroIsNoNull("Fecha_Rechazado");
                    if (estatus == "NO RECHAZADO")
                    {
                        objDB.AddFiltroIsNull("Fecha_Rechazado");
                        objDB.AddFiltroEmpieceEN("Estatus_Id", "V");
                    }

                    if (estatus == "CANCELADO")
                    {
                        objDB.AddFiltroIsNoNull("Fecha_Cancelado");

                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }

                    if (estatus == "NO CANCELADO")
                    {
                        objDB.AddFiltroIsNull("Fecha_Cancelado");

                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }

                    if (estatus == "POSTEADO")
                    {
                        if (MyData.Columns.Contains("Fecha_Posteado")) objDB.AddFiltroIsNoNull("Fecha_Posteado");
                        else if (MyData.Columns.Contains("Fecha_Actualizado")) objDB.AddFiltroIsNoNull("Fecha_Actualizado");

                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }

                    if (estatus == "NO POSTEADO")
                    {
                        if (MyData.Columns.Contains("Fecha_Posteado")) objDB.AddFiltroIsNull("Fecha_Posteado");
                        else if (MyData.Columns.Contains("Fecha_Actualizado")) objDB.AddFiltroIsNull("Fecha_Actualizado");

                        if (MyData.Columns.Contains("Fecha_Rechazado")) objDB.AddFiltroIsNull("Fecha_Rechazado");
                    }
                }

                //FILTRAMOS POR UN CAMPO
                if ((chkPorCampo.Checked) && (cboCampos.SelectedValue != null))
                {

                    condicion = cboCondicion.Text.Trim().ToUpper();
                    campo = cboCampos.SelectedValue.ToString();
                    aBuscar = txtABuscar2.Text.Trim();

                    if (condicion == "") objDB.AddFiltroPersonalizado(campo + " Like '%' + REPLACE('" + aBuscar + "', ' ', '%')" + '%');
                    if (condicion == "IGUAL") objDB.AddFiltroIgualA(campo, aBuscar);
                    if (condicion == "MAYOR O IGUAL") objDB.AddFiltroMayorOIgualA(campo, aBuscar);
                    if (condicion == "MENOR O IGUAL") objDB.AddFiltroMenorOIgualA(campo, aBuscar);
                    if (condicion == "QUE CONTENGA") objDB.AddFiltroContengaA(campo, aBuscar);
                    if (condicion == "COMIENZA EN") objDB.AddFiltroEmpieceEN(campo, aBuscar);
                    if (condicion == "TERMINA EN") objDB.AddFiltroTermineEN(campo, aBuscar);

                }

                //EXLUIMOS LOS NULOS
                if (chkNulos.Visible)
                {
                    if ((chkNulos.Checked) && (MyData.Columns.Contains("EsNulo"))) objDB.AddFiltroIgualA("EsNulo", "0");
                    if ((chkNulos.Checked) && (MyData.Columns.Contains("Nulo"))) objDB.AddFiltroIgualA("Nulo", "0");
                }

                //POR ULTIMO OBTENEMOS LOS DATOS
                GetData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public virtual void RealizarBusquedaSencilla()
        {
            string valor = "";
            string filtro = "";
            DateTime fecha;
            ELRCombobox cbo;

            try
            {
                objDB.LimpiarFiltros();
                tipoBusqueda = 1;
                if (txtABuscar.FiltroBusqueda != null) filtro = txtABuscar.FiltroBusqueda.Trim();

                //Si no se ha Indicado Filtro Busqueda, el sistema la asignara
                if (txtABuscar.Visible && filtro == "")
                {
                    if(NombreCampoID != null)
                    {
                        if(NombreCampoID.Trim() != "")
                        {
                            filtro = "Cast(" + NombreCampoID.Trim() + " as Varchar)";
                            filtro = "Replace(" + filtro + ",'-', ''" + ")";
                        }
                    }

                    if (DataGridConsulta != null)
                    {
                        if (DataGridConsulta.Columns.Contains("CedulaRNC"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "Replace(IsNull(" + DataGridConsulta.Columns["CedulaRNC"].DataPropertyName + ", ''), '-', '')";
                        }

                        if (DataGridConsulta.Columns.Contains("Cedula"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "Replace(IsNull(" + DataGridConsulta.Columns["Cedula"].DataPropertyName + ", ''), '-', '')";
                        }

                        if (DataGridConsulta.Columns.Contains("RNC"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "Replace(IsNull(" + DataGridConsulta.Columns["RNC"].DataPropertyName + ", ''), '-', '')";
                        }

                        if (DataGridConsulta.Columns.Contains("VALOR"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "Replace(IsNull(" + DataGridConsulta.Columns["VALOR"].DataPropertyName + ", ''), '-', '')";
                        }

                        //FILTRAMOS POR NOMBRE O DESCRIPCION
                        if (DataGridConsulta.Columns.Contains("Nombre"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" +  DataGridConsulta.Columns["Nombre"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("Nombres"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Nombres"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("ANombre"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["ANombre"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("Nombre_Completo"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Nombre_Completo"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("Descripcion"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Descripcion"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("Concepto"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Concepto"].DataPropertyName + ", '')";
                        }
                        //===============================================================================================================

                        //FILTRAMOS POR APELLIDOS
                        if (DataGridConsulta.Columns.Contains("Apellido"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Apellido"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("Apellidos"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Apellidos"].DataPropertyName + ", '')";
                        }
                        //==============================================================================================================

                        //FILTRAMOS POR APODOS
                        if (DataGridConsulta.Columns.Contains("Apodo"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Apodo"].DataPropertyName + ", '')";
                        }
                        else if (DataGridConsulta.Columns.Contains("Apodos"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "IsNull(" + DataGridConsulta.Columns["Apodos"].DataPropertyName + ", '')";
                        }
                        //==============================================================================================================


                        if (DataGridConsulta.Columns.Contains("Numero"))
                        {
                            if (filtro != "") filtro += " + ";
                            filtro += "Cast(IsNull(" + DataGridConsulta.Columns["Numero"].DataPropertyName + ", 0) as Varchar)";
                        }

                    }

                    txtABuscar.FiltroBusqueda = filtro + " Like '%' + @aBuscar + '%' ";
                    
                }


                foreach (Control item in pnBusqSencilla.Controls)
                {
                    filtro = "";

                    if (item is ELRTextBox)
                    {
                        valor = ((ELRTextBox)item).Text.Trim();
                        if (valor.Trim() == "") valor = "'%'";
                        else valor = valor.Replace(' ', '%');

                        if(valor != "") filtro = ((ELRTextBox)item).FiltroBusqueda.ToUpper();
                    }

                    if (item is ELRCombobox)
                    {
                        cbo = (ELRCombobox)item;
                        valor = "";
                        if ((cbo.SelectedValue != null) && (cbo.ValueMember != "")) valor = cbo.SelectedValue.ToString();
                        else if (cbo.Text.Trim() != "") valor = cbo.Text.Trim();

                        if (valor != "")  filtro = cbo.FiltroBusqueda.ToUpper();
                    }

                    if (item is ELRCheckBox)
                    {
                        if (((ELRCheckBox)item).Checked) filtro = ((ELRCheckBox)item).FiltroBusqueda.ToUpper();
                    }

                    if (item is ELRDatePicker)
                    {
                        fecha = ((ELRDatePicker)item).Value;
                        valor = objDB.DateToInt(fecha).ToString();
                        filtro = ((ELRDatePicker)item).FiltroBusqueda.ToUpper();
                    }

                    if (filtro.Trim() != "")
                    {
                        if (valor != "'%'") valor = "'" + valor.Trim().Replace("-", string.Empty) + "'";
                        filtro = filtro.Replace("@ABUSCAR", valor).Trim();
                        if (filtro.Substring(0, 3) != "AND") filtro = " AND " + filtro;
                        objDB.AddFiltroPersonalizado(filtro);
                    }
                }

                GetData();

                if (txtABuscar.Enabled && txtABuscar.Visible) txtABuscar.Focus();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusquedaSencilla();
        }

        private void btnCerrarBusq_Click(object sender, EventArgs e)
        {
            pnOpcionesBusqueda.Visible = false;
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            pnOpcionesBusqueda.Visible = true;
        }

        private void FormPlantillaIndex_Load(object sender, EventArgs e)
        {
            string titulo = "";
            string variableValor = "";
            DataTable tblMenu = null;
            string logoURL = "";
            string valor = "";
            try
            {
                impresoraDefault = "";
                objUtil = new ELRUtils(this);

                if (EnEjecusion)
                {
                    tsbBusquedaAvanzada.Enabled = false;
                    dtpFechaDesde.Value = DateTime.Now.Date.AddDays(-30);
                    dtpFechaHasta.Value = DateTime.Now.Date;

                    objUtil.NOMBRE_USUARIO = nombreUsuario;
                    objUtil.FORM_NAME = Name + "(" + Text + ")";

                    if (esBusqueda) txtABuscar.EsBusquedaAutoIncremental = true;

                    if (TablaOVista == null) TablaOVista = "";

                    //establecemos el font size al datagrid
                    if (DataGridConsulta != null)
                    {
                        DataGridConsulta.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                        foreach (DataGridViewColumn item in DataGridConsulta.Columns)
                        {
                            //los link hacemos en negrita
                            if (item is DataGridViewLinkColumn)
                            {
                                item.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                                if (item.Width < 140) item.Width = 140;
                            }

                            if (item.DefaultCellStyle.Font == null) continue;
                            if (item.DefaultCellStyle.Font.Size < 11 && item.DefaultCellStyle.Font.Bold) item.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                            else if (item.DefaultCellStyle.Font.Size < 11) item.DefaultCellStyle.Font = new Font("Segoe UI", 11);

                            
                        }
                    }

                    //VALIDAMOS VARIABLES PARA MOSTRAR DETALLE DE FACTURA COBRO
                    variableValor = objUtil.GetValorVariable("MOSTRAR_DETALLE_FACTURAS_PAGADAS", DTVariablesSYS);
                    MOSTRAR_DETALLE_FACTURAS_PAGADAS = (variableValor == "TRUE") || (variableValor == "1");
                    variableValor = "";
                    

                    //Validamos para Mostrar Columna_Prestamo_Id
                    variableValor = objUtil.GetValorVariable("MOSTRAR_COLUMNA_PRESTAMO", DTVariablesSYS, "false").Trim().ToUpper();
                    MOSTRAR_COLUMNA_PRESTAMO = (variableValor == "TRUE") || (variableValor == "1");
                    variableValor = "";


                    //Validamos Mostrar Columna Factura
                    variableValor = objUtil.GetValorVariable("MOSTRAR_COLUMNA_FACTURA", DTVariablesSYS, "false").Trim().ToUpper();
                    MOSTRAR_COLUMNA_FACTURA = (variableValor == "TRUE") || (variableValor == "1");
                    variableValor = "";

                    //buscamos el metodos a imprimir CAJA_METODO_IMPRIME <= 1 ticket    2 = matricial  3 = Preview
                    valor = objUtil.GetValorVariable("CAJA_METODO_IMPRIME_" + objUtil.GetSerialNumber(), DTVariablesSYS);
                    if (valor.Trim() == "") valor = objUtil.GetValorVariable("CAJA_METODO_IMPRIME", DTVariablesSYS);
                    int.TryParse(valor.Trim(), out metodoImp);
                    if (metodoImp <= 0) metodoImp = 3;

                    //buscamos el nombre de la impresora de caja
                    impresoraDefault = objUtil.GetValorVariable("CAJA_IMP_NOMBRE_" + objUtil.GetSerialNumber(), DTVariablesSYS).Trim();
                    if (impresoraDefault == "DEFAULT" || impresoraDefault == "") impresoraDefault = objUtil.getImpresoraPorDefecto();
                    else if (impresoraDefault == "MOSTRAR_CUADRO_DIALOGO") impresoraDefault = "";

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


                    if (DataGridConsulta != null)
                    {
                       
                        DataGridConsulta.ReadOnly = true;
                        DataGridConsulta.MultiSelect = false;
                        DataGridConsulta.RowHeadersWidth = 28;

                        if (DataGridConsulta.RowTemplate.Height < 40)  DataGridConsulta.RowTemplate.Height = 40;

                        /*if (DataGridConsulta.Columns.Contains("Prestamo_Id")) DataGridConsulta.Columns["Prestamo_Id"].Visible = MOSTRAR_COLUMNA_PRESTAMO;
                        if (DataGridConsulta.Columns.Contains("Factura_No")) DataGridConsulta.Columns["Factura_No"].Visible = MOSTRAR_COLUMNA_FACTURA;
                        if (DataGridConsulta.Columns.Contains("Factura_Numero")) DataGridConsulta.Columns["Factura_Numero"].Visible = MOSTRAR_COLUMNA_FACTURA;
                        */

                        //ASIGNAMOS METODO PARA SELECCIONAR FILA EN CASO DE BUSQUEDA
                        if (esBusqueda || EsModificar)
                        {
                            DataGridConsulta.CellContentDoubleClick += new DataGridViewCellEventHandler(dgvConsulta_SelectFila);
                        }
                    }

                    montoLetras = "";
                    
                    

                    if (DTEmpresaOficinas != null)
                    {
                        cboOficina.DataSource = DTEmpresaOficinas.DefaultView;
                        cboOficina.ValueMember = "Oficina_Id";
                        cboOficina.DisplayMember = "Nombre";
                    }

                    stlNombreUsuario.Text = nombreUsuario.ToUpper();
                    objDB.NOMBRE_USUARIO = nombreUsuario.ToUpper();

                    if (TablaOVista.Trim() != "") CargarOpcionesBusqueda();


                    //CARGAMOS LOS DATOS DE LA OFICINA
                    if (DTOficina == null) DTOficina = objDB.GetById("VEMPRESAS_OFICINAS", oficinaID.ToString(), "Oficina_Id");
                    else if (DTOficina.Rows.Count <= 0) DTOficina = objDB.GetById("VEMPRESAS_OFICINAS", oficinaID.ToString(), "Oficina_Id");

                    //Buscamos las Fecha de Trabajo
                    objDB.GetFechasOficina(oficinaID);

                    if(REQUIERE_CIERRE_OPERACIONES == false)
                    {
                        objDB.FECHA_TRABAJO = DateTime.Now.Date;
                        objDB.FECHA_CONTABLE = DateTime.Now.Date;

                    }

                    //PASAMOS DATOS DE LA EMPRESA AL OBJETO UTIL
                    if (DTOficina.Rows.Count > 0)
                    {
                        objUtil.EMPRESA_NOMBRE = objUtil.GetAsString("Empresa_Nombre", DTOficina.Rows[0]);
                        objUtil.EMPRESA_OFICINA = objUtil.GetAsString("Nombre", DTOficina.Rows[0]);
                        objUtil.EMPRESA_EMAIL = objUtil.GetAsString("EMail", DTOficina.Rows[0]);
                        objUtil.EMPRESA_TELEFONO = objUtil.GetAsString("Telefono1", DTOficina.Rows[0]);
                        EMPRESA_RNC = objUtil.GetAsString("Empresa_RNC", DTOficina.Rows[0]);
                    }

                    //Habilitamos o Deshabilitamos Opciones de Menu
                    tsbCopiar.Visible = EsCopiar;
                    tsbAgregar.Visible = EsAgregar;
                    tsbModificar.Visible = EsModificar;
                    tsbImprimir.Visible = EsImprimir;
                    tsmFilasAMostrar.Visible = EsFilasAMostrar;
                    tsbSeleciona.Visible = esBusqueda;
                    //tsbExcel.Visible = EsExcel;
                    tsbTXT.Visible = EsTXT;
                    tsbPreview.Visible = EsPreview;

                    //CARGAMOS OPCIONES DE MENU
                    if (menuId > 0)
                    {
                        if (nombreUsuario.Trim().ToUpper() == "SYS.ADMIN")
                        {
                            tblMenu = objDB.GetById(TABLA_OPCIONES_MENU, menuId.ToString(), "Menu_Id");
                            EsCambiarFecha = true;
                        }
                        else
                        {
                            objDB.LimpiarFiltros();
                            objDB.AddFiltroIgualA("Menu_Id", menuId.ToString());
                            objDB.AddFiltroIgualA("Nombre_Usuario", nombreUsuario);

                            tblMenu = objDB.GetAll("VOPCIONES_X_USUARIOS", -1, objDB.Filtros);
                            objDB.LimpiarFiltros();

                            PermisosToolbar(tblMenu);
                        }
        

                        if (tblMenu.Rows.Count > 0)
                        {
                            if (!(tblMenu.Rows[0]["Titulo"] is DBNull))
                            {
                                titulo = tblMenu.Rows[0]["Titulo"].ToString().ToUpper().Trim();
                                if (titulo != "") this.Text = titulo;
                            }

                            if (!(tblMenu.Rows[0]["Proximo"] is DBNull)) proximo = tblMenu.Rows[0]["Proximo"].ToString().ToUpper().Trim();
                        }

                    }

                    if (EsFilasAMostrar)
                    {
                        if (Limite > 0) tsmFilasAMostrar.Text = "Mostrar " + Limite.ToString() + " Filas";
                        else tsmFilasAMostrar.Text = "Mostrar (Todos)";
                    }


                    //VALIDAMOS LA LICENCIA
                    ValidaLicencia();
                    if ((esLicenciaActiva == false) && (diasLimiteSinLicensia <= 0))
                    {
                        objUtil.MostrarMensajeAdvertencia("PERIODO DE PRUEBA HA EXPIRADO, DEBE REGISTRAR UNA LICENSIA... ");

                        if (tsbAgregar.Visible) tsbAgregar.Enabled = false;
                        if (tsbModificar.Visible) tsbModificar.Enabled = false;
                    }


                    //BUSCAMOS ALGUNOS VALORES EN VARIABLES
                    IMPRIME_TICKET_COPIA = 0;
                    variableValor = objUtil.GetValorVariable("IMPRIME_TICKET_COPIA", DTVariablesSYS, "0");
                    int.TryParse(variableValor, out IMPRIME_TICKET_COPIA);

                    //EJECUTAMOS LA BUSQUEDA
                    if ((CargarDataAlInicio) && (TablaOVista.Trim() != ""))
                    {
                        if (txtABuscar.Visible) txtABuscar.Text = textoABuscar;
                        RealizarBusquedaSencilla();
                    }
                    if (esBusqueda) WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                this.Close();
            }
            finally
            {
                tblMenu = null;
            }

        }

        public void setTextoABuscar(string texto)
        {
            try
            {
                if (txtABuscar.Visible) txtABuscar.Text = texto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvConsulta_SelectFila(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (esBusqueda) SelectFila();
                else if (EsModificar) Modificar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SelectFila()
        {
            string valorUnico = "0";
            string valorId = "";
            filaSelecionada = null;

            try
            {
                if (NombreCampoID == null) NombreCampoID = "";

                if (esBusqueda && DataGridConsulta.Rows.Count > 0)
                {
                    if (DataGridConsulta.Columns.Contains("Unico"))
                    {
                        valorUnico = DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString();
                        filaSelecionada = MyData.Select("Unico = " + valorUnico)[0];
                    }
                    else if (NombreCampoID.Trim() != "")
                    {
                        if (DataGridConsulta.Columns.Contains(NombreCampoID.Trim()))
                        {
                            valorId = DataGridConsulta[NombreCampoID.Trim(), DataGridConsulta.CurrentRow.Index].Value.ToString();
                            filaSelecionada = MyData.Select(NombreCampoID + " = '" + valorId + "'")[0];
                        }
                    }

                    if (filaSelecionada != null) Close();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void PermisosToolbar(DataTable DTData)
        {
            bool _agregar = false, _modificar = false, _imprimir = true;
            bool _anular = false, _aprobar = false, _rechazar = false;
            bool _cambiarFecha = false;

            try
            {
                foreach (DataRow item in DTData.Rows)
                {
                    if (_agregar == false) _agregar = (bool)item["EsInsertar"];
                    if (_modificar == false) _modificar = (bool)item["EsModificar"];

                    if (_anular == false) _anular = (bool)item["EsAnular"];

                    if (_aprobar == false) _aprobar = (bool)item["EsAprobar"];
                    if (_rechazar == false) _rechazar = (bool)item["EsRechazar"];

                    if (_cambiarFecha == false) _cambiarFecha = (bool)item["EsCambiar_Fecha"];
                }

                if (EsAgregar) EsAgregar = _agregar;
                if (EsModificar) EsModificar = _modificar;
                if (EsImprimir) EsImprimir = _imprimir;
                if (EsAnular) EsAnular = _anular;
                if (EsAprobar) EsAprobar = _aprobar;
                if (EsRechazar) EsRechazar = _rechazar;
                if (EsCopiar) EsCopiar = _agregar;

                EsCambiarFecha = _cambiarFecha;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBusqAvanzada_Click(object sender, EventArgs e)
        {
            RealizarBusquedaAvanzada();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }


        private void txtABuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtABuscar.EsBusquedaAutoIncremental) RealizarBusquedaSencilla();
                else if (e.KeyChar == (char)Keys.Enter) RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void tsbBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnOpcionesBusqueda.Width != 308) pnOpcionesBusqueda.Width = 308;

                pnOpcionesBusqueda.Visible = !pnOpcionesBusqueda.Visible;
                if ((chkPorOficina.Checked == false) && (chkRangoFecha.Checked == false) && (chkPorEstatus.Checked == false) && (chkPorCampo.Checked == false))
                {
                    chkPorCampo.Checked = true;
                    cboCondicion.SelectedIndex = 1;

                    if (DataGridConsulta != null)
                    {
                        foreach (DataGridViewColumn item in DataGridConsulta.Columns)
                        {
                            if ((item.Visible) && (!(item is DataGridViewButtonColumn)) && (item.DataPropertyName != ""))
                            {
                                cboCampos.SelectedValue = item.DataPropertyName;
                                break;
                            }
                        }
                    }

                    txtABuscar2.Focus();
                }
                else if (txtABuscar2.Enabled)
                {
                    txtABuscar2.SelectAll();
                    txtABuscar2.Focus();
                }
                else btnBusqAvanzada.Focus();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormPlantillaIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                if (MyData != null) MyData.Dispose();

                this.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public virtual void Imprimir()
        {

        }

        public virtual void ShowPreview()
        {
            Imprimir();
        }

        public virtual void GenerarTXT()
        {

        }

        public virtual void GenerarEXCEL(string titulo = "")
        {
            FormExportToExcel frmExcel = new FormExportToExcel();
            List<MyColumna> colList = new List<MyColumna>();
            try
            {
                if(DataGridConsulta != null)
                {
                    foreach (DataGridViewColumn item in DataGridConsulta.Columns)
                    {
                        if(item.Visible && item.DataPropertyName != "")
                        {
                            colList.Add(new MyColumna(item.HeaderText, item.DataPropertyName));
                        }
                    }
                }

                if (titulo.Trim() == "") titulo = Text.ToUpper();
                frmExcel.titulo = titulo;
                frmExcel.DTData = MyData;
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

        private void FormPlantillaIndex_KeyDown(object sender, KeyEventArgs e)
        {
            //ESCAPE = SALIR
            if (e.KeyCode == Keys.Escape) tsbSalir.PerformClick();
            
            //CTRL + N = AGREGAR 
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.N) && (EsAgregar)) Agregar();

            //CTRL + M = MODIFICAR
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.M) && (EsModificar)) Modificar();

            //CTRL + P = IMPRIMIR
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.P) && (EsImprimir)) Imprimir();

            //CTRL + B = BUSQUEDA AVANZADA
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.B) && (tsbBusquedaAvanzada.Visible) && (tsbBusquedaAvanzada.Enabled)) tsbBusquedaAvanzada.PerformClick();

            //CTRL + S = SALIR
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.S)) tsbSalir.PerformClick();

        }

        private void chkPorOficina_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarOpcionesBusqueda();
        }

        private void tsmFilas50_Click(object sender, EventArgs e)
        {
            try
            {
                tsmFilasAMostrar.Text = "Mostrar 50 Filas";
                Limite = 50;

                if (tipoBusqueda <= 1) RealizarBusquedaSencilla();
                else RealizarBusquedaAvanzada();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tsmFilas200_Click(object sender, EventArgs e)
        {
            try
            {
                tsmFilasAMostrar.Text = "Mostrar 200 Filas";
                Limite = 200;

                if (tipoBusqueda <= 1) RealizarBusquedaSencilla();
                else RealizarBusquedaAvanzada();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tsmFilas100_Click(object sender, EventArgs e)
        {
            try
            {
                tsmFilasAMostrar.Text = "Mostrar 1000 Filas";
                Limite = 1000;

                if (tipoBusqueda <= 1) RealizarBusquedaSencilla();
                else RealizarBusquedaAvanzada();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tsmFilas0_Click(object sender, EventArgs e)
        {
            try
            {
                tsmFilasAMostrar.Text = "Mostrar (Todo)";
                Limite = -1;

                if (tipoBusqueda <= 1) RealizarBusquedaSencilla();
                else RealizarBusquedaAvanzada();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tsbSeleciona_Click(object sender, EventArgs e)
        {
            SelectFila();
        }

        private void tsbTXT_Click(object sender, EventArgs e)
        {
            GenerarTXT();
        }

        private void tsbExcel_Click(object sender, EventArgs e)
        {
            GenerarEXCEL();
        }

        private void tsbCopiar_Click(object sender, EventArgs e)
        {
            CopiarATemporal();
        }

        private void tsbPreview_Click(object sender, EventArgs e)
        {
            ShowPreview();
        }
    }
}
