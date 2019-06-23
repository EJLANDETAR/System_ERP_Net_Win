using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace ELRLogicaNegocio
{
    public class Cajas
    {
        public DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        public DataTable DTDataCXC;
        public string NombreImpresora = "";
        public int numeroCopias = 1;
        public string montoLetra = "";
        public bool imprimiendo = false;
        public Image logo = null;
        public bool MOSTRAR_DETALLE_FACTURAS_PAGADAS = true;

        //Variable Privada
        int maxCar = 80;
        int posItemsY = 0;
        int conteoFila = 0;
        int conteoPagina = 0;
        float conteoLinea = 0;


        Font printFont = null;
        SolidBrush myBrush = new SolidBrush(Color.Black);
        string fontName = "Lucida Console";
        int fontSize = 11;
        Graphics gfx = null;

        string nombreEmpresaOficina;
        string direccionOficina;
        string rncEmpresa;
        string telefonosOficina;
        string oficinaId = "0";
        string slogan = "";

        string numero = "0";
        string ncf = "";
        string nombreNCF = "";
        string concepto = "";
        string nombreUsuario = "";
        string cajaId = "0";
        int cajaNo = 0;
        string titulo = "";
        DateTime fechaAdicionado;

        double capital, interes, demora, otros, total;
        double enEfectivo = 0, enCheques = 0, enTarjeta = 0, suCambio = 0;
        double capitalPendiente = 0, capitalInicial = 0;

        string cedulaRNC = "";
        string nombreCliente = "";

        int facturaNo = 0;
        int prestamoNo = 0;
        int tipoTrans = 0;

        DataRow fila0 = null;
        DataTable DTOficina = null;
        DataRow filaOficina = null;

        public int getCajaAbierta(string nombreUsuario)
        {
            int resultado = 0;
            DataDB_ELR_NET.DataDB DB = new DataDB_ELR_NET.DataDB();
            DataTable DTCajas;
            try
            {
                DB.LimpiarFiltros();
                DB.AddFiltroIgualA("Usuario_En_Caja", nombreUsuario);
                DB.AddFiltroIsNull("Fecha_Cierre");

                DTCajas = DB.GetAll("TCAJAS_APERTURA_CIERRE", 50, DB.Filtros);

                if (DTCajas.Rows.Count > 0) resultado = int.Parse( DTCajas.Rows[0]["Caja_Id"].ToString());
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        void GetDataEncabezadoCXC()
        {

            try
            {
                //OBTENEMOS VALORES DEL DATASET
                fila0 = DTDataCXC.Rows[0];
                numero = fila0["Recibo_Id"].ToString();
                ncf = fila0["NCF"].ToString();
                nombreNCF = fila0["Nombre_NCF"].ToString();

                concepto = fila0["Concepto"].ToString();
                nombreUsuario = fila0["Adicionado_Por"].ToString();
                fechaAdicionado = (DateTime)fila0["Fecha_Adicionado"];
                oficinaId = fila0["Oficina_Id"].ToString();
                cajaId = fila0["Caja_Id"].ToString();
                cajaNo = db.GetAsInt("Caja_Id", fila0);
                if (cajaNo <= 0)
                {
                    cajaNo = 1;
                    cajaId = "1";
                }
                titulo = fila0["Descripcion"].ToString();

                //Buscamos los Datos del Cliente
                cedulaRNC = fila0["CedulaRNC"].ToString();
                nombreCliente = fila0["Nombre"].ToString();

                //Buscamos el tipo de transaccion
                if (!(fila0["Tipo_Trans"] is DBNull)) tipoTrans = int.Parse(fila0["Tipo_Trans"].ToString());

                //Buscamos Factura No
                facturaNo = 0;
                if (!(fila0["Factura_No"] is DBNull)) facturaNo = int.Parse(fila0["Factura_No"].ToString());


                //Buscamos Prestamo Id
                prestamoNo = 0;
                if (!(fila0["Documento_Id"] is DBNull)) prestamoNo = int.Parse(fila0["Documento_Id"].ToString());


                capital = double.Parse(fila0["Capital"].ToString());
                interes = double.Parse(fila0["Interes"].ToString());
                demora = double.Parse(fila0["Demora"].ToString());
                otros = double.Parse(fila0["Otros"].ToString());
                total = double.Parse(fila0["Monto"].ToString());

                if (!(fila0["Capital_PFinal"] is DBNull)) capitalPendiente = double.Parse(fila0["Capital_PFinal"].ToString());
                else capitalPendiente = 0;

                if (!(fila0["Capital_PAnterior"] is DBNull)) capitalInicial = double.Parse(fila0["Capital_PAnterior"].ToString());
                else capitalInicial = 0;


                enEfectivo = double.Parse(fila0["En_Efectivo"].ToString());
                enCheques = double.Parse(fila0["En_Cheques"].ToString());
                enTarjeta = double.Parse(fila0["En_Tarjetas"].ToString());
                suCambio = double.Parse(fila0["ADevolver"].ToString());

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
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool EsCajaCerrada(int cajaId, string nombreUsuario)
        {
            bool resultado = false;
            string SSQL = "";
            DataTable MyData = null;
            int conteo = 0;

            try
            {
                SSQL = "SELECT COUNT(*) AS Conteo From TCAJAS_APERTURA_CIERRE" +
                       " WHERE Fecha_Cierre Is Null " +
                       "       And ( Caja_Id = " + cajaId.ToString() + " Or Usuario_En_Caja = '" + nombreUsuario + "' ) ";

                MyData = db.GetSQL(SSQL);

                conteo = int.Parse(MyData.Rows[0]["Conteo"].ToString());

                resultado = (conteo == 0);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool MarcarCajaAbierta(int cajaId, string nombreUsuario)
        {
            bool resultado = false;
            string SSQL = "";
            try
            {
                SSQL = " UPDATE TCAJAS " +
                       "   SET Usuario_En_Caja = '" + nombreUsuario + "' " +
                       "       ,Fecha_Apertura = GetDate() " +
                       " Where Caja_Id = " + cajaId.ToString();

                db.EjecutarSQL(SSQL);
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public void ImprimirTicketReciboCXC(bool esCopia = false)
        {


            CrearTicket ticket1 = new CrearTicket();
            string fecha, hora;

            try
            {
                GetDataEncabezadoCXC();

                //Agregamos el Header
                ticket1.TextoCentro(nombreEmpresaOficina);
                ticket1.TextoCentro(direccionOficina);
                ticket1.TextoCentro("RNC: " + rncEmpresa);
                ticket1.TextoCentro("Telfs.: " + telefonosOficina);        

                //AGREGAMOS SUB HEADER
                fecha = "Fecha: " + fechaAdicionado.ToString("dd/MM/yyyy");
                hora = "Hora: " + fechaAdicionado.ToString("hh:mm:ss tt");
                ticket1.lineasIgual();
                if (cajaNo > 0) ticket1.TextoExtremos("Caja # " + cajaId, "Rec. # " + numero.PadLeft(8, '0'));
                else ticket1.TextoIzquierda("Rec. # " + numero.PadLeft(8, '0'));

                ticket1.TextoIzquierda("Le Atendio: " + nombreUsuario);
                ticket1.TextoExtremos(fecha, hora);

                //AGREGAMOS LOS DATOS DEL COMRPBANTE FISCAL Y DEL CLIENTE
                ticket1.lineasIgual();
                ticket1.lineasVacia();
                ticket1.TextoIzquierda("Cliente: " + nombreCliente);
                ticket1.TextoIzquierda("Cedula\\RNC: " + cedulaRNC);

                if (ncf.Trim() != "")
                {
                    ticket1.lineasVacia();
                    ticket1.TextoIzquierda(nombreNCF.ToUpper());
                    ticket1.TextoIzquierda("NCF: " + ncf);
                }


                ticket1.lineasVacia();
                
                if (tipoTrans <= 1)
                {
                    if (prestamoNo > 0) ticket1.TextoIzquierda("Prestamo No. " + prestamoNo.ToString().PadLeft(8, '0'));
                    if (prestamoNo > 0) ticket1.TextoIzquierda("Capital Inicial: " + capitalInicial.ToString("N2"));
                    if (prestamoNo <= 0) ticket1.TextoIzquierda("Saldo Inicial: " + capitalInicial.ToString("N2"));
                }


                //AGREGAMOS EL CONCEPTO
                ticket1.TextoIzquierda("Concepto: " + concepto);
                ticket1.lineasIgual();


                //AGREGAMOS EL TOTAL
                ticket1.lineasVacia();
                ticket1.AgregarTotales("Capital:", capital);
                ticket1.AgregarTotales("Interes:", interes);
                ticket1.AgregarTotales("Demora:", demora);
                ticket1.AgregarTotales("Otros:", otros);
                ticket1.AgregarTotales("Total:", total);

                //AGREGAMOS UN TOTAL EN BLANCO PARA SEPARAR
                ticket1.lineasVacia();

                //AGREGAMOS DESGLOSE DE PAGO
                ticket1.lineasVacia();
                ticket1.lineasIgual();
                ticket1.TextoCentro("DESGLOSE FORMA PAGO");
                ticket1.lineasGuio();
                ticket1.TextoIzquierda("En efectivo.:" + enEfectivo.ToString("N2"));
                ticket1.TextoIzquierda("Su Cambio...:" + suCambio.ToString("N2"));
                if (enCheques > 0) ticket1.TextoIzquierda("En Cheques..:" + enCheques.ToString("N2"));
                if (enTarjeta > 0) ticket1.TextoIzquierda("En Tarjeta..:" + enTarjeta.ToString("N2"));


                if (tipoTrans <= 1)
                {
                    ticket1.lineasVacia();
                    ticket1.lineasVacia();
                    if (prestamoNo > 0) ticket1.TextoIzquierda("Capital Pendiente: " + capitalPendiente.ToString("N2"));
                    if (prestamoNo <= 0) ticket1.TextoIzquierda("Saldo Pendiente: " + capitalPendiente.ToString("N2"));
                }

                //AGREGAMOS LINEA FIRMA DEL CAJERO
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoCentro("_____________________________");
                ticket1.TextoCentro("Firma y Sello Cajero");

                //Agregamos el slogan de la empresa
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasAsteriscos();
                if (slogan.Trim() != "") ticket1.TextoCentro(slogan.Trim());
  
                ticket1.TextoCentro("GRACIAS POR PREFERIRNOS");
                ticket1.lineasVacia();
                ticket1.lineasVacia(); 

                //POR ULTIMO SE IMPRIME EL TICKET
                ticket1.PrintTicket2(NombreImpresora);

                if (numeroCopias > 0 && !esCopia) ImprimirTicketReciboCXC(true);
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

        public void ImprimirReciboMatricial80()
        {
            CrearTicket ticket1 = new CrearTicket();
            string cadena = "";
            DataTable DTDetalle = null;
            double montoInicial = 0, descuento = 0, balanceFinal = 0, total = 0;
            double totalPago = 0, totalBalanceFinal = 0;

            if (imprimiendo == false)
            {
                imprimiendo = true;
                //OBTENEMOS VALORES DEL DATASET
                GetDataEncabezadoCXC();

                ticket1.maxCar = 80;
                ticket1.leftMargin = 10;
                ticket1.headerImage = logo;

                //Agregamos el Encabezado
                ticket1.AddHeader("");
                ticket1.AddHeader(nombreEmpresaOficina, true);
                ticket1.AddHeader("Direccion: " + direccionOficina, true);
                ticket1.AddHeader("RNC: " + rncEmpresa, true);
                ticket1.AddHeader("Telfs. " + telefonosOficina, true);
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoIzquierda("RECIBO NO.: " + numero.PadLeft(7, '0'), true);
                ticket1.lineasIgual();

                if (ncf != "")
                {
                    ticket1.TextoCentro(nombreNCF.ToUpper());
                    ticket1.lineasVacia();
                }

                if (ncf == "") ticket1.TextoIzquierda("Fecha......: " + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"));
                else ticket1.TextoExtremos("Fecha......: " + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"), "NCF.:" + ncf);

                ticket1.TextoExtremos("Recibo No.: " + numero.PadLeft(8, '0'), "Le Atendio: " + nombreUsuario + ",  Caja No.: " + cajaId);
                ticket1.lineasIgual();

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("RECIBIMOS DE: " + nombreCliente);

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("LA SUMA DE: " + montoLetra.ToUpper());

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("POR CONCEPTO: " + concepto);

                ticket1.lineasVacia();

                //Vamos a colocar los totales
                ticket1.lineasIgual();


                if (MOSTRAR_DETALLE_FACTURAS_PAGADAS == false)
                {
                    if (facturaNo > 0) cadena = "FACTURA NO.: " + facturaNo.ToString().PadLeft(7, '0');
                    else if (prestamoNo > 0) cadena = "PRESTAMO NO.: " + prestamoNo.ToString().PadLeft(7, '0');
                    else cadena = "";

                    ticket1.TextoExtremos(cadena, "Capital....: " + capital.ToString("N2").PadLeft(12, ' ') + "  ");

                    if (prestamoNo > 0) cadena = "CAPITAL PENDIENTE: " + capitalPendiente.ToString("N2");
                    else cadena = "MONTO PENDIENTE: " + capitalPendiente.ToString("N2");

                    ticket1.TextoExtremos(cadena, "Interes....: " + interes.ToString("N2").PadLeft(12, ' ') + "  ");

                    ticket1.TextoDerecha("Demora.....: " + demora.ToString("N2").PadLeft(12, ' ') + "  ");
                    ticket1.TextoDerecha("Otros......: " + otros.ToString("N2").PadLeft(12, ' ') + "   ");
                    ticket1.TextoDerecha("TOTAL NETO.: " + total.ToString("N2").PadLeft(12, ' ') + "   ");
                }

                if (MOSTRAR_DETALLE_FACTURAS_PAGADAS == true)
                {
                    //IMPRIMIMOS EL DETALLE DE LA FACTURAS COBRADAS
                    ticket1.TextoIzquierda("Factura          Monto            Pago       Descuento             Balance Final");
                    ticket1.lineasIgual();
                    DTDetalle = db.GetById("TPRESTAMOS_DETALLE_COBRADO", numero, "Recibo_Id");
                    foreach (DataRow item in DTDetalle.Rows)
                    {
                        facturaNo = db.GetAsInt("Factura_No", item);
                        montoInicial = db.GetAsDouble("Monto_Inicial", item);
                        balanceFinal = db.GetAsDouble("Balance_Final", item);
                        descuento = db.GetAsDouble("Descuento", item);
                        capital = db.GetAsDouble("Capital", item);
                        interes = db.GetAsDouble("Interes", item);
                        demora = db.GetAsDouble("Demora", item);
                        otros = db.GetAsDouble("Otros", item);
                        total = capital + interes + demora + otros;
                        totalPago += total;
                        totalBalanceFinal += balanceFinal;

                        cadena = facturaNo.ToString().PadLeft(7, '0');
                        cadena += montoInicial.ToString("N2").PadLeft(15, ' ');
                        cadena += total.ToString("N2").PadLeft(15, ' ');
                        cadena += descuento.ToString("N2").PadLeft(15, ' ');
                        cadena += balanceFinal.ToString("N2").PadLeft(25, ' ');
                        ticket1.TextoIzquierda(cadena);

                    }
                    ticket1.lineasGuio();
                    cadena = "TOTAL:";
                    cadena += totalPago.ToString("N2").PadLeft(31, ' ');
                    cadena += totalBalanceFinal.ToString("N2").PadLeft(39, ' ');
                    ticket1.TextoIzquierda(cadena, true);
                    ticket1.lineasVacia();
                    ticket1.lineasVacia();
                    cadena = "MONTO PENDIENTE: " + capitalPendiente.ToString("N2") + " ";
                    ticket1.TextoIzquierda(cadena, true);
                   
                }


                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoIzquierda("______________________     _______________________");
                ticket1.TextoIzquierda("     Recibido Por               Entregado Por");

                ticket1.PrintTicket2(NombreImpresora);

                imprimiendo = false;
            }
        }

        public void ImprimirReciboOtrosMatricial80()
        {
            CrearTicket ticket1 = new CrearTicket();
            string cadena = "";

            if (imprimiendo == false)
            {
                imprimiendo = true;
                //OBTENEMOS VALORES DEL DATASET
                GetDataEncabezadoCXC();

                ticket1.maxCar = 80;
                ticket1.leftMargin = 10;
                ticket1.headerImage = logo;

                //Agregamos el Encabezado
                ticket1.AddHeader("");
                ticket1.AddHeader(nombreEmpresaOficina, true);
                ticket1.AddHeader("Direccion: " + direccionOficina, true);
                ticket1.AddHeader("RNC: " + rncEmpresa, true);
                ticket1.AddHeader("Telfs. " + telefonosOficina, true);
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoIzquierda(titulo, true);
                ticket1.lineasIgual();

                if (ncf != "")
                {
                    ticket1.TextoCentro(nombreNCF.ToUpper());
                    ticket1.lineasVacia();
                }

                if (ncf == "") ticket1.TextoIzquierda("Fecha......: " + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"));
                else ticket1.TextoExtremos("Fecha......: " + fechaAdicionado.ToString("dd/MM/yyyy hh:mm:ss tt"), "NCF.:" + ncf);

                ticket1.TextoExtremos("Recibo No.: " + numero.PadLeft(8, '0'), "Le Atendio: " + nombreUsuario + ", Caja No.: " + cajaId);
                ticket1.lineasIgual();

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("RECIBIMOS DE: " + nombreCliente);

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("LA SUMA DE: " + montoLetra.ToUpper());

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("POR CONCEPTO: " + concepto);

                //Vamos a colocar los totales
                ticket1.lineasIgual();
                ticket1.lineasVacia();

                if (facturaNo > 0) cadena = "FACTURA NO.: " + facturaNo.ToString().PadLeft(7, '0');

                ticket1.TextoExtremos (cadena,  "Capital....: " + capital.ToString("N2").PadLeft(12, ' '));

                ticket1.TextoDerecha("Interes....: " + interes.ToString("N2").PadLeft(12, ' ') + "  ");
                ticket1.TextoDerecha("Demora.....: " + demora.ToString("N2").PadLeft(12, ' ') + "  ");
                ticket1.TextoDerecha("Otros......: " + otros.ToString("N2").PadLeft(12, ' ') + "  ");
                ticket1.TextoDerecha("TOTAL NETO.: " + total.ToString("N2").PadLeft(12, ' ') + "  ", true);

                ticket1.lineasVacia();
                ticket1.TextoIzquierda("______________________     _______________________");
                ticket1.TextoIzquierda("     Recibido Por               Entregado Por");

                ticket1.PrintTicket2(NombreImpresora);

                imprimiendo = false;
            }
        }

        public void ImprimirTicketOtrosIngresos(DataTable MyData, int numeroCopias, string nombreImpresora)
        {
            string numero = "0";
            string ncf = "";
            string nombreNCF = "";
            string concepto = "";
            string ANombre = "";
            string cedulaRNC = "";
            string oficinaId = "0";
            string cajaId = "0";
            string nombreUsuario = "";
            DateTime fechaAdicionado;

            DataTable DTOficina = null;
            DataRow filaOficina = null;
            string nombreEmpresaOficina;
            string direccionOficina;
            string rncEmpresa;
            string telefonosOficina;
            string slogan = "";
            string fecha, hora;

            double capital, interes, demora, otros, total;
            double enEfectivo = 0, enCheques = 0, enTarjeta = 0, suCambio = 0;

            CrearTicket ticket1 = new CrearTicket();
            

            try
            {

                //OBTENEMOS VALORES DEL DATASET
                numero = MyData.Rows[0]["Recibo_Id"].ToString();
                ncf = MyData.Rows[0]["NCF"].ToString();
                nombreNCF = MyData.Rows[0]["Nombre_NCF"].ToString().ToUpper();
                concepto = MyData.Rows[0]["Concepto"].ToString();
                ANombre = MyData.Rows[0]["Nombre"].ToString();
                cedulaRNC = MyData.Rows[0]["CedulaRNC"].ToString();

                cajaId = MyData.Rows[0]["Caja_Id"].ToString();
                cajaNo = db.GetAsInt("Caja_Id", MyData.Rows[0]);
                if (cajaNo <= 0) cajaId = "1";

                nombreUsuario = MyData.Rows[0]["Adicionado_Por"].ToString();
                fechaAdicionado = (DateTime)MyData.Rows[0]["Fecha_Adicionado"];

                capital = double.Parse(MyData.Rows[0]["Capital"].ToString());
                interes = double.Parse(MyData.Rows[0]["Interes"].ToString());
                demora = double.Parse(MyData.Rows[0]["Demora"].ToString());
                otros = double.Parse(MyData.Rows[0]["Otros"].ToString());
                total = double.Parse(MyData.Rows[0]["Monto"].ToString());

                enEfectivo = double.Parse(MyData.Rows[0]["En_Efectivo"].ToString());
                enCheques = double.Parse(MyData.Rows[0]["En_Cheques"].ToString());
                enTarjeta = double.Parse(MyData.Rows[0]["En_Tarjetas"].ToString());
                suCambio = double.Parse(MyData.Rows[0]["ADevolver"].ToString());


                //BUSCAMOS LOS DATOS DE LA OFICINA
                oficinaId = MyData.Rows[0]["Oficina_Id"].ToString();
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


                //Agregamos el Header
                ticket1.TextoCentro(nombreEmpresaOficina);
                ticket1.TextoCentro(direccionOficina);
                ticket1.TextoCentro("RNC: " + rncEmpresa);
                ticket1.TextoCentro("Telfs.: " + telefonosOficina);

                //AGREGAMOS SUB HEADER
                fecha = "Fecha: " + fechaAdicionado.ToString("dd/MM/yyyy");
                hora = "Hora: " + fechaAdicionado.ToString("hh:mm:ss tt");
                ticket1.lineasIgual();
                ticket1.TextoExtremos("Caja # " + cajaId, "Rec. # " + numero.PadLeft(8, '0'));
                ticket1.TextoIzquierda("Le Atendio: " + nombreUsuario);
                ticket1.TextoExtremos(fecha, hora);

                //AGREGAMOS NOMBRE DEL CLIENTE Y CONCEPTO
                ticket1.lineasIgual();
                ticket1.lineasVacia();
                ticket1.TextoIzquierda("Cliente.: " + ANombre);
                ticket1.TextoIzquierda("CedulaRNC.: " + cedulaRNC);
                ticket1.TextoIzquierda("Concepto: " + concepto);

                //AGREGAMOS LOS DATOS DEL COMRPBANTE FISCAL
                if (ncf.Trim() != "")
                {
                    ticket1.lineasVacia();
                    ticket1.TextoIzquierda(nombreNCF);
                    ticket1.TextoIzquierda("NCF: " + ncf);
                }

                ticket1.lineasIgual();
                ticket1.lineasVacia();
                //AGREGAMOS EL TOTAL
                ticket1.AgregarTotales("Capital:", capital);
                ticket1.AgregarTotales("Interes:", interes);
                ticket1.AgregarTotales("Demora:", demora);
                ticket1.AgregarTotales("Otros:", otros);
                ticket1.AgregarTotales("Total:", total);


                //AGREGAMOS UN TOTAL EN BLANCO PARA SEPARAR
                ticket1.lineasVacia();

                //AGREGAMOS DESGLOSE DE PAGO
                ticket1.lineasVacia();
                ticket1.lineasIgual();
                ticket1.TextoCentro("DESGLOSE FORMA PAGO");
                ticket1.lineasGuio();
                ticket1.TextoIzquierda("En efectivo.:" + enEfectivo.ToString("N2"));
                ticket1.TextoIzquierda("Su Cambio...:" + suCambio.ToString("N2"));
                if (enCheques > 0) ticket1.TextoIzquierda("En Cheques..:" + enCheques.ToString("N2"));
                if (enTarjeta > 0) ticket1.TextoIzquierda("En Tarjeta..:" + enTarjeta.ToString("N2"));

                //AGREGAMOS LINEA FIRMA DEL CAJERO
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.TextoCentro("_____________________________");
                ticket1.TextoCentro("Firma y Sello Cajero");


                //AGREGAMOS UN TOTAL EN BLANCO PARA SEPARAR
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasVacia();
                ticket1.lineasAsteriscos();

                //Agregamos el slogan de la empresa
                if (slogan.Trim() != "")
                {
                    ticket1.TextoCentro(slogan.Trim());
                    ticket1.lineasVacia();
                }


                ticket1.TextoCentro("GRACIAS POR PREFERIRNOS");
                ticket1.lineasVacia();
                ticket1.lineasVacia();

                //POR ULTIMO SE IMPRIME EL TICKET
                ticket1.PrintTicket2(nombreImpresora);


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

    }
}
