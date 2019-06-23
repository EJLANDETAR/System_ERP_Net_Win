namespace ELRNomina
{
    partial class FormNominasMovimientos
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
            this.txtEmpleadoId = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsSueldoBruto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComentario = new WinControl_ELR_NET.ELRTextBox();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.groupBox1);
            this.pnTotales.Controls.Add(this.lblTotal);
            this.pnTotales.Location = new System.Drawing.Point(0, 455);
            this.pnTotales.Size = new System.Drawing.Size(1037, 91);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.lblTotal, 0);
            this.pnTotales.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.txtCedulaRNC);
            this.pnBusqSencilla.Controls.Add(this.label9);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarEmpleado);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Controls.Add(this.txtEmpleadoId);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 129);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtEmpleadoId, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarEmpleado, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label9, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCedulaRNC, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(848, 34);
            this.txtABuscar.Size = new System.Drawing.Size(71, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 85);
            this.btnBuscar.Size = new System.Drawing.Size(88, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.Text = "Empleado:";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 403);
            // 
            // txtEmpleadoId
            // 
            this.txtEmpleadoId.AMostrar = null;
            this.txtEmpleadoId.AValidar = null;
            this.txtEmpleadoId.CampoBusquedaID = "";
            this.txtEmpleadoId.CampoData = "";
            this.txtEmpleadoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleadoId.ColumnasBusqGeneral = null;
            this.txtEmpleadoId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEmpleadoId.Decimales = 0;
            this.txtEmpleadoId.DSData = null;
            this.txtEmpleadoId.EsAutoGenerado = false;
            this.txtEmpleadoId.EsBusqueda = false;
            this.txtEmpleadoId.EsBusquedaAutoIncremental = false;
            this.txtEmpleadoId.EsEditable = true;
            this.txtEmpleadoId.FiltroBusqueda = "";
            this.txtEmpleadoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEmpleadoId.Location = new System.Drawing.Point(125, 14);
            this.txtEmpleadoId.Name = "txtEmpleadoId";
            this.txtEmpleadoId.NombreTabla = "";
            this.txtEmpleadoId.SepDecimal = '\0';
            this.txtEmpleadoId.Size = new System.Drawing.Size(132, 26);
            this.txtEmpleadoId.TabIndex = 3;
            this.txtEmpleadoId.TablaOVistaBusqueda = "";
            this.txtEmpleadoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEmpleadoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEmpleadoId.ValorPorDefecto = "";
            this.txtEmpleadoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpleadoId_KeyDown);
            this.txtEmpleadoId.Leave += new System.EventHandler(this.txtEmpleadoId_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Desde:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(134, 85);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(132, 26);
            this.dtpFecha1.TabIndex = 5;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 7, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Hasta:";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(403, 85);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(132, 26);
            this.dtpFecha2.TabIndex = 7;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 7, 0, 0, 0, 0);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = global::ELRNomina.Properties.Resources._1378160672_search;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(263, 14);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEmpleado.TabIndex = 9;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
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
            this.txtNombre.Location = new System.Drawing.Point(125, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(504, 26);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TablaOVistaBusqueda = "";
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
            this.Fecha,
            this.Concepto,
            this.Cantidad,
            this.Valor,
            this.Monto,
            this.EsSueldoBruto,
            this.Estatus,
            this.btnEliminar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 274);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Id";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Width = 85;
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
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // EsSueldoBruto
            // 
            this.EsSueldoBruto.DataPropertyName = "EsSueldoBruto";
            this.EsSueldoBruto.HeaderText = "EsSueldoBruto";
            this.EsSueldoBruto.Name = "EsSueldoBruto";
            this.EsSueldoBruto.ReadOnly = true;
            this.EsSueldoBruto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsSueldoBruto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsSueldoBruto.Width = 115;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 130;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cedula\\RNC:";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.BackColor = System.Drawing.Color.White;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = null;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(450, 12);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.ReadOnly = true;
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(179, 26);
            this.txtCedulaRNC.TabIndex = 13;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(790, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(243, 87);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.AMostrar = null;
            this.txtComentario.AValidar = null;
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.CampoBusquedaID = "";
            this.txtComentario.CampoData = "";
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.ColumnasBusqGeneral = null;
            this.txtComentario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtComentario.Decimales = 0;
            this.txtComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComentario.DSData = null;
            this.txtComentario.EsAutoGenerado = false;
            this.txtComentario.EsBusqueda = false;
            this.txtComentario.EsBusquedaAutoIncremental = false;
            this.txtComentario.EsEditable = true;
            this.txtComentario.FiltroBusqueda = "";
            this.txtComentario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtComentario.Location = new System.Drawing.Point(3, 22);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.NombreTabla = "";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComentario.SepDecimal = '\0';
            this.txtComentario.Size = new System.Drawing.Size(784, 62);
            this.txtComentario.TabIndex = 0;
            this.txtComentario.TablaOVistaBusqueda = "";
            this.txtComentario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtComentario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtComentario.ValorPorDefecto = "";
            // 
            // FormNominasMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsImprimir = true;
            this.FormularioRegistro = "ELRNomina.FormNominasMovimientosR";
            this.Name = "FormNominasMovimientos";
            this.NombreCampoID = "Unico";
            this.SPCargarATemporal = "SP_NOMINAS_MOVIMIENTOS_ATEMPORAL";
            this.Text = "NOMINA TRANSACCIONES";
            this.Load += new System.EventHandler(this.FormNominasMovimientos_Load);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtEmpleadoId;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtComentario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsSueldoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}