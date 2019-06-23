using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormImprimirDocumentos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormImprimirDocumentos()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            int valorUnico = 0;
            int index = 0;
            ELRPrintDocument.ELRDocument doc = new ELRPrintDocument.ELRDocument();

            try
            {
                if (DataGridConsulta == null) return;
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.Rows.Count <= 0) return;

                Cursor = Cursors.WaitCursor;
                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = int.Parse(DataGridConsulta["Unico", index].Value.ToString());
                doc.GenerarContractoPDF(valorUnico, nombreUsuario);
                GetData();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridConsulta == null) return;

                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn || DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Imprimir();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
