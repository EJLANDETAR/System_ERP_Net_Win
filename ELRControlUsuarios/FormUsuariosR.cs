using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRControlUsuarios
{
    public partial class FormUsuariosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormUsuariosR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            
            try
            {
                resultado = base.GetData();

                txtNombreUsuario.Enabled = ((VALOR_ID == "") || (VALOR_ID == "0"));
                txtClave.CharacterCasing = CharacterCasing.Normal;
                txtConfirmarClave.CharacterCasing = CharacterCasing.Normal;


                if (resultado)
                {
                    gbContrasena.Visible = esNuevo;     
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                this.Close();
            }

            return resultado;
        }

        public override bool EjecutaOtros()
        {
            bool resultado = false;
            string clave, confirma;

            ELRLogicaNegocio.Usuarios objUsuario = new ELRLogicaNegocio.Usuarios();
            try
            {
                resultado = base.EjecutaOtros();
                if ( (resultado) && (esNuevo) && (gbContrasena.Visible) )
                {
                    //VALIDAMOS LA CONTRASENA
                    clave = txtClave.Text.Trim();
                    confirma = txtConfirmarClave.Text.Trim();

                    if (clave.Length < 8)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeAdvertencia("La Clave Debe Tener Minimo 8 Caracteres");
                    }

                    if ((resultado) && (!clave.Equals(confirma)))
                    {
                        resultado = false;
                        objUtil.MostrarMensajeAdvertencia("Las Claves No Coinciden");
                    }
                    
                    //INDICAMOS LA CONTRASENA
                    if(resultado) resultado = ( objUsuario.SetClave(objDB, txtNombreUsuario.Text.Trim(), txtClave.Text.Trim()) > 0 );
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                objUsuario = null;
            }

            return resultado;
        }

        public override int GrabarDatos()
        {
            int resultado = -1;

            try
            {
                SetValorEncabezado("Tipo_Interop", "MSO");
                
                resultado = base.GrabarDatos();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

    }
}
