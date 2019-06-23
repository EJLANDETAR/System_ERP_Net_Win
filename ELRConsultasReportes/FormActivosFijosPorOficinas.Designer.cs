namespace ELRConsultasReportes
{
    partial class FormActivosFijosPorOficinas
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
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTipo = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.txtNombreTipo = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.chkPorFecha = new WinControl_ELR_NET.ELRCheckBox();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depre_Acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Libro_Depreciar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ultima_Depre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.chkPorFecha);
            this.pnBusqSencilla.Controls.Add(this.elrLabel1);
            this.pnBusqSencilla.Controls.Add(this.txtTipo);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarTipo);
            this.pnBusqSencilla.Controls.Add(this.txtNombreTipo);
            this.pnBusqSencilla.Controls.Add(this.txtCodigo);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarOficina);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 132);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarOficina, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombreTipo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarTipo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtTipo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrLabel1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkPorFecha, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(794, 9);
            this.txtABuscar.Size = new System.Drawing.Size(60, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 6);
            this.btnBuscar.Size = new System.Drawing.Size(166, 61);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
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
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = null;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(83, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 33;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.Text = "0";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigo, "Digite Codigo a Buscar y Presione Enter");
            this.txtCodigo.ValorPorDefecto = "";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarOficina.Location = new System.Drawing.Point(189, 4);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarOficina.TabIndex = 32;
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
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
            this.txtNombre.Location = new System.Drawing.Point(237, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(298, 26);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Activo_Id,
            this.Nombre,
            this.Fecha_Adquisicion,
            this.Valor_Adquisicion,
            this.Depre_Acumulada,
            this.Valor_Libro_Depreciar,
            this.Fecha_Ultima_Depre,
            this.Descripcion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 310);
            this.dataGridView1.TabIndex = 48;
            // 
            // txtTipo
            // 
            this.txtTipo.AMostrar = null;
            this.txtTipo.AValidar = null;
            this.txtTipo.CampoBusquedaID = "";
            this.txtTipo.CampoData = "";
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.ColumnasBusqGeneral = null;
            this.txtTipo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTipo.Decimales = 0;
            this.txtTipo.DSData = null;
            this.txtTipo.EsAutoGenerado = false;
            this.txtTipo.EsBusqueda = false;
            this.txtTipo.EsBusquedaAutoIncremental = false;
            this.txtTipo.EsEditable = true;
            this.txtTipo.FiltroBusqueda = "";
            this.txtTipo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTipo.Location = new System.Drawing.Point(83, 38);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.NombreTabla = "";
            this.txtTipo.SepDecimal = '\0';
            this.txtTipo.Size = new System.Drawing.Size(100, 26);
            this.txtTipo.TabIndex = 36;
            this.txtTipo.TablaOVistaBusqueda = "";
            this.txtTipo.Text = "0";
            this.txtTipo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTipo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtTipo, "Digite Codigo a Buscar y Presione Enter");
            this.txtTipo.ValorPorDefecto = "";
            this.txtTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipo_KeyDown);
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarTipo.Location = new System.Drawing.Point(189, 36);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarTipo.TabIndex = 35;
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // txtNombreTipo
            // 
            this.txtNombreTipo.AMostrar = null;
            this.txtNombreTipo.AValidar = null;
            this.txtNombreTipo.BackColor = System.Drawing.Color.White;
            this.txtNombreTipo.CampoBusquedaID = "";
            this.txtNombreTipo.CampoData = "";
            this.txtNombreTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreTipo.ColumnasBusqGeneral = null;
            this.txtNombreTipo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreTipo.Decimales = 0;
            this.txtNombreTipo.DSData = null;
            this.txtNombreTipo.EsAutoGenerado = false;
            this.txtNombreTipo.EsBusqueda = false;
            this.txtNombreTipo.EsBusquedaAutoIncremental = false;
            this.txtNombreTipo.EsEditable = true;
            this.txtNombreTipo.FiltroBusqueda = "";
            this.txtNombreTipo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreTipo.Location = new System.Drawing.Point(237, 40);
            this.txtNombreTipo.Name = "txtNombreTipo";
            this.txtNombreTipo.NombreTabla = "";
            this.txtNombreTipo.ReadOnly = true;
            this.txtNombreTipo.SepDecimal = '\0';
            this.txtNombreTipo.Size = new System.Drawing.Size(298, 26);
            this.txtNombreTipo.TabIndex = 34;
            this.txtNombreTipo.TablaOVistaBusqueda = "";
            this.txtNombreTipo.Text = "(TODOS)";
            this.txtNombreTipo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreTipo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreTipo.ValorPorDefecto = "";
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(14, 40);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(43, 20);
            this.elrLabel1.TabIndex = 37;
            this.elrLabel1.Text = "Tipo:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // chkPorFecha
            // 
            this.chkPorFecha.AutoSize = true;
            this.chkPorFecha.CampoData = "";
            this.chkPorFecha.DSData = null;
            this.chkPorFecha.EsEditable = true;
            this.chkPorFecha.EsModificable = true;
            this.chkPorFecha.FiltroBusqueda = "";
            this.chkPorFecha.Location = new System.Drawing.Point(18, 76);
            this.chkPorFecha.Name = "chkPorFecha";
            this.chkPorFecha.NombreTabla = "";
            this.chkPorFecha.Size = new System.Drawing.Size(241, 24);
            this.chkPorFecha.TabIndex = 38;
            this.chkPorFecha.Text = "Por Fecha Adquisicion Desde:";
            this.chkPorFecha.UseVisualStyleBackColor = true;
            this.chkPorFecha.ValorPorDefecto = true;
            this.chkPorFecha.CheckedChanged += new System.EventHandler(this.chkPorFecha_CheckedChanged);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.Enabled = false;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(519, 79);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 42;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.Enabled = false;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(265, 79);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 40;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Activo_Id
            // 
            this.Activo_Id.DataPropertyName = "Activo_Id";
            this.Activo_Id.HeaderText = "Codigo";
            this.Activo_Id.Name = "Activo_Id";
            this.Activo_Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha_Adquisicion
            // 
            this.Fecha_Adquisicion.DataPropertyName = "Fecha_Adquisicion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha_Adquisicion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha_Adquisicion.HeaderText = "Fe. Adquis.";
            this.Fecha_Adquisicion.Name = "Fecha_Adquisicion";
            this.Fecha_Adquisicion.ReadOnly = true;
            this.Fecha_Adquisicion.ToolTipText = "Fecha de Adquisicion o Compra";
            // 
            // Valor_Adquisicion
            // 
            this.Valor_Adquisicion.DataPropertyName = "Valor_Adquisicion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Valor_Adquisicion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor_Adquisicion.HeaderText = "V. Adquis.";
            this.Valor_Adquisicion.Name = "Valor_Adquisicion";
            this.Valor_Adquisicion.ReadOnly = true;
            this.Valor_Adquisicion.ToolTipText = "Valor de adquisicion o Compra";
            this.Valor_Adquisicion.Width = 120;
            // 
            // Depre_Acumulada
            // 
            this.Depre_Acumulada.DataPropertyName = "Depre_Acumulada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Depre_Acumulada.DefaultCellStyle = dataGridViewCellStyle3;
            this.Depre_Acumulada.HeaderText = "D. Acum.";
            this.Depre_Acumulada.Name = "Depre_Acumulada";
            this.Depre_Acumulada.ReadOnly = true;
            this.Depre_Acumulada.ToolTipText = "Depreciacion Acumulada";
            this.Depre_Acumulada.Width = 120;
            // 
            // Valor_Libro_Depreciar
            // 
            this.Valor_Libro_Depreciar.DataPropertyName = "Valor_Libro_Depreciar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Valor_Libro_Depreciar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valor_Libro_Depreciar.HeaderText = "V.  Libro";
            this.Valor_Libro_Depreciar.Name = "Valor_Libro_Depreciar";
            this.Valor_Libro_Depreciar.ReadOnly = true;
            this.Valor_Libro_Depreciar.ToolTipText = "Valor en Libro";
            this.Valor_Libro_Depreciar.Width = 120;
            // 
            // Fecha_Ultima_Depre
            // 
            this.Fecha_Ultima_Depre.DataPropertyName = "Fecha_Ultima_Depre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Fecha_Ultima_Depre.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha_Ultima_Depre.HeaderText = "UFe. Depre";
            this.Fecha_Ultima_Depre.Name = "Fecha_Ultima_Depre";
            this.Fecha_Ultima_Depre.ReadOnly = true;
            this.Fecha_Ultima_Depre.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // FormActivosFijosPorOficinas
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
            this.Name = "FormActivosFijosPorOficinas";
            this.Text = "ACTIVOS FIJOS POR OFICINAS";
            this.Load += new System.EventHandler(this.FormActivosFijosPorOficinas_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscarOficina;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRTextBox txtTipo;
        private System.Windows.Forms.Button btnBuscarTipo;
        private WinControl_ELR_NET.ELRTextBox txtNombreTipo;
        private WinControl_ELR_NET.ELRCheckBox chkPorFecha;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depre_Acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Libro_Depreciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ultima_Depre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}