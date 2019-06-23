namespace ELRBanco
{
    partial class FormBancoConciliaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.dtgConciliaciones = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conciliacion_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_En_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cheques_En_Transitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depositos_En_Transitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_En_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_Debito_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_Credito_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_Conciliado_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConciliaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Size = new System.Drawing.Size(1105, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.label9);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.cboCuenta);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1091, 89);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label9, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(770, 25);
            this.txtABuscar.Size = new System.Drawing.Size(107, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(581, 14);
            this.btnBuscar.Size = new System.Drawing.Size(136, 60);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(766, 54);
            this.label1.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cuenta Banco";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(435, 48);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(145, 48);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fecha Desde:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.DisplayMember = "Nombre";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(145, 14);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(430, 28);
            this.cboCuenta.TabIndex = 27;
            this.cboCuenta.ValueMember = "Cuenta_Id";
            // 
            // dtgConciliaciones
            // 
            this.dtgConciliaciones.AllowUserToAddRows = false;
            this.dtgConciliaciones.AllowUserToDeleteRows = false;
            this.dtgConciliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConciliaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Conciliacion_Id,
            this.NombreCuenta,
            this.Fecha,
            this.Balance_En_Banco,
            this.Cheques_En_Transitos,
            this.Depositos_En_Transitos,
            this.Balance_En_Libro,
            this.Nota_Debito_Libro,
            this.Nota_Credito_Libro,
            this.Balance_Conciliado_Libro,
            this.Comentario,
            this.Estatus});
            this.dtgConciliaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConciliaciones.Location = new System.Drawing.Point(14, 141);
            this.dtgConciliaciones.Name = "dtgConciliaciones";
            this.dtgConciliaciones.ReadOnly = true;
            this.dtgConciliaciones.Size = new System.Drawing.Size(1091, 353);
            this.dtgConciliaciones.TabIndex = 47;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Conciliacion_Id
            // 
            this.Conciliacion_Id.DataPropertyName = "Conciliacion_Id";
            this.Conciliacion_Id.HeaderText = "Id";
            this.Conciliacion_Id.Name = "Conciliacion_Id";
            this.Conciliacion_Id.ReadOnly = true;
            // 
            // NombreCuenta
            // 
            this.NombreCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCuenta.DataPropertyName = "NombreCuenta";
            this.NombreCuenta.HeaderText = "Cuenta Bancaria";
            this.NombreCuenta.Name = "NombreCuenta";
            this.NombreCuenta.ReadOnly = true;
            this.NombreCuenta.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Balance_En_Banco
            // 
            this.Balance_En_Banco.DataPropertyName = "Balance_En_Banco";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Balance_En_Banco.DefaultCellStyle = dataGridViewCellStyle2;
            this.Balance_En_Banco.HeaderText = "Bce. Banco";
            this.Balance_En_Banco.Name = "Balance_En_Banco";
            this.Balance_En_Banco.ReadOnly = true;
            this.Balance_En_Banco.Width = 120;
            // 
            // Cheques_En_Transitos
            // 
            this.Cheques_En_Transitos.DataPropertyName = "Cheques_En_Transitos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Cheques_En_Transitos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cheques_En_Transitos.HeaderText = "Chk. Transito";
            this.Cheques_En_Transitos.Name = "Cheques_En_Transitos";
            this.Cheques_En_Transitos.ReadOnly = true;
            this.Cheques_En_Transitos.Width = 120;
            // 
            // Depositos_En_Transitos
            // 
            this.Depositos_En_Transitos.DataPropertyName = "Depositos_En_Transitos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Depositos_En_Transitos.DefaultCellStyle = dataGridViewCellStyle4;
            this.Depositos_En_Transitos.HeaderText = "Dep. Transito";
            this.Depositos_En_Transitos.Name = "Depositos_En_Transitos";
            this.Depositos_En_Transitos.ReadOnly = true;
            this.Depositos_En_Transitos.Width = 120;
            // 
            // Balance_En_Libro
            // 
            this.Balance_En_Libro.DataPropertyName = "Balance_En_Libro";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Balance_En_Libro.DefaultCellStyle = dataGridViewCellStyle5;
            this.Balance_En_Libro.HeaderText = "Bce. Libro";
            this.Balance_En_Libro.Name = "Balance_En_Libro";
            this.Balance_En_Libro.ReadOnly = true;
            this.Balance_En_Libro.Width = 120;
            // 
            // Nota_Debito_Libro
            // 
            this.Nota_Debito_Libro.DataPropertyName = "Nota_Debito_Libro";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Nota_Debito_Libro.DefaultCellStyle = dataGridViewCellStyle6;
            this.Nota_Debito_Libro.HeaderText = "ND. Libro";
            this.Nota_Debito_Libro.Name = "Nota_Debito_Libro";
            this.Nota_Debito_Libro.ReadOnly = true;
            this.Nota_Debito_Libro.Width = 120;
            // 
            // Nota_Credito_Libro
            // 
            this.Nota_Credito_Libro.DataPropertyName = "Nota_Credito_Libro";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Nota_Credito_Libro.DefaultCellStyle = dataGridViewCellStyle7;
            this.Nota_Credito_Libro.HeaderText = "NC. Libro";
            this.Nota_Credito_Libro.Name = "Nota_Credito_Libro";
            this.Nota_Credito_Libro.ReadOnly = true;
            this.Nota_Credito_Libro.Width = 120;
            // 
            // Balance_Conciliado_Libro
            // 
            this.Balance_Conciliado_Libro.DataPropertyName = "Balance_Conciliado_Libro";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.Balance_Conciliado_Libro.DefaultCellStyle = dataGridViewCellStyle8;
            this.Balance_Conciliado_Libro.HeaderText = "Bce. Conciliado";
            this.Balance_Conciliado_Libro.Name = "Balance_Conciliado_Libro";
            this.Balance_Conciliado_Libro.ReadOnly = true;
            this.Balance_Conciliado_Libro.Width = 120;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Visible = false;
            // 
            // Estatus
            // 
            this.Estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // FormBancoConciliaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 568);
            this.Controls.Add(this.dtgConciliaciones);
            this.DataGridConsulta = this.dtgConciliaciones;
            this.EsImprimir = true;
            this.FormularioRegistro = "ELRBanco.FormBancoConciliacionR";
            this.Name = "FormBancoConciliaciones";
            this.NombreCampoID = "Conciliacion_Id";
            this.SPCargarATemporal = "SP_BANCOS_CONCILIACION_ATEMPORAL";
            this.Text = "CONCILIACIONES BANCARIA";
            this.Load += new System.EventHandler(this.FormBancoConciliaciones_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgConciliaciones, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConciliaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.DataGridView dtgConciliaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conciliacion_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_En_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cheques_En_Transitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depositos_En_Transitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_En_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_Debito_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_Credito_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Conciliado_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}