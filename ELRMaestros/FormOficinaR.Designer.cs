namespace ELRMaestros
{
    partial class FormOficinaR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtDreccion = new WinControl_ELR_NET.ELRTextBox();
            this.txtTelefono1 = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProvincia = new WinControl_ELR_NET.ELRCombobox();
            this.cboMunicipio = new WinControl_ELR_NET.ELRCombobox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEMail = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoGerente = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreGerente = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboOficinaRaiz = new WinControl_ELR_NET.ELRCombobox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboPais = new WinControl_ELR_NET.ELRCombobox();
            this.label13 = new System.Windows.Forms.Label();
            this.elrDatePicker1 = new WinControl_ELR_NET.ELRDatePicker();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 520);
            this.pnBotones.Size = new System.Drawing.Size(720, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(526, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(621, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(431, 0);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Oficina_Id";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsEditable = false;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(126, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(100, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(126, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(582, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // txtDreccion
            // 
            this.txtDreccion.AMostrar = null;
            this.txtDreccion.AValidar = null;
            this.txtDreccion.CampoBusquedaID = "";
            this.txtDreccion.CampoData = "Direccion";
            this.txtDreccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDreccion.ColumnasBusqGeneral = null;
            this.txtDreccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDreccion.Decimales = 0;
            this.txtDreccion.DSData = this.DSDatos;
            this.txtDreccion.EsAutoGenerado = false;
            this.txtDreccion.EsBusqueda = false;
            this.txtDreccion.EsEditable = true;
            this.txtDreccion.FiltroBusqueda = "";
            this.txtDreccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDreccion.Location = new System.Drawing.Point(126, 94);
            this.txtDreccion.Multiline = true;
            this.txtDreccion.Name = "txtDreccion";
            this.txtDreccion.NombreTabla = "";
            this.txtDreccion.SepDecimal = '\0';
            this.txtDreccion.Size = new System.Drawing.Size(582, 63);
            this.txtDreccion.TabIndex = 6;
            this.txtDreccion.TablaOVistaBusqueda = "";
            this.txtDreccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDreccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDreccion.ValorPorDefecto = "";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.AMostrar = null;
            this.txtTelefono1.AValidar = null;
            this.txtTelefono1.CampoBusquedaID = "";
            this.txtTelefono1.CampoData = "Telefono1";
            this.txtTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono1.ColumnasBusqGeneral = null;
            this.txtTelefono1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono1.Decimales = 0;
            this.txtTelefono1.DSData = this.DSDatos;
            this.txtTelefono1.EsAutoGenerado = false;
            this.txtTelefono1.EsBusqueda = false;
            this.txtTelefono1.EsEditable = true;
            this.txtTelefono1.FiltroBusqueda = "";
            this.txtTelefono1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono1.Location = new System.Drawing.Point(126, 163);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.NombreTabla = "";
            this.txtTelefono1.SepDecimal = '\0';
            this.txtTelefono1.Size = new System.Drawing.Size(213, 29);
            this.txtTelefono1.TabIndex = 8;
            this.txtTelefono1.TablaOVistaBusqueda = "";
            this.txtTelefono1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono1.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono #1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono #2";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.AMostrar = null;
            this.txtTelefono2.AValidar = null;
            this.txtTelefono2.CampoBusquedaID = "";
            this.txtTelefono2.CampoData = "Telefono2";
            this.txtTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono2.ColumnasBusqGeneral = null;
            this.txtTelefono2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono2.Decimales = 0;
            this.txtTelefono2.DSData = this.DSDatos;
            this.txtTelefono2.EsAutoGenerado = false;
            this.txtTelefono2.EsBusqueda = false;
            this.txtTelefono2.EsEditable = true;
            this.txtTelefono2.FiltroBusqueda = "";
            this.txtTelefono2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono2.Location = new System.Drawing.Point(451, 163);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.NombreTabla = "";
            this.txtTelefono2.SepDecimal = '\0';
            this.txtTelefono2.Size = new System.Drawing.Size(257, 29);
            this.txtTelefono2.TabIndex = 10;
            this.txtTelefono2.TablaOVistaBusqueda = "";
            this.txtTelefono2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono2.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Provincia";
            // 
            // cboProvincia
            // 
            this.cboProvincia.AValidar = null;
            this.cboProvincia.CampoData = "Provincia_Id";
            this.cboProvincia.CampoJoinCombobox2 = "Provincia_Id";
            this.cboProvincia.ComboboxAFiltrar = this.cboMunicipio;
            this.cboProvincia.DisplayMember = "Nombre";
            this.cboProvincia.DSData = this.DSDatos;
            this.cboProvincia.EsEditable = true;
            this.cboProvincia.FiltroBusqueda = "EsActivo = 1";
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(126, 236);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.NombreTabla = "";
            this.cboProvincia.Size = new System.Drawing.Size(582, 29);
            this.cboProvincia.SSQL = "";
            this.cboProvincia.TabIndex = 12;
            this.cboProvincia.TablaOVistaConsulta = "TZONAS_PROVINCIAS";
            this.cboProvincia.UsaDataGlobal = false;
            this.cboProvincia.ValorPorDefecto = "1";
            this.cboProvincia.ValueMember = "Provincia_Id";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.AValidar = null;
            this.cboMunicipio.CampoData = "Municipio_Id";
            this.cboMunicipio.CampoJoinCombobox2 = "";
            this.cboMunicipio.ComboboxAFiltrar = null;
            this.cboMunicipio.DisplayMember = "Nombre";
            this.cboMunicipio.DSData = this.DSDatos;
            this.cboMunicipio.EsEditable = true;
            this.cboMunicipio.FiltroBusqueda = "EsActivo = 1";
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(126, 271);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.NombreTabla = "";
            this.cboMunicipio.Size = new System.Drawing.Size(582, 29);
            this.cboMunicipio.SSQL = "";
            this.cboMunicipio.TabIndex = 14;
            this.cboMunicipio.TablaOVistaConsulta = "TZONAS_MUNICIPIOS";
            this.cboMunicipio.UsaDataGlobal = false;
            this.cboMunicipio.ValorPorDefecto = "1";
            this.cboMunicipio.ValueMember = "Municipio_Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Municipio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "EMail";
            // 
            // txtEMail
            // 
            this.txtEMail.AMostrar = null;
            this.txtEMail.AValidar = null;
            this.txtEMail.CampoBusquedaID = "";
            this.txtEMail.CampoData = "EMail";
            this.txtEMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEMail.ColumnasBusqGeneral = null;
            this.txtEMail.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEMail.Decimales = 0;
            this.txtEMail.DSData = this.DSDatos;
            this.txtEMail.EsAutoGenerado = false;
            this.txtEMail.EsBusqueda = false;
            this.txtEMail.EsEditable = true;
            this.txtEMail.FiltroBusqueda = "";
            this.txtEMail.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEMail.Location = new System.Drawing.Point(126, 306);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.NombreTabla = "";
            this.txtEMail.SepDecimal = '\0';
            this.txtEMail.Size = new System.Drawing.Size(582, 29);
            this.txtEMail.TabIndex = 16;
            this.txtEMail.TablaOVistaBusqueda = "";
            this.txtEMail.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEMail.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEMail.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefonoGerente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNombreGerente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 123);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Gerente";
            // 
            // txtTelefonoGerente
            // 
            this.txtTelefonoGerente.AMostrar = null;
            this.txtTelefonoGerente.AValidar = null;
            this.txtTelefonoGerente.CampoBusquedaID = "";
            this.txtTelefonoGerente.CampoData = "Telefonos_Gerente";
            this.txtTelefonoGerente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefonoGerente.ColumnasBusqGeneral = null;
            this.txtTelefonoGerente.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefonoGerente.Decimales = 0;
            this.txtTelefonoGerente.DSData = this.DSDatos;
            this.txtTelefonoGerente.EsAutoGenerado = false;
            this.txtTelefonoGerente.EsBusqueda = false;
            this.txtTelefonoGerente.EsEditable = true;
            this.txtTelefonoGerente.FiltroBusqueda = "";
            this.txtTelefonoGerente.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefonoGerente.Location = new System.Drawing.Point(174, 79);
            this.txtTelefonoGerente.Name = "txtTelefonoGerente";
            this.txtTelefonoGerente.NombreTabla = "";
            this.txtTelefonoGerente.SepDecimal = '\0';
            this.txtTelefonoGerente.Size = new System.Drawing.Size(472, 29);
            this.txtTelefonoGerente.TabIndex = 20;
            this.txtTelefonoGerente.TablaOVistaBusqueda = "";
            this.txtTelefonoGerente.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefonoGerente.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefonoGerente.ValorPorDefecto = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefonos";
            // 
            // txtNombreGerente
            // 
            this.txtNombreGerente.AMostrar = null;
            this.txtNombreGerente.AValidar = null;
            this.txtNombreGerente.CampoBusquedaID = "";
            this.txtNombreGerente.CampoData = "Gerente";
            this.txtNombreGerente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreGerente.ColumnasBusqGeneral = null;
            this.txtNombreGerente.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreGerente.Decimales = 0;
            this.txtNombreGerente.DSData = this.DSDatos;
            this.txtNombreGerente.EsAutoGenerado = false;
            this.txtNombreGerente.EsBusqueda = false;
            this.txtNombreGerente.EsEditable = true;
            this.txtNombreGerente.FiltroBusqueda = "";
            this.txtNombreGerente.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreGerente.Location = new System.Drawing.Point(174, 42);
            this.txtNombreGerente.Name = "txtNombreGerente";
            this.txtNombreGerente.NombreTabla = "";
            this.txtNombreGerente.SepDecimal = '\0';
            this.txtNombreGerente.Size = new System.Drawing.Size(472, 29);
            this.txtNombreGerente.TabIndex = 18;
            this.txtNombreGerente.TablaOVistaBusqueda = "";
            this.txtNombreGerente.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreGerente.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreGerente.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre Gerente";
            // 
            // cboOficinaRaiz
            // 
            this.cboOficinaRaiz.AValidar = null;
            this.cboOficinaRaiz.CampoData = "Oficina_Madre_Id";
            this.cboOficinaRaiz.CampoJoinCombobox2 = "";
            this.cboOficinaRaiz.ComboboxAFiltrar = null;
            this.cboOficinaRaiz.DisplayMember = "Nombre";
            this.cboOficinaRaiz.DSData = this.DSDatos;
            this.cboOficinaRaiz.EsEditable = true;
            this.cboOficinaRaiz.FiltroBusqueda = "";
            this.cboOficinaRaiz.FormattingEnabled = true;
            this.cboOficinaRaiz.Location = new System.Drawing.Point(380, 24);
            this.cboOficinaRaiz.Name = "cboOficinaRaiz";
            this.cboOficinaRaiz.NombreTabla = "";
            this.cboOficinaRaiz.Size = new System.Drawing.Size(328, 29);
            this.cboOficinaRaiz.SSQL = "";
            this.cboOficinaRaiz.TabIndex = 18;
            this.cboOficinaRaiz.TablaOVistaConsulta = "TEMPRESAS_OFICINAS";
            this.cboOficinaRaiz.UsaDataGlobal = false;
            this.cboOficinaRaiz.ValorPorDefecto = "0";
            this.cboOficinaRaiz.ValueMember = "Oficina_Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ofina Raiz:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "Pais";
            // 
            // cboPais
            // 
            this.cboPais.AValidar = null;
            this.cboPais.CampoData = "Pais_Id";
            this.cboPais.CampoJoinCombobox2 = "Pais_Id";
            this.cboPais.ComboboxAFiltrar = this.cboProvincia;
            this.cboPais.DisplayMember = "Nombre";
            this.cboPais.DSData = this.DSDatos;
            this.cboPais.EsEditable = true;
            this.cboPais.FiltroBusqueda = "EsActivo = 1";
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(126, 199);
            this.cboPais.Name = "cboPais";
            this.cboPais.NombreTabla = "";
            this.cboPais.Size = new System.Drawing.Size(582, 29);
            this.cboPais.SSQL = "";
            this.cboPais.TabIndex = 21;
            this.cboPais.TablaOVistaConsulta = "TZONAS_PAISES";
            this.cboPais.UsaDataGlobal = false;
            this.cboPais.ValorPorDefecto = "1";
            this.cboPais.ValueMember = "Pais_Id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Hora Cierre";
            // 
            // elrDatePicker1
            // 
            this.elrDatePicker1.AValidar = null;
            this.elrDatePicker1.CampoData = "Hora_Cierre";
            this.elrDatePicker1.DSData = this.DSDatos;
            this.elrDatePicker1.EsEditable = true;
            this.elrDatePicker1.FiltroBusqueda = "";
            this.elrDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.elrDatePicker1.Location = new System.Drawing.Point(126, 342);
            this.elrDatePicker1.Name = "elrDatePicker1";
            this.elrDatePicker1.NombreTabla = "";
            this.elrDatePicker1.ShowUpDown = true;
            this.elrDatePicker1.Size = new System.Drawing.Size(161, 29);
            this.elrDatePicker1.TabIndex = 23;
            this.elrDatePicker1.ValorPorDefecto = new System.DateTime(2016, 4, 3, 0, 0, 0, 0);
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrCheckBox1.Location = new System.Drawing.Point(357, 341);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(98, 25);
            this.elrCheckBox1.TabIndex = 24;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormOficinaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigo;
            valida1.Mensaje = "El Codigo de Oficina debe Ser Mayor a o Igual  a 100";
            valida1.NombreCampo = "Oficina_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "100";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "Debe Digitar el Nombre";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtDreccion;
            valida3.Mensaje = "Debe Digitar la Direccion";
            valida3.NombreCampo = "Direccion";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            valida4.comtrol = this.txtTelefono1;
            valida4.Mensaje = "Debe Digitar Telefono #1";
            valida4.NombreCampo = "Telefono1";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida4.Valor1 = null;
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.CamposAExcluirEnc = "Fecha_Trabajo;Fecha_Contable";
            this.ClientSize = new System.Drawing.Size(720, 563);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.elrDatePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboOficinaRaiz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMunicipio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDreccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormOficinaR";
            this.NombreCampoID = "Oficina_Id";
            this.TablaEncabezado = "TEMPRESAS_OFICINAS";
            this.Text = "REGISTRO DE OFICINA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDreccion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTelefono1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtTelefono2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboProvincia, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cboMunicipio, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtEMail, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cboOficinaRaiz, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.cboPais, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.elrDatePicker1, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtDreccion;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtTelefono1;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtTelefono2;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRCombobox cboProvincia;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRCombobox cboMunicipio;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txtEMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtTelefonoGerente;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRTextBox txtNombreGerente;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRCombobox cboOficinaRaiz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRCombobox cboPais;
        private System.Windows.Forms.Label label13;
        private WinControl_ELR_NET.ELRDatePicker elrDatePicker1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
    }
}