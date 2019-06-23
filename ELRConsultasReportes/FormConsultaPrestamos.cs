using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsultaPrestamos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaPrestamos()
        {
            InitializeComponent();
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void FormConsultaPrestamos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnImprimirHistorial_Click(object sender, EventArgs e)
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DataRow fila0;
            string valorUnico = "0";
            string prestamosId = "0", nombre = "", cedulaRNC = "0";
            DataTable DTData = null, DTDetalleCobrado = null;
            Button btn;

            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count == 0) return;
                if (DataGridConsulta.RowCount <= 0) return;
                btn = (Button)sender;

                valorUnico = DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                prestamosId = objUtil.GetAsString("Prestamo_Id", fila0);
                nombre = objUtil.GetAsString("ANombre", fila0);
                cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);

                //Buscamos el Detalle Cobrado
                if (btn == btnImprimirHistorial)
                {
                    pathReporte = objUtil.GetPathReportRDLC("RptCreditoHistorialCobro");

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Prestamo_Id", prestamosId);
                    objDB.AddFiltroIgualA("EsNulo", "0");
                    DTDetalleCobrado = objDB.GetAll("TPRESTAMOS_DETALLE_COBRADO", -1, objDB.Filtros);

                    frm.AddParm("PRESTAMO_ID", prestamosId);
                    frm.AddParm("NOMBRE_CLIENTE", nombre);
                    frm.AddParm("CEDULA_RNC", cedulaRNC);

                    frm.DTData = DTDetalleCobrado;
                }
                else if(btn == btnImprimirCredito)
                {
                    pathReporte = objUtil.GetPathReportRDLC("RptCredito");

                    DTData = objDB.GetById("VPRESTAMOS", prestamosId, "Prestamo_Id");

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Prestamo_Id", prestamosId);
                    objDB.AddFiltroIgualA("EsNulo", "0");
                    DTDetalleCobrado = objDB.GetAll("TPRESTAMOS_DETALLE", -1, objDB.Filtros);

                    frm.AddParm("PRESTAMO_ID", prestamosId);

                    frm.AddDS("DSData", DTData);
                    frm.AddDS("DSDetalle", DTDetalleCobrado);
                }

                frm.pathReporte = pathReporte;

                
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = Text;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                DTData = null;
                DTDetalleCobrado = null;
                frm.Dispose();
            }
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            string creditoNo = "0";
            try
            {
                if(MyData != null)
                {
                    if(MyData.Rows.Count > 0)creditoNo = dtgData["Prestamo_Id", dtgData.CurrentRow.Index].Value.ToString();
                    
                }

                creditoNo = "CREDITO NO.: " + creditoNo.PadLeft(7, '0');

                toolTip1.SetToolTip(btnImprimirCredito, creditoNo);
                toolTip1.SetToolTip(btnImprimirHistorial, creditoNo);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
