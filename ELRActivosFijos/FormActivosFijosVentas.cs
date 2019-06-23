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
    public partial class FormActivosFijosVentas : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormActivosFijosVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    if (DataGridConsulta.CurrentRow != null) concepto = DataGridConsulta["Concepto", DataGridConsulta.CurrentRow.Index].Value.ToString();
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormActivosFijosVentas_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipo.SelectedIndex = 0;

                dtpFecha1.Value = DateTime.Now.Date.AddDays(-30);
                dtpFecha2.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            //base.GetData(opcion);
            int tipo = -1;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataGridConsulta.DataSource = null;

                tipo = cboTipo.SelectedIndex;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (tipo == 1) objDB.AddFiltroIgualA("Tipo", "VENTA");
                else if (tipo == 2) objDB.AddFiltroIgualA("Tipo", "RETIRO");
                else objDB.AddFiltroPersonalizado("(Tipo = 'VENTA' Or Tipo = 'RETIRO')");

                MyData = objDB.GetAll("TACTIVOS_FIJOS_MOVIMIENTOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
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
