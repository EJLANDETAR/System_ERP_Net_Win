using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinControl_ELR_NET
{
    public class Totaliza
    {
        public tbTipoTotaliza operacion { get; set; }
        public string NombreCampoDet { get; set; }
        public string filtro { get; set; }
        public string NombreCampoEnc { get; set; }
        public ELRLabel controlLabel { get; set; }
        public string Formato { get; set; }
        public int Redondeo { get; set; }

        public Totaliza()
        {
            operacion = tbTipoTotaliza.Sum;
            filtro = "ItemNumero > 0";
            NombreCampoEnc = "";
            NombreCampoDet = "";
            Formato = "N2";
            Redondeo = 2;
        }
    }
}
