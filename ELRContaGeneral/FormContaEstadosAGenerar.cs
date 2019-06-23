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
    public partial class FormContaEstadosAGenerar : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTData = null;
        DataTable DTEstados = null;
        DateTime aFecha = DateTime.Now.Date;

        public FormContaEstadosAGenerar()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            //return base.GetData();
            bool resultado = false;
            string SSQL = "";

            try
            {
                //Buscamos la Fecha a la que este actualizado
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroIgualA("EsActualizado", "1");
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroIsNull("Fecha_Deleted");
                objDB.AddFiltroOrderBY("Fecha Desc");
                DTData = objDB.GetAll("TCONTA_DIARIO_DETALLE", 1, objDB.Filtros);

                if (DTData.Rows.Count > 0)
                {
                    aFecha = objUtil.GetAsDate("Fecha", DTData.Rows[0]);
                    dtpAFecha.Enabled = false;
                }

                dtpAFecha.Value = aFecha;

                SSQL = " SELECT 0 as Estado_Id, '(TODOS)' as Descripcion, Cast(0 as Bit) as EsConAnexo ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Estado_Id, Descripcion, EsConAnexo FROM TCONTA_ESTADOS ";
                SSQL += " WHERE EsActivo = 1 And Empresa_Id = " + EMPRESA_ID.ToString();

                DTEstados = objDB.GetSQL(SSQL);

                cboEstado.DataSource = DTEstados;
                cboEstado.SelectedValue = 0;

                resultado = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        void GetEstadosGenerados()
        {
            int fecha = 0;
            int estadoId = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                fecha = objUtil.DateToInt(aFecha);
                if (cboEstado.SelectedValue != null) estadoId= int.Parse(cboEstado.SelectedValue.ToString());

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                objDB.AddFiltroIgualA("Fecha", fecha.ToString());
                objDB.AddFiltroIsNull("Fecha_Deleted");
                objDB.AddFiltroOrderBY("Oficina_Id, Estado_Id, Unico");

                if (estadoId > 0) objDB.AddFiltroIgualA("Estado_Id", estadoId.ToString());

                objDB.AddFiltroOrderBY("Fecha Desc");

                DTData = objDB.GetAll("VCONTA_ESTADOS_GENERADOS", -1, objDB.Filtros);
                dtgEstadosGenerados.AutoGenerateColumns = false;
                dtgEstadosGenerados.DataSource = DTData.DefaultView;
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

        void ImprimirEstado()
        {
            //base.Imprimir();
            string valorId = "0";
            DataRow fila0 = null;
            bool esAnexo = false;
            string nombreReporte = "", titulo = "";
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DataTable DTReportes = null;
            int oficinaId = 0;

            try
            {
                if (dtgEstadosGenerados.RowCount > 0)
                {
                    valorId = dtgEstadosGenerados["Registro_Id", dtgEstadosGenerados.CurrentRow.Index].Value.ToString();
                    fila0 = DTData.Select("Registro_Id = " + valorId)[0];
                    titulo = objUtil.GetAsString("Titulo", fila0) + " " + objUtil.GetAsString("Nombre_Mes", fila0) + " " + objUtil.GetAsString("Anio", fila0);
                    oficinaId = objUtil.GetAsInt("Oficina_Id", fila0);

                    if (oficinaId <= 0) oficinaId = OFICINA_ID;

                    esAnexo = objUtil.GetAsBoolean("EsAnexo", fila0);
                    
                    if (esAnexo) nombreReporte = "RptContaEstadosAnexos";
                    else nombreReporte = "RptContaEstadosFinancieros";

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Registro_Id", valorId);
                    objDB.AddFiltroOrderBY("Unico");
                    DTReportes = objDB.GetAll("VCONTA_ESTADOS_GENERADOS_DETALLES", -1, objDB.Filtros);

                    pathReporte = objUtil.GetPathReportRDLC(nombreReporte);
                    frm.pathReporte = pathReporte;
                    frm.DTData = DTReportes;
                    frm.oficinaId = oficinaId;
                    frm.empresaId = EMPRESA_ID;
                    frm.nombreUsuario = nombreUsuario;
                    frm.titulo = titulo;

                    frm.ShowDialog();

                }
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

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            int resultado = 0, oficinaId = 0, valor = 0;
            DataTable DTOficinas = null;
            string SSQL = "";
            bool esConAnexo = false;
            int estadoId = 0;
            List<DataDB_ELR_NET.Parametro> myParm = new List<DataDB_ELR_NET.Parametro>();
            DialogResult resp;

            try
            {
                resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Generar Estados Financieros?");
                if (resp != DialogResult.Yes) return -1;

                Cursor = Cursors.WaitCursor;

                temporalID = objUtil.GetTemporalID();
                SSQL = " SELECT 0 as Oficina_Id, '(TODAS)' as Nombre ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Oficina_Id, Nombre FROM TEMPRESAS_OFICINAS WHERE EsActivo = 1 And Empresa_Id = " + EMPRESA_ID.ToString();
                SSQL += " ORDER BY 1 ";
                DTOficinas = objDB.GetSQL(SSQL);

                if(cboEstado.SelectedValue != null) valor = int.Parse( cboEstado.SelectedValue.ToString() );

                foreach (DataRow item in DTOficinas.Rows)
                {
                    oficinaId = objUtil.GetAsInt("Oficina_Id", item);
                    if (resultado < 0) break;

                    foreach (DataRow fila0 in DTEstados.Rows)
                    {
                        estadoId = objUtil.GetAsInt("Estado_Id", fila0);
                        esConAnexo = objUtil.GetAsBoolean("EsConAnexo", fila0);

                        if (estadoId == 0) continue;

                        //Procedemos a Generar Estados ACUMULADO
                        myParm = new List<DataDB_ELR_NET.Parametro>();
                        myParm.Add(new DataDB_ELR_NET.Parametro("estadoId", estadoId));
                        myParm.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                        myParm.Add(new DataDB_ELR_NET.Parametro("oficinaId", oficinaId));
                        myParm.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                        myParm.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalID));

                        
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_ACUMULADO", myParm);
                        if ((esConAnexo) && (resultado > 0))
                        {
                            //Generamos Anexos Acumulados
                            myParm = new List<DataDB_ELR_NET.Parametro>();
                            myParm.Add(new DataDB_ELR_NET.Parametro("estadoId", estadoId));
                            myParm.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                            myParm.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalID));
                            myParm.Add(new DataDB_ELR_NET.Parametro("reporteId", resultado));
                            resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_ACUMULADO_ANEXOS", myParm);
                        }

                        if (resultado < 0)
                        {
                            objDB.cancelarTransaccion();
                            break;
                        }
                        else objDB.confirmarTransaccion();

                        //Generamos el Mensual
                        myParm = new List<DataDB_ELR_NET.Parametro>();
                        myParm.Add(new DataDB_ELR_NET.Parametro("estadoId", estadoId));
                        myParm.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                        myParm.Add(new DataDB_ELR_NET.Parametro("oficinaId", oficinaId));
                        myParm.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                        myParm.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalID));

                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ESTADO_MENSUAL", myParm);
                        if ((esConAnexo) && (resultado > 0))
                        {
                            //Generamos Anexos MENSUAL
                            myParm = new List<DataDB_ELR_NET.Parametro>();
                            myParm.Add(new DataDB_ELR_NET.Parametro("estadoId", estadoId));
                            myParm.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                            myParm.Add(new DataDB_ELR_NET.Parametro("identificadorTemp", temporalID));
                            myParm.Add(new DataDB_ELR_NET.Parametro("reporteId", resultado));
                        }

                        if (resultado < 0)
                        {
                            objDB.cancelarTransaccion();
                            break;
                        }
                        else objDB.confirmarTransaccion();


                        //SALIMOS DEL BUCLE SI EL ESTADO SELECCIONADO NO ES CERO
                        if (estadoId == valor) break;
                    }
                    
                }

                
                if(resultado > 0)
                {
                    objDB.confirmarTransaccion();
                    objUtil.MostrarMensajeInformacion("Estados Generados de Forma Satisfactoria...");     
                }
                else
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }

                GetEstadosGenerados();

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

            return resultado;
        }

        private void cboEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            GetEstadosGenerados();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void dtgEstadosGenerados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTData == null) return;
            if (DTData.Rows.Count <= 0) return;

            if (dtgEstadosGenerados.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0) ImprimirEstado();
        }

        private void FormContaEstadosAGenerar_Load(object sender, EventArgs e)
        {

        }
    }
}
