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
    public partial class FormCXC_Por_Antiguedad_Saldo : WinControl_ELR_NET.FormPlantillaIndex
    {
        int entidadId = 0;
        public FormCXC_Por_Antiguedad_Saldo()
        {
            InitializeComponent();
        }

        private void FormCXC_Por_Antiguedad_Saldo_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        private void chkPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecha1.Enabled = chkPorFecha.Checked;
            dtpFecha2.Enabled = chkPorFecha.Checked;

            GetData();
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

                txtCodigo.Text = id;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            GetEntidad();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (e.KeyCode == Keys.F9) GetEntidad();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEntidad(codigo);
        }


        public override void GetData(int opcion = 0)
        {
            int fechaDesde = 0, fechaHasta = 0;
            double total0_30, total31_60, total61_90, total91_120, total121;
            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                int.TryParse(txtCodigo.Text, out entidadId);

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());

                if (chkPorFecha.Checked)
                {
                    objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                    objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());
                }

                if (entidadId > 0) objDB.AddFiltroIgualA("Entidad_Id", entidadId.ToString());

                //ORDENAMOS POR DIAS DE ATRASO Y FECHA FACTURA
                objDB.AddFiltroOrderBY("Dias_Atrazo Desc, Fecha");

                MyData = objDB.GetAll("VCXC_ANTIGUEDAD_SALDO2", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                total0_30 = GetSum("Monto_P0_30");
                total31_60 = GetSum("Monto_P31_60");
                total61_90 = GetSum("Monto_P61_90");
                total91_120 = GetSum("Monto_P91_120");
                total121 = GetSum("Monto_P121");

                txt0_30.Text = total0_30.ToString("N2");
                txt31_60.Text = total31_60.ToString("N2");
                txt61_90.Text = total61_90.ToString("N2");
                txt91_120.Text = total91_120.ToString("N2");
                txt121.Text = total121.ToString("N2");


                Cursor = Cursors.Default;
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

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DateTime fecha = DateTime.Now.Date;
            string subTitulo = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCXCPorAntiguedadSaldo");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "CUENTAS POR COBRAR POR ANTGUUEDAD DE SALDO A FECHA: " + objUtil.GetDateAsString(fecha);

                subTitulo += "CLIENTE: " + txtNombre.Text;

                if(chkPorFecha.Checked)
                {
                    if (subTitulo.Trim() != "") subTitulo += ", ";
                    subTitulo += "FACTURAS EMITIDAS EN FECHA: [" + objUtil.GetDateAsString(dtpFecha1.Value) + " - " + objUtil.GetDateAsString(dtpFecha2.Value) + "]";
                }

                frm.AddParm("SUB_TITULO", subTitulo);

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
