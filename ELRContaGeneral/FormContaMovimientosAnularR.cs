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
    public partial class FormContaMovimientosAnularR : WinControl_ELR_NET.ELRFormRegistro
    {
        string asientoId = "0";
        string asientoNo = "0";
        public FormContaMovimientosAnularR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            string concepto = "";
            DataTable DTDetalle = null;
            double totalDebito = 0, totalCredito = 0, diferencia = 0;
            object calcObject;

            try
            {
                //return base.GetData();
                asientoId = objUtil.GetAsString("Asiento_Id", drRegistroSel, "0");
                asientoNo = asientoId;
                concepto = objUtil.GetAsString("Concepto", drRegistroSel);

                txtConcepto.Text = "ASIENTO NO.:" + asientoId.PadLeft(7, '0')
                                      + ";  CONCEPTO: " + concepto.ToUpper();

                this.Text = "ANULAR ASIENTO NO.: " + asientoId.PadLeft(7, '0');

                //VISUALIZAMOS EL DETALLE DEL MOVIMIENTO A ANULAR
                DTDetalle = objDB.GetById("TCONTA_DIARIO_DETALLE", asientoId, "Asiento_Id");
                dtgDetalle.AutoGenerateColumns = false;
                dtgDetalle.DataSource = DTDetalle.DefaultView;

                //BUSCAMOS TOTAL DEBITO
                calcObject = DTDetalle.Compute("Sum(Debito)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalDebito = double.Parse(calcObject.ToString());
                }

                //BUSCAMOS TOTAL CREDITO
                calcObject = DTDetalle.Compute("Sum(Credito)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") totalCredito = double.Parse(calcObject.ToString());
                }

                diferencia = totalDebito - totalCredito;
                lblTotalDebito.Text = totalDebito.ToString("N2");
                lblTotalCredito.Text = totalCredito.ToString("N2");
                lblDiferencia.Text = diferencia.ToString("N2");

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public override int GrabarDatos()
        {
            int resultado = -1;
            string comentario = "";
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                //return base.GrabarDatos();
                comentario = txtComentario.Text.Trim();
                if (comentario.Length < 10) objUtil.MostrarMensajeAdvertencia("Debe Indicar un Comentario ...");
                else
                {
                    resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Anular El Asiento No.: " + asientoNo.PadLeft(8, '0') + "?");
                    if (resp == DialogResult.Yes)
                    {
                        temporalID = objUtil.GetTemporalID();
                        parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        parametros.Add(new DataDB_ELR_NET.Parametro("AsientoId", asientoId));
                        parametros.Add(new DataDB_ELR_NET.Parametro("Comentario", comentario));
                        parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.NOMBRE_USUARIO = nombreUsuario;
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_CONTA_ANULA_ASIENTO", parametros);
                        if (resultado < 0) MostrarErrorTemporal();
                        else
                        {
                            objDB.confirmarTransaccion();
                            lOK = true;
                            objUtil.MostrarMensajeInformacion("Asiento No.: " + asientoNo.PadLeft(8, '0') + " Anulado de Forma Satisfactoria ...");

                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objDB.cancelarTransaccion();
            }

            return resultado;
        }

        private void FormContaMovimientosAnularR_Activated(object sender, EventArgs e)
        {
            txtComentario.Focus();
        }
    }
}
