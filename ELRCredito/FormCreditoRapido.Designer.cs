namespace ELRCredito
{
    partial class FormCreditoRapido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditoRapido));
            WinControl_ELR_NET.MyColumna myColumna1 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna2 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna3 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            this.txtEntidadId = new WinControl_ELR_NET.ELRTextBox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarEntidad = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMetodo = new WinControl_ELR_NET.ELRCombobox();
            this.label7 = new System.Windows.Forms.Label();
            this.elrTextBox2 = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaPrimerPago = new WinControl_ELR_NET.ELRDatePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTasaMensual = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoSaldo = new WinControl_ELR_NET.ELRCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFrecuenciaPago = new WinControl_ELR_NET.ELRCombobox();
            this.txtPlazo = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMontoCuota = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarOficialCredito = new System.Windows.Forms.Button();
            this.lblOficialNombre = new WinControl_ELR_NET.ELRLabel();
            this.txtOficial = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new WinControl_ELR_NET.ELRLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalInteres = new WinControl_ELR_NET.ELRLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalCapital = new WinControl_ELR_NET.ELRLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTasa = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 555);
            this.pnBotones.Size = new System.Drawing.Size(1084, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(844, 0);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(985, 0);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(749, 0);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(654, 39);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // txtEntidadId
            // 
            this.txtEntidadId.AMostrar = null;
            this.txtEntidadId.AValidar = null;
            this.txtEntidadId.CampoBusquedaID = "";
            this.txtEntidadId.CampoData = "";
            this.txtEntidadId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntidadId.ColumnasBusqGeneral = null;
            this.txtEntidadId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEntidadId.Decimales = 0;
            this.txtEntidadId.DSData = null;
            this.txtEntidadId.EsAutoGenerado = false;
            this.txtEntidadId.EsBusqueda = false;
            this.txtEntidadId.EsBusquedaAutoIncremental = false;
            this.txtEntidadId.EsEditable = true;
            this.txtEntidadId.FiltroBusqueda = "";
            this.txtEntidadId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEntidadId.Location = new System.Drawing.Point(14, 28);
            this.txtEntidadId.Name = "txtEntidadId";
            this.txtEntidadId.NombreTabla = "";
            this.txtEntidadId.SepDecimal = '\0';
            this.txtEntidadId.Size = new System.Drawing.Size(125, 29);
            this.txtEntidadId.TabIndex = 0;
            this.txtEntidadId.TablaOVistaBusqueda = "";
            this.txtEntidadId.Text = "0";
            this.txtEntidadId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEntidadId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtEntidadId, "Digite Codigo o CedulaRNC y Presione Enter");
            this.txtEntidadId.ValorPorDefecto = "";
            this.txtEntidadId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntidadId_KeyDown);
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.AValidar = null;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Monto_AProbado";
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
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(143, 42);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(162, 29);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCedulaRNC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscarEntidad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtEntidadId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Cliente";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.BackColor = System.Drawing.Color.White;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = null;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(759, 28);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.ReadOnly = true;
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(162, 29);
            this.txtCedulaRNC.TabIndex = 4;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cedula\\RNC:";
            // 
            // btnBuscarEntidad
            // 
            this.btnBuscarEntidad.Image = global::ELRCredito.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscarEntidad.Location = new System.Drawing.Point(145, 28);
            this.btnBuscarEntidad.Name = "btnBuscarEntidad";
            this.btnBuscarEntidad.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEntidad.TabIndex = 1;
            this.btnBuscarEntidad.UseVisualStyleBackColor = true;
            this.btnBuscarEntidad.Click += new System.EventHandler(this.btnBuscarEntidad_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = null;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(193, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(422, 29);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtTasa);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboMetodo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.elrTextBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaPrimerPago);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtTasaMensual);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTipoSaldo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboFrecuenciaPago);
            this.panel1.Controls.Add(this.txtPlazo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 163);
            this.panel1.TabIndex = 1;
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "Tipo_Garantia_Id";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DisplayMember = "Descripcion";
            this.cboTipo.DSData = null;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "EsActivo = 1";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(142, 7);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(586, 29);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 1;
            this.cboTipo.TablaOVistaConsulta = "TPRESTAMOS_TIPO_GARANTIAS";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "P";
            this.cboTipo.ValueMember = "Tipo_Garantia_Id";
            this.cboTipo.SelectedValueChanged += new System.EventHandler(this.cboTipo_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tipo:";
            // 
            // cboMetodo
            // 
            this.cboMetodo.AValidar = null;
            this.cboMetodo.CampoData = "";
            this.cboMetodo.CampoJoinCombobox2 = "";
            this.cboMetodo.ComboboxAFiltrar = null;
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.DSData = null;
            this.cboMetodo.EsEditable = true;
            this.cboMetodo.FiltroBusqueda = "";
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "INTERES SIMPLE",
            "INTERES AMORTIZADO"});
            this.cboMetodo.Location = new System.Drawing.Point(445, 112);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.NombreTabla = "";
            this.cboMetodo.Size = new System.Drawing.Size(215, 29);
            this.cboMetodo.SSQL = "";
            this.cboMetodo.TabIndex = 20;
            this.cboMetodo.TablaOVistaConsulta = "";
            this.cboMetodo.UsaDataGlobal = false;
            this.cboMetodo.ValorPorDefecto = "S";
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Metodo:";
            // 
            // elrTextBox2
            // 
            this.elrTextBox2.AMostrar = null;
            this.elrTextBox2.AValidar = null;
            this.elrTextBox2.CampoBusquedaID = "";
            this.elrTextBox2.CampoData = "Numero";
            this.elrTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox2.ColumnasBusqGeneral = null;
            this.elrTextBox2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox2.Decimales = 0;
            this.elrTextBox2.DSData = this.DSDatos;
            this.elrTextBox2.EsAutoGenerado = false;
            this.elrTextBox2.EsBusqueda = false;
            this.elrTextBox2.EsBusquedaAutoIncremental = false;
            this.elrTextBox2.EsEditable = true;
            this.elrTextBox2.FiltroBusqueda = "";
            this.elrTextBox2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox2.Location = new System.Drawing.Point(143, 112);
            this.elrTextBox2.Name = "elrTextBox2";
            this.elrTextBox2.NombreTabla = "";
            this.elrTextBox2.SepDecimal = '\0';
            this.elrTextBox2.Size = new System.Drawing.Size(162, 29);
            this.elrTextBox2.TabIndex = 18;
            this.elrTextBox2.TablaOVistaBusqueda = "";
            this.elrTextBox2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox2.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Referencia No.:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(445, 42);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(215, 29);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 3, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // dtpFechaPrimerPago
            // 
            this.dtpFechaPrimerPago.AValidar = null;
            this.dtpFechaPrimerPago.CampoData = "Fecha_Primer_Pago";
            this.dtpFechaPrimerPago.DSData = this.DSDatos;
            this.dtpFechaPrimerPago.EsEditable = true;
            this.dtpFechaPrimerPago.FiltroBusqueda = "";
            this.dtpFechaPrimerPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrimerPago.Location = new System.Drawing.Point(799, 74);
            this.dtpFechaPrimerPago.Name = "dtpFechaPrimerPago";
            this.dtpFechaPrimerPago.NombreTabla = "";
            this.dtpFechaPrimerPago.Size = new System.Drawing.Size(269, 29);
            this.dtpFechaPrimerPago.TabIndex = 16;
            this.dtpFechaPrimerPago.ValorPorDefecto = new System.DateTime(2016, 3, 7, 0, 0, 0, 0);
            this.dtpFechaPrimerPago.ValueChanged += new System.EventHandler(this.dtpFechaPrimerPago_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(683, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fecha Pr. Pago";
            // 
            // txtTasaMensual
            // 
            this.txtTasaMensual.AMostrar = null;
            this.txtTasaMensual.AValidar = null;
            this.txtTasaMensual.CampoBusquedaID = "";
            this.txtTasaMensual.CampoData = "";
            this.txtTasaMensual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaMensual.ColumnasBusqGeneral = null;
            this.txtTasaMensual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaMensual.Decimales = 0;
            this.txtTasaMensual.DSData = null;
            this.txtTasaMensual.EsAutoGenerado = false;
            this.txtTasaMensual.EsBusqueda = false;
            this.txtTasaMensual.EsBusquedaAutoIncremental = false;
            this.txtTasaMensual.EsEditable = true;
            this.txtTasaMensual.FiltroBusqueda = "";
            this.txtTasaMensual.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtTasaMensual.Location = new System.Drawing.Point(445, 77);
            this.txtTasaMensual.Name = "txtTasaMensual";
            this.txtTasaMensual.NombreTabla = "";
            this.txtTasaMensual.SepDecimal = '\0';
            this.txtTasaMensual.Size = new System.Drawing.Size(72, 29);
            this.txtTasaMensual.TabIndex = 12;
            this.txtTasaMensual.TablaOVistaBusqueda = "";
            this.txtTasaMensual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaMensual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaMensual.ValorPorDefecto = "48";
            this.txtTasaMensual.Leave += new System.EventHandler(this.txtTasaMensual_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "% Tasa Mensual";
            // 
            // cboTipoSaldo
            // 
            this.cboTipoSaldo.AValidar = null;
            this.cboTipoSaldo.CampoData = "Tipo_Saldo";
            this.cboTipoSaldo.CampoJoinCombobox2 = "";
            this.cboTipoSaldo.ComboboxAFiltrar = null;
            this.cboTipoSaldo.DisplayMember = "Descripcion";
            this.cboTipoSaldo.DSData = this.DSDatos;
            this.cboTipoSaldo.EsEditable = true;
            this.cboTipoSaldo.FiltroBusqueda = "EsActivo = 1 and Nombre_Tabla = \'TIPO_SALDO\'";
            this.cboTipoSaldo.FormattingEnabled = true;
            this.cboTipoSaldo.Location = new System.Drawing.Point(142, 77);
            this.cboTipoSaldo.Name = "cboTipoSaldo";
            this.cboTipoSaldo.NombreTabla = "";
            this.cboTipoSaldo.Size = new System.Drawing.Size(163, 29);
            this.cboTipoSaldo.SSQL = "";
            this.cboTipoSaldo.TabIndex = 10;
            this.cboTipoSaldo.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboTipoSaldo.UsaDataGlobal = true;
            this.cboTipoSaldo.ValorPorDefecto = "S";
            this.cboTipoSaldo.ValueMember = "Id";
            this.cboTipoSaldo.SelectedValueChanged += new System.EventHandler(this.cboTipoSaldo_SelectedValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo Saldo";
            // 
            // cboFrecuenciaPago
            // 
            this.cboFrecuenciaPago.AValidar = null;
            this.cboFrecuenciaPago.CampoData = "Frecuencia_Pago";
            this.cboFrecuenciaPago.CampoJoinCombobox2 = "";
            this.cboFrecuenciaPago.ComboboxAFiltrar = null;
            this.cboFrecuenciaPago.DisplayMember = "Descripcion";
            this.cboFrecuenciaPago.DSData = this.DSDatos;
            this.cboFrecuenciaPago.EsEditable = true;
            this.cboFrecuenciaPago.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'FRECUENCIA_PAGO\'";
            this.cboFrecuenciaPago.FormattingEnabled = true;
            this.cboFrecuenciaPago.Location = new System.Drawing.Point(885, 39);
            this.cboFrecuenciaPago.Name = "cboFrecuenciaPago";
            this.cboFrecuenciaPago.NombreTabla = "";
            this.cboFrecuenciaPago.Size = new System.Drawing.Size(183, 29);
            this.cboFrecuenciaPago.SSQL = "";
            this.cboFrecuenciaPago.TabIndex = 8;
            this.cboFrecuenciaPago.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboFrecuenciaPago.UsaDataGlobal = true;
            this.cboFrecuenciaPago.ValorPorDefecto = "M";
            this.cboFrecuenciaPago.ValueMember = "iD";
            this.cboFrecuenciaPago.SelectedValueChanged += new System.EventHandler(this.cboFrecuenciaPago_SelectedValueChanged);
            // 
            // txtPlazo
            // 
            this.txtPlazo.AMostrar = null;
            this.txtPlazo.AValidar = null;
            this.txtPlazo.CampoBusquedaID = "";
            this.txtPlazo.CampoData = "Plazo";
            this.txtPlazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlazo.ColumnasBusqGeneral = null;
            this.txtPlazo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPlazo.Decimales = 0;
            this.txtPlazo.DSData = this.DSDatos;
            this.txtPlazo.EsAutoGenerado = false;
            this.txtPlazo.EsBusqueda = false;
            this.txtPlazo.EsBusquedaAutoIncremental = false;
            this.txtPlazo.EsEditable = true;
            this.txtPlazo.FiltroBusqueda = "";
            this.txtPlazo.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtPlazo.Location = new System.Drawing.Point(799, 39);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.NombreTabla = "";
            this.txtPlazo.SepDecimal = '\0';
            this.txtPlazo.Size = new System.Drawing.Size(80, 29);
            this.txtPlazo.TabIndex = 7;
            this.txtPlazo.TablaOVistaBusqueda = "";
            this.txtPlazo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPlazo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPlazo.ValorPorDefecto = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(683, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Plazo o Cuotas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto Prestado:";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.ItemNumero,
            this.Cuota_No,
            this.Fecha,
            this.Concepto,
            this.Saldo_Inicial,
            this.Capital,
            this.Interes,
            this.Saldo_Final});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 233);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.Size = new System.Drawing.Size(1084, 170);
            this.dtgDetalle.TabIndex = 2;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            this.Unico.Width = 105;
            // 
            // ItemNumero
            // 
            this.ItemNumero.DataPropertyName = "ItemNumero";
            this.ItemNumero.HeaderText = "Item";
            this.ItemNumero.Name = "ItemNumero";
            this.ItemNumero.ReadOnly = true;
            this.ItemNumero.Visible = false;
            // 
            // Cuota_No
            // 
            this.Cuota_No.DataPropertyName = "Cuota_No";
            this.Cuota_No.HeaderText = "No";
            this.Cuota_No.Name = "Cuota_No";
            this.Cuota_No.ReadOnly = true;
            this.Cuota_No.Width = 70;
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
            this.Fecha.Width = 120;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Saldo_Inicial
            // 
            this.Saldo_Inicial.DataPropertyName = "Saldo_Inicial";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Saldo_Inicial.DefaultCellStyle = dataGridViewCellStyle2;
            this.Saldo_Inicial.HeaderText = "Saldo Inicial";
            this.Saldo_Inicial.Name = "Saldo_Inicial";
            this.Saldo_Inicial.ReadOnly = true;
            this.Saldo_Inicial.Width = 140;
            // 
            // Capital
            // 
            this.Capital.DataPropertyName = "Capital";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Capital.DefaultCellStyle = dataGridViewCellStyle3;
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Width = 130;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Interes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Width = 130;
            // 
            // Saldo_Final
            // 
            this.Saldo_Final.DataPropertyName = "Saldo_Final";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Saldo_Final.DefaultCellStyle = dataGridViewCellStyle5;
            this.Saldo_Final.HeaderText = "Saldo Final";
            this.Saldo_Final.Name = "Saldo_Final";
            this.Saldo_Final.ReadOnly = true;
            this.Saldo_Final.Width = 140;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMontoCuota);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.lblTotalInteres);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.lblTotalCapital);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 152);
            this.panel3.TabIndex = 3;
            // 
            // lblMontoCuota
            // 
            this.lblMontoCuota.AutoSize = true;
            this.lblMontoCuota.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCuota.ForeColor = System.Drawing.Color.Blue;
            this.lblMontoCuota.Location = new System.Drawing.Point(96, 107);
            this.lblMontoCuota.Name = "lblMontoCuota";
            this.lblMontoCuota.Size = new System.Drawing.Size(64, 32);
            this.lblMontoCuota.TabIndex = 7;
            this.lblMontoCuota.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(17, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cuota";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarOficialCredito);
            this.groupBox3.Controls.Add(this.lblOficialNombre);
            this.groupBox3.Controls.Add(this.txtOficial);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboOficina);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(304, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 152);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Zonificacion";
            // 
            // btnBuscarOficialCredito
            // 
            this.btnBuscarOficialCredito.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOficialCredito.Image")));
            this.btnBuscarOficialCredito.Location = new System.Drawing.Point(330, 65);
            this.btnBuscarOficialCredito.Name = "btnBuscarOficialCredito";
            this.btnBuscarOficialCredito.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarOficialCredito.TabIndex = 4;
            this.btnBuscarOficialCredito.UseVisualStyleBackColor = true;
            this.btnBuscarOficialCredito.Click += new System.EventHandler(this.btnBuscarOficialCredito_Click);
            // 
            // lblOficialNombre
            // 
            this.lblOficialNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOficialNombre.CampoData = "Oficial_Nombre";
            this.lblOficialNombre.DSData = this.DSDatos;
            this.lblOficialNombre.Location = new System.Drawing.Point(378, 65);
            this.lblOficialNombre.Name = "lblOficialNombre";
            this.lblOficialNombre.NombreTabla = "";
            this.lblOficialNombre.Size = new System.Drawing.Size(378, 33);
            this.lblOficialNombre.TabIndex = 5;
            this.lblOficialNombre.Text = "NOMBRES Y APELLIDOS";
            this.lblOficialNombre.ValorPorDefecto = "";
            // 
            // txtOficial
            // 
            this.txtOficial.AMostrar = new WinControl_ELR_NET.ControlesMostrar[0];
            this.txtOficial.AValidar = null;
            this.txtOficial.CampoBusquedaID = "Empleado_Id";
            this.txtOficial.CampoData = "Evaluador_Id";
            this.txtOficial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            myColumna1.Ancho = 120;
            myColumna1.Formato = "";
            myColumna1.HeaderText = "Codigo";
            myColumna1.NombreCampo = "Empleado_Id";
            myColumna2.Ancho = 130;
            myColumna2.Formato = "";
            myColumna2.HeaderText = "CedulaRNC";
            myColumna2.NombreCampo = "CedulaRNC";
            myColumna3.Ancho = 300;
            myColumna3.Formato = "";
            myColumna3.HeaderText = "Nombre";
            myColumna3.NombreCampo = "Nombre_Completo";
            this.txtOficial.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[] {
        myColumna1,
        myColumna2,
        myColumna3};
            this.txtOficial.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtOficial.Decimales = 0;
            this.txtOficial.DSData = this.DSDatos;
            this.txtOficial.EsAutoGenerado = false;
            this.txtOficial.EsBusqueda = false;
            this.txtOficial.EsBusquedaAutoIncremental = false;
            this.txtOficial.EsEditable = true;
            this.txtOficial.FiltroBusqueda = "";
            this.txtOficial.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtOficial.Location = new System.Drawing.Point(163, 65);
            this.txtOficial.Name = "txtOficial";
            this.txtOficial.NombreTabla = "";
            this.txtOficial.SepDecimal = '\0';
            this.txtOficial.Size = new System.Drawing.Size(161, 33);
            this.txtOficial.TabIndex = 3;
            this.txtOficial.TablaOVistaBusqueda = "";
            this.txtOficial.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtOficial.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtOficial.ValorPorDefecto = "0";
            this.txtOficial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOficial_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Oficial Credito";
            // 
            // cboOficina
            // 
            this.cboOficina.AValidar = null;
            this.cboOficina.CampoData = "Oficina_Id";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DisplayMember = "Nombre";
            this.cboOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficina.DSData = this.DSDatos;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "EsActivo = 1";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(163, 26);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(593, 33);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 2;
            this.cboOficina.TablaOVistaConsulta = "TEMPRESAS_OFICINAS";
            this.cboOficina.UsaDataGlobal = true;
            this.cboOficina.ValorPorDefecto = "0";
            this.cboOficina.ValueMember = "Oficina_Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Oficina";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.CampoData = "";
            this.lblTotal.DSData = null;
            this.lblTotal.Location = new System.Drawing.Point(96, 77);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.NombreTabla = "";
            this.lblTotal.Size = new System.Drawing.Size(50, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0.00";
            this.lblTotal.ValorPorDefecto = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "Total";
            // 
            // lblTotalInteres
            // 
            this.lblTotalInteres.AutoSize = true;
            this.lblTotalInteres.CampoData = "";
            this.lblTotalInteres.DSData = null;
            this.lblTotalInteres.Location = new System.Drawing.Point(96, 42);
            this.lblTotalInteres.Name = "lblTotalInteres";
            this.lblTotalInteres.NombreTabla = "";
            this.lblTotalInteres.Size = new System.Drawing.Size(50, 25);
            this.lblTotalInteres.TabIndex = 3;
            this.lblTotalInteres.Text = "0.00";
            this.lblTotalInteres.ValorPorDefecto = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Interes";
            // 
            // lblTotalCapital
            // 
            this.lblTotalCapital.AutoSize = true;
            this.lblTotalCapital.CampoData = "";
            this.lblTotalCapital.DSData = null;
            this.lblTotalCapital.Location = new System.Drawing.Point(96, 7);
            this.lblTotalCapital.Name = "lblTotalCapital";
            this.lblTotalCapital.NombreTabla = "";
            this.lblTotalCapital.Size = new System.Drawing.Size(50, 25);
            this.lblTotalCapital.TabIndex = 1;
            this.lblTotalCapital.Text = "0.00";
            this.lblTotalCapital.ValorPorDefecto = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Capital";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(532, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 21);
            this.label17.TabIndex = 13;
            this.label17.Text = "Anual";
            // 
            // txtTasa
            // 
            this.txtTasa.AMostrar = null;
            this.txtTasa.AValidar = null;
            this.txtTasa.CampoBusquedaID = "";
            this.txtTasa.CampoData = "Tasa_Interes";
            this.txtTasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasa.ColumnasBusqGeneral = null;
            this.txtTasa.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasa.Decimales = 0;
            this.txtTasa.DSData = this.DSDatos;
            this.txtTasa.EsAutoGenerado = false;
            this.txtTasa.EsBusqueda = false;
            this.txtTasa.EsBusquedaAutoIncremental = false;
            this.txtTasa.EsEditable = true;
            this.txtTasa.FiltroBusqueda = "";
            this.txtTasa.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtTasa.Location = new System.Drawing.Point(588, 77);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.NombreTabla = "";
            this.txtTasa.SepDecimal = '\0';
            this.txtTasa.Size = new System.Drawing.Size(72, 29);
            this.txtTasa.TabIndex = 14;
            this.txtTasa.TablaOVistaBusqueda = "";
            this.txtTasa.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasa.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasa.ValorPorDefecto = "48";
            this.txtTasa.Leave += new System.EventHandler(this.txtTasa_Leave);
            // 
            // FormCreditoRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtEntidadId;
            valida1.Mensaje = "Debe elegir Cliente";
            valida1.NombreCampo = "Entidad_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtMonto;
            valida2.Mensaje = "El Monto a Prestar debe ser Mayor a Cero";
            valida2.NombreCampo = "Monto_Prestamo";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(1084, 598);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.PreviewRDLC;
            this.ImprimirAlGrabar = true;
            this.Name = "FormCreditoRapido";
            this.NuevoRegistroAlGrabar = true;
            this.SPGraba = "SP_PRESTAMOS_REGISTRAR_CREDITO";
            this.TablaDetalle = "TTEMPORAL_PRESTAMOS_AMORTIZACION_DETALLE";
            this.TablaEncabezado = "TTEMPORAL_PRESTAMOS_AMORTIZACION";
            this.Text = "GENERAR CREDITO RAPIDO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCreditoRapido_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEntidad;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRTextBox txtEntidadId;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRCombobox cboMetodo;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox elrTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRDatePicker dtpFechaPrimerPago;
        private System.Windows.Forms.Label label13;
        private WinControl_ELR_NET.ELRTextBox txtTasaMensual;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRCombobox cboTipoSaldo;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboFrecuenciaPago;
        private WinControl_ELR_NET.ELRTextBox txtPlazo;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMontoCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarOficialCredito;
        private WinControl_ELR_NET.ELRLabel lblOficialNombre;
        private WinControl_ELR_NET.ELRTextBox txtOficial;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRCombobox cboOficina;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRLabel lblTotal;
        private System.Windows.Forms.Label label16;
        private WinControl_ELR_NET.ELRLabel lblTotalInteres;
        private System.Windows.Forms.Label label15;
        private WinControl_ELR_NET.ELRLabel lblTotalCapital;
        private System.Windows.Forms.Label label14;
        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Final;
        private WinControl_ELR_NET.ELRTextBox txtTasa;
        private System.Windows.Forms.Label label17;
    }
}