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
    public partial class FormReportesR : ELRFormRegistro
    {
        public FormReportesR()
        {
            InitializeComponent();
        }

        private void FormReportesR_Load(object sender, EventArgs e)
        {
            txtTablaOVista.CharacterCasing = CharacterCasing.Normal;
            txtFiltroEstatico.CharacterCasing = CharacterCasing.Normal;
            txtCampoID.CharacterCasing = CharacterCasing.Normal;
            txtReportRDLC.CharacterCasing = CharacterCasing.Normal;
        }
    }
}
