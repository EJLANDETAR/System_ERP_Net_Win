namespace ELRCuentasPorPagar
{
    partial class FormRequisicionesR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTasaCambio = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMoneda = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreEmpleado = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.cboDepartamento = new WinControl_ELR_NET.ELRCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCantidad = new WinControl_ELR_NET.ELRTextBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblProdDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new WinControl_ELR_NET.ELRTextBox();
            this.dtpFechaRequerrida = new WinControl_ELR_NET.ELRDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UMedida_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 494);
            this.pnBotones.Size = new System.Drawing.Size(906, 61);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(637, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 57);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(778, 0);
            this.btnCancelar.Size = new System.Drawing.Size(124, 57);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(112, 57);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(516, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(121, 57);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(112, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(404, 57);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtTasaCambio);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cboMoneda);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNumero);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 49);
            this.panel4.TabIndex = 0;
            // 
            // txtTasaCambio
            // 
            this.txtTasaCambio.AMostrar = null;
            this.txtTasaCambio.autoSenTab = true;
            this.txtTasaCambio.AValidar = null;
            this.txtTasaCambio.BackColor = System.Drawing.Color.White;
            this.txtTasaCambio.CampoBusquedaID = "";
            this.txtTasaCambio.CampoData = "Tasa_Cambio";
            this.txtTasaCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaCambio.ColumnasBusqGeneral = null;
            this.txtTasaCambio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaCambio.Decimales = 0;
            this.txtTasaCambio.DSData = this.DSDatos;
            this.txtTasaCambio.Enabled = false;
            this.txtTasaCambio.EsAutoGenerado = false;
            this.txtTasaCambio.EsBusqueda = false;
            this.txtTasaCambio.EsBusquedaAutoIncremental = false;
            this.txtTasaCambio.EsEditable = true;
            this.txtTasaCambio.FiltroBusqueda = "";
            this.txtTasaCambio.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTasaCambio.Location = new System.Drawing.Point(659, 12);
            this.txtTasaCambio.Name = "txtTasaCambio";
            this.txtTasaCambio.NombreTabla = "";
            this.txtTasaCambio.SepDecimal = '\0';
            this.txtTasaCambio.Size = new System.Drawing.Size(93, 29);
            this.txtTasaCambio.TabIndex = 5;
            this.txtTasaCambio.TablaOVistaBusqueda = "";
            this.txtTasaCambio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaCambio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaCambio.ValorPorDefecto = "1.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(580, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cambio:";
            // 
            // cboMoneda
            // 
            this.cboMoneda.AValidar = null;
            this.cboMoneda.CampoData = "Moneda";
            this.cboMoneda.CampoJoinCombobox2 = "";
            this.cboMoneda.ComboboxAFiltrar = null;
            this.cboMoneda.DisplayMember = "Nombre";
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.DSData = this.DSDatos;
            this.cboMoneda.EsEditable = true;
            this.cboMoneda.FiltroBusqueda = "";
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(322, 13);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.NombreTabla = "";
            this.cboMoneda.Size = new System.Drawing.Size(235, 29);
            this.cboMoneda.SSQL = "";
            this.cboMoneda.TabIndex = 3;
            this.cboMoneda.TablaOVistaConsulta = "TSISTEMA_MONEDAS";
            this.cboMoneda.UsaDataGlobal = false;
            this.cboMoneda.ValorPorDefecto = "RD$";
            this.cboMoneda.ValueMember = "Codigo";
            this.cboMoneda.SelectedValueChanged += new System.EventHandler(this.cboMoneda_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moneda:";
            // 
            // txtNumero
            // 
            this.txtNumero.AMostrar = null;
            this.txtNumero.autoSenTab = true;
            this.txtNumero.AValidar = null;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.CampoBusquedaID = "";
            this.txtNumero.CampoData = "Numero";
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.ColumnasBusqGeneral = null;
            this.txtNumero.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumero.Decimales = 0;
            this.txtNumero.DSData = this.DSDatos;
            this.txtNumero.Enabled = false;
            this.txtNumero.EsAutoGenerado = false;
            this.txtNumero.EsBusqueda = false;
            this.txtNumero.EsBusquedaAutoIncremental = false;
            this.txtNumero.EsEditable = true;
            this.txtNumero.FiltroBusqueda = "";
            this.txtNumero.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNumero.Location = new System.Drawing.Point(95, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.NombreTabla = "";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.SepDecimal = '\0';
            this.txtNumero.Size = new System.Drawing.Size(125, 29);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TablaOVistaBusqueda = "";
            this.txtNumero.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumero.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumero.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.btnBuscarEmpleado);
            this.panel1.Controls.Add(this.cboDepartamento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCodigoEmpleado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dtpFechaRequerrida);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 175);
            this.panel1.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AMostrar = null;
            this.txtNombreEmpleado.autoSenTab = true;
            this.txtNombreEmpleado.AValidar = null;
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.White;
            this.txtNombreEmpleado.CampoBusquedaID = "";
            this.txtNombreEmpleado.CampoData = "Nombre";
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEmpleado.ColumnasBusqGeneral = null;
            this.txtNombreEmpleado.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreEmpleado.Decimales = 0;
            this.txtNombreEmpleado.DSData = this.DSDatos;
            this.txtNombreEmpleado.EsAutoGenerado = false;
            this.txtNombreEmpleado.EsBusqueda = false;
            this.txtNombreEmpleado.EsBusquedaAutoIncremental = false;
            this.txtNombreEmpleado.EsEditable = true;
            this.txtNombreEmpleado.FiltroBusqueda = "";
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(326, 17);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.NombreTabla = "";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.SepDecimal = '\0';
            this.txtNombreEmpleado.Size = new System.Drawing.Size(556, 29);
            this.txtNombreEmpleado.TabIndex = 3;
            this.txtNombreEmpleado.TablaOVistaBusqueda = "";
            this.txtNombreEmpleado.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreEmpleado.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreEmpleado.ValorPorDefecto = "";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(269, 17);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(51, 32);
            this.btnBuscarEmpleado.TabIndex = 2;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AValidar = null;
            this.cboDepartamento.CampoData = "Departamento_Id";
            this.cboDepartamento.CampoJoinCombobox2 = "";
            this.cboDepartamento.ComboboxAFiltrar = null;
            this.cboDepartamento.DisplayMember = "Nombre";
            this.cboDepartamento.DSData = this.DSDatos;
            this.cboDepartamento.EsEditable = true;
            this.cboDepartamento.FiltroBusqueda = "";
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(146, 52);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.NombreTabla = "";
            this.cboDepartamento.Size = new System.Drawing.Size(413, 29);
            this.cboDepartamento.SSQL = "";
            this.cboDepartamento.TabIndex = 5;
            this.cboDepartamento.TablaOVistaConsulta = "TRRHH_DEPARTAMENTOS";
            this.cboDepartamento.UsaDataGlobal = false;
            this.cboDepartamento.ValorPorDefecto = "0";
            this.cboDepartamento.ValueMember = "Departamento_Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamento:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.AMostrar = null;
            this.txtCodigoEmpleado.autoSenTab = true;
            this.txtCodigoEmpleado.AValidar = null;
            this.txtCodigoEmpleado.CampoBusquedaID = "";
            this.txtCodigoEmpleado.CampoData = "Empleado_Id";
            this.txtCodigoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEmpleado.ColumnasBusqGeneral = null;
            this.txtCodigoEmpleado.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoEmpleado.Decimales = 0;
            this.txtCodigoEmpleado.DSData = this.DSDatos;
            this.txtCodigoEmpleado.EsAutoGenerado = false;
            this.txtCodigoEmpleado.EsBusqueda = false;
            this.txtCodigoEmpleado.EsBusquedaAutoIncremental = false;
            this.txtCodigoEmpleado.EsEditable = true;
            this.txtCodigoEmpleado.FiltroBusqueda = "";
            this.txtCodigoEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpleado.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(146, 17);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.NombreTabla = "";
            this.txtCodigoEmpleado.SepDecimal = '\0';
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(117, 29);
            this.txtCodigoEmpleado.TabIndex = 1;
            this.txtCodigoEmpleado.TablaOVistaBusqueda = "";
            this.txtCodigoEmpleado.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoEmpleado.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoEmpleado.ValorPorDefecto = "";
            this.txtCodigoEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoEmpleado_KeyDown);
            this.txtCodigoEmpleado.Leave += new System.EventHandler(this.txtCodigoEmpleado_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Solicitado Por:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtCantidad);
            this.panel5.Controls.Add(this.btnAgregarItem);
            this.panel5.Controls.Add(this.lblNombreProducto);
            this.panel5.Controls.Add(this.lblProdDescripcion);
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtCodigoProducto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(906, 88);
            this.panel5.TabIndex = 8;
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
            this.txtCantidad.Location = new System.Drawing.Point(554, 6);
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
            this.btnAgregarItem.Location = new System.Drawing.Point(686, 4);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(143, 40);
            this.btnAgregarItem.TabIndex = 5;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(460, 9);
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
            this.lblProdDescripcion.Location = new System.Drawing.Point(0, 47);
            this.lblProdDescripcion.Name = "lblProdDescripcion";
            this.lblProdDescripcion.Size = new System.Drawing.Size(902, 37);
            this.lblProdDescripcion.TabIndex = 6;
            this.lblProdDescripcion.Text = "NOMBRE/DESCRIPCION ITEM VENTA";
            this.lblProdDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnAgregar.Location = new System.Drawing.Point(376, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(51, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto:";
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
            this.txtCodigoProducto.Location = new System.Drawing.Point(144, 9);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.NombreTabla = "";
            this.txtCodigoProducto.SepDecimal = '\0';
            this.txtCodigoProducto.Size = new System.Drawing.Size(226, 29);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.TablaOVistaBusqueda = "";
            this.txtCodigoProducto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoProducto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoProducto.ValorPorDefecto = "";
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // dtpFechaRequerrida
            // 
            this.dtpFechaRequerrida.AValidar = null;
            this.dtpFechaRequerrida.CampoData = "fecha_Requerida";
            this.dtpFechaRequerrida.DSData = this.DSDatos;
            this.dtpFechaRequerrida.EsEditable = true;
            this.dtpFechaRequerrida.FiltroBusqueda = "";
            this.dtpFechaRequerrida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRequerrida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRequerrida.Location = new System.Drawing.Point(722, 52);
            this.dtpFechaRequerrida.Name = "dtpFechaRequerrida";
            this.dtpFechaRequerrida.NombreTabla = "";
            this.dtpFechaRequerrida.Size = new System.Drawing.Size(160, 29);
            this.dtpFechaRequerrida.TabIndex = 7;
            this.dtpFechaRequerrida.ValorPorDefecto = new System.DateTime(2016, 8, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Requerida:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 127);
            this.panel2.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto\\Observaciones";
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
            this.txtConcepto.Size = new System.Drawing.Size(900, 99);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Producto_Id,
            this.Cantidad,
            this.UMedida_Id,
            this.Descripcion,
            this.ItemNumero,
            this.btnBorrar});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 224);
            this.dtgDetalle.MultiSelect = false;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.RowTemplate.Height = 35;
            this.dtgDetalle.Size = new System.Drawing.Size(906, 143);
            this.dtgDetalle.TabIndex = 2;
            this.dtgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalle_CellContentClick);
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
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // UMedida_Id
            // 
            this.UMedida_Id.DataPropertyName = "UMedida_Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UMedida_Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.UMedida_Id.HeaderText = "Unidad";
            this.UMedida_Id.Name = "UMedida_Id";
            this.UMedida_Id.ReadOnly = true;
            this.UMedida_Id.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ItemNumero
            // 
            this.ItemNumero.DataPropertyName = "ItemNumero";
            this.ItemNumero.HeaderText = "ItemNumero";
            this.ItemNumero.Name = "ItemNumero";
            this.ItemNumero.ReadOnly = true;
            this.ItemNumero.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // FormRequisicionesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            valida1.comtrol = null;
            valida1.Mensaje = "Debe Indicar un Concepto Valido";
            valida1.NombreCampo = "Concepto";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "10";
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(906, 555);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.EsConTemporal = true;
            this.Name = "FormRequisicionesR";
            this.NombreCampoID = "CXP_Id";
            this.SPGraba = "SP_COMPRAS_GRABA_REQUISICION";
            this.TablaDetalle = "TTEMPORAL_CXP_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_CXP";
            this.Text = "REGISTRAR REQUISICION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRequisicionesR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private WinControl_ELR_NET.ELRTextBox txtTasaCambio;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRCombobox cboMoneda;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRDatePicker dtpFechaRequerrida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UMedida_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private WinControl_ELR_NET.ELRTextBox txtNombreEmpleado;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private WinControl_ELR_NET.ELRCombobox cboDepartamento;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProdDescripcion;
        private WinControl_ELR_NET.ELRTextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label lblNombreProducto;
    }
}