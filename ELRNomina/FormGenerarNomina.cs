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
    public partial class FormGenerarNomina : WinControl_ELR_NET.ELRFormRegistro
    {
        DateTime fechaIni = DateTime.Now.Date;
        DateTime fechaFin = DateTime.Now.Date;
        DataView dvData = new DataView();

        public FormGenerarNomina()
        {
            InitializeComponent();
        }

        private void FormGenerarNomina_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            int dia = 0, mes = 0, anio = 0;

            try
            {
                btnGrabar.Enabled = false;

                dia = fecha.Day;
                mes = fecha.Month;
                anio = fecha.Year;

                if (dia > 15)
                {
                    fechaFin = objUtil.getUltimaFechaMes(fecha);
                    fechaIni = new DateTime(anio, mes, 16);
                }
                else
                {
                    fechaFin = new DateTime(anio, mes, 15);
                    fechaIni = objUtil.getPrimeraFechaMes(fecha);
                }

                if(dia <= 15) dtpFechaHasta.Value = new DateTime(anio, mes, 15);
                else
                {
                    dtpFechaHasta.Value = fechaFin;
                }

                

                //AGREGAMOS BOTONES A MENU LATERAL
                addButtonAMenuLateral("ELRMaestros.FormEmpleados");
                addButtonAMenuLateral("ELRNomina.FormNominaTablaISR");
                addButtonAMenuLateral("ELRNomina.FormNominaConfigR");
                addButtonAMenuLateral("ELRNomina.FormCambioSalario");
                addButtonAMenuLateral("ELRNomina.FormDarBajaEmpleados");
                addButtonAMenuLateral("ELRNomina.FormNominaAprobar");
                addButtonAMenuLateral("ELRNomina.FormNominasMovimientos");
                addButtonAMenuLateral("ELRConsultasReportes.FormRRHHConsultaPagosNomina"); 


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
            int fechaHasta = 0, feAValidar = 0;
            int oficinaId = 0;
            try
            {
                btnGrabar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                fechaHasta = objUtil.DateToInt(dtpFechaHasta.Value);
                txtFiltroNombre.Text = "";
                //VALIDAMOS LA FECHA NO PUEDE SER MAYOR A LA ULTIMA FECHA
                feAValidar = objUtil.DateToInt(fechaFin);
                if(fechaHasta > feAValidar)
                {
                    objUtil.MostrarMensajeAdvertencia("LA FECHA NO PUEDE SER MAYOR A: " + objUtil.GetDateAsString(fechaFin));
                    return;
                }

                //VALIDAMOS FECHA NO SEA MENOR A LA PRIMERA FECHA VALIDA
                feAValidar = objUtil.DateToInt(fechaIni);
                if (fechaHasta < feAValidar)
                {
                    objUtil.MostrarMensajeAdvertencia("LA FECHA NO PUEDE SER MENOR A: " + objUtil.GetDateAsString(fechaIni));
                    return;
                }

                if (temporalID.Trim() == "") temporalID = objUtil.GetTemporalID();

                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                parms.Add(new DataDB_ELR_NET.Parametro("oficinaId", oficinaId));
                parms.Add(new DataDB_ELR_NET.Parametro("fechaHasta", fechaHasta));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_NOMINA_GENERAR_TEMPORAL", parms);
                if(spReturn < 0)
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

                    filtrarData();

                    btnGrabar.Enabled = (DTDetalle.Rows.Count > 0);

                    TotalizarDetalle();

                    objUtil.MostrarMensajeAdvertencia("La nomina se ha generado de forma temporal. Favor revise los datos y luego de clic en el boton grabar.");
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

        void filtrarData()
        {
            string aBuscar = "";
            try
            {
                if (DTDetalle == null) return;
                if (dvData != null) dvData.RowFilter = "";
                dvData = DTDetalle.DefaultView;
                aBuscar = txtFiltroNombre.Text.Trim();
                if (aBuscar != "") dvData.RowFilter = objUtil.BuildLikeFilter("Nombre", aBuscar);
                DataGridDetalle.AutoGenerateColumns = false;
                DataGridDetalle.DataSource = dvData;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarNomina();
        }

        public override void TotalizarDetalle()
        {
            //base.TotalizarDetalle();
            double DARS = 0, DAFP = 0, DARL = 0, DISR = 0;
            double EARS = 0, EAFP = 0, EARL = 0, EINFOTEP = 0;
            double totalMensual = 0, totalBruto = 0, totalDescto = 0, totalNeto = 0;

            try
            {
                if(DTDetalle != null)
                {
                    DARS = GetSum("D_ARS", DTDetalle);
                    DAFP = GetSum("D_AFP", DTDetalle);
                    DARL = GetSum("D_ARL", DTDetalle);
                    DISR = GetSum("D_ISR", DTDetalle);

                    EARS = GetSum("E_ARS", DTDetalle);
                    EAFP = GetSum("E_AFP", DTDetalle);
                    EARL = GetSum("E_ARL", DTDetalle);
                    EINFOTEP = GetSum("E_INFOTEP", DTDetalle);

                    totalMensual = GetSum("Salario", DTDetalle);
                    totalBruto = GetSum("Monto_Bruto", DTDetalle);
                    totalDescto = GetSum("Total_Descuento", DTDetalle);
                    totalNeto = GetSum("Monto_APagar", DTDetalle);
                }

                txtDARS.Text = DARS.ToString("N2");
                txtDAFP.Text = DAFP.ToString("N2");
                txtDARL.Text = DARL.ToString("N2");
                txtDISR.Text = DISR.ToString("N2");

                txtEARS.Text = EARS.ToString("N2");
                txtEAFP.Text = EAFP.ToString("N2");
                txtEARL.Text = EARL.ToString("N2");
                txtEINFOTEP.Text = EINFOTEP.ToString("N2");

                txtSalarioMensual.Text = totalMensual.ToString("N2");
                txtSueldoBruto.Text = totalBruto.ToString("N2");
                txtDescto.Text = totalDescto.ToString("N2");
                txtNeto.Text = totalNeto.ToString("N2");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgNominaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int index = 0;
            DataRow fila0;

            FormNominaVerDetalle frm = new FormNominaVerDetalle();

            try
            {
                if(dtgNominaDetalle.RowCount > 0)
                {
                    index = dtgNominaDetalle.CurrentRow.Index;
                    valorUnico = dtgNominaDetalle["Unico", index].Value.ToString();

                    if(dtgNominaDetalle.Columns[e.ColumnIndex] is DataGridViewLinkColumn || dtgNominaDetalle.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];
                        frm.fila0 = fila0;

                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            VerNomina();
        }

        void VerNomina()
        {
            int nominaId = 0;
            DateTime fecha;
            int oficinaId = 0, anio, mes, dia;
            DialogResult resp;
            try
            {
                Cursor = Cursors.WaitCursor;
                btnGrabar.Enabled = false;

                fecha = dtpFechaHasta.Value;
                dia = fecha.Day;
                mes = fecha.Month;
                anio = fecha.Year;

                if (dia > 15) dia = 2;
                else dia = 1;

                nominaId = (anio * 10000) + (mes * 100) + dia;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroIgualA("Nomina_Id", nominaId.ToString());
                if(oficinaId > 0 ) objDB.AddFiltroIgualA("Oficina_Id", oficinaId.ToString());

                DTDetalle = objDB.GetAll("VNOMINAS_DETALLE", -1, objDB.Filtros);
                dtgNominaDetalle.AutoGenerateColumns = false;
                dtgNominaDetalle.DataSource = DTDetalle.DefaultView;

                TotalizarDetalle();

                resp = objUtil.MostrarMensajePregunta("Desea Imprimir?");
                if (resp == DialogResult.Yes) Imprimir(nominaId.ToString());
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
            int nominaId = -1;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            DataRow fila0;
            DialogResult resp;

            try
            {
                //procedemos a Grabar los datos de Nomina
                if(DTDetalle != null)
                {
                    if(DTDetalle.Rows.Count > 0)
                    {
                        fila0 = DTDetalle.Rows[0];
                        resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Grabar la Nomina?");
                        if(resp == DialogResult.Yes)
                        {
                            Cursor = Cursors.WaitCursor;
                            temporalID = objUtil.GetAsString("IdentificadorTemp", fila0);
                            parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                            objDB.iniciarTransaccion();
                            nominaId = objDB.EjecutarSP("SP_NOMINA_GRABAR_NOMINA", parms);
                            if(nominaId <= 0)
                            {
                                MostrarErrorTemporal();
                                objDB.cancelarTransaccion();
                            }
                            else
                            {
                                objDB.confirmarTransaccion();
                                btnGrabar.Enabled = false;
                                objUtil.MostrarMensajeInformacion("Datos Registrados de Forma Satisfactoria...");
                                VerNomina();
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

            return nominaId;
        }

        public override bool Imprimir(string valorId = "", int tipoImp = 0)
        {
            bool resultado = false;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptRRHHNominaDetalle");

                frm.pathReporte = pathReporte;
                frm.DTData = DTDetalle;
                frm.DTOficina = DTOficina;
                frm.oficinaId = OFICINA_ID;
                frm.empresaId = EMPRESA_ID;
                frm.nombreUsuario = nombreUsuario;

                frm.AddParm("NOMINA_ID",valorId);
                frm.AddParm("OFICINA_NOMINA", "(TODAS)");

                frm.titulo = "NOMINA";

                frm.ShowDialog();
                resultado = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeInformacion(ex.Message, "Error al Imprimir Nomina");
            }

            return resultado;
        }

        private void txtFiltroNombre_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarData();
        }
    }
}
