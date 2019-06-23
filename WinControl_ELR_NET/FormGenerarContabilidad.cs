using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WinControl_ELR_NET
{
    public partial class FormGenerarContabilidad : WinControl_ELR_NET.ELRFormRegistro
    {

        public DateTime fecha = DateTime.Now.Date;
        public bool esAutomatico = false;

        bool esInicio = true;
        string SSQL = "";
        DataTable DTDiario;
        int maxUnico = 0;

        public FormGenerarContabilidad()
        {
            InitializeComponent();
        }

        void GeneraConta()
        {
            if (esInicio && !isError) GrabarDatos();
        }

        private void FormContaGenerarContabilidad_Load(object sender, EventArgs e)
        {
            if (esAutomatico && esInicio)
            {
                Thread thread = new Thread(new ThreadStart(GeneraConta));
            }
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
            int conteo = 0, tipoId = 0;
            int nErrores = 0;
            DataTable DTCierre = null;
            DateTime fechaCierre = DateTime.Now.Date;

            try
            {

                fechaDesde = objUtil.DateToInt(objUtil.getPrimeraFechaMes(fecha));
                fechaHasta = objUtil.DateToInt(fecha);

                //Buscamos la fecha de ultimo cierre
                SSQL = "SELECT TOP 1  FECHA FROM TCONTA_CONTROL_CIERRE ";
                SSQL += " WHERE Empresa_Id = " + EMPRESA_ID.ToString();
                SSQL += " Order by Fecha Desc ";
                DTCierre = objDB.GetSQL(SSQL);
                if(DTCierre.Rows.Count > 0)
                {
                    fechaCierre = objUtil.GetAsDate("Fecha", DTCierre.Rows[0]);
                    if (fechaDesde <= objUtil.DateToInt(fechaCierre))
                    {
                        fechaCierre = fechaCierre.AddDays(1);
                        fechaDesde = objUtil.DateToInt(fechaCierre);
                        fechaHasta = objUtil.DateToInt(fechaCierre);
                    }
                }

                
                temporalID = objUtil.GetTemporalID();

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
                        tipoId = objUtil.GetAsInt("Tipo_Id", fila);
                        lblProcesoActual.Text = objUtil.GetAsString("Descripcion", fila);

                        myParms.Clear();
                        myParms.Add(new DataDB_ELR_NET.Parametro("PFechaDesde", fechaDesde));
                        myParms.Add(new DataDB_ELR_NET.Parametro("PFechaHasta", fechaHasta));
                        myParms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                        myParms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                        myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        myParms.Add(new DataDB_ELR_NET.Parametro("tipoId", tipoId));

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

                if (resultado > 0 && !isError)
                {
                    lOK = true;
                    SSQL = "SELECT COUNT(*) as Conteo FROM TCONTA_DIARIO WHERE Unico > " + maxUnico.ToString() + " And Empresa_Id = " + EMPRESA_ID.ToString();
                    DTDiario = objDB.GetSQL(SSQL);
                    conteo = objDB.GetAsInt("Conteo", DTDiario.Rows[0]);

                    lblProcesoActual.Text = "CANTIDAD ASIENTOS GENERADOS: " + conteo.ToString("N0");

                    //PROCEDEMOS A ACTUALIZAR EL CATALOGO DE CUENTAS
                    Cursor = Cursors.WaitCursor;
                    myParms.Clear();
                    myParms.Add(new DataDB_ELR_NET.Parametro("PFechaDesde", fechaDesde));
                    myParms.Add(new DataDB_ELR_NET.Parametro("PFechaHasta", fechaHasta));
                    myParms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                    myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_CONTA_ACTUALIZAR_CATALOGO", myParms);
                    if (resultado < 0)
                    {
                        isError = false;
                        MostrarErrorTemporal();
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        objDB.confirmarTransaccion();
                    }
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

            if (esAutomatico) btnCancelar.PerformClick();
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
