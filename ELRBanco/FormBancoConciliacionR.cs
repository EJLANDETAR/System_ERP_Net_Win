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
    public partial class FormBancoConciliacionR : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTTrans;
        DataView DVTrans;
        DataTable DTTipo;
        DataTable DTCuentas;
        DataTable DTTipoAjuste;
        int cuentaId = 0;
        int conciliacionId = 0;
        string filtroTrans = "";
        double totalChequesTrans;
        double totalDepositosTrans;
        bool esTemporal = false;
        double saldoCuenta = 0;

        public FormBancoConciliacionR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            string SSQL = "";
            try
            {
                tabControl1.Enabled = false;

                resultado = base.GetData();

                //Buscamos los tipos de Transaccion
                SSQL = "SELECT '0' as Tipo, '(TODAS)' as Nombre ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Tipo, Nombre From TBANCOS_TRANS_TIPOS";

                DTTipo = objDB.GetSQL(SSQL);
                cboTipo.DataSource = DTTipo.DefaultView;
                cboTipo.SelectedValue = "0";

                //BUSCAMOS LOS TIPOS DE AJUSTE
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsAjusteConciliacion", "1");
                objDB.AddFiltroIgualA("EsActivo", "1");
                DTTipoAjuste = objDB.GetAll("TBANCOS_TRANS_TIPOS", -1, objDB.Filtros);
                cboTipoAjuste.DisplayMember = "Nombre";
                cboTipoAjuste.ValueMember = "Tipo";
                cboTipoAjuste.DropDownStyle = ComboBoxStyle.DropDownList;
                cboTipoAjuste.DataSource = DTTipoAjuste.DefaultView;

                //Buscamos las Cuenta de Bancos
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTCuentas = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1, objDB.Filtros);
                cboCuenta.DataSource = DTCuentas.DefaultView;

                if (resultado)
                {
                    if (!esNuevo)
                    {
                        cuentaId = objUtil.GetAsInt("Cuenta_Id", DSDatos.Tables[0].Rows[0]);
                        cboCuenta.SelectedValue = cuentaId;

                        btnProcesar.PerformClick();
                    }
                    else
                    {
                        dtpFechaHasta.Value = DateTime.Now.Date;
                        cboCuenta.SelectedValue = 1;
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
           
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string SSQL = "";
            DataTable DTValida;
            int conteo = 0;
            try
            {
                if(cboCuenta.Text.Trim() == "")
                {
                    objUtil.MostrarMensajeAdvertencia("DEBE SELECCIONAR CUENTA BANCARIA A CONCILIAR");
                    return;
                }

                //VALIDAMOS LA FECHA DEBE SER MENOR A LA FECHA ACTUAL
                if(objUtil.DateToInt(dtpFechaHasta.Value) >= objUtil.DateToInt(DateTime.Now.Date) )
                {
                    objUtil.MostrarMensajeError("LA FECHA DEBE SER MENOR A LA FECHA ACTUAL");
                    return;
                }

                this.Cursor = Cursors.WaitCursor;

                cuentaId = int.Parse( cboCuenta.SelectedValue.ToString());

                //VALIDAMOS NO EXISTAN CONCILIACIONES TEMPORAL PENDIENTE
                conciliacionId = objUtil.GetAsInt("Conciliacion_Id", DSDatos.Tables[0].Rows[0]);
                SSQL = "SELECT COUNT(*) Conteo From TBANCOS_CONCILIACIONES ";
                SSQL += " WHERE Cuenta_Id = " + cuentaId.ToString();
                SSQL += "       And IsNull(EsConciliado, 0) = 0";
                SSQL += "       And IsNull(EsNulo, 0) = 0";
                SSQL += "       and Conciliacion_Id <> " + conciliacionId.ToString();

                DTValida = objDB.GetSQL(SSQL);
                conteo = objUtil.GetAsInt("Conteo", DTValida.Rows[0]);
                if(conteo > 0)
                {
                    objUtil.MostrarMensajeError("EXISTEN " + conteo.ToString() + " REGISTRO(S) DE CONCILIACION AUN EN TEMPORAL");
                    return;
                }

                //VALIDAMOS LA FECHA NO COINDICA CON UNA CONCILIACION YA REGISTRADA
                SSQL = "SELECT COUNT(*) Conteo From TBANCOS_CONCILIACIONES ";
                SSQL += " WHERE Cuenta_Id = " + cuentaId.ToString();
                SSQL += "       And IsNull(EsNulo, 0) = 0";
                SSQL += "       and Conciliacion_Id <> " + conciliacionId.ToString();
                SSQL += "        And Fecha >= '" + objUtil.DateToInt(dtpFechaHasta.Value) + "'";

                DTValida = objDB.GetSQL(SSQL);
                conteo = objUtil.GetAsInt("Conteo", DTValida.Rows[0]);
                if(conteo > 0)
                {
                    objUtil.MostrarMensajeError("EXISTEN " + conteo.ToString() + " REGISTRO(S) DE CONCILIACION EN FECHA POSTERIOR");
                    return;
                }

                //Buscamos el Saldo de la Cuenta a la Fecha
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Cuenta_Id", cuentaId.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroIsNull("Fecha_Deleted");
                objDB.AddFiltroMenorOIgualA("Fecha", objUtil.DateToInt(dtpFechaHasta.Value).ToString());
                objDB.AddFiltroOrderBY("Fecha Desc, Unico Desc");
                DTValida = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS_SALDOS", 1, objDB.Filtros);
                saldoCuenta = objUtil.GetAsDouble("Saldo", DTValida.Rows[0]);
                txtBalanceLibro.Text = saldoCuenta.ToString("N2");

                SetValorEncabezado("Cuenta_Id", cuentaId);
                SetValorEncabezado("Fecha", dtpFechaHasta.Value.Date);
                

                cboCuenta.Enabled = false;
                dtpFechaHasta.Enabled = false;

                //Buscamos las Transacciones
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Cuenta_Id", cuentaId.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroMayorOIgualA("Numero", "1");
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFechaHasta.Value).ToString());
                objDB.AddFiltroPersonalizado("IsNull(Conciliacion_Id, 0) = 0");
                objDB.AddFiltroOrderBY("Fecha, Tipo, Numero");

                DTTrans = objDB.GetAll("TBancos_Trans", -1, objDB.Filtros);
                DVTrans = new DataView(DTTrans);
                dtgTransacciones.AutoGenerateColumns = false;
                dtgTransacciones.DataSource = DVTrans;

                FiltrarTrans();

                totalizarTransEnTransito();

                btnProcesar.Enabled = false;
                btnSiguientePage.Visible = true;
                btnSiguientePage.Text = "Grabar Temporal";

                Refresh();
                CalcularBalance();
                tabControl1.Enabled = true;
                

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

        void FiltrarTrans()
        {
            string tipoTrans = "0";
            double numeroABuscar = 0;
            try
            {
                filtroTrans = "";
                numeroABuscar = objUtil.ConvertirANumero(txtNumeroABuscar.Text.Trim());

                if (DVTrans == null) return;

                this.Cursor = Cursors.WaitCursor;

                if (cboTipo.SelectedValue != null) tipoTrans = cboTipo.SelectedValue.ToString().Trim();

                if (tipoTrans != "0" && tipoTrans != "") filtroTrans += "Tipo like '" + tipoTrans + "%'";

                if(chkSoloNoRecibido.Checked)
                {
                    if (filtroTrans.Trim() != "") filtroTrans += " And EsRecibido = 0";
                    else filtroTrans += " EsRecibido = 0";
                }


                if(cboFiltro2.SelectedIndex >= 1 && numeroABuscar > 0)
                {
                    if(cboFiltro2.SelectedIndex == 1)
                    {
                        if (filtroTrans.Trim() != "") filtroTrans += " And Numero = " + numeroABuscar.ToString();
                        else filtroTrans += " Numero = " + numeroABuscar.ToString();
                    }
                    else if (cboFiltro2.SelectedIndex == 2)
                    {
                        if (filtroTrans.Trim() != "") filtroTrans += " And Monto = " + numeroABuscar.ToString();
                        else filtroTrans += " Monto = " + numeroABuscar.ToString();
                    }
                }

                DVTrans.RowFilter = filtroTrans;

                

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Filtrar Transacciones, " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void totalizarTransEnTransito()
        {
            int conteo = 0; 
            try
            {
                conteo = GetCount("Unico", DTTrans, "");

                totalChequesTrans = GetSum("Monto", DTTrans, "(EsRecibido = 0) and (tipo = 'CHK' or Tipo = 'CK')");
                totalDepositosTrans = GetSum("Monto", DTTrans, "(EsRecibido = 0) and (tipo LIKE 'DEP%' or Tipo like 'DP%')");

                lblTotalEnTransito.Text = conteo.ToString() + " TRANSACCIONES" +
                                          ",     EN TRANSITO ==>" +
                                          " CHEQUES:  " + totalChequesTrans.ToString("N2") +
                                          "          DEPOSITOS:  " + totalDepositosTrans.ToString("N2") + " ";

                txtChkEnTransito.Text = totalChequesTrans.ToString("N2");
                txtDepTransito.Text = totalDepositosTrans.ToString("N2");
 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltrarTrans();
        }

        private void chkSoloNoRecibido_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarTrans();
        }

        private void dtgTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = "";
            string valorUnico = "";
            bool esRecibido = false;
            DataRow fila0;
            string SSQL = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;
                nombreColumna = senderGrid.Columns[e.ColumnIndex].Name.ToUpper();

                if(senderGrid.RowCount > 0 && nombreColumna == "ESRECIBIDO" &&  senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn  )
                {
                    valorUnico = senderGrid["Unico", senderGrid.CurrentRow.Index].Value.ToString();
                    fila0 = DTTrans.Select("Unico = " + valorUnico)[0];
                    esRecibido = !objUtil.GetAsBoolean("EsRecibido", fila0);
                    fila0["EsRecibido"] = esRecibido;

                    SSQL = "UPDATE TBANCOS_TRANS SET EsRecibido = " + (esRecibido ? "1" : "0");
                    SSQL += " WHERE Unico = " + valorUnico;

                    objDB.EjecutarSQL(SSQL);

                    totalizarTransEnTransito();
                    CalcularBalance();
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

        private void FormBancoConciliacionR_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaHasta.Value = DateTime.Now.Date.AddDays(-1);
                btnGrabar.Enabled = false;
                cboFiltro2.SelectedIndex = 0;

                if (EnEjecusion)
                {
                    addButtonAMenuLateral("ELRBanco.FormBancos");
                    addButtonAMenuLateral("ELRBanco.FormBancosCuentas");
                    addButtonAMenuLateral("ELRBanco.FormBancoTiposTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancosCheques");
                    addButtonAMenuLateral("ELRBanco.FormImprimirCheques");
                    addButtonAMenuLateral("ELRBanco.FormBancosDepositos");
                    addButtonAMenuLateral("ELRBanco.FormOtrasTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancosConsTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancoAnularTrans");
                    
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboTipoAjuste_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoAjuste.SelectedValue != null) txtMontoAjuste.Focus();
        }

        private void btnAgregarAjuste_Click(object sender, EventArgs e)
        {
            DataRow fila0;
            double debito = 0, credito = 0;
            string origen = "D";
            string cuentaContable = "";
            int index = 0;
            try
            {
                if(cboTipoAjuste.SelectedValue != null)
                {
                    if(txtConceptoAjuste.Text.Trim().Length < 5)
                    {
                        objUtil.MostrarMensajeAdvertencia("DEBE INDICAR UN CONCEPTO VALIDO");
                        txtConceptoAjuste.Focus();

                        return;
                    }

                    fila0 = DTTipoAjuste.Select("Tipo = '" + cboTipoAjuste.SelectedValue.ToString() + "'")[0];
                    if(fila0 != null)
                    {
                        origen = objUtil.GetAsString("Origen", fila0).ToUpper();
                        cuentaContable = objUtil.GetAsString("Cuenta_Contable", fila0);

                        if (origen == "D") debito = objUtil.ConvertirANumero(txtMontoAjuste.Text);
                        else credito = objUtil.ConvertirANumero(txtMontoAjuste.Text);

                        if (debito <= 0 && credito <= 0) return;

                        AgregarLineaVacia();
                        detalleFilaActual["Tipo"] = cboTipoAjuste.SelectedValue;
                        detalleFilaActual["Concepto"] = txtConceptoAjuste.Text.Trim();
                        detalleFilaActual["Debito"] = debito;
                        detalleFilaActual["Credito"] = credito;
                        detalleFilaActual["Cuenta_Contable"] = cuentaContable;

                        txtMontoAjuste.Text = "0.00";
                        txtConceptoAjuste.Text = "";

                        index = dtgAjuste.RowCount - 1;
                        if (index > -1)
                        {
                            dtgAjuste.CurrentCell = dtgAjuste["TipoAjuste", index];
                            PostLineaDetalle();
                        }

                        TotalizarDetalle();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void TotalizarDetalle()
        {
            //base.TotalizarDetalle();
            double totalDebito = 0;
            double totalCredito = 0;

            try
            {
                totalDebito = GetSum("Debito", DTDetalle);
                totalCredito = GetSum("Credito", DTDetalle);

                txtNotaDebitoLibro.Text = totalDebito.ToString("N2");
                txtNotaCreditoLibro.Text = totalCredito.ToString("N2");

                lblTotalAjusteConciliacion.Text = "Debito:  " + totalDebito.ToString("N2") +
                                                  "            Credito:  " + totalCredito.ToString("N2");

                //TOTALIZAMOS LA CONCILIACION
                CalcularBalance();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void CalcularBalance()
        {
            double saldoEnBanco = 0;
            double saldoEnLibro = 0;
            double chkEnTransito = 0;
            double depEnTransito = 0;
            double notaDebito = 0;
            double notaCredito = 0;
            double diferencia = 0;

            double saldoConciliadoBanco = 0;
            double saldoConciliadoLibro = 0;

            try
            {
                saldoEnBanco = objUtil.ConvertirANumero(txtBalanceBanco.Text);
                chkEnTransito = objUtil.ConvertirANumero(txtChkEnTransito.Text);
                depEnTransito = objUtil.ConvertirANumero(txtDepTransito.Text);

                saldoConciliadoBanco = saldoEnBanco + (depEnTransito - chkEnTransito);

                saldoEnLibro = objUtil.ConvertirANumero(txtBalanceLibro.Text);
                notaDebito = objUtil.ConvertirANumero(txtNotaDebitoLibro.Text);
                notaCredito = objUtil.ConvertirANumero(txtNotaCreditoLibro.Text);

                saldoConciliadoLibro = saldoEnLibro + (notaDebito - notaCredito);

                diferencia = saldoConciliadoBanco - saldoConciliadoLibro;

                txtBceConciliadoBanco.Text = saldoConciliadoBanco.ToString("N2");
                txtBceConciliadoLibro.Text = saldoConciliadoLibro.ToString("N2");
                txtDiferencia.Text = diferencia.ToString("N2");

                btnGrabar.Enabled = (Math.Abs(diferencia) == 0) && (saldoConciliadoBanco != 0 || saldoConciliadoLibro != 0);
                btnSiguientePage.Enabled = (saldoConciliadoBanco != 0 || saldoConciliadoLibro != 0);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message, "ERROR AL CALCULAR BALANCE");
            }
        }

        private void dtgAjuste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dtgAjuste.RowCount > 0)
                {
                    if(dtgAjuste.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        EliminarLineaDetalleTemp();
                        TotalizarDetalle();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtBalanceBanco_Leave(object sender, EventArgs e)
        {
            CalcularBalance();
        }

        private void btnSiguientePage_Click(object sender, EventArgs e)
        {
            try
            {
                MensajePregunta = "¿Esta Seguro de Grabar Conciliacion TEMPORAL?";

                esTemporal = true;
                SetValorEncabezado("EsConciliado", false);

                GrabarDatos();
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                esTemporal = false;
            }
        }

        public override int GrabarDatos()
        {
            int resultado = -1;

            try
            {

                if (!esTemporal)
                {
                    MensajePregunta = "¿Esta Seguro de Grabar la CONCILIACION?";
                    SetValorEncabezado("EsConciliado", true);
                }

                resultado = base.GrabarDatos();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                esTemporal = false;
            }

            return resultado;
        }

        private void FormBancoConciliacionR_Activated(object sender, EventArgs e)
        {
            if (!esNuevo)
            {
                
                CalcularBalance();
            }
        }

        private void txtNumeroABuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) FiltrarTrans();
        }

        private void cboFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = cboFiltro2.SelectedIndex;

                if (index >= 0)
                {
                    if (index == 0)
                    {
                        txtNumeroABuscar.Text = "";
                        txtNumeroABuscar.ReadOnly = true;
                    }
                    else
                    {
                        if (index == 1) txtNumeroABuscar.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
                        else txtNumeroABuscar.Formato = WinControl_ELR_NET.tbFormato.Decimal;

                        txtNumeroABuscar.ReadOnly = false;
                        txtNumeroABuscar.Focus();
                    }

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCHKTransitos_Click(object sender, EventArgs e)
        {
            string titulo = "";
            DataTable DTData;
            Button btn;
            WinControl_ELR_NET.ELRFormPreviewRDLC frmReporte = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btn = (Button)sender;
                
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Cuenta_Id", cuentaId.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroMayorOIgualA("Numero", "1");
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFechaHasta.Value).ToString());
                objDB.AddFiltroPersonalizado("IsNull(Conciliacion_Id, 0) = 0");
                objDB.AddFiltroPersonalizado("IsNull(EsRecibido, 0) = 0");
                objDB.AddFiltroOrderBY("Numero, Fecha");

                if(btn == btnCHKTransitos)
                {
                    objDB.AddFiltroIgualA("Tipo", "CHK");
                    titulo = "LISTADO CHEQUES EN TRANSITO";
                }
                else
                {
                    objDB.AddFiltroEmpieceEN ("Tipo", "DEP");
                    titulo = "LISTADO DEPOSITOS EN TRANSITO";
                }

                DTData = objDB.GetAll("VBANCOS_TRANS", -1, objDB.Filtros);

                titulo += ", A FECHA: " + objUtil.GetDateAsString(dtpFechaHasta.Value);
                titulo += ", [" + cboCuenta.Text + " - " + lblCuentaNumero.Text + "]";

                frmReporte.titulo = titulo;
                frmReporte.pathReporte = "RptBancoTransTransitos";
                frmReporte.nombreUsuario = nombreUsuario;
                frmReporte.oficinaId = OFICINA_ID;
                frmReporte.empresaId = EMPRESA_ID;

                frmReporte.AddDS("DSData", DTData);

                frmReporte.ShowDialog();


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmReporte.Dispose();
            }
        }

        private void cboCuenta_SelectedValueChanged(object sender, EventArgs e)
        {
            string valorId = "";
            DataRow fila0;
            try
            {
                if(cboCuenta.SelectedValue != null)
                {
                    valorId = cboCuenta.SelectedValue.ToString();
                    fila0 = DTCuentas.Select("Cuenta_Id = " + valorId)[0];

                    lblCuentaNumero.Text = objUtil.GetAsString("Numero", fila0, "00000000");
                    lblCuentaContable.Text = objUtil.GetAsString("Cuenta_Contable", fila0, "00000000");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
