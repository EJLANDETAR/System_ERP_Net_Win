namespace ELRCuentasPorPagar
{
    partial class FormOtrosGastosR
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
            WinControl_ELR_NET.ControlesMostrar controlesMostrar1 = new WinControl_ELR_NET.ControlesMostrar();
            WinControl_ELR_NET.ControlesMostrar controlesMostrar2 = new WinControl_ELR_NET.ControlesMostrar();
            WinControl_ELR_NET.MyColumna myColumna1 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna2 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna3 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtTotal = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.elrTextBox4 = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.elrTextBox5 = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.elrTextBox6 = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 367);
            this.pnBotones.Size = new System.Drawing.Size(712, 61);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(439, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 57);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(580, 0);
            this.btnCancelar.Size = new System.Drawing.Size(128, 57);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 57);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(344, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 57);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(249, 57);
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.autoSenTab = true;
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
            this.txtCedulaRNC.Location = new System.Drawing.Point(510, 34);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(178, 29);
            this.txtCedulaRNC.TabIndex = 10;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.autoSenTab = true;
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
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(113, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(575, 29);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // txtTotal
            // 
            this.txtTotal.AMostrar = null;
            this.txtTotal.autoSenTab = true;
            this.txtTotal.AValidar = null;
            this.txtTotal.CampoBusquedaID = "";
            this.txtTotal.CampoData = "Total";
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.ColumnasBusqGeneral = null;
            this.txtTotal.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotal.Decimales = 0;
            this.txtTotal.DSData = this.DSDatos;
            this.txtTotal.EsAutoGenerado = false;
            this.txtTotal.EsBusqueda = false;
            this.txtTotal.EsBusquedaAutoIncremental = false;
            this.txtTotal.EsEditable = true;
            this.txtTotal.FiltroBusqueda = "";
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTotal.Location = new System.Drawing.Point(510, 174);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.NombreTabla = "";
            this.txtTotal.SepDecimal = '\0';
            this.txtTotal.Size = new System.Drawing.Size(178, 29);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TablaOVistaBusqueda = "";
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotal.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotal.ValorPorDefecto = "0.00";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.autoSenTab = true;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Concepto";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(135, 260);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(553, 101);
            this.txtConcepto.TabIndex = 19;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCedulaRNC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.elrTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Suplidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cedula\\RNC";
            // 
            // elrTextBox1
            // 
            controlesMostrar1.ComboBoxControl = null;
            controlesMostrar1.EsHabilitar = false;
            controlesMostrar1.Formato = "";
            controlesMostrar1.LabelControl = null;
            controlesMostrar1.NombreCampo = "CedulaRNC";
            controlesMostrar1.NumericUpDownControl = null;
            controlesMostrar1.TextBoxControl = this.txtCedulaRNC;
            controlesMostrar1.ValorPorDefecto = "";
            controlesMostrar2.ComboBoxControl = null;
            controlesMostrar2.EsHabilitar = false;
            controlesMostrar2.Formato = "";
            controlesMostrar2.LabelControl = null;
            controlesMostrar2.NombreCampo = "Nombre_Completo";
            controlesMostrar2.NumericUpDownControl = null;
            controlesMostrar2.TextBoxControl = this.txtNombre;
            controlesMostrar2.ValorPorDefecto = "";
            this.elrTextBox1.AMostrar = new WinControl_ELR_NET.ControlesMostrar[] {
        controlesMostrar1,
        controlesMostrar2};
            this.elrTextBox1.autoSenTab = true;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "Entidad_Id";
            this.elrTextBox1.CampoData = "Suplidor_Id";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            myColumna1.Ancho = 100;
            myColumna1.Formato = "";
            myColumna1.HeaderText = "Codigo";
            myColumna1.NombreCampo = "Entidad_Id";
            myColumna2.Ancho = 150;
            myColumna2.Formato = "";
            myColumna2.HeaderText = "CedulaRNC";
            myColumna2.NombreCampo = "CedulaRNC";
            myColumna3.Ancho = 350;
            myColumna3.Formato = "";
            myColumna3.HeaderText = "Nombre_Completo";
            myColumna3.NombreCampo = "Nombre_Completo";
            this.elrTextBox1.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[] {
        myColumna1,
        myColumna2,
        myColumna3};
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = true;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "EsSuplidor = 1 And EsActivo = 1";
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(113, 34);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(131, 29);
            this.elrTextBox1.TabIndex = 8;
            this.elrTextBox1.TablaOVistaBusqueda = "VENTIDADES";
            this.elrTextBox1.Text = "0";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Suplidor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Factura No.:";
            // 
            // elrTextBox4
            // 
            this.elrTextBox4.AMostrar = null;
            this.elrTextBox4.autoSenTab = true;
            this.elrTextBox4.AValidar = null;
            this.elrTextBox4.CampoBusquedaID = "";
            this.elrTextBox4.CampoData = "Factura_Numero";
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
            this.elrTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrTextBox4.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox4.Location = new System.Drawing.Point(135, 142);
            this.elrTextBox4.Name = "elrTextBox4";
            this.elrTextBox4.NombreTabla = "";
            this.elrTextBox4.SepDecimal = '\0';
            this.elrTextBox4.Size = new System.Drawing.Size(194, 29);
            this.elrTextBox4.TabIndex = 9;
            this.elrTextBox4.TablaOVistaBusqueda = "";
            this.elrTextBox4.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox4.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox4.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Factura_Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(135, 212);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(194, 29);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 7, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "NCF:";
            // 
            // elrTextBox5
            // 
            this.elrTextBox5.AMostrar = null;
            this.elrTextBox5.autoSenTab = true;
            this.elrTextBox5.AValidar = null;
            this.elrTextBox5.CampoBusquedaID = "";
            this.elrTextBox5.CampoData = "NCF";
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
            this.elrTextBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrTextBox5.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox5.Location = new System.Drawing.Point(135, 177);
            this.elrTextBox5.MaxLength = 19;
            this.elrTextBox5.Name = "elrTextBox5";
            this.elrTextBox5.NombreTabla = "";
            this.elrTextBox5.SepDecimal = '\0';
            this.elrTextBox5.Size = new System.Drawing.Size(194, 29);
            this.elrTextBox5.TabIndex = 13;
            this.elrTextBox5.TablaOVistaBusqueda = "";
            this.elrTextBox5.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox5.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox5.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Itbis:";
            // 
            // elrTextBox6
            // 
            this.elrTextBox6.AMostrar = null;
            this.elrTextBox6.autoSenTab = true;
            this.elrTextBox6.AValidar = null;
            this.elrTextBox6.CampoBusquedaID = "";
            this.elrTextBox6.CampoData = "Itbis";
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
            this.elrTextBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrTextBox6.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox6.Location = new System.Drawing.Point(510, 139);
            this.elrTextBox6.Name = "elrTextBox6";
            this.elrTextBox6.NombreTabla = "";
            this.elrTextBox6.SepDecimal = '\0';
            this.elrTextBox6.Size = new System.Drawing.Size(178, 29);
            this.elrTextBox6.TabIndex = 15;
            this.elrTextBox6.TablaOVistaBusqueda = "";
            this.elrTextBox6.Text = "0.00";
            this.elrTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.elrTextBox6.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox6.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox6.ValorPorDefecto = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Concepto:";
            // 
            // FormOtrosGastosR
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtTotal;
            valida1.Mensaje = "El Monto Debe Ser Mayor a Cero";
            valida1.NombreCampo = "Total";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtConcepto;
            valida2.Mensaje = "Debe Indicar un Concepto Valido";
            valida2.NombreCampo = "Concepto";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(712, 428);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.elrTextBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.elrTextBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.elrTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MensajePregunta = "¿Esta Seguro Que Desea Registrar Este Gasto?";
            this.MinimizeBox = false;
            this.Name = "FormOtrosGastosR";
            this.NombreCampoID = "CXP_Id";
            this.SPGraba = "SP_CXP_GRABA_GASTOS_OTROS";
            this.TablaEncabezado = "TTEMPORAL_CXP";
            this.Text = "REGISTRAR OTROS GASTOS";
            this.Load += new System.EventHandler(this.FormOtrosGastosR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.elrTextBox4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtpFecha, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.elrTextBox5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.elrTextBox6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox elrTextBox4;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox elrTextBox5;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox elrTextBox6;
        private WinControl_ELR_NET.ELRTextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label9;
    }
}