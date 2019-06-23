using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormEditCliente : Form
    {
        public string nombreUsuario = "";
        public int entidadId = 0;
        public int oficinaId = 0;
        public bool esEdit = true;
        public string nombreCompleto = "";
        public string cedulaRNC = "";
        public string direccion = "";
        public string telefonos = "";
        public string temporalId = "";
        public string nombres = "", apellidos = "", telefono1 = "", telefono2 = "";

        public string titulo = "ELEGIR ENTIDAD (CLIENTE)";
        public bool lOK = false;

        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        ELRUtils utils = new ELRUtils();
        DataTable DTEntidad = null;
        DataRow fila0 = null;
        DataRow filaDesglose = null;
        DataTable DTData = null;

        const string TABLE_NAME = "TTEMPORAL_DESGLOSE_PAGO_ENTIDAD";
        const string CAMPO_ID = "IdentificadorTemp";

        public ELRFormEditCliente()
        {
            InitializeComponent();
        }

        void mostrarDatoEntidad()
        {
            try
            {
                entidadId = 0;

                entidadId = db.GetAsInt("Entidad_Id", fila0);

                txtCedulaRNC.Text = db.GetAsString("CedulaRNC", fila0);
                txtNombres.Text = db.GetAsString("Nombres", fila0);
                txtApellidos.Text = db.GetAsString("Apellidos", fila0);
                txtDireccion.Text = db.GetAsString("Direccion", fila0);
                txtTelefono1.Text = db.GetAsString("Telefono1", fila0);
                txtTelefono2.Text = db.GetAsString("Telefono2", fila0);
            }
            catch (Exception)
            {

                throw;
            }
        }


        void getEntidadByCedula(string value)
        {
            try
            {
                fila0 = null;
                value = value.Replace("-", "").Trim();
                db.LimpiarFiltros();
                db.AddFiltroPersonalizado("Replace(CedulaRNC, '-', '') = '" + value + "'");
                DTEntidad = db.GetAll("TCLASIFICADOR_ENTIDADES", 1, db.Filtros);

                if (DTEntidad == null) return;
                if (DTEntidad.Rows.Count <= 0) return;
                fila0 = DTEntidad.Rows[0];

                mostrarDatoEntidad();
                txtNombres.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void getEntidadById(int value)
        {
            try
            {
                fila0 = null;
                db.LimpiarFiltros();
                db.AddFiltroIgualA("Entidad_Id", value.ToString());
                DTEntidad = db.GetAll("TCLASIFICADOR_ENTIDADES", 1, db.Filtros);
                if (DTEntidad == null) return;
                if (DTEntidad.Rows.Count <= 0) return;
                fila0 = DTEntidad.Rows[0];

                mostrarDatoEntidad();
                txtNombres.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void ELRFormEditCliente_Load(object sender, EventArgs e)
        {
            
            try
            {
                lOK = false;
                txtCedulaRNC.Enabled = (esEdit || entidadId <= 0);
                btnBuscarCliente.Enabled = (esEdit || entidadId <= 0);
                Text = titulo;
                gbDatos.Text = titulo;
                db.NOMBRE_USUARIO = nombreUsuario;
                if (entidadId > 0) getEntidadById(entidadId);
                else if(cedulaRNC.Trim() != "")
                {
                    txtCedulaRNC.Text = cedulaRNC;
                    getEntidadByCedula(cedulaRNC);
                }

                //Cargamos la data en el temporal
                DTData = db.GetById(TABLE_NAME, temporalId, CAMPO_ID);
                if (DTData.Rows.Count <= 0)
                {
                    filaDesglose = DTData.NewRow();
                    filaDesglose["IdentificadorTemp"] = temporalId;
                    db.InsertarFromFila(filaDesglose, TABLE_NAME, "Unico");
                }
                else filaDesglose = DTData.Rows[0];

                if (txtCedulaRNC.Enabled) txtCedulaRNC.Focus();

            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
            }
        }

        private void txtCedulaRNC_Leave(object sender, EventArgs e)
        {
            try
            {
                getEntidadByCedula(txtCedulaRNC.Text.Trim());

            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormPlantillaIndex frm = null;
            try
            {
                frm = (FormPlantillaIndex)Activator.CreateInstance("ELRMaestros", "ELRMaestros.FormEntidadesIndex").Unwrap();
                frm.empresaID = 1;
                frm.oficinaID = 100;
                frm.EsAgregar = false;
                frm.EsModificar = false;
                frm.esBusqueda = true;
                frm.EnEjecusion = true;
                frm.FiltroEstatico = "";

                frm.ShowDialog();

                if (frm.filaSelecionada != null)
                {
                    fila0 = frm.filaSelecionada;
                    mostrarDatoEntidad();
                    txtNombres.Focus();
                }

            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lOK = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double valor = 0;
            DialogResult resp;
            try
            {
                cedulaRNC = txtCedulaRNC.Text.Trim();
                nombreCompleto = (txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim()).Trim();
                telefonos = (txtTelefono1.Text.Trim() + "  " + txtTelefono2.Text.Trim()).Trim();

                direccion = txtDireccion.Text.Trim();
                nombres = txtNombres.Text.Trim();
                apellidos = txtApellidos.Text.Trim();
                telefono1 = txtTelefono1.Text.Trim();
                telefono2 = txtTelefono2.Text.Trim();

                double.TryParse(telefono1.Replace("-", ""), out valor);

                //Validamos se haya indicado los campos necesarios
                if (nombreCompleto.Length < 10)
                {
                    utils.MostrarMensajeAdvertencia("Debe indicar un nombre valido, Minimo 10 Caracteres");
                    txtNombres.Focus();
                    return;
                }
                else if (direccion.Length < 10)
                {
                    utils.MostrarMensajeAdvertencia("Debe indicar una direccion valida, Minimo 10 Caracteres");
                    txtDireccion.Focus();
                    return;
                }
                else if (valor <= 0 || telefono1.Replace("-", "").Length < 10 )
                {
                    utils.MostrarMensajeAdvertencia("Debe indicar un numero de telefono valido");
                    txtTelefono1.Focus();
                    return;
                }
                else
                {
                    resp = utils.MostrarMensajePregunta("Esta seguro que los datos suministrado estan corecto?");
                    if (resp == DialogResult.Yes)
                    {
                        filaDesglose["Oficina_Id"] = oficinaId;
                        filaDesglose["Entidad_Id"] = entidadId;
                        filaDesglose["CedulaRNC"] = txtCedulaRNC.Text.Trim();
                        filaDesglose["Nombres"] = txtNombres.Text.Trim();
                        filaDesglose["Apellidos"] = txtApellidos.Text.Trim();
                        filaDesglose["Direccion"] = txtDireccion.Text.Trim();
                        filaDesglose["Telefono1"] = txtTelefono1.Text.Trim();
                        filaDesglose["Telefono2"] = txtTelefono2.Text.Trim();

                        

                        cedulaRNC = txtCedulaRNC.Text.Trim();
                        nombreCompleto = (txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim()).Trim();
                        telefonos = (txtTelefono1.Text.Trim() + "  " + txtTelefono2.Text.Trim()).Trim();

                        filaDesglose["Nombre_Completo"] = nombreCompleto;
                        filaDesglose["Telefonos"] = telefonos;

                        direccion = txtDireccion.Text.Trim();
                        nombres = txtNombres.Text.Trim();
                        apellidos = txtApellidos.Text.Trim();
                        telefono1 = txtTelefono1.Text.Trim();
                        telefono2 = txtTelefono2.Text.Trim();

                        db.UpdateFromRow(TABLE_NAME, filaDesglose, CAMPO_ID);
                        lOK = true;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                utils.MostrarMensajeError(ex.Message);
            }
        }
    }
}
