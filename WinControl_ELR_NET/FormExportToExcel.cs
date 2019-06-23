using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormExportToExcel : Form
    {

        public DataTable DTData = null;
        public List<MyColumna> colList = new List<MyColumna>();
        public string nombreArchivo = "";
        public string titulo = "";
        public string subTitulo1 = "";
        public string subTitulo2 = "";

        bool esInicio = true;
        ELRUtils util = new ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        OfficeDriver.ExcelDriver excel = new OfficeDriver.ExcelDriver();
        OfficeDriver.Format format = new OfficeDriver.Format();
        int fila = 1, col = 1, filaIni = 0;
        DataRow DRItem = null;

        public FormExportToExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        void escribirTitulos()
        {
            int conteo = 1;
            try
            {
                //Insertamos los titulos
                format.bold = true;
                format.size = 12;
                format.backGroundColor = Color.Transparent;

                if (titulo.Trim() != "")
                {
                    excel.SetCellValue(conteo, 1, titulo.Trim(), "@");
                    excel.SetCellFormat(conteo, 1, format);
                    excel.Merge(1, colList.Count, conteo);
                    conteo++;
                }

                if (subTitulo1.Trim() != "")
                {
                    excel.SetCellValue(conteo, 1, subTitulo1.Trim(), "@");
                    excel.SetCellFormat(conteo, 1, format);
                    excel.Merge(1, colList.Count, conteo);
                    conteo++;
                }

                if (subTitulo2.Trim() != "")
                {
                    excel.SetCellValue(conteo, 1, subTitulo2.Trim(), "@");
                    excel.SetCellFormat(conteo, 1, format);
                    excel.Merge(1, colList.Count, conteo);
                    conteo++;
                }

               
            }
            catch (Exception)
            {

                throw;
            }
        }

        void escribirColumnas()
        {
            string nombre = "", header = "";
            
            try
            {
                format.bold = true;
                format.size = 12;
                format.backGroundColor = Color.Silver;

                if (colList.Count <= 0)
                {
                    foreach (DataColumn item in DTData.Columns)
                    {
                        nombre = item.ColumnName;
                        header = nombre.Replace("_", " ");
                        colList.Add(new MyColumna(header, nombre));
                    }
                }

                //Insertamos las columnas
                col = 1; fila = 1;

                if (titulo.Trim() != "") fila++;
                if (subTitulo1.Trim() != "") fila++;
                if (subTitulo2.Trim() != "") fila++;
                if (fila > 1) fila++;

                foreach (MyColumna item in colList)
                {
                    excel.SetCellValue(fila, col, item.HeaderText);
                    excel.SetCellFormat(fila, col, format);
                    col++;
                }

                fila++;
                filaIni = fila;
                format.backGroundColor = Color.White;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormExportToExcel_Activated(object sender, EventArgs e)
        {
            if(esInicio)
            {
                esInicio = false;
                generarExcel();
            }
        }

        void addFunctionSum()
        {
            DataColumn DCol = null;
            try
            {
                col = 1;
                format.bold = true;
                format.size = 12;
                format.backGroundColor = Color.Transparent;

                foreach (MyColumna myCol in colList)
                {
                    if (DRItem.Table.Columns.Contains(myCol.NombreCampo))
                    {
                        DCol = DRItem.Table.Columns[myCol.NombreCampo.Trim()];
                        if (DCol.DataType == typeof(decimal) || DCol.DataType == typeof(double))
                        {
                            excel.SetCellFunction("Sum", col, filaIni, fila - 1);
                            excel.SetCellFormat(fila, col, format);
                        }
                    }
                   

                    col++;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormExportToExcel_Load(object sender, EventArgs e)
        {
            if (titulo.Trim() == "")
            {
                titulo = "Escriba titulo aqui";
                subTitulo1 = "Escriba sub titulo aqui";
            }
            
        }

        void generarExcel()
        {
            int conteo = 0;
            double porc = 0;
            object valor = null;
            string numberFormat = "";
            try
            {
                //Validamos excel u openoffice deben estar instalado
                if(util.IsMSExcelIntalled() == false && util.IsOpenOfficeIntalled() == false)
                {
                    throw new Exception("USTED NO TIENE EXCEL U OPEN OFFICE INSTALADO");
                }


               if(util.IsMSExcelIntalled())
                {
                    excel.isOpenOffice = false;
                    Text = "EXPORT TO MS EXCEL";
                }
                else 
                {
                    excel.isOpenOffice = true;
                    Text = "EXPORT TO OPEN OFFICE CALC";
                }
                
                Cursor = Cursors.WaitCursor;
                conteo = DTData.Rows.Count;
                if (titulo.Trim() != "") conteo += 2;
                if (subTitulo1.Trim() != "") conteo++;
                if (subTitulo2.Trim() != "") conteo++;
               
                if (conteo > 0) porc = (fila / conteo) * 100;
                lblPorcentaje.Text = "0/" + conteo.ToString() + " (0%)";

                //En la primera fila se escribe las columnas

                progressBar1.Minimum = 0;
                progressBar1.Maximum = conteo;
                progressBar1.Step = 1;

                //Abrimos el archivo de excel
                Cursor = Cursors.WaitCursor;
                excel.OpenWorkBook("");

                //Pasamos las columnas en el encabezado
                escribirColumnas();

                

                format.bold = false;
                format.size = 12;
                format.backGroundColor = Color.Transparent;
                foreach (DataRow item in DTData.Rows)
                {
                    Cursor = Cursors.WaitCursor;
                    col = 1;
                    //Debemos hacer un bucle por cada columna
                    foreach (MyColumna myCol in colList)
                    {
                        numberFormat = "";
                        valor = db.GetValue(myCol.NombreCampo, item);
                        if (db.isString) numberFormat = "@";
                        excel.SetCellValue(fila, col, valor, numberFormat);
                        excel.SetCellFormat(fila, col, format);
                        col++;
                    }

                    //Mostramos el procentaje
                    Cursor = Cursors.Default;
                    progressBar1.PerformStep();
                    porc = ( (fila - 1) / (double)conteo) * 100;
                    lblPorcentaje.Text = (fila - 1).ToString() + "/" + conteo.ToString() + " (" + porc.ToString("N2") + "%)";
                    fila++;
                    col = 1;
                    DRItem = item;
                }

                //Agregamos funcion para sumar
                if (fila > 2) addFunctionSum();

                //Agregamos los titulos;
                escribirTitulos();

                //Ajustar tamano de las columnas
                excel.Autofit(colList.Count);

               

                //Mostramos el archivo generado
                excel.ShowBook();
                Close();
            }
            catch (Exception ex)
            {
                excel.CloseBook();
                Cursor = Cursors.Default;
                util.MostrarMensajeError(ex.Message);
                Close();
            }

        }
    }
}
