using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public class ControlesMostrar
    {
        [Category("Controles")]
        public Label LabelControl { get; set; }
        [Category("Controles")]
        public TextBox TextBoxControl { get; set; }
        [Category("Controles")]
        public ComboBox ComboBoxControl { get; set; }

        [Category("Controles")]
        public NumericUpDown NumericUpDownControl { get; set; }

        [Category("Datos")]
        public string NombreCampo { get; set; }
        [Category("Datos")]
        public string Formato { get; set; }
        [Category("Datos")]
        public string ValorPorDefecto { get; set; }

        [Category("Otros")]
        public bool EsHabilitar { get; set; }

        public ControlesMostrar()
        {
            NombreCampo = "";
            Formato = "";
            ValorPorDefecto = "";
            EsHabilitar = false;
        }
    }
}
