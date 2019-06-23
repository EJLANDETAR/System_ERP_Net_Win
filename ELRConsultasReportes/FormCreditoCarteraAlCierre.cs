using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormCreditoCarteraAlCierre : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTTotal = null;

        public FormCreditoCarteraAlCierre()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {

            double capital = 0, interes = 0, demora = 0, otros = 0;
            double saldo = 0;
            int cantidad = 0;
            int fecha = 0;
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            try
            {
                Cursor = Cursors.WaitCursor;
                fecha = objUtil.DateToInt(dtpFechaCierre.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("Fecha", fecha.ToString());
                objDB.AddFiltroMayorOIgualA("Balance", "1");

                MyData = objDB.GetAll("TPRESTAMOS_BALANCE_CIERRE", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                cantidad = MyData.Rows.Count;
                capital = GetSum("Capital_Pendiente");
                interes = GetSum("Interes_Pendiente");
                demora = GetSum("demora_Pendiente");
                otros = GetSum("Otros_Pendiente");
                saldo = GetSum("Balance");

                lblCantidadRegistro.Text = "Cantidad: " + cantidad.ToString();
                lblCantidadRegistro.Text += ",   Capital P: " + capital.ToString("N2");
                lblCantidadRegistro.Text += "   +Interes P: " + interes.ToString("N2");
                lblCantidadRegistro.Text += "   +Demora P: " + demora.ToString("N2");
                lblCantidadRegistro.Text += "   +Otros P: " + otros.ToString("N2");
                lblCantidadRegistro.Text += "   +Saldo: " + saldo.ToString("N2");

                //Procedemos a Total Para Mostrar Grafico
                temporalId = objUtil.GetTemporalID();
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                parms.Add(new DataDB_ELR_NET.Parametro("AFecha", fecha));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_TOTAL_BALANCE_CARTERA", parms);
                if(spReturn < 0)
                {
                    MostrarErrorTemporal(temporalId);
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    DTTotal = objDB.GetById("TTEMPORAL_PRESTAMOS_BALANCE_TOTAL", temporalId, "IdentificadorTemp");
                    objDB.LimpiarDetalleTemporal("TTEMPORAL_PRESTAMOS_BALANCE_TOTAL", temporalId);
                }


                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FormCreditoCarteraAlCierre_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFechaCierre.Value = fecha.AddDays(-1);

            GetData();
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            
            try
            {

                pathReporte = objUtil.GetPathReportRDLC("RptCarteraBalance");

                frm.pathReporte = pathReporte;
                //frm.DTData = MyData;
                frm.AddDS("DSTotal", DTTotal);
                frm.AddDS("DSData", MyData);
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "CARTERA DE CREDITO A FECHA: " + objUtil.GetDateAsString(dtpFechaCierre.Value);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico;
            DataRow myFila;
            FormConsultaPrestamosDetalle frm = new FormConsultaPrestamosDetalle();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    frm.prestamoId = myFila["Prestamo_Id"].ToString();
                    frm.nombreUsuario = nombreUsuario;

                    frm.ShowDialog();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm = null;
                myFila = null;
            }
        }
    }
}
