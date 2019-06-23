namespace ELRMaestros
{
    partial class FormEmpresas
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
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siglas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(825, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(825, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Nombre Like \'%\' + @aBuscar + \'%\'";
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
            this.Empresa_Id,
            this.Rnc,
            this.Nombre,
            this.Siglas,
            this.Direccion_Web});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 98);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.Size = new System.Drawing.Size(825, 368);
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
            // Empresa_Id
            // 
            this.Empresa_Id.DataPropertyName = "Empresa_Id";
            this.Empresa_Id.HeaderText = "Id";
            this.Empresa_Id.Name = "Empresa_Id";
            this.Empresa_Id.ReadOnly = true;
            this.Empresa_Id.Width = 80;
            // 
            // Rnc
            // 
            this.Rnc.DataPropertyName = "Rnc";
            this.Rnc.HeaderText = "RNC";
            this.Rnc.Name = "Rnc";
            this.Rnc.ReadOnly = true;
            this.Rnc.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Siglas
            // 
            this.Siglas.DataPropertyName = "Siglas";
            this.Siglas.HeaderText = "Siglas";
            this.Siglas.Name = "Siglas";
            this.Siglas.ReadOnly = true;
            this.Siglas.Width = 150;
            // 
            // Direccion_Web
            // 
            this.Direccion_Web.DataPropertyName = "Direccion_Web";
            this.Direccion_Web.HeaderText = "Web";
            this.Direccion_Web.Name = "Direccion_Web";
            this.Direccion_Web.ReadOnly = true;
            this.Direccion_Web.Width = 200;
            // 
            // FormEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 540);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.FormularioRegistro = "ELRMaestros.FormEmpresaR";
            this.Limite = 200;
            this.Name = "FormEmpresas";
            this.NombreCampoID = "Empresa_Id";
            this.TablaOVista = "TEMPRESAS";
            this.Text = "FormEmpresas";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siglas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Web;
    }
}