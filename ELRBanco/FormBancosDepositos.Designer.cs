namespace ELRBanco
{
    partial class FormBancosDepositos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkPorCuenta = new WinControl_ELR_NET.ELRCheckBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.Trans_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtConcepto);
            this.pnTotales.Controls.Add(this.panel1);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 466);
            this.pnTotales.Size = new System.Drawing.Size(940, 80);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.panel1, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtConcepto, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.chkPorCuenta);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.cboCuenta);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(926, 87);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkPorCuenta, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(747, 47);
            this.txtABuscar.Size = new System.Drawing.Size(95, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(548, 11);
            this.btnBuscar.Size = new System.Drawing.Size(150, 60);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(743, 24);
            this.label1.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Size = new System.Drawing.Size(57, 20);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 414);
            // 
            // chkPorCuenta
            // 
            this.chkPorCuenta.AutoSize = true;
            this.chkPorCuenta.CampoData = "";
            this.chkPorCuenta.Checked = true;
            this.chkPorCuenta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPorCuenta.DSData = null;
            this.chkPorCuenta.EsEditable = true;
            this.chkPorCuenta.EsModificable = true;
            this.chkPorCuenta.FiltroBusqueda = "";
            this.chkPorCuenta.Location = new System.Drawing.Point(14, 11);
            this.chkPorCuenta.Name = "chkPorCuenta";
            this.chkPorCuenta.NombreTabla = "";
            this.chkPorCuenta.Size = new System.Drawing.Size(112, 24);
            this.chkPorCuenta.TabIndex = 23;
            this.chkPorCuenta.Text = "Por Cuenta:";
            this.chkPorCuenta.UseVisualStyleBackColor = true;
            this.chkPorCuenta.ValorPorDefecto = true;
            this.chkPorCuenta.CheckedChanged += new System.EventHandler(this.chkPorCuenta_CheckedChanged);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(402, 45);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(135, 45);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha Desde:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.DisplayMember = "Nombre";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(135, 11);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(407, 28);
            this.cboCuenta.TabIndex = 18;
            this.cboCuenta.ValueMember = "Cuenta_Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trans_Id,
            this.Unico,
            this.Fecha,
            this.Numero,
            this.Concepto,
            this.Monto,
            this.Estatus,
            this.Asiento_Id});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(926, 327);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(625, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 76);
            this.panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(307, 72);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(0, 0);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.Size = new System.Drawing.Size(625, 76);
            this.txtConcepto.TabIndex = 3;
            // 
            // Trans_Id
            // 
            this.Trans_Id.DataPropertyName = "Trans_Id";
            this.Trans_Id.HeaderText = "Id";
            this.Trans_Id.Name = "Trans_Id";
            this.Trans_Id.ReadOnly = true;
            this.Trans_Id.Width = 80;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 115;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 125;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 200;
            // 
            // Asiento_Id
            // 
            this.Asiento_Id.DataPropertyName = "Asiento_Id";
            this.Asiento_Id.HeaderText = "Asiento Id";
            this.Asiento_Id.Name = "Asiento_Id";
            this.Asiento_Id.ReadOnly = true;
            this.Asiento_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Asiento_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormBancosDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Trans_Id Desc";
            this.ClientSize = new System.Drawing.Size(940, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRBanco.FormBancosDepositosR";
            this.Limite = -1;
            this.Name = "FormBancosDepositos";
            this.NombreCampoID = "Trans_Id";
            this.SPCargarATemporal = "SP_BANCO_CARGAR_TEMPORAL";
            this.TablaOVista = "TBANCOS_TRANS";
            this.Text = "BANCO, DEPOSITOS";
            this.Load += new System.EventHandler(this.FormBancosDepositos_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRCheckBox chkPorCuenta;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trans_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewLinkColumn Asiento_Id;
    }
}