namespace ELRBanco
{
    partial class FormBancoTiposTransR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tctNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrigen = new WinControl_ELR_NET.ELRCombobox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox2 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 239);
            this.pnBotones.Size = new System.Drawing.Size(532, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(292, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(433, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(197, 0);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(102, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Tipo";
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
            this.txtCodigo.Location = new System.Drawing.Point(119, 35);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(122, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // tctNombre
            // 
            this.tctNombre.AMostrar = null;
            this.tctNombre.AValidar = null;
            this.tctNombre.CampoBusquedaID = "";
            this.tctNombre.CampoData = "Nombre";
            this.tctNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tctNombre.ColumnasBusqGeneral = null;
            this.tctNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.tctNombre.Decimales = 0;
            this.tctNombre.DSData = this.DSDatos;
            this.tctNombre.EsAutoGenerado = false;
            this.tctNombre.EsBusqueda = false;
            this.tctNombre.EsEditable = true;
            this.tctNombre.FiltroBusqueda = "";
            this.tctNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.tctNombre.Location = new System.Drawing.Point(119, 70);
            this.tctNombre.Name = "tctNombre";
            this.tctNombre.NombreTabla = "";
            this.tctNombre.SepDecimal = '\0';
            this.tctNombre.Size = new System.Drawing.Size(382, 29);
            this.tctNombre.TabIndex = 4;
            this.tctNombre.TablaOVistaBusqueda = "";
            this.tctNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.tctNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.tctNombre.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Origen:";
            // 
            // cboOrigen
            // 
            this.cboOrigen.AValidar = null;
            this.cboOrigen.CampoData = "";
            this.cboOrigen.CampoJoinCombobox2 = "";
            this.cboOrigen.ComboboxAFiltrar = null;
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.DSData = null;
            this.cboOrigen.EsEditable = true;
            this.cboOrigen.FiltroBusqueda = "";
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "DEBITO",
            "CREDITO"});
            this.cboOrigen.Location = new System.Drawing.Point(119, 105);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.NombreTabla = "";
            this.cboOrigen.Size = new System.Drawing.Size(382, 29);
            this.cboOrigen.SSQL = "";
            this.cboOrigen.TabIndex = 6;
            this.cboOrigen.TablaOVistaConsulta = "";
            this.cboOrigen.UsaDataGlobal = false;
            this.cboOrigen.ValorPorDefecto = "0";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(119, 156);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 7;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // elrCheckBox2
            // 
            this.elrCheckBox2.AutoSize = true;
            this.elrCheckBox2.CampoData = "EsAjusteConciliacion";
            this.elrCheckBox2.DSData = this.DSDatos;
            this.elrCheckBox2.EsEditable = true;
            this.elrCheckBox2.EsModificable = true;
            this.elrCheckBox2.FiltroBusqueda = "";
            this.elrCheckBox2.Location = new System.Drawing.Point(234, 156);
            this.elrCheckBox2.Name = "elrCheckBox2";
            this.elrCheckBox2.NombreTabla = "";
            this.elrCheckBox2.Size = new System.Drawing.Size(179, 25);
            this.elrCheckBox2.TabIndex = 8;
            this.elrCheckBox2.Text = "Es Ajuste Conciliacion";
            this.elrCheckBox2.UseVisualStyleBackColor = true;
            this.elrCheckBox2.ValorPorDefecto = false;
            // 
            // FormBancoTiposTransR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigo;
            valida1.Mensaje = "Debe Indicar el Codigo";
            valida1.NombreCampo = "Tipo";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "2";
            valida1.Valor2 = null;
            valida2.comtrol = this.tctNombre;
            valida2.Mensaje = "Debe Indicar Nombre Transaccion";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "4";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(532, 282);
            this.Controls.Add(this.elrCheckBox2);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tctNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBancoTiposTransR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TBANCOS_TRANS_TIPOS";
            this.Text = "TIPO DE TRANSACCION REGISTRO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tctNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboOrigen, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.Controls.SetChildIndex(this.elrCheckBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox tctNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboOrigen;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox2;
    }
}