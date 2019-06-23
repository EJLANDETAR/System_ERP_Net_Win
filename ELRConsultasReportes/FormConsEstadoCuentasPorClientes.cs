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
    public partial class FormConsEstadoCuentasPorClientes : WinControl_ELR_NET.FormPlantillaIndex
    {

        DataTable DTFacturasPend = null;
        string cedulaRNC = "000000000";
        public FormConsEstadoCuentasPorClientes()
        {
            InitializeComponent();
        }

        private void FormConsEstadoCuentasPorClientes_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha2.Value = fecha;
            dtpFecha1.Value = fecha.AddMonths(-1);

            GetData();
        }

        void GetEntidad(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();
            DateTime fechaAdicionado = DateTime.Now.Date;

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                fechaAdicionado = dtpFecha1.Value;
                cedulaRNC = "000000000";
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
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0, "000000000");
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
            int entidadId = 0;
            double saldo = 0, totalDebito = 0, totalCredito = 0;
            string SSQL = "";
            double debito = 0, credito = 0;


            try
            {
                Cursor = Cursors.WaitCursor;

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);
                int.TryParse(txtCodigo.Text, out entidadId);

                SSQL = "SELECT * FROM FN_CLIENTES_ESTADO_CUENTAS(";
                SSQL += empresaID.ToString() + ", ";
                SSQL += "'" + fechaDesde.ToString() + "', ";
                SSQL += "'" + fechaHasta.ToString() + "', ";
                SSQL += entidadId.ToString();
                SSQL += ") ";
                SSQL += " Order By Fecha";

                MyData = objDB.GetSQL(SSQL);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
                MostrarCantidadFilas();

                
                totalDebito = GetSum("Debito");
                totalCredito = GetSum("Credito");
                saldo = totalDebito - totalCredito;

               

                //Carculamos el Saldo a la Fecha
                saldo = 0; debito = 0; credito = 0;
                foreach (DataRow item in MyData.Rows)
                {
                    debito = objUtil.GetAsDouble("Debito", item);
                    credito = objUtil.GetAsDouble("Credito", item);

                    saldo += (debito - credito);
                    item["Saldo"] = saldo;
                }

                //Buscamos las FacturasPendiente por Cobrar
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroMayorA("Monto", "0");
                objDB.AddFiltroMayorA("Balance", "0");
                objDB.AddFiltroNoIgualA("Estatus_Id", "N");

                if (entidadId > 0) objDB.AddFiltroIgualA("Entidad_Id", entidadId.ToString());

                DTFacturasPend = objDB.GetAll("TPRESTAMOS", -1, objDB.Filtros);
                dtgFacturas.AutoGenerateColumns = false;
                dtgFacturas.DataSource = DTFacturasPend.DefaultView;

                saldo = GetSum("Balance", DTFacturasPend);
                lblCantidadRegistro.Text = "Total Debitado: " + totalDebito.ToString("N2");
                lblCantidadRegistro.Text += "        Total Acreditado: " + totalCredito.ToString("N2");
                lblCantidadRegistro.Text += "        Balance: " + saldo.ToString("N2");


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
            DateTime fecha = DateTime.Now;
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptEstadoCuentasClientes");

                frm.pathReporte = pathReporte;

                frm.AddDS("DSData", MyData);
                frm.AddDS("DSFacturas", DTFacturasPend);
                frm.AddParm("NOMBRE", txtNombre.Text);
                frm.AddParm("CEDULA_RNC", cedulaRNC);
                frm.AddParm("FECHA_DESDE", objUtil.GetDateAsString(dtpFecha1.Value));
                frm.AddParm("FECHA_HASTA", objUtil.GetDateAsString(dtpFecha2.Value));

                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "ESTADO DE CUENTA CLIENTE, A FECHA: " + objUtil.GetDateAsString(fecha);
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
