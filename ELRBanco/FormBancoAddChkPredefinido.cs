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
    public partial class FormBancoAddChkPredefinido : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormBancoAddChkPredefinido()
        {
            InitializeComponent();
        }

        public override void PasarValorADS()
        {
            try
            {
                base.PasarValorADS();
                SetValorEncabezado("IdentificadorTemp", temporalID);
                SetValorEncabezado("Fecha", objDB.FECHA_CONTABLE);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
