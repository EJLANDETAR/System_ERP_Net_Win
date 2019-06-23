namespace ELRMaestros
{
    partial class FormProductos
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(1049, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1049, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.Size = new System.Drawing.Size(311, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(428, 6);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Producto_Id,
            this.Codigo_Barra,
            this.Nombre_Corto,
            this.Categoria,
            this.Marca,
            this.PrecioR,
            this.Precio_Minimo});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(14, 98);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(1049, 368);
            this.dgvData.TabIndex = 47;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Producto_Id
            // 
            this.Producto_Id.DataPropertyName = "Producto_Id";
            this.Producto_Id.HeaderText = "Id";
            this.Producto_Id.Name = "Producto_Id";
            this.Producto_Id.ReadOnly = true;
            this.Producto_Id.Width = 75;
            // 
            // Codigo_Barra
            // 
            this.Codigo_Barra.DataPropertyName = "Codigo_Barra";
            this.Codigo_Barra.HeaderText = "Codigo";
            this.Codigo_Barra.Name = "Codigo_Barra";
            this.Codigo_Barra.ReadOnly = true;
            this.Codigo_Barra.Width = 120;
            // 
            // Nombre_Corto
            // 
            this.Nombre_Corto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Corto.DataPropertyName = "Nombre_Corto";
            this.Nombre_Corto.HeaderText = "Nombre";
            this.Nombre_Corto.Name = "Nombre_Corto";
            this.Nombre_Corto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Visible = false;
            this.Categoria.Width = 200;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Visible = false;
            this.Marca.Width = 150;
            // 
            // PrecioR
            // 
            this.PrecioR.DataPropertyName = "PrecioR";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.PrecioR.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioR.HeaderText = "Pre. Regular";
            this.PrecioR.Name = "PrecioR";
            this.PrecioR.ReadOnly = true;
            this.PrecioR.Width = 120;
            // 
            // Precio_Minimo
            // 
            this.Precio_Minimo.DataPropertyName = "Precio_Minimo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Precio_Minimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio_Minimo.HeaderText = "Pre. Minimo";
            this.Precio_Minimo.Name = "Precio_Minimo";
            this.Precio_Minimo.ReadOnly = true;
            this.Precio_Minimo.Width = 120;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Unico Desc";
            this.ClientSize = new System.Drawing.Size(1063, 540);
            this.Controls.Add(this.dgvData);
            this.DataGridConsulta = this.dgvData;
            this.FormularioRegistro = "ELRMaestros.FormProductosR";
            this.Limite = 1000;
            this.Name = "FormProductos";
            this.NombreCampoID = "Producto_Id";
            this.TablaOVista = "VCATEGORIA_PRODUCTOS";
            this.Text = "PRODUCTOS Y/O SERVICIOS";
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Corto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Minimo;
    }
}