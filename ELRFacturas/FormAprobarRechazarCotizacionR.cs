using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormAprobarRechazarCotizacionR : Form
    {
        public FormAprobarRechazarCotizacionR()
        {
            InitializeComponent();
        }

        private void FormAprobarRechazarCotizacionR_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
