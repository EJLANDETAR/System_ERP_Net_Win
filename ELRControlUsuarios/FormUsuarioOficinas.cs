using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRControlUsuarios
{
    public partial class FormUsuarioOficinas : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormUsuarioOficinas()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            string SSQL = "";
            try
            {
                lblUser.Text = "USUARIO: " + VALOR_ID.ToUpper();

                SSQL = "select * from DBO.FN_USUARIOS_OFICINAS('" + VALOR_ID + "') Order by Oficina_Id";
                DTDetalle = objDB.GetSQL(SSQL);
                dtgOficinas.AutoGenerateColumns = false;
                dtgOficinas.DataSource = DTDetalle.DefaultView;
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public override int GrabarDatos()
        {
            int resultado = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                temporalID = objUtil.GetTemporalID();
                objDB.iniciarTransaccion();
                foreach (DataRow item in DTDetalle.Rows)
                {
                    Cursor = Cursors.WaitCursor;

                    parms.Clear();
                    parms.Add(new DataDB_ELR_NET.Parametro("nombreUsuario", objDB.GetAsString("Nombre_Usuario", item)));
                    parms.Add(new DataDB_ELR_NET.Parametro("oficinaId", objDB.GetAsInt("oficina_Id", item)));
                    parms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                    parms.Add(new DataDB_ELR_NET.Parametro("esActivo", objDB.GetAsBoolean("EsActivo", item)));
                    parms.Add(new DataDB_ELR_NET.Parametro("esDefault", objDB.GetAsBoolean("EsDefault", item)));
                    parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                    parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                    resultado = objDB.EjecutarSP("SP_ACCESOS_SET_USUARIO_OFICINA", parms);
                    if (resultado <= 0) break;

                    Cursor = Cursors.Default;
                }

                if (resultado <= 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                    Close();
                }
            }
            catch (Exception ex)
            {

                resultado = -1;
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                objDB.cancelarTransaccion();
            }

            return resultado;
        }

        private void FormUsuarioOficinas_Load(object sender, EventArgs e)
        {

        }
    }
}
