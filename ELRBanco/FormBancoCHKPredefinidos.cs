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
    public partial class FormBancoCHKPredefinidos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormBancoCHKPredefinidos()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string valor = "";

            int index = 0;
            try
            {
                txtConcepto.Text = "";

                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valor = DataGridConsulta["Concepto", index].Value.ToString();
                valor += " (" + DataGridConsulta["Cuenta_Contable", index].Value.ToString();
                valor += " - " + DataGridConsulta["Descripcion_Cuenta", index].Value.ToString() + ")";

                txtConcepto.Text = valor;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FormBancoGenerarCHKPredefinidos frm = new FormBancoGenerarCHKPredefinidos();
            try
            {
                frm.EMPRESA_ID = empresaID;
                frm.OFICINA_ID = oficinaID;
                frm.nombreUsuario = nombreUsuario;
                frm.EnEjecusion = true;

                frm.ShowDialog();

                if (frm.lOK) RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }
    }
}
