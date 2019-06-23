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
    public partial class FormFacturaDevolucionesR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormFacturaDevolucionesR()
        {
            InitializeComponent();
        }

        private void lblFacturaNo_Click(object sender, EventArgs e)
        {

        }

        public override bool GetData()
        {
            bool resultado = false;
            string facturaNO = "0";
            string cedulaRNC = "";
            string ANombre = "";
            string NCF = "0";
            DataRow MyFila = null;
            try
            {
                resultado = base.GetData();
                if (resultado)
                {
                    MyFila = DSDatos.Tables[0].Rows[0];
                    facturaNO = objUtil.GetAsString("Factura_No", MyFila, "0");
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", MyFila, "");
                    ANombre = objUtil.GetAsString("ANombre", MyFila, "");
                    NCF = objUtil.GetAsString("NCF_Modificado", MyFila, "0000000000000000000");

                    //Mostramos los Datos
                    lblFacturaNo.Text = facturaNO.PadLeft(8, '0');
                    lblCedulaRNC.Text = cedulaRNC;
                    lblNombreCompleto.Text = ANombre;
                    lblNCF.Text = NCF;

                    this.Text = "REGISTRAR DEVOLUCION, FACTURA NO.: " + facturaNO.PadLeft(8, '0');

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }

            return resultado;
        }

        public override void TotalizarDetalle()
        {
            double subTotal = 0, totalItbis = 0, total = 0;
            try
            {
                //base.TotalizarDetalle();
                subTotal = GetSumDetalle("Sub_Total");
                totalItbis = GetSumDetalle("Itbis");
                total = GetSumDetalle("Total");

                SetValorEncabezado("Sub_Total", subTotal);
                SetValorEncabezado("Total_Itbis", totalItbis);
                SetValorEncabezado("Total", total);

                lblSubTotal.Text = subTotal.ToString("N2");
                lblItbis.Text = totalItbis.ToString("N2");
                lblTotal.Text = total.ToString("N2");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormFacturaDevolucionesR_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvDetalle.ReadOnly = false;
                foreach (DataGridViewColumn item in dtgvDetalle.Columns)
                {
                    if (item.Name.ToUpper() == "CANTIDAD_ADEVOLVER") item.ReadOnly = false;
                    else item.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }
        }

        void DevolverTodo()
        {


            double cantidad = 0;
            double tasaItbis = 0;
            double precio = 0;
            double itbis = 0;
            double subTotal = 0;
            double total = 0;


            try
            {
                foreach (DataRow item in DTDetalle.Rows)
                {
                    cantidad = objUtil.GetAsDouble("Cantidad", item);
                    tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", item);
                    precio = objUtil.GetAsDouble("Precio", item);

                    //CALCULAMOS PRECIO SIN ITBIS
                    tasaItbis = tasaItbis / 100.0;
                    precio = precio / (1 + tasaItbis);

                    subTotal = cantidad * precio;
                    tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", item);
                    itbis = (subTotal * tasaItbis) / 100.0;
                    total = subTotal + itbis;

                    item["Cantidad_ADevolver"] = cantidad;
                    item["Sub_Total"] = subTotal;
                    item["Itbis"] = itbis;
                    item["Total"] = total;

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

        private void btnDevolverTodo_Click(object sender, EventArgs e)
        {
            DevolverTodo();
        }

        private void dtgvDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = "";
            bool IsDec = false;
            int nroDec = 0;
            try
            {
                DataGridViewCell celda = dtgvDetalle.CurrentCell;
                if (celda != null)
                {
                    if (celda.ReadOnly == false)
                    {
                        valor = celda.Value.ToString().Trim();

                        for (int i = 0; i < valor.Length; i++)
                        {
                            if (valor[i] == '.')
                                IsDec = true;

                            if (IsDec && nroDec++ >= 2)
                            {
                                e.Handled = true;
                                return;
                            }
                        }

                        if (e.KeyChar >= 48 && e.KeyChar <= 57)
                            e.Handled = false;
                        else if (e.KeyChar == 46)
                            e.Handled = (IsDec) ? true : false;
                        else
                            e.Handled = true;

                    }
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgvDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewCell celda;
            try
            {
                celda = dtgvDetalle.CurrentCell;
                if (celda != null)
                {

                    TextBox txt = e.Control as TextBox;

                    if (txt != null)
                    {
                        //txt.KeyPress -= new KeyPressEventHandler(dtgvDetalle_KeyPress);
                        //txt.KeyPress += new KeyPressEventHandler(dtgvDetalle_KeyPress);
                    }

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            string valorUnico = "0";
            DataRow item = null;
            double cantidad, tasaItbis, precio;
            double itbis, subTotal, total;

            try
            {
                index = dtgvDetalle.CurrentRow.Index;
                valorUnico = dtgvDetalle["unico", index].Value.ToString();
                item = DTDetalle.Select("Unico = " + valorUnico)[0];

                cantidad = objUtil.GetAsDouble("Cantidad_ADevolver", item);
                tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", item);
                precio = objUtil.GetAsDouble("Precio", item);

                //CALCULAMOS PRECIO SIN ITBIS
                tasaItbis = tasaItbis / 100.0;
                precio = precio / (1 + tasaItbis);

                subTotal = cantidad * precio;
                tasaItbis = objUtil.GetAsDouble("Tasa_Itbis", item);
                itbis = (subTotal * tasaItbis) / 100.0;
                total = subTotal + itbis;

                item["Cantidad_ADevolver"] = cantidad;
                item["Sub_Total"] = subTotal;
                item["Itbis"] = itbis;
                item["Total"] = total;

                //Actualizamos el Detalle
                ActualizarDetalleFormRow(item);

                TotalizarDetalle();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


    }
}
