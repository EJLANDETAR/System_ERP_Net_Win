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
    public partial class FormActivosFijosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormActivosFijosR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            double depreAcumulada = 0;

            try
            {
                resultado = base.GetData();

                if ( (resultado) && (esNuevo) )
                {
                    dtpFechaAdquisicion.Value = DateTime.Now.Date;
                    dtpFechaIniDepreciacion.Value = DateTime.Now.Date; 
                }
                else
                {
                    depreAcumulada = objUtil.GetAsDouble("Depre_Acumulada", DSDatos.Tables[0].Rows[0]);
                    cboTipo.Enabled = (depreAcumulada == 0);
                    dtpFechaAdquisicion.Enabled = (depreAcumulada == 0);
                    txtFacturaNo.Enabled = (depreAcumulada == 0);
                    txtSuplidorNombre.Enabled = (depreAcumulada == 0);
                    cboOficina.Enabled = (depreAcumulada == 0);
                    cboUbicacion.Enabled = (depreAcumulada == 0);
                    txtResponsable.Enabled = (depreAcumulada == 0);
                    dtpFechaIniDepreciacion.Enabled = (depreAcumulada == 0);
                    txtVidaUtil.Enabled = (depreAcumulada == 0);
                    txtValorAdquisicion.Enabled = (depreAcumulada == 0);
                    cboMetodoDepreciacion.Enabled = (depreAcumulada == 0);
                    //txtSerialNo.Enabled = (depreAcumulada == 0);
                    
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

            
        }

        private void elrCombobox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int vidaUtil = 4;
            string valorId = "0";
            DataRow dr = null;

            try
            {
                if(cboTipo.SelectedValue != null)
                {
                    valorId = cboTipo.SelectedValue.ToString();
                    dr = cboTipo.data.Select("Tipo_Id = " + valorId)[0];

                    vidaUtil = objUtil.GetAsInt("Vida_Util", dr);
                }

                txtVidaUtil.Text = vidaUtil.ToString();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormActivosFijosR_Load(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void elrTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
