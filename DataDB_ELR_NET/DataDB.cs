using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataDB_ELR_NET
{
    public class DataDB
    {
        //VARIABLES PRIVADAS
        SqlConnection OConn = new SqlConnection();
        SqlTransaction objTrans;
        int LICENCIA_LIMITE = 0;

        //VARIABLES PUBLICAS
        public string NOMBRE_USUARIO = "";
        public string MENSAJE = "";
        public DateTime FECHA_TRABAJO;
        public DateTime FECHA_CONTABLE;
        public int timeOut = 120;
        public bool isString = false;

        public List<string> Filtros = new List<string>();

        ~DataDB()
        {


        }

        public bool ValidarFechaOperaciones(int oficinaId, bool conCajaAbierta = false)
        {
            bool resultado = false;
            DateTime feActual = DateTime.Now.Date;
            DateTime feCaja = DateTime.Now.Date;
            DataTable DTCajas = null;
            string SSQL = "";
            int conteo = 0;
            try
            {
                //Buscamos la fecha de operaciones de la oficina
                GetFechasOficina(oficinaId);

                //la fecha de trabajo no puede ser menor a la fecha actual
                if (DateToInt(FECHA_TRABAJO) < DateToInt(feActual)) throw new Exception("LA FECHA DE TRABAJO [" + FECHA_TRABAJO.ToString("dd/MM/yyyy") + "] NO PUEDE SER MENOR A LA FECHA ACTUAL");

                if (conCajaAbierta)
                {
                    //validamos el usuario tenga caja abierta
                    SSQL = " SELECT Caja_Id, Fecha_Trabajo, Usuario_En_Caja ";
                    SSQL += " FROM TCAJAS_APERTURA_CIERRE ";
                    SSQL += " WHERE Fecha_Cierre IS NULL AND Usuario_En_Caja = '" + NOMBRE_USUARIO + "' ";
                    DTCajas = GetSQL(SSQL);
                    conteo = DTCajas.Rows.Count;
                    if (conteo <= 0) throw new Exception("EL USUARIO [" + NOMBRE_USUARIO + "] NO TIENE CAJA ABIERTA ");
                    if (conteo > 1) throw new Exception("EL USUARIO [" + NOMBRE_USUARIO + "] TIENE " + conteo.ToString() + " CAJAS ABIERTAS ");
                    //Validamos la fecha de caja sea igual a la fecha de operaciones
                    feCaja = GetAsDate("Fecha_Trabajo", DTCajas.Rows[0]);
                    if (DateToInt(feCaja) != DateToInt(FECHA_TRABAJO)) throw new Exception("LA FECHA DE CAJA NO SE CORRESPONDE CON LA FECHA DE TRABAJO DE LA OFICINA");

                }
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }

            return resultado;
        }

        //Definicion Funciones Privada
        bool ValidarUsuario()
        {
            bool resultado = false;
            try
            {
                if (NOMBRE_USUARIO.Trim() == "") throw new Exception("No se ha Indicado NOMBRE_USUARIO");

                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
        // ---FIN FUNCIONES PRIVADAS ------------------------------------------------------------------------------

        public bool ValidarFechaTrabajo()
        {
            bool resultado = true;
            DateTime feActual = DateTime.Now;
            try
            {
                GetFechasOficina();
                if (DateToInt(FECHA_TRABAJO) < DateToInt(feActual))
                {
                    resultado = false;
                    throw new Exception("FECHA DE TRABAJO NO PUEDE SER MENOR A FECHA ACTUAL");
                }

            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }

            return resultado;
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

        public void LimpiarFiltros()
        {
            try
            {
                Filtros.Clear();
                Filtros = new List<string>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroMayorA(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " > '" + valor.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroMayorOIgualA(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " >= '" + valor.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroIgualA(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " = '" + valor.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroMenorA(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " < '" + valor.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroMenorOIgualA(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " <= '" + valor + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroEmpieceEN(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " Like '" + valor.Trim() + "%'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroTermineEN(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " Like '%" + valor.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroContengaA(string nombreCampo, string valor)
        {
            try
            {
                valor = valor.Replace("-", "");
                valor = valor.Replace(" ", "%");

                if (!nombreCampo.ToUpper().Contains("REPLACE"))
                {
                    nombreCampo = "REPLACE(" + nombreCampo + ", '-', '') ";
                }

                Filtros.Add(" And " + nombreCampo + " Like '%" + valor.Trim() + "%'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroNoIgualA(string nombreCampo, string valor)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " <> '" + valor.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroIsNull(string nombreCampo)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " Is Null ");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroIsNoNull(string nombreCampo)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " Is Not Null ");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroRango(string nombreCampo, string valorDesde, string valorHasta)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " >= '" + valorDesde.Trim() + "' And " + nombreCampo + " <= '" + valorHasta.Trim() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroBetweenCampo(string valor, string campoDesde, string campoHasta)
        {
            try
            {
                Filtros.Add(" And '" + valor + "' between " + campoDesde + " And " + campoHasta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroRangoFecha(string nombreCampo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " >= '" + DateToInt(fechaDesde).ToString() +
                            "' And " + nombreCampo + " <= '" + DateToInt(fechaHasta).ToString() + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddFiltroPersonalizado(string filtro)
        {
            try
            {
                if (filtro.Trim() != "")
                {
                    if (filtro.Trim().Substring(0, 3).ToUpper() != "AND") filtro = " AND " + filtro;
                    Filtros.Add(filtro);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddFiltroOficina(int oficinaId, string nombreCampo = "Oficina_Id")
        {
            try
            {
                Filtros.Add(" And " + nombreCampo + " = " + oficinaId.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddFiltroOrderBY(string condicionOrderBY)
        {
            try
            {
                if (condicionOrderBY.Trim() != "")
                {
                    if (!condicionOrderBY.ToUpper().Contains("ORDER BY")) condicionOrderBY = " ORDER BY " + condicionOrderBY;

                    Filtros.Add(condicionOrderBY);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AbrirConeccion()
        {
            bool resultado = false;
            string archivoConfig = Environment.CurrentDirectory + "\\ELRDataDBConfig.xml";
            ELR_ConfigConn.ConfiConn objConf = new ELR_ConfigConn.ConfiConn();

            try
            {


                if (OConn.State != ConnectionState.Open)
                {
                    if (OConn.ConnectionString == "")
                    {
                        SqlConnectionStringBuilder cadenaConeccion = new SqlConnectionStringBuilder();
                        objConf.cargarDatosConnecion(archivoConfig);
                        cadenaConeccion.DataSource = objConf.NombreServidor;
                        cadenaConeccion.InitialCatalog = objConf.NombreBD;
                        cadenaConeccion.UserID = objConf.NombreUsuario;
                        cadenaConeccion.Password = objConf.Password;

                        OConn.ConnectionString = cadenaConeccion.ConnectionString + ";Connection Timeout=120";
                        //OConn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DB;Integrated Security=True";
                    }

                    //OConn.ConnectionTimeout = 120;
                    OConn.Open();


                    resultado = (OConn.State == ConnectionState.Open);
                }
            }
            catch (Exception)
            {
                OConn.ConnectionString = "";
                throw;
            }

            return resultado;
        }

        public void CerrarConeccion()
        {
            try
            {
                if ((OConn.State == ConnectionState.Open) && (objTrans == null))
                {
                    OConn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool iniciarTransaccion()
        {

            bool Resultado = false;

            try
            {

                if ((AbrirConeccion()) && (objTrans == null)) objTrans = OConn.BeginTransaction();
                Resultado = true;
            }
            catch (Exception ex)
            {

                Resultado = false;
                throw ex;
            }

            return Resultado;
        }

        public bool cancelarTransaccion()
        {

            bool Resultado = false;
            try
            {

                if (objTrans != null)
                {

                    objTrans.Rollback();
                    objTrans = null;
                    CerrarConeccion();
                }

                Resultado = true;
            }
            catch (Exception ex)
            {

                Resultado = false;
                throw ex;
            }

            return Resultado;
        }

        public bool confirmarTransaccion()
        {

            bool Resultado = false;
            try
            {

                if (objTrans != null)
                {

                    objTrans.Commit();
                    objTrans = null;
                    CerrarConeccion();
                }

                Resultado = true;
            }
            catch (Exception ex)
            {

                Resultado = false;
                throw ex;
            }

            return Resultado;
        }

        public int EjecutarSQL(string SSQL)
        {
            int resultado = -1;
            SqlCommand OComando = new SqlCommand(SSQL);
            try
            {
                //Validamos Haya Indicado NOMBRE_USUARIO
                ValidarUsuario();

                AbrirConeccion();
                OComando.CommandTimeout = timeOut;
                OComando.Connection = OConn;

                if (objTrans != null) OComando.Transaction = objTrans;

                resultado = OComando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                CerrarConeccion();
                throw;
            }
            finally
            {
                CerrarConeccion();
                OComando.Dispose();
            }

            return resultado;
        }

        public Int32 GetSiguienteId(string nombreTabla, string campoID, int oficinaId = 0)
        {
            Int32 resultado = 1;
            string SSQL = "", mensaje = "";
            DataTable DTData = null;
            List<Parametro> parms = new List<Parametro>();
            try
            {
                if (oficinaId > 0)
                {
                    parms.Add(new Parametro("campoId", campoID));
                    parms.Add(new Parametro("tabla", nombreTabla));
                    parms.Add(new Parametro("oficinaId", oficinaId));
                    parms.Add(new Parametro("IdentificadorTemp", NOMBRE_USUARIO));

                    resultado = EjecutarSP("SP_GET_SGUIENTE_ID", parms);
                    if (resultado <= 0)
                    {
                        SSQL = "SELECT TOP 1 Mensaje FROM TSISTEMA_MENSAJES_ERRORES Where IdentificadorTemp = '" + NOMBRE_USUARIO + "' Order by Unico Desc";
                        DTData = GetSQL(SSQL);
                        if (DTData.Rows.Count > 0) mensaje = GetAsString("Mensaje", DTData.Rows[0]);

                        throw new Exception("ERROR SP_GET_SGUIENTE_ID: " + mensaje);
                    }
                }
                else
                {
                    SSQL = "SELECT IsNull(MAX(" + campoID + "), 0) + 1 as Id FROM " + nombreTabla;
                    DTData = GetSQL(SSQL);
                    resultado = GetAsInt("Id", DTData.Rows[0]);
                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int Insertar(string nombreTabla, string campoId, DataTable data, int posicion, string camposAExcluir = "")
        {
            int resultado = -1, oficinaId = 0;
            Int32 Id = 0;
            string SSQL = "";
            string valuesSQL = "";
            string nombreCampo = "";
            string valor = "0";
            int conteo = 0;
            DateTime fecha;
            TimeSpan hora;

            try
            {
                if (data.Columns.Contains("Oficina_Id")) oficinaId = GetAsInt("Oficina_Id", data.Rows[posicion]);

                //Obtenemos el siguiente Id
                if (campoId.Trim() != "")
                {
                    if (campoId.Trim().ToUpper() == "UNICO") valor = "0";
                    else if (data.Rows[posicion][campoId] is DBNull) valor = "0";
                    else if (data.Rows[posicion][campoId].ToString().Trim() == "") valor = "0";


                    if (valor == "0") Id = GetSiguienteId(nombreTabla, campoId, oficinaId);
                }

                SSQL = " INSERT INTO " + nombreTabla + "( ";
                valuesSQL = " Values( ";
                foreach (DataColumn item in data.Columns)
                {

                    nombreCampo = item.ColumnName.ToUpper();

                    //SI ES AUTOINCREMENTAR O EL CAMPO ES UNICO HACEMOS UN BRINCO
                    if ((item.AutoIncrement == true) || (nombreCampo == "UNICO")) continue;

                    //BRINCAMOS CAMPOS NO SE VAN A INSERTAR
                    if (nombreCampo == "FECHA_ULTIMA_COMPRA") continue;
                    if (nombreCampo == "FECHA_ULTIMA_VENTA") continue;
                    if (nombreCampo == "FECHA_ULTIMO_ABONO") continue;
                    if (nombreCampo == "FECHA_PROXIMO_PAGO") continue;
                    if (nombreCampo == "MODIFICADO_POR") continue;
                    if (nombreCampo == "FECHA_MODIFICADO") continue;

                    //VAMOS A OBTENER LOS VALORES A INSERTAR
                    if (nombreCampo == "AUTOR") valor = "'" + NOMBRE_USUARIO + "'";
                    else if (nombreCampo == "ADICIONADO_POR") valor = "'" + NOMBRE_USUARIO + "'";
                    else if (nombreCampo == "AUTOR_FECHA") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORFECHA") valor = "GETDATE()";
                    else if (nombreCampo == "FECHA_ADICIONADO") valor = "GETDATE()";
                    else if (nombreCampo == "FECHAADICIONADO") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORACCION") valor = "'I'";
                    else if (nombreCampo == "AUTOR_ACCION") valor = "'I'";
                    else if (nombreCampo == "ACTIVO") valor = "'1'";
                    else if (nombreCampo == "ESACTIVO") valor = "'1'";
                    else if ((nombreCampo == campoId.Trim().ToUpper()) && (Id > 0)) valor = Id.ToString();
                    else if (data.Rows[posicion][nombreCampo] is DBNull) continue;
                    else
                    {
                        if (nombreCampo.ToUpper() == "PRECIO_US")
                        {
                            resultado = 1;
                        }
                        //SI EL CAMPO SE VA A EXCLUIR CONTINUAMOS CON EL BUCLE
                        if (camposAExcluir.Trim() != "")
                        {
                            if (IsCampoEnLista(nombreCampo, camposAExcluir)) continue;
                        }


                        //Obtenemos el Valor del DataTable, CASO ESPECIAL LOS CAMPOS DATETIME
                        if (item.DataType == typeof(DateTime))
                        {
                            if (data.Rows[posicion][nombreCampo] is DBNull) fecha = DateTime.Now.Date;
                            else fecha = (DateTime)data.Rows[posicion][nombreCampo];

                            valor = "'" + DateToInt(fecha).ToString() + "'";
                        }
                        else if (item.DataType == typeof(TimeSpan))
                        {
                            hora = (TimeSpan)data.Rows[posicion][nombreCampo];
                            valor = "'" + hora.Hours.ToString() + ":" + hora.Minutes.ToString() + ":" + hora.Seconds + "'";
                        }
                        else if (item.DataType == typeof(decimal))
                        {
                            if (data.Rows[posicion][nombreCampo] is DBNull) valor = "0";
                            else valor = "'" + data.Rows[posicion][nombreCampo].ToString() + "'";
                        }
                        else if (item.DataType == typeof(double))
                        {
                            if (data.Rows[posicion][nombreCampo] is DBNull) valor = "0";
                            else valor = "'" + data.Rows[posicion][nombreCampo].ToString() + "'";
                        }
                        else valor = "'" + data.Rows[posicion][nombreCampo].ToString() + "'";

                    }

                    if (conteo == 0)
                    {
                        SSQL += nombreCampo;
                        valuesSQL += valor;
                    }
                    else
                    {
                        SSQL += ", " + nombreCampo;
                        valuesSQL += ", " + valor;
                    }

                    conteo++;
                }

                SSQL += ") " + valuesSQL + ") ";
                resultado = EjecutarSQL(SSQL);

            }
            catch (Exception ex)
            {

                resultado = -1;
                throw new Exception("Error, [" + nombreCampo + "], " + ex.Message);
            }
            finally
            {
                CerrarConeccion();
            }

            return resultado;
        }

        public int InsertarFromFila(DataRow fila, string nombreTabla, string campoId = "Unico", string camposAExcluir = "")
        {
            int resultado = -1, oficinaId = 0;
            Int32 Id = 0;
            string SSQL = "";
            string valuesSQL = "";
            string nombreCampo;
            string valor = "0";
            int conteo = 0;
            DateTime fecha;
            TimeSpan hora;

            try
            {
                if (fila.Table.Columns.Contains("Oficina_Id")) oficinaId = GetAsInt("Oficina_Id", fila);

                //Obtenemos el siguiente Id
                if (campoId.Trim() != "")
                {
                    if (campoId.Trim().ToUpper() == "UNICO") valor = "0";
                    else if (fila[campoId] is DBNull) valor = "0";
                    else if (fila[campoId].ToString().Trim() == "") valor = "0";


                    if (valor == "0") Id = GetSiguienteId(nombreTabla, campoId, oficinaId);
                }

                SSQL = " INSERT INTO " + nombreTabla + "( ";
                valuesSQL = " Values( ";
                foreach (DataColumn item in fila.Table.Columns)
                {

                    nombreCampo = item.ColumnName.ToUpper();


                    //SI ES AUTOINCREMENTAR O EL CAMPO ES UNICO HACEMOS UN BRINCO
                    if ((item.AutoIncrement == true) || (nombreCampo == "UNICO")) continue;

                    //BRINCAMOS CAMPOS NO SE VAN A INSERTAR
                    if (nombreCampo == "FECHA_ULTIMA_COMPRA") continue;
                    if (nombreCampo == "FECHA_ULTIMA_VENTA") continue;
                    if (nombreCampo == "FECHA_ULTIMO_ABONO") continue;
                    if (nombreCampo == "FECHA_PROXIMO_PAGO") continue;
                    if (nombreCampo == "MODIFICADO_POR") continue;
                    if (nombreCampo == "FECHA_MODIFICADO") continue;

                    //VAMOS A OBTENER LOS VALORES A INSERTAR
                    if (nombreCampo == "AUTOR") valor = "'" + NOMBRE_USUARIO + "'";
                    else if (nombreCampo == "ADICIONADO_POR") valor = "'" + NOMBRE_USUARIO + "'";
                    else if (nombreCampo == "AUTOR_FECHA") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORFECHA") valor = "GETDATE()";
                    else if (nombreCampo == "FECHA_ADICIONADO") valor = "GETDATE()";
                    else if (nombreCampo == "FECHAADICIONADO") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORACCION") valor = "'I'";
                    else if (nombreCampo == "AUTOR_ACCION") valor = "'I'";
                    else if (nombreCampo == "ACTIVO") valor = "'1'";
                    else if (nombreCampo == "ESACTIVO") valor = "'1'";
                    else if ((nombreCampo == campoId.Trim().ToUpper()) && (Id > 0)) valor = Id.ToString();
                    else if (fila[nombreCampo] is DBNull) continue;
                    else
                    {
                        //SI EL CAMPO SE VA A EXCLUIR CONTINUAMOS CON EL BUCLE
                        if (camposAExcluir.Trim() != "")
                        {
                            if (IsCampoEnLista(nombreCampo, camposAExcluir)) continue;
                        }


                        //Obtenemos el Valor del DataTable, CASO ESPECIAL LOS CAMPOS DATETIME
                        if (item.DataType == typeof(DateTime))
                        {
                            fecha = (DateTime)fila[nombreCampo];
                            valor = "'" + DateToInt(fecha).ToString() + "'";
                        }
                        else if (item.DataType == typeof(TimeSpan))
                        {
                            hora = (TimeSpan)fila[nombreCampo];
                            valor = "'" + hora.Hours.ToString() + ":" + hora.Minutes.ToString() + ":" + hora.Seconds + "'";
                        }
                        else valor = "'" + fila[nombreCampo].ToString() + "'";

                    }

                    if (conteo == 0)
                    {
                        SSQL += nombreCampo;
                        valuesSQL += valor;
                    }
                    else
                    {
                        SSQL += ", " + nombreCampo;
                        valuesSQL += ", " + valor;
                    }

                    conteo++;
                }

                SSQL += ") " + valuesSQL + ") ";
                resultado = EjecutarSQL(SSQL);

            }
            catch (Exception)
            {

                resultado = -1;
                throw;
            }
            finally
            {
                CerrarConeccion();
            }

            return resultado;
        }

        public int InsertarFromParametros(string nombreTabla, List<Parametro> parametros, string campoId = "")
        {
            int resultado = -1;
            int Id = 0;
            string SSQL = "";
            string valuesSQL = "";
            DataTable data = new DataTable();
            int conteo = 0;

            try
            {
                SSQL = " SELECT TOP 0 * FROM " + nombreTabla;
                data = GetSQL(SSQL);

                //Obtenemos el siguiente Id
                if (campoId.Trim() != "") Id = GetSiguienteId(nombreTabla, campoId);

                SSQL = " INSERT INTO " + nombreTabla + "( ";
                valuesSQL = " Values( ";
                foreach (Parametro item in parametros)
                {
                    if (item.NombreCampo.Trim().ToUpper().Equals(campoId.Trim().ToUpper())) item.Valor = Id;

                    if (conteo == 0)
                    {
                        SSQL += item.NombreCampo;
                        valuesSQL += "'" + item.Valor.ToString() + "'";
                    }
                    else
                    {
                        SSQL += ", " + item.NombreCampo;
                        valuesSQL += ", '" + item.Valor.ToString() + "'";
                    }

                    conteo++;
                }

                //Agregamos Campos de Auditoria
                if (data.Columns.Contains("Autor"))
                {
                    SSQL += ", Autor";
                    valuesSQL += ", '" + NOMBRE_USUARIO + "'";
                }
                if (data.Columns.Contains("Autor_Fecha"))
                {
                    SSQL += ", Autor_Fecha";
                    valuesSQL += ", GetDate()";
                }
                if (data.Columns.Contains("AutorFecha"))
                {
                    SSQL += ", AutorFecha";
                    valuesSQL += ", GetDate()";
                }
                if (data.Columns.Contains("Autor_Accion"))
                {
                    SSQL += ", Autor_Accion";
                    valuesSQL += ", 'I'";
                }
                if (data.Columns.Contains("AutorAccion"))
                {
                    SSQL += ", AutorAccion";
                    valuesSQL += ", 'I'";
                }
                if (data.Columns.Contains("Adicionado_Por"))
                {
                    SSQL += ", Adicionado_Por";
                    valuesSQL += ", '" + NOMBRE_USUARIO + "'";
                }
                if (data.Columns.Contains("AdicionadoPor"))
                {
                    SSQL += ", AdicionadoPor";
                    valuesSQL += ", '" + NOMBRE_USUARIO + "'";
                }
                if (data.Columns.Contains("Fecha_Adicionado"))
                {
                    SSQL += ", Fecha_Adicionado";
                    valuesSQL += ", GetDate()";
                }
                if (data.Columns.Contains("FechaAdicionado"))
                {
                    SSQL += ", FechaAdicionado";
                    valuesSQL += ", GetDate()";
                }

                SSQL += ") " + valuesSQL + ") ";
                resultado = EjecutarSQL(SSQL);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int EjecutarSP(string nombreSP, List<Parametro> parametros)
        {
            int resultado = -1;
            bool esMsg = false;
            SqlCommand OComando = new SqlCommand();

            try
            {
                MENSAJE = "";
                OComando.Connection = OConn;
                OComando.CommandText = nombreSP.Trim();

                OComando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro item in parametros)
                {
                    if ((item.EsSalida == true) || (item.NombreCampo.ToUpper() == "MSG"))
                    {
                        if (esMsg == false) esMsg = (item.NombreCampo.ToUpper() == "MSG");

                        SqlParameter param = new SqlParameter();

                        if (item.NombreCampo.ToUpper() == "MSG")
                        {
                            param.ParameterName = "@msg";
                            param.DbType = DbType.String;
                            param.Size = 150;
                            param.Direction = ParameterDirection.Output;
                            param.Value = "";
                        }
                        else
                        {

                            param.ParameterName = "@" + item.NombreCampo.Trim();
                            param.Direction = ParameterDirection.Output;
                            param.Value = item.Valor;
                        }

                        OComando.Parameters.Add(param);
                    }
                    else OComando.Parameters.AddWithValue("@" + item.NombreCampo.Trim(), item.Valor);

                }

                //Creamos el Parametros para obtener el Valor del Return
                OComando.Parameters.Add("@ReturnValue", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;

                if (objTrans != null) OComando.Transaction = objTrans;


                AbrirConeccion();
                OComando.CommandTimeout = timeOut;
                OComando.ExecuteNonQuery();
                resultado = int.Parse(OComando.Parameters["@ReturnValue"].Value.ToString());

                if (esMsg) MENSAJE = OComando.Parameters["@msg"].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CerrarConeccion();
                OComando.Dispose();
            }

            return resultado;
        }

        public int Actualizar(string nombreTabla, string campoId, DataTable data, int posicion, string camposAExcluir = "")
        {
            int resultado = -1;
            string SSQL = "";
            string nombreCampo;
            string valor;
            string condicionWHERE = "";
            DateTime fecha;
            TimeSpan hora;

            try
            {

                SSQL = " UPDATE " + nombreTabla + " SET ";
                if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                else throw new Exception("Imposible Actualizar, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                //ESTABLECEMOS LA CONDICION WHERE
                if (campoId.Trim() != "")
                {
                    valor = data.Rows[posicion][campoId.Trim()].ToString();
                    condicionWHERE = " WHERE " + campoId + " = '" + valor + "'";
                }
                else if (data.Columns.Contains("Unico"))
                {
                    valor = data.Rows[posicion]["Unico"].ToString();
                    condicionWHERE = " WHERE Unico = '" + valor + "'";
                }
                else throw new Exception("Imposible Actualizar, Clausula WHERE No Encontrada");



                foreach (DataColumn item in data.Columns)
                {

                    nombreCampo = item.ColumnName.ToUpper();

                    //SI ES AUTOINCREMENTAR O EL CAMPO ES UNICO HACEMOS UN BRINCO
                    if ((item.AutoIncrement == true) || (nombreCampo == "UNICO")) continue;

                    //BRINCAMOS CAMPOS NO SE VAN A ACTUALIZAR
                    if (nombreCampo == "FECHA_ULTIMA_COMPRA") continue;
                    if (nombreCampo == "FECHA_ULTIMA_VENTA") continue;
                    if (nombreCampo == "FECHA_ULTIMO_ABONO") continue;
                    if (nombreCampo == "FECHA_PROXIMO_PAGO") continue;


                    //SI ES EL CAMPO ID HACEMOS UN BRINCO
                    if (nombreCampo.Trim().ToUpper().Equals(campoId.Trim().ToUpper())) continue;

                    //VAMOS A OBTENER LOS VALORES A ACTUALIZAR
                    if (nombreCampo == "AUTOR") continue;
                    else if (nombreCampo == "ADICIONADO_POR") continue;
                    else if (nombreCampo == "FECHA_ADICIONADO") continue;
                    else if (nombreCampo == "MODIFICADO_POR") continue;
                    if (nombreCampo == "AUTOR_FECHA") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORFECHA") valor = "GETDATE()";
                    else if (nombreCampo == "FECHA_MODIFICADO") valor = "GETDATE()";
                    else if (nombreCampo == "FECHAMODIFICADO") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORACCION") valor = "'M'";
                    else if (nombreCampo == "AUTOR_ACCION") valor = "'M'";
                    else if (data.Rows[posicion][nombreCampo] is DBNull) valor = "NULL";
                    else
                    {
                        //SI EL CAMPO SE VA A EXCLUIR CONTINUAMOS CON EL BUCLE
                        if (camposAExcluir.Trim() != "")
                        {
                            if (IsCampoEnLista(nombreCampo, camposAExcluir)) continue;
                        }

                        //Obtenemos el Valor del DataTable, CASO ESPECIAL LOS CAMPOS DATETIME
                        if (item.DataType == typeof(DateTime))
                        {
                            fecha = (DateTime)data.Rows[posicion][nombreCampo];
                            valor = "'" + DateToInt(fecha).ToString() + "'";
                        }
                        else if (item.DataType == typeof(TimeSpan))
                        {
                            hora = (TimeSpan)data.Rows[posicion][nombreCampo];
                            valor = "'" + hora.Hours.ToString() + ":" + hora.Minutes.ToString() + ":" + hora.Seconds + "'";
                        }
                        else valor = "'" + data.Rows[posicion][nombreCampo].ToString() + "'";
                    }

                    SSQL += ", " + nombreCampo + " = " + valor;

                }

                //VAMOS A EXCLUIR LOS REGISTRO YA MARCADO COMO ELIMINADO
                if (data.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                if (data.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                if (data.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                if (data.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                SSQL += " " + condicionWHERE;
                resultado = EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                resultado = -1;
                throw;
            }
            return resultado;
        }

        public int UpdateFromRow(string nombreTabla, DataRow Fila, string campoId, string camposAExcluir = "")
        {
            int resultado = -1;
            string SSQL = "";
            string nombreCampo;
            string valor;
            string condicionWHERE = "";
            DateTime fecha;
            TimeSpan hora;

            try
            {

                SSQL = " UPDATE " + nombreTabla + " SET ";
                if (Fila.Table.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                else if (Fila.Table.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                else throw new Exception("Imposible Actualizar, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                //ESTABLECEMOS LA CONDICION WHERE
                if (campoId.Trim() != "")
                {
                    valor = Fila[campoId.Trim()].ToString();
                    condicionWHERE = " WHERE " + campoId + " = '" + valor + "'";
                }
                else if (Fila.Table.Columns.Contains("Unico"))
                {
                    valor = Fila["Unico"].ToString();
                    condicionWHERE = " WHERE Unico = '" + valor + "'";
                }
                else throw new Exception("Imposible Actualizar, Clausula WHERE No Encontrada");

                //AGREGAMOS PARA INCLUIR IdentificadorTemp en la ClausulaWhere
                if (Fila.Table.Columns.Contains("IdentificadorTemp"))
                {
                    valor = Fila["IdentificadorTemp"].ToString();
                    condicionWHERE += " And IdentificadorTemp = '" + valor + "'";
                }

                foreach (DataColumn item in Fila.Table.Columns)
                {

                    nombreCampo = item.ColumnName.ToUpper();

                    //SI ES AUTOINCREMENTAR O EL CAMPO ES UNICO HACEMOS UN BRINCO
                    if ((item.AutoIncrement == true) || (nombreCampo == "UNICO")) continue;

                    //BRINCAMOS CAMPOS NO SE VAN A ACTUALIZAR
                    if (nombreCampo == "FECHA_ULTIMA_COMPRA") continue;
                    if (nombreCampo == "FECHA_ULTIMA_VENTA") continue;
                    if (nombreCampo == "FECHA_ULTIMO_ABONO") continue;
                    if (nombreCampo == "FECHA_PROXIMO_PAGO") continue;


                    //SI ES EL CAMPO ID HACEMOS UN BRINCO
                    if (nombreCampo.Trim().ToUpper().Equals(campoId.Trim().ToUpper())) continue;

                    //VAMOS A OBTENER LOS VALORES A ACTUALIZAR
                    if (nombreCampo == "AUTOR") continue;
                    else if (nombreCampo == "ADICIONADO_POR") continue;
                    else if (nombreCampo == "FECHA_ADICIONADO") continue;
                    else if (nombreCampo == "MODIFICADO_POR") continue;
                    if (nombreCampo == "AUTOR_FECHA") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORFECHA") valor = "GETDATE()";
                    else if (nombreCampo == "FECHA_MODIFICADO") valor = "GETDATE()";
                    else if (nombreCampo == "FECHAMODIFICADO") valor = "GETDATE()";
                    else if (nombreCampo == "AUTORACCION") valor = "'M'";
                    else if (nombreCampo == "AUTOR_ACCION") valor = "'M'";
                    else if (Fila[nombreCampo] is DBNull) valor = "NULL";
                    else
                    {
                        //SI EL CAMPO SE VA A EXCLUIR CONTINUAMOS CON EL BUCLE
                        if (camposAExcluir.Trim() != "")
                        {
                            if (IsCampoEnLista(nombreCampo, camposAExcluir)) continue;
                        }

                        //Obtenemos el Valor del DataTable, CASO ESPECIAL LOS CAMPOS DATETIME
                        if (item.DataType == typeof(DateTime))
                        {
                            fecha = (DateTime)Fila[nombreCampo];
                            valor = "'" + DateToInt(fecha).ToString() + "'";
                        }
                        else if (item.DataType == typeof(TimeSpan))
                        {
                            hora = (TimeSpan)Fila[nombreCampo];
                            valor = "'" + hora.Hours.ToString() + ":" + hora.Minutes.ToString() + ":" + hora.Seconds + "'";
                        }
                        else valor = "'" + Fila[nombreCampo].ToString() + "'";
                    }

                    SSQL += ", " + nombreCampo + " = " + valor;

                }

                //VAMOS A EXCLUIR LOS REGISTRO YA MARCADO COMO ELIMINADO
                if (Fila.Table.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                if (Fila.Table.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                if (Fila.Table.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                if (Fila.Table.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                SSQL += " " + condicionWHERE;
                resultado = EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                resultado = -1;
                throw;
            }
            return resultado;
        }

        public int PostearByUnico(string nombreTabla, int valorUnico, DataTable data, string listaCamposAPostear)
        {
            int resultado = -1;
            string SSQL = "";
            string nombreCampo;
            string valor;
            string condicionWHERE = "";
            DateTime fecha;
            DataRow fila;
            string[] lista;
            DataColumn columna;

            try
            {

                SSQL = " UPDATE " + nombreTabla + " SET ";
                if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                else throw new Exception("Imposible Actualizar, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                //AGREGAMOS UNOS CAMPOS POR DEFECTO
                if (data.Columns.Contains("AUTOR_FECHA")) SSQL += ",AUTOR_FECHA =  GETDATE() ";
                if (data.Columns.Contains("AUTORFECHA")) SSQL += ",AUTORFECHA =  GETDATE() ";
                if (data.Columns.Contains("FECHA_MODIFICADO")) SSQL += ",FECHA_MODIFICADO =  GETDATE() ";
                if (data.Columns.Contains("FECHAMODIFICADO")) SSQL += ",FECHAMODIFICADO =  GETDATE() ";
                if (data.Columns.Contains("AUTORACCION")) SSQL += ",AUTORACCION = 'M' ";
                if (data.Columns.Contains("AUTOR_ACCION")) SSQL += ",AUTOR_ACCION = 'M' ";

                //ESTABLECEMOS LA CONDICION WHERE
                condicionWHERE = " WHERE Unico = " + valorUnico.ToString();

                //BUSCAMOS LA FILA A POSTEAR
                fila = data.Select("Unico = " + valorUnico.ToString())[0];

                //RECORREMOS LAS FILAS INDICADA PARA POSTEAR
                lista = listaCamposAPostear.Split(';');
                foreach (string item in lista)
                {

                    nombreCampo = item.Trim().ToUpper();
                    columna = data.Columns[nombreCampo];


                    //Obtenemos el Valor del DataTable, CASO ESPECIAL LOS CAMPOS DATETIME
                    if (columna.DataType == typeof(DateTime))
                    {
                        fecha = (DateTime)fila[nombreCampo];
                        valor = "'" + DateToInt(fecha).ToString() + "'";
                    }
                    else valor = "'" + fila[nombreCampo].ToString() + "'";


                    SSQL += ", " + nombreCampo + " = " + valor;

                }


                SSQL += " " + condicionWHERE;
                resultado = EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                resultado = -1;
                throw;
            }
            return resultado;
        }

        public int ActualizarFromParametros(string nombreTabla, string valorId, List<Parametro> parametros, string campoId = "Unico")
        {
            int resultado = 0;
            string SSQL = "";
            string condicionWHERE = "";
            DataTable data = new DataTable();

            try
            {
                SSQL = " SELECT TOP 0 * FROM " + nombreTabla;
                data = GetSQL(SSQL);

                SSQL = " UPDATE " + nombreTabla + " SET ";

                if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                else throw new Exception("Imposible Actualizar, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                //ESTABLECEMOS LA CONDICION WHERE
                condicionWHERE = " WHERE " + campoId + " = '" + valorId + "'";

                foreach (Parametro item in parametros)
                {
                    //SI ES EL CAMPO ID HACEMOS UN BRINCO
                    if (item.NombreCampo.Trim().ToUpper().Equals(campoId.Trim().ToUpper())) continue;

                    //VAMOS A OBTENER LOS VALORES A ACTUALIZAR
                    SSQL += ", " + item.NombreCampo.Trim() + " = '" + item.Valor + "'";

                }

                //Agregamos Campos Auditoria
                if (data.Columns.Contains("Autor_Fecha")) condicionWHERE += ", Autor_Fecha = GetDate() ";
                if (data.Columns.Contains("AutorFecha")) condicionWHERE += ", AutorFecha = GetDate() ";
                if (data.Columns.Contains("Fecha_Modificado")) condicionWHERE += ", Fecha_Modificado = GetDate() ";
                if (data.Columns.Contains("FechaModificado")) condicionWHERE += ", FechaModificado = GetDate() ";
                if (data.Columns.Contains("Autor_Accion")) condicionWHERE += ", Autor_Accion = 'M' ";
                if (data.Columns.Contains("AutorAccion")) condicionWHERE += ", AutorAccion = 'M' ";

                //VAMOS A EXCLUIR LOS REGISTRO YA MARCADO COMO ELIMINADO
                if (data.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                if (data.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                if (data.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                if (data.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                SSQL += " " + condicionWHERE;
                resultado = EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool IsCampoEnLista(string nombreCampo, string listaCampos, char separador = ';')
        {
            bool resultado = false;
            string[] lista;
            try
            {
                lista = listaCampos.Split(separador);
                for (int i = 0; i < lista.Count(); i++)
                {
                    if (nombreCampo.Trim().ToUpper().Equals(lista[i].Trim().ToUpper()))
                    {
                        resultado = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int MarcarRegistroNulo(string nombreTabla, string valorId, string campoId = "Unico")
        {
            int resultado = 0;
            string SSQL = "";
            string condicionWHERE = " WHERE ";
            DataTable data = new DataTable();
            try
            {
                //VALIDAMOS HAYA INDICADO NOMBRE DE USUARIO
                ValidarUsuario();

                condicionWHERE += campoId + " = '" + valorId + "'";
                SSQL = " SELECT TOP 1 * FROM " + nombreTabla + condicionWHERE;
                data = GetSQL(SSQL);
                if (data.Rows.Count > 0)
                {
                    //VAMOS A ESTRUTURAR LA INSTRUCCION UPDATE
                    SSQL = " UPDATE " + nombreTabla + " SET ";
                    if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                    else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                    else throw new Exception("Imposible Marcar Nulo, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                    //Marcamos Registro como Nulo
                    if (data.Columns.Contains("EsNulo"))
                    {
                        SSQL += ", EsNulo = 1";
                        condicionWHERE += " And IsNull(EsNulo, 0) = 0";
                    }
                    else if (data.Columns.Contains("Nulo"))
                    {
                        SSQL += ", Nulo = 1";
                        condicionWHERE += " And IsNull(Nulo, 0) = 0";
                    }
                    else throw new Exception("Imposible Marcar Nulo, En La Tabla No Existe Campo EsNulo y/o Nulo");

                    if (data.Columns.Contains("Autor_Fecha")) SSQL += ", Autor_Fecha = GETDATE()";
                    if (data.Columns.Contains("AutorFecha")) SSQL += ", AutorFecha = GETDATE()";
                    if (data.Columns.Contains("AutorAccion")) SSQL += ", AutorAccion = 'AN'";
                    if (data.Columns.Contains("Autor_Accion")) SSQL += ", Autor_Accion = 'AN'";
                    if (data.Columns.Contains("Fecha_Modificado")) SSQL += ", Fecha_Modificado = GETDATE()";
                    if (data.Columns.Contains("FechaModificado")) SSQL += ", FechaModificado = GETDATE()";
                    if (data.Columns.Contains("Anulado_Por")) SSQL += ", Anulado_Por = '" + NOMBRE_USUARIO + "'";

                    // FILTRAMOS REGISTRO MARCADO COMO ELIMINADOS
                    if (data.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                    if (data.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                    if (data.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                    if (data.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                    SSQL += condicionWHERE;
                    resultado = EjecutarSQL(SSQL);

                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int MarcarRegistroNoNulo(string nombreTabla, string valorId, string campoId = "Unico")
        {
            int resultado = 0;
            string SSQL = "";
            string condicionWHERE = " WHERE ";
            DataTable data = new DataTable();
            try
            {
                //VALIDAMOS HAYA INDICADO NOMBRE DE USUARIO
                ValidarUsuario();

                condicionWHERE += campoId + " = '" + valorId + "'";
                SSQL = " SELECT TOP 1 * FROM " + nombreTabla + condicionWHERE;
                data = GetSQL(SSQL);
                if (data.Rows.Count > 0)
                {
                    //VAMOS A ESTRUTURAR LA INSTRUCCION UPDATE
                    SSQL = " UPDATE " + nombreTabla + " SET ";
                    if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                    else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                    else throw new Exception("Imposible Marcar No Nulo, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                    //Marcamos Registro como No Nulo
                    if (data.Columns.Contains("EsNulo"))
                    {
                        SSQL += ", EsNulo = 0";
                        condicionWHERE += " And IsNull(EsNulo, 0) = 1";
                    }
                    else if (data.Columns.Contains("Nulo"))
                    {
                        SSQL += ", Nulo = 0";
                        condicionWHERE += " And IsNull(Nulo, 0) = 1";
                    }
                    else throw new Exception("Imposible Marcar No Nulo, En La Tabla No Existe Campo EsNulo y/o Nulo");

                    if (data.Columns.Contains("Autor_Fecha")) SSQL += ", Autor_Fecha = GETDATE()";
                    if (data.Columns.Contains("AutorFecha")) SSQL += ", AutorFecha = GETDATE()";
                    if (data.Columns.Contains("AutorAccion")) SSQL += ", AutorAccion = 'M'";
                    if (data.Columns.Contains("Autor_Accion")) SSQL += ", Autor_Accion = 'M'";
                    if (data.Columns.Contains("Fecha_Modificado")) SSQL += ", Fecha_Modificado = GETDATE()";
                    if (data.Columns.Contains("FechaModificado")) SSQL += ", FechaModificado = GETDATE()";
                    if (data.Columns.Contains("Anulado_Por")) SSQL += ", Anulado_Por = NULL";

                    // FILTRAMOS REGISTRO MARCADO COMO ELIMINADOS
                    if (data.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                    if (data.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                    if (data.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                    if (data.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                    SSQL += condicionWHERE;
                    resultado = EjecutarSQL(SSQL);

                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int MarcarRegistroActivo(string nombreTabla, string valorId, string campoId = "Unico")
        {
            int resultado = 0;
            string SSQL = "";
            string condicionWHERE = " WHERE ";
            DataTable data = new DataTable();
            try
            {
                //VALIDAMOS HAYA INDICADO NOMBRE DE USUARIO
                ValidarUsuario();

                condicionWHERE += campoId + " = '" + valorId + "'";
                SSQL = " SELECT TOP 1 * FROM " + nombreTabla + condicionWHERE;
                data = GetSQL(SSQL);
                if (data.Rows.Count > 0)
                {
                    //VAMOS A ESTRUTURAR LA INSTRUCCION UPDATE
                    SSQL = " UPDATE " + nombreTabla + " SET ";
                    if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                    else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                    else throw new Exception("Imposible Marcar Activo, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                    //Marcamos Registro como Activo
                    if (data.Columns.Contains("EsActivo"))
                    {
                        SSQL += ", EsActivo = 1";
                        condicionWHERE += " And IsNull(EsActivo, 0) = 0";
                    }
                    else if (data.Columns.Contains("Activo"))
                    {
                        SSQL += ", Activo = 1";
                        condicionWHERE += " And IsNull(Activo, 0) = 0";
                    }
                    else throw new Exception("Imposible Marcar Activo, En La Tabla No Existe Campo EsActivo y/o Activo");

                    if (data.Columns.Contains("Autor_Fecha")) SSQL += ", Autor_Fecha = GETDATE()";
                    if (data.Columns.Contains("AutorFecha")) SSQL += ", AutorFecha = GETDATE()";
                    if (data.Columns.Contains("AutorAccion")) SSQL += ", AutorAccion = 'AN'";
                    if (data.Columns.Contains("Autor_Accion")) SSQL += ", Autor_Accion = 'AN'";
                    if (data.Columns.Contains("Fecha_Modificado")) SSQL += ", Fecha_Modificado = GETDATE()";
                    if (data.Columns.Contains("FechaModificado")) SSQL += ", FechaModificado = GETDATE()";

                    //FILTRAMOS REGISTRO MARCADO COMO ELIMINADOS
                    if (data.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                    if (data.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                    if (data.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                    if (data.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                    SSQL += condicionWHERE;
                    resultado = EjecutarSQL(SSQL);

                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int MarcarRegistroNoActivo(string nombreTabla, string valorId, string campoId = "Unico")
        {
            int resultado = 0;
            string SSQL = "";
            string condicionWHERE = " WHERE ";
            DataTable data = new DataTable();
            try
            {
                //VALIDAMOS HAYA INDICADO NOMBRE DE USUARIO
                ValidarUsuario();

                condicionWHERE += campoId + " = '" + valorId + "'";
                SSQL = " SELECT TOP 1 * FROM " + nombreTabla + condicionWHERE;
                data = GetSQL(SSQL);
                if (data.Rows.Count > 0)
                {
                    //VAMOS A ESTRUTURAR LA INSTRUCCION UPDATE
                    SSQL = " UPDATE " + nombreTabla + " SET ";
                    if (data.Columns.Contains("Autor")) SSQL += " Autor = '" + NOMBRE_USUARIO + "'";
                    else if (data.Columns.Contains("Modificado_Por")) SSQL += " Modificado_Por = '" + NOMBRE_USUARIO + "'";
                    else throw new Exception("Imposible Marcar Activo, En La Tabla No Existe Campo Autor y/o Modificado_Por");

                    //Marcamos Registro como Activo
                    if (data.Columns.Contains("EsActivo"))
                    {
                        SSQL += ", EsActivo = 0";
                        condicionWHERE += " And IsNull(EsActivo, 0) = 0";
                    }
                    else if (data.Columns.Contains("Activo"))
                    {
                        SSQL += ", Activo = 0";
                        condicionWHERE += " And IsNull(Activo, 0) = 0";
                    }
                    else throw new Exception("Imposible Marcar Activo, En La Tabla No Existe Campo EsActivo y/o Activo");

                    if (data.Columns.Contains("Autor_Fecha")) SSQL += ", Autor_Fecha = GETDATE()";
                    if (data.Columns.Contains("AutorFecha")) SSQL += ", AutorFecha = GETDATE()";
                    if (data.Columns.Contains("AutorAccion")) SSQL += ", AutorAccion = 'AN'";
                    if (data.Columns.Contains("Autor_Accion")) SSQL += ", Autor_Accion = 'AN'";
                    if (data.Columns.Contains("Fecha_Modificado")) SSQL += ", Fecha_Modificado = GETDATE()";
                    if (data.Columns.Contains("FechaModificado")) SSQL += ", FechaModificado = GETDATE()";

                    //FILTRAMOS REGISTRO MARCADO COMO ELIMINADOS
                    if (data.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                    if (data.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                    if (data.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                    if (data.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                    SSQL += condicionWHERE;
                    resultado = EjecutarSQL(SSQL);

                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int MarcarRegistroEliminado(string nombreTabla, string valorId, string campoId = "Unico")
        {
            int resultado = 0;
            string SSQL = "";
            string condicionWHERE = " WHERE ";
            DataTable data = new DataTable();
            try
            {
                //VALIDAMOS HAYA INDICADO NOMBRE DE USUARIO
                ValidarUsuario();

                condicionWHERE += campoId + " = '" + valorId + "'";
                SSQL = " SELECT TOP 1 * FROM " + nombreTabla + condicionWHERE;
                data = GetSQL(SSQL);
                if (data.Rows.Count > 0)
                {
                    //VAMOS A ESTRUTURAR LA INSTRUCCION UPDATE
                    SSQL = " UPDATE " + nombreTabla + " SET ";
                    if (data.Columns.Contains("Fecha_Deleted"))
                    {
                        SSQL += " Fecha_Deleted = GetDate() ";
                        condicionWHERE += " And Fecha_Deleted Is Null ";
                    }
                    else if (data.Columns.Contains("FechaDeleted"))
                    {
                        SSQL += " FechaDeleted = GetDate() ";
                        condicionWHERE += " And FechaDeleted Is Null";
                    }
                    else if (data.Columns.Contains("Fecha_Eliminado"))
                    {
                        SSQL += " Fecha_Eliminado = GetDate() ";
                        condicionWHERE += " And Fecha_Eliminado Is Null";
                    }
                    else if (data.Columns.Contains("FechaEliminado"))
                    {
                        SSQL += " FechaEliminado = GetDate() ";
                        condicionWHERE += " And FechaEliminado Is Null";
                    }
                    else throw new Exception("Imposible Eliminar, No Existen Campos Para Marcar como Eliminado");

                    if (data.Columns.Contains("Autor_Fecha")) SSQL += ", Autor_Fecha = GETDATE()";
                    if (data.Columns.Contains("AutorFecha")) SSQL += ", AutorFecha = GETDATE()";
                    if (data.Columns.Contains("AutorAccion")) SSQL += ", AutorAccion = 'D'";
                    if (data.Columns.Contains("Autor_Accion")) SSQL += ", Autor_Accion = 'D'";

                    SSQL += condicionWHERE;
                    resultado = EjecutarSQL(SSQL);

                }

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DataTable GetSQL(string SSQL)
        {
            DataTable resultado = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter();
            try
            {
                AbrirConeccion();
                ada = new SqlDataAdapter(SSQL, OConn);
                ada.SelectCommand.CommandTimeout = timeOut;

                if (objTrans != null) ada.SelectCommand.Transaction = objTrans;

                ada.Fill(resultado);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CerrarConeccion();
                ada.Dispose();
            }

            return resultado;
        }

        public DataTable GetById(string nombreTabla, string valorId, string campoId = "Unico")
        {
            DataTable resultado = new DataTable();
            string SSQL = "";
            try
            {
                SSQL = " SELECT TOP 0 * FROM " + nombreTabla;
                resultado = GetSQL(SSQL);

                if ((campoId.ToUpper() == "CEDULA") || (campoId.ToUpper() == "RCN") || (campoId.ToUpper() == "CEDULARNC"))
                {
                    SSQL = " SELECT * FROM " + nombreTabla + " WHERE REPLACE(" + campoId + ", '-', '') = '" + valorId + "' ";
                }
                else SSQL = " SELECT * FROM " + nombreTabla + " WHERE " + campoId + " = '" + valorId + "' ";

                //FILTRAMOS REGISTRO MARCADO COMO ELIMINADOS
                if (resultado.Columns.Contains("Fecha_Eliminado")) SSQL += " And Fecha_Eliminado IS NULL";
                if (resultado.Columns.Contains("FechaEliminado")) SSQL += " And FechaEliminado IS NULL";
                if (resultado.Columns.Contains("Fecha_Deleted")) SSQL += " And Fecha_Deleted IS NULL";
                if (resultado.Columns.Contains("FechaDeleted")) SSQL += " And FechaDeleted IS NULL";

                //EJECUTAMOS LA CONSULTA
                resultado = GetSQL(SSQL);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public DataTable GetAll(string nombreTabla, int limite = 50, List<string> listaFiltros = null)
        {
            DataTable resultado = new DataTable();
            string SSQL = "";
            string condicionWHERE = " Where 1=1 ";
            string condicionOrderBy = "";

            try
            {
                SSQL = " SELECT TOP 0 * FROM " + nombreTabla;
                resultado = GetSQL(SSQL);

                //FILTRAMOS REGISTRO MARCADO COMO ELIMINADOS
                if (resultado.Columns.Contains("Fecha_Eliminado")) condicionWHERE += " And Fecha_Eliminado IS NULL";
                if (resultado.Columns.Contains("FechaEliminado")) condicionWHERE += " And FechaEliminado IS NULL";
                if (resultado.Columns.Contains("Fecha_Deleted")) condicionWHERE += " And Fecha_Deleted IS NULL";
                if (resultado.Columns.Contains("FechaDeleted")) condicionWHERE += " And FechaDeleted IS NULL";

                SSQL = " SELECT ";
                if (limite > 0) SSQL += " TOP " + limite.ToString();

                SSQL += " * FROM " + nombreTabla + condicionWHERE;

                //APLICAMOS LOS FILTROS ESPECIFICADO
                if (listaFiltros != null)
                {
                    foreach (string item in listaFiltros)
                    {
                        if (item.Trim().ToUpper().Contains("ORDER BY"))
                        {
                            condicionOrderBy = item;
                        }
                        else SSQL += item + " ";
                    }
                }

                SSQL += " " + condicionOrderBy;
                resultado = GetSQL(SSQL);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DataTable GetData(string nombreTabla, int Limite, string OrderBy = "")
        {
            DataTable MyData = new DataTable();
            string SSQL = "";
            try
            {
                SSQL = " SELECT TOP " + Limite.ToString() + " * FROM " + nombreTabla + " " + OrderBy;
                MyData = GetSQL(SSQL);
            }
            catch (Exception)
            {

                throw;
            }

            return MyData;
        }

        public int EliminarDetalleTemporal(string nombreTabla, string temporalId, int itemNumero)
        {
            int resultado = -1;
            string SSQL = "";
            try
            {
                SSQL = "DELETE FROM " + nombreTabla + " WHERE IdentificadorTemp = '" + temporalId + "' And ItemNumero = " + itemNumero.ToString();
                resultado = EjecutarSQL(SSQL);
            }
            catch (Exception)
            {
                resultado = -1;
                throw;
            }

            return resultado;
        }

        public bool LimpiarDetalleTemporal(string tablaDetalle, string valorTemporalId)
        {
            bool resultado = false;
            string SSQL = "";

            try
            {
                SSQL = "DELETE FROM " + tablaDetalle + " WHERE IdentificadorTemp = '" + valorTemporalId + "'";
                resultado = (EjecutarSQL(SSQL) > 0);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int LimpiarTemporal(string nombreTablaEnc, string nombreTablaDet, string temporalId)
        {
            int resultado = 1;
            string SSQL = "";
            try
            {
                if (nombreTablaEnc != null)
                {
                    if (nombreTablaEnc.Trim() != "") SSQL = "DELETE FROM " + nombreTablaEnc + " WHERE IdentificadorTemp = '" + temporalId + "'; ";
                }


                if (nombreTablaDet != null)
                {
                    if (nombreTablaDet.Trim() != "") SSQL += "DELETE FROM " + nombreTablaDet + " WHERE IdentificadorTemp = '" + temporalId + "'; ";
                }

                SSQL += " DELETE FROM TTEMPORAL_DESGLOSE_PAGO_ENTIDAD WHERE IdentificadorTemp = '" + temporalId + "'; ";
                if (SSQL.Trim() != "") resultado = EjecutarSQL(SSQL);

            }
            catch (Exception)
            {
                resultado = -1;
                throw;
            }

            return resultado;
        }

        public int AnularLineaDetalleTemporal(string nombreTabla, string temporalId, int itemNumero)
        {
            int resultado = -1;
            string SSQL = "";
            try
            {
                SSQL = " Update " + nombreTabla +
                       " Set ItemNumero = abs(ItemNumero) * -1 " +
                       " WHERE IdentificadorTemp = '" + temporalId + "' And ItemNumero = " + itemNumero.ToString() +
                       "       And ItemNumero > 0";

                resultado = EjecutarSQL(SSQL);
            }
            catch (Exception)
            {
                resultado = -1;
                throw;
            }

            return resultado;
        }

        public int ValidarUsuarioPassword(string nombreUsuario, string Clave, string nombrePC = "", string direccionIP = "")
        {

            int Resultado = -1;
            SqlCommand Comando = new SqlCommand();
            try
            {
                MENSAJE = "";
                Comando.Connection = OConn;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "SP_ACCESOS_INICIAR_SESSION";

                Comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                Comando.Parameters.AddWithValue("@clave", Clave);
                Comando.Parameters.AddWithValue("@nombrePC", nombrePC);
                Comando.Parameters.AddWithValue("@direccionIP", direccionIP);

                //AGREGAMOS PARAMETROS DE SALIDA
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@msg";
                param.DbType = DbType.String;
                param.Size = 150;
                param.Direction = ParameterDirection.Output;
                param.Value = "";

                Comando.Parameters.Add(param);

                SqlParameter returnValue = new SqlParameter("@Return_Value", DbType.Int32);
                returnValue.Direction = ParameterDirection.ReturnValue;
                Comando.Parameters.Add(returnValue);
                Comando.CommandTimeout = timeOut;

                AbrirConeccion();
                Comando.ExecuteNonQuery();

                MENSAJE = Comando.Parameters["@msg"].Value.ToString();
                Resultado = Int32.Parse(Comando.Parameters["@Return_Value"].Value.ToString());

            }
            catch (Exception ex)
            {

                Resultado = -1;
                throw ex;
            }
            finally
            {

                CerrarConeccion();
            }

            return Resultado;
        }

        public int CambiarClaveUsuario(string nombreUsuario, string claveActual, string claveNueva)
        {

            int Resultado = -1;
            SqlCommand Comando = new SqlCommand();
            try
            {
                MENSAJE = "";
                Comando.Connection = OConn;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "SP_CAMBIAR_PASSWORD_USUARIO";

                Comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                Comando.Parameters.AddWithValue("@claveActual", claveActual);
                Comando.Parameters.AddWithValue("@claveNueva", claveNueva);

                //AGREGAMOS PARAMETROS DE SALIDA
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@msg";
                param.DbType = DbType.String;
                param.Size = 150;
                param.Direction = ParameterDirection.Output;
                param.Value = "";

                Comando.Parameters.Add(param);

                SqlParameter returnValue = new SqlParameter("@Return_Value", DbType.Int32);
                returnValue.Direction = ParameterDirection.ReturnValue;
                Comando.Parameters.Add(returnValue);

                Comando.CommandTimeout = timeOut;
                AbrirConeccion();
                Comando.ExecuteNonQuery();

                MENSAJE = Comando.Parameters["@msg"].Value.ToString();
                Resultado = Int32.Parse(Comando.Parameters["@Return_Value"].Value.ToString());

            }
            catch (Exception ex)
            {

                Resultado = -1;
                throw ex;
            }
            finally
            {

                CerrarConeccion();
            }

            return Resultado;
        }

        public void GetFechasOficina(int oficinaID = 0, int empresaId = 0)
        {

            string SSQL = "Select Top 1 Fecha_Trabajo, Fecha_Contable FROM  TEMPRESAS_OFICINAS ";
            DataTable MyData;

            try
            {
                FECHA_TRABAJO = DateTime.Now.Date;
                FECHA_CONTABLE = DateTime.Now.Date;

                if (oficinaID <= 0) SSQL += " WHERE Tipo = 'P' ";
                else SSQL += " WHERE Oficina_Id =  " + oficinaID.ToString();

                if (empresaId > 0) SSQL += " AND Empresa_Id = " + empresaId.ToString();

                SSQL += " Order by Oficina_Id";

                MyData = GetSQL(SSQL);
                if (MyData.Rows.Count > 0)
                {
                    if (!(MyData.Rows[0]["Fecha_Trabajo"] is DBNull)) FECHA_TRABAJO = ((DateTime)MyData.Rows[0]["Fecha_Trabajo"]).Date;

                    if (!(MyData.Rows[0]["Fecha_Contable"] is DBNull)) FECHA_CONTABLE = ((DateTime)MyData.Rows[0]["Fecha_Contable"]).Date;
                    else FECHA_CONTABLE = FECHA_TRABAJO;
                }


            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool SetFechaOficinas(DateTime fecha, int oficinaId = 0, int empresaId = 0)
        {
            bool resultado = false;
            string SSQL = "";

            try
            {
                SSQL = " UPDATE TEMPRESAS_OFICINAS " +
                       "  SET FECHA_TRABAJO = '" + DateToInt(fecha).ToString() + "' " +
                       " WHERE 1= 1 ";

                if (oficinaId > 0) SSQL += " And Oficina_Id = " + oficinaId.ToString();
                if (empresaId > 0) SSQL += " And Empresa_Id = " + empresaId.ToString();

                EjecutarSQL(SSQL);

                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DateTime GetFechaProcesos(int empresaId = 0)
        {
            DateTime fecha = DateTime.Now.Date;
            string SSQL = "";
            DataTable data;

            try
            {
                SSQL = "SELECT Max(FECHA) as Fecha FROM TSISTEMA_PROCESOS_CONTROL WHERE Fecha_Cierre Is Null ";
                data = GetSQL(SSQL);
                if (data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["Fecha"] is DBNull)) fecha = (DateTime)data.Rows[0]["Fecha"];
                }
            }
            catch (Exception)
            {

                throw;
            }

            return fecha;
        }

        public bool EsFechaTrabajoEnCierre(DateTime fecha)
        {
            bool resultado = false;
            string SSQL = "";
            DataTable DTData = null;
            int totalRegistro = 0;

            try
            {
                SSQL = " SELECT COUNT(*) as Conteo FROM TSISTEMA_PROCESOS_CONTROL WHERE Cast(Fecha as Date) = '" + DateToInt(fecha).ToString() + "' " +
                       " And (Fecha_Cierre Is Not Null Or Cierre_Iniciado Is Not Null) ";

                DTData = GetSQL(SSQL);
                totalRegistro = int.Parse(DTData.Rows[0][0].ToString());

                if (totalRegistro > 0) resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DTData = null;
            }

            return resultado;
        }

        public bool InicializarProcesos()
        {
            bool resultado = true;
            List<Parametro> parametros = new List<Parametro>();

            try
            {


                parametros.Add(new Parametro("Autor", NOMBRE_USUARIO));
                parametros.Add(new Parametro("Msg", ""));

                resultado = (EjecutarSP("SP_PROCESOS_INICIAR", parametros) > 0);

            }
            catch (Exception ex)
            {

                MENSAJE = ex.Message;
            }

            return resultado;
        }

        public DataTable GetOpcionesUsuario(string nombreUsuario)
        {
            DataTable DTData = null;
            string SSQL = "";

            try
            {

                SSQL += " SELECT DISTINCT Menu_Id, Nombre, Modulo_Id, " +
                       " TipoFormulario, Formulario_AEjecutar, Titulo, EsModal, Proximo, Image, OrdenNo, EsMenuConsulta " +
                       " FROM VOPCIONES_X_USUARIOS " +
                       " WHERE Nombre_Usuario = '" + nombreUsuario.Trim() + "'" +
                       " And IsNull(Formulario_AEjecutar, '') <> '' " +
                       " Order by Modulo_Id, OrdenNo, EsMenuConsulta ";

                DTData = GetSQL(SSQL);

            }
            catch (Exception)
            {

                throw;
            }

            return DTData;
        }

        public string GetValorVariable(string variable)
        {
            string resultado = "";
            string SSQL = "";
            DataTable DTData = null;

            try
            {
                SSQL = "SELECT VALOR FROM TSISTEMA_VARIABLES WHERE Variable = '" + variable.Trim() + "'" +
                       " And Fecha_Deleted Is Null ";

                DTData = GetSQL(SSQL);

                if (DTData.Rows.Count > 0) resultado = DTData.Rows[0]["Valor"].ToString().Trim();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DTData = null;
            }

            return resultado;
        }

        public bool GetValorVariableAsBool(string variable)
        {
            bool resultado = false;
            string valor = "";
            int nValor = 0;

            try
            {
                valor = GetValorVariable(variable.Trim());
                int.TryParse(valor, out nValor);

                resultado = (valor.Trim().ToUpper() == "TRUE" || nValor > 0);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DataTable GetFromSP(string nombreSP, string temporalId = "", List<Parametro> parms = null)
        {
            DataTable DTData = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            bool esMsg = false;

            try
            {
                cmd = new SqlCommand(nombreSP, OConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP.Trim();
                cmd.Connection = OConn;

                if (temporalId.Trim() != "") cmd.Parameters.AddWithValue("@IdentificadorTemp", temporalId.Trim());
                ada = new SqlDataAdapter(cmd);

                foreach (Parametro item in parms)
                {
                    if ((item.EsSalida == true) || (item.NombreCampo.ToUpper() == "MSG"))
                    {
                        if (esMsg == false) esMsg = (item.NombreCampo.ToUpper() == "MSG");

                        SqlParameter param = new SqlParameter();

                        if (item.NombreCampo.ToUpper() == "MSG")
                        {
                            param.ParameterName = "@msg";
                            param.DbType = DbType.String;
                            param.Size = 150;
                            param.Direction = ParameterDirection.Output;
                            param.Value = "";
                        }
                        else
                        {

                            param.ParameterName = "@" + item.NombreCampo.Trim();
                            param.Direction = ParameterDirection.Output;
                            param.Value = item.Valor;
                        }

                        cmd.Parameters.Add(param);
                    }
                    else cmd.Parameters.AddWithValue("@" + item.NombreCampo.Trim(), item.Valor);

                }

                cmd.CommandTimeout = timeOut;
                if (objTrans != null) cmd.Transaction = objTrans;
                AbrirConeccion();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(DTData);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CerrarConeccion();
                cmd.Dispose();
                ada.Dispose();
            }

            return DTData;
        }

        public int GetIdUltimoBK()
        {
            string SSQL = "";
            int resultado = 0;
            DataTable Data = null;
            DateTime fecha = DateTime.Now.Date;

            try
            {
                SSQL = "SELECT TOP 1 FECHA FROM TSISTEMA_CONTROL_BACKUP ORDER BY FECHA Desc";
                Data = GetSQL(SSQL);
                if (Data.Rows.Count > 0)
                {
                    fecha = (DateTime)Data.Rows[0]["Fecha"];
                    resultado = DateToInt(fecha);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool ValidarLicense(string serialNumero, string cedulaRNC, string tipo)
        {
            string SSQL = "", codigo = "", _fechaLimite = "";
            int conteo1 = 0, conteo2 = 0, anio = 0, mes = 0, dia = 0;
            DateTime _feActual = DateTime.Now.Date, fechaVence = DateTime.Now;
            string[] miArray;
            bool resultado = false;
            DataTable DTData = null;
            ELREncript.Encript encript = new ELREncript.Encript();
            try
            {
                LICENCIA_LIMITE = 300;
                /*
                _feActual = DateTime.Now;
                cedulaRNC = cedulaRNC.Replace("-", "").Trim();
                SSQL = "SELECT * FROM TSISTEMA_LICENCIAS " +
                     " WHERE PWDCOMPARE('" + serialNumero + "', Serial_Numero) = 1 " +
                     "       OR PWDCOMPARE('" + cedulaRNC + tipo + "', Serial_Numero) = 1 ";

                DTData = GetSQL(SSQL);
                foreach (DataRow item in DTData.Rows)
                {
                    codigo = GetAsString("Codigo_Activacion", item);
                    codigo = encript.desencriptar(codigo).Replace("\0", "").Trim();
                    miArray = codigo.Split('|');
                    codigo = miArray[0].Replace("-", "");
                    if (codigo == serialNumero || codigo == cedulaRNC)
                    {
                        _fechaLimite = DateToInt(_feActual).ToString();
                        _fechaLimite = miArray[1];
                        anio = int.Parse(_fechaLimite.Substring(0, 4));
                        mes = int.Parse(_fechaLimite.Substring(4, 2));
                        dia = int.Parse(_fechaLimite.Substring(6, 2));
                        if (mes > 12) mes = 12;
                        if (dia > 31) dia = 31;
                        fechaVence = new DateTime(anio, mes, dia);
                        dia = (int)(fechaVence - _feActual).TotalDays;
                        if (dia > LICENCIA_LIMITE) LICENCIA_LIMITE = dia;
                    }
                }
                if (LICENCIA_LIMITE <= 0)
                {
                    LICENCIA_LIMITE = 30;
                    SSQL = " SELECT COUNT( DISTINCT Cast(Fecha_Adicionado as DATE)) as conteo " +
                           " FROM TVENTAS " +
                           " WHERE Fecha_Adicionado >= '20160608' ";

                    DTData = GetSQL(SSQL);
                    conteo1 = GetAsInt("Conteo", DTData.Rows[0]);
                    if (conteo1 < 30)
                    {
                        //BUSCAMOS EN PRESTAMOS REGISTRADOS
                        SSQL = " SELECT COUNT( DISTINCT Cast(Fecha_Adicionado as DATE)) as conteo " +
                               " FROM  TPRESTAMOS " +
                               " WHERE Fecha_Adicionado >= '20160608' ";

                        DTData = GetSQL(SSQL);
                        conteo2 = GetAsInt("Conteo", DTData.Rows[0]);
                    }

                    if (conteo1 > conteo2) LICENCIA_LIMITE = (LICENCIA_LIMITE - conteo1);
                    else LICENCIA_LIMITE = (LICENCIA_LIMITE - conteo2);
                }
                */
                resultado = (LICENCIA_LIMITE >= -10);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int GetDiasRestanteSinLicencias()
        {
            return LICENCIA_LIMITE;
            
        }

        public object GetValue(string nombreCampo, DataRow fila)
        {
            object resultado = "";
            try
            {
                isString = false;
                if (!fila.Table.Columns.Contains(nombreCampo))
                {
                    resultado = nombreCampo.ToUpper() + " !!NO EXISTE!!";
                }
                else
                {
                    DataColumn col = fila.Table.Columns[nombreCampo.Trim()];
                    if (col.DataType == typeof(DateTime)) resultado = GetAsDate(nombreCampo, fila);
                    else if (col.DataType == typeof(TimeSpan)) resultado = GetAsDate(nombreCampo, fila);
                    else if (col.DataType == typeof(decimal)) resultado = GetAsDouble(nombreCampo, fila);
                    else if (col.DataType == typeof(double)) resultado = GetAsDouble(nombreCampo, fila);
                    else if (col.DataType == typeof(bool)) resultado = GetAsBoolean(nombreCampo, fila);
                    else if (col.DataType == typeof(Int64)) resultado = GetAsInt(nombreCampo, fila);
                    else if (col.DataType == typeof(Int32)) resultado = GetAsInt(nombreCampo, fila);
                    else if (col.DataType == typeof(Int16)) resultado = GetAsInt(nombreCampo, fila);
                    else if (col.DataType == typeof(int)) resultado = GetAsInt(nombreCampo, fila);
                    else
                    {
                        resultado = GetAsString(nombreCampo, fila);
                        isString = true;
                    }
                }
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
                resultado = valorPorDefecto;

                if (dr != null)
                {
                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = double.Parse(dr[nombreCampo.Trim()].ToString());
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");

                }
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

                if (dr != null)
                {

                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = int.Parse(dr[nombreCampo.Trim()].ToString());
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                }


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Int32 GetAsInt32(string nombreCampo, DataRow dr, Int32 valorPorDefecto = 0)
        {
            Int32 resultado = 0;

            try
            {
                resultado = valorPorDefecto;

                if (dr != null)
                {

                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = Int32.Parse(dr[nombreCampo.Trim()].ToString());
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                }


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Int64 GetAsInt64(string nombreCampo, DataRow dr, Int64 valorPorDefecto = 0)
        {
            Int64 resultado = 0;

            try
            {
                resultado = valorPorDefecto;

                if (dr != null)
                {

                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = Int64.Parse(dr[nombreCampo.Trim()].ToString());
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                }


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Int16 GetAsInt16(string nombreCampo, DataRow dr, Int16 valorPorDefecto = 0)
        {
            Int16 resultado = 0;

            try
            {
                resultado = valorPorDefecto;

                if (dr != null)
                {

                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = Int16.Parse(dr[nombreCampo.Trim()].ToString());
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                }


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

                if (dr != null)
                {

                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = dr[nombreCampo.Trim()].ToString();
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                }

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

        public DateTime GetAsDate(string nombreCampo, DataRow dr, bool restar100IsNull = false)
        {
            DateTime resultado = DateTime.Now.Date.AddYears(-100);

            try
            {
                if (dr != null)
                {
                    if (dr.Table.Columns.Contains(nombreCampo.Trim()))
                    {
                        if (!(dr[nombreCampo.Trim()] is DBNull)) resultado = (DateTime)dr[nombreCampo.Trim()];
                        else if (restar100IsNull) resultado = resultado.AddYears(-100);
                    }
                    else throw new Exception("El Campo, " + nombreCampo.Trim() + ", No Existe");
                }

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

        public int GetDateAsInt(string nombreCampo, DataRow dr)
        {
            int resultado = 0;
            DateTime fecha;

            try
            {
                if (!(dr[nombreCampo] is DBNull))
                {
                    fecha = (DateTime)dr[nombreCampo];
                    resultado = (fecha.Year * 10000) + (fecha.Month * 100) + fecha.Day;
                }


            }
            catch (Exception)
            {
                resultado = 0;
                throw;
            }

            return resultado;
        }

        public int GetConteoAsientos()
        {
            int resultado = 0;
            string SSQL = "";
            DataTable DTData = null;
            try
            {
                SSQL = "SELECT COUNT(*) as conteo FROM TCONTA_DIARIO WHERE EsNulo = 0 ";
                DTData = GetSQL(SSQL);
                resultado = GetAsInt("conteo", DTData.Rows[0]);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
    }
}
