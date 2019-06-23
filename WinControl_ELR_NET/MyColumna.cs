using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinControl_ELR_NET
{
    public class MyColumna
    {
        public string HeaderText { get; set; }
        public string NombreCampo { get; set; }
        public int Ancho { get; set; }
        public string Formato { get; set; }

        public MyColumna()
        {
            HeaderText = "";
            NombreCampo = "";
            Ancho = 100;
            Formato = "";
        }

        public MyColumna(string header, string nombreCampo, bool esId = false)
        {
            HeaderText = header;
            NombreCampo = nombreCampo;
            Ancho = 100;
        }

    }
}
