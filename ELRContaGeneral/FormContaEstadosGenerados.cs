using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRContaGeneral
{
    public partial class FormContaEstadosGenerados : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaEstadosGenerados()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            string valorId = "0";
            DataTable DTReportes = null;
            string pathReporte = "";
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            DataRow fila0 = null;
            bool esAnexo = false;
            string nombreReporte = "", titulo = "";
            int oficinaId = 0;

            try
            {
               if(DataGridConsulta.RowCount > 0)
                {
                    valorId = DataGridConsulta["Registro_Id", DataGridConsulta.CurrentRow.Index].Value.ToString();
                    fila0 = MyData.Select("Registro_Id = " + valorId)[0];
                    esAnexo = objUtil.GetAsBoolean("EsAnexo", fila0);
                    titulo = objUtil.GetAsString("Titulo", fila0) + " " + objUtil.GetAsString("Nombre_Mes", fila0) + " " + objUtil.GetAsString("Anio", fila0);
                    oficinaId = objUtil.GetAsInt("Oficina_Id", fila0);
                    esAnexo = false;

                    if (esAnexo) nombreReporte = "RptContaEstadosAnexos";
                    else nombreReporte = "RptContaEstadosFinancieros";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Registro_Id", valorId);
                    objDB.AddFiltroOrderBY("Unico");
                    DTReportes = objDB.GetAll("VCONTA_ESTADOS_GENERADOS_DETALLES", -1, objDB.Filtros);

                    pathReporte = objUtil.GetPathReportRDLC(nombreReporte);
                    frm.pathReporte = pathReporte;
                    frm.DTData = DTReportes;
                    frm.oficinaId = oficinaId;
                    frm.empresaId = empresaID;
                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = titulo;

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Agregar()
        {
            //base.Agregar();
            FormContaEstadosAGenerar frm = new FormContaEstadosAGenerar();
            frm.nombreUsuario = nombreUsuario;
            frm.OFICINA_ID = oficinaID;
            frm.EMPRESA_ID = empresaID;
            frm.EnEjecusion = true;

            frm.ShowDialog();
            if (frm.lOK) GetData();
        }

        public override void GetData(int opcion = 0)
        {
            int estadoId = 0;
            int fechaDesde = 0, fechaHasta = 0;
            try
            {
                if(cboEstado.SelectedValue != null)  estadoId = int.Parse( cboEstado.SelectedValue.ToString());

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                if (estadoId > 0) objDB.AddFiltroIgualA("Estado_Id", estadoId.ToString());

                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());

                base.GetData(opcion);
                DataGridConsulta.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0) Imprimir();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormContaEstadosGenerados_Load(object sender, EventArgs e)
        {
            string SSQL = "";
            DataTable DTEstados = null;
            DateTime fecha = DateTime.Now.Date;

            try
            {
                dtpFecha2.Value = fecha;
                dtpFecha1.Value = objUtil.getPrimeraFechaMes(fecha);

                SSQL = " SELECT 0 as Estado_Id, '(TODOS)' as Descripcion, Cast(0 as Bit) as EsConAnexo ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Estado_Id, Descripcion, EsConAnexo FROM TCONTA_ESTADOS ";
                SSQL += " WHERE EsActivo = 1 And Empresa_Id = " + empresaID.ToString();

                DTEstados = objDB.GetSQL(SSQL);

                cboEstado.DataSource = DTEstados;
                cboEstado.SelectedValue = 0;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnImprimirCatalogo_Click(object sender, EventArgs e)
        {
            ImprimirCatalogo();
        }

        void ImprimirCatalogo()
        {
            DataTable DTCatalogo = null;
            string pathReporte = "";
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();

            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroPersonalizado("(Saldo_Actual <> 0 Or Saldo_Mes_Anterior <> 0 Or Debito_Mes <> 0 Or Credito_Mes <> 0)");
                objDB.AddFiltroOrderBY("Cuenta_Contable, Codigo_Auxiliar");

                DTCatalogo = objDB.GetAll("VCONTA_CATALOGO", -1, objDB.Filtros);

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptContaCatalogo");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = DTCatalogo;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "Catalogo de Cuentas";
                    frmPreview.pathReporte = pathReporte.Trim();
                    frmPreview.montoLetras = montoLetras;

                    frmPreview.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmPreview.Dispose();
            }
        }
    }
}
