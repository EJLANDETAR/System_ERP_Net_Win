using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormSolicitudCreditoR : WinControl_ELR_NET.ELRFormRegistro
    {
        bool esInicio = true;
        public string filtroEntidad = "";

        public FormSolicitudCreditoR()
        {
            InitializeComponent();
        }

        private void txtCedulaRNC_Leave(object sender, EventArgs e)
        {

            if (txtCedulaRNC.Text.Trim() != "") GetEntidad(txtCedulaRNC.Text.Trim());
            
        }

        
        public override bool ValidarDatos(TabPage page)
        {
            bool resultado = false;
            double monto = 0;
            int plazo = 0;
            string motivo = "";
            try
            {
                resultado = base.ValidarDatos(page);
                
                
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void tpDatosGenerales_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (txtCedulaRNC.drFilaSel != null) txtNombres.Focus();
        }

        public override void PasarValorADS(TabPage page)
        {
            int entidadId = 0;
            DateTime fechaNacimiento = DateTime.Now;
            int dia, mes, anio;

            try
            {
                
                base.PasarValorADS(page);
                
                //FECHA NACIMIENTO CLIENTE
                dia = int.Parse( mnuDia.Value.ToString());

                if (cboMes.SelectedValue == null) mes = 1;
                else mes = int.Parse( cboMes.SelectedValue.ToString() );

                anio = int.Parse(txtAnio.Text.Trim());

                if (dia <= 0) dia = 1;
                if (anio <= 0) anio = fechaNacimiento.Year;

                fechaNacimiento = new DateTime(anio, mes, dia);
                SetValorEncabezado("Fecha_Nacimiento", fechaNacimiento);

                
                if (txtCedulaRNC.drFilaSel != null) 
                {
                    entidadId = objUtil.GetAsInt("Entidad_Id", txtCedulaRNC.drFilaSel);
                    
                }

               

                SetValorEncabezado("EsViviendaPropia", rdbViviendaPropia.Checked);
                SetValorEncabezado("EsCasado", rdbEsCasado.Checked);

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public override bool GetData()
        {
            bool resultado = false;
            bool esViviendaPropia = false;
            bool esCasado = false;
            string tipoGarantia = "";
            DataRow fila0;

            try
            {
                //ASIGNAMOS LAS TABLAS TEMPORALES Y LOS STORE PROCEDURE A EJECUTAR
                if (esSolicitudCredito) SPGraba = "SP_PRESTAMOS_GRABA_SOLICITUD";
                else if(esGarantiaPersonal) SPGraba = "SP_PRESTAMOS_GRABA_GARANTIA_PERSONAL";
                else if(esCoDeudor) SPGraba = "SP_PRESTAMOS_GRABA_SOLICITUD_DEUDOR";
               

                resultado =  base.GetData();
                SetValorEncabezado("Solicitud_Id", solicitudId);
                txtCedulaRNC.Enabled = true;
                btnBuscarCliente.Enabled = true;

                btnBuscarCliente.Enabled = esNuevo;

                if (esNuevo == false)
                {
                    fila0 = DSDatos.Tables[0].Rows[0];
                    esViviendaPropia = objUtil.GetAsBoolean("EsViviendaPropia", fila0);
                    esCasado = objUtil.GetAsBoolean("EsCasado", fila0);
                    

                    rdbViviendaPropia.Checked = (esViviendaPropia == true);
                    rdbViviendaAlquilada.Checked = (esViviendaPropia == false);
                    rdbEsCasado.Checked = (esCasado == true);
                    rdbEsSoltero.Checked = (esCasado == false);
                    
                   
                    
                    //Localizacion del cliente
                    cboProvincia.SelectedValue = objDB.GetAsInt("Provincia_Id", fila0);
                    cboMunicipio.SelectedValue = objDB.GetAsInt("Municipio_Id", fila0); 
                    cboSector.SelectedValue = objDB.GetAsInt("Sector_Id", fila0);
                    cboCliEmpresaProvincia.SelectedValue = objDB.GetAsInt("Empresa_Provincia", fila0);
                    cboCliEmpresaMunicipio.SelectedValue = objDB.GetAsInt("Empresa_Municipio", fila0);
                    cboClienteEmpresaSector.SelectedValue = objDB.GetAsInt("Empresa_Sector", fila0);

                    txtCedulaRNC.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                }
                else
                {
                    //Buscamos Datos del Municipio de la Oficina Para Poner Por Defecto
                    cboPais.SelectedValue = defPaisId;
                    cboProvincia.SelectedValue = defProvinciaId;
                    cboMunicipio.SelectedValue = defMunicipioId;
                    cboCliEmpresaProvincia.SelectedValue = defProvinciaId;
                    cboCliEmpresaMunicipio.SelectedValue = defMunicipioId;    
                }

               
            }
            catch (Exception ex)
            {
                
                objUtil.MostrarMensajeError(ex.Message);
            }

            return resultado;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            GetEntidad();
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
            string parentesco = "";
            try
            {
                txtCedulaRNC.drFilaSel = null;

                if (cedulaRNC.Trim() != "")
                {
                    SSQL = "SELECT TOP 1 * FROM VENTIDADES ";
                    SSQL += " WHERE EsActivo = 1";
                    SSQL += " And REPLACE(CedulaRNC, '-', '') = '" + cedulaRNC.Trim().Replace("-", "") + "'";
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

                    frm.ShowDialog();

                    if (frm.filaSelecionada != null) txtCedulaRNC.drFilaSel = frm.filaSelecionada;
                }

                if (txtCedulaRNC.drFilaSel != null)
                {
                    valorId = objUtil.GetAsString("CedulaRNC", txtCedulaRNC.drFilaSel);
                    entidadId = objUtil.GetAsInt("Entidad_Id", txtCedulaRNC.drFilaSel);
                    parentesco = objUtil.GetAsString("Familiar_Parentesco", txtCedulaRNC.drFilaSel);

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


                    txtFamiliarParentesco.Text = parentesco;
                    SetValorEncabezado("Entidad_Id", entidadId);
                    
                }
                else
                {
                    SetValorEncabezado("Entidad_Id", 0);
                    LimpiarControles(tpDatosGenerales);
                    LimpiarControles(tpDatosLaborales);
                    LimpiarControles(tpConyugue);

                    txtCedulaRNC.Text = cedulaRNC;
                    cboPais.SelectedValue = defPaisId;
                    cboProvincia.SelectedValue = defPaisId;
                    cboMunicipio.SelectedValue = defMunicipioId;
                    cboSector.SelectedValue = 0;

                    cboCliEmpresaProvincia.SelectedValue = defPaisId;
                    cboCliEmpresaMunicipio.SelectedValue = defPaisId;
                    cboClienteEmpresaSector.SelectedValue = defPaisId;
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

       
        

        private void txtCedulaRNC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9) GetEntidad();
        }

        

        private void FormSolicitudCreditoR_Load(object sender, EventArgs e)
        {
            try
            {
                lnkGarantias.Enabled = (esSolicitudCredito && !esNuevo);
                lnkCoDeudores.Enabled = (esSolicitudCredito && !esNuevo);
                pnSolicitudENC.Visible = esSolicitudCredito;
                if (!esSolicitudCredito) tpCompletar.Parent = null;

                lblSolicitudNo.Text = "SOLICITUD NO.: " + solicitudId.ToString().PadLeft(7, '0');

                if(esSolicitudCredito) Text = "REGISTRAR SOLICITUD DE CREDITO NO.: " + solicitudId.ToString().PadLeft(7, '0');
                if(esGarantiaPersonal) Text = "REGISTRAR GARANTIA PERSONAL, SOLICITUD NO: " + solicitudId.ToString().PadLeft(7, '0');
                if(esCoDeudor) Text = "REGISTRAR CO-DEUDOR, SOLICITUD NO: " + solicitudId.ToString().PadLeft(7, '0');
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void BTNSECTOR_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.ToUpper();

            if (btnName == "BTNSECTOR") GetSector(0);
            else if (btnName == "BTNCLIENTEEMPRESASECTOR") GetSector(1);
            else if (btnName == "BTNGARANTESECTOR") GetSector(2);
            else if (btnName == "BTNGARANTEEMPRESASECTOR") GetSector(3);
            
        }

        void GetSector(int tipo)
        {
            ELRMaestros.FormSectores frm = new ELRMaestros.FormSectores();
            int sectorId = 0;
            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.EsAgregar = true;
                frm.EsModificar = true;

                frm.ShowDialog();

                if(frm.filaSelecionada != null)
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

        private void btnTipoEmpresaCliente_Click(object sender, EventArgs e)
        {
            GetTipoEmpresa(0);
        }

        void GetTipoEmpresa(int tipo)
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

                    if (tipo == 0) cboClienteEmpresaTipo.SelectedValue = id;
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

        private void btnTipoEmpresaGarante_Click(object sender, EventArgs e)
        {
            GetTipoEmpresa(1);
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == btnProvincia) GetProvincia(0);
            else if (btn == btnCliEmpresaProvincia) GetProvincia(1);
        }

        private void FormSolicitudCreditoR_Activated(object sender, EventArgs e)
        {
            esInicio = false;
        }

        private void tpConyugue_Click(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void elrTextBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkGarantias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSolicitudGarantias2 frm = new FormSolicitudGarantias2();
            string ANombre = "";
            try
            {
                ANombre = txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim();

                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;
                frm.solicitudId = solicitudId;
                frm.oficinaID = OFICINA_ID;
                frm.empresaID = EMPRESA_ID;
                frm.aNombre = ANombre;
                frm.DTVariablesSYS = DTVariablesSYS;
                frm.DTOficina = DTOficina;
                //frm.DTEmpresaOficinas = ;
                frm.DSGlobal = DSGlobal;
                frm.EsGarantiaPersonal = true;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void lnkCoDeudores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSolicitudDeudores2 frm = new FormSolicitudDeudores2();
            string ANombre = "";
            try
            {
                ANombre = txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim();

                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;
                frm.solicitudId = solicitudId;
                frm.ANombre = ANombre;
                frm.FiltroEstatico = "Solicitud_Id = " + solicitudId.ToString() + " And Fecha_Deleted Is Null And EsNulo = 0";
               
                frm.oficinaID = OFICINA_ID;
                frm.empresaID = EMPRESA_ID;
                frm.DTVariablesSYS = DTVariablesSYS;
                frm.DTOficina = DTOficina;
                //frm.DTEmpresaOficinas = ;
                frm.DSGlobal = DSGlobal;
                frm.EsGarantiaPersonal = true;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCerrarSol_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                objDB.LimpiarDetalleTemporal(TablaEncabezado, temporalID);
                Close();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ELRPrintDocument.ELRDocument pd = new ELRPrintDocument.ELRDocument();
            try
            {
                Cursor = Cursors.WaitCursor;

                if (solicitudId  > 0)
                {
                    pd.GenerarContractoPDF(solicitudId, "SOL", nombreUsuario);
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
