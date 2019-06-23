using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsInteresesGenPrestamos : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsInteresesGenPrestamos()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            double totalInteres = 0;
            double totalI0_30 = 0, totalI31_90 = 0, totalI91_120 = 0, totalI121 = 0;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString() );
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());
                objDB.AddFiltroMayorA("Interes", "0");

                if (txtABuscar.Text.Trim() != "")
                {
                    if (txtABuscar.Text.Trim() != "0") objDB.AddFiltroIgualA("Prestamo_Id", txtABuscar.Text.Trim());
                    
                }

                objDB.AddFiltroOrderBY("Fecha, Prestamo_Id, Cuota_No");

                MyData = objDB.GetAll("TPRESTAMOS_DEVENGO_DEMORA", -1, objDB.Filtros);
                dtgData.AutoGenerateColumns = false;
                dtgData.DataSource = MyData.DefaultView;

                totalInteres = GetSum("Interes");
                totalI0_30 = GetSum("Interes", "Nivel_Interes <= 1");
                totalI31_90 = GetSum("Interes", "Nivel_Interes = 2");
                totalI91_120 = GetSum("Interes", "Nivel_Interes = 3");
                totalI121 = GetSum("Interes", "Nivel_Interes > 3");

                lblTotal.Text = totalInteres.ToString("N2");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void FormConsInteresesGenPrestamos_Load(object sender, EventArgs e)
        {
            tsbBusquedaAvanzada.Enabled = false;
            dtpFecha1.Value = DateTime.Now.Date;
            dtpFecha2.Value = DateTime.Now.Date;
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            string descripcion = "";
            string valorUnico = "0";
            string cantidadDias = "0";
            DataRow MyFila;
            DateTime fecha1, fecha2;
            try
            {
                if (MyData.Rows.Count > 0)
                {
                    valorUnico = dtgData["Unico", dtgData.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];
                    cantidadDias = objUtil.GetAsString("Cantiadad_Dias", MyFila, "0");
                    fecha1 = objUtil.GetAsDate("Fecha_Desde", MyFila);
                    fecha2 = objUtil.GetAsDate("Fecha_Hasta", MyFila);

                    descripcion = cantidadDias + " DIAS DE INTERES, DESDE FECHA " + fecha1.ToShortDateString() + " HASTA FECHA " + fecha2.ToShortDateString();
                }

                txtDescripcion.Text = descripcion;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
