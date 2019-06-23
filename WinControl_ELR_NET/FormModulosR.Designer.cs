namespace WinControl_ELR_NET
{
    partial class FormModulosR
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
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModuloId = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.elrNumericUpdDown1 = new WinControl_ELR_NET.ELRNumericUpdDown();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elrNumericUpdDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 217);
            this.pnBotones.Size = new System.Drawing.Size(561, 43);
            this.pnBotones.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(367, 0);
            this.btnGrabar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(462, 0);
            this.btnCancelar.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.CampoData = "Carpeta";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Location = new System.Drawing.Point(181, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.Size = new System.Drawing.Size(360, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo Id";
            // 
            // txtModuloId
            // 
            this.txtModuloId.CampoData = "Modulo_Id";
            this.txtModuloId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModuloId.DSData = this.DSDatos;
            this.txtModuloId.EsAutoGenerado = false;
            this.txtModuloId.EsEditable = false;
            this.txtModuloId.FiltroBusqueda = "";
            this.txtModuloId.Location = new System.Drawing.Point(181, 36);
            this.txtModuloId.Name = "txtModuloId";
            this.txtModuloId.NombreTabla = "";
            this.txtModuloId.ReadOnly = true;
            this.txtModuloId.Size = new System.Drawing.Size(107, 29);
            this.txtModuloId.TabIndex = 1;
            this.txtModuloId.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre o Carpeta";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(181, 154);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 6;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Orden en Menu";
            // 
            // elrNumericUpdDown1
            // 
            this.elrNumericUpdDown1.CampoData = "No_Orden_Menu";
            this.elrNumericUpdDown1.DSData = this.DSDatos;
            this.elrNumericUpdDown1.EsEditable = true;
            this.elrNumericUpdDown1.Location = new System.Drawing.Point(181, 110);
            this.elrNumericUpdDown1.Name = "elrNumericUpdDown1";
            this.elrNumericUpdDown1.NombreTabla = "";
            this.elrNumericUpdDown1.Size = new System.Drawing.Size(107, 29);
            this.elrNumericUpdDown1.TabIndex = 5;
            this.elrNumericUpdDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.elrNumericUpdDown1.ValorPorDefecto = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormModulosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Digitar el Nombre del Modulo";
            valida1.NombreCampo = "Carpeta";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(561, 260);
            this.Controls.Add(this.elrNumericUpdDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModuloId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModulosR";
            this.NombreCampoID = "Modulo_Id";
            this.TablaEncabezado = "TSISTEMA_MODULOS";
            this.Text = "REGISTRO MODULO DEL SISTEMA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtModuloId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.elrNumericUpdDown1, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elrNumericUpdDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ELRTextBox txtModuloId;
        private ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private ELRCheckBox elrCheckBox1;
        private System.Windows.Forms.Label label3;
        private ELRNumericUpdDown elrNumericUpdDown1;
    }
}