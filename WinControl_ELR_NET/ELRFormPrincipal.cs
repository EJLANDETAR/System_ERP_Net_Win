using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;

namespace WinControl_ELR_NET
{
    public partial class ELRFormPrincipal : Form
    {

        ELRUtils objUtil = null;

        bool esDemo = true;
        bool esInicio = true;
        int empresaID = 1;
        int oficinaID = 100;
        int sessionId = 0;

        string nombreEmpresa = "";
        string nombreOficina = "";
        string telefonosEmpresa = "";
        string emailEmpresa = "";
        string empresaRNC = "";
        int diasLimiteSinLicensia = 30;
        int cajaNo = 0;
        bool esNotificaciones = false;
        DateTime feUltValidacion = DateTime.Now.AddYears(-100);

        DirectoryInfo dirImage;
        DataTable DTMenu = null;
        FormSplash frmSplash;
        DateTime fechaTrabajo;

        public bool loginOK = false;
        public string nombreUsuario = "";
        public string nombreMenu = "";

        int conteoShowLicencia = 0;


        //DEFINIMOS PROPIEDADES
        [Category("PropiedadesELR")]
        public bool EnEjecusion { get; set; }

        [Category("PropiedadesELR")]
        public bool EsModoDeveloper { get; set; }

        //DEFINIMOS VARIABLES PUBLICAS
        public DataSet DSDataGlobal = null;
        public DataTable DTVariablesSYS = null;
        public DataTable DTOficinas = null;
        public DataTable DTEmpresaOficina = null;
        public DataTable DTLicencias = null;
        public DataTable DTMenuPrincipal = null;

        public DataView DVMenu = null;

        public string serialNumero = "";
        public bool REQUIERE_CIERRE_OPERACIONES = false;
        public bool REQUIERE_CAJA_ABIERTA = false;
        public bool REQUIERE_CONVERTIR_ADOLARES = false;
        public bool MOSTRAR_MENU_VERTICAL = false;
        public bool MOSTRAR_MENU_FLAT_PANEL = false;
        bool esShowLicencia = true;

        //Agregamos un panel lateral
        FlowLayoutPanel panelNotificaciones = new FlowLayoutPanel();

        int uUnicoNot = 0;

        private void AgregarSysNotificaciones()
        {
            DataTable DTData = null;
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            Notificacion.TipoNotificacion tipo = Notificacion.TipoNotificacion.Info;
            string sTipo = "", concepto = "", form = "", fileSound = "";
            int id = 0, conteo = 0;
            try
            {
                db.NOMBRE_USUARIO = nombreUsuario;
                parms.Add(new DataDB_ELR_NET.Parametro("Usuario", nombreUsuario));
                parms.Add(new DataDB_ELR_NET.Parametro("uUnicoNot", uUnicoNot));
                DTData = db.GetFromSP("SP_SISTEMA_GET_NOTIFICACIONES", "", parms);
                conteo = DTData.Rows.Count;
                foreach (DataRow fila0 in DTData.Rows)
                {
                    sTipo = db.GetAsString("Tipo", fila0).ToUpper();
                    concepto = db.GetAsString("Concepto", fila0).ToUpper();
                    id = db.GetAsInt("Unico", fila0);
                    form = db.GetAsString("FormAEjecutar", fila0);
                    if (sTipo == "INFO") tipo = Notificacion.TipoNotificacion.Info;
                    else if (sTipo == "ERROR") tipo = Notificacion.TipoNotificacion.Error;
                    else if (sTipo == "WARNING") tipo = Notificacion.TipoNotificacion.Warning;
                    else if (sTipo == "EXCEL") tipo = Notificacion.TipoNotificacion.Excel;
                    else if (sTipo == "DGII") tipo = Notificacion.TipoNotificacion.DGII;
                    else tipo = Notificacion.TipoNotificacion.Success;

                    AgregarNotificacion(concepto, tipo, id, form);
                    if (id > uUnicoNot) uUnicoNot = id;
                }

                //EMITIMOS SONIDO DE NOTIFICACION
                fileSound = Environment.CurrentDirectory + @"/images/sms-alert-2.wav";
                if (conteo > 0 && File.Exists(fileSound))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(fileSound);
                    player.Play();
                }
            }
            catch (Exception ex)
            {

                concepto = ex.Message;
            }
        }

