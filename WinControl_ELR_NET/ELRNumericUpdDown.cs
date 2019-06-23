using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinControl_ELR_NET
{
   public class ELRNumericUpdDown: System.Windows.Forms.NumericUpDown
    {

        [Category("PropiedadesELR")]
        public DataSet DSData { get; set; }

        [Category("PropiedadesELR")]
        public string CampoData { get; set; }

        [Category("PropiedadesELR")]
        public string NombreTabla { get; set; }

        [Category("PropiedadesELR")]
        public bool EsEditable { get; set; }

        [Category("PropiedadesELR")]
        public decimal ValorPorDefecto { get; set; }

        [Category("PropiedadesELR")]
        public Valida[] AValidar { get; set; }

        public ELRNumericUpdDown()
        {
            CampoData = "";
            NombreTabla = "";
            EsEditable = true;

            ValorPorDefecto = 0;
        }

        public void SetValorEnDS(int posicion = 0)
        {
            try
            {
                if (DSData != null)
                {
                    if (NombreTabla.Trim() == "") DSData.Tables[0].Rows[posicion][CampoData] = this.Value;
                    else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Value;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValor(decimal valor, int posicion = 0)
        {
            this.Value = valor;

            if (DSData != null)
            {
                if (NombreTabla.Trim() == "") DSData.Tables[0].Rows[posicion][CampoData] = this.Value;
                else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Value;
            }
        }

        public void GetValorFromDS(bool esNuevo, int posicion = 0)
        {
            try
            {
                if (DSData != null)
                {
                    if (esNuevo) this.Value = ValorPorDefecto;
                    else if (NombreTabla.Trim() == "")
                    {
                        if (DSData.Tables[0].Rows[posicion][CampoData] is DBNull) this.Value = ValorPorDefecto;
                        else this.Value = decimal.Parse( DSData.Tables[0].Rows[posicion][CampoData].ToString() );
                    }
                    else
                    {
                        if (DSData.Tables[NombreTabla].Rows[posicion][CampoData] is DBNull) this.Value= ValorPorDefecto;
                        else this.Value = decimal.Parse( DSData.Tables[NombreTabla].Rows[posicion][CampoData].ToString() );
                    }
                }

               
                if ((!esNuevo) && (this.Enabled)) this.Enabled = EsEditable;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
