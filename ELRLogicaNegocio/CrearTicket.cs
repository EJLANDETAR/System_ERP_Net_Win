using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregamos las librerias que utilizaremos.
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Collections;
using System.Windows.Forms;

namespace ELRLogicaNegocio
{

    //Esta es la clase para crear el ticket de venta. Crearemos varios métodos aquí.
    public class CrearTicket
    {

        public string fontName = "Lucida Console";
        public int fontSize = 11;
        public int maxCar = 40;
        public Image headerImage = null;

        Font printFont = null;
        SolidBrush myBrush = new SolidBrush(Color.Black);
        Graphics gfx = null;
        int count = 0;
        int imageHeight = 0;
        int lineaNo = 0;

        public float leftMargin = 5;
        public float topMargin = 5;

        //Creamos un objeto de la clase StringBuilder, en este objeto agregaremos las lineas del ticket
        StringBuilder lineas = new StringBuilder();
        ArrayList ALineas = new ArrayList();
        List<Lineas> lstLineas = new List<Lineas>();
        
        int cortar;//Para una impresora ticketera que imprime a 40 columnas. La variable cortar cortara el texto cuando rebase el limte.

        public string lineasVacia()
        {
            string cadena = "";
            for (int i = 0; i < maxCar; i++)
            {
                cadena += " ";//Agregara un guio hasta llegar la numero maximo de caracteres.
            }

            ALineas.Add(cadena);
            lstLineas.Add(new Lineas(cadena));
            return lineas.AppendLine(cadena).ToString(); //Devolvemos la lineaGuion
        }

        //Creamos el primer metodo, este dibujara lineas guion.
        public string lineasGuio()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";//Agregara un guio hasta llegar la numero maximo de caracteres.
            }

