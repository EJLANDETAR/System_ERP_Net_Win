using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormNotaDebitoCreditoACXP : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormNotaDebitoCreditoACXP()
        {
            InitializeComponent();
        }

        private void FormNotaDebitoCreditoACXP_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            try
            {
                dtpFecha1.Value = objUtil.getPrimeraFechaMes(fecha);
                dtpFecha2.Value = fecha;

                cboTipo.Items.Add("(TODOS)");
                cboTipo.Items.Add("NOTA DE DEBITO");
                cboTipo.Items.Add("NOTA DE CREDITO");
                cboTipo.SelectedIndex = 0;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            int fechaDesde, fechaHasta;
            try
            {
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                objDB.AddFiltroMayorOIgualA("fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("fecha", fechaHasta.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");

                if (cboTipo.SelectedIndex <= 0) objDB.AddFiltroPersonalizado("Modulo in ('ND', 'NC')");
                else if (cboTipo.SelectedIndex == 1) objDB.AddFiltroIgualA("Modulo", "ND");
                else if (cboTipo.SelectedIndex <= 2) objDB.AddFiltroIgualA("Modulo", "NC");

                base.GetData(opcion);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = -1;
            string valorUnico = "0", concepto = "";
            DataRow fila0;
            try
            {
                txtConcepto.Text = "";

                if (DataGridConsulta.RowCount <= 0) return;
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;

                if (index >= MyData.Rows.Count) index = MyData.Rows.Count - 1;

                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                concepto = objUtil.GetAsString("Concepto", fila0);

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0", temporalId = "", tipo, numero;
            DataRow fila0 = null;
            int id = 0, index = 0, spReturn = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;

                Cursor = Cursors.WaitCursor;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                id = objUtil.GetAsInt("CXP_Id", fila0, 0);
                tipo = objUtil.GetAsString("Modulo", fila0);
                numero = objUtil.GetAsString("Factura_Numero", fila0);

                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    //PROCEDEMOS A ELIMINAR
                    if(objUtil.MostrarMensajePregunta("Esta seguro que desea anular " + tipo + ": " + numero) == DialogResult.Yes)
                    {
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Id", id));
                        parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                        //Iniciamos una transaccion de Base de Datos
                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_COMPRAS_ANULAR_NOTA_DEBITO_CREDITO", parms);
                        if (spReturn <= 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            RealizarBusquedaSencilla();
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
                Cursor = Cursors.Default;
            }
        }
    }
}
