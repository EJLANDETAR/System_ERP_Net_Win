namespace ELRConsultasReportes
{
    partial class FormCreditosPorDiasAtrazos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.txtCodigoEmp = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elrLabel4 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.txtDia2 = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.txtDia1 = new WinControl_ELR_NET.ELRTextBox();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Factura_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otros_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Atrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Size = new System.Drawing.Size(1136, 52);
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.groupBox1);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarEmp);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Controls.Add(this.txtCodigoEmp);
            this.pnBusqSencilla.Controls.Add(this.elrLabel3);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1122, 123);
            this.pnBusqSencilla.TabIndex = 1;
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrLabel3, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigoEmp, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarEmp, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(873, 37);
            this.txtABuscar.Size = new System.Drawing.Size(67, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(413, 54);
            this.btnBuscar.Size = new System.Drawing.Size(153, 56);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(869, 66);
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.Text = "De:";
            this.label1.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.AutoSize = false;
            this.lblCantidadRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidadRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(1132, 48);
            this.lblCantidadRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            this.pnOpcionesBusqueda.TabIndex = 0;
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "";
            this.elrLabel3.DSData = null;
            this.elrLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrLabel3.Location = new System.Drawing.Point(19, 12);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(159, 20);
            this.elrLabel3.TabIndex = 0;
            this.elrLabel3.Text = "Por Oficial Credito:";
            this.elrLabel3.ValorPorDefecto = "";
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
            this.txtCodigoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmp.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoEmp.Location = new System.Drawing.Point(184, 12);
            this.txtCodigoEmp.Name = "txtCodigoEmp";
            this.txtCodigoEmp.NombreTabla = "";
            this.txtCodigoEmp.SepDecimal = '\0';
            this.txtCodigoEmp.Size = new System.Drawing.Size(124, 26);
            this.txtCodigoEmp.TabIndex = 1;
            this.txtCodigoEmp.TablaOVistaBusqueda = "";
            this.txtCodigoEmp.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoEmp.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoEmp.ValorPorDefecto = "";
            this.txtCodigoEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoEmp_KeyDown);
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarEmp.Location = new System.Drawing.Point(314, 12);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEmp.TabIndex = 2;
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
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(368, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(390, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elrLabel4);
            this.groupBox1.Controls.Add(this.elrLabel2);
            this.groupBox1.Controls.Add(this.txtDia2);
            this.groupBox1.Controls.Add(this.elrLabel1);
            this.groupBox1.Controls.Add(this.txtDia1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Dias";
            // 
            // elrLabel4
            // 
            this.elrLabel4.AutoSize = true;
            this.elrLabel4.CampoData = "";
            this.elrLabel4.DSData = null;
            this.elrLabel4.Location = new System.Drawing.Point(31, 29);
            this.elrLabel4.Name = "elrLabel4";
            this.elrLabel4.NombreTabla = "";
            this.elrLabel4.Size = new System.Drawing.Size(37, 20);
            this.elrLabel4.TabIndex = 0;
            this.elrLabel4.Text = "De:";
            this.elrLabel4.ValorPorDefecto = "";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(301, 29);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(52, 20);
            this.elrLabel2.TabIndex = 4;
            this.elrLabel2.Text = "DIAS";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // txtDia2
            // 
            this.txtDia2.AMostrar = null;
            this.txtDia2.AValidar = null;
            this.txtDia2.CampoBusquedaID = "";
            this.txtDia2.CampoData = "";
            this.txtDia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDia2.ColumnasBusqGeneral = null;
            this.txtDia2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDia2.Decimales = 0;
            this.txtDia2.DSData = null;
            this.txtDia2.EsAutoGenerado = false;
            this.txtDia2.EsBusqueda = false;
            this.txtDia2.EsBusquedaAutoIncremental = false;
            this.txtDia2.EsEditable = true;
            this.txtDia2.FiltroBusqueda = "";
            this.txtDia2.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtDia2.Location = new System.Drawing.Point(213, 26);
            this.txtDia2.Name = "txtDia2";
            this.txtDia2.NombreTabla = "";
            this.txtDia2.SepDecimal = '\0';
            this.txtDia2.Size = new System.Drawing.Size(82, 26);
            this.txtDia2.TabIndex = 3;
            this.txtDia2.TablaOVistaBusqueda = "";
            this.txtDia2.Text = "9999";
            this.txtDia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDia2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDia2.ValorPorDefecto = "";
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(175, 29);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(31, 20);
            this.elrLabel1.TabIndex = 2;
            this.elrLabel1.Text = "A: ";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // txtDia1
            // 
            this.txtDia1.AMostrar = null;
            this.txtDia1.AValidar = null;
            this.txtDia1.CampoBusquedaID = "";
            this.txtDia1.CampoData = "";
            this.txtDia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDia1.ColumnasBusqGeneral = null;
            this.txtDia1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDia1.Decimales = 0;
            this.txtDia1.DSData = null;
            this.txtDia1.EsAutoGenerado = false;
            this.txtDia1.EsBusqueda = false;
            this.txtDia1.EsBusquedaAutoIncremental = false;
            this.txtDia1.EsEditable = true;
            this.txtDia1.FiltroBusqueda = "";
            this.txtDia1.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtDia1.Location = new System.Drawing.Point(72, 29);
            this.txtDia1.Name = "txtDia1";
            this.txtDia1.NombreTabla = "";
            this.txtDia1.SepDecimal = '\0';
            this.txtDia1.Size = new System.Drawing.Size(82, 26);
            this.txtDia1.TabIndex = 1;
            this.txtDia1.TablaOVistaBusqueda = "";
            this.txtDia1.Text = "0";
            this.txtDia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDia1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDia1.ValorPorDefecto = "";
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
            this.Capital_Pendiente,
            this.Interes_Pendiente,
            this.Demora_Pendiente,
            this.Otros_Pendiente,
            this.Balance_Pendiente,
            this.Dias_Atrazo});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 175);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 25;
            this.dtgData.RowTemplate.Height = 30;
            this.dtgData.Size = new System.Drawing.Size(1122, 319);
            this.dtgData.TabIndex = 49;
            this.dtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellContentClick);
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
            // Capital_Pendiente
            // 
            this.Capital_Pendiente.DataPropertyName = "Capital_Pendiente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Capital_Pendiente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Capital_Pendiente.HeaderText = "Capital P.";
            this.Capital_Pendiente.Name = "Capital_Pendiente";
            this.Capital_Pendiente.ReadOnly = true;
            this.Capital_Pendiente.Width = 120;
            // 
            // Interes_Pendiente
            // 
            this.Interes_Pendiente.DataPropertyName = "Interes_Pendiente";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Interes_Pendiente.DefaultCellStyle = dataGridViewCellStyle5;
            this.Interes_Pendiente.HeaderText = "Interes P.";
            this.Interes_Pendiente.Name = "Interes_Pendiente";
            this.Interes_Pendiente.ReadOnly = true;
            this.Interes_Pendiente.Width = 120;
            // 
            // Demora_Pendiente
            // 
            this.Demora_Pendiente.DataPropertyName = "Demora_Pendiente";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Demora_Pendiente.DefaultCellStyle = dataGridViewCellStyle6;
            this.Demora_Pendiente.HeaderText = "Demora P.";
            this.Demora_Pendiente.Name = "Demora_Pendiente";
            this.Demora_Pendiente.ReadOnly = true;
            // 
            // Otros_Pendiente
            // 
            this.Otros_Pendiente.DataPropertyName = "Otros_Pendiente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Otros_Pendiente.DefaultCellStyle = dataGridViewCellStyle7;
            this.Otros_Pendiente.HeaderText = "Otros P.";
            this.Otros_Pendiente.Name = "Otros_Pendiente";
            this.Otros_Pendiente.ReadOnly = true;
            // 
            // Balance_Pendiente
            // 
            this.Balance_Pendiente.DataPropertyName = "Balance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.Balance_Pendiente.DefaultCellStyle = dataGridViewCellStyle8;
            this.Balance_Pendiente.HeaderText = "S. Pendiente";
            this.Balance_Pendiente.Name = "Balance_Pendiente";
            this.Balance_Pendiente.ReadOnly = true;
            this.Balance_Pendiente.Width = 120;
            // 
            // Dias_Atrazo
            // 
            this.Dias_Atrazo.DataPropertyName = "Dias_Atrazo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dias_Atrazo.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dias_Atrazo.HeaderText = "D. Atraso";
            this.Dias_Atrazo.Name = "Dias_Atrazo";
            this.Dias_Atrazo.ReadOnly = true;
            this.Dias_Atrazo.ToolTipText = "Cantidad de Dia Atrazado";
            this.Dias_Atrazo.Width = 90;
            // 
            // FormCreditosPorDiasAtrazos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 568);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormCreditosPorDiasAtrazos";
            this.Text = "CONSULTA DE PRESTAMOS POR DIAS DE ATRAZOS";
            this.Load += new System.EventHandler(this.FormCreditosPorDiasAtrazos_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WinControl_ELR_NET.ELRTextBox txtCodigoEmp;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
        private System.Windows.Forms.Button btnBuscarEmp;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRLabel elrLabel4;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRTextBox txtDia2;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRTextBox txtDia1;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Prestamo_Id;
        private System.Windows.Forms.DataGridViewLinkColumn Factura_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demora_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otros_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Atrazo;
    }
}