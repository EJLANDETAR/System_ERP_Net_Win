namespace WinControl_ELR_NET
{
    partial class FormPlantillaIndex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlantillaIndex));
            this.stbBarra = new System.Windows.Forms.StatusStrip();
            this.stlCantidadFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBusquedaAvanzada = new System.Windows.Forms.ToolStripButton();
            this.tsbSeleciona = new System.Windows.Forms.ToolStripButton();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCopiar = new System.Windows.Forms.ToolStripButton();
            this.tsbTXT = new System.Windows.Forms.ToolStripButton();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsmFilasAMostrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmFilas50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFilas200 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFilas100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFilas0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pnTotales = new System.Windows.Forms.Panel();
            this.lblCantidadRegistro = new System.Windows.Forms.Label();
            this.pnOpcionesBusqueda = new System.Windows.Forms.Panel();
            this.btnCerrarBusq = new System.Windows.Forms.Button();
            this.btnBusqAvanzada = new System.Windows.Forms.Button();
            this.chkNulos = new System.Windows.Forms.CheckBox();
            this.txtABuscar2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCondicion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCampos = new System.Windows.Forms.ComboBox();
            this.chkPorCampo = new System.Windows.Forms.CheckBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.chkPorEstatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkRangoFecha = new System.Windows.Forms.CheckBox();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.chkPorOficina = new System.Windows.Forms.CheckBox();
            this.pnBusqSencilla = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtABuscar = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.stbBarra.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnTotales.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbBarra
            // 
            this.stbBarra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlCantidadFilas,
            this.stlNombreUsuario});
            this.stbBarra.Location = new System.Drawing.Point(0, 546);
            this.stbBarra.Name = "stbBarra";
            this.stbBarra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stbBarra.Size = new System.Drawing.Size(1037, 22);
            this.stbBarra.TabIndex = 0;
            this.stbBarra.Text = "statusStrip1";
            // 
            // stlCantidadFilas
            // 
            this.stlCantidadFilas.Name = "stlCantidadFilas";
            this.stlCantidadFilas.Size = new System.Drawing.Size(72, 17);
            this.stlCantidadFilas.Text = "5,500 Filas";
            // 
            // stlNombreUsuario
            // 
            this.stlNombreUsuario.Name = "stlNombreUsuario";
            this.stlNombreUsuario.Size = new System.Drawing.Size(123, 17);
            this.stlNombreUsuario.Text = "NOMBRE.USUARIO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBusquedaAvanzada,
            this.tsbSeleciona,
            this.tsbAgregar,
            this.tsbModificar,
            this.tsbCopiar,
            this.tsbTXT,
            this.tsbExcel,
            this.tsbPreview,
            this.tsbImprimir,
            this.tsmFilasAMostrar,
            this.tsbSalir,
            this.tsProgressBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1037, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBusquedaAvanzada
            // 
            this.tsbBusquedaAvanzada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBusquedaAvanzada.Image = global::WinControl_ELR_NET.Properties.Resources.config;
            this.tsbBusquedaAvanzada.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBusquedaAvanzada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(5);
            this.tsbBusquedaAvanzada.Name = "tsbBusquedaAvanzada";
            this.tsbBusquedaAvanzada.Padding = new System.Windows.Forms.Padding(5);
            this.tsbBusquedaAvanzada.Size = new System.Drawing.Size(46, 42);
            this.tsbBusquedaAvanzada.Text = "Opciones Avanzadas(Ctrl + B)";
            this.tsbBusquedaAvanzada.Click += new System.EventHandler(this.tsbBusquedaAvanzada_Click);
            // 
            // tsbSeleciona
            // 
            this.tsbSeleciona.Image = global::WinControl_ELR_NET.Properties.Resources.check;
            this.tsbSeleciona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSeleciona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeleciona.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.tsbSeleciona.Name = "tsbSeleciona";
            this.tsbSeleciona.Padding = new System.Windows.Forms.Padding(5);
            this.tsbSeleciona.Size = new System.Drawing.Size(99, 47);
            this.tsbSeleciona.Text = "Elegir";
            this.tsbSeleciona.Click += new System.EventHandler(this.tsbSeleciona_Click);
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Padding = new System.Windows.Forms.Padding(5);
            this.tsbAgregar.Size = new System.Drawing.Size(96, 42);
            this.tsbAgregar.Text = "&Agregar";
            this.tsbAgregar.ToolTipText = "Agregar(Ctrl + N)";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = global::WinControl_ELR_NET.Properties.Resources.edit_property_26;
            this.tsbModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Margin = new System.Windows.Forms.Padding(5);
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Padding = new System.Windows.Forms.Padding(5);
            this.tsbModificar.Size = new System.Drawing.Size(104, 42);
            this.tsbModificar.Text = "&Modificar";
            this.tsbModificar.ToolTipText = "Modificar(Ctrl + M)";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbCopiar
            // 
            this.tsbCopiar.Image = global::WinControl_ELR_NET.Properties.Resources.Copy32x32;
            this.tsbCopiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopiar.Margin = new System.Windows.Forms.Padding(5);
            this.tsbCopiar.Name = "tsbCopiar";
            this.tsbCopiar.Padding = new System.Windows.Forms.Padding(5);
            this.tsbCopiar.Size = new System.Drawing.Size(93, 42);
            this.tsbCopiar.Text = "&Copiar";
            this.tsbCopiar.Click += new System.EventHandler(this.tsbCopiar_Click);
            // 
            // tsbTXT
            // 
            this.tsbTXT.Image = global::WinControl_ELR_NET.Properties.Resources.txt1;
            this.tsbTXT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTXT.Name = "tsbTXT";
            this.tsbTXT.Padding = new System.Windows.Forms.Padding(5);
            this.tsbTXT.Size = new System.Drawing.Size(127, 49);
            this.tsbTXT.Text = "Generar &TXT";
            this.tsbTXT.ToolTipText = "Generar Archivo TXT";
            this.tsbTXT.Click += new System.EventHandler(this.tsbTXT_Click);
            // 
            // tsbExcel
            // 
            this.tsbExcel.Image = global::WinControl_ELR_NET.Properties.Resources.excel1;
            this.tsbExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Margin = new System.Windows.Forms.Padding(5);
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Padding = new System.Windows.Forms.Padding(5);
            this.tsbExcel.Size = new System.Drawing.Size(134, 42);
            this.tsbExcel.Text = "Generar &Excel";
            this.tsbExcel.ToolTipText = "Generar Archivo EXCEL";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // tsbPreview
            // 
            this.tsbPreview.Image = global::WinControl_ELR_NET.Properties.Resources.preview;
            this.tsbPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Margin = new System.Windows.Forms.Padding(5);
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Padding = new System.Windows.Forms.Padding(5);
            this.tsbPreview.Size = new System.Drawing.Size(98, 42);
            this.tsbPreview.Text = "Preview";
            this.tsbPreview.Click += new System.EventHandler(this.tsbPreview_Click);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Image = global::WinControl_ELR_NET.Properties.Resources.print;
            this.tsbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(93, 49);
            this.tsbImprimir.Text = "&Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir(Ctrl + P)";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // tsmFilasAMostrar
            // 
            this.tsmFilasAMostrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFilas50,
            this.tsmFilas200,
            this.tsmFilas100,
            this.tsmFilas0});
            this.tsmFilasAMostrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmFilasAMostrar.Image = global::WinControl_ELR_NET.Properties.Resources.Menu___051;
            this.tsmFilasAMostrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmFilasAMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmFilasAMostrar.Name = "tsmFilasAMostrar";
            this.tsmFilasAMostrar.Size = new System.Drawing.Size(177, 52);
            this.tsmFilasAMostrar.Text = "Mostar 50 Filas";
            // 
            // tsmFilas50
            // 
            this.tsmFilas50.Name = "tsmFilas50";
            this.tsmFilas50.Size = new System.Drawing.Size(149, 24);
            this.tsmFilas50.Text = "50 Filas";
            this.tsmFilas50.Click += new System.EventHandler(this.tsmFilas50_Click);
            // 
            // tsmFilas200
            // 
            this.tsmFilas200.Name = "tsmFilas200";
            this.tsmFilas200.Size = new System.Drawing.Size(149, 24);
            this.tsmFilas200.Text = "200 Filas";
            this.tsmFilas200.Click += new System.EventHandler(this.tsmFilas200_Click);
            // 
            // tsmFilas100
            // 
            this.tsmFilas100.Name = "tsmFilas100";
            this.tsmFilas100.Size = new System.Drawing.Size(149, 24);
            this.tsmFilas100.Text = "1000 Filas";
            this.tsmFilas100.Click += new System.EventHandler(this.tsmFilas100_Click);
            // 
            // tsmFilas0
            // 
            this.tsmFilas0.Name = "tsmFilas0";
            this.tsmFilas0.Size = new System.Drawing.Size(149, 24);
            this.tsmFilas0.Text = "(Todos)";
            this.tsmFilas0.Click += new System.EventHandler(this.tsmFilas0_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = global::WinControl_ELR_NET.Properties.Resources._1379618331_exit;
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Margin = new System.Windows.Forms.Padding(5);
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(69, 36);
            this.tsbSalir.Text = "&Salir";
            this.tsbSalir.ToolTipText = "Salir(Ctrl + S)";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsProgressBar.AutoSize = false;
            this.tsProgressBar.AutoToolTip = true;
            this.tsProgressBar.Margin = new System.Windows.Forms.Padding(30, 2, 1, 1);
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsProgressBar.Size = new System.Drawing.Size(200, 49);
            this.tsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tsProgressBar.ToolTipText = "123456";
            this.tsProgressBar.Visible = false;
            // 
            // pnTotales
            // 
            this.pnTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTotales.Controls.Add(this.lblCantidadRegistro);
            this.pnTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTotales.Location = new System.Drawing.Point(0, 494);
            this.pnTotales.Name = "pnTotales";
            this.pnTotales.Size = new System.Drawing.Size(1037, 52);
            this.pnTotales.TabIndex = 2;
            this.pnTotales.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.AutoSize = true;
            this.lblCantidadRegistro.Location = new System.Drawing.Point(10, 11);
            this.lblCantidadRegistro.Name = "lblCantidadRegistro";
            this.lblCantidadRegistro.Size = new System.Drawing.Size(45, 16);
            this.lblCantidadRegistro.TabIndex = 0;
            this.lblCantidadRegistro.Text = "label6";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.AutoScroll = true;
            this.pnOpcionesBusqueda.BackColor = System.Drawing.Color.White;
            this.pnOpcionesBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnOpcionesBusqueda.Controls.Add(this.btnCerrarBusq);
            this.pnOpcionesBusqueda.Controls.Add(this.btnBusqAvanzada);
            this.pnOpcionesBusqueda.Controls.Add(this.chkNulos);
            this.pnOpcionesBusqueda.Controls.Add(this.txtABuscar2);
            this.pnOpcionesBusqueda.Controls.Add(this.label5);
            this.pnOpcionesBusqueda.Controls.Add(this.cboCondicion);
            this.pnOpcionesBusqueda.Controls.Add(this.label4);
            this.pnOpcionesBusqueda.Controls.Add(this.cboCampos);
            this.pnOpcionesBusqueda.Controls.Add(this.chkPorCampo);
            this.pnOpcionesBusqueda.Controls.Add(this.cboEstatus);
            this.pnOpcionesBusqueda.Controls.Add(this.chkPorEstatus);
            this.pnOpcionesBusqueda.Controls.Add(this.label3);
            this.pnOpcionesBusqueda.Controls.Add(this.dtpFechaHasta);
            this.pnOpcionesBusqueda.Controls.Add(this.label2);
            this.pnOpcionesBusqueda.Controls.Add(this.dtpFechaDesde);
            this.pnOpcionesBusqueda.Controls.Add(this.chkRangoFecha);
            this.pnOpcionesBusqueda.Controls.Add(this.cboOficina);
            this.pnOpcionesBusqueda.Controls.Add(this.chkPorOficina);
            this.pnOpcionesBusqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOpcionesBusqueda.Location = new System.Drawing.Point(0, 52);
            this.pnOpcionesBusqueda.Name = "pnOpcionesBusqueda";
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            this.pnOpcionesBusqueda.TabIndex = 3;
            // 
            // btnCerrarBusq
            // 
            this.btnCerrarBusq.Location = new System.Drawing.Point(228, 381);
            this.btnCerrarBusq.Name = "btnCerrarBusq";
            this.btnCerrarBusq.Size = new System.Drawing.Size(63, 24);
            this.btnCerrarBusq.TabIndex = 17;
            this.btnCerrarBusq.Text = "Ocultar";
            this.btnCerrarBusq.UseVisualStyleBackColor = true;
            this.btnCerrarBusq.Click += new System.EventHandler(this.btnCerrarBusq_Click);
            // 
            // btnBusqAvanzada
            // 
            this.btnBusqAvanzada.Location = new System.Drawing.Point(159, 381);
            this.btnBusqAvanzada.Name = "btnBusqAvanzada";
            this.btnBusqAvanzada.Size = new System.Drawing.Size(63, 25);
            this.btnBusqAvanzada.TabIndex = 16;
            this.btnBusqAvanzada.Text = "Buscar";
            this.btnBusqAvanzada.UseVisualStyleBackColor = true;
            this.btnBusqAvanzada.Click += new System.EventHandler(this.btnBusqAvanzada_Click);
            // 
            // chkNulos
            // 
            this.chkNulos.AutoSize = true;
            this.chkNulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNulos.Location = new System.Drawing.Point(13, 386);
            this.chkNulos.Name = "chkNulos";
            this.chkNulos.Size = new System.Drawing.Size(117, 20);
            this.chkNulos.TabIndex = 15;
            this.chkNulos.Text = "Excluir Nulos";
            this.chkNulos.UseVisualStyleBackColor = true;
            // 
            // txtABuscar2
            // 
            this.txtABuscar2.Location = new System.Drawing.Point(109, 292);
            this.txtABuscar2.Multiline = true;
            this.txtABuscar2.Name = "txtABuscar2";
            this.txtABuscar2.Size = new System.Drawing.Size(182, 83);
            this.txtABuscar2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "A Buscar";
            // 
            // cboCondicion
            // 
            this.cboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.Items.AddRange(new object[] {
            "",
            "Igual",
            "Que Contenga",
            "Mayor o Igual",
            "Menor o Igual",
            "Comienza en",
            "Termina En"});
            this.cboCondicion.Location = new System.Drawing.Point(109, 258);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(182, 24);
            this.cboCondicion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Condicion";
            // 
            // cboCampos
            // 
            this.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampos.FormattingEnabled = true;
            this.cboCampos.Location = new System.Drawing.Point(109, 229);
            this.cboCampos.Name = "cboCampos";
            this.cboCampos.Size = new System.Drawing.Size(182, 24);
            this.cboCampos.TabIndex = 10;
            // 
            // chkPorCampo
            // 
            this.chkPorCampo.AutoSize = true;
            this.chkPorCampo.Location = new System.Drawing.Point(13, 229);
            this.chkPorCampo.Name = "chkPorCampo";
            this.chkPorCampo.Size = new System.Drawing.Size(95, 20);
            this.chkPorCampo.TabIndex = 9;
            this.chkPorCampo.Text = "Por Campo";
            this.chkPorCampo.UseVisualStyleBackColor = true;
            this.chkPorCampo.CheckedChanged += new System.EventHandler(this.chkPorOficina_CheckedChanged);
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(28, 187);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(263, 24);
            this.cboEstatus.TabIndex = 8;
            // 
            // chkPorEstatus
            // 
            this.chkPorEstatus.AutoSize = true;
            this.chkPorEstatus.Location = new System.Drawing.Point(13, 161);
            this.chkPorEstatus.Name = "chkPorEstatus";
            this.chkPorEstatus.Size = new System.Drawing.Size(95, 20);
            this.chkPorEstatus.TabIndex = 7;
            this.chkPorEstatus.Text = "Por Estatus";
            this.chkPorEstatus.UseVisualStyleBackColor = true;
            this.chkPorEstatus.CheckedChanged += new System.EventHandler(this.chkPorOficina_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(109, 133);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(182, 22);
            this.dtpFechaHasta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(109, 105);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(182, 22);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // chkRangoFecha
            // 
            this.chkRangoFecha.AutoSize = true;
            this.chkRangoFecha.Location = new System.Drawing.Point(13, 79);
            this.chkRangoFecha.Name = "chkRangoFecha";
            this.chkRangoFecha.Size = new System.Drawing.Size(109, 20);
            this.chkRangoFecha.TabIndex = 2;
            this.chkRangoFecha.Text = "Rango Fecha";
            this.chkRangoFecha.UseVisualStyleBackColor = true;
            this.chkRangoFecha.CheckedChanged += new System.EventHandler(this.chkPorOficina_CheckedChanged);
            // 
            // cboOficina
            // 
            this.cboOficina.AValidar = null;
            this.cboOficina.CampoData = "";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficina.DSData = null;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(28, 40);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(263, 24);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 1;
            this.cboOficina.TablaOVistaConsulta = "";
            this.cboOficina.UsaDataGlobal = false;
            this.cboOficina.ValorPorDefecto = "0";
            // 
            // chkPorOficina
            // 
            this.chkPorOficina.AutoSize = true;
            this.chkPorOficina.Location = new System.Drawing.Point(13, 14);
            this.chkPorOficina.Name = "chkPorOficina";
            this.chkPorOficina.Size = new System.Drawing.Size(92, 20);
            this.chkPorOficina.TabIndex = 0;
            this.chkPorOficina.Text = "Por Oficina";
            this.chkPorOficina.UseVisualStyleBackColor = true;
            this.chkPorOficina.CheckedChanged += new System.EventHandler(this.chkPorOficina_CheckedChanged);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBusqSencilla.Controls.Add(this.btnBuscar);
            this.pnBusqSencilla.Controls.Add(this.txtABuscar);
            this.pnBusqSencilla.Controls.Add(this.label1);
            this.pnBusqSencilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBusqSencilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Name = "pnBusqSencilla";
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 46);
            this.pnBusqSencilla.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::WinControl_ELR_NET.Properties.Resources._1378160672_search;
            this.btnBuscar.Location = new System.Drawing.Point(380, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtABuscar
            // 
            this.txtABuscar.AMostrar = null;
            this.txtABuscar.AValidar = null;
            this.txtABuscar.CampoBusquedaID = "";
            this.txtABuscar.CampoData = "";
            this.txtABuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtABuscar.ColumnasBusqGeneral = null;
            this.txtABuscar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.Decimales = 0;
            this.txtABuscar.DSData = null;
            this.txtABuscar.EsAutoGenerado = false;
            this.txtABuscar.EsBusqueda = false;
            this.txtABuscar.EsBusquedaAutoIncremental = false;
            this.txtABuscar.EsEditable = true;
            this.txtABuscar.FiltroBusqueda = "";
            this.txtABuscar.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtABuscar.Location = new System.Drawing.Point(111, 6);
            this.txtABuscar.Name = "txtABuscar";
            this.txtABuscar.NombreTabla = "";
            this.txtABuscar.SepDecimal = '\0';
            this.txtABuscar.Size = new System.Drawing.Size(263, 26);
            this.txtABuscar.TabIndex = 1;
            this.txtABuscar.TablaOVistaBusqueda = "";
            this.txtABuscar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtABuscar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtABuscar.ValorPorDefecto = "";
            this.txtABuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtABuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Buscar:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FormPlantillaIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.pnBusqSencilla);
            this.Controls.Add(this.pnOpcionesBusqueda);
            this.Controls.Add(this.pnTotales);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stbBarra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPlantillaIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlantillaIndex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlantillaIndex_FormClosed);
            this.Load += new System.EventHandler(this.FormPlantillaIndex_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPlantillaIndex_KeyDown);
            this.stbBarra.ResumeLayout(false);
            this.stbBarra.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip stbBarra;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbAgregar;
        public System.Windows.Forms.ToolStripButton tsbModificar;
        public System.Windows.Forms.ToolStripButton tsbSalir;
        public System.Windows.Forms.Panel pnTotales;
        private System.Windows.Forms.ToolStripStatusLabel stlCantidadFilas;
        private System.Windows.Forms.ToolStripStatusLabel stlNombreUsuario;
        public System.Windows.Forms.Panel pnBusqSencilla;
        private System.Windows.Forms.CheckBox chkPorOficina;
        private ELRCombobox cboOficina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPorCampo;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.CheckBox chkPorEstatus;
        private System.Windows.Forms.TextBox txtABuscar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCampos;
        private System.Windows.Forms.Button btnCerrarBusq;
        private System.Windows.Forms.Button btnBusqAvanzada;
        private System.Windows.Forms.CheckBox chkNulos;
        public ELRTextBox txtABuscar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCantidadRegistro;
        public System.Windows.Forms.ToolStripButton tsbImprimir;
        public System.Windows.Forms.ToolStripButton tsbBusquedaAvanzada;
        public System.Windows.Forms.Panel pnOpcionesBusqueda;
        public System.Windows.Forms.CheckBox chkRangoFecha;
        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ToolStripMenuItem tsmFilas50;
        private System.Windows.Forms.ToolStripMenuItem tsmFilas200;
        private System.Windows.Forms.ToolStripMenuItem tsmFilas100;
        private System.Windows.Forms.ToolStripMenuItem tsmFilas0;
        private System.Windows.Forms.ToolStripButton tsbSeleciona;
        public System.Windows.Forms.ToolStripDropDownButton tsmFilasAMostrar;
        public System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        public System.Windows.Forms.ToolStripButton tsbExcel;
        public System.Windows.Forms.ToolStripButton tsbTXT;
        private System.Windows.Forms.ToolStripButton tsbCopiar;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton tsbPreview;
        //public System.Windows.Forms.CheckBox chkPorCampo;
    }
}