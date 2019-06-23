namespace WinControl_ELR_NET
{
    partial class FormOpcionesMenus
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
            this.Menu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsModal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrdenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 448);
            this.pnTotales.Size = new System.Drawing.Size(1007, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1007, 47);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Nombre Like \'%\' + @aBuscar + \'%\'";
            this.txtABuscar.Location = new System.Drawing.Point(111, 8);
            this.txtABuscar.Size = new System.Drawing.Size(307, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = null;
            this.btnBuscar.Location = new System.Drawing.Point(424, 6);
            this.btnBuscar.Size = new System.Drawing.Size(84, 30);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 8);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 448);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Menu_Id,
            this.Nombre,
            this.EsActivo,
            this.EsModal,
            this.OrdenNo,
            this.Modulo,
            this.Modulo_Id});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 349);
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
            // Menu_Id
            // 
            this.Menu_Id.DataPropertyName = "Menu_Id";
            this.Menu_Id.HeaderText = "Menu Id";
            this.Menu_Id.Name = "Menu_Id";
            this.Menu_Id.ReadOnly = true;
            this.Menu_Id.Width = 85;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "EsActivo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            this.EsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EsModal
            // 
            this.EsModal.DataPropertyName = "EsModal";
            this.EsModal.HeaderText = "EsModal";
            this.EsModal.Name = "EsModal";
            this.EsModal.ReadOnly = true;
            this.EsModal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsModal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OrdenNo
            // 
            this.OrdenNo.DataPropertyName = "OrdenNo";
            this.OrdenNo.HeaderText = "Orden No";
            this.OrdenNo.Name = "OrdenNo";
            this.OrdenNo.ReadOnly = true;
            this.OrdenNo.Width = 90;
            // 
            // Modulo
            // 
            this.Modulo.DataPropertyName = "Modulo";
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            this.Modulo.Width = 230;
            // 
            // Modulo_Id
            // 
            this.Modulo_Id.DataPropertyName = "Modulo_Id";
            this.Modulo_Id.HeaderText = "Modulo Id";
            this.Modulo_Id.Name = "Modulo_Id";
            this.Modulo_Id.ReadOnly = true;
            this.Modulo_Id.Visible = false;
            // 
            // FormOpcionesMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Order by Modulo_Id,  EsMenuConsulta, OrdenNo";
            this.ClientSize = new System.Drawing.Size(1021, 522);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "WinControl_ELR_NET.FormOpcionesMenusR";
            this.Name = "FormOpcionesMenus";
            this.NombreCampoID = "Menu_Id";
            this.TablaOVista = "VOPCIONES_X_MODULOS";
            this.Text = "LISTA DE OPCIONES O MENU";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsModal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo_Id;
    }
}