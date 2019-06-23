using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysProcesosERP
{
    public class Tarea
    {
        public string codigo { get; set; }
        public string nombre { get; set; }

        public Tarea()
        {
            
        }

        public Tarea(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
