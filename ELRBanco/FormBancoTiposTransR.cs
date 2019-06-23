using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRBanco
{
    public partial class FormBancoTiposTransR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormBancoTiposTransR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0;
            string origen = "";
            try
            {
                resultado = base.GetData();
                if (resultado && esNuevo) origen = "D";

                if (resultado && !esNuevo)
                {
                    fila0 = DSDatos.Tables[0].Rows[0];
                    origen = objUtil.GetAsString("Origen", fila0).ToUpper();
                }

                if (origen == "D") cboOrigen.SelectedIndex = 0;
                else cboOrigen.SelectedIndex = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public override void PasarValorADS()
        {
            try
            {
                base.PasarValorADS();
                if (cboOrigen.SelectedIndex == 0) SetValorEncabezado("Origen", "D");
                else SetValorEncabezado("Origen", "C");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    
}
