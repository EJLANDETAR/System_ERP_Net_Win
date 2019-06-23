using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRActivosFijos
{
    public partial class FormActivosFijosDepreciacionR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormActivosFijosDepreciacionR()
        {
            InitializeComponent();
        }

        private void FormActivosFijosDepreciacionR_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            temporalID = objUtil.GetTemporalID();
        }

        private void btnGenerarDepreciacion_Click(object sender, EventArgs e)
        {
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            DataTable DTData;
            double total = 0;
            int cantidad = 0;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                lblTotal.Text = "Cantidad: 0            Total: 00.00";
                btnGrabar.Enabled = false;
                DataGridDetalle.AutoGenerateColumns = false;
                DataGridDetalle.DataSource = null;

                parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parametros.Add(new DataDB_ELR_NET.Parametro("Fecha", objDB.DateToInt(dtpFecha.Value) ));
                parametros.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario ));

                objDB.iniciarTransaccion();

                LimpiarDetalleTemporal();

                spReturn = objDB.EjecutarSP("SP_ACTIVOS_FIJOS_GENERAR_DEPRE_TEMPORAL", parametros);

                if(spReturn < 0) MostrarErrorTemporal();
                else
                {
                    objDB.confirmarTransaccion();
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("IdentificadorTemp", temporalID);
                    DTData = objDB.GetAll("TTEMPORAL_ACTIVOS_FIJOS_MOVIMIENTOS", -1, objDB.Filtros);

                    cantidad = DTData.Rows.Count;
                    total = GetSum("Monto", DTData);
                    lblTotal.Text = "Cantidad: " + cantidad.ToString() + "               Total: " + total.ToString("N2");

                    DataGridDetalle.DataSource = DTData.DefaultView;
                    btnGrabar.Enabled = (DTData.Rows.Count > 0);
                }

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

        public override bool GetData()
        {
            //return base.GetData();
            return true;
        }
        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            int spReturn = 0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            DateTime fecha;
            try
            {
                fecha = dtpFecha.Value.Date;
                resp = objUtil.MostrarMensajePregunta("Esta Seguro de Aplicar Esta Depreciacion?");
                if(resp== DialogResult.Yes)
                {
                    objDB.iniciarTransaccion();
                    parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    spReturn = objDB.EjecutarSP("SP_ACTIVOS_FIJOS_GRABA_DEPRECIACION", parametros);
                    if (spReturn < 0) MostrarErrorTemporal();
                    else
                    {
                        objDB.confirmarTransaccion();
                        objUtil.MostrarMensajeInformacion("Depreciacion Aplicada de Forma Satisfactoria...");
                        TituloReporte = "DEPRECIACION NO. " + spReturn.ToString() + ", CORRESPONDIENTE A " + objUtil.GetNombreMes(fecha.Month) + " " + fecha.Year.ToString();
                        Imprimir(spReturn.ToString());
                        lOK = true;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return spReturn;
        }

        public override void ImprimirEnMatricial()
        {
            //base.ImprimirEnMatricial();
            ImprimirPreviewRDLC();
        }

        public override void ImprimirEnOtroFormato()
        {
            //base.ImprimirEnOtroFormato();
            ImprimirPreviewRDLC();
        }

        public override void ImprimirTicket()
        {
            //base.ImprimirTicket();
            ImprimirPreviewRDLC();
        }
    }
}
