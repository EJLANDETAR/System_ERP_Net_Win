namespace ELRFacturas
{
    partial class FormTasaInteres
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Garantia_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Interes_Anual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Interes_Anual_Minima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Demora_Mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(918, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(918, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Descripcion Like \'%\' + @aBuscar + \'%\'";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEliminar,
            this.Unico,
            this.Tipo_Garantia_Id,
            this.Descripcion,
            this.Monto_Desde,
            this.Monto_Hasta,
            this.Tasa_Interes_Anual,
            this.Tasa_Interes_Anual_Minima,
            this.Tasa_Demora_Mensual});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 27;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(918, 368);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.HeaderText = "Borrar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            this.btnEliminar.Width = 80;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Tipo_Garantia_Id
            // 
            this.Tipo_Garantia_Id.DataPropertyName = "Tipo_Garantia_Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Garantia_Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tipo_Garantia_Id.HeaderText = "Garantia Id";
            this.Tipo_Garantia_Id.Name = "Tipo_Garantia_Id";
            this.Tipo_Garantia_Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Monto_Desde
            // 
            this.Monto_Desde.DataPropertyName = "Monto_Desde";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Monto_Desde.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto_Desde.HeaderText = "Desde";
            this.Monto_Desde.Name = "Monto_Desde";
            this.Monto_Desde.ReadOnly = true;
            this.Monto_Desde.Width = 120;
            // 
            // Monto_Hasta
            // 
            this.Monto_Hasta.DataPropertyName = "Monto_Hasta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Monto_Hasta.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto_Hasta.HeaderText = "Hasta";
            this.Monto_Hasta.Name = "Monto_Hasta";
            this.Monto_Hasta.ReadOnly = true;
            this.Monto_Hasta.Width = 120;
            // 
            // Tasa_Interes_Anual
            // 
            this.Tasa_Interes_Anual.DataPropertyName = "Tasa_Interes_Anual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Tasa_Interes_Anual.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tasa_Interes_Anual.HeaderText = "% Int. Anual";
            this.Tasa_Interes_Anual.Name = "Tasa_Interes_Anual";
            this.Tasa_Interes_Anual.ReadOnly = true;
            this.Tasa_Interes_Anual.ToolTipText = "Porcentaje de Interes Anual";
            this.Tasa_Interes_Anual.Width = 120;
            // 
            // Tasa_Interes_Anual_Minima
            // 
            this.Tasa_Interes_Anual_Minima.DataPropertyName = "Tasa_Interes_Anual_Minima";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Tasa_Interes_Anual_Minima.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tasa_Interes_Anual_Minima.HeaderText = "% Int. Anual M.";
            this.Tasa_Interes_Anual_Minima.Name = "Tasa_Interes_Anual_Minima";
            this.Tasa_Interes_Anual_Minima.ReadOnly = true;
            this.Tasa_Interes_Anual_Minima.ToolTipText = "Porcentaje de Interes Anual Minimo";
            this.Tasa_Interes_Anual_Minima.Width = 120;
            // 
            // Tasa_Demora_Mensual
            // 
            this.Tasa_Demora_Mensual.DataPropertyName = "Tasa_Demora_Mensual";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Tasa_Demora_Mensual.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tasa_Demora_Mensual.HeaderText = "Demora";
            this.Tasa_Demora_Mensual.Name = "Tasa_Demora_Mensual";
            this.Tasa_Demora_Mensual.ReadOnly = true;
            // 
            // FormTasaInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRFacturas.FormTasaInteresR";
            this.Name = "FormTasaInteres";
            this.NombreCampoID = "Unico";
            this.TablaOVista = "VPRESTAMOS_TASA_INTERES";
            this.Text = "FormTasaInteres";
            this.Activated += new System.EventHandler(this.FormTasaInteres_Activated);
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
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Garantia_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Interes_Anual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Interes_Anual_Minima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Demora_Mensual;
    }
}