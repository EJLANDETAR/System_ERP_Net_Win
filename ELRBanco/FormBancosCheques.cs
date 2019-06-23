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
    public partial class FormBancosCheques : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormBancosCheques()
        {
            InitializeComponent();
        }

        private void chkPorCuenta_CheckedChanged(object sender, EventArgs e)
        {
            cboCuenta.Enabled = chkPorCuenta.Checked;
            if (chkPorCuenta.Checked == false) cboCuenta.SelectedValue = 0;
        }

        public override void RealizarBusquedaSencilla()
        {
            //base.RealizarBusquedaSencilla();
            try
            {
                pnOpcionesBusqueda.Visible = false;

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (txtABuscar.Text.Trim() != "") objDB.AddFiltroContengaA("Beneficiario", txtABuscar.Text.Trim());

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            int valorId = 0;

            try
            {
                if ( (chkPorCuenta.Checked) && (cboCuenta.SelectedValue != null) )
                {
                    valorId = int.Parse( cboCuenta.SelectedValue.ToString() );
                    if (valorId > 0) objDB.AddFiltroIgualA("Cuenta_Id", valorId.ToString());
                }


                objDB.AddFiltroPersonalizado("(Tipo = 'CK' Or Tipo = 'CHK')");

                base.GetData(opcion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            int index = 0;
            try
            {
                if (DataGridConsulta != null)
                {
                    if (DataGridConsulta.CurrentRow != null)
                    {
                        index = DataGridConsulta.CurrentRow.Index;
                        concepto = DataGridConsulta["Concepto", index].Value.ToString();
                    }
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormBancosCheques_Load(object sender, EventArgs e)
        {
            DataTable DTCuenta = null;
            try
            {
                dtpFecha1.Value = DateTime.Now.Date.AddDays(-30);
                dtpFecha2.Value = DateTime.Now.Date;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                DTCuenta = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1, objDB.Filtros);
                cboCuenta.DisplayMember = "Nombre";
                cboCuenta.ValueMember = "Cuenta_Id";
                cboCuenta.DataSource = DTCuenta.DefaultView;
                cboCuenta.SelectedValue = 1;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorId = "";
            string nombreColumna = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                nombreColumna = DataGridConsulta.Columns[e.ColumnIndex].Name.ToUpper();

                if (DataGridConsulta.RowCount > 0 && DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    valorId = DataGridConsulta[e.ColumnIndex, DataGridConsulta.CurrentRow.Index].Value.ToString().Trim();

                    if (valorId != "" && valorId != "0")
                    {
                        if (nombreColumna == "ASIENTO_ID")
                        {
                            ImprimirPreviewRDLC("RptContaAsientoDiario", "VCONTA_DIARIO_DETALLE", valorId, "Asiento_Id");
                        }
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
    }
}
