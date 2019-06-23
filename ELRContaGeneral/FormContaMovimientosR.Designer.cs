namespace ELRContaGeneral
{
    partial class FormContaMovimientosR
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
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCentroCosto = new System.Windows.Forms.Button();
            this.btnVerPanelDetalle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboTipoDocumento = new WinControl_ELR_NET.ELRCombobox();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.txtDocumentoNo = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubTransaccion = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransaccion = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAplicacion = new WinControl_ELR_NET.ELRTextBox();
            this.txtAsientoNo = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblTotalCredito = new System.Windows.Forms.Label();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Descripcion_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 539);
            this.pnBotones.Size = new System.Drawing.Size(1021, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(781, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(922, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(686, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(591, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCentroCosto);
            this.panel1.Controls.Add(this.btnVerPanelDetalle);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 157);
            this.panel1.TabIndex = 1;
            // 
            // btnCentroCosto
            // 
            this.btnCentroCosto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCentroCosto.Location = new System.Drawing.Point(210, 115);
            this.btnCentroCosto.Name = "btnCentroCosto";
            this.btnCentroCosto.Size = new System.Drawing.Size(156, 38);
            this.btnCentroCosto.TabIndex = 31;
            this.btnCentroCosto.Text = "C.Costo\\Oficina";
            this.btnCentroCosto.UseVisualStyleBackColor = true;
            this.btnCentroCosto.Click += new System.EventHandler(this.btnCentroCosto_Click);
            // 
            // btnVerPanelDetalle
            // 
            this.btnVerPanelDetalle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerPanelDetalle.Location = new System.Drawing.Point(0, 115);
            this.btnVerPanelDetalle.Name = "btnVerPanelDetalle";
            this.btnVerPanelDetalle.Size = new System.Drawing.Size(210, 38);
            this.btnVerPanelDetalle.TabIndex = 30;
            this.btnVerPanelDetalle.Text = "Agregar Detalle Ctrl + N";
            this.btnVerPanelDetalle.UseVisualStyleBackColor = true;
            this.btnVerPanelDetalle.Click += new System.EventHandler(this.btnVerPanelDetalle_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboTipoDocumento);
            this.panel5.Controls.Add(this.dtpFecha);
            this.panel5.Controls.Add(this.txtDocumentoNo);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(513, 115);
            this.panel5.TabIndex = 29;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.AValidar = null;
            this.cboTipoDocumento.CampoData = "Tipo_Movimiento";
            this.cboTipoDocumento.CampoJoinCombobox2 = "";
            this.cboTipoDocumento.ComboboxAFiltrar = null;
            this.cboTipoDocumento.DisplayMember = "Descripcion";
            this.cboTipoDocumento.DSData = this.DSDatos;
            this.cboTipoDocumento.EsEditable = true;
            this.cboTipoDocumento.FiltroBusqueda = "";
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(163, 42);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.NombreTabla = "";
            this.cboTipoDocumento.Size = new System.Drawing.Size(331, 29);
            this.cboTipoDocumento.SSQL = "";
            this.cboTipoDocumento.TabIndex = 13;
            this.cboTipoDocumento.TablaOVistaConsulta = "TCONTA_TIPO_MOVIMIENTOS";
            this.cboTipoDocumento.UsaDataGlobal = false;
            this.cboTipoDocumento.ValorPorDefecto = "ED";
            this.cboTipoDocumento.ValueMember = "Tipo_Id";
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(163, 7);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(331, 29);
            this.dtpFecha.TabIndex = 12;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 5, 18, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // txtDocumentoNo
            // 
            this.txtDocumentoNo.AMostrar = null;
            this.txtDocumentoNo.AValidar = null;
            this.txtDocumentoNo.CampoBusquedaID = "";
            this.txtDocumentoNo.CampoData = "Referencia";
            this.txtDocumentoNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumentoNo.ColumnasBusqGeneral = null;
            this.txtDocumentoNo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDocumentoNo.Decimales = 0;
            this.txtDocumentoNo.DSData = this.DSDatos;
            this.txtDocumentoNo.EsAutoGenerado = false;
            this.txtDocumentoNo.EsBusqueda = false;
            this.txtDocumentoNo.EsBusquedaAutoIncremental = false;
            this.txtDocumentoNo.EsEditable = true;
            this.txtDocumentoNo.FiltroBusqueda = "";
            this.txtDocumentoNo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDocumentoNo.Location = new System.Drawing.Point(163, 77);
            this.txtDocumentoNo.Name = "txtDocumentoNo";
            this.txtDocumentoNo.NombreTabla = "";
            this.txtDocumentoNo.SepDecimal = '\0';
            this.txtDocumentoNo.Size = new System.Drawing.Size(331, 29);
            this.txtDocumentoNo.TabIndex = 11;
            this.txtDocumentoNo.TablaOVistaBusqueda = "";
            this.txtDocumentoNo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDocumentoNo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDocumentoNo.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Documento No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtSubTransaccion);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtTransaccion);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtAplicacion);
            this.panel4.Controls.Add(this.txtAsientoNo);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(513, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 153);
            this.panel4.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sub Trans.:";
            // 
            // txtSubTransaccion
            // 
            this.txtSubTransaccion.AMostrar = null;
            this.txtSubTransaccion.AValidar = null;
            this.txtSubTransaccion.CampoBusquedaID = "";
            this.txtSubTransaccion.CampoData = "SubTransaccion_Nombre";
            this.txtSubTransaccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTransaccion.ColumnasBusqGeneral = null;
            this.txtSubTransaccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSubTransaccion.Decimales = 0;
            this.txtSubTransaccion.DSData = this.DSDatos;
            this.txtSubTransaccion.Enabled = false;
            this.txtSubTransaccion.EsAutoGenerado = false;
            this.txtSubTransaccion.EsBusqueda = false;
            this.txtSubTransaccion.EsBusquedaAutoIncremental = false;
            this.txtSubTransaccion.EsEditable = true;
            this.txtSubTransaccion.FiltroBusqueda = "";
            this.txtSubTransaccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSubTransaccion.Location = new System.Drawing.Point(122, 110);
            this.txtSubTransaccion.Name = "txtSubTransaccion";
            this.txtSubTransaccion.NombreTabla = "";
            this.txtSubTransaccion.SepDecimal = '\0';
            this.txtSubTransaccion.Size = new System.Drawing.Size(370, 29);
            this.txtSubTransaccion.TabIndex = 11;
            this.txtSubTransaccion.TablaOVistaBusqueda = "";
            this.txtSubTransaccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSubTransaccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSubTransaccion.ValorPorDefecto = "";
            this.txtSubTransaccion.Click += new System.EventHandler(this.txtConcepto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transacción:";
            // 
            // txtTransaccion
            // 
            this.txtTransaccion.AMostrar = null;
            this.txtTransaccion.AValidar = null;
            this.txtTransaccion.CampoBusquedaID = "";
            this.txtTransaccion.CampoData = "Transaccion_Nombre";
            this.txtTransaccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransaccion.ColumnasBusqGeneral = null;
            this.txtTransaccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTransaccion.Decimales = 0;
            this.txtTransaccion.DSData = this.DSDatos;
            this.txtTransaccion.Enabled = false;
            this.txtTransaccion.EsAutoGenerado = false;
            this.txtTransaccion.EsBusqueda = false;
            this.txtTransaccion.EsBusquedaAutoIncremental = false;
            this.txtTransaccion.EsEditable = true;
            this.txtTransaccion.FiltroBusqueda = "";
            this.txtTransaccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTransaccion.Location = new System.Drawing.Point(122, 77);
            this.txtTransaccion.Name = "txtTransaccion";
            this.txtTransaccion.NombreTabla = "";
            this.txtTransaccion.SepDecimal = '\0';
            this.txtTransaccion.Size = new System.Drawing.Size(370, 29);
            this.txtTransaccion.TabIndex = 9;
            this.txtTransaccion.TablaOVistaBusqueda = "";
            this.txtTransaccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTransaccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTransaccion.ValorPorDefecto = "";
            this.txtTransaccion.Click += new System.EventHandler(this.txtConcepto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aplicacion:";
            // 
            // txtAplicacion
            // 
            this.txtAplicacion.AMostrar = null;
            this.txtAplicacion.AValidar = null;
            this.txtAplicacion.CampoBusquedaID = "";
            this.txtAplicacion.CampoData = "Aplicacion_Nombre";
            this.txtAplicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAplicacion.ColumnasBusqGeneral = null;
            this.txtAplicacion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAplicacion.Decimales = 0;
            this.txtAplicacion.DSData = this.DSDatos;
            this.txtAplicacion.Enabled = false;
            this.txtAplicacion.EsAutoGenerado = false;
            this.txtAplicacion.EsBusqueda = false;
            this.txtAplicacion.EsBusquedaAutoIncremental = false;
            this.txtAplicacion.EsEditable = true;
            this.txtAplicacion.FiltroBusqueda = "";
            this.txtAplicacion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtAplicacion.Location = new System.Drawing.Point(123, 44);
            this.txtAplicacion.Name = "txtAplicacion";
            this.txtAplicacion.NombreTabla = "";
            this.txtAplicacion.SepDecimal = '\0';
            this.txtAplicacion.Size = new System.Drawing.Size(369, 29);
            this.txtAplicacion.TabIndex = 7;
            this.txtAplicacion.TablaOVistaBusqueda = "";
            this.txtAplicacion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAplicacion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAplicacion.ValorPorDefecto = "";
            this.txtAplicacion.Click += new System.EventHandler(this.txtConcepto_Click);
            // 
            // txtAsientoNo
            // 
            this.txtAsientoNo.AMostrar = null;
            this.txtAsientoNo.AValidar = null;
            this.txtAsientoNo.CampoBusquedaID = "";
            this.txtAsientoNo.CampoData = "Asiento_No";
            this.txtAsientoNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsientoNo.ColumnasBusqGeneral = null;
            this.txtAsientoNo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAsientoNo.Decimales = 0;
            this.txtAsientoNo.DSData = this.DSDatos;
            this.txtAsientoNo.Enabled = false;
            this.txtAsientoNo.EsAutoGenerado = false;
            this.txtAsientoNo.EsBusqueda = false;
            this.txtAsientoNo.EsBusquedaAutoIncremental = false;
            this.txtAsientoNo.EsEditable = true;
            this.txtAsientoNo.FiltroBusqueda = "";
            this.txtAsientoNo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtAsientoNo.Location = new System.Drawing.Point(122, 12);
            this.txtAsientoNo.Name = "txtAsientoNo";
            this.txtAsientoNo.NombreTabla = "";
            this.txtAsientoNo.SepDecimal = '\0';
            this.txtAsientoNo.Size = new System.Drawing.Size(105, 29);
            this.txtAsientoNo.TabIndex = 6;
            this.txtAsientoNo.TablaOVistaBusqueda = "";
            this.txtAsientoNo.Text = "000000";
            this.txtAsientoNo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAsientoNo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAsientoNo.ValorPorDefecto = "0";
            this.txtAsientoNo.Click += new System.EventHandler(this.txtConcepto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asiento No.:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 124);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
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
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(3, 25);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(676, 92);
            this.txtConcepto.TabIndex = 18;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblDiferencia);
            this.panel3.Controls.Add(this.lblTotalCredito);
            this.panel3.Controls.Add(this.lblTotalDebito);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(682, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 120);
            this.panel3.TabIndex = 0;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiferencia.Location = new System.Drawing.Point(143, 79);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(173, 28);
            this.lblDiferencia.TabIndex = 32;
            this.lblDiferencia.Text = "0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCredito
            // 
            this.lblTotalCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCredito.Location = new System.Drawing.Point(143, 45);
            this.lblTotalCredito.Name = "lblTotalCredito";
            this.lblTotalCredito.Size = new System.Drawing.Size(173, 28);
            this.lblTotalCredito.TabIndex = 31;
            this.lblTotalCredito.Text = "0.00";
            this.lblTotalCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDebito.Location = new System.Drawing.Point(143, 11);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(173, 28);
            this.lblTotalDebito.TabIndex = 30;
            this.lblTotalDebito.Text = "0.00";
            this.lblTotalDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "Diferencia:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Total Crédito:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Total Debito:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuenta_Contable,
            this.Codigo_Auxiliar,
            this.Descripcion,
            this.Debito,
            this.Credito,
            this.ItemNumero,
            this.btnBorrar,
            this.Descripcion_Cuenta});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 258);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.Visible = false;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cuenta Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 160;
            // 
            // Codigo_Auxiliar
            // 
            this.Codigo_Auxiliar.DataPropertyName = "Codigo_Auxiliar";
            this.Codigo_Auxiliar.HeaderText = "C.Costo\\Oficina";
            this.Codigo_Auxiliar.Name = "Codigo_Auxiliar";
            this.Codigo_Auxiliar.ReadOnly = true;
            this.Codigo_Auxiliar.Visible = false;
            this.Codigo_Auxiliar.Width = 130;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Debito
            // 
            this.Debito.DataPropertyName = "Debito";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Debito.DefaultCellStyle = dataGridViewCellStyle1;
            this.Debito.HeaderText = "Debito";
            this.Debito.Name = "Debito";
            this.Debito.Width = 130;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle2;
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.Width = 130;
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
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.HeaderText = "Eliminar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "Eiminar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // Descripcion_Cuenta
            // 
            this.Descripcion_Cuenta.DataPropertyName = "Descripcion_Cuenta";
            this.Descripcion_Cuenta.HeaderText = "Descripcion_Cuenta";
            this.Descripcion_Cuenta.Name = "Descripcion_Cuenta";
            this.Descripcion_Cuenta.Visible = false;
            // 
            // FormContaMovimientosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = null;
            valida1.Mensaje = "Debe Elegir Tipo de Documento";
            valida1.NombreCampo = "Tipo_Movimiento";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = null;
            valida2.Mensaje = "Debe Ingresar Documento o Referencia";
            valida2.NombreCampo = "Referencia";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = null;
            valida3.Mensaje = "Debe Ingresar un Concepto Valido";
            valida3.NombreCampo = "Concepto";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida3.Valor1 = "10";
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.CampoIdImprimir = "Asiento_Id";
            this.ClientSize = new System.Drawing.Size(1021, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.PreviewRDLC;
            this.ImprimirAlGrabar = true;
            this.Name = "FormContaMovimientosR";
            this.NombreReporte = "RptContaAsientoDiario";
            this.NombreVistaImprimir = "VCONTA_DIARIO_DETALLE";
            this.SPGraba = "SP_CONTA_GRABA_ASIENTO_MANUAL";
            this.TablaDetalle = "TTEMPORAL_CONTA_DIARIO_DETALLE";
            this.TablaEncabezado = "TTEMPORAL_CONTA_DIARIO";
            this.Text = "REGISTRAR MOVIMIENTO DE DIARIO";
            this.Load += new System.EventHandler(this.FormContaMovimientosR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtTransaccion;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtAplicacion;
        private WinControl_ELR_NET.ELRTextBox txtAsientoNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtSubTransaccion;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label lblTotalCredito;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Button btnCentroCosto;
        private System.Windows.Forms.Button btnVerPanelDetalle;
        private System.Windows.Forms.Panel panel5;
        private WinControl_ELR_NET.ELRCombobox cboTipoDocumento;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private WinControl_ELR_NET.ELRTextBox txtDocumentoNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumero;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Cuenta;
    }
}