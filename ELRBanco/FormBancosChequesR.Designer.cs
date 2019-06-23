namespace ELRBanco
{
    partial class FormBancosChequesR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.cboCuenta = new WinControl_ELR_NET.ELRCombobox();
            this.txtBeneficiario = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtChequeNo = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarLineaVacia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnBotones.Location = new System.Drawing.Point(0, 518);
            this.pnBotones.Size = new System.Drawing.Size(957, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(717, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(858, 0);
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
            this.btnSiguientePage.Location = new System.Drawing.Point(622, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(527, 39);
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
            this.txtMonto.Location = new System.Drawing.Point(719, 53);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(195, 33);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "";
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
            this.cboCuenta.Location = new System.Drawing.Point(140, 91);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.NombreTabla = "";
            this.cboCuenta.Size = new System.Drawing.Size(444, 33);
            this.cboCuenta.SSQL = "";
            this.cboCuenta.TabIndex = 5;
            this.cboCuenta.TablaOVistaConsulta = "TBANCOS_CUENTAS_BANCARIAS";
            this.cboCuenta.UsaDataGlobal = false;
            this.cboCuenta.ValorPorDefecto = "1";
            this.cboCuenta.ValueMember = "Cuenta_Id";
            this.cboCuenta.SelectedValueChanged += new System.EventHandler(this.cboCuenta_SelectedValueChanged);
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
            this.txtBeneficiario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeneficiario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtBeneficiario.Location = new System.Drawing.Point(140, 131);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.NombreTabla = "";
            this.txtBeneficiario.SepDecimal = '\0';
            this.txtBeneficiario.Size = new System.Drawing.Size(774, 33);
            this.txtBeneficiario.TabIndex = 7;
            this.txtBeneficiario.TablaOVistaBusqueda = "";
            this.txtBeneficiario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtBeneficiario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtBeneficiario.ValorPorDefecto = "";
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
            this.txtConcepto.Location = new System.Drawing.Point(140, 170);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(774, 92);
            this.txtConcepto.TabIndex = 9;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtChequeNo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboCuenta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtConcepto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMonto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBeneficiario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 270);
            this.panel2.TabIndex = 2;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.AMostrar = null;
            this.txtChequeNo.AValidar = null;
            this.txtChequeNo.BackColor = System.Drawing.Color.White;
            this.txtChequeNo.CampoBusquedaID = "";
            this.txtChequeNo.CampoData = "Numero";
            this.txtChequeNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequeNo.ColumnasBusqGeneral = null;
            this.txtChequeNo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtChequeNo.Decimales = 0;
            this.txtChequeNo.DSData = this.DSDatos;
            this.txtChequeNo.Enabled = false;
            this.txtChequeNo.EsAutoGenerado = false;
            this.txtChequeNo.EsBusqueda = false;
            this.txtChequeNo.EsBusquedaAutoIncremental = false;
            this.txtChequeNo.EsEditable = true;
            this.txtChequeNo.FiltroBusqueda = "";
            this.txtChequeNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtChequeNo.Location = new System.Drawing.Point(719, 91);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.NombreTabla = "";
            this.txtChequeNo.SepDecimal = '\0';
            this.txtChequeNo.Size = new System.Drawing.Size(195, 33);
            this.txtChequeNo.TabIndex = 11;
            this.txtChequeNo.TablaOVistaBusqueda = "";
            this.txtChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChequeNo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtChequeNo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtChequeNo.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(590, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cheque No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 89);
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
            this.dtpFecha.Location = new System.Drawing.Point(140, 52);
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
            this.label4.Location = new System.Drawing.Point(67, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Concepto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Beneficiario:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAgregarLineaVacia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 39);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(217, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Borrar Linea";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLineaVacia
            // 
            this.btnAgregarLineaVacia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarLineaVacia.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarLineaVacia.Name = "btnAgregarLineaVacia";
            this.btnAgregarLineaVacia.Size = new System.Drawing.Size(217, 39);
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
            this.Debito,
            this.Credito,
            this.ItemNumero,
            this.btnEliminar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(957, 248);
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
            // Debito
            // 
            this.Debito.DataPropertyName = "Debito";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Debito.DefaultCellStyle = dataGridViewCellStyle1;
            this.Debito.HeaderText = "Debito";
            this.Debito.Name = "Debito";
            this.Debito.Width = 130;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle2;
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
            // FormBancosChequesR
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
            valida2.Mensaje = "Debe Elegir una Cuenta Banco";
            valida2.NombreCampo = "Cuenta_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtBeneficiario;
            valida3.Mensaje = "Debe Indicar el Beneficiario";
            valida3.NombreCampo = "Beneficiario";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida3.Valor1 = "5";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtConcepto;
            valida4.Mensaje = "Debe Indicar un Concepto";
            valida4.NombreCampo = "Concepto";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida4.Valor1 = "10";
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(957, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EnEjecusion = true;
            this.EsConTemporal = true;
            this.Name = "FormBancosChequesR";
            this.NombreCampoID = "Trans_Id";
            this.SPGraba = "SP_BANCOS_GRABA_TRANS";
            this.TablaDetalle = "TTEMPORAL_BANCOS_TRANS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_BANCOS_TRANS";
            this.Text = "REGISTRO DE CHEQUE";
            this.Load += new System.EventHandler(this.FormBancosChequesR_Load);
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
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtBeneficiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregarLineaVacia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinControl_ELR_NET.ELRCombobox cboCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private WinControl_ELR_NET.ELRTextBox txtChequeNo;
        private System.Windows.Forms.Label label6;
    }
}