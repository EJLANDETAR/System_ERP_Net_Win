using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRMaestros
{
    public partial class FormProductosR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormProductosR()
        {
            InitializeComponent();
        }

        public override bool ValidarDatos()
        {
            bool valido = false;
            DialogResult resp;
            string codigo = "SC";
            string categoriaId = "";

            try
            {
                 valido = base.ValidarDatos();

                 if ((txtCodigoBarra.Text.Trim() == "") && (valido))
                 {
                     valido = false;
                     resp = objUtil.MostrarMensajePregunta("¿DESEA QUE EL SISTEMA GENERE EL CODIGO DE BARRA?");

                     if (resp == System.Windows.Forms.DialogResult.Yes)
                     {
                         categoriaId = cboCategoria.SelectedValue.ToString() + "-";

                         codigo += categoriaId + objUtil.GetNumeroAleatorio().ToString();
                         txtCodigoBarra.Text = codigo;
                         DSDatos.Tables[0].Rows[0]["Codigo_Barra"] = codigo;

                         valido = true;
                     }

                     
                 }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error al Validar Datos, " + ex.Message);
            }

            return valido;

        }

        private void FormProductosR_Load(object sender, EventArgs e)
        {
            try
            {
                if(EnEjecusion)
                {
                    //AGREGAMOS OPCIONES PARA MOSTRAR EN MENU
                    addButtonAMenuLateral("ELRMaestros.FormCategoriaProducto", "Categorias");
                    addButtonAMenuLateral("ELRMaestros.FormMarcas", "Marcas");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            
        }

        public override void ClickBotonLateral(string btnText = "")
        {
            try
            {
                if(btnText.ToUpper() == "CATEGORIAS")
                {
                    cboCategoria.LlenarCombo();
                    MostrarMenuLateral(false);
                    cboCategoria.Focus();
                }
                else if(btnText.ToUpper()=="MARCAS")
                {
                    cboMarca.LlenarCombo();
                    MostrarMenuLateral(false);
                    cboMarca.Focus();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
