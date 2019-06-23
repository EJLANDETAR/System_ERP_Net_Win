namespace ELRFacturas
{
    partial class FormTipoGarantiasR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 151);
            this.pnBotones.Size = new System.Drawing.Size(463, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(269, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(364, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoData = "Tipo_Garantia_Id";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsEditable = false;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Location = new System.Drawing.Point(115, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.Size = new System.Drawing.Size(107, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Location = new System.Drawing.Point(115, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.Size = new System.Drawing.Size(325, 29);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(115, 96);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 5;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormTipoGarantiasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigo;
            valida1.Mensaje = "Debe Digitar el Codigo o Id";
            valida1.NombreCampo = "Tipo_Garantia_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtDescripcion;
            valida2.Mensaje = "Debe Digitar Nombre o Descripcion";
            valida2.NombreCampo = "Descripcion";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtDescripcion;
            valida3.Mensaje = "La Descripcion debe Tener un Minimo de 5 Carcteres";
            valida3.NombreCampo = "Descripcion";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida3.Valor1 = "5";
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(463, 194);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FormTipoGarantiasR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TPRESTAMOS_TIPO_GARANTIAS";
            this.Text = "TIPO GARANTIA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
    }
}