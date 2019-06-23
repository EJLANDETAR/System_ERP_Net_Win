namespace ELRActivosFijos
{
    partial class FormActivosFijosTipos
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
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vida_Util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Residual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsDepreciacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(0, 438);
            this.pnTotales.Size = new System.Drawing.Size(796, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(12, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(784, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.CondicionABuscar = "Descripcion  Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.Size = new System.Drawing.Size(303, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(420, 6);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(12, 386);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Tipo_Id,
            this.Descripcion,
            this.Vida_Util,
            this.Valor_Residual,
            this.EsDepreciacion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(784, 340);
            this.dataGridView1.TabIndex = 47;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Tipo_Id
            // 
            this.Tipo_Id.DataPropertyName = "Tipo_Id";
            this.Tipo_Id.HeaderText = "Codigo";
            this.Tipo_Id.Name = "Tipo_Id";
            this.Tipo_Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Vida_Util
            // 
            this.Vida_Util.DataPropertyName = "Vida_Util";
            this.Vida_Util.HeaderText = "Vida Util";
            this.Vida_Util.Name = "Vida_Util";
            this.Vida_Util.ReadOnly = true;
            // 
            // Valor_Residual
            // 
            this.Valor_Residual.DataPropertyName = "Valor_Residual";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Valor_Residual.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_Residual.HeaderText = "Valor Residual";
            this.Valor_Residual.Name = "Valor_Residual";
            this.Valor_Residual.ReadOnly = true;
            this.Valor_Residual.Width = 120;
            // 
            // EsDepreciacion
            // 
            this.EsDepreciacion.DataPropertyName = "EsDepreciacion";
            this.EsDepreciacion.HeaderText = "EsDepreciacion";
            this.EsDepreciacion.Name = "EsDepreciacion";
            this.EsDepreciacion.ReadOnly = true;
            this.EsDepreciacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsDepreciacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsDepreciacion.Width = 120;
            // 
            // FormActivosFijosTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Unico";
            this.ClientSize = new System.Drawing.Size(796, 512);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRActivosFijos.FormActivosFijosTiposR";
            this.Name = "FormActivosFijosTipos";
            this.NombreCampoID = "Tipo_Id";
            this.TablaOVista = "TACTIVOS_FIJOS_TIPOS";
            this.Text = "ACTIVOS FIJOS TIPOS";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vida_Util;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Residual;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsDepreciacion;
    }
}