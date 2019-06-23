namespace ELRConsultasReportes
{
    partial class FormCXC_Por_Antiguedad_Saldo
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
            this.btnBuscarEntidad = new System.Windows.Forms.Button();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.chkPorFecha = new WinControl_ELR_NET.ELRCheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt0_30 = new WinControl_ELR_NET.ELRTextBox();
            this.txt31_60 = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt61_90 = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt91_120 = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt121 = new WinControl_ELR_NET.ELRTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_P0_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_P31_60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_P61_90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_P91_120 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_P121 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ultimo_Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Atrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txt121);
            this.pnTotales.Controls.Add(this.label11);
            this.pnTotales.Controls.Add(this.txt91_120);
            this.pnTotales.Controls.Add(this.label10);
            this.pnTotales.Controls.Add(this.txt61_90);
            this.pnTotales.Controls.Add(this.label9);
            this.pnTotales.Controls.Add(this.txt31_60);
            this.pnTotales.Controls.Add(this.label8);
            this.pnTotales.Controls.Add(this.txt0_30);
            this.pnTotales.Controls.Add(this.label6);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 466);
            this.pnTotales.Size = new System.Drawing.Size(1037, 80);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.label6, 0);
            this.pnTotales.Controls.SetChildIndex(this.txt0_30, 0);
            this.pnTotales.Controls.SetChildIndex(this.label8, 0);
            this.pnTotales.Controls.SetChildIndex(this.txt31_60, 0);
            this.pnTotales.Controls.SetChildIndex(this.label9, 0);
            this.pnTotales.Controls.SetChildIndex(this.txt61_90, 0);
            this.pnTotales.Controls.SetChildIndex(this.label10, 0);
            this.pnTotales.Controls.SetChildIndex(this.txt91_120, 0);
            this.pnTotales.Controls.SetChildIndex(this.label11, 0);
            this.pnTotales.Controls.SetChildIndex(this.txt121, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.chkPorFecha);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarEntidad);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Controls.Add(this.txtCodigo);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 84);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarEntidad, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkPorFecha, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(927, 105);
            this.txtABuscar.Size = new System.Drawing.Size(59, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(594, 41);
            this.btnBuscar.Size = new System.Drawing.Size(105, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.Text = "Código:";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Location = new System.Drawing.Point(937, 12);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(66, 24);
            this.lblCantidadRegistro.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 414);
            // 
            // btnBuscarEntidad
            // 
            this.btnBuscarEntidad.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarEntidad.Location = new System.Drawing.Point(229, 6);
            this.btnBuscarEntidad.Name = "btnBuscarEntidad";
            this.btnBuscarEntidad.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEntidad.TabIndex = 30;
            this.btnBuscarEntidad.UseVisualStyleBackColor = true;
            this.btnBuscarEntidad.Click += new System.EventHandler(this.btnBuscarEntidad_Click);
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
            this.dtpFecha2.Location = new System.Drawing.Point(458, 43);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 29;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hasta:";
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
            this.dtpFecha1.Location = new System.Drawing.Point(251, 43);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 27;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
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
            this.txtNombre.Location = new System.Drawing.Point(277, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(422, 26);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
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
            this.txtCodigo.Location = new System.Drawing.Point(98, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(125, 26);
            this.txtCodigo.TabIndex = 24;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.Text = "0";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigo, "Digite Codigo a Buscar y Presione Enter");
            this.txtCodigo.ValorPorDefecto = "";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // chkPorFecha
            // 
            this.chkPorFecha.AutoSize = true;
            this.chkPorFecha.CampoData = "";
            this.chkPorFecha.DSData = null;
            this.chkPorFecha.EsEditable = true;
            this.chkPorFecha.EsModificable = true;
            this.chkPorFecha.FiltroBusqueda = "";
            this.chkPorFecha.Location = new System.Drawing.Point(18, 43);
            this.chkPorFecha.Name = "chkPorFecha";
            this.chkPorFecha.NombreTabla = "";
            this.chkPorFecha.Size = new System.Drawing.Size(227, 24);
            this.chkPorFecha.TabIndex = 31;
            this.chkPorFecha.Text = "Por Fecha Facturas, Desde:";
            this.chkPorFecha.UseVisualStyleBackColor = true;
            this.chkPorFecha.ValorPorDefecto = true;
            this.chkPorFecha.CheckedChanged += new System.EventHandler(this.chkPorFecha_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Numero,
            this.Fecha,
            this.CedulaRNC,
            this.Nombre,
            this.Monto,
            this.Monto_P0_30,
            this.Monto_P31_60,
            this.Monto_P61_90,
            this.Monto_P91_120,
            this.Monto_P121,
            this.Fecha_Ultimo_Abono,
            this.Dias_Atrazo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 330);
            this.dataGridView1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "P0-30";
            // 
            // txt0_30
            // 
            this.txt0_30.AMostrar = null;
            this.txt0_30.AValidar = null;
            this.txt0_30.BackColor = System.Drawing.Color.White;
            this.txt0_30.CampoBusquedaID = "";
            this.txt0_30.CampoData = "";
            this.txt0_30.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt0_30.ColumnasBusqGeneral = null;
            this.txt0_30.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txt0_30.Decimales = 0;
            this.txt0_30.DSData = null;
            this.txt0_30.EsAutoGenerado = false;
            this.txt0_30.EsBusqueda = false;
            this.txt0_30.EsBusquedaAutoIncremental = false;
            this.txt0_30.EsEditable = true;
            this.txt0_30.FiltroBusqueda = "";
            this.txt0_30.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txt0_30.Location = new System.Drawing.Point(14, 39);
            this.txt0_30.Name = "txt0_30";
            this.txt0_30.NombreTabla = "";
            this.txt0_30.ReadOnly = true;
            this.txt0_30.SepDecimal = '\0';
            this.txt0_30.Size = new System.Drawing.Size(138, 29);
            this.txt0_30.TabIndex = 2;
            this.txt0_30.TablaOVistaBusqueda = "";
            this.txt0_30.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txt0_30.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txt0_30.ValorPorDefecto = "";
            // 
            // txt31_60
            // 
            this.txt31_60.AMostrar = null;
            this.txt31_60.AValidar = null;
            this.txt31_60.BackColor = System.Drawing.Color.White;
            this.txt31_60.CampoBusquedaID = "";
            this.txt31_60.CampoData = "";
            this.txt31_60.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt31_60.ColumnasBusqGeneral = null;
            this.txt31_60.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txt31_60.Decimales = 0;
            this.txt31_60.DSData = null;
            this.txt31_60.EsAutoGenerado = false;
            this.txt31_60.EsBusqueda = false;
            this.txt31_60.EsBusquedaAutoIncremental = false;
            this.txt31_60.EsEditable = true;
            this.txt31_60.FiltroBusqueda = "";
            this.txt31_60.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txt31_60.Location = new System.Drawing.Point(178, 39);
            this.txt31_60.Name = "txt31_60";
            this.txt31_60.NombreTabla = "";
            this.txt31_60.ReadOnly = true;
            this.txt31_60.SepDecimal = '\0';
            this.txt31_60.Size = new System.Drawing.Size(138, 29);
            this.txt31_60.TabIndex = 4;
            this.txt31_60.TablaOVistaBusqueda = "";
            this.txt31_60.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txt31_60.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txt31_60.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "P31-60";
            // 
            // txt61_90
            // 
            this.txt61_90.AMostrar = null;
            this.txt61_90.AValidar = null;
            this.txt61_90.BackColor = System.Drawing.Color.White;
            this.txt61_90.CampoBusquedaID = "";
            this.txt61_90.CampoData = "";
            this.txt61_90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt61_90.ColumnasBusqGeneral = null;
            this.txt61_90.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txt61_90.Decimales = 0;
            this.txt61_90.DSData = null;
            this.txt61_90.EsAutoGenerado = false;
            this.txt61_90.EsBusqueda = false;
            this.txt61_90.EsBusquedaAutoIncremental = false;
            this.txt61_90.EsEditable = true;
            this.txt61_90.FiltroBusqueda = "";
            this.txt61_90.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txt61_90.Location = new System.Drawing.Point(347, 39);
            this.txt61_90.Name = "txt61_90";
            this.txt61_90.NombreTabla = "";
            this.txt61_90.ReadOnly = true;
            this.txt61_90.SepDecimal = '\0';
            this.txt61_90.Size = new System.Drawing.Size(138, 29);
            this.txt61_90.TabIndex = 6;
            this.txt61_90.TablaOVistaBusqueda = "";
            this.txt61_90.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txt61_90.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txt61_90.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "P61-90";
            // 
            // txt91_120
            // 
            this.txt91_120.AMostrar = null;
            this.txt91_120.AValidar = null;
            this.txt91_120.BackColor = System.Drawing.Color.White;
            this.txt91_120.CampoBusquedaID = "";
            this.txt91_120.CampoData = "";
            this.txt91_120.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt91_120.ColumnasBusqGeneral = null;
            this.txt91_120.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txt91_120.Decimales = 0;
            this.txt91_120.DSData = null;
            this.txt91_120.EsAutoGenerado = false;
            this.txt91_120.EsBusqueda = false;
            this.txt91_120.EsBusquedaAutoIncremental = false;
            this.txt91_120.EsEditable = true;
            this.txt91_120.FiltroBusqueda = "";
            this.txt91_120.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txt91_120.Location = new System.Drawing.Point(513, 39);
            this.txt91_120.Name = "txt91_120";
            this.txt91_120.NombreTabla = "";
            this.txt91_120.ReadOnly = true;
            this.txt91_120.SepDecimal = '\0';
            this.txt91_120.Size = new System.Drawing.Size(138, 29);
            this.txt91_120.TabIndex = 8;
            this.txt91_120.TablaOVistaBusqueda = "";
            this.txt91_120.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txt91_120.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txt91_120.ValorPorDefecto = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "P91-120";
            // 
            // txt121
            // 
            this.txt121.AMostrar = null;
            this.txt121.AValidar = null;
            this.txt121.BackColor = System.Drawing.Color.White;
            this.txt121.CampoBusquedaID = "";
            this.txt121.CampoData = "";
            this.txt121.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt121.ColumnasBusqGeneral = null;
            this.txt121.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txt121.Decimales = 0;
            this.txt121.DSData = null;
            this.txt121.EsAutoGenerado = false;
            this.txt121.EsBusqueda = false;
            this.txt121.EsBusquedaAutoIncremental = false;
            this.txt121.EsEditable = true;
            this.txt121.FiltroBusqueda = "";
            this.txt121.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txt121.Location = new System.Drawing.Point(679, 39);
            this.txt121.Name = "txt121";
            this.txt121.NombreTabla = "";
            this.txt121.ReadOnly = true;
            this.txt121.SepDecimal = '\0';
            this.txt121.Size = new System.Drawing.Size(138, 29);
            this.txt121.TabIndex = 10;
            this.txt121.TablaOVistaBusqueda = "";
            this.txt121.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txt121.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txt121.ValorPorDefecto = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "P121";
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Factura_No";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Numero.ToolTipText = "Clic Sobre el Numero de Factura Para Ver Detalle de Pago";
            this.Numero.Width = 85;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Visible = false;
            this.CedulaRNC.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "ANombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 120;
            // 
            // Monto_P0_30
            // 
            this.Monto_P0_30.DataPropertyName = "Monto_P0_30";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Monto_P0_30.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto_P0_30.HeaderText = "P0-30";
            this.Monto_P0_30.Name = "Monto_P0_30";
            this.Monto_P0_30.ReadOnly = true;
            this.Monto_P0_30.Width = 120;
            // 
            // Monto_P31_60
            // 
            this.Monto_P31_60.DataPropertyName = "Monto_P31_60";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto_P31_60.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto_P31_60.HeaderText = "P31-60";
            this.Monto_P31_60.Name = "Monto_P31_60";
            this.Monto_P31_60.ReadOnly = true;
            this.Monto_P31_60.Width = 120;
            // 
            // Monto_P61_90
            // 
            this.Monto_P61_90.DataPropertyName = "Monto_P61_90";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Monto_P61_90.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto_P61_90.HeaderText = "P61-90";
            this.Monto_P61_90.Name = "Monto_P61_90";
            this.Monto_P61_90.ReadOnly = true;
            this.Monto_P61_90.Width = 120;
            // 
            // Monto_P91_120
            // 
            this.Monto_P91_120.DataPropertyName = "Monto_P91_120";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Monto_P91_120.DefaultCellStyle = dataGridViewCellStyle6;
            this.Monto_P91_120.HeaderText = "P91-120";
            this.Monto_P91_120.Name = "Monto_P91_120";
            this.Monto_P91_120.ReadOnly = true;
            this.Monto_P91_120.Width = 120;
            // 
            // Monto_P121
            // 
            this.Monto_P121.DataPropertyName = "Monto_P121";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Monto_P121.DefaultCellStyle = dataGridViewCellStyle7;
            this.Monto_P121.HeaderText = "P+121";
            this.Monto_P121.Name = "Monto_P121";
            this.Monto_P121.ReadOnly = true;
            this.Monto_P121.Width = 120;
            // 
            // Fecha_Ultimo_Abono
            // 
            this.Fecha_Ultimo_Abono.DataPropertyName = "Fecha_Ultimo_Abono";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            this.Fecha_Ultimo_Abono.DefaultCellStyle = dataGridViewCellStyle8;
            this.Fecha_Ultimo_Abono.HeaderText = "UFe. Abono";
            this.Fecha_Ultimo_Abono.Name = "Fecha_Ultimo_Abono";
            this.Fecha_Ultimo_Abono.ReadOnly = true;
            this.Fecha_Ultimo_Abono.Width = 120;
            // 
            // Dias_Atrazo
            // 
            this.Dias_Atrazo.DataPropertyName = "Dias_Atrazo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "0";
            this.Dias_Atrazo.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dias_Atrazo.HeaderText = "Dias Atraso";
            this.Dias_Atrazo.Name = "Dias_Atrazo";
            this.Dias_Atrazo.ReadOnly = true;
            this.Dias_Atrazo.Width = 110;
            // 
            // FormCXC_Por_Antiguedad_Saldo
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
            this.Name = "FormCXC_Por_Antiguedad_Saldo";
            this.Text = "CUENTAS POR COBRAR POR ANTIGUEDAD DE SALDO";
            this.Load += new System.EventHandler(this.FormCXC_Por_Antiguedad_Saldo_Load);
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

        private System.Windows.Forms.Button btnBuscarEntidad;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private WinControl_ELR_NET.ELRCheckBox chkPorFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinControl_ELR_NET.ELRTextBox txt121;
        private System.Windows.Forms.Label label11;
        private WinControl_ELR_NET.ELRTextBox txt91_120;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRTextBox txt61_90;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRTextBox txt31_60;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txt0_30;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_P0_30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_P31_60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_P61_90;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_P91_120;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_P121;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ultimo_Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Atrazo;
    }
}