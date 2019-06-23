using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinControl_ELR_NET
{
    public class MyReportParameter
    {
        public string nombre { get; set; }
        public string valor { get; set; }

        public MyReportParameter()
        {

        }

        public MyReportParameter(string nombre, string valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
