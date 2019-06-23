namespace ELRCuentasPorPagar
{
    partial class FormNotaDebitoCreditoACXPR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.txtNumero = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNCF = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.lblFacturaNo = new WinControl_ELR_NET.ELRLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCXP = new System.Windows.Forms.DataGridView();
            this.CXP_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura_Numero = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Factura_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarSuplidor = new System.Windows.Forms.Button();
            this.txtNombreSuplidor = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCXP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 525);
            this.pnBotones.Size = new System.Drawing.Size(853, 60);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(571, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 56);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(712, 0);
            this.btnCancelar.Size = new System.Drawing.Size(137, 56);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 56);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(476, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 56);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(381, 56);
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.autoSenTab = true;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "CedulaRNC";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = this.DSDatos;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(114, 10);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(189, 29);
            this.txtCedulaRNC.TabIndex = 1;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            this.txtCedulaRNC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCedulaRNC_KeyDown);
            this.txtCedulaRNC.Leave += new System.EventHandler(this.txtCedulaRNC_Leave);
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DSData = null;
            this.cboTipo.Enabled = false;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "NOTA DE CREDITO",
            "NOTA DE DEBITO"});
            this.cboTipo.Location = new System.Drawing.Point(115, 52);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(295, 33);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 2;
            this.cboTipo.TablaOVistaConsulta = "";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "0";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.autoSenTab = true;
            this.txtMonto.AValidar = null;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Total";
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
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(115, 208);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(295, 33);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
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
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.Enabled = false;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(456, 135);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(383, 106);
            this.txtConcepto.TabIndex = 14;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // txtNumero
            // 
            this.txtNumero.AMostrar = null;
            this.txtNumero.autoSenTab = true;
            this.txtNumero.AValidar = null;
            this.txtNumero.CampoBusquedaID = "";
            this.txtNumero.CampoData = "Factura_Numero";
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.ColumnasBusqGeneral = null;
            this.txtNumero.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumero.Decimales = 0;
            this.txtNumero.DSData = this.DSDatos;
            this.txtNumero.Enabled = false;
            this.txtNumero.EsAutoGenerado = false;
            this.txtNumero.EsBusqueda = false;
            this.txtNumero.EsBusquedaAutoIncremental = false;
            this.txtNumero.EsEditable = true;
            this.txtNumero.FiltroBusqueda = "";
            this.txtNumero.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNumero.Location = new System.Drawing.Point(115, 130);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.NombreTabla = "";
            this.txtNumero.SepDecimal = '\0';
            this.txtNumero.Size = new System.Drawing.Size(295, 33);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.TablaOVistaBusqueda = "";
            this.txtNumero.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumero.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumero.ValorPorDefecto = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNCF);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtItbis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.elrLabel1);
            this.panel1.Controls.Add(this.lblFacturaNo);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 266);
            this.panel1.TabIndex = 1;
            // 
            // txtNCF
            // 
            this.txtNCF.AMostrar = null;
            this.txtNCF.autoSenTab = true;
            this.txtNCF.AValidar = null;
            this.txtNCF.CampoBusquedaID = "";
            this.txtNCF.CampoData = "NCF";
            this.txtNCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNCF.ColumnasBusqGeneral = null;
            this.txtNCF.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNCF.Decimales = 0;
            this.txtNCF.DSData = this.DSDatos;
            this.txtNCF.Enabled = false;
            this.txtNCF.EsAutoGenerado = false;
            this.txtNCF.EsBusqueda = false;
            this.txtNCF.EsBusquedaAutoIncremental = false;
            this.txtNCF.EsEditable = true;
            this.txtNCF.FiltroBusqueda = "";
            this.txtNCF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCF.Formato = WinControl_ELR_NET.tbFormato.NoSpace;
            this.txtNCF.Location = new System.Drawing.Point(518, 60);
            this.txtNCF.MaxLength = 19;
            this.txtNCF.Name = "txtNCF";
            this.txtNCF.NombreTabla = "";
            this.txtNCF.SepDecimal = '\0';
            this.txtNCF.Size = new System.Drawing.Size(321, 33);
            this.txtNCF.TabIndex = 12;
            this.txtNCF.TablaOVistaBusqueda = "";
            this.txtNCF.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNCF.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNCF.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "NCF:";
            // 
            // txtItbis
            // 
            this.txtItbis.AMostrar = null;
            this.txtItbis.autoSenTab = true;
            this.txtItbis.AValidar = null;
            this.txtItbis.CampoBusquedaID = "";
            this.txtItbis.CampoData = "Itbis";
            this.txtItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItbis.ColumnasBusqGeneral = null;
            this.txtItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtItbis.Decimales = 0;
            this.txtItbis.DSData = this.DSDatos;
            this.txtItbis.Enabled = false;
            this.txtItbis.EsAutoGenerado = false;
            this.txtItbis.EsBusqueda = false;
            this.txtItbis.EsBusquedaAutoIncremental = false;
            this.txtItbis.EsEditable = true;
            this.txtItbis.FiltroBusqueda = "";
            this.txtItbis.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtItbis.Location = new System.Drawing.Point(115, 169);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.NombreTabla = "";
            this.txtItbis.SepDecimal = '\0';
            this.txtItbis.Size = new System.Drawing.Size(295, 33);
            this.txtItbis.TabIndex = 8;
            this.txtItbis.TablaOVistaBusqueda = "";
            this.txtItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtItbis.ValorPorDefecto = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Itbis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Factura_Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(115, 91);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(295, 33);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(12, 128);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(85, 25);
            this.elrLabel1.TabIndex = 5;
            this.elrLabel1.Text = "Numero:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // lblFacturaNo
            // 
            this.lblFacturaNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFacturaNo.CampoData = "";
            this.lblFacturaNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFacturaNo.DSData = null;
            this.lblFacturaNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaNo.Location = new System.Drawing.Point(0, 0);
            this.lblFacturaNo.Name = "lblFacturaNo";
            this.lblFacturaNo.NombreTabla = "";
            this.lblFacturaNo.Size = new System.Drawing.Size(849, 38);
            this.lblFacturaNo.TabIndex = 0;
            this.lblFacturaNo.Text = "APLICAR A FACTURA NO.: 000000        NCF: ";
            this.lblFacturaNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFacturaNo.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Concepto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCXP);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Suplidor y Cuenta por Pagar a Aplicar";
            // 
            // dtgCXP
            // 
            this.dtgCXP.AllowUserToAddRows = false;
            this.dtgCXP.AllowUserToDeleteRows = false;
            this.dtgCXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCXP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CXP_Id,
            this.Factura_Numero,
            this.Factura_Fecha,
            this.NCF,
            this.Total,
            this.Monto_Pendiente,
            this.Unico});
            this.dtgCXP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCXP.Location = new System.Drawing.Point(3, 78);
            this.dtgCXP.Name = "dtgCXP";
            this.dtgCXP.ReadOnly = true;
            this.dtgCXP.RowTemplate.Height = 33;
            this.dtgCXP.Size = new System.Drawing.Size(847, 178);
            this.dtgCXP.TabIndex = 1;
            this.dtgCXP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCXP_CellContentClick);
            // 
            // CXP_Id
            // 
            this.CXP_Id.DataPropertyName = "CXP_Id";
            this.CXP_Id.HeaderText = "CXP_Id";
            this.CXP_Id.Name = "CXP_Id";
            this.CXP_Id.ReadOnly = true;
            this.CXP_Id.Visible = false;
            // 
            // Factura_Numero
            // 
            this.Factura_Numero.DataPropertyName = "Factura_Numero";
            this.Factura_Numero.HeaderText = "Numero";
            this.Factura_Numero.Name = "Factura_Numero";
            this.Factura_Numero.ReadOnly = true;
            this.Factura_Numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Factura_Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Factura_Numero.Width = 150;
            // 
            // Factura_Fecha
            // 
            this.Factura_Fecha.DataPropertyName = "Factura_Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Factura_Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Factura_Fecha.HeaderText = "Fecha";
            this.Factura_Fecha.Name = "Factura_Fecha";
            this.Factura_Fecha.ReadOnly = true;
            this.Factura_Fecha.Width = 130;
            // 
            // NCF
            // 
            this.NCF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NCF.DataPropertyName = "NCF";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF.DefaultCellStyle = dataGridViewCellStyle2;
            this.NCF.HeaderText = "NCF";
            this.NCF.Name = "NCF";
            this.NCF.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // Monto_Pendiente
            // 
            this.Monto_Pendiente.DataPropertyName = "Monto_Pendiente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto_Pendiente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto_Pendiente.HeaderText = "Monto Pend.";
            this.Monto_Pendiente.Name = "Monto_Pendiente";
            this.Monto_Pendiente.ReadOnly = true;
            this.Monto_Pendiente.Width = 150;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuscarSuplidor);
            this.panel2.Controls.Add(this.txtNombreSuplidor);
            this.panel2.Controls.Add(this.txtCedulaRNC);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 53);
            this.panel2.TabIndex = 0;
            // 
            // btnBuscarSuplidor
            // 
            this.btnBuscarSuplidor.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnBuscarSuplidor.Location = new System.Drawing.Point(309, 8);
            this.btnBuscarSuplidor.Name = "btnBuscarSuplidor";
            this.btnBuscarSuplidor.Size = new System.Drawing.Size(55, 30);
            this.btnBuscarSuplidor.TabIndex = 2;
            this.btnBuscarSuplidor.UseVisualStyleBackColor = true;
            this.btnBuscarSuplidor.Click += new System.EventHandler(this.btnBuscarSuplidor_Click);
            // 
            // txtNombreSuplidor
            // 
            this.txtNombreSuplidor.AMostrar = null;
            this.txtNombreSuplidor.autoSenTab = true;
            this.txtNombreSuplidor.AValidar = null;
            this.txtNombreSuplidor.BackColor = System.Drawing.Color.White;
            this.txtNombreSuplidor.CampoBusquedaID = "";
            this.txtNombreSuplidor.CampoData = "Nombre";
            this.txtNombreSuplidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreSuplidor.ColumnasBusqGeneral = null;
            this.txtNombreSuplidor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreSuplidor.Decimales = 0;
            this.txtNombreSuplidor.DSData = this.DSDatos;
            this.txtNombreSuplidor.EsAutoGenerado = false;
            this.txtNombreSuplidor.EsBusqueda = false;
            this.txtNombreSuplidor.EsBusquedaAutoIncremental = false;
            this.txtNombreSuplidor.EsEditable = true;
            this.txtNombreSuplidor.FiltroBusqueda = "";
            this.txtNombreSuplidor.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreSuplidor.Location = new System.Drawing.Point(370, 10);
            this.txtNombreSuplidor.Name = "txtNombreSuplidor";
            this.txtNombreSuplidor.NombreTabla = "";
            this.txtNombreSuplidor.ReadOnly = true;
            this.txtNombreSuplidor.SepDecimal = '\0';
            this.txtNombreSuplidor.Size = new System.Drawing.Size(446, 29);
            this.txtNombreSuplidor.TabIndex = 3;
            this.txtNombreSuplidor.TablaOVistaBusqueda = "";
            this.txtNombreSuplidor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreSuplidor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreSuplidor.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula\\RNC:";
            // 
            // FormNotaDebitoCreditoACXPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCedulaRNC;
            valida1.Mensaje = "Debe Indicar la Cedula o RNC del Suplidor";
            valida1.NombreCampo = "CedulaRNC";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.cboTipo;
            valida2.Mensaje = "Debe Indicar el tipo de Transaccion";
            valida2.NombreCampo = "Modulo";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtMonto;
            valida3.Mensaje = "El monto debe ser mayor a Cero";
            valida3.NombreCampo = "Total";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtConcepto;
            valida4.Mensaje = "Debe Indicar un concepto, con un minimo de 10 caracteres";
            valida4.NombreCampo = "Concepto";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida4.Valor1 = "10";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtNumero;
            valida5.Mensaje = "Debe Indicar el numero de referencia en la nota";
            valida5.NombreCampo = "Factura_Numero";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida5.Valor1 = null;
            valida5.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5};
            this.ClientSize = new System.Drawing.Size(853, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.Name = "FormNotaDebitoCreditoACXPR";
            this.NombreCampoID = "CXP_Id";
            this.SPGraba = "SP_COMPRA_GRABA_NOTA_DEBITO_CREDITO";
            this.TablaEncabezado = "TTEMPORAL_CXP";
            this.Text = "APLICAR NOTA DE DEBITO Y/O CREDITO A CUENTA POR PAGAR";
            this.Load += new System.EventHandler(this.FormNotaDebitoCreditoACXPR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCXP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCXP;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarSuplidor;
        private WinControl_ELR_NET.ELRTextBox txtNombreSuplidor;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CXP_Id;
        private System.Windows.Forms.DataGridViewLinkColumn Factura_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private WinControl_ELR_NET.ELRLabel lblFacturaNo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNumero;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRTextBox txtItbis;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtNCF;
        private System.Windows.Forms.Label label7;
    }
}