using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormOpcionesImpCaja : Form
    {
        string serialNumero = "";
        public bool lOK = false;
        public string nombreUsuario = "";
        string variableMetodo = "";
        string variableImpNombre = "";
        int metodoImp = 3;
        string valor = "";

        ELRUtils util = new ELRUtils();
        DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();

        public DataTable DTVariables = null;
        

        public FormOpcionesImpCaja()
        {
            InitializeComponent();
        }

        private void FormOpcionesImpCaja_Load(object sender, EventArgs e)
        {
            
            try
            {
                objDB.NOMBRE_USUARIO = nombreUsuario;
                serialNumero = util.GetSerialNumber();
                variableMetodo = "CAJA_METODO_IMPRIME_" + serialNumero;
                variableImpNombre = "CAJA_IMP_NOMBRE_" + serialNumero;

                //Buscamos el metodo de impresion
                valor = util.GetValorVariable(variableMetodo, DTVariables);
                int.TryParse(valor, out metodoImp);
                if (metodoImp <= 0) metodoImp = 3;

                if (metodoImp == 1) cboMetodo.SelectedIndex = 0;
                else if (metodoImp == 2) cboMetodo.SelectedIndex = 1;
                else cboMetodo.SelectedIndex = 2;

                //Listamos las impresoras
                valor = util.GetValorVariable(variableImpNombre, DTVariables);
                cboImpresora.Items.Add("DEFAULT");
                cboImpresora.Items.Add("MOSTRAR_CUADRO_DIALOGO");
                
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cboImpresora.Items.Add(printer);
                }

                for (int i = 0; i < cboImpresora.Items.Count - 1; i++)
                {
                    if (cboImpresora.Items[i].ToString().ToUpper() == valor)
                    {
                        cboImpresora.SelectedIndex = i;
                        break;
                    }
                }

                lblSerialNo.Text = "Serial No.: " + serialNumero;
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreImpresora = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int resultado = 0;
            try
            {
                metodoImp = cboMetodo.SelectedIndex + 1;
                nombreImpresora = cboImpresora.Text.Trim();

                objDB.iniciarTransaccion();
                parms.Add(new DataDB_ELR_NET.Parametro("Variable", variableMetodo));
                parms.Add(new DataDB_ELR_NET.Parametro("Valor", metodoImp));
                parms.Add(new DataDB_ELR_NET.Parametro("Comentario", ""));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                parms.Add(new DataDB_ELR_NET.Parametro("msg", "", true));
                resultado = objDB.EjecutarSP("SP_SISTEMA_REGISTRAR_VARIABLE", parms);

                if (resultado > 0)
                {
                    parms = new List<DataDB_ELR_NET.Parametro>();
                    parms.Add(new DataDB_ELR_NET.Parametro("Variable", variableImpNombre));
                    parms.Add(new DataDB_ELR_NET.Parametro("Valor", nombreImpresora));
                    parms.Add(new DataDB_ELR_NET.Parametro("Comentario", ""));
                    parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));
                    parms.Add(new DataDB_ELR_NET.Parametro("msg", "", true));
                    resultado = objDB.EjecutarSP("SP_SISTEMA_REGISTRAR_VARIABLE", parms);
                }

                if (resultado <= 0)
                {
                    objDB.cancelarTransaccion();
                    util.MostrarMensajeError(objDB.MENSAJE);
                }
                else
                {
                    objDB.confirmarTransaccion();
                    lOK = true;
                    Close();
                }

            }
            catch (Exception ex)
            {
                objDB.iniciarTransaccion();
                util.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }
    }
}
