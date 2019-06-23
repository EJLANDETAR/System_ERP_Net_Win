using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinControl_ELR_NET
{
    public partial class FormSplash : Form
    {

        private Thread _subProceso;
        private string _status = "Cargando";
        private int conteo = 0;

        public Thread subProceso;
        public int segundo;

        public FormSplash()
        {
            InitializeComponent();
        }

        private string DateToVersion(DateTime dt)
        {
            return dt.Year.ToString() + "." + dt.Month.ToString() + "." + dt.Day.ToString();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            //AGREGAMOS LOS MODULOS
            string dirActual = "";
            DateTime dt = new DateTime();
            ELRUtils util = new ELRUtils();
            try
            {
                dirActual = Environment.CurrentDirectory;
                lblModulos.Visible = (subProceso == null);
                lnkOcultar.Visible = (subProceso == null);
                lblMensaje.Visible = (subProceso != null);
                ptbProcess.Visible = (subProceso != null);
                if (subProceso == null)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    ControlBox = true;
                    //ShowInTaskbar = true;
                }
                else Size = new Size(554, 352);

                dt = util.GetBuildDate(dirActual + @"/ELRFacturas.dll");
                lblModulos.Text = "  Ventas o Facturacion  " + DateToVersion(dt) + "\n";
                

            }
            catch (Exception)
            {

                
            }

            if (subProceso != null)
            {
                tiempoVentana.Interval = 1000;
                _subProceso = subProceso;

                if (!tiempoVentana.Enabled)
                    tiempoVentana.Enabled = true;	// Activamos el Timer si no esta Enabled (activado)
            }
            conteo = 0;
        }

        private void tiempoVentana_Tick(object sender, EventArgs e)
        {
            if (subProceso != null)
            {
                tiempoVentana.Stop();               // Se para el timer.
                lblMensaje.Text = _status;

                if (_subProceso.IsAlive)
                {
                    // Una vez transcurrido el tiempo inicialmente establecido
                    // establezco un intervalo de un segundo para mirar si el proceso ha terminado.

                    if (tiempoVentana.Interval != 1000)
                        tiempoVentana.Interval = 1000;

                    conteo = 0;

                    tiempoVentana.Start();
                }
                else if (conteo >= 3)
                {
                    this.Close();
                }
                else tiempoVentana.Start();

                conteo++;

            }   
        }

        public void MostrarTexto(string texto)
        {
            try
            {
                _status = texto;
            }
            catch (Exception)
            {
                
               
            }
        }

        private void lnkOcultar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
