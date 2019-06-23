namespace ELRContaGeneral
{
    partial class FormContaCierreDiarioMensual
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
            this.lblFechaActualizado = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.btnRealizarCierre = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
            this.pnBotones.Location = new System.Drawing.Point(0, 424);
            this.pnBotones.Size = new System.Drawing.Size(842, 53);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(586, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 49);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(727, 0);
            this.btnCancelar.Size = new System.Drawing.Size(111, 49);
            this.btnCancelar.Text = "&Cerrar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 49);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(468, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(118, 49);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(373, 49);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblFechaActualizado);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Controls.Add(this.btnRealizarCierre);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 105);
            this.panel1.TabIndex = 2;
            // 
            // lblFechaActualizado
            // 
            this.lblFechaActualizado.AutoSize = true;
            this.lblFechaActualizado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActualizado.Location = new System.Drawing.Point(332, 51);
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
            this.lblEstatus.Location = new System.Drawing.Point(332, 18);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(378, 30);
            this.lblEstatus.TabIndex = 15;
            this.lblEstatus.Text = "ACTUALIZADO\\POSTEADO A FECHA:";
            // 
            // btnRealizarCierre
            // 
            this.btnRealizarCierre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCierre.Location = new System.Drawing.Point(26, 54);
            this.btnRealizarCierre.Name = "btnRealizarCierre";
            this.btnRealizarCierre.Size = new System.Drawing.Size(262, 35);
            this.btnRealizarCierre.TabIndex = 14;
            this.btnRealizarCierre.Text = "Realizar Cierre";
            this.btnRealizarCierre.UseVisualStyleBackColor = true;
            this.btnRealizarCierre.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(95, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(193, 29);
            this.dtpFecha.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "A Fecha:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDiferencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 49);
            this.panel2.TabIndex = 3;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiferencia.ForeColor = System.Drawing.Color.Red;
            this.lblDiferencia.Location = new System.Drawing.Point(0, 0);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(838, 45);
            this.lblDiferencia.TabIndex = 2;
            this.lblDiferencia.Text = "Diferencia: 0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCatalogoBalance);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 270);
            this.groupBox1.TabIndex = 4;
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
            this.dtgCatalogoBalance.Size = new System.Drawing.Size(836, 242);
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
            this.Saldo_Mes_Anterior.Width = 150;
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
            this.Debito_Mes.Width = 150;
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
            this.Credito_Mes.Width = 150;
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
            // FormContaCierreDiarioMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormContaCierreDiarioMensual";
            this.TablaEncabezado = "TCONTA_CONTROL_CIERRE";
            this.Text = "CONTABILIDAD GENERAL, REALIZAR CIERRE DIARIO";
            this.Load += new System.EventHandler(this.FormContaCierreDiarioMensual_Load);
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
        private System.Windows.Forms.Label lblFechaActualizado;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Button btnRealizarCierre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCatalogoBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Mes_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.Label lblDiferencia;
    }
}