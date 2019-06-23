namespace TallerRep
{
    partial class FormTallerCategoriasR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoriaId = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 222);
            this.pnBotones.Size = new System.Drawing.Size(537, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(343, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(438, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria Id";
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.CampoData = "Categoria_Id";
            this.txtCategoriaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoriaId.DSData = this.DSDatos;
            this.txtCategoriaId.EsAutoGenerado = false;
            this.txtCategoriaId.EsEditable = false;
            this.txtCategoriaId.FiltroBusqueda = "";
            this.txtCategoriaId.Location = new System.Drawing.Point(124, 31);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.NombreTabla = "";
            this.txtCategoriaId.ReadOnly = true;
            this.txtCategoriaId.Size = new System.Drawing.Size(100, 29);
            this.txtCategoriaId.TabIndex = 2;
            this.txtCategoriaId.ValorPorDefecto = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Location = new System.Drawing.Point(124, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.Size = new System.Drawing.Size(384, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CampoData = "EsActivo";
            this.chkActivo.DSData = this.DSDatos;
            this.chkActivo.EsEditable = true;
            this.chkActivo.EsModificable = true;
            this.chkActivo.FiltroBusqueda = "";
            this.chkActivo.Location = new System.Drawing.Point(124, 111);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.NombreTabla = "";
            this.chkActivo.Size = new System.Drawing.Size(91, 25);
            this.chkActivo.TabIndex = 5;
            this.chkActivo.Text = "Es Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.ValorPorDefecto = true;
            // 
            // FormTallerCategoriasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Digitar Nombre de la Categoria";
            valida1.NombreCampo = "Nombre";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(537, 265);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTallerCategoriasR";
            this.NombreCampoID = "Categoria_Id";
            this.TablaEncabezado = "TTALLER_CATEGORIAS";
            this.Text = "REGISTRO DE CATEGORIA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCategoriaId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.chkActivo, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCategoriaId;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCheckBox chkActivo;
    }
}