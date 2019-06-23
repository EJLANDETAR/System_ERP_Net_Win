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
    public partial class FormContaConsultaCierre : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaConsultaCierre()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            double activos = 0, pasivos = 0, capital = 0, ingresos = 0, costos = 0, gastos = 0;
            double total1 = 0, total2 = 0;
            DataRow fila0 = null;
            string valorUnico = "0";
            int index = 0;
            DateTime fecha = DateTime.Now.Date;

            try
            {
                grbTotales.Text = "Total a Fecha de Corte 00/00/0000";

                if (MyData != null)
                {
                    if(MyData.Rows.Count > 0)
                    {
                        index = DataGridConsulta.CurrentRow.Index;
                        valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];

                        activos = objUtil.GetAsDouble("Total_Activos", fila0);
                        pasivos = objUtil.GetAsDouble("Total_Pasivos", fila0);
                        capital = objUtil.GetAsDouble("Total_Capital", fila0);
                        ingresos = objUtil.GetAsDouble("Total_Ingresos", fila0);
                        costos = objUtil.GetAsDouble("Total_Costos", fila0);
                        gastos = objUtil.GetAsDouble("Total_Gastos", fila0);

                        fecha = objUtil.GetAsDate("Fecha", fila0);
                        grbTotales.Text = "Total a Fecha de Corte " + objUtil.GetDateAsString(fecha);
                    }
                }

                txtActivos.Text = activos.ToString("N2");
                txtCostos.Text = costos.ToString("N2");
                txtGastos.Text = gastos.ToString("N2");
                total1 = activos + costos + gastos;

                txtPasivos.Text = pasivos.ToString("N2");
                txtCapital.Text = capital.ToString("N2");
                txtIngresos.Text = ingresos.ToString("N2");
                total2 = pasivos + capital + ingresos;

                lblTotal.Text = "Activos + Costos + Gastos = " + total1.ToString("N2") + "          Pasivos + Capital + Ingresos = " + total2.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
