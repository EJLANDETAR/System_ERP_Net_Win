using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormCXPPagoR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormCXPPagoR()
        {
            InitializeComponent();
        }

        public override void TotalizarDetalle()
        {
            //base.TotalizarDetalle();
            double monto = 0;
            double montoAPagar = 0;
            string concepto = "";

            try
            {
                txtConcepto.Text = "";

                monto = GetSum("Monto_APagar", DSDatos.Tables["Detalle"]);
                txtMontoLetra.Text = Numalet.ToCardinal(monto).ToUpper();

                btnGrabar.Enabled = (monto > 0);

                foreach (DataRow item in DSDatos.Tables["Detalle"].Rows)
                {
                    monto = objUtil.GetAsDouble("Monto_Pendiente", item);
                    montoAPagar = objUtil.GetAsDouble("Monto_APagar", item);

                    if (montoAPagar > 0)
                    {
                        if (concepto.Trim().Length > 0) concepto += ", ";
                        if (montoAPagar >= monto) concepto += "SALDO " + objUtil.GetAsString("Concepto", item);
                        else concepto += "ABONO A " + objUtil.GetAsString("Concepto", item);
                    }
                }

                txtConcepto.Text = concepto;

                if (concepto.Trim() != "") btnGrabar.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAplicarTodo_Click(object sender, EventArgs e)
        {
            string valorUnico = "0";
            string SSQL = "";
            double monto = 0;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                foreach (DataRow item in DSDatos.Tables["Detalle"].Rows)
                {
                    valorUnico = objUtil.GetAsString("Unico", item);
                    monto = objUtil.GetAsDouble("Monto_Pendiente", item);

                    SSQL = "UPDATE " + TablaDetalle + " Set Monto_APagar = " + monto.ToString() + " Where Unico = " + valorUnico;
                    objDB.EjecutarSQL(SSQL);

                    item["Monto_APagar"] = monto;
                }

                monto = GetSum("Monto_APagar", DSDatos.Tables["Detalle"]);
                txtMonto.Text = monto.ToString("N2");

                TotalizarDetalle();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string valorUnico = "0";
            string SSQL = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                foreach (DataRow item in DSDatos.Tables["Detalle"].Rows)
                {
                    valorUnico = objUtil.GetAsString("Unico", item);

                    SSQL = "UPDATE " + TablaDetalle + " Set Monto_APagar = 0 " + " Where Unico = " + valorUnico;
                    objDB.EjecutarSQL(SSQL);

                    item["Monto_APagar"] = 0;
                }

                TotalizarDetalle();
                txtMonto.Text = "0";
                txtMonto.Focus();
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


        public override void PostLineaDetalle(DataGridView senderGrid = null, string nombreColumnaUnico = "Unico")
        {
            base.PostLineaDetalle(senderGrid, nombreColumnaUnico);
        }


        public override int GrabarDatos()
        {
            int resultado = 0;
            string formaPago = "";
            int cuentaId = 0;
            try
            {
                if (cboFormaPago.Text.Trim() == "GENERAR CHEQUES") formaPago = "CK";
                else if (cboFormaPago.Text.Trim() == "PAGO PRE-REALIZADO") formaPago = "PRE";
                else formaPago = "";

                if (cboCuentaBancaria.Enabled)
                {
                    if (cboCuentaBancaria.SelectedValue != null) cuentaId = int.Parse(cboCuentaBancaria.SelectedValue.ToString());
                }

                if (formaPago.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Seleccionar Forma Pago");
                else if(cboCuentaBancaria.Enabled && cuentaId <= 0) objUtil.MostrarMensajeAdvertencia("Debe Seleccionar Cuenta Bancaria");
                else
                {
                    SetValorEncabezado("Empresa_Id", EMPRESA_ID);
                    SetValorEncabezado("Oficina_Id", OFICINA_ID);
                    SetValorEncabezado("Forma_Pago", formaPago);

                    resultado = base.GrabarDatos();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            double monto = 0, montoAPagar = 0;
            double montoPendiente = 0;
            string valorUnico = "0";
            DataRow fila0;


            try
            {
                if (txtMonto.Text.Trim() == "") txtMonto.Text = "0";

                double.TryParse(txtMonto.Text, out monto);
                montoPendiente = GetSum("Monto_Pendiente", DSDatos.Tables["Detalle"]);
                montoAPagar = monto;

                if (monto > montoPendiente)
                {
                    objUtil.MostrarMensajeAdvertencia("EL MONTO A PAGAR NO PUEDE SER MAYOR A: " + montoPendiente.ToString("N2"));
                    txtMonto.Text = montoPendiente.ToString();
                    montoAPagar = montoPendiente;
                }

                string SSQL = "";


                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < DataGridDetalle.RowCount; i++)
                {
                    valorUnico = DataGridDetalle["Unico", i].Value.ToString();
                    fila0 = DSDatos.Tables["Detalle"].Select("Unico = " + valorUnico)[0];
                    montoPendiente = objUtil.GetAsDouble("Monto_Pendiente", fila0);

                    SSQL = "UPDATE " + TablaDetalle + " Set Monto_APagar = ";
                    if (montoPendiente >= montoAPagar)
                    {
                        fila0["Monto_APagar"] = montoAPagar;
                        SSQL += montoAPagar.ToString();
                        montoAPagar = 0;
                    }
                    else if (montoAPagar > montoPendiente)
                    {
                        fila0["Monto_APagar"] = montoPendiente;
                        SSQL += montoPendiente.ToString();
                        montoAPagar -= montoPendiente;
                    }
                    else
                    {
                        fila0["Monto_APagar"] = 0;
                        SSQL += " 0";
                    }


                    //APLICAMOS LOS CAMBIOS EN EL TEMPORAL;
                    SSQL += " WHERE Unico = " + valorUnico;
                    objDB.EjecutarSQL(SSQL);

                }

                TotalizarDetalle();

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

        private void FormCXPPagoR_Activated(object sender, EventArgs e)
        {
            txtMonto.Focus();
        }

        private void FormCXPPagoR_Load(object sender, EventArgs e)
        {
            bool esValor = false;
            string valorVariable = "";

            try
            {
                valorVariable = objUtil.GetValorVariable("COMPRAS_GENERAR_PAGOS_CHEQUES", DTVariablesSYS, "").ToUpper();
                esValor = (valorVariable == "TRUE" || valorVariable == "1");
                if (esValor) cboFormaPago.Items.Add("GENERAR CHEQUES");

                valorVariable = objUtil.GetValorVariable("COMPRAS_PAGOS_PRE_REALIZADO", DTVariablesSYS, "").ToUpper();
                esValor = (valorVariable == "TRUE" || valorVariable == "1");
                if (esValor) cboFormaPago.Items.Add("PAGO PRE-REALIZADO");

               if(cboFormaPago.Items.Count > 0) cboFormaPago.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboCuentaBancaria.Enabled = (cboFormaPago.Text == "GENERAR CHEQUES");
                if (!cboCuentaBancaria.Enabled) cboCuentaBancaria.SelectedValue = 0;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
