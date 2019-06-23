namespace ELRCuentasPorPagar
{
    partial class FormGastosFijosR
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
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            this.txtAPagar = new WinControl_ELR_NET.ELRTextBox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.cboTipoGastos = new WinControl_ELR_NET.ELRCombobox();
            this.cboTipoNCF = new WinControl_ELR_NET.ELRCombobox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panelEnc = new System.Windows.Forms.Panel();
            this.btnElegirBeneficiario = new System.Windows.Forms.Button();
            this.lblCedulaRNC = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCentroCosto = new System.Windows.Forms.Button();
            this.btnVerPanelDetalle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetISR = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 561);
            this.pnBotones.Size = new System.Drawing.Size(976, 63);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(702, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 59);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(843, 0);
            this.btnCancelar.Size = new System.Drawing.Size(129, 59);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 59);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(607, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 59);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(512, 59);
            // 
            // txtAPagar
            // 
            this.txtAPagar.AMostrar = null;
            this.txtAPagar.autoSenTab = true;
            this.txtAPagar.AValidar = null;
            this.txtAPagar.BackColor = System.Drawing.Color.White;
            this.txtAPagar.CampoBusquedaID = "";
            this.txtAPagar.CampoData = "Monto_APagar";
            this.txtAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAPagar.ColumnasBusqGeneral = null;
            this.txtAPagar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAPagar.Decimales = 2;
            this.txtAPagar.DSData = this.DSDatos;
            this.txtAPagar.EsAutoGenerado = false;
            this.txtAPagar.EsBusqueda = false;
            this.txtAPagar.EsBusquedaAutoIncremental = false;
            this.txtAPagar.EsEditable = true;
            this.txtAPagar.FiltroBusqueda = "";
            this.txtAPagar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPagar.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtAPagar.Location = new System.Drawing.Point(144, 189);
            this.txtAPagar.Name = "txtAPagar";
            this.txtAPagar.NombreTabla = "";
            this.txtAPagar.ReadOnly = true;
            this.txtAPagar.SepDecimal = '\0';
            this.txtAPagar.Size = new System.Drawing.Size(218, 39);
            this.txtAPagar.TabIndex = 23;
            this.txtAPagar.TablaOVistaBusqueda = "";
            this.txtAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAPagar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAPagar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAPagar.ValorPorDefecto = "0.00";
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
            this.txtMonto.Location = new System.Drawing.Point(144, 9);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(218, 39);
            this.txtMonto.TabIndex = 15;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
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
            this.cboTipoGastos.Location = new System.Drawing.Point(404, 39);
            this.cboTipoGastos.Name = "cboTipoGastos";
            this.cboTipoGastos.NombreTabla = "";
            this.cboTipoGastos.Size = new System.Drawing.Size(556, 36);
            this.cboTipoGastos.SSQL = "";
            this.cboTipoGastos.TabIndex = 15;
            this.cboTipoGastos.TablaOVistaConsulta = " TSISTEMA_TIPOS_GASTOS_DGII";
            this.cboTipoGastos.UsaDataGlobal = false;
            this.cboTipoGastos.ValorPorDefecto = "7";
            this.cboTipoGastos.ValueMember = "Tipo_Id";
            // 
            // cboTipoNCF
            // 
            this.cboTipoNCF.AValidar = null;
            this.cboTipoNCF.CampoData = "Tipo_NCF";
            this.cboTipoNCF.CampoJoinCombobox2 = "";
            this.cboTipoNCF.ComboboxAFiltrar = null;
            this.cboTipoNCF.DisplayMember = "Descripcion";
            this.cboTipoNCF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoNCF.DSData = this.DSDatos;
            this.cboTipoNCF.EsEditable = true;
            this.cboTipoNCF.FiltroBusqueda = "Tipo_NCF in (1, 11, 13)";
            this.cboTipoNCF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoNCF.FormattingEnabled = true;
            this.cboTipoNCF.Location = new System.Drawing.Point(504, 82);
            this.cboTipoNCF.Name = "cboTipoNCF";
            this.cboTipoNCF.NombreTabla = "";
            this.cboTipoNCF.Size = new System.Drawing.Size(458, 36);
            this.cboTipoNCF.SSQL = "";
            this.cboTipoNCF.TabIndex = 17;
            this.cboTipoNCF.TablaOVistaConsulta = "TSISTEMA_TIPOS_NCF";
            this.cboTipoNCF.UsaDataGlobal = false;
            this.cboTipoNCF.ValorPorDefecto = "13";
            this.cboTipoNCF.ValueMember = "Tipo_NCF";
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
            this.txtConcepto.Location = new System.Drawing.Point(3, 29);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(580, 80);
            this.txtConcepto.TabIndex = 1;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panelEnc
            // 
            this.panelEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEnc.Controls.Add(this.btnElegirBeneficiario);
            this.panelEnc.Controls.Add(this.lblCedulaRNC);
            this.panelEnc.Controls.Add(this.lblNombre);
            this.panelEnc.Controls.Add(this.panel5);
            this.panelEnc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEnc.Location = new System.Drawing.Point(0, 0);
            this.panelEnc.Name = "panelEnc";
            this.panelEnc.Size = new System.Drawing.Size(976, 185);
            this.panelEnc.TabIndex = 1;
            // 
            // btnElegirBeneficiario
            // 
            this.btnElegirBeneficiario.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnElegirBeneficiario.Location = new System.Drawing.Point(19, 3);
            this.btnElegirBeneficiario.Name = "btnElegirBeneficiario";
            this.btnElegirBeneficiario.Size = new System.Drawing.Size(330, 47);
            this.btnElegirBeneficiario.TabIndex = 20;
            this.btnElegirBeneficiario.Text = "Elegir Beneficiario";
            this.btnElegirBeneficiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElegirBeneficiario.UseVisualStyleBackColor = true;
            this.btnElegirBeneficiario.Click += new System.EventHandler(this.btnElegirBeneficiario_Click);
            // 
            // lblCedulaRNC
            // 
            this.lblCedulaRNC.AutoSize = true;
            this.lblCedulaRNC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaRNC.Location = new System.Drawing.Point(14, 87);
            this.lblCedulaRNC.Name = "lblCedulaRNC";
            this.lblCedulaRNC.Size = new System.Drawing.Size(265, 25);
            this.lblCedulaRNC.TabIndex = 22;
            this.lblCedulaRNC.Text = "Cedula o RNC: 00000000000";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(335, 25);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre o Razon Social: Beneficiario";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnCentroCosto);
            this.panel5.Controls.Add(this.btnVerPanelDetalle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(972, 52);
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
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboTipoNCF);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboTipoGastos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 240);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(386, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 112);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtAPagar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRetISR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRetItbis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTotalItbis);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 236);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "A Pagar:";
            // 
            // txtRetISR
            // 
            this.txtRetISR.AMostrar = null;
            this.txtRetISR.autoSenTab = true;
            this.txtRetISR.AValidar = null;
            this.txtRetISR.BackColor = System.Drawing.Color.White;
            this.txtRetISR.CampoBusquedaID = "";
            this.txtRetISR.CampoData = "Retencion_Neto";
            this.txtRetISR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetISR.ColumnasBusqGeneral = null;
            this.txtRetISR.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtRetISR.Decimales = 2;
            this.txtRetISR.DSData = this.DSDatos;
            this.txtRetISR.EsAutoGenerado = false;
            this.txtRetISR.EsBusqueda = false;
            this.txtRetISR.EsBusquedaAutoIncremental = false;
            this.txtRetISR.EsEditable = true;
            this.txtRetISR.FiltroBusqueda = "";
            this.txtRetISR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetISR.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtRetISR.Location = new System.Drawing.Point(144, 144);
            this.txtRetISR.Name = "txtRetISR";
            this.txtRetISR.NombreTabla = "";
            this.txtRetISR.SepDecimal = '\0';
            this.txtRetISR.Size = new System.Drawing.Size(218, 39);
            this.txtRetISR.TabIndex = 21;
            this.txtRetISR.TablaOVistaBusqueda = "";
            this.txtRetISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetISR.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtRetISR.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtRetISR.ValorPorDefecto = "0.00";
            this.txtRetISR.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ret. ISR:";
            // 
            // txtRetItbis
            // 
            this.txtRetItbis.AMostrar = null;
            this.txtRetItbis.autoSenTab = true;
            this.txtRetItbis.AValidar = null;
            this.txtRetItbis.BackColor = System.Drawing.Color.White;
            this.txtRetItbis.CampoBusquedaID = "";
            this.txtRetItbis.CampoData = "Retencion_Itbis";
            this.txtRetItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetItbis.ColumnasBusqGeneral = null;
            this.txtRetItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtRetItbis.Decimales = 2;
            this.txtRetItbis.DSData = this.DSDatos;
            this.txtRetItbis.EsAutoGenerado = false;
            this.txtRetItbis.EsBusqueda = false;
            this.txtRetItbis.EsBusquedaAutoIncremental = false;
            this.txtRetItbis.EsEditable = true;
            this.txtRetItbis.FiltroBusqueda = "";
            this.txtRetItbis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetItbis.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtRetItbis.Location = new System.Drawing.Point(144, 98);
            this.txtRetItbis.Name = "txtRetItbis";
            this.txtRetItbis.NombreTabla = "";
            this.txtRetItbis.SepDecimal = '\0';
            this.txtRetItbis.Size = new System.Drawing.Size(218, 39);
            this.txtRetItbis.TabIndex = 19;
            this.txtRetItbis.TablaOVistaBusqueda = "";
            this.txtRetItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtRetItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtRetItbis.ValorPorDefecto = "0.00";
            this.txtRetItbis.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ret. Itbis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total:";
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
            this.txtTotalItbis.Location = new System.Drawing.Point(144, 53);
            this.txtTotalItbis.Name = "txtTotalItbis";
            this.txtTotalItbis.NombreTabla = "";
            this.txtTotalItbis.ReadOnly = true;
            this.txtTotalItbis.SepDecimal = '\0';
            this.txtTotalItbis.Size = new System.Drawing.Size(218, 39);
            this.txtTotalItbis.TabIndex = 17;
            this.txtTotalItbis.TablaOVistaBusqueda = "";
            this.txtTotalItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotalItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotalItbis.ValorPorDefecto = "0.00";
            this.txtTotalItbis.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Itbis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo NCF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo gasto:";
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
            this.dtgDetalle.Location = new System.Drawing.Point(0, 185);
            this.dtgDetalle.MultiSelect = false;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.RowTemplate.Height = 35;
            this.dtgDetalle.Size = new System.Drawing.Size(976, 136);
            this.dtgDetalle.TabIndex = 5;
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
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Total.DefaultCellStyle = dataGridViewCellStyle1;
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
            // FormGastosFijosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtAPagar;
            valida1.Mensaje = "El monto a pagar debe ser mayor a cero";
            valida1.NombreCampo = "Monto_APagar";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtMonto;
            valida2.Mensaje = "El monto o total debe ser mayor a cero";
            valida2.NombreCampo = "Total";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
            valida2.Valor2 = null;
            valida3.comtrol = this.cboTipoGastos;
            valida3.Mensaje = "Debe Indicar el tipo de gasto";
            valida3.NombreCampo = "Tipo_Gastos_DGII";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.cboTipoNCF;
            valida4.Mensaje = "Debe Indicar el Tipo de comprobante fiscal";
            valida4.NombreCampo = "Tipo_NCF";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "1";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtConcepto;
            valida5.Mensaje = "Debe indicar un concepto valido, minimo 10 caracteres";
            valida5.NombreCampo = "Concepto";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida5.Valor1 = "10";
            valida5.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5};
            this.ClientSize = new System.Drawing.Size(976, 624);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelEnc);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.EsConTemporal = true;
            this.Name = "FormGastosFijosR";
            this.NombreCampoID = "Unico";
            this.SPGraba = "SP_GASTOS_FIJOS_GRABAR";
            this.TablaDetalle = "TTEMPORAL_CXP_GASTOS_FIJOS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_CXP_GASTOS_FIJOS";
            this.Text = "REGISTRAR GASTO FIJO";
            this.Load += new System.EventHandler(this.FormGastosFijosR_Load);
            this.Controls.SetChildIndex(this.panelEnc, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panelEnc.ResumeLayout(false);
            this.panelEnc.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCentroCosto;
        private System.Windows.Forms.Button btnVerPanelDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRTextBox txtAPagar;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtRetISR;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtRetItbis;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRTextBox txtTotalItbis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRCombobox cboTipoNCF;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRCombobox cboTipoGastos;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Button btnElegirBeneficiario;
        private System.Windows.Forms.Label lblCedulaRNC;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Cuenta;
        private System.Windows.Forms.DataGridViewButtonColumn bnBorrar;
    }
}