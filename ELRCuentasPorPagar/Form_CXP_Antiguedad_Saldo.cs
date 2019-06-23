using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class Form_CXP_Antiguedad_Saldo : WinControl_ELR_NET.FormPlantillaIndex
    {
        public Form_CXP_Antiguedad_Saldo()
        {
            InitializeComponent();
        }

        public override void TotalizarData()
        {
            //base.TotalizarData();
            try
            {
                double total = GetSum("Monto_Pendiente");
                lblTotal.Text = "Total Cuenta Por Pagar:  " + total.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCXCPorAntiguedadSaldo2");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "CUENTAS POR PAGAR POR ANTIGUEDAD DE SALDO A FECHA:  " + objUtil.GetDateAsString(DateTime.Now);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }
    }
}
