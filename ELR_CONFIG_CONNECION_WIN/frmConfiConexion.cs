using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;
using ELR_ConfigConn;

namespace ConfigConexion
{
    public partial class frmConfiConexion : Form
    {

        ConfiConn objConf = new ConfiConn();

        public frmConfiConexion()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (MessageBox.Show("¿Esta seguro que desea actualizar la Configuración?", "Configurar Conexión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                objConf.GestorBD = cboGestorDB.Text.Trim();
                objConf.NombreServidor = txtNombreServer.Text.Trim();
                objConf.NombreBD = txtDatabase.Text.Trim();
                objConf.NombreUsuario = txtUsuario.Text.Trim();
                objConf.Password = txtPassWord.Text;
                objConf.Puerto = txtPuerto.Text.Trim();
                objConf.NombreDominio = txtNombreDominio.Text.Trim();
                objConf.FormaInicioSession = cboFormaInicioSession.SelectedIndex.ToString();

                if (objConf.probarConeccionMSSQL())
                {

                    if (objConf.gravarDatosConeccion())
                    {

                        MessageBox.Show("Configuración Actualizada de Forma Satisfactoria", "Configuración Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Gravar Datos de Conección: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConfiConexion_Load(object sender, EventArgs e)
        {
            string nombreArchivo = "";
            try
            {
                nombreArchivo = Application.StartupPath + @"\ELRDataDBConfig.xml";
                if(File.Exists(nombreArchivo))
                {
                    txtNombreArchivo.Text = nombreArchivo;
                    MostrarDatosConfig(nombreArchivo);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosConfig(string archivoConfig)
        {
            int FormaInicioSession = 1;

            try
            {

                objConf.cargarDatosConnecion(archivoConfig);

                cboGestorDB.Text = objConf.GestorBD;
                txtNombreServer.Text = objConf.NombreServidor;
                txtDatabase.Text = objConf.NombreBD;
                txtUsuario.Text = objConf.NombreUsuario;
                txtPassWord.Text = objConf.Password;
                txtPuerto.Text = objConf.Puerto;
                txtNombreDominio.Text = objConf.NombreDominio;

                if (!int.TryParse(objConf.FormaInicioSession, out FormaInicioSession)) FormaInicioSession = 1;
                cboFormaInicioSession.SelectedIndex = FormaInicioSession;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Cargar Datos de Conección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            objConf.GestorBD = cboGestorDB.Text;
            objConf.NombreServidor = txtNombreServer.Text;
            objConf.NombreBD = txtDatabase.Text;
            objConf.NombreUsuario = txtUsuario.Text;
            objConf.Puerto = txtPuerto.Text;

            if (cboGestorDB.Text == "MS SQL SERVER")
            {
                ProbarConexionMSServer();
            }

            if (cboGestorDB.Text == "My SQL SERVER")
            {
                ProbarConexionMySQLServer();
            }

        }

        public void cargarXML(ref DataSet ds, string nombreXML)
        {
            try
            {
                if (File.Exists(nombreXML))
                {
                    ds.ReadXml(nombreXML);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool guardarXML(ref DataSet ds, string nombreXML)
        {
            bool Resultado = false;
            try
            {
                ds.WriteXml(nombreXML);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Resultado;
        }

        public string encriptar(string cadena, string clave)
        {
            // Convierto la cadena y la clave en arreglos de bytes
            // para poder usarlas en las funciones de encriptacion
            byte[] cadenaBytes = Encoding.UTF8.GetBytes(cadena);
            byte[] claveBytes = Encoding.UTF8.GetBytes(clave);

            // Creo un objeto de la clase Rijndael
            RijndaelManaged rij = new RijndaelManaged();

            // Configuro para que utilice el modo ECB
            rij.Mode = CipherMode.ECB;

            // Configuro para que use encriptacion de 256 bits.
            rij.BlockSize = 256;

            // Declaro que si necesitara mas bytes agregue ceros.
            rij.Padding = PaddingMode.Zeros;

            // Declaro un encriptador que use mi clave secreta y un vector
            // de inicializacion aleatorio
            ICryptoTransform encriptador;
            encriptador = rij.CreateEncryptor(claveBytes, rij.IV);

            // Declaro un stream de memoria para que guarde los datos
            // encriptados a medida que se van calculando
            MemoryStream memStream = new MemoryStream();

            // Declaro un stream de cifrado para que pueda escribir aqui
            // la cadena a encriptar. Esta clase utiliza el encriptador
            // y el stream de memoria para realizar la encriptacion
            // y para almacenarla
            CryptoStream cifradoStream;
            cifradoStream = new CryptoStream(memStream, encriptador, CryptoStreamMode.Write);

            // Escribo los bytes a encriptar. A medida que se va escribiendo
            // se va encriptando la cadena
            cifradoStream.Write(cadenaBytes, 0, cadenaBytes.Length);

            // Aviso que la encriptación se terminó
            cifradoStream.FlushFinalBlock();

            // Convert our encrypted data from a memory stream into a byte array.
            byte[] cipherTextBytes = memStream.ToArray();

            // Cierro los dos streams creados
            memStream.Close();
            cifradoStream.Close();

            // Convierto el resultado en base 64 para que sea legible
            // y devuelvo el resultado
            return Convert.ToBase64String(cipherTextBytes);
        }

        public string desencriptar(string cadena, string clave)
        {
            // Convierto la cadena y la clave en arreglos de bytes
            // para poder usarlas en las funciones de encriptacion
            // En este caso la cadena la convierta usando base 64
            // que es la codificacion usada en el metodo encriptar
            byte[] cadenaBytes = Convert.FromBase64String(cadena);
            byte[] claveBytes = Encoding.UTF8.GetBytes(clave);

            // Creo un objeto de la clase Rijndael
            RijndaelManaged rij = new RijndaelManaged();

            // Configuro para que utilice el modo ECB
            rij.Mode = CipherMode.ECB;

            // Configuro para que use encriptacion de 256 bits.
            rij.BlockSize = 256;

            // Declaro que si necesitara mas bytes agregue ceros.
            rij.Padding = PaddingMode.Zeros;

            // Declaro un desencriptador que use mi clave secreta y un vector
            // de inicializacion aleatorio
            ICryptoTransform desencriptador;
            desencriptador = rij.CreateDecryptor(claveBytes, rij.IV);

            // Declaro un stream de memoria para que guarde los datos
            // encriptados
            MemoryStream memStream = new MemoryStream(cadenaBytes);

            // Declaro un stream de cifrado para que pueda leer de aqui
            // la cadena a desencriptar. Esta clase utiliza el desencriptador
            // y el stream de memoria para realizar la desencriptacion
            CryptoStream cifradoStream;
            cifradoStream = new CryptoStream(memStream, desencriptador, CryptoStreamMode.Read);

            // Declaro un lector para que lea desde el stream de cifrado.
            // A medida que vaya leyendo se ira desencriptando.
            StreamReader lectorStream = new StreamReader(cifradoStream);

            // Leo todos los bytes y lo almaceno en una cadena
            string resultado = lectorStream.ReadToEnd();

            // Cierro los dos streams creados
            memStream.Close();
            cifradoStream.Close();

            // Devuelvo la cadena
            return resultado;
        }

        void ProbarConexionMSServer()
        {
            SqlConnection sqlOConn = new SqlConnection();
            SqlConnectionStringBuilder strCadena = new SqlConnectionStringBuilder();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                strCadena.DataSource = txtNombreServer.Text;
                strCadena.InitialCatalog = txtDatabase.Text;
                strCadena.UserID = txtUsuario.Text;
                strCadena.Password = txtPassWord.Text;

                sqlOConn.ConnectionString = strCadena.ToString() + ";Connect Timeout=120";

                sqlOConn.Open();
                MessageBox.Show("Conexión realizada de forma Satisfactoria", "Configurar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlOConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Conexión Fallida: " + ex.Message, "Configurar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void ProbarConexionMySQLServer()
        {
            //MySqlConnection mysqlOConn = new MySqlConnection();
            //MySqlConnectionStringBuilder strCadena = new MySqlConnectionStringBuilder();
            try
            {
                this.Cursor = Cursors.WaitCursor;

               // strCadena.Server = txtNombreServer.Text;
                //strCadena.Database = txtDatabase.Text;
                //strCadena.UserID = txtUsuario.Text;
                //strCadena.Password = txtPassWord.Text;

                //mysqlOConn.ConnectionString = strCadena.ToString();

                //mysqlOConn.Open();
                MessageBox.Show("Conexión realizada de forma Satisfactoria", "Configurar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //mysqlOConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Conexión Fallida: " + ex.Message, "Configurar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Config Files|*.xml";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtNombreArchivo.Text = openFileDialog1.FileName;
                MostrarDatosConfig(txtNombreArchivo.Text);
            }
            
        }

    }
}
