using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormGenerarProcesos : WinControl_ELR_NET.ELRFormRegistro
    {

        DateTime fecha;
        DateTime fechaUltGenerado;
        DataTable DTData;
        int contabilidadId = 0;

        public FormGenerarProcesos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            DataTable myData;
            string nombreSP;
            string descripcion;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            string temporalId;
            bool resultado = false;
            int cantErrores = 0;
            string mensaje = "";

            WinControl_ELR_NET.ELRFormMensajeErrores frmErrores = new WinControl_ELR_NET.ELRFormMensajeErrores();

            try
            {
                fecha = dtpFecha.Value.Date;
                cantErrores = 0;
                resultado = false;
                lblProcesoActual.Text = "PROCESO EN EJECUSION...";

                //VALIDAMOS LA FECHA DE CIERRE NO PUEDE SER MAYOR A LA ACTUAL
                if (objDB.DateToInt(fecha) > objDB.DateToInt(DateTime.Now.Date))
                {
                    resultado = false;
                    objUtil.MostrarMensajeAdvertencia("LA FECHA A CERRAR NO PUEDE SER MAYOR A LA FECHA ACTUAL");
                    return;
                }

                cantErrores = 0;
                temporalId = objUtil.GetTemporalID();

                progressBar1.Value = 0;
                progressBar1.Step = 1;
                progressBar1.Refresh();

                resultado = true;

                
                if ((DTData.Rows.Count > 0) && (resultado == true))
                {

                    resultado = false;
                    if (objDB.DateToInt(fechaUltGenerado) < objDB.DateToInt(fecha)) resultado = true;

                }

                if (resultado) 
                {
                    resp = objUtil.MostrarMensajePregunta("ESTA SEGURO DE REALIZAR EL CIERRE DE FECHA " + fecha.ToShortDateString() + "?");
                    if (resp != DialogResult.Yes) resultado = false;
                }


                if (resultado)
                {
                    objDB.iniciarTransaccion();

                    parametros.Add(new DataDB_ELR_NET.Parametro("Fecha", objDB.DateToInt(fecha).ToString()));
                    parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));

                    foreach (DataRow item in DTData.Rows)
                    {
                        if(cantErrores == 0)
                        {
                            this.Cursor = Cursors.WaitCursor;
                            resultado = false;

                            nombreSP = item["Nombre_SP"].ToString();
                            descripcion = item["Descripcion"].ToString();
                            lblProcesoActual.Text = descripcion;

                            //EJECUTAMOS EL STORE PROCEDURE

                            if (objDB.EjecutarSP(nombreSP, parametros) < 0)
                            {
                                cantErrores++;
                                resultado = false;
                                break;
                            }


                            progressBar1.PerformStep();
                            this.Cursor = Cursors.Default;
                            resultado = true;
                        }

                    }
                }


                //MOSTRAMOS LA VENTANA DE ERRORES
                if (cantErrores > 0)
                {
                    frmErrores.objDB = objDB;
                    frmErrores.TemporalId = temporalId;
                    frmErrores.ShowDialog();
                }

                if (resultado)
                {
                    fechaUltGenerado = fecha;
                    objDB.confirmarTransaccion();

                    mensaje = "PROCESO REALIZADO DE FORMA SATISFACTORIA";
                    if (contabilidadId > 0) mensaje += ", A CONTINUACION EL SISTEMA GENERARA LOS MOVIMIENTOS CONTABLES";

                    objUtil.MostrarMensajeInformacion(mensaje);

                    //GENERAMOS LA CONTABILIDAD
                    if (contabilidadId > 0) GenerarContabilidad();

                }
                else objDB.cancelarTransaccion();

                this.Cursor = Cursors.Default;

            }

            catch (Exception ex)
            {

                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmErrores.Dispose();
                myData = null;
            }

        }

        private void FormProcesos_Load(object sender, EventArgs e)
        {
            DataRow MiFila = null;
            string SSQL = "";

            if (EnEjecusion)
            {
                try
                {
                    btnGrabar.Visible = false;

                    //Vamos a Obtener La Fecha de los procesos Habilitados
                    fecha = objDB.GetFechaProcesos(EMPRESA_ID);
                    dtpFecha.Value = fecha.Date;

                    //VEMOS SI LA CONTABILIDAD ESTA ACTIVADA O NO
                    contabilidadId = 0;

                    SSQL = "SELECT IsNull(Max(Modulo_Id), 0) as Id From TSISTEMA_MODULOS Where EsActivo = 1 and Carpeta like 'CONTABILIDAD%' ";
                    DTData = objDB.GetSQL(SSQL);
                    contabilidadId = objUtil.GetAsInt("Id", DTData.Rows[0]);

                    //OBTENEMOS LA TABLA CON LOS PROCESOS A EJECUTAR
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroOrderBY("OrdenNo");
                    DTData = objDB.GetAll("TSISTEMA_PROCESOS_INTERNOS", -1, objDB.Filtros);

                    if (DTData.Rows.Count > 0)
                    {
                        if (DTData.Rows[0]["Fecha_Ult_Generado"] is DBNull) fechaUltGenerado = fecha.AddDays(-1);
                        else fechaUltGenerado = (DateTime)DTData.Rows[0]["Fecha_Ult_Generado"];
                    }

                    dtgProcesos.AutoGenerateColumns = false;
                    dtgProcesos.DataSource = DTData.DefaultView;

                    //INICIAMOS LA BARRA DE PROCESOS
                    progressBar1.Maximum = DTData.Rows.Count;
                    progressBar1.Value = 0;
                    progressBar1.Step = 1;

                }
                catch (Exception ex)
                {

                    objUtil.MostrarMensajeError(ex.Message);
                    Close();
                }
            }
        }

        int GenerarContabilidad()
        {

            ELRContaGeneral.FormContaGenerarContabilidad frm = new ELRContaGeneral.FormContaGenerarContabilidad();
            int resultado = 0;
            string valorVariable = "";
            bool esGenerarConta = false;

            try
            {
                valorVariable = objUtil.GetValorVariable("GENERAR_CONTABILIDAD_CON_CIERRE", DTVariablesSYS).ToUpper();
                esGenerarConta = (valorVariable == "TRUE" || valorVariable == "1");

                if (contabilidadId > 0 && esGenerarConta == true)
                {
                    frm.OFICINA_ID = OFICINA_ID;
                    frm.EMPRESA_ID = EMPRESA_ID;
                    frm.DTVariablesSYS = DTVariablesSYS;
                    frm.nombreUsuario = nombreUsuario;

                    frm.EnEjecusion = true;
                    frm.fecha = dtpFecha.Value.Date;

                    frm.ShowDialog();

                    if(frm.lOK) resultado = 1;
                }

            }
            catch (Exception ex)
            {
                resultado = -1;
                objUtil.MostrarMensajeError("Error al Generar Contabilidad, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                
            }

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarContabilidad();
        }
    }
}
