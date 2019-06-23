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
    public partial class FormRRHHConsHistorico : WinControl_ELR_NET.FormPlantillaIndex
    {
        string cedulaRNC = "000000000";
        int empleadoId = 0;

        public FormRRHHConsHistorico()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            int index = 0;
            try
            {
                txtConcepto.Text = "";

                if (MyData == null) return;
                if (MyData.Rows.Count == 0) return;
                if (dataGridView1.RowCount == 0) return;

                index = dataGridView1.CurrentRow.Index;
                concepto = dataGridView1["Tipo", index].Value.ToString() + "; ";
                concepto += dataGridView1["Concepto", index].Value.ToString();

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormRRHHConsHistorico_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);
            cboTipo.SelectedIndex = 0;
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
                cedulaRNC = "000000000";
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Empleado_Id, Nombres, Apellidos, CedulaRNC FROM VEMPLEADOS";
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
                    frm.Text = "LISTADO DE EMPLEADOS";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);
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

        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            int tipo = 0;
            string SSQL = "";
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                tipo = cboTipo.SelectedIndex;
                int.TryParse(txtCodigoEmp.Text, out empleadoId);

                SSQL = "SELECT * FROM  FRRHH_EMPLEADOS_HISTORICOS(";
                SSQL += "'" + fechaDesde.ToString() + "'";
                SSQL += ", '" + fechaHasta.ToString() + "'";
                SSQL += ", " + empresaID.ToString();
                SSQL += ")";
                SSQL += " WHERE 1=1 ";

                if (empleadoId > 0) SSQL += " And Empleado_Id = " + empleadoId;

                if(tipo > 0)
                {
                    if (tipo == 1) SSQL += " And Tipo Like 'CAMBIO SALARIO%' ";
                    if (tipo == 2) SSQL += " And Tipo Like 'VACACI%' ";
                    if (tipo == 3) SSQL += " And Tipo Like 'BAJA%' ";
                    if (tipo == 4) SSQL += " And Tipo Like 'LICENCIA%' ";
                    if (tipo == 5) SSQL += " And Tipo Like 'LICENCIA PATER%' ";
                    if (tipo == 6) SSQL += " And Tipo Like 'LICENCIA MATER%' ";
                    if (tipo == 7) SSQL += " And Tipo Like 'PERMIS%' ";
                    if (tipo == 8) SSQL += " And (Tipo Like 'SANCION%' Or Tipo Like 'SANSION%') ";
                    if (tipo == 9) SSQL += " And Tipo Like 'OTRO%' ";

                }

                MyData = objDB.GetSQL(SSQL);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

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
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptRRHHConsHistorico");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;

                frm.AddParm("NOMBRE_EMPLEADO", txtNombre.Text);
                frm.AddParm("CEDULA_RNC", cedulaRNC);

                frm.titulo = "CONSULTA HISTORICO A EMPLEADOS, FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";

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

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
