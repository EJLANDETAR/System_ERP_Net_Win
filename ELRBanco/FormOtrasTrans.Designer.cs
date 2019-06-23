namespace ELRBanco
{
    partial class FormOtrasTrans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trans_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.chkPorCuenta = new WinControl_ELR_NET.ELRCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalCredito = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtConcepto);
            this.pnTotales.Controls.Add(this.panel1);
            this.pnTotales.Location = new System.Drawing.Point(0, 440);
            this.pnTotales.Size = new System.Drawing.Size(940, 106);
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
            this.pnBusqSencilla.Size = new System.Drawing.Size(926, 88);
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
            this.txtABuscar.Location = new System.Drawing.Point(718, 37);
            this.txtABuscar.Size = new System.Drawing.Size(135, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 14);
            this.btnBuscar.Size = new System.Drawing.Size(145, 60);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(714, 12);
            this.label1.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 388);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Trans_Id,
            this.Tipo,
            this.Fecha,
            this.Numero,
            this.Concepto,
            this.Debito,
            this.Credito,
            this.Asiento_Id});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(926, 300);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Trans_Id
            // 
            this.Trans_Id.DataPropertyName = "Trans_Id";
            this.Trans_Id.HeaderText = "Id";
            this.Trans_Id.Name = "Trans_Id";
            this.Trans_Id.ReadOnly = true;
            this.Trans_Id.Width = 80;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.Numero.Width = 120;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Debito
            // 
            this.Debito.DataPropertyName = "Debito";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Debito.DefaultCellStyle = dataGridViewCellStyle5;
            this.Debito.HeaderText = "Debito";
            this.Debito.Name = "Debito";
            this.Debito.ReadOnly = true;
            this.Debito.Width = 120;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle6;
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            this.Credito.Width = 120;
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
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(400, 48);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha2.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(133, 48);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha Desde:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.DisplayMember = "Nombre";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(133, 14);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(407, 28);
            this.cboCuenta.TabIndex = 23;
            this.cboCuenta.ValueMember = "Cuenta_Id";
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
            this.chkPorCuenta.Location = new System.Drawing.Point(14, 14);
            this.chkPorCuenta.Name = "chkPorCuenta";
            this.chkPorCuenta.NombreTabla = "";
            this.chkPorCuenta.Size = new System.Drawing.Size(112, 24);
            this.chkPorCuenta.TabIndex = 28;
            this.chkPorCuenta.Text = "Por Cuenta:";
            this.chkPorCuenta.UseVisualStyleBackColor = true;
            this.chkPorCuenta.ValorPorDefecto = true;
            this.chkPorCuenta.CheckedChanged += new System.EventHandler(this.chkPorCuenta_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(587, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 102);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblTotalCredito);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblTotalDebito);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 102);
            this.panel2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 34);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total Credito:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCredito
            // 
            this.lblTotalCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredito.Location = new System.Drawing.Point(157, 55);
            this.lblTotalCredito.Name = "lblTotalCredito";
            this.lblTotalCredito.Size = new System.Drawing.Size(182, 34);
            this.lblTotalCredito.TabIndex = 6;
            this.lblTotalCredito.Text = "0.00";
            this.lblTotalCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total Debito:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebito.Location = new System.Drawing.Point(157, 11);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(182, 34);
            this.lblTotalDebito.TabIndex = 4;
            this.lblTotalDebito.Text = "0.00";
            this.lblTotalDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Debito:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(0, 0);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.Size = new System.Drawing.Size(587, 102);
            this.txtConcepto.TabIndex = 4;
            // 
            // FormOtrasTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRBanco.FormOtrasTransR";
            this.Name = "FormOtrasTrans";
            this.NombreCampoID = "Trans_Id";
            this.SPCargarATemporal = "SP_BANCO_CARGAR_TEMPORAL";
            this.TablaOVista = "TBANCOS_TRANS";
            this.Text = "BANCO OTROS TIPOS DE TRANSACCIONES";
            this.Load += new System.EventHandler(this.FormOtrasTrans_Load);
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCuenta;
        private WinControl_ELR_NET.ELRCheckBox chkPorCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trans_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewLinkColumn Asiento_Id;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalCredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.Label label6;
    }
}