using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRMaestros
{
    public partial class FormMunicipiosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormMunicipiosR()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormProvincias frm = new FormProvincias();
            int provinciaId = 0;
            try
            {
                frm.EsAgregar = false;
                frm.EsModificar = false;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;
                frm.oficinaID = OFICINA_ID;
                frm.empresaID = EMPRESA_ID;

                frm.ShowDialog();

                if(frm.filaSelecionada != null)
                {
                    provinciaId = objUtil.GetAsInt("Provincia_Id", frm.filaSelecionada);
                    cboProvincia.SelectedValue = provinciaId;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frm.Dispose();
            }
        }
    }
}
