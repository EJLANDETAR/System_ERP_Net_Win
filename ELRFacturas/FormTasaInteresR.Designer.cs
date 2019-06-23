namespace ELRFacturas
{
    partial class FormTasaInteresR
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
            WinControl_ELR_NET.Valida valida7 = new WinControl_ELR_NET.Valida();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMontoHasta = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoDesde = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoGarantia = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlazo = new WinControl_ELR_NET.ELRTextBox();
            this.cboFormaPago = new WinControl_ELR_NET.ELRCombobox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTasaInteres = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTasaInteresMin = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLegalMonto = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.txtPorcLegalizacion = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 405);
            this.pnBotones.Size = new System.Drawing.Size(559, 43);
            this.pnBotones.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(319, 0);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(460, 0);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(224, 0);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(129, 39);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtMontoHasta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMontoDesde);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboTipoGarantia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 94);
            this.panel1.TabIndex = 0;
            // 
            // txtMontoHasta
            // 
            this.txtMontoHasta.AMostrar = null;
            this.txtMontoHasta.AValidar = null;
            this.txtMontoHasta.CampoBusquedaID = "";
            this.txtMontoHasta.CampoData = "Monto_Hasta";
            this.txtMontoHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoHasta.ColumnasBusqGeneral = null;
            this.txtMontoHasta.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMontoHasta.Decimales = 0;
            this.txtMontoHasta.DSData = this.DSDatos;
            this.txtMontoHasta.EsAutoGenerado = false;
            this.txtMontoHasta.EsBusqueda = false;
            this.txtMontoHasta.EsBusquedaAutoIncremental = false;
            this.txtMontoHasta.EsEditable = true;
            this.txtMontoHasta.FiltroBusqueda = "";
            this.txtMontoHasta.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMontoHasta.Location = new System.Drawing.Point(394, 44);
            this.txtMontoHasta.Name = "txtMontoHasta";
            this.txtMontoHasta.NombreTabla = "";
            this.txtMontoHasta.SepDecimal = '\0';
            this.txtMontoHasta.Size = new System.Drawing.Size(149, 29);
            this.txtMontoHasta.TabIndex = 5;
            this.txtMontoHasta.TablaOVistaBusqueda = "";
            this.txtMontoHasta.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMontoHasta.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMontoHasta.ValorPorDefecto = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto Hasta";
            // 
            // txtMontoDesde
            // 
            this.txtMontoDesde.AMostrar = null;
            this.txtMontoDesde.AValidar = null;
            this.txtMontoDesde.CampoBusquedaID = "";
            this.txtMontoDesde.CampoData = "Monto_Desde";
            this.txtMontoDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoDesde.ColumnasBusqGeneral = null;
            this.txtMontoDesde.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMontoDesde.Decimales = 0;
            this.txtMontoDesde.DSData = this.DSDatos;
            this.txtMontoDesde.EsAutoGenerado = false;
            this.txtMontoDesde.EsBusqueda = false;
            this.txtMontoDesde.EsBusquedaAutoIncremental = false;
            this.txtMontoDesde.EsEditable = true;
            this.txtMontoDesde.FiltroBusqueda = "";
            this.txtMontoDesde.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMontoDesde.Location = new System.Drawing.Point(125, 44);
            this.txtMontoDesde.Name = "txtMontoDesde";
            this.txtMontoDesde.NombreTabla = "";
            this.txtMontoDesde.SepDecimal = '\0';
            this.txtMontoDesde.Size = new System.Drawing.Size(149, 29);
            this.txtMontoDesde.TabIndex = 3;
            this.txtMontoDesde.TablaOVistaBusqueda = "";
            this.txtMontoDesde.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMontoDesde.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMontoDesde.ValorPorDefecto = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto Desde";
            // 
            // cboTipoGarantia
            // 
            this.cboTipoGarantia.AValidar = null;
            this.cboTipoGarantia.CampoData = "Tipo_Garantia_Id";
            this.cboTipoGarantia.CampoJoinCombobox2 = "";
            this.cboTipoGarantia.ComboboxAFiltrar = null;
            this.cboTipoGarantia.DisplayMember = "Descripcion";
            this.cboTipoGarantia.DSData = this.DSDatos;
            this.cboTipoGarantia.EsEditable = true;
            this.cboTipoGarantia.FiltroBusqueda = "EsActivo = 1";
            this.cboTipoGarantia.FormattingEnabled = true;
            this.cboTipoGarantia.Location = new System.Drawing.Point(125, 9);
            this.cboTipoGarantia.Name = "cboTipoGarantia";
            this.cboTipoGarantia.NombreTabla = "";
            this.cboTipoGarantia.Size = new System.Drawing.Size(418, 29);
            this.cboTipoGarantia.SSQL = "";
            this.cboTipoGarantia.TabIndex = 1;
            this.cboTipoGarantia.TablaOVistaConsulta = "TPRESTAMOS_TIPO_GARANTIAS";
            this.cboTipoGarantia.UsaDataGlobal = false;
            this.cboTipoGarantia.ValorPorDefecto = "";
            this.cboTipoGarantia.ValueMember = "Tipo_Garantia_Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Garantia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.elrTextBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.cboFormaPago);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTasaInteres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTasaInteresMin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasa de Interes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(461, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Forma Pago";
            // 
            // txtPlazo
            // 
            this.txtPlazo.AMostrar = null;
            this.txtPlazo.AValidar = null;
            this.txtPlazo.CampoBusquedaID = "";
            this.txtPlazo.CampoData = "Plazo";
            this.txtPlazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlazo.ColumnasBusqGeneral = null;
            this.txtPlazo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPlazo.Decimales = 0;
            this.txtPlazo.DSData = this.DSDatos;
            this.txtPlazo.EsAutoGenerado = false;
            this.txtPlazo.EsBusqueda = false;
            this.txtPlazo.EsBusquedaAutoIncremental = false;
            this.txtPlazo.EsEditable = true;
            this.txtPlazo.FiltroBusqueda = "";
            this.txtPlazo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPlazo.Location = new System.Drawing.Point(127, 95);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.NombreTabla = "";
            this.txtPlazo.SepDecimal = '\0';
            this.txtPlazo.Size = new System.Drawing.Size(105, 29);
            this.txtPlazo.TabIndex = 9;
            this.txtPlazo.TablaOVistaBusqueda = "";
            this.txtPlazo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPlazo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPlazo.ValorPorDefecto = "1";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.AValidar = null;
            this.cboFormaPago.CampoData = "Frecuencia_Pago";
            this.cboFormaPago.CampoJoinCombobox2 = "";
            this.cboFormaPago.ComboboxAFiltrar = null;
            this.cboFormaPago.DisplayMember = "Descripcion";
            this.cboFormaPago.DSData = this.DSDatos;
            this.cboFormaPago.EsEditable = true;
            this.cboFormaPago.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'FRECUENCIA_PAGO\'";
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(127, 25);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.NombreTabla = "";
            this.cboFormaPago.Size = new System.Drawing.Size(362, 29);
            this.cboFormaPago.SSQL = "";
            this.cboFormaPago.TabIndex = 1;
            this.cboFormaPago.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboFormaPago.UsaDataGlobal = false;
            this.cboFormaPago.ValorPorDefecto = "M";
            this.cboFormaPago.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tasa de Interes";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.AMostrar = null;
            this.txtTasaInteres.AValidar = null;
            this.txtTasaInteres.CampoBusquedaID = "";
            this.txtTasaInteres.CampoData = "Tasa_Interes_Anual";
            this.txtTasaInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaInteres.ColumnasBusqGeneral = null;
            this.txtTasaInteres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaInteres.Decimales = 0;
            this.txtTasaInteres.DSData = this.DSDatos;
            this.txtTasaInteres.EsAutoGenerado = false;
            this.txtTasaInteres.EsBusqueda = false;
            this.txtTasaInteres.EsBusquedaAutoIncremental = false;
            this.txtTasaInteres.EsEditable = true;
            this.txtTasaInteres.FiltroBusqueda = "";
            this.txtTasaInteres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTasaInteres.Location = new System.Drawing.Point(127, 60);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.NombreTabla = "";
            this.txtTasaInteres.SepDecimal = '\0';
            this.txtTasaInteres.Size = new System.Drawing.Size(105, 29);
            this.txtTasaInteres.TabIndex = 3;
            this.txtTasaInteres.TablaOVistaBusqueda = "";
            this.txtTasaInteres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaInteres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaInteres.ValorPorDefecto = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minimo";
            // 
            // txtTasaInteresMin
            // 
            this.txtTasaInteresMin.AMostrar = null;
            this.txtTasaInteresMin.AValidar = null;
            this.txtTasaInteresMin.CampoBusquedaID = "";
            this.txtTasaInteresMin.CampoData = "Tasa_Interes_Anual_Minima";
            this.txtTasaInteresMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaInteresMin.ColumnasBusqGeneral = null;
            this.txtTasaInteresMin.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaInteresMin.Decimales = 0;
            this.txtTasaInteresMin.DSData = this.DSDatos;
            this.txtTasaInteresMin.EsAutoGenerado = false;
            this.txtTasaInteresMin.EsBusqueda = false;
            this.txtTasaInteresMin.EsBusquedaAutoIncremental = false;
            this.txtTasaInteresMin.EsEditable = true;
            this.txtTasaInteresMin.FiltroBusqueda = "";
            this.txtTasaInteresMin.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTasaInteresMin.Location = new System.Drawing.Point(357, 63);
            this.txtTasaInteresMin.Name = "txtTasaInteresMin";
            this.txtTasaInteresMin.NombreTabla = "";
            this.txtTasaInteresMin.SepDecimal = '\0';
            this.txtTasaInteresMin.Size = new System.Drawing.Size(93, 29);
            this.txtTasaInteresMin.TabIndex = 6;
            this.txtTasaInteresMin.TablaOVistaBusqueda = "";
            this.txtTasaInteresMin.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaInteresMin.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaInteresMin.ValorPorDefecto = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLegalMonto);
            this.groupBox2.Controls.Add(this.elrLabel2);
            this.groupBox2.Controls.Add(this.txtPorcLegalizacion);
            this.groupBox2.Controls.Add(this.elrLabel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Legalizacion";
            // 
            // txtLegalMonto
            // 
            this.txtLegalMonto.AMostrar = null;
            this.txtLegalMonto.AValidar = null;
            this.txtLegalMonto.CampoBusquedaID = "";
            this.txtLegalMonto.CampoData = "Monto_Legalizacion";
            this.txtLegalMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLegalMonto.ColumnasBusqGeneral = null;
            this.txtLegalMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtLegalMonto.Decimales = 0;
            this.txtLegalMonto.DSData = this.DSDatos;
            this.txtLegalMonto.EsAutoGenerado = false;
            this.txtLegalMonto.EsBusqueda = false;
            this.txtLegalMonto.EsBusquedaAutoIncremental = false;
            this.txtLegalMonto.EsEditable = true;
            this.txtLegalMonto.FiltroBusqueda = "";
            this.txtLegalMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtLegalMonto.Location = new System.Drawing.Point(127, 77);
            this.txtLegalMonto.Name = "txtLegalMonto";
            this.txtLegalMonto.NombreTabla = "";
            this.txtLegalMonto.SepDecimal = '\0';
            this.txtLegalMonto.Size = new System.Drawing.Size(177, 29);
            this.txtLegalMonto.TabIndex = 3;
            this.txtLegalMonto.TablaOVistaBusqueda = "";
            this.txtLegalMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtLegalMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtLegalMonto.ValorPorDefecto = "0.00";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(20, 77);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(88, 21);
            this.elrLabel2.TabIndex = 2;
            this.elrLabel2.Text = "Monto Fijo:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // txtPorcLegalizacion
            // 
            this.txtPorcLegalizacion.AMostrar = null;
            this.txtPorcLegalizacion.AValidar = null;
            this.txtPorcLegalizacion.CampoBusquedaID = "";
            this.txtPorcLegalizacion.CampoData = "Porc_Legalizacion";
            this.txtPorcLegalizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcLegalizacion.ColumnasBusqGeneral = null;
            this.txtPorcLegalizacion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPorcLegalizacion.Decimales = 0;
            this.txtPorcLegalizacion.DSData = this.DSDatos;
            this.txtPorcLegalizacion.EsAutoGenerado = false;
            this.txtPorcLegalizacion.EsBusqueda = false;
            this.txtPorcLegalizacion.EsBusquedaAutoIncremental = false;
            this.txtPorcLegalizacion.EsEditable = true;
            this.txtPorcLegalizacion.FiltroBusqueda = "";
            this.txtPorcLegalizacion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPorcLegalizacion.Location = new System.Drawing.Point(127, 42);
            this.txtPorcLegalizacion.Name = "txtPorcLegalizacion";
            this.txtPorcLegalizacion.NombreTabla = "";
            this.txtPorcLegalizacion.SepDecimal = '\0';
            this.txtPorcLegalizacion.Size = new System.Drawing.Size(177, 29);
            this.txtPorcLegalizacion.TabIndex = 1;
            this.txtPorcLegalizacion.TablaOVistaBusqueda = "";
            this.txtPorcLegalizacion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPorcLegalizacion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPorcLegalizacion.ValorPorDefecto = "0.00";
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(15, 42);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(85, 21);
            this.elrLabel1.TabIndex = 0;
            this.elrLabel1.Text = "Porcentaje:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tasa Demora:";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Tasa_Demora_Mensual";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(357, 98);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(93, 29);
            this.elrTextBox1.TabIndex = 11;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(461, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "%";
            // 
            // FormTasaInteresR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = null;
            valida1.Mensaje = "Debe Indicar el Tipo de Garantia";
            valida1.NombreCampo = "Tipo_Garantia_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = null;
            valida2.Mensaje = "El Valor Debe Ser Mayor o Igual a Cero";
            valida2.NombreCampo = "Monto_Desde";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "0";
            valida2.Valor2 = null;
            valida3.comtrol = null;
            valida3.Mensaje = "Debe Indicar La Forma de Pago";
            valida3.NombreCampo = "Frecuencia_Pago";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            valida4.comtrol = null;
            valida4.Mensaje = "Valor debe estar entre 0 y 100";
            valida4.NombreCampo = "Tasa_Interes_Anual";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida4.Valor1 = "0";
            valida4.Valor2 = "100";
            valida5.comtrol = null;
            valida5.Mensaje = "Valor debe estar entre 0 y 100";
            valida5.NombreCampo = "Tasa_Interes_Anual_Minima";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida5.Valor1 = "0";
            valida5.Valor2 = "100";
            valida6.comtrol = null;
            valida6.Mensaje = "Valor debe Ser Mayor a Cero (0)";
            valida6.NombreCampo = "Plazo";
            valida6.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida6.Valor1 = "1";
            valida6.Valor2 = null;
            valida7.comtrol = null;
            valida7.Mensaje = "Valor Debe Ser Mayor o Igual a Cero";
            valida7.NombreCampo = "Monto_Hasta";
            valida7.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida7.Valor1 = "0";
            valida7.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5,
        valida6,
        valida7};
            this.ClientSize = new System.Drawing.Size(559, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormTasaInteresR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TPRESTAMOS_TASA_INTERES";
            this.Text = "REGISTRAR TASA DE INTERES";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRTextBox txtMontoHasta;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtMontoDesde;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCombobox cboTipoGarantia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtPlazo;
        private WinControl_ELR_NET.ELRCombobox cboFormaPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtTasaInteres;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtTasaInteresMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRTextBox txtLegalMonto;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRTextBox txtPorcLegalizacion;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private System.Windows.Forms.Label label11;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private System.Windows.Forms.Label label6;
    }
}