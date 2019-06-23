namespace ELRBanco
{
    partial class FormBancoAnularTransR
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
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCuenta = new WinControl_ELR_NET.ELRCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeneficiario = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAnularYCrear = new System.Windows.Forms.RadioButton();
            this.rdbSoloAnular = new System.Windows.Forms.RadioButton();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 462);
            this.pnBotones.Size = new System.Drawing.Size(690, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(450, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(591, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(355, 0);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(260, 39);
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.DSData = null;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(135, 321);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(522, 104);
            this.txtConcepto.TabIndex = 19;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Concepto:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboCuenta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBeneficiario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 225);
            this.panel1.TabIndex = 20;
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "Tipo";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DisplayMember = "Nombre";
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DSData = this.DSDatos;
            this.cboTipo.Enabled = false;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "";
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(133, 20);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(522, 33);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 29;
            this.cboTipo.TablaOVistaConsulta = "TBANCOS_TRANS_TIPOS";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "1";
            this.cboTipo.ValueMember = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo:";
            // 
            // txtNumero
            // 
            this.txtNumero.AMostrar = null;
            this.txtNumero.AValidar = null;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.CampoBusquedaID = "";
            this.txtNumero.CampoData = "Numero";
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.ColumnasBusqGeneral = null;
            this.txtNumero.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumero.Decimales = 0;
            this.txtNumero.DSData = this.DSDatos;
            this.txtNumero.EsAutoGenerado = false;
            this.txtNumero.EsBusqueda = false;
            this.txtNumero.EsEditable = true;
            this.txtNumero.FiltroBusqueda = "";
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNumero.Location = new System.Drawing.Point(133, 57);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.NombreTabla = "";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.SepDecimal = '\0';
            this.txtNumero.Size = new System.Drawing.Size(522, 33);
            this.txtNumero.TabIndex = 27;
            this.txtNumero.TablaOVistaBusqueda = "";
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumero.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumero.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumero.ValorPorDefecto = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Numero:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.AValidar = null;
            this.cboCuenta.CampoData = "Cuenta_Id";
            this.cboCuenta.CampoJoinCombobox2 = "";
            this.cboCuenta.ComboboxAFiltrar = null;
            this.cboCuenta.DisplayMember = "Nombre";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.DSData = this.DSDatos;
            this.cboCuenta.Enabled = false;
            this.cboCuenta.EsEditable = true;
            this.cboCuenta.FiltroBusqueda = "";
            this.cboCuenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(133, 135);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.NombreTabla = "";
            this.cboCuenta.Size = new System.Drawing.Size(522, 33);
            this.cboCuenta.SSQL = "";
            this.cboCuenta.TabIndex = 23;
            this.cboCuenta.TablaOVistaConsulta = "TBANCOS_CUENTAS_BANCARIAS";
            this.cboCuenta.UsaDataGlobal = false;
            this.cboCuenta.ValorPorDefecto = "1";
            this.cboCuenta.ValueMember = "Cuenta_Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cuenta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(133, 96);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(200, 33);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 8, 23, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha:";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.AValidar = null;
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Monto";
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColumnasBusqGeneral = null;
            this.txtMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMonto.Decimales = 0;
            this.txtMonto.DSData = this.DSDatos;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(460, 96);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(195, 33);
            this.txtMonto.TabIndex = 21;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Monto:";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.AMostrar = null;
            this.txtBeneficiario.AValidar = null;
            this.txtBeneficiario.BackColor = System.Drawing.Color.White;
            this.txtBeneficiario.CampoBusquedaID = "";
            this.txtBeneficiario.CampoData = "Beneficiario";
            this.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficiario.ColumnasBusqGeneral = null;
            this.txtBeneficiario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtBeneficiario.Decimales = 0;
            this.txtBeneficiario.DSData = this.DSDatos;
            this.txtBeneficiario.EsAutoGenerado = false;
            this.txtBeneficiario.EsBusqueda = false;
            this.txtBeneficiario.EsEditable = true;
            this.txtBeneficiario.FiltroBusqueda = "";
            this.txtBeneficiario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeneficiario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtBeneficiario.Location = new System.Drawing.Point(133, 175);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.NombreTabla = "";
            this.txtBeneficiario.ReadOnly = true;
            this.txtBeneficiario.SepDecimal = '\0';
            this.txtBeneficiario.Size = new System.Drawing.Size(522, 33);
            this.txtBeneficiario.TabIndex = 25;
            this.txtBeneficiario.TablaOVistaBusqueda = "";
            this.txtBeneficiario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtBeneficiario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtBeneficiario.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Beneficiario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAnularYCrear);
            this.groupBox1.Controls.Add(this.rdbSoloAnular);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 75);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rdbAnularYCrear
            // 
            this.rdbAnularYCrear.AutoSize = true;
            this.rdbAnularYCrear.Location = new System.Drawing.Point(166, 28);
            this.rdbAnularYCrear.Name = "rdbAnularYCrear";
            this.rdbAnularYCrear.Size = new System.Drawing.Size(191, 25);
            this.rdbAnularYCrear.TabIndex = 1;
            this.rdbAnularYCrear.TabStop = true;
            this.rdbAnularYCrear.Text = "Anular y Crear Nuevo";
            this.rdbAnularYCrear.UseVisualStyleBackColor = true;
            // 
            // rdbSoloAnular
            // 
            this.rdbSoloAnular.AutoSize = true;
            this.rdbSoloAnular.Location = new System.Drawing.Point(12, 28);
            this.rdbSoloAnular.Name = "rdbSoloAnular";
            this.rdbSoloAnular.Size = new System.Drawing.Size(79, 25);
            this.rdbSoloAnular.TabIndex = 0;
            this.rdbSoloAnular.TabStop = true;
            this.rdbSoloAnular.Text = "Anular";
            this.rdbSoloAnular.UseVisualStyleBackColor = true;
            this.rdbSoloAnular.CheckedChanged += new System.EventHandler(this.rdbSoloAnular_CheckedChanged);
            // 
            // FormBancoAnularTransR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.Name = "FormBancoAnularTransR";
            this.NombreCampoID = "Unico";
            this.TablaDetalle = "TTEMPORAL_BANCOS_TRANS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_BANCOS_TRANS";
            this.Text = "ANULAR TRANSACCION DE BANCO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
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
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRCombobox cboCuenta;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtBeneficiario;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAnularYCrear;
        private System.Windows.Forms.RadioButton rdbSoloAnular;
    }
}