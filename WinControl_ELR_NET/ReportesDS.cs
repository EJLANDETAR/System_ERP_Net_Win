using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WinControl_ELR_NET
{
    public class ReportesDS
    {
        public string Nombre { get; set; }
        public DataTable Valor { get; set; }

        public ReportesDS()
        {

        }

        public ReportesDS(string nombre, DataTable valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
        }


    }

    
}
