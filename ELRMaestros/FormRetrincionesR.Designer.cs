namespace ELRMaestros
{
    partial class FormRetrincionesR
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboCodigo = new WinControl_ELR_NET.ELRCombobox();
            this.txtValor = new WinControl_ELR_NET.ELRTextBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 389);
            this.pnBotones.Size = new System.Drawing.Size(667, 51);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(427, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(568, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(332, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(237, 47);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "A Restringir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // cboCodigo
            // 
            this.cboCodigo.AValidar = null;
            this.cboCodigo.CampoData = "Codigo";
            this.cboCodigo.CampoJoinCombobox2 = "";
            this.cboCodigo.ComboboxAFiltrar = null;
            this.cboCodigo.DisplayMember = "Descripcion";
            this.cboCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigo.DSData = this.DSDatos;
            this.cboCodigo.EsEditable = true;
            this.cboCodigo.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'TIPO_RESTRINCION\'";
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(143, 47);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.NombreTabla = "";
            this.cboCodigo.Size = new System.Drawing.Size(490, 29);
            this.cboCodigo.SSQL = "";
            this.cboCodigo.TabIndex = 3;
            this.cboCodigo.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboCodigo.UsaDataGlobal = false;
            this.cboCodigo.ValorPorDefecto = "ID";
            this.cboCodigo.ValueMember = "Id";
            // 
            // txtValor
            // 
            this.txtValor.AMostrar = null;
            this.txtValor.AValidar = null;
            this.txtValor.CampoBusquedaID = "";
            this.txtValor.CampoData = "Valor";
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.ColumnasBusqGeneral = null;
            this.txtValor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValor.Decimales = 0;
            this.txtValor.DSData = this.DSDatos;
            this.txtValor.EsAutoGenerado = false;
            this.txtValor.EsBusqueda = false;
            this.txtValor.EsBusquedaAutoIncremental = false;
            this.txtValor.EsEditable = true;
            this.txtValor.FiltroBusqueda = "";
            this.txtValor.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValor.Location = new System.Drawing.Point(143, 89);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.NombreTabla = "";
            this.txtValor.SepDecimal = '\0';
            this.txtValor.Size = new System.Drawing.Size(490, 181);
            this.txtValor.TabIndex = 4;
            this.txtValor.TablaOVistaBusqueda = "";
            this.txtValor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtValor.ValorPorDefecto = "";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(143, 296);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 5;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // FormRetrincionesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboCodigo;
            valida1.Mensaje = "Debe Indicar el tipo de Restrincion";
            valida1.NombreCampo = "Codigo";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtValor;
            valida2.Mensaje = "Debe Indicar un Valor";
            valida2.NombreCampo = "Valor";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(667, 440);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cboCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRetrincionesR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TCONFIGURACION_RETRINCIONES";
            this.Text = "REGISTRAR RESTRINCION";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboCodigo, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCombobox cboCodigo;
        private WinControl_ELR_NET.ELRTextBox txtValor;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
    }
}