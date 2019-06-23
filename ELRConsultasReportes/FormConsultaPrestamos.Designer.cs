namespace ELRConsultasReportes
{
    partial class FormConsultaPrestamos
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
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Factura_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Atrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.btnImprimirHistorial = new System.Windows.Forms.Button();
            this.btnImprimirCredito = new System.Windows.Forms.Button();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(1011, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnImprimirCredito);
            this.pnBusqSencilla.Controls.Add(this.btnImprimirHistorial);
            this.pnBusqSencilla.Controls.Add(this.elrCheckBox1);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1011, 66);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnImprimirHistorial, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnImprimirCredito, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Campo_Busqueda  Like \'%\' + @aBuscar + \'%\'";
            this.txtABuscar.Size = new System.Drawing.Size(294, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(411, 6);
            this.btnBuscar.Size = new System.Drawing.Size(128, 52);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.Prestamo_Id,
            this.Factura_No,
            this.Fecha,
            this.CedulaRNC,
            this.ANombre,
            this.Prestamo_Monto,
            this.Balance_Pendiente,
            this.Dias_Atrazo,
            this.Estatus});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 118);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 25;
            this.dtgData.RowTemplate.Height = 30;
            this.dtgData.Size = new System.Drawing.Size(1011, 348);
            this.dtgData.TabIndex = 48;
            this.dtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellContentClick);
            this.dtgData.SelectionChanged += new System.EventHandler(this.dtgData_SelectionChanged);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Prestamo_Id
            // 
            this.Prestamo_Id.DataPropertyName = "Prestamo_Id";
            this.Prestamo_Id.HeaderText = "Prestamo Id";
            this.Prestamo_Id.Name = "Prestamo_Id";
            this.Prestamo_Id.ReadOnly = true;
            this.Prestamo_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prestamo_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Prestamo_Id.Width = 110;
            // 
            // Factura_No
            // 
            this.Factura_No.DataPropertyName = "Factura_No";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "0";
            this.Factura_No.DefaultCellStyle = dataGridViewCellStyle1;
            this.Factura_No.HeaderText = "Factura No.";
            this.Factura_No.Name = "Factura_No";
            this.Factura_No.ReadOnly = true;
            this.Factura_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Factura_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Factura_No.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.FillWeight = 90F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "Cedula\\RNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Visible = false;
            this.CedulaRNC.Width = 120;
            // 
            // ANombre
            // 
            this.ANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANombre.DataPropertyName = "ANombre";
            this.ANombre.HeaderText = "Nombre";
            this.ANombre.Name = "ANombre";
            this.ANombre.ReadOnly = true;
            // 
            // Prestamo_Monto
            // 
            this.Prestamo_Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Prestamo_Monto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prestamo_Monto.HeaderText = "Monto";
            this.Prestamo_Monto.Name = "Prestamo_Monto";
            this.Prestamo_Monto.ReadOnly = true;
            this.Prestamo_Monto.Width = 120;
            // 
            // Balance_Pendiente
            // 
            this.Balance_Pendiente.DataPropertyName = "Balance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Balance_Pendiente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Balance_Pendiente.HeaderText = "S. Pendiente";
            this.Balance_Pendiente.Name = "Balance_Pendiente";
            this.Balance_Pendiente.ReadOnly = true;
            this.Balance_Pendiente.Width = 120;
            // 
            // Dias_Atrazo
            // 
            this.Dias_Atrazo.DataPropertyName = "Dias_Atrazo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dias_Atrazo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dias_Atrazo.HeaderText = "D. Atraso";
            this.Dias_Atrazo.Name = "Dias_Atrazo";
            this.Dias_Atrazo.ReadOnly = true;
            this.Dias_Atrazo.ToolTipText = "Cantidad de Dia Atrazado";
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 175;
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "";
            this.elrCheckBox1.Checked = true;
            this.elrCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elrCheckBox1.DSData = null;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "(Estatus_Id = \'V\' Or Balance > 0)";
            this.elrCheckBox1.Location = new System.Drawing.Point(111, 34);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(191, 24);
            this.elrCheckBox1.TabIndex = 4;
            this.elrCheckBox1.Text = "Solo Prestamo Vigente";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // btnImprimirHistorial
            // 
            this.btnImprimirHistorial.Location = new System.Drawing.Point(693, 7);
            this.btnImprimirHistorial.Name = "btnImprimirHistorial";
            this.btnImprimirHistorial.Size = new System.Drawing.Size(142, 52);
            this.btnImprimirHistorial.TabIndex = 6;
            this.btnImprimirHistorial.Text = "Imprimir Historial Cobro";
            this.btnImprimirHistorial.UseVisualStyleBackColor = true;
            this.btnImprimirHistorial.Click += new System.EventHandler(this.btnImprimirHistorial_Click);
            // 
            // btnImprimirCredito
            // 
            this.btnImprimirCredito.Location = new System.Drawing.Point(545, 7);
            this.btnImprimirCredito.Name = "btnImprimirCredito";
            this.btnImprimirCredito.Size = new System.Drawing.Size(142, 52);
            this.btnImprimirCredito.TabIndex = 7;
            this.btnImprimirCredito.Text = "Imprimir";
            this.btnImprimirCredito.UseVisualStyleBackColor = true;
            this.btnImprimirCredito.Click += new System.EventHandler(this.btnImprimirHistorial_Click);
            // 
            // FormConsultaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClausulaOrderBY = "Dias_Atrazo Desc, Prestamo_Id Desc";
            this.ClientSize = new System.Drawing.Size(1025, 540);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.EnEjecusion = true;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.Name = "FormConsultaPrestamos";
            this.NombreCampoID = "Prestamo_Id";
            this.TablaOVista = "VPRESTAMOS";
            this.Text = "CONSULTA CUENTAS POR COBRAR CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private System.Windows.Forms.Button btnImprimirHistorial;
        private System.Windows.Forms.Button btnImprimirCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Prestamo_Id;
        private System.Windows.Forms.DataGridViewLinkColumn Factura_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Atrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}