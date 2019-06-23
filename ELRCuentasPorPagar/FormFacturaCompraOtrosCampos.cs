using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormFacturaCompraOtrosCampos : Form
    {
        public bool lOK = false;
        public string nombreUsuario = "";
        public DataRow fila0 = null;

        WinControl_ELR_NET.ELRUtils util = new WinControl_ELR_NET.ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        double total = 0, retItbis = 0, retISR = 0, aPagar = 0;
        double itbis = 0, itbisCosto = 0, itbisPorAdelantar = 0;
        double itbisProp = 0, itbisPercibido = 0, ISRPercibido = 0;
        double impSelectivo = 0, propinaLegal = 0, otrosImp = 0;
        int tipoRet = 0;

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Calcular())
                {
                    if (retISR > 0 && tipoRet <= 0)
                    {
                        util.MostrarMensajeError("Debe elegir tipo de retencion");
                        cboTipoRet.Focus();
                        return;
                    }

                    fila0["Retencion_Itbis"] = retItbis;
                    fila0["Retencion_Neto"] = retISR;
                    fila0["Tipo_Retencion_ISR"] = tipoRet;
                    fila0["Itbis_Proporcionalidad"] = itbisProp;
                    fila0["Itbis_Costo"] = itbisCosto;
                    fila0["Itbis_Por_Adelantar"] = itbisPorAdelantar;
                    fila0["Itbis_Percivido"] = itbisPercibido;
                    fila0["ISR_Percivido"] = ISRPercibido;
                    fila0["Impuesto_Selectivo_Consumo"] = impSelectivo;
                    fila0["Otros_Impuestos"] = otrosImp;
                    fila0["Propina_Legal"] = propinaLegal;
                    fila0["Monto_APagar"] = aPagar;

                    lOK = true;
                    Close();
                }
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        

        public FormFacturaCompraOtrosCampos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }

        private void FormFacturaCompraOtrosCampos_Load(object sender, EventArgs e)
        {
            DataTable DTTipoRet = null;

            try
            {
                Cursor = Cursors.WaitCursor;

                btnAplicar.Enabled = false;
                db.NOMBRE_USUARIO = nombreUsuario;
                DTTipoRet = db.GetAll("TSISTEMA_TIPO_RETENCION_DGII", -1);
                cboTipoRet.DisplayMember = "Descripcion";
                cboTipoRet.ValueMember = "Codigo";
                cboTipoRet.DataSource = DTTipoRet.DefaultView;
                cboTipoRet.SelectedValue = util.GetAsInt("Tipo_Retencion_ISR", fila0); 

                txtRetItbis.Text = util.GetAsDouble("Retencion_Itbis", fila0).ToString("N2");
                txtRetISR.Text = util.GetAsDouble("Retencion_Neto", fila0).ToString("N2");
                txtItbisProp.Text = util.GetAsDouble("Itbis_Proporcionalidad", fila0).ToString("N2");
                txtItbisPorAdelantar.Text = util.GetAsDouble("Itbis_Por_Adelantar", fila0).ToString("N2");
                txtItbisPercibido.Text = util.GetAsDouble("Itbis_Percivido", fila0).ToString("N2");
                txtItbisCosto.Text = util.GetAsDouble("Itbis_Costo", fila0).ToString("N2");
                txtISRPercibido.Text = util.GetAsDouble("ISR_Percivido", fila0).ToString("N2");
                txtImpSel.Text = util.GetAsDouble("Impuesto_Selectivo_Consumo", fila0).ToString("N2");
                txtPropinaLegal.Text = util.GetAsDouble("Propina_Legal", fila0).ToString("N2");
                txtOtrosImpuestos.Text = util.GetAsDouble("Otros_Impuestos", fila0).ToString("N2");

                Calcular();
                
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        bool Calcular()
        {
            
            bool resultado = false;
            try
            {
                btnAplicar.Enabled = false;

                total = util.GetAsDouble("Total", fila0);
                itbis = util.GetAsDouble("Itbis", fila0);

                retItbis = double.Parse(txtRetItbis.Text.Replace(",", ""));
                retISR = double.Parse(txtRetISR.Text.Replace(",", ""));
                itbisProp = double.Parse(txtItbisProp.Text.Replace(",", ""));
                itbisCosto = double.Parse(txtItbisCosto.Text.Replace(",", ""));
                itbisPorAdelantar = itbis - itbisCosto;
                itbisPercibido = double.Parse(txtItbisPercibido.Text.Replace(",", ""));
                ISRPercibido = double.Parse(txtISRPercibido.Text.Replace(",", ""));
                impSelectivo = double.Parse(txtImpSel.Text.Replace(",", ""));
                propinaLegal = double.Parse(txtPropinaLegal.Text.Replace(",", ""));
                otrosImp =  double.Parse(txtOtrosImpuestos.Text.Replace(",", ""));
                if (cboTipoRet.SelectedValue != null) tipoRet = int.Parse(cboTipoRet.SelectedValue.ToString());

                aPagar = total - (retItbis + retISR);

                lblAPagar.Text = "A Pagar: " + aPagar.ToString("N2");
                txtItbisPorAdelantar.Text = itbisPorAdelantar.ToString("N2");

                if(retItbis > itbis) throw new Exception("El itbis a retener debe set igual o menor a: " + itbis.ToString("N2"));
                if (itbisPorAdelantar < 0) throw new Exception("El itbis llevado al costo debe ser igual o menor a: " + itbis.ToString("N2"));
                if (retISR <= 0) tipoRet = 0;

                resultado = true;
                btnAplicar.Enabled = true;
            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }

            return resultado;
        }

        private void txtRetItbis_Leave(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }
    }
}
