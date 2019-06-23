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
    public partial class FormContaAsientoPredefinidosGenerar : WinControl_ELR_NET.ELRFormRegistro
    {
        double total = 0.0;

        public FormContaAsientoPredefinidosGenerar()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            int spReturn = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                Cursor = Cursors.WaitCursor;

                btnGrabar.Enabled = false;
                dtpAFecha.Value = DateTime.Now.Date;

                temporalID = objUtil.GetTemporalID();
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                parms.Add(new DataDB_ELR_NET.Parametro("oficinaId", OFICINA_ID));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));

                //Iniciamos una transaccion para cargar a temporal
                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_CONTA_ASIENTOS_PREDEFINIDOS_ATEMPORAL", parms);
                if(spReturn <= 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    DTDetalle = objDB.GetById("TTEMPORAL_CONTA_ASIENTOS_PREDEFINIDOS", temporalID, "IdentificadorTemp");
                    DataGridDetalle.AutoGenerateColumns = false;
                    DataGridDetalle.DataSource = DTDetalle.DefaultView;

                    TotalizarDetalle();

                    resultado = true;
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

            return resultado;
        }

        public override void TotalizarDetalle()
        {
            try
            {
                total = GetSumDetalle("Monto");
                lblTotal.Text = total.ToString("N2");

                btnGrabar.Enabled = (total > 0);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override int GrabarDatos()
        {
            int resultado = 0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            DateTime fecha = DateTime.Now;

            try
            {
                if (total > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    fecha = dtpAFecha.Value.Date;
                    resp = objUtil.MostrarMensajePregunta("Esta seguro de Generar estos Movimientos a fecha " + objUtil.GetDateAsString(fecha)  + "?");
                    if(resp == DialogResult.Yes)
                    {
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                        parms.Add(new DataDB_ELR_NET.Parametro("fecha", objUtil.DateToInt(fecha).ToString() ));

                        //Iniciamos una transaccion
                        objDB.iniciarTransaccion();
                        resultado = objDB.EjecutarSP("SP_CONTA_GENERAR_ASIENTOS_PREDEFINIDOS", parms);
                        if(resultado <= 0)
                        {
                            MostrarErrorTemporal();
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            objUtil.MostrarMensajeInformacion("Se han generado " + resultado.ToString() + " asientos contables");
                            lOK = true;
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
                Cursor = Cursors.Default;
            }

            return resultado;
        }
    }
}
