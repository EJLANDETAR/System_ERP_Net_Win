using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaCentroCostos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaCentroCostos()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            if (TablaOVista.ToUpper() == "VCONTA_AUXILIARES")
            {
                DataGridConsulta.Columns["Codigo"].DataPropertyName = "Codigo_Auxiliar";
                DataGridConsulta.Columns["Concepto"].DataPropertyName = "Descripcion";
                NombreCampoID = "Codigo_Auxiliar";
                txtABuscar.FiltroBusqueda = " Concepto Like '%' + @aBuscar + '%' ";
            }
            base.GetData(opcion);
        }
    }
}
