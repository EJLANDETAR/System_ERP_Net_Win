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
    public partial class FormBancoConciliaciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTCuentasBanco;

        public FormBancoConciliaciones()
        {
            InitializeComponent();
        }

        private void FormBancoConciliaciones_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFecha1.Value = DateTime.Now.Date.AddDays(-30);
                dtpFecha2.Value = DateTime.Now.Date;

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                DTCuentasBanco = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1, objDB.Filtros);

                cboCuenta.DisplayMember = "Nombre";
                cboCuenta.ValueMember = "Cuenta_Id";
                cboCuenta.DataSource = DTCuentasBanco.DefaultView;

                RealizarBusquedaSencilla();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                
            }
        }

        public override void GetData(int opcion = 0)
        {
            try
            {
                objDB.LimpiarFiltros();

                if (cboCuenta.SelectedValue != null) objDB.AddFiltroIgualA("Cuenta_Id", cboCuenta.SelectedValue.ToString());

                objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(dtpFecha1.Value).ToString());
                objDB.AddFiltroMenorOIgualA("Fecha", objDB.DateToInt(dtpFecha2.Value).ToString());
                objDB.AddFiltroOrderBY("Fecha Desc, Unico");

                MyData = objDB.GetAll("VBANCOS_CONCILIACIONES", -1, objDB.Filtros);

                dtgConciliaciones.AutoGenerateColumns = false;
                dtgConciliaciones.DataSource = MyData.DefaultView;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            DataTable DTData;
            DataTable DTDetalle;
            WinControl_ELR_NET.ELRFormPreviewRDLC frmReporte = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string valorId = "0";
            int index;

            try
            {
                if(MyData.Rows.Count > 0)
                {
                    if (DataGridConsulta.CurrentRow != null)
                    {
                        index = DataGridConsulta.CurrentRow.Index;
                        valorId = DataGridConsulta["Conciliacion_Id", index].Value.ToString();
                    }
                    else
                    {
                        valorId = objUtil.GetAsString("Conciliacion_Id", MyData.Rows[0]);
                    }

                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA ("Conciliacion_Id", valorId);
                    DTData = objDB.GetAll("VBANCOS_CONCILIACIONES", 1, objDB.Filtros);
                    DTDetalle = objDB.GetAll("TBANCOS_CONCILIACIONES_DETALLES", 1, objDB.Filtros);

                    frmReporte.titulo = "CONCILIACION BANCARIA";
                    frmReporte.pathReporte = "RptBancoConciliacion";
                    frmReporte.nombreUsuario = nombreUsuario;
                    frmReporte.oficinaId = oficinaID;
                    frmReporte.empresaId = empresaID;

                    frmReporte.AddDS("DSData", DTData);
                    frmReporte.AddDS("DSDetalle", DTDetalle);

                    frmReporte.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frmReporte.Dispose();
            }
        }
    }
}
