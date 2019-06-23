using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysProcesosERP
{
    public partial class FormScheduleR : WinControl_ELR_NET.ELRFormRegistro
    {

        public List<Tarea> tareaList = new List<Tarea>();
        string codigo = "", descripcion = "", nombreSP = "";

        public FormScheduleR()
        {
            InitializeComponent();
        }

        public override void PasarValorADS()
        {
            if (codigo == "SP") descripcion = "EJECUTAR STORE PROCEDURE: " + txtNombreSP.Text.ToUpper();
            else descripcion = cboTarea.Text;

            DSDatos.Tables[0].Rows[0]["codigo"] = codigo;
            DSDatos.Tables[0].Rows[0]["Descripcion"] = descripcion;
            base.PasarValorADS();
        }

        public override bool GetData()
        {
            bool result = false;
            
            try
            {
                cboTarea.DataSource = tareaList;

                result = base.GetData();


                if(!esNuevo)
                {
                    codigo = objDB.GetAsString("Codigo", DSDatos.Tables[0].Rows[0]);
                    nombreSP = objDB.GetAsString("NombreSP", DSDatos.Tables[0].Rows[0]);
                    descripcion = objDB.GetAsString("Descripcion", DSDatos.Tables[0].Rows[0]);
                    cboTarea.SelectedValue = codigo;
                    cboTarea.Enabled = false;
                }
                else
                {
                    chkEsActivo.Checked = true;
                    chkEsActivo.Enabled = false;

                    dtpHoraInicio.Value = DateTime.Now;
                    dtpHoraFinal.Value = DateTime.Now.AddMinutes(10);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return result;
        }

        private void FormScheduleR_Load(object sender, EventArgs e)
        {

        }

        private void cboTarea_SelectedValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (cboTarea.SelectedValue != null)
                {
                    txtNombreSP.Text = "";
                    codigo = cboTarea.SelectedValue.ToString().ToUpper();
                    descripcion = cboTarea.Text;

                    txtNombreSP.ReadOnly = (codigo != "SP");
                    if(codigo == "SP") txtNombreSP.Text = nombreSP;
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
