namespace ELRMaestros
{
    partial class FormProvinciasR
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
            this.txtProvinciaId = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPais = new WinControl_ELR_NET.ELRCombobox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 239);
            this.pnBotones.Size = new System.Drawing.Size(511, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(317, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincia Id";
            // 
            // txtProvinciaId
            // 
            this.txtProvinciaId.CampoData = "Provincia_Id";
            this.txtProvinciaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProvinciaId.DSData = this.DSDatos;
            this.txtProvinciaId.EsAutoGenerado = false;
            this.txtProvinciaId.EsEditable = false;
            this.txtProvinciaId.FiltroBusqueda = "";
            this.txtProvinciaId.Location = new System.Drawing.Point(119, 29);
            this.txtProvinciaId.Name = "txtProvinciaId";
            this.txtProvinciaId.NombreTabla = "";
            this.txtProvinciaId.ReadOnly = true;
            this.txtProvinciaId.Size = new System.Drawing.Size(114, 29);
            this.txtProvinciaId.TabIndex = 2;
            this.txtProvinciaId.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pais";
            // 
            // cboPais
            // 
            this.cboPais.CampoData = "Pais_Id";
            this.cboPais.CampoJoinCombobox2 = "";
            this.cboPais.ComboboxAFiltrar = null;
            this.cboPais.DisplayMember = "Nombre";
            this.cboPais.DSData = this.DSDatos;
            this.cboPais.EsEditable = true;
            this.cboPais.FiltroBusqueda = "";
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(119, 64);
            this.cboPais.Name = "cboPais";
            this.cboPais.NombreTabla = "";
            this.cboPais.Size = new System.Drawing.Size(356, 29);
            this.cboPais.SSQL = "";
            this.cboPais.TabIndex = 4;
            this.cboPais.TablaOVistaConsulta = "TZONAS_PAISES";
            this.cboPais.ValorPorDefecto = "1";
            this.cboPais.ValueMember = "Pais_Id";
            // 
            // txtNombre
            // 
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Location = new System.Drawing.Point(119, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.Size = new System.Drawing.Size(356, 29);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(119, 135);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 7;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormProvinciasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.cboPais;
            valida1.Mensaje = "Debe Seleccional el Pais";
            valida1.NombreCampo = "Pais_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "El Nombre de la Provincia Debe Tener Minimo 5 Caracteres";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(511, 282);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProvinciaId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProvinciasR";
            this.NombreCampoID = "Provincia_Id";
            this.TablaEncabezado = "TZONAS_PROVINCIAS";
            this.Text = "REGISTRO DE PROVINCIAS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtProvinciaId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboPais, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
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
        private WinControl_ELR_NET.ELRTextBox txtProvinciaId;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCombobox cboPais;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
    }
}