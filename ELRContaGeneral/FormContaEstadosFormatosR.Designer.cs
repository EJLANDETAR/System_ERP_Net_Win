namespace ELRContaGeneral
{
    partial class FormContaEstadosFormatosR
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
            this.txtMultiplicaPor = new WinControl_ELR_NET.ELRTextBox();
            this.txtLineaNo = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoLinea = new WinControl_ELR_NET.ELRCombobox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elrCheckBox2 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCombobox2 = new WinControl_ELR_NET.ELRCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormula = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.elrCombobox1 = new WinControl_ELR_NET.ELRCombobox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 431);
            this.pnBotones.Size = new System.Drawing.Size(689, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(449, 0);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(590, 0);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(354, 0);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(259, 39);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // txtMultiplicaPor
            // 
            this.txtMultiplicaPor.AMostrar = null;
            this.txtMultiplicaPor.AValidar = null;
            this.txtMultiplicaPor.CampoBusquedaID = "";
            this.txtMultiplicaPor.CampoData = "MultiplicaPor";
            this.txtMultiplicaPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMultiplicaPor.ColumnasBusqGeneral = null;
            this.txtMultiplicaPor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMultiplicaPor.Decimales = 4;
            this.txtMultiplicaPor.DSData = this.DSDatos;
            this.txtMultiplicaPor.EsAutoGenerado = false;
            this.txtMultiplicaPor.EsBusqueda = false;
            this.txtMultiplicaPor.EsBusquedaAutoIncremental = false;
            this.txtMultiplicaPor.EsEditable = true;
            this.txtMultiplicaPor.FiltroBusqueda = "";
            this.txtMultiplicaPor.Formato = WinControl_ELR_NET.tbFormato.Decimal;
            this.txtMultiplicaPor.Location = new System.Drawing.Point(123, 221);
            this.txtMultiplicaPor.Name = "txtMultiplicaPor";
            this.txtMultiplicaPor.NombreTabla = "";
            this.txtMultiplicaPor.SepDecimal = '\0';
            this.txtMultiplicaPor.Size = new System.Drawing.Size(125, 29);
            this.txtMultiplicaPor.TabIndex = 12;
            this.txtMultiplicaPor.TablaOVistaBusqueda = "";
            this.txtMultiplicaPor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMultiplicaPor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMultiplicaPor.ValorPorDefecto = "1";
            // 
            // txtLineaNo
            // 
            this.txtLineaNo.AMostrar = null;
            this.txtLineaNo.AValidar = null;
            this.txtLineaNo.CampoBusquedaID = "";
            this.txtLineaNo.CampoData = "LineaNo";
            this.txtLineaNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLineaNo.ColumnasBusqGeneral = null;
            this.txtLineaNo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtLineaNo.Decimales = 0;
            this.txtLineaNo.DSData = this.DSDatos;
            this.txtLineaNo.EsAutoGenerado = false;
            this.txtLineaNo.EsBusqueda = false;
            this.txtLineaNo.EsBusquedaAutoIncremental = false;
            this.txtLineaNo.EsEditable = true;
            this.txtLineaNo.FiltroBusqueda = "";
            this.txtLineaNo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtLineaNo.Location = new System.Drawing.Point(123, 186);
            this.txtLineaNo.Name = "txtLineaNo";
            this.txtLineaNo.NombreTabla = "";
            this.txtLineaNo.SepDecimal = '\0';
            this.txtLineaNo.Size = new System.Drawing.Size(125, 29);
            this.txtLineaNo.TabIndex = 8;
            this.txtLineaNo.TablaOVistaBusqueda = "";
            this.txtLineaNo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtLineaNo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtLineaNo.ValorPorDefecto = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Formula_Id";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = false;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(123, 22);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(125, 29);
            this.elrTextBox1.TabIndex = 1;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "0";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Descripcion";
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
            this.txtConcepto.Location = new System.Drawing.Point(123, 57);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(526, 29);
            this.txtConcepto.TabIndex = 4;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Linea No.:";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(558, 26);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 2;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo Linea:";
            // 
            // cboTipoLinea
            // 
            this.cboTipoLinea.AValidar = null;
            this.cboTipoLinea.CampoData = "Tipo_Linea";
            this.cboTipoLinea.CampoJoinCombobox2 = "";
            this.cboTipoLinea.ComboboxAFiltrar = null;
            this.cboTipoLinea.DSData = this.DSDatos;
            this.cboTipoLinea.EsEditable = true;
            this.cboTipoLinea.FiltroBusqueda = "";
            this.cboTipoLinea.FormattingEnabled = true;
            this.cboTipoLinea.Items.AddRange(new object[] {
            "LINEA VACIA",
            "TITULO",
            "TOTAL EN CUENTA",
            "SUMA LINEA"});
            this.cboTipoLinea.Location = new System.Drawing.Point(362, 189);
            this.cboTipoLinea.Name = "cboTipoLinea";
            this.cboTipoLinea.NombreTabla = "";
            this.cboTipoLinea.Size = new System.Drawing.Size(287, 29);
            this.cboTipoLinea.SSQL = "";
            this.cboTipoLinea.TabIndex = 10;
            this.cboTipoLinea.TablaOVistaConsulta = "";
            this.cboTipoLinea.UsaDataGlobal = false;
            this.cboTipoLinea.ValorPorDefecto = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elrCheckBox2);
            this.groupBox1.Controls.Add(this.elrCheckBox1);
            this.groupBox1.Controls.Add(this.elrCombobox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Formato";
            // 
            // elrCheckBox2
            // 
            this.elrCheckBox2.AutoSize = true;
            this.elrCheckBox2.CampoData = "EsVisible";
            this.elrCheckBox2.DSData = this.DSDatos;
            this.elrCheckBox2.EsEditable = true;
            this.elrCheckBox2.EsModificable = true;
            this.elrCheckBox2.FiltroBusqueda = "";
            this.elrCheckBox2.Location = new System.Drawing.Point(273, 83);
            this.elrCheckBox2.Name = "elrCheckBox2";
            this.elrCheckBox2.NombreTabla = "";
            this.elrCheckBox2.Size = new System.Drawing.Size(101, 25);
            this.elrCheckBox2.TabIndex = 3;
            this.elrCheckBox2.Text = "Es Visible";
            this.elrCheckBox2.UseVisualStyleBackColor = true;
            this.elrCheckBox2.ValorPorDefecto = true;
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsNegrita";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(135, 83);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(107, 25);
            this.elrCheckBox1.TabIndex = 2;
            this.elrCheckBox1.Text = "Es Negrita";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = false;
            // 
            // elrCombobox2
            // 
            this.elrCombobox2.AValidar = null;
            this.elrCombobox2.CampoData = "Tipo_Subrayado";
            this.elrCombobox2.CampoJoinCombobox2 = "";
            this.elrCombobox2.ComboboxAFiltrar = null;
            this.elrCombobox2.DSData = this.DSDatos;
            this.elrCombobox2.EsEditable = true;
            this.elrCombobox2.FiltroBusqueda = "";
            this.elrCombobox2.FormattingEnabled = true;
            this.elrCombobox2.Items.AddRange(new object[] {
            "(NINGUNO)",
            "SENCILLO",
            "DOBLE"});
            this.elrCombobox2.Location = new System.Drawing.Point(135, 34);
            this.elrCombobox2.Name = "elrCombobox2";
            this.elrCombobox2.NombreTabla = "";
            this.elrCombobox2.Size = new System.Drawing.Size(430, 29);
            this.elrCombobox2.SSQL = "";
            this.elrCombobox2.TabIndex = 1;
            this.elrCombobox2.TablaOVistaConsulta = "";
            this.elrCombobox2.UsaDataGlobal = false;
            this.elrCombobox2.ValorPorDefecto = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subrayado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Formula:";
            // 
            // txtFormula
            // 
            this.txtFormula.AMostrar = null;
            this.txtFormula.AValidar = null;
            this.txtFormula.BackColor = System.Drawing.Color.White;
            this.txtFormula.CampoBusquedaID = "";
            this.txtFormula.CampoData = "Formula";
            this.txtFormula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormula.ColumnasBusqGeneral = null;
            this.txtFormula.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtFormula.Decimales = 0;
            this.txtFormula.DSData = this.DSDatos;
            this.txtFormula.EsAutoGenerado = false;
            this.txtFormula.EsBusqueda = false;
            this.txtFormula.EsBusquedaAutoIncremental = false;
            this.txtFormula.EsEditable = true;
            this.txtFormula.FiltroBusqueda = "";
            this.txtFormula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtFormula.Location = new System.Drawing.Point(123, 92);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.NombreTabla = "";
            this.txtFormula.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFormula.SepDecimal = '\0';
            this.txtFormula.Size = new System.Drawing.Size(526, 88);
            this.txtFormula.TabIndex = 6;
            this.txtFormula.TablaOVistaBusqueda = "";
            this.txtFormula.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtFormula.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtFormula.ValorPorDefecto = "";
            this.txtFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormula_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Multiplica Por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Anexo:";
            // 
            // elrCombobox1
            // 
            this.elrCombobox1.AValidar = null;
            this.elrCombobox1.CampoData = "AnexoNo";
            this.elrCombobox1.CampoJoinCombobox2 = "";
            this.elrCombobox1.ComboboxAFiltrar = null;
            this.elrCombobox1.DisplayMember = "Concepto";
            this.elrCombobox1.DSData = this.DSDatos;
            this.elrCombobox1.EsEditable = true;
            this.elrCombobox1.FiltroBusqueda = "";
            this.elrCombobox1.FormattingEnabled = true;
            this.elrCombobox1.Location = new System.Drawing.Point(123, 256);
            this.elrCombobox1.Name = "elrCombobox1";
            this.elrCombobox1.NombreTabla = "";
            this.elrCombobox1.Size = new System.Drawing.Size(526, 29);
            this.elrCombobox1.SSQL = "";
            this.elrCombobox1.TabIndex = 14;
            this.elrCombobox1.TablaOVistaConsulta = "VCONTA_ESTADOS_ANEXOS";
            this.elrCombobox1.UsaDataGlobal = false;
            this.elrCombobox1.ValorPorDefecto = "0";
            this.elrCombobox1.ValueMember = "Anexo_Id";
            // 
            // FormContaEstadosFormatosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtMultiplicaPor;
            valida1.Mensaje = "Debe Ser Diferente de Cero";
            valida1.NombreCampo = "MultiplicaPor";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.DiferenteA;
            valida1.Valor1 = "0";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtLineaNo;
            valida2.Mensaje = "Debe Ser Mayor o Igual a 1";
            valida2.NombreCampo = "LineaNo";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(689, 474);
            this.Controls.Add(this.elrCombobox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMultiplicaPor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTipoLinea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtLineaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MensajeAlGrabar = false;
            this.MinimizeBox = false;
            this.Name = "FormContaEstadosFormatosR";
            this.NombreCampoID = "Formula_Id";
            this.TablaEncabezado = "TCONTA_ESTADOS_FORMULAS";
            this.Text = "CONFIGURAR LINEA ESTADO FINANCIERO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtLineaNo, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboTipoLinea, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtFormula, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtMultiplicaPor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.elrCombobox1, 0);
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
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtLineaNo;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboTipoLinea;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox2;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private WinControl_ELR_NET.ELRCombobox elrCombobox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtFormula;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtMultiplicaPor;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRCombobox elrCombobox1;
    }
}