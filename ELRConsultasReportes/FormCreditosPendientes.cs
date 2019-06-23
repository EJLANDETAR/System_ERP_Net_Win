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
    public partial class FormCreditosPendientes : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCreditosPendientes()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            
            double capital = 0, interes = 0, demora = 0, otros = 0;
            double saldo = 0;
            int cantidad = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroNoIgualA("Estatus_Id", "N");
                objDB.AddFiltroNoIgualA("Estatus_Id", "R");
                objDB.AddFiltroMayorOIgualA("Balance", "1");

                MyData = objDB.GetAll("TPRESTAMOS", -1, objDB.Filtros);
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

                Cursor = Cursors.Default;
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
            string pathReporte = "";
            DateTime fecha = DateTime.Now.Date;
            try
            {

                pathReporte = objUtil.GetPathReportRDLC("RptCreditosPorCobrar");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "LISTADO DE CREDITOS POR COBRAR A FECHA: " + objUtil.GetDateAsString(fecha);
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

        private void FormCreditosPendientes_Load(object sender, EventArgs e)
        {
            GetData();
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
