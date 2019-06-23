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
    public partial class FormBancoAnularTrans : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormBancoAnularTrans()
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
                if ((chkPorCuenta.Checked) && (cboCuenta.SelectedValue != null))
                {
                    valorId = int.Parse(cboCuenta.SelectedValue.ToString());
                    if (valorId > 0) objDB.AddFiltroIgualA("Cuenta_Id", valorId.ToString());
                }

                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroPersonalizado("EsNulo = 0");

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

        private void FormBancoAnularTrans_Load(object sender, EventArgs e)
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
            string valorId = "0";
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            FormBancoAnularTransR frm = new FormBancoAnularTransR();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if(DataGridConsulta.RowCount > 0 && DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn )
                {
                   
                    if (SPCargarATemporal.Trim() != "")
                    {
                        valorId = DataGridConsulta["Trans_Id", DataGridConsulta.CurrentRow.Index].Value.ToString();
                        temporalId = objUtil.GetTemporalID();
                        //Agregamos Parametros Para Ejecutar el SP PARA CARGAR A TEMPORAL
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("Id", valorId));
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("esModificar", false));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP(SPCargarATemporal.Trim(), MyParametros);
                        if (spReturn < 0)
                        {
                            //MOSTRAMOS ERRORES DEL SISTEMA
                            MostrarErrorTemporal(temporalId);
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            //Invocamos el Formulario para anular
                            frm.nombreUsuario = nombreUsuario;
                            frm.EMPRESA_ID = empresaID;
                            frm.OFICINA_ID = oficinaID;
                            frm.VALOR_ID = valorId;
                            frm.temporalID = temporalId;
                            frm.EnEjecusion = true;

                            frm.ShowDialog();
                            if (frm.lOK) RealizarBusquedaSencilla();
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
