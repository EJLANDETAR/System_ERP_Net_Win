namespace ELRFacturas
{
    partial class FormCajaRecibosInicialR
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
            this.lblMontoLetra = new System.Windows.Forms.Label();
            this.txtMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEntidad = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 334);
            this.pnBotones.Size = new System.Drawing.Size(630, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(436, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(531, 0);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 0;
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(341, 0);
            this.btnSiguientePage.TabIndex = 0;
            // 
            // lblMontoLetra
            // 
            this.lblMontoLetra.AutoSize = true;
            this.lblMontoLetra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoLetra.Location = new System.Drawing.Point(141, 181);
            this.lblMontoLetra.Name = "lblMontoLetra";
            this.lblMontoLetra.Size = new System.Drawing.Size(137, 21);
            this.lblMontoLetra.TabIndex = 7;
            this.lblMontoLetra.Text = "MONTO EN LETRA";
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
            this.txtMonto.EsAutoGenerado = false;
            this.txtMonto.EsBusqueda = false;
            this.txtMonto.EsEditable = true;
            this.txtMonto.FiltroBusqueda = "";
            this.txtMonto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMonto.Location = new System.Drawing.Point(148, 145);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.NombreTabla = "";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SepDecimal = '\0';
            this.txtMonto.Size = new System.Drawing.Size(164, 29);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.TablaOVistaBusqueda = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMonto.ValorPorDefecto = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto";
            // 
            // txtNombreEntidad
            // 
            this.txtNombreEntidad.AMostrar = null;
            this.txtNombreEntidad.AValidar = null;
            this.txtNombreEntidad.BackColor = System.Drawing.Color.White;
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
            this.txtNombreEntidad.Location = new System.Drawing.Point(148, 106);
            this.txtNombreEntidad.Name = "txtNombreEntidad";
            this.txtNombreEntidad.NombreTabla = "";
            this.txtNombreEntidad.ReadOnly = true;
            this.txtNombreEntidad.SepDecimal = '\0';
            this.txtNombreEntidad.Size = new System.Drawing.Size(462, 29);
            this.txtNombreEntidad.TabIndex = 4;
            this.txtNombreEntidad.TablaOVistaBusqueda = "";
            this.txtNombreEntidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreEntidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreEntidad.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Entidad";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.BackColor = System.Drawing.Color.White;
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
            this.txtCedulaRNC.Location = new System.Drawing.Point(148, 62);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.ReadOnly = true;
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(164, 29);
            this.txtCedulaRNC.TabIndex = 2;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula\\RNC";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
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
            this.txtConcepto.Location = new System.Drawing.Point(148, 220);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(462, 77);
            this.txtConcepto.TabIndex = 9;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Concepto";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECIBO INICIAL FACTURA A CREDITO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCajaRecibosInicialR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMontoLetra);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreEntidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedulaRNC);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.Ticket;
            this.ImprimirAlGrabar = true;
            this.MostrarDesglosePago = true;
            this.Name = "FormCajaRecibosInicialR";
            this.NombreCampoID = "Recibo_Id";
            this.NombreReporte = "RptReciboCajaOtros";
            this.NombreVistaImprimir = "VCAJAS_RECIBOS";
            this.RequiereCajaAbierta = true;
            this.SPGraba = "SP_CAJAS_GRABA_RECIBO_INICIAL";
            this.TablaEncabezado = "TTEMPORAL_CAJAS_RECIBOS";
            this.Text = "REGISTRAR RECIBO, INICAL FACTURA NO.:";
            this.Load += new System.EventHandler(this.FormCajaRecibosInicialR_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCedulaRNC, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNombreEntidad, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.lblMontoLetra, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoLetra;
        private WinControl_ELR_NET.ELRTextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtNombreEntidad;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}