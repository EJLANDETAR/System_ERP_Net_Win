namespace ELRMaestros
{
    partial class FormMunicipiosR
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
            this.cboProvincia = new WinControl_ELR_NET.ELRCombobox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMunicipioId = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 198);
            this.pnBotones.Size = new System.Drawing.Size(532, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(292, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(433, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(197, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(102, 39);
            // 
            // cboProvincia
            // 
            this.cboProvincia.AValidar = null;
            this.cboProvincia.CampoData = "Provincia_Id";
            this.cboProvincia.CampoJoinCombobox2 = "";
            this.cboProvincia.ComboboxAFiltrar = null;
            this.cboProvincia.DisplayMember = "Nombre";
            this.cboProvincia.DSData = this.DSDatos;
            this.cboProvincia.EsEditable = true;
            this.cboProvincia.FiltroBusqueda = "";
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(119, 59);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.NombreTabla = "";
            this.cboProvincia.Size = new System.Drawing.Size(326, 29);
            this.cboProvincia.SSQL = "";
            this.cboProvincia.TabIndex = 6;
            this.cboProvincia.TablaOVistaConsulta = "TZONAS_PROVINCIAS";
            this.cboProvincia.UsaDataGlobal = false;
            this.cboProvincia.ValorPorDefecto = "0";
            this.cboProvincia.ValueMember = "Provincia_Id";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(119, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(379, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Municipio Id";
            // 
            // txtMunicipioId
            // 
            this.txtMunicipioId.AMostrar = null;
            this.txtMunicipioId.AValidar = null;
            this.txtMunicipioId.CampoBusquedaID = "";
            this.txtMunicipioId.CampoData = "Municipio_Id";
            this.txtMunicipioId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipioId.ColumnasBusqGeneral = null;
            this.txtMunicipioId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMunicipioId.Decimales = 0;
            this.txtMunicipioId.DSData = this.DSDatos;
            this.txtMunicipioId.EsAutoGenerado = false;
            this.txtMunicipioId.EsBusqueda = false;
            this.txtMunicipioId.EsBusquedaAutoIncremental = false;
            this.txtMunicipioId.EsEditable = true;
            this.txtMunicipioId.FiltroBusqueda = "";
            this.txtMunicipioId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMunicipioId.Location = new System.Drawing.Point(119, 24);
            this.txtMunicipioId.Name = "txtMunicipioId";
            this.txtMunicipioId.NombreTabla = "";
            this.txtMunicipioId.ReadOnly = true;
            this.txtMunicipioId.SepDecimal = '\0';
            this.txtMunicipioId.Size = new System.Drawing.Size(108, 29);
            this.txtMunicipioId.TabIndex = 2;
            this.txtMunicipioId.TablaOVistaBusqueda = "";
            this.txtMunicipioId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMunicipioId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMunicipioId.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Provincia";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(119, 129);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 7;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ELRMaestros.Properties.Resources._1378160672_search___Copy__2_;
            this.btnBuscar.Location = new System.Drawing.Point(451, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 29);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormMunicipiosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboProvincia;
            valida1.Mensaje = "Debe Selecional Provincia";
            valida1.NombreCampo = "Provincia_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "Debe Digitar el Nombre";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(532, 241);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMunicipioId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMunicipiosR";
            this.NombreCampoID = "Municipio_Id";
            this.TablaEncabezado = "TZONAS_MUNICIPIOS";
            this.Text = "REGISTRO DE MUNICIPIOS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMunicipioId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboProvincia, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtMunicipioId;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboProvincia;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.Button btnBuscar;
    }
}