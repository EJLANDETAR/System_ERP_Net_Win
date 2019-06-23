namespace ELRNomina
{
    partial class FormNominaTablaISR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota_Fija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Excedente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(0, 338);
            this.pnTotales.Size = new System.Drawing.Size(701, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(687, 46);
            this.pnBusqSencilla.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 286);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Monto_Desde,
            this.Monto_Hasta,
            this.Cuota_Fija,
            this.Tasa_Excedente,
            this.Borrar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(687, 240);
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
            // Monto_Desde
            // 
            this.Monto_Desde.DataPropertyName = "Monto_Desde";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto_Desde.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto_Desde.HeaderText = "Desde";
            this.Monto_Desde.Name = "Monto_Desde";
            this.Monto_Desde.ReadOnly = true;
            this.Monto_Desde.Width = 140;
            // 
            // Monto_Hasta
            // 
            this.Monto_Hasta.DataPropertyName = "Monto_Hasta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Monto_Hasta.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto_Hasta.HeaderText = "Hasta";
            this.Monto_Hasta.Name = "Monto_Hasta";
            this.Monto_Hasta.ReadOnly = true;
            this.Monto_Hasta.Width = 140;
            // 
            // Cuota_Fija
            // 
            this.Cuota_Fija.DataPropertyName = "Cuota_Fija";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Cuota_Fija.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cuota_Fija.HeaderText = "Cuota Fija";
            this.Cuota_Fija.Name = "Cuota_Fija";
            this.Cuota_Fija.ReadOnly = true;
            this.Cuota_Fija.Width = 140;
            // 
            // Tasa_Excedente
            // 
            this.Tasa_Excedente.DataPropertyName = "Tasa_Excedente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Tasa_Excedente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tasa_Excedente.HeaderText = "% Excedente";
            this.Tasa_Excedente.Name = "Tasa_Excedente";
            this.Tasa_Excedente.ReadOnly = true;
            this.Tasa_Excedente.Width = 120;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForButtonValue = true;
            // 
            // FormNominaTablaISR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Monto_Desde";
            this.ClientSize = new System.Drawing.Size(701, 412);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsFilasAMostrar = false;
            this.FiltroEstatico = "Fecha_Deleted Is Null";
            this.FormularioRegistro = "ELRNomina.FormNominaTablaISRR";
            this.Limite = -1;
            this.Name = "FormNominaTablaISR";
            this.NombreCampoID = "Unico";
            this.TablaOVista = "TNOMINA_TABLA_ISR";
            this.Text = "TABLA DESCUENTO IMPUESTO SOBRE LA RENTA(ISR VALORES ANUALES)";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota_Fija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Excedente;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}