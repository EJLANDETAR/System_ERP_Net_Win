namespace ELRMaestros
{
    partial class FormOficinasNCF
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
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_NCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valido_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(880, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(880, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Descripcion Like \'%\' + @aBuscar + \'%\'";
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
            this.Descripcion,
            this.Prefijo,
            this.Numero_NCF,
            this.Numero_Maximo,
            this.NCF_Disponible,
            this.Valido_Hasta});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 98);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 33;
            this.dtgData.Size = new System.Drawing.Size(880, 368);
            this.dtgData.TabIndex = 47;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Prefijo
            // 
            this.Prefijo.DataPropertyName = "Prefijo";
            this.Prefijo.HeaderText = "Prefijo";
            this.Prefijo.Name = "Prefijo";
            this.Prefijo.ReadOnly = true;
            this.Prefijo.Width = 90;
            // 
            // Numero_NCF
            // 
            this.Numero_NCF.DataPropertyName = "NumeroNCF";
            this.Numero_NCF.HeaderText = "Numero NCF";
            this.Numero_NCF.Name = "Numero_NCF";
            this.Numero_NCF.ReadOnly = true;
            this.Numero_NCF.Width = 120;
            // 
            // Numero_Maximo
            // 
            this.Numero_Maximo.DataPropertyName = "Numero_Maximo";
            this.Numero_Maximo.HeaderText = "Limite NCF";
            this.Numero_Maximo.Name = "Numero_Maximo";
            this.Numero_Maximo.ReadOnly = true;
            // 
            // NCF_Disponible
            // 
            this.NCF_Disponible.DataPropertyName = "NCF_Disponible";
            this.NCF_Disponible.HeaderText = "Disponible";
            this.NCF_Disponible.Name = "NCF_Disponible";
            this.NCF_Disponible.ReadOnly = true;
            // 
            // Valido_Hasta
            // 
            this.Valido_Hasta.DataPropertyName = "Valido_Hasta";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Valido_Hasta.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valido_Hasta.HeaderText = "Valido Hasta";
            this.Valido_Hasta.Name = "Valido_Hasta";
            this.Valido_Hasta.ReadOnly = true;
            this.Valido_Hasta.Width = 120;
            // 
            // FormOficinasNCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 540);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.FormularioRegistro = "ELRMaestros.FormOficinaNCFR";
            this.Name = "FormOficinasNCF";
            this.NombreCampoID = "Unico";
            this.TablaOVista = "VEMPRESAS_NCF_X_OFICINAS";
            this.Text = "NCF - COMPROBANTES FISCALES POR OFICINAS";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_NCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF_Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valido_Hasta;
    }
}