using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace WinControl_ELR_NET
{
    public class ELRCheckBox: System.Windows.Forms.CheckBox
    {
        [Category("PropiedadesELR")]
        public DataSet DSData { get; set; }

        [Category("PropiedadesELR")]
        public string CampoData { get; set; }

        [Category("PropiedadesELR")]
        public bool EsEditable { get; set; }

        [Category("PropiedadesELR")]
        public bool EsModificable { get; set; }

        [Category("PropiedadesELR")]
        public string NombreTabla { get; set; }

        [Category("PropiedadesELR")]
        public bool ValorPorDefecto { get; set; }

        [Category("PropiedadesELR")]
        public string FiltroBusqueda { get; set; }

        public void SetValorEnDS(int posicion = 0)
        {
            try
            {
                if (DSData != null)
                {
                    if (NombreTabla.Trim() == "") DSData.Tables[0].Rows[posicion][CampoData] = this.Checked;
                    else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Checked;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GetValorFromDS(bool esNuevo, int posicion = 0)
        {
            try
            {
                if (DSData != null)
                {
                    if (esNuevo) this.Checked = ValorPorDefecto;
                    else if (NombreTabla.Trim() == "")
                    {
                        if (DSData.Tables[0].Rows[posicion][CampoData] is DBNull) this.Checked = false;
                        else this.Checked = (bool)DSData.Tables[0].Rows[posicion][CampoData];
                    }

                    else
                    {
                        if (DSData.Tables[NombreTabla].Rows[posicion][CampoData] is DBNull) this.Checked = false;
                        else this.Checked = (bool)DSData.Tables[NombreTabla].Rows[posicion][CampoData];
                    }
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

        //CONSTRUTOR DE LA CLASE
        public ELRCheckBox()
        {
            InitializeComponent();

            this.CampoData = "";
            this.NombreTabla = "";
            this.EsEditable = true;
            this.EsModificable = true;
            this.ValorPorDefecto = true;
            this.FiltroBusqueda = "";
        }
    }
}
