namespace ELRContaGeneral
{
    partial class FormCatalogoCuentas
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
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsCuentaControl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Balance_Mes_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(1014, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1014, 46);
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
            this.Cuenta_Contable,
            this.Descripcion,
            this.EsCuentaControl,
            this.Balance_Mes_Anterior,
            this.Debito_Mes,
            this.Credito_Mes,
            this.Balance_Actual});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 368);
            this.dataGridView1.TabIndex = 47;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.HeaderText = "Cuenta Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 230;
            // 
            // EsCuentaControl
            // 
            this.EsCuentaControl.HeaderText = "Es Control";
            this.EsCuentaControl.Name = "EsCuentaControl";
            this.EsCuentaControl.ReadOnly = true;
            this.EsCuentaControl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsCuentaControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Balance_Mes_Anterior
            // 
            this.Balance_Mes_Anterior.HeaderText = "B. Mes Anterior";
            this.Balance_Mes_Anterior.Name = "Balance_Mes_Anterior";
            this.Balance_Mes_Anterior.ReadOnly = true;
            this.Balance_Mes_Anterior.Width = 130;
            // 
            // Debito_Mes
            // 
            this.Debito_Mes.HeaderText = "Debito Mes";
            this.Debito_Mes.Name = "Debito_Mes";
            this.Debito_Mes.ReadOnly = true;
            this.Debito_Mes.Width = 120;
            // 
            // Credito_Mes
            // 
            this.Credito_Mes.HeaderText = "Credito Mes";
            this.Credito_Mes.Name = "Credito_Mes";
            this.Credito_Mes.ReadOnly = true;
            this.Credito_Mes.Width = 120;
            // 
            // Balance_Actual
            // 
            this.Balance_Actual.HeaderText = "B. Actual";
            this.Balance_Actual.Name = "Balance_Actual";
            this.Balance_Actual.ReadOnly = true;
            this.Balance_Actual.Width = 120;
            // 
            // FormCatalogoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 540);
            this.Controls.Add(this.dataGridView1);
            this.EsImprimir = true;
            this.Name = "FormCatalogoCuentas";
            this.Text = "CATALOGO DE CUENTAS, BALANCE GENERAL";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsCuentaControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Mes_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Actual;
    }
}