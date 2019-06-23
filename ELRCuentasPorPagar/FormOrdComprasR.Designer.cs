namespace ELRCuentasPorPagar
{
    partial class FormOrdComprasR
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
            WinControl_ELR_NET.ControlesMostrar controlesMostrar1 = new WinControl_ELR_NET.ControlesMostrar();
            WinControl_ELR_NET.ControlesMostrar controlesMostrar2 = new WinControl_ELR_NET.ControlesMostrar();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            this.txtNombreSuplidor = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigoSup = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPrecio = new WinControl_ELR_NET.ELRTextBox();
            this.txtCantidad = new WinControl_ELR_NET.ELRTextBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblProdDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTasaCambio = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMoneda = new WinControl_ELR_NET.ELRCombobox();
            this.label10 = new System.Windows.Forms.Label();
            this.elrDatePicker1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.elrTextBox4 = new WinControl_ELR_NET.ELRTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new WinControl_ELR_NET.ELRTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccion = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarSup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requisicion_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarReq = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnAgregarReq);
            this.pnBotones.Location = new System.Drawing.Point(0, 498);
            this.pnBotones.Size = new System.Drawing.Size(1127, 60);
            this.pnBotones.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnGrabar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnSiguientePage, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAnterior, 0);
            this.pnBotones.Controls.SetChildIndex(this.lblNombreUsuario, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAgregarReq, 0);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(846, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 56);
            this.btnGrabar.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(987, 0);
            this.btnCancelar.Size = new System.Drawing.Size(136, 56);
            this.btnCancelar.TabIndex = 5;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(53, 0);
            this.btnAnterior.Size = new System.Drawing.Size(95, 56);
            this.btnAnterior.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(751, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 56);
            this.btnSiguientePage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(148, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(603, 56);
            // 
            // txtNombreSuplidor
            // 
            this.txtNombreSuplidor.AMostrar = null;
            this.txtNombreSuplidor.autoSenTab = true;
            this.txtNombreSuplidor.AValidar = null;
            this.txtNombreSuplidor.BackColor = System.Drawing.Color.White;
            this.txtNombreSuplidor.CampoBusquedaID = "";
            this.txtNombreSuplidor.CampoData = "Nombre";
            this.txtNombreSuplidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreSuplidor.ColumnasBusqGeneral = null;
            this.txtNombreSuplidor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreSuplidor.Decimales = 0;
            this.txtNombreSuplidor.DSData = this.DSDatos;
            this.txtNombreSuplidor.EsAutoGenerado = false;
            this.txtNombreSuplidor.EsBusqueda = false;
            this.txtNombreSuplidor.EsBusquedaAutoIncremental = false;
            this.txtNombreSuplidor.EsEditable = true;
            this.txtNombreSuplidor.FiltroBusqueda = "";
            this.txtNombreSuplidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSuplidor.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreSuplidor.Location = new System.Drawing.Point(355, 58);
            this.txtNombreSuplidor.Name = "txtNombreSuplidor";
            this.txtNombreSuplidor.NombreTabla = "";
            this.txtNombreSuplidor.ReadOnly = true;
            this.txtNombreSuplidor.SepDecimal = '\0';
            this.txtNombreSuplidor.Size = new System.Drawing.Size(375, 29);
            this.txtNombreSuplidor.TabIndex = 4;
            this.txtNombreSuplidor.TablaOVistaBusqueda = "";
            this.txtNombreSuplidor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreSuplidor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreSuplidor.ValorPorDefecto = "";
            // 
            // txtCodigoSup
            // 
            controlesMostrar1.ComboBoxControl = null;
            controlesMostrar1.EsHabilitar = false;
            controlesMostrar1.Formato = "";
            controlesMostrar1.LabelControl = null;
            controlesMostrar1.NombreCampo = "Nombre_Completo";
            controlesMostrar1.NumericUpDownControl = null;
            controlesMostrar1.TextBoxControl = this.txtNombreSuplidor;
            controlesMostrar1.ValorPorDefecto = "";
            controlesMostrar2.ComboBoxControl = null;
            controlesMostrar2.EsHabilitar = false;
            controlesMostrar2.Formato = "";
            controlesMostrar2.LabelControl = null;
            controlesMostrar2.NombreCampo = "Entidad_Id";
            controlesMostrar2.NumericUpDownControl = null;
            controlesMostrar2.TextBoxControl = this.txtCodigoSup;
            controlesMostrar2.ValorPorDefecto = "";
            this.txtCodigoSup.AMostrar = new WinControl_ELR_NET.ControlesMostrar[] {
        controlesMostrar1,
        controlesMostrar2};
            this.txtCodigoSup.autoSenTab = true;
            this.txtCodigoSup.AValidar = null;
            this.txtCodigoSup.CampoBusquedaID = "";
            this.txtCodigoSup.CampoData = "Suplidor_Id";
            this.txtCodigoSup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSup.ColumnasBusqGeneral = null;
            this.txtCodigoSup.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoSup.Decimales = 0;
            this.txtCodigoSup.DSData = this.DSDatos;
            this.txtCodigoSup.EsAutoGenerado = false;
            this.txtCodigoSup.EsBusqueda = false;
            this.txtCodigoSup.EsBusquedaAutoIncremental = false;
            this.txtCodigoSup.EsEditable = true;
            this.txtCodigoSup.FiltroBusqueda = "";
            this.txtCodigoSup.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtCodigoSup.Location = new System.Drawing.Point(148, 58);
            this.txtCodigoSup.Name = "txtCodigoSup";
            this.txtCodigoSup.NombreTabla = "";
            this.txtCodigoSup.SepDecimal = '\0';
            this.txtCodigoSup.Size = new System.Drawing.Size(149, 29);
            this.txtCodigoSup.TabIndex = 2;
            this.txtCodigoSup.TablaOVistaBusqueda = "";
            this.txtCodigoSup.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoSup.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigoSup, "F9 = Buscar");
            this.txtCodigoSup.ValorPorDefecto = "0";
            this.txtCodigoSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoSup_KeyDown);
            this.txtCodigoSup.Leave += new System.EventHandler(this.txtCodigoSup_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtCedulaRNC);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnBuscarSup);
            this.panel1.Controls.Add(this.txtNombreSuplidor);
            this.panel1.Controls.Add(this.txtCodigoSup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 256);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtPrecio);
            this.panel5.Controls.Add(this.txtCantidad);
            this.panel5.Controls.Add(this.btnAgregarItem);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblNombreProducto);
            this.panel5.Controls.Add(this.lblProdDescripcion);
            this.panel5.Controls.Add(this.txtCodigoProducto);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnAgregarDetalle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1127, 92);
            this.panel5.TabIndex = 11;
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
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPrecio.Location = new System.Drawing.Point(768, 10);
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
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtCantidad.Location = new System.Drawing.Point(543, 11);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.NombreTabla = "";
            this.txtCantidad.SepDecimal = '\0';
            this.txtCantidad.Size = new System.Drawing.Size(126, 33);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TablaOVistaBusqueda = "";
            this.txtCantidad.Text = "0.00";
            this.txtCantidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCantidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCantidad.ValorPorDefecto = "";
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Enabled = false;
            this.btnAgregarItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Image = global::ELRCuentasPorPagar.Properties.Resources.Add;
            this.btnAgregarItem.Location = new System.Drawing.Point(946, 6);
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
            this.label2.Location = new System.Drawing.Point(693, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(449, 14);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(88, 25);
            this.lblNombreProducto.TabIndex = 3;
            this.lblNombreProducto.Text = "Cantidad";
            // 
            // lblProdDescripcion
            // 
            this.lblProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProdDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProdDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescripcion.Location = new System.Drawing.Point(0, 51);
            this.lblProdDescripcion.Name = "lblProdDescripcion";
            this.lblProdDescripcion.Size = new System.Drawing.Size(1123, 37);
            this.lblProdDescripcion.TabIndex = 8;
            this.lblProdDescripcion.Text = "NOMBRE/DESCRIPCION ITEM VENTA";
            this.lblProdDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.AMostrar = null;
            this.txtCodigoProducto.autoSenTab = true;
            this.txtCodigoProducto.AValidar = null;
            this.txtCodigoProducto.CampoBusquedaID = "";
            this.txtCodigoProducto.CampoData = "";
            this.txtCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProducto.ColumnasBusqGeneral = null;
            this.txtCodigoProducto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoProducto.Decimales = 0;
            this.txtCodigoProducto.DSData = null;
            this.txtCodigoProducto.EsAutoGenerado = false;
            this.txtCodigoProducto.EsBusqueda = false;
            this.txtCodigoProducto.EsBusquedaAutoIncremental = false;
            this.txtCodigoProducto.EsEditable = true;
            this.txtCodigoProducto.FiltroBusqueda = "";
            this.txtCodigoProducto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoProducto.Location = new System.Drawing.Point(146, 11);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.NombreTabla = "";
            this.txtCodigoProducto.SepDecimal = '\0';
            this.txtCodigoProducto.Size = new System.Drawing.Size(243, 29);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.TablaOVistaBusqueda = "";
            this.txtCodigoProducto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoProducto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoProducto.ValorPorDefecto = "";
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(395, 11);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(45, 33);
            this.btnAgregarDetalle.TabIndex = 2;
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtTasaCambio);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cboMoneda);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.elrDatePicker1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.elrTextBox4);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1127, 45);
            this.panel4.TabIndex = 0;
            // 
            // txtTasaCambio
            // 
            this.txtTasaCambio.AMostrar = null;
            this.txtTasaCambio.autoSenTab = true;
            this.txtTasaCambio.AValidar = null;
            this.txtTasaCambio.CampoBusquedaID = "";
            this.txtTasaCambio.CampoData = "Tasa_Cambio";
            this.txtTasaCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaCambio.ColumnasBusqGeneral = null;
            this.txtTasaCambio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaCambio.Decimales = 0;
            this.txtTasaCambio.DSData = this.DSDatos;
            this.txtTasaCambio.EsAutoGenerado = false;
            this.txtTasaCambio.EsBusqueda = false;
            this.txtTasaCambio.EsBusquedaAutoIncremental = false;
            this.txtTasaCambio.EsEditable = true;
            this.txtTasaCambio.FiltroBusqueda = "";
            this.txtTasaCambio.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTasaCambio.Location = new System.Drawing.Point(922, 9);
            this.txtTasaCambio.Name = "txtTasaCambio";
            this.txtTasaCambio.NombreTabla = "";
            this.txtTasaCambio.SepDecimal = '\0';
            this.txtTasaCambio.Size = new System.Drawing.Size(127, 29);
            this.txtTasaCambio.TabIndex = 7;
            this.txtTasaCambio.TablaOVistaBusqueda = "";
            this.txtTasaCambio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaCambio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaCambio.ValorPorDefecto = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(843, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cambio:";
            // 
            // cboMoneda
            // 
            this.cboMoneda.AValidar = null;
            this.cboMoneda.CampoData = "Moneda";
            this.cboMoneda.CampoJoinCombobox2 = "";
            this.cboMoneda.ComboboxAFiltrar = null;
            this.cboMoneda.DisplayMember = "Nombre";
            this.cboMoneda.DSData = this.DSDatos;
            this.cboMoneda.EsEditable = true;
            this.cboMoneda.FiltroBusqueda = "";
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(577, 10);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.NombreTabla = "";
            this.cboMoneda.Size = new System.Drawing.Size(260, 29);
            this.cboMoneda.SSQL = "";
            this.cboMoneda.TabIndex = 5;
            this.cboMoneda.TablaOVistaConsulta = "TSISTEMA_MONEDAS";
            this.cboMoneda.UsaDataGlobal = false;
            this.cboMoneda.ValorPorDefecto = "RD$";
            this.cboMoneda.ValueMember = "Codigo";
            this.cboMoneda.SelectedValueChanged += new System.EventHandler(this.elrCombobox1_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Moneda:";
            // 
            // elrDatePicker1
            // 
            this.elrDatePicker1.AValidar = null;
            this.elrDatePicker1.CampoData = "";
            this.elrDatePicker1.DSData = null;
            this.elrDatePicker1.Enabled = false;
            this.elrDatePicker1.EsEditable = true;
            this.elrDatePicker1.FiltroBusqueda = "";
            this.elrDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.elrDatePicker1.Location = new System.Drawing.Point(325, 10);
            this.elrDatePicker1.Name = "elrDatePicker1";
            this.elrDatePicker1.NombreTabla = "";
            this.elrDatePicker1.Size = new System.Drawing.Size(141, 29);
            this.elrDatePicker1.TabIndex = 3;
            this.elrDatePicker1.ValorPorDefecto = new System.DateTime(2016, 8, 5, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fecha:";
            // 
            // elrTextBox4
            // 
            this.elrTextBox4.AMostrar = null;
            this.elrTextBox4.autoSenTab = true;
            this.elrTextBox4.AValidar = null;
            this.elrTextBox4.CampoBusquedaID = "";
            this.elrTextBox4.CampoData = "Numero";
            this.elrTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox4.ColumnasBusqGeneral = null;
            this.elrTextBox4.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox4.Decimales = 0;
            this.elrTextBox4.DSData = this.DSDatos;
            this.elrTextBox4.Enabled = false;
            this.elrTextBox4.EsAutoGenerado = false;
            this.elrTextBox4.EsBusqueda = false;
            this.elrTextBox4.EsBusquedaAutoIncremental = false;
            this.elrTextBox4.EsEditable = true;
            this.elrTextBox4.FiltroBusqueda = "";
            this.elrTextBox4.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox4.Location = new System.Drawing.Point(95, 10);
            this.elrTextBox4.Name = "elrTextBox4";
            this.elrTextBox4.NombreTabla = "";
            this.elrTextBox4.SepDecimal = '\0';
            this.elrTextBox4.Size = new System.Drawing.Size(125, 29);
            this.elrTextBox4.TabIndex = 1;
            this.elrTextBox4.TablaOVistaBusqueda = "";
            this.elrTextBox4.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox4.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox4.ValorPorDefecto = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Suplidor No.:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AMostrar = null;
            this.txtTelefono.autoSenTab = true;
            this.txtTelefono.AValidar = null;
            this.txtTelefono.CampoBusquedaID = "";
            this.txtTelefono.CampoData = "Telefono";
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.ColumnasBusqGeneral = null;
            this.txtTelefono.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono.Decimales = 0;
            this.txtTelefono.DSData = this.DSDatos;
            this.txtTelefono.EsAutoGenerado = false;
            this.txtTelefono.EsBusqueda = false;
            this.txtTelefono.EsBusquedaAutoIncremental = false;
            this.txtTelefono.EsEditable = true;
            this.txtTelefono.FiltroBusqueda = "";
            this.txtTelefono.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono.Location = new System.Drawing.Point(862, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.NombreTabla = "";
            this.txtTelefono.SepDecimal = '\0';
            this.txtTelefono.Size = new System.Drawing.Size(189, 29);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.TablaOVistaBusqueda = "";
            this.txtTelefono.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono.ValorPorDefecto = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(748, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Telf.:";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.autoSenTab = true;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "CedulaRNC";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = this.DSDatos;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(862, 58);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(189, 29);
            this.txtCedulaRNC.TabIndex = 6;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(748, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ced.\\RNC.:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AMostrar = null;
            this.txtDireccion.autoSenTab = true;
            this.txtDireccion.AValidar = null;
            this.txtDireccion.CampoBusquedaID = "";
            this.txtDireccion.CampoData = "Direccion";
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColumnasBusqGeneral = null;
            this.txtDireccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDireccion.Decimales = 0;
            this.txtDireccion.DSData = this.DSDatos;
            this.txtDireccion.EsAutoGenerado = false;
            this.txtDireccion.EsBusqueda = false;
            this.txtDireccion.EsBusquedaAutoIncremental = false;
            this.txtDireccion.EsEditable = true;
            this.txtDireccion.FiltroBusqueda = "";
            this.txtDireccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDireccion.Location = new System.Drawing.Point(148, 93);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NombreTabla = "";
            this.txtDireccion.SepDecimal = '\0';
            this.txtDireccion.Size = new System.Drawing.Size(582, 55);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TablaOVistaBusqueda = "";
            this.txtDireccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDireccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDireccion.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Direccion..:";
            // 
            // btnBuscarSup
            // 
            this.btnBuscarSup.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnBuscarSup.Location = new System.Drawing.Point(303, 58);
            this.btnBuscarSup.Name = "btnBuscarSup";
            this.btnBuscarSup.Size = new System.Drawing.Size(46, 32);
            this.btnBuscarSup.TabIndex = 3;
            this.btnBuscarSup.UseVisualStyleBackColor = true;
            this.btnBuscarSup.Click += new System.EventHandler(this.btnBuscarSup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 127);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.autoSenTab = true;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Concepto";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(3, 25);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(819, 99);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTotalItbis);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSubTotal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(825, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 127);
            this.panel3.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.autoSenTab = true;
            this.txtMonto.AValidar = null;
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Total";
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColumnasBusqGeneral = null;
            this.txtMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMonto.Decimales = 0;
            this.txtMonto.DSData = this.DSDatos;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsBusquedaAutoIncremental = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(116, 88);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(172, 33);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Importe:";
            // 
            // txtTotalItbis
            // 
            this.txtTotalItbis.AMostrar = null;
            this.txtTotalItbis.autoSenTab = true;
            this.txtTotalItbis.AValidar = null;
            this.txtTotalItbis.BackColor = System.Drawing.Color.White;
            this.txtTotalItbis.CampoBusquedaID = "";
            this.txtTotalItbis.CampoData = "Itbis";
            this.txtTotalItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalItbis.ColumnasBusqGeneral = null;
            this.txtTotalItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotalItbis.Decimales = 0;
            this.txtTotalItbis.DSData = this.DSDatos;
            this.txtTotalItbis.EsAutoGenerado = false;
            this.txtTotalItbis.EsBusqueda = false;
            this.txtTotalItbis.EsBusquedaAutoIncremental = false;
            this.txtTotalItbis.EsEditable = true;
            this.txtTotalItbis.FiltroBusqueda = "";
            this.txtTotalItbis.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTotalItbis.Location = new System.Drawing.Point(116, 49);
            this.txtTotalItbis.Name = "txtTotalItbis";
            this.txtTotalItbis.NombreTabla = "";
            this.txtTotalItbis.ReadOnly = true;
            this.txtTotalItbis.SepDecimal = '\0';
            this.txtTotalItbis.Size = new System.Drawing.Size(172, 33);
            this.txtTotalItbis.TabIndex = 3;
            this.txtTotalItbis.TablaOVistaBusqueda = "";
            this.txtTotalItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotalItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotalItbis.ValorPorDefecto = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Itbis:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.AMostrar = null;
            this.txtSubTotal.autoSenTab = true;
            this.txtSubTotal.AValidar = null;
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.CampoBusquedaID = "";
            this.txtSubTotal.CampoData = "Sub_Total";
            this.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTotal.ColumnasBusqGeneral = null;
            this.txtSubTotal.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSubTotal.Decimales = 0;
            this.txtSubTotal.DSData = this.DSDatos;
            this.txtSubTotal.EsAutoGenerado = false;
            this.txtSubTotal.EsBusqueda = false;
            this.txtSubTotal.EsBusquedaAutoIncremental = false;
            this.txtSubTotal.EsEditable = true;
            this.txtSubTotal.FiltroBusqueda = "";
            this.txtSubTotal.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSubTotal.Location = new System.Drawing.Point(116, 10);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.NombreTabla = "";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.SepDecimal = '\0';
            this.txtSubTotal.Size = new System.Drawing.Size(172, 33);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.TablaOVistaBusqueda = "";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSubTotal.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSubTotal.ValorPorDefecto = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sub Total:";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Producto_Id,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Sub_Total,
            this.Itbis,
            this.Importe,
            this.Requisicion_Id,
            this.ItemNumero,
            this.Tasa_Itbis,
            this.btnBorrar});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 256);
            this.dtgDetalle.MultiSelect = false;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.RowTemplate.Height = 35;
            this.dtgDetalle.Size = new System.Drawing.Size(1127, 115);
            this.dtgDetalle.TabIndex = 0;
            this.dtgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalle_CellContentClick);
            this.dtgDetalle.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalle_RowValidated);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Producto_Id
            // 
            this.Producto_Id.DataPropertyName = "Producto_Id";
            this.Producto_Id.HeaderText = "Codigo";
            this.Producto_Id.Name = "Producto_Id";
            this.Producto_Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 120;
            // 
            // Sub_Total
            // 
            this.Sub_Total.DataPropertyName = "Sub_Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Sub_Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 130;
            // 
            // Itbis
            // 
            this.Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Itbis.DefaultCellStyle = dataGridViewCellStyle4;
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.ReadOnly = true;
            this.Itbis.Width = 120;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle5;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 130;
            // 
            // Requisicion_Id
            // 
            this.Requisicion_Id.DataPropertyName = "Requisicion_Id";
            this.Requisicion_Id.HeaderText = "Req_Id";
            this.Requisicion_Id.Name = "Requisicion_Id";
            this.Requisicion_Id.ReadOnly = true;
            this.Requisicion_Id.Visible = false;
            // 
            // ItemNumero
            // 
            this.ItemNumero.DataPropertyName = "ItemNumero";
            this.ItemNumero.HeaderText = "ItemNumero";
            this.ItemNumero.Name = "ItemNumero";
            this.ItemNumero.ReadOnly = true;
            this.ItemNumero.Visible = false;
            // 
            // Tasa_Itbis
            // 
            this.Tasa_Itbis.DataPropertyName = "Tasa_Itbis";
            this.Tasa_Itbis.HeaderText = "Tasa_Itbis";
            this.Tasa_Itbis.Name = "Tasa_Itbis";
            this.Tasa_Itbis.ReadOnly = true;
            this.Tasa_Itbis.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // btnAgregarReq
            // 
            this.btnAgregarReq.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarReq.Image = global::ELRCuentasPorPagar.Properties.Resources.add_property_26;
            this.btnAgregarReq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarReq.Location = new System.Drawing.Point(148, 0);
            this.btnAgregarReq.Name = "btnAgregarReq";
            this.btnAgregarReq.Size = new System.Drawing.Size(216, 56);
            this.btnAgregarReq.TabIndex = 2;
            this.btnAgregarReq.Text = "Agregar Requisicion";
            this.btnAgregarReq.UseVisualStyleBackColor = true;
            this.btnAgregarReq.Click += new System.EventHandler(this.btnAgregarReq_Click);
            // 
            // FormOrdComprasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigoSup;
            valida1.Mensaje = "Debe Indicar el Suplidor";
            valida1.NombreCampo = "Suplidor_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = null;
            valida2.Mensaje = "Debe Indicar un Concepto Valido";
            valida2.NombreCampo = "Concepto";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "10";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(1127, 558);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.EnEjecusion = true;
            this.EsConTemporal = true;
            this.Name = "FormOrdComprasR";
            this.NombreCampoID = "Unico";
            this.SPGraba = "SP_COMPRAS_GRABAR_ORDEN";
            this.TablaDetalle = "TTEMPORAL_CXP_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_CXP";
            this.TablaProducto = "VCATEGORIA_PRODUCTOS";
            this.Text = "REGISTRAR ORDEN DE COMPRA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrdComprasR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarSup;
        private WinControl_ELR_NET.ELRTextBox txtNombreSuplidor;
        private WinControl_ELR_NET.ELRTextBox txtCodigoSup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtTotalItbis;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtSubTotal;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtTelefono;
        private System.Windows.Forms.Label label14;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label13;
        private WinControl_ELR_NET.ELRTextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private WinControl_ELR_NET.ELRTextBox txtTasaCambio;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRCombobox cboMoneda;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRDatePicker elrDatePicker1;
        private System.Windows.Forms.Label label11;
        private WinControl_ELR_NET.ELRTextBox elrTextBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Button btnAgregarReq;
        private System.Windows.Forms.Panel panel5;
        private WinControl_ELR_NET.ELRTextBox txtCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblProdDescripcion;
        private WinControl_ELR_NET.ELRTextBox txtPrecio;
        private WinControl_ELR_NET.ELRTextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requisicion_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Itbis;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}