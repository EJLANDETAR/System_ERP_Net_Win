namespace ELRActivosFijos
{
    partial class FormActivosFijosCBUbicacionR
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
            this.txtActivoId = new WinControl_ELR_NET.ELRTextBox();
            this.cboAUbicacion = new WinControl_ELR_NET.ELRCombobox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUbicacionActual = new WinControl_ELR_NET.ELRCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActivoNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarUbicacion = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 351);
            this.pnBotones.Size = new System.Drawing.Size(640, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(400, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(541, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(305, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(210, 39);
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
            this.txtActivoId.EsBusquedaAutoIncremental = false;
            this.txtActivoId.EsEditable = true;
            this.txtActivoId.FiltroBusqueda = "";
            this.txtActivoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivoId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtActivoId.Location = new System.Drawing.Point(86, 27);
            this.txtActivoId.Name = "txtActivoId";
            this.txtActivoId.NombreTabla = "";
            this.txtActivoId.SepDecimal = '\0';
            this.txtActivoId.Size = new System.Drawing.Size(135, 29);
            this.txtActivoId.TabIndex = 23;
            this.txtActivoId.TablaOVistaBusqueda = "";
            this.txtActivoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoId.ValorPorDefecto = "";
            this.txtActivoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivoId_KeyDown);
            this.txtActivoId.Leave += new System.EventHandler(this.txtActivoId_Leave);
            // 
            // cboAUbicacion
            // 
            this.cboAUbicacion.AValidar = null;
            this.cboAUbicacion.CampoData = "AUbicacion_Id";
            this.cboAUbicacion.CampoJoinCombobox2 = "";
            this.cboAUbicacion.ComboboxAFiltrar = null;
            this.cboAUbicacion.DisplayMember = "Nombre";
            this.cboAUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAUbicacion.DSData = this.DSDatos;
            this.cboAUbicacion.EsEditable = true;
            this.cboAUbicacion.FiltroBusqueda = "";
            this.cboAUbicacion.FormattingEnabled = true;
            this.cboAUbicacion.Location = new System.Drawing.Point(153, 166);
            this.cboAUbicacion.Name = "cboAUbicacion";
            this.cboAUbicacion.NombreTabla = "";
            this.cboAUbicacion.Size = new System.Drawing.Size(404, 29);
            this.cboAUbicacion.SSQL = "";
            this.cboAUbicacion.TabIndex = 30;
            this.cboAUbicacion.TablaOVistaConsulta = "";
            this.cboAUbicacion.UsaDataGlobal = false;
            this.cboAUbicacion.ValorPorDefecto = "0";
            this.cboAUbicacion.ValueMember = "Ubicacion_Id";
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
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(153, 201);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(450, 90);
            this.txtConcepto.TabIndex = 32;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Concepto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nueva Ubicacion:";
            // 
            // cboUbicacionActual
            // 
            this.cboUbicacionActual.AValidar = null;
            this.cboUbicacionActual.CampoData = "DeUbicacion_Id";
            this.cboUbicacionActual.CampoJoinCombobox2 = "";
            this.cboUbicacionActual.ComboboxAFiltrar = null;
            this.cboUbicacionActual.DisplayMember = "Nombre";
            this.cboUbicacionActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUbicacionActual.DSData = this.DSDatos;
            this.cboUbicacionActual.Enabled = false;
            this.cboUbicacionActual.EsEditable = true;
            this.cboUbicacionActual.FiltroBusqueda = "";
            this.cboUbicacionActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUbicacionActual.FormattingEnabled = true;
            this.cboUbicacionActual.Location = new System.Drawing.Point(153, 131);
            this.cboUbicacionActual.Name = "cboUbicacionActual";
            this.cboUbicacionActual.NombreTabla = "";
            this.cboUbicacionActual.Size = new System.Drawing.Size(450, 29);
            this.cboUbicacionActual.SSQL = "";
            this.cboUbicacionActual.TabIndex = 28;
            this.cboUbicacionActual.TablaOVistaConsulta = "";
            this.cboUbicacionActual.UsaDataGlobal = false;
            this.cboUbicacionActual.ValorPorDefecto = "0";
            this.cboUbicacionActual.ValueMember = "Ubicacion_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ubicacion Actual:";
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
            this.txtActivoNombre.EsBusquedaAutoIncremental = false;
            this.txtActivoNombre.EsEditable = true;
            this.txtActivoNombre.FiltroBusqueda = "";
            this.txtActivoNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivoNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtActivoNombre.Location = new System.Drawing.Point(86, 61);
            this.txtActivoNombre.Multiline = true;
            this.txtActivoNombre.Name = "txtActivoNombre";
            this.txtActivoNombre.NombreTabla = "";
            this.txtActivoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtActivoNombre.SepDecimal = '\0';
            this.txtActivoNombre.Size = new System.Drawing.Size(517, 53);
            this.txtActivoNombre.TabIndex = 26;
            this.txtActivoNombre.TablaOVistaBusqueda = "";
            this.txtActivoNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoNombre.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ELRActivosFijos.Properties.Resources._1378160672_search;
            this.btnBuscar.Location = new System.Drawing.Point(227, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 29);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Activo:";
            // 
            // btnBuscarUbicacion
            // 
            this.btnBuscarUbicacion.Image = global::ELRActivosFijos.Properties.Resources._1378160672_search;
            this.btnBuscarUbicacion.Location = new System.Drawing.Point(563, 166);
            this.btnBuscarUbicacion.Name = "btnBuscarUbicacion";
            this.btnBuscarUbicacion.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarUbicacion.TabIndex = 33;
            this.btnBuscarUbicacion.UseVisualStyleBackColor = true;
            this.btnBuscarUbicacion.Click += new System.EventHandler(this.btnBuscarUbicacion_Click);
            // 
            // FormActivosFijosCBUbicacionR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtActivoId;
            valida1.Mensaje = "Debe Indicar el Activo Fijo";
            valida1.NombreCampo = "Activo_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.cboAUbicacion;
            valida2.Mensaje = "Debe Indicar la Nueva Ubicacion";
            valida2.NombreCampo = "AUbicacion_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
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
            this.ClientSize = new System.Drawing.Size(640, 394);
            this.Controls.Add(this.btnBuscarUbicacion);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboAUbicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboUbicacionActual);
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
            this.Name = "FormActivosFijosCBUbicacionR";
            this.SPGraba = "SP_ACTIVOS_FIJOS_GRABA_CAMBIO_UBICACION";
            this.TablaEncabezado = "TTEMPORAL_ACTIVOS_FIJOS_MOVIMIENTOS";
            this.Text = "REGISTRAR CAMBIO DE UBICACION DE ACTIVOS FIJOS";
            this.Load += new System.EventHandler(this.FormActivosFijosCBUbicacionR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtActivoId, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtActivoNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboUbicacionActual, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cboAUbicacion, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.btnBuscarUbicacion, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRCombobox cboAUbicacion;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRCombobox cboUbicacionActual;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtActivoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private WinControl_ELR_NET.ELRTextBox txtActivoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarUbicacion;
    }
}