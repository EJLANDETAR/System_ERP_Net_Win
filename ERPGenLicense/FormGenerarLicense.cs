using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPGenLicense
{
    public partial class FormGenerarLicense : Form
    {
        WinControl_ELR_NET.ELRUtils util = new WinControl_ELR_NET.ELRUtils();

        public FormGenerarLicense()
        {
            InitializeComponent();
        }

        

        void GenerarCodigo(int cantidadMeses = 1)
        {

            string codigo = "", archivo = "";
            string valor = "";
            DateTime fechaActual = DateTime.Now;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                valor = txtNumeroSerial.Text.Trim() + "|";
                if (cantidadMeses > 0) {
                    fechaActual = fechaActual.AddMonths(cantidadMeses);
                    fechaActual = util.getUltimaFechaMes(fechaActual);
                    valor += util.DateToInt(fechaActual);
                }
                else
                {
                    valor += "99999999";
                }
                               

                //AGREGAMOS EL TIPO
                valor += "|" + cboTipo.Text.Trim();

                codigo = util.GetCodigoActivacion(valor);
                txtCodigoActivacion.Text = codigo;

                archivo = System.Environment.CurrentDirectory + @"\" + cboTipo.Text.Trim() + "license.txt";
                //SI EL ARCHIVO EXISTE SE ELIMINA
                if (File.Exists(archivo)) File.Delete(archivo);

                StreamWriter sw = new StreamWriter(archivo);
                sw.WriteLine(codigo);
                sw.Close();
                util.MostrarMensajeInformacion(archivo);

                //CREAMOS OTRO ARCHIVO ESPECIFICANDO LOS DATOS GENERADOS
                archivo = System.Environment.CurrentDirectory + @"\license-generada.txt";
                if (File.Exists(archivo)) File.Delete(archivo);
                sw = new StreamWriter(archivo);
                sw.WriteLine("Tipo: " + cboTipo.Text.Trim());
                sw.WriteLine("Serial: " + txtNumeroSerial.Text.Trim());
                sw.WriteLine("Key: " + codigo);
                sw.Close();
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGenerarLicense_Load(object sender, EventArgs e)
        {
            
            txtNumeroSerial.CharacterCasing = CharacterCasing.Normal;
            txtCodigoActivacion.CharacterCasing = CharacterCasing.Normal;
            cboTipo.SelectedIndex = 0;           
            
        }

       
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidadMeses = 0;
            Button btn = null;
            try
            {
                btn = (Button)sender;
                if (btn == btnGenerar1) cantidadMeses = 1;
                else if (btn == btnGenerar3) cantidadMeses = 3;
                else if (btn == btnGenerar12) cantidadMeses = 12;
                else cantidadMeses = -1;

                GenerarCodigo(cantidadMeses);
                
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }
    }
}
