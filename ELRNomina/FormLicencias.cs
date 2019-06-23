using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormLicencias : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormLicencias()
        {
            InitializeComponent();
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow fila0;

            FormLicenciasR frm = new FormLicenciasR();
            try
            {
                if (dtgData.RowCount > 0)
                {
                    if (dtgData.Columns[e.ColumnIndex] is DataGridViewButtonColumn || dtgData.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                    {
                        valorUnico = dtgData["Unico", dtgData.CurrentRow.Index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];

                        frm.fila0 = fila0;
                        frm.nombreUsuario = nombreUsuario;
                        frm.EnEjecusion = true;

                        frm.ShowDialog();

                        GetData();

                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
