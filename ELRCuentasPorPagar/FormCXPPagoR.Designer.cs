namespace ELRCuentasPorPagar
{
    partial class FormCXPPagoR
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
            this.cboCuentaBancaria = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoLetra = new WinControl_ELR_NET.ELRTextBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
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
            this.pnBotones.Location = new System.Drawing.Point(0, 505);
            this.pnBotones.Size = new System.Drawing.Size(886, 57);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(618, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 53);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(759, 0);
            this.btnCancelar.Size = new System.Drawing.Size(123, 53);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 53);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(523, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 53);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(428, 53);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboCuentaBancaria);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtMontoLetra);
            this.panel3.Controls.Add(this.cboFormaPago);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 289);
            this.panel3.TabIndex = 4;
            // 
            // cboCuentaBancaria
            // 
            this.cboCuentaBancaria.AValidar = null;
            this.cboCuentaBancaria.CampoData = "Cuenta_Id";
            this.cboCuentaBancaria.CampoJoinCombobox2 = "";
            this.cboCuentaBancaria.ComboboxAFiltrar = null;
            this.cboCuentaBancaria.DisplayMember = "Nombre";
            this.cboCuentaBancaria.DSData = this.DSDatos;
            this.cboCuentaBancaria.EsEditable = true;
            this.cboCuentaBancaria.FiltroBusqueda = "EsActivo = 1 And EsCheques = 1";
            this.cboCuentaBancaria.FormattingEnabled = true;
            this.cboCuentaBancaria.Location = new System.Drawing.Point(134, 139);
            this.cboCuentaBancaria.Name = "cboCuentaBancaria";
            this.cboCuentaBancaria.NombreTabla = "";
            this.cboCuentaBancaria.Size = new System.Drawing.Size(419, 29);
            this.cboCuentaBancaria.SSQL = "";
            this.cboCuentaBancaria.TabIndex = 32;
            this.cboCuentaBancaria.TablaOVistaConsulta = "TBANCOS_CUENTAS_BANCARIAS";
            this.cboCuentaBancaria.UsaDataGlobal = false;
            this.cboCuentaBancaria.ValorPorDefecto = "0";
            this.cboCuentaBancaria.ValueMember = "Cuenta_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cuenta Banco;";
            // 
            // txtMontoLetra
            // 
            this.txtMontoLetra.AMostrar = null;
            this.txtMontoLetra.autoSenTab = true;
            this.txtMontoLetra.AValidar = null;
            this.txtMontoLetra.BackColor = System.Drawing.Color.White;
            this.txtMontoLetra.CampoBusquedaID = "";
            this.txtMontoLetra.CampoData = "";
            this.txtMontoLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoLetra.ColumnasBusqGeneral = null;
            this.txtMontoLetra.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMontoLetra.Decimales = 0;
            this.txtMontoLetra.DSData = null;
            this.txtMontoLetra.EsAutoGenerado = false;
            this.txtMontoLetra.EsBusqueda = false;
            this.txtMontoLetra.EsBusquedaAutoIncremental = false;
            this.txtMontoLetra.EsEditable = true;
            this.txtMontoLetra.FiltroBusqueda = "";
            this.txtMontoLetra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoLetra.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMontoLetra.Location = new System.Drawing.Point(430, 60);
            this.txtMontoLetra.Multiline = true;
            this.txtMontoLetra.Name = "txtMontoLetra";
            this.txtMontoLetra.NombreTabla = "";
            this.txtMontoLetra.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMontoLetra.SepDecimal = '\0';
            this.txtMontoLetra.Size = new System.Drawing.Size(433, 71);
            this.txtMontoLetra.TabIndex = 30;
            this.txtMontoLetra.TablaOVistaBusqueda = "";
            this.txtMontoLetra.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMontoLetra.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMontoLetra.ValorPorDefecto = "";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(134, 102);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(290, 29);
            this.cboFormaPago.TabIndex = 29;
            this.cboFormaPago.SelectedIndexChanged += new System.EventHandler(this.cboFormaPago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Forma Pago:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.autoSenTab = true;
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
            this.txtConcepto.EsBusquedaAutoIncremental = false;
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
            this.txtConcepto.Size = new System.Drawing.Size(880, 72);
            this.txtConcepto.TabIndex = 26;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "0.00";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.autoSenTab = true;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "Beneficiario";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(134, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(729, 33);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "A Nombre:";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.autoSenTab = true;
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
            this.txtMonto.EsBusquedaAutoIncremental = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(134, 60);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(290, 33);
            this.txtMonto.TabIndex = 21;
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
            this.label9.TabIndex = 20;
            this.label9.Text = "El Monto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnAplicarTodo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 44);
            this.panel2.TabIndex = 6;
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
            this.dataGridView1.Size = new System.Drawing.Size(886, 172);
            this.dataGridView1.TabIndex = 7;
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
            // FormCXPPagoR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.Name = "FormCXPPagoR";
            this.SPGraba = "SP_CXP_GRABAR_SOLICITUD_PAGO";
            this.TablaDetalle = "TTEMPORAL_CXP_PAGOS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_CXP_PAGOS";
            this.Text = "APLICAR PAGO A CXP";
            this.Activated += new System.EventHandler(this.FormCXPPagoR_Activated);
            this.Load += new System.EventHandler(this.FormCXPPagoR_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicarTodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_APagar;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtMontoLetra;
        private WinControl_ELR_NET.ELRCombobox cboCuentaBancaria;
    }
}