using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinControl_ELR_NET;

namespace SysProcesosERP
{
    public class Codigo
    {
        DataDB_ELR_NET.DataDB db;
        ELRUtils objUtil = new ELRUtils();

        public Codigo()
        {
            db = new DataDB_ELR_NET.DataDB();
            db.NOMBRE_USUARIO = "SYS";
        }

        public void RealizarBK()
        {
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            int resultado = -1;
            string pathBK = "";
            ELRFormMensajeErrores frmErrores = new ELRFormMensajeErrores();

            try
            {
                
                pathBK = db.GetValorVariable("BACKUP_PATH");

                temporalId = objUtil.GetTemporalID();

                parametros.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalId));
                parametros.Add(new DataDB_ELR_NET.Parametro("Autor", db.NOMBRE_USUARIO));

                resultado = db.EjecutarSP("SP_REALIZAR_BACKUP", parametros);

                if (resultado < 0)
                {
                    frmErrores.TemporalId = temporalId;
                    frmErrores.objDB = db;
                    frmErrores.ShowDialog();

                }

                if (resultado > 0) objUtil.MostrarMensajeInformacion("BACKUP REALIZADO DE FORMA SATISFACTORIA EN " + pathBK.ToUpper());

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                
                frmErrores.Dispose();
                db = null;
            }
        }

        public void GenerarAsientos()
        {
            string SSQL = "";
            DataTable DTData = null;
            int nErrores = 0, tipoId = 0;
            string valorUnico = "0", nombreSP = "";
            List<DataDB_ELR_NET.Parametro> myParms = new List<DataDB_ELR_NET.Parametro>();
            int fechaDesde, fechaHasta, resultado;
            DateTime fecha = DateTime.Now.Date;
            string temporalID = "";
            try
            {
                //return base.GetData();
                SSQL = " SELECT *, Cast(1 as bit) as EsAplicar ";
                SSQL += " FROM TCONTA_SP_GENERA_ASIENTOS ";
                SSQL += " WHERE EsActivo = 1 ";
                SSQL += " Order by Modulo_Id, NoOrden, Unico ";

                DTData = db.GetSQL(SSQL);

                fechaDesde = objUtil.DateToInt(objUtil.getPrimeraFechaMes(fecha));
                fechaHasta = objUtil.DateToInt(fecha);
                temporalID = objUtil.GetTemporalID();

                foreach (DataRow item in DTData.Rows)
                {

                    if (nErrores > 0) break;

                    valorUnico = objUtil.GetAsString("Unico", item);

                    nombreSP = objUtil.GetAsString("Nombre_SP", item);
                    tipoId = objUtil.GetAsInt("Tipo_Id", item);

                    myParms = new List<DataDB_ELR_NET.Parametro>();
                    myParms.Add(new DataDB_ELR_NET.Parametro("PFechaDesde", fechaDesde));
                    myParms.Add(new DataDB_ELR_NET.Parametro("PFechaHasta", fechaHasta));
                    myParms.Add(new DataDB_ELR_NET.Parametro("empresaId", 1));
                    myParms.Add(new DataDB_ELR_NET.Parametro("autor", db.NOMBRE_USUARIO));
                    myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    myParms.Add(new DataDB_ELR_NET.Parametro("TipoId", tipoId));

                    db.iniciarTransaccion();
                    resultado = db.EjecutarSP(nombreSP, myParms);
                    if (resultado < 0)
                    {
                        nErrores++;
                        //MostrarErrorTemporal();
                        db.cancelarTransaccion();
                        break;
                    }
                    else
                    {
                        db.confirmarTransaccion();
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
