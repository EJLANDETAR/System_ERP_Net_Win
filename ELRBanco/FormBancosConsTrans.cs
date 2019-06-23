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
    public partial class FormBancosConsTrans : WinControl_ELR_NET.FormPlantillaIndex
    {
        string cuentaNumero = "";
        DataTable DTCuentas = null;

        public FormBancosConsTrans()
        {
            InitializeComponent();
        }

        private void FormBancosConsTrans_Load(object sender, EventArgs e)
        {        
            try
            {
                cboTipo.SelectedIndex = 0;
                dtpFecha1.Value = DateTime.Now.Date.AddDays(-30);
                dtpFecha2.Value = DateTime.Now.Date;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                DTCuentas = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1, objDB.Filtros);
                cboCuenta.DisplayMember = "Nombre";
                cboCuenta.ValueMember = "Cuenta_Id";
                cboCuenta.DataSource = DTCuentas.DefaultView;
                cboCuenta.SelectedValue = 1;

                RealizarBusquedaSencilla();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void RealizarBusquedaSencilla()
        {
            //base.RealizarBusquedaSencilla();
            objDB.LimpiarFiltros();
            objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
            objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

            if (txtABuscar.Text.Trim() != "") objDB.AddFiltroContengaA("Beneficiario", txtABuscar.Text.Trim());

            GetData();
        }

        public override void GetData(int opcion = 0)
        {
            int cuentaId = 0;
            int tipo = 0;
            double totalDebito = 0, totalCredito = 0;
            try
            {
                if (cboCuenta.SelectedValue != null)
                {
                    cuentaId = int.Parse(cboCuenta.SelectedValue.ToString());
                    objDB.AddFiltroIgualA("Cuenta_Id", cuentaId.ToString());
                }

                tipo = cboTipo.SelectedIndex;

                if (tipo == 1) objDB.AddFiltroPersonalizado("(Tipo Like 'CK%' Or Tipo Like 'CHK%')");
                else if (tipo == 2) objDB.AddFiltroEmpieceEN("Tipo", "DEP");
                else if (tipo == 3) objDB.AddFiltroEmpieceEN("Tipo", "TRANSF+");
                else if (tipo == 4) objDB.AddFiltroEmpieceEN("Tipo", "TRANSF-");
                else if (tipo == 5) objDB.AddFiltroEmpieceEN("Tipo", "ND");
                else if (tipo == 6) objDB.AddFiltroEmpieceEN("Tipo", "NC");

                if (chkExcluirNulos.Checked) objDB.AddFiltroIgualA("EsNulo", "0");

                base.GetData(opcion);
                DataGridConsulta.SelectionMode = DataGridViewSelectionMode.CellSelect;

                //Procedemos a Totalizar
                totalDebito = GetSum("Debito", "EsNulo = 0");
                totalCredito = GetSum("Credito", "EsNulo = 0");

                lblTotalDebito.Text = totalDebito.ToString("N2");
                lblTotalCredito.Text = totalCredito.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataRow fila0;
            string valorUnico = "0";
            bool esNulo = false;

            try
            {
                valorUnico = DataGridConsulta["Unico", e.RowIndex].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                esNulo = objUtil.GetAsBoolean("EsNulo", fila0);

                if (esNulo)
                {
                    DataGridViewCell celda = DataGridConsulta["Estatus", e.RowIndex];

                    celda.Style.BackColor = Color.Red;
                    celda.Style.ForeColor = Color.White;

                }
            }
            catch (Exception)
            {


            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string titulo = "";

            try
            {
                Cursor = Cursors.WaitCursor;

                titulo = "TRANSACIONES BANCARIAS";

                if (cboTipo.Text != "(TODOS)") titulo += ", " + cboTipo.Text;

                titulo += ", EN FECHAS [" + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";

                frm.titulo = titulo;
                frm.pathReporte = "RptBancoTransListado";
                frm.DTData = MyData;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;

                frm.AddParm("CUENTA_NOMBRE", cboCuenta.Text);
                frm.AddParm("CUENTA_NUMERO", cuentaNumero);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
                Cursor = Cursors.Default;
            }
            
        }

        private void cboCuenta_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRow fila0;
            string cuentaId = "0";
            try
            {
                cuentaNumero = "";
                if (cboCuenta.SelectedValue != null)
                {
                    cuentaId = cboCuenta.SelectedValue.ToString();
                    fila0 = DTCuentas.Select("Cuenta_Id = " + cuentaId)[0];
                    cuentaNumero = objUtil.GetAsString("Numero", fila0);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
