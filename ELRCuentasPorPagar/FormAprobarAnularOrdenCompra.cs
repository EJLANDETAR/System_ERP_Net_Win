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
    public partial class FormAprobarAnularOrdenCompra : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormAprobarAnularOrdenCompra()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            int tipo = 0;
            string aBuscar = "";
            try
            {
                tipo = cboTipo.SelectedIndex;
                aBuscar = txtABuscar.Text.Trim();
                if (tipo == 1) objDB.AddFiltroIgualA("Modulo", "ORD");
                else if (tipo == 2) objDB.AddFiltroIgualA("Modulo", "REQ");
                else objDB.AddFiltroPersonalizado("(Modulo = 'ORD' Or Modulo = 'REQ')");

                objDB.AddFiltroPersonalizado("(IsNull(Orden_Id, 0) = 0)");
                objDB.AddFiltroPersonalizado("(IsNull(URegistro_Id, 0) = 0)");

                if (aBuscar != "") objDB.AddFiltroPersonalizado("( Cast(Numero as Varchar) Like '%" + aBuscar + "' Or Nombre like '%" + aBuscar + "%' )");

                base.GetData(opcion);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarBusquedaSencilla();
        }

        private void FormAprobarAnularOrdenCompra_Load(object sender, EventArgs e)
        {
            if (EnEjecusion) cboTipo.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            string valorUnico = "0";
            string modulo = "";
            int valorId = 0;
            DataRow fila0;
            FormComprasAprobarAnularR frm = new FormComprasAprobarAnularR();
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    index = dataGridView1.CurrentRow.Index;
                    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                    {
                        this.Cursor = Cursors.Default;

                        valorUnico = dataGridView1["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        oficinaID = objUtil.GetAsInt("Oficina_Id", fila0);
                        modulo = objUtil.GetAsString("Modulo", fila0);
                        valorId = objUtil.GetAsInt("CXP_Id", fila0);

                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.nombreUsuario = nombreUsuario;
                        frm.modulo = modulo;
                        frm.Id = valorId;
                        frm.EnEjecusion = true;

                        frm.ShowDialog();

                        GetData();
                        if (dataGridView1.RowCount >= index) dataGridView1.CurrentCell = dataGridView1["Estatus", index];
                    }
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    concepto = dataGridView1["Concepto", dataGridView1.CurrentRow.Index].Value.ToString();
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
