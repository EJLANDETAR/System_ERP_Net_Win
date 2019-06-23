using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRMaestros
{
    public partial class FormEmpleadosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormEmpleadosR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0;
            string formaPago = "E";

            resultado = base.GetData();

            txtSalacioMensual.Enabled = esNuevo;

            if(!esNuevo)
            {
                btnGrabar.Enabled = false;

                fila0 = DSDatos.Tables[0].Rows[0];
                btnGrabar.Enabled = (fila0["Fecha_Baja"] is DBNull);
                formaPago = objUtil.GetAsString("Forma_Pago", fila0);

                if (formaPago.ToUpper() == "CHK") cboFormaPago.SelectedIndex = 1;
                else cboFormaPago.SelectedIndex = 0;

                if (btnGrabar.Enabled == false) objUtil.MostrarMensajeInformacion("Datos de Solo Lectura");
            }

            return resultado;
        }

        public override void PasarValorADS()
        {
            string formaPago = "";
            try
            {
                base.PasarValorADS();
                formaPago = cboFormaPago.SelectedIndex <= 0 ? "E" : "CHK";
                SetValorEncabezado("Forma_Pago", formaPago);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
