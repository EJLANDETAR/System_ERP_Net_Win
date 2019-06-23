using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRControlUsuarios
{
    public partial class FormOpcionesXRol : WinControl_ELR_NET.ELRFormRegistro
    {
        DataRow fila0 = null;

        public FormOpcionesXRol()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PostLineaDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void AplicarPermisos(object sender, EventArgs e)
        {
            ToolStripMenuItem mnuItem;

            bool esConsulta = false;
            bool esInsertar = false;
            bool esModificar = false;
            bool esCambiar_Fecha = false;
            bool esAnular = false;
            bool esAprobar = false;
            bool esRechazar = false;
            bool esGenerar = false;
            bool esImprimir = false;
            string valorUnico = "0";

            try
            {
                if (fila0 == null) return;
                this.Cursor = Cursors.WaitCursor;

                mnuItem = (ToolStripMenuItem)sender;

                if ((mnuItem == tsmAplicarFila) || (mnuItem == tsmAplicarTodos))
                {
                    esConsulta = true; esInsertar = true; esModificar = true;
                    esCambiar_Fecha = true; esAnular = true; esAprobar = true;
                    esRechazar = true; esGenerar = true; esImprimir = true;
                }

                if ((mnuItem == tsmAplicarFila) || (mnuItem == tsmQuitarFila))
                {
                    fila0["EsActivo"] = esConsulta;
                    fila0["EsConsulta"] = esConsulta;
                    fila0["esInsertar"] = esInsertar;
                    fila0["esModificar"] = esModificar;
                    fila0["esCambiar_Fecha"] = esCambiar_Fecha;
                    fila0["esAnular"] = esAnular;
                    fila0["esAprobar"] = esAprobar;
                    fila0["esRechazar"] = esRechazar;
                    fila0["esGenerar"] = esGenerar;

                    if (DataGridDetalle.Columns.Contains("EsImprimir")) fila0["EsImprimir"] = esImprimir;
                }
                else
                {
                    for (int i = 0; i < DataGridDetalle.RowCount; i++)
                    {
                        valorUnico = DataGridDetalle["Unico", i].Value.ToString();
                        fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];
                        fila0["EsActivo"] = esConsulta;
                        fila0["EsConsulta"] = esConsulta;
                        fila0["esInsertar"] = esInsertar;
                        fila0["esModificar"] = esModificar;
                        fila0["esCambiar_Fecha"] = esCambiar_Fecha;
                        fila0["esAnular"] = esAnular;
                        fila0["esAprobar"] = esAprobar;
                        fila0["esRechazar"] = esRechazar;
                        fila0["esGenerar"] = esGenerar;

                        if (DataGridDetalle.Columns.Contains("EsImprimir")) fila0["EsImprimir"] = esImprimir;

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

        private void FormOpcionesXRol_Load(object sender, EventArgs e)
        {
            string nombreRol = "";
            try
            {
                nombreRol = objUtil.GetAsString("Nombre", drRegistroSel);
                this.Text = "APLICAR OPCIONES A ROL: " + nombreRol;

                cboMenuPrincipal.LlenarCombo();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboMenuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView DVData = null;
            string id = "";

            try
            {
                if (cboMenuPrincipal.SelectedValue != null)
                {
                    id = cboMenuPrincipal.SelectedValue.ToString();
                    DVData = new DataView(DTDetalle);
                    DVData.RowFilter = "Tipo = '" + "1-" + id + "'";

                    if (DVData != null)
                    {
                        DataGridDetalle.DataSource = null;
                        DataGridDetalle.DataSource = DVData;
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string valorUnico = "0";
            try
            {
                fila0 = null;

                if (DTDetalle == null) return;
                if (DTDetalle.Rows.Count <= 0) return;
                if (dataGridView1.RowCount <= 0) return;

                valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();

                fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];

            }
            catch (Exception)
            {


            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string valorUnico = "0";
            try
            {
                if (DTDetalle == null) return;
                if (DTDetalle.Rows.Count <= 0) return;
                if (dataGridView1.RowCount <= 0) return;
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex < 0) return;

                valorUnico = dataGridView1["Unico", e.RowIndex].Value.ToString();
                dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;

                fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];

            }
            catch (Exception)
            {


            }
        }

        private void btnAplicarTodos_Click(object sender, EventArgs e)
        {

            bool esConsulta = false;
            bool esInsertar = false;
            bool esModificar = false;
            bool esCambiar_Fecha = false;
            bool esAnular = false;
            bool esAprobar = false;
            bool esRechazar = false;
            bool esGenerar = false;
            bool esImprimir = false;
            string valorUnico = "0";
            Button btn;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btn = (Button)sender;

                if (btn == btnAplicarTodos)
                {
                    esConsulta = true; esInsertar = true; esModificar = true;
                    esCambiar_Fecha = true; esAnular = true; esAprobar = true;
                    esRechazar = true; esGenerar = true; esImprimir = true;
                }

                for (int i = 0; i < DataGridDetalle.RowCount; i++)
                {
                    valorUnico = DataGridDetalle["Unico", i].Value.ToString();
                    fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];

                    fila0["EsActivo"] = esConsulta;
                    fila0["EsConsulta"] = esConsulta;
                    fila0["esInsertar"] = esInsertar;
                    fila0["esModificar"] = esModificar;
                    fila0["esCambiar_Fecha"] = esCambiar_Fecha;
                    fila0["esAnular"] = esAnular;
                    fila0["esAprobar"] = esAprobar;
                    fila0["esRechazar"] = esRechazar;
                    fila0["esGenerar"] = esGenerar;

                    if (DataGridDetalle.Columns.Contains("EsImprimir")) fila0["EsImprimir"] = esImprimir;

                    objDB.UpdateFromRow(TablaDetalle, fila0, "Unico", "IdentificadorTeemp");
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
