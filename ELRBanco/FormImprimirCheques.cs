using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRBanco
{
    public partial class FormImprimirCheques : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormImprimirCheques()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FormImprimirCheques_Load(object sender, EventArgs e)
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

                //LISTAMOS LAS IMPRESORAS DISPONIBLE PARA IMPRIMIR CHEQUES
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cboImpresora.Items.Add(printer);
                }

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
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
            Int32 numero = -1;

            try
            {
                if (cboCuenta.SelectedValue != null)
                {
                    valorId = int.Parse(cboCuenta.SelectedValue.ToString());
                    if (valorId > 0) objDB.AddFiltroIgualA("Cuenta_Id", valorId.ToString());
                }


                numero = GetSiguienteNumero();
                txtProxNumero.Text = numero.ToString();

                base.GetData(opcion);

                tsbImprimir.Enabled = (MyData.Rows.Count > 0);
                btnImprimir.Enabled = (MyData.Rows.Count > 0);
                cboImpresora.Enabled = (MyData.Rows.Count > 0);
                txtProxNumero.Enabled = (MyData.Rows.Count > 0) && (numero <= 1);
                txtCantidad.Text = MyData.Rows.Count.ToString();

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

        Int32 GetSiguienteNumero()
        {
            int cuentaId = 0;
            int numero = -1;
            DataTable DTData = null;
            string SSQL = "";
            try
            {
                if (cboCuenta.SelectedValue != null) cuentaId = int.Parse(cboCuenta.SelectedValue.ToString());

                if (cuentaId > 0)
                {
                    SSQL = " SELECT IsNull(MAX(Numero), 0) + 1 as Numero FROM TBANCOS_TRANS ";
                    SSQL += " WHERE Cuenta_Id = " + cuentaId;
                    SSQL += "      And(Tipo = 'CK' Or Tipo = 'CHK') ";

                    DTData = objDB.GetSQL(SSQL);
                    numero = objUtil.GetAsInt("Numero", DTData.Rows[0]);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return numero;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            Int32 numero = 0;
            int cantidad = 0;
            int conteo = 0;
            Int32 valorId = 0;
            ELRLogicaNegocio.Bancos lBanco = new ELRLogicaNegocio.Bancos();


            try
            {
                cantidad = int.Parse(txtCantidad.Text);
                numero = Int32.Parse(txtProxNumero.Text);
                lBanco.db = objDB;
                lBanco.nombreImpresora = cboImpresora.Text;

                if (cboImpresora.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("Debe Seleccionar una Impresora");
                else if (numero <= 0) objUtil.MostrarMensajeError("Debe Indicar el Proximo Numero de Cheque a Imprimir");
                else if (objUtil.MostrarMensajePregunta("Cantidad de Cheques a Imprimir: " + cantidad.ToString() + "\r\r" + "Esta Seguro de Imprimir?") == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;

                    objDB.iniciarTransaccion();

                    foreach (DataRow fila0 in MyData.Rows)
                    {
                        valorId = Int32.Parse(fila0["Trans_Id"].ToString());
                        numero = lBanco.ImprimirCheque(valorId);
                        conteo++;
                        if (numero < 0) break;

                        if (conteo >= cantidad) break;

                        numero++;
                    }

                    if (numero < 0) objDB.cancelarTransaccion();
                    else objDB.confirmarTransaccion();

                    GetData();
                }


            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objDB.cancelarTransaccion();
                this.Cursor = Cursors.Default;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int index = 0, numero = 0, conteo = 0;
            Int32 valorId = 0;
            DataRow fila0;
            ELRLogicaNegocio.Bancos lBanco = new ELRLogicaNegocio.Bancos();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                valorId = Int32.Parse(fila0["Trans_Id"].ToString());
                numero = objUtil.GetAsInt("Numero", fila0);

                lBanco.db = objDB;
                lBanco.nombreImpresora = cboImpresora.Text;

                if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    //VALIDAMOS SE HAYA SELECCIONADO UNA IMPRESORA
                    if (cboImpresora.Text.Trim() == "")
                    {
                        objUtil.MostrarMensajeAdvertencia("Debe Seleccionar una Impresora");
                        return;
                    }

                    //VALIDAMOS SI EXISTEN OTROS CHEQUES YA ENUMERADOS SERA IMPOSIBLE IMPRIMIR ESTE INDIVIDUAL
                    conteo = GetCount("Unico", "Numero <> 0");
                    if (conteo > 0)
                    {
                        objUtil.MostrarMensajeAdvertencia("IMPOSIBLE IMPRIMIR CHEQUE INDIVIDUAL, YA EXISTEN CHEQUES ENUMERADOS...");
                        return;
                    }

                    if (objUtil.MostrarMensajePregunta("Esta Seguro de Imprimir este cheque?") == DialogResult.Yes)
                    {
                        numero = lBanco.ImprimirCheque(valorId);
                        if (numero > 0) GetData();
                    }   
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
