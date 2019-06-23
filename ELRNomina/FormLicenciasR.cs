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
    public partial class FormLicenciasR : WinControl_ELR_NET.ELRFormRegistro
    {
        public DataRow fila0;
        string empleadoId = "0";
        string nombreCompleto = "";

        public FormLicenciasR()
        {
            InitializeComponent();
        }

        private void FormLicenciasR_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            dtpFecha.Value = fecha;
            dtpFechaRetornar.Value = fecha.AddDays(16);
        }

        public override bool GetData()
        {
            //return base.GetData();
            bool resultado = false;
            string cedula = "";
            string sexo = "M";
            try
            {
                Cursor = Cursors.WaitCursor;

                empleadoId = objUtil.GetAsString("Empleado_Id", fila0);
                cedula = objUtil.GetAsString("CedulaRNC", fila0);
                sexo = objUtil.GetAsString("Sexo", fila0).ToUpper();
                nombreCompleto = objUtil.GetAsString("Nombres", fila0) + " " + objUtil.GetAsString("Apellidos", fila0);

                lblCodigo.Text = "Codigo: " + empleadoId.PadLeft(7, '0') + "              Cedula: " + cedula;
                lblNombreCompleto.Text = nombreCompleto.ToUpper();

                cboTipo.Items.Add("PERMISO");
                cboTipo.Items.Add("LICENCIA MEDICA");

                if(sexo == "M") cboTipo.Items.Add("LICENCIA PATERNIDAD");
                else cboTipo.Items.Add("LICENCIA MATERNIDAD");

                cboTipo.Items.Add("SANSION");
                cboTipo.Items.Add("OTROS");

                cboTipo.SelectedIndex = 0;

                Cursor = Cursors.Default;
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

        public override int GrabarDatos()
        {
            //return base.GrabarDatos();
            int resultado = -1;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int fechaId = 0, fechaRetornar;
            string concepto = "", tipo = "";
            int spReturn = 0;

            try
            {
                fechaId = objUtil.DateToInt(dtpFecha.Value);
                fechaRetornar = objUtil.DateToInt(dtpFechaRetornar.Value);
                concepto = txtMotivo.Text.Trim();
                tipo = cboTipo.Text;

                if(concepto.Length < 5)
                {
                    objUtil.MostrarMensajeError("Debe Indicar un Concepto Valido");
                    txtMotivo.Focus();
                    return -1;
                }

                resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Aplicar " + tipo + " A: " + nombreCompleto + "?");

                if (resp == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    if (temporalID == "") temporalID = objUtil.GetTemporalID();

                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));
                    parms.Add(new DataDB_ELR_NET.Parametro("empleadoId", empleadoId));
                    parms.Add(new DataDB_ELR_NET.Parametro("Fecha", fechaId));
                    parms.Add(new DataDB_ELR_NET.Parametro("FechaARetornar", fechaRetornar));
                    parms.Add(new DataDB_ELR_NET.Parametro("Concepto", concepto));
                    parms.Add(new DataDB_ELR_NET.Parametro("Tipo", tipo));
                    parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_RRHH_REGISTRAR_OTROS_HECHOS_AEMPLEADO", parms);
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
