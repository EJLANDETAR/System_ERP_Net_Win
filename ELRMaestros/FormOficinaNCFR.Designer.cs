namespace ELRMaestros
{
    partial class FormOficinaNCFR
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
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            this.cboNCF = new WinControl_ELR_NET.ELRCombobox();
            this.txtPrefijo = new WinControl_ELR_NET.ELRTextBox();
            this.txtNumeroNCF = new WinControl_ELR_NET.ELRTextBox();
            this.txtPuntoReorden = new WinControl_ELR_NET.ELRTextBox();
            this.txtLimite = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFeVence = new WinControl_ELR_NET.ELRDatePicker();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 338);
            this.pnBotones.Size = new System.Drawing.Size(548, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(308, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(449, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(213, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(118, 39);
            // 
            // cboNCF
            // 
            this.cboNCF.AValidar = null;
            this.cboNCF.CampoData = "Tipo_NCF";
            this.cboNCF.CampoJoinCombobox2 = "";
            this.cboNCF.ComboboxAFiltrar = null;
            this.cboNCF.DisplayMember = "Descripcion";
            this.cboNCF.DSData = this.DSDatos;
            this.cboNCF.EsEditable = false;
            this.cboNCF.FiltroBusqueda = "Tipo_NCF > 0";
            this.cboNCF.FormattingEnabled = true;
            this.cboNCF.Location = new System.Drawing.Point(102, 28);
            this.cboNCF.Name = "cboNCF";
            this.cboNCF.NombreTabla = "";
            this.cboNCF.Size = new System.Drawing.Size(434, 29);
            this.cboNCF.SSQL = "";
            this.cboNCF.TabIndex = 2;
            this.cboNCF.TablaOVistaConsulta = "TSISTEMA_TIPOS_NCF";
            this.cboNCF.UsaDataGlobal = false;
            this.cboNCF.ValorPorDefecto = "0";
            this.cboNCF.ValueMember = "Tipo_NCF";
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.AMostrar = null;
            this.txtPrefijo.AValidar = null;
            this.txtPrefijo.CampoBusquedaID = "";
            this.txtPrefijo.CampoData = "Prefijo";
            this.txtPrefijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrefijo.ColumnasBusqGeneral = null;
            this.txtPrefijo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPrefijo.Decimales = 0;
            this.txtPrefijo.DSData = this.DSDatos;
            this.txtPrefijo.EsAutoGenerado = false;
            this.txtPrefijo.EsBusqueda = false;
            this.txtPrefijo.EsBusquedaAutoIncremental = false;
            this.txtPrefijo.EsEditable = true;
            this.txtPrefijo.FiltroBusqueda = "";
            this.txtPrefijo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPrefijo.Location = new System.Drawing.Point(150, 38);
            this.txtPrefijo.MaxLength = 3;
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.NombreTabla = "";
            this.txtPrefijo.SepDecimal = '\0';
            this.txtPrefijo.Size = new System.Drawing.Size(232, 29);
            this.txtPrefijo.TabIndex = 8;
            this.txtPrefijo.TablaOVistaBusqueda = "";
            this.txtPrefijo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPrefijo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPrefijo.ValorPorDefecto = "";
            // 
            // txtNumeroNCF
            // 
            this.txtNumeroNCF.AMostrar = null;
            this.txtNumeroNCF.AValidar = null;
            this.txtNumeroNCF.CampoBusquedaID = "";
            this.txtNumeroNCF.CampoData = "NumeroNCF";
            this.txtNumeroNCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroNCF.ColumnasBusqGeneral = null;
            this.txtNumeroNCF.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumeroNCF.Decimales = 0;
            this.txtNumeroNCF.DSData = this.DSDatos;
            this.txtNumeroNCF.EsAutoGenerado = false;
            this.txtNumeroNCF.EsBusqueda = false;
            this.txtNumeroNCF.EsBusquedaAutoIncremental = false;
            this.txtNumeroNCF.EsEditable = true;
            this.txtNumeroNCF.FiltroBusqueda = "";
            this.txtNumeroNCF.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNumeroNCF.Location = new System.Drawing.Point(150, 108);
            this.txtNumeroNCF.Name = "txtNumeroNCF";
            this.txtNumeroNCF.NombreTabla = "";
            this.txtNumeroNCF.SepDecimal = '\0';
            this.txtNumeroNCF.Size = new System.Drawing.Size(232, 29);
            this.txtNumeroNCF.TabIndex = 12;
            this.txtNumeroNCF.TablaOVistaBusqueda = "";
            this.txtNumeroNCF.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumeroNCF.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumeroNCF.ValorPorDefecto = "0";
            // 
            // txtPuntoReorden
            // 
            this.txtPuntoReorden.AMostrar = null;
            this.txtPuntoReorden.AValidar = null;
            this.txtPuntoReorden.CampoBusquedaID = "";
            this.txtPuntoReorden.CampoData = "Punto_Reorden";
            this.txtPuntoReorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuntoReorden.ColumnasBusqGeneral = null;
            this.txtPuntoReorden.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPuntoReorden.Decimales = 0;
            this.txtPuntoReorden.DSData = this.DSDatos;
            this.txtPuntoReorden.EsAutoGenerado = false;
            this.txtPuntoReorden.EsBusqueda = false;
            this.txtPuntoReorden.EsBusquedaAutoIncremental = false;
            this.txtPuntoReorden.EsEditable = true;
            this.txtPuntoReorden.FiltroBusqueda = "";
            this.txtPuntoReorden.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPuntoReorden.Location = new System.Drawing.Point(150, 144);
            this.txtPuntoReorden.Name = "txtPuntoReorden";
            this.txtPuntoReorden.NombreTabla = "";
            this.txtPuntoReorden.SepDecimal = '\0';
            this.txtPuntoReorden.Size = new System.Drawing.Size(232, 29);
            this.txtPuntoReorden.TabIndex = 14;
            this.txtPuntoReorden.TablaOVistaBusqueda = "";
            this.txtPuntoReorden.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPuntoReorden.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPuntoReorden.ValorPorDefecto = "0";
            // 
            // txtLimite
            // 
            this.txtLimite.AMostrar = null;
            this.txtLimite.AValidar = null;
            this.txtLimite.CampoBusquedaID = "";
            this.txtLimite.CampoData = "Numero_Maximo";
            this.txtLimite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLimite.ColumnasBusqGeneral = null;
            this.txtLimite.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtLimite.Decimales = 0;
            this.txtLimite.DSData = this.DSDatos;
            this.txtLimite.EsAutoGenerado = false;
            this.txtLimite.EsBusqueda = false;
            this.txtLimite.EsBusquedaAutoIncremental = false;
            this.txtLimite.EsEditable = true;
            this.txtLimite.FiltroBusqueda = "";
            this.txtLimite.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtLimite.Location = new System.Drawing.Point(150, 73);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.NombreTabla = "";
            this.txtLimite.SepDecimal = '\0';
            this.txtLimite.Size = new System.Drawing.Size(232, 29);
            this.txtLimite.TabIndex = 10;
            this.txtLimite.TablaOVistaBusqueda = "";
            this.txtLimite.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtLimite.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtLimite.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "NCF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFeVence);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPuntoReorden);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumeroNCF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrefijo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(30, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 240);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Punto Reorden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "No. NCF Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Limite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prefijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Vence";
            // 
            // dtpFeVence
            // 
            this.dtpFeVence.AValidar = null;
            this.dtpFeVence.CampoData = "Valido_Hasta";
            this.dtpFeVence.DSData = this.DSDatos;
            this.dtpFeVence.EsEditable = true;
            this.dtpFeVence.FiltroBusqueda = "";
            this.dtpFeVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeVence.Location = new System.Drawing.Point(150, 184);
            this.dtpFeVence.Name = "dtpFeVence";
            this.dtpFeVence.NombreTabla = "";
            this.dtpFeVence.Size = new System.Drawing.Size(232, 29);
            this.dtpFeVence.TabIndex = 16;
            this.dtpFeVence.ValorPorDefecto = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            // 
            // FormOficinaNCFR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboNCF;
            valida1.Mensaje = "Debe Elegir el NCF";
            valida1.NombreCampo = "Tipo_NCF";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtPrefijo;
            valida2.Mensaje = "El Prefijo debe Tener una Longitud de 11 Caracteres";
            valida2.NombreCampo = "Prefijo";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "3";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtNumeroNCF;
            valida3.Mensaje = "El Numero Actual de NCF Debe ser Mayor o Igual a Cero";
            valida3.NombreCampo = "NumeroNCF";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "0";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtPuntoReorden;
            valida4.Mensaje = "El Punto de Reorden debe ser Mayor a Cero";
            valida4.NombreCampo = "Punto_Reorden";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "1";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtLimite;
            valida5.Mensaje = "El Limite debe Ser Mayor a Cero";
            valida5.NombreCampo = "Numero_Maximo";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida5.Valor1 = "1";
            valida5.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5};
            this.ClientSize = new System.Drawing.Size(548, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboNCF);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormOficinaNCFR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TEMPRESAS_NCF_X_OFICINAS";
            this.Text = "REGISTRO NCF OFICINA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboNCF, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
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
        private WinControl_ELR_NET.ELRCombobox cboNCF;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtPuntoReorden;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtNumeroNCF;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtLimite;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtPrefijo;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRDatePicker dtpFeVence;
        private System.Windows.Forms.Label label2;
    }
}