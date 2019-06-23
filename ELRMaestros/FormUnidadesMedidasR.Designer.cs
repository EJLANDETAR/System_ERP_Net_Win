namespace ELRMaestros
{
    partial class FormUnidadesMedidasR
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
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUMedidaId = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 246);
            this.pnBotones.Size = new System.Drawing.Size(512, 43);
            this.pnBotones.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(318, 0);
            this.btnGrabar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(413, 0);
            this.btnCancelar.TabIndex = 1;
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(122, 157);
            this.chkEsActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 6;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // txtNombre
            // 
            this.txtNombre.CampoData = "Descripcion";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Location = new System.Drawing.Point(122, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.Size = new System.Drawing.Size(362, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txtUMedidaId
            // 
            this.txtUMedidaId.CampoData = "UMedida_Id";
            this.txtUMedidaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUMedidaId.DSData = this.DSDatos;
            this.txtUMedidaId.EsAutoGenerado = false;
            this.txtUMedidaId.EsEditable = false;
            this.txtUMedidaId.FiltroBusqueda = "";
            this.txtUMedidaId.Location = new System.Drawing.Point(122, 31);
            this.txtUMedidaId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUMedidaId.Name = "txtUMedidaId";
            this.txtUMedidaId.NombreTabla = "";
            this.txtUMedidaId.ReadOnly = true;
            this.txtUMedidaId.Size = new System.Drawing.Size(112, 29);
            this.txtUMedidaId.TabIndex = 1;
            this.txtUMedidaId.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medida Id";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.CampoData = "Abreviatura";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Location = new System.Drawing.Point(121, 118);
            this.elrTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.Size = new System.Drawing.Size(113, 29);
            this.elrTextBox1.TabIndex = 5;
            this.elrTextBox1.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abreviatura";
            // 
            // FormUnidadesMedidasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Digitar el Nombre";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(512, 289);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUMedidaId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUnidadesMedidasR";
            this.NombreCampoID = "UMedida_Id";
            this.TablaEncabezado = "TCLASIFICADOR_PRODUCTOS_UNIDADES_MEDIDAS";
            this.Text = "REGISTRAR UNIDAD DE MEDIDA";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtUMedidaId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtUMedidaId;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private System.Windows.Forms.Label label3;
    }
}