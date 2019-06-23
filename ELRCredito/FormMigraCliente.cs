using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ELRCredito
{
    public partial class FormMigraCliente : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormMigraCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void elrTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarArchivoCliente_Click(object sender, EventArgs e)
        {
            StreamReader streamDatos;
            string linea = null;
            string codigoCliente = "";
            string nombreCliente = "";
            string municipio = "";
            string tipo = "", factura = "", sFecha, recibo, sValor, origen, concepto = "";
            int anio, mes, dia;
            string[] AFecha;
            DateTime fecha;
            DataRow dr;
            OpenFileDialog ofdArchivoCliente = new OpenFileDialog();
            string nombreArchivo = "";
            int index = 0;

            int conteo = 0;
            int carACopiar = 0, longitudActual = 0, posActual = 0;
            try
            {
                string directorioActual = "";

                directorioActual = System.Environment.CurrentDirectory;

                if (Directory.Exists(directorioActual)) ofdArchivoCliente.InitialDirectory = directorioActual;
                

                LimpiarDetalleTemporal();

                this.Cursor = Cursors.WaitCursor;
                ofdArchivoCliente.Filter = "txt files (*.txt)|*.txt";

                
                if (ofdArchivoCliente.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                {
                    //Verificamos si el archivo existe en el directori actual
                    nombreArchivo = ofdArchivoCliente.SafeFileName;
                    nombreArchivo = directorioActual + @"\" + nombreArchivo;

                    if (nombreArchivo.ToUpper() != ofdArchivoCliente.FileName.ToUpper())
                    {

                        if (File.Exists(nombreArchivo)) File.Delete(nombreArchivo);

                        File.Copy(ofdArchivoCliente.FileName, nombreArchivo);
                    }

                    ofdArchivoCliente.FileName = nombreArchivo;
                    streamDatos = new StreamReader(nombreArchivo);

                    while ((linea = streamDatos.ReadLine()) != null)
                    {
                        conteo++;
                        linea = linea.Trim();
                        tipo = "";
                        factura = "";
                        sFecha = "";
                        recibo = "";
                        sValor = "0.00";
                        origen = "DR";
                        concepto = "";
                        fecha = DateTime.Now.Date;

                        if (linea == "") continue;

                        if (conteo == 6)
                        {
                            codigoCliente = linea.Substring(0, 7);
                            nombreCliente = linea.Substring(7, linea.Length - 7);
                            txtCodigo.Text = codigoCliente;
                            txtNombres.Text = nombreCliente;
                            continue;
                        }

                        //Buscamos el Municipio
                        if (conteo == 8)
                        {
                            municipio = linea;
                            txtMunicipio.Text = municipio;
                            continue;
                            
                        }

                        if (conteo == 7)
                        {
                            municipio = linea;
                            continue;
                        }

                        if (linea.Contains("-----")) continue;
                        if (linea.Contains("TIPO  FACTURA")) continue;

                        tipo = linea.Substring(0, 2).ToUpper();

                        if ((tipo == "FT") || (tipo == "ND") || (tipo == "NC") || (tipo == "RC"))
                        {
                            factura = linea.Substring(2, 12).Trim();
                            recibo = linea.Substring(14, 8).Trim();
                            sFecha = linea.Substring(22, 11).Trim();
                            sValor = linea.Substring(33, 13).Trim();

                            longitudActual = 47;
                            posActual = 46;
                            if (linea.Length > longitudActual)
                            {

                                origen = linea.Substring(posActual, 2).Trim();
                                if (origen.Trim() != "")
                                {
                                    longitudActual = 49;
                                    posActual = 48;
                                }   

                            }

                            if (origen.Trim() == "") origen = "DR";

                            //Buscamos el Concepto
                            carACopiar = linea.Length - longitudActual;
                            if (carACopiar > 0) concepto = linea.Substring(posActual, carACopiar + 1).Trim();
                         
                            
                            //Vamos a Buscar la Fecha
                            if (sFecha.Trim() != "")
                            {
                                AFecha = sFecha.Split('/');
                                dia = int.Parse(AFecha[0]);
                                mes = int.Parse(AFecha[1]);
                                anio = int.Parse(AFecha[2]);

                                fecha = new DateTime(anio, mes, dia);
                            }


                            dr = DTDetalle.NewRow();
                            dr["tipo"] = tipo;
                            dr["Factura"] = factura;
                            dr["Recibo_No"] = recibo;
                            dr["Fecha"] = fecha;
                            dr["valor"] = objUtil.ConvertirANumero(sValor);
                            dr["Origen"] = origen;
                            dr["Concepto"] = concepto;

                            AgregarLineaDetalle(dr);

                            

                        } 
                    }

                    
                    //ELIMINAMOS EL ARCHIVO

                    try
                    {
                        streamDatos.Dispose();
                        if (File.Exists(nombreArchivo)) File.Delete(nombreArchivo);
                    }
                    catch (Exception)
                    {

                        
                    }
                    
                }

                

            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ofdArchivoCliente.Dispose();
            }
        }

        public override void TotalizarDetalle()
        {
            object calcObject;
            double totalDebito = 0.0, totalCredito = 0.0, total = 0.0;
            try
            {
               
                calcObject = DTDetalle.Compute("Sum(Valor)",  "Origen = 'DR'");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalDebito = double.Parse(calcObject.ToString());
                }

                calcObject = DTDetalle.Compute("Sum(Valor)", "Origen = 'CR'");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalCredito = double.Parse(calcObject.ToString());
                }

                total = totalDebito - totalCredito;

                lblTotal.Text = "TOTAL >>>      " + total.ToString("N2");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FormMigraCliente_Load(object sender, EventArgs e)
        {
            
        }

    }
}
