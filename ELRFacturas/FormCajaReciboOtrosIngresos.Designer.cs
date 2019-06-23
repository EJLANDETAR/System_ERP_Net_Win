namespace ELRFacturas
{
    partial class FormCajaReciboOtrosIngresos
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
            WinControl_ELR_NET.MyColumna myColumna1 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna2 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna3 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            this.cboTipoTransaccion = new WinControl_ELR_NET.ELRCombobox();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarEntidad = new WinControl_ELR_NET.ELRBotonBuscar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEntidad = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMontoLetra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 355);
            this.pnBotones.Size = new System.Drawing.Size(684, 43);
            this.pnBotones.TabIndex = 11;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(490, 0);
            this.btnGrabar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(585, 0);
            this.btnCancelar.TabIndex = 1;
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(395, 0);
            // 
            // cboTipoTransaccion
            // 
            this.cboTipoTransaccion.AValidar = null;
            this.cboTipoTransaccion.CampoData = "Tipo_Trans";
            this.cboTipoTransaccion.CampoJoinCombobox2 = "";
            this.cboTipoTransaccion.ComboboxAFiltrar = null;
            this.cboTipoTransaccion.DisplayMember = "Descripcion";
            this.cboTipoTransaccion.DSData = this.DSDatos;
            this.cboTipoTransaccion.EsEditable = true;
            this.cboTipoTransaccion.FiltroBusqueda = "EsActivo = 1 And Tipo_Trans > 0 and EsOtro = 1";
            this.cboTipoTransaccion.FormattingEnabled = true;
            this.cboTipoTransaccion.Location = new System.Drawing.Point(156, 10);
            this.cboTipoTransaccion.Name = "cboTipoTransaccion";
            this.cboTipoTransaccion.NombreTabla = "";
            this.cboTipoTransaccion.Size = new System.Drawing.Size(507, 29);
            this.cboTipoTransaccion.SSQL = "";
            this.cboTipoTransaccion.TabIndex = 1;
            this.cboTipoTransaccion.TablaOVistaConsulta = "TCAJAS_TIPO_TRANS";
            this.cboTipoTransaccion.UsaDataGlobal = false;
            this.cboTipoTransaccion.ValorPorDefecto = "0";
            this.cboTipoTransaccion.ValueMember = "Tipo_Trans";
            // 
            // txtMonto
            // 
            this.txtMonto.AMostrar = null;
            this.txtMonto.AValidar = null;
            this.txtMonto.CampoBusquedaID = "";
            this.txtMonto.CampoData = "Monto";
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColumnasBusqGeneral = null;
            this.txtMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMonto.Decimales = 0;
            this.txtMonto.DSData = this.DSDatos;
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(158, 163);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(164, 29);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
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
            this.txtConcepto.Location = new System.Drawing.Point(158, 235);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(500, 105);
            this.txtConcepto.TabIndex = 10;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTipoTransaccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Transaccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula\\RNC";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
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
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(158, 80);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(164, 29);
            this.txtCedulaRNC.TabIndex = 2;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // btnBuscarEntidad
            // 
            this.btnBuscarEntidad.AMostrar = null;
            myColumna1.Ancho = 100;
            myColumna1.HeaderText = "Id";
            myColumna1.NombreCampo = "Entidad_Id";
            myColumna2.Ancho = 150;
            myColumna2.HeaderText = "Cedula\\RNC";
            myColumna2.NombreCampo = "CedulaRNC";
            myColumna3.Ancho = 250;
            myColumna3.HeaderText = "Nombre";
            myColumna3.NombreCampo = "Nombre_Completo";
            this.btnBuscarEntidad.columnas = new WinControl_ELR_NET.MyColumna[] {
        myColumna1,
        myColumna2,
        myColumna3};
            this.btnBuscarEntidad.CondicionABuscar = "Campo_Busqueda Like \'%\' + @aBuscar + \'%\'";
            this.btnBuscarEntidad.CondicionOrderBY = "";
            this.btnBuscarEntidad.EsAutoIncremental = true;
            this.btnBuscarEntidad.FiltroEstatico = "EsActivo = 1";
            this.btnBuscarEntidad.Limite = 100;
            this.btnBuscarEntidad.Location = new System.Drawing.Point(328, 81);
            this.btnBuscarEntidad.Name = "btnBuscarEntidad";
            this.btnBuscarEntidad.Size = new System.Drawing.Size(70, 28);
            this.btnBuscarEntidad.TabIndex = 3;
            this.btnBuscarEntidad.TablaOVista = "VENTIDADES";
            this.btnBuscarEntidad.Text = "Buscar";
            this.btnBuscarEntidad.Titulo = "Busqueda General";
            this.btnBuscarEntidad.UseVisualStyleBackColor = true;
            this.btnBuscarEntidad.Click += new System.EventHandler(this.btnBuscarEntidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Entidad";
            // 
            // txtNombreEntidad
            // 
            this.txtNombreEntidad.AMostrar = null;
            this.txtNombreEntidad.AValidar = null;
            this.txtNombreEntidad.CampoBusquedaID = "";
            this.txtNombreEntidad.CampoData = "ANombre";
            this.txtNombreEntidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEntidad.ColumnasBusqGeneral = null;
            this.txtNombreEntidad.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreEntidad.Decimales = 0;
            this.txtNombreEntidad.DSData = this.DSDatos;
            this.txtNombreEntidad.EsAutoGenerado = false;
            this.txtNombreEntidad.EsBusqueda = false;
            this.txtNombreEntidad.EsEditable = true;
            this.txtNombreEntidad.FiltroBusqueda = "";
            this.txtNombreEntidad.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreEntidad.Location = new System.Drawing.Point(158, 124);
            this.txtNombreEntidad.Name = "txtNombreEntidad";
            this.txtNombreEntidad.NombreTabla = "";
            this.txtNombreEntidad.SepDecimal = '\0';
            this.txtNombreEntidad.Size = new System.Drawing.Size(507, 29);
            this.txtNombreEntidad.TabIndex = 5;
            this.txtNombreEntidad.TablaOVistaBusqueda = "";
            this.txtNombreEntidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreEntidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreEntidad.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto";
            // 
            // lblMontoLetra
            // 
            this.lblMontoLetra.AutoSize = true;
            this.lblMontoLetra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoLetra.Location = new System.Drawing.Point(151, 199);
            this.lblMontoLetra.Name = "lblMontoLetra";
            this.lblMontoLetra.Size = new System.Drawing.Size(137, 21);
            this.lblMontoLetra.TabIndex = 8;
            this.lblMontoLetra.Text = "MONTO EN LETRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Concepto";
            // 
            // FormCajaReciboOtrosIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboTipoTransaccion;
            valida1.Mensaje = "Debe Indicar el Tipo de Transaccion";
            valida1.NombreCampo = "Tipo_Trans";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtMonto;
            valida2.Mensaje = "El Monto Debe Ser Mayor a Cero";
            valida2.NombreCampo = "Monto";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtConcepto;
            valida3.Mensaje = "Debe Indicar un Concepto Minimo 15 Caracteres";
            valida3.NombreCampo = "Concepto";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida3.Valor1 = "15";
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(684, 398);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMontoLetra);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreEntidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarEntidad);
            this.Controls.Add(this.txtCedulaRNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnEjecusion = true;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.Ticket;
            this.ImprimirAlGrabar = true;
            this.MostrarDesglosePago = true;
            this.Name = "FormCajaReciboOtrosIngresos";
            this.NombreCampoID = "Recibo_Id";
            this.NombreReporte = "RptReciboCajaOtros";
            this.NombreVistaImprimir = "VCAJAS_RECIBOS";
            this.RequiereCajaAbierta = true;
            this.SPGraba = "SP_CAJAS_GRABA_RECIBO_OTROS_INGRESOS";
            this.TablaEncabezado = "TTEMPORAL_CAJAS_RECIBOS";
            this.Text = "REGISTRAR RECIBO OTROS INGRESOS";
            this.Load += new System.EventHandler(this.FormCajaReciboOtrosIngresos_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCedulaRNC, 0);
            this.Controls.SetChildIndex(this.btnBuscarEntidad, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNombreEntidad, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.lblMontoLetra, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRCombobox cboTipoTransaccion;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private WinControl_ELR_NET.ELRBotonBuscar btnBuscarEntidad;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtNombreEntidad;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label lblMontoLetra;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
    }
}