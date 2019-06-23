namespace ELRControlUsuarios
{
    partial class FormOpcionesXRol
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAplicarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAplicarFila = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuitarFila = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmQuitarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsConsulta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsInsertar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsModificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsAnular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsCambiar_Fecha = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsAprobar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsRechazar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsGenerar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMenuPrincipal = new WinControl_ELR_NET.ELRCombobox();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.btnAplicarTodos = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 476);
            this.pnBotones.Size = new System.Drawing.Size(1043, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(803, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(944, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(708, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(613, 39);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAplicarTodos,
            this.toolStripMenuItem1,
            this.tsmAplicarFila,
            this.tsmQuitarFila,
            this.toolStripMenuItem2,
            this.tsmQuitarTodos});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 104);
            // 
            // tsmAplicarTodos
            // 
            this.tsmAplicarTodos.Name = "tsmAplicarTodos";
            this.tsmAplicarTodos.Size = new System.Drawing.Size(220, 22);
            this.tsmAplicarTodos.Text = "Aplicar Todos";
            this.tsmAplicarTodos.Click += new System.EventHandler(this.AplicarPermisos);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 6);
            // 
            // tsmAplicarFila
            // 
            this.tsmAplicarFila.Name = "tsmAplicarFila";
            this.tsmAplicarFila.Size = new System.Drawing.Size(220, 22);
            this.tsmAplicarFila.Text = "Aplicar Permisos Fila Actual";
            this.tsmAplicarFila.Click += new System.EventHandler(this.AplicarPermisos);
            // 
            // tsmQuitarFila
            // 
            this.tsmQuitarFila.Name = "tsmQuitarFila";
            this.tsmQuitarFila.Size = new System.Drawing.Size(220, 22);
            this.tsmQuitarFila.Text = "Quitar Permisos Fila Actual";
            this.tsmQuitarFila.Click += new System.EventHandler(this.AplicarPermisos);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 6);
            // 
            // tsmQuitarTodos
            // 
            this.tsmQuitarTodos.Name = "tsmQuitarTodos";
            this.tsmQuitarTodos.Size = new System.Drawing.Size(220, 22);
            this.tsmQuitarTodos.Text = "Quitar Todos";
            this.tsmQuitarTodos.Click += new System.EventHandler(this.AplicarPermisos);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 476);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opciones Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Menu_Id,
            this.Nombre_Menu,
            this.EsActivo,
            this.EsConsulta,
            this.EsInsertar,
            this.EsModificar,
            this.EsAnular,
            this.EsCambiar_Fecha,
            this.EsAprobar,
            this.EsRechazar,
            this.EsGenerar});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 382);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.Visible = false;
            // 
            // Menu_Id
            // 
            this.Menu_Id.DataPropertyName = "Menu_Id";
            this.Menu_Id.HeaderText = "Id";
            this.Menu_Id.Name = "Menu_Id";
            this.Menu_Id.ReadOnly = true;
            this.Menu_Id.Width = 70;
            // 
            // Nombre_Menu
            // 
            this.Nombre_Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Menu.DataPropertyName = "Nombre_Menu";
            this.Nombre_Menu.HeaderText = "Nombre";
            this.Nombre_Menu.Name = "Nombre_Menu";
            this.Nombre_Menu.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "Activo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.Visible = false;
            // 
            // EsConsulta
            // 
            this.EsConsulta.DataPropertyName = "EsConsulta";
            this.EsConsulta.HeaderText = "Consulta";
            this.EsConsulta.Name = "EsConsulta";
            this.EsConsulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsConsulta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsConsulta.Width = 90;
            // 
            // EsInsertar
            // 
            this.EsInsertar.DataPropertyName = "EsInsertar";
            this.EsInsertar.HeaderText = "Inserta";
            this.EsInsertar.Name = "EsInsertar";
            this.EsInsertar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsInsertar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsInsertar.Width = 80;
            // 
            // EsModificar
            // 
            this.EsModificar.DataPropertyName = "EsModificar";
            this.EsModificar.HeaderText = "Modifica";
            this.EsModificar.Name = "EsModificar";
            this.EsModificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsModificar.Width = 80;
            // 
            // EsAnular
            // 
            this.EsAnular.DataPropertyName = "EsAnular";
            this.EsAnular.HeaderText = "Anula";
            this.EsAnular.Name = "EsAnular";
            this.EsAnular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsAnular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsAnular.Width = 80;
            // 
            // EsCambiar_Fecha
            // 
            this.EsCambiar_Fecha.DataPropertyName = "EsCambiar_Fecha";
            this.EsCambiar_Fecha.HeaderText = "M. Fecha";
            this.EsCambiar_Fecha.Name = "EsCambiar_Fecha";
            this.EsCambiar_Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsCambiar_Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsCambiar_Fecha.ToolTipText = "Modifica Fecha";
            this.EsCambiar_Fecha.Width = 95;
            // 
            // EsAprobar
            // 
            this.EsAprobar.DataPropertyName = "EsAprobar";
            this.EsAprobar.HeaderText = "Aprobar";
            this.EsAprobar.Name = "EsAprobar";
            this.EsAprobar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsAprobar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsAprobar.Width = 80;
            // 
            // EsRechazar
            // 
            this.EsRechazar.DataPropertyName = "EsRechazar";
            this.EsRechazar.HeaderText = "Rechaza";
            this.EsRechazar.Name = "EsRechazar";
            this.EsRechazar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsRechazar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsRechazar.Width = 80;
            // 
            // EsGenerar
            // 
            this.EsGenerar.DataPropertyName = "EsGenerar";
            this.EsGenerar.HeaderText = "Genera";
            this.EsGenerar.Name = "EsGenerar";
            this.EsGenerar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsGenerar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsGenerar.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAplicarTodos);
            this.panel1.Controls.Add(this.btnQuitarTodos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboMenuPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 54);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Principal:";
            // 
            // cboMenuPrincipal
            // 
            this.cboMenuPrincipal.AValidar = null;
            this.cboMenuPrincipal.CampoData = "";
            this.cboMenuPrincipal.CampoJoinCombobox2 = "";
            this.cboMenuPrincipal.ComboboxAFiltrar = null;
            this.cboMenuPrincipal.DisplayMember = "Carpeta";
            this.cboMenuPrincipal.DSData = null;
            this.cboMenuPrincipal.EsEditable = true;
            this.cboMenuPrincipal.FiltroBusqueda = "EsActivo = 1";
            this.cboMenuPrincipal.FormattingEnabled = true;
            this.cboMenuPrincipal.Location = new System.Drawing.Point(186, 8);
            this.cboMenuPrincipal.Name = "cboMenuPrincipal";
            this.cboMenuPrincipal.NombreTabla = "";
            this.cboMenuPrincipal.Size = new System.Drawing.Size(366, 33);
            this.cboMenuPrincipal.SSQL = "";
            this.cboMenuPrincipal.TabIndex = 0;
            this.cboMenuPrincipal.TablaOVistaConsulta = "TSISTEMA_MODULOS";
            this.cboMenuPrincipal.UsaDataGlobal = false;
            this.cboMenuPrincipal.ValorPorDefecto = "0";
            this.cboMenuPrincipal.ValueMember = "Modulo_Id";
            this.cboMenuPrincipal.SelectedIndexChanged += new System.EventHandler(this.cboMenuPrincipal_SelectedIndexChanged);
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuitarTodos.Location = new System.Drawing.Point(878, 0);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(147, 50);
            this.btnQuitarTodos.TabIndex = 2;
            this.btnQuitarTodos.Text = "Quitar Todos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnAplicarTodos_Click);
            // 
            // btnAplicarTodos
            // 
            this.btnAplicarTodos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAplicarTodos.Location = new System.Drawing.Point(731, 0);
            this.btnAplicarTodos.Name = "btnAplicarTodos";
            this.btnAplicarTodos.Size = new System.Drawing.Size(147, 50);
            this.btnAplicarTodos.TabIndex = 3;
            this.btnAplicarTodos.Text = "Aplicar Todos";
            this.btnAplicarTodos.UseVisualStyleBackColor = true;
            this.btnAplicarTodos.Click += new System.EventHandler(this.btnAplicarTodos_Click);
            // 
            // FormOpcionesXRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 519);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.LCamposPostearDetalle = "esActivo;EsConsulta;EsInsertar;EsModificar;EsAnular;EsCambiar_Fecha;EsAprobar;EsR" +
    "echazar;EsGenerar";
            this.Name = "FormOpcionesXRol";
            this.OmitirMetodosDataGrid = true;
            this.SPGraba = " SP_GRABA_OPCIONES_ROL";
            this.TablaDetalle = "TTEMPORAL_OPCIONES_X_ROLES";
            this.Text = "APLICAR OPCIONES A ROL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOpcionesXRol_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAplicarTodos;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAplicarFila;
        private System.Windows.Forms.ToolStripMenuItem tsmQuitarFila;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmQuitarTodos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRCombobox cboMenuPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Menu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsConsulta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsInsertar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsModificar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsAnular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsCambiar_Fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsAprobar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsRechazar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsGenerar;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.Button btnAplicarTodos;
    }
}