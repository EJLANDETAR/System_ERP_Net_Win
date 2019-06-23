namespace ELRMaestros
{
    partial class FormCategoriaProductoRegistro
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
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtTasaItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriaId = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 234);
            this.pnBotones.Size = new System.Drawing.Size(561, 52);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(289, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 48);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(430, 0);
            this.btnCancelar.Size = new System.Drawing.Size(127, 48);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 48);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(194, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 48);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(99, 48);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.autoSenTab = true;
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
            this.txtNombre.Location = new System.Drawing.Point(142, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(401, 29);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // txtTasaItbis
            // 
            this.txtTasaItbis.AMostrar = null;
            this.txtTasaItbis.autoSenTab = true;
            this.txtTasaItbis.AValidar = null;
            this.txtTasaItbis.CampoBusquedaID = "";
            this.txtTasaItbis.CampoData = "Tasa_Itbis";
            this.txtTasaItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaItbis.ColumnasBusqGeneral = null;
            this.txtTasaItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaItbis.Decimales = 0;
            this.txtTasaItbis.DSData = this.DSDatos;
            this.txtTasaItbis.EsAutoGenerado = false;
            this.txtTasaItbis.EsBusqueda = false;
            this.txtTasaItbis.EsBusquedaAutoIncremental = false;
            this.txtTasaItbis.EsEditable = true;
            this.txtTasaItbis.FiltroBusqueda = "";
            this.txtTasaItbis.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTasaItbis.Location = new System.Drawing.Point(142, 118);
            this.txtTasaItbis.Name = "txtTasaItbis";
            this.txtTasaItbis.NombreTabla = "";
            this.txtTasaItbis.SepDecimal = '\0';
            this.txtTasaItbis.Size = new System.Drawing.Size(166, 29);
            this.txtTasaItbis.TabIndex = 4;
            this.txtTasaItbis.TablaOVistaBusqueda = "";
            this.txtTasaItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTasaItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaItbis.ValorPorDefecto = "18.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tasa Itbis";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CampoData = "EsActivo";
            this.chkActivo.DSData = this.DSDatos;
            this.chkActivo.EsEditable = true;
            this.chkActivo.EsModificable = true;
            this.chkActivo.FiltroBusqueda = "";
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(142, 162);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.NombreTabla = "";
            this.chkActivo.Size = new System.Drawing.Size(98, 25);
            this.chkActivo.TabIndex = 5;
            this.chkActivo.Text = "Es Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.ValorPorDefecto = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria Id";
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.AMostrar = null;
            this.txtCategoriaId.autoSenTab = true;
            this.txtCategoriaId.AValidar = null;
            this.txtCategoriaId.CampoBusquedaID = "";
            this.txtCategoriaId.CampoData = "Categoria_Id";
            this.txtCategoriaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoriaId.ColumnasBusqGeneral = null;
            this.txtCategoriaId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCategoriaId.Decimales = 0;
            this.txtCategoriaId.DSData = this.DSDatos;
            this.txtCategoriaId.EsAutoGenerado = true;
            this.txtCategoriaId.EsBusqueda = false;
            this.txtCategoriaId.EsBusquedaAutoIncremental = false;
            this.txtCategoriaId.EsEditable = true;
            this.txtCategoriaId.FiltroBusqueda = "";
            this.txtCategoriaId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCategoriaId.Location = new System.Drawing.Point(142, 33);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.NombreTabla = "";
            this.txtCategoriaId.SepDecimal = '\0';
            this.txtCategoriaId.Size = new System.Drawing.Size(166, 29);
            this.txtCategoriaId.TabIndex = 7;
            this.txtCategoriaId.TablaOVistaBusqueda = "";
            this.txtCategoriaId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCategoriaId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCategoriaId.ValorPorDefecto = "0";
            // 
            // FormCategoriaProductoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Especificar el Nombre de La Categoria";
            valida1.NombreCampo = "Nombre";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtTasaItbis;
            valida2.Mensaje = "La Tasa de Itbis debe Ser Mayor o Igual a Cero";
            valida2.NombreCampo = "Tasa_Itbis";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "0";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(561, 286);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtTasaItbis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormCategoriaProductoRegistro";
            this.NombreCampoID = "Categoria_Id";
            this.TablaEncabezado = "TCLASIFICADOR_PRODUCTOS_CATEGORIAS";
            this.Text = "CATEGORIA DE PRODUCTOS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTasaItbis, 0);
            this.Controls.SetChildIndex(this.chkActivo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCategoriaId, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtTasaItbis;
        private WinControl_ELR_NET.ELRCheckBox chkActivo;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtCategoriaId;
    }
}