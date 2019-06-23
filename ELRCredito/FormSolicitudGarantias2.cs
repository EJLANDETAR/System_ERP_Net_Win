using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormSolicitudGarantias2 : WinControl_ELR_NET.FormPlantillaIndex
    {
        //DECLARAMOS VARIABLES PUBLICAS
        public int solicitudId = 0;
        public string aNombre = "";

        public FormSolicitudGarantias2()
        {
            InitializeComponent();
        }

        private void btnGarantiaPersonal_Click(object sender, EventArgs e)
        {
            FormSolicitudCreditoR frmGPersonal = new FormSolicitudCreditoR();
            string filtroEntidad = "";
            int id = 0;
            string tipoGarantiaId = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                foreach (DataRow fila in MyData.Rows)
                {
                    id = objUtil.GetAsInt("Entidad_Id", fila);
                    tipoGarantiaId = objUtil.GetAsString("Tipo_Garantia_Id", fila).Trim().ToUpper();

                    if(tipoGarantiaId == "P")
                    {
                        if (filtroEntidad == "") filtroEntidad = id.ToString();
                        else filtroEntidad += "," + id.ToString();
                    }
                }

                frmGPersonal.nombreUsuario = nombreUsuario;
                frmGPersonal.solicitudId = solicitudId;
                frmGPersonal.VALOR_ID = "0";
                frmGPersonal.DTVariablesSYS = DTVariablesSYS;
                frmGPersonal.DSGlobal = DSGlobal;
                frmGPersonal.EnEjecusion = true;
                frmGPersonal.filtroEntidad = filtroEntidad;
                frmGPersonal.EMPRESA_ID = empresaID;
                frmGPersonal.OFICINA_ID = oficinaID;
                frmGPersonal.esGarantiaPersonal = true;

                frmGPersonal.ShowDialog();

                if (frmGPersonal.lOK) RealizarBusquedaSencilla();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmGPersonal.Dispose();
            }
        }

        private void FormSolicitudGarantias2_Load(object sender, EventArgs e)
        {
            try
            {
                if (EnEjecusion)
                {
                    lblSolicitud.Text = "Solicitud No.: " + solicitudId.ToString().PadLeft(8, '0') + " - " + aNombre.Trim().ToUpper();
                    FiltroEstatico = "Solicitud_Id = " + solicitudId + " And Fecha_Deleted Is Null And EsNulo = 0";

                    GetData();

                    tsbAgregar.Visible = false;
                    tsbModificar.Visible = false;
                    tsbImprimir.Visible = false;
                }
            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int entidadId = 0;
            string documentoId = "0";
            string tipoGarantiaId = "";
            string temporalId = "";
            DialogResult resp;
            int resultado = 0, index = 0;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();

            DataRow MyFila = null;

            FormSolicitudCreditoR frmGPersonal = new FormSolicitudCreditoR();
            FormSolicitudGarantiaVehiculo frmGVehiculo = new FormSolicitudGarantiaVehiculo();
            WinControl_ELR_NET.ELRFormMensajeErrores frmMensajeErrores = new WinControl_ELR_NET.ELRFormMensajeErrores();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                temporalId = objUtil.GetTemporalID();

                var senderGrid = (DataGridView)sender;
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (e.RowIndex < 0) return;

                valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();
                index = senderGrid.CurrentRow.Index;

                //ELIMINAMOS UN REGISTRO DE GARANTIA
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                   
                    resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Eliminar el Registro de Esta Garantia?");

                    if (resp == System.Windows.Forms.DialogResult.Yes)
                    {
                        parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parametros.Add(new DataDB_ELR_NET.Parametro("Unico", valorUnico));
                        parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_PRESTAMOS_ELIMINA_GARANTIA", parametros);

                        if (resultado > 0)
                        {
                            objDB.confirmarTransaccion();
                            RealizarBusquedaSencilla();
                        }
                        else
                        {
                            frmMensajeErrores.TemporalId = temporalId;
                            frmMensajeErrores.objDB = objDB;

                            frmMensajeErrores.ShowDialog();
                        }

                    }

              
                }

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    MyFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                    entidadId = objUtil.GetAsInt("Entidad_Id", MyFila);
                    documentoId = objUtil.GetAsString("Documento_Id", MyFila);
                    tipoGarantiaId = objUtil.GetAsString("Tipo_Garantia_Id", MyFila).Trim().ToUpper();

                    parametros.Clear();
                    
                    if (tipoGarantiaId == "P")
                    {
                        parametros.Add(new DataDB_ELR_NET.Parametro("Id", entidadId));
                        parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parametros.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_TEMPORAL_CLASIFICADOR_ENTIDADES", parametros);
                        if (resultado < 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();

                            frmGPersonal.nombreUsuario = nombreUsuario;
                            frmGPersonal.solicitudId = solicitudId;
                            frmGPersonal.entidadId = entidadId;
                            frmGPersonal.VALOR_ID = entidadId.ToString();
                            frmGPersonal.DTVariablesSYS = DTVariablesSYS;
                            frmGPersonal.DSGlobal = DSGlobal;
                            frmGPersonal.EnEjecusion = true;
                            frmGPersonal.temporalID = temporalId;
                            frmGPersonal.EMPRESA_ID = empresaID;
                            frmGPersonal.OFICINA_ID = oficinaID;
                            frmGPersonal.esGarantiaPersonal = true;

                            frmGPersonal.ShowDialog();

                            if (frmGPersonal.lOK) this.GetData();
                        }
                    }

                    if (tipoGarantiaId == "V")
                    {
                        parametros.Add(new DataDB_ELR_NET.Parametro("Id", valorUnico));
                        parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parametros.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_TEMPORAL_GARANTIA_VEHICULO", parametros);
                        if (resultado < 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();

                            frmGVehiculo.nombreUsuario = nombreUsuario;
                            frmGVehiculo.solicitudId = solicitudId;
                            frmGVehiculo.VALOR_ID = valorUnico;
                            frmGVehiculo.DTVariablesSYS = DTVariablesSYS;
                            frmGVehiculo.DSGlobal = DSGlobal;
                            frmGVehiculo.EnEjecusion = true;
                            frmGVehiculo.temporalID = temporalId;
                            frmGVehiculo.EMPRESA_ID = empresaID;
                            frmGVehiculo.OFICINA_ID = oficinaID;

                            frmGVehiculo.ShowDialog();

                            if (frmGVehiculo.lOK) RealizarBusquedaSencilla();
                        }
                    }

                    //Buscamos el Unico Para Ubicar sobre la fila
                    senderGrid.CurrentCell = senderGrid["btnEliminar", index];
                    senderGrid.CurrentCell.Selected = true;
                   

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmGPersonal.Dispose();
                frmGVehiculo.Dispose();
                frmMensajeErrores.Dispose();

                objDB.cancelarTransaccion();
            }
        }

        private void btnGarantiaVehiculo_Click(object sender, EventArgs e)
        {
            FormSolicitudGarantiaVehiculo frmGVehiculo = new FormSolicitudGarantiaVehiculo();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                frmGVehiculo.nombreUsuario = nombreUsuario;
                frmGVehiculo.solicitudId = solicitudId;
                frmGVehiculo.OFICINA_ID = oficinaID;
                frmGVehiculo.VALOR_ID = "0";
                frmGVehiculo.DTVariablesSYS = DTVariablesSYS;
                frmGVehiculo.DSGlobal = DSGlobal;
                frmGVehiculo.EnEjecusion = true;

                frmGVehiculo.ShowDialog();

                if (frmGVehiculo.lOK) this.GetData();
            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmGVehiculo.Dispose();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int filaId = 0;
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    filaId = dataGridView1.CurrentRow.Index;
                    txtDescripcion.Text = dataGridView1["Descripcion", filaId].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnGarantiaEmpleado_Click(object sender, EventArgs e)
        {
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();
            int spReturn = -1;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            int empleadoId = 0;
            try
            {
                frm.empresaID = empresaID;
                frm.oficinaID = oficinaID;
                frm.FiltroEstatico = "EsActivo = 1 And Fecha_Baja Is Null";
                frm.EsAgregar = false;
                frm.EsModificar = false;

                frm.esBusqueda = true;
                frm.EnEjecusion = true;

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    Cursor = Cursors.WaitCursor;

                    temporalId = objUtil.GetTemporalID();
                    empleadoId = objUtil.GetAsInt("Empleado_Id", frm.filaSelecionada);
                    parms.Add(new DataDB_ELR_NET.Parametro("empleadoId", empleadoId));
                    parms.Add(new DataDB_ELR_NET.Parametro("solicitudId", solicitudId));
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                    parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_SOLICITUD_AGREGAR_GARANTIA_EMPLEADO", parms);

                    if(spReturn < 0)
                    {
                        MostrarErrorTemporal(temporalId);
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        objDB.confirmarTransaccion();
                        RealizarBusquedaSencilla();
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
                frm.Dispose();
            }
        }
    }
}
