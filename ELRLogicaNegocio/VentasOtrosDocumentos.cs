using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace ELRLogicaNegocio
{
    public class VentasOtrosDocumentos
    {
        public DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        public DataTable MyData;
        public string NombreImpresora = "";
        public int numeroCopias = 1;
        public bool imprimiendo = false;
        public Image logo = null;


        string nombreEmpresaOficina;
        string direccionOficina;
        string rncEmpresa;
        string telefonosOficina;
        string oficinaId = "0";
        string slogan = "";

        string numero = "0";
        string tipo = "";
        DateTime fechaAdicionado;
        string sFechaVencimiento;

        int entidadId = 0, diasCredito = 0;
        string cedulaRNC = "";
        string nombreCliente = "";
        string direccionCliente = "";
        string telfsCliente = "";

        string nombreUsuario = "";
        string condicion = "";
        double subtotal, descto, totalItbis, total, totalUS = 0;
        double totalDescto = 0, porcDescto = 0;
        bool esNulo = false;
        string estatus = "";

        DataRow fila0 = null;
        DataTable DTOficina = null;
        DataRow filaOficina = null;

        public VentasOtrosDocumentos()
        {
            db = new DataDB_ELR_NET.DataDB();
        }

        void GetDataEncabezado()
        {
            DateTime fecha = DateTime.Now.Date;
            try
            {
                diasCredito = 0;
                entidadId = 0;
                totalUS = 0;

                if (fila0 == null) fila0 = MyData.Rows[0];

                numero = fila0["Numero"].ToString();
                fechaAdicionado = (DateTime)fila0["Fecha_Adicionado"];
                tipo = fila0["Tipo"].ToString();
                nombreUsuario = fila0["Adicionado_Por"].ToString();


                oficinaId = fila0["Oficina_Id"].ToString();


                //BUSCAMOS LOS DATOS DE LA OFICINA
                DTOficina = db.GetById("VEMPRESAS_OFICINAS", oficinaId, "Oficina_Id");
                filaOficina = DTOficina.Rows[0];
                nombreEmpresaOficina = filaOficina["Empresa_Nombre"].ToString() + ", " + filaOficina["Nombre"].ToString();
                slogan = filaOficina["Empresa_Slogan"].ToString();
                direccionOficina = filaOficina["Direccion"].ToString();

                telefonosOficina = filaOficina["Telefono1"].ToString();
                if (!(filaOficina["Telefono2"] is DBNull))
                {
                    if (filaOficina["Telefono2"].ToString().Trim() != "")
                    {
                        if (telefonosOficina.Trim() != "") telefonosOficina += ", ";
                        telefonosOficina += filaOficina["Telefono2"].ToString().Trim();
                    }
                }

                rncEmpresa = filaOficina["Empresa_RNC"].ToString();

                //Buscamos los Datos del Cliente
                entidadId = int.Parse(fila0["Entidad_Id"].ToString());
                cedulaRNC = fila0["CedulaRNC"].ToString();
                nombreCliente = fila0["Nombre"].ToString();
                direccionCliente = fila0["Direccion"].ToString();
                telfsCliente = fila0["Telefonos"].ToString();

                esNulo = db.GetAsBoolean("EsNulo", fila0);
                estatus = db.GetAsString("Estatus", fila0);
                subtotal = db.GetAsDouble("Sub_Total", fila0);
                totalDescto = db.GetAsDouble("Total_Descuento", fila0);
                porcDescto = db.GetAsDouble("PorcDescto", fila0);
                total      = db.GetAsDouble("Monto", fila0);
                totalItbis = db.GetAsDouble("Total_Itbis", fila0);
                diasCredito = db.GetAsInt("Dias_Credito", fila0);

                if (!(fila0["Monto_US"] is DBNull)) totalUS = db.GetAsDouble("Monto_US", fila0);

                //INDICAMOS LA CONDICION
                if ((diasCredito <= 0) && (!(fila0["Fecha_Vencimiento"] is DBNull))) diasCredito = db.DateToInt(fechaAdicionado) - db.DateToInt(fecha);
                else
                {
                    diasCredito = 30;
                    fecha = fechaAdicionado.AddDays(30);
                }

                sFechaVencimiento = fecha.ToString("dd/MM/yyyy");

                condicion = " A " + diasCredito.ToString() + " Dias";

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void ImprimirTicket()
        {

            CrearTicket ticket1 = new CrearTicket();
            CrearTicket ticket2 = new CrearTicket();

            string descripcion = "", codigo = "0";
            string fecha = "", hora = "";
            double cantidad = 0, precio = 0, importe = 0;

            try
            {


                //OBTENEMOS VALORES DEL DATASET
                fila0 = MyData.Rows[0];
                GetDataEncabezado();

                //Agregamos el Header
                ticket1.headerImage = logo;
                ticket1.TextoCentro(nombreEmpresaOficina, true);
                ticket1.TextoCentro(direccionOficina, true);
                ticket1.TextoCentro("RNC: " + rncEmpresa, true);
                ticket1.TextoCentro("Telfs.: " + telefonosOficina, true);

                if (numeroCopias > 1)
                {
                    ticket2.headerImage = logo;
                    ticket2.TextoCentro(nombreEmpresaOficina, true);
                    ticket2.TextoCentro(direccionOficina, true);
                    ticket2.TextoCentro("RNC: " + rncEmpresa, true);
                    ticket2.TextoCentro("Telfs.: " + telefonosOficina, true);
                }

                //AGREGAMOS SUB HEADER
                fecha = "Fecha: " + fechaAdicionado.ToString("dd/MM/yyyy");
                hora = "Hora: " + fechaAdicionado.ToString("hh:mm:ss tt");
                ticket1.lineasIgual();
                ticket1.TextoCentro(tipo + " # " + numero.PadLeft(8, '0'));
                ticket1.lineasIgual();

                ticket1.TextoIzquierda("Le Atendio: " + nombreUsuario);
                ticket1.TextoExtremos(fecha, hora);

                if (numeroCopias > 1)
                {
                    ticket2.lineasIgual();
                    ticket2.TextoCentro(tipo + " # " + numero.PadLeft(8, '0'));
                    ticket2.lineasIgual();

                    ticket2.TextoIzquierda("Le Atendio: " + nombreUsuario);
                    ticket2.TextoExtremos(fecha, hora);
                }

                //AGREGAMOS LOS DATOS DEL COMRPBANTE FISCAL Y DEL CLIENTE
                ticket1.lineasIgual();
                ticket1.TextoIzquierda("Cliente: " + nombreCliente);
                ticket1.TextoIzquierda("Cedula\\RNC: " + cedulaRNC);

                if (numeroCopias > 1)
                {
                    ticket2.lineasIgual();
                    ticket2.TextoIzquierda("Cliente: " + nombreCliente);
                    ticket2.TextoIzquierda("Cedula\\RNC: " + cedulaRNC);
                }


                ticket1.lineasIgual();
                ticket1.EncabezadoVenta40();

                if (numeroCopias > 1)
                {
                    ticket2.lineasIgual();
                    ticket2.EncabezadoVenta40();
                }

                //AGREGAMOS LOS ITEMS FACTURADO
                foreach (DataRow item in MyData.Rows)
                {
                    codigo = item["Producto_Id"].ToString();
                    cantidad = double.Parse(item["Cantidad"].ToString());
                    descripcion = item["Descripcion"].ToString();
                    precio = double.Parse(item["Precio"].ToString());
                    importe = double.Parse(item["DTotal"].ToString());

                    ticket1.AddItem40(codigo, descripcion, cantidad, precio, importe);
                    if (numeroCopias > 1) ticket2.AddItem40(codigo, descripcion, cantidad, precio, importe);

                }

                //AGREGAMOS EL TOTAL
                ticket1.lineasIgual();
                ticket1.lineasVacia();
                ticket1.AgregarTotales("SubTotal: ", subtotal);
                ticket1.AgregarTotales("Descto: ", totalDescto);
                ticket1.AgregarTotales("Itbis: ", totalItbis);
                ticket1.AgregarTotales("Total: ", total);

                if (totalUS > 0)
                {
                    ticket1.lineasVacia();
                    ticket1.AgregarTotales("Total US$", totalUS);
                }

                if (numeroCopias > 1)
                {
                    ticket2.lineasIgual();
                    ticket2.lineasVacia();
                    ticket2.AgregarTotales("SubTotal:", subtotal);
                    ticket1.AgregarTotales("Descto: ", totalDescto);
                    ticket2.AgregarTotales("Itbis:", totalItbis);
                    ticket2.AgregarTotales("Total:", total);

                    if (totalUS > 0)
                    {
                        ticket2.lineasVacia();
                        ticket2.AgregarTotales("Total US$", totalUS);
                    }
                }

                //AGREGAMOS UN TOTAL EN BLANCO PARA SEPARAR
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasAsteriscos();
                if (numeroCopias > 1)
                {
                    ticket2.lineasVacia();
                    ticket2.lineasVacia();
                    ticket2.lineasAsteriscos();
                }

                //Agregamos el slogan de la empresa
                if (slogan.Trim() != "")
                {
                    ticket1.TextoCentro(slogan);
                    if (numeroCopias > 1) ticket2.TextoCentro(slogan);
                }

                ticket1.TextoCentro("GRACIAS POR PREFERIRNOS!");
                if (numeroCopias > 1) ticket2.TextoCentro("GRACIAS POR PREFERIRNOS!");

                //POR ULTIMO SE IMPRIME EL TICKET
                ticket1.PrintTicket2(NombreImpresora);
                if (numeroCopias > 1) ticket2.PrintTicket2(NombreImpresora);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ticket1 = null;
                ticket2 = null;
            }

        }

        public void PrintMatricial80()
        {
            CrearTicket ticket1 = new CrearTicket();
            string cadena = "", codigo = "", descripcion = "", medida;
            double cantidad = 0, precio = 0, importe = 0, itbis = 0;

            try
            {
                ticket1.maxCar = 80;
                ticket1.leftMargin = 10;
                ticket1.headerImage = logo;

                //Obtenemos los datos del encabezado
                GetDataEncabezado();

                //Agregamos el Encabezado
                ticket1.TextoIzquierda(nombreEmpresaOficina, true);
                ticket1.TextoIzquierda("Direccion: " + direccionOficina, true);
                ticket1.TextoIzquierda("RNC: " + rncEmpresa, true);
                ticket1.TextoIzquierda("Telfs. " + telefonosOficina, true);

                ticket1.lineasVacia();
                cadena = tipo.ToUpper() + " NO.: " + numero.PadLeft(7, '0');
                cadena += "  ESTATUS: " + estatus.ToUpper();
                ticket1.TextoIzquierda(cadena, true);

                ticket1.lineasIgual();

                ticket1.TextoIzquierda("Fecha..........:" + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"));
                

                ticket1.TextoExtremos("Codigo Cliente.:" + entidadId.ToString().PadLeft(6, '0'), tipo + " NO.: " + numero.PadLeft(7, '0'));
                ticket1.TextoExtremos("Nombre.........:" + nombreCliente, "Vendedor.: " + nombreUsuario);

                if (diasCredito > 0) ticket1.TextoExtremos("Rnc/Ced........:" + cedulaRNC, condicion + ", Fecha Vence.:" + sFechaVencimiento);
                else ticket1.TextoIzquierda("Rnc/Ced........:" + cedulaRNC);

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("Direccion: " + direccionCliente + "   Telfs.: " + telfsCliente);

                //ticket1.TextoExtremos("Direccion......:" + direccionCliente, "Condicion.:" + condicion);

                ticket1.lineasIgual();

                ticket1.EncabezadoVenta80();
                ticket1.lineasGuio();

                //AGREGAMOS LOS ITEMS FACTURADO
                foreach (DataRow item in MyData.Rows)
                {
                    codigo = item["Producto_Id"].ToString();
                    medida = item["Medida"].ToString();
                    cantidad = double.Parse(item["Cantidad"].ToString());
                    descripcion = item["Descripcion"].ToString();
                    precio = double.Parse(item["Precio"].ToString());
                    importe = double.Parse(item["DTotal"].ToString());
                    itbis = db.GetAsDouble("DItbis", item);

                    ticket1.AgregaArticulo80(codigo, descripcion, medida, cantidad, precio, itbis, importe);
                }

                //AGREGAMOS EL TOTAL
                ticket1.lineasIgual();

                ticket1.AgregarTotales("SubTotal:", subtotal);
                ticket1.AgregarTotales("Descto: ", totalDescto);
                ticket1.AgregarTotales("Itbis:", totalItbis);
                ticket1.AgregarTotales("Total:", total);

                if (totalUS > 0)
                {
                    ticket1.lineasVacia();
                    ticket1.AgregarTotales("Total US$", totalUS);
                }

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("_______________________________________");
                ticket1.TextoIzquierda("     Aprobado Por(firma y sello)");

                ticket1.PrintTicket2(NombreImpresora);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
