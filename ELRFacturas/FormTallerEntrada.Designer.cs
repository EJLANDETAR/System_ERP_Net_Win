namespace ELRFacturas
{
    partial class FormTallerEntrada
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
            this.Identificador_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.elrDatePicker1 = new WinControl_ELR_NET.ELRDatePicker();
            this.elrDatePicker2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pnBusqSencilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(951, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.elrDatePicker2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.elrDatePicker1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Size = new System.Drawing.Size(951, 75);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrDatePicker1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrDatePicker2, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(113, 39);
            this.txtABuscar.Size = new System.Drawing.Size(322, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(441, 7);
            this.btnBuscar.Size = new System.Drawing.Size(119, 61);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 39);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Identificador_Id,
            this.Categoria,
            this.Nombre,
            this.Telefono1,
            this.Estatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(951, 339);
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
            // Identificador_Id
            // 
            this.Identificador_Id.DataPropertyName = "Identificador_Id";
            this.Identificador_Id.HeaderText = "Numero";
            this.Identificador_Id.Name = "Identificador_Id";
            this.Identificador_Id.ReadOnly = true;
            this.Identificador_Id.Width = 85;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 230;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // Telefono1
            // 
            this.Telefono1.DataPropertyName = "Telefono1";
            this.Telefono1.HeaderText = "Telefono";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Width = 150;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Desde:";
            // 
            // elrDatePicker1
            // 
            this.elrDatePicker1.CampoData = "";
            this.elrDatePicker1.DSData = null;
            this.elrDatePicker1.EsEditable = true;
            this.elrDatePicker1.FiltroBusqueda = "";
            this.elrDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.elrDatePicker1.Location = new System.Drawing.Point(113, 7);
            this.elrDatePicker1.Name = "elrDatePicker1";
            this.elrDatePicker1.NombreTabla = "";
            this.elrDatePicker1.Size = new System.Drawing.Size(115, 26);
            this.elrDatePicker1.TabIndex = 4;
            this.elrDatePicker1.ValorPorDefecto = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // elrDatePicker2
            // 
            this.elrDatePicker2.CampoData = "";
            this.elrDatePicker2.DSData = null;
            this.elrDatePicker2.EsEditable = true;
            this.elrDatePicker2.FiltroBusqueda = "";
            this.elrDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.elrDatePicker2.Location = new System.Drawing.Point(320, 7);
            this.elrDatePicker2.Name = "elrDatePicker2";
            this.elrDatePicker2.NombreTabla = "";
            this.elrDatePicker2.Size = new System.Drawing.Size(115, 26);
            this.elrDatePicker2.TabIndex = 6;
            this.elrDatePicker2.ValorPorDefecto = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hasta:";
            // 
            // FormTallerEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsModificar = false;
            this.Name = "FormTallerEntrada";
            this.NombreCampoID = "Identificador_Id";
            this.TablaOVista = "VTALLER";
            this.Text = "ENTRADAS DE EQUIPOS A TALLER";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private WinControl_ELR_NET.ELRDatePicker elrDatePicker2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker elrDatePicker1;
        private System.Windows.Forms.Label label6;
    }
}