using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaGenerarContabilidad : WinControl_ELR_NET.ELRFormRegistro
    {

        public DateTime fecha = DateTime.Now.Date;
        bool esInicio = false;
        string SSQL = "";
        DataTable DTDiario;
        int maxUnico = 0;

        public FormContaGenerarContabilidad()
        {
            InitializeComponent();
        }

        private void FormContaGenerarContabilidad_Load(object sender, EventArgs e)
        {

        }

        public override bool GetData()
        {
            bool resultado = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //Obtenemos el Ultimo Unico Generado en el Diario
                SSQL = "SELECT IsNull(MAX(Unico), 0) as Unico FROM TCONTA_DIARIO WHERE Empresa_Id = " + EMPRESA_ID.ToString();
                DTDiario = objDB.GetSQL(SSQL);
                maxUnico = objDB.GetAsInt("Unico", DTDiario.Rows[0]);

                //return base.GetData();
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                objDB.AddFiltroOrderBY("Modulo_Id, NoOrden, Unico");
                DTDetalle = objDB.GetAll("TCONTA_SP_GENERA_ASIENTOS", -1, objDB.Filtros);

                resultado = true;
                esInicio = true;
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            return resultado;
        }

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            int resultado = 0;
            List<DataDB_ELR_NET.Parametro> myParms = new List<DataDB_ELR_NET.Parametro>();
            string nombreSP = "";
            int fechaDesde = 0, fechaHasta = 0;
            int conteo = 0;
            int nErrores = 0;

            try
            {

                fechaDesde = objUtil.DateToInt(fecha);
                fechaHasta = objUtil.DateToInt(fecha);
                temporalID = objUtil.GetTemporalID();

                myParms.Add(new DataDB_ELR_NET.Parametro("PFechaDesde", fechaDesde));
                myParms.Add(new DataDB_ELR_NET.Parametro("PFechaHasta", fechaHasta));
                myParms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                myParms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                pgbProcesos.Maximum = DTDetalle.Rows.Count;
                pgbProcesos.Value = 0;
                pgbProcesos.Step = 1;
                Refresh();

                foreach (DataRow fila in DTDetalle.Rows)
                {
                    if (nErrores > 0) break;

                    if (nErrores == 0)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        nombreSP = objUtil.GetAsString("Nombre_SP", fila);
                        lblProcesoActual.Text = objUtil.GetAsString("Descripcion", fila);

                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP(nombreSP, myParms);
                        if (resultado < 0)
                        {
                            nErrores++;
                            MostrarErrorTemporal();
                            objDB.cancelarTransaccion();
                            break;
                        }
                        else
                        {
                            this.Cursor = Cursors.Default;
                            objDB.confirmarTransaccion();
                            pgbProcesos.PerformStep();
                            Refresh();
                        }
                    }
                }

                if (resultado > 0)
                {
                    lOK = true;
                    SSQL = "SELECT COUNT(*) as Conteo FROM TCONTA_DIARIO WHERE Unico > " + maxUnico.ToString() + " And Empresa_Id = " + EMPRESA_ID.ToString();
                    DTDiario = objDB.GetSQL(SSQL);
                    conteo = objDB.GetAsInt("Conteo", DTDiario.Rows[0]);

                    lblProcesoActual.Text = "CANTIDAD ASIENTOS GENERADOS: " + conteo.ToString("N0");
                }


            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            return resultado;
        }

        private void FormContaGenerarContabilidad_Activated(object sender, EventArgs e)
        {
            if (esInicio)
            {
                GrabarDatos();
                esInicio = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
    }
}
