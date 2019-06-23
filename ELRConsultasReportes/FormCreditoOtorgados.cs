using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormCreditoOtorgados : WinControl_ELR_NET.FormPlantillaIndex
    {
        int provinciaId = 0, municipioId = 0, sectorId = 0, empleadoId = 0;

        public FormCreditoOtorgados()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            double total = 0;
            double saldo = 0;
            int cantidad = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroNoIgualA("Estatus_Id", "N");
                objDB.AddFiltroNoIgualA("Estatus_Id", "R");
                objDB.AddFiltroMayorOIgualA("Fecha_Otorgado", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha_Otorgado", fechaHasta.ToString());

                if (empleadoId > 0) objDB.AddFiltroIgualA("Evaluador_Id", empleadoId.ToString());
                if (provinciaId > 0) objDB.AddFiltroIgualA("Provincia_Id", provinciaId.ToString());
                if (municipioId > 0) objDB.AddFiltroIgualA("Municipio_Id", municipioId.ToString());
                if (sectorId > 0) objDB.AddFiltroIgualA("Sector_Id", sectorId.ToString());

                MyData = objDB.GetAll("VPRESTAMOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("Monto");
                saldo = GetSum("Balance");
                cantidad = GetCount("Unico");

                lblCantidadRegistro.Text = "Cantidad Registro: " + cantidad.ToString("N0");
                lblCantidadRegistro.Text+= ",     Monto Prestado: " + total.ToString("N2");
               
                lblCantidadRegistro.Text += "     Saldo P.: " + saldo.ToString("N2");

                Cursor = Cursors.Default;
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

        private void FormCreditoOtorgados_Load(object sender, EventArgs e)
        {
            int mes, anio;
            DateTime fecha = DateTime.Now.Date;
            mes = fecha.Month;
            anio = fecha.Year;

            dtpFecha2.Value = fecha;
            dtpFecha1.Value = new DateTime(anio, mes, 1);

            GetData();
        }

        

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCreditosOtorgados");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "LISTADO DE CREDITOS OTORGADOS ENTRE EL " + objUtil.GetDateAsString(dtpFecha1.Value) + " Y EL " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";

                frm.AddParm("PROVINCIA", txtNomProvincia.Text);
                frm.AddParm("MUNICIPIO", txtNomNumicipio.Text);
                frm.AddParm("SECTOR", txtNomSector.Text);
                frm.AddParm("OFICIAL_NOMBRE", txtNombre.Text);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            DataRow myFila;
            FormConsultaPrestamosDetalle frm = new FormConsultaPrestamosDetalle();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    frm.prestamoId = myFila["Prestamo_Id"].ToString();
                    frm.nombreUsuario = nombreUsuario;

                    frm.ShowDialog();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm = null;
                myFila = null;
            }
        }

        void GetEmpleado(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", nombre = "(TODOS)";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
                empleadoId = 0;
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = " SELECT TOP 1 Empleado_Id, Nombres, Apellidos FROM TRRHH_EMPLEADOS";
                    SSQL += " WHERE Cast(Empleado_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";
                    frm.Text = "EMPLEADOS, OFICIAL DE CREDITO";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    empleadoId = objUtil.GetAsInt("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCodigoEmp.Text = empleadoId.ToString();
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnBuscarEmp) GetEmpleado();
            else if (btn == btnBuscarProvincia) GetProvincia();
            else if (btn == btnBuscarMunicipio) GetMunicipio();
            else if (btn == btnBuscarSector) GetSector();
        }

        private void txtCodigoEmp_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigoEmp.Text.Trim();
            TextBox txt = (TextBox)sender;

            codigo = txt.Text.Trim();

            if (e.KeyCode == Keys.F9)
            {
                if (txt == txtCodigoEmp) GetEmpleado();
                else if (txt == txtCodigoProvincia) GetProvincia();
                else if (txt == txtCodigoMunicipio) GetMunicipio();
                else if (txt == txtCodigoSector) GetSector();
            }
            else if (e.KeyCode == Keys.Enter && codigo != "")
            {
                if (txt == txtCodigoEmp) GetEmpleado(codigo);
                else if (txt == txtCodigoProvincia) GetProvincia(codigo);
                else if (txt == txtCodigoMunicipio) GetMunicipio(codigo);
                else if (txt == txtCodigoSector) GetSector(codigo);
            }
        }

        void GetProvincia(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", nombre = "(TODOS)";
            ELRMaestros.FormProvincias frm = new ELRMaestros.FormProvincias();

            try
            {
                provinciaId = 0;
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = " SELECT TOP 1 Provincia_Id, Nombre FROM TZONAS_PROVINCIAS";
                    SSQL += " WHERE Cast(Provincia_Id as Varchar) = '" + codigo + "'";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    provinciaId = objUtil.GetAsInt("Provincia_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre", fila0);
                }

                txtCodigoProvincia.Text = provinciaId.ToString();
                txtNomProvincia.Text = nombre;
                toolTip1.SetToolTip(txtNomProvincia, nombre);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetMunicipio(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", nombre = "(TODOS)";
            ELRMaestros.FormMunicipios frm = new ELRMaestros.FormMunicipios();

            try
            {
                municipioId = 0;
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = " SELECT TOP 1 Municipio_Id, Nombre FROM TZONAS_MUNICIPIOS";
                    SSQL += " WHERE Cast(Municipio_Id as Varchar) = '" + codigo + "'";

                    if (provinciaId > 0) SSQL += " And Provincia_Id = " + provinciaId.ToString();

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";

                    if (provinciaId > 0) frm.FiltroEstatico = " Provincia_Id = " + provinciaId.ToString();


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    municipioId = objUtil.GetAsInt("Municipio_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre", fila0);
                }

                txtCodigoMunicipio.Text = municipioId.ToString();
                txtNomNumicipio.Text = nombre;
                toolTip1.SetToolTip(txtNomNumicipio, nombre);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetSector(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", nombre = "(TODOS)";
            ELRMaestros.FormSectores frm = new ELRMaestros.FormSectores();

            try
            {
                sectorId = 0;
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = " SELECT TOP 1 Sector_Id, Nombre FROM TZONAS_SECTORES";
                    SSQL += " WHERE Cast(Sector_Id as Varchar) = '" + codigo + "'";

                    if (municipioId > 0) SSQL += " And Municipio_Id = " + municipioId.ToString();

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";

                    if (municipioId > 0) frm.FiltroEstatico = " Municipio_Id = " + municipioId.ToString();


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    sectorId = objUtil.GetAsInt("Sector_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre", fila0);
                }

                txtCodigoSector.Text = sectorId.ToString();
                txtNomSector.Text = nombre;
                toolTip1.SetToolTip(txtNomSector, nombre);


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

    }
}
