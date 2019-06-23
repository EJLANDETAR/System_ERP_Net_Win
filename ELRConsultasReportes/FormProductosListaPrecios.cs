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
    public partial class FormProductosListaPrecios : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormProductosListaPrecios()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            int categoriaId = 0;
            try
            {
                int.TryParse(txtCodigo.Text, out categoriaId);

                FiltroEstatico = "EsActivo = 1 ";

                if (categoriaId > 0) FiltroEstatico += " And Categoria_Id = " + categoriaId.ToString();

                base.GetData(opcion);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            DateTime fecha = DateTime.Now.Date;

            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptProductosListaPrecios");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = Text + " A FECHA " + objUtil.GetDateAsString(fecha);
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

        void GetCategoria(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormCategoriaProducto frm = new ELRMaestros.FormCategoriaProducto();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Categoria_Id, Nombre FROM TCLASIFICADOR_PRODUCTOS_CATEGORIAS";
                    SSQL += " WHERE Cast(Categoria_Id as Varchar) = '" + codigo + "' ";

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
                    id = objUtil.GetAsString("Categoria_Id", fila0);
                    nombre = objUtil.GetAsString("Nombre", fila0);
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
            GetCategoria();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (e.KeyCode == Keys.F9) GetCategoria();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetCategoria(codigo);
        }
    }
}
