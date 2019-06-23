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
    public partial class FormContaEstadosFormatosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public int estadoId = 0;
        int formulaId = 0;

        public FormContaEstadosFormatosR()
        {
            InitializeComponent();
        }

        public override int GrabarDatos()
        {
            int tipoLinea = 0;
            string formulaAnt = "";
            int resultado = 0;

            try
            {
                tipoLinea = cboTipoLinea.SelectedIndex;
                formulaAnt = txtFormula.Text;

                if (tipoLinea <= 1) txtFormula.Text = "";

                if (esNuevo) SetValorEncabezado("Estado_Id", estadoId);

                resultado = base.GrabarDatos();

                if (resultado < 0) txtFormula.Text = formulaAnt;
                else SetCuentasFormulas();
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormContaEstadosFormatosCuentas frmCuentas = new FormContaEstadosFormatosCuentas();
            int formulaId = 0;
            DataRow fila0;
            DataTable DTData = null;
            string formula = "";
            bool esSuma = true, esAbs = false;
            string operador = "+";
            string cuentaContable = "";

            try
            {
                fila0 = DSDatos.Tables["Encabezado"].Rows[0];
                formulaId = objUtil.GetAsInt("Formula_Id", fila0);

                if (formulaId > 0)
                {
                    txtFormula.Text = "";

                    frmCuentas.nombreUsuario = nombreUsuario;
                    frmCuentas.oficinaID = OFICINA_ID;
                    frmCuentas.empresaID = EMPRESA_ID;
                    frmCuentas.formulaId = formulaId;

                    frmCuentas.EnEjecusion = true;

                    frmCuentas.ShowDialog();

                    //Buscamos las Cuentas para especificar las formulas involucradas
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Formula_Id", formulaId.ToString());
                    DTData = objDB.GetAll("TCONTA_ESTADOS_CUENTAS", -1, objDB.Filtros);

                    this.Cursor = Cursors.WaitCursor;
                    foreach (DataRow item in DTData.Rows)
                    {
                        esSuma = objUtil.GetAsBoolean("EsSum", item);
                        esAbs = objUtil.GetAsBoolean("EsAbs", item);
                        cuentaContable = objUtil.GetAsString("Cuenta_Contable", item);

                        if (esSuma) operador = "+";
                        else operador = "-";

                        if ((formula.Trim() == "") && (operador != "+")) formula += operador;
                        else if(formula.Trim() != "") formula += operador;

                        if (esAbs) formula += "Abs(";

                        formula += cuentaContable;

                        if (esAbs) formula += ")";
                    }

                    txtFormula.Text = formula;

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        void SetCuentasFormulas()
        {
            
            DataTable DTData = null;
            int spReturn = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            try
            {
                if (formulaId <= 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Adicionado_Por", nombreUsuario);
                    objDB.AddFiltroOrderBY("Unico Desc");
                    DTData = objDB.GetAll(TablaEncabezado, 1, objDB.Filtros);

                    if (DTData.Rows.Count > 0) formulaId = objUtil.GetAsInt("Formula_Id", DTData.Rows[0]);
                }

                if (temporalID == "") temporalID = objUtil.GetTemporalID();

                //ejecutamos store procedure para grabar cuentas
                parms.Add(new DataDB_ELR_NET.Parametro("formulaId", formulaId));
                parms.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID));
                parms.Add(new DataDB_ELR_NET.Parametro("autor", nombreUsuario));
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_CONTA_SET_ESTADOS_CUENTAS", parms);
                if(spReturn < 0)
                {
                    MostrarErrorTemporal();
                    objDB.cancelarTransaccion();
                }
                else
                {
                    objDB.confirmarTransaccion();
                }

                Close();
            }
            catch (Exception)
            {

                //throw;
            }
        }


        public override bool GetData()
        {
            bool resultado = false;
            int lineaNo = 1;
            DataTable DTData = null;
            string SSQL = "";

            try
            {
                resultado = base.GetData();

                if (esNuevo)
                {
                    //Buscamos la siguiente linea
                    SSQL = "SELECT IsNull(Max(LineaNo), 0) + 1 as LineaNo FROM TCONTA_ESTADOS_FORMULAS ";
                    SSQL += " WHERE Estado_Id = " + estadoId.ToString();
                    SSQL += "       And Fecha_Deleted Is Null";

                    DTData = objDB.GetSQL(SSQL);

                    lineaNo = objUtil.GetAsInt("LineaNo", DTData.Rows[0]);
                    txtLineaNo.Text = lineaNo.ToString();
                }
                else formulaId = objUtil.GetAsInt("Formula_Id", DSDatos.Tables[0].Rows[0]);
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void txtFormula_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valoresPermitidos = "0123456789.+-Ll";
            string valor = "";

            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                valor = e.KeyChar.ToString().ToUpper();
                if (!valoresPermitidos.Contains(valor)) e.Handled = true;
                else e.Handled = false;
                
            }

            
        }
    }
}
