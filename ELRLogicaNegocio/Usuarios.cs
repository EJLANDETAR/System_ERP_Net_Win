using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELRLogicaNegocio
{
    public class Usuarios
    {
        public int SetClave(DataDB_ELR_NET.DataDB objDB, string nombreUsuario, string clave)
        {
            string SSQL = "";
            int resultado = 0;
            string regExp = "";
            string mensaje = "";
            bool valido = false;

            try
            {
                regExp = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";

                //valido = System.Text.RegularExpressions.Regex.IsMatch(clave.Trim(), regExp);
                valido = true;

                if (!valido)
                {
                    mensaje = "Error!! La Contraseña debe Cumplir: \r\r" +
                              "Al menos una letra mayúscula\r" +
                              "Al menos una letra minúscula\r" +
                              "Al menos un número o caracter especial\r" +
                              "Longitud sea como mínimo 8 caracteres";

                    throw new Exception(mensaje);
                }

                SSQL = " UPDATE TACCESOS_USUARIOS SET CLAVE = PWDENCRYPT('" + clave.Trim() + "') " +
                       " WHERE Nombre_Usuario = '" + nombreUsuario.Trim() + "'";

                resultado = objDB.EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
    }
}
