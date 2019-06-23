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
    public partial class FormCreditoConCuotasVencidas : WinControl_ELR_NET.FormPlantillaIndex
    {
        int fecha = 0;
        int provinciaId = 0, municipioId = 0, sectorId = 0;
        public FormCreditoConCuotasVencidas()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {

            double capital = 0, interes = 0, demora = 0, otros = 0;
            double saldo = 0;
            int cantidad = 0, oficialId = 0;
            string SSQL = "";
            try
            {
                Cursor = Cursors.WaitCursor;

                fecha = objUtil.DateToInt(dtpAFecha.Value);
                int.TryParse(txtCodigoEmp.Text, out oficialId);

                SSQL += " SELECT * FROM FPRESTAMOS_CUOTAS_AVENCER(";
                SSQL += " '" + fecha.ToString() + "'";
                SSQL += "," + empresaID.ToString();
                SSQL += ")";
                SSQL += " WHERE 1= 1 ";

                if (oficialId > 0) SSQL += " AND Oficial_Id = " + oficialId.ToString();
                if (provinciaId > 0) SSQL += " And Provincia_Id = " + provinciaId.ToString();
                if (municipioId > 0) SSQL += " And Municipio_Id = " + municipioId.ToString();
                if (sectorId > 0) SSQL += " And Sector_Id = " + sectorId.ToString();

                SSQL += " Order by Dias_Atrazo Desc, Prestamo_Id ";

                MyData = objDB.GetSQL(SSQL);

                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                cantidad = MyData.Rows.Count;
                capital = GetSum("Capital_VP");
                interes = GetSum("Interes_VP");
                demora = GetSum("demora_VP");
                otros = GetSum("Otros_VP");

                saldo = capital + interes + demora + otros;

                lblCantidadRegistro.Text = "Cantidad: " + cantidad.ToString();
                lblCantidadRegistro.Text += ",   Capital: " + capital.ToString("N2");
                lblCantidadRegistro.Text += "   +Interes: " + interes.ToString("N2");
                lblCantidadRegistro.Text += "   +Demora: " + demora.ToString("N2");
                lblCantidadRegistro.Text += "   +Otros: " + otros.ToString("N2");
                lblCantidadRegistro.Text += "   =Total ACobrar: " + saldo.ToString("N2");

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

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DateTime fecha = DateTime.Now.Date;
            try
            {
                fecha = dtpAFecha.Value;
                pathReporte = objUtil.GetPathReportRDLC("RptCreditoConCuotasPendientes");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = @"CREDITOS CON CUOTAS VENCIDAS Y/O A VENCER, A FECHA " + objUtil.GetDateAsString(fecha);

                frm.AddParm("OFICIAL_NOMBRE", txtNombre.Text);
                frm.AddParm("PROVINCIA", txtNomProvincia.Text);
                frm.AddParm("MUNICIPIO", txtNomNumicipio.Text);
                frm.AddParm("SECTOR", txtNomSector.Text);

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

        private void FormCreditoConCuotasVencidas_Load(object sender, EventArgs e)
        {
            dtpAFecha.Value = DateTime.Now.Date;
            GetData();
        }

        void GetEmpleado(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
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
                    id = objUtil.GetAsString("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCodigoEmp.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
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
    }
}
