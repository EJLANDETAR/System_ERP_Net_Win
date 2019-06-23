namespace ELRConsultasReportes
{
    partial class FormConsultaVencidas
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
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Factura_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas_Vencida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Proximo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Atrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficial_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficial_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtDescripcion);
            this.pnTotales.Controls.Add(this.lblTotal);
            this.pnTotales.Location = new System.Drawing.Point(12, 468);
            this.pnTotales.Size = new System.Drawing.Size(1181, 76);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.lblTotal, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtDescripcion, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Size = new System.Drawing.Size(1181, 48);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(98, 5);
            this.txtABuscar.Size = new System.Drawing.Size(340, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(444, 5);
            this.btnBuscar.Size = new System.Drawing.Size(83, 29);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "A Buscar";
            // 
            // lblCantidadRegistro
            // 
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
            this.Factura_No,
            this.ANombre,
            this.Telefono1,
            this.Cuotas_Vencida,
            this.Total,
            this.Fecha_Proximo_Pago,
            this.Dias_Atrazo,
            this.Oficial_Id,
            this.Oficial_Nombre});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(12, 100);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 28;
            this.dtgData.Size = new System.Drawing.Size(1181, 368);
            this.dtgData.TabIndex = 47;
            this.dtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellContentClick);
            this.dtgData.SelectionChanged += new System.EventHandler(this.dtgData_SelectionChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(888, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(289, 72);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(0, 0);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(888, 72);
            this.txtDescripcion.TabIndex = 3;
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
            this.Prestamo_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prestamo_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Prestamo_Id.Width = 120;
            // 
            // Factura_No
            // 
            this.Factura_No.DataPropertyName = "Factura_No";
            this.Factura_No.HeaderText = "Factura No";
            this.Factura_No.Name = "Factura_No";
            this.Factura_No.ReadOnly = true;
            this.Factura_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Factura_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Factura_No.Width = 110;
            // 
            // ANombre
            // 
            this.ANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANombre.DataPropertyName = "ANombre";
            this.ANombre.HeaderText = "ANombre";
            this.ANombre.Name = "ANombre";
            this.ANombre.ReadOnly = true;
            // 
            // Telefono1
            // 
            this.Telefono1.DataPropertyName = "Telefonos";
            this.Telefono1.HeaderText = "Telefono";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Width = 150;
            // 
            // Cuotas_Vencida
            // 
            this.Cuotas_Vencida.DataPropertyName = "No_Cuota_VP";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "0";
            this.Cuotas_Vencida.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cuotas_Vencida.HeaderText = "Cuo. P";
            this.Cuotas_Vencida.Name = "Cuotas_Vencida";
            this.Cuotas_Vencida.ReadOnly = true;
            this.Cuotas_Vencida.Width = 75;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total_VP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 130;
            // 
            // Fecha_Proximo_Pago
            // 
            this.Fecha_Proximo_Pago.DataPropertyName = "Fecha_Proximo_Pago";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Fecha_Proximo_Pago.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha_Proximo_Pago.HeaderText = "Fe. Pr. Pago";
            this.Fecha_Proximo_Pago.Name = "Fecha_Proximo_Pago";
            this.Fecha_Proximo_Pago.ReadOnly = true;
            this.Fecha_Proximo_Pago.Width = 130;
            // 
            // Dias_Atrazo
            // 
            this.Dias_Atrazo.DataPropertyName = "Dias_Atrazo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "0";
            this.Dias_Atrazo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dias_Atrazo.HeaderText = "Dias Atrazo";
            this.Dias_Atrazo.Name = "Dias_Atrazo";
            this.Dias_Atrazo.ReadOnly = true;
            // 
            // Oficial_Id
            // 
            this.Oficial_Id.DataPropertyName = "Oficial_Id";
            this.Oficial_Id.HeaderText = "Codigo Oficial Credito";
            this.Oficial_Id.Name = "Oficial_Id";
            this.Oficial_Id.ReadOnly = true;
            this.Oficial_Id.Visible = false;
            // 
            // Oficial_Nombre
            // 
            this.Oficial_Nombre.DataPropertyName = "Oficial_Nombre";
            this.Oficial_Nombre.HeaderText = "Oficial Credito Nombre";
            this.Oficial_Nombre.Name = "Oficial_Nombre";
            this.Oficial_Nombre.ReadOnly = true;
            this.Oficial_Nombre.Visible = false;
            // 
            // FormConsultaVencidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 566);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.EsAgregar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.FiltroEstatico = "BALANCE > 0 AND IsNull(NO_CUOTA_VP, 0) > 0";
            this.Limite = -1;
            this.Name = "FormConsultaVencidas";
            this.NombreCampoID = "Prestamo_Id";
            this.TablaOVista = "VPRESTAMOS";
            this.Text = "CONSULTA DE VENCIDAS";
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Prestamo_Id;
        private System.Windows.Forms.DataGridViewLinkColumn Factura_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas_Vencida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Proximo_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Atrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficial_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficial_Nombre;
    }
}