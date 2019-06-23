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
    public partial class FormCreditosPorDiasAtrazos : WinControl_ELR_NET.FormPlantillaIndex
    {
        int dia1 = 0, dia2 = 0;
        int empleadoId = 0;
        string nombre = "(TODOS)";

        public FormCreditosPorDiasAtrazos()
        {
            InitializeComponent();
        }

        private void FormCreditosPorDiasAtrazos_Load(object sender, EventArgs e)
        {
            txtCodigoEmp.Text = "0";
            GetData();

            txtDia1.SelectAll();
            txtDia1.Focus();
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            DataRow fila0;
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
                    fila0 = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    frm.prestamoId = fila0["Prestamo_Id"].ToString();
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
                fila0 = null;
            }
        }

        public override void GetData(int opcion = 0)
        {
            double capital, saldo = 0;
            int conteo = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                int.TryParse(txtDia1.Text, out dia1);
                int.TryParse(txtDia2.Text, out dia2);

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Dias_Atrazo", dia1.ToString());
                objDB.AddFiltroMenorOIgualA("Dias_Atrazo", dia2.ToString());
                objDB.AddFiltroMayorOIgualA("Balance", "1");

                if (empleadoId > 0) objDB.AddFiltroIgualA("Oficial_Id", empleadoId.ToString());

                objDB.AddFiltroOrderBY("Dias_Atrazo Desc, Prestamo_Id");
                MyData = objDB.GetAll("VPRESTAMOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                capital = GetSum("Capital_Pendiente");
                saldo = GetSum("Balance");
                conteo = GetCount("Unico");

                lblCantidadRegistro.Text = "Cantidad de Registro: " + conteo.ToString("N0");
                lblCantidadRegistro.Text += ",    Capital Pendiente: " + capital.ToString("N2");
                lblCantidadRegistro.Text += "     Saldo Pendiente: " + saldo.ToString("N2");


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

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void txtCodigoEmp_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigoEmp.Text.Trim();

            if (e.KeyCode == Keys.F9) GetEmpleado();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEmpleado(codigo);
        }

        void GetEmpleado(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
                empleadoId = 0;
                nombre = "(TODOS)";
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

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DateTime fecha = DateTime.Now.Date;
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCreditoConCuotasPendientes");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = @"CREDITOS DE " + dia1.ToString("N0") + " A " + dia2.ToString("N0") + " DIAS DE ATRAZO, A FECHA " + objUtil.GetDateAsString(fecha);

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

    }
}
