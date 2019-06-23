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
    public partial class FormCreditosIntDemGeneradas : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTDemoras = null;
        int prestamoId = 0;
        string nombre = "(TODOS)";
        public FormCreditosIntDemGeneradas()
        {
            InitializeComponent();
        }

        private void FormCreditosIntDemGeneradas_Load(object sender, EventArgs e)
        {
            dtpFecha1.Value = DateTime.Now.Date;
            dtpFecha2.Value = DateTime.Now.Date;

            GetData();
        }

        void GetDemoras()
        {
            int fechaDesde = 0, fechaHasta = 0;
            try
            {
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());
                objDB.AddFiltroMayorOIgualA("Demora", "1");
                objDB.AddFiltroIgualA("EsNulo", "0");

                if (prestamoId > 0) objDB.AddFiltroIgualA("Prestamo_Id", prestamoId.ToString());

                DTDemoras = objDB.GetAll("TPRESTAMOS_DEVENGO_DEMORA", -1, objDB.Filtros);
                dtgDemoras.AutoGenerateColumns = false;
                dtgDemoras.DataSource = DTDemoras.DefaultView;

            }
            catch (Exception)
            {

                throw;
            }
        }

        void GetIntereses()
        {
            int fechaDesde = 0, fechaHasta = 0;
            try
            {
                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());
                objDB.AddFiltroMayorOIgualA("Interes", "1");
                objDB.AddFiltroIgualA("EsNulo", "0");

                if (prestamoId > 0) objDB.AddFiltroIgualA("Prestamo_Id", prestamoId.ToString());

                MyData = objDB.GetAll("TPRESTAMOS_DEVENGO_DEMORA", -1, objDB.Filtros);
                dtgIntereses.AutoGenerateColumns = false;
                dtgIntereses.DataSource = MyData.DefaultView;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void GetData(int opcion = 0)
        {
            double totalInteres = 0, totalDemora = 0;
            try
            {
                Cursor = Cursors.WaitCursor;

                GetIntereses();
                GetDemoras();

                MostrarCantidadFilas();

                totalInteres = GetSum("Interes");
                totalDemora = GetSum("Demora", DTDemoras);

                lblCantidadRegistro.Text = "Total Intereses: " + totalInteres.ToString("N2");
                lblCantidadRegistro.Text += "          Total Demora: " + totalDemora.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void GetPrestamoNo(int numero)
        {
            string SSQL = "";
            DataRow fila0;
            DataTable DTData = null;
            DateTime fecha = DateTime.Now.Date;

            try
            {
                prestamoId = 0;
                nombre = "(TODOS)";

                SSQL = "SELECT TOP 1 Prestamo_Id, Fecha_Otorgado, ANombre FROM TPRESTAMOS WHERE Prestamo_Id = " + numero.ToString();
                DTData = objDB.GetSQL(SSQL);
                if(DTData.Rows.Count > 0)
                {
                    fila0 = DTData.Rows[0];
                    prestamoId = objUtil.GetAsInt("Prestamo_Id", fila0);
                    nombre = objUtil.GetAsString("ANombre", fila0);
                    fecha = objUtil.GetAsDate("Fecha_Otorgado", fila0);
                }

                dtpFecha1.Value = fecha;
                txtPrestamoNo.Text = prestamoId.ToString();
                txtNombre.Text = nombre;

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtPrestamoNo_KeyDown(object sender, KeyEventArgs e)
        {
            int numero = 0;
            int.TryParse(txtPrestamoNo.Text, out numero);

            if (e.KeyCode == Keys.Enter) GetPrestamoNo(numero);
        }
    }
}
