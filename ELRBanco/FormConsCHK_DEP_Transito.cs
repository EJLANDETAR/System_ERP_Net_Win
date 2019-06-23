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
    public partial class FormConsCHK_DEP_Transito : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTCuentas;
        string cuentaId = "0", cuentaNumero = "00000000", cuentaContable = "00000000";

        public FormConsCHK_DEP_Transito()
        {
            InitializeComponent();
        }

        private void FormConsCHK_DEP_Transito_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFecha1.Value = DateTime.Now.Date;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                DTCuentas = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1);
                cboCuentaBanco.ValueMember = "Cuenta_Id";
                cboCuentaBanco.DisplayMember = "Nombre";
                cboCuentaBanco.DataSource = DTCuentas.DefaultView;
                cboCuentaBanco.SelectedValue = 1;
                cboTipo.SelectedIndex = 0;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            string valorUnico = "0";
            DataRow fila0;
            int index = 0;

            try
            {
                txtConcepto.Text = "";

                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;
                if (DataGridConsulta.RowCount != MyData.Rows.Count) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                concepto = objUtil.GetAsString("Tipo", fila0) + " No. ";
                concepto += objUtil.GetAsString("Numero", fila0) + "; ";
                concepto += objUtil.GetAsString("Concepto", fila0);

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {
                txtConcepto.Text = "";
                objUtil.MostrarMensajeError(ex.Message);
            }

            
        }

        private void cboCuentaBanco_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRow fila0;
            try
            {
                cuentaNumero = "00000000";
                cuentaContable = "00000000";

                if (cboCuentaBanco.SelectedValue != null)
                {
                    cuentaId = cboCuentaBanco.SelectedValue.ToString();
                    fila0 = DTCuentas.Select("Cuenta_Id = " + cuentaId)[0];
                    cuentaNumero = objUtil.GetAsString("Numero", fila0);
                    cuentaContable = objUtil.GetAsString("Cuenta_Contable", fila0);
                }

                lblCuentaBancoNumero.Text = "Cuenta Banco No.: " + cuentaNumero;
                lblCuentaContable.Text = "Cuenta Contable.: " + cuentaContable;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            int fechaHasta = 0;
            double total = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroIgualA("EsRecibido", "0");
                objDB.AddFiltroIgualA("Conciliacion_Id", "0");

                objDB.AddFiltroIgualA("Cuenta_Id", cuentaId);
                fechaHasta = objUtil.DateToInt(dtpFecha1.Value);
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());

                if(cboTipo.SelectedIndex <= 0) objDB.AddFiltroPersonalizado("Tipo in ('CK', 'CHK')");
                else objDB.AddFiltroPersonalizado("Tipo in ('DP', 'DEP')");

                MyData = objDB.GetAll("TBANCOS_TRANS", -1, objDB.Filtros);
                MostrarCantidadFilas();
                total = GetSum("Monto");

                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                lblTotal.Text = total.ToString("N2");
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

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string titulo = "LISTADO ";
            try
            {
                Cursor = Cursors.WaitCursor;

                titulo += (cboTipo.SelectedIndex <= 0 ? "CHEQUES" : "DEPOSITOS") + " EN TRANSITO ";
                titulo += ", A FECHA: " + objUtil.GetDateAsString(dtpFecha1.Value);
                titulo += ", [" + cboCuentaBanco.Text + " - " + cuentaNumero + "]";

                frm.titulo = titulo;
                frm.DTData = MyData;
                frm.pathReporte = "RptBancoTransTransitos";
                frm.nombreUsuario = nombreUsuario;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                frm.Dispose();
            }
        }
    }
}
