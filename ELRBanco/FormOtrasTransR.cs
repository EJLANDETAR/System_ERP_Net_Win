using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRBanco
{
    public partial class FormOtrasTransR : WinControl_ELR_NET.ELRFormRegistro
    {
        DataTable DTTipos;
        DataTable DTCuentas;

        public FormOtrasTransR()
        {
            InitializeComponent();
        }

        private void FormOtrasTransR_Load(object sender, EventArgs e)
        {
            try
            {
                if (EnEjecusion)
                {
                    addButtonAMenuLateral("ELRBanco.FormBancos");
                    addButtonAMenuLateral("ELRBanco.FormBancosCuentas");
                    addButtonAMenuLateral("ELRBanco.FormBancoTiposTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancosCheques");
                    addButtonAMenuLateral("ELRBanco.FormImprimirCheques");
                    addButtonAMenuLateral("ELRBanco.FormBancosDepositos");
                    addButtonAMenuLateral("ELRBanco.FormBancosConsTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancoAnularTrans");
                    addButtonAMenuLateral("ELRBanco.FormBancoConciliaciones");
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
            
            try
            {
                //Buscamo los Tipos de Transaccion
                objDB.LimpiarFiltros();
                objDB.AddFiltroPersonalizado("Tipo Not Like 'CK%' ");
                objDB.AddFiltroPersonalizado("Tipo Not Like 'CHK%' ");
                objDB.AddFiltroPersonalizado("Tipo Not Like 'DEP%' ");

                DTTipos = objDB.GetAll("TBANCOS_TRANS_TIPOS", -1, objDB.Filtros);
                cboTipo.DataSource = DTTipos.DefaultView;

                //Buscamos las Cuentas
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTCuentas = objDB.GetAll("TBANCOS_CUENTAS_BANCARIAS", -1, objDB.Filtros);
                cboCuenta.DataSource = DTCuentas.DefaultView;

                resultado = base.GetData();

                if (esNuevo) dtpFecha.Value = objDB.FECHA_CONTABLE;

                dtpFecha.Enabled = EsCambiarFecha;
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public override void PasarValorADS()
        {
            string origen = "D";
            double monto = 0;
            DataRow fila0;
            string tipo = "";
            string cuentaId = "0";
            string cuentaNumero = "0";

            try
            {
                base.PasarValorADS();

                monto = double.Parse(txtMonto.Text);
                if(cboTipo.Text.Trim() != "")
                {
                    tipo = cboTipo.SelectedValue.ToString();
                    fila0 = DTTipos.Select("Tipo = '" + tipo + "'")[0];
                    origen = objUtil.GetAsString("Tipo", fila0).ToUpper();
                }

                if (cboCuenta.Text.Trim() != "")
                {
                    cuentaId = cboCuenta.SelectedValue.ToString();
                    fila0 = DTCuentas.Select("Cuenta_Id = " + cuentaId)[0];
                    cuentaNumero = objUtil.GetAsString("Numero", fila0);
                }

                SetValorEncabezado("Cuenta_Numero", cuentaNumero);

                if (origen == "D")
                {
                    SetValorEncabezado("Debito", monto);
                    SetValorEncabezado("Beneficiario", cboCuenta.Text);
                }
                else
                {
                    SetValorEncabezado("Credito", monto);
                    SetValorEncabezado("Beneficiario", "");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
