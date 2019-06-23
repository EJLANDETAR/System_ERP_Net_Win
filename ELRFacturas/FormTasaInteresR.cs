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
    public partial class FormTasaInteresR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormTasaInteresR()
        {
            InitializeComponent();
        }

        public override bool ValidarDatos()
        {
            bool resultado = false;
            double legalPorcentaje, legalMonto;

            try
            {
                resultado = base.ValidarDatos();
                if(resultado)
                {
                    legalPorcentaje = objUtil.ConvertirANumero(txtPorcLegalizacion.Text);
                    legalMonto = objUtil.ConvertirANumero(txtLegalMonto.Text);

                    if(legalMonto > 0 && legalPorcentaje > 0)
                    {
                        resultado = false;
                        objUtil.MostrarMensajeError("La Legalizacion No puede coincidir Porcentaje Mayor a Cero y Monto Mayor a Cero, Por lo Meno Uno debe ser Cero (0)");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

    }
}
