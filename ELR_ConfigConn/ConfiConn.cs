using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace ELR_ConfigConn
{
    public class ConfiConn
    {
        public string GestorBD, NombreServidor, NombreBD, NombreUsuario, Password, Puerto, FormaInicioSession, NombreDominio;
        private string clave = "$wert#AFT*Y^HBCVG@T1x+45YFTDF&%)";
        private string Configxml;
        private DataSet dscc1SGP = new DataSet();


        public int Asc(string s)
        {
            return Encoding.ASCII.GetBytes(s)[0];
        }

        public char Chr(int c)
        {
            return Convert.ToChar(c);
        }

        private string encriptar(string cadena)
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

        private string desencriptar(string cadena)
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

        public string ENCRIPTAR_DESENCRIPTAR(string cadena, int accion)
        {

            string Resultado = "";

            if (accion == 1) Resultado = encriptar(cadena);   //Encriptamos
            if (accion != 1) Resultado = desencriptar(cadena).Replace("\0", "").Trim();   //DesEncriptamos

            return Resultado;
        }

        public void cargarDatosConnecion(string archivoXML)
        {

            try
            {
                Configxml = archivoXML;

                if (File.Exists(Configxml))
                {
                    dscc1SGP.ReadXml(Configxml);

                    if (dscc1SGP.Tables.Count > 0)
                    {
                        if (dscc1SGP.Tables[0].Rows.Count > 0)
                        {
                            GestorBD = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP0"].ToString(), 2);
                            NombreServidor = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP1"].ToString(), 2);
                            NombreBD = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP2"].ToString(), 2);
                            NombreUsuario = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP3"].ToString(), 2);
                            Password = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP4"].ToString(), 2);
                            Puerto = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP5"].ToString(), 2);
                            FormaInicioSession = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP6"].ToString(), 2);
                            NombreDominio = ENCRIPTAR_DESENCRIPTAR(dscc1SGP.Tables[0].Rows[0]["cc1SGP7"].ToString(), 2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool gravarDatosConeccion()
        {

            bool Resultado = false;
            bool esNuevo = false;
            DataRow dr;

            try
            {

                if (dscc1SGP.Tables[0].Rows.Count <= 0)
                {
                    dr = dscc1SGP.Tables[0].NewRow();
                    esNuevo = true;
                }
                else
                {
                    dr = dscc1SGP.Tables[0].Rows[0];
                }

                dr["cc1SGP0"] = ENCRIPTAR_DESENCRIPTAR(GestorBD, 1);
                dr["cc1SGP1"] = ENCRIPTAR_DESENCRIPTAR(NombreServidor, 1);
                dr["cc1SGP2"] = ENCRIPTAR_DESENCRIPTAR(NombreBD, 1);
                dr["cc1SGP3"] = ENCRIPTAR_DESENCRIPTAR(NombreUsuario, 1);
                dr["cc1SGP4"] = ENCRIPTAR_DESENCRIPTAR(Password, 1);
                dr["cc1SGP5"] = ENCRIPTAR_DESENCRIPTAR(Puerto, 1);
                dr["cc1SGP6"] = ENCRIPTAR_DESENCRIPTAR(FormaInicioSession, 1);
                dr["cc1SGP7"] = ENCRIPTAR_DESENCRIPTAR(NombreDominio, 1);


                if (esNuevo)
                {
                    dscc1SGP.Tables[0].Rows.Add(dr);
                }

                dscc1SGP.WriteXml(Configxml);
                Resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Resultado;
        }

        public bool probarConeccionMSSQL()
        {

            bool Resultado = false;
            SqlConnection objConeccion = new SqlConnection();
            SqlConnectionStringBuilder strCadena = new SqlConnectionStringBuilder();

            try
            {

                strCadena.DataSource = NombreServidor;
                strCadena.InitialCatalog = NombreBD;
                strCadena.UserID = NombreUsuario;
                strCadena.Password = Password;

                objConeccion.ConnectionString = strCadena.ToString() + ";Connect Timeout=120";
                objConeccion.Open();
                Resultado = true;
                objConeccion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                objConeccion.Dispose();
            }

            return Resultado;
        }
    }
}
