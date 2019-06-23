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
    public partial class FormDesglosePagoCliente : Form
    {
        public string nombreUsuario = "";
        public int entidadId = 0;
        public int oficinaId = 0;
        public string nombreCompleto = "";
        public string cedulaRNC = "";
        public string direccion = "";
        public string telefonos = "";
        public string temporalId = "";
        public double monto = 0;
        public double montoUS = 0;
        public double enEfectivo = 0;
        public double enCheques = 0;
        public double enTarjetas = 0;
        public double aDevolver = 0;
        public double aCredito = 0;
        public double montoDeduda = 0;
        public bool esNuevo = true;
        public bool esCredito = true;
        public bool LOK = false;
        public int metodoImp = -1;
        public string nombres = "", apellidos = "", telefono1 = "", telefono2 = "";
        public DateTime fechaVence;
        public int diasCredito;
        public string ncf = "";
        public double aPagar = 0;

        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        ELRUtils utils = new ELRUtils();
        DataTable DTEntidad = null;
        DataTable DTData = null;
        DataRow filaDesglose = null;
        DataTable DTCondicion = null;
        DataRow fila0 = null;
        bool esInicio = true;

        const string TABLE_NAME = "TTEMPORAL_DESGLOSE_PAGO_ENTIDAD";
        const string CAMPO_ID = "IdentificadorTemp";

        public FormDesglosePagoCliente()
        {
            InitializeComponent();
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

        void getEntidadById (int value)
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

        void mostrarDatoEntidad()
        {
            try
            {
                entidadId = 0;
                
                entidadId = db.GetAsInt("Entidad_Id", fila0);
                diasCredito = db.GetAsInt("Dias_Credito", fila0);
                grbCredito.Visible = (esCredito || diasCredito > 0);
                txtAPagar.ReadOnly = !(esCredito || diasCredito > 0);

                txtCedulaRNC.Text = db.GetAsString("CedulaRNC", fila0);
                txtNombres.Text = db.GetAsString("Nombres", fila0);
                txtApellidos.Text = db.GetAsString("Apellidos", fila0);
                txtDireccion.Text = db.GetAsString("Direccion", fila0);
                txtTelefono1.Text = db.GetAsString("Telefono1", fila0);
                txtTelefono2.Text = db.GetAsString("Telefono2", fila0);
                

                //Habilitamos o Deshabilitamos controles
                txtCedulaRNC.Enabled = (esNuevo || ncf == "");
                txtNombres.Enabled = (esNuevo || ncf == "");
                txtApellidos.Enabled = (esNuevo || ncf == "");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtEnEfectivo_Leave(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            double total = 0;
            Button btn = null;

            try
            {
                LOK = true;
                if (Calcular())
                {
                    //VALIDAMOS CONDICION A CREDITO
                    if ((montoDeduda > 0) && (!esCredito) && diasCredito <= 0)
                    {
                        utils.MostrarMensajeAdvertencia("El Credito No esta Permitido");
                        LOK = false;
                    }
                    else if ((montoDeduda > 0) && (esCredito))
                    {
                        LOK = false;
                        respuesta = utils.MostrarMensajePregunta("SE REGISTRARA UNA CUENTA POR COBRAR DE: " + montoDeduda.ToString("N2") + "\r" +
                                                        "ESTA SEGURO DE REGISTRAR LOS DATOS?"
                                                  );
                        if (respuesta == System.Windows.Forms.DialogResult.Yes) LOK = true;
                    }

                    if (LOK)
                    {
                        total = (enEfectivo - aDevolver) + enCheques + enTarjetas;
                        if (total <= 0 && !esCredito) utils.MostrarMensajeAdvertencia("El Desglose de Pago Debe Ser Mayor a Cero");
                        else if ((total - monto) > 1) utils.MostrarMensajeAdvertencia("El Desglose de Pago No Puede ser Mayor al Monto a Pagar");
                        else
                        {
                            Cursor = Cursors.WaitCursor;

                            filaDesglose["Oficina_Id"] = oficinaId;
                            filaDesglose["Entidad_Id"] = entidadId;
                            filaDesglose["CedulaRNC"] = txtCedulaRNC.Text.Trim();
                            filaDesglose["Nombres"] = txtNombres.Text.Trim();
                            filaDesglose["Apellidos"] = txtApellidos.Text.Trim();
                            filaDesglose["Direccion"] = txtDireccion.Text.Trim();
                            filaDesglose["Telefono1"] = txtTelefono1.Text.Trim();
                            filaDesglose["Telefono2"] = txtTelefono2.Text.Trim();

                            filaDesglose["Monto"] = monto;
                            filaDesglose["EnEfectivo"] = enEfectivo;
                            filaDesglose["EnCheques"] = enCheques;
                            filaDesglose["EnTarjetas"] = enTarjetas;
                            filaDesglose["Monto_AlContado"] = monto - montoDeduda;
                            filaDesglose["Monto_ACredito"] = montoDeduda;

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
                            LOK = true;
                        }
                    }

                    Cursor = Cursors.Default;
                    if (LOK)
                    {
                        btn = (Button)sender;
                       
                        this.Close();
                    }
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

        private void FormDesglosePagoCliente_Activated(object sender, EventArgs e)
        {
            try
            {
                if(esInicio)
                {
                    if (txtCedulaRNC.Enabled) txtCedulaRNC.Focus();
                    else if (txtNombres.Enabled) txtNombres.Focus();
                    else if (txtApellidos.Enabled) txtApellidos.Focus();
                    else if (txtDireccion.Enabled) txtDireccion.Focus();
                    else if (txtTelefono1.Enabled) txtTelefono1.Focus();
                    else if (txtTelefono2.Enabled) txtTelefono2.Focus();

                    esInicio = false;
                }
            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
                LOK = false;
                Close();
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


        private void txtAPagar_Leave(object sender, EventArgs e)
        {
            try
            {

                Calcular();
            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
            }
        }

        private void FormDesglosePagoCliente_Shown(object sender, EventArgs e)
        {
            try
            {
                if (entidadId <= 0) txtCedulaRNC.Focus();
                else if (txtAPagar.ReadOnly) txtEnEfectivo.Focus();
                else txtAPagar.Focus();
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

        private void FormDesglosePagoCliente_Load(object sender, EventArgs e)
        {
            bool permiteCheques = false;
            bool permiteTarjetaC = false;
            string sValor = "";
            int valor = 0;
            try
            {
                btnAceptar.Enabled = false;
                
                db.NOMBRE_USUARIO = nombreUsuario;
                lbTotal.Text = "TOTAL: " + monto.ToString("N2");  

                txtAPagar.ReadOnly = !esCredito;
                txtEnEfectivo.Text = enEfectivo.ToString("N2");
                txtEnCheques.Text = enCheques.ToString("N2");
                txtEnTarjeta.Text = enTarjetas.ToString();
                txtACredito.Text = "0.00";
                montoDeduda = monto;
                grbCredito.Visible = esCredito;

                getEntidadById(entidadId);

                txtCedulaRNC.Enabled = esNuevo;

                //Cargamos la data en el temporal
                DTData = db.GetById(TABLE_NAME, temporalId, CAMPO_ID);
                if (DTData.Rows.Count <= 0)
                {
                    filaDesglose = DTData.NewRow();
                    filaDesglose["IdentificadorTemp"] = temporalId;
                    db.InsertarFromFila(filaDesglose, TABLE_NAME, "Unico");
                }
                else filaDesglose = DTData.Rows[0];

                //BUSCAMOS LA VARIABLES PARA PERMITIR COBRO EN CHEQUES
                valor = -1;
                sValor = "";
                sValor = db.GetValorVariable("COBRO_EN_CHEQUES").Trim().ToUpper();
                int.TryParse(sValor, out valor);
                if (valor > 0) permiteCheques = true;
                else permiteCheques = (sValor == "TRUE");

                //BUSCAMOS LA VARIABLES PARA PERMITIR COBRO EN TARJETA CREDITO
                valor = -1;
                sValor = "";
                sValor = db.GetValorVariable("COBRO_EN_TARJETA_C").Trim().ToUpper();
                int.TryParse(sValor, out valor);
                if (valor > 0) permiteTarjetaC = true;
                else permiteTarjetaC = (sValor == "TRUE");

                txtEnCheques.Enabled = permiteCheques;
                txtEnTarjeta.Enabled = permiteTarjetaC;

              

                Calcular();
            }
            catch (Exception ex)
            {

                utils.MostrarMensajeError(ex.Message);
            }
        }

        private bool Calcular()
        {
            bool resultado = false;
            double total;
            
            try
            {
                btnAceptar.Enabled = false;
                
                montoDeduda = 0;
                diasCredito = 0;
                fechaVence = DateTime.Now.Date;
                enEfectivo = utils.ConvertirANumero(txtEnEfectivo.Text);
                enCheques = utils.ConvertirANumero(txtEnCheques.Text);
                enTarjetas = utils.ConvertirANumero(txtEnTarjeta.Text);
                aPagar = utils.ConvertirANumero(txtAPagar.Text);

                aDevolver = enEfectivo - aPagar;
                if(aDevolver < 0) aDevolver = 0;

                total = (enEfectivo - aDevolver) + enCheques + enTarjetas;
                if ((enEfectivo < 0) || (enCheques < 0) || (enTarjetas < 0) || (aPagar < 0))
                {
                    if (aPagar < 0)
                    {
                        txtAPagar.SelectAll();
                        txtAPagar.Focus();
                    }
                    else if (enEfectivo < 0)
                    {
                        txtEnEfectivo.SelectAll();
                        txtEnEfectivo.Focus();
                    }
                    else if (enCheques < 0)
                    {
                        txtEnCheques.SelectAll();
                        txtEnCheques.Focus();
                    }
                    else
                    {
                        txtEnTarjeta.SelectAll();
                        txtEnTarjeta.Focus();
                    }

                    throw new Exception("No Puede Digitar Valores Negativos");
                }
                if (total > aPagar) throw new Exception("El Desglose de Pago no Puede Superar el Monto a Cobrar");
                else
                {
                    montoDeduda = monto - aPagar;

                    //Mostramos los Datos
                    txtADevolver.Text = aDevolver.ToString("n2");
                    txtACredito.Text = montoDeduda.ToString("N2");                   
                    btnAceptar.Enabled = (total == aPagar);
                    
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LOK = false;
            metodoImp = -1;
            Close();
        }
    }
}
