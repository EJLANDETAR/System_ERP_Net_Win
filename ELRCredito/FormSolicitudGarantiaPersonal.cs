using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormSolicitudGarantiaPersonal : WinControl_ELR_NET.ELRFormRegistro
    {

        //VARIABLES PUBLICAS
        public int solicitudId = 0;
        public int entidadId = 0;
        public string filtroEntidad = "";

        //VARIABLES PRIVADAS
        bool esViviendaPropia = false;
        bool esCasado = false;

        public FormSolicitudGarantiaPersonal()
        {
            InitializeComponent();
        }

        private void txtCedulaRNC_Leave(object sender, EventArgs e)
        {
            if (txtCedulaRNC.Text.Trim() != "") GetEntidad(txtCedulaRNC.Text.Trim());
        }

        private void FormSolicitudGarantiaPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                if (EnEjecusion)
                {
                    txtCedulaRNC.Enabled = (entidadId <= 0);
                    if (txtCedulaRNC.Enabled) txtCedulaRNC.Focus();

                    esViviendaPropia = objUtil.GetAsBoolean("EsViviendaPropia", DSDatos.Tables[0].Rows[0]);
                    esCasado = objUtil.GetAsBoolean("EsCasado", DSDatos.Tables[0].Rows[0]);

                    rdbViviendaPropia.Checked = (esViviendaPropia == true);
                    rdbViviendaAlquilada.Checked = (esViviendaPropia == false);

                    rdbEsCasado.Checked = (esCasado == true);
                    rdbEsSoltero.Checked = (esCasado == false);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void PasarValorADS(TabPage page)
        {
            DateTime fechaNacimiento = DateTime.Now;
            int dia, mes, anio;
            try
            {
                base.PasarValorADS(page);

                if (txtCedulaRNC.Enabled)
                {
                    if (txtCedulaRNC.drFilaSel != null) entidadId = objUtil.GetAsInt("Entidad_Id", txtCedulaRNC.drFilaSel);
                    else entidadId = 0;

                }

                dia = (int)mnuDia.Value;
                mes = int.Parse(cboMes.SelectedValue.ToString());
                anio = int.Parse(txtAnio.Text);
                fechaNacimiento = new DateTime(anio, mes, dia);

                esCasado = (rdbEsCasado.Checked);
                esViviendaPropia = (rdbViviendaPropia.Checked);

                SetValorEncabezado("Solicitud_Id", solicitudId);
                SetValorEncabezado("Entidad_Id", entidadId);
                SetValorEncabezado("Fecha_Nacimiento", fechaNacimiento);
                SetValorEncabezado("EsViviendaPropia", esViviendaPropia);
                SetValorEncabezado("EsCasado", esCasado);

            }
            catch (Exception)
            {

                throw;
            }
        }

        void GetEntidad(string cedulaRNC = "")
        {
            ELRMaestros.FormEntidadesIndex frm = new ELRMaestros.FormEntidadesIndex();
            bool esViviendaPropia = false;
            bool esCasado = false;
            DataTable DTData;
            string SSQL = "";
            int tipoDocumento = 0;
            string valorId = "";

            try
            {
                txtCedulaRNC.drFilaSel = null;

                if (cedulaRNC.Trim() != "")
                {
                    SSQL = "SELECT TOP 1 * FROM VENTIDADES ";
                    SSQL += " WHERE EsActivo = 1";
                    SSQL += " And Replace(CedulaRNC, '-', '') = '" + cedulaRNC.Trim().Replace("-", "") + "'";

                    if (filtroEntidad != "") SSQL += " And Entidad_Id Not In (" + filtroEntidad + ") ";

                    SSQL += " Order by Unico Desc";

                    DTData = objDB.GetSQL(SSQL);
                    if (DTData.Rows.Count > 0) txtCedulaRNC.drFilaSel = DTData.Rows[0];

                }
                else
                {
                    frm.nombreUsuario = nombreUsuario;
                    frm.empresaID = EMPRESA_ID;
                    frm.oficinaID = OFICINA_ID;
                    frm.esBusqueda = true;
                    frm.EnEjecusion = true;
                    frm.FiltroEstatico = "EsActivo = 1";

                    if (filtroEntidad != "") frm.FiltroEstatico += " And Entidad_Id Not In (" + filtroEntidad + ") ";

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) txtCedulaRNC.drFilaSel = frm.filaSelecionada;
                }

                if (txtCedulaRNC.drFilaSel != null)
                {
                    valorId = objUtil.GetAsString("CedulaRNC", txtCedulaRNC.drFilaSel);
                    txtCedulaRNC.Text = objUtil.FormatearCedulaRNC(valorId);
                    entidadId = objUtil.GetAsInt("Entidad_Id", txtCedulaRNC.drFilaSel);

                    txtCedulaRNC.MostrarEnControles(txtCedulaRNC.drFilaSel);

                    esViviendaPropia = objUtil.GetAsBoolean("EsViviendaPropia", txtCedulaRNC.drFilaSel);
                    esCasado = objUtil.GetAsBoolean("EsCasado", txtCedulaRNC.drFilaSel);


                    rdbViviendaPropia.Checked = (esViviendaPropia == true);
                    rdbViviendaAlquilada.Checked = (esViviendaPropia == false);

                    rdbEsCasado.Checked = (esCasado == true);
                    rdbEsSoltero.Checked = (esCasado == false);

                    //VALIDAMOS EL TIPO DE DOCUMENTO
                    //Procedemos a Validar si es Cedula TipoDocumento = 1, RNC TipoDocumento = 2 else TipoDocumento = 3
                    if (objUtil.ValidarCedula(valorId)) tipoDocumento = 1;
                    else if (objUtil.ValidarRNC(valorId)) tipoDocumento = 2;
                    else tipoDocumento = 3;

                    

                    txtNombres.Focus();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetEntidad();
        }

        private void txtCedulaRNC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9) GetEntidad();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataRow fila0 = null;
            try
            {
                btnBuscar.Enabled = false;
                txtCedulaRNC.Enabled = false;
               

                resultado = base.GetData();

                if(resultado)
                {
                    btnBuscar.Enabled = esNuevo;
                    txtCedulaRNC.Enabled = esNuevo;

                    if(esNuevo)
                    {
                        cboPais.SelectedValue = defPaisId;
                        cboProvincia.SelectedValue = defProvinciaId;
                        cboMunicipio.SelectedValue = defMunicipioId;
                        cboSector.SelectedValue = 1;

                        cboCliEmpresaProvincia.SelectedValue = defProvinciaId;
                        cboCliEmpresaMunicipio.SelectedValue = defMunicipioId;
                        cboClienteEmpresaTipo.SelectedValue = 1;
                        cboClienteEmpresaSector.SelectedValue = 1;
                    }
                    else
                    {
                        fila0 = DSDatos.Tables[0].Rows[0];

                        //Localizacion del cliente
                        cboProvincia.SelectedValue = objDB.GetAsInt("Provincia_Id", fila0);
                        cboMunicipio.SelectedValue = objDB.GetAsInt("Municipio_Id", fila0);
                        cboSector.SelectedValue = objDB.GetAsInt("Sector_Id", fila0);
                        cboCliEmpresaProvincia.SelectedValue = objDB.GetAsInt("Empresa_Provincia", fila0);
                        cboCliEmpresaMunicipio.SelectedValue = objDB.GetAsInt("Empresa_Municipio", fila0);
                        cboClienteEmpresaSector.SelectedValue = objDB.GetAsInt("Empresa_Sector", fila0);
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;

        }

        void GetTipoEmpresa()
        {
            ELRMaestros.FormTipoEmpresas frm = new ELRMaestros.FormTipoEmpresas();
            int id = 0;
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = true;
                frm.EsModificar = true;

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    id = objUtil.GetAsInt("Tipo_Id", frm.filaSelecionada);
                    cboClienteEmpresaTipo.LlenarCombo();
                   
                    cboClienteEmpresaTipo.SelectedValue = id;
                    
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

        void GetSector(int tipo)
        {
            ELRMaestros.FormSectores frm = new ELRMaestros.FormSectores();
            int sectorId = 0, municipioId = 0; ;
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = true;
                frm.EsModificar = true;

                if (tipo == 0) municipioId = int.Parse(cboMunicipio.SelectedValue.ToString());
                else municipioId = int.Parse(cboCliEmpresaMunicipio.SelectedValue.ToString());

                frm.FiltroEstatico = "ESActivo = 1 And Municipio_Id = " + municipioId.ToString();

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    cboSector.LlenarCombo();
                    cboClienteEmpresaSector.LlenarCombo();

                    sectorId = objUtil.GetAsInt("Sector_Id", frm.filaSelecionada);

                    if (tipo <= 0) cboSector.SelectedValue = sectorId;
                    else if (tipo == 1) cboClienteEmpresaSector.SelectedValue = sectorId;

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

        void GetProvincia(int tipo)
        {
            ELRMaestros.FormProvincias frm = new ELRMaestros.FormProvincias();
            int provinciaId = 0, paisId = 0;
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = false;
                frm.EsModificar = false;

                if (tipo == 0 && cboPais.SelectedValue != null) paisId = int.Parse(cboPais.SelectedValue.ToString());
                else paisId = defPaisId;

                frm.FiltroEstatico = "EsActivo = 1 And Pais_Id = " + paisId.ToString();


                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {


                    provinciaId = objUtil.GetAsInt("Provincia_Id", frm.filaSelecionada);

                    if (tipo <= 0) cboProvincia.SelectedValue = provinciaId;
                    else if (tipo == 1) cboCliEmpresaProvincia.SelectedValue = provinciaId;

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

        void GetMunicipio(int tipo)
        {
            ELRMaestros.FormMunicipios frm = new ELRMaestros.FormMunicipios();
            int provinciaId = 0, municipioId = 0;
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = false;
                frm.EsModificar = false;

                if (tipo == 0 && cboProvincia.SelectedValue != null) provinciaId = int.Parse(cboProvincia.SelectedValue.ToString());
                else if (tipo == 1 && cboCliEmpresaProvincia.SelectedValue != null) provinciaId = int.Parse(cboCliEmpresaProvincia.SelectedValue.ToString());
                else provinciaId = defProvinciaId;

                frm.FiltroEstatico = "EsActivo = 1 And Provincia_Id = " + provinciaId.ToString();


                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {


                    municipioId = objUtil.GetAsInt("Municipio_Id", frm.filaSelecionada);

                    if (tipo <= 0) cboMunicipio.SelectedValue = municipioId;
                    else if (tipo == 1) cboCliEmpresaMunicipio.SelectedValue = municipioId;

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

        private void button2_Click(object sender, EventArgs e)
        {
            GetTipoEmpresa();
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            GetProvincia(0);
        }

        private void btnBuscarMunicipio_Click(object sender, EventArgs e)
        {
            GetMunicipio(0);
        }

        private void btnSector_Click(object sender, EventArgs e)
        {
            GetSector(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetProvincia(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetMunicipio(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetSector(1);
        }
    }
}
