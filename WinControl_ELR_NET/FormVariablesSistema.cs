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
    public partial class FormVariablesSistema : Form
    {

        public string variable = "";
        public string valor = "";
        public string comentario = "";

        public int valorUnico = 0;

        public bool lOK = false;

        ELRUtils objUtil = new ELRUtils();

        public FormVariablesSistema()
        {
            InitializeComponent();
        }

        private void FormVariablesSistema_Load(object sender, EventArgs e)
        {
            try
            {
                lOK = false;
                txtValor.CharacterCasing = CharacterCasing.Normal;

                txtVariable.Text = variable.Trim();
                txtValor.Text = valor.Trim();
                txtComentario.Text = comentario.Trim();

                txtVariable.Enabled = (valorUnico == 0);

                if (txtVariable.Enabled) txtVariable.Focus();
                else txtValor.Focus();
            }
            catch (Exception ex)
            {

                lOK = false;
                objUtil.MostrarMensajeError(ex.Message);

                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVariable.Text.Trim() == "") objUtil.MostrarMensajeAdvertencia("DEBE INDICAR EL NOMBRE DE LA VARIABLE");
                else
                {
                    variable = txtVariable.Text.Trim();
                    valor = txtValor.Text.Trim();
                    comentario = txtComentario.Text.Trim();

                    lOK = true;
                    Close();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }
    }
}
