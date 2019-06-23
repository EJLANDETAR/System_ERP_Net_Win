using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace ELRPrintDocument
{
    public class ELRDocument
    {
        OfficeDriver.WordDriver wordDriver = new OfficeDriver.WordDriver();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        WinControl_ELR_NET.ELRUtils utils = new WinControl_ELR_NET.ELRUtils();
        DataTable DTRepresentante = null;
        string targetFile = "";
        string targetPDF = "";
        string civiles = "", IDs = "", nombres = "", direcciones = "", monedaNom = "", monedaSimb = "";


        void ChangeLabelsSector(int sectorId, string prefijo, string sexo = "M")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            
            int municipioId = 0;
            try
            {
                DTData = db.GetById("VSECTORES", sectorId.ToString(), "Sector_Id");
                if (DTData.Rows.Count > 0)
                {
                    fila0 = DTData.Rows[0];
                    municipioId = db.GetAsInt("Municipio_Id", fila0);
                } 

                wordDriver.ChangeOneValue("<" + prefijo + "_SEC>", db.GetAsString("Nombre", fila0));
                ChangeLabelsLocalidad(municipioId, prefijo, sexo);

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsLocalidad(int municipioId, string prefijo, string sexo)
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string nacionalidad = "";
            try
            {
                DTData = db.GetById("VMUNICIPIOS", municipioId.ToString(), "Municipio_Id");
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                if (sexo.ToUpper() == "M") nacionalidad = db.GetAsString("Nacionalidad_M", fila0);
                if (sexo.ToUpper() == "F" || nacionalidad.Trim() == "") nacionalidad = db.GetAsString("Nacionalidad", fila0);

                wordDriver.ChangeOneValue("<" + prefijo + "_PROVINCIA>", db.GetAsString("Provincia", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_MUNICIPIO>", db.GetAsString("Nombre", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_PRO>", db.GetAsString("Provincia", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_PROV>", db.GetAsString("Provincia", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_MUN>", db.GetAsString("Nombre", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_NACIONALIDAD>", nacionalidad);
                wordDriver.ChangeOneValue("<" + prefijo + "_NAC>", nacionalidad);

                if(fila0 != null)
                {
                    if (direcciones.Length > 0) direcciones += ", ";
                    direcciones += db.GetAsString("Nombre", fila0) + " PROVINCIA " + db.GetAsString("Provincia", fila0);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsEmpresa(int empresaId = 0)
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "SELECT TOP 1 * FROM TEMPRESAS ";

            try
            {
                if (empresaId > 0) SSQL += " WHERE Empresa_Id = " + empresaId.ToString();

                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                wordDriver.ChangeOneValue("<EMPRESA_RNC>", db.GetAsString("RNC", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_NOM>", db.GetAsString("Nombre", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_SIGLAS>", db.GetAsString("Siglas", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_SLOGAN>", db.GetAsString("slogan", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_MSG_FACTURA>", db.GetAsString("Mensaje_Factura", fila0));
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsOficina(int oficinaId = 0)
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            int municipioId = 0;
            string SSQL = "SELECT TOP 1 * FROM TEMPRESAS_OFICINAS WHERE 1=1 ";

            try
            {
                if (oficinaId > 0) SSQL += " And Oficina_Id = " + oficinaId.ToString();
                else SSQL += " And (tipo = 'P' Or EsPrincipal = 1) ";
                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                wordDriver.ChangeOneValue("<OFICINA_NOM>", db.GetAsString("Nombre", fila0));
                wordDriver.ChangeOneValue("<OFICINA_DIRECCION>", db.GetAsString("Direccion", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_DIRECCION>", db.GetAsString("Direccion", fila0));
                wordDriver.ChangeOneValue("<OFICINA_TELEFONO1>", db.GetAsString("Telefono1", fila0));
                wordDriver.ChangeOneValue("<OFICINA_TELEFONO2>", db.GetAsString("Telefono2", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_TELEFONO1>", db.GetAsString("Telefono1", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_TELEFONO2>", db.GetAsString("Telefono2", fila0));
                wordDriver.ChangeOneValue("<OFICINA_TELEFONO1>", db.GetAsString("Telefono1", fila0));
                wordDriver.ChangeOneValue("<OFICINA_GERENTE>", db.GetAsString("Gerente", fila0));
                wordDriver.ChangeOneValue("<EMPRESA_GERENTE>", db.GetAsString("Gerente", fila0));

                //BUSCAMOS LA LOCALIDAD DE LA OFICINAS
                municipioId = db.GetAsInt("Municipio_Id", fila0);
                ChangeLabelsLocalidad(municipioId, "OFICINA", "");

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsRepresentante(string prefijo, int valorUnico = 0)
        {
            DataRow fila0 = null;
            string sexo = "M", estadoCivil = "S", estadoCivilD = "SOLTERO";
            string SSQL = "";
            int municipioId = 0;
            string nombre = "";

            try
            {
                if (valorUnico > 0)
                {
                    SSQL = "SELECT TOP 1 * FROM TEMPRESAS_REPRESENTANTES WHERE Fecha_Deleted Is Null AND Unico = " + valorUnico.ToString();
                    DTRepresentante = db.GetSQL(SSQL);
                }

                if (DTRepresentante.Rows.Count > 0) fila0 = DTRepresentante.Rows[0];

                wordDriver.ChangeOneValue("<" + prefijo + "_NOM>", db.GetAsString("Nombres", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_APE>", db.GetAsString("Apellidos", fila0));

                nombre = db.GetAsString("Nombres", fila0);
                nombre += " " + db.GetAsString("Apellidos", fila0);
                wordDriver.ChangeOneValue("<" + prefijo + "_NOM>", nombre);

                wordDriver.ChangeOneValue("<" + prefijo + "_CED_RNC>", db.GetAsString("CedulaRNC", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_ID>", db.GetAsString("CedulaRNC", fila0));

                wordDriver.ChangeOneValue("<" + prefijo + "_TELEFONO1>", db.GetAsString("Telefono1", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_TELEFONO2>", db.GetAsString("Telefono2", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_DIRECCION>", db.GetAsString("Direccion", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_TITULO>", db.GetAsString("Direccion", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_NO_OFICIO>", db.GetAsString("NoOficio", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_NUM>", db.GetAsString("NoOficio", fila0));

                //Agregamos las etiquetas del sexo
                sexo = db.GetAsString("Sexo", fila0).ToUpper();
                if (sexo == "M") wordDriver.ChangeOneValue("<" + prefijo + "_SEXO>", "MASCULINO");
                else if (sexo == "F") wordDriver.ChangeOneValue("<" + prefijo + "_SEXO>", "FEMENINO");
                else wordDriver.ChangeOneValue("<" + prefijo + "_SEXO>", "");

                //Agregamos las etiquetas del estado civil
                estadoCivil = db.GetAsString("Estado_Civil", fila0);
                if (estadoCivil == "C") estadoCivilD = "CASADO";
                else if (estadoCivil == "S") estadoCivilD = "SOLTERO";
                else if (estadoCivil == "D") estadoCivilD = "DIVORCIADO";
                else if (estadoCivil == "V") estadoCivilD = "VIUDO";
                else if (estadoCivil == "UL") estadoCivilD = "EN UNION LIBRE";

                wordDriver.ChangeOneValue("<" + prefijo + "_ESTADO_CIVIL>", estadoCivilD);
                wordDriver.ChangeOneValue("<" + prefijo + "_CIVIL>", estadoCivilD);


                //BUSCAMOS LA LOCALIDAD
                municipioId = db.GetAsInt("Municipio_Id", fila0);
                ChangeLabelsLocalidad(municipioId, prefijo, sexo);


            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsGerente(int oficinaId = 0, string cedulaRNC = "")
        {
            string SSQL = "";
            try
            {
                SSQL = " SELECT TOP 1 * FROM TEMPRESAS_REPRESENTANTES WHERE EsGerente = 1 And Fecha_Deleted Is Null ";

                if (cedulaRNC.Trim() != "") SSQL += " And REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";
                SSQL += " And Oficina_Id IN (0, " + oficinaId.ToString() + ")";
                SSQL += " Order by Oficina_Id Desc";

                DTRepresentante = db.GetSQL(SSQL);
                ChangeLabelsRepresentante("GER");

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsNotario(int oficinaId = 0, string cedulaRNC = "")
        {
            string SSQL = "";
            try
            {
                SSQL = " SELECT TOP 1 * FROM TEMPRESAS_REPRESENTANTES WHERE EsNotario = 1 And Fecha_Deleted Is Null ";

                if (cedulaRNC.Trim() != "") SSQL += " And REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";
                SSQL += " And Oficina_Id IN (0, " + oficinaId.ToString() + ")";
                SSQL += " Order by Oficina_Id Desc";

                DTRepresentante = db.GetSQL(SSQL);
                ChangeLabelsRepresentante("NOT");

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsAbogado(int oficinaId = 0, string cedulaRNC = "")
        {
            string SSQL = "";
            try
            {
                SSQL = " SELECT TOP 1 * FROM TEMPRESAS_REPRESENTANTES WHERE EsAbogado = 1 And Fecha_Deleted Is Null ";

                if (cedulaRNC.Trim() != "") SSQL += " And REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";
                SSQL += " And Oficina_Id IN (0, " + oficinaId.ToString() + ")";
                SSQL += " Order by Oficina_Id Desc";

                DTRepresentante = db.GetSQL(SSQL);
                ChangeLabelsRepresentante("ABOG");

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsAlguacil(int oficinaId = 0, string cedulaRNC = "")
        {
            string SSQL = "";
            try
            {
                SSQL = " SELECT TOP 1 * FROM TEMPRESAS_REPRESENTANTES WHERE EsAlguacil = 1 And Fecha_Deleted Is Null ";

                if (cedulaRNC.Trim() != "") SSQL += " And REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";
                SSQL += " And Oficina_Id IN (0, " + oficinaId.ToString() + ")";
                SSQL += " Order by Oficina_Id Desc";

                DTRepresentante = db.GetSQL(SSQL);
                ChangeLabelsRepresentante("ALGC");

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsTestigo(int oficinaId = 0, string cedulaRNC = "")
        {
            string SSQL = "";
            DataTable DTData = null;
            int valorUnico = 0, I = 1;
            try
            {
                SSQL = " SELECT * FROM TEMPRESAS_REPRESENTANTES WHERE EsTestigo = 1 And Fecha_Deleted Is Null ";

                if (cedulaRNC.Trim() != "") SSQL += " And REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";
                SSQL += " And Oficina_Id IN (0, " + oficinaId.ToString() + ")";
                SSQL += " Order by Oficina_Id Desc";

                DTData = db.GetSQL(SSQL);
                foreach (DataRow item in DTData.Rows)
                {
                    valorUnico = db.GetAsInt("Unico", item);
                    ChangeLabelsRepresentante("TEST" + I.ToString(), valorUnico);
                    I++;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        string GetDescripcionPersona(int entidadId, string cedulaRNC)
        {
            string resultado = "";
            string SSQL = "", estadoCivil = "";
            DataTable DTData = null;
            DataRow fila0 = null;

            try
            {
                SSQL = "SELECT TOP 1 * FROM TCLASIFICADOR_ENTIDADES WHERE ";
                if (entidadId > 0) SSQL += " Entidad_Id = " + entidadId.ToString();
                else SSQL += " REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";

                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0)
                {
                    fila0 = DTData.Rows[0];
                    resultado += db.GetAsString("Nombres", fila0);
                    resultado += " " + db.GetAsString("Apellidos", fila0);
                    resultado += " PORTADOR DE LA CEDULA DE IDENTIDAD Y ELECTORAL NO. ";
                    resultado += db.GetAsString("CedulaRNC", fila0);
                    resultado += " MAYOR DE EDAD";

                    //Agregamos las etiquetas del estado civil
                    estadoCivil = db.GetAsString("Estado_Civil", fila0);
                    if (estadoCivil == "C") resultado += " CASADO";
                    else if (estadoCivil == "S") resultado += " SOLTERO";
                    else if (estadoCivil == "D") resultado += " DIVORCIADO";
                    else if (estadoCivil == "V") resultado += " VIUDO";
                    else if (estadoCivil == "UL") resultado += " EN UNION LIBRE";

                    resultado += " RESIDENTE EN ";
                    resultado += db.GetAsString("Direccion", fila0);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        void ChangeLabelsEntidad(int entidadId, string cedulaRNC = "", string prefijo = "CLI")
        {
            string SSQL = "";
            DataTable DTData = null;
            DataRow fila0 = null;
            double montoIngresos = 0;
            string sexo = "", estadoCivil = "", nombre = "", estadoCivilD = "";
            int municipioId = 0, anio, mes, sectorId = 0;
            DateTime feNac;

            try
            {
                SSQL = "SELECT TOP 1 * FROM TCLASIFICADOR_ENTIDADES WHERE ";
                if (entidadId > 0) SSQL += " Entidad_Id = " + entidadId.ToString();
                else SSQL += " REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Replace("-", "") + "'";

                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                wordDriver.ChangeOneValue("<" + prefijo + "_NOM>", db.GetAsString("Nombres", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_APE>", db.GetAsString("Apellidos", fila0));

              
                nombre = db.GetAsString("Nombres", fila0);
                nombre += " " + db.GetAsString("Apellidos", fila0);
                wordDriver.ChangeOneValue("<" + prefijo + "_NOM>", nombre);
                wordDriver.ChangeOneValue("<" + prefijo + "_FIRMA>", nombre);

                if (nombres.Length > 0) nombres += ", " + nombre;


                wordDriver.ChangeOneValue("<" + prefijo + "_APODOS>", db.GetAsString("Apodos", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_CED_RNC>", db.GetAsString("CedulaRNC", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_ID>", db.GetAsString("CedulaRNC", fila0));

                if (IDs.Length > 0) IDs += ", ";
                IDs += db.GetAsString("CedulaRNC", fila0);

                wordDriver.ChangeOneValue("<" + prefijo + "_TELEFONO1>", db.GetAsString("Telefono1", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_TELEFONO2>", db.GetAsString("Telefono2", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_WHATSAPP>", db.GetAsString("TelWhatsaap", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_DIRECCION>", db.GetAsString("Direccion", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_DIR>", db.GetAsString("Direccion", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_CALLE_NO>", db.GetAsString("Calle_Numero", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_PROXIMO_A>", db.GetAsString("Proximo_A", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_EMAIL>", db.GetAsString("EMail", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_OCUPACION>", db.GetAsString("Ocupacion", fila0));
                montoIngresos = db.GetAsDouble("Ingreso_Mensual", fila0);
                wordDriver.ChangeOneValue("<" + prefijo + "_INGRESOS_MES>", montoIngresos.ToString("N2"));

                if (direcciones.Length > 0) direcciones += ", ";
                direcciones += db.GetAsString("Direccion", fila0);

                //Agregamos las etiquetas del sexo
                sexo = db.GetAsString("Sexo", fila0).ToUpper();
                if (sexo == "M") wordDriver.ChangeOneValue("<" + prefijo + "_SEXO>", "MASCULINO");
                else if (sexo == "F") wordDriver.ChangeOneValue("<" + prefijo + "_SEXO>", "FEMENINO");
                else wordDriver.ChangeOneValue("<" + prefijo + "_SEXO>", "");

                //Agregamos las etiquetas del estado civil
                estadoCivil = db.GetAsString("Estado_Civil", fila0);
                if (estadoCivil == "C") estadoCivilD = "CASADO";
                else if (estadoCivil == "S") estadoCivilD = "SOLTERO";
                else if (estadoCivil == "D") estadoCivilD = "DIVORCIADO";
                else if (estadoCivil == "V") estadoCivilD = "VIUDO";
                else if (estadoCivil == "UL") estadoCivilD = "EN UNION LIBRE";

                wordDriver.ChangeOneValue("<" + prefijo + "_ESTADO_CIVIL>", estadoCivilD);
                wordDriver.ChangeOneValue("<" + prefijo + "_CIVIL>", estadoCivilD);

                if (civiles.Length > 0) civiles += ", ";
                civiles += estadoCivilD;

                //AGREGAMOS LAS ETIQUETAS DE FECHA DE NACIMIENTO Y EDAD
                feNac = db.GetAsDate("Fecha_Nacimiento", fila0);
                ChangeLabelsFecha(feNac, prefijo + "_FENAC", true);


                //AGREGAMOS LAS ETIQUETAS DEL CONYUGUE
                wordDriver.ChangeOneValue("<" + prefijo + "_CONYUGUE>", db.GetAsString("Conyugue_Nombres", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_CONYUGUE_TELEFONO>", db.GetAsString("Conyugue_Telefono", fila0));

                //AGREGAMOS LAS ETIQUETAS PARA LA INFORMACION LABORAL
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA>", db.GetAsString("Empresa_Nombre", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_DIRECCION>", db.GetAsString("Empresa_Direccion", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_TELEFONO>", db.GetAsString("Empresa_Telefono", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_SALARIO>", db.GetAsString("Empresa_Salario", fila0));
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_SUPERVISOR>", db.GetAsString("Empresa_Supervisor", fila0));
                anio = db.GetAsInt("Empresa_Anio", fila0);
                mes = db.GetAsInt("Empresa_Mes", fila0);
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_ANIO>", anio.ToString());
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_MES>", mes.ToString());
                wordDriver.ChangeOneValue("<" + prefijo + "_EMPRESA_TIEMPO>", anio.ToString() + " AÑO(S) Y " + mes.ToString() + " MESES");

                //BUSCAMOS LA LOCALIDAD
                municipioId = db.GetAsInt("Municipio_Id", fila0);
                if (municipioId > 0) ChangeLabelsLocalidad(municipioId, prefijo, sexo);

                //BUSCAMOS LOS DATOS DEL SECTOR
                sectorId = db.GetAsInt("Sector_Id", fila0);
                ChangeLabelsSector(sectorId, prefijo, sexo);

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsFecha(DateTime fecha, string prefijo, bool conEdad = false)
        {
            int anio, mes, dia;
            DateTime feActual = DateTime.Now;
            string enLetra = "";
            try
            {
                anio = fecha.Year;
                mes = fecha.Month;
                dia = fecha.Day;
                wordDriver.ChangeOneValue("<" + prefijo + "_DIA>", dia.ToString());
                enLetra = Numalet.ToCardinal(dia);
                wordDriver.ChangeOneValue("<" + prefijo + "_DIA_LET>", enLetra.ToUpper());

                wordDriver.ChangeOneValue("<" + prefijo + "_MES>", mes.ToString());
                enLetra = utils.GetNombreMes(mes);
                wordDriver.ChangeOneValue("<" + prefijo + "_MES_LET>", enLetra.ToUpper());

                wordDriver.ChangeOneValue("<" + prefijo + "_ANIO>", anio.ToString());
                enLetra = Numalet.ToCardinal(anio);
                wordDriver.ChangeOneValue("<" + prefijo + "_ANIO_LET>", enLetra.ToUpper());

                wordDriver.ChangeOneValue("<" + prefijo + "_FECHA>", fecha.ToString("dd/MM/yyyy hh:mm:ss tt"));

                if (conEdad)
                {
                    anio = feActual.Year - fecha.Year;
                    mes = feActual.Month - fecha.Month;
                    dia = feActual.Day - fecha.Day;

                    if (mes <= 0)
                    {
                        anio--;
                        mes = (12 - fecha.Month) + feActual.Month;
                        if (dia <= 0)
                        {
                            mes--;
                            dia = feActual.Day;
                        }
                    }

                    wordDriver.ChangeOneValue("<" + prefijo + "_EDAD_DIA>", dia.ToString());
                    wordDriver.ChangeOneValue("<" + prefijo + "_EDAD_MES>", mes.ToString());
                    wordDriver.ChangeOneValue("<" + prefijo + "_EDAD_ANIO>", anio.ToString());
                    wordDriver.ChangeOneValue("<" + prefijo + "_EDAD>", anio.ToString() + " AÑO, " + mes.ToString() + " MESES Y " + dia.ToString() + " DIAS ");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsMonto(double monto, string prefijo, string moneda = "")
        {
            string valor = "0.00";
            string enLetra = "";
            try
            {
                valor = monto.ToString("N2");
                if (moneda.Trim() != "") valor = moneda.Trim() + " " + valor;

                enLetra = Numalet.ToCardinal(monto);

                wordDriver.ChangeOneValue("<" + prefijo + ">", valor);
                wordDriver.ChangeOneValue("<" + prefijo + "_LET>", enLetra.ToUpper());
                wordDriver.ChangeOneValue("<" + prefijo + "_LETRA>", enLetra.ToUpper());

                ChangeLabelsMoneda(moneda, "MONEDA");

            }
            catch (Exception)
            {

                throw;
            }
        }
                
        void ChangeLabelsMoneda(string codigo, string prefijo = "MONEDA")
        {
            string SSQL = "";
            DataTable DTData = null;
            DataRow fila0 = null;

            try
            {
                if (codigo == "0") codigo = "RD";
                else if (codigo.Trim() == "") codigo = "RD";

                SSQL = "SELECT TOP 1 * FROM TSISTEMA_MONEDAS WHERE Codigo like '" + codigo.Trim() + "%' ";
                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                monedaNom = db.GetAsString("Nombre", fila0).ToUpper();
                monedaSimb = db.GetAsString("Codigo", fila0).ToUpper();

                wordDriver.ChangeOneValue("<" + prefijo + "_SIMB>", monedaSimb);
                wordDriver.ChangeOneValue("<" + prefijo + ">", monedaNom);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsFormaPago(string formaPago, string prefijo)
        {
            string valor = formaPago;
            try
            {
                if (formaPago.ToUpper() == "D") valor = "DIARIO";
                if (formaPago.ToUpper() == "I") valor = "INTERDIARIO";
                if (formaPago.ToUpper() == "S") valor = "SEMANALES";
                if (formaPago.ToUpper() == "Q") valor = "QUINCENALES";
                if (formaPago.ToUpper() == "M") valor = "MENSUALES";

                wordDriver.ChangeOneValue("<" + prefijo + ">", valor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsDeudores(int solicitudId, int prestamoId = 0)
        {
            DataTable DTData = null;
            string SSQL = "", prefijo = "";
            int entidadId = 0, conteo = 0;

            try
            {
                IDs = ""; civiles = ""; nombres = ""; direcciones = "";

                SSQL = "SELECT * FROM VPRESTAMOS_SOLICITUD_DEUDORES WHERE Fecha_Deleted Is Null ";
                if (solicitudId > 0) SSQL += " and Solicitud_Id = " + solicitudId.ToString();
                if (prestamoId > 0) SSQL += " and Prestamo_Id = " + prestamoId.ToString();
                SSQL += " Order by EsPrincipal Desc, Entidad_Id ";

                DTData = db.GetSQL(SSQL);
                foreach (DataRow fila in DTData.Rows)
                {
                    if (conteo <= 0) prefijo = "CLI";
                    else prefijo = "CLI" + conteo.ToString();

                    entidadId = db.GetAsInt("Entidad_Id", fila);
                    ChangeLabelsEntidad(entidadId, "", prefijo);
                    conteo++;
                }

                if (conteo <= 0)
                {
                    //SOLO EN CASO DE NO TENER CODEUDOR PARA DEJARLO VACIO
                    entidadId = -1;
                    prefijo = "CLI";
                    ChangeLabelsEntidad(entidadId, "", prefijo);
                }

                wordDriver.ChangeOneValue("<CLI_NOMBRES>", nombres);
                wordDriver.ChangeOneValue("<CLI_FIRMAS>", nombres);
                wordDriver.ChangeOneValue("<CLI_IDS>", IDs);
                wordDriver.ChangeOneValue("<CLI_CIVILES>", civiles);
                wordDriver.ChangeOneValue("<CLI_DIRECCIONES>", direcciones);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsGarantias(int solicitudId, int prestamoId = 0)
        {
            DataTable DTData = null;
            string SSQL = "", prefijo = "", tipo = "", documentoId = "";
            int entidadId = 0, conteo = 0;
            string descripcion = "", garantias = "", sufijos = "LOS SE";
            double valor = 0;
            DateTime fecha = DateTime.Now.Date;

            try
            {
                IDs = ""; civiles = ""; nombres = ""; direcciones = "" ;

                SSQL = "SELECT * FROM VPRESTAMOS_SOLICITUD_GARANTIAS WHERE Fecha_Deleted Is Null ";
                if (solicitudId > 0) SSQL += " and Solicitud_Id = " + solicitudId.ToString();
                if (prestamoId > 0) SSQL += " and Prestamo_Id = " + prestamoId.ToString();

                DTData = db.GetSQL(SSQL);
                foreach (DataRow fila in DTData.Rows)
                {
                    prefijo = "GAR";
                    entidadId = db.GetAsInt("Entidad_Id", fila);
                    tipo = db.GetAsString("Tipo_Garantia", fila).ToUpper();
                    descripcion = db.GetAsString("Descripcion", fila);
                    documentoId = db.GetAsString("Documento_Id", fila);
                    valor = db.GetAsDouble("valor", fila);

                    //Reemplazamos datos basico de la garantia
                    wordDriver.ChangeOneValue("<GAR_ID>", documentoId);
                    wordDriver.ChangeOneValue("<GAR_DESCRIPCION>", descripcion.ToUpper());
                    ChangeLabelsMonto(valor, "GAR_VALOR");

                    //REEMPLAZAMOS LOS DATOS DE LA GARANTIA DE VEHICULO
                    if (tipo == "V")
                    {
                        wordDriver.ChangeOneValue("<GAR_PLACA_NO>", db.GetAsString("Vehiculo_Placa_Numero", fila));
                        wordDriver.ChangeOneValue("<GAR_CHASIS_NO>", db.GetAsString("Vehiculo_Chasis_Numero", fila));
                        wordDriver.ChangeOneValue("<GAR_TIPO>", db.GetAsString("Vehiculo_Tipo", fila));
                        wordDriver.ChangeOneValue("<GAR_MODELO>", db.GetAsString("Vehiculo_Modelo", fila));
                        wordDriver.ChangeOneValue("<GAR_COLOR>", db.GetAsString("Vehiculo_Color", fila));
                        wordDriver.ChangeOneValue("<GAR_COMBUSTIBLE>", db.GetAsString("Vehiculo_Combustible", fila));
                        wordDriver.ChangeOneValue("<GAR_FAB_ANIO>", db.GetAsInt("Vehiculo_Fabricacion_Anio", fila).ToString());
                        wordDriver.ChangeOneValue("<GAR_MOTOR_NUMERO>", db.GetAsString("Vehiculo_Motor_Numero", fila));
                        wordDriver.ChangeOneValue("<GAR_CANT_PASAJEROS>", db.GetAsInt("Vehiculo_Pasajeros", fila).ToString());
                        wordDriver.ChangeOneValue("<GAR_FUERZA_MOTRIZ>", db.GetAsInt("Vehiculo_Fuerza_Motriz", fila).ToString());
                        valor = db.GetAsDouble("Vehiculo_Carga", fila);
                        ChangeLabelsMonto(valor, "GAR_CARGA");
                        wordDriver.ChangeOneValue("<GAR_CILINDROS>", db.GetAsInt("Vehiculo_Cilindros", fila).ToString());
                        wordDriver.ChangeOneValue("<GAR_PUERTAS>", db.GetAsInt("Vehiculo_Pruetas", fila).ToString());
                        fecha = db.GetAsDate("Vehiculo_Fecha_Adquision", fila);
                        ChangeLabelsFecha(fecha, "GAR_FE_ADQUIS", true);
                        wordDriver.ChangeOneValue("<GAR_TRANSMISION>", db.GetAsString("Vehiculo_Transmision", fila));

                    }

                    if (entidadId > 0 || tipo == "P")
                    {
                        if (garantias.Length > 0) garantias += ", ";
                        garantias += GetDescripcionPersona(entidadId, "");

                        if (conteo <= 0) prefijo = "GAR";
                        else prefijo = "GAR" + conteo.ToString();
                        ChangeLabelsEntidad(entidadId, "", prefijo);
                        conteo++;
                    }
                }

                wordDriver.ChangeOneValue("<GAR_NOMBRES>", nombres);
                wordDriver.ChangeOneValue("<GAR_FIRMAS>", nombres);
                wordDriver.ChangeOneValue("<GAR_IDS>", IDs);
                wordDriver.ChangeOneValue("<GAR_CIVILES>", civiles);
                wordDriver.ChangeOneValue("<GAR_DIRECCIONES>", direcciones);
                wordDriver.ChangeOneValue("<GARANTIAS>", garantias);

                if (conteo <= 0)
                {
                    //SOLO EN CASO DE NO TENER GARANTIA PERSONAL PARA DEJAR VACIO
                    entidadId = -1;
                    prefijo = "GAR";
                    ChangeLabelsEntidad(entidadId, "", prefijo);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsSolicitud(int solicitudId)
        {
            String SSQL = "";
            DataTable DTData = null;
            DataRow fila0 = null;
            int clienteId = 0, plazo = 0, garanteId = 0;
            double monto = 0;
            string motivo = "", formaPago = "";
            DateTime fecha;

            try
            {
                SSQL = "SELECT TOP 1 * FROM VPRESTAMOS_SOLICITUDES WHERE Solicitud_Id = " + solicitudId.ToString();
                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                monedaSimb = db.GetAsString("Moneda_Id", fila0);
                clienteId = db.GetAsInt("Entidad_Id", fila0);
                garanteId = db.GetAsInt("Garante_Id", fila0);
                monto = db.GetAsDouble("Monto_Solicitado", fila0);
                plazo = db.GetAsInt("Plazo", fila0);
                motivo = db.GetAsString("Motivo", fila0);
                formaPago = db.GetAsString("Forma_Pago", fila0);
                fecha = db.GetAsDate("Fecha", fila0);

                ChangeLabelsMoneda(monedaSimb);

                //Reemplazamos los datos de la solicitud
                wordDriver.ChangeOneValue("<SOL_NO>", solicitudId.ToString());
                wordDriver.ChangeOneValue("<SOL_PLAZO>", plazo.ToString());
                wordDriver.ChangeOneValue("<SOL_MOTIVO>", motivo.ToUpper());
                ChangeLabelsFecha(fecha, "SOL_FECHA");
                ChangeLabelsMonto(monto, "SOL_MONTO", monedaSimb);
                ChangeLabelsFormaPago(formaPago, "SOL_FORMA_PAGO");
                ChangeLabelsFormaPago(formaPago, "FORMA_PAGO");

                //Reemplazamos los datos del cliente
                ChangeLabelsEntidad(clienteId, "", "CLI");

                //Reemplazamos los datos del Garante
                ChangeLabelsEntidad(garanteId, "", "GAR");

                //Reemplazamos los datos de los deudores y codeurores
                ChangeLabelsDeudores(solicitudId);

                //Reemplazamos los datos de la Garantias
                ChangeLabelsGarantias(solicitudId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsPlanAmortizacion(int solicitudId, int prestamoId = 0, string prefijo = "SOL")
        {
            string SSQL = "", formaPago = "", enLetra = "", sCuotas = "", monedaId = "";
            DataTable DTData = null;
            DataRow fila0 = null;
            int clienteId = 0;
            double tasaInteres = 0, tasaDemora = 0, monto = 0, montoCuota = 0;
            int plazo = 0, diaAPagar = 0, diasGraDemora = 0;

            try
            {
                SSQL = "SELECT TOP 1 * FROM TPRESTAMOS_AMORTIZACION WHERE 1=1 ";
                if (solicitudId > 0) SSQL += " And Solicitud_Id = " + solicitudId.ToString();
                if (prestamoId < 0) SSQL += " And Prestamo_Id = " + prestamoId.ToString();

                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                fila0 = DTData.Rows[0];
                solicitudId = db.GetAsInt("Solicitud_Id", fila0);
                monedaId = db.GetAsString("Moneda_Id", fila0);
                clienteId = db.GetAsInt("Entidad_Id", fila0);
                monto = db.GetAsDouble("Monto_Prestamo", fila0);
                montoCuota = db.GetAsDouble("Monto_Cuota", fila0);
                plazo = db.GetAsInt("Plazo", fila0);
                formaPago = db.GetAsString("Frecuencia_Pago", fila0);
                tasaInteres = db.GetAsDouble("Tasa_Interes", fila0);
                tasaDemora = db.GetAsDouble("Tasa_Demora", fila0);
                diaAPagar = db.GetAsInt("Dia_APagar", fila0);
                diasGraDemora = db.GetAsInt("Dias_Gracias_Demora", fila0);

                ChangeLabelsMoneda(monedaId, "MONEDA");

                wordDriver.ChangeOneValue("<SOL_NO>", solicitudId.ToString());
                wordDriver.ChangeOneValue("<NUMERO>", solicitudId.ToString());
                wordDriver.ChangeOneValue("<" + prefijo + "_NO>", solicitudId.ToString());
                wordDriver.ChangeOneValue("<" + prefijo + "_NUMERO>", solicitudId.ToString());

                wordDriver.ChangeOneValue("<DIA_APAGAR>", diaAPagar.ToString());
                wordDriver.ChangeOneValue("<" + prefijo +  "_DIA_APAGAR>", diaAPagar.ToString());
                enLetra = Numalet.ToCardinal(diaAPagar).ToUpper();
                wordDriver.ChangeOneValue("<" + prefijo + "_LDIA_APAGAR>", enLetra);
                wordDriver.ChangeOneValue("<LDIA_APAGAR>", enLetra);
                wordDriver.ChangeOneValue("<DIA_APAGAR_LET>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo +"_DIA_APAGAR_LET>", enLetra);

                wordDriver.ChangeOneValue("<" + prefijo + "_PLAZO>", plazo.ToString());
                wordDriver.ChangeOneValue("<" + prefijo + "_PLA>", plazo.ToString());
                enLetra = Numalet.ToCardinal(plazo).ToUpper();
                wordDriver.ChangeOneValue("<" + prefijo + "_PLAZO_LET>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_LPLA>", enLetra);

                ChangeLabelsFormaPago(formaPago, prefijo + "_FORMA_PAGO");
                ChangeLabelsMonto(monto, prefijo + "_MONTO", monedaSimb);
                ChangeLabelsMonto(montoCuota, prefijo + "_MONTO_CUOTA", monedaSimb);

                //Tasa interes anual
                enLetra = Numalet.ToCardinal(tasaInteres).ToUpper();
                ChangeLabelsMonto(tasaInteres, prefijo + "_TASA_ANUAL");
                ChangeLabelsMonto(tasaInteres, prefijo + "_PORANUAL");
                wordDriver.ChangeOneValue("<" + prefijo + "_LTASA_ANUAL>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_LPORANUAL>", enLetra);


                //Tasa interes mensual
                enLetra = Numalet.ToCardinal((tasaInteres / 12.0)).ToUpper();
                ChangeLabelsMonto((tasaInteres / 12.0), prefijo + "_PORMES");
                ChangeLabelsMonto((tasaInteres / 12.0), prefijo + "_POR");
                wordDriver.ChangeOneValue("<" + prefijo + "_PORMES_LETRA>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_PORMES_LET>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_LPORMES>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_POR_LETRA>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_POR_LET>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_LPOR>", enLetra);

                ChangeLabelsMonto(tasaDemora, prefijo + "_DEMORA");
                ChangeLabelsMonto(tasaDemora, prefijo + "_MOR");
                enLetra = Numalet.ToCardinal(tasaDemora).ToUpper();
                wordDriver.ChangeOneValue("<" + prefijo + "_DEMORA_LETRA>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_DEMORA_LET>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_MOR_LETRA>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_MOR_LET>", enLetra);
                wordDriver.ChangeOneValue("<" + prefijo + "_LMOR>", enLetra);
                enLetra = Numalet.ToCardinal(diasGraDemora).ToUpper();
                wordDriver.ChangeOneValue("<" + prefijo + "_DIA_LGRA>", enLetra);
                wordDriver.ChangeOneValue("<DIA_LGRA>", enLetra);
                wordDriver.ChangeOneValue("<DIA_GRA_LET>", enLetra);
                wordDriver.ChangeOneValue("<DIA_GRA>", diasGraDemora.ToString());
                wordDriver.ChangeOneValue("<" + prefijo + "_DIA_GRA>", diasGraDemora.ToString());



                //Cambiamos los datos del Cliente y codeudores
                ChangeLabelsDeudores(solicitudId);

                //Cambiamos los datos del garante
                ChangeLabelsGarantias(solicitudId);

                //Especificamos la descripcion de las cuotas
                sCuotas = Numalet.ToCardinal(plazo).ToUpper() + " (" + plazo.ToString() + ") CUOTAS IGUALES Y CONSECUTIVAS";
                sCuotas += " A RAZON DE " + Numalet.ToCardinal(montoCuota).ToUpper() + " " + monedaNom;
                sCuotas +=  " ( " + monedaSimb + " " + montoCuota.ToString("N2") + ") CADA UNA";
                wordDriver.ChangeOneValue("<SOL_LCUOTAS>", sCuotas);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ChangeLabelsPrestamo(int prestamoId)
        {
            int solicitudId = 0;
            String SSQL = "";
            DataTable DTData = null;
            DataRow fila0 = null;
            try
            {
                SSQL = "SELECT TOP 1 * FROM VPRESTAMOS WHERE Prestamo_Id = " + prestamoId.ToString();
                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                solicitudId = db.GetAsInt("Solicitud_Id", fila0);

                //Reemplazamos los datos segun el plan de amortizacion Creado
                ChangeLabelsPlanAmortizacion(solicitudId, prestamoId);

            }
            catch (Exception)
            {

                throw;
            }
        }

        void openDocument(string sourceFile)
        {
            string[] cadena;
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(sourceFile);

                //copiamos el archivo a la carpeta temporal
                targetFile = Environment.GetEnvironmentVariable("TEMP");
                targetPDF = Environment.GetEnvironmentVariable("TEMP");
                targetFile += @"\" + fi.Name;
                cadena = fi.Name.Split('.');
                targetPDF += @"\" + cadena[0] + ".pdf";

                System.IO.File.Copy(sourceFile, targetFile, true);

                wordDriver.OpenDocument(targetFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void SaveAsPDF()
        {
            DateTime feActual = DateTime.Now;
            try
            {
                ChangeLabelsFecha(feActual, "DOC");
                wordDriver.ChangeOneValue("<IMPRESO_POR>", db.NOMBRE_USUARIO);
                wordDriver.ChangeOneValue("<IMPRESO_FECHA>", feActual.ToString("dd/MM/yyyy hh:mm:ss tt"));
                wordDriver.SaveToPDF(targetPDF);
                wordDriver.CloseDocument();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void setDocImpreso(int valorUnico)
        {
            string SSQL = "";
            try
            {
                SSQL = " UPDATE TSISTEMA_DOCUMENTOS_CONTRACTOS ";
                SSQL += " SET Impreso_Por = '" + db.NOMBRE_USUARIO + "', ";
                SSQL += "     Fecha_Impresion = GetDate() ";
                SSQL += " WHERE Unico = " + valorUnico.ToString();

                db.EjecutarSQL(SSQL);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Definicion de metodos publicos
        public string GenerarContractoPDF(int valorUnico, string nombreUsuario)
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string cedulaRNC = "", codigo = "", docTemplate = "", moneda = "", titulo = "";
            int oficinaId = 0, numero = 0, solicitudId = 0, prestamoId = 0;
            double monto = 0, itbis = 0, retItbis = 0, retISR = 0;
            bool conGerente, conAbogado, conNotario, conAlguacil, conTestigo;

            try
            {
                targetPDF = "";
                db.NOMBRE_USUARIO = nombreUsuario;

                DTData = db.GetById("VSISTEMA_DOCUMENTOS_CONTRACTOS", valorUnico.ToString());
                fila0 = DTData.Rows[0];
                solicitudId = db.GetAsInt("Solicitud_Id", fila0);
                prestamoId = db.GetAsInt("Prestamo_Id", fila0);
                titulo = db.GetAsString("Descripcion", fila0);
                cedulaRNC = db.GetAsString("CedulaRNC", fila0);
                codigo = db.GetAsString("Codigo", fila0).ToUpper();
                docTemplate = db.GetAsString("DocTemplate", fila0);
                numero = db.GetAsInt("Numero", fila0);
                monto = db.GetAsDouble("Monto", fila0);
                itbis = db.GetAsDouble("Itbis", fila0);
                retItbis = db.GetAsDouble("Ret_Itbis", fila0);
                retISR = db.GetAsDouble("Ret_ISR", fila0);
                moneda = db.GetAsString("Moneda", fila0);
                oficinaId = db.GetAsInt("Oficina_Id", fila0);
                conGerente = db.GetAsBoolean("ConGerente", fila0);
                conAbogado = db.GetAsBoolean("ConAbogado", fila0);
                conNotario = db.GetAsBoolean("ConNotario", fila0);
                conAlguacil = db.GetAsBoolean("ConAlguacil", fila0);
                conTestigo = db.GetAsBoolean("ConTestigo", fila0);

                //Abrimos el documento y reemplazamos los datos de las etiquetas
                wordDriver.isOpenOffice = utils.IsOpenOfficeIntalled();
                docTemplate = Environment.CurrentDirectory + @"\DocTemplates\" + docTemplate;
                openDocument(docTemplate);

                //Reemplazamos labels de Solicitud y Prestamos
                if (codigo == "CPA") ChangeLabelsPlanAmortizacion(solicitudId, 0);
                else if (codigo == "SOL" || codigo == "HE" || codigo == "HEP") ChangeLabelsSolicitud(solicitudId);

                //Reemplazamos los labels de empresa y oficina
                ChangeLabelsEmpresa();
                ChangeLabelsOficina(oficinaId);

                //Reemplazamos label representantes
                if (conGerente) ChangeLabelsGerente(oficinaId);
                if (conAbogado) ChangeLabelsAbogado(oficinaId);
                if (conAlguacil) ChangeLabelsAlguacil(oficinaId);
                if (conNotario) ChangeLabelsNotario(oficinaId);
                if (conTestigo) ChangeLabelsTestigo(oficinaId);

                //Reemplazamos los labels de la entidad si es que ya no se hizo por prestamo o solicitud
                if (solicitudId <= 0 && prestamoId <= 0) ChangeLabelsEntidad(0, cedulaRNC.Trim());

                //Reemplazamos la informacion del documento
                wordDriver.ChangeOneValue("<DOC_NO>", numero.ToString());
                wordDriver.ChangeOneValue("<DOC_TITULO>", titulo.ToUpper());
                wordDriver.ChangeOneValue("<DOC_DESCRIPCION>", titulo.ToUpper());
                ChangeLabelsFecha(DateTime.Now, "DOC_FE");
                ChangeLabelsMonto(monto, "DOC_MONTO", moneda);
                ChangeLabelsMonto(itbis, "DOC_ITBIS", moneda);
                ChangeLabelsMonto(retItbis, "DOC_RET_ITBIS", moneda);
                ChangeLabelsMonto(retISR, "DOC_RET_ISR", moneda);

                //Generamos el PDF
                SaveAsPDF();

                //ACTUALIZAMOS EL DOCUMENTO COMO IMPRESO
                setDocImpreso(valorUnico);

                Process.Start(targetPDF);

            }
            catch (Exception)
            {
                targetPDF = "";
                throw;
            }
            finally
            {
                wordDriver.CloseDocument();
            }

            return targetPDF;
        }

        public string GenerarPDFSolicitudCredito(int solicitudId, string codigo, string nombreUsuario)
        {

            Int32 cantDeudores = 0, prestamoId = 0, garanteId, clienteId;
            string tipoGarantia = "P";
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", docTemplate = "", titulo = "";
            bool conGerente, conAbogado, conNotario, conAlguacil, conTestigo;
            int oficinaId = 0;

            try
            {
                db.NOMBRE_USUARIO = nombreUsuario;

                //Buscamos tipo de garantia, prestamo Id y garante Id
                DTData = db.GetSQL("SELECT TOP 1 Oficina_Id, Tipo_Garantia, Prestamo_Id, Entidad_Id, Garante_Id FROM [TPRESTAMOS_SOLICITUD] WHERE Solicitud_Id = " + solicitudId.ToString());
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                oficinaId = db.GetAsInt("Oficina_Id", fila0);
                prestamoId = db.GetAsInt("Prestamo_Id", fila0);
                garanteId = db.GetAsInt("Garante_Id", fila0);
                clienteId = db.GetAsInt("Entidad_Id", fila0);
                tipoGarantia = db.GetAsString("Tipo_Garantia", fila0, "P");
                if (tipoGarantia.Trim() == "") tipoGarantia = "P";

                //Buscamos cantidad de deudores
                DTData = db.GetSQL("SELECT Count(*) as Conteo FROM [TPRESTAMOS_SOLICITUD_DEUDORES] WHERE Fecha_Deleted Is Null And Solicitud_Id = " + solicitudId.ToString());
                fila0 = DTData.Rows[0];
                cantDeudores = db.GetAsInt("Conteo", fila0);

                //Buscamos los datos del template a usar
                SSQL = "SELECT TOP 1 * FROM TCONFIGURACION_DOC_TEMPLATES WHERE EsActivo = 1 ";
                SSQL += "  And Codigo = '" + codigo.Trim() + "'";
                SSQL += "  And Tipo_Garantia_Id = '" + tipoGarantia + "'";
                SSQL += "  And IsNull(Cantidad_Deudores, 0) <= " + cantDeudores.ToString();
                SSQL += " Order by Unico Desc ";

                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count <= 0) throw new Exception("NO EXISTE PLANTILLA PARA GENERAR DOCUMENTO");
                fila0 = DTData.Rows[0];
                docTemplate = db.GetAsString("DocTemplate", fila0);
                titulo = db.GetAsString("Descripcion", fila0);
                conGerente = db.GetAsBoolean("ConGerente", fila0);
                conAbogado = db.GetAsBoolean("ConAbogado", fila0);
                conNotario = db.GetAsBoolean("ConNotario", fila0);
                conAlguacil = db.GetAsBoolean("ConAlguacil", fila0);
                conTestigo = db.GetAsBoolean("ConTestigo", fila0);

                //Abrimos el documento y reemplazamos los datos de las etiquetas
                wordDriver.isOpenOffice = utils.IsOpenOfficeIntalled();
                docTemplate = Environment.CurrentDirectory + @"\DocTemplates\" + docTemplate;
                openDocument(docTemplate);

                //Reemplazamos labels de Solicitud y Prestamos
                if (codigo == "CPA") ChangeLabelsPrestamo(prestamoId);
                else ChangeLabelsSolicitud(solicitudId);

                //Reemplazamos los labels de empresa y oficina
                ChangeLabelsEmpresa();
                ChangeLabelsOficina(oficinaId);

                //Reemplazamos label representantes
                if (conGerente) ChangeLabelsGerente(oficinaId);
                if (conAbogado) ChangeLabelsAbogado(oficinaId);
                if (conAlguacil) ChangeLabelsAlguacil(oficinaId);
                if (conNotario) ChangeLabelsNotario(oficinaId);
                if (conTestigo) ChangeLabelsTestigo(oficinaId);

                //Reemplazamos los datos de la entidad y del garante
                ChangeLabelsEntidad(clienteId);
                ChangeLabelsEntidad(garanteId, "", "GAR");

                wordDriver.ChangeOneValue("<DOC_DESCRIPCION>", titulo.ToUpper());

                //Generamos el PDF
                SaveAsPDF();

                //Mostramos el pdf
                Process.Start(targetPDF);
            }
            catch (Exception)
            {
                targetPDF = "";
                throw;
            }

            return targetPDF;
        }

        public string GenerarPDFDocLegal(int valorUnico)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return targetPDF;
        }

        public string GenerarContractoPDF(int numero, string codigo, string nombreUsuario)
        {
            string resultado = "";
            string SSQL = "";
            int valorUnico = -1;
            DataTable DTData = null;
            try
            {
                SSQL = "SELECT TOP 1 Unico FROM TSISTEMA_DOCUMENTOS_CONTRACTOS WHERE Numero = " + numero.ToString();
                SSQL += " And Codigo = '" + codigo.Trim() + "'";
                SSQL += " Order by Unico Desc";

                db.NOMBRE_USUARIO = nombreUsuario;
                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) valorUnico = db.GetAsInt("Unico", DTData.Rows[0]);

                if (valorUnico > 0) resultado = GenerarContractoPDF(valorUnico, nombreUsuario);
                else throw new Exception("NO EXISTE DOCUMENTO " + codigo.ToUpper() + "[" + numero.ToString() + "] PARA IMPRIMIR");

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

    }
}
