using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRMaestros
{
    public partial class FormZonasR : WinControl_ELR_NET.ELRFormRegistro
    {
        int empleadoId = 0;
        string nombre = "";

        public FormZonasR()
        {
            InitializeComponent();
        }

        private void btnBuscarOficialCredito_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            try
            {
                GetEmpleado();
                if(btn == btnBuscarOficial)
                {
                    txtOficialCreditoId.Text = empleadoId.ToString();
                    txtOficialNombre.Text = nombre;
                }
                else if(btn == btnBuscarSupervisor)
                {
                    txtSupervisorId.Text = empleadoId.ToString();
                    txtSupervisorNombre.Text = nombre;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        public override bool GetData()
        {
            bool resultado = false;
            int evaluadorId = 0;
            int supervisorId = 0;
            DataRow fila0;

            try
            {
                resultado = base.GetData();
                this.Cursor = Cursors.WaitCursor;

                if (resultado)
                {
                    resultado = false;

                    fila0 = DSDatos.Tables[0].Rows[0];
                    evaluadorId = objUtil.GetAsInt("Evaluador_Id", fila0);
                    supervisorId = objUtil.GetAsInt("Supervisor_Id", fila0);

                    GetEmpleado(evaluadorId.ToString());
                    txtOficialCreditoId.Text = empleadoId.ToString();
                    txtOficialNombre.Text = nombre;

                    GetEmpleado(supervisorId.ToString());
                    txtSupervisorId.Text = empleadoId.ToString();
                    txtSupervisorNombre.Text = nombre;

                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError("Error al Obtener Nombres, " + ex.Message);

                this.Close();
            }
            finally
            {
                this.Cursor = Cursors.Default;
                fila0 = null;
            }

            return resultado;

        }

        void GetEmpleado(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
                empleadoId = 0;
                nombre = "(NO ASIGNADO)";
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = " SELECT TOP 1 Empleado_Id, Nombres, Apellidos FROM TRRHH_EMPLEADOS";
                    SSQL += " WHERE Cast(Empleado_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";
                    SSQL += " And EsActivo = 1 And Fecha_Baja Is Null";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "EsActivo = 1 And Fecha_Baja Is Null";
                    frm.Text = "EMPLEADOS (OFICIAL DE CREDITO)";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    empleadoId = objUtil.GetAsInt("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtOficialCreditoId_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string codigo = "";
            bool resultado = false;
            try
            {
                codigo = txt.Text.Trim();
                if (e.KeyCode == Keys.F9)
                {
                    GetEmpleado();
                    resultado = true;
                }
                else if (e.KeyCode == Keys.Enter && codigo != "")
                {
                    GetEmpleado(codigo);
                    resultado = true;
                }

                if(txt == txtOficialCreditoId && resultado)
                {
                    txtOficialCreditoId.Text = empleadoId.ToString();
                    txtOficialNombre.Text = nombre;
                }
                else if(txt == txtSupervisorId && resultado)
                {
                    txtSupervisorId.Text = empleadoId.ToString();
                    txtSupervisorNombre.Text = nombre;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
