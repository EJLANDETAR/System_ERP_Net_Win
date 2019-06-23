namespace ELRNomina
{
    partial class FormNominaTipoMovimientosR
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
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsResta = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 261);
            this.pnBotones.Size = new System.Drawing.Size(570, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(330, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(471, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(235, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(140, 39);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Codigo";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(134, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(186, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AMostrar = null;
            this.txtDescripcion.AValidar = null;
            this.txtDescripcion.CampoBusquedaID = "";
            this.txtDescripcion.CampoData = "Concepto";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColumnasBusqGeneral = null;
            this.txtDescripcion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescripcion.Decimales = 0;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsBusqueda = false;
            this.txtDescripcion.EsBusquedaAutoIncremental = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescripcion.Location = new System.Drawing.Point(134, 69);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.SepDecimal = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(400, 29);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TablaOVistaBusqueda = "";
            this.txtDescripcion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescripcion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concepto:";
            // 
            // txtValor
            // 
            this.txtValor.AMostrar = null;
            this.txtValor.AValidar = null;
            this.txtValor.CampoBusquedaID = "";
            this.txtValor.CampoData = "Valor";
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.ColumnasBusqGeneral = null;
            this.txtValor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValor.Decimales = 0;
            this.txtValor.DSData = this.DSDatos;
            this.txtValor.EsAutoGenerado = false;
            this.txtValor.EsBusqueda = false;
            this.txtValor.EsBusquedaAutoIncremental = false;
            this.txtValor.EsEditable = true;
            this.txtValor.FiltroBusqueda = "";
            this.txtValor.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValor.Location = new System.Drawing.Point(134, 106);
            this.txtValor.Name = "txtValor";
            this.txtValor.NombreTabla = "";
            this.txtValor.SepDecimal = '\0';
            this.txtValor.Size = new System.Drawing.Size(186, 29);
            this.txtValor.TabIndex = 5;
            this.txtValor.TablaOVistaBusqueda = "";
            this.txtValor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtValor.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor\\Precio:";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(134, 213);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 8;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // chkEsResta
            // 
            this.chkEsResta.AutoSize = true;
            this.chkEsResta.CampoData = "EsDescto";
            this.chkEsResta.DSData = this.DSDatos;
            this.chkEsResta.EsEditable = true;
            this.chkEsResta.EsModificable = true;
            this.chkEsResta.FiltroBusqueda = "";
            this.chkEsResta.Location = new System.Drawing.Point(134, 182);
            this.chkEsResta.Name = "chkEsResta";
            this.chkEsResta.NombreTabla = "";
            this.chkEsResta.Size = new System.Drawing.Size(145, 25);
            this.chkEsResta.TabIndex = 7;
            this.chkEsResta.Text = "Es Un Descuento";
            this.chkEsResta.UseVisualStyleBackColor = true;
            this.chkEsResta.ValorPorDefecto = false;
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsSueldoBruto";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(134, 151);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(198, 25);
            this.elrCheckBox1.TabIndex = 6;
            this.elrCheckBox1.Text = "Es Parte de Sueldo Bruto";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormNominaTipoMovimientosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigo;
            valida1.Mensaje = "Debe Indicar el Codigo";
            valida1.NombreCampo = "Codigo";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtDescripcion;
            valida2.Mensaje = "Debe Indicar un Concepto Valido";
            valida2.NombreCampo = "Concepto";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "4";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(570, 304);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.chkEsResta);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNominaTipoMovimientosR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TNOMINAS_TIPO_MOVIMIENTOS";
            this.Text = "REGISTRAR TIPO DE MOVIMIENTO DE NOMINA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.Controls.SetChildIndex(this.chkEsResta, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtValor;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private WinControl_ELR_NET.ELRCheckBox chkEsResta;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
    }
}