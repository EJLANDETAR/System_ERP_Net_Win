namespace ELRCuentasPorPagar
{
    partial class FormGastosMenoresR
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
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            this.btnElegirBeneficiario = new System.Windows.Forms.Button();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.txtTotalItbis = new WinControl_ELR_NET.ELRTextBox();
            this.cboTipoGastos = new WinControl_ELR_NET.ELRCombobox();
            this.panelEnc = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCedulaRNC = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCF = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCentroCosto = new System.Windows.Forms.Button();
            this.btnVerPanelDetalle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSubTotal = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panelEnc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 568);
            this.pnBotones.Size = new System.Drawing.Size(1046, 64);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(768, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 60);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(909, 0);
            this.btnCancelar.Size = new System.Drawing.Size(133, 60);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 60);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(673, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 60);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(578, 60);
            // 
            // btnElegirBeneficiario
            // 
            this.btnElegirBeneficiario.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnElegirBeneficiario.Location = new System.Drawing.Point(19, 28);
            this.btnElegirBeneficiario.Name = "btnElegirBeneficiario";
            this.btnElegirBeneficiario.Size = new System.Drawing.Size(330, 47);
            this.btnElegirBeneficiario.TabIndex = 0;
            this.btnElegirBeneficiario.Text = "Elegir Beneficiario";
            this.btnElegirBeneficiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElegirBeneficiario.UseVisualStyleBackColor = true;
            this.btnElegirBeneficiario.Click += new System.EventHandler(this.btnElegirBeneficiario_Click);
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.autoSenTab = true;
            this.txtConcepto.AValidar = null;
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
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(3, 25);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(627, 146);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.autoSenTab = true;
            this.txtMonto.AValidar = null;
            this.txtMonto.BackColor = System.Drawing.Color.White;
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
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtMonto.Location = new System.Drawing.Point(147, 104);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(247, 39);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            // 
            // txtTotalItbis
            // 
            this.txtTotalItbis.AMostrar = null;
            this.txtTotalItbis.autoSenTab = true;
            this.txtTotalItbis.AValidar = null;
            this.txtTotalItbis.BackColor = System.Drawing.Color.White;
            this.txtTotalItbis.CampoBusquedaID = "";
            this.txtTotalItbis.CampoData = "Itbis";
            this.txtTotalItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalItbis.ColumnasBusqGeneral = null;
            this.txtTotalItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotalItbis.Decimales = 2;
            this.txtTotalItbis.DSData = this.DSDatos;
            this.txtTotalItbis.EsAutoGenerado = false;
            this.txtTotalItbis.EsBusqueda = false;
            this.txtTotalItbis.EsBusquedaAutoIncremental = false;
            this.txtTotalItbis.EsEditable = true;
            this.txtTotalItbis.FiltroBusqueda = "";
            this.txtTotalItbis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItbis.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtTotalItbis.Location = new System.Drawing.Point(147, 59);
            this.txtTotalItbis.Name = "txtTotalItbis";
            this.txtTotalItbis.NombreTabla = "";
            this.txtTotalItbis.SepDecimal = '\0';
            this.txtTotalItbis.Size = new System.Drawing.Size(247, 39);
            this.txtTotalItbis.TabIndex = 3;
            this.txtTotalItbis.TablaOVistaBusqueda = "";
            this.txtTotalItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotalItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotalItbis.ValorPorDefecto = "0.00";
            // 
            // cboTipoGastos
            // 
            this.cboTipoGastos.AValidar = null;
            this.cboTipoGastos.CampoData = "Tipo_Gastos_DGII";
            this.cboTipoGastos.CampoJoinCombobox2 = "";
            this.cboTipoGastos.ComboboxAFiltrar = null;
            this.cboTipoGastos.DisplayMember = "Descripcion";
            this.cboTipoGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoGastos.DSData = this.DSDatos;
            this.cboTipoGastos.EsEditable = true;
            this.cboTipoGastos.FiltroBusqueda = "EsActivo = 1";
            this.cboTipoGastos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoGastos.FormattingEnabled = true;
            this.cboTipoGastos.Location = new System.Drawing.Point(137, 13);
            this.cboTipoGastos.Name = "cboTipoGastos";
            this.cboTipoGastos.NombreTabla = "";
            this.cboTipoGastos.Size = new System.Drawing.Size(496, 36);
            this.cboTipoGastos.SSQL = "";
            this.cboTipoGastos.TabIndex = 1;
            this.cboTipoGastos.TablaOVistaConsulta = " TSISTEMA_TIPOS_GASTOS_DGII";
            this.cboTipoGastos.UsaDataGlobal = false;
            this.cboTipoGastos.ValorPorDefecto = "7";
            this.cboTipoGastos.ValueMember = "Tipo_Id";
            // 
            // panelEnc
            // 
            this.panelEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEnc.Controls.Add(this.groupBox2);
            this.panelEnc.Controls.Add(this.panel4);
            this.panelEnc.Controls.Add(this.panel5);
            this.panelEnc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEnc.Location = new System.Drawing.Point(0, 0);
            this.panelEnc.Name = "panelEnc";
            this.panelEnc.Size = new System.Drawing.Size(1046, 281);
            this.panelEnc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnElegirBeneficiario);
            this.groupBox2.Controls.Add(this.lblCedulaRNC);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beneficiario";
            // 
            // lblCedulaRNC
            // 
            this.lblCedulaRNC.AutoSize = true;
            this.lblCedulaRNC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaRNC.Location = new System.Drawing.Point(14, 112);
            this.lblCedulaRNC.Name = "lblCedulaRNC";
            this.lblCedulaRNC.Size = new System.Drawing.Size(265, 25);
            this.lblCedulaRNC.TabIndex = 2;
            this.lblCedulaRNC.Text = "Cedula o RNC: 00000000000";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(335, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre o Razon Social: Beneficiario";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNCF);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cboTipoGastos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1042, 61);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo gastos:";
            // 
            // txtNCF
            // 
            this.txtNCF.AMostrar = null;
            this.txtNCF.autoSenTab = true;
            this.txtNCF.AValidar = null;
            this.txtNCF.BackColor = System.Drawing.Color.White;
            this.txtNCF.CampoBusquedaID = "";
            this.txtNCF.CampoData = "NCF";
            this.txtNCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNCF.ColumnasBusqGeneral = null;
            this.txtNCF.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNCF.Decimales = 2;
            this.txtNCF.DSData = this.DSDatos;
            this.txtNCF.EsAutoGenerado = false;
            this.txtNCF.EsBusqueda = false;
            this.txtNCF.EsBusquedaAutoIncremental = false;
            this.txtNCF.EsEditable = true;
            this.txtNCF.FiltroBusqueda = "";
            this.txtNCF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCF.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNCF.Location = new System.Drawing.Point(730, 12);
            this.txtNCF.Name = "txtNCF";
            this.txtNCF.NombreTabla = "";
            this.txtNCF.ReadOnly = true;
            this.txtNCF.SepDecimal = '\0';
            this.txtNCF.Size = new System.Drawing.Size(173, 35);
            this.txtNCF.TabIndex = 3;
            this.txtNCF.TablaOVistaBusqueda = "";
            this.txtNCF.Text = "B1300000000";
            this.txtNCF.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNCF.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNCF.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "NCF:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnCentroCosto);
            this.panel5.Controls.Add(this.btnVerPanelDetalle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 52);
            this.panel5.TabIndex = 19;
            // 
            // btnCentroCosto
            // 
            this.btnCentroCosto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCentroCosto.Location = new System.Drawing.Point(210, 0);
            this.btnCentroCosto.Name = "btnCentroCosto";
            this.btnCentroCosto.Size = new System.Drawing.Size(156, 48);
            this.btnCentroCosto.TabIndex = 1;
            this.btnCentroCosto.Text = "C.Costo\\Oficina";
            this.btnCentroCosto.UseVisualStyleBackColor = true;
            this.btnCentroCosto.Click += new System.EventHandler(this.btnCentroCosto_Click);
            // 
            // btnVerPanelDetalle
            // 
            this.btnVerPanelDetalle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerPanelDetalle.Location = new System.Drawing.Point(0, 0);
            this.btnVerPanelDetalle.Name = "btnVerPanelDetalle";
            this.btnVerPanelDetalle.Size = new System.Drawing.Size(210, 48);
            this.btnVerPanelDetalle.TabIndex = 0;
            this.btnVerPanelDetalle.Text = "Agregar Detalle Ctrl + N";
            this.btnVerPanelDetalle.UseVisualStyleBackColor = true;
            this.btnVerPanelDetalle.Click += new System.EventHandler(this.btnVerPanelDetalle_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 178);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtSubTotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtTotalItbis);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(633, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 174);
            this.panel3.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.AMostrar = null;
            this.txtSubTotal.autoSenTab = true;
            this.txtSubTotal.AValidar = null;
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.CampoBusquedaID = "";
            this.txtSubTotal.CampoData = "Sub_Total";
            this.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTotal.ColumnasBusqGeneral = null;
            this.txtSubTotal.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSubTotal.Decimales = 2;
            this.txtSubTotal.DSData = this.DSDatos;
            this.txtSubTotal.EsAutoGenerado = false;
            this.txtSubTotal.EsBusqueda = false;
            this.txtSubTotal.EsBusquedaAutoIncremental = false;
            this.txtSubTotal.EsEditable = true;
            this.txtSubTotal.FiltroBusqueda = "";
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtSubTotal.Location = new System.Drawing.Point(147, 14);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.NombreTabla = "";
            this.txtSubTotal.SepDecimal = '\0';
            this.txtSubTotal.Size = new System.Drawing.Size(247, 39);
            this.txtSubTotal.TabIndex = 5;
            this.txtSubTotal.TablaOVistaBusqueda = "";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSubTotal.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSubTotal.ValorPorDefecto = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sub Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Itbis:";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuenta_Contable,
            this.Descripcion,
            this.Itbis,
            this.Total,
            this.ItemNumero,
            this.Descripcion_Cuenta,
            this.bnBorrar});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 281);
            this.dtgDetalle.MultiSelect = false;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.RowTemplate.Height = 35;
            this.dtgDetalle.Size = new System.Drawing.Size(1046, 109);
            this.dtgDetalle.TabIndex = 1;
            this.dtgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalle_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cta. Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 220;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Itbis
            // 
            this.Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Itbis.DefaultCellStyle = dataGridViewCellStyle1;
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Itbis.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Monto";
            this.Total.Name = "Total";
            this.Total.Width = 170;
            // 
            // ItemNumero
            // 
            this.ItemNumero.DataPropertyName = "ItemNumero";
            this.ItemNumero.HeaderText = "ItemNumero";
            this.ItemNumero.Name = "ItemNumero";
            this.ItemNumero.ReadOnly = true;
            this.ItemNumero.Visible = false;
            // 
            // Descripcion_Cuenta
            // 
            this.Descripcion_Cuenta.DataPropertyName = "Descripcion_Cuenta";
            this.Descripcion_Cuenta.HeaderText = "Descripcion_Cuenta";
            this.Descripcion_Cuenta.Name = "Descripcion_Cuenta";
            this.Descripcion_Cuenta.Visible = false;
            // 
            // bnBorrar
            // 
            this.bnBorrar.HeaderText = "Borrar";
            this.bnBorrar.Name = "bnBorrar";
            this.bnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bnBorrar.Text = "Borrar";
            this.bnBorrar.UseColumnTextForButtonValue = true;
            // 
            // FormGastosMenoresR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.btnElegirBeneficiario;
            valida1.Mensaje = "Favor Elegir Suplidor";
            valida1.NombreCampo = "CedulaRNC";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "4";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtConcepto;
            valida2.Mensaje = "Debe indicar un concepto valido";
            valida2.NombreCampo = "Concepto";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "10";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtMonto;
            valida3.Mensaje = "Debe ser mayor a cero";
            valida3.NombreCampo = "Total";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtTotalItbis;
            valida4.Mensaje = "No puede ser negativo";
            valida4.NombreCampo = "Itbis";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "0";
            valida4.Valor2 = null;
            valida5.comtrol = this.cboTipoGastos;
            valida5.Mensaje = "Debe elegir el tipo de Gasto";
            valida5.NombreCampo = "Tipo_Gastos_DGII";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida5.Valor1 = "1";
            valida5.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5};
            this.CampoIdImprimir = "Identificador_Id";
            this.ClientSize = new System.Drawing.Size(1046, 632);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelEnc);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.PreviewRDLC;
            this.ImprimirAlGrabar = true;
            this.Name = "FormGastosMenoresR";
            this.NombreCampoID = "CXP_ID";
            this.NombreReporte = "rptCompraFactura";
            this.NombreVistaImprimir = "VCXP_DETALLES";
            this.SPGraba = "SP_COMPRAS_GRABA_GASTO_MENOR";
            this.TablaDetalle = "TTEMPORAL_CXP_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_CXP";
            this.Text = "REGISTRAR GASTO MENOR";
            this.TituloEditEntidad = "ELEGIR BENEFICIARIO";
            this.Load += new System.EventHandler(this.FormGastosMenoresR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panelEnc, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panelEnc.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRTextBox txtTotalItbis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNCF;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRCombobox cboTipoGastos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnElegirBeneficiario;
        private System.Windows.Forms.Label lblCedulaRNC;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCentroCosto;
        private System.Windows.Forms.Button btnVerPanelDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Cuenta;
        private System.Windows.Forms.DataGridViewButtonColumn bnBorrar;
        private WinControl_ELR_NET.ELRTextBox txtSubTotal;
        private System.Windows.Forms.Label label3;
    }
}