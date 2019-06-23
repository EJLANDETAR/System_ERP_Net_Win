using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace WinControl_ELR_NET
{
    public class ELRDatePicker: System.Windows.Forms.DateTimePicker
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
        public DateTime ValorPorDefecto { get; set; }

        [Category("PropiedadesELR")]
        public string FiltroBusqueda { get; set; }

        [Category("PropiedadesELR")]
        public Valida[] AValidar { get; set; }

        public void SetValorEnDS(int posicion = 0)
        {
            TimeSpan hora;
            DateTime valor;

            try
            {
                if (DSData != null)
                {
                    if (NombreTabla.Trim() == "")
                    {
                        

                        if ( (DSData.Tables[0].Rows[posicion][CampoData] is TimeSpan) || (this.Format == System.Windows.Forms.DateTimePickerFormat.Time) )
                        {
                            valor = this.Value;

                            hora = new TimeSpan(valor.Hour, valor.Minute, valor.Second);
                            DSData.Tables[0].Rows[posicion][CampoData] = hora;
                        }
                        else DSData.Tables[0].Rows[posicion][CampoData] = this.Value;
                    }
                    else
                    {
                        if ((DSData.Tables[NombreTabla].Rows[posicion][CampoData] is TimeSpan) || (this.Format == System.Windows.Forms.DateTimePickerFormat.Time))
                        {
                            valor = this.Value;

                            hora = new TimeSpan(valor.Hour, valor.Minute, valor.Second);
                            DSData.Tables[NombreTabla].Rows[posicion][CampoData] = hora;
                        }
                        else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Value;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GetValorFromDS(bool esNuevo, int posicion = 0)
        {
            DateTime valor;
            TimeSpan hora;
            DateTime fechaActual = DateTime.Now.Date;

            try
            {
                if (DSData != null)
                {
                    if (esNuevo) this.Value = ValorPorDefecto;
                    else if (NombreTabla.Trim() == "")
                    {
                        if (DSData.Tables[0].Rows[posicion][CampoData] is DBNull) valor = DateTime.Now;
                        else
                        {
                            if (DSData.Tables[0].Rows[posicion][CampoData] is TimeSpan)
                            {
                                hora = (TimeSpan) DSData.Tables[0].Rows[posicion][CampoData];
                                valor = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, hora.Hours, hora.Minutes, hora.Seconds);
                            }
                            else valor = (DateTime)DSData.Tables[0].Rows[posicion][CampoData];
                        }

                        this.Value = valor;
                    }
                    else
                    {
                        if (DSData.Tables[NombreTabla].Rows[posicion][CampoData] is DBNull) valor = DateTime.Now;
                        else
                        {
                            if (DSData.Tables[NombreTabla].Rows[posicion][CampoData] is TimeSpan)
                            {
                                hora = (TimeSpan)DSData.Tables[NombreTabla].Rows[posicion][CampoData];
                                valor = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, hora.Hours, hora.Minutes, hora.Seconds);
                            }
                            valor = (DateTime)DSData.Tables[NombreTabla].Rows[posicion][CampoData];
                        }

                        this.Value = valor;
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

        //CONSTRUCTOR DE LA CLASE
        public ELRDatePicker()
        {
            InitializeComponent();

            this.CampoData = "";
            this.NombreTabla = "";
            this.EsEditable = true;
            this.ValorPorDefecto = DateTime.Now.Date;
            this.FiltroBusqueda = "";
        }
    }
}
