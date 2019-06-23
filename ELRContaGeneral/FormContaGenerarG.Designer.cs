namespace ELRContaGeneral
{
    partial class FormContaGenerarG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImprimirCatalogo = new System.Windows.Forms.Button();
            this.btnVerEstados = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaActualizado = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgCierre = new System.Windows.Forms.DataGridView();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Mes_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCierre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Size = new System.Drawing.Size(1056, 51);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(791, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(932, 0);
            this.btnCancelar.Size = new System.Drawing.Size(120, 47);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(696, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(601, 47);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtpFechaCierre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFechaActualizado);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 152);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnImprimirCatalogo);
            this.panel2.Controls.Add(this.btnVerEstados);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 52);
            this.panel2.TabIndex = 20;
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcel.Location = new System.Drawing.Point(594, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(156, 48);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Exportar a Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImprimirCatalogo
            // 
            this.btnImprimirCatalogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimirCatalogo.Location = new System.Drawing.Point(401, 0);
            this.btnImprimirCatalogo.Name = "btnImprimirCatalogo";
            this.btnImprimirCatalogo.Size = new System.Drawing.Size(193, 48);
            this.btnImprimirCatalogo.TabIndex = 17;
            this.btnImprimirCatalogo.Text = "Imprimir Catalogo";
            this.btnImprimirCatalogo.UseVisualStyleBackColor = true;
            this.btnImprimirCatalogo.Click += new System.EventHandler(this.btnImprimirCatalogo_Click);
            // 
            // btnVerEstados
            // 
            this.btnVerEstados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerEstados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstados.Location = new System.Drawing.Point(161, 0);
            this.btnVerEstados.Name = "btnVerEstados";
            this.btnVerEstados.Size = new System.Drawing.Size(240, 48);
            this.btnVerEstados.TabIndex = 16;
            this.btnVerEstados.Text = "Ver Estados financieros";
            this.btnVerEstados.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(161, 48);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(30, 42);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(216, 29);
            this.dtpFechaCierre.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "A Fecha:";
            // 
            // lblFechaActualizado
            // 
            this.lblFechaActualizado.AutoSize = true;
            this.lblFechaActualizado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActualizado.Location = new System.Drawing.Point(360, 51);
            this.lblFechaActualizado.Name = "lblFechaActualizado";
            this.lblFechaActualizado.Size = new System.Drawing.Size(116, 25);
            this.lblFechaActualizado.TabIndex = 16;
            this.lblFechaActualizado.Text = "00/00/0000";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.Green;
            this.lblEstatus.Location = new System.Drawing.Point(360, 18);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(378, 30);
            this.lblEstatus.TabIndex = 15;
            this.lblEstatus.Text = "ACTUALIZADO\\POSTEADO A FECHA:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 53);
            this.panel3.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Red;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(1052, 49);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Diferencia: 0.00  ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgCierre
            // 
            this.dtgCierre.AllowUserToAddRows = false;
            this.dtgCierre.AllowUserToDeleteRows = false;
            this.dtgCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCierre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta_Contable,
            this.Descripcion,
            this.Saldo_Mes_Anterior,
            this.Debito,
            this.Credito,
            this.Saldo_Actual});
            this.dtgCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCierre.Location = new System.Drawing.Point(0, 152);
            this.dtgCierre.Name = "dtgCierre";
            this.dtgCierre.ReadOnly = true;
            this.dtgCierre.RowHeadersWidth = 28;
            this.dtgCierre.RowTemplate.Height = 33;
            this.dtgCierre.Size = new System.Drawing.Size(1056, 239);
            this.dtgCierre.TabIndex = 8;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cuenta No.";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Saldo_Mes_Anterior
            // 
            this.Saldo_Mes_Anterior.DataPropertyName = "Saldo_Mes_Anterior";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Saldo_Mes_Anterior.DefaultCellStyle = dataGridViewCellStyle1;
            this.Saldo_Mes_Anterior.HeaderText = "S. Mes Anterior";
            this.Saldo_Mes_Anterior.Name = "Saldo_Mes_Anterior";
            this.Saldo_Mes_Anterior.ReadOnly = true;
            this.Saldo_Mes_Anterior.Width = 155;
            // 
            // Debito
            // 
            this.Debito.DataPropertyName = "Debito_Mes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Debito.DefaultCellStyle = dataGridViewCellStyle2;
            this.Debito.HeaderText = "Debito Mes";
            this.Debito.Name = "Debito";
            this.Debito.ReadOnly = true;
            this.Debito.Width = 140;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito_Mes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle3;
            this.Credito.HeaderText = "Credito Mes";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            this.Credito.Width = 140;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.DataPropertyName = "Saldo_Actual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Saldo_Actual.DefaultCellStyle = dataGridViewCellStyle4;
            this.Saldo_Actual.HeaderText = "Saldo Actual";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.ReadOnly = true;
            this.Saldo_Actual.Width = 155;
            // 
            // FormContaGenerarG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 495);
            this.Controls.Add(this.dtgCierre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgCierre;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormContaGenerarG";
            this.Text = "GENERAR CONTABILIDAD A FECHA DE CIERRE";
            this.Load += new System.EventHandler(this.FormContaGenerarG_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dtgCierre, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCierre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVerEstados;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaActualizado;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgCierre;
        private System.Windows.Forms.Button btnImprimirCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Mes_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.Button btnExcel;
    }
}