using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Security.Cryptography;
using System.Management;
using System.Threading;
using System.Net.Mail;
using System.IO;

namespace WinControl_ELR_NET
{
    public class ELRUtils
    {
        //VARIABLES PRIVADA
        public string MENSAJE = "";
        public string TITULO_MENSAJE = "";
        public string FORM_NAME = "";

        private Form _thisForm = null;


        //VARIABLES PUBLICAS
        public string nombrePC, nombreUsuarioPC, localIP;
        public string EMPRESA_NOMBRE = "", EMPRESA_EMAIL = "", EMPRESA_OFICINA = "", EMPRESA_TELEFONO, NOMBRE_USUARIO = "";

        

        public DateTime GetBuildDate(string fileURL)
        {
            
            const int headerOffset = 60;
            const int linkerTimestampOffset = 8;
            var buffer = new byte[2048];
            Stream stream = null;
            DateTime dt = new DateTime(1900, 1, 1);
            try
            {
                stream = new FileStream(fileURL, FileMode.Open, FileAccess.Read);
                stream.Read(buffer, 0, 2048);

                var i = BitConverter.ToInt32(buffer, headerOffset);
                var secondsSince1970 = BitConverter.ToInt32(buffer, i + linkerTimestampOffset);
                dt = new DateTime(1970, 1, 1, 0, 0, 0);
                dt = dt.AddSeconds(secondsSince1970);
                dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);
                
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

            return dt;
        }

