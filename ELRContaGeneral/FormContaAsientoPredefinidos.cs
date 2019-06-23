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
    public partial class FormContaAsientoPredefinidos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaAsientoPredefinidos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FormContaAsientoPredefinidosGenerar frm = new FormContaAsientoPredefinidosGenerar();
            try
            {
                frm.EMPRESA_ID = empresaID;
                frm.OFICINA_ID = oficinaID;
                frm.nombreUsuario = nombreUsuario;
                frm.EnEjecusion = true;

                frm.ShowDialog();

                if (frm.lOK) RealizarBusquedaSencilla();
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
