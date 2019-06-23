namespace ELRFacturas
{
    partial class FormFactura
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
            WinControl_ELR_NET.MyColumna myColumna1 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna2 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna3 = new WinControl_ELR_NET.MyColumna();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            WinControl_ELR_NET.Totaliza totaliza1 = new WinControl_ELR_NET.Totaliza();
            WinControl_ELR_NET.Totaliza totaliza2 = new WinControl_ELR_NET.Totaliza();
            WinControl_ELR_NET.Totaliza totaliza3 = new WinControl_ELR_NET.Totaliza();
            WinControl_ELR_NET.Totaliza totaliza4 = new WinControl_ELR_NET.Totaliza();
            this.lblSubTotal = new WinControl_ELR_NET.ELRLabel();
            this.lblDescuento = new WinControl_ELR_NET.ELRLabel();
            this.lblItbis = new WinControl_ELR_NET.ELRLabel();
            this.lblTotal2 = new WinControl_ELR_NET.ELRLabel();
            this.lblNombreCliente = new WinControl_ELR_NET.ELRLabel();
            this.lblTipoNCF = new System.Windows.Forms.Label();
            this.lblAPagar = new WinControl_ELR_NET.ELRLabel();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarEntidad = new System.Windows.Forms.Button();
            this.lblCedulaRNC = new WinControl_ELR_NET.ELRLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new WinControl_ELR_NET.ELRTextBox();
            this.pnArticuloInsertar = new System.Windows.Forms.Panel();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new WinControl_ELR_NET.ELRTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMontoDevolucion = new System.Windows.Forms.Label();
            this.txtDevolucionNo = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvDetalle = new System.Windows.Forms.DataGridView();
            this.clnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAplicarDevolucion = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnArticuloInsertar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnAplicarDevolucion);
            this.pnBotones.Location = new System.Drawing.Point(0, 610);
            this.pnBotones.Size = new System.Drawing.Size(1162, 45);
            this.pnBotones.TabIndex = 4;
            this.pnBotones.Controls.SetChildIndex(this.lblNombreUsuario, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnGrabar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnSiguientePage, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAnterior, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAplicarDevolucion, 0);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(918, 0);
            this.btnGrabar.Size = new System.Drawing.Size(148, 41);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1066, 0);
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(53, 0);
            this.btnAnterior.Size = new System.Drawing.Size(95, 41);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(832, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(86, 41);
            this.btnSiguientePage.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(53, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(1105, 41);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.CampoData = "";
            this.lblSubTotal.DSData = null;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblSubTotal.Location = new System.Drawing.Point(158, 14);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.NombreTabla = "";
            this.lblSubTotal.Size = new System.Drawing.Size(176, 32);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubTotal.ValorPorDefecto = "";
            // 
            // lblDescuento
            // 
            this.lblDescuento.CampoData = "";
            this.lblDescuento.DSData = null;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDescuento.Location = new System.Drawing.Point(164, 46);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.NombreTabla = "";
            this.lblDescuento.Size = new System.Drawing.Size(170, 32);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "0.00";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescuento.ValorPorDefecto = "";
            // 
            // lblItbis
            // 
            this.lblItbis.CampoData = "";
            this.lblItbis.DSData = null;
            this.lblItbis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItbis.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblItbis.Location = new System.Drawing.Point(164, 76);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.NombreTabla = "";
            this.lblItbis.Size = new System.Drawing.Size(170, 32);
            this.lblItbis.TabIndex = 5;
            this.lblItbis.Text = "0.00";
            this.lblItbis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblItbis.ValorPorDefecto = "";
            // 
            // lblTotal2
            // 
            this.lblTotal2.CampoData = "";
            this.lblTotal2.DSData = null;
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTotal2.Location = new System.Drawing.Point(164, 105);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.NombreTabla = "";
            this.lblTotal2.Size = new System.Drawing.Size(170, 32);
            this.lblTotal2.TabIndex = 7;
            this.lblTotal2.Text = "0.00";
            this.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal2.ValorPorDefecto = "";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.CampoData = "Nombre";
            this.lblNombreCliente.DSData = this.DSDatos;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(195, 51);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.NombreTabla = "";
            this.lblNombreCliente.Size = new System.Drawing.Size(235, 30);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "NOMBRE DEL CLIENTE";
            this.lblNombreCliente.ValorPorDefecto = "NOMBRE DEL CLIENTE";
            // 
            // lblTipoNCF
            // 
            this.lblTipoNCF.AutoSize = true;
            this.lblTipoNCF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoNCF.Location = new System.Drawing.Point(9, 78);
            this.lblTipoNCF.Name = "lblTipoNCF";
            this.lblTipoNCF.Size = new System.Drawing.Size(332, 30);
            this.lblTipoNCF.TabIndex = 3;
            this.lblTipoNCF.Text = "TIPO NCF: CONSUMIDOR FINAL";
            // 
            // lblAPagar
            // 
            this.lblAPagar.BackColor = System.Drawing.Color.Black;
            this.lblAPagar.CampoData = "";
            this.lblAPagar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAPagar.DSData = null;
            this.lblAPagar.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPagar.ForeColor = System.Drawing.Color.Lime;
            this.lblAPagar.Location = new System.Drawing.Point(772, 0);
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.NombreTabla = "";
            this.lblAPagar.Size = new System.Drawing.Size(386, 113);
            this.lblAPagar.TabIndex = 5;
            this.lblAPagar.Text = "0.00";
            this.lblAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAPagar.ValorPorDefecto = "";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.BackColor = System.Drawing.Color.MediumBlue;
            this.lblNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(1162, 39);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "MUEBLERIA HERMANOS  XYZ";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBuscarEntidad);
            this.panel1.Controls.Add(this.lblCedulaRNC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodigoCliente);
            this.panel1.Controls.Add(this.lblAPagar);
            this.panel1.Controls.Add(this.lblNombreCliente);
            this.panel1.Controls.Add(this.lblTipoNCF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 117);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscarEntidad
            // 
            this.btnBuscarEntidad.Image = global::ELRFacturas.Properties.Resources._1378160672_search;
            this.btnBuscarEntidad.Location = new System.Drawing.Point(363, 9);
            this.btnBuscarEntidad.Name = "btnBuscarEntidad";
            this.btnBuscarEntidad.Size = new System.Drawing.Size(67, 39);
            this.btnBuscarEntidad.TabIndex = 9;
            this.btnBuscarEntidad.UseVisualStyleBackColor = true;
            this.btnBuscarEntidad.Click += new System.EventHandler(this.btnBuscarEntidad_Click);
            // 
            // lblCedulaRNC
            // 
            this.lblCedulaRNC.AutoSize = true;
            this.lblCedulaRNC.CampoData = "CedulaRNC";
            this.lblCedulaRNC.DSData = this.DSDatos;
            this.lblCedulaRNC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaRNC.Location = new System.Drawing.Point(9, 49);
            this.lblCedulaRNC.Name = "lblCedulaRNC";
            this.lblCedulaRNC.NombreTabla = "";
            this.lblCedulaRNC.Size = new System.Drawing.Size(161, 30);
            this.lblCedulaRNC.TabIndex = 6;
            this.lblCedulaRNC.Text = "000-0000000-0";
            this.lblCedulaRNC.ValorPorDefecto = "NOMBRE DEL CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente No.:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.AMostrar = new WinControl_ELR_NET.ControlesMostrar[0];
            this.txtCodigoCliente.autoSenTab = true;
            this.txtCodigoCliente.AValidar = null;
            this.txtCodigoCliente.CampoBusquedaID = "";
            this.txtCodigoCliente.CampoData = "Entidad_Id";
            this.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCliente.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[0];
            this.txtCodigoCliente.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoCliente.Decimales = 0;
            this.txtCodigoCliente.DSData = this.DSDatos;
            this.txtCodigoCliente.EsAutoGenerado = false;
            this.txtCodigoCliente.EsBusqueda = false;
            this.txtCodigoCliente.EsBusquedaAutoIncremental = false;
            this.txtCodigoCliente.EsEditable = true;
            this.txtCodigoCliente.FiltroBusqueda = "EsActivo = 1";
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoCliente.Location = new System.Drawing.Point(148, 9);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.NombreTabla = "";
            this.txtCodigoCliente.SepDecimal = '\0';
            this.txtCodigoCliente.Size = new System.Drawing.Size(209, 35);
            this.txtCodigoCliente.TabIndex = 1;
            this.txtCodigoCliente.TablaOVistaBusqueda = "VENTIDADES";
            this.txtCodigoCliente.Text = "000000";
            this.txtCodigoCliente.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoCliente.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoCliente.ValorPorDefecto = "1";
            this.txtCodigoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCliente_KeyDown);
            this.txtCodigoCliente.Leave += new System.EventHandler(this.txtCodigoCliente_Leave);
            // 
            // pnArticuloInsertar
            // 
            this.pnArticuloInsertar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnArticuloInsertar.Controls.Add(this.lblMensajeError);
            this.pnArticuloInsertar.Controls.Add(this.btnBuscarProducto);
            this.pnArticuloInsertar.Controls.Add(this.label5);
            this.pnArticuloInsertar.Controls.Add(this.txtCantidad);
            this.pnArticuloInsertar.Controls.Add(this.lblNombreProducto);
            this.pnArticuloInsertar.Controls.Add(this.txtBusquedaProducto);
            this.pnArticuloInsertar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnArticuloInsertar.Location = new System.Drawing.Point(0, 156);
            this.pnArticuloInsertar.Name = "pnArticuloInsertar";
            this.pnArticuloInsertar.Size = new System.Drawing.Size(1162, 64);
            this.pnArticuloInsertar.TabIndex = 2;
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.BackColor = System.Drawing.Color.Red;
            this.lblMensajeError.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMensajeError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.White;
            this.lblMensajeError.Location = new System.Drawing.Point(692, 0);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(466, 60);
            this.lblMensajeError.TabIndex = 6;
            this.lblMensajeError.Text = "label2";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Visible = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(600, 15);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(86, 35);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(70, 13);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 31);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(3, 11);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(61, 30);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Cant.";
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProducto.Location = new System.Drawing.Point(325, 15);
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(269, 31);
            this.txtBusquedaProducto.TabIndex = 3;
            this.txtBusquedaProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaProducto_KeyDown);
            this.txtBusquedaProducto.Leave += new System.EventHandler(this.txtBusquedaProducto_Leave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 147);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar A:";
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
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDireccion.DSData = this.DSDatos;
            this.txtDireccion.EsAutoGenerado = false;
            this.txtDireccion.EsBusqueda = false;
            this.txtDireccion.EsBusquedaAutoIncremental = false;
            this.txtDireccion.EsEditable = true;
            this.txtDireccion.FiltroBusqueda = "";
            this.txtDireccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDireccion.Location = new System.Drawing.Point(3, 25);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NombreTabla = "";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDireccion.SepDecimal = '\0';
            this.txtDireccion.Size = new System.Drawing.Size(792, 69);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TablaOVistaBusqueda = "";
            this.txtDireccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDireccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDireccion.ValorPorDefecto = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblMontoDevolucion);
            this.panel3.Controls.Add(this.txtDevolucionNo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 46);
            this.panel3.TabIndex = 0;
            // 
            // lblMontoDevolucion
            // 
            this.lblMontoDevolucion.AutoSize = true;
            this.lblMontoDevolucion.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDevolucion.Location = new System.Drawing.Point(292, 9);
            this.lblMontoDevolucion.Name = "lblMontoDevolucion";
            this.lblMontoDevolucion.Size = new System.Drawing.Size(50, 25);
            this.lblMontoDevolucion.TabIndex = 5;
            this.lblMontoDevolucion.Text = "0.00";
            // 
            // txtDevolucionNo
            // 
            controlesMostrar1.ComboBoxControl = null;
            controlesMostrar1.EsHabilitar = false;
            controlesMostrar1.Formato = "";
            controlesMostrar1.LabelControl = null;
            controlesMostrar1.NombreCampo = "Nombre_Completo";
            controlesMostrar1.NumericUpDownControl = null;
            controlesMostrar1.TextBoxControl = null;
            controlesMostrar1.ValorPorDefecto = "(USUARIO CAJA)";
            this.txtDevolucionNo.AMostrar = new WinControl_ELR_NET.ControlesMostrar[] {
        controlesMostrar1};
            this.txtDevolucionNo.autoSenTab = true;
            this.txtDevolucionNo.AValidar = null;
            this.txtDevolucionNo.CampoBusquedaID = "Empleado_Id";
            this.txtDevolucionNo.CampoData = "Nota_Credito_No";
            this.txtDevolucionNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            myColumna1.Ancho = 85;
            myColumna1.Formato = "";
            myColumna1.HeaderText = "Codigo";
            myColumna1.NombreCampo = "Empleado_Id";
            myColumna2.Ancho = 135;
            myColumna2.Formato = "";
            myColumna2.HeaderText = "CedulaRNC";
            myColumna2.NombreCampo = "CedulaRNC";
            myColumna3.Ancho = 300;
            myColumna3.Formato = "";
            myColumna3.HeaderText = "Nombre";
            myColumna3.NombreCampo = "Nombre_Completo";
            this.txtDevolucionNo.ColumnasBusqGeneral = new WinControl_ELR_NET.MyColumna[] {
        myColumna1,
        myColumna2,
        myColumna3};
            this.txtDevolucionNo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDevolucionNo.Decimales = 0;
            this.txtDevolucionNo.DSData = this.DSDatos;
            this.txtDevolucionNo.Enabled = false;
            this.txtDevolucionNo.EsAutoGenerado = false;
            this.txtDevolucionNo.EsBusqueda = true;
            this.txtDevolucionNo.EsBusquedaAutoIncremental = false;
            this.txtDevolucionNo.EsEditable = true;
            this.txtDevolucionNo.FiltroBusqueda = "EsActivo = 1 And EsVendedor = 1";
            this.txtDevolucionNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolucionNo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDevolucionNo.Location = new System.Drawing.Point(167, 5);
            this.txtDevolucionNo.Name = "txtDevolucionNo";
            this.txtDevolucionNo.NombreTabla = "";
            this.txtDevolucionNo.SepDecimal = '\0';
            this.txtDevolucionNo.Size = new System.Drawing.Size(107, 29);
            this.txtDevolucionNo.TabIndex = 4;
            this.txtDevolucionNo.TablaOVistaBusqueda = "VVENDEDORES";
            this.txtDevolucionNo.Text = "0";
            this.txtDevolucionNo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDevolucionNo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDevolucionNo.ValorPorDefecto = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Devolucion No.:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.lblTotal2);
            this.panel5.Controls.Add(this.lblItbis);
            this.panel5.Controls.Add(this.lblDescuento);
            this.panel5.Controls.Add(this.lblSubTotal);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(798, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 143);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(84, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Yellow;
            this.label17.Location = new System.Drawing.Point(95, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 29);
            this.label17.TabIndex = 4;
            this.label17.Text = "Itbis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sub Total";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(503, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha ";
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.AllowUserToAddRows = false;
            this.dtgvDetalle.AllowUserToDeleteRows = false;
            this.dtgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnEliminar,
            this.ItemNumero,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Itbis,
            this.Monto});
            this.dtgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDetalle.Location = new System.Drawing.Point(0, 220);
            this.dtgvDetalle.MultiSelect = false;
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.ReadOnly = true;
            this.dtgvDetalle.RowHeadersWidth = 25;
            this.dtgvDetalle.RowTemplate.Height = 35;
            this.dtgvDetalle.Size = new System.Drawing.Size(1162, 243);
            this.dtgvDetalle.TabIndex = 3;
            this.dtgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetalle_CellContentClick);
            this.dtgvDetalle.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetalle_RowValidated);
            this.dtgvDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvDetalle_KeyDown);
            // 
            // clnEliminar
            // 
            this.clnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clnEliminar.HeaderText = "Borrar";
            this.clnEliminar.Name = "clnEliminar";
            this.clnEliminar.ReadOnly = true;
            this.clnEliminar.Text = "Borrar";
            this.clnEliminar.ToolTipText = "(-)";
            this.clnEliminar.UseColumnTextForButtonValue = true;
            this.clnEliminar.Width = 85;
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
            this.Precio.Width = 120;
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
            this.Monto.Width = 130;
            // 
            // btnAplicarDevolucion
            // 
            this.btnAplicarDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAplicarDevolucion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAplicarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnAplicarDevolucion.Location = new System.Drawing.Point(148, 0);
            this.btnAplicarDevolucion.Name = "btnAplicarDevolucion";
            this.btnAplicarDevolucion.Size = new System.Drawing.Size(235, 41);
            this.btnAplicarDevolucion.TabIndex = 7;
            this.btnAplicarDevolucion.Text = "Aplicar Nota Credito";
            this.btnAplicarDevolucion.UseVisualStyleBackColor = false;
            this.btnAplicarDevolucion.Click += new System.EventHandler(this.btnAplicarDevolucion_Click);
            // 
            // FormFactura
            // 
            totaliza1.controlLabel = this.lblSubTotal;
            totaliza1.filtro = "ItemNumero > 0";
            totaliza1.Formato = "N2";
            totaliza1.NombreCampoDet = "Sub_Total";
            totaliza1.NombreCampoEnc = "Sub_Total";
            totaliza1.operacion = WinControl_ELR_NET.tbTipoTotaliza.Sum;
            totaliza1.Redondeo = 2;
            totaliza2.controlLabel = this.lblDescuento;
            totaliza2.filtro = "ItemNumero > 0";
            totaliza2.Formato = "N2";
            totaliza2.NombreCampoDet = "Descuento";
            totaliza2.NombreCampoEnc = "Descuento";
            totaliza2.operacion = WinControl_ELR_NET.tbTipoTotaliza.Sum;
            totaliza2.Redondeo = 2;
            totaliza3.controlLabel = this.lblItbis;
            totaliza3.filtro = "ItemNumero > 0";
            totaliza3.Formato = "N2";
            totaliza3.NombreCampoDet = "Itbis";
            totaliza3.NombreCampoEnc = "Itbis";
            totaliza3.operacion = WinControl_ELR_NET.tbTipoTotaliza.Sum;
            totaliza3.Redondeo = 2;
            totaliza4.controlLabel = this.lblTotal2;
            totaliza4.filtro = "ItemNumero > 0";
            totaliza4.Formato = "N2";
            totaliza4.NombreCampoDet = "Monto";
            totaliza4.NombreCampoEnc = "Monto";
            totaliza4.operacion = WinControl_ELR_NET.tbTipoTotaliza.Sum;
            totaliza4.Redondeo = 2;
            this.ATotalizar = new WinControl_ELR_NET.Totaliza[] {
        totaliza1,
        totaliza2,
        totaliza3,
        totaliza4};
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 655);
            this.CodigoOperacion = 100;
            this.Controls.Add(this.dtgvDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnArticuloInsertar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgvDetalle;
            this.EsAgregarLineaVacia = false;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.Ticket;
            this.ImprimirAlGrabar = true;
            this.MostrarDesglosePago = true;
            this.Name = "FormFactura";
            this.NombreCampoID = "Identificador_Id";
            this.NombreReporte = "rptFactura";
            this.NombreVistaImprimir = "VVENTAS_DETALLE";
            this.NuevoRegistroAlGrabar = true;
            this.RequiereCajaAbierta = true;
            this.RequiereCliente = true;
            this.SPCargaATemporal = "SP_VENTAS_CARGAR_A_TEMPORAL";
            this.SPGraba = "SP_VENTAS_GRABA_FACTURA";
            this.TablaDetalle = "TTEMPORAL_VENTAS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_VENTAS";
            this.Text = "REGISTRAR FACTURA";
            this.Activated += new System.EventHandler(this.FormFactura_Activated);
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.lblNombreEmpresa, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnArticuloInsertar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgvDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnArticuloInsertar.ResumeLayout(false);
            this.pnArticuloInsertar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoNCF;
        public System.Windows.Forms.Panel pnArticuloInsertar;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRLabel lblNombreCliente;
        private System.Windows.Forms.DataGridView dtgvDetalle;
        private WinControl_ELR_NET.ELRLabel lblAPagar;
        private WinControl_ELR_NET.ELRLabel lblTotal2;
        private WinControl_ELR_NET.ELRLabel lblItbis;
        private WinControl_ELR_NET.ELRLabel lblDescuento;
        private WinControl_ELR_NET.ELRLabel lblSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel3;
        private WinControl_ELR_NET.ELRTextBox txtCodigoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicarDevolucion;
        private System.Windows.Forms.Label lblMontoDevolucion;
        private WinControl_ELR_NET.ELRTextBox txtDevolucionNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn clnEliminar;
        private System.Windows.Forms.DataGridViewLinkColumn ItemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private WinControl_ELR_NET.ELRLabel lblCedulaRNC;
        private System.Windows.Forms.Button btnBuscarEntidad;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtDireccion;
    }
}