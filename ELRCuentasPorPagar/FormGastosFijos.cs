using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormGastosFijos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormGastosFijos()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            int index = 0;
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    index = dataGridView1.CurrentRow.Index;
                    concepto += "Concepto: " + dataGridView1["Concepto", index].Value.ToString();
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;
                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Modificar();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ejecutaForm("ELRCuentasPorPagar.FormGastosFijosGenerar");
        }

        private void FormGastosFijos_Load(object sender, EventArgs e)
        {
            try
            {
                btnGenerar.Visible = false;
                btnGenerar.Visible = DTMenu.Select("Formulario_AEjecutar = 'ELRCuentasPorPagar.FormGastosFijosGenerar'").Count() > 0;
            }
            catch (Exception)
            {

                
            }
        }
    }
}
