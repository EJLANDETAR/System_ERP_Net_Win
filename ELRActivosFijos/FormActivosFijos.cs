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
    public partial class FormActivosFijos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormActivosFijos()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string descripcion = "";
            int index = 0;

            try
            {
                if(DataGridConsulta.ColumnCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    descripcion = DataGridConsulta["Descripcion", index].Value.ToString();

                    if(descripcion.Trim() == "") descripcion = DataGridConsulta["Nombre", index].Value.ToString();
                }

                txtDescripcion.Text = descripcion;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
