using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaMovimientosContrapartidas : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaMovimientosContrapartidas()
        {
            InitializeComponent();
        }

        private void FormContaMovimientosContrapartidas_Load(object sender, EventArgs e)
        {
            string SSQL = "";
            DataTable DTTipo = null;
            try
            {
                if (objUtil == null) objUtil = new WinControl_ELR_NET.ELRUtils();

                dtpFecha1.Value = objUtil.getPrimeraFechaMes(DateTime.Now.Date);
                dtpFecha2.Value = DateTime.Now.Date;

                SSQL = " SELECT 0 as Tipo_Id, '(TODOS)' as Decripcion, 0 as Modulo_Id ";
                SSQL += " UNION ALL ";
                SSQL += " SELECT Tipo_Id, REPLACE(Descripcion, 'GENERAR ', '') Descripcion, Modulo_Id ";
                SSQL += " FROM TCONTA_SP_GENERA_ASIENTOS ";
                SSQL += " Order by Modulo_Id, Tipo_Id ";

                DTTipo = objDB.GetSQL(SSQL);
                cboTipo.DataSource = DTTipo.DefaultView;
                cboTipo.SelectedValue = 0;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void RealizarBusquedaSencilla()
        {
            int fechaDesde = 0, fechaHasta = 0;
            int tipoId = 0;

            try
            {
                if (objUtil == null) objUtil = new WinControl_ELR_NET.ELRUtils();

                fechaDesde = objUtil.DateToInt(dtpFecha1.Value);
                fechaHasta = objUtil.DateToInt(dtpFecha2.Value);

                objDB.LimpiarFiltros();
                objDB.AddFiltroMayorOIgualA("Fecha", fechaDesde.ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", fechaHasta.ToString());

                if (cboTipo.SelectedValue != null)
                {
                    tipoId = int.Parse(cboTipo.SelectedValue.ToString());
                    if (tipoId > 0) objDB.AddFiltroIgualA("TipoAutom", tipoId.ToString());
                }

                GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