        public ELRFormPrincipal()
        {
            InitializeComponent();

            EnEjecusion = false;
            EsModoDeveloper = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Application.Exit();
            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarMenuDB()
        {
            DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();

            DataView dvData = null;
            string mnuName, descripcion;
            ToolStripMenuItem item;
            int moduloId;
            bool esMenuVertical = true;
            TreeNode node = null;
            DataRow fila0 = null;
            int menuDefault = -1;


            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                objDB.AddFiltroNoIgualA("Modulo_Id", "15");
                objDB.AddFiltroNoIgualA("Modulo_Id", "4");
                DTMenuPrincipal = objDB.GetAll("TSISTEMA_MODULOS", 1000, objDB.Filtros);

                //Buscamos las Opciones Menu      
                if (nombreUsuario.Trim().ToUpper() == "SYS.ADMIN")
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroOrderBY("Modulo_Id, EsMenuConsulta, OrdenNo");
                    objDB.AddFiltroPersonalizado(" (IsNull(Formulario_AEjecutar, '') <> '') ");
                    DTMenu = objDB.GetAll("TACCESOS_OPCIONES_MENU", -1, objDB.Filtros);
                }
                else
                {
                    DTMenu = objDB.GetOpcionesUsuario(nombreUsuario);
                    DTMenu.DefaultView.Sort = "Modulo_Id, EsMenuConsulta, OrdenNo";
                }

                dvData = DTMenuPrincipal.DefaultView;

                //if (nombreUsuario.Trim().ToUpper() != "SYS.ADMIN") dvData.RowFilter = MyData.Columns["Modulo_Id"].ColumnName + " = '0'";

                foreach (DataRowView drFilaActual in dvData)
                {
                    moduloId = (int)drFilaActual["Modulo_Id"];
                    descripcion = drFilaActual["Carpeta"].ToString().ToLower();
                    descripcion = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(descripcion);
                    mnuName = "mnu" + objUtil.GetNumeroAleatorio().ToString();

                    item = new ToolStripMenuItem();
                    item.Name = mnuName;
                    item.Text = descripcion;

                    //AGREGAMOS AL TREEVIEW
                    if (esMenuVertical)
                    {
                        node = new TreeNode();
                        node.Name = mnuName;
                        node.Text = descripcion;
                    }


                    if (esMenuVertical) AgregarSubMenu(moduloId, item, node);
                    else AgregarSubMenu(moduloId, item);

                    mnuPrincipal.Items.Add(item);

                    if (esMenuVertical) trvMenu.Nodes.Add(node);

                    if (item.DropDownItems.Count <= 0)
                    {
                        mnuPrincipal.Items.Remove(item);
                        fila0 = DTMenuPrincipal.Select("Modulo_Id = " + moduloId.ToString())[0];
                        if (fila0 != null) DTMenuPrincipal.Rows.Remove(fila0);
                    }
                    else if (menuDefault <= 0)
                    {
                        descripcion = descripcion.ToUpper();
                        if (descripcion.Contains("VENTA")) menuDefault = moduloId;
                        else if (descripcion.Contains("CAJA")) menuDefault = moduloId;
                        else if (descripcion.Contains("CREDITO")) menuDefault = moduloId;
                        else if (descripcion.Contains("GERENCIA")) menuDefault = moduloId;
                        else if (descripcion.Contains("CONTABILID")) menuDefault = moduloId;
                        else if (descripcion.Contains("BANCO")) menuDefault = moduloId;
                        else if (descripcion.Contains("NOMINA")) menuDefault = moduloId;
                        else if (descripcion.Contains("RRHH")) menuDefault = moduloId;
                    }

                    if (esMenuVertical)
                    {
                        if (node.Nodes.Count <= 0) trvMenu.Nodes.Remove(node);
                    }

                }

                fila0 = DTMenuPrincipal.NewRow();
                fila0["Modulo_Id"] = 0;
                fila0["Carpeta"] = "(TODAS)";
                DTMenuPrincipal.Rows.Add(fila0);

                if (menuDefault < 0) menuDefault = objUtil.GetAsInt("Modulo_Id", DTMenuPrincipal.Rows[0]);

                cargarToolbar();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Cargar Menu, " + ex.Message);
            }
            finally
            {
                //DTMenu.Dispose();
                //dvData.Dispose();

                objDB = null;
            }
        }

        private void cargarToolbar()
        {
            int conteo = 0, total = 0;
            string nombreForm = "";
            bool esMenuConsulta = false;

            List<string> forms = new List<string>();
            DataRow[] filas;
            try
            {
                if (DTMenu == null) return;
                if (DTMenu.Rows.Count <= 0) return;

                foreach (ToolStripItem item in tsBarra.Items)
                {
                    if (item is ToolStripButton)
                    {
                        total++;
                        nombreForm = "";
                        if (item.Tag != null) nombreForm = item.Tag.ToString().Trim();
                        if (nombreForm.Trim() != "")
                        {
                            filas = DTMenu.Select("Formulario_AEjecutar Like '" + nombreForm + "'");
                            if (item == tsbVentas && filas.Length <= 0)
                            {
                                nombreForm = "ELRFacturas.FormFacturasList";
                                item.Tag = "ELRFacturas.FormFacturasList";
                                filas = DTMenu.Select("Formulario_AEjecutar Like '" + nombreForm + "'");
                            }

                            forms.Add(nombreForm);
                            if (filas.Length > 0) item.Visible = true;
                            else item.Visible = false;
                        }

                        if (item.Visible) conteo++;
                    }
                }

                conteo = (total - conteo) - 1;
                if (conteo > 0)
                {
                    foreach (DataRow fila0 in DTMenu.Rows)
                    {
                        esMenuConsulta = objUtil.GetAsBoolean("EsMenuConsulta", fila0);
                        nombreForm = objUtil.GetAsString("Formulario_AEjecutar", fila0);
                        if (esMenuConsulta) continue;
                        if ((nombreForm.ToUpper().Contains("ELRMAESTRO")) && (!nombreForm.ToUpper().Contains("EMPLEADO"))) continue;
                        if (nombreForm.ToUpper().Contains("ACTIVOSFIJOSTIPOS")) continue;
                        if (nombreForm.ToUpper().Contains("TABLAISR")) continue;
                        if (nombreForm.ToUpper().Contains("NOMINACONFI")) continue;
                        if (nombreForm.ToUpper().Contains("TIPO")) continue;
                        if (nombreForm.ToUpper().Contains("CENTROCOSTO")) continue;
                        if (nombreForm.ToUpper().Contains("ACTIVOSFIJOSUBICA")) continue;


                        //Validamos el formulario no este ya registrado
                        foreach (string item in forms)
                        {
                            if (nombreForm.ToUpper() == item.ToUpper())
                            {
                                nombreForm = "";
                                break;
                            }
                        }

                        if (nombreForm == "") continue;

                        ToolStripButton btn = new ToolStripButton();
                        btn.Name = "tsbA" + conteo.ToString();
                        btn.Tag = nombreForm;
                        btn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                        btn.TextImageRelation = TextImageRelation.ImageAboveText;
                        btn.Text = objUtil.GetAsString("Nombre", fila0).ToUpper();
                        btn.ToolTipText = btn.Text;
                        btn.ImageScaling = ToolStripItemImageScaling.None;
                        btn.Padding = new Padding(8);

                        //Asignamos las imagen
                        if (nombreForm.ToUpper().Contains("EXCEL")) btn.Image = Properties.Resources.Excel_52px;
                        else if (nombreForm.ToUpper().Contains("ANULAR")) btn.Image = Properties.Resources.Cancel_52px;
                        else if (nombreForm.ToUpper().Contains("CANCEL")) btn.Image = Properties.Resources.Cancel_52px;
                        else if (nombreForm.ToUpper().Contains("ELIMINA")) btn.Image = Properties.Resources.Cancel_52px;
                        else if (nombreForm.ToUpper().Contains("DELETE")) btn.Image = Properties.Resources.Cancel_52px;
                        else if (nombreForm.ToUpper().Contains("DARBAJA")) btn.Image = Properties.Resources.Cancel_52px;
                        else if (nombreForm.ToUpper().Contains("IMPRIM")) btn.Image = Properties.Resources.Print_52px;
                        else if (nombreForm.ToUpper().Contains("UNDO")) btn.Image = Properties.Resources.Undo_52px;
                        else if (nombreForm.ToUpper().Contains("REVER")) btn.Image = Properties.Resources.Undo_52px;
                        else if (nombreForm.ToUpper().Contains("CONTRAPARTIDA")) btn.Image = Properties.Resources.Undo_52px;
                        else if (nombreForm.ToUpper().Contains("FORMEMPLEADO")) btn.Image = Properties.Resources.Worker_52px;
                        else if (nombreForm.ToUpper().Contains("SALARIO")) btn.Image = Properties.Resources.Paper_Money_52px;
                        else if (nombreForm.ToUpper().Contains("CONFIG")) btn.Image = Properties.Resources.Automation_52px;
                        else if (nombreForm.ToUpper().Contains("TRANS")) btn.Image = Properties.Resources.Transaction_List_52px;
                        else if (nombreForm.ToUpper().Contains("DIARIO")) btn.Image = Properties.Resources.Book_52px;
                        else if (nombreForm.ToUpper().Contains("CHEQUES")) btn.Image = Properties.Resources.Bonds_52px;
                        else if (nombreForm.ToUpper().Contains("CONTAMOVIMIENTO")) btn.Image = Properties.Resources.Book_52px;
                        else if (nombreForm.ToUpper().Contains("CONTAPASE")) btn.Image = Properties.Resources.Check_All_52px;
                        else if (nombreForm.ToUpper().Contains("CATALOGO")) btn.Image = Properties.Resources.Bill_52px;
                        else if (nombreForm.ToUpper().Contains("GENERA")) btn.Image = Properties.Resources.Process_52px;
                        else if (nombreForm.ToUpper().Contains("REGISTRA")) btn.Image = Properties.Resources.Process_52px;
                        else if (nombreForm.ToUpper().Contains("MOVIMIENTO")) btn.Image = Properties.Resources.Transaction_List_52px;
                        else if (nombreForm.ToUpper().Contains("VACACIONE")) btn.Image = Properties.Resources.Beach_52px;
                        else if (nombreForm.ToUpper().Contains("APLICAR")) btn.Image = Properties.Resources.Check_All_52px;
                        else if (nombreForm.ToUpper().Contains("APROBAR")) btn.Image = Properties.Resources.Check_All_52px;
                        //modulo bancos
                        else if (nombreForm.ToUpper().Contains("BANCOSDEPOSI")) btn.Image = Properties.Resources.Deposit_52px;
                        else if (nombreForm.ToUpper().Contains("CHKPREDEFI")) btn.Image = Properties.Resources.Paper_Money_52px;
                        else if (nombreForm.ToUpper().Contains("BANCOSCUENTAS")) btn.Image = Properties.Resources.Bill_52px;
                        else if (nombreForm.ToUpper().Contains("FORMBANCO")) btn.Image = Properties.Resources.Bank_52px;
                        //oTROS
                        else if (nombreForm.ToUpper().Contains("VENTA")) btn.Image = Properties.Resources.Sell_52px;
                        else if (nombreForm.ToUpper().Contains("RESP")) btn.Image = Properties.Resources.Worker_52px;
                        else if (nombreForm.ToUpper().Contains("OFICINA")) btn.Image = Properties.Resources.Home_Automation_52px;
                        else if (nombreForm.ToUpper().Contains("DEPRECIACION")) btn.Image = Properties.Resources.Process_52px;
                        else if (nombreForm.ToUpper().Contains("CBUBIC")) btn.Image = Properties.Resources.Process_52px;
                        else if (nombreForm.ToUpper().Contains("FORMACTIVOSFIJOS")) btn.Image = Properties.Resources.List_52px;
                        else btn.Image = Properties.Resources.Check_52px;

                        btn.Click += new EventHandler(tsbBarraBtn_Click);
                        tsBarra.Items.Add(btn);

                        conteo--;
                        if (conteo <= 0) break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AgregarSubMenu(int moduloId, ToolStripMenuItem itemPrincipal, TreeNode nodePrincipal = null)
        {
            DataView dvData = null;
            string mnuName, descripcion;
            string formAEjecutar = "";
            ToolStripMenuItem item = new ToolStripMenuItem();
            ToolStripSeparator tsSeparador;
            int id = 0;
            bool esModal = true;
            string tipoForm = "C";
            string imageMenu = "";
            TreeNode node = new TreeNode();
            int conteoMenuConsulta = 0;
            bool esMenuConsulta = false;

            try
            {
                dvData = DTMenu.DefaultView;
                dvData.RowFilter = DTMenu.Columns["Modulo_Id"].ColumnName + " = '" + moduloId.ToString() + "'";

                foreach (DataRowView drFilaActual in dvData)
                {
                    id = (int)drFilaActual["Menu_Id"];
                    descripcion = drFilaActual["Nombre"].ToString();
                    //descripcion = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(descripcion);
                    mnuName = "mnu" + objUtil.GetNumeroAleatorio().ToString();
                    imageMenu = drFilaActual["Image"].ToString();
                    esMenuConsulta = bool.Parse(drFilaActual["EsMenuConsulta"].ToString());


                    //Agregamos Lineas Divisora
                    if (esMenuConsulta && conteoMenuConsulta == 0 && moduloId != 10)
                    {
                        tsSeparador = new ToolStripSeparator();
                        itemPrincipal.DropDownItems.Add(tsSeparador);

                    }

                    if (esMenuConsulta) conteoMenuConsulta++;

                    item = new ToolStripMenuItem();
                    item.Name = mnuName;
                    item.Text = descripcion;

                    if (nodePrincipal != null)
                    {
                        node = new TreeNode();
                        node.Name = mnuName;
                        node.Text = descripcion;
                    }

                    //AGREGAMOS UNA IMAGEN AL MENU SI APLICA
                    if (imageMenu.Trim() != "")
                    {
                        imageMenu = dirImage.ToString() + @"\" + imageMenu.Trim();
                        if (File.Exists(imageMenu))
                        {
                            if (itemPrincipal != null) item.Image = Image.FromFile(imageMenu);

                        }

                    }

                    itemPrincipal.DropDownItems.Add(item);
                    if (nodePrincipal != null) nodePrincipal.Nodes.Add(node);



                    //ASIGNAMOS EL FORM A EJECUTAR
                    formAEjecutar = "";
                    if (!(drFilaActual["Formulario_AEjecutar"] is DBNull))
                    {
                        formAEjecutar = drFilaActual["Formulario_AEjecutar"].ToString();
                        formAEjecutar += ";" + id.ToString();
                        esModal = true;
                        if (!(drFilaActual["Formulario_AEjecutar"] is DBNull))
                        {
                            esModal = (bool)drFilaActual["EsModal"];
                            tipoForm = drFilaActual["TipoFormulario"].ToString().ToUpper();
                        }


                        if (esModal) formAEjecutar += ";1;" + tipoForm;
                        else formAEjecutar += ";0;" + tipoForm;

                        item.Tag = formAEjecutar;
                        item.Click += new EventHandler(menuItem_Click);

                        if (nodePrincipal != null) node.Tag = formAEjecutar;

                    }
                }



            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Cargar SubMenu, " + ex.Message);
            }
            finally
            {
                //dvData.Dispose();
            }
        }

        void ejecutaForm(string valor, string nombreMenu = "")
        {
            string MyAsembly = "";
            string formulario;
            int menuId = 0;
            int modal = 0;
            bool esModal = true, esValido = true, conCaja = false;
            string tipoFormulario = "";
            string[] MyArray;
            FormPlantillaIndex frmCons = null;
            ELRFormRegistro frmRegistro = null;
            DialogResult resp;
            DataRow fila0 = null;
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                db.NOMBRE_USUARIO = nombreUsuario;
                //VALIDAMOS QUE EL USUARIO HAYA REGISTRADO SU LICENCIA
                if(diasLimiteSinLicensia <= 0)
                {
                    this.Cursor = Cursors.Default;
                    tsmRegistrarLicencia.PerformClick();
                    return;
                }

                MyArray = valor.Split(';');
                formulario = MyArray[0];
                MyAsembly = formulario.Split('.')[0];

                if (objUtil.getNivelForm(formulario) > 2)
                {
                    objUtil.MostrarMensajeAdvertencia("Proceso Rechazado, Usted tiene dos o mas formulario ejecutandose");
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

                //Mostramos un mensaje de advetencia si la fecha de trabajo es menor a la fecha actual
                if (objUtil.DateToInt(fechaTrabajo) < objUtil.DateToInt(DateTime.Now))
                {
                    resp = objUtil.MostrarMensajePregunta("FAVOR REALIZAR CIERRE OPERACIONES, LA FECHA DE TRABAJO ES MENOR A LA FECHA ACTUAL\n\nDESEA CONTINUAR?");
                    if (resp != DialogResult.Yes) return;
                }

                if (tipoFormulario == "C")
                {
                    frmCons = (FormPlantillaIndex)Activator.CreateInstance(MyAsembly, formulario).Unwrap();
                    frmCons.nivelForm = objUtil.getNivelForm(formulario);
                    frmCons.menuId = menuId;
                    frmCons.empresaID = empresaID;
                    frmCons.oficinaID = oficinaID;
                    frmCons.REQUIERE_CAJA_ABIERTA = REQUIERE_CAJA_ABIERTA;
                    frmCons.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                    frmCons.REQUIERE_CONVERTIR_ADOLARES = REQUIERE_CONVERTIR_ADOLARES;

                    frmCons.NOMBRE_EMPRESA = nombreEmpresa;
                    frmCons.NOMBRE_OFICINA = nombreOficina;
                    frmCons.nombreUsuario = nombreUsuario;
                    frmCons.FECHA_TRABAJO = fechaTrabajo;

                    frmCons.DTVariablesSYS = DTVariablesSYS;
                    frmCons.DTEmpresaOficinas = DTOficinas;
                    frmCons.DSGlobal = DSDataGlobal;
                    frmCons.DTMenu = DTMenu;

                    frmCons.EnEjecusion = true;
                    esModal = (modal > 0);
                    if (modal > 0) frmCons.ShowDialog();
                    else frmCons.Show();

                }
                else
                {
                    frmRegistro = (ELRFormRegistro)Activator.CreateInstance(MyAsembly, formulario).Unwrap();
                    frmRegistro.nivelForm = objUtil.getNivelForm(formulario);
                    frmRegistro.EMPRESA_ID = empresaID;
                    frmRegistro.OFICINA_ID = oficinaID;
                    frmRegistro.REQUIERE_CAJA_ABIERTA = REQUIERE_CAJA_ABIERTA;
                    frmRegistro.REQUIERE_CIERRE_OPERACIONES = REQUIERE_CIERRE_OPERACIONES;
                    frmRegistro.REQUIERE_CONVERTIR_ADOLARES = REQUIERE_CONVERTIR_ADOLARES;
                    conCaja = (frmRegistro.RequiereCajaAbierta && REQUIERE_CAJA_ABIERTA);

                    //VALIDAMOS LA FECHA DE OPERACIONES
                    if (frmRegistro.ExcluirValidacionCierre) esValido = true;
                    else if (frmRegistro.DataGridDetalle != null) esValido = db.ValidarFechaOperaciones(oficinaID, conCaja);
                    else if (REQUIERE_CIERRE_OPERACIONES) esValido = db.ValidarFechaOperaciones(oficinaID, conCaja);

                    frmRegistro.NOMBRE_EMPRESA_OFICINA = nombreEmpresa;
                    frmRegistro.NOMBRE_OFICINA = nombreOficina;
                    frmRegistro.nombreUsuario = nombreUsuario;
                    frmRegistro.FECHA_TRABAJO = fechaTrabajo;

                    frmRegistro.DTVariablesSYS = DTVariablesSYS;
                    frmRegistro.DSGlobal = DSDataGlobal;

                    frmRegistro.DTLicense = DTLicencias;

                    frmRegistro.EnEjecusion = true;
                    frmRegistro.DTMenu = DTMenu;

                    esModal = (modal > 0);
                    if (modal > 0) frmRegistro.ShowDialog();
                    else frmRegistro.Show();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (esModal)
                {
                    if (frmCons != null) frmCons.Dispose();
                    if (frmRegistro != null) frmRegistro.Dispose();
                }

            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem objitem = (ToolStripMenuItem)sender;
            string valor = "";

            try
            {
                if (objitem.Tag != null)
                {
                    valor = objitem.Tag.ToString().Trim();
                    nombreMenu = objitem.Text;
                    if (valor != "") ejecutaForm(valor, nombreMenu);
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void CargarData()
        {
            DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();
            DataTable DTData = null;
            try
            {
                DSDataGlobal = new DataSet();

                //Buscamos los Paises
                frmSplash.MostrarTexto("Cargando Paises");
                DTData = new DataTable();
                DTData = objDB.GetAll("TZONAS_PAISES", -1);
                DTData.TableName = "TZONAS_PAISES";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos Las Provincias
                frmSplash.MostrarTexto("Cargando Provincias");
                DTData = new DataTable();
                DTData = objDB.GetAll("TZONAS_PROVINCIAS", -1);
                DTData.TableName = "TZONAS_PROVINCIAS";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos Los Municipios
                frmSplash.MostrarTexto("Cargando Municipios");
                DTData = new DataTable();
                DTData = objDB.GetAll("TZONAS_MUNICIPIOS", -1);
                DTData.TableName = "TZONAS_MUNICIPIOS";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos Los Sectores
                frmSplash.MostrarTexto("Cargando Sectores");
                DTData = new DataTable();
                DTData = objDB.GetAll("TZONAS_SECTORES", -1);
                DTData.TableName = "TZONAS_SECTORES";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos Las Variable
                frmSplash.MostrarTexto("Cargando Variables");
                DTData = new DataTable();
                DTData = objDB.GetAll("TSISTEMA_VARIABLES", -1);
                DTData.TableName = "Variables";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos LOS MODULOS
                frmSplash.MostrarTexto("Cargando Modulos");
                DTData = new DataTable();
                DTData = objDB.GetAll("TSISTEMA_MODULOS", -1);
                DTData.TableName = "TSISTEMA_MODULOS";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos Las Tablas Auxiliares
                frmSplash.MostrarTexto("Cargando Tablas Auxiliares");
                DTData = new DataTable();
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                DTData = objDB.GetAll("TSISTEMA_TABLA_AUXILIAR", -1, objDB.Filtros);
                DTData.TableName = "TSISTEMA_TABLA_AUXILIAR";
                DSDataGlobal.Tables.Add(DTData);

                //Buscamos TIPOS DE EMPRESAS
                frmSplash.MostrarTexto("Cargando Tipos de Empresas");
                DTData = new DataTable();
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                DTData = objDB.GetAll("TCLASIFICADOR_TIPOS_EMPRESAS", -1, objDB.Filtros);
                DTData.TableName = "TCLASIFICADOR_TIPOS_EMPRESAS";
                DSDataGlobal.Tables.Add(DTData);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Cargar Data, " + ex.Message);
            }
            finally
            {
                objDB = null;
                DTData.Dispose();
            }
        }

        private void ELRFormPrincipal_Load(object sender, EventArgs e)
        {
            ELRFormSelEmpresa frmSelEmpresa = new ELRFormSelEmpresa();
            DataTable MyTabla = null;
            DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();
            string[] ACadena;
            string nombreImage = "", SSQL = "", concepto = "";

            try
            {
                objUtil = new ELRUtils(this);

                esDemo = false;
                esInicio = true;
                nombreImage = "";
                ACadena = nombreImage.Split(';');

                if (EnEjecusion)
                {

                    EsModoDeveloper = false;

                    serialNumero = objUtil.GetSerialNumber();
                    Text = "SISTEMA DE GESTION";

                    //CARGAMOS EN UN DataTable las Variables del sistema
                    DTVariablesSYS = objDB.GetAll("TSISTEMA_VARIABLES");

                    //VALIDAMOS SI EL SISTEMA RQUIERE CIERRE OPERACIONES
                    REQUIERE_CIERRE_OPERACIONES = objUtil.GetValorVariableAsBool("REQUIERE_CIERRE_OPERACIONES", DTVariablesSYS);

                    //VALIDAMOS SI EL SISTEMA REQUIERRE CAJA ABIERTA
                    REQUIERE_CAJA_ABIERTA = objUtil.GetValorVariableAsBool("REQUIERE_CAJA_ABIERTA", DTVariablesSYS);

                    //VARIABLE QUE INDICA SI REQUIERRE CONVERTIR A DOLARES
                    REQUIERE_CONVERTIR_ADOLARES = objUtil.GetValorVariableAsBool("REQUIERE_CONVERTIR_ADOLARES", DTVariablesSYS);

                    //MOSTRAR MENU VERTICAL
                    MOSTRAR_MENU_VERTICAL = objUtil.GetValorVariableAsBool("MOSTRAR_MENU_VERTICAL", DTVariablesSYS, "false");
                    splitContainer1.Panel1Collapsed = !MOSTRAR_MENU_VERTICAL;


                    dirImage = new DirectoryInfo(Application.StartupPath + @"\images");
                    frmSplash = new FormSplash();

                    //Cargamos la Data Necesaria
                    Thread tAux = new Thread(new ThreadStart(CargarData));
                    tAux.Start();
                    while (!tAux.IsAlive) ;


                    //Mostramos Formulario Splash
                    frmSplash.segundo = 7;
                    frmSplash.subProceso = tAux;
                    frmSplash.ShowDialog();



                    //this.Visible = true;

                    if (EsModoDeveloper)
                    {
                        nombreUsuario = "SYS.ADMIN";
                        loginOK = true;
                    }

                    this.Cursor = Cursors.WaitCursor;

                    tslNombreUsuario.Text = "USUARIO.: " + nombreUsuario;

                    //AGREGAMOS UNA NOTIFICACION PARA MOSTRAR A QUIEN LLAMAR EN CASO DE NECESITAR AYUDA
                    concepto = "NECESITAS AYUDA? COMUNIQUESE CON:";
                    concepto += "\nELVIN LANDETA";
                    concepto += "\nTELF.: 829-786-1902";
                    concepto += "\nEMAIL: ej.LandetaR@GMail.com";
                    AgregarNotificacion(concepto, Notificacion.TipoNotificacion.Help, 0, "");

                    //AGREGAMOS LAS NOTIFICACIONES
                    AgregarSysNotificaciones();

                    //GENERAMOS LAS NOTIFICACIONES DEL SISTEMA
                    Thread tNot = new Thread(new ThreadStart(GenerarNotificacionesSYS));
                    tNot.Start();
                    while (!tNot.IsAlive) ;

                    //INICIALIZAMOS LOS PROCESOS
                    objDB.NOMBRE_USUARIO = nombreUsuario;
                    objDB.InicializarProcesos();

                    //Asignamos la oficina por defecto del usuario
                    SSQL = " SELECT TOP 1 * FROM FN_ACCESOS_USUARIOS_X_OFICINAS('" + nombreUsuario + "', 1, 1000)";
                    MyTabla = objDB.GetSQL(SSQL);

                    if (MyTabla.Rows.Count > 0) oficinaID = objDB.GetAsInt("Oficina_Id", MyTabla.Rows[0]);
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Oficina_Id", oficinaID.ToString());
                    MyTabla = objDB.GetAll("VEMPRESAS_OFICINAS", 5, objDB.Filtros);
                    if (MyTabla.Rows.Count > 0) empresaRNC = objDB.GetAsString("Empresa_RNC", MyTabla.Rows[0]);

                    tsmConfigSeparador.Visible = (nombreUsuario == "SYS.ADMIN");
                    tsmConfiOpcionesMenu.Visible = (nombreUsuario == "SYS.ADMIN");
                    tsmConfigModulosCarpetas.Visible = (nombreUsuario == "SYS.ADMIN");
                    tsmConfiReportes.Visible = (nombreUsuario == "SYS.ADMIN");
                    tsmConfigSistema.Visible = (nombreUsuario == "SYS.ADMIN");

                    //Hacemos una Precarga de los Datos
                    GetData();

                    //CARGAMOS EL MENU DEL USUARIO
                    CargarMenuDB();

                    //Creamos el panel de notificaciones
                    CrearPanelNotificaciones();
                                      
                    //GENERAMOS DEMORAS
                    GenerarDemora();

                    //Validamos FECHA DE ULTIMO CIERRE CONTABLE
                    ValidarCierreContable();

                    WindowState = FormWindowState.Maximized;
                    
                    //VALIDAMOS LICENCIA
                    ValidaLicencia();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);

                //CERRAMOS LA APLICACION
                Application.Exit();
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmSelEmpresa.Dispose();

                if (MyTabla != null) MyTabla.Dispose();

                objDB = null;
            }
        }

        void CrearPanelNotificaciones()
        {

            try
            {
                //AGREGAMOS PANEL DE NOTIFICACIONES
                panelNotificaciones.Size = new Size(400, 570);
                panelNotificaciones.AutoScroll = true;
                panelNotificaciones.Visible = false;
                tsbNotf.Visible = false;
                panelNotificaciones.BackColor = Color.Transparent;

                splitContainer1.Panel2.Controls.Add(panelNotificaciones);
                panelNotificaciones.Dock = DockStyle.Right;

                timerNotificaciones.Enabled = true;
                timerNotificaciones.Start();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void notificacionAccion(string nombreControl, int value)
        {
            Control controlN = null;
            Notificacion notif = null;
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            DialogResult resp = DialogResult.Yes;
            try
            {
                Cursor = Cursors.WaitCursor;
                controlN = panelNotificaciones.Controls[nombreControl];
                if (controlN is Notificacion) notif = (Notificacion)controlN;
                if (value < 0)
                {

                    //Marcamos la notificacion como oculta
                    db.NOMBRE_USUARIO = nombreUsuario;
                    if (notif.notificacionId > 0)
                    {
                        resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea ocultar esta notificacion?");
                        if (resp == DialogResult.Yes)
                        {
                            parms.Add(new DataDB_ELR_NET.Parametro("UNotificacion", notif.notificacionId));
                            parms.Add(new DataDB_ELR_NET.Parametro("Usuario", nombreUsuario));
                            db.EjecutarSP("SP_SISTEMAS_SET_NOTIFICACION_OCULTA", parms);
                        }
                    }

                    if (resp == DialogResult.Yes) panelNotificaciones.Controls.Remove(controlN);

                    tsbNotf.Text = "( " + panelNotificaciones.Controls.Count.ToString() + " )";
                    if (panelNotificaciones.Controls.Count <= 0)
                    {
                        tsbNotf.Visible = false;
                        panelNotificaciones.Visible = false;
                    }

                }
                else if (notif.formAEjecutar.Trim() != "") ejecutaForm(notif.formAEjecutar.Trim());
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

        public void AgregarNotificacion(string mensaje, Notificacion.TipoNotificacion tipo, int id = 0, string form = "")
        {
            try
            {
                Notificacion noti = new Notificacion(mensaje, tipo, id, form);
                noti.Dock = DockStyle.Top;
                noti.Name = "noti" + panelNotificaciones.Controls.Count.ToString();
                noti.onVerMas += new Notificacion.Enviar(notificacionAccion);
                if (panelNotificaciones.InvokeRequired)
                {
                    panelNotificaciones.Invoke((Action)delegate
                    {
                        panelNotificaciones.Controls.Add(noti);
                        panelNotificaciones.Visible = true;
                        if (objUtil.GetCountFormOpen() <= 1) noti.Focus();
                        tsbNotf.Visible = true;
                        tsbNotf.Text = "( " + panelNotificaciones.Controls.Count.ToString() + " )";

                    });
                }
                else
                {
                    panelNotificaciones.Controls.Add(noti);
                    panelNotificaciones.Visible = true;
                    if (objUtil.GetCountFormOpen() <= 1) noti.Focus();
                    tsbNotf.Visible = true;
                    tsbNotf.Text = "( " + panelNotificaciones.Controls.Count.ToString() + " )";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GenerarNotificacionesSYS()
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                temporalId = objUtil.GetTemporalID();
                db.NOMBRE_USUARIO = nombreUsuario;
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                db.EjecutarSP("SP_SISTEMA_GENERAR_NOTIFICACIONES", parms);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public virtual void GenerarDemora()
        {
            string temporalId = "";
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            int fechaId = 0;
            try
            {
                if (REQUIERE_CIERRE_OPERACIONES == false)
                {
                    Cursor = Cursors.WaitCursor;

                    temporalId = objUtil.GetTemporalID();
                    fechaId = objUtil.DateToInt(DateTime.Now.Date);
                    parms.Add(new DataDB_ELR_NET.Parametro("fecha", fechaId));
                    parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                    parms.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalId));

                    db.NOMBRE_USUARIO = nombreUsuario;
                    db.iniciarTransaccion();
                    spReturn = db.EjecutarSP("SP_PROCESOS_GENERAR_DEMORA", parms);
                    if (spReturn > 0) db.confirmarTransaccion();

                }
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


        public virtual void ValidarCierreContable()
        {
            int contabilidadId = 0;
            string SSQL = "";
            DataTable DTData = null;
            DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();
            DateTime fechaActual = DateTime.Now.Date;
            DateTime fechaCierre = DateTime.Now.Date;
            int diferencia = 0;

            try
            {
                SSQL = "SELECT IsNull(Max(Modulo_Id), 0) as Id From TSISTEMA_MODULOS Where EsActivo = 1 and Carpeta like 'CONTABILIDAD%' ";
                DTData = objDB.GetSQL(SSQL);
                contabilidadId = objUtil.GetAsInt("Id", DTData.Rows[0]);

                if (contabilidadId > 0)
                {
                    SSQL = " SELECT TOP 1 FECHA FROM TCONTA_CONTROL_CIERRE " +
                                " WHERE EsNulo = 0 And Empresa_Id = " + empresaID.ToString() +
                                " Order by Fecha Desc";
                    DTData = objDB.GetSQL(SSQL);

                    if (DTData.Rows.Count <= 0)
                    {
                        SSQL = " SELECT TOP 1 FECHA FROM TCONTA_DIARIO " +
                               " WHERE EsNulo = 0 And Empresa_Id = " + empresaID.ToString() +
                               " Order by Fecha ";
                        DTData = objDB.GetSQL(SSQL);
                    }

                    if (DTData.Rows.Count > 0) fechaCierre = objDB.GetAsDate("Fecha", DTData.Rows[0]);

                    SSQL = "SELECT DATEDIFF(dd, '" + objDB.DateToInt(fechaCierre) + "', '" + objDB.DateToInt(fechaActual) + "' ) as Diferencia";
                    DTData = objDB.GetSQL(SSQL);

                    diferencia = Math.Abs(objUtil.GetAsInt("Diferencia", DTData.Rows[0]));

                    if (diferencia >= 7)
                    {
                        AgregarNotificacion("HAN TRANSCURRIDO " + diferencia.ToString() + " DIA(S) DESDE EL ULTIMO CIERRE CONTABLE, FAVOR REALIZAR CIERRE DIARIO O MENSUAL", Notificacion.TipoNotificacion.Warning);
                    }




                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Validar Cierre Contable, " + ex.Message);
            }
        }

        public void ValidaLicencia()
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();

            try
            {
                esDemo = true;
                serialNumero = objUtil.GetSerialNumber();
                db.ValidarLicense(serialNumero, empresaRNC, "WIN32");
                diasLimiteSinLicensia = db.GetDiasRestanteSinLicencias();
                esDemo = diasLimiteSinLicensia <= 15;
                
                //MOSTRAMOS LA ACTIVACION DE LA LICENCIA
                if (tsmRegistrarLicencia.Enabled && diasLimiteSinLicensia <= 15)
                {
                    tsmRegistrarLicencia.PerformClick();
                    
                    //MANDAMOS UN CORREO CON LOS DATOS DE INICIO DE SESSION
                    Thread tAux = new Thread(new ThreadStart(EnviarCorreoSession));
                    tAux.Start();
                    while (!tAux.IsAlive) ;


                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCambiarContrasena frm = new FormCambiarContrasena();
            try
            {
                frm.nombreUsuario = nombreUsuario;
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

        private void consultasYoReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultasGlobal frm = new FormConsultasGlobal();
            string variableValor = "";
            bool esFactura = false;

            try
            {
                variableValor = objUtil.GetValorVariable("MOSTRAR_COLUMNA_FACTURA", DTVariablesSYS, "false").Trim().ToUpper();
                esFactura = (variableValor == "TRUE") || (variableValor == "1");


                frm.nombreUsuario = nombreUsuario;
                frm.DTOficina = DTEmpresaOficina;
                frm.empresaId = empresaID;
                frm.oficinaId = oficinaID;
                frm.esFactura = esFactura;
                frm.nombreEmpresa = nombreEmpresa;
                frm.nombreOficina = nombreOficina;
                frm.DTLicencias = DTLicencias;
                frm.DSDataGlobal = DSDataGlobal;
                frm.DTVariablesSYS = DTVariablesSYS;

                frm.DTMenuPrincipal = DTMenuPrincipal;
                frm.DTOpcionesMenu = DTMenu;

                frm.Show();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }


        }

        private void tsmConfigSistema_Click(object sender, EventArgs e)
        {
            FormConfigSys frm = new FormConfigSys();
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            string valorVariable = "";
            try
            {
                if (nombreUsuario.Trim().ToUpper() == "SYS.ADMIN")
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.ShowDialog();

                    //CARGAMOS EN UN DataTable las Variables del sistema
                    DTVariablesSYS = db.GetAll("TSISTEMA_VARIABLES");

                    //MOSTRAR MENU VERTICAL
                    valorVariable = objUtil.GetValorVariable("MOSTRAR_MENU_VERTICAL", DTVariablesSYS, "false").Trim().ToUpper();
                    MOSTRAR_MENU_VERTICAL = (valorVariable == "TRUE") || (valorVariable == "1");
                    valorVariable = "";
                    splitContainer1.Panel1Collapsed = !MOSTRAR_MENU_VERTICAL;

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
                db = null;
            }
        }

        private void GetInfoSys()
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            DataTable DTCajaAbierta = null;
            DataRow filaOficina = null;
            string imagenLogoSys = "";
            string imagenFondoSys = "";
            string telf2 = "";
            string lineaNo = "0";
            DataTable DTData = null;
            string cadena = "";

            try
            {
                lineaNo = "1";
                db.LimpiarFiltros();
                lineaNo = "2";

                if (objUtil == null) objUtil = new ELRUtils();
                lineaNo = "3";

                db.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                db.AddFiltroIgualA("Oficina_Id", oficinaID.ToString());
                lineaNo = "5";

                DTData = db.GetAll("VEMPRESAS_OFICINAS", 1, db.Filtros);
                lineaNo = "6";



                if (DTData.Rows.Count > 0)
                {
                    lineaNo = "7";

                    filaOficina = DTData.Rows[0];

                    nombreEmpresa = filaOficina["Empresa_Nombre"].ToString().ToUpper();
                    nombreOficina = filaOficina["Nombre"].ToString().ToUpper();

                    fechaTrabajo = objUtil.GetAsDate("fecha_Trabajo", filaOficina);

                    //fechaTrabajo = (DateTime)filaOficina["Fecha_Trabajo"];
                    emailEmpresa = objUtil.GetAsString("EMail", filaOficina);

                    telefonosEmpresa = objUtil.GetAsTelefono("Telefono1", filaOficina);
                    telf2 = objUtil.GetAsTelefono("Telefono2", filaOficina);

                    if (telf2.Trim() != "") telefonosEmpresa += ",  " + telf2;

                    this.Text = nombreEmpresa + ", " + nombreOficina;

                    tslFechaOperaciones.Text = "FECHA OPERACIONES: " + objUtil.DateToStr(fechaTrabajo);
                    tslFechaLetra.Text = "  " + fechaTrabajo.ToLongDateString().ToUpper();
                    tslNumeroSerial.Text = "NUMERO SERIAL: " + objUtil.GetSerialNumber();

                    imagenLogoSys = filaOficina["Imagen_Logo_Sys"].ToString();
                    imagenFondoSys = filaOficina["Imagen_Fondo_Sys"].ToString();

                    //COLOCAMOS EL LOGO
                    /* pnLogo.Visible = false;
                     if (imagenLogoSys.Trim() != "")
                     {
                         imagenLogoSys = dirImage.ToString() + @"\" + imagenLogoSys;
                         if (File.Exists(imagenLogoSys))
                         {
                             ptbLogo.Image = Image.FromFile(imagenLogoSys);
                             pnLogo.Visible = true;
                         }
                     }*/

                    //COLOCAMOS IMAGEN DE FONDO SI ESTA CONDIGURADA
                    this.BackgroundImage = null;
                    if (imagenFondoSys.Trim() != "")
                    {
                        imagenFondoSys = dirImage.ToString() + @"\" + imagenFondoSys;
                        if (File.Exists(imagenFondoSys))
                        {
                            this.BackgroundImageLayout = ImageLayout.Stretch;
                            this.BackgroundImage = Image.FromFile(imagenFondoSys);

                            splitContainer1.BackgroundImage = Image.FromFile(imagenFondoSys);
                            splitContainer1.Panel2.BackgroundImage = Image.FromFile(imagenFondoSys);

                        }
                    }

                }


               
                lineaNo = "2";

                //Buscamos si el usuario tiene alguna caja abierta
                db.LimpiarFiltros();
                db.AddFiltroIgualA("Usuario_En_Caja", nombreUsuario);
                DTCajaAbierta = db.GetAll("TCAJAS", 1, db.Filtros);
                if (DTCajaAbierta.Rows.Count > 0)
                {
                    cajaNo = objUtil.GetAsInt("Caja_Id", DTCajaAbierta.Rows[0]);
                    this.Text += ", CAJA NO.: " + cajaNo.ToString();
                    tslCajaNo.Text = "CAJA NO.: " + cajaNo.ToString();
                    tslCajaNo.Visible = true;
                }
                else tslCajaNo.Visible = false;

                lineaNo = "-1";

                cadena = tslNombreUsuario.Text + " " + tslFechaOperaciones.Text + " " + tslFechaLetra.Text + " " + tslNumeroSerial.Text + " " + tslCajaNo.Text;
                toolTip1.SetToolTip(statusStrip1, cadena);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error GetInfoSys, " + ex.Message + ", Ultima Linea = " + lineaNo);
            }
            finally
            {
                esInicio = false;
                this.Cursor = Cursors.Default;
                db = null;
                filaOficina = null;
            }

        }

        void EnviarCorreoSession()
        {
            Correos MyCorreo = new Correos();
            string mensaje = "", miClave = "";
            DataSet ds = new DataSet();
            
            try
            {
                ds.ReadXml(System.Environment.CurrentDirectory + @"\ELRDataDBConfig.xml");
                miClave = objUtil.GetAsString("cc1SGP8", ds.Tables[0].Rows[0]);
                miClave = objUtil.desencriptar(miClave);
                MyCorreo.SetCredenciales("developerlr86@gmail.com", miClave);
                MailMessage mnsj = new MailMessage();

                if (nombreEmpresa.Trim() != "") mnsj.Subject = nombreEmpresa + "(INICIO DE SESSION CON VERSION DEMO)";
                else mnsj.Subject = "INICIO DE SESSION CON VERSION DEMO";

                mnsj.To.Add(new MailAddress("developerlr86@gmail.com"));
                mnsj.To.Add(new MailAddress("Ej.LandetaR@GMail.com"));
                mnsj.To.Add(new MailAddress("yahiris1987@gmail.com"));


                if (objUtil.ValidaEMail(emailEmpresa)) mnsj.From = new MailAddress(emailEmpresa, nombreEmpresa);
                else mnsj.From = new MailAddress("developerlr86@gmail.com", nombreEmpresa);

                mnsj.Body = "Serial No. " + serialNumero + "\n" +
                            "Empresa: " + nombreEmpresa + ", " + nombreOficina + "\n" +
                            "Telefonos: " + telefonosEmpresa + "\n" +
                            "Usuario: " + nombreUsuario + "\n" +
                            "Dias Limite: " + diasLimiteSinLicensia.ToString();


                MyCorreo.MandarCorreo(mnsj);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

        }


        private void ptbLogo_DoubleClick(object sender, EventArgs e)
        {
            tsmConfigSistema.PerformClick();
        }

        private void ELRFormPrincipal_Activated(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            DateTime fechaProceso = DateTime.Now.Date;
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            FormGenerarProcesosSys frm = new FormGenerarProcesosSys();

            try
            {
                if (loginOK)
                {
                    //Validamos la fecha de trabajo
                    db.GetFechasOficina();
                    fechaTrabajo = db.FECHA_TRABAJO;

                    if (db.DateToInt(db.FECHA_TRABAJO) < db.DateToInt(fecha) && db.DateToInt(feUltValidacion) < db.DateToInt(fecha))
                    {
                        feUltValidacion = fecha;
                    }
                    esInicio = false;
                    GetInfoSys();

                }
            }
            catch (Exception)
            {


            }
            finally
            {
                frm.Dispose();
                db = null;
            }
        }

        private void tsmConfiReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            try
            {
                if (nombreUsuario.Trim().ToUpper() == "SYS.ADMIN")
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                }
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

        private void tsmConfigModulosCarpetas_Click(object sender, EventArgs e)
        {
            FormModulos frm = new FormModulos();

            try
            {
                if (nombreUsuario.Trim().ToUpper() == "SYS.ADMIN")
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                }
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

        private void tsmConfiOpcionesMenu_Click(object sender, EventArgs e)
        {
            FormOpcionesMenus frm = new FormOpcionesMenus();

            try
            {
                if (nombreUsuario.Trim().ToUpper() == "SYS.ADMIN")
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EnEjecusion = true;
                    frm.DSGlobal = DSDataGlobal;

                    frm.ShowDialog();
                }
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

        public virtual void GetData()
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            string valorVariable = "";
            string cultura = "ES";
            DataTable DTTipoNot;

            try
            {

                //Cargamos las Oficinas de la Empresa
                DTOficinas = db.GetById("TEMPRESAS_OFICINAS", empresaID.ToString(), "Empresa_Id");

                //BUSCAMOS LA CULTURA A USAR POR EL SISTEMA
                cultura = objUtil.GetValorVariable("CULTURA", DTVariablesSYS, "ES");
                Thread.CurrentThread.CurrentCulture = new CultureInfo(cultura.Trim());



            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error GetData Principal, " + ex.Message);
            }
        }

        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarBK();
        }

        public void RealizarBK()
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            int resultado = -1;
            string pathBK = "";
            ELRFormMensajeErrores frmErrores = new ELRFormMensajeErrores();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                pathBK = objUtil.GetValorVariable("BACKUP_PATH", DTVariablesSYS);

                temporalId = objUtil.GetTemporalID();

                parametros.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalId));
                parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                resultado = db.EjecutarSP("SP_REALIZAR_BACKUP", parametros);

                if (resultado < 0)
                {
                    frmErrores.TemporalId = temporalId;
                    frmErrores.objDB = db;
                    frmErrores.ShowDialog();

                }

                if (resultado > 0) objUtil.MostrarMensajeInformacion("BACKUP REALIZADO DE FORMA SATISFACTORIA EN " + pathBK.ToUpper());

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmErrores.Dispose();
                db = null;
            }
        }

        private void ELRFormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            int ultimoBK = 0;
            DialogResult resp;
            TimeSpan hora, hora2;
            DateTime fechaActual = DateTime.Now;

            try
            {
                ultimoBK = db.GetIdUltimoBK();
                if (ultimoBK < db.DateToInt(fechaActual))
                {
                    hora = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);
                    hora2 = new TimeSpan(17, 0, 0);

                    if (hora > hora2)
                    {
                        resp = objUtil.MostrarMensajePregunta("Desea Realizar Backup Ahora?");

                        if (resp == DialogResult.Yes) RealizarBK();
                    }
                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);

            }
            finally
            {
                db = null;
            }
        }

        private void registrarLicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarLicencia frm = new FormRegistrarLicencia();
            try
            {
                frm.mensaje = "SU LICENCIA EXPIRA EN (" + diasLimiteSinLicensia.ToString() + ") DIAS";

                frm.nombreUsuario = nombreUsuario;
                frm.cedulaRNC = empresaRNC;
                frm.ShowDialog();
               

                if (frm.lOK) ValidaLicencia();
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

        private void trvMenu_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = null;
            string valor = "";

            try
            {
                if (trvMenu.Nodes.Count > 0)
                {
                    node = trvMenu.SelectedNode;


                    if (node.Tag != null)
                    {
                        valor = node.Tag.ToString().Trim();
                        nombreMenu = node.Text;
                        if (valor != "") ejecutaForm(valor, nombreMenu);
                    }
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(244, 212, 66);

        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }





        private void btnFlpClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string valor = "";

            try
            {
                if (btn.Tag != null)
                {
                    valor = btn.Tag.ToString().Trim();
                    nombreMenu = btn.Text;
                    if (valor != "") ejecutaForm(valor, nombreMenu);
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }


        private void ELRFormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            //CTRL + R = Mostrar Conssultas y/o Reportes 
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyCode == Keys.R)) consultasYoReportesToolStripMenuItem.PerformClick();

            //ALT + F4 = SALIR(CERRAR LA APLICACION)
            if ((Control.ModifierKeys == Keys.Alt) && (e.KeyCode == Keys.F4)) salirToolStripMenuItem.PerformClick();
        }

        private void queryDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryDB frm = new FormQueryDB();
            try
            {
                frm.nombreUsuario = nombreUsuario;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cambiarDeOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectOficina frm = new FormSelectOficina();
            try
            {
                frm.nombreUsuario = nombreUsuario;
                frm.empresaID = empresaID;
                frm.EnEjecusion = true;

                frm.ShowDialog();
                oficinaID = frm.oficinaID;
                GetInfoSys();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void tsbConsultas_Click(object sender, EventArgs e)
        {
            consultasYoReportesToolStripMenuItem.PerformClick();
        }

        private void tsbBarraBtn_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = null;
            try
            {
                if (!(sender is ToolStripButton)) return;
                btn = (ToolStripButton)sender;
                if (btn.Tag == null) return;
                else ejecutaForm(btn.Tag.ToString());

            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem.PerformClick();

        }

        private void opcionesImpresionDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpcionesImpCaja frm = new FormOpcionesImpCaja();
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            try
            {
                frm.nombreUsuario = nombreUsuario;
                frm.DTVariables = DTVariablesSYS;
                frm.ShowDialog();

                if (frm.lOK)
                {
                    //CARGAMOS EN UN DataTable las Variables del sistema
                    DTVariablesSYS = db.GetAll("TSISTEMA_VARIABLES");
                }
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

        private void timerNotificaciones_Tick(object sender, EventArgs e)
        {
            try
            {
                //MOSTRAMOS LAS NOTIFICACIONES DEL SISTEMA
                Thread tNot = new Thread(new ThreadStart(AgregarSysNotificaciones));
                tNot.Start();
                while (!tNot.IsAlive) ;
                timerNotificaciones.Interval = 600000;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbNotf_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelNotificaciones != null) panelNotificaciones.Visible = !panelNotificaciones.Visible;
                if (panelNotificaciones.Visible && panelNotificaciones.Controls.Count > 0)
                {
                    panelNotificaciones.Controls[panelNotificaciones.Controls.Count - 1].Focus();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSplash frm = new FormSplash();
            try
            {
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

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            
        }
    }
}
