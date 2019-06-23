using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormSelEmpresa : Form
    {
        public int empresaId = 0;
        public int oficinaId = 0;
        public string nombreEmpresa = "";
        public string nombreOficina = "";
        public bool lOK = false;

        ELRUtils objUtil = new ELRUtils();
        
        public ELRFormSelEmpresa()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                nombreEmpresa = "";
                nombreOficina = "";

                if (cboEmpresa.SelectedValue != null)
                {
                    empresaId = (int)cboEmpresa.SelectedValue;
                    nombreEmpresa = cboEmpresa.Text.Trim().ToUpper();
                }
                if (cboOficina.SelectedValue != null)
                {
                    oficinaId = (int)cboOficina.SelectedValue;
                    nombreOficina = cboOficina.Text.Trim().ToUpper();
                }

                if ((empresaId > 0) && (oficinaId > 0))
                {
                    lOK = true;
                    this.Close();
                }
                else objUtil.MostrarMensajeError("Debe Seleccional Empresa y Oficina");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            lOK = false;
            oficinaId = 0;
            empresaId = 0;

            nombreOficina = "";
            nombreEmpresa = "";

            this.Close();
        }

        private void ELRFormSelEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                cboEmpresa.LlenarCombo();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
