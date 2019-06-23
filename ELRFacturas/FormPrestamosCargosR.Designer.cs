namespace ELRFacturas
{
    partial class FormPrestamosCargosR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCargoId = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoGarantia = new WinControl_ELR_NET.ELRCombobox();
            this.chkEsDemora = new WinControl_ELR_NET.ELRCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiasAtrazo = new WinControl_ELR_NET.ELRTextBox();
            this.txtMontoACobrar = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTasaDemora = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 327);
            this.pnBotones.Size = new System.Drawing.Size(485, 43);
            this.pnBotones.TabIndex = 8;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(291, 0);
            this.btnGrabar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 0);
            this.btnCancelar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo Id";
            // 
            // txtCargoId
            // 
            this.txtCargoId.CampoData = "Cargo_Id";
            this.txtCargoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCargoId.DSData = this.DSDatos;
            this.txtCargoId.EsAutoGenerado = false;
            this.txtCargoId.EsEditable = true;
            this.txtCargoId.FiltroBusqueda = "";
            this.txtCargoId.Location = new System.Drawing.Point(122, 31);
            this.txtCargoId.Name = "txtCargoId";
            this.txtCargoId.NombreTabla = "";
            this.txtCargoId.ReadOnly = true;
            this.txtCargoId.Size = new System.Drawing.Size(100, 29);
            this.txtCargoId.TabIndex = 1;
            this.txtCargoId.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Location = new System.Drawing.Point(122, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.Size = new System.Drawing.Size(349, 29);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Garantia";
            // 
            // cboTipoGarantia
            // 
            this.cboTipoGarantia.CampoData = "Tipo_Garantia_Id";
            this.cboTipoGarantia.CampoJoinCombobox2 = "";
            this.cboTipoGarantia.ComboboxAFiltrar = null;
            this.cboTipoGarantia.DisplayMember = "Descripcion";
            this.cboTipoGarantia.DSData = this.DSDatos;
            this.cboTipoGarantia.EsEditable = true;
            this.cboTipoGarantia.FiltroBusqueda = "EsActivo = 1";
            this.cboTipoGarantia.FormattingEnabled = true;
            this.cboTipoGarantia.Location = new System.Drawing.Point(122, 104);
            this.cboTipoGarantia.Name = "cboTipoGarantia";
            this.cboTipoGarantia.NombreTabla = "";
            this.cboTipoGarantia.Size = new System.Drawing.Size(349, 29);
            this.cboTipoGarantia.SSQL = "";
            this.cboTipoGarantia.TabIndex = 5;
            this.cboTipoGarantia.TablaOVistaConsulta = "TPRESTAMOS_TIPO_GARANTIAS";
            this.cboTipoGarantia.ValorPorDefecto = "0";
            this.cboTipoGarantia.ValueMember = "Tipo_Garantia_Id";
            // 
            // chkEsDemora
            // 
            this.chkEsDemora.AutoSize = true;
            this.chkEsDemora.CampoData = "EsDemora";
            this.chkEsDemora.DSData = this.DSDatos;
            this.chkEsDemora.EsEditable = true;
            this.chkEsDemora.EsModificable = true;
            this.chkEsDemora.FiltroBusqueda = "";
            this.chkEsDemora.Location = new System.Drawing.Point(122, 139);
            this.chkEsDemora.Name = "chkEsDemora";
            this.chkEsDemora.NombreTabla = "";
            this.chkEsDemora.Size = new System.Drawing.Size(104, 25);
            this.chkEsDemora.TabIndex = 6;
            this.chkEsDemora.Text = "Es Demora";
            this.chkEsDemora.UseVisualStyleBackColor = true;
            this.chkEsDemora.ValorPorDefecto = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTasaDemora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMontoACobrar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiasAtrazo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dias Atrazo";
            // 
            // txtDiasAtrazo
            // 
            this.txtDiasAtrazo.CampoData = "Dias_Atrazo";
            this.txtDiasAtrazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiasAtrazo.DSData = this.DSDatos;
            this.txtDiasAtrazo.EsAutoGenerado = false;
            this.txtDiasAtrazo.EsEditable = true;
            this.txtDiasAtrazo.FiltroBusqueda = "";
            this.txtDiasAtrazo.Location = new System.Drawing.Point(158, 35);
            this.txtDiasAtrazo.Name = "txtDiasAtrazo";
            this.txtDiasAtrazo.NombreTabla = "";
            this.txtDiasAtrazo.Size = new System.Drawing.Size(168, 29);
            this.txtDiasAtrazo.TabIndex = 1;
            this.txtDiasAtrazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiasAtrazo.ValorPorDefecto = "10";
            // 
            // txtMontoACobrar
            // 
            this.txtMontoACobrar.CampoData = "Monto";
            this.txtMontoACobrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoACobrar.DSData = this.DSDatos;
            this.txtMontoACobrar.EsAutoGenerado = false;
            this.txtMontoACobrar.EsEditable = true;
            this.txtMontoACobrar.FiltroBusqueda = "";
            this.txtMontoACobrar.Location = new System.Drawing.Point(158, 71);
            this.txtMontoACobrar.Name = "txtMontoACobrar";
            this.txtMontoACobrar.NombreTabla = "";
            this.txtMontoACobrar.Size = new System.Drawing.Size(168, 29);
            this.txtMontoACobrar.TabIndex = 3;
            this.txtMontoACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoACobrar.ValorPorDefecto = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monto a Cobrar";
            // 
            // txtTasaDemora
            // 
            this.txtTasaDemora.CampoData = "Tasa_Demora";
            this.txtTasaDemora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaDemora.DSData = this.DSDatos;
            this.txtTasaDemora.EsAutoGenerado = false;
            this.txtTasaDemora.EsEditable = true;
            this.txtTasaDemora.FiltroBusqueda = "";
            this.txtTasaDemora.Location = new System.Drawing.Point(158, 106);
            this.txtTasaDemora.Name = "txtTasaDemora";
            this.txtTasaDemora.NombreTabla = "";
            this.txtTasaDemora.Size = new System.Drawing.Size(100, 29);
            this.txtTasaDemora.TabIndex = 5;
            this.txtTasaDemora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTasaDemora.ValorPorDefecto = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tasa Dem. Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "%";
            // 
            // FormPrestamosCargosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtDescripcion;
            valida1.Mensaje = "Debe Indicar Nombre del Cargo o Descripcion";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.cboTipoGarantia;
            valida2.Mensaje = "Debe Indicar el Tipo de Garantia";
            valida2.NombreCampo = "Tipo_Garantia_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtDiasAtrazo;
            valida3.Mensaje = "Los Dias de Atrazo Deben Ser Mayor a Cero";
            valida3.NombreCampo = "Dias_Atrazo";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtMontoACobrar;
            valida4.Mensaje = "El Monto a Cobrar Debe Ser Mayor a Cero";
            valida4.NombreCampo = "Monto";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "1";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtTasaDemora;
            valida5.Mensaje = "La Tasa de Demora Debe Ser Mayor a Cero";
            valida5.NombreCampo = "Tasa_Demora";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida5.Valor1 = "1";
            valida5.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5};
            this.ClientSize = new System.Drawing.Size(485, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkEsDemora);
            this.Controls.Add(this.cboTipoGarantia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCargoId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrestamosCargosR";
            this.NombreCampoID = "Cargo_Id";
            this.TablaEncabezado = "TPRESTAMOS_CARGOS";
            this.Text = "REGISTRAR CARGO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCargoId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboTipoGarantia, 0);
            this.Controls.SetChildIndex(this.chkEsDemora, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCargoId;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboTipoGarantia;
        private WinControl_ELR_NET.ELRCheckBox chkEsDemora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtTasaDemora;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtMontoACobrar;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtDiasAtrazo;
        private System.Windows.Forms.Label label4;
    }
}