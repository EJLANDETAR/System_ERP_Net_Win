namespace ELRActivosFijos
{
    partial class FormActivosFijosTiposR
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
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.txtVidaUtil = new WinControl_ELR_NET.ELRTextBox();
            this.txtValorResidual = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepre1 = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepre2 = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 377);
            this.pnBotones.Size = new System.Drawing.Size(576, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(336, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(477, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(241, 0);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AMostrar = null;
            this.txtDescripcion.AValidar = null;
            this.txtDescripcion.CampoBusquedaID = "";
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColumnasBusqGeneral = null;
            this.txtDescripcion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescripcion.Decimales = 0;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsBusqueda = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescripcion.Location = new System.Drawing.Point(151, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.SepDecimal = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(393, 29);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TablaOVistaBusqueda = "";
            this.txtDescripcion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescripcion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.AMostrar = null;
            this.txtVidaUtil.AValidar = null;
            this.txtVidaUtil.CampoBusquedaID = "";
            this.txtVidaUtil.CampoData = "Vida_Util";
            this.txtVidaUtil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVidaUtil.ColumnasBusqGeneral = null;
            this.txtVidaUtil.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtVidaUtil.Decimales = 0;
            this.txtVidaUtil.DSData = this.DSDatos;
            this.txtVidaUtil.EsAutoGenerado = false;
            this.txtVidaUtil.EsBusqueda = false;
            this.txtVidaUtil.EsEditable = true;
            this.txtVidaUtil.FiltroBusqueda = "";
            this.txtVidaUtil.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtVidaUtil.Location = new System.Drawing.Point(151, 101);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.NombreTabla = "";
            this.txtVidaUtil.SepDecimal = '\0';
            this.txtVidaUtil.Size = new System.Drawing.Size(100, 29);
            this.txtVidaUtil.TabIndex = 5;
            this.txtVidaUtil.TablaOVistaBusqueda = "";
            this.txtVidaUtil.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtVidaUtil.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtVidaUtil.ValorPorDefecto = "1";
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.AMostrar = null;
            this.txtValorResidual.AValidar = null;
            this.txtValorResidual.CampoBusquedaID = "";
            this.txtValorResidual.CampoData = "Valor_Residual";
            this.txtValorResidual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorResidual.ColumnasBusqGeneral = null;
            this.txtValorResidual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValorResidual.Decimales = 0;
            this.txtValorResidual.DSData = this.DSDatos;
            this.txtValorResidual.EsAutoGenerado = false;
            this.txtValorResidual.EsBusqueda = false;
            this.txtValorResidual.EsEditable = true;
            this.txtValorResidual.FiltroBusqueda = "";
            this.txtValorResidual.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValorResidual.Location = new System.Drawing.Point(421, 102);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.NombreTabla = "";
            this.txtValorResidual.SepDecimal = '\0';
            this.txtValorResidual.Size = new System.Drawing.Size(123, 29);
            this.txtValorResidual.TabIndex = 7;
            this.txtValorResidual.TablaOVistaBusqueda = "";
            this.txtValorResidual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValorResidual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtValorResidual.ValorPorDefecto = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Tipo_Id";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsEditable = false;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(151, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(100, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vida Util(Anos):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Residual:";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsDepreciacion";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(151, 145);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(138, 25);
            this.elrCheckBox1.TabIndex = 8;
            this.elrCheckBox1.Text = "Es Depreciacion";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepre2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDepre1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(32, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "% De Depreciacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durante Primer Anio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDepre1
            // 
            this.txtDepre1.AMostrar = null;
            this.txtDepre1.AValidar = null;
            this.txtDepre1.CampoBusquedaID = "";
            this.txtDepre1.CampoData = "Depre_Primer_Anio";
            this.txtDepre1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepre1.ColumnasBusqGeneral = null;
            this.txtDepre1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDepre1.Decimales = 0;
            this.txtDepre1.DSData = this.DSDatos;
            this.txtDepre1.EsAutoGenerado = false;
            this.txtDepre1.EsBusqueda = false;
            this.txtDepre1.EsEditable = true;
            this.txtDepre1.FiltroBusqueda = "";
            this.txtDepre1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDepre1.Location = new System.Drawing.Point(211, 43);
            this.txtDepre1.MaxLength = 5;
            this.txtDepre1.Name = "txtDepre1";
            this.txtDepre1.NombreTabla = "";
            this.txtDepre1.SepDecimal = '\0';
            this.txtDepre1.Size = new System.Drawing.Size(113, 29);
            this.txtDepre1.TabIndex = 1;
            this.txtDepre1.TablaOVistaBusqueda = "";
            this.txtDepre1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDepre1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDepre1.ValorPorDefecto = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "A Partir Segundo Anio:";
            // 
            // txtDepre2
            // 
            this.txtDepre2.AMostrar = null;
            this.txtDepre2.AValidar = null;
            this.txtDepre2.CampoBusquedaID = "";
            this.txtDepre2.CampoData = "Depre_Despues_Anio";
            this.txtDepre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepre2.ColumnasBusqGeneral = null;
            this.txtDepre2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDepre2.Decimales = 0;
            this.txtDepre2.DSData = this.DSDatos;
            this.txtDepre2.EsAutoGenerado = false;
            this.txtDepre2.EsBusqueda = false;
            this.txtDepre2.EsEditable = true;
            this.txtDepre2.FiltroBusqueda = "";
            this.txtDepre2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDepre2.Location = new System.Drawing.Point(212, 82);
            this.txtDepre2.MaxLength = 5;
            this.txtDepre2.Name = "txtDepre2";
            this.txtDepre2.NombreTabla = "";
            this.txtDepre2.SepDecimal = '\0';
            this.txtDepre2.Size = new System.Drawing.Size(113, 29);
            this.txtDepre2.TabIndex = 3;
            this.txtDepre2.TablaOVistaBusqueda = "";
            this.txtDepre2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDepre2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDepre2.ValorPorDefecto = "0.00";
            // 
            // FormActivosFijosTiposR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtDescripcion;
            valida1.Mensaje = "Debe Indicar una Descripcion Valida";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "5";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtVidaUtil;
            valida2.Mensaje = "Vida Util Debe Ser Mayor o Igual a 1";
            valida2.NombreCampo = "Vida_Util";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtValorResidual;
            valida3.Mensaje = "Valor Residual debe Ser Mayor o Igual a 1";
            valida3.NombreCampo = "Valor_Residual";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtDepre1;
            valida4.Mensaje = "Este Valor Debe Ser Menor a 100";
            valida4.NombreCampo = "Depre_Primer_Anio";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida4.Valor1 = "99";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtDepre2;
            valida5.Mensaje = "Este Valor Debe Ser Menor a 99";
            valida5.NombreCampo = "Depre_Despues_Anio";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida5.Valor1 = "99";
            valida5.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5};
            this.ClientSize = new System.Drawing.Size(576, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtValorResidual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVidaUtil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActivosFijosTiposR";
            this.NombreCampoID = "Tipo_Id";
            this.TablaEncabezado = "TACTIVOS_FIJOS_TIPOS";
            this.Text = "REGISTRAR TIPO DE ACTIVOS FIJOS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtVidaUtil, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtValorResidual, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
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
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtVidaUtil;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtValorResidual;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtDepre2;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtDepre1;
        private System.Windows.Forms.Label label5;
    }
}