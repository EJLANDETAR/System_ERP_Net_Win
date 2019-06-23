using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataDB_ELR_NET;

namespace SysProcesosERP
{
    public class Proceso
    {
        public int identificadorId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string identificadorTemp { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public Thread t { get; set; }
        public int estatusId { get; set; }
        public int tareaId { get; set; }
        public bool esReinicioOnError { get; set; }

        private DataDB_ELR_NET.DataDB db;
        private WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();
        private string nombreUsuario = "SYS";

        DataTable DTMsgERR = null;
        public string nombreSP = "";

        public Proceso()
        {
            try
            {
                db = new DataDB_ELR_NET.DataDB();
                db.NOMBRE_USUARIO = objUtil.nombreUsuarioPC;

                fechaDesde = DateTime.Now.Date;
                fecha = DateTime.Now.Date;
                fechaHasta = objUtil.getUltimaFechaMes(fechaDesde);
                estatusId = 0;
                tareaId = 0;
                esReinicioOnError = false;

            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public int addProceso(string codigo, string nombre, int tareaId = 0)
        {
            List<Parametro> parms = new List<Parametro>();
            identificadorId = -1;
            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                parms.Add(new Parametro("codigo", codigo));
                parms.Add(new Parametro("descripcion", nombre));
                parms.Add(new Parametro("autor", nombreUsuario));
                parms.Add(new Parametro("identificadorTemp", identificadorTemp));
                parms.Add(new Parametro("tareaId", tareaId));

                db.iniciarTransaccion();
                identificadorId = db.EjecutarSP("SP_SISTEMA_ADD_PROCESO", parms);

                if (identificadorId > 0)
                {
                    db.confirmarTransaccion();
                }
                else
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }

            }
            catch (Exception ex)
            {
                identificadorId = -1;
                RegistrarHistorialErrores(ex.Message);
            }

            return identificadorId;
        }

        public void limpiarTablasTemporales()
        {
            List<Parametro> parms = new List<Parametro>();
            int spReturn = 0;
            try
            {
                identificadorTemp = objUtil.GetTemporalID();
                parms.Add(new Parametro("IdentificadorTemp", identificadorTemp));
                db.iniciarTransaccion();
                spReturn = db.EjecutarSP("SP_SISTEMA_LIMPIA_TABLAS_TEMPORALES", parms);
                if (spReturn > 0)
                {
                    RegistrarSuccess();
                    db.confirmarTransaccion();
                }
                else
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }

            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public void realizarBackup()
        {
            List<Parametro> parms = new List<Parametro>();
            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                if (identificadorId <= 0)
                {
                    addProceso("BK", "REALIZAR BACKUP");
                }

                //Realizamos backup mediante un procedimiento alamcenado
                parms.Add(new Parametro("IdentificadorTemp", identificadorTemp));
                parms.Add(new Parametro("autor", "Sys.Proc"));
                parms.Add(new Parametro("IdentificadorId", identificadorId));
                nombreSP = "SP_REALIZAR_BACKUP";

                db.EjecutarSP(nombreSP, parms);
                RegistrarSuccess();

            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public void limpiarLogDB()
        {
            List<Parametro> parms = new List<Parametro>();
            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                if (identificadorId <= 0)
                {
                    addProceso("LIMPIAR_LOG_DB", "LIMPIAR LOG FILE DATABASE");
                }

                //LIMPIAMOS LOG FILE DE BASE DE DATOS
                nombreSP = "SP_LIMPIAR_LOG";

                db.EjecutarSP(nombreSP, parms);
                RegistrarSuccess();
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public void RebuildDBIndices()
        {
            List<Parametro> parms = new List<Parametro>();
            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                if (identificadorId <= 0)
                {
                    addProceso("RB-DB-INDICES", "RECONSTRUIR (REBUILD) DATABASE INDICES");
                }

                //EJECUTAMOS EL STORE PROCEDURES
                nombreSP = "SP_REBUILD_INDICES";

                db.EjecutarSP(nombreSP, parms);
                RegistrarSuccess();
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public DataTable GetHistorico(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable DTData = null;
            try
            {
                db.LimpiarFiltros();
                db.AddFiltroMayorOIgualA("Fecha_Inicio", db.DateToInt(fechaDesde).ToString());
                db.AddFiltroMenorA("Fecha_Inicio", db.DateToInt(fechaHasta.AddDays(1)).ToString());
                db.AddFiltroOrderBY("Fecha_Inicio Desc, Unico Desc");

                DTData = db.GetAll("TSISTEMA_PROCESOS_LOG", -1, db.Filtros);
                //dtgProcesos.DataSource = DTHistorico.DefaultView;
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }

            return DTData;
        }

        public DataTable GetErrorHistorico(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable DTData = null;
            try
            {
                db.LimpiarFiltros();
                db.AddFiltroMayorOIgualA("Fecha_Adicionado", db.DateToInt(fechaDesde).ToString());
                db.AddFiltroMenorA("Fecha_Adicionado", db.DateToInt(fechaHasta.AddDays(1)).ToString());
                db.AddFiltroOrderBY("Unico Desc");

                DTData = db.GetAll("TSISTEMA_HISTORIAL_ERRORES", -1, db.Filtros);
                //dtgProcesos.DataSource = DTHistorico.DefaultView;
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }

            return DTData;
        }

        public void realizarCierreOPE()
        {
            string descripcion;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            bool resultado = false;
            int cantErrores = 0;
            int valorId = 0;
            DataTable DTData;
            int feActual = 0, feTrabajo = 0;

            try
            {
                valorId = identificadorId;
                cantErrores = 0;
                resultado = false;
                feActual = objUtil.DateToInt(DateTime.Now);
                identificadorTemp = objUtil.GetTemporalID();

                //Buscamos la fecha de trabajo
                db.GetFechasOficina();
                feTrabajo = objUtil.DateToInt(db.FECHA_TRABAJO);

                db.LimpiarFiltros();
                db.AddFiltroOrderBY("OrdenNo");
                DTData = db.GetAll("TSISTEMA_PROCESOS_INTERNOS", -1, db.Filtros);


                if ((DTData.Rows.Count > 0) && (feTrabajo <= feActual))
                {
                    db.iniciarTransaccion();

                    parametros.Add(new DataDB_ELR_NET.Parametro("Fecha", feTrabajo));
                    parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));


                    foreach (DataRow item in DTData.Rows)
                    {
                        if (cantErrores == 0)
                        {
                            resultado = false;

                            nombreSP = item["Nombre_SP"].ToString();
                            descripcion = item["Descripcion"].ToString();

                            //EJECUTAMOS EL STORE PROCEDURE

                            if (db.EjecutarSP(nombreSP, parametros) < 0)
                            {
                                cantErrores++;
                                resultado = false;
                                break;
                            }

                            resultado = true;
                        }

                    }
                }

                if (resultado)
                {
                    RegistrarSuccess();
                    db.confirmarTransaccion();
                }
                else
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }


            }

            catch (Exception ex)
            {
                db.cancelarTransaccion();
                RegistrarHistorialErrores(ex.Message);

            }

        }

        public void generarDemora()
        {
            List<Parametro> parms = new List<Parametro>();
            DateTime feActual = DateTime.Now;
            int spReturn = 0;

            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("Fecha", db.DateToInt(feActual)));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorId", identificadorId));
                nombreSP = "SP_PROCESOS_GENERAR_DEMORA";

                db.iniciarTransaccion();
                spReturn = db.EjecutarSP(nombreSP, parms);
                if (spReturn > 0)
                {
                    RegistrarSuccess();
                    db.confirmarTransaccion();
                }
                else
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public void GenerarAFDepreciacion()
        {
            List<Parametro> parms = new List<Parametro>();
            int spReturn = 0;
            
            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                parms.Add(new DataDB_ELR_NET.Parametro("Fecha", db.DateToInt(fecha)));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", 1));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                db.iniciarTransaccion();
                spReturn = db.EjecutarSP("SP_ACTIVOS_FIJOS_GENERAR_DEPRE_TEMPORAL", parms);
                if (spReturn > 0)
                {
                    //APLICAMOS LA DEPRECIACION
                    parms = new List<Parametro>();
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                    spReturn = db.EjecutarSP("SP_ACTIVOS_FIJOS_GRABA_DEPRECIACION", parms);
                }

                if (spReturn >= 0)
                {
                    RegistrarSuccess();
                    db.confirmarTransaccion();
                }
                else
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
            finally
            {
                db.cancelarTransaccion();
            }
        }

        public void GenerarPagoGastosFijos()
        {
            List<Parametro> parms = new List<Parametro>();
            int spReturn = 0;
            DataTable DTData = null;
            try
            {
                identificadorTemp = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                db.iniciarTransaccion();
                DTData = db.GetFromSP("SP_GASTOS_FIJOS_PAGOS_ATEMPORAL", "", parms);
                if(DTData.Rows.Count > 0)
                {
                    //Confirmamos el pago de gastos fijos
                    parms = new List<Parametro>();
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                    spReturn = db.EjecutarSP("SP_GASTOS_FIJOS_APLICAR_PAGOS", parms);
                }

                if (spReturn >= 0)
                {
                    RegistrarSuccess();
                    db.confirmarTransaccion();
                }
                else 
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
            finally
            {
                db.cancelarTransaccion();
            }
        }

        void getErrorFromTemp()
        {
            string SSQL = "";
            try
            {
                SSQL = "SELECT * FROM TSISTEMA_MENSAJES_ERRORES WHERE IdentificadorTemp = '" + identificadorTemp.Trim() + "' ";
                DTMsgERR = db.GetSQL(SSQL);
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public void RegistrarHistorialErrores()
        {
            string SSQL = "";
            int result = 0;
            string mensaje = "";
            List<Parametro> parms = new List<Parametro>();

            try
            {
                if (esReinicioOnError) estatusId = 0;
                else estatusId = -1;

                db.cancelarTransaccion();

                if (DTMsgERR != null)
                {
                    foreach (DataRow item in DTMsgERR.Rows)
                    {
                        mensaje = db.GetAsString("Nombre_SP", item).Replace("'", "") + ", " + db.GetAsString("Mensaje", item).Replace("'", "");

                        SSQL = "INSERT INTO TSISTEMA_HISTORIAL_ERRORES (Identificador_Id, Tipo_Error, Nombre_SP, Linea_No, Mensaje, Codigo, Descripcion) ";
                        SSQL += " VALUES (";
                        SSQL += identificadorId.ToString() + ", ";
                        SSQL += db.GetAsInt("Tipo_Error", item).ToString() + ", ";
                        SSQL += "'" + db.GetAsString("Nombre_SP", item).Replace("'", "") + "', ";
                        SSQL += db.GetAsInt("Linea_No", item).ToString() + ", ";
                        SSQL += "'" + mensaje + "', ";
                        SSQL += "'" + codigo + "', ";
                        SSQL += "'" + nombre + "'";
                        SSQL += ") ";

                        result = db.EjecutarSQL(SSQL);
                    }
                }

                //CAMBIAMOS EL ESTATUS A LA TAREA
                setEstatus();
                setTareaEjecutada();
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
            }
        }

        public void RegistrarHistorialErrores(string mensaje)
        {
            string SSQL = "";
            int result = 0;
            List<Parametro> parms = new List<Parametro>();
            try
            {
                if (esReinicioOnError) estatusId = 0;
                else estatusId = -1;

                db.cancelarTransaccion();

                SSQL = "INSERT INTO TSISTEMA_HISTORIAL_ERRORES (Identificador_Id, Tipo_Error, Nombre_SP, Linea_No, Mensaje, Codigo, Descripcion) ";
                SSQL += " VALUES (";
                SSQL += identificadorId + ", ";
                SSQL += "-1, ";
                SSQL += "'" + nombreSP + "', ";
                SSQL += "0, ";
                SSQL += "'" + mensaje.Replace("'", "") + "', ";
                SSQL += "'" + codigo + "', ";
                SSQL += "'" + nombre + "'";
                SSQL += ") ";

                result = db.EjecutarSQL(SSQL);

                //CAMBIAMOS EL ESTATUS A LA TAREA
                setEstatus();
                setTareaEjecutada();
            }

            catch (Exception ex)
            {

                mensaje = ex.Message;
            }
        }

        public void RegistrarSuccess()
        {
            string SSQL = "";
            string mensaje = "";
            int result = 0;
            List<Parametro> parms = new List<Parametro>();

            try
            {
                estatusId = 2;
                mensaje = nombre.ToUpper() + ": COMPLETADO DE FORMA SATISFACTORIA";

                SSQL = "INSERT INTO TSISTEMA_HISTORIAL_ERRORES (Identificador_Id, Tipo_Error, Nombre_SP, Linea_No, Mensaje, Codigo, Descripcion) ";
                SSQL += " VALUES (";
                SSQL += identificadorId + ", ";
                SSQL += "1, ";
                SSQL += "'" + nombreSP + "', ";
                SSQL += "0, ";
                SSQL += "'" + mensaje + "', ";
                SSQL += "'" + codigo + "', ";
                SSQL += "'" + nombre + "'";
                SSQL += ") ";

                result = db.EjecutarSQL(SSQL);


                //Marcamos la tarea como completada
                parms = new List<Parametro>();
                parms.Add(new Parametro("IdentificadorId", identificadorId));
                db.EjecutarSP("SP_SISTEMA_MARCAR_PROCESO_COMPLETADO", parms);
                setTareaEjecutada();
            }

            catch (Exception)
            {


            }
        }

        public void generarContabilidad()
        {
            int feHasta = 0;
            List<Parametro> myParms = new List<Parametro>();
            int resultado = 0;

            try
            {
                identificadorTemp = objUtil.GetTemporalID();
                
                //Convertimos la fecha a int
                feHasta = objUtil.DateToInt(fecha);

                //Procedemos a ejecutar el store procedure
                myParms = new List<DataDB_ELR_NET.Parametro>();
                myParms.Add(new DataDB_ELR_NET.Parametro("fecha", feHasta));
                myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                myParms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                db.iniciarTransaccion();
                resultado = db.EjecutarSP("SP_CONTA_GENERAR_CONTABILIDAD_ALL", myParms);
                if (resultado < 0)
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();

                }
                else
                {
                    db.confirmarTransaccion();
                }


                if (resultado > 0)
                {
                    RegistrarSuccess();
                    identificadorId = -1;
                }


            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
            
        }

        public void setEstatus(int estatusId, int valorUnico)
        {
            string SSQL = "";
            string estatus = "";
            try
            {
                switch (estatusId)
                {
                    case -1:
                        estatus = "ERROR";
                        break;
                    case 0:
                        estatus = "EN COLA";
                        break;
                    case 1:
                        estatus = "EN PROCESO";
                        break;
                    case 2:
                        estatus = "COMPLEATADO";
                        break;
                    default:
                        break;
                }

                SSQL = "UPDATE TSISTEMA_PROCESOS_LOG Set Estatus_Id = " + estatusId.ToString() + ", ";
                SSQL += " Estatus = '" + estatus + "' ";

                if (estatusId < 0) SSQL += ", Fecha_Fin = GetDate() ";

                if (estatusId == 2)
                {
                    SSQL += " , Fecha_Completado = GetDate(), Fecha_Fin = GetDate() ";
                }

                SSQL += " WHERE Unico = " + valorUnico.ToString();
                db.EjecutarSQL(SSQL);
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public void setEstatus()
        {
            string SSQL = "";
            string estatus = "";
            try
            {
                switch (estatusId)
                {
                    case -1:
                        estatus = "ERROR";
                        break;
                    case 0:
                        estatus = "EN COLA";
                        break;
                    case 1:
                        estatus = "EN PROCESO";
                        break;
                    case 2:
                        estatus = "COMPLEATADO";
                        break;
                    default:
                        break;
                }

                SSQL = "UPDATE TSISTEMA_PROCESOS_LOG Set Estatus_Id = " + estatusId.ToString() + ", ";
                SSQL += " Estatus = '" + estatus + "' ";

                if (estatusId < 0) SSQL += ", Fecha_Fin = GetDate() ";

                if (estatusId == 2)
                {
                    SSQL += " , Fecha_Completado = GetDate(), Fecha_Fin = GetDate() ";
                }

                SSQL += " WHERE Identificador_Id = " + identificadorId.ToString();
                db.EjecutarSQL(SSQL);
                setTareaEjecutada();

            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        public int colocarPendienteACola()
        {
            int resultado = 0;
            string SSQL = "";

            try
            {
                SSQL = " UPDATE TSISTEMA_PROCESOS_LOG SET Estatus_Id = 0, Estatus = 'EN COLA' ";
                SSQL += " WHERE Estatus_Id = 1 And Fecha_Completado Is Null and Fecha_Fin Is Null ";

                resultado = db.EjecutarSQL(SSQL);
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }

            return resultado;
        }

        public void borrarFilesBK()
        {
            string carpeta = @"C:\BackupDB";
            int dias = 1;

            try
            {
                objUtil.BorraArchivosCarpeta(carpeta, dias);
                RegistrarSuccess();

            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }

        private void setTareaEjecutada()
        {
            string SSQL = "";
            try
            {
                SSQL = "UPDATE TSISTEMA_PROCESOS_SCHEDULE SET Fecha_Ultima_Ejecusion = GetDate(), Fecha_Ult_Cola = NULL WHERE Tarea_Id = " + tareaId.ToString();
                db.EjecutarSQL(SSQL);
            }
            catch (Exception)
            {


            }
        }

        public void EjecutaSP()
        {
            List<Parametro> parms = new List<Parametro>();
            int resultado = -1;
            try
            {
                identificadorTemp = objUtil.GetTemporalID();
                parms.Add(new Parametro("IdentificadorTemp", identificadorTemp));
                //db.iniciarTransaccion();
                resultado = db.EjecutarSP(nombreSP, parms);
                if (resultado > 0)
                {
                    db.confirmarTransaccion();
                    RegistrarSuccess();
                    identificadorId = -1;
                }

                if (resultado < 0)
                {
                    getErrorFromTemp();
                    db.cancelarTransaccion();

                    RegistrarHistorialErrores();
                }
            }
            catch (Exception ex)
            {

                RegistrarHistorialErrores(ex.Message);
            }
        }
    }

}
