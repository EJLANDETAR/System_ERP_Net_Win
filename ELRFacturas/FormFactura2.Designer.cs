namespace ELRFacturas
{
    partial class FormFactura2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDetalle = new System.Windows.Forms.DataGridView();
            this.ItemNumero = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.txtPrecio = new WinControl_ELR_NET.ELRTextBox();
            this.txtCantidad = new WinControl_ELR_NET.ELRTextBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProdDescripcion = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblMonto = new WinControl_ELR_NET.ELRLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVendedorNombre = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.txtVendedorId = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTipoNCF = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenuLateral = new System.Windows.Forms.Panel();
            this.brnAplicarNotaCredito = new System.Windows.Forms.Button();
            this.btnBorrarItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 544);
            this.pnBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pnBotones.Size = new System.Drawing.Size(1133, 50);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(841, 0);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Size = new System.Drawing.Size(172, 46);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1013, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Size = new System.Drawing.Size(116, 46);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Size = new System.Drawing.Size(116, 46);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(725, 0);
            this.btnSiguientePage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguientePage.Size = new System.Drawing.Size(116, 46);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(116, 0);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(609, 46);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDetalle);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnMenuLateral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 544);
            this.panel1.TabIndex = 1;
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.AllowUserToAddRows = false;
            this.dtgvDetalle.AllowUserToDeleteRows = false;
            this.dtgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumero,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Itbis,
            this.Monto});
            this.dtgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDetalle.Location = new System.Drawing.Point(143, 228);
            this.dtgvDetalle.MultiSelect = false;
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.ReadOnly = true;
            this.dtgvDetalle.RowHeadersWidth = 25;
            this.dtgvDetalle.RowTemplate.Height = 35;
            this.dtgvDetalle.Size = new System.Drawing.Size(990, 216);
            this.dtgvDetalle.TabIndex = 4;
            this.dtgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetalle_CellContentClick);
            // 
            // ItemNumero
            // 
            this.ItemNumero.DataPropertyName = "ItemNumero";
            this.ItemNumero.HeaderText = "Item";
            this.ItemNumero.Name = "ItemNumero";
            this.ItemNumero.ReadOnly = true;
            this.ItemNumero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemNumero.Width = 85;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 120;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 140;
            // 
            // Itbis
            // 
            this.Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Itbis.DefaultCellStyle = dataGridViewCellStyle3;
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.ReadOnly = true;
            this.Itbis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Itbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Itbis.Width = 120;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto.HeaderText = "Total";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Monto.Width = 145;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Controls.Add(this.txtPrecio);
            this.panel4.Controls.Add(this.txtCantidad);
            this.panel4.Controls.Add(this.btnAgregarItem);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblProdDescripcion);
            this.panel4.Controls.Add(this.btnBuscarProducto);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblNombreProducto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(143, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(990, 100);
            this.panel4.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.autoSenTab = true;
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
            this.txtCodigo.Location = new System.Drawing.Point(85, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(231, 33);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.AMostrar = null;
            this.txtPrecio.autoSenTab = true;
            this.txtPrecio.AValidar = null;
            this.txtPrecio.CampoBusquedaID = "";
            this.txtPrecio.CampoData = "";
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.ColumnasBusqGeneral = null;
            this.txtPrecio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPrecio.Decimales = 2;
            this.txtPrecio.DSData = null;
            this.txtPrecio.EsAutoGenerado = false;
            this.txtPrecio.EsBusqueda = false;
            this.txtPrecio.EsBusquedaAutoIncremental = false;
            this.txtPrecio.EsEditable = true;
            this.txtPrecio.FiltroBusqueda = "";
            this.txtPrecio.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPrecio.Location = new System.Drawing.Point(669, 17);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.NombreTabla = "";
            this.txtPrecio.SepDecimal = '\0';
            this.txtPrecio.Size = new System.Drawing.Size(160, 33);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TablaOVistaBusqueda = "";
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPrecio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPrecio.ValorPorDefecto = "";
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AMostrar = null;
            this.txtCantidad.autoSenTab = true;
            this.txtCantidad.AValidar = null;
            this.txtCantidad.CampoBusquedaID = "";
            this.txtCantidad.CampoData = "";
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.ColumnasBusqGeneral = null;
            this.txtCantidad.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCantidad.Decimales = 2;
            this.txtCantidad.DSData = null;
            this.txtCantidad.EsAutoGenerado = false;
            this.txtCantidad.EsBusqueda = false;
            this.txtCantidad.EsBusquedaAutoIncremental = false;
            this.txtCantidad.EsEditable = true;
            this.txtCantidad.FiltroBusqueda = "";
            this.txtCantidad.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtCantidad.Location = new System.Drawing.Point(477, 17);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.NombreTabla = "";
            this.txtCantidad.SepDecimal = '\0';
            this.txtCantidad.Size = new System.Drawing.Size(100, 33);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TablaOVistaBusqueda = "";
            this.txtCantidad.Text = "0.00";
            this.txtCantidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCantidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCantidad.ValorPorDefecto = "";
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Enabled = false;
            this.btnAgregarItem.Image = global::ELRFacturas.Properties.Resources.add;
            this.btnAgregarItem.Location = new System.Drawing.Point(835, 17);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(143, 40);
            this.btnAgregarItem.TabIndex = 7;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio:";
            // 
            // lblProdDescripcion
            // 
            this.lblProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProdDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProdDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescripcion.Location = new System.Drawing.Point(0, 63);
            this.lblProdDescripcion.Name = "lblProdDescripcion";
            this.lblProdDescripcion.Size = new System.Drawing.Size(990, 37);
            this.lblProdDescripcion.TabIndex = 8;
            this.lblProdDescripcion.Text = "NOMBRE/DESCRIPCION ITEM VENTA";
            this.lblProdDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::ELRFacturas.Properties.Resources._1378160672_search;
            this.btnBuscarProducto.Location = new System.Drawing.Point(322, 16);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(55, 41);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
            this.btnBuscarProducto.Enter += new System.EventHandler(this.btnBuscarProducto_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codigo";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(383, 16);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(88, 25);
            this.lblNombreProducto.TabIndex = 3;
            this.lblNombreProducto.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Controls.Add(this.lblMonto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(143, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 100);
            this.panel3.TabIndex = 3;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(669, 100);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Sub Total: 0.00     Dscto.: 0.00     Itbis: 0.00     ";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.Black;
            this.lblMonto.CampoData = "";
            this.lblMonto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMonto.DSData = null;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.lblMonto.ForeColor = System.Drawing.Color.Lime;
            this.lblMonto.Location = new System.Drawing.Point(669, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.NombreTabla = "";
            this.lblMonto.Size = new System.Drawing.Size(321, 100);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "0.00";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonto.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVendedorNombre);
            this.groupBox1.Controls.Add(this.btnBuscarVendedor);
            this.groupBox1.Controls.Add(this.txtVendedorId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(143, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONE VENDEDOR";
            // 
            // txtVendedorNombre
            // 
            this.txtVendedorNombre.AMostrar = null;
            this.txtVendedorNombre.autoSenTab = true;
            this.txtVendedorNombre.AValidar = null;
            this.txtVendedorNombre.BackColor = System.Drawing.Color.White;
            this.txtVendedorNombre.CampoBusquedaID = "";
            this.txtVendedorNombre.CampoData = "Vendedor_Nombre";
            this.txtVendedorNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedorNombre.ColumnasBusqGeneral = null;
            this.txtVendedorNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtVendedorNombre.Decimales = 0;
            this.txtVendedorNombre.DSData = this.DSDatos;
            this.txtVendedorNombre.Enabled = false;
            this.txtVendedorNombre.EsAutoGenerado = false;
            this.txtVendedorNombre.EsBusqueda = false;
            this.txtVendedorNombre.EsBusquedaAutoIncremental = false;
            this.txtVendedorNombre.EsEditable = true;
            this.txtVendedorNombre.FiltroBusqueda = "";
            this.txtVendedorNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtVendedorNombre.Location = new System.Drawing.Point(251, 32);
            this.txtVendedorNombre.Name = "txtVendedorNombre";
            this.txtVendedorNombre.NombreTabla = "";
            this.txtVendedorNombre.ReadOnly = true;
            this.txtVendedorNombre.SepDecimal = '\0';
            this.txtVendedorNombre.Size = new System.Drawing.Size(727, 33);
            this.txtVendedorNombre.TabIndex = 2;
            this.txtVendedorNombre.TablaOVistaBusqueda = "";
            this.txtVendedorNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtVendedorNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtVendedorNombre.ValorPorDefecto = "";
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.Image = global::ELRFacturas.Properties.Resources._1378160672_search;
            this.btnBuscarVendedor.Location = new System.Drawing.Point(196, 32);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(49, 41);
            this.btnBuscarVendedor.TabIndex = 1;
            this.btnBuscarVendedor.UseVisualStyleBackColor = true;
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            // 
            // txtVendedorId
            // 
            this.txtVendedorId.AMostrar = null;
            this.txtVendedorId.autoSenTab = true;
            this.txtVendedorId.AValidar = null;
            this.txtVendedorId.CampoBusquedaID = "";
            this.txtVendedorId.CampoData = "Vendedor_Id";
            this.txtVendedorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedorId.ColumnasBusqGeneral = null;
            this.txtVendedorId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtVendedorId.Decimales = 0;
            this.txtVendedorId.DSData = this.DSDatos;
            this.txtVendedorId.EsAutoGenerado = false;
            this.txtVendedorId.EsBusqueda = false;
            this.txtVendedorId.EsBusquedaAutoIncremental = false;
            this.txtVendedorId.EsEditable = true;
            this.txtVendedorId.FiltroBusqueda = "";
            this.txtVendedorId.Formato = WinControl_ELR_NET.tbFormato.LetrasYNumeros;
            this.txtVendedorId.Location = new System.Drawing.Point(11, 32);
            this.txtVendedorId.Name = "txtVendedorId";
            this.txtVendedorId.NombreTabla = "";
            this.txtVendedorId.SepDecimal = '\0';
            this.txtVendedorId.Size = new System.Drawing.Size(179, 33);
            this.txtVendedorId.TabIndex = 0;
            this.txtVendedorId.TablaOVistaBusqueda = "";
            this.txtVendedorId.Text = "0";
            this.txtVendedorId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtVendedorId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtVendedorId.ValorPorDefecto = "0";
            this.txtVendedorId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendedorId_KeyDown);
            this.txtVendedorId.Leave += new System.EventHandler(this.txtVendedorId_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTipoNCF);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(143, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 55);
            this.panel2.TabIndex = 1;
            // 
            // cboTipoNCF
            // 
            this.cboTipoNCF.AValidar = null;
            this.cboTipoNCF.CampoData = "Tipo_NCF";
            this.cboTipoNCF.CampoJoinCombobox2 = "";
            this.cboTipoNCF.ComboboxAFiltrar = this.cboTipoNCF;
            this.cboTipoNCF.DisplayMember = "Descripcion";
            this.cboTipoNCF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoNCF.DSData = this.DSDatos;
            this.cboTipoNCF.EsEditable = true;
            this.cboTipoNCF.FiltroBusqueda = "(EsVenta = 1 OR Tipo_NCF = 0)";
            this.cboTipoNCF.FormattingEnabled = true;
            this.cboTipoNCF.Location = new System.Drawing.Point(251, 9);
            this.cboTipoNCF.Name = "cboTipoNCF";
            this.cboTipoNCF.NombreTabla = "";
            this.cboTipoNCF.Size = new System.Drawing.Size(727, 33);
            this.cboTipoNCF.SSQL = "";
            this.cboTipoNCF.TabIndex = 0;
            this.cboTipoNCF.TablaOVistaConsulta = "TSISTEMA_TIPOS_NCF";
            this.cboTipoNCF.UsaDataGlobal = false;
            this.cboTipoNCF.ValorPorDefecto = "0";
            this.cboTipoNCF.ValueMember = "Tipo_NCF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Comprobante Fiscal:";
            // 
            // pnMenuLateral
            // 
            this.pnMenuLateral.BackColor = System.Drawing.Color.Silver;
            this.pnMenuLateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenuLateral.Controls.Add(this.brnAplicarNotaCredito);
            this.pnMenuLateral.Controls.Add(this.btnBorrarItem);
            this.pnMenuLateral.Controls.Add(this.button1);
            this.pnMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnMenuLateral.Name = "pnMenuLateral";
            this.pnMenuLateral.Size = new System.Drawing.Size(143, 544);
            this.pnMenuLateral.TabIndex = 0;
            // 
            // brnAplicarNotaCredito
            // 
            this.brnAplicarNotaCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnAplicarNotaCredito.Location = new System.Drawing.Point(0, 204);
            this.brnAplicarNotaCredito.Name = "brnAplicarNotaCredito";
            this.brnAplicarNotaCredito.Size = new System.Drawing.Size(139, 102);
            this.brnAplicarNotaCredito.TabIndex = 2;
            this.brnAplicarNotaCredito.Text = "Aplicar Nota Credito";
            this.brnAplicarNotaCredito.UseVisualStyleBackColor = true;
            this.brnAplicarNotaCredito.Click += new System.EventHandler(this.brnAplicarNotaCredito_Click);
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrarItem.Location = new System.Drawing.Point(0, 102);
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.Size = new System.Drawing.Size(139, 102);
            this.btnBorrarItem.TabIndex = 2;
            this.btnBorrarItem.Text = "Borrar Item";
            this.btnBorrarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrarItem.UseVisualStyleBackColor = true;
            this.btnBorrarItem.Click += new System.EventHandler(this.btnBorrarItem_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Editar Cantidad Precio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFactura2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 594);
            this.CodigoOperacion = 100;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgvDetalle;
            this.EditarClienteDesglose = true;
            this.EsAgregarLineaVacia = false;
            this.EsConTemporal = true;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.PreviewRDLC;
            this.ImprimirAlGrabar = true;
            this.MenuLateralBringToFront = true;
            this.MostrarDesglosePago = true;
            this.Name = "FormFactura2";
            this.NombreCampoID = "Identificador_Id";
            this.NombreReporte = "rptFactura";
            this.NombreVistaImprimir = "VVENTAS_DETALLE";
            this.NuevoRegistroAlGrabar = true;
            this.PermiteACredito = true;
            this.SPCargaATemporal = "SP_VENTAS_CARGAR_A_TEMPORAL";
            this.SPGraba = "SP_VENTAS_GRABA_FACTURA";
            this.TablaDetalle = "TTEMPORAL_VENTAS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_VENTAS";
            this.Text = "REGISTRAR FACTURA";
            this.Activated += new System.EventHandler(this.FormFactura2_Activated);
            this.Load += new System.EventHandler(this.FormFactura2_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnMenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRCombobox cboTipoNCF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtVendedorId;
        private WinControl_ELR_NET.ELRTextBox txtVendedorNombre;
        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvDetalle;
        private System.Windows.Forms.DataGridViewLinkColumn ItemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProdDescripcion;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreProducto;
        private WinControl_ELR_NET.ELRTextBox txtCantidad;
        private WinControl_ELR_NET.ELRTextBox txtPrecio;
        private System.Windows.Forms.Label lblSubTotal;
        private WinControl_ELR_NET.ELRLabel lblMonto;
        private System.Windows.Forms.Panel pnMenuLateral;
        private System.Windows.Forms.Button brnAplicarNotaCredito;
        private System.Windows.Forms.Button btnBorrarItem;
        private System.Windows.Forms.Button button1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
    }
}