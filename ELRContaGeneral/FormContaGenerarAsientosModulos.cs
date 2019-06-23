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
    public partial class FormContaGenerarAsientos : WinControl_ELR_NET.ELRFormRegistro
    {
        public bool cerrarAlGrabar = false;
        public bool esAuto = false;
        public DateTime fecha; 

        DataTable DTModulos = null;
        DataView DVData = null;

        public FormContaGenerarAsientos()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            string SSQL = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //return base.GetData();
                SSQL = " SELECT *, Cast(1 as bit) as EsAplicar ";
                SSQL += " FROM TCONTA_SP_GENERA_ASIENTOS ";
                SSQL += " WHERE EsActivo = 1 ";
                SSQL += " Order by Modulo_Id, NoOrden, Unico ";

                DTDetalle = objDB.GetSQL(SSQL);
                DVData = new DataView(DTDetalle);
                dtgOpciones.AutoGenerateColumns = false;
                dtgOpciones.DataSource = DVData;

                //Buscamos los Modulos
                SSQL = " SELECT 0 as Modulo_Id, '(TODOS)'  as Carpeta ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Modulo_Id, Carpeta FROM TSISTEMA_MODULOS WHERE EsActivo = 1 ";
                DTModulos = objDB.GetSQL(SSQL);
                cboModulo.ValueMember = "Modulo_Id";
                cboModulo.DisplayMember = "Carpeta";
                cboModulo.DataSource = DTModulos.DefaultView;
                cboModulo.SelectedValue = 0;

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

        private void cboModulo_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltrarData();
        }

        void FiltrarData()
        {
            int moduloId = 0;
            string aBuscar = "";
            string filtro = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;
                aBuscar = txtABuscar.Text.Trim();
                DVData.RowFilter = "";

                btnGrabar.Enabled = false;
                btnGenerar.Enabled = false;

                if (cboModulo.SelectedValue != null) moduloId = int.Parse(cboModulo.SelectedValue.ToString());

                if (moduloId > 0) filtro = "Modulo_Id = " + moduloId.ToString();
                if(aBuscar.Length > 0)
                {
                    if (filtro.Length > 0) filtro += " And Descripcion like '%" + aBuscar + "%'";
                    else filtro = " Descripcion like '%" + aBuscar + "%'";
                }

                DVData.RowFilter = filtro;
                dtgOpciones.DataSource = null;
                dtgOpciones.DataSource = DVData;

                if (dtgOpciones.RowCount > 0) dtgOpciones.CurrentCell = dtgOpciones["EsAplicar", 0];

                btnGrabar.Enabled = (dtgOpciones.RowCount > 0);
                btnGenerar.Enabled = (dtgOpciones.RowCount > 0);

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

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            int resultado = 0, conteo = 0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> myParms = new List<DataDB_ELR_NET.Parametro>();
            string valorUnico = "0";
            string nombreSP = "";
            bool esAplicar = false;
            DataRow fila0;
            int fechaDesde = 0, fechaHasta = 0;
            string SSQL = "";
            int nErrores = 0;
            int tipoId = 0, conteo1, conteo2;

            try
            {

                fechaDesde = objUtil.DateToInt(dtpFechaDesde.Value);
                fechaHasta = objUtil.DateToInt(dtpFechaHasta.Value);
                temporalID = objUtil.GetTemporalID();


                if (dtgOpciones.RowCount <= 0) return 0;

                resp = objUtil.MostrarMensajePregunta("Esta Seguro que Desea Generar Movimientos?");
                if (resp != DialogResult.Yes) return 0;

                //Buscamos el total de asientos contables
                conteo1 = objDB.GetConteoAsientos();

                for (int i = 0; i < dtgOpciones.RowCount; i++)
                {
                    if(nErrores == 0)
                    {
                        valorUnico = dtgOpciones["Unico", i].Value.ToString();
                        esAplicar = (bool)dtgOpciones["EsAplicar", i].Value;

                        if (esAplicar)
                        {
                            this.Cursor = Cursors.WaitCursor;
                            conteo++;

                            fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];
                            nombreSP = objUtil.GetAsString("Nombre_SP", fila0);
                            tipoId = objUtil.GetAsInt("Tipo_Id", fila0);

                            myParms = new List<DataDB_ELR_NET.Parametro>();
                            myParms.Add(new DataDB_ELR_NET.Parametro("PFechaDesde", fechaDesde));
                            myParms.Add(new DataDB_ELR_NET.Parametro("PFechaHasta", fechaHasta));
                            myParms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                            myParms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                            myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                            myParms.Add(new DataDB_ELR_NET.Parametro("TipoId", tipoId));

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
                            }

                        }
                    }

                }

                if ((resultado >= 0) && (conteo > 0))
                {
                    lOK = true;
                    //Buscamos el total de asientos contables
                    conteo2 = objDB.GetConteoAsientos();

                    objUtil.MostrarMensajeInformacion("SE HAN GENERADOS " + (conteo2 - conteo1).ToString("N0") + " ASIENTOS DE FORMA SATISFACTORIA");
                    if (DTMenu.Select("Formulario_AEjecutar = 'ELRContaGeneral.FormContaMovimientos'").Count()  > 0)
                    {
                        ejecutaForm("ELRContaGeneral.FormContaMovimientos");
                    }

                    if (cerrarAlGrabar) Close();
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

        private void FormContaGenerarAsientos_Load(object sender, EventArgs e)
        {
            if (EnEjecusion)
            {
                lOK = false;
                if (esAuto == false)
                {
                    dtpFechaDesde.Value = DateTime.Now.Date.AddDays(-7);
                    dtpFechaHasta.Value = DateTime.Now.Date;
                }
                else
                {
                    dtpFechaDesde.Value = fecha.Date;
                    dtpFechaHasta.Value = fecha.Date;
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GrabarDatos();
        }

        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            string valorUnico = "0";
            DataRow fila0;

            try
            {
                for (int i = 0; i < dtgOpciones.RowCount; i++)
                {
                    valorUnico = dtgOpciones["Unico", i].Value.ToString();
                    fila0 = DTDetalle.Select("Unico = " + valorUnico)[0];

                    if (fila0 != null) fila0["EsAplicar"] = chkMarcarTodos.Checked;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgOpciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtABuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarData();
        }

        private void btnIrACuentaEnlace_Click(object sender, EventArgs e)
        {
            FormContaConfigurarCuentas frm = new FormContaConfigurarCuentas();
            try
            {
                frm.EMPRESA_ID = EMPRESA_ID;
                frm.OFICINA_ID = OFICINA_ID;
                frm.nombreUsuario = nombreUsuario;
                frm.EnEjecusion = true;

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
