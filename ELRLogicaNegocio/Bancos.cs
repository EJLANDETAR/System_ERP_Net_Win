using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace ELRLogicaNegocio
{
    public class Bancos
    {
        public DataDB_ELR_NET.DataDB db;
        public string fontName = "Lucida Console";
        public int fontSize = 11;
        public string nombreImpresora;

        //Variables Privada
        Font printFont = null;
        SolidBrush myBrush = new SolidBrush(Color.Black);
        DataTable DTCheque = null, DTCuenta = null;
        DataRow fila0 = null;
        int cuentaId = 0, oficinaID = 0;
        double monto = 0;
        string beneficiario = "", fecha = "", concepto = "", referencia = "";
        string dia, mes, anio;
        string montoLetra = "";
        float diasPosX = 0, mesPosX = 0, anioPosX = 0, fechaPosY = 0;
        float nombrePosX = 0, nombrePosY = 0;
        int nombreMaxCar = 0;
        float montoPosX = 0, montoPosY = 0;
        float montoLetraPosX = 0, montoLetraPosY = 0;
        int MontoLetraMaxCar = 0;
        float coletillaPosX = 0, coletillaPosY = 0;
        int numeroCheque = 0;

        public Int32 ImprimirCheque(int transId)
        {
            Int32 resultado = -1;
            int empresaId = 0;
            Int32 numero = 0;
            string SSQL = "";

            try
            {


                db.LimpiarFiltros();
                db.AddFiltroIgualA("Trans_Id", transId.ToString());
                DTCheque = db.GetAll("TBANCOS_TRANS", 1, db.Filtros);

                fila0 = DTCheque.Rows[0];
                empresaId = db.GetAsInt("Empresa_Id", fila0);
                numero = db.GetAsInt("Numero", fila0);
                monto = db.GetAsDouble("Monto", fila0);
                beneficiario = db.GetAsString("Beneficiario", fila0);
                fecha = db.GetDateAsInt("Fecha", fila0).ToString();
                anio = fecha.Substring(0, 4);
                mes = fecha.Substring(4, 2);
                dia = fecha.Substring(6, 2);
                concepto = db.GetAsString("Concepto", fila0);
                cuentaId = db.GetAsInt("Cuenta_Id", fila0);
                oficinaID = db.GetAsInt("Oficina_Id", fila0);

                //montoLetra = Numalet.ToCardinal(monto);

                //Buscamos el Siguiente Numer0
                if(numero <= 0) numero = getNumeroCheque(cuentaId, empresaId);

                numeroCheque = numero;

                //Buscamos los datos de la cuenta
                db.LimpiarFiltros();
                DTCuenta = db.GetAll("TBANCOS_CUENTAS_BANCARIAS", 1, db.Filtros);
                fila0 = DTCuenta.Rows[0];
                diasPosX = db.GetAsInt("Dias_PosX", fila0);
                mesPosX = db.GetAsInt("Mes_PosX", fila0);
                anioPosX = db.GetAsInt("Anio_PosX", fila0);
                fechaPosY = db.GetAsInt("Fecha_PosY", fila0);

                nombrePosX = db.GetAsInt("Nombre_PosX", fila0);
                nombrePosY = db.GetAsInt("Nombre_PosY", fila0);
                nombreMaxCar = db.GetAsInt("Nombre_MaxCar", fila0);

                montoPosX = db.GetAsInt("Monto_PosX", fila0);
                montoPosY = db.GetAsInt("Monto_PosY", fila0);

                montoLetraPosX = db.GetAsInt("Monto_Letra_PosX", fila0);
                montoLetraPosY = db.GetAsInt("Monto_Letra_PosY", fila0);
                MontoLetraMaxCar = db.GetAsInt("Monto_Letra_MaxCar", fila0);

                coletillaPosX = db.GetAsInt("Coletilla_PosX", fila0);
                coletillaPosY = db.GetAsInt("Coletilla_PosY", fila0);

                printFont = new Font(fontName, fontSize, FontStyle.Regular);
                PrintDocument pr = new PrintDocument();
                pr.PrinterSettings.PrinterName = nombreImpresora;
                pr.PrintController = new StandardPrintController();
                pr.PrintPage += new PrintPageEventHandler(pr_PrintPageCheque);
                pr.Print();


                //Marcamos el cheque como impreso
                referencia = oficinaID.ToString() + "-CHK-" + cuentaId + "-" + numero.ToString().PadLeft(8, '0');


                SSQL = "UPDATE TBANCOS_TRANS ";
                SSQL += " SET Numero = " + numero.ToString();
                SSQL += "     ,Impreso_Por = '" + db.NOMBRE_USUARIO + "'";
                SSQL += "     ,EsImpreso   = 1";
                SSQL += "     ,Fecha_Impreso = GetDate() ";
                SSQL += "     ,Referencia = '" + referencia + "'";
                SSQL += " WHERE Trans_Id = " + transId.ToString();

                if (db.EjecutarSQL(SSQL) > 0) resultado = numero;
                else resultado = -1;

            }
            catch (Exception)
            {
                resultado = -1;
                throw;
            }

            return resultado;
        }

        public Int32 getNumeroCheque(int cuentaId, int empresaId)
        {
            DataTable DTData = null;
            string SSQL = "";
            Int32 numero1 = 1, numero2 = 1, resultado = 1;
            try
            {
                if (db == null) db = new DataDB_ELR_NET.DataDB();

                //Buscamos el numero definido en la tabla
                SSQL = "SELECT TOP 1 IsNull(Secuencia_Cheques, 0) + 1 as Numero FROM TBANCOS_CUENTAS_BANCARIAS where Cuenta_Id = " + cuentaId.ToString();
                DTData = db.GetSQL(SSQL);
                if (DTData.Rows.Count > 0) numero1 = db.GetAsInt("Numero", DTData.Rows[0]);
                resultado = numero1;

                //Buscamos el numero mas alto en las transacciones
                SSQL = "SELECT IsNull(Max(Numero), 0) + 1 as Numero FROM TBANCOS_TRANS ";
                SSQL += " WHERE Cuenta_Id = " + cuentaId.ToString();
                SSQL += "       And Tipo in ('CK', 'CHK') ";
                SSQL += "       And Empresa_Id = " + empresaId;
                DTData = db.GetSQL(SSQL);
                if(DTData.Rows.Count > 0) numero2 = db.GetAsInt("Numero", DTData.Rows[0]);
                if (numero2 > numero1) resultado = numero2;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }


        private void pr_PrintPageCheque(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics gfx = e.Graphics;

            gfx.PageUnit = GraphicsUnit.Millimeter;
            gfx = e.Graphics;

            //Imprimimos la Fecha
            gfx.DrawString(dia, printFont, myBrush, diasPosX, fechaPosY, new StringFormat());
            gfx.DrawString(mes, printFont, myBrush, mesPosX, fechaPosY, new StringFormat());
            gfx.DrawString(anio, printFont, myBrush, anioPosX, fechaPosY, new StringFormat());

            //Imprimimos el beneficiario
            if ((nombreMaxCar > 0) && (beneficiario.Length > nombreMaxCar)) beneficiario = beneficiario.Substring(0, nombreMaxCar);
            gfx.DrawString(beneficiario, printFont, myBrush, nombrePosX, nombrePosY, new StringFormat());

            //Imprimimos el Monto Numerico
            gfx.DrawString(monto.ToString("N2"), printFont, myBrush, montoPosX, montoPosY, new StringFormat());

            //Imprimimos Monto en Letra
            if ((MontoLetraMaxCar > 0) && (montoLetra.Length > MontoLetraMaxCar)) montoLetra.Substring(0, MontoLetraMaxCar);
            gfx.DrawString(montoLetra, printFont, myBrush, montoLetraPosX, montoPosY, new StringFormat());

            //Imprimimos la Coletilla del cheque concepto y numero
            gfx.DrawString("NUMERO: " + numeroCheque.ToString().PadLeft(8, '0'), printFont, myBrush, coletillaPosX, coletillaPosY, new StringFormat());

            if (concepto.Trim() != "") gfx.DrawString(concepto, printFont, myBrush, coletillaPosX, coletillaPosY + 5, new StringFormat());


        }

    }
}
