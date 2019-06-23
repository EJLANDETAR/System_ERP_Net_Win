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
    public partial class FormSectoresR : WinControl_ELR_NET.ELRFormRegistro
    {
        int paisId = 0, provinciaId = 0, municipioId = 0, zonaId = 0;

        public FormSectoresR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataTable DTData = null;
            
            DataRow fila0;
            try
            {
                resultado = base.GetData();
                if(resultado)
                {
                    GetPaises();
                    GetZonas();

                    if (esNuevo)
                    {
                        zonaId = 0;
                        paisId = defPaisId;
                        provinciaId = defProvinciaId;
                        municipioId = defMunicipioId;
                    }
                    else
                    {
                        fila0 = DSDatos.Tables[0].Rows[0];
                        zonaId = objUtil.GetAsInt("Zona_Id", fila0);
                        municipioId = objUtil.GetAsInt("Municipio_Id", fila0);
                        DTData = objDB.GetById("VMUNICIPIOS", municipioId.ToString(), "Municipio_Id");
                        if (DTData.Rows.Count > 0)
                        {
                            fila0 = DTData.Rows[0];
                            paisId = objUtil.GetAsInt("Pais_Id", fila0);
                            provinciaId = objUtil.GetAsInt("Provincia_Id", fila0);
                            if (paisId <= 0) paisId = defPaisId;
                        }
                    }

                    cboPais.SelectedValue = paisId;
                    cboProvincia.SelectedValue = provinciaId;
                    cboMunicipio.SelectedValue = municipioId;
                    cboZona.SelectedValue = zonaId;
                }
                
            }
            catch (Exception ex)
            {
                resultado = false;
                objUtil.MostrarMensajeError(ex.Message);

                Close();
            }

            return resultado;

        }
        
        void GetPaises()
        {
            DataTable DTData = null;
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                DTData = objDB.GetAll("TZONAS_PAISES", -1, objDB.Filtros);
                cboPais.DataSource = DTData.DefaultView; 
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboPais_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboPais.SelectedValue != null)
            {
                paisId = int.Parse(cboPais.SelectedValue.ToString());
                GetProvincias();
            }
        }

        private void cboProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue != null)
            {
                provinciaId = int.Parse(cboProvincia.SelectedValue.ToString());
                GetMunicipios();
            }
        }

        void GetProvincias()
        {
            DataTable DTData = null;
            
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                objDB.AddFiltroIgualA("Pais_Id", paisId.ToString());
                DTData = objDB.GetAll("TZONAS_PROVINCIAS", -1, objDB.Filtros);
                cboProvincia.DataSource = DTData.DefaultView;

                if(cboProvincia.SelectedValue == null) cboProvincia.SelectedValue = defProvinciaId;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormSectoresR_Load(object sender, EventArgs e)
        {

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
                    frm.FiltroEstatico = "EsActivo = 1 And Pais_Id = " + paisId.ToString();
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                }
                else if (btn == btnBuscarMunicipio)
                {
                    frm = new FormMunicipios();
                    frm.FiltroEstatico = "EsActivo = 1 And Provincia_Id = " + provinciaId.ToString();
                    frm.EsAgregar = false;
                    frm.EsModificar = false;
                }
                else if (btn == btnBuscarZona)
                {
                    frm = new FormZonas();
                    frm.FiltroEstatico = "EsActivo = 1 ";
                    frm.EsAgregar = true;
                    frm.EsModificar = true;
                }

                
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;

                frm.ShowDialog();
                if(frm.filaSelecionada != null)
                {
                    if(btn == btnBuscarProvincia)
                    {
                        valorId = objUtil.GetAsInt("Provincia_Id", frm.filaSelecionada);
                        cboProvincia.SelectedValue = valorId;
                    }
                    else if (btn == btnBuscarMunicipio)
                    {
                        valorId = objUtil.GetAsInt("Municipio_Id", frm.filaSelecionada);
                        cboMunicipio.SelectedValue = valorId;
                    }
                    else if (btn == btnBuscarZona)
                    {
                        valorId = objUtil.GetAsInt("Zona_Id", frm.filaSelecionada);
                        GetZonas();
                        cboZona.SelectedValue = valorId;
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

        void GetMunicipios()
        {
            DataTable DTData = null;
            
            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");
                objDB.AddFiltroIgualA("Provincia_Id", provinciaId.ToString());

                DTData = objDB.GetAll("TZONAS_MUNICIPIOS", -1, objDB.Filtros);

                cboMunicipio.DataSource = DTData.DefaultView;
                if (cboMunicipio.SelectedValue == null) cboMunicipio.SelectedValue = defMunicipioId;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void GetZonas()
        {
            DataTable DTData = null;

            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsActivo", "1");

                DTData = objDB.GetAll("TZONAS", -1, objDB.Filtros);

                cboZona.DataSource = DTData.DefaultView;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

    }
}
