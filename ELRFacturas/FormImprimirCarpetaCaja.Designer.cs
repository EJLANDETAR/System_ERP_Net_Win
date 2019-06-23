namespace ELRFacturas
{
    partial class FormImprimirCarpetaCaja
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
            this.Apertura_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Caja_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_En_Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBusqSencilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Size = new System.Drawing.Size(822, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Size = new System.Drawing.Size(808, 46);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Apertura_No,
            this.Caja_Id,
            this.Fecha_Apertura,
            this.Usuario_En_Caja,
            this.Fecha_Cierre});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(808, 368);
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
            // Apertura_No
            // 
            this.Apertura_No.DataPropertyName = "Apertura_No";
            this.Apertura_No.HeaderText = "Numero";
            this.Apertura_No.Name = "Apertura_No";
            this.Apertura_No.ReadOnly = true;
            this.Apertura_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Apertura_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Apertura_No.Width = 85;
            // 
            // Caja_Id
            // 
            this.Caja_Id.DataPropertyName = "Caja_Id";
            this.Caja_Id.HeaderText = "Caja No";
            this.Caja_Id.Name = "Caja_Id";
            this.Caja_Id.ReadOnly = true;
            this.Caja_Id.Width = 85;
            // 
            // Fecha_Apertura
            // 
            this.Fecha_Apertura.DataPropertyName = "Fecha_Apertura";
            this.Fecha_Apertura.HeaderText = "Fecha Apertura";
            this.Fecha_Apertura.Name = "Fecha_Apertura";
            this.Fecha_Apertura.ReadOnly = true;
            this.Fecha_Apertura.Width = 150;
            // 
            // Usuario_En_Caja
            // 
            this.Usuario_En_Caja.DataPropertyName = "Usuario_En_Caja";
            this.Usuario_En_Caja.HeaderText = "Usuario";
            this.Usuario_En_Caja.Name = "Usuario_En_Caja";
            this.Usuario_En_Caja.ReadOnly = true;
            this.Usuario_En_Caja.Width = 300;
            // 
            // Fecha_Cierre
            // 
            this.Fecha_Cierre.DataPropertyName = "Fecha_Cierre";
            this.Fecha_Cierre.HeaderText = "Fecha Cierre";
            this.Fecha_Cierre.Name = "Fecha_Cierre";
            this.Fecha_Cierre.ReadOnly = true;
            this.Fecha_Cierre.Width = 150;
            // 
            // FormImprimirCarpetaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Apertura_No Desc";
            this.ClientSize = new System.Drawing.Size(822, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.Name = "FormImprimirCarpetaCaja";
            this.NombreCampoID = "Apertura_No";
            this.TablaOVista = "TCAJAS_APERTURA_CIERRE";
            this.Text = "IMPRIMIR CIERRE O CARPETA DE CAJA";
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
        private System.Windows.Forms.DataGridViewLinkColumn Apertura_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_En_Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Cierre;
    }
}