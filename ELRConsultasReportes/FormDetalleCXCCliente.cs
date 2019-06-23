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
    public partial class FormDetalleCXCCliente : WinControl_ELR_NET.FormPlantillaIndex
    {
        public DataRow filaEntidad = null;

        int entidadId = 0;
        string cedulaRNC = "", nombre = "";
        string direccion = "", telefono1 = "", telefono2 = "", email = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int index = 0;
            DataRow fila0;
            int facturaNo = 0;
            FormFacturaDetalle frm = new FormFacturaDetalle();
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.RowCount <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];

                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Cursor = Cursors.WaitCursor;
                    facturaNo = objUtil.GetAsInt("Factura_No", fila0);
                    frm.facturaNo = facturaNo;
                    frm.ShowDialog();
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                frm.Dispose();
            }
        }

        private void FormDetalleCXCCliente_Load(object sender, EventArgs e)
        {
            GetData();
        }

        double balanceCXC = 0;

        public FormDetalleCXCCliente()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {

            double balance, capital, interes, demora;
            try
            {
                Cursor = Cursors.WaitCursor;

                entidadId = objUtil.GetAsInt("Entidad_Id", filaEntidad);
                cedulaRNC = objUtil.GetAsString("CedulaRNC", filaEntidad);
                nombre = objUtil.GetAsString("Nombre_Completo", filaEntidad);
                direccion = objUtil.GetAsString("Direccion", filaEntidad);
                telefono1 = objUtil.GetAsString("Telefono1", filaEntidad);
                telefono2 = objUtil.GetAsString("Telefono2", filaEntidad);
                email = objUtil.GetAsString("EMail", filaEntidad);
                balanceCXC = objUtil.GetAsDouble("Balance_CXC", filaEntidad);

                Text = "FACTURAS PENDIENTE POR COBRAR: " + nombre;
                txtCedulaRNC.Text = cedulaRNC;
                txtNombres.Text = nombre;
                txtDireccion.Text = direccion;
                txtTelefono1.Text = telefono1;
                txtTelefono2.Text = telefono2;
                txtEMail.Text = email;
                txtBalance.Text = balanceCXC.ToString("N2");

                //Buscamos las Facturas Pendiente de Pago
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Entidad_Id", entidadId.ToString());
                objDB.AddFiltroMayorA("Monto", "0");
                objDB.AddFiltroMayorA("Balance", "0");
                objDB.AddFiltroNoIgualA("Estatus_Id", "N");
                MyData = objDB.GetAll("TPRESTAMOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

                balance = GetSum("Balance");
                capital = GetSum("Capital_Pendiente");
                interes = GetSum("Interes_Pendiente");
                demora = GetSum("Demora_Pendiente");

                lblCantidadRegistro.Text = "Monto Pendiente: " + capital.ToString("N2");
                lblCantidadRegistro.Text += "     +Interes: " + interes.ToString("N2");
                lblCantidadRegistro.Text += "     +Demora: " + demora.ToString("N2");
                lblCantidadRegistro.Text += "     = " + balance.ToString("N2");


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
    }
}
