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
    public partial class FormFacturaEditItem : Form
    {
        public DataRow MyFila = null;
        public bool lOK = false;

        WinControl_ELR_NET.ELRUtils util = new WinControl_ELR_NET.ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        DataRow DRProducto = null;

        bool esExcentoItbis = false, esItbisIncluido = false;
        double cantidad, precioSinItbis, precio, precioMinimo;
        double subTotal, tasaItbis, itbis, monto;

        bool esProcesada = false;
        bool valido = true;

        public FormFacturaEditItem()
        {
            InitializeComponent();
        }

        private void FormFacturaEditItem_Load(object sender, EventArgs e)
        {
            string productoId = "0";
            string descripcion = "";
            string codigoBarra = "";
            DataTable DTData = null;

            try
            {
                lOK = false;
                esProcesada = false;

                productoId = util.GetAsString("Producto_Id", MyFila, "0");
                descripcion = util.GetAsString("Descripcion", MyFila, "0");
                DTData = db.GetById("VCATEGORIA_PRODUCTOS", productoId, "Producto_Id");
                DRProducto = DTData.Rows[0];
                precioMinimo = util.GetAsDouble("PrecioM", DRProducto);
                codigoBarra = util.GetAsString("Codigo_Barra", DRProducto);

                esExcentoItbis = util.GetAsBoolean("EsExcentoItbis", DRProducto);
                esItbisIncluido = util.GetAsBoolean("precioConItbis", DRProducto);

                cantidad = util.GetAsDouble("Cantidad", MyFila);
                precioSinItbis = util.GetAsDouble("Precio_Sin_Itbis", MyFila);
                precio = util.GetAsDouble("Precio", MyFila);

                subTotal = util.GetAsDouble("Sub_Total", MyFila);
                tasaItbis = util.GetAsDouble("Tasa_Itbis", MyFila);
                itbis = util.GetAsDouble("Itbis", MyFila);
                monto = util.GetAsDouble("Monto", MyFila);


                if (codigoBarra.Trim() != "") descripcion += "; CODIGO: " + codigoBarra;

                descripcion += "; PRECIO MINIMO: " + precioMinimo.ToString("N2");

                txtDescripcion.Text = descripcion;

                txtCantidad.Text = cantidad.ToString("N2");
                txtPrecio.Text = precio.ToString("N2");
                txtPrecioSinItbis.Text = precioSinItbis.ToString("N2");
                lblSubTotal.Text = subTotal.ToString("N2");
                lblItbis.Text = itbis.ToString("N2");
                lblMonto.Text = monto.ToString("N2");

            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
                Close();
            }
            finally
            {
                DTData = null;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            bool esSinItbis = false;
            esSinItbis = ((TextBox)sender) == txtPrecioSinItbis;
            Procesar(esSinItbis);
        }


        void Procesar(bool esSinItbis = false)
        {
            double nuevoPrecio = 0;

            try
            {
                esProcesada = false;
                valido = true;
                nuevoPrecio = double.Parse(txtPrecio.Text);

                if (esSinItbis)
                {
                    precioSinItbis = double.Parse(txtPrecioSinItbis.Text);
                    nuevoPrecio = precioSinItbis + ( precioSinItbis * (tasaItbis / 100.0) );
                    txtPrecio.Text = nuevoPrecio.ToString("N2");
                }
                
                if ((nuevoPrecio < precioMinimo) || (nuevoPrecio <= 0))
                {
                    util.MostrarMensajeAdvertencia("NO ESTA PERMITIDO FACTURAR POR DEBAJO DEL MINIMO: " + precioMinimo.ToString("N2"));
                    nuevoPrecio = precio;
                    txtPrecio.Text = nuevoPrecio.ToString("N2");

                    valido = false;
                }

                cantidad = util.ConvertirANumero(txtCantidad.Text);

                esItbisIncluido = util.GetAsBoolean("precioConItbis", DRProducto);
                precioSinItbis = nuevoPrecio;
                precioSinItbis = Math.Round(precioSinItbis / (1 + tasaItbis / 100.0), 2);
                itbis = nuevoPrecio - precioSinItbis;

                /*
                if ((esItbisIncluido) && (esExcentoItbis == false))
                {
                    precioSinItbis = Math.Round(precioSinItbis / (1 + tasaItbis / 100.0), 2);
                    itbis = nuevoPrecio - precioSinItbis;
                }
                else if (esExcentoItbis == false)
                {
                    itbis = precioSinItbis * (tasaItbis / 100.0);
                    nuevoPrecio = precioSinItbis + itbis;
                }
                */
                subTotal = cantidad * precioSinItbis;
                itbis = cantidad * itbis;
                monto = cantidad * nuevoPrecio;

                txtPrecioSinItbis.Text = precioSinItbis.ToString("N2");
                lblSubTotal.Text = subTotal.ToString("N2");
                lblItbis.Text = itbis.ToString("N2");
                lblMonto.Text = monto.ToString("N2");

                esProcesada = true;

            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esProcesada) Procesar();

                if (valido)
                {
                    MyFila["Cantidad"] = cantidad;
                    MyFila["Precio_Sin_Itbis"] = precioSinItbis;
                    MyFila["Precio"] = util.ConvertirANumero(txtPrecio.Text);
                    MyFila["Sub_Total"] = subTotal;
                    MyFila["Itbis"] = itbis;
                    MyFila["Monto"] = monto;

                    lOK = true;
                    Close();
                }
                else
                {
                    txtPrecio.SelectAll();
                    txtPrecio.Focus();
                }
            }
            catch (Exception ex)
            {
                lOK = false;
                MyFila.RejectChanges();

                util.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            esProcesada = false;
        }

    }
}
