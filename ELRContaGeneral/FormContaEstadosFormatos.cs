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
    public partial class FormContaEstadosFormatos : WinControl_ELR_NET.FormPlantillaIndex
    {

        public int estadoId = 0;
        public string titulo = "";

        string valorUnico = "-1";

        public FormContaEstadosFormatos()
        {
            InitializeComponent();
        }


        private void FormContaEstadosFormatos_Load(object sender, EventArgs e)
        {
            if (EnEjecusion)
            {
                DataGridConsulta.SelectionMode = DataGridViewSelectionMode.CellSelect;
                lblTitulo.Text = "CONFIGURAR: " + titulo.ToUpper();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string formula = "";
            int tipoLinea = 0;
            DataRow fila0 = null;
            int index = 0;
            DataRow[] filas = null;

            try
            {
                txtFormula.Text = "";
                valorUnico = "-1";
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;

                if (DataGridConsulta.RowCount > 0 && index >= 0)
                {
                    valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                    filas = MyData.Select("Unico = " + valorUnico);

                    if (filas.Count() > 0)
                    {
                        fila0 = filas[0];

                        valorUnico = objUtil.GetAsString("Unico", fila0, "-1");
                        tipoLinea = objUtil.GetAsInt("Tipo_Linea", fila0);

                        if (tipoLinea == 0) formula = "Tipo: Linea Vacia; ";
                        else if (tipoLinea == 1) formula = "Tipo: Titulo; ";
                        else if (tipoLinea == 2) formula = "Tipo: total en Cuenta ";
                        else formula = "Tipo: Sum Linea; ";

                        formula += objUtil.GetAsString("Formula", fila0);
                    }
                }

                btnDown.Enabled = DataGridConsulta.RowCount > 1;
                btnUp.Enabled = DataGridConsulta.RowCount > 1;
                btnEliminar.Enabled = DataGridConsulta.RowCount > 0;

                txtFormula.Text = formula;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Agregar()
        {
            //base.Agregar();
            FormContaEstadosFormatosR frm = new FormContaEstadosFormatosR();
            try
            {
                frm.OFICINA_ID = oficinaID;
                frm.EMPRESA_ID = empresaID;
                frm.esNuevo = true;
                frm.nombreUsuario = nombreUsuario;
                frm.EnEjecusion = true;
                frm.estadoId = estadoId;

                frm.ShowDialog();

                if (frm.lOK) GetData();
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

        public override void ShowPreview()
        {
            DataTable DTData = null;
            string SSQL = "", pathReporte;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            try
            {
                SSQL = " SELECT *, 0.00 as Valor, 'PREVIEW' as Nombre_Mes, 0 as Anio, Cast(1 as Bit) EsAcumulado";
                SSQL += ", 0 as Mes_Ant, 0 as Mes_Ant_Anio, 'MES ANT' as Nombre_Mes_Anterior, 0.00 as Valor_Mes_Ant, 0 as Variacion";
                SSQL += ", '" + titulo + "' as Titulo ";
                SSQL += " FROM TCONTA_ESTADOS_FORMULAS ";
                SSQL += " WHERE Estado_Id = " + estadoId.ToString();
                SSQL += " And Fecha_Deleted Is Null ";
                SSQL += " Order By LineaNo, Unico ";

                DTData = objDB.GetSQL(SSQL);

                pathReporte = objUtil.GetPathReportRDLC("RptContaEstadosFinancieros");

                frm.pathReporte = pathReporte;
                frm.DTData = DTData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = titulo;
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

        private void btnDown_Click(object sender, EventArgs e)
        {
            Button btn;
            string temporalId = "";
            int mf = 0, spResult = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                if (valorUnico == "-1") return;
                Cursor = Cursors.WaitCursor;

                btn = (Button)sender;
                if (btn == btnUp) mf = -1;
                else mf = 1;

                temporalId = objUtil.GetTemporalID();
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                parms.Add(new DataDB_ELR_NET.Parametro("Unico", valorUnico));
                parms.Add(new DataDB_ELR_NET.Parametro("mf", mf));

                objDB.iniciarTransaccion();
                spResult = objDB.EjecutarSP("SP_CONTA_ESTADOS_FORMULAS_MOVER_LINEA", parms);
                if (spResult < 0)
                {
                    MostrarErrorTemporal(temporalId);
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    RealizarBusquedaSencilla();
                    for (int i = 0; i < DataGridConsulta.RowCount; i++)
                    {
                        if (valorUnico == DataGridConsulta["unico", i].Value.ToString())
                        {
                            DataGridConsulta.CurrentCell = DataGridConsulta["LineaNo", i];
                            break;
                        }
                    }
                }
                Cursor = Cursors.Default;
            }
            
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorUnico == "-1") return;

                if (objUtil.MostrarMensajePregunta("Esta Seguro de Eliminar esta Linea") == DialogResult.Yes)
                {
                    objDB.MarcarRegistroEliminado("TCONTA_ESTADOS_FORMULAS", valorUnico);
                    RealizarBusquedaSencilla();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
