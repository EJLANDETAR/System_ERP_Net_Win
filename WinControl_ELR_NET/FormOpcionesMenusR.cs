using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinControl_ELR_NET
{
    public partial class FormOpcionesMenusR : ELRFormRegistro
    {
        public FormOpcionesMenusR()
        {
            InitializeComponent();
        }

        private void btnCambiarImage_Click(object sender, EventArgs e)
        {
            FormSelectImage frm = new FormSelectImage();

            try
            {
                ptbImage.Image = null;
                ptbImage.Tag = "";

                frm.ShowDialog();

                if (frm.nombreImagen.Trim() != null)
                {
                    if (File.Exists(frm.pathImagen))
                    {
                        ptbImage.Image = Image.FromFile(frm.pathImagen);
                        ptbImage.Tag = frm.nombreImagen;
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }

        }

        public override bool GetData()
        {
            bool resultado = false;
            string nombreImage = "";

            try
            {
                resultado = base.GetData();
                ptbImage.Image = null;
                ptbImage.Tag = "";

                txtNombre.Text = DSDatos.Tables[0].Rows[0]["Nombre"].ToString();
                txtURL.Text = DSDatos.Tables[0].Rows[0]["URL"].ToString();
                txtFormAEjecutar.Text = DSDatos.Tables[0].Rows[0]["Formulario_AEjecutar"].ToString();

                if (resultado)
                {
                    nombreImage = DSDatos.Tables[0].Rows[0]["Image"].ToString();
                    if (nombreImage.Trim() != "")
                    {
                        ptbImage.Tag = nombreImage;
                        nombreImage = dirImage.ToString() + @"\" + nombreImage.Trim();

                        if (File.Exists(nombreImage))
                        {
                            ptbImage.Image = Image.FromFile(nombreImage);
                        }


                    }

                }

            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;

        }

        public override bool ValidarDatos()
        {
            bool resultado = false;

            try
            {
                resultado = base.ValidarDatos();

                if (resultado)
                {
                    if (ptbImage.Tag == null) DSDatos.Tables[0].Rows[0]["Image"] = "";
                    else DSDatos.Tables[0].Rows[0]["Image"] = ptbImage.Tag.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError("Error al Validar Datos, " + ex.Message);
            }

            return resultado;

        }

        private void FormOpcionesMenusR_Load(object sender, EventArgs e)
        {
            txtFormAEjecutar.CharacterCasing = CharacterCasing.Normal;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtURL.CharacterCasing = CharacterCasing.Normal;
        }

        public override void PasarValorADS()
        {
            try
            {
                base.PasarValorADS();
                DSDatos.Tables[0].Rows[0]["Nombre"] = txtNombre.Text.Trim();
                DSDatos.Tables[0].Rows[0]["URL"] = txtURL.Text.Trim();
                DSDatos.Tables[0].Rows[0]["Formulario_AEjecutar"] = txtFormAEjecutar.Text.Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboModulo_SelectedValueChanged(object sender, EventArgs e)
        {
            string modudoId = "0";
            string SSQL = "";
            DataTable DTData = null;
            int ordenNo = 0;
            try
            {
                if (esNuevo && cboModulo.SelectedValue != null)
                {
                    modudoId = cboModulo.SelectedValue.ToString();
                    SSQL = "SELECT IsNull(Max(OrdenNo), 0) + 1 as OrdenNo FROM TACCESOS_OPCIONES_MENU WHERE Modulo_Id = " + modudoId;
                    DTData = objDB.GetSQL(SSQL);
                    ordenNo = objUtil.GetAsInt("OrdenNo", DTData.Rows[0]);
                    SetValorEncabezado("OrdenNo", ordenNo);
                    txtOrdenNo.Text = ordenNo.ToString();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
