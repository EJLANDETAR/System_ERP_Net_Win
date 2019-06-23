using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace SysProcesosERP
{
    public partial class frmMain : Form
    {
        List<Proceso> procesosList = new List<Proceso>();
        List<Tarea> tareaList = new List<Tarea>();
        ELRUtils objUtil = new ELRUtils();
        DataTable DTData = null;
        DataTable DTTareasPendientes = null;
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        string mensajeError = "";

        public frmMain()
        {
            InitializeComponent();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            Proceso myProc = new Proceso();
            try
            {
                dtpFeDesde.Value = DateTime.Now.Date;
                dtpFeHasta.Value = DateTime.Now.Date;

                dtpError1.Value = DateTime.Now.Date;
                dtpError2.Value = DateTime.Now.Date;
                db.NOMBRE_USUARIO = objUtil.nombreUsuarioPC;

                lblEnEjecusion.Text = "EN EJECUSION DESDE:  " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

                //Marcamos las tareas no completada para entrar en cola otra vez
                myProc.colocarPendienteACola();

                llenarListTarea();

                chkAutoRefresh.Checked = true;
                showHistorial();

                timerEjecutaProcesos.Start();
            }
            catch (Exception ex)
            {

                mensajeError = ex.Message;
            }

        }

        void llenarListTarea()
        {
            tareaList = new List<Tarea>();
            tareaList.Add(new Tarea("BK", "REALIZAR BACKUP"));
            tareaList.Add(new Tarea("COPER", "CERRAR OPERACIONES"));
            tareaList.Add(new Tarea("CONTA", "GENERAR ASIENTOS CONTABLE"));
            tareaList.Add(new Tarea("DEMORA", "GENERAR DEMORA"));
            tareaList.Add(new Tarea("AF-DEPRE", "DEPRECIACION DE ACTIVOS FIJOS"));
            tareaList.Add(new Tarea("PGO-GTOS-FIJOS", "PAGO DE GASTOS FIJOS"));
            tareaList.Add(new Tarea("SP", "EJECUTAR STORE PROCEDURE"));

            //ANADIMOS TAREA DE MANTENIMIENTO DE LA BASE DE DATOS
            tareaList.Add(new Tarea("CLS-TBL-TEMP", "LIMPIAR TABLAS TEMPORALES"));
            tareaList.Add(new Tarea("LIMPIAR_LOG_DB", "LIMPIAR LOG FILE DATABASE"));
            tareaList.Add(new Tarea("DFOLDER_BK", "ELIMINAR ARCHIVOS BACKUP"));
            tareaList.Add(new Tarea("RB-DB-INDICES", "RECONSTRUIR INDICES"));

            cboTareas.DataSource = tareaList;
            cboTareas.ValueMember = "codigo";
            cboTareas.DisplayMember = "nombre";
            cboTareas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void showHistorial()
        {
            Proceso procSys = new Proceso();
            int index = -1, colId = -1;
            try
            {
                if (dtgHistorico.RowCount > 0)
                {
                    index = dtgHistorico.CurrentRow.Index;
                    colId = dtgHistorico.CurrentCell.ColumnIndex;
                }

                this.Cursor = Cursors.WaitCursor;

                DTData = procSys.GetHistorico(dtpFeDesde.Value, dtpFeHasta.Value);
                dtgHistorico.AutoGenerateColumns = false;
                dtgHistorico.DataSource = DTData;

                if (dtgHistorico.RowCount - 1 >= index)
                {
                    dtgHistorico.CurrentCell = dtgHistorico[colId, index];
                    dtgHistorico.CurrentCell.Selected = true;
                }
            }
            catch (Exception)
            {

                //objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        void showErrores()
        {
            Proceso procSys = new Proceso();
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DTData = procSys.GetErrorHistorico(dtpError1.Value, dtpError2.Value);
                dtgErrores.AutoGenerateColumns = false;
                dtgErrores.DataSource = DTData;
            }
            catch (Exception)
            {

                //objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        void addTarea()
        {
            Proceso myProceso = new Proceso();
            string codigo = "", descripcion = "";
            try
            {
                codigo = cboTareas.SelectedValue.ToString();
                descripcion = cboTareas.Text;

                if (codigo == "SP") return;

                tabControl1.SelectedIndex = 0;

                myProceso.addProceso(codigo, descripcion);

                showHistorial();

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

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            showHistorial();
        }

        private void timerEjecutaProcesos_Tick(object sender, EventArgs e)
        {
            string codigo = "";
            int valorUnico = 0, tareaId = 0;
            DateTime feActual = DateTime.Now;
            try
            {
                if (chkAutoRefresh.Checked)
                {
                    dtpFeDesde.Value = feActual.Date;
                    dtpFeHasta.Value = feActual.Date;
                }
                
                //Agregamos la tareas a la cola de ejecusion
                addTareasACola();

                //Buscamos las tareas pendientes
                db.LimpiarFiltros();
                db.AddFiltroNoIgualA("Codigo", "PI");
                db.AddFiltroIgualA("Estatus_Id", "0");
                db.AddFiltroIsNull("Fecha_Completado");
                db.AddFiltroIsNull("Fecha_Fin");
                db.AddFiltroOrderBY("Unico");
                DTTareasPendientes = db.GetAll("TSISTEMA_PROCESOS_LOG", -1, db.Filtros);

                stLabelFecha.Text = "FECHA: " + feActual.ToLongDateString().ToUpper() + "     " + feActual.ToLongTimeString().ToUpper();

                foreach (DataRow item in DTTareasPendientes.Rows)
                {
                    valorUnico = db.GetAsInt("Unico", item);
                    tareaId = db.GetAsInt("Tarea_Id", item);
                    codigo = db.GetAsString("Codigo", item).ToUpper().Trim();
                    Proceso myProc = new Proceso();
                    myProc.fecha = db.GetAsDate("Fecha", item);
                    myProc.identificadorId = db.GetAsInt("Identificador_Id", item);
                    myProc.codigo = codigo;
                    myProc.tareaId = tareaId;
                    myProc.nombre = db.GetAsString("Descripcion", item).ToUpper().Trim();
                    myProc.nombreSP = db.GetAsString("NombreSP", item).Trim();

                    //Marcamos la tarea como en proceso
                    myProc.setEstatus(1, valorUnico);

                    //if (codigo == "COPER") myProc.esReinicioOnError = true;

                    if (codigo == "BK")myProc.t = new Thread(myProc.realizarBackup);
                    if (codigo == "COPER") myProc.t = new Thread(myProc.realizarCierreOPE);
                    if (codigo == "DEMORA") myProc.t = new Thread(myProc.generarDemora);
                    if (codigo == "CONTA") myProc.t = new Thread(myProc.generarContabilidad);
                    if (codigo == "LIMPIAR_LOG_DB") myProc.t = new Thread(myProc.limpiarLogDB);
                    if (codigo == "DFOLDER_BK") myProc.t = new Thread(myProc.borrarFilesBK);
                    if (codigo == "CLS-TBL-TEMP") myProc.t = new Thread(myProc.limpiarTablasTemporales);
                    if(codigo == "PGO-GTOS-FIJOS") myProc.t = new Thread(myProc.GenerarPagoGastosFijos);
                    if(codigo == "AF-DEPRE") myProc.t = new Thread(myProc.GenerarAFDepreciacion);
                    if(codigo == "RB-DB-INDICES") myProc.t = new Thread(myProc.RebuildDBIndices);
                    if (codigo == "SP" && myProc.nombreSP != "") myProc.t = new Thread(myProc.EjecutaSP);

                    if (myProc.t != null)
                    {
                        myProc.t.Start();
                        procesosList.Add(myProc);
                    }

                    

                }

                for (int i = 0; i < procesosList.Count; i++)
                {
                    if (procesosList[i].estatusId != 0 && procesosList[i].estatusId != 1) procesosList.Remove(procesosList[i]);
                }

                lblCantidadActivos.Text = "CANTIDAD PROCESOS ACTIVOS: " + procesosList.Count.ToString("N0");
                ptbProcess.Visible = procesosList.Count > 0;


                if (chkAutoRefresh.Checked) showHistorial();

            }
            catch (Exception ex)
            {

                mensajeError = ex.Message;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnErrorBuscar_Click(object sender, EventArgs e)
        {
            showErrores();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            addTarea();
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSchedule frm = new FormSchedule();
            frm.nombreUsuario = objUtil.nombreUsuarioPC;
            frm.empresaID = 1;
            frm.oficinaID = 0;
            frm.EnEjecusion = true;
            frm.tareaList = tareaList;

            frm.ShowDialog();
        }

        void addTareasACola()
        {
            DateTime feActual = DateTime.Now;
            int hh = 0, mm = 0, ss = 00, conteo = 0, tareaId = 0;
            int cantSgdoRepite = 0, cantSgdoTranscurrido = 0, cantSegundosEnCola = 0;
            int diaActual = 0, diaIni = 0, diaFin = 0;
            bool esEjecutado = false;
            string SSQL = "";
            string sHora = "00:00:00";
            string codigo = "", nombre = "";
            Proceso myProc = new Proceso();
            DataTable DTData = null;
            int valorUnico = 0;
            DateTime feUltEjecutado = DateTime.Now;
            bool onlyOnce = true;

            try
            {
                hh = feActual.Hour;
                mm = feActual.Minute;
                ss = feActual.Second;
                diaActual = feActual.Day;

                sHora = hh.ToString().PadLeft(2, '0') + ":";
                sHora += mm.ToString().PadLeft(2, '0') + ":";
                sHora += ss.ToString().PadLeft(2, '0');

                //Buscamos la fecha de trabajo para agregar el cierre automatico si la fecha actual es mayor a fecha trabajo
                db.GetFechasOficina();
                if(db.DateToInt(feActual) > db.DateToInt(db.FECHA_TRABAJO))
                {
                    SSQL = "SELECT COUNT(*) as Conteo FROM TSISTEMA_PROCESOS_LOG WHERE Codigo = 'COPER' and Estatus_Id >= 0 AND Cast(Fecha as Date) = '" + db.DateToInt(db.FECHA_TRABAJO).ToString() + "' ";
                    DTData = db.GetSQL(SSQL);
                    conteo = db.GetAsInt("Conteo", DTData.Rows[0]);
                    if (conteo <= 0) myProc.addProceso("COPER", "CIERRE OPERACIONES");
                }

                SSQL = "SELECT * FROM VSISTEMA_PROCESOS_SCHEDULE WHERE EsActivo = 1 And Fecha_Ult_Cola IS NULL";
                SSQL += " And '" + sHora + "' between Hora_Inicio and Hora_Fin ";

                //Filtramos por dia de la semana
                switch (feActual.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        SSQL += " And EsDomingo = 1 ";
                        break;
                    case DayOfWeek.Monday:
                        SSQL += " And EsLunes = 1 ";
                        break;
                    case DayOfWeek.Tuesday:
                        SSQL += " And EsMartes = 1 ";
                        break;
                    case DayOfWeek.Wednesday:
                        SSQL += " And EsMiercoles = 1 ";
                        break;
                    case DayOfWeek.Thursday:
                        SSQL += " And EsJueves = 1 ";
                        break;
                    case DayOfWeek.Friday:
                        SSQL += " And EsViernes = 1 ";
                        break;
                    case DayOfWeek.Saturday:
                        SSQL += " And EsSabado = 1 ";
                        break;
                    default:
                        break;
                }

                //Buscamos la data y la insertamos en cola
                DTData = db.GetSQL(SSQL);
                foreach (DataRow item in DTData.Rows)
                {
                    valorUnico = db.GetAsInt("Unico", item);
                    tareaId = db.GetAsInt("Tarea_Id", item);
                    cantSgdoRepite = db.GetAsInt("CantSegundoRepite", item);
                    cantSgdoTranscurrido = db.GetAsInt("segundosTrascurridos", item);
                    cantSegundosEnCola = db.GetAsInt("CantSegundosEnCola", item);
                    feUltEjecutado = db.GetAsDate("Fecha_Ultima_Ejecusion", item, true);
                    onlyOnce = db.GetAsBoolean("onlyOnce", item);
                    esEjecutado = db.GetAsBoolean("EsEjecutado", item);
                    diaIni = db.GetAsInt("Dia_Inicio", item);
                    diaFin = db.GetAsInt("Dia_Fin", item);

                    if (onlyOnce && db.DateToInt(feUltEjecutado) >= db.DateToInt(feActual)) continue;
                    if (cantSgdoRepite > 0 && cantSgdoTranscurrido < cantSgdoRepite && esEjecutado) continue;
                    if(diaFin > 0 && diaIni > 0)
                    {
                        if(!(diaActual >= diaIni && diaActual <= diaFin)) continue;
                    }

                    //Actulizamos con la fecha en que se coloco en cola
                    SSQL = "UPDATE TSISTEMA_PROCESOS_SCHEDULE SET Fecha_Ult_Cola = GetDate() WHERE Unico = " + valorUnico.ToString();
                    db.EjecutarSQL(SSQL);

                    codigo = db.GetAsString("codigo", item);
                    nombre = db.GetAsString("Descripcion", item);
                    myProc.addProceso(codigo, nombre, tareaId);

                }


            }
            catch (Exception ex)
            {

                mensajeError = ex.Message;
            }
        }
    }
}
