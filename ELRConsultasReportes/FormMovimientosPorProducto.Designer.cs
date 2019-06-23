namespace ELRConsultasReportes
{
    partial class FormMovimientosPorProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionado_Por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.txtTotalSalida = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.txtTotalEntrada = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.txtComentario = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigoprod = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescProd = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtComentario);
            this.pnTotales.Controls.Add(this.panel1);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 450);
            this.pnTotales.Size = new System.Drawing.Size(1037, 96);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.panel1, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtComentario, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnBuscarProducto);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Controls.Add(this.txtDescProd);
            this.pnBusqSencilla.Controls.Add(this.txtCodigoprod);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 84);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigoprod, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtDescProd, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarProducto, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(817, 14);
            this.txtABuscar.Size = new System.Drawing.Size(54, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(559, 40);
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.Text = "Código:";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Size = new System.Drawing.Size(52, 18);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 398);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Producto_Id,
            this.Descripcion,
            this.Concepto,
            this.Cantidad,
            this.Precio,
            this.Tipo,
            this.Adicionado_Por});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 314);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Producto_Id
            // 
            this.Producto_Id.DataPropertyName = "Producto_Id";
            this.Producto_Id.HeaderText = "Producto_Id";
            this.Producto_Id.Name = "Producto_Id";
            this.Producto_Id.ReadOnly = true;
            this.Producto_Id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.HeaderText = "Precio\\Costo";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 130;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Adicionado_Por
            // 
            this.Adicionado_Por.DataPropertyName = "Adicionado_Por";
            this.Adicionado_Por.HeaderText = "Adicionado_Por";
            this.Adicionado_Por.Name = "Adicionado_Por";
            this.Adicionado_Por.ReadOnly = true;
            this.Adicionado_Por.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.elrLabel3);
            this.panel1.Controls.Add(this.txtTotalSalida);
            this.panel1.Controls.Add(this.elrLabel2);
            this.panel1.Controls.Add(this.txtTotalEntrada);
            this.panel1.Controls.Add(this.elrLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(771, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 92);
            this.panel1.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.AMostrar = null;
            this.txtTotal.AValidar = null;
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.CampoBusquedaID = "";
            this.txtTotal.CampoData = "";
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.ColumnasBusqGeneral = null;
            this.txtTotal.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotal.Decimales = 0;
            this.txtTotal.DSData = null;
            this.txtTotal.EsAutoGenerado = false;
            this.txtTotal.EsBusqueda = false;
            this.txtTotal.EsBusquedaAutoIncremental = false;
            this.txtTotal.EsEditable = true;
            this.txtTotal.FiltroBusqueda = "";
            this.txtTotal.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTotal.Location = new System.Drawing.Point(134, 61);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.NombreTabla = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SepDecimal = '\0';
            this.txtTotal.Size = new System.Drawing.Size(116, 24);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TablaOVistaBusqueda = "";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotal.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotal.ValorPorDefecto = "";
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "";
            this.elrLabel3.DSData = null;
            this.elrLabel3.Location = new System.Drawing.Point(77, 61);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(51, 18);
            this.elrLabel3.TabIndex = 4;
            this.elrLabel3.Text = "Total:";
            this.elrLabel3.ValorPorDefecto = "";
            // 
            // txtTotalSalida
            // 
            this.txtTotalSalida.AMostrar = null;
            this.txtTotalSalida.AValidar = null;
            this.txtTotalSalida.BackColor = System.Drawing.Color.White;
            this.txtTotalSalida.CampoBusquedaID = "";
            this.txtTotalSalida.CampoData = "";
            this.txtTotalSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalSalida.ColumnasBusqGeneral = null;
            this.txtTotalSalida.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotalSalida.Decimales = 0;
            this.txtTotalSalida.DSData = null;
            this.txtTotalSalida.EsAutoGenerado = false;
            this.txtTotalSalida.EsBusqueda = false;
            this.txtTotalSalida.EsBusquedaAutoIncremental = false;
            this.txtTotalSalida.EsEditable = true;
            this.txtTotalSalida.FiltroBusqueda = "";
            this.txtTotalSalida.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTotalSalida.Location = new System.Drawing.Point(134, 35);
            this.txtTotalSalida.Name = "txtTotalSalida";
            this.txtTotalSalida.NombreTabla = "";
            this.txtTotalSalida.ReadOnly = true;
            this.txtTotalSalida.SepDecimal = '\0';
            this.txtTotalSalida.Size = new System.Drawing.Size(116, 24);
            this.txtTotalSalida.TabIndex = 3;
            this.txtTotalSalida.TablaOVistaBusqueda = "";
            this.txtTotalSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalSalida.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotalSalida.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotalSalida.ValorPorDefecto = "";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(26, 35);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(102, 18);
            this.elrLabel2.TabIndex = 2;
            this.elrLabel2.Text = "Total Salida:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // txtTotalEntrada
            // 
            this.txtTotalEntrada.AMostrar = null;
            this.txtTotalEntrada.AValidar = null;
            this.txtTotalEntrada.BackColor = System.Drawing.Color.White;
            this.txtTotalEntrada.CampoBusquedaID = "";
            this.txtTotalEntrada.CampoData = "";
            this.txtTotalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalEntrada.ColumnasBusqGeneral = null;
            this.txtTotalEntrada.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotalEntrada.Decimales = 0;
            this.txtTotalEntrada.DSData = null;
            this.txtTotalEntrada.EsAutoGenerado = false;
            this.txtTotalEntrada.EsBusqueda = false;
            this.txtTotalEntrada.EsBusquedaAutoIncremental = false;
            this.txtTotalEntrada.EsEditable = true;
            this.txtTotalEntrada.FiltroBusqueda = "";
            this.txtTotalEntrada.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTotalEntrada.Location = new System.Drawing.Point(134, 9);
            this.txtTotalEntrada.Name = "txtTotalEntrada";
            this.txtTotalEntrada.NombreTabla = "";
            this.txtTotalEntrada.ReadOnly = true;
            this.txtTotalEntrada.SepDecimal = '\0';
            this.txtTotalEntrada.Size = new System.Drawing.Size(116, 24);
            this.txtTotalEntrada.TabIndex = 1;
            this.txtTotalEntrada.TablaOVistaBusqueda = "";
            this.txtTotalEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalEntrada.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotalEntrada.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotalEntrada.ValorPorDefecto = "";
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(14, 9);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(114, 18);
            this.elrLabel1.TabIndex = 0;
            this.elrLabel1.Text = "Total Entrada:";
            this.elrLabel1.ValorPorDefecto = "";
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
            this.txtComentario.Location = new System.Drawing.Point(0, 0);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.NombreTabla = "";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComentario.SepDecimal = '\0';
            this.txtComentario.Size = new System.Drawing.Size(771, 92);
            this.txtComentario.TabIndex = 2;
            this.txtComentario.TablaOVistaBusqueda = "";
            this.txtComentario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtComentario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtComentario.ValorPorDefecto = "";
            // 
            // txtCodigoprod
            // 
            this.txtCodigoprod.AMostrar = null;
            this.txtCodigoprod.AValidar = null;
            this.txtCodigoprod.CampoBusquedaID = "";
            this.txtCodigoprod.CampoData = "";
            this.txtCodigoprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoprod.ColumnasBusqGeneral = null;
            this.txtCodigoprod.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoprod.Decimales = 0;
            this.txtCodigoprod.DSData = null;
            this.txtCodigoprod.EsAutoGenerado = false;
            this.txtCodigoprod.EsBusqueda = false;
            this.txtCodigoprod.EsBusquedaAutoIncremental = false;
            this.txtCodigoprod.EsEditable = true;
            this.txtCodigoprod.FiltroBusqueda = "";
            this.txtCodigoprod.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoprod.Location = new System.Drawing.Point(83, 6);
            this.txtCodigoprod.Name = "txtCodigoprod";
            this.txtCodigoprod.NombreTabla = "";
            this.txtCodigoprod.SepDecimal = '\0';
            this.txtCodigoprod.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoprod.TabIndex = 3;
            this.txtCodigoprod.TablaOVistaBusqueda = "";
            this.txtCodigoprod.Text = "0";
            this.txtCodigoprod.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoprod.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigoprod, "Digite Codigo de Producto a Buscar y Presione Enter");
            this.txtCodigoprod.ValorPorDefecto = "";
            this.txtCodigoprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoprod_KeyDown);
            // 
            // txtDescProd
            // 
            this.txtDescProd.AMostrar = null;
            this.txtDescProd.AValidar = null;
            this.txtDescProd.BackColor = System.Drawing.Color.White;
            this.txtDescProd.CampoBusquedaID = "";
            this.txtDescProd.CampoData = "";
            this.txtDescProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescProd.ColumnasBusqGeneral = null;
            this.txtDescProd.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescProd.Decimales = 0;
            this.txtDescProd.DSData = null;
            this.txtDescProd.EsAutoGenerado = false;
            this.txtDescProd.EsBusqueda = false;
            this.txtDescProd.EsBusquedaAutoIncremental = false;
            this.txtDescProd.EsEditable = true;
            this.txtDescProd.FiltroBusqueda = "";
            this.txtDescProd.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescProd.Location = new System.Drawing.Point(237, 6);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.NombreTabla = "";
            this.txtDescProd.ReadOnly = true;
            this.txtDescProd.SepDecimal = '\0';
            this.txtDescProd.Size = new System.Drawing.Size(422, 26);
            this.txtDescProd.TabIndex = 4;
            this.txtDescProd.TablaOVistaBusqueda = "";
            this.txtDescProd.Text = "(TODOS)";
            this.txtDescProd.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescProd.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescProd.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 5;
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
            this.dtpFecha1.Location = new System.Drawing.Point(129, 40);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 6;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(384, 40);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 8;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha Hasta:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarProducto.Location = new System.Drawing.Point(189, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // FormMovimientosPorProducto
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
            this.Name = "FormMovimientosPorProducto";
            this.Text = "MOVIMIENTOS POR PRODUCTO Y\\O SERVICIOS";
            this.Load += new System.EventHandler(this.FormMovimientosPorProducto_Load);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRTextBox txtComentario;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtDescProd;
        private WinControl_ELR_NET.ELRTextBox txtCodigoprod;
        private System.Windows.Forms.Button btnBuscarProducto;
        private WinControl_ELR_NET.ELRTextBox txtTotalSalida;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRTextBox txtTotalEntrada;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRTextBox txtTotal;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicionado_Por;
    }
}