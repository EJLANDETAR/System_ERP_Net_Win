namespace ELRFacturas
{
    partial class FormNCPorDescuentoR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFacturaMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorcDescto = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.elrTextBox3 = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 371);
            this.pnBotones.Size = new System.Drawing.Size(634, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(394, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(535, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(299, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(204, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtFacturaMonto);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.elrTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodigoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 140);
            this.panel1.TabIndex = 1;
            // 
            // txtFacturaMonto
            // 
            this.txtFacturaMonto.AMostrar = new WinControl_ELR_NET.ControlesMostrar[0];
            this.txtFacturaMonto.AValidar = null;
            this.txtFacturaMonto.BackColor = System.Drawing.Color.White;
            this.txtFacturaMonto.CampoBusquedaID = "";
            this.txtFacturaMonto.CampoData = "Factura_Monto";
            this.txtFacturaMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacturaMonto.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[0];
            this.txtFacturaMonto.CondicionABuscar = "";
            this.txtFacturaMonto.Decimales = 0;
            this.txtFacturaMonto.DSData = this.DSDatos;
            this.txtFacturaMonto.EsAutoGenerado = false;
            this.txtFacturaMonto.EsBusqueda = false;
            this.txtFacturaMonto.EsBusquedaAutoIncremental = false;
            this.txtFacturaMonto.EsEditable = true;
            this.txtFacturaMonto.FiltroBusqueda = "EsActivo = 1";
            this.txtFacturaMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtFacturaMonto.Location = new System.Drawing.Point(441, 55);
            this.txtFacturaMonto.Name = "txtFacturaMonto";
            this.txtFacturaMonto.NombreTabla = "";
            this.txtFacturaMonto.ReadOnly = true;
            this.txtFacturaMonto.SepDecimal = '\0';
            this.txtFacturaMonto.Size = new System.Drawing.Size(165, 29);
            this.txtFacturaMonto.TabIndex = 36;
            this.txtFacturaMonto.TablaOVistaBusqueda = "";
            this.txtFacturaMonto.Text = "000000";
            this.txtFacturaMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFacturaMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtFacturaMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtFacturaMonto.ValorPorDefecto = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "A Nombre.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Monto Factura";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = new WinControl_ELR_NET.ControlesMostrar[0];
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.BackColor = System.Drawing.Color.White;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Factura_No";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[0];
            this.elrTextBox1.CondicionABuscar = "";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "EsActivo = 1";
            this.elrTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(187, 24);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.ReadOnly = true;
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(134, 29);
            this.elrTextBox1.TabIndex = 33;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.Text = "000000";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Factura Numero";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.AMostrar = null;
            this.txtNombreCliente.AValidar = null;
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.CampoBusquedaID = "";
            this.txtNombreCliente.CampoData = "ANombre";
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.ColumnasBusqGeneral = null;
            this.txtNombreCliente.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreCliente.Decimales = 0;
            this.txtNombreCliente.DSData = this.DSDatos;
            this.txtNombreCliente.EsAutoGenerado = false;
            this.txtNombreCliente.EsBusqueda = false;
            this.txtNombreCliente.EsBusquedaAutoIncremental = false;
            this.txtNombreCliente.EsEditable = true;
            this.txtNombreCliente.FiltroBusqueda = "";
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreCliente.Location = new System.Drawing.Point(145, 90);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.NombreTabla = "";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.SepDecimal = '\0';
            this.txtNombreCliente.Size = new System.Drawing.Size(461, 29);
            this.txtNombreCliente.TabIndex = 31;
            this.txtNombreCliente.TablaOVistaBusqueda = "";
            this.txtNombreCliente.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreCliente.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreCliente.ValorPorDefecto = "";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::ELRFacturas.Properties.Resources._1378160672_search;
            this.btnBuscarCliente.Location = new System.Drawing.Point(279, 55);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarCliente.TabIndex = 30;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cliente No.:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.AMostrar = new WinControl_ELR_NET.ControlesMostrar[0];
            this.txtCodigoCliente.AValidar = null;
            this.txtCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txtCodigoCliente.CampoBusquedaID = "";
            this.txtCodigoCliente.CampoData = "Entidad_Id";
            this.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCliente.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[0];
            this.txtCodigoCliente.CondicionABuscar = "";
            this.txtCodigoCliente.Decimales = 0;
            this.txtCodigoCliente.DSData = this.DSDatos;
            this.txtCodigoCliente.EsAutoGenerado = false;
            this.txtCodigoCliente.EsBusqueda = false;
            this.txtCodigoCliente.EsBusquedaAutoIncremental = false;
            this.txtCodigoCliente.EsEditable = true;
            this.txtCodigoCliente.FiltroBusqueda = "EsActivo = 1";
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoCliente.Location = new System.Drawing.Point(145, 55);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.NombreTabla = "";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.SepDecimal = '\0';
            this.txtCodigoCliente.Size = new System.Drawing.Size(128, 29);
            this.txtCodigoCliente.TabIndex = 29;
            this.txtCodigoCliente.TablaOVistaBusqueda = "";
            this.txtCodigoCliente.Text = "000000";
            this.txtCodigoCliente.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoCliente.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoCliente.ValorPorDefecto = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPorcDescto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.AValidar = null;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Total";
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColumnasBusqGeneral = null;
            this.txtMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMonto.Decimales = 2;
            this.txtMonto.DSData = this.DSDatos;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsBusquedaAutoIncremental = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Decimal;
            this.txtMonto.Location = new System.Drawing.Point(209, 79);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(172, 31);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "";
            this.txtMonto.Leave += new System.EventHandler(this.txtPorcDescto_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto:";
            // 
            // txtPorcDescto
            // 
            this.txtPorcDescto.AMostrar = null;
            this.txtPorcDescto.AValidar = null;
            this.txtPorcDescto.CampoBusquedaID = "";
            this.txtPorcDescto.CampoData = "PorcDescto";
            this.txtPorcDescto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcDescto.ColumnasBusqGeneral = null;
            this.txtPorcDescto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPorcDescto.Decimales = 2;
            this.txtPorcDescto.DSData = this.DSDatos;
            this.txtPorcDescto.EsAutoGenerado = false;
            this.txtPorcDescto.EsBusqueda = false;
            this.txtPorcDescto.EsBusquedaAutoIncremental = false;
            this.txtPorcDescto.EsEditable = true;
            this.txtPorcDescto.FiltroBusqueda = "";
            this.txtPorcDescto.Formato = WinControl_ELR_NET.tbFormato.Decimal;
            this.txtPorcDescto.Location = new System.Drawing.Point(209, 42);
            this.txtPorcDescto.MaxLength = 5;
            this.txtPorcDescto.Name = "txtPorcDescto";
            this.txtPorcDescto.NombreTabla = "";
            this.txtPorcDescto.SepDecimal = '\0';
            this.txtPorcDescto.Size = new System.Drawing.Size(172, 31);
            this.txtPorcDescto.TabIndex = 1;
            this.txtPorcDescto.TablaOVistaBusqueda = "";
            this.txtPorcDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPorcDescto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPorcDescto.ValorPorDefecto = "";
            this.txtPorcDescto.Leave += new System.EventHandler(this.txtPorcDescto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "% Descuento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.elrTextBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comentario";
            // 
            // elrTextBox3
            // 
            this.elrTextBox3.AMostrar = null;
            this.elrTextBox3.AValidar = null;
            this.elrTextBox3.CampoBusquedaID = "";
            this.elrTextBox3.CampoData = "Comentario";
            this.elrTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox3.ColumnasBusqGeneral = null;
            this.elrTextBox3.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox3.Decimales = 0;
            this.elrTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elrTextBox3.DSData = this.DSDatos;
            this.elrTextBox3.EsAutoGenerado = false;
            this.elrTextBox3.EsBusqueda = false;
            this.elrTextBox3.EsBusquedaAutoIncremental = false;
            this.elrTextBox3.EsEditable = true;
            this.elrTextBox3.FiltroBusqueda = "";
            this.elrTextBox3.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox3.Location = new System.Drawing.Point(3, 25);
            this.elrTextBox3.Multiline = true;
            this.elrTextBox3.Name = "elrTextBox3";
            this.elrTextBox3.NombreTabla = "";
            this.elrTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.elrTextBox3.SepDecimal = '\0';
            this.elrTextBox3.Size = new System.Drawing.Size(628, 74);
            this.elrTextBox3.TabIndex = 0;
            this.elrTextBox3.TablaOVistaBusqueda = "";
            this.elrTextBox3.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox3.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox3.ValorPorDefecto = "";
            // 
            // FormNCPorDescuentoR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CampoIdImprimir = "Identificador_Id";
            this.ClientSize = new System.Drawing.Size(634, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.PreviewRDLC;
            this.ImprimirAlGrabar = true;
            this.Name = "FormNCPorDescuentoR";
            this.NombreReporte = "rptDevolucion";
            this.NombreVistaImprimir = "VDEVOLUCIONES_DETALLES";
            this.SPGraba = "SP_VENTAS_GRABAR_NC_DESCUENTO";
            this.TablaEncabezado = "TTEMPORAL_VENTAS_DEVOLUCIONES";
            this.Text = "REGISTRAR NOTA DE CREDITO POR DESCUENTO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCodigoCliente;
        private WinControl_ELR_NET.ELRTextBox txtFacturaMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtPorcDescto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRTextBox elrTextBox3;
    }
}