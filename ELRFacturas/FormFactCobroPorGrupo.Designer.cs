namespace ELRFacturas
{
    partial class FormFactCobroPorGrupo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Entidad_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otros_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Size = new System.Drawing.Size(940, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(926, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = " Nombre_Completo  Like \'%\' + @aBuscar + \'%\' ";
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
            this.Nombre_Completo,
            this.Capital_Pendiente,
            this.Interes_Pendiente,
            this.Demora_Pendiente,
            this.Otros_Pendiente,
            this.Telefono1,
            this.Telefono2,
            this.Monto});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(926, 396);
            this.dataGridView1.TabIndex = 47;
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
            // Nombre_Completo
            // 
            this.Nombre_Completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Completo.DataPropertyName = "Nombre_Completo";
            this.Nombre_Completo.HeaderText = "ANombre";
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.ReadOnly = true;
            // 
            // Capital_Pendiente
            // 
            this.Capital_Pendiente.DataPropertyName = "Capital_Pendiente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Capital_Pendiente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Capital_Pendiente.HeaderText = "Capital";
            this.Capital_Pendiente.Name = "Capital_Pendiente";
            this.Capital_Pendiente.ReadOnly = true;
            this.Capital_Pendiente.Width = 120;
            // 
            // Interes_Pendiente
            // 
            this.Interes_Pendiente.DataPropertyName = "Interes_Pendiente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Interes_Pendiente.DefaultCellStyle = dataGridViewCellStyle2;
            this.Interes_Pendiente.HeaderText = "Interes";
            this.Interes_Pendiente.Name = "Interes_Pendiente";
            this.Interes_Pendiente.ReadOnly = true;
            this.Interes_Pendiente.Width = 120;
            // 
            // Demora_Pendiente
            // 
            this.Demora_Pendiente.DataPropertyName = "Demora_Pendiente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Demora_Pendiente.DefaultCellStyle = dataGridViewCellStyle3;
            this.Demora_Pendiente.HeaderText = "Demora";
            this.Demora_Pendiente.Name = "Demora_Pendiente";
            this.Demora_Pendiente.ReadOnly = true;
            this.Demora_Pendiente.Width = 120;
            // 
            // Otros_Pendiente
            // 
            this.Otros_Pendiente.DataPropertyName = "Otros_Pendiente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Otros_Pendiente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Otros_Pendiente.HeaderText = "Otros";
            this.Otros_Pendiente.Name = "Otros_Pendiente";
            this.Otros_Pendiente.ReadOnly = true;
            this.Otros_Pendiente.Width = 120;
            // 
            // Telefono1
            // 
            this.Telefono1.DataPropertyName = "Telefono1";
            this.Telefono1.HeaderText = "Telefono 1";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Visible = false;
            this.Telefono1.Width = 130;
            // 
            // Telefono2
            // 
            this.Telefono2.DataPropertyName = "Telefono2";
            this.Telefono2.HeaderText = "Telefono 2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            this.Telefono2.Visible = false;
            this.Telefono2.Width = 130;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto.HeaderText = "Total";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 140;
            // 
            // FormFactCobroPorGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.Limite = -1;
            this.Name = "FormFactCobroPorGrupo";
            this.NombreCampoID = "Entidad_Id";
            this.TablaOVista = "VENTIDAD_CXC";
            this.Text = "REGISTRAR RECIBO DE CUENTA POR COBRAR";
            this.ValidaCajaAbierta = true;
            this.ValidaMonedaUS = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demora_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otros_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}