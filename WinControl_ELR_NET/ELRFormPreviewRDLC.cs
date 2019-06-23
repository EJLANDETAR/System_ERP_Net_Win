using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace WinControl_ELR_NET
{
    public partial class ELRFormPreviewRDLC : Form
    {

        ELRUtils objUtil = new ELRUtils();
        string logoEmpresa = "";

        public DataTable DTOficina = null;
        public DataTable DTData = null;
        public string nombreUsuario = "";
        public string pathReporte = "";
        public string titulo;
        public string montoLetras = "";
        public int oficinaId = 0;
        public int empresaId = 0;

        List<ReportesDS> MyParametrosDS = new List<ReportesDS>();
        List<MyReportParameter> otrosParms = new List<MyReportParameter>();


        public ELRFormPreviewRDLC()
        {
            InitializeComponent();
        }


        public void AddDS(string nombre, DataTable valor)
        {
            ReportesDS rds = new ReportesDS();
            try
            {
                rds.Nombre = nombre;
                rds.Valor = valor;

                if (MyParametrosDS == null) MyParametrosDS = new List<ReportesDS>();

                MyParametrosDS.Add(rds);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddParm(string nombre, string valor)
        {
            MyReportParameter parm = new MyReportParameter();
            try
            {
                parm.nombre = nombre;
                parm.valor = valor;

                if (otrosParms == null) otrosParms = new List<MyReportParameter>();

                otrosParms.Add(parm);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void MostrarReporte()
        {
            ReportDataSource DSData;
            DataRow fila;

            string NOMBRE_EMPRESA_OFICINA = "";
            string DIRECCION_OFICINA = "";
            string RNC_EMPRESA = "";
            string TELEFONOS_OFICINA = "";
            DirectoryInfo dirReport;
            int cantParametros = 0, parmIndex = 0;
            double valorRNC = 0;

            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();

            bool resultado = true;

            byte[] arrPicture;
            string logoBase64 = "";

            try
            {

                dirReport = new DirectoryInfo(Application.StartupPath + @"\reportes");

                pathReporte = pathReporte.ToUpper().Trim();
                if (!pathReporte.Contains(dirReport.ToString().ToUpper())) pathReporte = dirReport.ToString() + @"\" + pathReporte;

                //AGREGAMOS LA EXTENSION
                if (!pathReporte.Contains("RDLC")) pathReporte += ".rdlc";


                //CARGAMOS EL REPORTE LOCAL DESDE LA CARPETA REPORTES
                resultado = File.Exists(pathReporte);



                if (resultado == false) objUtil.MostrarMensajeError("El Archivo [" + pathReporte + "] No Existe");

                if (resultado)
                {

                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportPath = pathReporte;
                    reportViewer1.LocalReport.DataSources.Clear();

                    //AGREGAMOS LOS DATASET
                    if (MyParametrosDS.Count > 0)
                    {
                        foreach (ReportesDS item in MyParametrosDS)
                        {
                            DSData = new ReportDataSource();
                            DSData.Name = item.Nombre;
                            DSData.Value = item.Valor;

                            reportViewer1.LocalReport.DataSources.Add(DSData);
                        }
                    }
                    else
                    {
                        DSData = new ReportDataSource();
                        DSData.Name = "DSData";
                        DSData.Value = DTData;

                        reportViewer1.LocalReport.DataSources.Add(DSData);
                    }





                    //Buscamos los datos de la oficina
                    if (DTOficina == null) 
                    {
                        db.LimpiarFiltros();

                        if (oficinaId > 0) db.AddFiltroIgualA("Oficina_Id", oficinaId.ToString());
                        if (empresaId > 0) db.AddFiltroIgualA("Empresa_Id", empresaId.ToString());

                        DTOficina = db.GetAll("VEMPRESAS_OFICINAS", 1, db.Filtros);

                    }


                    //Vamos a Obtener los datos de la Oficina Para Pasar como Parametros
                    if (DTOficina.Rows.Count > 0)
                    {
                        fila = DTOficina.Rows[0];
                        NOMBRE_EMPRESA_OFICINA = fila["Empresa_Nombre"].ToString() + ", " + fila["Nombre"].ToString();
                        DIRECCION_OFICINA = fila["Direccion"].ToString();

                        TELEFONOS_OFICINA = fila["Telefono1"].ToString();
                        if (!(fila["Telefono2"] is DBNull))
                        {
                            if (fila["Telefono2"].ToString().Trim() != "")
                            {
                                if (TELEFONOS_OFICINA.Trim() != "") TELEFONOS_OFICINA += ", ";
                                TELEFONOS_OFICINA += fila["Telefono2"].ToString().Trim();
                            }
                        }

                        RNC_EMPRESA = fila["Empresa_RNC"].ToString();
                        valorRNC = objUtil.ConvertirANumero(RNC_EMPRESA.Replace("-", ""));
                        if (valorRNC <= 0) RNC_EMPRESA = "0";
                    }

                    //AGREGAMOS LOS PARAMETROS
                    AddParm("NOMBRE_EMPRESA_OFICINA", NOMBRE_EMPRESA_OFICINA);
                    AddParm("RNC_EMPRESA", RNC_EMPRESA);
                    AddParm("DIRECCION_OFICINA", DIRECCION_OFICINA);
                    AddParm("TELEFONOS_OFICINAS", TELEFONOS_OFICINA);
                    AddParm("TITULO", titulo);
                    AddParm("NOMBRE_USUARIO", nombreUsuario);

                    //CARGAMOS EL LOGO
                    logoEmpresa = Environment.CurrentDirectory + @"\images\logo.png";
                    arrPicture = File.ReadAllBytes(logoEmpresa);
                    logoBase64 = Convert.ToBase64String(arrPicture);
                    AddParm("LOGO_EMPRESA", logoBase64);
                   

                    if (montoLetras.Trim() != "") AddParm("MONTO_LETRAS", montoLetras.ToUpper());

                    //AGREGAMOS OTROS PARAMETROS
                    parmIndex = 0;
                    cantParametros = otrosParms.Count;
                    ReportParameter[] parametros = new ReportParameter[cantParametros];
                    foreach (MyReportParameter item in otrosParms)
                    {
                        if (parmIndex >= cantParametros) break;
                        parametros[parmIndex] = new ReportParameter(item.nombre, item.valor);
                        parmIndex++;
                    }


                    this.reportViewer1.LocalReport.SetParameters(parametros);

                    //MOSTRAMOS VISTA EN DISENO DE IMPRESION
                    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 100;

                    //POR ULTIMO UN REFRESH AL REPORTE
                    reportViewer1.RefreshReport();
                    
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void ELRFormPreviewRDLC_Load(object sender, EventArgs e)
        {
            if (titulo == null) titulo = "";

            this.Text = "REPORT PREVIEW: " + titulo.ToUpper();

            tslUsuario.Text = "USUARIO: " + nombreUsuario.Trim().ToUpper();

            MostrarReporte();

        }

        private void ELRFormPreviewRDLC_KeyDown(object sender, KeyEventArgs e)
        {
            
            //ESCAPE = SALIR
            if (e.KeyCode == Keys.Escape) Close();

            //IMPRIMIR
            if ((ModifierKeys == Keys.Control) && (e.KeyCode == Keys.P)) reportViewer1.PrintDialog();

            if ((ModifierKeys == Keys.Control) && (e.KeyCode == Keys.S)) reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[3]);
        }
    }
}
