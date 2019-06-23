using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRSmartPhones
{
    public partial class FormSmartPhonesR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormSmartPhonesR()
        {
            InitializeComponent();
        }

        void GetUsuario()
        {
            string usuario = "";
            ELRControlUsuarios.FormUsuarios frm = new ELRControlUsuarios.FormUsuarios();

            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.EsAgregar = false;
                frm.EsModificar = false;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.FiltroEstatico = "EsActivo = 1 and EsBloqueado = 0";


                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    usuario = objUtil.GetAsString("Nombre_Usuario", frm.filaSelecionada);
                    txtUsuario.Text = usuario;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

        void GetEmpleado(string codigo = "")
        {
            DataTable DTData = null;
            DataRow fila0 = null;
            string SSQL = "", id = "0", nombre = "(TODOS)";
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();

            try
            {
                codigo = codigo.Trim().Replace('-', ' ');
                if (codigo != "")
                {
                    SSQL = "SELECT TOP 1 Empleado_Id, Nombres, Apellidos FROM TRRHH_EMPLEADOS";
                    SSQL += " WHERE Cast(Empleado_Id as Varchar) = '" + codigo + "' ";
                    SSQL += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "' ";

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
                    frm.FiltroEstatico = "EsActivo = 1 and Fecha_Baja Is Null";
                    frm.Text = "EMPLEADOS VENDEDORES";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    id = objUtil.GetAsString("Empleado_Id", fila0);
                    nombre = objUtil.GetAsString("Nombres", fila0);
                    nombre += " " + objUtil.GetAsString("Apellidos", fila0);
                }

                SetValorEncabezado("Empleado_Id", id);
                txtEmpleadoId.Text = id;
                txtEmpleadoNombre.Text = nombre;
                toolTip1.SetToolTip(txtEmpleadoNombre, nombre);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void txtEmpleadoId_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtEmpleadoId.Text.Trim();
            if (e.KeyCode == Keys.F9) GetEmpleado();
            else if (e.KeyCode == Keys.Enter && codigo != "") GetEmpleado(codigo);
        }

        public override bool GetData()
        {
            bool resultado = true;
            int empleadoId = 0;
            try
            {
                resultado = base.GetData();
                if (resultado && !esNuevo)
                {
                    empleadoId = objUtil.GetAsInt("Empleado_Id", DSDatos.Tables[0].Rows[0]);
                    GetEmpleado(empleadoId.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            GetUsuario();
        }
    }
}
