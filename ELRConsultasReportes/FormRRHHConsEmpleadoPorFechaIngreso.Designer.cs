namespace ELRConsultasReportes
{
    partial class FormRRHHConsEmpleadoPorFechaIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOficina2 = new WinControl_ELR_NET.ELRCombobox();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario_Mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSoloEmpleadosActivos = new WinControl_ELR_NET.ELRCheckBox();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.chkSoloEmpleadosActivos);
            this.pnBusqSencilla.Controls.Add(this.cboOficina2);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 104);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboOficina2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkSoloEmpleadosActivos, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(853, 33);
            this.txtABuscar.Size = new System.Drawing.Size(49, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(366, 70);
            this.btnBuscar.Size = new System.Drawing.Size(237, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 6);
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.Text = "Oficina:";
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
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(473, 40);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 26;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(141, 39);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 24;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha Desde:";
            // 
            // cboOficina2
            // 
            this.cboOficina2.AValidar = null;
            this.cboOficina2.CampoData = "";
            this.cboOficina2.CampoJoinCombobox2 = "";
            this.cboOficina2.ComboboxAFiltrar = null;
            this.cboOficina2.DisplayMember = "Nombre";
            this.cboOficina2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficina2.DSData = null;
            this.cboOficina2.EsEditable = true;
            this.cboOficina2.FiltroBusqueda = "";
            this.cboOficina2.FormattingEnabled = true;
            this.cboOficina2.Location = new System.Drawing.Point(141, 6);
            this.cboOficina2.Name = "cboOficina2";
            this.cboOficina2.NombreTabla = "";
            this.cboOficina2.Size = new System.Drawing.Size(462, 28);
            this.cboOficina2.SSQL = "";
            this.cboOficina2.TabIndex = 27;
            this.cboOficina2.TablaOVistaConsulta = "";
            this.cboOficina2.UsaDataGlobal = false;
            this.cboOficina2.ValorPorDefecto = "0";
            this.cboOficina2.ValueMember = "Oficina_Id";
            this.cboOficina2.SelectedValueChanged += new System.EventHandler(this.cboOficina2_SelectedValueChanged);
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Empleado_Id,
            this.CedulaRNC,
            this.Nombres,
            this.Fecha_Entrada,
            this.Salario_Mensual,
            this.EsActivo,
            this.Estatus});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 156);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 28;
            this.dtgData.Size = new System.Drawing.Size(1023, 338);
            this.dtgData.TabIndex = 49;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Empleado_Id
            // 
            this.Empleado_Id.DataPropertyName = "Empleado_Id";
            this.Empleado_Id.HeaderText = "Id";
            this.Empleado_Id.Name = "Empleado_Id";
            this.Empleado_Id.ReadOnly = true;
            this.Empleado_Id.Width = 85;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "Cedula";
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
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.DataPropertyName = "Fecha_Entrada";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "dd/MM/yyyy";
            this.Fecha_Entrada.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fecha_Entrada.HeaderText = "Fecha";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.ReadOnly = true;
            // 
            // Salario_Mensual
            // 
            this.Salario_Mensual.DataPropertyName = "Salario_Mensual";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.Salario_Mensual.DefaultCellStyle = dataGridViewCellStyle12;
            this.Salario_Mensual.HeaderText = "Salario";
            this.Salario_Mensual.Name = "Salario_Mensual";
            this.Salario_Mensual.ReadOnly = true;
            this.Salario_Mensual.Width = 120;
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
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 200;
            // 
            // chkSoloEmpleadosActivos
            // 
            this.chkSoloEmpleadosActivos.AutoSize = true;
            this.chkSoloEmpleadosActivos.CampoData = "";
            this.chkSoloEmpleadosActivos.Checked = true;
            this.chkSoloEmpleadosActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloEmpleadosActivos.DSData = null;
            this.chkSoloEmpleadosActivos.EsEditable = true;
            this.chkSoloEmpleadosActivos.EsModificable = true;
            this.chkSoloEmpleadosActivos.FiltroBusqueda = "";
            this.chkSoloEmpleadosActivos.Location = new System.Drawing.Point(141, 70);
            this.chkSoloEmpleadosActivos.Name = "chkSoloEmpleadosActivos";
            this.chkSoloEmpleadosActivos.NombreTabla = "";
            this.chkSoloEmpleadosActivos.Size = new System.Drawing.Size(199, 24);
            this.chkSoloEmpleadosActivos.TabIndex = 28;
            this.chkSoloEmpleadosActivos.Text = "Solo Empleados Activos";
            this.chkSoloEmpleadosActivos.UseVisualStyleBackColor = true;
            this.chkSoloEmpleadosActivos.ValorPorDefecto = true;
            this.chkSoloEmpleadosActivos.CheckedChanged += new System.EventHandler(this.chkSoloEmpleadosActivos_CheckedChanged);
            // 
            // FormRRHHConsEmpleadoPorFechaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormRRHHConsEmpleadoPorFechaIngreso";
            this.Text = "CONSULTA EMPLEADOS POR FECHA DE INGRESOS";
            this.Load += new System.EventHandler(this.FormRRHHConsEmpleadoPorFechaIngreso_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRCombobox cboOficina2;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario_Mensual;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private WinControl_ELR_NET.ELRCheckBox chkSoloEmpleadosActivos;
    }
}