using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsultaMovimientoPorEntidad : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaMovimientoPorEntidad()
        {
            InitializeComponent();
        }

        void GetEntidad(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Entidad_Id, Nombres, Apellidos FROM TCLASIFICADOR_ENTIDADES";
                    SSQL += " WHERE Cast(Entidad_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = empresaID;
                    frm.oficinaID = oficinaID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Entidad_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCodigoEntidad.Text = id;
                txtNombreEntidad.Text = nombre;

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void GetData(int opcion = 0)
        {
            String SSQL = "";
            int fechaDesde = 0, fechaHasta = 0;
            int entidadId = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                int.TryParse(txtCodigoEntidad.Text, out entidadId);
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                SSQL = "SELECT * FROM FMOVIMIENTOS_POR_PRODUCTO(" + empresaID.ToString();
                SSQL += ", " + fechaDesde.ToString();
                SSQL += ", " + fechaHasta.ToString();
                SSQL += ")";
                SSQL += " WHERE 1= 1 and Entidad_Id > 0 ";

                if (entidadId > 0) SSQL += " and Entidad_Id = " + entidadId.ToString();
                SSQL += " Order by Fecha";

                MyData = objDB.GetSQL(SSQL);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;

                MostrarCantidadFilas();
                TotalizarData();
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

        public override void TotalizarData()
        {
            double totalEntrada = 0, totalSalida = 0, total = 0;
            try
            {
                if (MyData != null)
                {
                    totalEntrada = GetSum("Cantidad", "Cantidad > 0");
                    totalSalida = GetSum("Cantidad", "Cantidad < 0");
                    total = GetSum("Cantidad");
                }

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptMovimientosInventarioPorEntidad");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = @"MOVIMIENTOS DE INVENTARIO POR ENTIDAD, FECHA [ " + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
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

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            GetEntidad();
        }

        private void FormConsultaMovimientoPorEntidad_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        private void txtCodigoEntidad_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigoEntidad.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEntidad();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEntidad(codigo);
        }
    }
}
