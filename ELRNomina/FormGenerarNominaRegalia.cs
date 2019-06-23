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
    public partial class FormGenerarNominaRegalia : WinControl_ELR_NET.ELRFormRegistro
    {
        int nominaId = 0, mes = 0;

        public FormGenerarNominaRegalia()
        {
            InitializeComponent();
        }

        private void FormGenerarNominaRegalia_Load(object sender, EventArgs e)
        {
            string SSQL = "";
            DataTable DTMyOficinas = null;

            try
            {
                btnGrabar.Enabled = false;
                mes = DateTime.Now.Month;
                dtgNominaDetalle.Columns["Monto_APagar"].ReadOnly = (mes < 12);
                //btnGenerar.Enabled = (DateTime.Now.Month == 12);
                nominaId = int.Parse(DateTime.Now.Year.ToString() + "1301");
                lblNominaId.Text = "Nomina Id: " + nominaId.ToString();

                //Buscamos las oficinas
                SSQL = "SELECT 0 Oficina_Id, '(TODAS)' as Nombre";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Oficina_Id, Nombre FROM TEMPRESAS_OFICINAS WHERE EsActivo = 1 ";
                SSQL += "  And Empresa_Id = " + EMPRESA_ID.ToString();
                DTMyOficinas = objDB.GetSQL(SSQL);
                cboOficina.DataSource = DTMyOficinas.DefaultView;
                cboOficina.SelectedValue = 0;

                //AGREGAMOS BOTONES A MENU LATERAL
                addButtonAMenuLateral("ELRMaestros.FormEmpleados");
                addButtonAMenuLateral("ELRNomina.FormNominaTablaISR");
                addButtonAMenuLateral("ELRNomina.FormNominaConfigR");
                addButtonAMenuLateral("ELRNomina.FormCambioSalario");
                addButtonAMenuLateral("ELRNomina.FormDarBajaEmpleados");
                addButtonAMenuLateral("ELRNomina.FormNominaAprobar");
                addButtonAMenuLateral("ELRNomina.FormNominasMovimientos");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            //return base.GetData();

            return true;
        }

        void GenerarNomina()
        {
            //Procedemos a Generar la Nomina
            int spReturn = -1;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int oficinaId = 0;
            try
            {
                btnGrabar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (temporalID.Trim() == "") temporalID = objUtil.GetTemporalID();

                if (cboOficina.SelectedValue != null) oficinaId = int.Parse(cboOficina.SelectedValue.ToString());

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                parms.Add(new DataDB_ELR_NET.Parametro("oficinaId", oficinaId));
                parms.Add(new DataDB_ELR_NET.Parametro("nominaId", nominaId));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_NOMINA13_GENERAR_TEMPORAL", parms);
                if (spReturn < 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                    DTDetalle = objDB.GetAll("TTEMPORAL_NOMINAS_DETALLE", -1, objDB.Filtros);

                    dtgNominaDetalle.AutoGenerateColumns = false;
                    dtgNominaDetalle.DataSource = DTDetalle.DefaultView;

                    btnGrabar.Enabled = (DTDetalle.Rows.Count > 0 && mes == 12);

                    TotalizarDetalle();
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarNomina();
        }

        public override void TotalizarDetalle()
        {
            //base.TotalizarDetalle();
            double totalAcum = 0, totalPend = 0, total = 0;

            try
            {
                if (DTDetalle != null)
                {
                    total = GetSum("Monto_APagar", DTDetalle);
                    totalAcum = GetSum("Acumulado", DTDetalle);
                    totalPend = GetSum("Pendiente", DTDetalle);
                }

                lblTotal.Text = "Acumulado: " + totalAcum.ToString("N2") + "      ";
                lblTotal.Text += "Quincena Pendiente: " + totalPend.ToString("N2") + "            ";
                lblTotal.Text += "Total: " + total.ToString("N2");


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            VerNomina();
        }

        void VerNomina()
        {
            int oficinaId = 0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parm = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            try
            {
                Cursor = Cursors.WaitCursor;
                btnGrabar.Enabled = false;
                

                if (cboOficina.SelectedValue != null) oficinaId = int.Parse(cboOficina.SelectedValue.ToString());
                if (temporalID == "") temporalID = objUtil.GetTemporalID();

                parm.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parm.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                parm.Add(new DataDB_ELR_NET.Parametro("oficinaId", oficinaId));
                parm.Add(new DataDB_ELR_NET.Parametro("nominaId", nominaId));
                parm.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_NOMINA_CARGAR_ATEMPORAL", parm);
                if(spReturn < 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                }

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroIgualA("Nomina_Id", nominaId.ToString());
                objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                if (oficinaId > 0) objDB.AddFiltroIgualA("Oficina_Id", oficinaId.ToString());

                DTDetalle = objDB.GetAll("TTEMPORAL_NOMINAS_DETALLE", -1, objDB.Filtros);
                dtgNominaDetalle.AutoGenerateColumns = false;
                dtgNominaDetalle.DataSource = DTDetalle.DefaultView;
                btnGrabar.Enabled = (DTDetalle.Rows.Count > 0 && mes == 12);

                TotalizarDetalle();

               
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

        public override int GrabarDatos()
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            DataRow fila0;
            DialogResult resp;
            int spResult = -1;

            try
            {
                //procedemos a Grabar los datos de Nomina
                if (DTDetalle != null)
                {
                    if (DTDetalle.Rows.Count > 0)
                    {
                        fila0 = DTDetalle.Rows[0];
                        resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Grabar la Nomina?");
                        if (resp == DialogResult.Yes)
                        {
                            Cursor = Cursors.WaitCursor;
                            temporalID = objUtil.GetAsString("IdentificadorTemp", fila0);
                            parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                            objDB.iniciarTransaccion();
                            spResult = objDB.EjecutarSP("SP_NOMINA_GRABAR_NOMINA", parms);
                            if (spResult <= 0)
                            {
                                MostrarErrorTemporal();
                                objDB.cancelarTransaccion();
                            }
                            else
                            {
                                objDB.confirmarTransaccion();

                                resp = objUtil.MostrarMensajePregunta("Datos Registrados de Forma Satisfactoria \r\rDESEA IMPRIMIR?");
                                if (resp == DialogResult.Yes) Imprimir(nominaId.ToString());
                                
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
                objDB.cancelarTransaccion();
            }

            return spResult;
        }

        public override bool Imprimir(string valorId = "", int tipoImp = 0)
        {
            bool resultado = false;
            int oficinaId = 0;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DataTable DTData = null;
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Nomina_Id", valorId);
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());

                oficinaId = int.Parse( cboOficina.SelectedValue.ToString());
                if (oficinaId > 0) objDB.AddFiltroIgualA("Oficina_Id", oficinaId.ToString());
                DTData = objDB.GetAll("VNOMINAS_DETALLE", -1, objDB.Filtros);

                pathReporte = objUtil.GetPathReportRDLC("RptRRHHNominaDetalle");

                frm.pathReporte = pathReporte;
                frm.DTData = DTData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = OFICINA_ID;
                frm.empresaId = EMPRESA_ID;
                frm.nombreUsuario = nombreUsuario;

                frm.AddParm("NOMINA_ID", valorId);
                frm.AddParm("OFICINA_NOMINA", cboOficina.Text);

                frm.titulo = "NOMINA REGALIA PASCUAL";

                frm.ShowDialog();
                resultado = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeInformacion(ex.Message, "Error al Imprimir Nomina");
            }

            return resultado;
        }

        public override void PostLineaDetalle(DataGridView senderGrid = null, string nombreColumnaUnico = "Unico")
        {
            if (mes == 12) base.PostLineaDetalle(senderGrid, nombreColumnaUnico);
            TotalizarDetalle();
        }
    }
}
