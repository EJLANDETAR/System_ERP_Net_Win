using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace WinControl_ELR_NET
{
    public class ELRLabel: System.Windows.Forms.Label
    {
        [Category("PropiedadesELR")]
        public DataSet DSData { get; set; }

        [Category("PropiedadesELR")]
        public string CampoData { get; set; }

        [Category("PropiedadesELR")]
        public string NombreTabla { get; set; }

        [Category("PropiedadesELR")]
        public string ValorPorDefecto { get; set; }

        public void SetValorEnDS(int posicion = 0)
        {
            try
            {
                if (DSData != null)
                {
                    if (NombreTabla.Trim() == "") DSData.Tables[0].Rows[posicion][CampoData] = this.Text;
                    else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Text;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValor(string valor, int posicion = 0)
        {
            this.Text = valor;

            if (DSData != null)
            {
                if (NombreTabla.Trim() == "") DSData.Tables[0].Rows[posicion][CampoData] = this.Text;
                else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Text;
            }
        }

        public void GetValorFromDS(bool esNuevo, int posicion = 0)
        {
            try
            {
                if (DSData != null)
                {
                    if (esNuevo) this.Text = ValorPorDefecto;
                    if (NombreTabla.Trim() == "") this.Text = DSData.Tables[0].Rows[posicion][CampoData].ToString();
                    else this.Text = DSData.Tables[NombreTabla].Rows[posicion][CampoData].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        //Constructor de la Clase
        public ELRLabel()
        {
            InitializeComponent();

            this.CampoData = "";
            this.NombreTabla = "";
            this.ValorPorDefecto = "";
        }

    }
}
