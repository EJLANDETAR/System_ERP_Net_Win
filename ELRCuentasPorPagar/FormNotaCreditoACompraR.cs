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
    public partial class FormNotaCreditoACompraR : WinControl_ELR_NET.ELRFormRegistro
    {
        double totalItbis = 0, total = 0, montoP = 0;
        string NCFAModificar = "B0000000000";
        string nombre = "NOMBRE COMPLETO DEL SUPLIDOR";
        string cedulaRNC = "00000000000";
        string facturaNumero = "00000000";
        int suplidorId = 0, tipoGastoDGII = 0;

        public FormNotaCreditoACompraR()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarCXP frm = new FormBuscarCXP();
            DataRow fila0 = null;
            
            try
            {
                totalItbis = 0; total = 0; montoP = 0;

                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.FiltroEstatico = "CedulaRNC <> 'DGII' and SubString(NCF, 2, 2) In ('01') ";
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    fila0 = frm.filaSelecionada;
                    NCFAModificar = objDB.GetAsString("NCF", fila0);
                    nombre = objDB.GetAsString("Nombre", fila0);
                    cedulaRNC = objDB.GetAsString("CedulaRNC", fila0);
                    suplidorId = objDB.GetAsInt("Suplidor_Id", fila0);
                    tipoGastoDGII = objDB.GetAsInt("Tipo_Gastos_DGII", fila0);
                    facturaNumero = objDB.GetAsString("Factura_Numero", fila0);
                    total = objDB.GetAsDouble("Total", fila0);
                    totalItbis = objDB.GetAsDouble("Itbis", fila0);
                    montoP = objDB.GetAsDouble("Monto_Pendiente", fila0);      
                }

                txtItbis.Text = "0.00";
                txtMonto.Text = "0.00";
                txtSubTotal.Text = "0.00";

                MostrarNCFAModificar();
                PostEncabezadoTemp();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            double monto = 0, itbis = 0, subTotal = 0;

            try
            {
                monto = objUtil.ConvertirANumero(txtMonto.Text);
                itbis = objUtil.ConvertirANumero(txtItbis.Text);
                subTotal = (monto - itbis);
                txtSubTotal.Text = subTotal.ToString("N2");
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormNotaCreditoACompraR_Load(object sender, EventArgs e)
        {

        }

        void MostrarNCFAModificar()
        {
            try
            {
                txtMonto.Enabled = (total > 0);
                txtItbis.Enabled = (totalItbis > 0);

                SetValorEncabezado("Suplidor_Id", suplidorId);
                SetValorEncabezado("CedulaRNC", cedulaRNC);
                SetValorEncabezado("Nombre", nombre);
                SetValorEncabezado("NCF_AModificar", NCFAModificar);
                SetValorEncabezado("Modulo", "NCC");
                SetValorEncabezado("Tipo_Gastos_DGII", tipoGastoDGII);
                SetValorEncabezado("Tipo_NCF", 4);
                
                lblNCFModificar.Text = "FACTURA NO.:  " + facturaNumero + "             ";
                lblNCFModificar.Text += "NCF A MODIFICAR:  " + NCFAModificar;
                lblSuplidor.Text = "SUPLIDOR:  " + cedulaRNC + "      ";
                lblSuplidor.Text += nombre;
                lblMonto.Text = "MONTO TOTAL:  " + total.ToString("N2") + "                                      ";
                lblMonto.Text += "ITBIS:  " + totalItbis.ToString("N2");
                lblMontoPendiente.Text = "MONTO PENDIENTE POR PAGAR:  " + montoP.ToString("N2");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0 = null;
            string SSQL = "";
            try
            {
                resultado = base.GetData();
                if(resultado && !esNuevo)
                {
                    Cursor = Cursors.WaitCursor;
                    resultado = false;
                    fila0 = DSDatos.Tables[0].Rows[0];
                    NCFAModificar = objDB.GetAsString("NCF", fila0);
                    suplidorId = objDB.GetAsInt("Suplidor_Id", fila0);

                    //Buscamos los datos del ncf a modificar
                    SSQL = "SELECT TOP 1 * FROM TCXP WHERE Suplidor_Id = " + suplidorId.ToString();
                    SSQL += " and NCF = '" + NCFAModificar + "' ";
                    fila0 = objDB.GetSQL(SSQL).Rows[0];

                    tipoGastoDGII = objDB.GetAsInt("Tipo_Gastos_DGII", fila0);
                    nombre = objDB.GetAsString("Nombre", fila0);
                    cedulaRNC = objDB.GetAsString("CedulaRNC", fila0);
                    facturaNumero = objDB.GetAsString("Factura_Numero", fila0);
                    total = objDB.GetAsDouble("Total", fila0);
                    totalItbis = objDB.GetAsDouble("Itbis", fila0);
                    montoP = objDB.GetAsDouble("Monto_Pendiente", fila0);

                    MostrarNCFAModificar();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        public override bool ValidarDatos()
        {
            bool resultado = false;
            double monto = 0, itbis = 0;
            string mensaje = "", ncf = "";
            try
            {
                resultado = base.ValidarDatos();
                if(resultado)
                {
                    resultado = false;
                    monto = objUtil.ConvertirANumero(txtMonto.Text);
                    itbis = objUtil.ConvertirANumero(txtItbis.Text);
                    ncf = txtNCF.Text.Trim();


                    if (suplidorId <= 0) mensaje += "\nDebe seleccionar NCF a Modificar";
                    else if (NCFAModificar == "" || NCFAModificar == "B0000000000") mensaje += "\nDebe seleccionar NCF a Modificar";
                    else if (monto > montoP) mensaje += "\nEl monto debe ser menor a " + montoP.ToString("N2");
                    else if (itbis > totalItbis) mensaje += "\nEl itbis debe ser menor a " + totalItbis.ToString("N2");
                    else if (!objUtil.ValidarNCF(ncf, 4)) mensaje += "\nEl NCF es invalido";
                    
                    if (mensaje.Trim() != "") objUtil.MostrarMensajeAdvertencia(mensaje);
                    else resultado = true;

                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

    }
}
