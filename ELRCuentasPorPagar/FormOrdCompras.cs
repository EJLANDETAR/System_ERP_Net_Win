using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormOrdCompras : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormOrdCompras()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                if (dataGridView1.RowCount > 0) concepto = dataGridView1["Concepto", dataGridView1.CurrentRow.Index].Value.ToString();

                txtConcepto.Text = concepto;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            try
            {
                if(dataGridView1.RowCount  > 0)
                {
                    index = dataGridView1.CurrentRow.Index;
                    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                    {
                        if (!esBusqueda) Modificar();
                        else SelectFila();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormOrdCompras_Load(object sender, EventArgs e)
        {
            try
            {
                objDB.GetFechasOficina();
                dtpFecha1.Value = objUtil.getPrimeraFechaMes(objDB.FECHA_TRABAJO);
                dtpFecha2.Value = objDB.FECHA_TRABAJO;
                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void RealizarBusquedaSencilla()
        {
            //base.RealizarBusquedaSencilla();
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (txtABuscar.Text.Trim() != "") objDB.AddFiltroContengaA("Nombre", txtABuscar.Text.Trim());

                GetData();
                pnOpcionesBusqueda.Visible = false;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            double total = 0;
            try
            {

                base.GetData(opcion);
                total = GetSum("Total");

                lblTotal.Text = "Total: " + total.ToString("N2") + " ";
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

    }
}
