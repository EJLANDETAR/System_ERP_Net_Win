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
    public partial class FormConfigSys : Form
    {

        public string nombreUsuario = "";

        ELRUtils objUtil = new ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();

        DataTable DTData = null;
        DataTable DTVariables = null;
        int valorUnico = 0;
        DirectoryInfo dir;
        DataView DVVariables = null;

        public FormConfigSys()
        {
            InitializeComponent();
        }

        private void FormConfigSys_Load(object sender, EventArgs e)
        {
            try
            {
                dir = new DirectoryInfo(Application.StartupPath + @"\images");
                GetData();
                GetVariables();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void GetData()
        {
            string nombreImagenLogo = "";
            string nombreImagenBackGround = "";
            
            try
            {
                db.NOMBRE_USUARIO = nombreUsuario;

                DTData = db.GetAll("TSISTEMA_CONFIG", -1);

                if (DTData.Rows.Count == 0)
                {
                    DTData.Rows.Add(DTData.NewRow());
                    DTData.Rows[0]["Unico"] = 0;
                    DTData.Rows[0]["Logo"] = "";
                    DTData.Rows[0]["BackGround"] = "";

                    valorUnico = 0;
                }
                else
                {
                    valorUnico = int.Parse( DTData.Rows[0]["Unico"].ToString() );
                }

                nombreImagenLogo = DTData.Rows[0]["Logo"].ToString();
                nombreImagenBackGround = DTData.Rows[0]["BackGround"].ToString();

                ptbLogo.Tag = nombreImagenLogo;
                ptbBackGround.Tag = nombreImagenBackGround;

                if (nombreImagenLogo.Trim() != "")
                {
                    nombreImagenLogo = dir.ToString() + @"\" + nombreImagenLogo;
                    if (File.Exists(nombreImagenLogo) ) 
                    {
                        ptbLogo.Image = Image.FromFile(nombreImagenLogo);
                    }
                }

                if (nombreImagenBackGround.Trim() != "")
                {
                    nombreImagenBackGround = dir.ToString() + @"\" + nombreImagenBackGround;
                    if (File.Exists(nombreImagenBackGround))
                    {
                        ptbBackGround.Image = Image.FromFile(nombreImagenBackGround);
                    }
                }

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetVariables()
        {
            try
            {
                DTVariables = db.GetAll("TSISTEMA_VARIABLES", -1);
                mostrarVariables();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void mostrarVariables()
        {
            string filtro = "";
            try
            {
                dtgVariables.AutoGenerateColumns = false;

                DVVariables = DTVariables.DefaultView;
                DVVariables.RowFilter = "";

                filtro = txtBuscarVariable.Text.Trim();
                if (filtro != "") DVVariables.RowFilter = "Variable like '%" + filtro + "%'";

                dtgVariables.DataSource = DVVariables;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private int Guardar()
        {
            int resultado = 0;
            
            try
            {
               

                if (ptbLogo.Tag == null) DTData.Rows[0]["Logo"] = "";
                else DTData.Rows[0]["Logo"] = Path.GetFileName(ptbLogo.Tag.ToString());

                if (ptbBackGround.Tag == null) DTData.Rows[0]["BackGround"] = "";
                else DTData.Rows[0]["BackGround"] = Path.GetFileName(ptbBackGround.Tag.ToString());

                if (valorUnico <= 0) resultado = db.Insertar("TSISTEMA_CONFIG", "Unico", DTData, 0);
                else resultado = db.Actualizar("TSISTEMA_CONFIG", "Unico", DTData, 0);
            }
            catch (Exception ex)
            {
                resultado = -1;
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void SelectImage(object sender, EventArgs e)
        {
            FormSelectImage frm = new FormSelectImage();
            Button btn = null;

            try
            {
                btn = (Button)sender;
                
                frm.ShowDialog();

                if (frm.nombreImagen.Trim() != "")
                {
                    if (btn == btnCambiarLogo)
                    {
                        ptbLogo.Image = Image.FromFile(frm.pathImagen);
                        ptbLogo.Tag = frm.nombreImagen;
                    }
                    else
                    {
                        ptbBackGround.Image = Image.FromFile(frm.pathImagen);
                        ptbBackGround.Tag = frm.nombreImagen;
                    }
                }
                else
                {
                    if (btn == btnCambiarLogo) 
                    {
                        ptbLogo.Image = null;
                        ptbLogo.Tag = "";
                    }
                    else
                    {
                        ptbBackGround.Image = null;
                        ptbBackGround.Tag = "";
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
                btn = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar() > 0) Close();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void EditarVariableClick(object sender, EventArgs e)
        {
            Button btn = null;
            FormVariablesSistema frm = new FormVariablesSistema();
            int index = 0;
            DataRow filaActual = null;

            bool continuar = true;
            int resultado = 0;
            string variable = "";

            try
            {
                btn = (Button)sender;

                if (btn == btnEditarVariable)
                {
                    continuar = false;

                    if (dtgVariables.SelectedRows != null)
                    {
                        index = dtgVariables.CurrentRow.Index;
                        frm.valorUnico = int.Parse(dtgVariables["unicoVariable", index].Value.ToString());

                        filaActual = DTVariables.Select("Unico = " + frm.valorUnico.ToString())[0];

                        variable = filaActual["Variable"].ToString();
                        frm.variable = variable;
                        frm.valor = filaActual["Valor"].ToString();
                        frm.comentario = filaActual["Comentario"].ToString();

                        continuar = true;
                    }
                }
                else if (btn == btnAgregarVariable)
                {
                    filaActual = DTVariables.NewRow();
                    filaActual["Unico"] = 0;
                    filaActual["EsSistema"] = true;
                    filaActual["Modulo"] = "SYS";
                }
                else continuar = false;

                if (continuar)
                {
                    frm.ShowDialog();
                    if (frm.lOK)
                    {
                        variable = frm.variable;
                        filaActual["Variable"] = frm.variable;
                        filaActual["Valor"] = frm.valor;
                        filaActual["Comentario"] = frm.comentario;

                        if (frm.valorUnico == 0)
                        {
                            DTVariables.Rows.Add(filaActual);
                            index = DTVariables.Rows.Count - 1;

                            resultado = db.InsertarFromFila (filaActual, "TSISTEMA_VARIABLES", "Unico");
                        }
                        else resultado = db.UpdateFromRow ("TSISTEMA_VARIABLES", filaActual, "Unico");

                        if (resultado > 0)
                        {
                            GetVariables();
                            IrAVariable(variable);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                DTVariables.RejectChanges();
                objUtil.MostrarMensajeError(ex.Message);
                
            }
        }

        private void dtgVariables_SelectionChanged(object sender, EventArgs e)
        {
            int filaId = 0;
            try
            {
                if (dtgVariables.CurrentRow != null)
                {
                    filaId = dtgVariables.CurrentRow.Index;
                    txtComentarioVariable.Text = dtgVariables["Comentario", filaId].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtBuscarVariable_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                string variable = txtBuscarVariable.Text.Trim();
                mostrarVariables();
                if (e.KeyCode == Keys.Enter && variable != "") IrAVariable(variable);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void IrAVariable(string variable = "")
        {
            string valor = "";
            try
            {
                variable = variable.Trim().Replace(' ', '_');

                if (dtgVariables.RowCount <= 0) return;

                for (int i = 0; i < dtgVariables.RowCount; i++)
                {
                    valor = dtgVariables["Variable", i].Value.ToString().ToUpper().Trim();
                    if(valor.Contains(variable))
                    {
                        dtgVariables.CurrentCell = dtgVariables["Variable", i];
                        txtComentarioVariable.Text = dtgVariables["Comentario", i].Value.ToString();
                        txtBuscarVariable.SelectAll();
                        txtBuscarVariable.Focus();

                        break;
                    }
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) txtBuscarVariable.Focus();
        }
    }
}
