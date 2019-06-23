namespace ELRCuentasPorPagar
{
    partial class FormCXP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Entidad_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(926, 46);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entidad_Id,
            this.CedulaRNC,
            this.ANombre,
            this.Telefono1,
            this.Telefono2,
            this.Monto_Pendiente});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(926, 396);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Entidad_Id
            // 
            this.Entidad_Id.DataPropertyName = "Entidad_Id";
            this.Entidad_Id.HeaderText = "Codigo";
            this.Entidad_Id.Name = "Entidad_Id";
            this.Entidad_Id.ReadOnly = true;
            this.Entidad_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Entidad_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Entidad_Id.Width = 90;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 130;
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
            this.Telefono1.DataPropertyName = "Telefono1";
            this.Telefono1.HeaderText = "Telefono 1";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Width = 130;
            // 
            // Telefono2
            // 
            this.Telefono2.DataPropertyName = "Telefono2";
            this.Telefono2.HeaderText = "Telefono 2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            this.Telefono2.Width = 130;
            // 
            // Monto_Pendiente
            // 
            this.Monto_Pendiente.DataPropertyName = "Monto_Pendiente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto_Pendiente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto_Pendiente.HeaderText = "Monto";
            this.Monto_Pendiente.Name = "Monto_Pendiente";
            this.Monto_Pendiente.ReadOnly = true;
            this.Monto_Pendiente.Width = 140;
            // 
            // FormCXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Limite = -1;
            this.Name = "FormCXP";
            this.NombreCampoID = "Entidad_Id";
            this.TablaOVista = "VCXP_ANTIGUEDAD_SALDO";
            this.Text = "LISTADO DE CUENTAS POR PAGAR";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Entidad_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pendiente;
    }
}