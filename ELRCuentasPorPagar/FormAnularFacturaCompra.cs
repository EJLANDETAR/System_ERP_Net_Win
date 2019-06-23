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
    public partial class FormAnularFacturaCompra : WinControl_ELR_NET.FormPlantillaIndex
    {
        int suplidorId = 0;
        string cedulaRNC = "";

        public FormAnularFacturaCompra()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            string aBuscar = "";
            double total = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                Cursor = Cursors.WaitCursor;

                cedulaRNC = txtCedulaRNC.Text.Trim().Replace("-", "");
                if (cedulaRNC.Trim() == "0") cedulaRNC = "";
                aBuscar = txtABuscar.Text.Trim().Replace("-", "");
                aBuscar = aBuscar.Replace(" ", "%");

                parms.Add(new DataDB_ELR_NET.Parametro("suplidorId", suplidorId));
                parms.Add(new DataDB_ELR_NET.Parametro("cedulaRNC", cedulaRNC));
                parms.Add(new DataDB_ELR_NET.Parametro("aBuscar", aBuscar));

                MyData = objDB.GetFromSP ("SP_COMPRAS_GET_PARA_ANULAR", "",  parms);
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            string valorUnico = "0";
            DataRow fila0;
            int valorId = 0;
            FormAnularFacturaCompraR frm = new FormAnularFacturaCompraR();
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        valorId = objUtil.GetAsInt("CXP_Id", fila0);
                        frm.VALOR_ID = valorId.ToString();
                        frm.nombreUsuario = nombreUsuario;
                        frm.EnEjecusion = true;
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.ShowDialog();

                        if (frm.lOK) GetData();
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
                frm.Dispose();
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
