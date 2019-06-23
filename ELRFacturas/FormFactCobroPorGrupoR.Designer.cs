namespace ELRFacturas
{
    partial class FormFactCobroPorGrupoR
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.lblMontoLetra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAplicarTodo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_APagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 526);
            this.pnBotones.Size = new System.Drawing.Size(808, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(568, 0);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(709, 0);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 0;
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(473, 0);
            this.btnSiguientePage.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(378, 39);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.lblMontoLetra);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 237);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Concepto";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(3, 25);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(802, 72);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "0.00";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "ANombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(138, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(648, 33);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "0.00";
            // 
            // lblMontoLetra
            // 
            this.lblMontoLetra.AutoSize = true;
            this.lblMontoLetra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoLetra.Location = new System.Drawing.Point(134, 96);
            this.lblMontoLetra.Name = "lblMontoLetra";
            this.lblMontoLetra.Size = new System.Drawing.Size(139, 20);
            this.lblMontoLetra.TabIndex = 4;
            this.lblMontoLetra.Text = "MONTO EN LETRA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Recibimos de:";
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
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(138, 60);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(194, 33);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "El Monto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnAplicarTodo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 44);
            this.panel2.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpiar.Location = new System.Drawing.Point(157, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(157, 44);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAplicarTodo
            // 
            this.btnAplicarTodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAplicarTodo.Location = new System.Drawing.Point(0, 0);
            this.btnAplicarTodo.Name = "btnAplicarTodo";
            this.btnAplicarTodo.Size = new System.Drawing.Size(157, 44);
            this.btnAplicarTodo.TabIndex = 0;
            this.btnAplicarTodo.Text = "Aplicar Todo";
            this.btnAplicarTodo.UseVisualStyleBackColor = true;
            this.btnAplicarTodo.Click += new System.EventHandler(this.btnAplicarTodo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Concepto,
            this.Monto_Pendiente,
            this.Monto_APagar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(808, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Monto_Pendiente
            // 
            this.Monto_Pendiente.DataPropertyName = "Monto_Pendiente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto_Pendiente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto_Pendiente.HeaderText = "Monto Pendiente";
            this.Monto_Pendiente.Name = "Monto_Pendiente";
            this.Monto_Pendiente.ReadOnly = true;
            this.Monto_Pendiente.Width = 160;
            // 
            // Monto_APagar
            // 
            this.Monto_APagar.DataPropertyName = "Monto_APagar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Monto_APagar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto_APagar.HeaderText = "Monto APagar";
            this.Monto_APagar.Name = "Monto_APagar";
            this.Monto_APagar.ReadOnly = true;
            this.Monto_APagar.Width = 140;
            // 
            // FormFactCobroPorGrupoR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.Ticket;
            this.ImprimirAlGrabar = true;
            this.MostrarDesglosePago = true;
            this.Name = "FormFactCobroPorGrupoR";
            this.NombreCampoID = "Recibo_Id";
            this.NombreReporte = "RptReciboCaja";
            this.NombreVistaImprimir = "VCAJAS_RECIBOS";
            this.RequiereCajaAbierta = true;
            this.SPGraba = "SP_CAJAS_GRABA_RECIBO_CXC_GRUPO";
            this.TablaDetalle = "TTEMPORAL_CAJAS_RECIBOS_POR_GRUPO";
            this.TablaEncabezado = "TTEMPORAL_CAJAS_RECIBOS";
            this.Text = "REGISTRAR COBRO POR GRUPO";
            this.Activated += new System.EventHandler(this.FormFactCobroPorGrupoR_Activated);
            this.Load += new System.EventHandler(this.FormFactCobroPorGrupoR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label lblMontoLetra;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicarTodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_APagar;
    }
}