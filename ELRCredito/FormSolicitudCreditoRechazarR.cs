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
    public partial class FormSolicitudCreditoRechazarR : WinControl_ELR_NET.ELRFormRegistro
    {
        public int solicitudId = 0;
        public double monto = 0.0;
        public string ANombre = "";

        public FormSolicitudCreditoRechazarR()
        {
            InitializeComponent();
        }

        private void FormSolicitudCreditoRechazarR_Load(object sender, EventArgs e)
        {
            try
            {
                lblSolicitudNo.Text = solicitudId.ToString().PadLeft(7, '0');
                lblMonto.Text = monto.ToString("N2");
                lblANombre.Text = ANombre.ToUpper();
                Text =  "RECHAZAR SOLICITUD NO.: " + solicitudId.ToString().PadLeft(7, '0');
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            string comentario = "";
            string identificadorTemp = "";
            DialogResult resp;
            
            
            WinControl_ELR_NET.ELRFormMensajeErrores objMsgERRORES = new WinControl_ELR_NET.ELRFormMensajeErrores();


            int resultado = -1;

            try
            {
                comentario = txtConcepto.Text.Trim();
                if (comentario.Length < 10)
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Indicar un Comentario Minimo 15 Caracteres");
                    txtConcepto.Focus();
                }
                else
                {
                    //EJECUTAMOS EL SP QUE PASA DEL TEMPORAL A LA TABLA DE OPERACIONES
                    resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Rechazar la Solicitud No.: " + solicitudId.ToString().PadLeft(8, '0') + "?");

                    if (resp == System.Windows.Forms.DialogResult.Yes)
                    {
                        identificadorTemp = objUtil.GetTemporalID();

                        MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", identificadorTemp));
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("SolicitudId", solicitudId));
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("Concepto", comentario));
                        MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_PRESTAMOS_SOLICITUD_RECHAZAR", MyParametros);
                        if (resultado < 0)
                        {


                            objMsgERRORES.TemporalId = identificadorTemp;
                            objMsgERRORES.objDB = objDB;

                            objMsgERRORES.ShowDialog();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            lOK = true;
                            Close();
                        }
                    }
                   
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                objDB.cancelarTransaccion();
            }

            return resultado;

        }
    }
}
