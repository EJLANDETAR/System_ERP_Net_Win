namespace ELRCuentasPorPagar
{
    partial class FormNotaCreditoACompraR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida6 = new WinControl_ELR_NET.Valida();
            this.txtNCF = new WinControl_ELR_NET.ELRTextBox();
            this.txtDocumentoNO = new WinControl_ELR_NET.ELRTextBox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.txtItbis = new WinControl_ELR_NET.ELRTextBox();
            this.txtSubTotal = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMontoPendiente = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblSuplidor = new System.Windows.Forms.Label();
            this.lblNCFModificar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.elrLabel6 = new WinControl_ELR_NET.ELRLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elrLabel5 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel4 = new WinControl_ELR_NET.ELRLabel();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 539);
            this.pnBotones.Size = new System.Drawing.Size(876, 51);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(609, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(750, 0);
            this.btnCancelar.Size = new System.Drawing.Size(122, 47);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(514, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(419, 47);
            // 
            // txtNCF
            // 
            this.txtNCF.AMostrar = null;
            this.txtNCF.autoSenTab = true;
            this.txtNCF.AValidar = null;
            this.txtNCF.CampoBusquedaID = "";
            this.txtNCF.CampoData = "NCF";
            this.txtNCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNCF.ColumnasBusqGeneral = null;
            this.txtNCF.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNCF.Decimales = 0;
            this.txtNCF.DSData = this.DSDatos;
            this.txtNCF.EsAutoGenerado = false;
            this.txtNCF.EsBusqueda = false;
            this.txtNCF.EsBusquedaAutoIncremental = false;
            this.txtNCF.EsEditable = true;
            this.txtNCF.FiltroBusqueda = "";
            this.txtNCF.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNCF.Location = new System.Drawing.Point(95, 16);
            this.txtNCF.Name = "txtNCF";
            this.txtNCF.NombreTabla = "";
            this.txtNCF.SepDecimal = '\0';
            this.txtNCF.Size = new System.Drawing.Size(245, 35);
            this.txtNCF.TabIndex = 7;
            this.txtNCF.TablaOVistaBusqueda = "";
            this.txtNCF.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNCF.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNCF.ValorPorDefecto = "";
            // 
            // txtDocumentoNO
            // 
            this.txtDocumentoNO.AMostrar = null;
            this.txtDocumentoNO.autoSenTab = true;
            this.txtDocumentoNO.AValidar = null;
            this.txtDocumentoNO.CampoBusquedaID = "";
            this.txtDocumentoNO.CampoData = "Factura_Numero";
            this.txtDocumentoNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumentoNO.ColumnasBusqGeneral = null;
            this.txtDocumentoNO.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDocumentoNO.Decimales = 0;
            this.txtDocumentoNO.DSData = this.DSDatos;
            this.txtDocumentoNO.EsAutoGenerado = false;
            this.txtDocumentoNO.EsBusqueda = false;
            this.txtDocumentoNO.EsBusquedaAutoIncremental = false;
            this.txtDocumentoNO.EsEditable = true;
            this.txtDocumentoNO.FiltroBusqueda = "";
            this.txtDocumentoNO.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDocumentoNO.Location = new System.Drawing.Point(20, 154);
            this.txtDocumentoNO.Name = "txtDocumentoNO";
            this.txtDocumentoNO.NombreTabla = "";
            this.txtDocumentoNO.SepDecimal = '\0';
            this.txtDocumentoNO.Size = new System.Drawing.Size(320, 35);
            this.txtDocumentoNO.TabIndex = 12;
            this.txtDocumentoNO.TablaOVistaBusqueda = "";
            this.txtDocumentoNO.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDocumentoNO.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDocumentoNO.ValorPorDefecto = "";
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
            this.txtMonto.Enabled = false;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsBusquedaAutoIncremental = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(158, 16);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(245, 39);
            this.txtMonto.TabIndex = 24;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.Text = "999,999,999.99";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "";
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // txtItbis
            // 
            this.txtItbis.AMostrar = null;
            this.txtItbis.autoSenTab = true;
            this.txtItbis.AValidar = null;
            this.txtItbis.BackColor = System.Drawing.Color.White;
            this.txtItbis.CampoBusquedaID = "";
            this.txtItbis.CampoData = "Itbis";
            this.txtItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItbis.ColumnasBusqGeneral = null;
            this.txtItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtItbis.Decimales = 0;
            this.txtItbis.DSData = this.DSDatos;
            this.txtItbis.Enabled = false;
            this.txtItbis.EsAutoGenerado = false;
            this.txtItbis.EsBusqueda = false;
            this.txtItbis.EsBusquedaAutoIncremental = false;
            this.txtItbis.EsEditable = true;
            this.txtItbis.FiltroBusqueda = "";
            this.txtItbis.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtItbis.Location = new System.Drawing.Point(157, 64);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.NombreTabla = "";
            this.txtItbis.SepDecimal = '\0';
            this.txtItbis.Size = new System.Drawing.Size(245, 39);
            this.txtItbis.TabIndex = 22;
            this.txtItbis.TablaOVistaBusqueda = "";
            this.txtItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtItbis.ValorPorDefecto = "";
            this.txtItbis.Leave += new System.EventHandler(this.txtMonto_Leave);
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
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.EsAutoGenerado = false;
            this.txtSubTotal.EsBusqueda = false;
            this.txtSubTotal.EsBusquedaAutoIncremental = false;
            this.txtSubTotal.EsEditable = true;
            this.txtSubTotal.FiltroBusqueda = "";
            this.txtSubTotal.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSubTotal.Location = new System.Drawing.Point(158, 115);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.NombreTabla = "";
            this.txtSubTotal.SepDecimal = '\0';
            this.txtSubTotal.Size = new System.Drawing.Size(245, 39);
            this.txtSubTotal.TabIndex = 21;
            this.txtSubTotal.TablaOVistaBusqueda = "";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSubTotal.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSubTotal.ValorPorDefecto = "";
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
            this.txtConcepto.Location = new System.Drawing.Point(3, 29);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(866, 91);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblMontoPendiente);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.lblSuplidor);
            this.panel1.Controls.Add(this.lblNCFModificar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 223);
            this.panel1.TabIndex = 1;
            // 
            // lblMontoPendiente
            // 
            this.lblMontoPendiente.AutoSize = true;
            this.lblMontoPendiente.Location = new System.Drawing.Point(15, 174);
            this.lblMontoPendiente.Name = "lblMontoPendiente";
            this.lblMontoPendiente.Size = new System.Drawing.Size(355, 25);
            this.lblMontoPendiente.TabIndex = 4;
            this.lblMontoPendiente.Text = "MONTO PENDIENTE POR PAGAR:  0.00";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(15, 139);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(506, 25);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "MONTO TOTAL:  0.00                                      ITBIS:  0.00    ";
            // 
            // lblSuplidor
            // 
            this.lblSuplidor.AutoSize = true;
            this.lblSuplidor.Location = new System.Drawing.Point(15, 100);
            this.lblSuplidor.Name = "lblSuplidor";
            this.lblSuplidor.Size = new System.Drawing.Size(626, 25);
            this.lblSuplidor.TabIndex = 2;
            this.lblSuplidor.Text = "SUPLIDOR:  000-00000000-0      NOMBRE COMPLETO  DEL SUPLIDOR";
            // 
            // lblNCFModificar
            // 
            this.lblNCFModificar.AutoSize = true;
            this.lblNCFModificar.Location = new System.Drawing.Point(15, 66);
            this.lblNCFModificar.Name = "lblNCFModificar";
            this.lblNCFModificar.Size = new System.Drawing.Size(626, 25);
            this.lblNCFModificar.TabIndex = 1;
            this.lblNCFModificar.Text = "FACTURA NO.:  0000000000             NCF A MODIFICAR:  B0100000000";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(302, 43);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar NCF/Factura a Afectar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtDocumentoNO);
            this.panel2.Controls.Add(this.elrLabel6);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.elrLabel5);
            this.panel2.Controls.Add(this.txtNCF);
            this.panel2.Controls.Add(this.elrLabel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 316);
            this.panel2.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "Factura_Fecha";
            this.dtpFecha.DSData = this.DSDatos;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(95, 68);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(245, 35);
            this.dtpFecha.TabIndex = 20;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2018, 7, 21, 0, 0, 0, 0);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.txtMonto);
            this.panel5.Controls.Add(this.elrLabel3);
            this.panel5.Controls.Add(this.txtItbis);
            this.panel5.Controls.Add(this.txtSubTotal);
            this.panel5.Controls.Add(this.elrLabel2);
            this.panel5.Controls.Add(this.elrLabel1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(451, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(421, 189);
            this.panel5.TabIndex = 19;
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "";
            this.elrLabel3.DSData = null;
            this.elrLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.elrLabel3.Location = new System.Drawing.Point(16, 113);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(128, 32);
            this.elrLabel3.TabIndex = 23;
            this.elrLabel3.Text = "Sub Total:";
            this.elrLabel3.ValorPorDefecto = "";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.elrLabel2.Location = new System.Drawing.Point(72, 62);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(72, 32);
            this.elrLabel2.TabIndex = 20;
            this.elrLabel2.Text = "Itbis:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.elrLabel1.Location = new System.Drawing.Point(45, 14);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(99, 32);
            this.elrLabel1.TabIndex = 19;
            this.elrLabel1.Text = "Monto:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(564, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha ";
            // 
            // elrLabel6
            // 
            this.elrLabel6.AutoSize = true;
            this.elrLabel6.CampoData = "";
            this.elrLabel6.DSData = null;
            this.elrLabel6.Location = new System.Drawing.Point(15, 115);
            this.elrLabel6.Name = "elrLabel6";
            this.elrLabel6.NombreTabla = "";
            this.elrLabel6.Size = new System.Drawing.Size(176, 30);
            this.elrLabel6.TabIndex = 11;
            this.elrLabel6.Text = "Documento No.:";
            this.elrLabel6.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // elrLabel5
            // 
            this.elrLabel5.AutoSize = true;
            this.elrLabel5.CampoData = "";
            this.elrLabel5.DSData = null;
            this.elrLabel5.Location = new System.Drawing.Point(15, 64);
            this.elrLabel5.Name = "elrLabel5";
            this.elrLabel5.NombreTabla = "";
            this.elrLabel5.Size = new System.Drawing.Size(75, 30);
            this.elrLabel5.TabIndex = 8;
            this.elrLabel5.Text = "Fecha:";
            this.elrLabel5.ValorPorDefecto = "";
            // 
            // elrLabel4
            // 
            this.elrLabel4.AutoSize = true;
            this.elrLabel4.CampoData = "";
            this.elrLabel4.DSData = null;
            this.elrLabel4.Location = new System.Drawing.Point(23, 16);
            this.elrLabel4.Name = "elrLabel4";
            this.elrLabel4.NombreTabla = "";
            this.elrLabel4.Size = new System.Drawing.Size(60, 30);
            this.elrLabel4.TabIndex = 6;
            this.elrLabel4.Text = "NCF:";
            this.elrLabel4.ValorPorDefecto = "";
            // 
            // FormNotaCreditoACompraR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNCF;
            valida1.Mensaje = "Debe indicar un NCF Valido";
            valida1.NombreCampo = "NCF";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "11";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtDocumentoNO;
            valida2.Mensaje = "Debe indicar un numero de documento";
            valida2.NombreCampo = "Factura_Numero";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "3";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtMonto;
            valida3.Mensaje = "Debe indicar un monto valido";
            valida3.NombreCampo = "Total";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtItbis;
            valida4.Mensaje = "El itbis no puede ser menor a cero";
            valida4.NombreCampo = "Itbis";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida4.Valor1 = "0";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtSubTotal;
            valida5.Mensaje = "El sub total no puede ser menor a cero";
            valida5.NombreCampo = "Sub_Total";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida5.Valor1 = "0";
            valida5.Valor2 = null;
            valida6.comtrol = this.txtConcepto;
            valida6.Mensaje = "Debe indicar un concepto valido";
            valida6.NombreCampo = "Concepto";
            valida6.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida6.Valor1 = "10";
            valida6.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5,
        valida6};
            this.ClientSize = new System.Drawing.Size(876, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.Name = "FormNotaCreditoACompraR";
            this.NombreCampoID = "CXP_Id";
            this.SPGraba = "SP_COMPRA_GRABAR_NOTA_CREDITO";
            this.TablaEncabezado = "TTEMPORAL_CXP";
            this.Text = "REGISTRAR NOTA DE CREDITO A FACTURA DE COMPRA";
            this.Load += new System.EventHandler(this.FormNotaCreditoACompraR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMontoPendiente;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblSuplidor;
        private System.Windows.Forms.Label lblNCFModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRTextBox txtDocumentoNO;
        private WinControl_ELR_NET.ELRLabel elrLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private WinControl_ELR_NET.ELRLabel elrLabel5;
        private WinControl_ELR_NET.ELRTextBox txtNCF;
        private WinControl_ELR_NET.ELRLabel elrLabel4;
        public System.Windows.Forms.Panel panel5;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
        private WinControl_ELR_NET.ELRTextBox txtItbis;
        private WinControl_ELR_NET.ELRTextBox txtSubTotal;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
    }
}