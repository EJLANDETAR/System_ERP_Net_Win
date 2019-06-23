namespace ELRContaGeneral
{
    partial class FormContaPaseAlMayor
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
            this.chkGenerarEstados = new System.Windows.Forms.CheckBox();
            this.lblFechaActualizado = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.btnRealizarPase = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCatalogoBalance = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Mes_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirCatalogo = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogoBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnImprimirCatalogo);
            this.pnBotones.Location = new System.Drawing.Point(0, 467);
            this.pnBotones.Size = new System.Drawing.Size(827, 43);
            this.pnBotones.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnGrabar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnSiguientePage, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAnterior, 0);
            this.pnBotones.Controls.SetChildIndex(this.lblNombreUsuario, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnImprimirCatalogo, 0);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(587, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(728, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.Text = "&Cerrar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(53, 0);
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(492, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.lblNombreUsuario.Size = new System.Drawing.Size(182, 39);
            this.lblNombreUsuario.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkGenerarEstados);
            this.panel1.Controls.Add(this.lblFechaActualizado);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Controls.Add(this.btnRealizarPase);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 138);
            this.panel1.TabIndex = 1;
            // 
            // chkGenerarEstados
            // 
            this.chkGenerarEstados.AutoSize = true;
            this.chkGenerarEstados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerarEstados.Location = new System.Drawing.Point(365, 90);
            this.chkGenerarEstados.Name = "chkGenerarEstados";
            this.chkGenerarEstados.Size = new System.Drawing.Size(242, 25);
            this.chkGenerarEstados.TabIndex = 17;
            this.chkGenerarEstados.Text = "Generar Estados Financieros";
            this.chkGenerarEstados.UseVisualStyleBackColor = true;
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
            // btnRealizarPase
            // 
            this.btnRealizarPase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPase.Location = new System.Drawing.Point(30, 90);
            this.btnRealizarPase.Name = "btnRealizarPase";
            this.btnRealizarPase.Size = new System.Drawing.Size(291, 35);
            this.btnRealizarPase.TabIndex = 14;
            this.btnRealizarPase.Text = "Actualizar\\Realizar Pase";
            this.btnRealizarPase.UseVisualStyleBackColor = true;
            this.btnRealizarPase.Click += new System.EventHandler(this.btnRealizarPase_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(128, 55);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(193, 29);
            this.dtpFechaHasta.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta Fecha:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(128, 18);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(193, 29);
            this.dtpFechaDesde.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde Fecha:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDiferencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 49);
            this.panel2.TabIndex = 2;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiferencia.ForeColor = System.Drawing.Color.Red;
            this.lblDiferencia.Location = new System.Drawing.Point(0, 0);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(823, 45);
            this.lblDiferencia.TabIndex = 2;
            this.lblDiferencia.Text = "Diferencia: 0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCatalogoBalance);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalogo Balance";
            // 
            // dtgCatalogoBalance
            // 
            this.dtgCatalogoBalance.AllowUserToAddRows = false;
            this.dtgCatalogoBalance.AllowUserToDeleteRows = false;
            this.dtgCatalogoBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCatalogoBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Saldo_Mes_Anterior,
            this.Debito_Mes,
            this.Credito_Mes,
            this.Saldo_Actual});
            this.dtgCatalogoBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCatalogoBalance.Location = new System.Drawing.Point(3, 25);
            this.dtgCatalogoBalance.Name = "dtgCatalogoBalance";
            this.dtgCatalogoBalance.ReadOnly = true;
            this.dtgCatalogoBalance.RowHeadersWidth = 28;
            this.dtgCatalogoBalance.RowTemplate.Height = 33;
            this.dtgCatalogoBalance.Size = new System.Drawing.Size(821, 252);
            this.dtgCatalogoBalance.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Cuenta";
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
            this.Saldo_Mes_Anterior.Width = 140;
            // 
            // Debito_Mes
            // 
            this.Debito_Mes.DataPropertyName = "Debito_Mes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Debito_Mes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Debito_Mes.HeaderText = "Debito Mes";
            this.Debito_Mes.Name = "Debito_Mes";
            this.Debito_Mes.ReadOnly = true;
            this.Debito_Mes.Width = 140;
            // 
            // Credito_Mes
            // 
            this.Credito_Mes.DataPropertyName = "Credito_Mes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Credito_Mes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Credito_Mes.HeaderText = "Credito Mes";
            this.Credito_Mes.Name = "Credito_Mes";
            this.Credito_Mes.ReadOnly = true;
            this.Credito_Mes.Width = 140;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.DataPropertyName = "Saldo_Actual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Saldo_Actual.DefaultCellStyle = dataGridViewCellStyle4;
            this.Saldo_Actual.HeaderText = "S. Actual";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.ReadOnly = true;
            this.Saldo_Actual.Width = 160;
            // 
            // btnImprimirCatalogo
            // 
            this.btnImprimirCatalogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimirCatalogo.Location = new System.Drawing.Point(299, 0);
            this.btnImprimirCatalogo.Name = "btnImprimirCatalogo";
            this.btnImprimirCatalogo.Size = new System.Drawing.Size(193, 39);
            this.btnImprimirCatalogo.TabIndex = 7;
            this.btnImprimirCatalogo.Text = "Imprimir Catalogo";
            this.btnImprimirCatalogo.UseVisualStyleBackColor = true;
            this.btnImprimirCatalogo.Click += new System.EventHandler(this.btnImprimirCatalogo_Click);
            // 
            // FormContaPaseAlMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormContaPaseAlMayor";
            this.TablaEncabezado = "TCONTA_CATALOGO";
            this.Text = "CONTABILIDAD GENERAL, REALIZAR PASE AL MAYOR";
            this.Load += new System.EventHandler(this.FormContaPaseAlMayor_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogoBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Button btnRealizarPase;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaActualizado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCatalogoBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Mes_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.CheckBox chkGenerarEstados;
        private System.Windows.Forms.Button btnImprimirCatalogo;
    }
}