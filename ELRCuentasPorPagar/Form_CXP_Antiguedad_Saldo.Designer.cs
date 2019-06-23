namespace ELRCuentasPorPagar
{
    partial class Form_CXP_Antiguedad_Saldo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P0_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P31_60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P61_90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P91_120 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM_121 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new WinControl_ELR_NET.ELRLabel();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.lblTotal);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 488);
            this.pnTotales.Size = new System.Drawing.Size(1162, 58);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.lblTotal, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1148, 46);
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Size = new System.Drawing.Size(57, 20);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 436);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CedulaRNC,
            this.ANombre,
            this.P0_30,
            this.P31_60,
            this.P61_90,
            this.P91_120,
            this.PM_121,
            this.Monto_Pendiente});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 22;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 390);
            this.dataGridView1.TabIndex = 47;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.Width = 140;
            // 
            // ANombre
            // 
            this.ANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANombre.DataPropertyName = "ANombre";
            this.ANombre.HeaderText = "Suplidor";
            this.ANombre.Name = "ANombre";
            // 
            // P0_30
            // 
            this.P0_30.DataPropertyName = "P0_30";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.P0_30.DefaultCellStyle = dataGridViewCellStyle1;
            this.P0_30.HeaderText = "De 0 a 30";
            this.P0_30.Name = "P0_30";
            this.P0_30.Width = 130;
            // 
            // P31_60
            // 
            this.P31_60.DataPropertyName = "P31_60";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.P31_60.DefaultCellStyle = dataGridViewCellStyle2;
            this.P31_60.HeaderText = "De 31 a 60";
            this.P31_60.Name = "P31_60";
            this.P31_60.Width = 130;
            // 
            // P61_90
            // 
            this.P61_90.DataPropertyName = "P61_90";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.P61_90.DefaultCellStyle = dataGridViewCellStyle3;
            this.P61_90.HeaderText = "De 61 a 90";
            this.P61_90.Name = "P61_90";
            this.P61_90.Width = 130;
            // 
            // P91_120
            // 
            this.P91_120.DataPropertyName = "P91_120";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.P91_120.DefaultCellStyle = dataGridViewCellStyle4;
            this.P91_120.HeaderText = "De 91 a 120";
            this.P91_120.Name = "P91_120";
            this.P91_120.Width = 130;
            // 
            // PM_121
            // 
            this.PM_121.DataPropertyName = "PM_121";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.PM_121.DefaultCellStyle = dataGridViewCellStyle5;
            this.PM_121.HeaderText = "M121";
            this.PM_121.Name = "PM_121";
            this.PM_121.Width = 130;
            // 
            // Monto_Pendiente
            // 
            this.Monto_Pendiente.DataPropertyName = "Monto_Pendiente";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Monto_Pendiente.DefaultCellStyle = dataGridViewCellStyle6;
            this.Monto_Pendiente.HeaderText = "Total";
            this.Monto_Pendiente.Name = "Monto_Pendiente";
            this.Monto_Pendiente.Width = 130;
            // 
            // lblTotal
            // 
            this.lblTotal.CampoData = "";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.DSData = null;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.NombreTabla = "";
            this.lblTotal.Size = new System.Drawing.Size(1158, 54);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Cuenta Por Pagar:  0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.ValorPorDefecto = "";
            // 
            // Form_CXP_Antiguedad_Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "P0_30 Desc";
            this.ClientSize = new System.Drawing.Size(1162, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Limite = -1;
            this.Name = "Form_CXP_Antiguedad_Saldo";
            this.NombreCampoID = "Entidad_Id";
            this.TablaOVista = "VCXP_ANTIGUEDAD_SALDO";
            this.Text = "CUENTA POR PAGAR POR ANTIGUEDAD DE SALDO";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn P0_30;
        private System.Windows.Forms.DataGridViewTextBoxColumn P31_60;
        private System.Windows.Forms.DataGridViewTextBoxColumn P61_90;
        private System.Windows.Forms.DataGridViewTextBoxColumn P91_120;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM_121;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pendiente;
        private WinControl_ELR_NET.ELRLabel lblTotal;
    }
}