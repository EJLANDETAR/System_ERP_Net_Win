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
    public partial class FormSolicitudDesembolso : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSolicitudDesembolso()
        {
            InitializeComponent();
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDesembolsoR frm = new FormDesembolsoR();
            string valorUnico = "0";
            DataRow MyFila = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;


                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];

                    frm.cajaId = 0;
                    frm.nombreUsuario = nombreUsuario;
                    frm.EsConTemporal = true;
                    frm.EMPRESA_ID = empresaID;
                    frm.OFICINA_ID = oficinaID;
                    frm.drRegistroSel = MyFila;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.lOK) GetData();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
                MyFila = null;
            }

        }
    }
}
