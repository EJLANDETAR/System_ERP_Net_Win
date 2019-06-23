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
    public partial class FormFacturasPorCobrar : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormFacturasPorCobrar()
        {
            InitializeComponent();
        }

        void GetEntidad(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Entidad_Id, Nombres, Apellidos FROM TCLASIFICADOR_ENTIDADES";
                    SSQL += " WHERE Cast(Entidad_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Entidad_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCodigo.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            GetEntidad();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEntidad();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEntidad(codigo);
        }

        public override void GetData(int opcion = 0)
        {
            int entidadId = 0;
            double total = 0, capitalPendiente = 0, demoraPendiente = 0, balance = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                int.TryParse(txtCodigo.Text, out entidadId);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroNoIgualA("Estatus_Id", "N");
                objDB.AddFiltroMayorA("Monto", "0");
                objDB.AddFiltroMayorA("Balance", "0");
                objDB.AddFiltroMayorA("Factura_No", "0");

                if (entidadId > 0) objDB.AddFiltroIgualA("Entidad_Id", entidadId.ToString());

                MyData = objDB.GetAll("TPRESTAMOS", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total = GetSum("Monto");
                capitalPendiente = GetSum("Capital_Pendiente");
                demoraPendiente = GetSum("Demora_Pendiente");
                balance = GetSum("Balance");

                lblCantidadRegistro.Text = "Monto Pendiente: " + capitalPendiente.ToString("N2");
                lblCantidadRegistro.Text += "        +Demora: " + demoraPendiente.ToString("N2");
                lblCantidadRegistro.Text += "        =Balance: " + balance.ToString("N2");

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
                pathReporte = objUtil.GetPathReportRDLC("RptCuentasPorCobrarVentas");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "FACTURAS PENDIENTE POR COBRAR A FECHA: " + objUtil.GetDateAsString(fecha);
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
            string valorUnico = "0";
            int index = 0;
            DataRow fila0 = null;
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
                    frm.fila0 = fila0;
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

        private void FormFacturasPorCobrar_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
