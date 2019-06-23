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
    public partial class FormRepresentantesR : WinControl_ELR_NET.ELRFormRegistro
    {
        int municipioId = 0;
        int provinciaId = 0;

        DataTable DTMunicipios = null;
        DataView DVMunicipios = null;

        public FormRepresentantesR()
        {
            InitializeComponent();
        }

        private void FormRepresentantesR_Load(object sender, EventArgs e)
        {

        }

        public override bool GetData()
        {
            bool resultado = false;
            string SSQL = "";
            DataRow fila0;
            DataRow[] filas;
            try
            {
                GetProvincias();

                //Buscamos los datos del municipio
                SSQL = "SELECT * FROM TZONAS_MUNICIPIOS ";
                DTMunicipios = objDB.GetSQL(SSQL);
                DVMunicipios = DTMunicipios.DefaultView;
                cboMunicipio.DataSource = DVMunicipios;

                resultado = base.GetData();
                

                fila0 = DSDatos.Tables[0].Rows[0];
                municipioId = objDB.GetAsInt("Municipio_Id", fila0);

                

                DVMunicipios.RowFilter = "Municipio_Id = " + municipioId.ToString();
                if (DVMunicipios.Count > 0)
                {
                    filas = DTMunicipios.Select("Municipio_Id = " + municipioId.ToString());
                    if (filas.Count() > 0) provinciaId = Convert.ToInt32(filas[0]["Provincia_Id"].ToString());
                }

                cboProvincia.SelectedValue = provinciaId;
                cboMunicipio.SelectedValue = municipioId;
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        void GetProvincias()
        {
            DataTable DTData = null;

            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                DTData = objDB.GetAll("TZONAS_PROVINCIAS", -1, objDB.Filtros);
                cboProvincia.DataSource = DTData.DefaultView;

                if (cboProvincia.SelectedValue == null) cboProvincia.SelectedValue = 0;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DVMunicipios == null) return;
                if (cboProvincia.SelectedValue == null) return;

                provinciaId = int.Parse(cboProvincia.SelectedValue.ToString());
                DVMunicipios.RowFilter = "Provincia_Id = " + provinciaId.ToString();
                cboMunicipio.DataSource = DVMunicipios;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarProvincia_Click(object sender, EventArgs e)
        {
            int valorId = 0;
            WinControl_ELR_NET.FormPlantillaIndex frm = null;
            Button btn = (Button)sender;
            try
            {
                if (btn == btnBuscarProvincia)
                {
                    frm = new FormProvincias();
                    frm.FiltroEstatico = "EsActivo = 1 ";
                    
                }
                else if (btn == btnBuscarMunicipio)
                {
                    frm = new FormMunicipios();
                    frm.FiltroEstatico = "EsActivo = 1 And Provincia_Id = " + provinciaId.ToString();     
                }


                frm.EsAgregar = false;
                frm.EsModificar = false;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;

                frm.ShowDialog();
                if (frm.filaSelecionada != null)
                {
                    if (btn == btnBuscarProvincia)
                    {
                        valorId = objUtil.GetAsInt("Provincia_Id", frm.filaSelecionada);
                        cboProvincia.SelectedValue = valorId;
                    }
                    else if (btn == btnBuscarMunicipio)
                    {
                        valorId = objUtil.GetAsInt("Municipio_Id", frm.filaSelecionada);
                        cboMunicipio.SelectedValue = valorId;
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
    }
}
