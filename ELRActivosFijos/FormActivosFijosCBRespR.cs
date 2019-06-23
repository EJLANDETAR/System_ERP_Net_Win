using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRActivosFijos
{
    public partial class FormActivosFijosCBRespR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormActivosFijosCBRespR()
        {
            InitializeComponent();
        }

        void GetActivoFijo(int id = 0)
        {
            DataTable DTData;
            DataRow fila0 = null;
            FormActivosFijos frm = new FormActivosFijos();

            try
            {
                txtActivoId.Text = "0";
                txtActivoNombre.Text = "";
                txtDeResponsable.Text = "";

                if (id > 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIsNull("Fecha_Baja");

                    objDB.AddFiltroPersonalizado("(Activo_Id = " + id.ToString() + " Or Codigo_Barra = '" + id.ToString() + "')");
                    DTData = objDB.GetAll("TACTIVOS_FIJOS", 1, objDB.Filtros);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.nombreUsuario = nombreUsuario;
                    frm.FiltroEstatico = "EsActivo = 1 and Fecha_Baja Is Null";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    txtActivoId.Text = objUtil.GetAsString("Activo_Id", fila0, "0");
                    txtActivoNombre.Text = objUtil.GetAsString("Nombre", fila0, "");
                    txtDeResponsable.Text = objUtil.GetAsString("Responsable", fila0);
                    
                    txtActivoId.drFilaSel = fila0;

                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetActivoFijo();
        }

        private void txtActivoId_Leave(object sender, EventArgs e)
        {
            int valorId = 0;
            try
            {
                if (txtActivoId.drFilaSel == null)
                {
                    valorId = int.Parse(txtActivoId.Text);
                    if (valorId > 0) GetActivoFijo(valorId);
                    else txtActivoNombre.Text = "";
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtActivoId_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F9)) GetActivoFijo();
            else if ((e.KeyCode != Keys.Tab) && (e.KeyCode != Keys.Enter)) txtActivoId.drFilaSel = null;
        }
    }
}
