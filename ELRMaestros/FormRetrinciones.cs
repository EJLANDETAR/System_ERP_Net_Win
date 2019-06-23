using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRMaestros
{
    public partial class FormRetrinciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormRetrinciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string valor = "";
            int index = 0;

            try
            {
                txtValor.Text = "";

                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valor = DataGridConsulta["valor", index].Value.ToString();

                txtValor.Text = valor;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
