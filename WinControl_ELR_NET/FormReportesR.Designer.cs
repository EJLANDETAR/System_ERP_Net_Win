namespace WinControl_ELR_NET
{
    partial class FormReportesR
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
            this.cboModulo = new WinControl_ELR_NET.ELRCombobox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtTablaOVista = new WinControl_ELR_NET.ELRTextBox();
            this.txtReportRDLC = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReporteId = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltroEstatico = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAFecha = new WinControl_ELR_NET.ELRCheckBox();
            this.chpPorRangoFecha = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorOficialCredito = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorEvaluador = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorZona = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorCampoId = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorCaja = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorVendedor = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPorOficina = new WinControl_ELR_NET.ELRCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCampoID = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSPEjecuta = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 551);
            this.pnBotones.Size = new System.Drawing.Size(678, 43);
            this.pnBotones.TabIndex = 18;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(484, 0);
            this.btnGrabar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(579, 0);
            this.btnCancelar.TabIndex = 1;
            // 
            // cboModulo
            // 
            this.cboModulo.CampoData = "Modulo_Id";
            this.cboModulo.CampoJoinCombobox2 = "";
            this.cboModulo.ComboboxAFiltrar = null;
            this.cboModulo.DisplayMember = "Carpeta";
            this.cboModulo.DSData = this.DSDatos;
            this.cboModulo.EsEditable = true;
            this.cboModulo.FiltroBusqueda = "";
            this.cboModulo.FormattingEnabled = true;
            this.cboModulo.Location = new System.Drawing.Point(316, 26);
            this.cboModulo.Name = "cboModulo";
            this.cboModulo.NombreTabla = "";
            this.cboModulo.Size = new System.Drawing.Size(340, 29);
            this.cboModulo.SSQL = "";
            this.cboModulo.TabIndex = 3;
            this.cboModulo.TablaOVistaConsulta = "TSISTEMA_MODULOS";
            this.cboModulo.ValorPorDefecto = "1";
            this.cboModulo.ValueMember = "Modulo_Id";
            // 
            // txtNombre
            // 
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Location = new System.Drawing.Point(129, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.Size = new System.Drawing.Size(527, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.ValorPorDefecto = "";
            // 
            // txtTablaOVista
            // 
            this.txtTablaOVista.CampoData = "TablaOVista";
            this.txtTablaOVista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTablaOVista.DSData = this.DSDatos;
            this.txtTablaOVista.EsAutoGenerado = false;
            this.txtTablaOVista.EsEditable = true;
            this.txtTablaOVista.FiltroBusqueda = "";
            this.txtTablaOVista.Location = new System.Drawing.Point(129, 133);
            this.txtTablaOVista.Name = "txtTablaOVista";
            this.txtTablaOVista.NombreTabla = "";
            this.txtTablaOVista.Size = new System.Drawing.Size(366, 29);
            this.txtTablaOVista.TabIndex = 9;
            this.txtTablaOVista.ValorPorDefecto = "";
            // 
            // txtReportRDLC
            // 
            this.txtReportRDLC.CampoData = "ReportRDLC";
            this.txtReportRDLC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReportRDLC.DSData = this.DSDatos;
            this.txtReportRDLC.EsAutoGenerado = false;
            this.txtReportRDLC.EsEditable = true;
            this.txtReportRDLC.FiltroBusqueda = "";
            this.txtReportRDLC.Location = new System.Drawing.Point(129, 238);
            this.txtReportRDLC.Name = "txtReportRDLC";
            this.txtReportRDLC.NombreTabla = "";
            this.txtReportRDLC.Size = new System.Drawing.Size(366, 29);
            this.txtReportRDLC.TabIndex = 15;
            this.txtReportRDLC.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Id";
            // 
            // txtReporteId
            // 
            this.txtReporteId.CampoData = "Reporte_Id";
            this.txtReporteId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReporteId.DSData = this.DSDatos;
            this.txtReporteId.EsAutoGenerado = false;
            this.txtReporteId.EsEditable = true;
            this.txtReporteId.FiltroBusqueda = "";
            this.txtReporteId.Location = new System.Drawing.Point(129, 26);
            this.txtReporteId.Name = "txtReporteId";
            this.txtReporteId.NombreTabla = "";
            this.txtReporteId.ReadOnly = true;
            this.txtReporteId.Size = new System.Drawing.Size(100, 29);
            this.txtReporteId.TabIndex = 1;
            this.txtReporteId.Text = "000000";
            this.txtReporteId.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filtro Estatico";
            // 
            // txtFiltroEstatico
            // 
            this.txtFiltroEstatico.CampoData = "FiltroEstatico";
            this.txtFiltroEstatico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroEstatico.DSData = this.DSDatos;
            this.txtFiltroEstatico.EsAutoGenerado = false;
            this.txtFiltroEstatico.EsEditable = true;
            this.txtFiltroEstatico.FiltroBusqueda = "";
            this.txtFiltroEstatico.Location = new System.Drawing.Point(129, 98);
            this.txtFiltroEstatico.Name = "txtFiltroEstatico";
            this.txtFiltroEstatico.NombreTabla = "";
            this.txtFiltroEstatico.Size = new System.Drawing.Size(527, 29);
            this.txtFiltroEstatico.TabIndex = 7;
            this.txtFiltroEstatico.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAFecha);
            this.groupBox1.Controls.Add(this.chpPorRangoFecha);
            this.groupBox1.Controls.Add(this.chkPorOficialCredito);
            this.groupBox1.Controls.Add(this.chkPorEvaluador);
            this.groupBox1.Controls.Add(this.chkPorZona);
            this.groupBox1.Controls.Add(this.chkPorCampoId);
            this.groupBox1.Controls.Add(this.chkPorCaja);
            this.groupBox1.Controls.Add(this.chkPorVendedor);
            this.groupBox1.Controls.Add(this.chkPorOficina);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 210);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Para Filtrar";
            // 
            // chkAFecha
            // 
            this.chkAFecha.AutoSize = true;
            this.chkAFecha.CampoData = "EsAUnaFecha";
            this.chkAFecha.DSData = this.DSDatos;
            this.chkAFecha.EsEditable = true;
            this.chkAFecha.EsModificable = true;
            this.chkAFecha.FiltroBusqueda = "";
            this.chkAFecha.Location = new System.Drawing.Point(416, 82);
            this.chkAFecha.Name = "chkAFecha";
            this.chkAFecha.NombreTabla = "";
            this.chkAFecha.Size = new System.Drawing.Size(203, 25);
            this.chkAFecha.TabIndex = 8;
            this.chkAFecha.Text = "A Una Fecha Especifica";
            this.chkAFecha.UseVisualStyleBackColor = true;
            this.chkAFecha.ValorPorDefecto = false;
            // 
            // chpPorRangoFecha
            // 
            this.chpPorRangoFecha.AutoSize = true;
            this.chpPorRangoFecha.CampoData = "EsRangoFecha";
            this.chpPorRangoFecha.DSData = this.DSDatos;
            this.chpPorRangoFecha.EsEditable = true;
            this.chpPorRangoFecha.EsModificable = true;
            this.chpPorRangoFecha.FiltroBusqueda = "";
            this.chpPorRangoFecha.Location = new System.Drawing.Point(416, 42);
            this.chpPorRangoFecha.Name = "chpPorRangoFecha";
            this.chpPorRangoFecha.NombreTabla = "";
            this.chpPorRangoFecha.Size = new System.Drawing.Size(179, 25);
            this.chpPorRangoFecha.TabIndex = 7;
            this.chpPorRangoFecha.Text = "Por Rango de Fecha";
            this.chpPorRangoFecha.UseVisualStyleBackColor = true;
            this.chpPorRangoFecha.ValorPorDefecto = false;
            // 
            // chkPorOficialCredito
            // 
            this.chkPorOficialCredito.AutoSize = true;
            this.chkPorOficialCredito.CampoData = "EsPorOficialCredito";
            this.chkPorOficialCredito.DSData = this.DSDatos;
            this.chkPorOficialCredito.EsEditable = true;
            this.chkPorOficialCredito.EsModificable = true;
            this.chkPorOficialCredito.FiltroBusqueda = "";
            this.chkPorOficialCredito.Location = new System.Drawing.Point(216, 122);
            this.chkPorOficialCredito.Name = "chkPorOficialCredito";
            this.chkPorOficialCredito.NombreTabla = "";
            this.chkPorOficialCredito.Size = new System.Drawing.Size(192, 25);
            this.chkPorOficialCredito.TabIndex = 6;
            this.chkPorOficialCredito.Text = "Por Oficial de Credito";
            this.chkPorOficialCredito.UseVisualStyleBackColor = true;
            this.chkPorOficialCredito.ValorPorDefecto = false;
            // 
            // chkPorEvaluador
            // 
            this.chkPorEvaluador.AutoSize = true;
            this.chkPorEvaluador.CampoData = "EsPorEvaluador";
            this.chkPorEvaluador.DSData = this.DSDatos;
            this.chkPorEvaluador.EsEditable = true;
            this.chkPorEvaluador.EsModificable = true;
            this.chkPorEvaluador.FiltroBusqueda = "";
            this.chkPorEvaluador.Location = new System.Drawing.Point(216, 82);
            this.chkPorEvaluador.Name = "chkPorEvaluador";
            this.chkPorEvaluador.NombreTabla = "";
            this.chkPorEvaluador.Size = new System.Drawing.Size(136, 25);
            this.chkPorEvaluador.TabIndex = 5;
            this.chkPorEvaluador.Text = "Por Evaluador";
            this.chkPorEvaluador.UseVisualStyleBackColor = true;
            this.chkPorEvaluador.ValorPorDefecto = false;
            // 
            // chkPorZona
            // 
            this.chkPorZona.AutoSize = true;
            this.chkPorZona.CampoData = "EsPorZona";
            this.chkPorZona.DSData = this.DSDatos;
            this.chkPorZona.EsEditable = true;
            this.chkPorZona.EsModificable = true;
            this.chkPorZona.FiltroBusqueda = "";
            this.chkPorZona.Location = new System.Drawing.Point(216, 42);
            this.chkPorZona.Name = "chkPorZona";
            this.chkPorZona.NombreTabla = "";
            this.chkPorZona.Size = new System.Drawing.Size(98, 25);
            this.chkPorZona.TabIndex = 4;
            this.chkPorZona.Text = "Por Zona";
            this.chkPorZona.UseVisualStyleBackColor = true;
            this.chkPorZona.ValorPorDefecto = false;
            // 
            // chkPorCampoId
            // 
            this.chkPorCampoId.AutoSize = true;
            this.chkPorCampoId.CampoData = "EsPorCampoId";
            this.chkPorCampoId.DSData = this.DSDatos;
            this.chkPorCampoId.EsEditable = true;
            this.chkPorCampoId.EsModificable = true;
            this.chkPorCampoId.FiltroBusqueda = "";
            this.chkPorCampoId.Location = new System.Drawing.Point(17, 162);
            this.chkPorCampoId.Name = "chkPorCampoId";
            this.chkPorCampoId.NombreTabla = "";
            this.chkPorCampoId.Size = new System.Drawing.Size(155, 25);
            this.chkPorCampoId.TabIndex = 3;
            this.chkPorCampoId.Text = "Por Id o Numero";
            this.chkPorCampoId.UseVisualStyleBackColor = true;
            this.chkPorCampoId.ValorPorDefecto = false;
            // 
            // chkPorCaja
            // 
            this.chkPorCaja.AutoSize = true;
            this.chkPorCaja.CampoData = "EsPorCaja";
            this.chkPorCaja.DSData = this.DSDatos;
            this.chkPorCaja.EsEditable = true;
            this.chkPorCaja.EsModificable = true;
            this.chkPorCaja.FiltroBusqueda = "";
            this.chkPorCaja.Location = new System.Drawing.Point(17, 122);
            this.chkPorCaja.Name = "chkPorCaja";
            this.chkPorCaja.NombreTabla = "";
            this.chkPorCaja.Size = new System.Drawing.Size(92, 25);
            this.chkPorCaja.TabIndex = 2;
            this.chkPorCaja.Text = "Por Caja";
            this.chkPorCaja.UseVisualStyleBackColor = true;
            this.chkPorCaja.ValorPorDefecto = false;
            // 
            // chkPorVendedor
            // 
            this.chkPorVendedor.AutoSize = true;
            this.chkPorVendedor.CampoData = "EsPorVendedor";
            this.chkPorVendedor.DSData = this.DSDatos;
            this.chkPorVendedor.EsEditable = true;
            this.chkPorVendedor.EsModificable = true;
            this.chkPorVendedor.FiltroBusqueda = "";
            this.chkPorVendedor.Location = new System.Drawing.Point(17, 82);
            this.chkPorVendedor.Name = "chkPorVendedor";
            this.chkPorVendedor.NombreTabla = "";
            this.chkPorVendedor.Size = new System.Drawing.Size(133, 25);
            this.chkPorVendedor.TabIndex = 1;
            this.chkPorVendedor.Text = "Por Vendedor";
            this.chkPorVendedor.UseVisualStyleBackColor = true;
            this.chkPorVendedor.ValorPorDefecto = false;
            // 
            // chkPorOficina
            // 
            this.chkPorOficina.AutoSize = true;
            this.chkPorOficina.CampoData = "EsPorOficina";
            this.chkPorOficina.DSData = this.DSDatos;
            this.chkPorOficina.EsEditable = true;
            this.chkPorOficina.EsModificable = true;
            this.chkPorOficina.FiltroBusqueda = "";
            this.chkPorOficina.Location = new System.Drawing.Point(17, 42);
            this.chkPorOficina.Name = "chkPorOficina";
            this.chkPorOficina.NombreTabla = "";
            this.chkPorOficina.Size = new System.Drawing.Size(114, 25);
            this.chkPorOficina.TabIndex = 0;
            this.chkPorOficina.Text = "Por Oficina";
            this.chkPorOficina.UseVisualStyleBackColor = true;
            this.chkPorOficina.ValorPorDefecto = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tabla o Vista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Campo ID";
            // 
            // txtCampoID
            // 
            this.txtCampoID.CampoData = "Nombre_CampoID";
            this.txtCampoID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCampoID.DSData = this.DSDatos;
            this.txtCampoID.EsAutoGenerado = false;
            this.txtCampoID.EsEditable = true;
            this.txtCampoID.FiltroBusqueda = "";
            this.txtCampoID.Location = new System.Drawing.Point(129, 168);
            this.txtCampoID.Name = "txtCampoID";
            this.txtCampoID.NombreTabla = "";
            this.txtCampoID.Size = new System.Drawing.Size(366, 29);
            this.txtCampoID.TabIndex = 11;
            this.txtCampoID.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "SP a Ejecutar";
            // 
            // txtSPEjecuta
            // 
            this.txtSPEjecuta.CampoData = "Nombre_SP";
            this.txtSPEjecuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSPEjecuta.DSData = this.DSDatos;
            this.txtSPEjecuta.EsAutoGenerado = false;
            this.txtSPEjecuta.EsEditable = true;
            this.txtSPEjecuta.FiltroBusqueda = "";
            this.txtSPEjecuta.Location = new System.Drawing.Point(129, 203);
            this.txtSPEjecuta.Name = "txtSPEjecuta";
            this.txtSPEjecuta.NombreTabla = "";
            this.txtSPEjecuta.Size = new System.Drawing.Size(366, 29);
            this.txtSPEjecuta.TabIndex = 13;
            this.txtSPEjecuta.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Report RDLC";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(129, 273);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 16;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormReportesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboModulo;
            valida1.Mensaje = "Debe Indicar el Modulo";
            valida1.NombreCampo = "Modulo_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "De Indicar el Titulo o Nombre del Reporte";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtTablaOVista;
            valida3.Mensaje = "Debe Indicar Nombre de la Tabla o Vista";
            valida3.NombreCampo = "TablaOVista";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            valida4.comtrol = this.txtReportRDLC;
            valida4.Mensaje = "Debe Indicar el Nombre del Reporte";
            valida4.NombreCampo = "ReportRDLC";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida4.Valor1 = null;
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(678, 594);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReportRDLC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSPEjecuta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCampoID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTablaOVista);
            this.Controls.Add(this.txtFiltroEstatico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboModulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReporteId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportesR";
            this.NombreCampoID = "Reporte_Id";
            this.TablaEncabezado = "TSISTEMA_MODULOS_REPORTES";
            this.Text = "REGISTRO DE REPORTES RDLC";
            this.Load += new System.EventHandler(this.FormReportesR_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtReporteId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboModulo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFiltroEstatico, 0);
            this.Controls.SetChildIndex(this.txtTablaOVista, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCampoID, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtSPEjecuta, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtReportRDLC, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ELRTextBox txtReporteId;
        private System.Windows.Forms.Label label2;
        private ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private ELRCombobox cboModulo;
        private System.Windows.Forms.Label label4;
        private ELRTextBox txtFiltroEstatico;
        private ELRTextBox txtTablaOVista;
        private System.Windows.Forms.GroupBox groupBox1;
        private ELRCheckBox chkPorOficialCredito;
        private ELRCheckBox chkPorEvaluador;
        private ELRCheckBox chkPorZona;
        private ELRCheckBox chkPorCampoId;
        private ELRCheckBox chkPorCaja;
        private ELRCheckBox chkPorVendedor;
        private ELRCheckBox chkPorOficina;
        private ELRCheckBox chkAFecha;
        private ELRCheckBox chpPorRangoFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ELRTextBox txtCampoID;
        private System.Windows.Forms.Label label6;
        private ELRTextBox txtSPEjecuta;
        private System.Windows.Forms.Label label5;
        private ELRTextBox txtReportRDLC;
        private ELRCheckBox elrCheckBox1;
    }
}