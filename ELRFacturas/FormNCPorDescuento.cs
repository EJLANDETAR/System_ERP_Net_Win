using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormNCPorDescuento : WinControl_ELR_NET.FormPlantillaIndex
    {
        public int tipo = -1;

        public FormNCPorDescuento()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {

            base.GetData(opcion);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Modificar();
                    if (tipo > 0) Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Modificar()
        {
            base.Modificar();

           
        }
    }
}
