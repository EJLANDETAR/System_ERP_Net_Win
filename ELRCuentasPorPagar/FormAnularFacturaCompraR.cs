using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormAnularFacturaCompraR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormAnularFacturaCompraR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0 = null;
            double totalItbis = 0, total = 0, montoP = 0;
            string NCF = "B0000000000";
            string nombre = "NOMBRE COMPLETO DEL SUPLIDOR";
            string cedulaRNC = "00000000000";
            string facturaNumero = "00000000", tipo = "";
            int tipoGastoDGII = 0;
            try
            {
                //BUSCAMOS EL DETALLE
                DTDetalle = objDB.GetById("TCXP_DETALLES", VALOR_ID, "Identificador_Id");
                dtgDetalle.AutoGenerateColumns = false;
                dtgDetalle.DataSource = DTDetalle.DefaultView;

                //BUSCAMOS EL ENCABEZADO
                fila0 = objDB.GetById("VCXP", VALOR_ID, "CXP_Id").Rows[0];
                tipoGastoDGII = objDB.GetAsInt("Tipo_Gastos_DGII", fila0);
                nombre = objDB.GetAsString("Nombre", fila0);
                cedulaRNC = objDB.GetAsString("CedulaRNC", fila0);
                facturaNumero = objDB.GetAsString("Factura_Numero", fila0);
                NCF = objDB.GetAsString("NCF", fila0);
                tipo = objDB.GetAsString("TTransaccion", fila0);
                total = objDB.GetAsDouble("Total", fila0);
                totalItbis = objDB.GetAsDouble("Itbis", fila0);
                montoP = objDB.GetAsDouble("Monto_Pendiente", fila0);

                lblNCFModificar.Text = tipo +  ",    NO.:  " + facturaNumero + "    ";
                lblNCFModificar.Text += "NCF:  " + NCF;
                lblNCFModificar.BackColor = colorR;
                lblSuplidor.Text = "SUPLIDOR:  " + cedulaRNC + "      ";
                lblSuplidor.Text += nombre;
                lblMonto.Text = "MONTO TOTAL:  " + total.ToString("N2") + "                                      ";
                lblMonto.Text += "ITBIS:  " + totalItbis.ToString("N2");
                lblMontoPendiente.Text = "MONTO PENDIENTE POR PAGAR:  " + montoP.ToString("N2");

                btnGrabar.BackColor = colorR;
                btnCancelar.BackColor = colorR;
                txtConcepto.Focus();
                resultado = true;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }


        public override int GrabarDatos()
        {
            int resultado = 1;
            string comentario = "";
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                comentario = txtConcepto.Text.Trim();
                //Validamos el comentario tenga mas de 10 caracteres
                if(comentario.Length < 10)
                {
                    objUtil.MostrarMensajeAdvertencia("Debe especificar un concepto o motivo");
                    txtConcepto.Focus();
                    resultado = -1;
                }
                else
                {
                    resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea anular este documento?");
                    if (resp == DialogResult.Yes)
                    {
                        temporalID = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        parms.Add(new DataDB_ELR_NET.Parametro("Id", VALOR_ID));
                        parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                        parms.Add(new DataDB_ELR_NET.Parametro("comentario", comentario));

                        //ejecutamos el store procedure
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_COMPRAS_ANULAR_CXP", parms);
                        if (resultado <= 0)
                        {
                            MostrarErrorTemporal();
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            lOK = true;
                            objUtil.MostrarMensajeInformacion("Proceso realizado de forma satisfactoria...");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            return resultado;
        }

        private void FormAnularFacturaCompraR_Activated(object sender, EventArgs e)
        {
            txtConcepto.Focus();
        }
    }
}
