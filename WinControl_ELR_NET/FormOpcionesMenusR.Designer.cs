namespace WinControl_ELR_NET
{
    partial class FormOpcionesMenusR
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
            this.cboModulo = new WinControl_ELR_NET.ELRCombobox();
            this.cboTipoForm = new WinControl_ELR_NET.ELRCombobox();
            this.txtTitulo = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEsConsulta = new WinControl_ELR_NET.ELRCheckBox();
            this.txtFormAEjecutar = new System.Windows.Forms.TextBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsModal = new WinControl_ELR_NET.ELRCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMenuId = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnCambiarImage = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtOrdenNo = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 455);
            this.pnBotones.Size = new System.Drawing.Size(675, 43);
            this.pnBotones.TabIndex = 11;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(435, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(576, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(340, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.btnSiguientePage.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(245, 39);
            // 
            
            // cboModulo
            // 
            this.cboModulo.AValidar = null;
            this.cboModulo.CampoData = "Modulo_Id";
            this.cboModulo.CampoJoinCombobox2 = "";
            this.cboModulo.ComboboxAFiltrar = null;
            this.cboModulo.DisplayMember = "Carpeta";
            this.cboModulo.DSData = this.DSDatos;
            this.cboModulo.EsEditable = true;
            this.cboModulo.FiltroBusqueda = "";
            this.cboModulo.FormattingEnabled = true;
            this.cboModulo.Location = new System.Drawing.Point(157, 65);
            this.cboModulo.Name = "cboModulo";
            this.cboModulo.NombreTabla = "";
            this.cboModulo.Size = new System.Drawing.Size(484, 29);
            this.cboModulo.SSQL = "";
            this.cboModulo.TabIndex = 3;
            this.cboModulo.TablaOVistaConsulta = "TSISTEMA_MODULOS";
            this.cboModulo.UsaDataGlobal = false;
            this.cboModulo.ValorPorDefecto = "1";
            this.cboModulo.ValueMember = "Modulo_Id";
            this.cboModulo.SelectedValueChanged += new System.EventHandler(this.cboModulo_SelectedValueChanged);
            // 
            // cboTipoForm
            // 
            this.cboTipoForm.AValidar = null;
            this.cboTipoForm.CampoData = "TipoFormulario";
            this.cboTipoForm.CampoJoinCombobox2 = "";
            this.cboTipoForm.ComboboxAFiltrar = null;
            this.cboTipoForm.DisplayMember = "Descripcion";
            this.cboTipoForm.DSData = this.DSDatos;
            this.cboTipoForm.EsEditable = true;
            this.cboTipoForm.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'TIPO_FORM\'";
            this.cboTipoForm.FormattingEnabled = true;
            this.cboTipoForm.Location = new System.Drawing.Point(145, 74);
            this.cboTipoForm.Name = "cboTipoForm";
            this.cboTipoForm.NombreTabla = "";
            this.cboTipoForm.Size = new System.Drawing.Size(474, 29);
            this.cboTipoForm.SSQL = "";
            this.cboTipoForm.TabIndex = 3;
            this.cboTipoForm.TablaOVistaConsulta = " TSISTEMA_TABLA_AUXILIAR";
            this.cboTipoForm.UsaDataGlobal = false;
            this.cboTipoForm.ValorPorDefecto = "C";
            this.cboTipoForm.ValueMember = "Id";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AMostrar = null;
            this.txtTitulo.AValidar = null;
            this.txtTitulo.CampoBusquedaID = "";
            this.txtTitulo.CampoData = "Titulo";
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.ColumnasBusqGeneral = null;
            this.txtTitulo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTitulo.Decimales = 0;
            this.txtTitulo.DSData = this.DSDatos;
            this.txtTitulo.EsAutoGenerado = false;
            this.txtTitulo.EsBusqueda = false;
            this.txtTitulo.EsBusquedaAutoIncremental = false;
            this.txtTitulo.EsEditable = true;
            this.txtTitulo.FiltroBusqueda = "";
            this.txtTitulo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTitulo.Location = new System.Drawing.Point(157, 135);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.NombreTabla = "";
            this.txtTitulo.SepDecimal = '\0';
            this.txtTitulo.Size = new System.Drawing.Size(484, 29);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.TablaOVistaBusqueda = "";
            this.txtTitulo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTitulo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTitulo.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEsConsulta);
            this.groupBox1.Controls.Add(this.txtFormAEjecutar);
            this.groupBox1.Controls.Add(this.chkEsActivo);
            this.groupBox1.Controls.Add(this.chkEsModal);
            this.groupBox1.Controls.Add(this.cboTipoForm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 165);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Form A Ejecutar";
            // 
            // chkEsConsulta
            // 
            this.chkEsConsulta.AutoSize = true;
            this.chkEsConsulta.CampoData = "EsMenuConsulta";
            this.chkEsConsulta.DSData = this.DSDatos;
            this.chkEsConsulta.EsEditable = true;
            this.chkEsConsulta.EsModificable = true;
            this.chkEsConsulta.FiltroBusqueda = "";
            this.chkEsConsulta.Location = new System.Drawing.Point(401, 122);
            this.chkEsConsulta.Name = "chkEsConsulta";
            this.chkEsConsulta.NombreTabla = "";
            this.chkEsConsulta.Size = new System.Drawing.Size(170, 25);
            this.chkEsConsulta.TabIndex = 6;
            this.chkEsConsulta.Text = "Es Consulta\\Reporte";
            this.chkEsConsulta.UseVisualStyleBackColor = true;
            this.chkEsConsulta.ValorPorDefecto = false;
            // 
            // txtFormAEjecutar
            // 
            this.txtFormAEjecutar.Location = new System.Drawing.Point(145, 39);
            this.txtFormAEjecutar.Name = "txtFormAEjecutar";
            this.txtFormAEjecutar.Size = new System.Drawing.Size(474, 29);
            this.txtFormAEjecutar.TabIndex = 1;
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(145, 122);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 4;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // chkEsModal
            // 
            this.chkEsModal.AutoSize = true;
            this.chkEsModal.CampoData = "EsModal";
            this.chkEsModal.DSData = this.DSDatos;
            this.chkEsModal.EsEditable = true;
            this.chkEsModal.EsModificable = true;
            this.chkEsModal.FiltroBusqueda = "";
            this.chkEsModal.Location = new System.Drawing.Point(278, 122);
            this.chkEsModal.Name = "chkEsModal";
            this.chkEsModal.NombreTabla = "";
            this.chkEsModal.Size = new System.Drawing.Size(92, 25);
            this.chkEsModal.TabIndex = 5;
            this.chkEsModal.Text = "Es Modal";
            this.chkEsModal.UseVisualStyleBackColor = true;
            this.chkEsModal.ValorPorDefecto = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo Form:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre Form:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Menu Principal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titulo:";
            // 
            // txtMenuId
            // 
            this.txtMenuId.AMostrar = null;
            this.txtMenuId.AValidar = null;
            this.txtMenuId.CampoBusquedaID = "";
            this.txtMenuId.CampoData = "Menu_Id";
            this.txtMenuId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMenuId.ColumnasBusqGeneral = null;
            this.txtMenuId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMenuId.Decimales = 0;
            this.txtMenuId.DSData = this.DSDatos;
            this.txtMenuId.EsAutoGenerado = false;
            this.txtMenuId.EsBusqueda = false;
            this.txtMenuId.EsBusquedaAutoIncremental = false;
            this.txtMenuId.EsEditable = false;
            this.txtMenuId.FiltroBusqueda = "";
            this.txtMenuId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMenuId.Location = new System.Drawing.Point(157, 30);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.NombreTabla = "";
            this.txtMenuId.ReadOnly = true;
            this.txtMenuId.SepDecimal = '\0';
            this.txtMenuId.Size = new System.Drawing.Size(168, 29);
            this.txtMenuId.TabIndex = 1;
            this.txtMenuId.TablaOVistaBusqueda = "";
            this.txtMenuId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMenuId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMenuId.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Image:";
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImage.Location = new System.Drawing.Point(377, 208);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(90, 76);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 21;
            this.ptbImage.TabStop = false;
            // 
            // btnCambiarImage
            // 
            this.btnCambiarImage.Location = new System.Drawing.Point(473, 208);
            this.btnCambiarImage.Name = "btnCambiarImage";
            this.btnCambiarImage.Size = new System.Drawing.Size(98, 32);
            this.btnCambiarImage.TabIndex = 13;
            this.btnCambiarImage.Text = "Cambiar Imagen";
            this.btnCambiarImage.UseVisualStyleBackColor = true;
            this.btnCambiarImage.Click += new System.EventHandler(this.btnCambiarImage_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(484, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // txtOrdenNo
            // 
            this.txtOrdenNo.AMostrar = null;
            this.txtOrdenNo.AValidar = null;
            this.txtOrdenNo.CampoBusquedaID = "";
            this.txtOrdenNo.CampoData = "OrdenNo";
            this.txtOrdenNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrdenNo.ColumnasBusqGeneral = null;
            this.txtOrdenNo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtOrdenNo.Decimales = 0;
            this.txtOrdenNo.DSData = this.DSDatos;
            this.txtOrdenNo.EsAutoGenerado = false;
            this.txtOrdenNo.EsBusqueda = false;
            this.txtOrdenNo.EsBusquedaAutoIncremental = false;
            this.txtOrdenNo.EsEditable = true;
            this.txtOrdenNo.FiltroBusqueda = "";
            this.txtOrdenNo.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtOrdenNo.Location = new System.Drawing.Point(158, 205);
            this.txtOrdenNo.Name = "txtOrdenNo";
            this.txtOrdenNo.NombreTabla = "";
            this.txtOrdenNo.SepDecimal = '\0';
            this.txtOrdenNo.Size = new System.Drawing.Size(100, 29);
            this.txtOrdenNo.TabIndex = 11;
            this.txtOrdenNo.TablaOVistaBusqueda = "";
            this.txtOrdenNo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtOrdenNo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtOrdenNo.ValorPorDefecto = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Orden No.:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(157, 170);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(484, 29);
            this.txtURL.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "URL:";
            // 
            // FormOpcionesMenusR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboModulo;
            valida1.Mensaje = "Debe Indicar el Modulo";
            valida1.NombreCampo = "Modulo_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = null;
            valida2.Mensaje = "Debe Indicar el Nombre del Menu";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = null;
            valida3.Mensaje = "Debe Indicar el Formulario a Ejecutar";
            valida3.NombreCampo = "Formulario_AEjecutar";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            valida4.comtrol = this.cboTipoForm;
            valida4.Mensaje = "Debe Indicar el Tipo de Formulario";
            valida4.NombreCampo = "TipoFormulario";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida4.Valor1 = null;
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(675, 498);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOrdenNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCambiarImage);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboModulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMenuId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOpcionesMenusR";
            this.NombreCampoID = "Menu_Id";
            this.TablaEncabezado = "TACCESOS_OPCIONES_MENU";
            this.Text = "REGISTRAR OPCIONES DE MENU";
            this.Load += new System.EventHandler(this.FormOpcionesMenusR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMenuId, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cboModulo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.ptbImage, 0);
            this.Controls.SetChildIndex(this.btnCambiarImage, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtOrdenNo, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtURL, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ELRCheckBox chkEsActivo;
        private ELRCheckBox chkEsModal;
        private ELRCombobox cboTipoForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private ELRCombobox cboModulo;
        private System.Windows.Forms.Label label5;
        private ELRTextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private ELRTextBox txtMenuId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Button btnCambiarImage;
        private System.Windows.Forms.TextBox txtFormAEjecutar;
        private System.Windows.Forms.TextBox txtNombre;
        private ELRTextBox txtOrdenNo;
        private System.Windows.Forms.Label label9;
        private ELRCheckBox chkEsConsulta;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label8;
    }
}