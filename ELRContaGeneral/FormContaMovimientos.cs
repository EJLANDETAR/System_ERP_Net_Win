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
    public partial class FormContaMovimientos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaMovimientos()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            string valorId = "0";

            try
            {
                if(DataGridConsulta.RowCount > 0)
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

        public override void TotalizarData()
        {
            
            int conteo = 0;
            double total = 0;

            try
            {
                base.TotalizarData();

                if (MyData != null)
                {
                    conteo = MyData.Rows.Count;
                    total = GetSum("Monto", "EsNulo = 0");
                }

                lblCantidadFilas.Text = "Cantidad Registro: " + conteo.ToString();
                lblTotal.Text = "Total: " + total.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormContaMovimientos_Load(object sender, EventArgs e)
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

                if(cboTipo.SelectedValue != null)
                {
                   tipoId = int.Parse( cboTipo.SelectedValue.ToString());
                   if(tipoId > 0) objDB.AddFiltroIgualA("TipoAutom", tipoId.ToString());
                }

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }
    }
}
