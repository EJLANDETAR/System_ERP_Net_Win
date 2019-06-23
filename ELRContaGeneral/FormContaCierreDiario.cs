using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaCierreDiarioMensual : WinControl_ELR_NET.ELRFormRegistro
    {
        double diferencia = 0;

        public FormContaCierreDiarioMensual()
        {
            InitializeComponent();
        }

        void GetCatalogoBalance()
        {
            DataTable DTCatalogo = null;
            object calcObject;
            string estatus = "DESACTUALIZADO; NO DATA";

            try
            {
                lblEstatus.Text = estatus;
                btnRealizarCierre.Enabled = false;

                objDB.LimpiarFiltros();
                objDB.AddFiltroPersonalizado(" Len(Cuenta_Contable) = 1 ");
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTCatalogo = objDB.GetAll("TCONTA_CATALOGO", -1, objDB.Filtros);

                dtgCatalogoBalance.AutoGenerateColumns = false;
                dtgCatalogoBalance.DataSource = DTCatalogo.DefaultView;

                //VAMOS A BUSCAR LA DIFERENCIA SI EXISTEN
                calcObject = DTCatalogo.Compute("Sum(Saldo_Actual)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") diferencia = double.Parse(calcObject.ToString());
                }

                lblDiferencia.Text = "Diferencia: " + diferencia.ToString("N2");

                if (DTCatalogo.Rows.Count > 0)
                {
                    //MOSTRAMOS EL ESTATUS DEL CATALOGO Y HASTA QUE FECHA ESTA POSTEADO
                    estatus = objUtil.GetAsString("Estatus", DTCatalogo.Rows[0], "DESACTUALIZADO; NO POSTEADO");

                    lblEstatus.Text = estatus + " A FECHA:";

                    if (DTCatalogo.Rows[0]["Fecha_Actualizado"] is DBNull) lblFechaActualizado.Text = "00/00/0000";
                    else
                    {
                        DateTime fecha = objUtil.GetAsDate("Fecha_Actualizado", DTCatalogo.Rows[0]);
                        lblFechaActualizado.Text = objUtil.GetDateAsString(fecha) + "(" + fecha.ToLongDateString() + ")";
                    }
                }

                btnRealizarCierre.Enabled = (DTCatalogo.Rows.Count > 0 && diferencia == 0);
                if (estatus.ToUpper().Contains("DESACTUALIZADO")) lblEstatus.ForeColor = Color.Red;
                else lblEstatus.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override bool GetData()
        {
            bool resultado = true;
            try
            {
                //return base.GetData();
                GetCatalogoBalance();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void FormContaCierreDiarioMensual_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now.Date;
            btnGrabar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string fecha;
            List<DataDB_ELR_NET.Parametro> parametros = new List<DataDB_ELR_NET.Parametro>();
            int resultado = -1;

            try
            {
                resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Realizar el Cierre?");

                if(resp== DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    fecha = objDB.DateToInt(dtpFecha.Value).ToString();
                    temporalID = objUtil.GetTemporalID();

                    parametros.Add(new DataDB_ELR_NET.Parametro("pFecha", fecha));
                    parametros.Add(new DataDB_ELR_NET.Parametro("empresaId", EMPRESA_ID.ToString()));
                    parametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    parametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalID));

                    //EJECUTAMOS EL SP DENTRO DE UNA TRANSACCION
                    objDB.iniciarTransaccion();
                    resultado = objDB.EjecutarSP("SP_CONTA_CERRAR_DIA", parametros);

                    if (resultado > 0)
                    {
                        objDB.confirmarTransaccion();
                        GetCatalogoBalance();
                        objUtil.MostrarMensajeInformacion("CIERRE DIARIO, Realizado de Forma Satisfactoria ...");
                    }
                    else MostrarErrorTemporal();
                }

            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objDB.cancelarTransaccion();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
