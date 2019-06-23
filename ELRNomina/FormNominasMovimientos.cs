using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormNominasMovimientos : WinControl_ELR_NET.FormPlantillaIndex
    {
        string cedulaRNC = "000000000";
        public FormNominasMovimientos()
        {
            InitializeComponent();
        }

        void GetEmpleado(string codigo = "")
        {
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();
            DataTable DTEmpleados = null;
            DataRow fila0 = null;
            string sfiltro = "";
            string nombres = "", apellidos = "";
            int id = 0;
            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                cedulaRNC = "000000000";
                if (codigo != "" && codigo != "0")
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                    sfiltro = "( Cast(Empleado_Id as Varchar) = '" + codigo + "'";
                    sfiltro += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "'";
                    sfiltro += ")";
                    objDB.AddFiltroPersonalizado(sfiltro);

                    DTEmpleados = objDB.GetAll("TRRHH_EMPLEADOS", 1, objDB.Filtros);
                    if (DTEmpleados.Rows.Count > 0) fila0 = DTEmpleados.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.esBusqueda = true;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.FiltroEstatico = "Empresa_Id = " + empresaID.ToString();
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                id = 0;
                if (fila0 != null)
                {
                    id = objUtil.GetAsInt("Empleado_Id", fila0);
                    nombres = objUtil.GetAsString("Nombres", fila0);
                    apellidos = objUtil.GetAsString("Apellidos", fila0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);
                }

                txtEmpleadoId.Text = id.ToString();
                txtNombre.Text = (nombres + " " + apellidos).Trim();
                txtCedulaRNC.Text = cedulaRNC;
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Cliente, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                DTEmpleados = null;
                fila0 = null;
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void txtEmpleadoId_Leave(object sender, EventArgs e)
        {
            string codigo = txtEmpleadoId.Text.Trim();
            if(codigo == "")
            {
                txtEmpleadoId.Text = "0";
                txtNombre.Text = "";
                txtCedulaRNC.Text = "";
            } 
        }

        private void txtEmpleadoId_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtEmpleadoId.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEmpleado();
            else if (e.KeyCode == Keys.Enter) GetEmpleado(codigo); 
        }

        private void FormNominasMovimientos_Load(object sender, EventArgs e)
        {
            DateTime fechaDesde, fechaHasta;
            int dia, mes, anio;
            try
            {
                //Buscamos Fecha Desde
                fechaDesde = DateTime.Now.Date;
                dia = fechaDesde.Day;
                mes = fechaDesde.Month;
                anio = fechaDesde.Year;

                if (dia <= 15)
                {
                    fechaDesde = new DateTime(anio, mes, 1);
                    fechaHasta = new DateTime(anio, mes, 15);
                }
                else
                {
                    fechaDesde = new DateTime(anio, mes, 16);
                    fechaHasta = fechaDesde.AddMonths(1);
                    mes = fechaHasta.Month;
                    anio = fechaHasta.Year;
                    fechaHasta = new DateTime(anio, mes, 1);
                    fechaHasta = fechaHasta.AddDays(-1);
                }

                dtpFecha1.Value = fechaDesde;
                dtpFecha2.Value = fechaHasta;

                GetData(); 
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            int empleadoId = 0;
            int fechaDesde = 0, fechaHasta = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                int.TryParse(txtEmpleadoId.Text, out empleadoId);
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());

                if(empleadoId > 0) objDB.AddFiltroIgualA("Empleado_Id", empleadoId.ToString());

                MyData = objDB.GetAll("TNOMINAS_MOVIMIENTOS", -1, objDB.Filtros);
                MostrarCantidadFilas();
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

                TotalizarData();

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

        public override void TotalizarData()
        {
            double total = 0;
            try
            {
                if(MyData != null) total = GetSum("Monto");

                lblTotal.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string comentario = "";
            int index = 0;
            string valorUnico = "0";
            DataRow fila0;

            try
            {
                if (MyData == null) return;

                if (DataGridConsulta.RowCount > 0 && MyData.Rows.Count > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    comentario = objUtil.GetAsString("Comentario", fila0);
                }

                txtComentario.Text = comentario;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int index = 0, nominaId = 0, spReturn = -1;
            DataRow fila0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    //SP_NOMINAS_ELIMINAR_TRANSACCION
                    index = DataGridConsulta.CurrentRow.Index;
                    valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    nominaId = objUtil.GetAsInt("Nomina_Id", fila0);

                    if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        if (nominaId > 0) objUtil.MostrarMensajeAdvertencia("TRANSACCION YA APLICADA, NO SE PUEDE ELIMINAR");
                        else
                        {
                            resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Eliminar esta Transaccion?");
                            if (resp == DialogResult.Yes)
                            {
                                Cursor = Cursors.WaitCursor;
                                temporalId = objUtil.GetTemporalID();
                                parms.Add(new DataDB_ELR_NET.Parametro("Id", valorUnico));
                                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                                objDB.iniciarTransaccion();
                                spReturn = objDB.EjecutarSP("SP_NOMINAS_ELIMINAR_TRANSACCION", parms);
                                if (spReturn < 0)
                                {
                                    MostrarErrorTemporal(temporalId);
                                    objDB.cancelarTransaccion();
                                }
                                else
                                {
                                    objDB.confirmarTransaccion();
                                    objUtil.MostrarMensajeInformacion("Transaccion Eliminada de Forma Satisfactoria...");
                                    GetData();
                                }

                            }
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
                Cursor = Cursors.Default;
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptRRHHNominaMovimientos");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;

                frm.AddParm("EMPLEADO_NOMBRE", txtNombre.Text);
                frm.AddParm("EMPLEADO_ID", cedulaRNC);
                frm.AddParm("FECHA_DESDE", objUtil.GetDateAsString(dtpFecha1.Value));
                frm.AddParm("FECHA_HASTA", objUtil.GetDateAsString(dtpFecha2.Value));

                frm.titulo = "DETALLE TRANSACIONES DE NOMINA POR FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";

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
    }
}
