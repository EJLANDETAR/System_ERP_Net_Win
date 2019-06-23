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
    public partial class FormValidarSolicitud : Form
    {
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        WinControl_ELR_NET.ELRUtils objUtil = new WinControl_ELR_NET.ELRUtils();
        DataRow drFila;
        int empresaId = 0, oficinaId = 0;
        bool esInicio = true;

        public int solicitudId = 0;
        public string nombreUsuario = "";

        public FormValidarSolicitud()
        {
            InitializeComponent();
        }

        private void FormValidarSolicitud_Activated(object sender, EventArgs e)
        {
            try
            {
                if(esInicio)
                {
                    esInicio = false;
                    validarRestrinciones();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReptValidacion_Click(object sender, EventArgs e)
        {
            validarRestrinciones();
        }

        private void FormValidarSolicitud_Load(object sender, EventArgs e)
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string nombre = "", cedulaRNC = "";
      
            try
            {
                DTData = db.GetById("VPRESTAMOS_SOLICITUDES", solicitudId.ToString(), "Solicitud_Id");
                if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];

                nombre = db.GetAsString("Nombres", fila0) + " " + db.GetAsString("Apellidos", fila0);
                cedulaRNC = db.GetAsString("CedulaRNC", fila0);

                lblSolicitudId.Text = "SOLICITUD NO.: " + solicitudId.ToString().PadLeft(7, '0');
                lblNombre.Text = nombre + @"       CEDULA\RNC: " + cedulaRNC;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void validarRestrinciones()
        {
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "", pathReporte, SSQL = "";
            int result = 0, conteo = 0;
            WinControl_ELR_NET.ELRFormMensajeErrores frmError = new WinControl_ELR_NET.ELRFormMensajeErrores();
            WinControl_ELR_NET.ELRFormPreviewRDLC frmRPT = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            DataTable DTData;
            try
            {
                Cursor = Cursors.WaitCursor;

                temporalId = objUtil.GetTemporalID();
                parms.Add(new DataDB_ELR_NET.Parametro("solicitudId", solicitudId));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                db.iniciarTransaccion();
                result = db.EjecutarSP("SP_SISTEMA_VALIDAR_SOLICITUD", parms);
                if (result > 0)
                {
                    db.confirmarTransaccion();

                    //Mostramos el Reporte de la Validacion Realizada
                    SSQL = "SELECT * FROM TSISTEMA_VALIDACION_RESTRINCIONES WHERE IdentificadorTemp ='" + temporalId + "' Order by Unico ";
                    DTData = db.GetSQL(SSQL);

                    //Mostramos los puntos a favor y en contra
                    conteo = (Int32) objUtil.GetSum("Valor", DTData, "Valor > 0");
                    lblPuntosAFavor.Text = "PUNTOS A FAVOR: " + conteo.ToString();

                    //Mostramos los puntos a favor y en contra
                    conteo = (Int32) objUtil.GetSum("Valor", DTData, "Valor < 0");
                    lblPuntosNegativos.Text = "PUNTOS NEGATIVOS: " + Math.Abs(conteo).ToString();

                    pathReporte = objUtil.GetPathReportRDLC("RptValidaciones");
                    frmRPT.AddDS("DSData", DTData);
                    frmRPT.pathReporte = pathReporte;
                    frmRPT.oficinaId = oficinaId;
                    frmRPT.empresaId = empresaId;
                    frmRPT.nombreUsuario = nombreUsuario;
                    frmRPT.titulo = "SOLICITUD NO.: " + solicitudId.ToString();

                    frmRPT.ShowDialog();
                    Cursor = Cursors.Default;

                }
                else
                {
                    Cursor = Cursors.Default;

                    //Mostramos mensaje error
                    frmError.objDB = db;
                    frmError.TemporalId = temporalId;
                    frmError.ShowDialog();
                }
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
    }
}
