using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaMovimientosAnular : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaMovimientosAnular()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            string valorId = "0";

            try
            {
                if (DataGridConsulta.RowCount > 0)
                {
                    valorId = DataGridConsulta["Asiento_Id", DataGridConsulta.CurrentRow.Index].Value.ToString();
                    ImprimirPreviewRDLC("rptContaAsientoDiario", "VCONTA_DIARIO_DETALLE", valorId, "Asiento_Id");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = 0;
            string concepto;
            string asientoNo = "0";

            try
            {
                txtConcepto.Text = "";
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                index = dataGridView1.CurrentRow.Index;
                concepto = dataGridView1["Concepto", index].Value.ToString();
                asientoNo = dataGridView1["Asiento_No", index].Value.ToString();

                concepto = "ASIENTO NO.:" + asientoNo.PadLeft(7, '0') + "; CONCEPTO: " + concepto.ToUpper();

                txtConcepto.Text = concepto;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objUtil = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow MyFila = null;
            bool esSistema = false;
            string asientoNo = "0";
            DialogResult resp = DialogResult.Yes;
            FormContaMovimientosAnularR frmAnular = new FormContaMovimientosAnularR();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (objUtil == null) objUtil = new WinControl_ELR_NET.ELRUtils();

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    esSistema = objUtil.GetAsBoolean("EsSistema", MyFila);
                    asientoNo = objUtil.GetAsString("Asiento_No", MyFila, "0");

                    if (esSistema) resp = objUtil.MostrarMensajePregunta("El Asiento No.:" + asientoNo.PadLeft(8, '0') 
                                                                         + " Ha Sido Generado Por El Sistema. ¿Esta Seguro que desea Anularlo?");

                    if(resp == DialogResult.Yes)
                    {
                        frmAnular.EMPRESA_ID = empresaID;
                        frmAnular.OFICINA_ID = oficinaID;
                        frmAnular.VALOR_ID = "0";
                        frmAnular.drRegistroSel = MyFila;
                        frmAnular.DTVariablesSYS = DTVariablesSYS;
                        frmAnular.DSGlobal = DSGlobal;
                        frmAnular.nombreUsuario = nombreUsuario;
                        frmAnular.EnEjecusion = true;

                        frmAnular.ShowDialog();

                        if (frmAnular.lOK) RealizarBusquedaSencilla();

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
                frmAnular.Dispose();
            }
        }

        public override void RealizarBusquedaSencilla()
        {
            int fechaDesde = 0, fechaHasta = 0;
            int tipoId = 0;

            try
            {
                if (objUtil == null) objUtil = new WinControl_ELR_NET.ELRUtils();

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());

                if (cboTipo.SelectedValue != null)
                {
                    tipoId = int.Parse(cboTipo.SelectedValue.ToString());
                    if (tipoId > 0) objDB.AddFiltroIgualA("TipoAutom", tipoId.ToString());
                }

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void FormContaMovimientosAnular_Load(object sender, EventArgs e)
        {
            string SSQL = "";
            DataTable DTTipo = null;
            try
            {
                if (objUtil == null) objUtil = new WinControl_ELR_NET.ELRUtils();

                dtpFecha1.Value = objUtil.getPrimeraFechaMes(DateTime.Now.Date);
                dtpFecha2.Value = DateTime.Now.Date;

                SSQL = " SELECT 0 as Tipo_Id, '(TODOS)' as Decripcion, 0 as Modulo_Id ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Tipo_Id, REPLACE(Descripcion, 'GENERAR ', '') Descripcion, Modulo_Id ";
                SSQL += " FROM TCONTA_SP_GENERA_ASIENTOS ";
                SSQL += " Order by Modulo_Id, Tipo_Id ";

                DTTipo = objDB.GetSQL(SSQL);
                cboTipo.DataSource = DTTipo.DefaultView;
                cboTipo.SelectedValue = 0;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
