namespace ELRFacturas
{
    partial class FormPrestamosCargos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Atrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsDemora = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 401);
            this.pnTotales.Size = new System.Drawing.Size(820, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(820, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Descripcion Like \'%\' + @aBuscar + \'%\'";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 401);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cargo_Id,
            this.Descripcion,
            this.Monto,
            this.Dias_Atrazo,
            this.Tasa_Demora,
            this.EsDemora});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(820, 303);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Cargo_Id
            // 
            this.Cargo_Id.DataPropertyName = "Cargo_Id";
            this.Cargo_Id.HeaderText = "Cargo Id";
            this.Cargo_Id.Name = "Cargo_Id";
            this.Cargo_Id.ReadOnly = true;
            this.Cargo_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cargo_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cargo_Id.Width = 85;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 120;
            // 
            // Dias_Atrazo
            // 
            this.Dias_Atrazo.DataPropertyName = "Dias_Atrazo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.Dias_Atrazo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dias_Atrazo.HeaderText = "Dias Atrazo";
            this.Dias_Atrazo.Name = "Dias_Atrazo";
            this.Dias_Atrazo.ReadOnly = true;
            // 
            // Tasa_Demora
            // 
            this.Tasa_Demora.DataPropertyName = "Tasa_Demora";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Tasa_Demora.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tasa_Demora.HeaderText = "Tasa Demora";
            this.Tasa_Demora.Name = "Tasa_Demora";
            this.Tasa_Demora.ReadOnly = true;
            this.Tasa_Demora.Width = 120;
            // 
            // EsDemora
            // 
            this.EsDemora.DataPropertyName = "EsDemora";
            this.EsDemora.HeaderText = "EsDemora";
            this.EsDemora.Name = "EsDemora";
            this.EsDemora.ReadOnly = true;
            this.EsDemora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsDemora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormPrestamosCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 475);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRFacturas.FormPrestamosCargosR";
            this.Name = "FormPrestamosCargos";
            this.NombreCampoID = "Cargo_Id";
            this.TablaOVista = "TPRESTAMOS_CARGOS";
            this.Text = "CONFIGURACION DE CARGOS A APLICAR ";
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Cargo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Atrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Demora;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsDemora;
    }
}