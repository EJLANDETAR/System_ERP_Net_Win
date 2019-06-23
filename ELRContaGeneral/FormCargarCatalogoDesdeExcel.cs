using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormCargarCatalogoDesdeExcel : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormCargarCatalogoDesdeExcel()
        {
            InitializeComponent();
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "";
            string cuentaContable = "", descripcion = "", valor = "";
            int oficinaId = 0, I = 2, conteo = 0;
            double saldo = 0, diferencia = 0;
            OfficeDriver.ExcelDriver excel = new OfficeDriver.ExcelDriver();
            bool resultado = true;
            
            try
            {
                btnGrabar.Enabled = false;

                if (temporalID.Trim() == "") temporalID = objUtil.GetTemporalID();
                else objDB.LimpiarDetalleTemporal("TTEMPORAL_CONTA_CATALOGO", temporalID);

                DataGridDetalle.DataSource = null;

                if (opFD.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;

                    nombreArchivo = opFD.FileName;
                    txtNombreArchivo.Text = nombreArchivo;
                    Refresh();

                    if (cboCargarCon.Text == "MS OFFICE EXCEL") excel.isOpenOffice = false;
                    else excel.isOpenOffice = true;
                    
                    excel.OpenWorkBook(nombreArchivo);                

                    while (resultado)
                    {
                        Cursor = Cursors.WaitCursor;

                        cuentaContable = excel.GetCellValue("A" + I.ToString()).ToString();
                        descripcion    = excel.GetCellValue("B" +  I.ToString()).ToString();

                        valor          = excel.GetCellValue("C" + I.ToString()).ToString();
                        int.TryParse(valor, out oficinaId);

                        valor = excel.GetCellValue("D" + I.ToString()).ToString();
                        saldo = objUtil.ConvertirANumero(valor);               

                        if (cuentaContable.Trim() == "")
                        {
                            resultado = false;
                            break;
                        }

                        //procedemos a insertar el detalle
                        cuentaContable = cuentaContable.Replace(" ", "").Trim();
                        SetValorEncabezado("Cuenta_Contable", cuentaContable);
                        SetValorEncabezado("Empresa_Id", EMPRESA_ID);
                        SetValorEncabezado("Descripcion", descripcion);
                        SetValorEncabezado("Oficina_Id", oficinaId);
                        SetValorEncabezado("Saldo_Actual", saldo);
                        SetValorEncabezado("Adicionado_Por", nombreUsuario);
                        SetValorEncabezado("IdentificadorTemp", temporalID);

                        objDB.Insertar("TTEMPORAL_CONTA_CATALOGO", "", DSDatos.Tables[0], 0, CamposAExcluirEnc);

                        I++;
                        cuentaContable = "";
                        Cursor = Cursors.Default;
                    }

                    excel.CloseBook();
                    excel = null;
                   

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                    objDB.AddFiltroOrderBY("Cuenta_Contable");
                    DTDetalle = objDB.GetAll("TTEMPORAL_CONTA_CATALOGO", -1, objDB.Filtros);
                    DataGridDetalle.AutoGenerateColumns = false;
                    DataGridDetalle.DataSource = DTDetalle.DefaultView;
                    diferencia = GetSumDetalle("Saldo_Actual");
                    conteo = DTDetalle.Rows.Count;

                    lblDiferencia.Text = "Cantidad Registro: " +  conteo.ToString("N0") + "         Diferencia: " + diferencia.ToString("N2");

                    btnGrabar.Enabled = (DTDetalle.Rows.Count > 0 && diferencia == 0);
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
                resultado = objDB.EjecutarSP("SP_CONTA_CARGAR_CATALOGO_EXCEL", parms);
                if(resultado < 0)
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

        private void FormCargarCatalogoDesdeExcel_Load(object sender, EventArgs e)
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
