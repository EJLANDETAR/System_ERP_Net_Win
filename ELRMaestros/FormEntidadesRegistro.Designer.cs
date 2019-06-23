namespace ELRMaestros
{
    partial class FormEntidadesRegistro
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
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombres = new WinControl_ELR_NET.ELRTextBox();
            this.cboTipoEntidad = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elrTextBox3 = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elrTextBox4 = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.elrCombobox1 = new WinControl_ELR_NET.ELRCombobox();
            this.label6 = new System.Windows.Forms.Label();
            this.elrTextBox5 = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.elrTextBox6 = new WinControl_ELR_NET.ELRTextBox();
            this.elrTextBox7 = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.elrTextBox8 = new WinControl_ELR_NET.ELRTextBox();
            this.elrCombobox6 = new WinControl_ELR_NET.ELRCombobox();
            this.label13 = new System.Windows.Forms.Label();
            this.elrTextBox9 = new WinControl_ELR_NET.ELRTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSector = new System.Windows.Forms.Button();
            this.cboSectores = new WinControl_ELR_NET.ELRCombobox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMunicipio = new WinControl_ELR_NET.ELRCombobox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboProvincia = new WinControl_ELR_NET.ELRCombobox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPais = new WinControl_ELR_NET.ELRCombobox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFormaPago = new WinControl_ELR_NET.ELRCombobox();
            this.chkCreditoDisponible = new WinControl_ELR_NET.ELRCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elrCheckBox5 = new WinControl_ELR_NET.ELRCheckBox();
            this.chkActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.elrCombobox2 = new WinControl_ELR_NET.ELRCombobox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new WinControl_ELR_NET.ELRDatePicker();
            this.btnBuscarProvincia = new System.Windows.Forms.Button();
            this.btnBuscarMunicipio = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 611);
            this.pnBotones.Margin = new System.Windows.Forms.Padding(5);
            this.pnBotones.Size = new System.Drawing.Size(862, 42);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(623, 0);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrabar.Size = new System.Drawing.Size(140, 38);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(763, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Size = new System.Drawing.Size(95, 38);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 38);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(528, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 38);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(433, 38);
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "CedulaRNC";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = this.DSDatos;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(443, 13);
            this.txtCedulaRNC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(174, 29);
            this.txtCedulaRNC.TabIndex = 3;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // txtNombres
            // 
            this.txtNombres.AMostrar = null;
            this.txtNombres.AValidar = null;
            this.txtNombres.CampoBusquedaID = "";
            this.txtNombres.CampoData = "Nombres";
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.ColumnasBusqGeneral = null;
            this.txtNombres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombres.Decimales = 0;
            this.txtNombres.DSData = this.DSDatos;
            this.txtNombres.EsAutoGenerado = false;
            this.txtNombres.EsBusqueda = false;
            this.txtNombres.EsBusquedaAutoIncremental = false;
            this.txtNombres.EsEditable = true;
            this.txtNombres.FiltroBusqueda = "";
            this.txtNombres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombres.Location = new System.Drawing.Point(127, 50);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.NombreTabla = "";
            this.txtNombres.SepDecimal = '\0';
            this.txtNombres.Size = new System.Drawing.Size(490, 29);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TablaOVistaBusqueda = "";
            this.txtNombres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombres.ValorPorDefecto = "";
            // 
            // cboTipoEntidad
            // 
            this.cboTipoEntidad.AValidar = null;
            this.cboTipoEntidad.CampoData = "Tipo_Entidad";
            this.cboTipoEntidad.CampoJoinCombobox2 = "";
            this.cboTipoEntidad.ComboboxAFiltrar = null;
            this.cboTipoEntidad.DisplayMember = "Descripcion";
            this.cboTipoEntidad.DSData = this.DSDatos;
            this.cboTipoEntidad.EsEditable = true;
            this.cboTipoEntidad.FiltroBusqueda = "Nombre_Tabla = \'TIPO_ENTIDAD\' and EsActivo = 1";
            this.cboTipoEntidad.FormattingEnabled = true;
            this.cboTipoEntidad.Location = new System.Drawing.Point(127, 12);
            this.cboTipoEntidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipoEntidad.Name = "cboTipoEntidad";
            this.cboTipoEntidad.NombreTabla = "";
            this.cboTipoEntidad.Size = new System.Drawing.Size(204, 29);
            this.cboTipoEntidad.SSQL = "";
            this.cboTipoEntidad.TabIndex = 32;
            this.cboTipoEntidad.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboTipoEntidad.UsaDataGlobal = false;
            this.cboTipoEntidad.ValorPorDefecto = "1";
            this.cboTipoEntidad.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula RNC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // elrTextBox3
            // 
            this.elrTextBox3.AMostrar = null;
            this.elrTextBox3.AValidar = null;
            this.elrTextBox3.CampoBusquedaID = "";
            this.elrTextBox3.CampoData = "Apellidos";
            this.elrTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox3.ColumnasBusqGeneral = null;
            this.elrTextBox3.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox3.Decimales = 0;
            this.elrTextBox3.DSData = this.DSDatos;
            this.elrTextBox3.EsAutoGenerado = false;
            this.elrTextBox3.EsBusqueda = false;
            this.elrTextBox3.EsBusquedaAutoIncremental = false;
            this.elrTextBox3.EsEditable = true;
            this.elrTextBox3.FiltroBusqueda = "";
            this.elrTextBox3.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox3.Location = new System.Drawing.Point(127, 88);
            this.elrTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox3.Name = "elrTextBox3";
            this.elrTextBox3.NombreTabla = "";
            this.elrTextBox3.SepDecimal = '\0';
            this.elrTextBox3.Size = new System.Drawing.Size(204, 29);
            this.elrTextBox3.TabIndex = 6;
            this.elrTextBox3.TablaOVistaBusqueda = "";
            this.elrTextBox3.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox3.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox3.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apodos";
            // 
            // elrTextBox4
            // 
            this.elrTextBox4.AMostrar = null;
            this.elrTextBox4.AValidar = null;
            this.elrTextBox4.CampoBusquedaID = "";
            this.elrTextBox4.CampoData = "Apodos";
            this.elrTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox4.ColumnasBusqGeneral = null;
            this.elrTextBox4.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox4.Decimales = 0;
            this.elrTextBox4.DSData = this.DSDatos;
            this.elrTextBox4.EsAutoGenerado = false;
            this.elrTextBox4.EsBusqueda = false;
            this.elrTextBox4.EsBusquedaAutoIncremental = false;
            this.elrTextBox4.EsEditable = true;
            this.elrTextBox4.FiltroBusqueda = "";
            this.elrTextBox4.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox4.Location = new System.Drawing.Point(412, 90);
            this.elrTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox4.Name = "elrTextBox4";
            this.elrTextBox4.NombreTabla = "";
            this.elrTextBox4.SepDecimal = '\0';
            this.elrTextBox4.Size = new System.Drawing.Size(205, 29);
            this.elrTextBox4.TabIndex = 8;
            this.elrTextBox4.TablaOVistaBusqueda = "";
            this.elrTextBox4.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox4.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox4.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo";
            // 
            // elrCombobox1
            // 
            this.elrCombobox1.AValidar = null;
            this.elrCombobox1.CampoData = "Sexo";
            this.elrCombobox1.CampoJoinCombobox2 = "";
            this.elrCombobox1.ComboboxAFiltrar = null;
            this.elrCombobox1.DisplayMember = "Descripcion";
            this.elrCombobox1.DSData = this.DSDatos;
            this.elrCombobox1.EsEditable = true;
            this.elrCombobox1.FiltroBusqueda = "Nombre_Tabla = \'Sexo\'";
            this.elrCombobox1.FormattingEnabled = true;
            this.elrCombobox1.Location = new System.Drawing.Point(127, 124);
            this.elrCombobox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrCombobox1.Name = "elrCombobox1";
            this.elrCombobox1.NombreTabla = "";
            this.elrCombobox1.Size = new System.Drawing.Size(204, 29);
            this.elrCombobox1.SSQL = "";
            this.elrCombobox1.TabIndex = 10;
            this.elrCombobox1.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.elrCombobox1.UsaDataGlobal = false;
            this.elrCombobox1.ValorPorDefecto = "M";
            this.elrCombobox1.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // elrTextBox5
            // 
            this.elrTextBox5.AMostrar = null;
            this.elrTextBox5.AValidar = null;
            this.elrTextBox5.CampoBusquedaID = "";
            this.elrTextBox5.CampoData = "Direccion";
            this.elrTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox5.ColumnasBusqGeneral = null;
            this.elrTextBox5.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox5.Decimales = 0;
            this.elrTextBox5.DSData = this.DSDatos;
            this.elrTextBox5.EsAutoGenerado = false;
            this.elrTextBox5.EsBusqueda = false;
            this.elrTextBox5.EsBusquedaAutoIncremental = false;
            this.elrTextBox5.EsEditable = true;
            this.elrTextBox5.FiltroBusqueda = "";
            this.elrTextBox5.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox5.Location = new System.Drawing.Point(127, 163);
            this.elrTextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox5.Multiline = true;
            this.elrTextBox5.Name = "elrTextBox5";
            this.elrTextBox5.NombreTabla = "";
            this.elrTextBox5.SepDecimal = '\0';
            this.elrTextBox5.Size = new System.Drawing.Size(490, 51);
            this.elrTextBox5.TabIndex = 12;
            this.elrTextBox5.TablaOVistaBusqueda = "";
            this.elrTextBox5.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox5.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox5.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefonos";
            // 
            // elrTextBox6
            // 
            this.elrTextBox6.AMostrar = null;
            this.elrTextBox6.AValidar = null;
            this.elrTextBox6.CampoBusquedaID = "";
            this.elrTextBox6.CampoData = "Telefono1";
            this.elrTextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox6.ColumnasBusqGeneral = null;
            this.elrTextBox6.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox6.Decimales = 0;
            this.elrTextBox6.DSData = this.DSDatos;
            this.elrTextBox6.EsAutoGenerado = false;
            this.elrTextBox6.EsBusqueda = false;
            this.elrTextBox6.EsBusquedaAutoIncremental = false;
            this.elrTextBox6.EsEditable = true;
            this.elrTextBox6.FiltroBusqueda = "";
            this.elrTextBox6.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox6.Location = new System.Drawing.Point(127, 222);
            this.elrTextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox6.Name = "elrTextBox6";
            this.elrTextBox6.NombreTabla = "";
            this.elrTextBox6.SepDecimal = '\0';
            this.elrTextBox6.Size = new System.Drawing.Size(184, 29);
            this.elrTextBox6.TabIndex = 14;
            this.elrTextBox6.TablaOVistaBusqueda = "";
            this.elrTextBox6.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox6.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox6.ValorPorDefecto = "";
            // 
            // elrTextBox7
            // 
            this.elrTextBox7.AMostrar = null;
            this.elrTextBox7.AValidar = null;
            this.elrTextBox7.CampoBusquedaID = "";
            this.elrTextBox7.CampoData = "Telefono2";
            this.elrTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox7.ColumnasBusqGeneral = null;
            this.elrTextBox7.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox7.Decimales = 0;
            this.elrTextBox7.DSData = this.DSDatos;
            this.elrTextBox7.EsAutoGenerado = false;
            this.elrTextBox7.EsBusqueda = false;
            this.elrTextBox7.EsBusquedaAutoIncremental = false;
            this.elrTextBox7.EsEditable = true;
            this.elrTextBox7.FiltroBusqueda = "";
            this.elrTextBox7.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox7.Location = new System.Drawing.Point(317, 222);
            this.elrTextBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox7.Name = "elrTextBox7";
            this.elrTextBox7.NombreTabla = "";
            this.elrTextBox7.SepDecimal = '\0';
            this.elrTextBox7.Size = new System.Drawing.Size(299, 29);
            this.elrTextBox7.TabIndex = 15;
            this.elrTextBox7.TablaOVistaBusqueda = "";
            this.elrTextBox7.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox7.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox7.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email";
            // 
            // elrTextBox8
            // 
            this.elrTextBox8.AMostrar = null;
            this.elrTextBox8.AValidar = null;
            this.elrTextBox8.CampoBusquedaID = "";
            this.elrTextBox8.CampoData = "EMail";
            this.elrTextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox8.ColumnasBusqGeneral = null;
            this.elrTextBox8.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox8.Decimales = 0;
            this.elrTextBox8.DSData = this.DSDatos;
            this.elrTextBox8.EsAutoGenerado = false;
            this.elrTextBox8.EsBusqueda = false;
            this.elrTextBox8.EsBusquedaAutoIncremental = false;
            this.elrTextBox8.EsEditable = true;
            this.elrTextBox8.FiltroBusqueda = "";
            this.elrTextBox8.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox8.Location = new System.Drawing.Point(127, 259);
            this.elrTextBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox8.Name = "elrTextBox8";
            this.elrTextBox8.NombreTabla = "";
            this.elrTextBox8.SepDecimal = '\0';
            this.elrTextBox8.Size = new System.Drawing.Size(490, 29);
            this.elrTextBox8.TabIndex = 17;
            this.elrTextBox8.TablaOVistaBusqueda = "";
            this.elrTextBox8.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox8.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox8.ValorPorDefecto = "";
            // 
            // elrCombobox6
            // 
            this.elrCombobox6.AValidar = null;
            this.elrCombobox6.CampoData = "Tipo_NCF";
            this.elrCombobox6.CampoJoinCombobox2 = "";
            this.elrCombobox6.ComboboxAFiltrar = null;
            this.elrCombobox6.DisplayMember = "Descripcion";
            this.elrCombobox6.DSData = this.DSDatos;
            this.elrCombobox6.EsEditable = true;
            this.elrCombobox6.FiltroBusqueda = "(EsCompra = 1 Or EsVenta = 1 Or Tipo_NCF = 0)";
            this.elrCombobox6.FormattingEnabled = true;
            this.elrCombobox6.Location = new System.Drawing.Point(127, 293);
            this.elrCombobox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrCombobox6.Name = "elrCombobox6";
            this.elrCombobox6.NombreTabla = "";
            this.elrCombobox6.Size = new System.Drawing.Size(490, 29);
            this.elrCombobox6.SSQL = "";
            this.elrCombobox6.TabIndex = 28;
            this.elrCombobox6.TablaOVistaConsulta = " TSISTEMA_TIPOS_NCF";
            this.elrCombobox6.UsaDataGlobal = false;
            this.elrCombobox6.ValorPorDefecto = "0";
            this.elrCombobox6.ValueMember = "Tipo_NCF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tipo NCF";
            // 
            // elrTextBox9
            // 
            this.elrTextBox9.AMostrar = null;
            this.elrTextBox9.AValidar = null;
            this.elrTextBox9.CampoBusquedaID = "";
            this.elrTextBox9.CampoData = "Ocupacion";
            this.elrTextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox9.ColumnasBusqGeneral = null;
            this.elrTextBox9.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox9.Decimales = 0;
            this.elrTextBox9.DSData = this.DSDatos;
            this.elrTextBox9.EsAutoGenerado = false;
            this.elrTextBox9.EsBusqueda = false;
            this.elrTextBox9.EsBusquedaAutoIncremental = false;
            this.elrTextBox9.EsEditable = true;
            this.elrTextBox9.FiltroBusqueda = "";
            this.elrTextBox9.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox9.Location = new System.Drawing.Point(126, 330);
            this.elrTextBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrTextBox9.Name = "elrTextBox9";
            this.elrTextBox9.NombreTabla = "";
            this.elrTextBox9.SepDecimal = '\0';
            this.elrTextBox9.Size = new System.Drawing.Size(490, 29);
            this.elrTextBox9.TabIndex = 30;
            this.elrTextBox9.TablaOVistaBusqueda = "";
            this.elrTextBox9.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox9.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox9.ValorPorDefecto = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ocupacion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tipo Entidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarMunicipio);
            this.groupBox2.Controls.Add(this.btnBuscarProvincia);
            this.groupBox2.Controls.Add(this.btnBuscarSector);
            this.groupBox2.Controls.Add(this.cboSectores);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboMunicipio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboProvincia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboPais);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 406);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(595, 203);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zonificacion";
            // 
            // btnBuscarSector
            // 
            this.btnBuscarSector.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarSector.Location = new System.Drawing.Point(526, 157);
            this.btnBuscarSector.Name = "btnBuscarSector";
            this.btnBuscarSector.Size = new System.Drawing.Size(57, 31);
            this.btnBuscarSector.TabIndex = 41;
            this.btnBuscarSector.UseVisualStyleBackColor = true;
            this.btnBuscarSector.Click += new System.EventHandler(this.btnGaranteEmpresaSector_Click);
            // 
            // cboSectores
            // 
            this.cboSectores.AValidar = null;
            this.cboSectores.CampoData = "Sector_Id";
            this.cboSectores.CampoJoinCombobox2 = "";
            this.cboSectores.ComboboxAFiltrar = null;
            this.cboSectores.DisplayMember = "Nombre";
            this.cboSectores.DSData = this.DSDatos;
            this.cboSectores.EsEditable = true;
            this.cboSectores.FiltroBusqueda = "EsActivo = 1";
            this.cboSectores.FormattingEnabled = true;
            this.cboSectores.Location = new System.Drawing.Point(110, 159);
            this.cboSectores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSectores.Name = "cboSectores";
            this.cboSectores.NombreTabla = "";
            this.cboSectores.Size = new System.Drawing.Size(410, 29);
            this.cboSectores.SSQL = "";
            this.cboSectores.TabIndex = 34;
            this.cboSectores.TablaOVistaConsulta = "TZONAS_SECTORES";
            this.cboSectores.UsaDataGlobal = false;
            this.cboSectores.ValorPorDefecto = "0";
            this.cboSectores.ValueMember = "Sector_Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Sector";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.AValidar = null;
            this.cboMunicipio.CampoData = "Municipio_Id";
            this.cboMunicipio.CampoJoinCombobox2 = "Municipio_Id";
            this.cboMunicipio.ComboboxAFiltrar = this.cboSectores;
            this.cboMunicipio.DisplayMember = "Nombre";
            this.cboMunicipio.DSData = this.DSDatos;
            this.cboMunicipio.EsEditable = true;
            this.cboMunicipio.FiltroBusqueda = "";
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(110, 119);
            this.cboMunicipio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.NombreTabla = "";
            this.cboMunicipio.Size = new System.Drawing.Size(410, 29);
            this.cboMunicipio.SSQL = "";
            this.cboMunicipio.TabIndex = 32;
            this.cboMunicipio.TablaOVistaConsulta = "TZONAS_MUNICIPIOS";
            this.cboMunicipio.UsaDataGlobal = false;
            this.cboMunicipio.ValorPorDefecto = "0";
            this.cboMunicipio.ValueMember = "Municipio_Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Municipio";
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
            this.cboProvincia.FiltroBusqueda = "";
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(110, 80);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.NombreTabla = "";
            this.cboProvincia.Size = new System.Drawing.Size(410, 29);
            this.cboProvincia.SSQL = "";
            this.cboProvincia.TabIndex = 30;
            this.cboProvincia.TablaOVistaConsulta = " TZONAS_PROVINCIAS";
            this.cboProvincia.UsaDataGlobal = false;
            this.cboProvincia.ValorPorDefecto = "0";
            this.cboProvincia.ValueMember = "Provincia_Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Provincia";
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
            this.cboPais.FiltroBusqueda = "";
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(110, 40);
            this.cboPais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPais.Name = "cboPais";
            this.cboPais.NombreTabla = "";
            this.cboPais.Size = new System.Drawing.Size(473, 29);
            this.cboPais.SSQL = "";
            this.cboPais.TabIndex = 28;
            this.cboPais.TablaOVistaConsulta = " TZONAS_PAISES";
            this.cboPais.UsaDataGlobal = false;
            this.cboPais.ValorPorDefecto = "1";
            this.cboPais.ValueMember = "Pais_Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Pais:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboFormaPago);
            this.panel1.Controls.Add(this.chkCreditoDisponible);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.elrCheckBox5);
            this.panel1.Controls.Add(this.chkActivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(623, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 611);
            this.panel1.TabIndex = 34;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFormaPago.AValidar = null;
            this.cboFormaPago.CampoData = "Dias_Credito";
            this.cboFormaPago.CampoJoinCombobox2 = "";
            this.cboFormaPago.ComboboxAFiltrar = null;
            this.cboFormaPago.DisplayMember = "Descripcion";
            this.cboFormaPago.DSData = this.DSDatos;
            this.cboFormaPago.EsEditable = true;
            this.cboFormaPago.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'CONDICION_FACTURA\'";
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(13, 341);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.NombreTabla = "";
            this.cboFormaPago.Size = new System.Drawing.Size(219, 29);
            this.cboFormaPago.SSQL = "";
            this.cboFormaPago.TabIndex = 15;
            this.cboFormaPago.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboFormaPago.UsaDataGlobal = false;
            this.cboFormaPago.ValorPorDefecto = "0";
            this.cboFormaPago.ValueMember = "Id";
            // 
            // chkCreditoDisponible
            // 
            this.chkCreditoDisponible.AutoSize = true;
            this.chkCreditoDisponible.CampoData = "EsCreditoDisponible";
            this.chkCreditoDisponible.DSData = this.DSDatos;
            this.chkCreditoDisponible.EsEditable = true;
            this.chkCreditoDisponible.EsModificable = true;
            this.chkCreditoDisponible.FiltroBusqueda = "";
            this.chkCreditoDisponible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreditoDisponible.Location = new System.Drawing.Point(13, 309);
            this.chkCreditoDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCreditoDisponible.Name = "chkCreditoDisponible";
            this.chkCreditoDisponible.NombreTabla = "";
            this.chkCreditoDisponible.Size = new System.Drawing.Size(172, 25);
            this.chkCreditoDisponible.TabIndex = 13;
            this.chkCreditoDisponible.Text = "Credito Disponible";
            this.chkCreditoDisponible.UseVisualStyleBackColor = true;
            this.chkCreditoDisponible.ValorPorDefecto = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ELRMaestros.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // elrCheckBox5
            // 
            this.elrCheckBox5.AutoSize = true;
            this.elrCheckBox5.CampoData = "EsSuplidor";
            this.elrCheckBox5.DSData = this.DSDatos;
            this.elrCheckBox5.EsEditable = true;
            this.elrCheckBox5.EsModificable = true;
            this.elrCheckBox5.FiltroBusqueda = "";
            this.elrCheckBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrCheckBox5.Location = new System.Drawing.Point(13, 276);
            this.elrCheckBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrCheckBox5.Name = "elrCheckBox5";
            this.elrCheckBox5.NombreTabla = "";
            this.elrCheckBox5.Size = new System.Drawing.Size(114, 25);
            this.elrCheckBox5.TabIndex = 10;
            this.elrCheckBox5.Text = "Es Suplidor";
            this.elrCheckBox5.UseVisualStyleBackColor = true;
            this.elrCheckBox5.ValorPorDefecto = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CampoData = "EsActivo";
            this.chkActivo.DSData = this.DSDatos;
            this.chkActivo.EsEditable = true;
            this.chkActivo.EsModificable = true;
            this.chkActivo.FiltroBusqueda = "";
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(13, 243);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.NombreTabla = "";
            this.chkActivo.Size = new System.Drawing.Size(98, 25);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Es Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.ValorPorDefecto = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "Nivel Precio";
            // 
            // elrCombobox2
            // 
            this.elrCombobox2.AValidar = null;
            this.elrCombobox2.CampoData = "Nivel_Precio";
            this.elrCombobox2.CampoJoinCombobox2 = "";
            this.elrCombobox2.ComboboxAFiltrar = null;
            this.elrCombobox2.DisplayMember = "Descripcion";
            this.elrCombobox2.DSData = this.DSDatos;
            this.elrCombobox2.EsEditable = true;
            this.elrCombobox2.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'NIVEL_PRECIO\'";
            this.elrCombobox2.FormattingEnabled = true;
            this.elrCombobox2.Location = new System.Drawing.Point(127, 367);
            this.elrCombobox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elrCombobox2.Name = "elrCombobox2";
            this.elrCombobox2.NombreTabla = "";
            this.elrCombobox2.Size = new System.Drawing.Size(490, 29);
            this.elrCombobox2.SSQL = "";
            this.elrCombobox2.TabIndex = 36;
            this.elrCombobox2.TablaOVistaConsulta = " TSISTEMA_TABLA_AUXILIAR";
            this.elrCombobox2.UsaDataGlobal = true;
            this.elrCombobox2.ValorPorDefecto = "0";
            this.elrCombobox2.ValueMember = "Id";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(343, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 21);
            this.label17.TabIndex = 37;
            this.label17.Text = "Fe. Nac.";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.AValidar = null;
            this.dtpFechaNacimiento.CampoData = "Fecha_Nacimiento";
            this.dtpFechaNacimiento.DSData = this.DSDatos;
            this.dtpFechaNacimiento.EsEditable = true;
            this.dtpFechaNacimiento.FiltroBusqueda = "";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(412, 124);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.NombreTabla = "";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(204, 29);
            this.dtpFechaNacimiento.TabIndex = 38;
            this.dtpFechaNacimiento.ValorPorDefecto = new System.DateTime(2017, 1, 24, 0, 0, 0, 0);
            // 
            // btnBuscarProvincia
            // 
            this.btnBuscarProvincia.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarProvincia.Location = new System.Drawing.Point(526, 80);
            this.btnBuscarProvincia.Name = "btnBuscarProvincia";
            this.btnBuscarProvincia.Size = new System.Drawing.Size(57, 31);
            this.btnBuscarProvincia.TabIndex = 42;
            this.btnBuscarProvincia.UseVisualStyleBackColor = true;
            this.btnBuscarProvincia.Click += new System.EventHandler(this.btnBuscarProvincia_Click);
            // 
            // btnBuscarMunicipio
            // 
            this.btnBuscarMunicipio.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarMunicipio.Location = new System.Drawing.Point(526, 119);
            this.btnBuscarMunicipio.Name = "btnBuscarMunicipio";
            this.btnBuscarMunicipio.Size = new System.Drawing.Size(57, 31);
            this.btnBuscarMunicipio.TabIndex = 43;
            this.btnBuscarMunicipio.UseVisualStyleBackColor = true;
            this.btnBuscarMunicipio.Click += new System.EventHandler(this.btnBuscarMunicipio_Click);
            // 
            // FormEntidadesRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCedulaRNC;
            valida1.Mensaje = "Debe Indicar Numero de Cedula o RNC";
            valida1.NombreCampo = "CedulaRNC";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombres;
            valida2.Mensaje = "Debe Indicar el Nombre";
            valida2.NombreCampo = "Nombres";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.cboTipoEntidad;
            valida3.Mensaje = "Debe Indicar Tipo de Entidad";
            valida3.NombreCampo = "Tipo_Entidad";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(862, 653);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.elrCombobox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboTipoEntidad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.elrTextBox9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.elrCombobox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.elrTextBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.elrTextBox7);
            this.Controls.Add(this.elrTextBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.elrTextBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.elrCombobox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.elrTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.elrTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCedulaRNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FormEntidadesRegistro";
            this.NombreCampoID = "Entidad_Id";
            this.TablaEncabezado = " TCLASIFICADOR_ENTIDADES";
            this.Text = "REGISTRO DE ENTIDADES";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCedulaRNC, 0);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.elrTextBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.elrTextBox4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.elrCombobox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.elrTextBox5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.elrTextBox6, 0);
            this.Controls.SetChildIndex(this.elrTextBox7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.elrTextBox8, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.elrCombobox6, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.elrTextBox9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.cboTipoEntidad, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.elrCombobox2, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.dtpFechaNacimiento, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private WinControl_ELR_NET.ELRTextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox elrTextBox3;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox elrTextBox4;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRCombobox elrCombobox1;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox elrTextBox5;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox elrTextBox6;
        private WinControl_ELR_NET.ELRTextBox elrTextBox7;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox elrTextBox8;
        private WinControl_ELR_NET.ELRCombobox elrCombobox6;
        private System.Windows.Forms.Label label13;
        private WinControl_ELR_NET.ELRTextBox elrTextBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private WinControl_ELR_NET.ELRCombobox cboTipoEntidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRCombobox cboSectores;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRCombobox cboMunicipio;
        private System.Windows.Forms.Label label11;
        private WinControl_ELR_NET.ELRCombobox cboProvincia;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRCombobox cboPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox5;
        private WinControl_ELR_NET.ELRCheckBox chkActivo;
        private System.Windows.Forms.Label label16;
        private WinControl_ELR_NET.ELRCombobox elrCombobox2;
        private WinControl_ELR_NET.ELRCheckBox chkCreditoDisponible;
        private WinControl_ELR_NET.ELRCombobox cboFormaPago;
        private System.Windows.Forms.Label label17;
        private WinControl_ELR_NET.ELRDatePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnBuscarSector;
        private System.Windows.Forms.Button btnBuscarProvincia;
        private System.Windows.Forms.Button btnBuscarMunicipio;
    }
}