namespace ELRBanco
{
    partial class FormBancoAddChkPredefinido
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeneficiario = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 334);
            this.pnBotones.Size = new System.Drawing.Size(622, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(382, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(523, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(287, 0);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(192, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "Cheque_Id";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DisplayMember = "Concepto";
            this.cboTipo.DSData = this.DSDatos;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "EsActivo = 1";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(128, 25);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(465, 29);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 2;
            this.cboTipo.TablaOVistaConsulta = "TBANCOS_CHEQUES_PREDEFINIDOS";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "0";
            this.cboTipo.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beneficiario:";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.AMostrar = null;
            this.txtBeneficiario.AValidar = null;
            this.txtBeneficiario.CampoBusquedaID = "";
            this.txtBeneficiario.CampoData = "Beneficiario";
            this.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficiario.ColumnasBusqGeneral = null;
            this.txtBeneficiario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtBeneficiario.Decimales = 0;
            this.txtBeneficiario.DSData = this.DSDatos;
            this.txtBeneficiario.EsAutoGenerado = false;
            this.txtBeneficiario.EsBusqueda = false;
            this.txtBeneficiario.EsBusquedaAutoIncremental = false;
            this.txtBeneficiario.EsEditable = true;
            this.txtBeneficiario.FiltroBusqueda = "";
            this.txtBeneficiario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtBeneficiario.Location = new System.Drawing.Point(128, 60);
            this.txtBeneficiario.Multiline = true;
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.NombreTabla = "";
            this.txtBeneficiario.SepDecimal = '\0';
            this.txtBeneficiario.Size = new System.Drawing.Size(465, 64);
            this.txtBeneficiario.TabIndex = 4;
            this.txtBeneficiario.TablaOVistaBusqueda = "";
            this.txtBeneficiario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtBeneficiario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtBeneficiario.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
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
            this.txtConcepto.Location = new System.Drawing.Point(128, 130);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(465, 136);
            this.txtConcepto.TabIndex = 6;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.AValidar = null;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Monto";
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColumnasBusqGeneral = null;
            this.txtMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMonto.Decimales = 0;
            this.txtMonto.DSData = this.DSDatos;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsBusquedaAutoIncremental = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(128, 272);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(205, 29);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "";
            // 
            // FormBancoAddChkPredefinido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboTipo;
            valida1.Mensaje = "Debe Indicar el Tipo de Cheques";
            valida1.NombreCampo = "Cheque_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtBeneficiario;
            valida2.Mensaje = "Debe Indicar Nombre de Beneficiario";
            valida2.NombreCampo = "Beneficiario";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "10";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtConcepto;
            valida3.Mensaje = "Debe Indicar el Concepto";
            valida3.NombreCampo = "Concepto";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida3.Valor1 = "10";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtMonto;
            valida4.Mensaje = "El Monto Debe Ser Mayor a Cero";
            valida4.NombreCampo = "Monto";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "1";
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(622, 377);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MensajeAlGrabar = false;
            this.Name = "FormBancoAddChkPredefinido";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TTEMPORAL_BANCOS_CHEQUES_PREDEFINIDOS";
            this.Text = "GENERAR CHEQUE PRDEFINIDO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBeneficiario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtBeneficiario;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
    }
}