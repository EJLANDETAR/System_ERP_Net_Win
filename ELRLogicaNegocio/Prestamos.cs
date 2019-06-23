using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ELRLogicaNegocio
{
    public class Prestamos
    {
        public double GetCuota(double montoCredito, int plazo, double tasaAnual, string tipoSaldo = "I")
        {
            double tasa = 0;
            double caluclulo1 = 0;
            double resultado = 0;

            try
            {
                tipoSaldo = tipoSaldo.Trim().Substring(0, 1).ToUpper();

                if (tasaAnual <= 0) resultado = 0;
                else if ( ( tipoSaldo == "I") || (tipoSaldo == "0") )
                {
                    //SALDO INSOUTO
                    tasa = (tasaAnual / 12) / 100.0;
                    caluclulo1 = Math.Pow((1 + tasa), plazo);
                    resultado = montoCredito * ((tasa * caluclulo1) / (caluclulo1 - 1));
                }
                else
                {
                    tasa = tasaAnual / 100.0;
                    resultado = montoCredito * tasa * (plazo/12.0);
                    resultado = resultado + (resultado * tasa);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return Math.Abs(resultado);
        }

        public double GetCuotaFactura(double monto, int plazo, double tasaAnual,  double inicial)
        {
           
            double tasa, total = 0, interesMes = 0, totalInteres = 0, resultado = 0;

            try
            {
                tasa = tasaAnual / 12.0;
                total = monto - inicial;
                interesMes = (total * tasa) / 100.0;
                totalInteres = interesMes * plazo;

                total += totalInteres;
                resultado = total / plazo;
                
            }
            catch (Exception)
            {

                throw;
            }

            return Math.Abs(resultado);
        }

        public DataRow GetDocumentoPorAmortizar(DataDB_ELR_NET.DataDB db, int Id, string tipo)
        {
            DataRow fila = null;
            DataTable MyTabla = null;
            string SSQL = "";

            try
            {
                SSQL = "SELECT * FROM VDOCUMENTOS_PENDIENTE_AMORTIZAR WHERE Identificador_Id = " + Id.ToString() +
                       " And Tipo ='" + tipo.Trim() + "' ";

                MyTabla = db.GetSQL(SSQL);

                if (MyTabla.Rows.Count > 0) fila = MyTabla.Rows[0];

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                MyTabla.Dispose();
            }

            return fila;

        }
    }
}
