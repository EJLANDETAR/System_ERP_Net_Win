using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormLogin : MetroFramework.Forms.MetroForm
    {

        //DECLARAMOS VARIABLES PUBLICAS
        public bool loginOK = false;
        public string Nombre_Usuario = "";
        public int Session_Id = 0;
        public int FormaInicioSession;

        //VARIABLES PRIVADAS
        ELRUtils objUtil = null;

        public ELRFormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
     
            loginOK = false;
            Close();
        }

        private void ELRFormLogin_Load(object sender, EventArgs e)
        {
            objUtil = new ELRUtils(this);

            loginOK = false;

            txtNombreUsuario.CharacterCasing = CharacterCasing.Normal;
            txtClave.CharacterCasing = CharacterCasing.Normal;

            //txtNombreUsuario.Text = objUtil.nombreUsuarioPC.ToUpper();
            txtNombreUsuario.Text = "";
            if (objUtil.nombreUsuarioPC != "") txtClave.Focus();
            else txtNombreUsuario.Focus();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();

            string Clave = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;
                objDB.timeOut = 90;

                Nombre_Usuario = txtNombreUsuario.Text.Trim().ToUpper();
                Clave = txtClave.Text.Trim();

                if ((Nombre_Usuario == "") || (Clave == "")) objUtil.MostrarMensajeAdvertencia("Debe especificar Nombre de Usuario y Clave o PassWord");
                else if (objDB.ValidarUsuarioPassword(Nombre_Usuario, Clave, objUtil.nombrePC, objUtil.localIP) < 1) objUtil.MostrarMensajeAdvertencia(objDB.MENSAJE);
                else
                {
                   
                    loginOK = true;
                    Close();
                }
            }
            catch (Exception ex)
            {

                loginOK = false;
                objUtil.MostrarMensajeError(ex.Message, "");
            }
            finally
            {

                this.Cursor = Cursors.Default;

                txtClave.Text = "";
                objDB = null;

                if (txtNombreUsuario.Text.Trim() != "") txtClave.Focus();
                else txtNombreUsuario.Focus();
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ELRTextBox txt = null;

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txt = (ELRTextBox)sender;

                    if (txt == txtNombreUsuario)
                    {
                        if (txtNombreUsuario.Text.Trim() != "") txtClave.Focus();
                    }
                    else
                    {
                        if (txtClave.Text.Trim() != "") btnAceptar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                txt = null;
            }

        }

        private void ELRFormLogin_Activated(object sender, EventArgs e)
        {
            txtNombreUsuario.Focus();
        }
    }
}
