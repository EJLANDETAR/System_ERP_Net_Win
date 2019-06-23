using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRMaestros
{
    public partial class FormDocTemplatesR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormDocTemplatesR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            int evento = 1;
            try
            {
                resultado = base.GetData();
                if(!esNuevo)
                {
                    evento = objDB.GetAsInt("Evento", DSDatos.Tables[0].Rows[0]);
                    if (evento <= 0) evento = 1;
                }

                cboEvento.SelectedIndex = evento - 1;

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
            
        }

        public override void PasarValorADS()
        {
            int evento = 1;
            string descripcion = "";
            try
            {
                
                base.PasarValorADS();

                evento = cboEvento.SelectedIndex + 1;
                SetValorEncabezado("Evento", evento);

                descripcion = objDB.GetAsString("Descripcion", DSDatos.Tables[0].Rows[0]);
                if (descripcion.Trim() == "") descripcion = cboCodigo.Text;
                SetValorEncabezado("Descripcion", descripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
