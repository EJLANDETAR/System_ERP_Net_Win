using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormNominaVerDetalle : Form
    {
        public DataRow fila0;
        WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();
        public FormNominaVerDetalle()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNominaVerDetalle_Load(object sender, EventArgs e)
        {
            int nominaId = 0, quincenaNo = 0, mes = 0, anio = 0;
            DateTime fecha;
            string ANombre = "";
            int empleadoId = 0;
            string cedulaRNC = "";
            double salarioMensual = 0, sueldoBruto = 0, totalDescto = 0, sueldoNeto = 0;
            double DARS = 0, DAFP = 0, DARL = 0, DISR = 0, DARSDep = 0, DOTROS = 0, DPRESTAMOS;
            
            try
            {
                nominaId = objUtil.GetAsInt("Nomina_Id", fila0);
                quincenaNo = objUtil.GetAsInt("Quincena", fila0);
                mes = objUtil.GetAsInt("Mes", fila0);
                fecha = objUtil.GetAsDate("Fecha", fila0);
                ANombre = objUtil.GetAsString("Nombre", fila0);
                empleadoId = objUtil.GetAsInt("Empleado_Id", fila0);
                cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);

                salarioMensual = objUtil.GetAsDouble("Salario", fila0);
                sueldoBruto = objUtil.GetAsDouble("Monto_Bruto", fila0);
                totalDescto = objUtil.GetAsDouble("Total_Descuento", fila0);
                sueldoNeto = objUtil.GetAsDouble("Monto_APagar", fila0);

                DARS = objUtil.GetAsDouble("D_ARS", fila0);
                DAFP = objUtil.GetAsDouble("D_AFP", fila0);
                DARL = objUtil.GetAsDouble("D_ARL", fila0);
                DISR = objUtil.GetAsDouble("D_ISR", fila0);
                DOTROS = objUtil.GetAsDouble("D_OTROS", fila0);
                DPRESTAMOS = objUtil.GetAsDouble("D_PRESTAMO", fila0);
                DARSDep = objUtil.GetAsDouble("D_Seguro_Dep", fila0);

                lblNominaId.Text = "Nomina Id: " + nominaId.ToString();
                lblQuincenaNo.Text = "Quincena No.: " + quincenaNo.ToString();
                lblMes.Text = "Mes: " + mes.ToString() + " " + objUtil.GetNombreMes(mes);
                lblAnio.Text = "Año: " + fecha.Year.ToString();

                lblCodigoEmp.Text = "Codigo Empleado: " + empleadoId.ToString().PadLeft(6, '0') + "      ID: " + cedulaRNC;
                lblNombre.Text = "***" + ANombre + "***";

                txtSalarioMensual.Text = salarioMensual.ToString("N2");
                txtSueldoBruto.Text = sueldoBruto.ToString("N2");
                txtTotalDescto.Text = totalDescto.ToString("N2");
                txtSueldoNeto.Text = sueldoNeto.ToString("N2");

                txtDARS.Text = DARS.ToString("N2");
                txtDAFP.Text = DAFP.ToString("N2");
                txtDARL.Text = DARL.ToString("N2");
                txtDISR.Text = DISR.ToString("N2");
                txtDARSDep.Text = DARSDep.ToString("N2");
                txtDOtros.Text = DOTROS.ToString("N2");
                txtDPrestamos.Text = DPRESTAMOS.ToString("N2");

                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
