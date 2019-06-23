namespace ELRActivosFijos
{
    partial class FormActivosFijosVentasR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtActivoId = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActivoNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoAdquisicion = new WinControl_ELR_NET.ELRTextBox();
            this.txtValorEnLibro = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepreAcumulada = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGananciaPerdida = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 427);
            this.pnBotones.Size = new System.Drawing.Size(641, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(401, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(542, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(306, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activo:";
            // 
            // txtActivoId
            // 
            this.txtActivoId.AMostrar = null;
            this.txtActivoId.AValidar = null;
            this.txtActivoId.CampoBusquedaID = "";
            this.txtActivoId.CampoData = "Activo_Id";
            this.txtActivoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActivoId.ColumnasBusqGeneral = null;
            this.txtActivoId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtActivoId.Decimales = 0;
            this.txtActivoId.DSData = this.DSDatos;
            this.txtActivoId.EsAutoGenerado = false;
            this.txtActivoId.EsBusqueda = false;
            this.txtActivoId.EsEditable = true;
            this.txtActivoId.FiltroBusqueda = "";
            this.txtActivoId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtActivoId.Location = new System.Drawing.Point(86, 27);
            this.txtActivoId.Name = "txtActivoId";
            this.txtActivoId.NombreTabla = "";
            this.txtActivoId.SepDecimal = '\0';
            this.txtActivoId.Size = new System.Drawing.Size(100, 29);
            this.txtActivoId.TabIndex = 2;
            this.txtActivoId.TablaOVistaBusqueda = "";
            this.txtActivoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoId.ValorPorDefecto = "";
            this.txtActivoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivoId_KeyDown);
            this.txtActivoId.Leave += new System.EventHandler(this.txtActivoId_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ELRActivosFijos.Properties.Resources._1378160672_search;
            this.btnBuscar.Location = new System.Drawing.Point(192, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Activo:";
            // 
            // txtActivoNombre
            // 
            this.txtActivoNombre.AMostrar = null;
            this.txtActivoNombre.AValidar = null;
            this.txtActivoNombre.BackColor = System.Drawing.Color.White;
            this.txtActivoNombre.CampoBusquedaID = "";
            this.txtActivoNombre.CampoData = "Nombre";
            this.txtActivoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActivoNombre.ColumnasBusqGeneral = null;
            this.txtActivoNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtActivoNombre.Decimales = 0;
            this.txtActivoNombre.DSData = this.DSDatos;
            this.txtActivoNombre.Enabled = false;
            this.txtActivoNombre.EsAutoGenerado = false;
            this.txtActivoNombre.EsBusqueda = false;
            this.txtActivoNombre.EsEditable = true;
            this.txtActivoNombre.FiltroBusqueda = "";
            this.txtActivoNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivoNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtActivoNombre.Location = new System.Drawing.Point(86, 62);
            this.txtActivoNombre.Multiline = true;
            this.txtActivoNombre.Name = "txtActivoNombre";
            this.txtActivoNombre.NombreTabla = "";
            this.txtActivoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtActivoNombre.SepDecimal = '\0';
            this.txtActivoNombre.Size = new System.Drawing.Size(527, 53);
            this.txtActivoNombre.TabIndex = 5;
            this.txtActivoNombre.TablaOVistaBusqueda = "";
            this.txtActivoNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoNombre.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Adquisicion:";
            // 
            // txtMontoAdquisicion
            // 
            this.txtMontoAdquisicion.AMostrar = null;
            this.txtMontoAdquisicion.AValidar = null;
            this.txtMontoAdquisicion.BackColor = System.Drawing.Color.White;
            this.txtMontoAdquisicion.CampoBusquedaID = "";
            this.txtMontoAdquisicion.CampoData = "Valor_Adquisicion";
            this.txtMontoAdquisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoAdquisicion.ColumnasBusqGeneral = null;
            this.txtMontoAdquisicion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMontoAdquisicion.Decimales = 0;
            this.txtMontoAdquisicion.DSData = this.DSDatos;
            this.txtMontoAdquisicion.Enabled = false;
            this.txtMontoAdquisicion.EsAutoGenerado = false;
            this.txtMontoAdquisicion.EsBusqueda = false;
            this.txtMontoAdquisicion.EsEditable = true;
            this.txtMontoAdquisicion.FiltroBusqueda = "";
            this.txtMontoAdquisicion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAdquisicion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMontoAdquisicion.Location = new System.Drawing.Point(159, 133);
            this.txtMontoAdquisicion.Name = "txtMontoAdquisicion";
            this.txtMontoAdquisicion.NombreTabla = "";
            this.txtMontoAdquisicion.SepDecimal = '\0';
            this.txtMontoAdquisicion.Size = new System.Drawing.Size(165, 29);
            this.txtMontoAdquisicion.TabIndex = 7;
            this.txtMontoAdquisicion.TablaOVistaBusqueda = "";
            this.txtMontoAdquisicion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMontoAdquisicion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMontoAdquisicion.ValorPorDefecto = "";
            // 
            // txtValorEnLibro
            // 
            this.txtValorEnLibro.AMostrar = null;
            this.txtValorEnLibro.AValidar = null;
            this.txtValorEnLibro.BackColor = System.Drawing.Color.White;
            this.txtValorEnLibro.CampoBusquedaID = "";
            this.txtValorEnLibro.CampoData = "Valor_Libro_Depreciar";
            this.txtValorEnLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorEnLibro.ColumnasBusqGeneral = null;
            this.txtValorEnLibro.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValorEnLibro.Decimales = 0;
            this.txtValorEnLibro.DSData = this.DSDatos;
            this.txtValorEnLibro.Enabled = false;
            this.txtValorEnLibro.EsAutoGenerado = false;
            this.txtValorEnLibro.EsBusqueda = false;
            this.txtValorEnLibro.EsEditable = true;
            this.txtValorEnLibro.FiltroBusqueda = "";
            this.txtValorEnLibro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEnLibro.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValorEnLibro.Location = new System.Drawing.Point(448, 133);
            this.txtValorEnLibro.Name = "txtValorEnLibro";
            this.txtValorEnLibro.NombreTabla = "";
            this.txtValorEnLibro.SepDecimal = '\0';
            this.txtValorEnLibro.Size = new System.Drawing.Size(165, 29);
            this.txtValorEnLibro.TabIndex = 9;
            this.txtValorEnLibro.TablaOVistaBusqueda = "";
            this.txtValorEnLibro.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValorEnLibro.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtValorEnLibro.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Libro:";
            // 
            // txtDepreAcumulada
            // 
            this.txtDepreAcumulada.AMostrar = null;
            this.txtDepreAcumulada.AValidar = null;
            this.txtDepreAcumulada.BackColor = System.Drawing.Color.White;
            this.txtDepreAcumulada.CampoBusquedaID = "";
            this.txtDepreAcumulada.CampoData = "Depre_Acumulada";
            this.txtDepreAcumulada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepreAcumulada.ColumnasBusqGeneral = null;
            this.txtDepreAcumulada.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDepreAcumulada.Decimales = 0;
            this.txtDepreAcumulada.DSData = this.DSDatos;
            this.txtDepreAcumulada.Enabled = false;
            this.txtDepreAcumulada.EsAutoGenerado = false;
            this.txtDepreAcumulada.EsBusqueda = false;
            this.txtDepreAcumulada.EsEditable = true;
            this.txtDepreAcumulada.FiltroBusqueda = "";
            this.txtDepreAcumulada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepreAcumulada.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDepreAcumulada.Location = new System.Drawing.Point(159, 168);
            this.txtDepreAcumulada.Name = "txtDepreAcumulada";
            this.txtDepreAcumulada.NombreTabla = "";
            this.txtDepreAcumulada.SepDecimal = '\0';
            this.txtDepreAcumulada.Size = new System.Drawing.Size(165, 29);
            this.txtDepreAcumulada.TabIndex = 11;
            this.txtDepreAcumulada.TablaOVistaBusqueda = "";
            this.txtDepreAcumulada.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDepreAcumulada.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDepreAcumulada.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Depre. Acumulada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "VENTAS",
            "RETIRO"});
            this.cboTipo.Location = new System.Drawing.Point(159, 215);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(196, 29);
            this.cboTipo.TabIndex = 13;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monto Venta:";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.AValidar = null;
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Monto";
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColumnasBusqGeneral = null;
            this.txtMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMonto.Decimales = 0;
            this.txtMonto.DSData = this.DSDatos;
            this.txtMonto.Enabled = false;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(159, 250);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(196, 29);
            this.txtMonto.TabIndex = 15;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "";
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gan\\Perdida:";
            // 
            // txtGananciaPerdida
            // 
            this.txtGananciaPerdida.AMostrar = null;
            this.txtGananciaPerdida.AValidar = null;
            this.txtGananciaPerdida.BackColor = System.Drawing.Color.White;
            this.txtGananciaPerdida.CampoBusquedaID = "";
            this.txtGananciaPerdida.CampoData = "Monto_Ganancia";
            this.txtGananciaPerdida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGananciaPerdida.ColumnasBusqGeneral = null;
            this.txtGananciaPerdida.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtGananciaPerdida.Decimales = 0;
            this.txtGananciaPerdida.DSData = this.DSDatos;
            this.txtGananciaPerdida.Enabled = false;
            this.txtGananciaPerdida.EsAutoGenerado = false;
            this.txtGananciaPerdida.EsBusqueda = false;
            this.txtGananciaPerdida.EsEditable = true;
            this.txtGananciaPerdida.FiltroBusqueda = "";
            this.txtGananciaPerdida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGananciaPerdida.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtGananciaPerdida.Location = new System.Drawing.Point(159, 285);
            this.txtGananciaPerdida.Name = "txtGananciaPerdida";
            this.txtGananciaPerdida.NombreTabla = "";
            this.txtGananciaPerdida.SepDecimal = '\0';
            this.txtGananciaPerdida.Size = new System.Drawing.Size(196, 29);
            this.txtGananciaPerdida.TabIndex = 17;
            this.txtGananciaPerdida.TablaOVistaBusqueda = "";
            this.txtGananciaPerdida.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtGananciaPerdida.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtGananciaPerdida.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Concepto:";
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
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(159, 320);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(454, 90);
            this.txtConcepto.TabIndex = 19;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // FormActivosFijosVentasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtActivoId;
            valida1.Mensaje = "Debe Indicar Activo Fijo";
            valida1.NombreCampo = "Activo_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtConcepto;
            valida2.Mensaje = "Debe Indicar un Concepto";
            valida2.NombreCampo = "Concepto";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(641, 470);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGananciaPerdida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDepreAcumulada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorEnLibro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontoAdquisicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtActivoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtActivoId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActivosFijosVentasR";
            this.SPGraba = "SP_ACTIVOS_FIJOS_GRABA_VENTA_RETIRO";
            this.TablaEncabezado = "TTEMPORAL_ACTIVOS_FIJOS_MOVIMIENTOS";
            this.Text = "REGISTRAR VENTAS Y/O RETIROS DE ACTIVOS FIJOS";
            this.Load += new System.EventHandler(this.FormActivosFijosVentasR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtActivoId, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtActivoNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMontoAdquisicion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtValorEnLibro, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDepreAcumulada, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtGananciaPerdida, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtActivoId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtActivoNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtMontoAdquisicion;
        private WinControl_ELR_NET.ELRTextBox txtValorEnLibro;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtDepreAcumulada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txtGananciaPerdida;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
    }
}