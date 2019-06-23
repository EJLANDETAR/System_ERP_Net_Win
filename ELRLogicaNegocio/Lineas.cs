using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELRLogicaNegocio
{
    public class Lineas
    {
        public string line;
        public bool esNegrita;

        public Lineas()
        {
            esNegrita = false;
        }

        public Lineas(string linea)
        {
            line = linea;
            esNegrita = false;
        }

        public Lineas(string linea, bool esNegrita)
        {
            this.line = linea;
            this.esNegrita = esNegrita;
        }


    }

   
}
