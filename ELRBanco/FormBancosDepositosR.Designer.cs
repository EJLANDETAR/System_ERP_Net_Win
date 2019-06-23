namespace ELRBanco
{
    partial class FormBancosDepositosR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.cboCuenta = new WinControl_ELR_NET.ELRCombobox();
            this.txtNumero = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarLineaVacia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 489);
            this.pnBotones.Size = new System.Drawing.Size(909, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(669, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(810, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(574, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(479, 39);
            this.lblNombreUsuario.TabIndex = 1;
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
            this.txtMonto.Enabled = false;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsBusquedaAutoIncremental = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(471, 52);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(238, 33);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0";
            // 
            // cboCuenta
            // 
            this.cboCuenta.AValidar = null;
            this.cboCuenta.CampoData = "Cuenta_Id";
            this.cboCuenta.CampoJoinCombobox2 = "";
            this.cboCuenta.ComboboxAFiltrar = null;
            this.cboCuenta.DisplayMember = "Nombre";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.DSData = this.DSDatos;
            this.cboCuenta.EsEditable = true;
            this.cboCuenta.FiltroBusqueda = "";
            this.cboCuenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(159, 91);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.NombreTabla = "";
            this.cboCuenta.Size = new System.Drawing.Size(550, 33);
            this.cboCuenta.SSQL = "";
            this.cboCuenta.TabIndex = 5;
            this.cboCuenta.TablaOVistaConsulta = "TBANCOS_CUENTAS_BANCARIAS";
            this.cboCuenta.UsaDataGlobal = false;
            this.cboCuenta.ValorPorDefecto = "1";
            this.cboCuenta.ValueMember = "Cuenta_Id";
            this.cboCuenta.SelectedValueChanged += new System.EventHandler(this.cboCuenta_SelectedValueChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.AMostrar = null;
            this.txtNumero.AValidar = null;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.CampoBusquedaID = "";
            this.txtNumero.CampoData = "Numero";
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.ColumnasBusqGeneral = null;
            this.txtNumero.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumero.Decimales = 0;
            this.txtNumero.DSData = this.DSDatos;
            this.txtNumero.EsAutoGenerado = false;
            this.txtNumero.EsBusqueda = false;
            this.txtNumero.EsBusquedaAutoIncremental = false;
            this.txtNumero.EsEditable = true;
            this.txtNumero.FiltroBusqueda = "";
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNumero.Location = new System.Drawing.Point(159, 130);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.NombreTabla = "";
            this.txtNumero.SepDecimal = '\0';
            this.txtNumero.Size = new System.Drawing.Size(550, 33);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TablaOVistaBusqueda = "";
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumero.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumero.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumero.ValorPorDefecto = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboCuenta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtConcepto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMonto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 278);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deposito No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuenta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(159, 52);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(200, 33);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 8, 23, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
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
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(159, 170);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(550, 92);
            this.txtConcepto.TabIndex = 9;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Concepto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAgregarLineaVacia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregarLineaVacia
            // 
            this.btnAgregarLineaVacia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarLineaVacia.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarLineaVacia.Name = "btnAgregarLineaVacia";
            this.btnAgregarLineaVacia.Size = new System.Drawing.Size(217, 35);
            this.btnAgregarLineaVacia.TabIndex = 0;
            this.btnAgregarLineaVacia.Text = "Agregar Detalle (Ctrl + N)";
            this.btnAgregarLineaVacia.UseVisualStyleBackColor = true;
            this.btnAgregarLineaVacia.Click += new System.EventHandler(this.btnAgregarLineaVacia_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuenta_Contable,
            this.Codigo_Auxiliar,
            this.Descripcion,
            this.Credito,
            this.ItemNumero,
            this.btnEliminar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(909, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.Visible = false;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cuenta Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.Width = 160;
            // 
            // Codigo_Auxiliar
            // 
            this.Codigo_Auxiliar.DataPropertyName = "Codigo_Auxiliar";
            this.Codigo_Auxiliar.HeaderText = "C.Costo\\Oficina";
            this.Codigo_Auxiliar.Name = "Codigo_Auxiliar";
            this.Codigo_Auxiliar.Width = 130;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle1;
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.Width = 130;
            // 
            // ItemNumero
            // 
            this.ItemNumero.DataPropertyName = "ItemNumero";
            this.ItemNumero.HeaderText = "ItemNumero";
            this.ItemNumero.Name = "ItemNumero";
            this.ItemNumero.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // FormBancosDepositosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtMonto;
            valida1.Mensaje = "El Monto Debe Ser Mayor a Cero";
            valida1.NombreCampo = "Monto";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.cboCuenta;
            valida2.Mensaje = "Debe Elegir Cuenta";
            valida2.NombreCampo = "Cuenta_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtNumero;
            valida3.Mensaje = "Debe Indicar Numero Deposito";
            valida3.NombreCampo = "Numero";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(909, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.Name = "FormBancosDepositosR";
            this.NombreCampoID = "Trans_Id";
            this.SPGraba = "SP_BANCOS_GRABA_TRANS";
            this.TablaDetalle = "TTEMPORAL_BANCOS_TRANS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_BANCOS_TRANS";
            this.Text = "REGISTRAR DEPOSITO BANCARIO";
            this.Load += new System.EventHandler(this.FormBancosDepositosR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRCombobox cboCuenta;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarLineaVacia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private WinControl_ELR_NET.ELRTextBox txtNumero;
        private System.Windows.Forms.Label label1;
    }
}