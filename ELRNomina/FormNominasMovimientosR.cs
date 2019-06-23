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
    public partial class FormNominasMovimientosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormNominasMovimientosR()
        {
            InitializeComponent();
        }

        void GetEmpleado(string codigo = "")
        {
            ELRMaestros.FormEmpleados frm = new ELRMaestros.FormEmpleados();
            DataTable DTEmpleados = null;
            DataRow fila0 = null;
            string sfiltro = "";
            string nombres = "", apellidos = "", cedulaRNC = "";
            int id = 0;
            try
            {
                codigo = codigo.Trim().Replace('-', ' ');

                if (codigo != "" && codigo != "0")
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIsNull("Fecha_Baja");

                    sfiltro = "( Cast(Empleado_Id as Varchar) = '" + codigo + "'";
                    sfiltro += " Or REPLACE(CedulaRNC, '-', '') = '" + codigo + "'";
                    sfiltro += ")";
                    objDB.AddFiltroPersonalizado(sfiltro);

                    DTEmpleados = objDB.GetAll("TRRHH_EMPLEADOS", 1, objDB.Filtros);
                    if (DTEmpleados.Rows.Count > 0) fila0 = DTEmpleados.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.esBusqueda = true;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.FiltroEstatico = "Empresa_Id = " + EMPRESA_ID.ToString() + " And EsActivo = 1 And Fecha_Baja Is Null";
             
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                id = 0;
                if (fila0 != null)
                {
                    id = objUtil.GetAsInt("Empleado_Id", fila0);
                    nombres = objUtil.GetAsString("Nombres", fila0);
                    apellidos = objUtil.GetAsString("Apellidos", fila0);
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);
                }

                txtEmpleadoId.Text = id.ToString();
                txtCedulaRNC.Text = cedulaRNC;
                txtNombre.Text = (nombres + " " + apellidos).Trim();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Cliente, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                DTEmpleados = null;
                fila0 = null;
            }
        }

        void GetTipoTransaccion(string codigo = "")
        {
            FormNominaTipoMovimientos frm = new FormNominaTipoMovimientos();
            DataTable DTData = null;
            DataRow fila0 = null;
            string concepto = "";
            double valor = 0;
   
            try
            {
                codigo = codigo.Trim().Replace('-', ' ');

                if (codigo != "" && codigo != "0")
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Codigo", codigo);
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    DTData = objDB.GetAll("TNOMINAS_TIPO_MOVIMIENTOS", 1, objDB.Filtros);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.esBusqueda = true;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.FiltroEstatico = "EsActivo = 1";
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;
                }

                if (fila0 != null)
                {
                    codigo = objUtil.GetAsString("Codigo", fila0);
                    concepto = objUtil.GetAsString("Concepto", fila0);
                    valor = objUtil.GetAsDouble("Valor", fila0);
                }

                txtCodigo.Text = codigo;
                txtConcepto.Text = concepto;
                txtValor.Text = valor.ToString("N2");
                txtValor.ReadOnly = (valor > 0);

                if (valor <= 0 && fila0 != null) txtValor.Focus(); 

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Buscar Cliente, " + ex.Message);
            }
            finally
            {
                frm.Dispose();
                DTData = null;
                fila0 = null;
            }
        }

        private void btnBuscarTipoTrans_Click(object sender, EventArgs e)
        {
            GetTipoTransaccion();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (e.KeyCode == Keys.F9) GetTipoTransaccion();
            else if (e.KeyCode == Keys.Enter) GetTipoTransaccion(codigo);
        }

        private void txtEmpleadoId_KeyDown(object sender, KeyEventArgs e)
        {
            string codigo = txtEmpleadoId.Text.Trim();

            if (e.KeyCode == Keys.F9) GetEmpleado();
            else if (e.KeyCode == Keys.Enter) GetEmpleado(codigo);
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            GetEmpleado();
        }

        private void FormNominasMovimientosR_Load(object sender, EventArgs e)
        {
            
            try
            {
                dtpFecha.Value = DateTime.Now.Date;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void PasarValorADS()
        {
            base.PasarValorADS();
            SetValorEncabezado("Fecha", dtpFecha.Value.Date);
        }
    }
}
