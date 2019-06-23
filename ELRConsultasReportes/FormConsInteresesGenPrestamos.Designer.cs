namespace ELRConsultasReportes
{
    partial class FormConsInteresesGenPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Interes_Anual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtDescripcion);
            this.pnTotales.Controls.Add(this.lblTotal);
            this.pnTotales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(12, 486);
            this.pnTotales.Size = new System.Drawing.Size(1145, 60);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblTotal, 0);
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtDescripcion, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1145, 87);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtABuscar.Location = new System.Drawing.Point(133, 46);
            this.txtABuscar.Size = new System.Drawing.Size(130, 26);
            this.txtABuscar.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(285, 42);
            this.btnBuscar.Size = new System.Drawing.Size(233, 34);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.Text = "Prestamo No.:";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Location = new System.Drawing.Point(317, 20);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(57, 21);
            this.lblCantidadRegistro.Visible = false;
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Prestamo_Id,
            this.ANombre,
            this.Fecha,
            this.Capital_Pendiente,
            this.Tasa_Interes_Anual,
            this.Cantidad_Dias,
            this.Interes,
            this.Nivel_Interes});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(12, 139);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 28;
            this.dtgData.Size = new System.Drawing.Size(1145, 347);
            this.dtgData.TabIndex = 47;
            this.dtgData.SelectionChanged += new System.EventHandler(this.dtgData_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Desde:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(133, 11);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha1.TabIndex = 4;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(391, 11);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha Hasta:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(889, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(252, 56);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Prestamo_Id
            // 
            this.Prestamo_Id.DataPropertyName = "Prestamo_Id";
            this.Prestamo_Id.HeaderText = "Prestamo Id";
            this.Prestamo_Id.Name = "Prestamo_Id";
            this.Prestamo_Id.ReadOnly = true;
            this.Prestamo_Id.Width = 120;
            // 
            // ANombre
            // 
            this.ANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANombre.DataPropertyName = "ANombre";
            this.ANombre.HeaderText = "ANombre";
            this.ANombre.Name = "ANombre";
            this.ANombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // Capital_Pendiente
            // 
            this.Capital_Pendiente.DataPropertyName = "Capital_Pendiente";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.Capital_Pendiente.DefaultCellStyle = dataGridViewCellStyle12;
            this.Capital_Pendiente.HeaderText = "B. Capital";
            this.Capital_Pendiente.Name = "Capital_Pendiente";
            this.Capital_Pendiente.ReadOnly = true;
            this.Capital_Pendiente.Width = 140;
            // 
            // Tasa_Interes_Anual
            // 
            this.Tasa_Interes_Anual.DataPropertyName = "Tasa_Interes_Anual";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0.00";
            this.Tasa_Interes_Anual.DefaultCellStyle = dataGridViewCellStyle13;
            this.Tasa_Interes_Anual.HeaderText = "Tasa Interes";
            this.Tasa_Interes_Anual.Name = "Tasa_Interes_Anual";
            this.Tasa_Interes_Anual.ReadOnly = true;
            this.Tasa_Interes_Anual.Width = 120;
            // 
            // Cantidad_Dias
            // 
            this.Cantidad_Dias.DataPropertyName = "Cantidad_Dias";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = "0";
            this.Cantidad_Dias.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cantidad_Dias.HeaderText = "Cant. Dias";
            this.Cantidad_Dias.Name = "Cantidad_Dias";
            this.Cantidad_Dias.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0.00";
            this.Interes.DefaultCellStyle = dataGridViewCellStyle15;
            this.Interes.HeaderText = "Interes G.";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Width = 120;
            // 
            // Nivel_Interes
            // 
            this.Nivel_Interes.DataPropertyName = "Nivel_Interes";
            this.Nivel_Interes.HeaderText = "Nivel";
            this.Nivel_Interes.Name = "Nivel_Interes";
            this.Nivel_Interes.ReadOnly = true;
            this.Nivel_Interes.Width = 80;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(0, 0);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(889, 56);
            this.txtDescripcion.TabIndex = 2;
            // 
            // FormConsInteresesGenPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CargarDataAlInicio = false;
            this.ClientSize = new System.Drawing.Size(1157, 568);
            this.Controls.Add(this.dtgData);
            this.EsAgregar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsInteresesGenPrestamos";
            this.Text = "CONSULTAS INTERESES GENERADOS";
            this.Load += new System.EventHandler(this.FormConsInteresesGenPrestamos_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Interes_Anual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_Interes;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}