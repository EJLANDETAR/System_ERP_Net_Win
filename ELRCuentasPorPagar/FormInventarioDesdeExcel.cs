using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormInventarioDesdeExcel : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormInventarioDesdeExcel()
        {
            InitializeComponent();
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "";
            string nombre = "", codigo = "", valor = "", marca = "", categoria = "";
            double cantidad = 0, costo = 0, precioRegular = 0, precioMinimo = 0, tasaItbis = 0;
            int I = 2, conteo = 0;
            OfficeDriver.ExcelDriver excel = new OfficeDriver.ExcelDriver();
            bool resultado = true, esInventario = false;

            try
            {
                btnGrabar.Enabled = false;

                if (temporalID.Trim() == "") temporalID = objUtil.GetTemporalID();
                else objDB.LimpiarDetalleTemporal("TTEMPORAL_CLASIFICADOR_PRODUCTOS", temporalID);

                DataGridDetalle.DataSource = null;

                if (opFD.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;

                    nombreArchivo = opFD.FileName;
                    txtNombreArchivo.Text = nombreArchivo;

                    if (cboCargarCon.Text == "MS OFFICE EXCEL") excel.isOpenOffice = false;
                    else excel.isOpenOffice = true;

                    excel.OpenWorkBook(nombreArchivo);

                    while (resultado)
                    {
                        Cursor = Cursors.WaitCursor;

                        nombre = excel.GetCellValue("A" + I.ToString()).ToString();
                        codigo = excel.GetCellValue("B" + I.ToString()).ToString();
                        marca = excel.GetCellValue("C" + I.ToString()).ToString();
                        categoria = excel.GetCellValue("D" + I.ToString()).ToString();

                        valor = excel.GetCellValue("E" + I.ToString()).ToString();
                        cantidad = objUtil.ConvertirANumero(valor);

                        valor = excel.GetCellValue("F" + I.ToString()).ToString();
                        costo = objUtil.ConvertirANumero(valor);

                        valor = excel.GetCellValue("G" + I.ToString()).ToString();
                        precioRegular = objUtil.ConvertirANumero(valor);

                        valor = excel.GetCellValue("H" + I.ToString()).ToString();
                        precioMinimo = objUtil.ConvertirANumero(valor);

                        valor = excel.GetCellValue("I" + I.ToString()).ToString().ToUpper();
                        if (valor == "1" || valor == "SI" || valor == "S" || valor == "YES" || valor == "Y") esInventario = false;
                        else esInventario = true;

                        valor = excel.GetCellValue("J" + I.ToString()).ToString().ToUpper();
                        tasaItbis = objUtil.ConvertirANumero(valor);


                        if (nombre.Trim() == "")
                        {
                            resultado = false;
                            break;
                        }

                        //procedemos a insertar el detalle
                        if (marca.Trim() == "") marca = "NO MARCA";
                        if (categoria.Trim() == "") categoria = "NO CATEGORIA";

                        codigo = codigo.Replace(" ", "").Trim();
                        SetValorEncabezado("Nombre_Corto", nombre);
                        SetValorEncabezado("Descripcion", nombre);
                        SetValorEncabezado("Codigo_Barra", codigo);
                        SetValorEncabezado("Marca", marca);
                        SetValorEncabezado("Categoria", categoria);
                        SetValorEncabezado("Costo_Ultima_Compra", costo);
                        SetValorEncabezado("EnExistencia", cantidad);
                        SetValorEncabezado("Precio_Minimo", precioMinimo);
                        SetValorEncabezado("Precio_Regular", precioRegular);
                        SetValorEncabezado("EsInventario", esInventario);
                        SetValorEncabezado("Tasa_Itbis", tasaItbis);

                        objDB.Insertar("TTEMPORAL_CLASIFICADOR_PRODUCTOS", "", DSDatos.Tables[0], 0, CamposAExcluirEnc);

                        I++;
                        nombre = "";
                        Cursor = Cursors.Default;
                    }

                    excel.CloseBook();

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                    objDB.AddFiltroOrderBY("Unico");
                    DTDetalle = objDB.GetAll("TTEMPORAL_CLASIFICADOR_PRODUCTOS", -1, objDB.Filtros);
                    DataGridDetalle.AutoGenerateColumns = false;
                    DataGridDetalle.DataSource = DTDetalle.DefaultView;
                    conteo = DTDetalle.Rows.Count;

                    btnGrabar.Enabled = (DTDetalle.Rows.Count > 0);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                excel = null;
            }
        }

        public override bool GetData()
        {
            btnGrabar.Enabled = false;
            return base.GetData();
        }

        public override int GrabarDatos()
        {
            int resultado = 0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                resp = objUtil.MostrarMensajePregunta("Esta Seguro de Realizar Este Proceso?");
                if (resp == DialogResult.No) return -1;

                Cursor = Cursors.WaitCursor;

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                objDB.iniciarTransaccion();
                resultado = objDB.EjecutarSP("SP_INVENTARIO_CARGAR_EXCEL", parms);
                if (resultado < 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    objUtil.MostrarMensajeInformacion("Proceso Realizado de Forma Satisfactoria...");
                    Close();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                objDB.cancelarTransaccion();
            }

            return resultado;
        }

        private void FormInventarioDesdeExcel_Load(object sender, EventArgs e)
        {
            try
            {
                if (objUtil.IsOpenOfficeIntalled()) cboCargarCon.Items.Add("OPEN OFFICE");
                if (objUtil.IsMSExcelIntalled()) cboCargarCon.Items.Add("MS OFFICE EXCEL");

                if (cboCargarCon.Items.Count > 0) cboCargarCon.SelectedIndex = 0;
                btnBuscarArchivo.Enabled = (cboCargarCon.Items.Count > 0);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
