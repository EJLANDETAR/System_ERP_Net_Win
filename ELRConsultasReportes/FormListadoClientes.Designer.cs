namespace ELRConsultasReportes
{
    partial class FormListadoClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkPorFecha = new WinControl_ELR_NET.ELRCheckBox();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.chkSoloCXC = new WinControl_ELR_NET.ELRCheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_CXC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.chkSoloCXC);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.chkPorFecha);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 75);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkPorFecha, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkSoloCXC, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(911, 14);
            this.txtABuscar.Size = new System.Drawing.Size(47, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(411, 40);
            this.btnBuscar.Size = new System.Drawing.Size(168, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(818, 12);
            this.label1.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.AutoSize = false;
            this.lblCantidadRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidadRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(1033, 48);
            this.lblCantidadRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // chkPorFecha
            // 
            this.chkPorFecha.AutoSize = true;
            this.chkPorFecha.CampoData = "";
            this.chkPorFecha.DSData = null;
            this.chkPorFecha.EsEditable = true;
            this.chkPorFecha.EsModificable = true;
            this.chkPorFecha.FiltroBusqueda = "";
            this.chkPorFecha.Location = new System.Drawing.Point(14, 6);
            this.chkPorFecha.Name = "chkPorFecha";
            this.chkPorFecha.NombreTabla = "";
            this.chkPorFecha.Size = new System.Drawing.Size(246, 24);
            this.chkPorFecha.TabIndex = 3;
            this.chkPorFecha.Text = "Por Fecha de Registro, Desde:";
            this.chkPorFecha.UseVisualStyleBackColor = true;
            this.chkPorFecha.ValorPorDefecto = true;
            this.chkPorFecha.CheckedChanged += new System.EventHandler(this.chkPorFecha_CheckedChanged);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(449, 6);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 25;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(254, 7);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 23;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // chkSoloCXC
            // 
            this.chkSoloCXC.AutoSize = true;
            this.chkSoloCXC.CampoData = "";
            this.chkSoloCXC.Checked = true;
            this.chkSoloCXC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloCXC.DSData = null;
            this.chkSoloCXC.EsEditable = true;
            this.chkSoloCXC.EsModificable = true;
            this.chkSoloCXC.FiltroBusqueda = "";
            this.chkSoloCXC.Location = new System.Drawing.Point(14, 39);
            this.chkSoloCXC.Name = "chkSoloCXC";
            this.chkSoloCXC.NombreTabla = "";
            this.chkSoloCXC.Size = new System.Drawing.Size(346, 24);
            this.chkSoloCXC.TabIndex = 26;
            this.chkSoloCXC.Text = "Mostrar Solo Cuentas Pendientes Por Cobrar";
            this.chkSoloCXC.UseVisualStyleBackColor = true;
            this.chkSoloCXC.ValorPorDefecto = true;
            this.chkSoloCXC.CheckedChanged += new System.EventHandler(this.chkSoloCXC_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Entidad_Id,
            this.CedulaRNC,
            this.Nombres,
            this.Telefono1,
            this.Telefono2,
            this.EMail,
            this.Direccion,
            this.Balance_CXC,
            this.btnVerDetalle});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(14, 127);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 28;
            this.dgvData.RowTemplate.Height = 33;
            this.dgvData.Size = new System.Drawing.Size(1023, 367);
            this.dgvData.TabIndex = 48;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Entidad_Id
            // 
            this.Entidad_Id.DataPropertyName = "Entidad_Id";
            this.Entidad_Id.HeaderText = "Id";
            this.Entidad_Id.Name = "Entidad_Id";
            this.Entidad_Id.ReadOnly = true;
            this.Entidad_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Entidad_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Entidad_Id.Width = 85;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "Cedula/RNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 120;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombres.DataPropertyName = "Nombre_Completo";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Telefono1
            // 
            this.Telefono1.DataPropertyName = "Telefono1";
            this.Telefono1.HeaderText = "Telefono";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Visible = false;
            this.Telefono1.Width = 120;
            // 
            // Telefono2
            // 
            this.Telefono2.DataPropertyName = "Telefono2";
            this.Telefono2.HeaderText = "Telefono";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            this.Telefono2.Visible = false;
            this.Telefono2.Width = 120;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "EMail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Visible = false;
            this.EMail.Width = 180;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Visible = false;
            // 
            // Balance_CXC
            // 
            this.Balance_CXC.DataPropertyName = "Balance_CXC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Balance_CXC.DefaultCellStyle = dataGridViewCellStyle2;
            this.Balance_CXC.HeaderText = "Balance";
            this.Balance_CXC.Name = "Balance_CXC";
            this.Balance_CXC.ReadOnly = true;
            this.Balance_CXC.Width = 130;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.HeaderText = "Ver Detalle";
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.ReadOnly = true;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.ToolTipText = "Muestra Las Facturas Pendiente Por Cobrar";
            this.btnVerDetalle.UseColumnTextForButtonValue = true;
            // 
            // FormListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dgvData);
            this.DataGridConsulta = this.dgvData;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormListadoClientes";
            this.Text = "LISTADO DE CLIENTES";
            this.Load += new System.EventHandler(this.FormListadoClientes_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRCheckBox chkPorFecha;
        private WinControl_ELR_NET.ELRCheckBox chkSoloCXC;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Entidad_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_CXC;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerDetalle;
    }
}