namespace ELRConsultasReportes
{
    partial class FormRRHHConsHistorico
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
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigoEmp = new WinControl_ELR_NET.ELRTextBox();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtConcepto);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 466);
            this.pnTotales.Size = new System.Drawing.Size(1037, 80);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtConcepto, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.cboTipo);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarEmp);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Controls.Add(this.txtCodigoEmp);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 114);
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
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboTipo, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(849, 23);
            this.txtABuscar.Size = new System.Drawing.Size(60, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 37);
            this.btnBuscar.Size = new System.Drawing.Size(152, 62);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.Text = "Codigo:";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Size = new System.Drawing.Size(57, 20);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 414);
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarEmp.Location = new System.Drawing.Point(214, 3);
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
            this.txtNombre.Location = new System.Drawing.Point(262, 5);
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
            this.txtCodigoEmp.Location = new System.Drawing.Point(83, 6);
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
            this.dtpFecha2.Location = new System.Drawing.Point(384, 37);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 26;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 37);
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
            this.dtpFecha1.Location = new System.Drawing.Point(129, 37);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 24;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha Desde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DSData = null;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "(TODOS)",
            "CAMBIO SALARIO",
            "VACACIONES",
            "BAJA",
            "LICENCIA",
            "LICENCIA PATERNIDAD",
            "LICENCIA MATERNIDAD",
            "PERMISOS",
            "SANCIONES",
            "OTROS"});
            this.cboTipo.Location = new System.Drawing.Point(129, 70);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(385, 28);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 31;
            this.cboTipo.TablaOVistaConsulta = "";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "0";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Tipo,
            this.Nombre,
            this.Fecha_Desde,
            this.Fecha_Hasta,
            this.Aumento,
            this.Concepto});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 300);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.DSData = null;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(0, 0);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(1033, 76);
            this.txtConcepto.TabIndex = 1;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 250;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha_Desde
            // 
            this.Fecha_Desde.DataPropertyName = "Fecha_Desde";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha_Desde.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha_Desde.HeaderText = "Fecha Desde";
            this.Fecha_Desde.Name = "Fecha_Desde";
            this.Fecha_Desde.ReadOnly = true;
            this.Fecha_Desde.Width = 130;
            // 
            // Fecha_Hasta
            // 
            this.Fecha_Hasta.DataPropertyName = "Fecha_Hasta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Fecha_Hasta.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_Hasta.HeaderText = "Fecha Hasta";
            this.Fecha_Hasta.Name = "Fecha_Hasta";
            this.Fecha_Hasta.ReadOnly = true;
            this.Fecha_Hasta.Width = 130;
            // 
            // Aumento
            // 
            this.Aumento.DataPropertyName = "Aumento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Aumento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Aumento.HeaderText = "Aumento";
            this.Aumento.Name = "Aumento";
            this.Aumento.ReadOnly = true;
            this.Aumento.Width = 130;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Visible = false;
            // 
            // FormRRHHConsHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormRRHHConsHistorico";
            this.Text = "CONSULTA HISTORICO DE EMPLEADOS";
            this.Load += new System.EventHandler(this.FormRRHHConsHistorico_Load);
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

        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarEmp;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRTextBox txtCodigoEmp;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
    }
}