namespace ELRContaGeneral
{
    partial class FormContaCierrePeriodo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaActualizado = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.btnPreCierre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgCierre = new System.Windows.Forms.DataGridView();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirCatalogo = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCierre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnImprimirCatalogo);
            this.pnBotones.Location = new System.Drawing.Point(0, 439);
            this.pnBotones.Size = new System.Drawing.Size(951, 57);
            this.pnBotones.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnGrabar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnSiguientePage, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAnterior, 0);
            this.pnBotones.Controls.SetChildIndex(this.lblNombreUsuario, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnImprimirCatalogo, 0);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(603, 0);
            this.btnGrabar.Size = new System.Drawing.Size(210, 53);
            this.btnGrabar.Text = "Realizar Cierre (Ctrl + G)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(813, 0);
            this.btnCancelar.Size = new System.Drawing.Size(134, 53);
            this.btnCancelar.Text = "&Cerrar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(53, 0);
            this.btnAnterior.Size = new System.Drawing.Size(95, 53);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(508, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 53);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(148, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(360, 53);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpFechaCierre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFechaActualizado);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Controls.Add(this.btnPreCierre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 110);
            this.panel1.TabIndex = 5;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(105, 18);
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
            // btnPreCierre
            // 
            this.btnPreCierre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreCierre.Location = new System.Drawing.Point(30, 53);
            this.btnPreCierre.Name = "btnPreCierre";
            this.btnPreCierre.Size = new System.Drawing.Size(291, 35);
            this.btnPreCierre.TabIndex = 14;
            this.btnPreCierre.Text = "General Pre-Asiento de Cierre";
            this.btnPreCierre.UseVisualStyleBackColor = true;
            this.btnPreCierre.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 53);
            this.panel2.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(947, 49);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Debito:  0.00               Total Credito: 0.00               Diferencia: 0" +
    ".00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgCierre
            // 
            this.dtgCierre.AllowUserToAddRows = false;
            this.dtgCierre.AllowUserToDeleteRows = false;
            this.dtgCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCierre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta_Contable,
            this.Codigo_Auxiliar,
            this.Descripcion,
            this.Debito,
            this.Credito});
            this.dtgCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCierre.Location = new System.Drawing.Point(0, 110);
            this.dtgCierre.Name = "dtgCierre";
            this.dtgCierre.ReadOnly = true;
            this.dtgCierre.RowHeadersWidth = 28;
            this.dtgCierre.RowTemplate.Height = 33;
            this.dtgCierre.Size = new System.Drawing.Size(951, 276);
            this.dtgCierre.TabIndex = 7;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cuenta No.";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 150;
            // 
            // Codigo_Auxiliar
            // 
            this.Codigo_Auxiliar.DataPropertyName = "Codigo_Auxiliar";
            this.Codigo_Auxiliar.HeaderText = "C. Costo\\Suc.";
            this.Codigo_Auxiliar.Name = "Codigo_Auxiliar";
            this.Codigo_Auxiliar.ReadOnly = true;
            this.Codigo_Auxiliar.Width = 140;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Debito
            // 
            this.Debito.DataPropertyName = "Debito";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Debito.DefaultCellStyle = dataGridViewCellStyle1;
            this.Debito.HeaderText = "Debito";
            this.Debito.Name = "Debito";
            this.Debito.ReadOnly = true;
            this.Debito.Width = 140;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle2;
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            this.Credito.Width = 140;
            // 
            // btnImprimirCatalogo
            // 
            this.btnImprimirCatalogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimirCatalogo.Location = new System.Drawing.Point(315, 0);
            this.btnImprimirCatalogo.Name = "btnImprimirCatalogo";
            this.btnImprimirCatalogo.Size = new System.Drawing.Size(193, 53);
            this.btnImprimirCatalogo.TabIndex = 9;
            this.btnImprimirCatalogo.Text = "Imprimir Catalogo";
            this.btnImprimirCatalogo.UseVisualStyleBackColor = true;
            this.btnImprimirCatalogo.Click += new System.EventHandler(this.btnImprimirCatalogo_Click);
            // 
            // FormContaCierrePeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 496);
            this.Controls.Add(this.dtgCierre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormContaCierrePeriodo";
            this.TablaEncabezado = "TTEMPORAL_CONTA_CIERRE_PERIODO";
            this.Text = "CONTABILIDAD GENERAL, CERRAR PERIODO CONTABLE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormContaCierrePeriodo_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgCierre, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCierre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaActualizado;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Button btnPreCierre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Button btnImprimirCatalogo;
    }
}