        public int GetCountFormOpen()
        {
            int resultado = 0;
            try
            {
                resultado = Application.OpenForms.OfType<Form>().Count();

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int getNivelForm(string formAEjecutar)
        {
            int resultado = 0;
            try
            {
               resultado =  Application.OpenForms.OfType<Form>().Where(pre => pre.ProductName.ToUpper() + "." + pre.Name.ToUpper() == formAEjecutar.ToUpper()).Count();
  
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DateTime getPrimeraFechaMes(DateTime fecha)
        {
            DateTime resultado = fecha;
            int mes = 0, anio = 0;

            mes = resultado.Month;
            anio = resultado.Year;

            resultado = new DateTime(anio, mes, 1);

            return resultado;
        }

        public DateTime getUltimaFechaMes(DateTime fecha)
        {
            DateTime resultado = fecha.AddMonths(1);
            int mes = 0, anio = 0;

            mes = resultado.Month;
            anio = resultado.Year;

            resultado = new DateTime(anio, mes, 1).AddDays(-1);

            return resultado;
        }

        public string GetNombreMes(DateTime fecha)
        {
            int mes = 0;
            string resultado = "";
            try
            {
                mes = fecha.Month;
                resultado = GetNombreMes(mes);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string GetNombreMes(int mes)
        {
            string resultado = "";

            switch (mes)
            {
                case 1: resultado = "ENERO"; break;
                case 2: resultado = "FEBRERO"; break;
                case 3: resultado = "MARZO"; break;
                case 4: resultado = "ABRIL"; break;
                case 5: resultado = "MAYO"; break;
                case 6: resultado = "JUNIO"; break;
                case 7: resultado = "JULIO"; break;
                case 8: resultado = "AGOSTO"; break;
                case 9: resultado = "SEPTIEMBRE"; break;
                case 10: resultado = "OCTUBRE"; break;
                case 11: resultado = "NOVIEMBRE"; break;
                case 12: resultado = "DICIEMBRE"; break;

            }

            return resultado;
        }       

        public string GetCodigoActivacion(string clave)
        {
            string resultado = "";
            ELREncript.Encript encript = new ELREncript.Encript();
            try
            {
                resultado = encript.encriptar(clave);

               

            }
            catch (Exception)
            {

                resultado = "";

            }

            return resultado;

        }

        public string desencriptar(string clave)
        {
            string resultado = "";
            ELREncript.Encript encript = new ELREncript.Encript();
            try
            {
                resultado = encript.desencriptar(clave);
                
            }
            catch (Exception)
            {

                resultado = "";

            }

            return resultado;
        }

        public string GetSerialNumber()
        {
            string resultado = "";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
                foreach (ManagementObject objeto in searcher.Get())
                {
                    resultado = objeto.Properties["SerialNumber"].Value.ToString();
                }

            }
            catch (Exception)
            {

                resultado = "NA00000000000";
            }

            return resultado;
        }

       

        public string GetTipoInterop()
        {
            string resultado = "";
            List<string> directories = new List<string>();
            try
            {
                //Carpetas Open Office
                directories.Add(@"C:\Program Files (x86)\OpenOffice 4");
                directories.Add(@"C:\Program Files\OpenOffice 4");
                directories.Add(@"C:\OpenOffice 4");
                directories.Add(@"C:\Archivos de Programas (x86)\OpenOffice 4");
                directories.Add(@"C:\Archivos de Programas\OpenOffice 4");

                //Carpetas Microsoft Office
                directories.Add(@"C:\Program Files\Microsoft Office");
                directories.Add(@"C:\Program Files (x86)\Microsoft Office");
                directories.Add(@"C:\Archivos de Programas\Microsoft Office");
                directories.Add(@"C:\Archivos de Programas (x86)\Microsoft Office");
               
                

                foreach (string item in directories)
                {
                    if(Directory.Exists(item))
                    {
                        DirectoryInfo di = new DirectoryInfo(item);

                        //BUSCAMOS POR  Open Office, soffice.exe
                        foreach (var fi in di.GetFiles("soffice.exe", SearchOption.AllDirectories))
                        {
                            resultado = "OO";
                            break;
                        }

                        if (resultado != "") break;

                        //Buscamos por Microsof word
                        foreach (var fi in di.GetFiles("winword.exe", SearchOption.AllDirectories))
                        {
                            resultado = "MSO";
                            break;
                        }

                        if (resultado != "") break;         
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool IsOpenOfficeIntalled()
        {
            bool resultado = false;
            
            try
            {
                Type officeType = Type.GetTypeFromProgID("com.sun.star.ServiceManager");
                resultado = (officeType != null);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool IsMSExcelIntalled()
        {
            bool resultado = false;
            try
            {
                Type officeType = Type.GetTypeFromProgID("Excel.Application");
                resultado = (officeType != null);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool IsMSWordIntalled()
        {
            bool resultado = false;
           
            try
            {
                Type officeType = Type.GetTypeFromProgID("Word.Application");
                resultado = (officeType != null);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public double ConvertirANumero(string cadena)
        {
            double resultado = 0;
            char c;
            string valor = "";

            try
            {

                if (cadena.Trim() != "")
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {

                        c = cadena[i];

                        if ((c == '.') && (!valor.Contains("."))) valor += ".";
                        else if ((c == '-') && (!valor.Contains("-"))) valor += "-";
                        else if ((cadena[i] >= '0') && (cadena[i] <= '9')) valor += cadena[i];

                    }

                    double.TryParse(valor, out resultado);
                }


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public void MostrarMensajeInformacion(string Mensaje, string titulo = "")
        {

           MessageBox.Show(Mensaje.ToUpper(), titulo.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult MostrarMensajePregunta(string Mensaje, string titulo = "FAVOR CONFIRMAR")
        {

            return MessageBox.Show(Mensaje.ToUpper(), titulo.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void MostrarMensajeError(string Mensaje, string titulo = "ERROR INESPERADO")
        {
            //Mandamos un Mensaje de Error a Correos
            try
            {
                TITULO_MENSAJE = FORM_NAME + ", ERROR DEL SISTEMA";
                MENSAJE = titulo + ", " + Mensaje;

                //MANDAMOS UN CORREO CON LOS DATOS DE INICIO DE SESSION
                Thread tAux = new Thread(new ThreadStart(EnviarEMail));
                tAux.Start();
                while (!tAux.IsAlive) ;
            }
            catch (Exception)
            {


            }




            MessageBox.Show(Mensaje.ToUpper(), titulo.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public void MostrarMensajeAdvertencia(string Mensaje, string titulo = "AVERTENCIA!!")
        {

            MessageBox.Show(Mensaje.ToUpper(), titulo.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        public void EnviarEMail()
        {
            Correos MyCorreo = new Correos();
            try
            {


                MyCorreo.SetCredenciales("developerlr86@gmail.com", "CumpliendoMetas#1620");
                MailMessage mnsj = new MailMessage();
                mnsj.Subject = TITULO_MENSAJE;
                mnsj.To.Add(new MailAddress("Ej.LandetaR@GMail.com"));
                mnsj.To.Add(new MailAddress("developerlr86@gmail.com"));
                mnsj.To.Add(new MailAddress("reynosojoaquin@gmail.com"));

                if (ValidaEMail(EMPRESA_EMAIL)) mnsj.From = new MailAddress(EMPRESA_EMAIL, EMPRESA_NOMBRE);
                else mnsj.From = new MailAddress("developerlr86@gmail.com", EMPRESA_NOMBRE);

                mnsj.Body = "Serial No. " + GetSerialNumber() + "\n" +
                            "Empresa: " + EMPRESA_NOMBRE + ", " + EMPRESA_OFICINA + "\n" +
                            "Telefonos: " + EMPRESA_TELEFONO + "\n" +
                            "Usuario: " + NOMBRE_USUARIO + "\n" +
                            "Nombre PC: " + nombrePC + "\n" +
                            "Usuario PC: " + nombreUsuarioPC + "\n" +
                            "IP: " + localIP + "\n\n" +
                            MENSAJE;


                //MyCorreo.MandarCorreo(mnsj);
            }
            catch (Exception)
            {

            }
        }

        public bool SetValorDT(string nombreCampo, string valor, DataTable dt, int posicion = 0)
        {
            bool resultado = false;
            try
            {
                if (!dt.Columns.Contains(nombreCampo.Trim())) throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                dt.Rows[posicion][nombreCampo.Trim()] = valor;

                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public string GetValorFromDT(string nombreCampo, DataTable dt, int posicion = 0)
        {
            string resultado = "";
            try
            {
                if (!dt.Columns.Contains(nombreCampo.Trim())) throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                resultado = dt.Rows[posicion][nombreCampo.Trim()].ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }


        public string GetValorFromDR(string nombreCampo, DataRow dr, string valorDefault = " ")
        {
            string resultado = valorDefault;

            try
            {

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = dr[nombreCampo.Trim()].ToString();
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool GetAsBoolean(string nombreCampo, DataRow dr)
        {
            bool resultado = false;

            try
            {

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = (bool)dr[nombreCampo.Trim()];
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public double GetAsDouble(string nombreCampo, DataRow dr, double valorPorDefecto = 0.0)
        {
            double resultado = 0;

            try
            {

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = double.Parse(dr[nombreCampo.Trim()].ToString());
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public decimal GetAsDecimal(string nombreCampo, DataRow dr, decimal valorPorDefecto = 0)
        {
            decimal resultado = 0;

            try
            {

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = decimal.Parse(dr[nombreCampo.Trim()].ToString());
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int GetAsInt(string nombreCampo, DataRow dr, int valorPorDefecto = 0)
        {
            int resultado = 0;

            try
            {
                resultado = valorPorDefecto;

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = int.Parse(dr[nombreCampo.Trim()].ToString());
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string GetAsString(string nombreCampo, DataRow dr, string valorPorDefecto = "")
        {
            string resultado = "";

            try
            {
                resultado = valorPorDefecto;

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = dr[nombreCampo.Trim()].ToString();
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string GetAsTelefono(string nombreCampo, DataRow dr, string valorPorDefecto = "")
        {
            string resultado = "";
            string telefono = "";

            try
            {
                resultado = valorPorDefecto;

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull))
                    {
                        telefono = dr[nombreCampo.Trim()].ToString().Trim();
                        resultado = telefono;
                        if (telefono.Length == 10)
                        {
                            resultado = "(" + telefono.Substring(0, 3) + ")-";
                            resultado += telefono.Substring(3, 3) + "-";
                            resultado += telefono.Substring(6, 4);

                        }


                    }
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DateTime GetAsDate(string nombreCampo, DataRow dr)
        {
            DateTime resultado = DateTime.Now.Date;

            try
            {

                if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = (DateTime)dr[nombreCampo.Trim()];
                }
                else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string GetDateAsString(string nombreCampo, DataTable dt, int posicion = 0)
        {
            string resultado = "00/00/0000";
            int dia, mes, anio;
            DateTime fecha;

            try
            {
                if (dt.Columns.Contains(nombreCampo.Trim()))
                {
                    if (!(dt.Rows[posicion][nombreCampo] is DBNull))
                    {
                        fecha = (DateTime)dt.Rows[posicion][nombreCampo];
                        dia = fecha.Day;
                        mes = fecha.Month;
                        anio = fecha.Year;

                        resultado = dia.ToString().PadLeft(2, '0') + "/" + mes.ToString().PadLeft(2, '0') + "/" + anio.ToString().PadLeft(4, '0');
                    }
                }
                else throw new Exception("El Campo [" + nombreCampo + "] No Existe");

            }
            catch (Exception)
            {
                resultado = "00/00/0000";
                throw;
            }

            return resultado;
        }

        public string GetDateAsString(DateTime fecha)
        {
            string resultado = "00/00/0000";
            int dia, mes, anio;


            try
            {
                dia = fecha.Day;
                mes = fecha.Month;
                anio = fecha.Year;

                resultado = dia.ToString().PadLeft(2, '0') + "/" + mes.ToString().PadLeft(2, '0') + "/" + anio.ToString().PadLeft(4, '0');

            }
            catch (Exception)
            {
                resultado = "00/00/0000";
                throw;
            }

            return resultado;
        }


        public string GetDateAsString(string nombreCampo, DataRow dr)
        {
            string resultado = "00/00/0000";
            int dia, mes, anio;
            DateTime fecha;

            try
            {
                if (!(dr[nombreCampo] is DBNull))
                {
                    fecha = (DateTime)dr[nombreCampo];
                    dia = fecha.Day;
                    mes = fecha.Month;
                    anio = fecha.Year;

                    resultado = dia.ToString().PadLeft(2, '0') + "/" + mes.ToString().PadLeft(2, '0') + "/" + anio.ToString().PadLeft(4, '0');
                }


            }
            catch (Exception)
            {
                resultado = "00/00/0000";
                throw;
            }

            return resultado;
        }

        public string DateToStr(DateTime fecha)
        {
            string resultado = "00/00/0000";
            int dia, mes, anio;
            try
            {
                dia = fecha.Day;
                mes = fecha.Month;
                anio = fecha.Year;

                resultado = dia.ToString().PadLeft(2, '0') + "/" + mes.ToString().PadLeft(2, '0') + "/" + anio.ToString().PadLeft(4, '0');

            }
            catch (Exception)
            {
                resultado = "00/00/0000";
                throw;
            }

            return resultado;
        }

        public string BuildLikeFilter(string nombreCampo, string aBuscar)
        {
            string resultado = "";
            string[] sBuscar;
            try
            {
                sBuscar = aBuscar.Trim().Replace(" ", "|").Split('|');
                foreach (string valor in sBuscar)
                {
                    if(valor.Trim() != "")
                    {
                        if (resultado != "") resultado += " And ";
                        resultado += nombreCampo + " Like '%" + valor.Trim() + "%'"; 
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public ELRUtils(Form frm = null)
        {
            string Host;

            if (frm != null) _thisForm = frm;

            nombrePC = System.Environment.MachineName.ToUpper();
            nombreUsuarioPC = System.Environment.UserName.ToUpper();

            //Vamos a Obtener las Ips
            Host = Dns.GetHostName();
            IPHostEntry IPs = Dns.GetHostByName(Host);
            IPAddress[] Direcciones = IPs.AddressList;

            for (int i = 0; i < Direcciones.Length; i++)
            {
                localIP += Direcciones[i].ToString();
                if (i < Direcciones.Length - 1) localIP += ";";
            }
        }

        public int GetNumeroAleatorio(int valorMinimo = 1000, int valorMaximo = 9999)
        {
            Random r = new Random();
            int resultado = 0;
            try
            {
                resultado = r.Next(valorMinimo, valorMaximo);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string getImpresoraPorDefecto()
        {
            PrinterSettings settings = new PrinterSettings();
            string resultado = "";

            try
            {


                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    settings.PrinterName = printer;
                    if (settings.IsDefaultPrinter)
                        return printer;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string GetPathReportRDLC(string nombreReporte)
        {
            string pathReporte = "";
            string[] archivo;
            bool resultado = false;

            try
            {
                if (nombreReporte == null) nombreReporte = "";

                resultado = (nombreReporte.Trim() != "");

                if (resultado)
                {
                    archivo = nombreReporte.Split('.');
                    if (archivo.Length == 1) nombreReporte += ".rdlc";

                    pathReporte = Application.StartupPath + "\\Reportes\\" + nombreReporte.Trim();

                    if (!File.Exists(pathReporte))
                    {
                        MostrarMensajeError("Archivo de Reporte RDLC [" + pathReporte + "] NO EXISTE");
                        pathReporte = "";
                    }
                }
            }
            catch (Exception)
            {

                pathReporte = "";
                throw;
            }

            return pathReporte;
        }

        public bool ValidarClave(string clave)
        {
            bool resultado = false;
            string mensaje = "";
            string regExp;

            try
            {
                regExp = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";

                resultado = System.Text.RegularExpressions.Regex.IsMatch(clave.Trim(), regExp);

                if (!resultado)
                {
                    mensaje = "Error!! La Contraseña debe Cumplir: \r\r" +
                              "Al menos una letra mayúscula\r" +
                              "Al menos una letra minúscula\r" +
                              "Al menos un número o caracter especial\r" +
                              "Longitud sea como mínimo 8 caracteres";

                    throw new Exception(mensaje);
                }
            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }

            return resultado;
        }

        public string GetTemporalID()
        {
            return (Guid.NewGuid().ToString());
        }

        public int DateToInt(DateTime fecha)
        {
            try
            {
                return ((fecha.Year * 10000) + (fecha.Month * 100) + fecha.Day);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string GetValorVariable(string variable, DataTable DTVariables, string valorPorDefecto = "")
        {
            string resultado = "";
            DataRow[] filas = null;
            DataRow fila0 = null;

            try
            {
                resultado = valorPorDefecto;

                if (DTVariables != null)
                {
                    filas = DTVariables.Select("Variable = '" + variable.Trim() + "'");

                    if (filas.Count() > 0)
                    {
                        fila0 = filas[0];

                        resultado = fila0["Valor"].ToString().Trim().ToUpper();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public bool GetValorVariableAsBool(string variable, DataTable DTVariables, string valorPorDefecto = "")
        {
            bool resultado = false;
            string valor = "";
            int nValor = 0;

            try
            {
                valor = GetValorVariable(variable.Trim(), DTVariables, valorPorDefecto);
                int.TryParse(valor, out nValor);

                resultado = (valor.Trim().ToUpper() == "TRUE" || nValor > 0);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool ValidarNCF(string NCF, int tipo)
        {
            bool resultado = false;
            string mensaje = "";
            int tipoNCF = 0;
            Int32 numero = 0;
            try
            {
                //validamos la longitud
                if (NCF.Length != 11) mensaje += "\nLa longitud del ncf debe ser de 11 caracteres";

                //validamos la primera letra sea B
                if(NCF.Substring(0, 1) != "B") mensaje += "\nLa primera letra debe ser B";

                //validamos el tipo 
                tipoNCF = int.Parse(NCF.Substring(1, 2));
                if (tipoNCF <= 0) mensaje += "\nEl tipo de ncf es incorecto";

                if(tipoNCF > 0 && tipo > 0 && tipoNCF != tipo) mensaje += "\nEl NCF debe ser de tipo: " + tipo.ToString().PadLeft(2, '0');

                //validamos la parte numerica
                numero = Int32.Parse(NCF.Substring(3, 8));
                if (numero <= 0) mensaje += "\nEl numero NCF no es valido";

                resultado = (mensaje.Trim() == "");
                if (mensaje.Trim() != "") throw new Exception(mensaje);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }


        public bool ValidarCedula(String cedula)
        {
            try
            {
                cedula = cedula.Replace("-", string.Empty).Trim();

                if (cedula == null || cedula.Length != 11) return false;

                int suma = 0;
                int division = 0;
                String peso = "1212121212";

                for (int i = 0; i < 10; i++)
                {
                    int mul = (cedula[i] - '0') * (peso[i] - '0');
                    while (mul > 0)
                    {
                        suma += mul % 10;
                        mul /= 10;
                    }
                }

                division = (suma / 10) * 10;

                if (division < suma) division += 10;

                int digito = division - suma;

                if (digito != cedula[10] - '0') return false;

                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ValidarRNC(string rnc)
        {
            string peso = "79865432";
            int suma = 0;
            int division = 0;

            try
            {
                if (rnc.Length != 9)
                    return false;
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        //para verificar si es un dígito o no
                        if (!Char.IsDigit(rnc[i]))
                            return false;

                        int mul = (rnc[i] - '0') * (peso[i] - '0');
                        while (mul > 0)
                        {
                            suma += mul % 10;
                            mul /= 10;
                        }

                    }

                    division = suma / 11;

                    int resto = suma - (division * 11);

                    int digito = 0;

                    if (resto == 0)
                        digito = 2;
                    else if (resto == 1)
                        digito = 1;
                    else
                        digito = 11 - resto;

                    if (digito != ((int)rnc[8]))
                        return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string FormatearCedulaRNC(string cedulaRNC)
        {
            string resultado = "", valor = "";
            try
            {
                valor = cedulaRNC.Trim().Replace("-", "").Replace(" ", "");
                if (valor.Length == 11)
                {
                    resultado = valor.Substring(0, 3) + "-" + valor.Substring(3, 7) + "-" + valor.Substring(10, 1);
                }
                else if (valor.Length == 9)
                {
                    resultado = valor.Substring(0, 3) + "-" + valor.Substring(3, 5) + "-" + valor.Substring(8, 1);
                }
                else resultado = cedulaRNC.Trim();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public string FormatearTelefono(string telefono)
        {
            string resultado = "", valor = "";
            try
            {
                valor = telefono.Trim().Replace("-", "").Replace("+", "").Replace(" ", "").Replace("(", "").Replace(")", "");
                if (valor.Length == 10)
                {
                    resultado = valor.Substring(0, 3) + "-" + valor.Substring(3, 3) + "-" + valor.Substring(6, 4);
                }
                else if (valor.Length == 11)
                {
                    resultado = "+" + valor.Substring(0, 1) + valor.Substring(1, 3) + "-" + valor.Substring(4, 3) + "-" + valor.Substring(7, 4);
                }
                else resultado = telefono.Trim();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool ValidaTelef(string numero)
        {
            bool resultado = false;

            try
            {
                string regExp = @"^[+-]?\d+(\.\d+)?$";

                resultado = System.Text.RegularExpressions.Regex.IsMatch(numero.Trim(), regExp);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool ValidaSoloNumero(string numero)
        {
            bool resultado = false;

            try
            {
                string regExp = @"[0-9]{1,9}(\.[0-9]{0,2})?$";

                resultado = System.Text.RegularExpressions.Regex.IsMatch(numero.Trim(), regExp);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool ValidaEMail(string email)
        {
            bool resultado = false;

            try
            {
                string regExp = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

                resultado = System.Text.RegularExpressions.Regex.IsMatch(email.Trim(), regExp);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool ValidaDecimal(string email)
        {
            bool resultado = false;

            try
            {
                string regExp = @"^(\d|-)?(\d|,)*\.?\d*$";

                resultado = System.Text.RegularExpressions.Regex.IsMatch(email.Trim(), regExp);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int BorraArchivosCarpeta(string carpeta, int dias = 15)
        {
            int resultado = 0;
            FileInfo[] fileList;
            DateTime fecha = DateTime.Now.Date;
            DateTime feCreado = DateTime.Now.Date;
            try
            {
                dias =  Math.Abs(dias) * -1;
                fecha = fecha.AddDays(dias);

                DirectoryInfo di = new DirectoryInfo(@carpeta);
                fileList = di.GetFiles();
                foreach (FileInfo item in fileList)
                {
                    feCreado = item.CreationTime;
                    if(DateToInt(feCreado) <= DateToInt(fecha))
                    {
                        item.Delete();
                        resultado++;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public double GetSum(string nombreCampo, DataTable data, string filtro = "")
        {
            double resultado = 0;
            object calcObject;
            try
            {

                calcObject = data.Compute("Sum(" + nombreCampo + ")", filtro);
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") resultado = double.Parse(calcObject.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }
    }

}
