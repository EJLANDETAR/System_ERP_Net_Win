using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRActivosFijos
{
    public partial class FormActivosFijosVentasR : WinControl_ELR_NET.ELRFormRegistro
    {
        double montoCompra = 0, valorLibro = 0, depreAcumulada = 0;

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorId = -1;
            try
            {
                txtGananciaPerdida.Enabled = false;

                if (cboTipo.Text.Trim() != "") valorId = cboTipo.SelectedIndex;
                txtMonto.Enabled = (valorId == 0);

                if(valorId != 0)
                {
                    txtMonto.Text = "0.0";
                    txtGananciaPerdida.Text = "0.00";
                }

                if (valorId == 0)
                {
                    SetValorEncabezado("Tipo", "VENTA");
                    txtMonto.Focus();
                }
                else SetValorEncabezado("Tipo", "RETIRO");

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetActivoFijo();
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            double montoVenta = 0, ganancia;
            try
            {
                if(cboTipo.SelectedIndex == 0)
                {

                    if (txtMonto.Text.Trim() == "") txtMonto.Text = "0.00";

                    montoVenta = double.Parse(txtMonto.Text);
                    ganancia = montoVenta - valorLibro;

                    txtGananciaPerdida.Text = ganancia.ToString("N2");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormActivosFijosVentasR_Load(object sender, EventArgs e)
        {

        }

        public override bool GetData()
        {
            bool resultado = false;

            resultado = base.GetData();
            txtActivoId.Focus();

            return resultado;
        }

        private void txtActivoId_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F9)) GetActivoFijo();
            else if ( (e.KeyCode != Keys.Tab) && (e.KeyCode != Keys.Enter) ) txtActivoId.drFilaSel = null;
        }

        private void txtActivoId_Leave(object sender, EventArgs e)
        {
            int valorId = 0;
            try
            {
                valorId = int.Parse(txtActivoId.Text);
                GetActivoFijo(valorId);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public FormActivosFijosVentasR()
        {
            InitializeComponent();
        }

        void GetActivoFijo(int id = 0)
        {
            DataTable DTData;
            DataRow fila0 = null;
            FormActivosFijos frm = new FormActivosFijos();

            try
            {
                txtActivoId.Text = "0";
                txtActivoNombre.Text = "";
                txtMontoAdquisicion.Text = "0.00";
                txtValorEnLibro.Text = "0.00";
                txtDepreAcumulada.Text = "0.00";
                txtGananciaPerdida.Text = "0.00";


                if (id > 0)
                {
                    objDB.LimpiarFiltros();
                    objDB.AddFiltroIgualA("Activo_Id", id.ToString());
                    objDB.AddFiltroIgualA("EsActivo", "1");
                    objDB.AddFiltroIsNull("Fecha_Baja");
                    DTData = objDB.GetAll("TACTIVOS_FIJOS", 1, objDB.Filtros);
                    if (DTData.Rows.Count > 0) fila0 = DTData.Rows[0];
                }
                else
                {
                    //Realizamos una Busqueda General
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.nombreUsuario = nombreUsuario;
                    frm.FiltroEstatico = "EsActivo = 1 And Fecha_Baja Is Null";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) fila0 = frm.filaSelecionada;

                }

                if (fila0 != null)
                {
                    txtActivoId.Text = objUtil.GetAsString("Activo_Id", fila0, "0");
                    txtActivoNombre.Text = objUtil.GetAsString("Nombre", fila0);

                    montoCompra = objUtil.GetAsDouble("Valor_Adquisicion", fila0);
                    valorLibro = objUtil.GetAsDouble("Valor_Libro_Depreciar", fila0);
                    depreAcumulada = objUtil.GetAsDouble("Depre_Acumulada", fila0);

                    txtMontoAdquisicion.Text = montoCompra.ToString("N2");
                    txtValorEnLibro.Text = valorLibro.ToString("N2");
                    txtDepreAcumulada.Text = depreAcumulada.ToString();

                    cboTipo.Focus();
                    
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
