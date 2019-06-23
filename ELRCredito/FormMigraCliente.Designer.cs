namespace ELRCredito
{
    partial class FormMigraCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMunicipio = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elrTextBox7 = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.elrTextBox5 = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarArchivoCliente = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibo_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 542);
            this.pnBotones.Size = new System.Drawing.Size(1044, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(804, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(945, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(709, 0);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMunicipio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.elrTextBox7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.elrTextBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCargarArchivoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 213);
            this.panel1.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Codigo_Anterior";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(436, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(167, 29);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Codigo:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.AMostrar = null;
            this.txtMunicipio.AValidar = null;
            this.txtMunicipio.CampoBusquedaID = "";
            this.txtMunicipio.CampoData = "Municipio";
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.ColumnasBusqGeneral = null;
            this.txtMunicipio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMunicipio.Decimales = 0;
            this.txtMunicipio.DSData = this.DSDatos;
            this.txtMunicipio.EsAutoGenerado = false;
            this.txtMunicipio.EsBusqueda = false;
            this.txtMunicipio.EsEditable = true;
            this.txtMunicipio.FiltroBusqueda = "";
            this.txtMunicipio.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMunicipio.Location = new System.Drawing.Point(528, 159);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.NombreTabla = "";
            this.txtMunicipio.SepDecimal = '\0';
            this.txtMunicipio.Size = new System.Drawing.Size(212, 29);
            this.txtMunicipio.TabIndex = 16;
            this.txtMunicipio.TablaOVistaBusqueda = "";
            this.txtMunicipio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMunicipio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMunicipio.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Municipio";
            // 
            // elrTextBox7
            // 
            this.elrTextBox7.AMostrar = null;
            this.elrTextBox7.AValidar = null;
            this.elrTextBox7.CampoBusquedaID = "";
            this.elrTextBox7.CampoData = "Direccion";
            this.elrTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox7.ColumnasBusqGeneral = null;
            this.elrTextBox7.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox7.Decimales = 0;
            this.elrTextBox7.DSData = this.DSDatos;
            this.elrTextBox7.EsAutoGenerado = false;
            this.elrTextBox7.EsBusqueda = false;
            this.elrTextBox7.EsEditable = true;
            this.elrTextBox7.FiltroBusqueda = "";
            this.elrTextBox7.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox7.Location = new System.Drawing.Point(125, 89);
            this.elrTextBox7.Multiline = true;
            this.elrTextBox7.Name = "elrTextBox7";
            this.elrTextBox7.NombreTabla = "";
            this.elrTextBox7.SepDecimal = '\0';
            this.elrTextBox7.Size = new System.Drawing.Size(891, 62);
            this.elrTextBox7.TabIndex = 14;
            this.elrTextBox7.TablaOVistaBusqueda = "";
            this.elrTextBox7.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox7.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox7.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Direccion:";
            // 
            // elrTextBox5
            // 
            this.elrTextBox5.AMostrar = null;
            this.elrTextBox5.AValidar = null;
            this.elrTextBox5.CampoBusquedaID = "";
            this.elrTextBox5.CampoData = "Telefonos";
            this.elrTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox5.ColumnasBusqGeneral = null;
            this.elrTextBox5.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox5.Decimales = 0;
            this.elrTextBox5.DSData = this.DSDatos;
            this.elrTextBox5.EsAutoGenerado = false;
            this.elrTextBox5.EsBusqueda = false;
            this.elrTextBox5.EsEditable = true;
            this.elrTextBox5.FiltroBusqueda = "";
            this.elrTextBox5.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox5.Location = new System.Drawing.Point(125, 159);
            this.elrTextBox5.Name = "elrTextBox5";
            this.elrTextBox5.NombreTabla = "";
            this.elrTextBox5.SepDecimal = '\0';
            this.elrTextBox5.Size = new System.Drawing.Size(265, 29);
            this.elrTextBox5.TabIndex = 10;
            this.elrTextBox5.TablaOVistaBusqueda = "";
            this.elrTextBox5.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox5.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox5.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefonos:";
            // 
            // txtNombres
            // 
            this.txtNombres.AMostrar = null;
            this.txtNombres.AValidar = null;
            this.txtNombres.CampoBusquedaID = "";
            this.txtNombres.CampoData = "Nombres";
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.ColumnasBusqGeneral = null;
            this.txtNombres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombres.Decimales = 0;
            this.txtNombres.DSData = this.DSDatos;
            this.txtNombres.EsAutoGenerado = false;
            this.txtNombres.EsBusqueda = false;
            this.txtNombres.EsEditable = true;
            this.txtNombres.FiltroBusqueda = "";
            this.txtNombres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombres.Location = new System.Drawing.Point(125, 51);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.NombreTabla = "";
            this.txtNombres.SepDecimal = '\0';
            this.txtNombres.Size = new System.Drawing.Size(891, 29);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.TablaOVistaBusqueda = "";
            this.txtNombres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombres.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // btnCargarArchivoCliente
            // 
            this.btnCargarArchivoCliente.Location = new System.Drawing.Point(20, 10);
            this.btnCargarArchivoCliente.Name = "btnCargarArchivoCliente";
            this.btnCargarArchivoCliente.Size = new System.Drawing.Size(250, 31);
            this.btnCargarArchivoCliente.TabIndex = 0;
            this.btnCargarArchivoCliente.Text = "Cargar Archivo de Cliente";
            this.btnCargarArchivoCliente.UseVisualStyleBackColor = true;
            this.btnCargarArchivoCliente.Click += new System.EventHandler(this.btnCargarArchivoCliente_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 501);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(1044, 41);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total  >>> 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Factura,
            this.Recibo_No,
            this.Fecha,
            this.Valor,
            this.Origen,
            this.Concepto});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 288);
            this.dataGridView1.TabIndex = 4;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 75;
            // 
            // Factura
            // 
            this.Factura.DataPropertyName = "Factura";
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 120;
            // 
            // Recibo_No
            // 
            this.Recibo_No.DataPropertyName = "Recibo_No";
            this.Recibo_No.HeaderText = "Recibo";
            this.Recibo_No.Name = "Recibo_No";
            this.Recibo_No.ReadOnly = true;
            this.Recibo_No.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 130;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 140;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "DR";
            this.Origen.DefaultCellStyle = dataGridViewCellStyle3;
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 75;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // FormMigraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.Name = "FormMigraCliente";
            this.NombreCampoID = "Unico";
            this.SPGraba = "SP_MIGRA_DATOS_CLIENTE";
            this.TablaDetalle = "TTEMPORAL_MIGRA_CLIENTES_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_MIGRA_CLIENTES";
            this.Text = "MIGRAR DATOS DEL CLIENTE";
            this.Load += new System.EventHandler(this.FormMigraCliente_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRTextBox elrTextBox5;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarArchivoCliente;
        private WinControl_ELR_NET.ELRTextBox elrTextBox7;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtMunicipio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibo_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label3;
    }
}