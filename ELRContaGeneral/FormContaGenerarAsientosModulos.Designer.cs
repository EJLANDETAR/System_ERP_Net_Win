namespace ELRContaGeneral
{
    partial class FormContaGenerarAsientos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMarcarTodos = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtABuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboModulo = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgOpciones = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAplicar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnIrACuentaEnlace = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnIrACuentaEnlace);
            this.pnBotones.Location = new System.Drawing.Point(0, 448);
            this.pnBotones.Size = new System.Drawing.Size(940, 58);
            this.pnBotones.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnGrabar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnSiguientePage, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAnterior, 0);
            this.pnBotones.Controls.SetChildIndex(this.lblNombreUsuario, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnIrACuentaEnlace, 0);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(668, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 54);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(809, 0);
            this.btnCancelar.Size = new System.Drawing.Size(127, 54);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(53, 0);
            this.btnAnterior.Size = new System.Drawing.Size(77, 54);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(573, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 54);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(130, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(443, 54);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkMarcarTodos);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 127);
            this.panel1.TabIndex = 1;
            // 
            // chkMarcarTodos
            // 
            this.chkMarcarTodos.AutoSize = true;
            this.chkMarcarTodos.Checked = true;
            this.chkMarcarTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMarcarTodos.Location = new System.Drawing.Point(570, 25);
            this.chkMarcarTodos.Name = "chkMarcarTodos";
            this.chkMarcarTodos.Size = new System.Drawing.Size(122, 25);
            this.chkMarcarTodos.TabIndex = 1;
            this.chkMarcarTodos.Text = "Marcar Todos";
            this.chkMarcarTodos.UseVisualStyleBackColor = true;
            this.chkMarcarTodos.CheckedChanged += new System.EventHandler(this.chkMarcarTodos_CheckedChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(570, 65);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(349, 50);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtABuscar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtpFechaHasta);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpFechaDesde);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboModulo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 123);
            this.panel3.TabIndex = 0;
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(116, 45);
            this.txtABuscar.Name = "txtABuscar";
            this.txtABuscar.Size = new System.Drawing.Size(433, 29);
            this.txtABuscar.TabIndex = 3;
            this.txtABuscar.TextChanged += new System.EventHandler(this.txtABuscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "A Buscar:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(404, 80);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(145, 29);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(116, 80);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(145, 29);
            this.dtpFechaDesde.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Desde:";
            // 
            // cboModulo
            // 
            this.cboModulo.AValidar = null;
            this.cboModulo.CampoData = "";
            this.cboModulo.CampoJoinCombobox2 = "";
            this.cboModulo.ComboboxAFiltrar = null;
            this.cboModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModulo.DSData = null;
            this.cboModulo.EsEditable = true;
            this.cboModulo.FiltroBusqueda = "";
            this.cboModulo.FormattingEnabled = true;
            this.cboModulo.Location = new System.Drawing.Point(116, 10);
            this.cboModulo.Name = "cboModulo";
            this.cboModulo.NombreTabla = "";
            this.cboModulo.Size = new System.Drawing.Size(433, 29);
            this.cboModulo.SSQL = "";
            this.cboModulo.TabIndex = 1;
            this.cboModulo.TablaOVistaConsulta = "";
            this.cboModulo.UsaDataGlobal = false;
            this.cboModulo.ValorPorDefecto = "0";
            this.cboModulo.SelectedValueChanged += new System.EventHandler(this.cboModulo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo:";
            // 
            // dtgOpciones
            // 
            this.dtgOpciones.AllowUserToAddRows = false;
            this.dtgOpciones.AllowUserToDeleteRows = false;
            this.dtgOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOpciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Modulo_Id,
            this.Descripcion,
            this.EsAplicar});
            this.dtgOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOpciones.Location = new System.Drawing.Point(0, 127);
            this.dtgOpciones.Name = "dtgOpciones";
            this.dtgOpciones.RowHeadersWidth = 28;
            this.dtgOpciones.RowTemplate.Height = 33;
            this.dtgOpciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgOpciones.Size = new System.Drawing.Size(940, 321);
            this.dtgOpciones.TabIndex = 0;
            this.dtgOpciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOpciones_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Modulo_Id
            // 
            this.Modulo_Id.DataPropertyName = "Modulo_Id";
            this.Modulo_Id.HeaderText = "Id";
            this.Modulo_Id.Name = "Modulo_Id";
            this.Modulo_Id.ReadOnly = true;
            this.Modulo_Id.Width = 75;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // EsAplicar
            // 
            this.EsAplicar.DataPropertyName = "EsAplicar";
            this.EsAplicar.HeaderText = "Aplicar";
            this.EsAplicar.Name = "EsAplicar";
            this.EsAplicar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsAplicar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnIrACuentaEnlace
            // 
            this.btnIrACuentaEnlace.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIrACuentaEnlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrACuentaEnlace.Location = new System.Drawing.Point(392, 0);
            this.btnIrACuentaEnlace.Name = "btnIrACuentaEnlace";
            this.btnIrACuentaEnlace.Size = new System.Drawing.Size(181, 54);
            this.btnIrACuentaEnlace.TabIndex = 5;
            this.btnIrACuentaEnlace.Text = "Ir a Cuentas Enlace";
            this.btnIrACuentaEnlace.UseVisualStyleBackColor = true;
            this.btnIrACuentaEnlace.Click += new System.EventHandler(this.btnIrACuentaEnlace_Click);
            // 
            // FormContaGenerarAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 506);
            this.Controls.Add(this.dtgOpciones);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormContaGenerarAsientos";
            this.TablaEncabezado = "TCONTA_SP_GENERA_ASIENTOS";
            this.Text = "GENERAR ASIENTOS POR MODULO";
            this.Load += new System.EventHandler(this.FormContaGenerarAsientos_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dtgOpciones, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgOpciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsAplicar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCombobox cboModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMarcarTodos;
        private System.Windows.Forms.TextBox txtABuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIrACuentaEnlace;
    }
}