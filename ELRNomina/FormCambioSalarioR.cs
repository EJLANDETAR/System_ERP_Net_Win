using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormCambioSalarioR : WinControl_ELR_NET.ELRFormRegistro
    {
        public DataRow fila0;
        string empleadoId = "0";
        string nombreCompleto = "";

        public FormCambioSalarioR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            //return base.GetData();
            bool resultado = false;
            string cedula = "";
            double salarioActual = 0;
            try
            {
                empleadoId = objUtil.GetAsString("Empleado_Id", fila0);
                cedula = objUtil.GetAsString("CedulaRNC", fila0);
                nombreCompleto = objUtil.GetAsString("Nombres", fila0) + " " + objUtil.GetAsString("Apellidos", fila0);
                salarioActual = objUtil.GetAsDouble("Salario_Mensual", fila0);

                lblCodigo.Text = "Codigo: " + empleadoId.PadLeft(7, '0') + "              Cedula: " + cedula;
                lblNombreCompleto.Text = nombreCompleto.ToUpper();
                lblSalarioActual.Text = "Salario Actual: " + salarioActual.ToString("N2");

                txtSalarioNuevo.Text = "0.00";
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }


            return resultado;
        }

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            int resultado = -1;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            double salarioNuevo = 0;
            string concepto = "";
            int spReturn = 0;

            try
            {
                salarioNuevo = objUtil.ConvertirANumero(txtSalarioNuevo.Text);
                concepto = txtMotivo.Text.Trim();

                resp = objUtil.MostrarMensajePregunta("Esta Seguro Cambiar el Salario A: " + nombreCompleto + "?");

                if (resp == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    if (temporalID == "") temporalID = objUtil.GetTemporalID();

                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    parms.Add(new DataDB_ELR_NET.Parametro("empleadoId", empleadoId));
                    parms.Add(new DataDB_ELR_NET.Parametro("SalarioNuevo", salarioNuevo));
                    parms.Add(new DataDB_ELR_NET.Parametro("Concepto", concepto));
                    parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_RRHH_REGISTRAR_CAMBIO_SALARIO", parms);
                    if (spReturn <= 0)
                    {
                        MostrarErrorTemporal();
                        objDB.cancelarTransaccion();
                    }
                    else
                    {
                        objDB.confirmarTransaccion();
                        lOK = true;
                        Close();
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
                objDB.cancelarTransaccion();
            }

            return resultado;
        }
    }
}
