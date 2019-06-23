using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormRegistrarLicencia : Form
    {

        public string mensaje = "";
        public string nombreUsuario = "";
        public string cedulaRNC = "";
        public bool lOK = false;

        ELRUtils util = new ELRUtils();
        string serialNumero = "";

        public FormRegistrarLicencia()
        {
            InitializeComponent();
        }

        private void FormRegistrarLicencia_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = mensaje;
                txtNumeroSerial.CharacterCasing = CharacterCasing.Normal;
                txtCodigoActivacion.CharacterCasing = CharacterCasing.Normal;

                serialNumero = util.GetSerialNumber();
                txtNumeroSerial.Text = serialNumero;
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = "";
            string codigoActivacion = "", tipo = "";
            string temporalId = "";
            string[] miArray;
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();
            int resultado = -1;

            try
            {
                codigoActivacion = util.desencriptar(txtCodigoActivacion.Text.Trim());
                miArray = codigoActivacion.Split('|');
                codigoActivacion = miArray[0];
                if (miArray.Length >= 3) tipo = miArray[2].ToUpper();
                tipo = tipo.Replace("\0", "").Trim();
                codigoActivacion = codigoActivacion.Replace("\0", "").Trim();
                codigoActivacion = codigoActivacion.Replace("-", "");
                cedulaRNC = cedulaRNC.Replace("-", "");
                
                lOK = false;

                if (serialNumero.Trim() == "" && cedulaRNC.Trim() == "") util.MostrarMensajeAdvertencia("El Sistema no ha Podido Identificar el Numero de Serial ...");
                else if (codigoActivacion == "")
                {
                    util.MostrarMensajeAdvertencia("Debe Digitar Codigo de Activacion ...");
                    txtCodigoActivacion.Focus();
                }
                else if ( (serialNumero != codigoActivacion && cedulaRNC != codigoActivacion) || tipo != "WIN32")
                {
                    util.MostrarMensajeError("Codigo de Activacion Invalido ...");
                    txtCodigoActivacion.Focus();
                }
                else
                {
                    //PROCEDEMOS A REGISTRAR EL CODIGO DE ACTIVACION
                    this.Cursor = Cursors.WaitCursor;
                    if (codigoActivacion == cedulaRNC) serialNumero = cedulaRNC + "WIN32";

                    codigoActivacion = txtCodigoActivacion.Text;
                    temporalId = util.GetTemporalID();
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("SerialNumero", serialNumero));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("CodigoActivacion", codigoActivacion));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    db.iniciarTransaccion();
                    resultado = db.EjecutarSP("SP_SISTEMA_REGISTRAR_LICENCIA", MyParametros);
                    if (resultado < 0)
                    {
                        //MOSTRAMOS MENSAJE DE ERRORES
                        objMsgERRORES.TemporalId = temporalId;
                        objMsgERRORES.objDB = db;

                        objMsgERRORES.ShowDialog();
                    }
                    else
                    {
                        db.confirmarTransaccion();
                        util.MostrarMensajeInformacion("Datos Registrado de Forma Satisfactoria ...");
                        lOK = true;
                        Close();
                    }


                }
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                db.cancelarTransaccion();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
