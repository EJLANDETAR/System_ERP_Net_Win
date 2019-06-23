namespace ELRFacturas
{
    partial class FormGenerarProcesos
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
            this.pnEncabezado = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProcesoActual = new System.Windows.Forms.Label();
            this.pnBarraProgeso = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtgProcesos = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ult_Generado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.pnEncabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnBarraProgeso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 426);
            this.pnBotones.Size = new System.Drawing.Size(744, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(504, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(645, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(409, 0);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(314, 39);
            // 
            // pnEncabezado
            // 
            this.pnEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnEncabezado.Controls.Add(this.panel1);
            this.pnEncabezado.Controls.Add(this.pnBarraProgeso);
            this.pnEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEncabezado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnEncabezado.Margin = new System.Windows.Forms.Padding(2);
            this.pnEncabezado.Name = "pnEncabezado";
            this.pnEncabezado.Size = new System.Drawing.Size(744, 94);
            this.pnEncabezado.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(282, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 90);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 40);
            this.panel3.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(458, 40);
            this.progressBar1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProcesoActual);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 50);
            this.panel2.TabIndex = 9;
            // 
            // lblProcesoActual
            // 
            this.lblProcesoActual.AutoSize = true;
            this.lblProcesoActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesoActual.Location = new System.Drawing.Point(3, 15);
            this.lblProcesoActual.Name = "lblProcesoActual";
            this.lblProcesoActual.Size = new System.Drawing.Size(143, 25);
            this.lblProcesoActual.TabIndex = 11;
            this.lblProcesoActual.Text = "Proceso Actual";
            // 
            // pnBarraProgeso
            // 
            this.pnBarraProgeso.Controls.Add(this.btnGenerar);
            this.pnBarraProgeso.Controls.Add(this.label1);
            this.pnBarraProgeso.Controls.Add(this.dtpFecha);
            this.pnBarraProgeso.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBarraProgeso.Location = new System.Drawing.Point(0, 0);
            this.pnBarraProgeso.Margin = new System.Windows.Forms.Padding(2);
            this.pnBarraProgeso.Name = "pnBarraProgeso";
            this.pnBarraProgeso.Size = new System.Drawing.Size(282, 90);
            this.pnBarraProgeso.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(7, 47);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(248, 36);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Realizar Cierre";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(73, 9);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(182, 33);
            this.dtpFecha.TabIndex = 2;
            // 
            // dtgProcesos
            // 
            this.dtgProcesos.AllowUserToAddRows = false;
            this.dtgProcesos.AllowUserToDeleteRows = false;
            this.dtgProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Descripcion,
            this.Fecha_Ult_Generado});
            this.dtgProcesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProcesos.Location = new System.Drawing.Point(0, 94);
            this.dtgProcesos.Name = "dtgProcesos";
            this.dtgProcesos.ReadOnly = true;
            this.dtgProcesos.RowHeadersWidth = 30;
            this.dtgProcesos.Size = new System.Drawing.Size(744, 332);
            this.dtgProcesos.TabIndex = 3;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fecha_Ult_Generado
            // 
            this.Fecha_Ult_Generado.DataPropertyName = "Fecha_Ult_Generado";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha_Ult_Generado.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha_Ult_Generado.HeaderText = "Fe. Ult. Generado";
            this.Fecha_Ult_Generado.Name = "Fecha_Ult_Generado";
            this.Fecha_Ult_Generado.ReadOnly = true;
            this.Fecha_Ult_Generado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_Ult_Generado.Width = 200;
            // 
            // FormGenerarProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 469);
            this.Controls.Add(this.dtgProcesos);
            this.Controls.Add(this.pnEncabezado);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MinimizeBox = false;
            this.Name = "FormGenerarProcesos";
            this.Text = "REALIZAR PROCESO DE CIERRE";
            this.Load += new System.EventHandler(this.FormProcesos_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.pnEncabezado, 0);
            this.Controls.SetChildIndex(this.dtgProcesos, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.pnEncabezado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnBarraProgeso.ResumeLayout(false);
            this.pnBarraProgeso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezado;
        private System.Windows.Forms.Panel pnBarraProgeso;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dtgProcesos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProcesoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ult_Generado;
    }
}