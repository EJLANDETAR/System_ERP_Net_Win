using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormBuscarCXP : WinControl_ELR_NET.FormPlantillaIndex
    {
        int suplidorId = 0;
        string cedulaRNC = "";

        public FormBuscarCXP()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            string aBuscar = "";
            double total = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                cedulaRNC = txtCedulaRNC.Text.Trim();
                if (cedulaRNC.Trim() == "0") cedulaRNC = "";
                aBuscar = txtABuscar3.Text.Trim();

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroIgualA("EsNulo", "0");
                objDB.AddFiltroMayorOIgualA("Monto_Pendiente", "1");
                if (FiltroEstatico.Trim() != "") objDB.AddFiltroPersonalizado(FiltroEstatico);
                if (aBuscar != "")
                {
                    aBuscar = aBuscar.Replace("-", "");
                    objDB.AddFiltroContengaA("IsNull(Factura_No, '') + IsNull(NCF, '') ", aBuscar);
                }

                
                objDB.AddFiltroOrderBY("Unico Desc");
                MyData = objDB.GetAll("TCXP", -1, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
               

                total = GetSum("Monto_Pendiente");
                lblCantidadRegistro.Text = "Total Pendiente A Pagar: " + total.ToString("N2") + "   ";

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

        void GetEntidad(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", nombre = "(TODOS)";
            string cedulaRNC = "0";
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();

            try
            {
                suplidorId = 0;
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Entidad_Id, CedulaRNC, Nombres, Apellidos FROM TCLASIFICADOR_ENTIDADES";
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
                    frm.FiltroEstatico = "EsSuplidor = 1";


                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    suplidorId = objUtil.GetAsInt("Entidad_Id", fila0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                txtCedulaRNC.Text = cedulaRNC;
                txtNombre.Text = nombre;
                toolTip1.SetToolTip(txtNombre, nombre);

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        private void txtCedulaRNC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                string codigo = txtCedulaRNC.Text.Trim();
                if (e.KeyCode == Keys.F9) GetEntidad();
                else if (e.KeyCode == Keys.Enter && codigo != "") GetEntidad(codigo);
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
    }
}
