using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRBanco
{
    public partial class FormBancosCuentas : WinControl_ELR_NET.FormPlantillaIndex
    {
        string nombreFormulario = "";

        public FormBancosCuentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        FormularioRegistro = "ELRBanco.FormBancosFormatoChequesR";
                        Modificar();

                        FormularioRegistro = nombreFormulario;
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormBancosCuentas_Load(object sender, EventArgs e)
        {
            if (EnEjecusion) nombreFormulario = FormularioRegistro;
        }

        public override void GetData(int opcion = 0)
        {
            DataGridConsulta.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridConsulta.RowTemplate.Height = 35;

            base.GetData(opcion);
        }
    }
}
