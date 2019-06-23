using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormCotizacionesR : WinControl_ELR_NET.ELRFormRegistro
    {
        double precioLista = 0;
        double precioSinItbis, tasaItbis, itbis;
        string nivelPrecio;
        bool esOferta = false;
        bool precioConItbis;

        public FormCotizacionesR()
        {
            InitializeComponent();
        }

        private void cboNivelPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                drProducto = txtProductoId.drFilaSel;
                nivelPrecio = "";
                precioLista = 0;
                precioSinItbis = 0;
                esOferta = false;

                if ( (drProducto != null) && (cboNivelPrecio.SelectedValue != null) )
                {
                    nivelPrecio = cboNivelPrecio.SelectedValue.ToString().ToUpper();

                    if (nivelPrecio == "R") precioLista = objUtil.GetAsDouble("PrecioR", drProducto);
                    else if (nivelPrecio == "A") precioLista = objUtil.GetAsDouble("PrecioA", drProducto);
                    else if (nivelPrecio == "B") precioLista = objUtil.GetAsDouble("PrecioB", drProducto);
                    else if (nivelPrecio == "C") precioLista = objUtil.GetAsDouble("PrecioC", drProducto);
                    else if (nivelPrecio == "D") precioLista = objUtil.GetAsDouble("PrecioD", drProducto);
                    else
                    {
                        precioLista = objUtil.GetAsDouble("PrecioOFerta", drProducto);
                        esOferta = true;
                    }

                    tasaItbis = double.Parse(drProducto["Tasa_Itbis"].ToString());
                    precioConItbis = bool.Parse(drProducto["precioConItbis"].ToString());
                    precioSinItbis = precioLista;

                    if (precioConItbis)
                    {
                        precioSinItbis = precioSinItbis / (1 + tasaItbis / 100.0);
                        itbis = precioLista - precioSinItbis;
                    }
                    else
                    {
                        itbis = precioSinItbis * (tasaItbis / 100.0);
                        precioLista = precioSinItbis + itbis;
                    }


                    lblPrecio.Text = precioLista.ToString("N2");
                    txtCantidad.Text = "1";
                   
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorItemNumero = 0;

            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorItemNumero = int.Parse(senderGrid["ItemNumero", senderGrid.CurrentRow.Index].Value.ToString());

                    EliminarLineaDetalleTemp();
                    txtProductoId.SelectAll();
                    txtProductoId.Focus();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormCotizacionesR_Load(object sender, EventArgs e)
        {
            //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
            addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto");
            addButtonAMenuLateral("ELRMaestros.FormProductos");
            addButtonAMenuLateral("ELRMaestros.FormEntidadesIndex", "Clientes");
            addButtonAMenuLateral("ELRFacturas.FormFacturaReImprimir");
            addButtonAMenuLateral("ELRFacturas.FormAnularFactura");
            addButtonAMenuLateral("ELRFacturas.FormFactCobroPorGrupo", "Abono o pago");
            addButtonAMenuLateral("ELRMaestros.FormEmpleados", "Empleados - Vendedores");
            addButtonAMenuLateral("ELRFacturas.FormVentasNotasCreditos");
            addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII607", "607 DGII");
            addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII608", "608 DGII");
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ( (e.KeyCode == Keys.Enter) && (txtCantidad.Text.Trim() != "") )
                {
                    usaCliente0 = true;
                    AgregarProducto();
                    
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void AgregarProducto()
        {
            DataRow MyFila;
            double cantidad = 1;
            double subTotal = 0, total = 0;
            
            try
            {
                cantidad = double.Parse(txtCantidad.Text);

                if ( (drProducto != null) && (nivelPrecio != "") )
                {

                    subTotal = cantidad * precioSinItbis;
                    itbis = cantidad * itbis;
                    total = cantidad * precioLista;

                    MyFila = DTDetalle.NewRow();
                    MyFila["Producto_Id"] = drProducto["Producto_Id"];
                    MyFila["Descripcion"] = drProducto["Nombre_Corto"];
                    MyFila["Categoria_Id"] = drProducto["Categoria_Id"];
                    MyFila["UMedida_Id"] = drProducto["UMedida_Id"];
                    MyFila["Cantidad"] = cantidad;
                    MyFila["Precio_Sin_Itbis"] = Math.Round(precioSinItbis, 2);
                    MyFila["Precio"] = Math.Round(precioLista, 2);
                    MyFila["Sub_Total"] = Math.Round(subTotal, 2);
                    MyFila["Descuento"] = 0;
                    MyFila["Tasa_Itbis"] = Math.Round(tasaItbis, 2);
                    MyFila["Itbis"] = Math.Round(itbis, 2);
                    MyFila["Monto"] = Math.Round(total, 2);
                    MyFila["EsOferta"] = esOferta;
                    MyFila["Nivel_Precio"] = nivelPrecio;

                    AgregarLineaDetalle(MyFila);
                    txtCantidad.Text = "1";
                }

                precioLista = 0;
                precioSinItbis = 0;
                itbis = 0;
                nivelPrecio = "";

                txtProductoId.Text = "0000";
                txtProductoId.drFilaSel = null;
                drProducto = null;
                cboNivelPrecio.SelectedValue = "";
                txtProductoId.SelectAll();

                txtProductoId.Focus();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            
        }
       
    }
}
