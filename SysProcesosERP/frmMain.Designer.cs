namespace SysProcesosERP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verHistoricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarAColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verScheduleProgramacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLabelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerEjecutaProcesos = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbProcess = new System.Windows.Forms.PictureBox();
            this.lblEnEjecusion = new System.Windows.Forms.Label();
            this.lblCantidadActivos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTareas = new System.Windows.Forms.ComboBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPHistorial = new System.Windows.Forms.TabPage();
            this.dtgHistorico = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkAutoRefresh = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFeHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFeDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPErrores = new System.Windows.Forms.TabPage();
            this.dtgErrores = new System.Windows.Forms.DataGridView();
            this.UnicoError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Adicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnErrorImprimir = new System.Windows.Forms.Button();
            this.btnErrorBuscar = new System.Windows.Forms.Button();
            this.dtpError2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpError1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProcess)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrores)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Receipt.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.ejecutarToolStripMenuItem.Text = "Ver tareas programadas (Schedule)";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verHistoricoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.agregarAColaToolStripMenuItem,
            this.verScheduleProgramacionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 76);
            // 
            // verHistoricoToolStripMenuItem
            // 
            this.verHistoricoToolStripMenuItem.Name = "verHistoricoToolStripMenuItem";
            this.verHistoricoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.verHistoricoToolStripMenuItem.Text = "Ver Historico";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 6);
            // 
            // agregarAColaToolStripMenuItem
            // 
            this.agregarAColaToolStripMenuItem.Name = "agregarAColaToolStripMenuItem";
            this.agregarAColaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarAColaToolStripMenuItem.Text = "Agregar a Cola";
            // 
            // verScheduleProgramacionToolStripMenuItem
            // 
            this.verScheduleProgramacionToolStripMenuItem.Name = "verScheduleProgramacionToolStripMenuItem";
            this.verScheduleProgramacionToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.verScheduleProgramacionToolStripMenuItem.Text = "Ver Schedule (Programacion)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLabelFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLabelFecha
            // 
            this.stLabelFecha.Name = "stLabelFecha";
            this.stLabelFecha.Size = new System.Drawing.Size(53, 20);
            this.stLabelFecha.Text = "Fecha:";
            // 
            // timerEjecutaProcesos
            // 
            this.timerEjecutaProcesos.Enabled = true;
            this.timerEjecutaProcesos.Interval = 5000;
            this.timerEjecutaProcesos.Tick += new System.EventHandler(this.timerEjecutaProcesos_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ptbProcess);
            this.panel1.Controls.Add(this.lblEnEjecusion);
            this.panel1.Controls.Add(this.lblCantidadActivos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboTareas);
            this.panel1.Controls.Add(this.btnAgregarTarea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 74);
            this.panel1.TabIndex = 5;
            // 
            // ptbProcess
            // 
            this.ptbProcess.Image = global::SysProcesosERP.Properties.Resources.loading__1_;
            this.ptbProcess.Location = new System.Drawing.Point(907, 8);
            this.ptbProcess.Name = "ptbProcess";
            this.ptbProcess.Size = new System.Drawing.Size(86, 58);
            this.ptbProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProcess.TabIndex = 11;
            this.ptbProcess.TabStop = false;
            this.ptbProcess.Visible = false;
            // 
            // lblEnEjecusion
            // 
            this.lblEnEjecusion.AutoSize = true;
            this.lblEnEjecusion.Location = new System.Drawing.Point(532, 11);
            this.lblEnEjecusion.Name = "lblEnEjecusion";
            this.lblEnEjecusion.Size = new System.Drawing.Size(339, 21);
            this.lblEnEjecusion.TabIndex = 10;
            this.lblEnEjecusion.Text = "En ejecusion desde: 00/00/0000 00:mm:ss tt";
            // 
            // lblCantidadActivos
            // 
            this.lblCantidadActivos.AutoSize = true;
            this.lblCantidadActivos.Location = new System.Drawing.Point(532, 32);
            this.lblCantidadActivos.Name = "lblCantidadActivos";
            this.lblCantidadActivos.Size = new System.Drawing.Size(227, 21);
            this.lblCantidadActivos.TabIndex = 9;
            this.lblCantidadActivos.Text = "Cantidad Procesos Activos: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proceso:";
            // 
            // cboTareas
            // 
            this.cboTareas.DropDownWidth = 500;
            this.cboTareas.FormattingEnabled = true;
            this.cboTareas.Location = new System.Drawing.Point(18, 32);
            this.cboTareas.Name = "cboTareas";
            this.cboTareas.Size = new System.Drawing.Size(342, 29);
            this.cboTareas.TabIndex = 6;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(377, 8);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(117, 53);
            this.btnAgregarTarea.TabIndex = 7;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPHistorial);
            this.tabControl1.Controls.Add(this.tabPErrores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 399);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPHistorial
            // 
            this.tabPHistorial.Controls.Add(this.dtgHistorico);
            this.tabPHistorial.Controls.Add(this.panel2);
            this.tabPHistorial.Location = new System.Drawing.Point(4, 30);
            this.tabPHistorial.Name = "tabPHistorial";
            this.tabPHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPHistorial.Size = new System.Drawing.Size(999, 365);
            this.tabPHistorial.TabIndex = 0;
            this.tabPHistorial.Text = "Historial";
            this.tabPHistorial.UseVisualStyleBackColor = true;
            // 
            // dtgHistorico
            // 
            this.dtgHistorico.AllowUserToAddRows = false;
            this.dtgHistorico.AllowUserToDeleteRows = false;
            this.dtgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Descripcion,
            this.Fecha_Inicio,
            this.Fecha_Fin,
            this.Estatus,
            this.Comentario});
            this.dtgHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgHistorico.Location = new System.Drawing.Point(3, 85);
            this.dtgHistorico.MultiSelect = false;
            this.dtgHistorico.Name = "dtgHistorico";
            this.dtgHistorico.ReadOnly = true;
            this.dtgHistorico.RowTemplate.Height = 33;
            this.dtgHistorico.Size = new System.Drawing.Size(993, 277);
            this.dtgHistorico.TabIndex = 3;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.DataPropertyName = "Fecha_Inicio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm:ss tt";
            this.Fecha_Inicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha_Inicio.HeaderText = "Fe.Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            this.Fecha_Inicio.Width = 200;
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.DataPropertyName = "Fecha_Fin";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy hh:mm:ss tt";
            this.Fecha_Fin.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha_Fin.HeaderText = "Fe.Fin";
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.ReadOnly = true;
            this.Fecha_Fin.Width = 200;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 200;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkAutoRefresh);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.dtpFeHasta);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFeDesde);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 82);
            this.panel2.TabIndex = 2;
            // 
            // chkAutoRefresh
            // 
            this.chkAutoRefresh.AutoSize = true;
            this.chkAutoRefresh.Checked = true;
            this.chkAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRefresh.Location = new System.Drawing.Point(113, 45);
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.Size = new System.Drawing.Size(193, 25);
            this.chkAutoRefresh.TabIndex = 6;
            this.chkAutoRefresh.Text = "Auto Refrescar Historial";
            this.chkAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(633, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(98, 38);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(529, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 38);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFeHasta
            // 
            this.dtpFeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeHasta.Location = new System.Drawing.Point(370, 10);
            this.dtpFeHasta.Name = "dtpFeHasta";
            this.dtpFeHasta.Size = new System.Drawing.Size(153, 29);
            this.dtpFeHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtpFeDesde
            // 
            this.dtpFeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeDesde.Location = new System.Drawing.Point(113, 10);
            this.dtpFeDesde.Name = "dtpFeDesde";
            this.dtpFeDesde.Size = new System.Drawing.Size(153, 29);
            this.dtpFeDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            // 
            // tabPErrores
            // 
            this.tabPErrores.Controls.Add(this.dtgErrores);
            this.tabPErrores.Controls.Add(this.panel3);
            this.tabPErrores.Location = new System.Drawing.Point(4, 30);
            this.tabPErrores.Name = "tabPErrores";
            this.tabPErrores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPErrores.Size = new System.Drawing.Size(999, 305);
            this.tabPErrores.TabIndex = 1;
            this.tabPErrores.Text = "Mensajes";
            this.tabPErrores.UseVisualStyleBackColor = true;
            // 
            // dtgErrores
            // 
            this.dtgErrores.AllowUserToAddRows = false;
            this.dtgErrores.AllowUserToDeleteRows = false;
            this.dtgErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnicoError,
            this.Tipo_Error,
            this.Fecha_Adicionado,
            this.Mensaje});
            this.dtgErrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgErrores.Location = new System.Drawing.Point(3, 63);
            this.dtgErrores.MultiSelect = false;
            this.dtgErrores.Name = "dtgErrores";
            this.dtgErrores.ReadOnly = true;
            this.dtgErrores.RowHeadersWidth = 30;
            this.dtgErrores.RowTemplate.Height = 33;
            this.dtgErrores.Size = new System.Drawing.Size(993, 239);
            this.dtgErrores.TabIndex = 4;
            // 
            // UnicoError
            // 
            this.UnicoError.DataPropertyName = "Unico";
            this.UnicoError.HeaderText = "Unico";
            this.UnicoError.Name = "UnicoError";
            this.UnicoError.ReadOnly = true;
            this.UnicoError.Visible = false;
            // 
            // Tipo_Error
            // 
            this.Tipo_Error.DataPropertyName = "Tipo_Error";
            this.Tipo_Error.HeaderText = "Tipo_Error";
            this.Tipo_Error.Name = "Tipo_Error";
            this.Tipo_Error.ReadOnly = true;
            this.Tipo_Error.Visible = false;
            // 
            // Fecha_Adicionado
            // 
            this.Fecha_Adicionado.DataPropertyName = "Fecha_Adicionado";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy hh:mm:ss tt";
            this.Fecha_Adicionado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fecha_Adicionado.HeaderText = "Fecha";
            this.Fecha_Adicionado.Name = "Fecha_Adicionado";
            this.Fecha_Adicionado.ReadOnly = true;
            this.Fecha_Adicionado.Width = 200;
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mensaje.DataPropertyName = "Mensaje";
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnErrorImprimir);
            this.panel3.Controls.Add(this.btnErrorBuscar);
            this.panel3.Controls.Add(this.dtpError2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpError1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 60);
            this.panel3.TabIndex = 3;
            // 
            // btnErrorImprimir
            // 
            this.btnErrorImprimir.Location = new System.Drawing.Point(633, 10);
            this.btnErrorImprimir.Name = "btnErrorImprimir";
            this.btnErrorImprimir.Size = new System.Drawing.Size(98, 38);
            this.btnErrorImprimir.TabIndex = 5;
            this.btnErrorImprimir.Text = "Imprimir";
            this.btnErrorImprimir.UseVisualStyleBackColor = true;
            // 
            // btnErrorBuscar
            // 
            this.btnErrorBuscar.Location = new System.Drawing.Point(529, 10);
            this.btnErrorBuscar.Name = "btnErrorBuscar";
            this.btnErrorBuscar.Size = new System.Drawing.Size(98, 38);
            this.btnErrorBuscar.TabIndex = 4;
            this.btnErrorBuscar.Text = "Buscar";
            this.btnErrorBuscar.UseVisualStyleBackColor = true;
            this.btnErrorBuscar.Click += new System.EventHandler(this.btnErrorBuscar_Click);
            // 
            // dtpError2
            // 
            this.dtpError2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpError2.Location = new System.Drawing.Point(370, 10);
            this.dtpError2.Name = "dtpError2";
            this.dtpError2.Size = new System.Drawing.Size(153, 29);
            this.dtpError2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // dtpError1
            // 
            this.dtpError1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpError1.Location = new System.Drawing.Point(113, 10);
            this.dtpError1.Name = "dtpError1";
            this.dtpError1.Size = new System.Drawing.Size(153, 29);
            this.dtpError1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha Desde:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 527);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "SystemERP, PROCESOS INTERNOS DEL SISTEMA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProcess)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPErrores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verHistoricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarAColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verScheduleProgramacionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerEjecutaProcesos;
        private System.Windows.Forms.ToolStripStatusLabel stLabelFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTareas;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPHistorial;
        private System.Windows.Forms.DataGridView dtgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkAutoRefresh;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFeHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFeDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPErrores;
        private System.Windows.Forms.DataGridView dtgErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnicoError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Adicionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnErrorImprimir;
        private System.Windows.Forms.Button btnErrorBuscar;
        private System.Windows.Forms.DateTimePicker dtpError2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpError1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadActivos;
        private System.Windows.Forms.Label lblEnEjecusion;
        private System.Windows.Forms.PictureBox ptbProcess;
    }
}

