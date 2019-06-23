namespace ELRMaestros
{
    partial class FormSectoresR
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
            this.cboMunicipio = new WinControl_ELR_NET.ELRCombobox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSectorId = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarZona = new System.Windows.Forms.Button();
            this.btnBuscarMunicipio = new System.Windows.Forms.Button();
            this.btnBuscarProvincia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProvincia = new WinControl_ELR_NET.ELRCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPais = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboZona = new WinControl_ELR_NET.ELRCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 338);
            this.pnBotones.Size = new System.Drawing.Size(662, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(422, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(563, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(327, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(232, 39);
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.AValidar = null;
            this.cboMunicipio.CampoData = "Municipio_Id";
            this.cboMunicipio.CampoJoinCombobox2 = "";
            this.cboMunicipio.ComboboxAFiltrar = null;
            this.cboMunicipio.DisplayMember = "Nombre";
            this.cboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMunicipio.DSData = this.DSDatos;
            this.cboMunicipio.EsEditable = true;
            this.cboMunicipio.FiltroBusqueda = "";
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(108, 108);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.NombreTabla = "";
            this.cboMunicipio.Size = new System.Drawing.Size(472, 29);
            this.cboMunicipio.SSQL = "";
            this.cboMunicipio.TabIndex = 16;
            this.cboMunicipio.TablaOVistaConsulta = "";
            this.cboMunicipio.UsaDataGlobal = false;
            this.cboMunicipio.ValorPorDefecto = "0";
            this.cboMunicipio.ValueMember = "Municipio_Id";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.elrCheckBox1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSectorId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 107);
            this.panel1.TabIndex = 11;
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(290, 14);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 11;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
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
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(120, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(511, 29);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // txtSectorId
            // 
            this.txtSectorId.AMostrar = null;
            this.txtSectorId.AValidar = null;
            this.txtSectorId.CampoBusquedaID = "";
            this.txtSectorId.CampoData = "Sector_Id";
            this.txtSectorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSectorId.ColumnasBusqGeneral = null;
            this.txtSectorId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSectorId.Decimales = 0;
            this.txtSectorId.DSData = this.DSDatos;
            this.txtSectorId.EsAutoGenerado = false;
            this.txtSectorId.EsBusqueda = false;
            this.txtSectorId.EsBusquedaAutoIncremental = false;
            this.txtSectorId.EsEditable = false;
            this.txtSectorId.FiltroBusqueda = "";
            this.txtSectorId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSectorId.Location = new System.Drawing.Point(120, 14);
            this.txtSectorId.Name = "txtSectorId";
            this.txtSectorId.NombreTabla = "";
            this.txtSectorId.ReadOnly = true;
            this.txtSectorId.SepDecimal = '\0';
            this.txtSectorId.Size = new System.Drawing.Size(143, 29);
            this.txtSectorId.TabIndex = 8;
            this.txtSectorId.TablaOVistaBusqueda = "";
            this.txtSectorId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSectorId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSectorId.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sector Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarZona);
            this.groupBox1.Controls.Add(this.btnBuscarMunicipio);
            this.groupBox1.Controls.Add(this.btnBuscarProvincia);
            this.groupBox1.Controls.Add(this.cboMunicipio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboPais);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboZona);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 231);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Seleccional Municipio]";
            // 
            // btnBuscarZona
            // 
            this.btnBuscarZona.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarZona.Location = new System.Drawing.Point(586, 147);
            this.btnBuscarZona.Name = "btnBuscarZona";
            this.btnBuscarZona.Size = new System.Drawing.Size(47, 29);
            this.btnBuscarZona.TabIndex = 20;
            this.btnBuscarZona.UseVisualStyleBackColor = true;
            this.btnBuscarZona.Click += new System.EventHandler(this.btnBuscarProvincia_Click);
            // 
            // btnBuscarMunicipio
            // 
            this.btnBuscarMunicipio.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarMunicipio.Location = new System.Drawing.Point(586, 108);
            this.btnBuscarMunicipio.Name = "btnBuscarMunicipio";
            this.btnBuscarMunicipio.Size = new System.Drawing.Size(47, 29);
            this.btnBuscarMunicipio.TabIndex = 19;
            this.btnBuscarMunicipio.UseVisualStyleBackColor = true;
            this.btnBuscarMunicipio.Click += new System.EventHandler(this.btnBuscarProvincia_Click);
            // 
            // btnBuscarProvincia
            // 
            this.btnBuscarProvincia.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarProvincia.Location = new System.Drawing.Point(586, 73);
            this.btnBuscarProvincia.Name = "btnBuscarProvincia";
            this.btnBuscarProvincia.Size = new System.Drawing.Size(47, 29);
            this.btnBuscarProvincia.TabIndex = 18;
            this.btnBuscarProvincia.UseVisualStyleBackColor = true;
            this.btnBuscarProvincia.Click += new System.EventHandler(this.btnBuscarProvincia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Municipio:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.AValidar = null;
            this.cboProvincia.CampoData = "";
            this.cboProvincia.CampoJoinCombobox2 = "";
            this.cboProvincia.ComboboxAFiltrar = null;
            this.cboProvincia.DisplayMember = "Nombre";
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.DSData = null;
            this.cboProvincia.EsEditable = true;
            this.cboProvincia.FiltroBusqueda = "";
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(108, 73);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.NombreTabla = "";
            this.cboProvincia.Size = new System.Drawing.Size(472, 29);
            this.cboProvincia.SSQL = "";
            this.cboProvincia.TabIndex = 14;
            this.cboProvincia.TablaOVistaConsulta = "";
            this.cboProvincia.UsaDataGlobal = false;
            this.cboProvincia.ValorPorDefecto = "0";
            this.cboProvincia.ValueMember = "Provincia_Id";
            this.cboProvincia.SelectedValueChanged += new System.EventHandler(this.cboProvincia_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Provincia:";
            // 
            // cboPais
            // 
            this.cboPais.AValidar = null;
            this.cboPais.CampoData = "";
            this.cboPais.CampoJoinCombobox2 = "";
            this.cboPais.ComboboxAFiltrar = null;
            this.cboPais.DisplayMember = "Nombre";
            this.cboPais.DSData = null;
            this.cboPais.EsEditable = true;
            this.cboPais.FiltroBusqueda = "";
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(108, 36);
            this.cboPais.Name = "cboPais";
            this.cboPais.NombreTabla = "";
            this.cboPais.Size = new System.Drawing.Size(525, 29);
            this.cboPais.SSQL = "";
            this.cboPais.TabIndex = 12;
            this.cboPais.TablaOVistaConsulta = "";
            this.cboPais.UsaDataGlobal = false;
            this.cboPais.ValorPorDefecto = "0";
            this.cboPais.ValueMember = "Pais_Id";
            this.cboPais.SelectedValueChanged += new System.EventHandler(this.cboPais_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pais:";
            // 
            // cboZona
            // 
            this.cboZona.AValidar = null;
            this.cboZona.CampoData = "Zona_Id";
            this.cboZona.CampoJoinCombobox2 = "";
            this.cboZona.ComboboxAFiltrar = null;
            this.cboZona.DisplayMember = "Nombre";
            this.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZona.DSData = this.DSDatos;
            this.cboZona.EsEditable = true;
            this.cboZona.FiltroBusqueda = "";
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(108, 147);
            this.cboZona.Name = "cboZona";
            this.cboZona.NombreTabla = "";
            this.cboZona.Size = new System.Drawing.Size(472, 29);
            this.cboZona.SSQL = "";
            this.cboZona.TabIndex = 10;
            this.cboZona.TablaOVistaConsulta = "";
            this.cboZona.UsaDataGlobal = false;
            this.cboZona.ValorPorDefecto = "0";
            this.cboZona.ValueMember = "Zona_Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zona:";
            // 
            // FormSectoresR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = null;
            valida1.Mensaje = "Debe Digitar El Nombre del Sector";
            valida1.NombreCampo = "Nombre";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.cboMunicipio;
            valida2.Mensaje = "Debe Seleccional el Municipio";
            valida2.NombreCampo = "Municipio_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = "";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(662, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSectoresR";
            this.NombreCampoID = "Sector_Id";
            this.TablaEncabezado = "TZONAS_SECTORES";
            this.Text = "REGISTRO DE SECTORES";
            this.Load += new System.EventHandler(this.FormSectoresR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtSectorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRCombobox cboZona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarZona;
        private System.Windows.Forms.Button btnBuscarMunicipio;
        private System.Windows.Forms.Button btnBuscarProvincia;
        private WinControl_ELR_NET.ELRCombobox cboMunicipio;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRCombobox cboProvincia;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRCombobox cboPais;
        private System.Windows.Forms.Label label2;
    }
}