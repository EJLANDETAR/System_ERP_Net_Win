namespace ELRBanco
{
    partial class FormBancoGenerarCHKPredefinidos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSoloChequesGenerar = new WinControl_ELR_NET.ELRCheckBox();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.Unico = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Size = new System.Drawing.Size(964, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(724, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(865, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(629, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(534, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpAFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(696, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(264, 49);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkSoloChequesGenerar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 52);
            this.panel2.TabIndex = 2;
            // 
            // chkSoloChequesGenerar
            // 
            this.chkSoloChequesGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSoloChequesGenerar.AutoSize = true;
            this.chkSoloChequesGenerar.CampoData = "";
            this.chkSoloChequesGenerar.DSData = null;
            this.chkSoloChequesGenerar.EsEditable = true;
            this.chkSoloChequesGenerar.EsModificable = true;
            this.chkSoloChequesGenerar.FiltroBusqueda = "";
            this.chkSoloChequesGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloChequesGenerar.Location = new System.Drawing.Point(614, 10);
            this.chkSoloChequesGenerar.Name = "chkSoloChequesGenerar";
            this.chkSoloChequesGenerar.NombreTabla = "";
            this.chkSoloChequesGenerar.Size = new System.Drawing.Size(319, 25);
            this.chkSoloChequesGenerar.TabIndex = 0;
            this.chkSoloChequesGenerar.Text = "MOSTRAR SOLO CHEQUES A GENERAR";
            this.chkSoloChequesGenerar.UseVisualStyleBackColor = true;
            this.chkSoloChequesGenerar.ValorPorDefecto = true;
            this.chkSoloChequesGenerar.CheckedChanged += new System.EventHandler(this.chkSoloChequesGenerar_CheckedChanged);
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Concepto,
            this.Beneficiario,
            this.Monto});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(0, 52);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersWidth = 30;
            this.dtgData.RowTemplate.Height = 33;
            this.dtgData.Size = new System.Drawing.Size(964, 307);
            this.dtgData.TabIndex = 3;
            this.dtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "A Fecha:";
            // 
            // dtpAFecha
            // 
            this.dtpAFecha.AValidar = null;
            this.dtpAFecha.CampoData = "";
            this.dtpAFecha.DSData = null;
            this.dtpAFecha.EsEditable = true;
            this.dtpAFecha.FiltroBusqueda = "";
            this.dtpAFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAFecha.Location = new System.Drawing.Point(105, 10);
            this.dtpAFecha.Name = "dtpAFecha";
            this.dtpAFecha.NombreTabla = "";
            this.dtpAFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpAFecha.TabIndex = 2;
            this.dtpAFecha.ValorPorDefecto = new System.DateTime(2017, 6, 17, 0, 0, 0, 0);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unico.Visible = false;
            this.Unico.Width = 75;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Concepto.Width = 350;
            // 
            // Beneficiario
            // 
            this.Beneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Beneficiario.DataPropertyName = "Beneficiario";
            this.Beneficiario.HeaderText = "Beneficiario";
            this.Beneficiario.Name = "Beneficiario";
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 140;
            // 
            // FormBancoGenerarCHKPredefinidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 455);
            this.Controls.Add(this.dtgData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgData;
            this.EsConTemporal = true;
            this.Name = "FormBancoGenerarCHKPredefinidos";
            this.TablaDetalle = "TTEMPORAL_CHEQUES_PREDEFINIDOS";
            this.TablaEncabezado = "";
            this.Text = "GENERAR CHEQUES PREDEFINIDOS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgData, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.Label lblTotal;
        private WinControl_ELR_NET.ELRCheckBox chkSoloChequesGenerar;
        private WinControl_ELR_NET.ELRDatePicker dtpAFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewLinkColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}