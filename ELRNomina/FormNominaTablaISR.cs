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
    public partial class FormNominaTablaISR : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormNominaTablaISR()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            DialogResult resp;
            DataRow fila0;
            double montoDesde = 0, montoHasta = 0, cuotaFija = 0, tasaExcedente = 0;
            string valorUnico = "0";
            string mensaje = "";
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        montoDesde = objUtil.GetAsDouble("Monto_Desde", fila0);
                        montoHasta = objUtil.GetAsDouble("Monto_Hasta", fila0);
                        cuotaFija = objUtil.GetAsDouble("Cuota_Fija", fila0);
                        tasaExcedente = objUtil.GetAsDouble("Tasa_Excedente", fila0);

                        mensaje = "Esta Seguro que Desea Borrar?\r\r";
                        mensaje += "Desde: " + montoDesde.ToString("N2") + "\r";
                        mensaje += "Hasta: " + montoHasta.ToString("N2") + "\r";
                        mensaje += "Cuota Fija: " + cuotaFija.ToString("N2") + "\r";
                        mensaje += "Excedente: " + tasaExcedente.ToString("N2") + "\r";

                        resp = objUtil.MostrarMensajePregunta(mensaje);

                        if(resp == DialogResult.Yes)
                        {
                            objDB.MarcarRegistroEliminado(TablaOVista, valorUnico, "Unico");
                            GetData();
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
