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
    public partial class FormBancoAnularTransR : WinControl_ELR_NET.ELRFormRegistro
    {
        
        public FormBancoAnularTransR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            bool esImpreso = false;
            int asientoId = 0;
            double debito = 0;
            string tipo = "CHK";

            try
            {
                rdbAnularYCrear.Enabled = false;
                resultado = base.GetData();

                rdbSoloAnular.Checked = true;
                cboTipo.Enabled = false;
                cboCuenta.Enabled = false;

                esImpreso = objUtil.GetAsBoolean("EsImpreso", DSDatos.Tables[0].Rows[0]);
                asientoId = objUtil.GetAsInt("Asiento_Id", DSDatos.Tables[0].Rows[0]);
                debito = objUtil.GetAsDouble("Debito", DSDatos.Tables[0].Rows[0]);
                tipo = objUtil.GetAsString("Tipo", DSDatos.Tables[0].Rows[0]);

                if( tipo == "CHK" || tipo== "CK" )
                {
                    rdbAnularYCrear.Enabled = esImpreso;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void rdbSoloAnular_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public override int GrabarDatos()
        {
            int resultado = 0;
            int opcion = 1;
            List<DataDB_ELR_NET.Parametro> myParms = new List<DataDB_ELR_NET.Parametro>();
            DataRow fila0;
            DialogResult resp;

            try
            {
                if(txtConcepto.Text.Trim().Length < 5)
                {
                    objUtil.MostrarMensajeAdvertencia("Debe Indicar un Concepto Valido");
                    txtConcepto.Focus();

                    return 0;
                }

                resp = objUtil.MostrarMensajePregunta("Esta Seguro que Desea Anular Dicha Transaccion?");
                if (resp != DialogResult.Yes) return 0;

                if (rdbAnularYCrear.Checked) opcion = 2;

                fila0 = DSDatos.Tables[0].Rows[0];
                myParms.Add(new DataDB_ELR_NET.Parametro("Id", objUtil.GetAsInt("Trans_Id", fila0)));
                myParms.Add(new DataDB_ELR_NET.Parametro("Concepto", txtConcepto.Text.Trim()));
                myParms.Add(new DataDB_ELR_NET.Parametro("opcion", opcion));
                myParms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                myParms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                objDB.iniciarTransaccion();

                resultado = objDB.EjecutarSP("SP_BANCOS_ANULA_TRANS", myParms);
                if (resultado < 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    objUtil.MostrarMensajeInformacion("Proceso Realizado de Forma Satisfactoria...");
                    lOK = true;
                    Close();
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objDB.cancelarTransaccion();
                Cursor = Cursors.Default;
            }
            

            return resultado;
        }
    }
}
