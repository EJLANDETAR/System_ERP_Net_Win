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
    public partial class FormConsultaVencidas : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaVencidas()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            double totalP = 0;
            try
            {
                base.GetData(opcion);

                totalP = GetSum("Total_VP");
                lblTotal.Text = totalP.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frmReporte = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                frmReporte.nombreUsuario = nombreUsuario;
                frmReporte.DTData = MyData;
                frmReporte.DTOficina = DTOficina;
                frmReporte.pathReporte = "RptCreditoConCuotasPendientes";
                frmReporte.titulo = "REPORTE DE VENCIDAS";


                frmReporte.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmReporte.Dispose();
                this.Cursor = Cursors.Default;
            }
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            string valorUnico = "0";
            string direccion = "";
            DataRow MyFila = null;
            try
            {
                if (MyData.Rows.Count > 0)
                {
                    valorUnico = dtgData["Unico", dtgData.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    direccion = objUtil.GetAsString("Direccion", MyFila);
                }

                txtDescripcion.Text = direccion;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormConsultaPrestamosDetalle frm = new FormConsultaPrestamosDetalle();
            string prestamoId = "0";
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (dtgData.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    prestamoId = dtgData["Prestamo_Id", dtgData.CurrentRow.Index].Value.ToString();
                    frm.prestamoId = prestamoId;

                    frm.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
