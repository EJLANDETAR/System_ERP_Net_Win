namespace ELRMaestros
{
    partial class FormMonedaR
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
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorVenta = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorCompra = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 318);
            this.pnBotones.Size = new System.Drawing.Size(481, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(287, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(382, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(192, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
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
            this.txtCodigo.CampoData = "Codigo";
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
            this.txtCodigo.Location = new System.Drawing.Point(97, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(108, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
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
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(97, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(358, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(97, 96);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 4;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasa de Cambio";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.AMostrar = null;
            this.txtValorVenta.AValidar = null;
            this.txtValorVenta.CampoBusquedaID = "";
            this.txtValorVenta.CampoData = "Valor_Venta";
            this.txtValorVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorVenta.ColumnasBusqGeneral = null;
            this.txtValorVenta.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValorVenta.Decimales = 0;
            this.txtValorVenta.DSData = this.DSDatos;
            this.txtValorVenta.EsAutoGenerado = false;
            this.txtValorVenta.EsBusqueda = false;
            this.txtValorVenta.EsEditable = true;
            this.txtValorVenta.FiltroBusqueda = "";
            this.txtValorVenta.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValorVenta.Location = new System.Drawing.Point(183, 81);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.NombreTabla = "";
            this.txtValorVenta.SepDecimal = '\0';
            this.txtValorVenta.Size = new System.Drawing.Size(144, 29);
            this.txtValorVenta.TabIndex = 3;
            this.txtValorVenta.TablaOVistaBusqueda = "";
            this.txtValorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenta.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValorVenta.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtValorVenta.ValorPorDefecto = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor Venta:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.AMostrar = null;
            this.txtValorCompra.AValidar = null;
            this.txtValorCompra.CampoBusquedaID = "";
            this.txtValorCompra.CampoData = "Valor_Compra";
            this.txtValorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorCompra.ColumnasBusqGeneral = null;
            this.txtValorCompra.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValorCompra.Decimales = 0;
            this.txtValorCompra.DSData = this.DSDatos;
            this.txtValorCompra.EsAutoGenerado = false;
            this.txtValorCompra.EsBusqueda = false;
            this.txtValorCompra.EsEditable = true;
            this.txtValorCompra.FiltroBusqueda = "";
            this.txtValorCompra.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValorCompra.Location = new System.Drawing.Point(183, 42);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.NombreTabla = "";
            this.txtValorCompra.SepDecimal = '\0';
            this.txtValorCompra.Size = new System.Drawing.Size(144, 29);
            this.txtValorCompra.TabIndex = 1;
            this.txtValorCompra.TablaOVistaBusqueda = "";
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCompra.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValorCompra.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtValorCompra.ValorPorDefecto = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tasa Cambio (V. C.):";
            // 
            // FormMonedaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigo;
            valida1.Mensaje = "Codigo Debe Tener Minimo 2 Caracteres";
            valida1.NombreCampo = "Codigo";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "2";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "Debe Indicar Nombre Moneda, Minimo 5 Carcateres";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtValorCompra;
            valida3.Mensaje = "Tasa de Cambio(Valor Compra) Debe Ser Mayor a Cero";
            valida3.NombreCampo = "Valor_Compra";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtValorVenta;
            valida4.Mensaje = "Debe Ser Mayor a Cero";
            valida4.NombreCampo = "Valor_Venta";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "1";
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(481, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMonedaR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TSISTEMA_MONEDAS";
            this.Text = "REGISTRO DE MONEDAS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
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
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtValorVenta;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtValorCompra;
        private System.Windows.Forms.Label label3;
    }
}