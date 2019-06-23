namespace ELRFacturas
{
    partial class FormConsultaCXC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_VP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Atrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(1042, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1042, 42);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Campo_Busqueda Like \'%\' + @aBuscar + \'%\'";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Prestamo_Id,
            this.Numero,
            this.Fecha,
            this.CedulaRNC,
            this.ANombre,
            this.Prestamo_Monto,
            this.Balance_Pendiente,
            this.Total_VP,
            this.Dias_Atrazo,
            this.Estatus});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 94);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 25;
            this.dtgData.RowTemplate.Height = 30;
            this.dtgData.Size = new System.Drawing.Size(1042, 372);
            this.dtgData.TabIndex = 47;
            this.dtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellContentClick);
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
            this.Prestamo_Id.HeaderText = "Prestamo No.";
            this.Prestamo_Id.Name = "Prestamo_Id";
            this.Prestamo_Id.ReadOnly = true;
            this.Prestamo_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prestamo_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Prestamo_Id.Width = 115;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle16;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "Cedula\\RNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 120;
            // 
            // ANombre
            // 
            this.ANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANombre.DataPropertyName = "ANombre";
            this.ANombre.HeaderText = "Nombre";
            this.ANombre.Name = "ANombre";
            this.ANombre.ReadOnly = true;
            // 
            // Prestamo_Monto
            // 
            this.Prestamo_Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = "0.00";
            this.Prestamo_Monto.DefaultCellStyle = dataGridViewCellStyle17;
            this.Prestamo_Monto.HeaderText = "Monto";
            this.Prestamo_Monto.Name = "Prestamo_Monto";
            this.Prestamo_Monto.ReadOnly = true;
            this.Prestamo_Monto.Width = 130;
            // 
            // Balance_Pendiente
            // 
            this.Balance_Pendiente.DataPropertyName = "Balance";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = "0.00";
            this.Balance_Pendiente.DefaultCellStyle = dataGridViewCellStyle18;
            this.Balance_Pendiente.HeaderText = "S. Pendiente";
            this.Balance_Pendiente.Name = "Balance_Pendiente";
            this.Balance_Pendiente.ReadOnly = true;
            this.Balance_Pendiente.Width = 130;
            // 
            // Total_VP
            // 
            this.Total_VP.DataPropertyName = "Total_VP";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = "0.00";
            this.Total_VP.DefaultCellStyle = dataGridViewCellStyle19;
            this.Total_VP.HeaderText = "Monto V.P";
            this.Total_VP.Name = "Total_VP";
            this.Total_VP.ReadOnly = true;
            this.Total_VP.Width = 120;
            // 
            // Dias_Atrazo
            // 
            this.Dias_Atrazo.DataPropertyName = "Dias_Atrazo";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = "0";
            this.Dias_Atrazo.DefaultCellStyle = dataGridViewCellStyle20;
            this.Dias_Atrazo.HeaderText = "Dias Atraso";
            this.Dias_Atrazo.Name = "Dias_Atrazo";
            this.Dias_Atrazo.ReadOnly = true;
            this.Dias_Atrazo.Width = 110;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Visible = false;
            this.Estatus.Width = 200;
            // 
            // FormConsultaCXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Dias_Atrazo Desc, Prestamo_Id";
            this.ClientSize = new System.Drawing.Size(1056, 540);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.FiltroEstatico = "Balance > 0 and Monto > 0";
            this.Limite = 200;
            this.Name = "FormConsultaCXC";
            this.NombreCampoID = "Prestamo_Id";
            this.TablaOVista = "VPRESTAMOS";
            this.Text = "CONSULTA CUENTAS POR COBRAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCuentasPorCobrar_Load);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Prestamo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_VP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Atrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}