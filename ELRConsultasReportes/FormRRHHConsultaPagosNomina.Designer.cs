namespace ELRConsultasReportes
{
    partial class FormRRHHConsultaPagosNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigoEmp = new WinControl_ELR_NET.ELRTextBox();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgNominaDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_APagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNominaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(0, 466);
            this.pnTotales.Size = new System.Drawing.Size(1037, 80);
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnBuscarEmp);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Controls.Add(this.txtCodigoEmp);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 75);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigoEmp, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarEmp, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(799, 3);
            this.txtABuscar.Size = new System.Drawing.Size(69, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(576, 37);
            this.btnBuscar.Size = new System.Drawing.Size(123, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.Text = "Codigo:";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 414);
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarEmp.Location = new System.Drawing.Point(229, 3);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEmp.TabIndex = 29;
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = null;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(277, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(422, 26);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // txtCodigoEmp
            // 
            this.txtCodigoEmp.AMostrar = null;
            this.txtCodigoEmp.AValidar = null;
            this.txtCodigoEmp.CampoBusquedaID = "";
            this.txtCodigoEmp.CampoData = "";
            this.txtCodigoEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEmp.ColumnasBusqGeneral = null;
            this.txtCodigoEmp.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoEmp.Decimales = 0;
            this.txtCodigoEmp.DSData = null;
            this.txtCodigoEmp.EsAutoGenerado = false;
            this.txtCodigoEmp.EsBusqueda = false;
            this.txtCodigoEmp.EsBusquedaAutoIncremental = false;
            this.txtCodigoEmp.EsEditable = true;
            this.txtCodigoEmp.FiltroBusqueda = "";
            this.txtCodigoEmp.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoEmp.Location = new System.Drawing.Point(98, 6);
            this.txtCodigoEmp.Name = "txtCodigoEmp";
            this.txtCodigoEmp.NombreTabla = "";
            this.txtCodigoEmp.SepDecimal = '\0';
            this.txtCodigoEmp.Size = new System.Drawing.Size(125, 26);
            this.txtCodigoEmp.TabIndex = 27;
            this.txtCodigoEmp.TablaOVistaBusqueda = "";
            this.txtCodigoEmp.Text = "0";
            this.txtCodigoEmp.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoEmp.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigoEmp, "Digite Codigo a Buscar y Presione Enter");
            this.txtCodigoEmp.ValorPorDefecto = "";
            this.txtCodigoEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoEmp_KeyDown);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(399, 37);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 26;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 37);
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
            this.dtpFecha1.Location = new System.Drawing.Point(144, 37);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 24;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha Desde:";
            // 
            // dtgNominaDetalle
            // 
            this.dtgNominaDetalle.AllowUserToAddRows = false;
            this.dtgNominaDetalle.AllowUserToDeleteRows = false;
            this.dtgNominaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNominaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.IdentificadorTemp,
            this.Empleado_Id,
            this.CedulaRNC,
            this.Nombre,
            this.Fecha,
            this.Monto_Bruto,
            this.Descuento,
            this.Monto_APagar});
            this.dtgNominaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNominaDetalle.Location = new System.Drawing.Point(14, 127);
            this.dtgNominaDetalle.Name = "dtgNominaDetalle";
            this.dtgNominaDetalle.ReadOnly = true;
            this.dtgNominaDetalle.RowHeadersWidth = 28;
            this.dtgNominaDetalle.RowTemplate.Height = 33;
            this.dtgNominaDetalle.Size = new System.Drawing.Size(1023, 339);
            this.dtgNominaDetalle.TabIndex = 48;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // IdentificadorTemp
            // 
            this.IdentificadorTemp.DataPropertyName = "IdentificadorTemp";
            this.IdentificadorTemp.HeaderText = "IdentificadorTemp";
            this.IdentificadorTemp.Name = "IdentificadorTemp";
            this.IdentificadorTemp.ReadOnly = true;
            this.IdentificadorTemp.Visible = false;
            // 
            // Empleado_Id
            // 
            this.Empleado_Id.DataPropertyName = "Empleado_Id";
            this.Empleado_Id.HeaderText = "Codigo";
            this.Empleado_Id.Name = "Empleado_Id";
            this.Empleado_Id.ReadOnly = true;
            this.Empleado_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Empleado_Id.Width = 80;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "Empleado ID";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle17;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto_Bruto
            // 
            this.Monto_Bruto.DataPropertyName = "Monto_Bruto";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = "0.00";
            this.Monto_Bruto.DefaultCellStyle = dataGridViewCellStyle18;
            this.Monto_Bruto.HeaderText = "Sueldo Bruto";
            this.Monto_Bruto.Name = "Monto_Bruto";
            this.Monto_Bruto.ReadOnly = true;
            this.Monto_Bruto.Width = 130;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Total_Descuento";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = "0.00";
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle19;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 120;
            // 
            // Monto_APagar
            // 
            this.Monto_APagar.DataPropertyName = "Monto_APagar";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = "0.00";
            this.Monto_APagar.DefaultCellStyle = dataGridViewCellStyle20;
            this.Monto_APagar.HeaderText = "Sueldo Neto";
            this.Monto_APagar.Name = "Monto_APagar";
            this.Monto_APagar.ReadOnly = true;
            this.Monto_APagar.Width = 120;
            // 
            // FormRRHHConsultaPagosNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dtgNominaDetalle);
            this.DataGridConsulta = this.dtgNominaDetalle;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormRRHHConsultaPagosNomina";
            this.Text = "CONSULTAR PAGO DE NOMINA POR EMPLEADOS";
            this.Load += new System.EventHandler(this.FormRRHHConsultaPagosNomina_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgNominaDetalle, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNominaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarEmp;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRTextBox txtCodigoEmp;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgNominaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_APagar;
    }
}