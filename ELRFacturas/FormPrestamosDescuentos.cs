using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormPrestamosDescuentos : WinControl_ELR_NET.ELRFormRegistro
    {

        double total = 0;
        public string entidadId = "0";
        public string cedulaRNC = "";
        public string ANombre = "";

        public FormPrestamosDescuentos()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
           
            try
            {
                lblEntidadId.Text = entidadId.PadLeft(6, '0') + "     Cedula\\RNC: " + cedulaRNC;
                lblNombreCompleto.Text = ANombre;

                resultado = base.GetData();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        void DescontarTodo()
        {
          

            double interesPendiente = 0;
            double demoraPendiente = 0;
            double otrosPendiente = 0;

            try
            {
                foreach (DataRow item in DTDetalle.Rows)
                {
                    interesPendiente = objUtil.GetAsDouble("Interes_Pendiente", item);
                    demoraPendiente = objUtil.GetAsDouble("Demora_Pendiente", item);
                    otrosPendiente = objUtil.GetAsDouble("Otros_Pendiente", item);

                    if (interesPendiente > 0) item["D_Interes"] = interesPendiente;
                    if (demoraPendiente > 0) item["D_Demora"] = demoraPendiente;
                    if (otrosPendiente > 0) item["D_Otros"] = otrosPendiente;

                    //Actualizamos el Detalle
                    ActualizarDetalleFormRow(item);
                    

                }

                TotalizarDetalle();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnDescontarTodo_Click(object sender, EventArgs e)
        {
            DescontarTodo();
        }

        public override void TotalizarDetalle()
        {
            object calcObject;
            double totalInteres = 0;
            double totalDemora = 0;
            double totalOtros = 0;

            try
            {
                //base.TotalizarDetalle();

                calcObject = DTDetalle.Compute("Sum(D_Interes)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalInteres = double.Parse(calcObject.ToString());
                }

                calcObject = DTDetalle.Compute("Sum(D_Demora)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalDemora = double.Parse(calcObject.ToString());
                }

                calcObject = DTDetalle.Compute("Sum(D_Otros)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalOtros = double.Parse(calcObject.ToString());
                }

                total = totalInteres + totalDemora + totalOtros;

                SetValorEncabezado("Total_Interes", totalInteres);
                SetValorEncabezado("Total_Demora", totalDemora);
                SetValorEncabezado("Total_Otros", totalOtros);
                SetValorEncabezado("Total", total);

                lblTotalInteres.Text = totalInteres.ToString("C2");
                lblTotalDemora.Text = totalDemora.ToString("C2");
                lblTotalOtros.Text = totalOtros.ToString("C2");
                lblTotal.Text = total.ToString("C2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Totalizar, " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorUnico = 0;
            DataRow myFila = null;
            FormPrestamosDescuentosR frm = new FormPrestamosDescuentosR();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = int.Parse(senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString());

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = DTDetalle.Select("Unico = " + valorUnico.ToString())[0];

                    frm.Fila = myFila;
                    frm.ShowDialog();

                    if (frm.LOK)
                    {
                        TotalizarDetalle();
                        ActualizarDetalleFormRow(myFila);

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

        public override int GrabarDatos()
        {
            int resultado = -1;
            try
            {
                if (total <= 0) objUtil.MostrarMensajeAdvertencia("Debe Indicar los Valores a Descontar");
                else if (txtConcepto.Text.Trim().Length < 10) objUtil.MostrarMensajeAdvertencia("Debe Indicar un Concepto, Minimo 15 Caracteres");
                else resultado = base.GrabarDatos();
            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

    }
}
