namespace ELRNomina
{
    partial class FormGenerarNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new WinControl_ELR_NET.ELRDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDISR = new WinControl_ELR_NET.ELRTextBox();
            this.txtDARL = new WinControl_ELR_NET.ELRTextBox();
            this.txtDAFP = new WinControl_ELR_NET.ELRTextBox();
            this.txtDARS = new WinControl_ELR_NET.ELRTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEINFOTEP = new WinControl_ELR_NET.ELRTextBox();
            this.txtEARL = new WinControl_ELR_NET.ELRTextBox();
            this.txtEAFP = new WinControl_ELR_NET.ELRTextBox();
            this.txtEARS = new WinControl_ELR_NET.ELRTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNeto = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescto = new WinControl_ELR_NET.ELRTextBox();
            this.txtSueldoBruto = new WinControl_ELR_NET.ELRTextBox();
            this.txtSalarioMensual = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgNominaDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_APagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFiltroNombre = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNominaDetalle)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 476);
            this.pnBotones.Size = new System.Drawing.Size(931, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(691, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(832, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(596, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(501, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 125);
            this.panel1.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(388, 10);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(128, 35);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(248, 10);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(127, 35);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.AValidar = null;
            this.dtpFechaHasta.CampoData = "";
            this.dtpFechaHasta.DSData = null;
            this.dtpFechaHasta.EsEditable = true;
            this.dtpFechaHasta.FiltroBusqueda = "";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(89, 11);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.NombreTabla = "";
            this.dtpFechaHasta.Size = new System.Drawing.Size(153, 29);
            this.dtpFechaHasta.TabIndex = 3;
            this.dtpFechaHasta.ValorPorDefecto = new System.DateTime(2017, 1, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 183);
            this.panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDISR);
            this.groupBox3.Controls.Add(this.txtDARL);
            this.groupBox3.Controls.Add(this.txtDAFP);
            this.groupBox3.Controls.Add(this.txtDARS);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descuento Empleado TSS";
            // 
            // txtDISR
            // 
            this.txtDISR.AMostrar = null;
            this.txtDISR.autoSenTab = true;
            this.txtDISR.AValidar = null;
            this.txtDISR.BackColor = System.Drawing.Color.White;
            this.txtDISR.CampoBusquedaID = "";
            this.txtDISR.CampoData = "";
            this.txtDISR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDISR.ColumnasBusqGeneral = null;
            this.txtDISR.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDISR.Decimales = 0;
            this.txtDISR.DSData = null;
            this.txtDISR.EsAutoGenerado = false;
            this.txtDISR.EsBusqueda = false;
            this.txtDISR.EsBusquedaAutoIncremental = false;
            this.txtDISR.EsEditable = true;
            this.txtDISR.FiltroBusqueda = "";
            this.txtDISR.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDISR.Location = new System.Drawing.Point(116, 133);
            this.txtDISR.Name = "txtDISR";
            this.txtDISR.NombreTabla = "";
            this.txtDISR.ReadOnly = true;
            this.txtDISR.SepDecimal = '\0';
            this.txtDISR.Size = new System.Drawing.Size(143, 29);
            this.txtDISR.TabIndex = 11;
            this.txtDISR.TablaOVistaBusqueda = "";
            this.txtDISR.Text = "0.00";
            this.txtDISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDISR.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDISR.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDISR.ValorPorDefecto = "";
            // 
            // txtDARL
            // 
            this.txtDARL.AMostrar = null;
            this.txtDARL.autoSenTab = true;
            this.txtDARL.AValidar = null;
            this.txtDARL.BackColor = System.Drawing.Color.White;
            this.txtDARL.CampoBusquedaID = "";
            this.txtDARL.CampoData = "";
            this.txtDARL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDARL.ColumnasBusqGeneral = null;
            this.txtDARL.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDARL.Decimales = 0;
            this.txtDARL.DSData = null;
            this.txtDARL.EsAutoGenerado = false;
            this.txtDARL.EsBusqueda = false;
            this.txtDARL.EsBusquedaAutoIncremental = false;
            this.txtDARL.EsEditable = true;
            this.txtDARL.FiltroBusqueda = "";
            this.txtDARL.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDARL.Location = new System.Drawing.Point(116, 98);
            this.txtDARL.Name = "txtDARL";
            this.txtDARL.NombreTabla = "";
            this.txtDARL.ReadOnly = true;
            this.txtDARL.SepDecimal = '\0';
            this.txtDARL.Size = new System.Drawing.Size(143, 29);
            this.txtDARL.TabIndex = 10;
            this.txtDARL.TablaOVistaBusqueda = "";
            this.txtDARL.Text = "0.00";
            this.txtDARL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDARL.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDARL.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDARL.ValorPorDefecto = "";
            // 
            // txtDAFP
            // 
            this.txtDAFP.AMostrar = null;
            this.txtDAFP.autoSenTab = true;
            this.txtDAFP.AValidar = null;
            this.txtDAFP.BackColor = System.Drawing.Color.White;
            this.txtDAFP.CampoBusquedaID = "";
            this.txtDAFP.CampoData = "";
            this.txtDAFP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDAFP.ColumnasBusqGeneral = null;
            this.txtDAFP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDAFP.Decimales = 0;
            this.txtDAFP.DSData = null;
            this.txtDAFP.EsAutoGenerado = false;
            this.txtDAFP.EsBusqueda = false;
            this.txtDAFP.EsBusquedaAutoIncremental = false;
            this.txtDAFP.EsEditable = true;
            this.txtDAFP.FiltroBusqueda = "";
            this.txtDAFP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDAFP.Location = new System.Drawing.Point(116, 63);
            this.txtDAFP.Name = "txtDAFP";
            this.txtDAFP.NombreTabla = "";
            this.txtDAFP.ReadOnly = true;
            this.txtDAFP.SepDecimal = '\0';
            this.txtDAFP.Size = new System.Drawing.Size(143, 29);
            this.txtDAFP.TabIndex = 9;
            this.txtDAFP.TablaOVistaBusqueda = "";
            this.txtDAFP.Text = "0.00";
            this.txtDAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDAFP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDAFP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDAFP.ValorPorDefecto = "";
            // 
            // txtDARS
            // 
            this.txtDARS.AMostrar = null;
            this.txtDARS.autoSenTab = true;
            this.txtDARS.AValidar = null;
            this.txtDARS.BackColor = System.Drawing.Color.White;
            this.txtDARS.CampoBusquedaID = "";
            this.txtDARS.CampoData = "";
            this.txtDARS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDARS.ColumnasBusqGeneral = null;
            this.txtDARS.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDARS.Decimales = 0;
            this.txtDARS.DSData = null;
            this.txtDARS.EsAutoGenerado = false;
            this.txtDARS.EsBusqueda = false;
            this.txtDARS.EsBusquedaAutoIncremental = false;
            this.txtDARS.EsEditable = true;
            this.txtDARS.FiltroBusqueda = "";
            this.txtDARS.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDARS.Location = new System.Drawing.Point(116, 28);
            this.txtDARS.Name = "txtDARS";
            this.txtDARS.NombreTabla = "";
            this.txtDARS.ReadOnly = true;
            this.txtDARS.SepDecimal = '\0';
            this.txtDARS.Size = new System.Drawing.Size(143, 29);
            this.txtDARS.TabIndex = 8;
            this.txtDARS.TablaOVistaBusqueda = "";
            this.txtDARS.Text = "0.00";
            this.txtDARS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDARS.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDARS.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDARS.ValorPorDefecto = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 21);
            this.label19.TabIndex = 6;
            this.label19.Text = "ISR:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(53, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 21);
            this.label23.TabIndex = 2;
            this.label23.Text = "ARL:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(53, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 21);
            this.label24.TabIndex = 1;
            this.label24.Text = "AFP:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(52, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "ARS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEINFOTEP);
            this.groupBox2.Controls.Add(this.txtEARL);
            this.groupBox2.Controls.Add(this.txtEAFP);
            this.groupBox2.Controls.Add(this.txtEARS);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(283, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aporte Empresa TSS";
            // 
            // txtEINFOTEP
            // 
            this.txtEINFOTEP.AMostrar = null;
            this.txtEINFOTEP.autoSenTab = true;
            this.txtEINFOTEP.AValidar = null;
            this.txtEINFOTEP.BackColor = System.Drawing.Color.White;
            this.txtEINFOTEP.CampoBusquedaID = "";
            this.txtEINFOTEP.CampoData = "";
            this.txtEINFOTEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEINFOTEP.ColumnasBusqGeneral = null;
            this.txtEINFOTEP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEINFOTEP.Decimales = 0;
            this.txtEINFOTEP.DSData = null;
            this.txtEINFOTEP.EsAutoGenerado = false;
            this.txtEINFOTEP.EsBusqueda = false;
            this.txtEINFOTEP.EsBusquedaAutoIncremental = false;
            this.txtEINFOTEP.EsEditable = true;
            this.txtEINFOTEP.FiltroBusqueda = "";
            this.txtEINFOTEP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEINFOTEP.Location = new System.Drawing.Point(116, 133);
            this.txtEINFOTEP.Name = "txtEINFOTEP";
            this.txtEINFOTEP.NombreTabla = "";
            this.txtEINFOTEP.ReadOnly = true;
            this.txtEINFOTEP.SepDecimal = '\0';
            this.txtEINFOTEP.Size = new System.Drawing.Size(143, 29);
            this.txtEINFOTEP.TabIndex = 12;
            this.txtEINFOTEP.TablaOVistaBusqueda = "";
            this.txtEINFOTEP.Text = "0.00";
            this.txtEINFOTEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEINFOTEP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEINFOTEP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEINFOTEP.ValorPorDefecto = "";
            // 
            // txtEARL
            // 
            this.txtEARL.AMostrar = null;
            this.txtEARL.autoSenTab = true;
            this.txtEARL.AValidar = null;
            this.txtEARL.BackColor = System.Drawing.Color.White;
            this.txtEARL.CampoBusquedaID = "";
            this.txtEARL.CampoData = "";
            this.txtEARL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEARL.ColumnasBusqGeneral = null;
            this.txtEARL.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEARL.Decimales = 0;
            this.txtEARL.DSData = null;
            this.txtEARL.EsAutoGenerado = false;
            this.txtEARL.EsBusqueda = false;
            this.txtEARL.EsBusquedaAutoIncremental = false;
            this.txtEARL.EsEditable = true;
            this.txtEARL.FiltroBusqueda = "";
            this.txtEARL.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEARL.Location = new System.Drawing.Point(116, 98);
            this.txtEARL.Name = "txtEARL";
            this.txtEARL.NombreTabla = "";
            this.txtEARL.ReadOnly = true;
            this.txtEARL.SepDecimal = '\0';
            this.txtEARL.Size = new System.Drawing.Size(143, 29);
            this.txtEARL.TabIndex = 11;
            this.txtEARL.TablaOVistaBusqueda = "";
            this.txtEARL.Text = "0.00";
            this.txtEARL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEARL.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEARL.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEARL.ValorPorDefecto = "";
            // 
            // txtEAFP
            // 
            this.txtEAFP.AMostrar = null;
            this.txtEAFP.autoSenTab = true;
            this.txtEAFP.AValidar = null;
            this.txtEAFP.BackColor = System.Drawing.Color.White;
            this.txtEAFP.CampoBusquedaID = "";
            this.txtEAFP.CampoData = "";
            this.txtEAFP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEAFP.ColumnasBusqGeneral = null;
            this.txtEAFP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEAFP.Decimales = 0;
            this.txtEAFP.DSData = null;
            this.txtEAFP.EsAutoGenerado = false;
            this.txtEAFP.EsBusqueda = false;
            this.txtEAFP.EsBusquedaAutoIncremental = false;
            this.txtEAFP.EsEditable = true;
            this.txtEAFP.FiltroBusqueda = "";
            this.txtEAFP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEAFP.Location = new System.Drawing.Point(116, 63);
            this.txtEAFP.Name = "txtEAFP";
            this.txtEAFP.NombreTabla = "";
            this.txtEAFP.ReadOnly = true;
            this.txtEAFP.SepDecimal = '\0';
            this.txtEAFP.Size = new System.Drawing.Size(143, 29);
            this.txtEAFP.TabIndex = 10;
            this.txtEAFP.TablaOVistaBusqueda = "";
            this.txtEAFP.Text = "0.00";
            this.txtEAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEAFP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEAFP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEAFP.ValorPorDefecto = "";
            // 
            // txtEARS
            // 
            this.txtEARS.AMostrar = null;
            this.txtEARS.autoSenTab = true;
            this.txtEARS.AValidar = null;
            this.txtEARS.BackColor = System.Drawing.Color.White;
            this.txtEARS.CampoBusquedaID = "";
            this.txtEARS.CampoData = "";
            this.txtEARS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEARS.ColumnasBusqGeneral = null;
            this.txtEARS.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEARS.Decimales = 0;
            this.txtEARS.DSData = null;
            this.txtEARS.EsAutoGenerado = false;
            this.txtEARS.EsBusqueda = false;
            this.txtEARS.EsBusquedaAutoIncremental = false;
            this.txtEARS.EsEditable = true;
            this.txtEARS.FiltroBusqueda = "";
            this.txtEARS.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEARS.Location = new System.Drawing.Point(116, 27);
            this.txtEARS.Name = "txtEARS";
            this.txtEARS.NombreTabla = "";
            this.txtEARS.ReadOnly = true;
            this.txtEARS.SepDecimal = '\0';
            this.txtEARS.Size = new System.Drawing.Size(143, 29);
            this.txtEARS.TabIndex = 9;
            this.txtEARS.TablaOVistaBusqueda = "";
            this.txtEARS.Text = "0.00";
            this.txtEARS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEARS.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEARS.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEARS.ValorPorDefecto = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "INFOTEP:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "ARL:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "AFP:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "ARS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNeto);
            this.groupBox1.Controls.Add(this.txtDescto);
            this.groupBox1.Controls.Add(this.txtSueldoBruto);
            this.groupBox1.Controls.Add(this.txtSalarioMensual);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(586, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Generar";
            // 
            // txtNeto
            // 
            this.txtNeto.AMostrar = null;
            this.txtNeto.autoSenTab = true;
            this.txtNeto.AValidar = null;
            this.txtNeto.BackColor = System.Drawing.Color.White;
            this.txtNeto.CampoBusquedaID = "";
            this.txtNeto.CampoData = "";
            this.txtNeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNeto.ColumnasBusqGeneral = null;
            this.txtNeto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNeto.Decimales = 0;
            this.txtNeto.DSData = null;
            this.txtNeto.EsAutoGenerado = false;
            this.txtNeto.EsBusqueda = false;
            this.txtNeto.EsBusquedaAutoIncremental = false;
            this.txtNeto.EsEditable = true;
            this.txtNeto.FiltroBusqueda = "";
            this.txtNeto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNeto.Location = new System.Drawing.Point(159, 129);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.NombreTabla = "";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.SepDecimal = '\0';
            this.txtNeto.Size = new System.Drawing.Size(172, 29);
            this.txtNeto.TabIndex = 13;
            this.txtNeto.TablaOVistaBusqueda = "";
            this.txtNeto.Text = "0.00";
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNeto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNeto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNeto.ValorPorDefecto = "";
            // 
            // txtDescto
            // 
            this.txtDescto.AMostrar = null;
            this.txtDescto.autoSenTab = true;
            this.txtDescto.AValidar = null;
            this.txtDescto.BackColor = System.Drawing.Color.White;
            this.txtDescto.CampoBusquedaID = "";
            this.txtDescto.CampoData = "";
            this.txtDescto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescto.ColumnasBusqGeneral = null;
            this.txtDescto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescto.Decimales = 0;
            this.txtDescto.DSData = null;
            this.txtDescto.EsAutoGenerado = false;
            this.txtDescto.EsBusqueda = false;
            this.txtDescto.EsBusquedaAutoIncremental = false;
            this.txtDescto.EsEditable = true;
            this.txtDescto.FiltroBusqueda = "";
            this.txtDescto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescto.Location = new System.Drawing.Point(159, 94);
            this.txtDescto.Name = "txtDescto";
            this.txtDescto.NombreTabla = "";
            this.txtDescto.ReadOnly = true;
            this.txtDescto.SepDecimal = '\0';
            this.txtDescto.Size = new System.Drawing.Size(172, 29);
            this.txtDescto.TabIndex = 12;
            this.txtDescto.TablaOVistaBusqueda = "";
            this.txtDescto.Text = "0.00";
            this.txtDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescto.ValorPorDefecto = "";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.AMostrar = null;
            this.txtSueldoBruto.autoSenTab = true;
            this.txtSueldoBruto.AValidar = null;
            this.txtSueldoBruto.BackColor = System.Drawing.Color.White;
            this.txtSueldoBruto.CampoBusquedaID = "";
            this.txtSueldoBruto.CampoData = "";
            this.txtSueldoBruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSueldoBruto.ColumnasBusqGeneral = null;
            this.txtSueldoBruto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSueldoBruto.Decimales = 0;
            this.txtSueldoBruto.DSData = null;
            this.txtSueldoBruto.EsAutoGenerado = false;
            this.txtSueldoBruto.EsBusqueda = false;
            this.txtSueldoBruto.EsBusquedaAutoIncremental = false;
            this.txtSueldoBruto.EsEditable = true;
            this.txtSueldoBruto.FiltroBusqueda = "";
            this.txtSueldoBruto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSueldoBruto.Location = new System.Drawing.Point(159, 59);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.NombreTabla = "";
            this.txtSueldoBruto.ReadOnly = true;
            this.txtSueldoBruto.SepDecimal = '\0';
            this.txtSueldoBruto.Size = new System.Drawing.Size(172, 29);
            this.txtSueldoBruto.TabIndex = 11;
            this.txtSueldoBruto.TablaOVistaBusqueda = "";
            this.txtSueldoBruto.Text = "0.00";
            this.txtSueldoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldoBruto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSueldoBruto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSueldoBruto.ValorPorDefecto = "";
            // 
            // txtSalarioMensual
            // 
            this.txtSalarioMensual.AMostrar = null;
            this.txtSalarioMensual.autoSenTab = true;
            this.txtSalarioMensual.AValidar = null;
            this.txtSalarioMensual.BackColor = System.Drawing.Color.White;
            this.txtSalarioMensual.CampoBusquedaID = "";
            this.txtSalarioMensual.CampoData = "";
            this.txtSalarioMensual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalarioMensual.ColumnasBusqGeneral = null;
            this.txtSalarioMensual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSalarioMensual.Decimales = 0;
            this.txtSalarioMensual.DSData = null;
            this.txtSalarioMensual.EsAutoGenerado = false;
            this.txtSalarioMensual.EsBusqueda = false;
            this.txtSalarioMensual.EsBusquedaAutoIncremental = false;
            this.txtSalarioMensual.EsEditable = true;
            this.txtSalarioMensual.FiltroBusqueda = "";
            this.txtSalarioMensual.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSalarioMensual.Location = new System.Drawing.Point(159, 24);
            this.txtSalarioMensual.Name = "txtSalarioMensual";
            this.txtSalarioMensual.NombreTabla = "";
            this.txtSalarioMensual.ReadOnly = true;
            this.txtSalarioMensual.SepDecimal = '\0';
            this.txtSalarioMensual.Size = new System.Drawing.Size(172, 29);
            this.txtSalarioMensual.TabIndex = 10;
            this.txtSalarioMensual.TablaOVistaBusqueda = "";
            this.txtSalarioMensual.Text = "0.00";
            this.txtSalarioMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalarioMensual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSalarioMensual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSalarioMensual.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Neto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Descto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Bruto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario Mensual:";
            // 
            // dtgNominaDetalle
            // 
            this.dtgNominaDetalle.AllowUserToAddRows = false;
            this.dtgNominaDetalle.AllowUserToDeleteRows = false;
            this.dtgNominaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNominaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.IdentificadorTemp,
            this.Empleado_Id,
            this.Nombre,
            this.CedulaRNC,
            this.Salario,
            this.Monto_Bruto,
            this.Descuento,
            this.Monto_APagar,
            this.btnVerDetalle});
            this.dtgNominaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNominaDetalle.Location = new System.Drawing.Point(0, 125);
            this.dtgNominaDetalle.Name = "dtgNominaDetalle";
            this.dtgNominaDetalle.ReadOnly = true;
            this.dtgNominaDetalle.RowHeadersWidth = 28;
            this.dtgNominaDetalle.RowTemplate.Height = 35;
            this.dtgNominaDetalle.Size = new System.Drawing.Size(931, 168);
            this.dtgNominaDetalle.TabIndex = 3;
            this.dtgNominaDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNominaDetalle_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            this.Unico.Width = 130;
            // 
            // IdentificadorTemp
            // 
            this.IdentificadorTemp.DataPropertyName = "IdentificadorTemp";
            this.IdentificadorTemp.HeaderText = "IdentificadorTemp";
            this.IdentificadorTemp.Name = "IdentificadorTemp";
            this.IdentificadorTemp.ReadOnly = true;
            this.IdentificadorTemp.Visible = false;
            // 
            // Empleado_Id
            // 
            this.Empleado_Id.DataPropertyName = "Empleado_Id";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado_Id.DefaultCellStyle = dataGridViewCellStyle11;
            this.Empleado_Id.HeaderText = "Codigo";
            this.Empleado_Id.Name = "Empleado_Id";
            this.Empleado_Id.ReadOnly = true;
            this.Empleado_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Empleado_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Empleado_Id.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Visible = false;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.Salario.DefaultCellStyle = dataGridViewCellStyle12;
            this.Salario.HeaderText = "Salario M.";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Width = 140;
            // 
            // Monto_Bruto
            // 
            this.Monto_Bruto.DataPropertyName = "Monto_Bruto";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0.00";
            this.Monto_Bruto.DefaultCellStyle = dataGridViewCellStyle13;
            this.Monto_Bruto.HeaderText = "Sueldo Bruto";
            this.Monto_Bruto.Name = "Monto_Bruto";
            this.Monto_Bruto.ReadOnly = true;
            this.Monto_Bruto.Width = 130;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Total_Descuento";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "0.00";
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle14;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 120;
            // 
            // Monto_APagar
            // 
            this.Monto_APagar.DataPropertyName = "Monto_APagar";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0.00";
            this.Monto_APagar.DefaultCellStyle = dataGridViewCellStyle15;
            this.Monto_APagar.HeaderText = "Sueldo Neto";
            this.Monto_APagar.Name = "Monto_APagar";
            this.Monto_APagar.ReadOnly = true;
            this.Monto_APagar.Width = 120;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.HeaderText = "Ver Detalle";
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.ReadOnly = true;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseColumnTextForButtonValue = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFiltroNombre);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(927, 70);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrar Por nombre";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.AMostrar = null;
            this.txtFiltroNombre.autoSenTab = true;
            this.txtFiltroNombre.AValidar = null;
            this.txtFiltroNombre.CampoBusquedaID = "";
            this.txtFiltroNombre.CampoData = "";
            this.txtFiltroNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroNombre.ColumnasBusqGeneral = null;
            this.txtFiltroNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtFiltroNombre.Decimales = 0;
            this.txtFiltroNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFiltroNombre.DSData = null;
            this.txtFiltroNombre.EsAutoGenerado = false;
            this.txtFiltroNombre.EsBusqueda = false;
            this.txtFiltroNombre.EsBusquedaAutoIncremental = false;
            this.txtFiltroNombre.EsEditable = true;
            this.txtFiltroNombre.FiltroBusqueda = "";
            this.txtFiltroNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtFiltroNombre.Location = new System.Drawing.Point(3, 29);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.NombreTabla = "";
            this.txtFiltroNombre.SepDecimal = '\0';
            this.txtFiltroNombre.Size = new System.Drawing.Size(921, 33);
            this.txtFiltroNombre.TabIndex = 0;
            this.txtFiltroNombre.TablaOVistaBusqueda = "";
            this.txtFiltroNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtFiltroNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtFiltroNombre.ValorPorDefecto = "";
            this.txtFiltroNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroNombre_KeyUp);
            // 
            // FormGenerarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 519);
            this.Controls.Add(this.dtgNominaDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgNominaDetalle;
            this.EsConTemporal = true;
            this.Name = "FormGenerarNomina";
            this.TablaDetalle = "TTEMPORAL_NOMINAS_DETALLE";
            this.Text = "GENERAR NOMINA QUINCENA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGenerarNomina_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgNominaDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNominaDetalle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRDatePicker dtpFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtgNominaDetalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnVisualizar;
        private WinControl_ELR_NET.ELRTextBox txtDISR;
        private WinControl_ELR_NET.ELRTextBox txtDARL;
        private WinControl_ELR_NET.ELRTextBox txtDAFP;
        private WinControl_ELR_NET.ELRTextBox txtDARS;
        private WinControl_ELR_NET.ELRTextBox txtEINFOTEP;
        private WinControl_ELR_NET.ELRTextBox txtEARL;
        private WinControl_ELR_NET.ELRTextBox txtEAFP;
        private WinControl_ELR_NET.ELRTextBox txtEARS;
        private WinControl_ELR_NET.ELRTextBox txtNeto;
        private WinControl_ELR_NET.ELRTextBox txtDescto;
        private WinControl_ELR_NET.ELRTextBox txtSueldoBruto;
        private WinControl_ELR_NET.ELRTextBox txtSalarioMensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorTemp;
        private System.Windows.Forms.DataGridViewLinkColumn Empleado_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_APagar;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerDetalle;
        private System.Windows.Forms.GroupBox groupBox4;
        private WinControl_ELR_NET.ELRTextBox txtFiltroNombre;
    }
}