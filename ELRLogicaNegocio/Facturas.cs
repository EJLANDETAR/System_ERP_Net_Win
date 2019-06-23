using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace ELRLogicaNegocio
{
    public class Facturas
    {

        public DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        public DataTable MyData;
        public string NombreImpresora = "";
        public int numeroCopias = 1;
        public bool imprimiendo = false, esCopia = false;
        public Image logo = null;


        string nombreEmpresaOficina;
        string direccionOficina;
        string rncEmpresa;
        string telefonosOficina;
        string oficinaId = "0";
        string slogan = "";
        string mensajeFactura = "";

        string numero = "0";
        int ncfTipo = 0;
        string ncf = "";
        string nombreNCF = "";
        string feVenceNCF = "";
        DateTime fechaOPE;
        DateTime fechaAdicionado;
        string sFechaVencimiento;

        int entidadId = 0, diasCredito = 0;
        string cedulaRNC = "";
        string nombreCliente = "";
        string direccionCliente = "";
        string telfsCliente = "";
        string condicion = "AL CONTADO";

        string cajaId = "0";
        int cajaNo = 0;
        string nombreUsuario = "";
        double subtotal, descto, totalItbis, total, totalUS = 0;
        double enEfectivo = 0, enCheques = 0, enTarjeta = 0, suCambio = 0;
        double aCredito = 0, aContado = 0;
        double totalDescto = 0, porcDescto = 0;

        DataRow fila0 = null;
        DataTable DTOficina = null;
        DataRow filaOficina = null;

        void GetDataEncabezado()
        {
            DateTime fecha = DateTime.Now.Date;
            try
            {
                diasCredito = 0;
                entidadId = 0;
                totalUS = 0;
                feVenceNCF = "";
                ncfTipo = 0;

                if (fila0 == null) fila0 = MyData.Rows[0];

                numero = fila0["Numero"].ToString();
                ncfTipo = db.GetAsInt("Tipo_NCF", fila0);
                ncf = fila0["NCF"].ToString();
                nombreNCF = fila0["Nombre_NCF"].ToString();
                fechaOPE = (DateTime)fila0["Fecha"];
                fechaAdicionado = (DateTime)fila0["Fecha_Adicionado"];
                cajaId = fila0["Caja_Id"].ToString();
                cajaNo = db.GetAsInt("Caja_Id", fila0);
                nombreUsuario = db.GetAsString("Nombre_Vendedor", fila0);

                //Buscamos la fecha en que vence el ncf
                if (fila0["NCF_Valido_Hasta"] is DBNull) feVenceNCF = "";
                else feVenceNCF = ((DateTime)fila0["NCF_Valido_Hasta"]).ToString("dd/MM/yyyy");

                oficinaId = fila0["Oficina_Id"].ToString();

                enEfectivo = double.Parse(fila0["EnEfectivo"].ToString());
                enCheques = double.Parse(fila0["EnCheques"].ToString());
                enTarjeta = double.Parse(fila0["EnTarjeta"].ToString());
                suCambio = double.Parse(fila0["ADevolver"].ToString());
                aCredito = double.Parse(fila0["Monto_ACredito"].ToString());
                aContado = double.Parse(fila0["Monto_AlContado"].ToString());
                diasCredito = db.GetAsInt("Dias_Credito", fila0);
                sFechaVencimiento = db.GetDateAsString("Fecha_Vencimiento", fila0);

                if (!(fila0["Monto_US"] is DBNull)) totalUS = double.Parse(fila0["Monto_US"].ToString());

                if (aCredito > 0) condicion = "A CREDITO " + diasCredito.ToString() + " Dias";
                else condicion = "AL CONTADO";


                //BUSCAMOS LOS DATOS DE LA OFICINA
                DTOficina = db.GetById("VEMPRESAS_OFICINAS", oficinaId, "Oficina_Id");
                filaOficina = DTOficina.Rows[0];
                nombreEmpresaOficina = filaOficina["Empresa_Nombre"].ToString() + ", " + filaOficina["Nombre"].ToString();
                slogan = filaOficina["Empresa_Slogan"].ToString();
                direccionOficina = filaOficina["Direccion"].ToString();
                mensajeFactura = filaOficina["Mensaje_Factura"].ToString();

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
                entidadId = int.Parse( fila0["Entidad_Id"].ToString());
                cedulaRNC = fila0["CedulaRNC"].ToString();
                nombreCliente = fila0["Nombre"].ToString();
                direccionCliente = fila0["Direccion"].ToString();
                telfsCliente = fila0["Telefonos"].ToString();

                //Buscamos los totales
                subtotal = db.GetAsDouble("VSub_Total", fila0);
                totalDescto = db.GetAsDouble("VDescuento", fila0);
                porcDescto = db.GetAsDouble("PorcDescto", fila0);
                total = db.GetAsDouble("VMonto", fila0);
                totalItbis = db.GetAsDouble("VItbis", fila0);


            }
            catch (Exception)
            {

                throw;
            }

        }

        public void ImprimirTicket()
        {

            CrearTicket ticket1 = new CrearTicket();

            string descripcion = "", codigo = "0";
            string fecha = "", hora = "";
            double cantidad = 0, precio = 0, importe = 0;
 
            try
            {
                //OBTENEMOS VALORES DEL DATASET
                fila0 = MyData.Rows[0];
                GetDataEncabezado();

                //Agregamos el Header
                //ticket1.headerImage = logo;
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoCentro(nombreEmpresaOficina);
                ticket1.TextoCentro(direccionOficina);
                ticket1.TextoCentro("RNC: " + rncEmpresa);
                ticket1.TextoCentro("Telfs.: " + telefonosOficina);

                //AGREGAMOS SUB HEADER
                fecha = "Fecha: " + fechaAdicionado.ToString("dd/MM/yyyy");
                hora = "Hora: " + fechaAdicionado.ToString("hh:mm:ss tt");
                ticket1.lineasIgual();
                if (cajaNo > 0) ticket1.TextoExtremos("Caja # " + cajaId, "Fact. # " + numero.PadLeft(8, '0'));
                else ticket1.TextoIzquierda("Fact. # " + numero.PadLeft(8, '0')); 

                ticket1.TextoIzquierda("Le Atendio: " + nombreUsuario);
                ticket1.TextoExtremos(fecha, hora);

                //AGREGAMOS LOS DATOS DEL COMRPBANTE FISCAL Y DEL CLIENTE
                ticket1.lineasIgual();
                ticket1.TextoIzquierda("Cliente: " + nombreCliente);
                ticket1.TextoIzquierda("Cedula\\RNC: " + cedulaRNC);

                if (ncf.Trim() != "")
                {
                    ticket1.lineasVacia();
                    ticket1.TextoIzquierda(nombreNCF.ToUpper());
                    ticket1.TextoIzquierda("NCF: " + ncf);
                    ticket1.TextoIzquierda("Fecha: " + fechaOPE.ToString("dd/MM/yyyy") );
                    if (feVenceNCF.Trim() != "" && ncfTipo != 2) ticket1.TextoIzquierda("Sec. valida hasta: " + feVenceNCF);
                    ticket1.lineasVacia();
                }

                ticket1.lineasIgual();
                ticket1.EncabezadoVenta40();
                ticket1.lineasGuio();

                //AGREGAMOS LOS ITEMS FACTURADO
                foreach (DataRow item in MyData.Rows)
                {
                    codigo = item["Producto_Id"].ToString();
                    cantidad = double.Parse( item["Cantidad"].ToString());
                    descripcion = item["Descripcion"].ToString();
                    precio      = double.Parse( item["Precio"].ToString());
                    importe     = double.Parse(item["Monto"].ToString());

                    ticket1.AddItem40(codigo, descripcion, cantidad, precio, importe);
                }

                //AGREGAMOS EL TOTAL
                ticket1.lineasIgual();
                ticket1.lineasVacia();
                ticket1.AgregarTotales ("SubTotal: ", subtotal);
                ticket1.AgregarTotales("Descto: ", totalDescto );
                ticket1.AgregarTotales("Itbis: ", totalItbis);
                ticket1.AgregarTotales("Total: ", total);

                if(totalUS > 0)
                {
                    ticket1.lineasVacia();
                    ticket1.AgregarTotales("Total US$", totalUS);
                }

                //AGREGAMOS DESGLOSE DE PAGO
                ticket1.lineasVacia();
                ticket1.lineasIgual();
                ticket1.TextoCentro("DESGLOSE FORMA PAGO");
                ticket1.lineasGuio();
                ticket1.TextoIzquierda("En efectivo.:" + enEfectivo.ToString("N2"));
                ticket1.TextoIzquierda("Su Cambio...:" + suCambio.ToString("N2"));
                if (enCheques > 0) ticket1.TextoIzquierda("En Cheques..:" + enCheques.ToString("N2"));
                if (enTarjeta > 0) ticket1.TextoIzquierda("En Tarjeta..:" + enTarjeta.ToString("N2"));

                //AGREGAMOS EL MONTO QUE QUEDO PENDIENTE DE PAGAR
                if (aCredito > 0)
                {
                    ticket1.lineasVacia();
                    ticket1.TextoIzquierda("A Credito...:" + aCredito.ToString("N2"));
                    ticket1.TextoIzquierda("Fecha Vence.:" + sFechaVencimiento);
                }
                ticket1.lineasIgual();

                //AGREGAMOS UN TOTAL EN BLANCO PARA SEPARAR
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoCentro(mensajeFactura);
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasAsteriscos();

                //Agregamos el slogan de la empresa
                if (slogan.Trim() != "")
                {
                    ticket1.TextoCentro(slogan);
                    ticket1.lineasVacia();
                }

                ticket1.TextoCentro("GRACIAS POR PREFERIRNOS!");
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                

                //POR ULTIMO SE IMPRIME EL TICKET
                ticket1.PrintTicket2(NombreImpresora);
                if (numeroCopias > 1 && !esCopia)
                {
                    esCopia = true;
                    ImprimirTicket();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ticket1 = null;
            }

        }
       
        public void PrintMatricial80()
        {
            CrearTicket ticket1 = new CrearTicket();
            string cadena = "", codigo = "", descripcion = "", medida;
            double cantidad = 0, precio = 0, importe = 0, itbis = 0;
            string myTexto = "";
            try
            {
                ticket1.maxCar = 80;
                ticket1.leftMargin = 10;
                ticket1.headerImage = logo;

                //Obtenemos los datos del encabezado
                GetDataEncabezado();

                //Agregamos el Encabezado
                ticket1.AddHeader("", false);
                ticket1.AddHeader(nombreEmpresaOficina, true);
                ticket1.AddHeader("Direccion: " + direccionOficina, true);
                ticket1.AddHeader("RNC: " + rncEmpresa, true);
                ticket1.AddHeader("Telfs. " + telefonosOficina, true);
                ticket1.AddHeader("", false);

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("FACTURA NO.: " + numero.PadLeft(7, '0'), true);
                ticket1.lineasIgual();

                if (ncf != "")
                {
                    ticket1.TextoCentro(nombreNCF.ToUpper());
                    ticket1.lineasVacia();
                }
                
                if (ncf == "") ticket1.TextoIzquierda("Fecha..........:" + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"));
                else ticket1.TextoExtremos("Fecha..........:" + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"), "NCF.:" + ncf);

                myTexto = "Factura No.:" + numero.PadLeft(7, '0');
                if (cajaNo > 0) myTexto += ", Caja No.: " + cajaNo.ToString();
                ticket1.TextoExtremos("Codigo Cliente.:" + entidadId.ToString().PadLeft(6, '0'), myTexto);

                ticket1.TextoExtremos("Nombre.........:" + nombreCliente, "Vendedor.: " + nombreUsuario);

                if (diasCredito > 0) ticket1.TextoExtremos("Rnc/Ced........:" + cedulaRNC, condicion + ", Fecha Vence.:" + sFechaVencimiento);
                else ticket1.TextoExtremos("Rnc/Ced........:" + cedulaRNC, condicion);

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
                    importe = double.Parse(item["Monto"].ToString());
                    itbis = db.GetAsDouble("Itbis", item);

                    ticket1.AgregaArticulo80 (codigo, descripcion, medida, cantidad, precio, itbis, importe);
                    

                }

                //AGREGAMOS EL TOTAL
                ticket1.lineasIgual();
               
                ticket1.AgregarTotales("SubTotal: ", subtotal);
                ticket1.AgregarTotales("Descto: ", totalDescto);
                ticket1.AgregarTotales("Itbis: ", totalItbis);
                ticket1.AgregarTotales("Total: ", total);

                if (totalUS > 0)
                {
                    ticket1.lineasVacia();
                    ticket1.AgregarTotales("Total US$", totalUS);
                }

                ticket1.lineasVacia();

                //MOSTRAMOS FORMA DE PAGO
                ticket1.TextoIzquierda("DESGLOSE DE PAGO");
                ticket1.TextoIzquierda("====================================");
                ticket1.TextoIzquierda("EN EFECTIVO.: " + enEfectivo.ToString("N2"));
                ticket1.TextoIzquierda("SU CAMBIO...: " + suCambio.ToString("N2"));
                if (enCheques > 0) ticket1.TextoIzquierda("EN CHEQUES..: " + enCheques.ToString("N2"));
                if (enTarjeta > 0) ticket1.TextoIzquierda("EN TARJETA..: " + enTarjeta.ToString("N2"));
                if (aCredito > 0)
                {
                    ticket1.lineasVacia();
                    ticket1.TextoIzquierda("A CREDITO...: " + aCredito.ToString("N2") + "    " + diasCredito.ToString() +  "DIAS, FECHA VENCE: " + sFechaVencimiento);
                }

                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoIzquierda("                            ______________________     _______________________");
                ticket1.TextoIzquierda("                                 Recibido Por               Entregado Por");

                ticket1.PrintTicket2(NombreImpresora);



            }
            catch (Exception)
            {

                throw;
            }
        }

        public Facturas()
        {
            db = new DataDB_ELR_NET.DataDB();
        }
    }
}
