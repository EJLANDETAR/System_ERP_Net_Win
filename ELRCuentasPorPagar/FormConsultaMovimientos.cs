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
    public partial class FormConsultaMovimientos : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTTipo = null;

        public FormConsultaMovimientos()
        {
            InitializeComponent();
        }

        private void FormConsultaMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroPersonalizado(("Modulo = 'COMP' Or Modulo = 'ALL'"));
                DTTipo = objDB.GetAll("TSISTEMA_MODULOS_TRANSACCIONES", -1, objDB.Filtros);

                cboTipo.ValueMember = "Codigo";
                cboTipo.DisplayMember = "Nombre";
                cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                cboTipo.DataSource = DTTipo.DefaultView;

                objDB.GetFechasOficina();
                dtpFechaDesde2.Value = objUtil.getPrimeraFechaMes(objDB.FECHA_TRABAJO);
                dtpFechaHasta2.Value = objDB.FECHA_TRABAJO;

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            //base.GetData(opcion);
            string tipo = "";
            DateTime fecha;
            string aBuscar = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                objDB.LimpiarFiltros();
                if (cboTipo.SelectedValue != null) tipo = cboTipo.SelectedValue.ToString().ToUpper();

                if (tipo == "CXP") objDB.AddFiltroEmpieceEN("Proximo", tipo);
                else if (tipo != "") objDB.AddFiltroEmpieceEN("Modulo", tipo);

                fecha = dtpFechaDesde2.Value.Date;
                objDB.AddFiltroMayorOIgualA("Factura_Fecha", objDB.DateToInt(fecha).ToString());

                fecha = dtpFechaHasta2.Value.Date;
                objDB.AddFiltroMenorOIgualA("Factura_Fecha", objDB.DateToInt(fecha).ToString());

                aBuscar = txtABuscar.Text.Trim();

                if (aBuscar != "") objDB.AddFiltroContengaA("Nombre", aBuscar);

                objDB.AddFiltroOrderBY("Unico Desc");

                MyData = objDB.GetAll("TCXP", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

                MostrarCantidadFilas();


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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string concepto = "";
            try
            {
                if (dataGridView1.RowCount > 0) concepto = dataGridView1["Concepto", dataGridView1.CurrentRow.Index].Value.ToString();

                txtConcepto.Text = concepto;
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
