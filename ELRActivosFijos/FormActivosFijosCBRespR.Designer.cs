namespace ELRActivosFijos
{
    partial class FormActivosFijosCBRespR
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
            this.txtActivoNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtActivoId = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeResponsable = new WinControl_ELR_NET.ELRTextBox();
            this.txtAResponsable = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 360);
            this.pnBotones.Size = new System.Drawing.Size(673, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(433, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(574, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(338, 0);
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
            this.txtActivoNombre.Location = new System.Drawing.Point(80, 59);
            this.txtActivoNombre.Multiline = true;
            this.txtActivoNombre.Name = "txtActivoNombre";
            this.txtActivoNombre.NombreTabla = "";
            this.txtActivoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtActivoNombre.SepDecimal = '\0';
            this.txtActivoNombre.Size = new System.Drawing.Size(555, 53);
            this.txtActivoNombre.TabIndex = 15;
            this.txtActivoNombre.TablaOVistaBusqueda = "";
            this.txtActivoNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoNombre.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ELRActivosFijos.Properties.Resources._1378160672_search;
            this.btnBuscar.Location = new System.Drawing.Point(221, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 29);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtActivoId
            // 
            this.txtActivoId.AMostrar = null;
            this.txtActivoId.AValidar = null;
            this.txtActivoId.BackColor = System.Drawing.Color.White;
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
            this.txtActivoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivoId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtActivoId.Location = new System.Drawing.Point(80, 25);
            this.txtActivoId.Name = "txtActivoId";
            this.txtActivoId.NombreTabla = "";
            this.txtActivoId.SepDecimal = '\0';
            this.txtActivoId.Size = new System.Drawing.Size(135, 29);
            this.txtActivoId.TabIndex = 12;
            this.txtActivoId.TablaOVistaBusqueda = "";
            this.txtActivoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoId.ValorPorDefecto = "";
            this.txtActivoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivoId_KeyDown);
            this.txtActivoId.Leave += new System.EventHandler(this.txtActivoId_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Activo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Responsable Actual:";
            // 
            // txtDeResponsable
            // 
            this.txtDeResponsable.AMostrar = null;
            this.txtDeResponsable.AValidar = null;
            this.txtDeResponsable.BackColor = System.Drawing.Color.White;
            this.txtDeResponsable.CampoBusquedaID = "";
            this.txtDeResponsable.CampoData = "DeResponsable";
            this.txtDeResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeResponsable.ColumnasBusqGeneral = null;
            this.txtDeResponsable.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDeResponsable.Decimales = 0;
            this.txtDeResponsable.DSData = this.DSDatos;
            this.txtDeResponsable.Enabled = false;
            this.txtDeResponsable.EsAutoGenerado = false;
            this.txtDeResponsable.EsBusqueda = false;
            this.txtDeResponsable.EsEditable = true;
            this.txtDeResponsable.FiltroBusqueda = "";
            this.txtDeResponsable.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDeResponsable.Location = new System.Drawing.Point(175, 143);
            this.txtDeResponsable.Name = "txtDeResponsable";
            this.txtDeResponsable.NombreTabla = "";
            this.txtDeResponsable.SepDecimal = '\0';
            this.txtDeResponsable.Size = new System.Drawing.Size(460, 29);
            this.txtDeResponsable.TabIndex = 17;
            this.txtDeResponsable.TablaOVistaBusqueda = "";
            this.txtDeResponsable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDeResponsable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDeResponsable.ValorPorDefecto = "";
            // 
            // txtAResponsable
            // 
            this.txtAResponsable.AMostrar = null;
            this.txtAResponsable.AValidar = null;
            this.txtAResponsable.CampoBusquedaID = "";
            this.txtAResponsable.CampoData = "AResponsable";
            this.txtAResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAResponsable.ColumnasBusqGeneral = null;
            this.txtAResponsable.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAResponsable.Decimales = 0;
            this.txtAResponsable.DSData = this.DSDatos;
            this.txtAResponsable.EsAutoGenerado = false;
            this.txtAResponsable.EsBusqueda = false;
            this.txtAResponsable.EsEditable = true;
            this.txtAResponsable.FiltroBusqueda = "";
            this.txtAResponsable.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtAResponsable.Location = new System.Drawing.Point(175, 178);
            this.txtAResponsable.Name = "txtAResponsable";
            this.txtAResponsable.NombreTabla = "";
            this.txtAResponsable.SepDecimal = '\0';
            this.txtAResponsable.Size = new System.Drawing.Size(460, 29);
            this.txtAResponsable.TabIndex = 19;
            this.txtAResponsable.TablaOVistaBusqueda = "";
            this.txtAResponsable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAResponsable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAResponsable.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nuevo Responsable:";
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
            this.txtConcepto.Location = new System.Drawing.Point(175, 213);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(460, 90);
            this.txtConcepto.TabIndex = 23;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Concepto:";
            // 
            // FormActivosFijosCBRespR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtActivoId;
            valida1.Mensaje = "Debe Indicar un Activo Fijo";
            valida1.NombreCampo = "Activo_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtAResponsable;
            valida2.Mensaje = "Debe Inciar un Responsable";
            valida2.NombreCampo = "AResponsable";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtConcepto;
            valida3.Mensaje = "Debe Indicar un Concepto";
            valida3.NombreCampo = "Concepto";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida3.Valor1 = "5";
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(673, 403);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAResponsable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeResponsable);
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
            this.Name = "FormActivosFijosCBRespR";
            this.SPGraba = "SP_ACTIVOS_FIJOS_GRABA_CAMBIO_RESP";
            this.TablaEncabezado = "TTEMPORAL_ACTIVOS_FIJOS_MOVIMIENTOS";
            this.Text = "REGISTRAR CAMBIO DE RESPONSABLE";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtActivoId, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtActivoNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDeResponsable, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtAResponsable, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRTextBox txtActivoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private WinControl_ELR_NET.ELRTextBox txtActivoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtDeResponsable;
        private WinControl_ELR_NET.ELRTextBox txtAResponsable;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label9;
    }
}