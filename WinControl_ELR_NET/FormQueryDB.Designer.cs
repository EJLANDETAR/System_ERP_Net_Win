namespace WinControl_ELR_NET
{
    partial class FormQueryDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueryDB));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbRun = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTGObjetos = new System.Windows.Forms.DataGridView();
            this.tstABuscar = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.object_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTGColumns = new System.Windows.Forms.DataGridView();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGObjetos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(916, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstABuscar,
            this.tsbRun,
            this.tsbExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(916, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(916, 388);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 2;
            // 
            // tsbExcel
            // 
            this.tsbExcel.Image = global::WinControl_ELR_NET.Properties.Resources.excel1;
            this.tsbExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(124, 44);
            this.tsbExcel.Text = "Exportar a Excel";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // tsbRun
            // 
            this.tsbRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbRun.Image")));
            this.tsbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRun.Name = "tsbRun";
            this.tsbRun.Size = new System.Drawing.Size(69, 44);
            this.tsbRun.Text = "Ejecutar";
            this.tsbRun.Click += new System.EventHandler(this.tsbRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTGObjetos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas y Vista";
            // 
            // DTGObjetos
            // 
            this.DTGObjetos.AllowUserToAddRows = false;
            this.DTGObjetos.AllowUserToDeleteRows = false;
            this.DTGObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGObjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.object_name,
            this.Tabla_Id});
            this.DTGObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGObjetos.Location = new System.Drawing.Point(3, 23);
            this.DTGObjetos.MultiSelect = false;
            this.DTGObjetos.Name = "DTGObjetos";
            this.DTGObjetos.ReadOnly = true;
            this.DTGObjetos.RowHeadersWidth = 28;
            this.DTGObjetos.RowTemplate.Height = 33;
            this.DTGObjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGObjetos.Size = new System.Drawing.Size(390, 358);
            this.DTGObjetos.TabIndex = 0;
            this.DTGObjetos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGObjetos_CellContentDoubleClick);
            // 
            // tstABuscar
            // 
            this.tstABuscar.Name = "tstABuscar";
            this.tstABuscar.Size = new System.Drawing.Size(300, 47);
            this.tstABuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstABuscar_KeyUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DTGColumns);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Columnas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(366, 91);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ordenar Por";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(366, 91);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resultado";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // object_name
            // 
            this.object_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.object_name.DataPropertyName = "object_name";
            this.object_name.HeaderText = "Name";
            this.object_name.Name = "object_name";
            this.object_name.ReadOnly = true;
            // 
            // Tabla_Id
            // 
            this.Tabla_Id.DataPropertyName = "Tabla_Id";
            this.Tabla_Id.HeaderText = "Tabla_Id";
            this.Tabla_Id.Name = "Tabla_Id";
            this.Tabla_Id.ReadOnly = true;
            this.Tabla_Id.Visible = false;
            // 
            // DTGColumns
            // 
            this.DTGColumns.AllowUserToAddRows = false;
            this.DTGColumns.AllowUserToDeleteRows = false;
            this.DTGColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna,
            this.Tipo,
            this.NoOrden});
            this.DTGColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGColumns.Location = new System.Drawing.Point(3, 3);
            this.DTGColumns.Name = "DTGColumns";
            this.DTGColumns.ReadOnly = true;
            this.DTGColumns.RowHeadersWidth = 28;
            this.DTGColumns.RowTemplate.Height = 33;
            this.DTGColumns.Size = new System.Drawing.Size(494, 345);
            this.DTGColumns.TabIndex = 0;
            // 
            // Columna
            // 
            this.Columna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columna.DataPropertyName = "Columna";
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 175;
            // 
            // NoOrden
            // 
            this.NoOrden.DataPropertyName = "NoOrden";
            this.NoOrden.HeaderText = "NoOrden";
            this.NoOrden.Name = "NoOrden";
            this.NoOrden.ReadOnly = true;
            // 
            // FormQueryDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 457);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQueryDB";
            this.Text = "FormQueryDB";
            this.Load += new System.EventHandler(this.FormQueryDB_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGObjetos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExcel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DTGObjetos;
        private System.Windows.Forms.ToolStripTextBox tstABuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabla_Id;
        private System.Windows.Forms.DataGridView DTGColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOrden;
    }
}