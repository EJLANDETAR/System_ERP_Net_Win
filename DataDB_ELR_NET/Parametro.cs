using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDB_ELR_NET
{
    public class Parametro
    {
        public string NombreCampo { get; set; }
        public object Valor { get; set; }
        public bool EsSalida { get; set; }

        public Parametro()
        {
            NombreCampo = "";
            Valor = "";
            EsSalida = false;
        }

        public Parametro(string nombreCampo, object valor)
        {
            this.NombreCampo = nombreCampo;
            this.Valor = valor;
            this.EsSalida = false;
        }

        public Parametro(string nombreCampo, object valor, bool esSalida)
        {
            this.NombreCampo = nombreCampo;
            this.Valor = valor;
            this.EsSalida = esSalida;
        }
    }
}
