using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRActivosFijos
{
    public partial class FormActivosFijosDepreciaciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormActivosFijosDepreciaciones()
        {
            InitializeComponent();
        }

        private void FormActivosFijosDepreciaciones_Load(object sender, EventArgs e)
        {
            try
            {
                tsbBusquedaAvanzada.Visible = false;

                dtpFechaHasta2.Value = DateTime.Now.Date;
                dtpFechaDesde2.Value = DateTime.Now.Date.AddDays(-30);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            //base.GetData(opcion);
            string SSQL = "";
            DateTime fechaDesde, fechaHasta;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                fechaDesde = dtpFechaDesde2.Value.Date;
                fechaHasta = dtpFechaHasta2.Value.Date;

                SSQL = "SELECT * FROM FN_ACTIVOS_FIJOS_DEPRECIACIONES ('"
                      + objDB.DateToInt(fechaDesde).ToString() + "', '"
                      + objDB.DateToInt(fechaHasta).ToString() + "', "
                      + empresaID.ToString() + ") ";

                MyData = objDB.GetSQL(SSQL);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

                MostrarCantidadFilas();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorId = "";
            string nombreColumna = "";
            string tituloReporte = "";
            DateTime fecha;
            DataRow fila0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                nombreColumna = DataGridConsulta.Columns[e.ColumnIndex].Name.ToUpper();

                if (DataGridConsulta.RowCount > 0 && DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    valorId = DataGridConsulta[e.ColumnIndex, DataGridConsulta.CurrentRow.Index].Value.ToString().Trim();

                    if (valorId != "" && valorId != "0")
                    {
                        if (nombreColumna == "ID")
                        {
                            fila0 = MyData.Select("Id = " + valorId)[0];
                            fecha = objUtil.GetAsDate("Fecha", fila0);
                            tituloReporte = "DEPRECIACION NO. " + valorId + ", CORRESPONDIENTE A " + objUtil.GetNombreMes(fecha.Month) + " " + fecha.Year.ToString();
                            ImprimirPreviewRDLC("RptActivosFijosDepre", "VACTIVOS_FIJOS_MOVIMIENTOS", valorId, "Id", tituloReporte);
                        }
                        else if (nombreColumna == "ASIENTO_ID")
                        {
                            ImprimirPreviewRDLC("RptContaAsientoDiario", "VCONTA_DIARIO_DETALLE", valorId, "Asiento_Id");
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
    }
}
