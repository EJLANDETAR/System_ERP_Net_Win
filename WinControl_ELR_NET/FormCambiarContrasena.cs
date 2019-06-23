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
    public partial class FormCambiarContrasena : Form
    {

        public string nombreUsuario;

        public FormCambiarContrasena()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCambiarContrasena_Load(object sender, EventArgs e)
        {
            txtClaveActual.CharacterCasing = CharacterCasing.Normal;
            txtClaveNueva.CharacterCasing = CharacterCasing.Normal;
            txtConfirmar.CharacterCasing = CharacterCasing.Normal;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ELRUtils objUtil = new ELRUtils();
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();

            string claveActual = "";
            string claveNueva = "";
            string confirmar = "";

            bool valido = false;
            
            try
            {
                claveActual = txtClaveActual.Text.Trim();
                claveNueva = txtClaveNueva.Text.Trim();
                confirmar = txtConfirmar.Text.Trim();
                
                //Validamos Haya Digitado Claves
                if (claveActual == "") 
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Digitar la Clave Actual");
                    txtClaveActual.Focus();
                }
                else if (claveNueva == "")
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Digitar la Nueva Clave");
                    txtClaveNueva.Focus();
                }
                else if (confirmar == "")
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Confirmar la Nueva Clave");
                    txtConfirmar.Focus();
                }
                else if (claveActual == claveNueva)
                {
                    objUtil.MostrarMensajeAdvertencia("La Nueva Clave Debe Ser Diferente a la Clave Actual");
                    txtClaveNueva.Focus();
                }
                else
                {
                    if (claveNueva.Length < 6) throw new Exception("La clave debe tener minimo 6 caracteres");
                    
                    //Validamos la Calve Nueva Debe ser Diferente a la Actual

                    if (nombreUsuario.ToUpper() == "SYS.ADMIN")
                    {
                        valido = objUtil.ValidarClave(claveNueva);
                    }
                    

                    if (valido)
                    {
                        if (claveNueva == confirmar)
                        {
                            valido = (db.CambiarClaveUsuario(nombreUsuario, claveActual, claveNueva) > 0);
                            if (valido == false) objUtil.MostrarMensajeAdvertencia(db.MENSAJE);
                        }
                        else
                        {
                            valido = false;
                            objUtil.MostrarMensajeAdvertencia("Las Claves no Coinciden");
                            txtConfirmar.Focus();
                        }
                    }

                    if (valido)
                    {
                        objUtil.MostrarMensajeInformacion("Clave o Password Cambiado de Forma Satisfactoria...");
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);
                
            }
            finally
            {
                objUtil = null;
                db = null;
            }
        }
    }
}
