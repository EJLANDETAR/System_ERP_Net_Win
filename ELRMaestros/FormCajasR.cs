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
    public partial class FormCajasR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormCajasR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0;
            int valorId = 0;
            try
            {
                resultado = base.GetData();

                if(resultado && !esNuevo)
                {
                    fila0 = DSDatos.Tables[0].Rows[0];
                    valorId = objUtil.GetAsInt("Caja_Id", fila0);

                    txtCodigo.Text = valorId.ToString();
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
