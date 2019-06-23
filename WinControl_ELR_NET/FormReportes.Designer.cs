namespace WinControl_ELR_NET
{
    partial class FormReportes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reporte_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportRDLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTablaOVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnBusqSencilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(926, 52);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Nombre Like \'%\' + @aBuscar + \'%\'";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Reporte_Id,
            this.Nombre,
            this.ReportRDLC,
            this.clnTablaOVista,
            this.EsActivo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(926, 368);
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
            // Reporte_Id
            // 
            this.Reporte_Id.DataPropertyName = "Reporte_Id";
            this.Reporte_Id.HeaderText = "Id";
            this.Reporte_Id.Name = "Reporte_Id";
            this.Reporte_Id.ReadOnly = true;
            this.Reporte_Id.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 280;
            // 
            // ReportRDLC
            // 
            this.ReportRDLC.DataPropertyName = "ReportRDLC";
            this.ReportRDLC.HeaderText = "ReportRDLC";
            this.ReportRDLC.Name = "ReportRDLC";
            this.ReportRDLC.ReadOnly = true;
            this.ReportRDLC.Width = 230;
            // 
            // clnTablaOVista
            // 
            this.clnTablaOVista.DataPropertyName = "TablaOVista";
            this.clnTablaOVista.HeaderText = "Tabla O Vista";
            this.clnTablaOVista.Name = "clnTablaOVista";
            this.clnTablaOVista.ReadOnly = true;
            this.clnTablaOVista.Width = 220;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "EsActivo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "WinControl_ELR_NET.FormReportesR";
            this.Name = "FormReportes";
            this.NombreCampoID = "Reporte_Id";
            this.TablaOVista = "TSISTEMA_MODULOS_REPORTES";
            this.Text = "LISTADO DE REPORTES RDLC";
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reporte_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportRDLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTablaOVista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
    }
}