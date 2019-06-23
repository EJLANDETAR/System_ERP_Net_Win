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
    public partial class FormRequisicionesR : WinControl_ELR_NET.ELRFormRegistro
    {
        bool isChangeCodigoP = false;

        public FormRequisicionesR()
        {
            InitializeComponent();
        }

        private void FormRequisicionesR_Load(object sender, EventArgs e)
        {
            try
            {
                //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
                addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto");
                addButtonAMenuLateral("ELRMaestros.FormProductos", "Productos/Servicios");
                addButtonAMenuLateral("ELRMaestros.FormEntidadesIndex", "Suplidores");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormAnularFacturaCompra", "Anular compra");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormInventarioAjuste", "Ajuste Inventario");
                addButtonAMenuLateral("ELRCuentasPorPagar.FormCXP", "Abono o pago CXP");
                addButtonAMenuLateral("ELRConsultasReportes.FormReporteDGII606", "606 DGII");
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void HandleCellKeyDown(object sender, KeyEventArgs e)
        {
            //base.HandleCellKeyDown(sender, e);
            WinControl_ELR_NET.ELRFormBusquedaGeneral frm = new WinControl_ELR_NET.ELRFormBusquedaGeneral();
            WinControl_ELR_NET.MyColumna col;

            try
            {
                if (COLUMNA_ACTUAL_GRID_DETALLE == "PRODUCTO_ID")
                {
                    if (e.KeyCode == Keys.F9)
                    {
                        //Vamos a Buscar el Producto
                        frm.titulo = @"PRODUCTOS Y\O SERVICIOS PARA COMPRA";
                        frm.TablaOVista = "VCATEGORIA_PRODUCTOS";
                        frm.columnas = new WinControl_ELR_NET.MyColumna[2];


                        col = new WinControl_ELR_NET.MyColumna();
                        col.NombreCampo = "Producto_Id";
                        col.HeaderText = "Codigo";
                        col.Ancho = 120;
                        frm.columnas[0] = col;

                        col = new WinControl_ELR_NET.MyColumna();
                        col.NombreCampo = "Nombre_Corto";
                        col.HeaderText = "Nombre";
                        col.Ancho = -1;
                        frm.columnas[1] = col;

                        frm.ShowDialog();

                        if (frm.FilaSelecionada != null)
                        {
                            drProducto = frm.FilaSelecionada;
                            //Mandamos el Focus a la columna Cantidad
                            DataGridDetalle.CurrentCell = DataGridDetalle["Cantidad", DataGridDetalle.CurrentRow.Index];
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
                frm.Dispose();
            }

        }

        public override void MostrarDataEnGrid()
        {
            //base.MostrarDataEnGrid();
            int index = 0;
          
            try
            {
                if (drProducto != null)
                {
                    index = DataGridDetalle.CurrentRow.Index;

                    DataGridDetalle["Descripcion", index].Value = drProducto["Nombre_Corto"];
                    DataGridDetalle["Producto_Id", index].Value = drProducto["Producto_Id"];
                    DataGridDetalle["Cantidad", index].Value = 1;

                    
                    DataGridDetalle.EndEdit();
                    drProducto = null;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboMoneda_SelectedValueChanged(object sender, EventArgs e)
        {
            double tasaCambio = 1.0;
            string codigo = "";
            DataRow fila0 = null;
            try
            {

                if (cboMoneda.SelectedValue != null)
                {
                    codigo = cboMoneda.SelectedValue.ToString();
                    fila0 = cboMoneda.data.Select("Codigo = '" + codigo + "'")[0];
                    tasaCambio = objUtil.GetAsDouble("Valor_Compra", fila0);
                }

                txtTasaCambio.Text = tasaCambio.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        private void AddItem()
        {
            DataRow MyFila;
            double cantidad = 1;
            
            try
            {
                cantidad = objUtil.ConvertirANumero(txtCantidad.Text);

                if (drProducto != null)
                {
                    if (cantidad <= 0)
                    {
                        objUtil.MostrarMensajeAdvertencia("LA CANTIDAD DEBE SER MAYOR A CERO(0)");
                        txtCantidad.Focus();
                        return;
                    }


                    MyFila = DTDetalle.NewRow();
                    MyFila["Producto_Id"] = drProducto["Producto_Id"];
                    MyFila["Descripcion"] = drProducto["Nombre_Corto"];
                    MyFila["Categoria_Id"] = drProducto["Categoria_Id"];
                    MyFila["UMedida_Id"] = drProducto["UMedida_Id"];
                    MyFila["Cantidad"] = cantidad;
                    MyFila["Precio"] = 0;
                    MyFila["Sub_Total"] = 0;
                    MyFila["Descuento"] = 0;
                    MyFila["Tasa_Itbis"] = 0;
                    MyFila["Itbis"] =0;
                    MyFila["Total"] = 0;
                    MyFila["EsExcentoItbis"] = false;
                    MyFila["PrecioConItbis"] = false;

                    AgregarLineaDetalle(MyFila, "Identificador_Id");

                    txtCodigoProducto.Text = "";
                    txtCantidad.Text = "1";
                    drProducto = null;
                    btnAgregarItem.Enabled = false;
                    lblProdDescripcion.BackColor = SystemColors.Control;
                    lblProdDescripcion.Text = @"NOMBRE/DESCRIPCION ITEM VENTA";

                    txtCodigoProducto.Focus();

                }


            }
            catch (Exception ex)
            {

                lblProdDescripcion.Text = "ERROR: " + ex.Message;
                lblProdDescripcion.BackColor = Color.Red;
            }

        }


        void GetProducto(int tipo = 0)
        {
            ELRMaestros.FormProductos frm = new ELRMaestros.FormProductos();
            Int32 codigoNum = 0;
            DataTable DTProductos = null;
            string filtro = "";
            string codigo = "";
            try
            {
                Cursor = Cursors.WaitCursor;
                codigo = txtCodigoProducto.Text.Trim();
                Int32.TryParse(codigo, out codigoNum);
                lblProdDescripcion.BackColor = SystemColors.Control;
                isChangeCodigoP = false;
                drProducto = null;

                if (tipo == 0)
                {
                    codigo = codigo.Trim();
                    filtro = "(Cast(Producto_Id as Varchar) = '" + codigoNum.ToString() + "'";
                    filtro += " Or Codigo_Barra = '" + codigo + "')";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsCompra", "1");
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroPersonalizado(filtro);

                    DTProductos = objDB.GetAll("VCATEGORIA_PRODUCTOS", 1, objDB.Filtros);
                    if (DTProductos.Rows.Count > 0)
                    {
                        drProducto = DTProductos.Rows[0];
                        txtCodigoProducto.Text = "";
                    }
                }

                if (tipo == 1 || (tipo == 0 && codigo != "" && drProducto == null && codigoNum <= 0))
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.Limite = 200;
                    frm.esBusqueda = true;
                    frm.textoABuscar = codigo;
                    frm.FiltroEstatico = "EsActivo = 1 And EsCompra = 1";

                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) drProducto = frm.filaSelecionada;
                }

                if (drProducto != null)
                {
                    lblProdDescripcion.Text = objUtil.GetAsString("Nombre_Corto", drProducto);
                    txtCodigoProducto.Text = objUtil.GetAsString("Producto_Id", drProducto);
                    lblProdDescripcion.BackColor = Color.Green;
                    txtCantidad.Text = "1";
                    btnAgregarItem.Enabled = true;
                    txtCantidad.Focus();
                }
                else
                {
                    lblProdDescripcion.Text = " ITEM CON CODIGO: " + codigo + ", NO EXISTE O NO ESTA DISPONIBLE PARA COMPRA";
                    lblProdDescripcion.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {

                lblProdDescripcion.Text = " ERROR: " + ex.Message;
                lblProdDescripcion.BackColor = Color.Red;
            }
            finally
            {
                Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            GetProducto(1);
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (isChangeCodigoP) GetProducto(0);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) GetProducto(0);
                else if (e.KeyCode == Keys.F9) GetProducto(1);
                else isChangeCodigoP = true;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridDetalle.RowCount > 0)
                {
                    if (DataGridDetalle.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        EliminarLineaDetalleTemp();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetEmpleado()
        {
            string codigo = "";
            DataTable DTEmpleado = null;
            DataRow fila0 = null;
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();
            int departamentoId = 0;
            int empleadoId = 0;
            string nombre = "";
            try
            {
                codigo = txtCodigoEmpleado.Text.Trim();
                if(codigo != "")
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Empleado_Id", codigo);
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIsNull("Fecha_Baja");

                    DTEmpleado = objDB.GetAll("VEMPLEADOS", 1, objDB.Filtros);
                    if (DTEmpleado.Rows.Count > 0) fila0 = DTEmpleado.Rows[0];
                }
                else
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.Limite = 200;
                    frm.esBusqueda = true;
                    frm.FiltroEstatico = "EsActivo = 1 And Fecha_Baja Is Null";

                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                if(fila0 != null)
                {
                    empleadoId = objUtil.GetAsInt("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre_Completo", fila0);
                    departamentoId = objUtil.GetAsInt("Departamento_Id", fila0);

                    txtCodigoEmpleado.Text = empleadoId.ToString();
                    txtNombreEmpleado.Text = nombre;
                    cboDepartamento.SelectedValue = departamentoId;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            txtCodigoEmpleado.Text = "";
            GetEmpleado();
        }

        private void txtCodigoEmpleado_Leave(object sender, EventArgs e)
        {
            if(txtCodigoEmpleado.Text.Trim() != "") GetEmpleado();
        }

        private void txtCodigoEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigoEmpleado.Text.Trim();
            if (e.KeyCode == Keys.Enter && codigo != "") GetEmpleado();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }
    }
}
