using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormAnular : Form
    {
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        ELRUtils objUtil = new ELRUtils();
        string identificadorId = "";
        string numero = "0";
        int valorUnico = 0;


        //Variables publicas
        public string NOMBRE_USUARIO = "";
        public string SP_ANULA = "";
        public DataRow drFilaSel = null;
        public string nombreCampoId = "";
        public bool lOK = false;

        public ELRFormAnular()
        {
            InitializeComponent();
        }

        private void ELRFormAnular_Load(object sender, EventArgs e)
        {

            string sfecha = "00/00/0000";
            string referencia = "";
            string NCF = "";
            string nombreBeneficiario = "";
            string concepto = "";
            double monto = 0;

            try
            {
                identificadorId = drFilaSel[nombreCampoId].ToString();
                valorUnico = int.Parse(drFilaSel["Unico"].ToString());

                if (drFilaSel.Table.Columns.Contains("Numero")) numero = drFilaSel["Numero"].ToString();

                //BUSCAMOS EL BENFICIARIO
                if (drFilaSel.Table.Columns.Contains("Beneficiario")) nombreBeneficiario = drFilaSel["Beneficiario"].ToString();
                else if (drFilaSel.Table.Columns.Contains("Nombre")) nombreBeneficiario = drFilaSel["Nombre"].ToString();
                else if (drFilaSel.Table.Columns.Contains("ANombre")) nombreBeneficiario = drFilaSel["ANombre"].ToString();

                //BUSCAMOS EL CONCEPTO
                if (drFilaSel.Table.Columns.Contains("Concepto")) concepto = drFilaSel["Concepto"].ToString();
                else if (drFilaSel.Table.Columns.Contains("Descripcion")) concepto = drFilaSel["Descripcion"].ToString();


                if (drFilaSel.Table.Columns.Contains("NCF"))
                {
                    if (!(drFilaSel["NCF"] is DBNull)) NCF = "NCF: " + drFilaSel["NCF"].ToString().Trim();
                }

                if (drFilaSel.Table.Columns.Contains("Fecha"))
                {
                    if (!(drFilaSel["Fecha"] is DBNull))
                    {
                        sfecha = objUtil.GetDateAsString("fecha", drFilaSel);
                    }

                }


                if (drFilaSel.Table.Columns.Contains("Referencia")) referencia = drFilaSel["Referencia"].ToString();
                else if (drFilaSel.Table.Columns.Contains("Referencia_No")) referencia = drFilaSel["Referencia_No"].ToString();

                if (drFilaSel.Table.Columns.Contains("Monto")) monto = double.Parse(drFilaSel["Monto"].ToString());
                else if (drFilaSel.Table.Columns.Contains("Total")) monto = double.Parse(drFilaSel["Total"].ToString());

                lblIdentificador.Text = identificadorId;
                lblBeneficiario.Text = "Nombre o Beneficiario: " + nombreBeneficiario;
                lblMontoTotal.Text = monto.ToString("N2");
                lblNombreUsuario.Text = NOMBRE_USUARIO.ToUpper();
                lblNCF.Text = NCF;
                lblNumero.Text = numero;
                lblFecha.Text = sfecha;
                lblReferenciaNo.Text = referencia;

                lblBeneficiario.Visible = (lblBeneficiario.Text.Trim() != "");

                cboMotivo.LlenarCombo();

                txtComentario.Text = "ANULADO POR " + cboMotivo.Text.ToUpper();
                txtConcepto.Text = concepto;
                pnConcepto.Visible = (concepto.Trim().Length > 0);

                if (pnConcepto.Visible == false) this.Height = this.Height - pnConcepto.Height;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
                Close();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int motivoId;
            string comentario;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            ELRFormMensajeErrores objMsgERRORES = new ELRFormMensajeErrores();

            int resultado = 0;
            DialogResult resp;

            try
            {
                lOK = false;

                //VALIDAMOS HAYA INDICADO NOMBRE_SP_ANULA
                if (SP_ANULA.Trim() == "") objUtil.MostrarMensajeError("NO SE INDICO SP_ANULA");
                //VALIDAMOS SE HAYA INDICADO NOMBRE DE USUARIO
                else if (NOMBRE_USUARIO.Trim() == "") objUtil.MostrarMensajeError("NO SE INDICO NOMBRE DE USUARIO");
                //Validamos ValorUnico sea Mayor a Cero
                else if (valorUnico <= 0) objUtil.MostrarMensajeError("EL VALOR DEL CAMPO UNICO DEBE SER MAYOR A CERO");
                //Validamos Haya Indicado Motivo Id
                else if (cboMotivo.Text == "") objUtil.MostrarMensajeError("DEBE ELEGIR UN MOTIVO");
                //VALIDAMOS HAYA INDICADO COMENTARIO
                else if (txtComentario.Text.Trim().Length < 15) objUtil.MostrarMensajeError("EL COMENTARIO DEBE TENER UN MINIMO DE 15 CARACTERES");
                else
                {
                    resp = objUtil.MostrarMensajePregunta(this.Text + "\r\r" + "ESTA SEGURO QUE DESEA REALIZAR ESTA ACCION?");

                    if (resp == System.Windows.Forms.DialogResult.Yes)
                    {
                        //PASAMOS PARAMETROS PARA EL SP
                        motivoId = int.Parse(cboMotivo.SelectedValue.ToString());
                        comentario = txtComentario.Text.Trim();
                        temporalId = objUtil.GetTemporalID();

                        parametros.Add(new DataDB_ELR_NET.Parametro("valorUnico", valorUnico));
                        parametros.Add(new DataDB_ELR_NET.Parametro("motivoId", motivoId));
                        parametros.Add(new DataDB_ELR_NET.Parametro("comentario", comentario));
                        parametros.Add(new DataDB_ELR_NET.Parametro("autor", NOMBRE_USUARIO));
                        parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));

                        //INICIAMOS UNA TRANSACCION DE BASE DE DATOS
                        db.iniciarTransaccion();

                        //EJECUTAMOS EL STORE PROCEDURE PARA ANULAR
                        resultado = db.EjecutarSP(SP_ANULA, parametros);
                        if (resultado < 0)
                        {
                            //MOSTRAMOS ERRORES DEL SISTEMA
                            objMsgERRORES.TemporalId = temporalId;
                            objMsgERRORES.objDB = db;

                            objMsgERRORES.ShowDialog();
                        }
                        else
                        {
                            db.confirmarTransaccion();

                            objUtil.MostrarMensajeInformacion(this.Text + " !!EJECUTADO DE FORMA SATISFACTORIA!!");
                            lOK = true;

                            Close();
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }
    }
}
