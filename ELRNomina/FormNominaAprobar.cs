using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormNominaAprobar : WinControl_ELR_NET.FormPlantillaIndex
    {
        int nominaId = 0;
        public FormNominaAprobar()
        {
            InitializeComponent();
        }

        public override void TotalizarData()
        {
            double DARS = 0, DAFP = 0, DARL = 0, DISR = 0;
            double EARS = 0, EAFP = 0, EARL = 0, EINFOTEP = 0;
            double totalMensual = 0, totalBruto = 0, totalDescto = 0, totalNeto = 0;
            double totalAcum = 0, totalPend = 0, total = 0;

            try
            {
                pnTotales.Visible = (cboMes.SelectedIndex < 12);
                pnTotalRegalia.Visible = (cboMes.SelectedIndex == 12);

                if (MyData != null)
                {
                    DARS = GetSum("D_ARS");
                    DAFP = GetSum("D_AFP");
                    DARL = GetSum("D_ARL");
                    DISR = GetSum("D_ISR");

                    EARS = GetSum("E_ARS");
                    EAFP = GetSum("E_AFP");
                    EARL = GetSum("E_ARL");
                    EINFOTEP = GetSum("E_INFOTEP");

                    totalMensual = GetSum("Salario");
                    totalBruto = GetSum("Monto_Bruto");
                    totalDescto = GetSum("Total_Descuento");
                    totalNeto = GetSum("Monto_APagar");

                    total = GetSum("Monto_APagar");
                    totalAcum = GetSum("Acumulado");
                    totalPend = GetSum("Pendiente");
                }

                lblDARS.Text = DARS.ToString("N2");
                lblDAFP.Text = DAFP.ToString("N2");
                lblDARL.Text = DARL.ToString("N2");
                lblDISR.Text = DISR.ToString("N2");

                lblEARS.Text = EARS.ToString("N2");
                lblEAFP.Text = EAFP.ToString("N2");
                lblEARL.Text = EARL.ToString("N2");
                lblEINFOTEP.Text = EINFOTEP.ToString("N2");

                lblSalarioMensual.Text = totalMensual.ToString("N2");
                lblSueldoBruto.Text = totalBruto.ToString("N2");
                lblDescto.Text = totalDescto.ToString("N2");
                lblNeto.Text = totalNeto.ToString("N2");

                lblTotal.Text = "Acumulado: " + totalAcum.ToString("N2") + "      ";
                lblTotal.Text += "Quincena Pendiente: " + totalPend.ToString("N2") + "            ";
                lblTotal.Text += "Total: " + total.ToString("N2");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormNominaAprobar_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            int dia = 0, mes = 0, anio = 0; ;
            string SSQL = "";
            DataTable DTMyOficinas;

            try
            {
                dia = fecha.Day;
                mes = fecha.Month;
                anio = fecha.Year;

                btnAprobar.Enabled = false;
                tsbTXT.Enabled = false;
                tsbExcel.Enabled = false;

                tsbBusquedaAvanzada.Visible = false;
                pnTotalRegalia.Visible = false;

                if (dia <= 15) npdQuincenaNo.Value = 1;
                else npdQuincenaNo.Value = 2;

                txtAnio.Text = anio.ToString();
                cboMes.SelectedIndex = mes - 1;

                //Buscamos las oficinas
                SSQL = "SELECT 0 Oficina_Id, '(TODAS)' as Nombre";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Oficina_Id, Nombre FROM TEMPRESAS_OFICINAS WHERE EsActivo = 1 ";
                SSQL += "  And Empresa_Id = " + empresaID.ToString();
                DTMyOficinas = objDB.GetSQL(SSQL);
                cboOficinas2.DataSource = DTMyOficinas.DefaultView;
                cboOficinas2.SelectedValue = 0;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {

            string estatus = "";
            int oficinaId = 0, anio = 0, mes = 0, dia = 0;
            DataRow fila0;
            string estatusId = "";

            try
            {
                Cursor = Cursors.WaitCursor;

                tsProgressBar.Visible = false;
                btnAprobar.Enabled = false;
                tsbTXT.Enabled = false;
                tsbExcel.Enabled = false;
                lblEstatus.ForeColor = Color.Black;
                lblNominaId.ForeColor = Color.Black;

                if (cboOficinas2.SelectedValue != null) oficinaId = int.Parse(cboOficinas2.SelectedValue.ToString());

                dia = (int)npdQuincenaNo.Value;
                mes = (cboMes.SelectedIndex + 1);
                int.TryParse(txtAnio.Text, out anio);

                nominaId = (anio * 10000) + (mes * 100) + dia;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("Nomina_Id", nominaId.ToString());
                if (oficinaId > 0) objDB.AddFiltroIgualA("Oficina_Id", oficinaId.ToString());

                MyData = objDB.GetAll("VNOMINAS_DETALLE", -1, objDB.Filtros);
                MostrarCantidadFilas();
                dtgNominaDetalle.AutoGenerateColumns = false;
                dtgNominaDetalle.DataSource = MyData.DefaultView;

                //Ocultamos algunas columnas
                dtgNominaDetalle.Columns["Acumulado"].Visible = (cboMes.SelectedIndex == 12);
                dtgNominaDetalle.Columns["Pendiente"].Visible = (cboMes.SelectedIndex == 12);
                dtgNominaDetalle.Columns["Monto_Bruto"].Visible = (cboMes.SelectedIndex < 12);
                dtgNominaDetalle.Columns["Descuento"].Visible = (cboMes.SelectedIndex < 12);
                dtgNominaDetalle.Columns["btnVerDetalle"].Visible = (cboMes.SelectedIndex < 12);


                //Totalizamos la Data
                TotalizarData();

                if (MyData.Rows.Count > 0)
                {
                    fila0 = MyData.Rows[0];
                    estatusId = objUtil.GetAsString("Estatus_Id", fila0).ToUpper();

                    btnAprobar.Enabled = (estatusId != "A");
                    tsbExcel.Enabled = (estatusId == "A");
                    tsbTXT.Enabled = (estatusId == "A");

                    if (estatusId == "A")
                    {
                        estatus = "APROBADA";
                        lblNominaId.ForeColor = Color.Green;
                        lblEstatus.ForeColor = Color.Green;
                    }
                    else estatus = "PENDEINTE";
                }
                else estatus = "NO GENERADA";


                lblNominaId.Text = "Nomina Id: " + nominaId.ToString().PadLeft(6, '0');
                lblEstatus.Text = "Estatus: " + estatus;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dtgNominaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int index = 0;
            DataRow fila0;

            FormNominaVerDetalle frm = new FormNominaVerDetalle();

            try
            {
                if (dtgNominaDetalle.RowCount > 0)
                {
                    index = dtgNominaDetalle.CurrentRow.Index;
                    valorUnico = dtgNominaDetalle["Unico", index].Value.ToString();

                    if (dtgNominaDetalle.Columns[e.ColumnIndex] is DataGridViewLinkColumn || dtgNominaDetalle.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        frm.fila0 = fila0;

                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            Aprobar();
        }

        public override void Aprobar()
        {
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            string temporalId = "";

            try
            {
                if (dtgNominaDetalle.RowCount > 0 && nominaId > 0)
                {
                    resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Aprobar esta Nomina?");
                    if (resp == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("nominaId", nominaId));
                        parms.Add(new DataDB_ELR_NET.Parametro("empresaId", empresaID));
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_NOMINA_APROBAR", parms);
                        if (spReturn < 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            lblEstatus.Text = "Estatus: APROBADA";
                            objUtil.MostrarMensajeInformacion("Nomina Aprobada de Forma Satisfactoria...");

                            tsbExcel.Enabled = true;
                            tsbTXT.Enabled = true;
                            lblNominaId.ForeColor = Color.Green;
                            lblEstatus.ForeColor = Color.Green;

                            Imprimir();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public override void GenerarEXCEL(string titulo = "")
        {
            string pathFile = "", cuentaBancoEmpresa = "";
            string id = "", empleadoId, cedulaRNC, nombre, cuentaBancoEmpleado = "", formaPago = "E";
            double sueldoNeto = 0;
            int I = 2;
            string formula = "";
            
            OfficeDriver.ExcelDriver objExcel = new OfficeDriver.ExcelDriver();
            DataTable DTCuenta = null, DTEmpleado = null;

            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                Cursor = Cursors.WaitCursor;

                objExcel.isOpenOffice = objUtil.IsOpenOfficeIntalled();

                if (objExcel.isOpenOffice == false && objUtil.IsMSExcelIntalled() == false) throw new Exception("MS EXCEL U OPEN OFFICE CAL NO INSTALLED");


                //Buscamos la Cuenta Bancaria Para Pago de Nomina o Transferencia Bancaria
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("EsActivo", "1");
                objDB.AddFiltroIgualA("EsNomina", "1");
                DTCuenta = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", 1, objDB.Filtros);
                if (DTCuenta.Rows.Count > 0) cuentaBancoEmpresa = objUtil.GetAsString("Codigo_Completo", DTCuenta.Rows[0]);

                if (cuentaBancoEmpresa.Trim() == "")
                {
                    Cursor = Cursors.Default;
                    objUtil.MostrarMensajeError("No se ha Definido Cuenta Bancaria Empresa Para el Pago de Nomina");
                    return;
                }


                //Establecemos el Id de la Nomina
                id = "Nomina_" + nominaId.ToString() + "_" + empresaID.ToString();

                pathFile = GetFolderDocGenerados("Nomina") + @"\" + id + ".xls";
                if (File.Exists(pathFile)) File.Delete(pathFile);

                //objExcel.create(pathFile, true);
                objExcel.OpenWorkBook("");
                objExcel.SetCellValue("A1", "RNC");
                objExcel.SetCellValue("B1", "CUENTA ORIGEN");
                objExcel.SetCellValue("C1", "CUENTA DESTINO");
                objExcel.SetCellValue("D1", "MONTO A PAGAR");
                objExcel.SetCellValue("E1", "REGISTRO ID");
                objExcel.SetCellValue("F1", "NOMBRE");
                objExcel.SetCellValue("G1", "FORMA PAGO");


                formula = "Sum(D2:D";

                foreach (DataRow item in MyData.Rows)
                {
                    this.Cursor = Cursors.WaitCursor;

                    empleadoId = objUtil.GetAsString("Empleado_Id", item, "0");
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", item);
                    nombre = objUtil.GetAsString("Nombre", item);
                    sueldoNeto = objUtil.GetAsDouble("Monto_APagar", item, 0);
                    cuentaBancoEmpleado = objUtil.GetAsString("Cuenta_Banco_Destino", item, "");
                    formaPago = objUtil.GetAsString("Forma_Pago", item, "CHK");

                    if (cuentaBancoEmpleado.Trim() == "")
                    {
                        //Buscamos la Cuenta de Banco de Dicho Empleado
                        DTEmpleado = objDB.GetById("TRRHH_EMPLEADOS", empleadoId, "Empleado_Id");
                        if (DTEmpleado.Rows.Count > 0) cuentaBancoEmpleado = objUtil.GetAsString("Cuenta_Banco_No", DTEmpleado.Rows[0]);
                    }

                    objExcel.SetCellValue("A" + I.ToString(), EMPRESA_RNC);
                    objExcel.SetCellValue("B" + I.ToString(), cuentaBancoEmpresa);
                    objExcel.SetCellValue("C" + I.ToString(), cuentaBancoEmpleado);
                    objExcel.SetCellValue("D" + I.ToString(), sueldoNeto);
                    objExcel.SetCellValue("E" + I.ToString(), I - 1);
                    objExcel.SetCellValue("F" + I.ToString(), nombre);
                    objExcel.SetCellValue("G" + I.ToString(), formaPago);


                    I++;
                    this.Cursor = Cursors.Default;
                }
                formula += (I - 1).ToString() + ")";

                
                objExcel.SetCellFormula("D" + I.ToString(), formula);
                objExcel.Autofit();
                objExcel.SaveAS(pathFile);
                objExcel.ShowBook();

                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                //objExcel.CloseBook();
            }
        }

        public override void GenerarTXT()
        {
            string pathFile = "", cuentaBancoEmpresa = "";
            string empleadoId, cedulaRNC, nombre, cuentaBancoEmpleado = "", formaPago = "E";
            string detalle = "";
            double sueldoNeto = 0;
            DataRow fila0;
            int registroId = 1;
            DataTable DTCuenta = null;

            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                Cursor = Cursors.WaitCursor;

                //Buscamos la Cuenta Bancaria Para Pago de Nomina o Transferencia Bancaria
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("EsActivo", "1");
                objDB.AddFiltroIgualA("EsNomina", "1");
                DTCuenta = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", 1, objDB.Filtros);
                if (DTCuenta.Rows.Count > 0) cuentaBancoEmpresa = objUtil.GetAsString("Codigo_Completo", DTCuenta.Rows[0]);

                if (cuentaBancoEmpresa.Trim() == "")
                {
                    Cursor = Cursors.Default;
                    objUtil.MostrarMensajeError("No se ha Definido Cuenta Bancaria Empresa Para el Pago de Nomina");
                    return;
                }

                pathFile = GetFolderDocGenerados("Nomina");

                fila0 = MyData.Rows[0];

                pathFile += @"\Nomina_" + nominaId.ToString() + ".txt";

                tsProgressBar.Visible = true;
                tsProgressBar.Value = 0;
                tsProgressBar.Maximum = MyData.Rows.Count;
                tsProgressBar.Width = 350;
                tsProgressBar.Step = 1;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(pathFile);

                foreach (DataRow item in MyData.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    detalle = "";
                    empleadoId = objUtil.GetAsString("Empleado_Id", item, "0");
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", item);
                    nombre = objUtil.GetAsString("Nombre", item);
                    sueldoNeto = objUtil.GetAsDouble("Monto_APagar", item, 0);
                    cuentaBancoEmpleado = objUtil.GetAsString("Cuenta_Banco_Destino", item, "");
                    formaPago = objUtil.GetAsString("Forma_Pago", item, "CHK");

                    if (formaPago == "E")
                    {
                        detalle = EMPRESA_RNC + "," + cuentaBancoEmpresa + "," + cuentaBancoEmpleado + "," + sueldoNeto.ToString("N2").Replace(",", "");
                        detalle += "," + registroId.ToString() + "," + nombre.ToUpper().Replace('Ñ', 'N');
                        sw.WriteLine(detalle);

                        registroId++;
                    }

                    tsProgressBar.PerformStep();
                    Cursor = Cursors.Default;
                }

                Cursor = Cursors.Default;
                sw.Close();
                objUtil.MostrarMensajeInformacion(pathFile.ToUpper(), "ARCHIVO GENERADO");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptRRHHNominaDetalle");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;

                frm.AddParm("NOMINA_ID", nominaId.ToString());
                frm.AddParm("OFICINA_NOMINA", cboOficinas2.Text);

                frm.titulo = "NOMINA";

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

        private void cboOficinas2_SelectedValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            npdQuincenaNo.Enabled = (cboMes.SelectedIndex < 12);
            if (cboMes.SelectedIndex == 12) npdQuincenaNo.Value = 1;

        }
    }
}
