namespace ELRCuentasPorPagar
{
    partial class FormNotaCreditoACompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CXP_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factrura_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF_Modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 46);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CXP_Id,
            this.Unico,
            this.Factrura_Numero,
            this.Fecha,
            this.NCF,
            this.NCF_Modificado,
            this.Itbis,
            this.Total,
            this.Estatus,
            this.Concepto,
            this.CedulaRNC,
            this.Nombre});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 396);
            this.dataGridView1.TabIndex = 49;
            // 
            // CXP_Id
            // 
            this.CXP_Id.DataPropertyName = "CXP_Id";
            this.CXP_Id.HeaderText = "CXP_Id";
            this.CXP_Id.Name = "CXP_Id";
            this.CXP_Id.ReadOnly = true;
            this.CXP_Id.Visible = false;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Factrura_Numero
            // 
            this.Factrura_Numero.DataPropertyName = "Factura_Numero";
            this.Factrura_Numero.HeaderText = "Numero";
            this.Factrura_Numero.Name = "Factrura_Numero";
            this.Factrura_Numero.ReadOnly = true;
            this.Factrura_Numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Factrura_Numero.Width = 130;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle7;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // NCF
            // 
            this.NCF.DataPropertyName = "NCF";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF.DefaultCellStyle = dataGridViewCellStyle8;
            this.NCF.HeaderText = "NCF";
            this.NCF.Name = "NCF";
            this.NCF.ReadOnly = true;
            this.NCF.Width = 150;
            // 
            // NCF_Modificado
            // 
            this.NCF_Modificado.DataPropertyName = "NCF_AModificar";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF_Modificado.DefaultCellStyle = dataGridViewCellStyle9;
            this.NCF_Modificado.HeaderText = "NCF Modificado";
            this.NCF_Modificado.Name = "NCF_Modificado";
            this.NCF_Modificado.ReadOnly = true;
            this.NCF_Modificado.Width = 150;
            // 
            // Itbis
            // 
            this.Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.Itbis.DefaultCellStyle = dataGridViewCellStyle10;
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.ReadOnly = true;
            this.Itbis.Width = 140;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle11;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 130;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estatus.DefaultCellStyle = dataGridViewCellStyle12;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Visible = false;
            this.Estatus.Width = 180;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Visible = false;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Suplidor";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FormNotaCreditoACompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Unico Desc";
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsModificar = false;
            this.FiltroEstatico = "Modulo = \'NCC\' and IsNull(EsNulo, 0) = 0";
            this.FormularioRegistro = "ELRCuentasPorPagar.FormNotaCreditoACompraR";
            this.Name = "FormNotaCreditoACompra";
            this.NombreCampoID = "CXP_Id";
            this.TablaOVista = "VCXP";
            this.Text = "NOTAS DE CREDITOS A FACTURA DE COMPRA";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CXP_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factrura_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF_Modificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}