            ALineas.Add(lineasGuion);
            lstLineas.Add(new Lineas(lineasGuion));
            return lineas.AppendLine(lineasGuion).ToString(); //Devolvemos la lineaGuion
        }

        //Metodo para dibujar una linea con asteriscos
        public string lineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*";//Agregara un asterisco hasta llegar la numero maximo de caracteres.
            }

            ALineas.Add(lineasAsterisco);
            lstLineas.Add(new Lineas(lineasAsterisco));

            return lineas.AppendLine(lineasAsterisco).ToString(); //Devolvemos la linea con asteriscos
        }

        //Realizamos el mismo procedimiento para dibujar una lineas con el signo igual
        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";//Agregara un igual hasta llegar la numero maximo de caracteres.
            }

            ALineas.Add(lineasIgual);
            lstLineas.Add(new Lineas(lineasIgual));
            return lineas.AppendLine(lineasIgual).ToString(); //Devolvemos la lienas con iguales
        }

        //Creamos el encabezado para los articulos
        public void EncabezadoVenta40()
        {
            //Escribimos los espacios para mostrar el articulo. En total tienen que ser 40 caracteres
            string cadena = @"ARTÍCULO             CANT    PREC\IMPORT";

            ALineas.Add(cadena);
            lstLineas.Add(new Lineas(cadena));

            lineas.AppendLine(cadena);

        }

        //Creamos el encabezado para los articulos
        public void EncabezadoVenta80()
        {
            //Escribimos los espacios para mostrar el articulo. En total tienen que ser 80 caracteres
            string cadena = "CODIGO  DESCRIPCION                       MEDIDA  CANT.      PRECIO      IMPORTE";

            ALineas.Add(cadena);
            lstLineas.Add(new Lineas(cadena));

            lineas.AppendLine(cadena);
        }


        //AGREGAR ENCABEZADO
        public void AddHeader(string texto, bool esNegrita = false)
        {
            string cadena = "";

            if (headerImage != null) texto = "              " + texto;

            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    cadena = texto.Substring(caracterActual, maxCar);

                    ALineas.Add(cadena);
                    lstLineas.Add(new Lineas(cadena, esNegrita));
                    lineas.AppendLine(cadena);
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                cadena = texto.Substring(caracterActual, texto.Length - caracterActual);

                ALineas.Add(cadena);
                lstLineas.Add(new Lineas(cadena, esNegrita));
                lineas.AppendLine(cadena);
            }
            else
            {
                //Si no es mayor solo agregarlo.
                ALineas.Add(texto);
                lstLineas.Add(new Lineas(texto, esNegrita));
                lineas.AppendLine(texto);
            }
        }


        //Creamos un metodo para poner el texto a la izquierda
        public void TextoIzquierda(string texto, bool esNegrita = false)
        {
            string cadena = "";
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    cadena = texto.Substring(caracterActual, maxCar);

                    ALineas.Add(cadena);
                    lstLineas.Add(new Lineas(cadena, esNegrita));
                    lineas.AppendLine(cadena);
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                cadena = texto.Substring(caracterActual, texto.Length - caracterActual);

                ALineas.Add(cadena);
                lstLineas.Add(new Lineas(cadena, esNegrita));
                lineas.AppendLine(cadena);
            }
            else
            {
                //Si no es mayor solo agregarlo.
                ALineas.Add(texto);
                lstLineas.Add(new Lineas(texto, esNegrita));
                lineas.AppendLine(texto);
            }
        }

        //Creamos un metodo para poner texto a la derecha.
        public void TextoDerecha(string texto, bool esNegrita = false)
        {
            string cadena = "";

            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    cadena = texto.Substring(caracterActual, maxCar);

                    ALineas.Add(cadena);
                    lstLineas.Add(new Lineas(cadena, esNegrita));
                    lineas.AppendLine(cadena);
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                cadena = espacios + texto.Substring(caracterActual, texto.Length - caracterActual);
                ALineas.Add(cadena);
                lstLineas.Add(new Lineas(cadena, esNegrita));
                lineas.AppendLine(cadena);
            }
            else
            {
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }
                //Si no es mayor solo agregarlo.
                cadena = espacios + texto;
                ALineas.Add(cadena);
                lstLineas.Add(new Lineas(cadena, esNegrita));

                lineas.AppendLine(cadena);
            }
        }

        //Metodo para centrar el texto
        public void TextoCentro(string texto, bool esNegrita = false)
        {
            string cadena = "";

            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    cadena = texto.Substring(caracterActual, maxCar);
                    ALineas.Add(cadena);
                    lstLineas.Add(new Lineas(cadena, esNegrita));
                    lineas.AppendLine(cadena);
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                cadena = espacios + texto.Substring(caracterActual, texto.Length - caracterActual);
                ALineas.Add(cadena);
                lstLineas.Add(new Lineas(cadena, esNegrita));

                lineas.AppendLine(cadena);
            }
            else
            {
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                cadena = espacios + texto;
                ALineas.Add(cadena);
                lstLineas.Add(new Lineas(cadena, esNegrita));

                lineas.AppendLine(cadena);

            }
        }

        //Metodo para poner texto a los extremos
        public void TextoExtremos(string textoIzquierdo, string textoDerecho, int tamanio = 0, bool esNegrita = false)
        {
            //variables que utilizaremos
            string textoIzq, textoDer, textoCompleto = "", espacios = "";
            int medio = (int)(maxCar / 2) - 2;
            int posCar = 0;
            int longitudDerecha = textoDerecho.Length;
            posCar = maxCar - (longitudDerecha + 1);

            //Si el texto que va a la izquierda es mayor a 18, cortamos el texto.
            if ( (maxCar > 40) && (textoIzquierdo.Length <= posCar)) textoIzq = textoIzquierdo;
            else if ((maxCar > 40) && (textoIzquierdo.Length > posCar)) textoIzq = textoIzquierdo.Substring(0, posCar);
            else if (textoIzquierdo.Length > medio)
            {
                cortar = textoIzquierdo.Length - medio;
                textoIzq = textoIzquierdo.Remove(medio, cortar);
            }
            else
            { textoIzq = textoIzquierdo; }

            textoCompleto = textoIzq;//Agregamos el primer texto.

            medio = (int)(maxCar / 2);

            if ( (textoDerecho.Length > medio) && (maxCar <= 40) )//Si es mayor a 20 lo cortamos
            {
                cortar = textoDerecho.Length - medio;
                textoDer = textoDerecho.Remove(medio, cortar);
            }
            else
            { textoDer = textoDerecho; }

            //Obtenemos el numero de espacios restantes para poner textoDerecho al final
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";//agrega los espacios para poner textoDerecho al final
            }
            textoCompleto += espacios + textoDerecho;//Agregamos el segundo texto con los espacios para alinearlo a la derecha.
            ALineas.Add(textoCompleto);
            lstLineas.Add(new Lineas(textoCompleto, esNegrita));

            lineas.AppendLine(textoCompleto);//agregamos la linea al ticket, al objeto en si.
        }

        //Metodo para agregar los totales d ela venta
        public void AgregarTotales(string texto, double total, bool esDerecha = false)
        {
            //Variables que usaremos
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 15) resumen = texto.Substring(0, 15);
            else  resumen = texto; 

            textoCompleto = resumen;

            if (!textoCompleto.Contains(":")) textoCompleto += ": ";
            textoCompleto = textoCompleto.PadLeft(16, ' ');

            valor = total.ToString("N2").PadLeft(13, ' ');//Agregamos el total previo formateo.

            textoCompleto += valor + "  ";

            //Obtenemos el numero de espacios restantes para alinearlos a la derecha
            int nroEspacios = maxCar - textoCompleto.Length;
            //agregamos los espacios
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto = espacios + textoCompleto;

            ALineas.Add(textoCompleto);
            lstLineas.Add(new Lineas(textoCompleto, false));

            lineas.AppendLine(textoCompleto);
        }

        //Metodo para agreagar articulos al ticket de venta
        public void AddItem40(string codigo, string descripcion, double cantidad, double precio, double importe)
        {
            string cadena = "";
            cadena = descripcion + "                    ";
            
            cadena = cadena.Substring(0, 20) + " " + cantidad.ToString("N2").PadRight(6, ' ') + "   " + precio.ToString("N2").PadLeft(10, ' ');

            ALineas.Add(cadena);
            lstLineas.Add(new Lineas(cadena));
            lineas.Append(cadena);

            if (codigo.Trim().Length < 7) codigo = codigo.PadLeft(7, '0');
            TextoExtremos(codigo, importe.ToString("N2"));

        }

        public void AgregaArticulo80(string codigo, string articulo, string medida, double cant, double precio, double itbis, double importe)
        {
            string cadena = "";
            string descripcion = "";
            int posCarActual = 32;
            int cantidadACopiar = 0;

            articulo = articulo.Trim();

            descripcion = articulo;

            if (articulo.Length > posCarActual) descripcion = articulo.Substring(0, posCarActual);
            if (medida.Length > 6) medida = medida.Substring(0, 6);

            cadena += codigo.PadLeft(6, '0') + "  " + descripcion.PadRight(posCarActual, ' ') + "  " + medida.PadRight(5, ' ') + " " + cant.ToString("N2").PadRight(8, ' ')
                   + precio.ToString("N2").PadLeft(10, ' ') + "   " + importe.ToString("N2").PadLeft(10, ' ');


            ALineas.Add(cadena);
            lstLineas.Add(new Lineas(cadena));
            lineas.Append(cadena);

            //Validamos si la Descripcion del articulo sobre pasa los 30 caracteres para Imprimir en la Siguiente Linea
            while (posCarActual < articulo.Length)
            {
                cadena = "        ";
                descripcion = "";
                cantidadACopiar = articulo.Length - posCarActual;
                if (cantidadACopiar <= 32)
                {
                    descripcion = articulo.Substring(posCarActual, cantidadACopiar);
                    posCarActual += cantidadACopiar;
                }
                else
                {
                    descripcion = articulo.Substring(posCarActual, 32);
                    posCarActual += 32;
                }



                if (descripcion != "")
                {
                    cadena += descripcion;
                    ALineas.Add(cadena);
                    lstLineas.Add(new Lineas(cadena));
                    lineas.Append(cadena);
                }

            }


        }

        //Metodos para enviar secuencias de escape a la impresora
        //Para cortar el ticket
        public void CortaTicket()
        {
            lineas.AppendLine("\x1B" + "m"); //Caracteres de corte. Estos comando varian segun el tipo de impresora
            lineas.AppendLine("\x1B" + "d" + "\x09"); //Avanza 9 renglones, Tambien varian

            ALineas.Add("\x1B" + "m");
            ALineas.Add("\x1B" + "d" + "\x09");
        }
        //Para abrir el cajon
        public void AbreCajon()
        {
            //Estos tambien varian, tienen que ever el manual de la impresora para poner los correctos.
            lineas.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96"); //Caracteres de apertura cajon 0
            ALineas.Add("\x1B" + "p" + "\x00" + "\x0F" + "\x96");
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96"); //Caracteres de apertura cajon 1
        }

        //Para Verificar si la Impresora Existe
        public bool PrinterExists(string impresora)
        {
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                if (impresora == strPrinter)
                    return true;
            }
            return false;
        }

        //Para mandara a imprimir el texto a la impresora que le indiquemos.
        public void ImprimirTicket(string impresora)
        {
            //Este metodo recibe el nombre de la impresora a la cual se mandara a imprimir y el texto que se imprimira.
            //Usaremos un código que nos proporciona Microsoft. https://support.microsoft.com/es-es/kb/322091

            RawPrinterHelper.SendStringToPrinter(impresora, lineas.ToString()); //Imprime texto.
            lineas.Clear();//Al cabar de imprimir limpia la linea de todo el texto agregado.
        }

        public void PrintTicket2(string impresora)
        {
            PrintDialog prtDlg = new PrintDialog();
            bool valido = true;
            try
            {
                if(impresora.Trim() == "")
                {
                    valido = false;
                    if(prtDlg.ShowDialog() == DialogResult.OK)
                    {
                        valido = true;
                        impresora = prtDlg.PrinterSettings.PrinterName;
                    }
                }

                if (!valido) return;

                lineaNo = 0;
                printFont = new Font(fontName, fontSize, FontStyle.Regular);
                PrintDocument pr = new PrintDocument();
                pr.PrinterSettings.PrinterName = impresora;
                pr.PrintController = new StandardPrintController();
                pr.PrintPage += new PrintPageEventHandler(pr_PrintPage);
                pr.Print();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pr_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int lineasPorPagina = 0;
            int conteoLinea = 0;
            string line = null;
            string miLinea = "";
            bool esNegrita = false;

            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            gfx = e.Graphics;

            DrawImage();

            lineasPorPagina = (int) ( e.MarginBounds.Height / printFont.GetHeight(e.Graphics) );

            while (conteoLinea < lineasPorPagina && (lineaNo < lstLineas.Count)) //ALineas.Count) )
            {
                //miLinea = ALineas[lineaNo].ToString();
                miLinea = lstLineas[lineaNo].line;
                esNegrita = lstLineas[lineaNo].esNegrita;

                if(esNegrita) printFont = new Font(fontName, fontSize, FontStyle.Bold);
                else printFont = new Font(fontName, fontSize, FontStyle.Regular);

                lineaNo++;

                if (miLinea.Length > maxCar)
                {
                    int currentChar = 0;
                    int longitud = miLinea.Length;

                    while (longitud > maxCar)
                    {
                        line = miLinea.Substring(currentChar, maxCar);
                        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

                        count++;
                        conteoLinea++;
                        currentChar += maxCar;
                        longitud -= maxCar;
                    }
                    line = miLinea;
                    gfx.DrawString(line.Substring(currentChar, line.Length - currentChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
                    count++;
                    conteoLinea++;
                }
                else
                {
                    line = miLinea;
                    gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());

                    count++;
                    conteoLinea++;
                }
            }

            //printFont = new Font(fontName, fontSize, FontStyle.Regular);

            // If more lines exist, print another page.
           // if (lineaNo < ALineas.Count)
           if(lineaNo < lstLineas.Count)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;


        }



        private void DrawImage()
        {
            Image newImage = null;
            if (headerImage != null)
            {
                try
                {
                    newImage = headerImage.GetThumbnailImage(128, 80, null, IntPtr.Zero);

                    if (maxCar <= 80) gfx.DrawImage(newImage, new Point( (int)leftMargin, (int)topMargin));
                    else if(maxCar <= 40)
                    {
                        gfx.DrawImage(headerImage, new Point((int)leftMargin, (int)YPosition()));
                        double height = ((double)headerImage.Height / 58) * 15;
                        imageHeight = (int)Math.Round(height) + 3;
                    }

                }
                catch (Exception)
                {
                }
            }
        }

       

        private float YPosition()
        {
            float resultado = 0;

            
            resultado = topMargin + (count * printFont.GetHeight(gfx) + imageHeight);
            

            return resultado; 
        }

    }



}
