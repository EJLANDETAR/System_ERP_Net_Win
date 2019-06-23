using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormSolicitudGarantiaVehiculo : WinControl_ELR_NET.ELRFormRegistro
    {
        public int solicitudId;

        public FormSolicitudGarantiaVehiculo()
        {
            InitializeComponent();
        }

        public override void PasarValorADS()
        {
            try
            {
                base.PasarValorADS();
                SetValorEncabezado("Solicitud_Id", solicitudId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
