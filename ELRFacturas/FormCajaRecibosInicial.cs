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
    public partial class FormCajaRecibosInicial : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCajaRecibosInicial()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow myFila;
            FormCajaRecibosInicialR frm = new FormCajaRecibosInicialR();

            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + valorUnico)[0];

                    frm.OFICINA_ID = oficinaID;
                    frm.EMPRESA_ID = empresaID;
                    frm.DTOficina = DTOficina;
                    frm.DTVariablesSYS = DTVariablesSYS;
                    frm.DSGlobal = DSGlobal;

                    frm.drRegistroSel = myFila;
                    frm.nombreUsuario = nombreUsuario;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    //Recargamos la Data
                    if (frm.lOK) GetData(0);
                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
