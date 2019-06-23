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
    public partial class FormEntidadesRegistro : WinControl_ELR_NET.ELRFormRegistro
    {
        int paisId = 0, provinciaId = 0, municipioId = 0, sectorId = 0;

        public FormEntidadesRegistro()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DateTime fecha = DateTime.Now.Date;
            DataRow fila0 = null;
            try
            {
                resultado = base.GetData();
                if (esNuevo)
                {
                    dtpFechaNacimiento.Value = fecha.AddYears(-18);

                    cboPais.SelectedValue = defPaisId;
                    cboProvincia.SelectedValue = defProvinciaId;
                    cboMunicipio.SelectedValue = defMunicipioId;
                }
                else
                {
                    fila0 = DSDatos.Tables[0].Rows[0];
                    paisId = objUtil.GetAsInt("Pais_Id", fila0);
                    provinciaId = objUtil.GetAsInt("Provincia_Id", fila0);
                    municipioId = objUtil.GetAsInt("Municipio_Id", fila0);
                    sectorId = objUtil.GetAsInt("Sector_Id", fila0);

                    cboPais.SelectedValue = paisId;
                    cboProvincia.SelectedValue = provinciaId;
                    cboMunicipio.SelectedValue = municipioId;
                    cboSectores.SelectedValue = sectorId;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        void GetSector()
        {
            FormSectores frm = new FormSectores();
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = true;
                frm.EsModificar = true;

                if(cboMunicipio.SelectedValue != null)
                {
                    municipioId = int.Parse(cboMunicipio.SelectedValue.ToString());
                    frm.FiltroEstatico = "Municipio_Id = " + municipioId.ToString();
                }

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    cboSectores.LlenarCombo();

                    sectorId = objUtil.GetAsInt("Sector_Id", frm.filaSelecionada);

                    cboSectores.SelectedValue = sectorId;

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

        private void btnBuscarProvincia_Click(object sender, EventArgs e)
        {
            GetProvincia();
        }

        private void btnBuscarMunicipio_Click(object sender, EventArgs e)
        {
            GetMunicipio();
        }

        void GetProvincia()
        {
            FormProvincias frm = new FormProvincias();
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = false;
                frm.EsModificar = false;

                if (cboPais.SelectedValue != null)
                {
                    paisId = int.Parse(cboPais.SelectedValue.ToString());
                    frm.FiltroEstatico = "Pais_Id = " + paisId.ToString();
                }

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {  
                    provinciaId = objUtil.GetAsInt("Provincia_Id", frm.filaSelecionada);
                    cboProvincia.SelectedValue = provinciaId;
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

        void GetMunicipio()
        {
            FormProvincias frm = new FormProvincias();
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = false;
                frm.EsModificar = false;

                if (cboProvincia.SelectedValue != null)
                {
                    provinciaId = int.Parse(cboProvincia.SelectedValue.ToString());
                    frm.FiltroEstatico = "Provincia_Id = " + provinciaId.ToString();
                }

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    municipioId = objUtil.GetAsInt("Municipio_Id", frm.filaSelecionada);
                    cboMunicipio.SelectedValue = municipioId;
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

        private void btnGaranteEmpresaSector_Click(object sender, EventArgs e)
        {
            GetSector();
        }
    }
}
