using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRControlUsuarios
{
    public partial class FormUsuarioResetearPassword : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormUsuarioResetearPassword()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            try
            {
                 //return base.GetData();
                lblUsuario.Text = VALOR_ID;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;

        }

        public override int GrabarDatos()
        {
            int resultado = 0;
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                //return base.GrabarDatos();
                if (txtPassword.Text.Trim() == "")
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Ingresar el Password ...");
                    txtPassword.Focus();
                }
                else if (txtConfirmar.Text.Trim() == "")
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Confirmar el Password ...");
                    txtConfirmar.Focus();
                }
                else if( txtConfirmar.Text.Trim() != txtPassword.Text.Trim() )
                {
                    objUtil.MostrarMensajeAdvertencia("El Password no Coinciden ...");
                    txtConfirmar.Focus();
                }
                else if ( objUtil.ValidarClave(txtPassword.Text.Trim()) )
                {
                    this.Cursor = Cursors.WaitCursor;
                    
                    temporalID = objUtil.GetTemporalID();
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Usuario", VALOR_ID));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Clave", txtPassword.Text.Trim()));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_RESETEAR_PASSWORD", MyParametros);
                    if (resultado < 0)
                    {
                        MostrarErrorTemporal();
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        objDB.confirmarTransaccion();
                        objUtil.MostrarMensajeInformacion("Password Cambiado de Forma Satisfactoria ...");
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
                this.Cursor = Cursors.Default;
                objDB.cancelarTransaccion();
            }

            return resultado;
        }

        private void FormUsuarioResetearPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

    }
}
