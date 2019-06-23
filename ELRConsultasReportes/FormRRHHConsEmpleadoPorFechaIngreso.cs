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
    public partial class FormRRHHConsEmpleadoPorFechaIngreso : WinControl_ELR_NET.FormPlantillaIndex
    {
        int id = 0;

        public FormRRHHConsEmpleadoPorFechaIngreso()
        {
            InitializeComponent();
        }

        private void FormRRHHConsEmpleadoPorFechaIngreso_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
           
            DataTable DTOficinas = null;
            String SSQL = "";
            try
            {
                Cursor = Cursors.WaitCursor;

                dtpFecha2.Value = fecha;
                dtpFecha1.Value = fecha.AddMonths(-1);

                SSQL = " SELECT 0 as Oficina_Id, '(TODAS)' as Nombre ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Oficina_Id, Nombre FROM TEMPRESAS_OFICINAS ";
                SSQL += " WHERE Empresa_Id = " + empresaID.ToString();

                DTOficinas = objDB.GetSQL(SSQL);
                cboOficina2.DataSource = DTOficinas.DefaultView;
                cboOficina2.SelectedValue = 0;
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

        public override void GetData(int opcion = 0)
        {

            double totalSalario = 0;
            int fechaDesde = 0, fechaHasta = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroMayorOIgualA("Fecha_Entrada", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha_Entrada", fechaHasta.ToString());
                
                if(chkSoloEmpleadosActivos.Checked)
                {
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIsNull("Fecha_Baja");
                }

                if (cboOficina2.SelectedValue != null) id = int.Parse(cboOficina2.SelectedValue.ToString());

                if (id > 0) objDB.AddFiltroIgualA("Oficina_Id", id.ToString());

                objDB.AddFiltroOrderBY("Fecha_Entrada, Empleado_Id");

                MyData = objDB.GetAll("VEMPLEADOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                totalSalario = GetSum("Salario_Mensual");
                lblCantidadRegistro.Text = "Total Salario Mensual: " + totalSalario.ToString("N2");

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

        private void chkSoloEmpleadosActivos_CheckedChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void cboOficina2_SelectedValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptRRHHEmpleadosPorFechaIngreso");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;

                frm.titulo = "LISTADO DE EMPLEADOS POR FECHA DE INGRESO: [" + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
                frm.titulo += ", OFICINA: " + cboOficina2.Text;

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
