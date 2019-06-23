using Microsoft.Reporting.WinForms;
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

namespace WinControl_ELR_NET
{
    public partial class FormConsultasGlobal : Form
    {
        public string nombreUsuario = "";
        public bool esFactura = false;
        public DataTable DTOficina = null;
        public DataTable DTMenuPrincipal = null;
        public DataTable DTOpcionesMenu = null, DTVariablesSYS = null, DTOficinas = null;
        public DataTable DTLicencias = null;
        public DataSet DSDataGlobal;
        public int empresaId = 0, oficinaId = 0;
        public string nombreEmpresa, nombreOficina;
        public DateTime fechaTrabajo;

        ELRUtils objUtil = new ELRUtils();
        int menuDefault = -1;

        public FormConsultasGlobal()
        {
            InitializeComponent();
        }

        private void FormConsultasGlobal_Load(object sender, EventArgs e)
        {
            try
            {
                menuDefault = 0;
                tsmNombreUsuario.Text = "USUARIO.: " + nombreUsuario.ToUpper();
                MostrarMenuFlatLayout();

                MostrarMenu();
                if (trvMenu.Nodes.Count == 0) trvMenu.Nodes.Add("Reportes Disponibles");

                cboBuscarPorMenu.DataSource = DTMenuPrincipal.DefaultView;
                cboBuscarPorMenu.SelectedValue = menuDefault;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        void MostrarMenuFlatLayout(string aBuscar = "")
        {
            string menuId, descripcion = "";
            int moduloId = 0;
            string nombreModulo = "", nombreForm = "", tipoForm = "0";
            bool esModal = false;
            DataRow[] filas;
            DataRow fila0;
            int carpetaId = 0;
            bool esMenuConsulta = false;

            try
            {
                flpMenu.Visible = false;
                flpMenu.Controls.Clear();
                aBuscar = aBuscar.Trim();

                if (DTOpcionesMenu == null) return;
                if (DTOpcionesMenu.Rows.Count <= 0) return;

                if (cboBuscarPorMenu.SelectedValue != null) carpetaId = int.Parse(cboBuscarPorMenu.SelectedValue.ToString());

                foreach (DataRow item in DTOpcionesMenu.Rows)
                {
                    menuId = objUtil.GetAsString("Menu_Id", item, "0");
                    descripcion = objUtil.GetAsString("Nombre", item).Trim();
                    moduloId = objUtil.GetAsInt("Modulo_Id", item);
                    esMenuConsulta = objUtil.GetAsBoolean("EsMenuConsulta", item);

                    if (aBuscar != "")
                    {
                        if (!descripcion.ToUpper().Contains(aBuscar)) continue;

                    }

                   
                    if (esMenuConsulta == false && moduloId != 10) continue;
                    if (carpetaId > 0 && moduloId != carpetaId) continue;

                    filas = DTMenuPrincipal.Select("Modulo_Id = " + moduloId.ToString());
                    if (filas.Count() > 0)
                    {
                        fila0 = filas[0];
                        nombreModulo = objUtil.GetAsString("Carpeta", fila0);
                    }

                    Button btn = new Button();
                    btn.Name = "btnFP" + menuId;
                    btn.Text = descripcion;
                    descripcion = nombreModulo + " => " + descripcion;
                    toolTip1.SetToolTip(btn, descripcion);
                    btn.Width = 120;
                    btn.Height = 100;

                    //ASIGNAMOS EL FORM A EJECUTAR
                    nombreForm = objUtil.GetAsString("Formulario_AEjecutar", item).Trim();
                    esModal = objUtil.GetAsBoolean("EsModal", item);
                    tipoForm = objUtil.GetAsString("TipoFormulario", item);
                    if (nombreForm != "")
                    {

                        nombreForm += ";" + menuId.ToString();
                        if (esModal) nombreForm += ";1;" + tipoForm;
                        else nombreForm += ";0;" + tipoForm;

                        btn.Tag = nombreForm;
                        btn.Click += new EventHandler(btnFlpClick);
                    }

                    btn.MouseLeave += new EventHandler(btnMouseLeave);
                    btn.MouseHover += new EventHandler(btnMouseHover);

                    flpMenu.Controls.Add(btn);
                }

                flpMenu.Visible = true;
            }
            catch (Exception)
            {

                throw;
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
            string nombreMenu = "";
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

        private void cboBuscarPorMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBuscarPorMenu.Text.Trim() != null)
            {
                MostrarMenuFlatLayout(txtBuscarMenu.Text.Trim());
                txtBuscarMenu.Focus();
            }
        }

        private void txtBuscarMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string aBuscar = txtBuscarMenu.Text.Trim();
                MostrarMenuFlatLayout(aBuscar);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsultasGlobal_Activated(object sender, EventArgs e)
        {
            txtBuscarMenu.Focus();
        }

        void ejecutaForm(string valor, string nombreMenu)
        {
            string MyAsembly = "";
            string formulario;
            int menuId = 0;
            int modal = 0;
            string tipoFormulario = "";
            string[] MyArray;
            FormPlantillaIndex frmCons = null;
            ELRFormRegistro frmRegistro = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                MyArray = valor.Split(';');
                formulario = MyArray[0];
                MyAsembly = formulario.Split('.')[0];
                menuId = int.Parse(MyArray[1]);
                modal = int.Parse(MyArray[2]);
                tipoFormulario = MyArray[3].Trim().ToUpper();

                if (tipoFormulario == "C")
                {
                    frmCons = (FormPlantillaIndex)Activator.CreateInstance(MyAsembly, formulario).Unwrap();
                    frmCons.menuId = menuId;
                    frmCons.empresaID = empresaId;
                    frmCons.oficinaID = oficinaId;

                    frmCons.NOMBRE_EMPRESA = nombreEmpresa;
                    frmCons.NOMBRE_OFICINA = nombreOficina;
                    frmCons.nombreUsuario = nombreUsuario;
                    frmCons.FECHA_TRABAJO = fechaTrabajo;

                    frmCons.DTVariablesSYS = DTVariablesSYS;
                    frmCons.DTEmpresaOficinas = DTOficinas;
                    frmCons.DSGlobal = DSDataGlobal;
                                        
                    frmCons.EnEjecusion = true;

                    if (modal > 0) frmCons.ShowDialog();
                    else frmCons.Show();

                }
                else
                {
                    frmRegistro = (ELRFormRegistro)Activator.CreateInstance(MyAsembly, formulario).Unwrap();
                    frmRegistro.EMPRESA_ID = empresaId;
                    frmRegistro.OFICINA_ID = oficinaId;

                    frmRegistro.NOMBRE_EMPRESA_OFICINA = nombreEmpresa;
                    frmRegistro.NOMBRE_OFICINA = nombreOficina;
                    frmRegistro.nombreUsuario = nombreUsuario;
                    frmRegistro.FECHA_TRABAJO = fechaTrabajo;

                    frmRegistro.DTVariablesSYS = DTVariablesSYS;
                    frmRegistro.DSGlobal = DSDataGlobal;

                    frmRegistro.DTLicense = DTLicencias;

                    frmRegistro.EnEjecusion = true;

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

                if ((frmCons != null) && (modal > 0)) frmCons.Dispose();
                if ((frmRegistro != null) && (modal > 0)) frmRegistro.Dispose();
            }
        }

        void MostrarMenu()
        {
            DataView dvData;
            int moduloId = 0;
            string descripcion = "";
            string mnuName = "";
            TreeNode node = null;
            int conteo = 0;
            
            try
            {
                dvData = DTMenuPrincipal.DefaultView;
                
                //if (nombreUsuario.Trim().ToUpper() != "SYS.ADMIN") dvData.RowFilter = MyData.Columns["Modulo_Id"].ColumnName + " = '0'";

                foreach (DataRowView drFilaActual in dvData)
                {
                    moduloId = (int)drFilaActual["Modulo_Id"];
                    

                    descripcion = drFilaActual["Carpeta"].ToString().ToLower();
                    descripcion = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(descripcion);
                    if (moduloId == 10) descripcion = @"Otras Consultas y/o Reportes";
                    mnuName = "mnu" + objUtil.GetNumeroAleatorio().ToString();

                    if (descripcion.ToUpper() == "VENTAS") descripcion = "Ventas (Cuentas Por Cobrar)";
                    if (descripcion.ToUpper().Contains("COMPRAS")) descripcion = "Inventario (Compras, Cuentas Por Pagar)";

                    node = new TreeNode();
                    node.Name = mnuName;
                    node.Text = descripcion;
                    node.ImageIndex = 0;
                    

                    AgregarSubMenu(moduloId, node);


                    trvMenu.Nodes.Add(node);
                    if (node.Nodes.Count <= 0) trvMenu.Nodes.Remove(node);
                    else if(node.Nodes.Count > conteo)
                    {
                        conteo = node.Nodes.Count;
                        menuDefault = moduloId;
                    }                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AgregarSubMenu(int moduloId, TreeNode nodePrincipal)
        {
            DataView dvData = null;
            string mnuName, descripcion;
            string formAEjecutar = "";

            int id = 0;
            bool esModal = true;
            string tipoForm = "C";
            string imageMenu = "";
            TreeNode node = new TreeNode();
            bool esMenuConsulta = false;
            try
            {
                dvData = DTOpcionesMenu.DefaultView;
                dvData.RowFilter = "Modulo_Id = " + moduloId;

                foreach (DataRowView drFilaActual in dvData)
                {
                    id = (int)drFilaActual["Menu_Id"];
                    esMenuConsulta = (bool)drFilaActual["EsMenuConsulta"];

                    if (esMenuConsulta == false && moduloId != 10) continue;
                   
                    descripcion = drFilaActual["Nombre"].ToString();

                    //descripcion = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(descripcion);
                    mnuName = "mnu" + objUtil.GetNumeroAleatorio().ToString();
                    imageMenu = drFilaActual["Image"].ToString();

                    node = new TreeNode();
                    node.Name = mnuName;
                    node.Text = descripcion;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;

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

        private void trvMenu_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = null;
            string valor = "";
            string nombreMenu = "";
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

    }
}
