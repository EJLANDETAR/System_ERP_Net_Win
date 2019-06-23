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
    public partial class FormSolicitudDeudores2 : WinControl_ELR_NET.FormPlantillaIndex
    {
        public int solicitudId = 0;
        public string ANombre = "";

        public FormSolicitudDeudores2()
        {
            InitializeComponent();
        }

        private void FormSolicitudDeudores2_Load(object sender, EventArgs e)
        {

            try
            {
                if (EnEjecusion)
                {
                    
                    lblSolicitud.Text = "Solicitud No.: " + solicitudId.ToString().PadLeft(8, '0') + " - " + ANombre.ToUpper();

                    this.GetData();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Modificar()
        {
            //base.Modificar();
            FormSolicitudCreditoR frm = new FormSolicitudCreditoR();
            DataRow MyFila;
            string valorUnico = "0";
            string entidadId = "0";
            int index = 0;
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DataGridConsulta != null)
                {
                    if (DataGridConsulta.RowCount > 0)
                    {
                        index = DataGridConsulta.CurrentRow.Index;
                        valorUnico = DataGridConsulta["DUnico", index].Value.ToString();
                        MyFila = MyData.Select("DUnico = " + valorUnico)[0];

                        entidadId = objUtil.GetAsString("Entidad_Id", MyFila, "0");
                       
                        //PROCEDEMOS A EJECUTAR EL SP PARA CARGAR A TEMPORAL
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("Id", entidadId));
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_TEMPORAL_CLASIFICADOR_ENTIDADES", parms);
                        if (spReturn < 0) MostrarErrorTemporal(temporalId);
                        else
                        {
                            objDB.confirmarTransaccion();

                            frm.VALOR_ID = entidadId;
                            frm.entidadId = int.Parse(entidadId);
                            frm.solicitudId = solicitudId;
                            frm.nombreUsuario = nombreUsuario;
                            frm.temporalID = temporalId;
                            frm.EMPRESA_ID = empresaID;
                            frm.OFICINA_ID = oficinaID;
                            frm.EnEjecusion = true;
                            frm.esCoDeudor = true;
                            frm.ShowDialog();

                            if (frm.lOK)
                            {
                                this.GetData();

                                if(DataGridConsulta.RowCount >= index)
                                {
                                    DataGridConsulta.CurrentCell = DataGridConsulta["CedulaRNC", index];
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
                this.Cursor = Cursors.Default;
                frm.Dispose();
                MyFila = null;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow MyFila = null;
            bool esPrincipal = false;
            DialogResult resp;

            try
            {
                var senderGrid = (DataGridView)sender;
                this.Cursor = Cursors.WaitCursor;

                if (e.RowIndex >= 0)
                {
                    if(senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn) Modificar();
                    else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        valorUnico = senderGrid["DUnico", senderGrid.CurrentRow.Index].Value.ToString();
                        MyFila = MyData.Select("DUnico = " + valorUnico)[0];
                        esPrincipal = objUtil.GetAsBoolean("EsPrincipal", MyFila);

                        if (esPrincipal) objUtil.MostrarMensajeAdvertencia("No esta Permitido Eliminar al Deudor Principal");
                        else
                        {
                            resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Eliminar este Registro?");
                            if (resp == DialogResult.Yes)
                            {
                                objDB.MarcarRegistroEliminado("TPRESTAMOS_SOLICITUD_DEUDORES", valorUnico);
                                GetData();
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
                this.Cursor = Cursors.Default;
            }
        }

        public override void Agregar()
        {

            FormSolicitudCreditoR frm = new FormSolicitudCreditoR();
            string filtroEntidad = "";
            int entidadId = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                foreach (DataRow fila in MyData.Rows)
                {
                    entidadId = objUtil.GetAsInt("Entidad_Id", fila);
                    if (filtroEntidad != "") filtroEntidad += "," + entidadId.ToString();
                    else filtroEntidad = entidadId.ToString();
                }

                frm.VALOR_ID = "0";
                frm.entidadId = 0;
                frm.EMPRESA_ID = empresaID;
                frm.OFICINA_ID = oficinaID;
                frm.solicitudId = solicitudId;
                frm.nombreUsuario = nombreUsuario;
                //frm.filtroEntidad = filtroEntidad;

                frm.esCoDeudor = true;
                frm.EnEjecusion = true;
                frm.ShowDialog();

                if (frm.lOK) this.GetData();

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
    }
}
