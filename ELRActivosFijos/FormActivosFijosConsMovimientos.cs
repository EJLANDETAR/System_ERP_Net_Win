using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRActivosFijos
{
    public partial class FormActivosFijosConsMovimientos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormActivosFijosConsMovimientos()
        {
            InitializeComponent();
        }

        void GetActivoFijo(int id = 0)
        {
            DataTable DTData;
            DataRow fila0 = null;
            FormActivosFijos frm = new FormActivosFijos();

            try
            {
                txtActivoId.Text = "0";
                lblActivoFijoNombre.Text = "(TODOS)";

                if (id > 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Activo_Id", id.ToString());
                    DTData = objDB.GetAll("TACTIVOS_FIJOS", 1, objDB.Filtros);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.nombreUsuario = nombreUsuario;
                    frm.FiltroEstatico = "";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    txtActivoId.Text = objUtil.GetAsString("Activo_Id", fila0, "0");
                    lblActivoFijoNombre.Text = objUtil.GetAsString("Nombre", fila0, "");
                    txtActivoId.drFilaSel = fila0;

                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtActivoId_Leave(object sender, EventArgs e)
        {
            int valorId = 0;
            try
            {
                if (txtActivoId.drFilaSel == null)
                {
                    valorId = int.Parse(txtActivoId.Text);
                    if (valorId > 0) GetActivoFijo(valorId);
                    else lblActivoFijoNombre.Text = "";
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtActivoId_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F9)) GetActivoFijo();
            else if ((e.KeyCode != Keys.Tab) && (e.KeyCode != Keys.Enter)) txtActivoId.drFilaSel = null;
        }

        private void FormActivosFijosConsMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                tsbBusquedaAvanzada.Enabled = false;
                cboTipo.SelectedIndex = 0;
                dtpFecha1.Value = DateTime.Now.Date.AddDays(-30);
                dtpFecha2.Value = DateTime.Now.Date;

                txtActivoId.Text = "0";
                lblActivoFijoNombre.Text = "(TODOS)";

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
            int tipo = -1;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                tipo = cboTipo.SelectedIndex;
                DataGridConsulta.DataSource = null;

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());

                if (txtActivoId.drFilaSel != null) objDB.AddFiltroIgualA("Activo_Id", txtActivoId.Text);

                if (tipo == 1) objDB.AddFiltroEmpieceEN("TIPO", "DEPRE");
                else if (tipo == 2) objDB.AddFiltroEmpieceEN("TIPO", "VENTA");
                else if (tipo == 3) objDB.AddFiltroEmpieceEN("TIPO", "RETIRO");
                else if (tipo == 4) objDB.AddFiltroEmpieceEN("TIPO", "CB-OFICINA");
                else if (tipo == 5) objDB.AddFiltroEmpieceEN("TIPO", "CB-UBIC");
                else if (tipo == 6) objDB.AddFiltroEmpieceEN("TIPO", "CB-RESP");

                objDB.AddFiltroOrderBY("Id");

                MyData = objDB.GetAll("TACTIVOS_FIJOS_MOVIMIENTOS", -1, objDB.Filtros);
                MostrarCantidadFilas();

                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

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
            int index = 0;
            try
            {
                if (DataGridConsulta != null)
                {
                    if (DataGridConsulta.CurrentRow != null)
                    {
                        index = DataGridConsulta.CurrentRow.Index;
                        concepto = DataGridConsulta["Descripcion", index].Value.ToString();
                        if (concepto.Trim() == "") concepto = DataGridConsulta["Concepto", index].Value.ToString();

                        concepto = DataGridConsulta["Tipo", index].Value.ToString() + "; " + concepto;
                    }
                }

                txtConcepto.Text = concepto;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarActivo_Click(object sender, EventArgs e)
        {
            GetActivoFijo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorUnico = 0;
            int index = 0;
            int asientoId = 0;
            int spReturn = 0;
            DataRow fila0;
            DialogResult resp;
            string temporalId = "", nombreColumna = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                if (DataGridConsulta.RowCount > 0 && e.RowIndex >= 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    nombreColumna = DataGridConsulta.Columns[e.ColumnIndex].Name.ToUpper();

                    valorUnico = int.Parse(DataGridConsulta["Unico", index].Value.ToString());
                    fila0 = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    asientoId = objUtil.GetAsInt("Asiento_Id", fila0);

                    if (asientoId > 0)
                    {
                        objUtil.MostrarMensajeAdvertencia("NO PUEDE ANULAR UN MOVIMIENTO YA ASENTADO");
                        return;
                    }

                    if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea eliminar esta Transaccion?");
                        if (resp != DialogResult.Yes) return;

                        this.Cursor = Cursors.WaitCursor;
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("ValorUnico", valorUnico));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_ACTIVOS_FIJOS_ANULAR_MOVIMIENTO", parms);
                        if (spReturn < 0) MostrarErrorTemporal(temporalId);
                        else
                        {
                            objDB.confirmarTransaccion();
                            GetData();
                        }

                    }
                    else if (nombreColumna == "ASIENTO_ID")
                    {
                        ImprimirPreviewRDLC("RptContaAsientoDiario", "VCONTA_DIARIO_DETALLE", asientoId.ToString(), "Asiento_Id");
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
                objDB.cancelarTransaccion();
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
