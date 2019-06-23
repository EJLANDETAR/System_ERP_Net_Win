namespace ELRMaestros
{
    partial class FormTipoProductosDGIIR
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
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida6 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida7 = new WinControl_ELR_NET.Valida();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoId = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetItebisFisica = new WinControl_ELR_NET.ELRTextBox();
            this.txtRetNetoFisica = new WinControl_ELR_NET.ELRTextBox();
            this.txtRetNetoFisicaRegistrada = new WinControl_ELR_NET.ELRTextBox();
            this.txtRetItbisFisicaRegistrada = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRetNetoJuridica = new WinControl_ELR_NET.ELRTextBox();
            this.txtRetItbisJuridica = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 384);
            this.pnBotones.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Id";
            // 
            // txtTipoId
            // 
            this.txtTipoId.CampoData = "Tipo_Id";
            this.txtTipoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoId.DSData = this.DSDatos;
            this.txtTipoId.EsAutoGenerado = false;
            this.txtTipoId.EsEditable = false;
            this.txtTipoId.FiltroBusqueda = "";
            this.txtTipoId.Location = new System.Drawing.Point(114, 34);
            this.txtTipoId.Name = "txtTipoId";
            this.txtTipoId.NombreTabla = "";
            this.txtTipoId.ReadOnly = true;
            this.txtTipoId.Size = new System.Drawing.Size(100, 29);
            this.txtTipoId.TabIndex = 1;
            this.txtTipoId.ValorPorDefecto = "0";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Location = new System.Drawing.Point(114, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.Size = new System.Drawing.Size(474, 29);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRetNetoJuridica);
            this.groupBox1.Controls.Add(this.txtRetItbisJuridica);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRetNetoFisicaRegistrada);
            this.groupBox1.Controls.Add(this.txtRetItbisFisicaRegistrada);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRetNetoFisica);
            this.groupBox1.Controls.Add(this.txtRetItebisFisica);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla Retenciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Itebis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Neto( Ante de Itebis)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Persona Fisica";
            // 
            // txtRetItebisFisica
            // 
            this.txtRetItebisFisica.CampoData = "Ret_Itbis_Fisica";
            this.txtRetItebisFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetItebisFisica.DSData = this.DSDatos;
            this.txtRetItebisFisica.EsAutoGenerado = false;
            this.txtRetItebisFisica.EsEditable = true;
            this.txtRetItebisFisica.FiltroBusqueda = "";
            this.txtRetItebisFisica.Location = new System.Drawing.Point(220, 76);
            this.txtRetItebisFisica.Name = "txtRetItebisFisica";
            this.txtRetItebisFisica.NombreTabla = "";
            this.txtRetItebisFisica.Size = new System.Drawing.Size(131, 29);
            this.txtRetItebisFisica.TabIndex = 3;
            this.txtRetItebisFisica.Text = "0.00";
            this.txtRetItebisFisica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetItebisFisica.ValorPorDefecto = "0.00";
            // 
            // txtRetNetoFisica
            // 
            this.txtRetNetoFisica.CampoData = "Ret_Neto_Fisica";
            this.txtRetNetoFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetNetoFisica.DSData = this.DSDatos;
            this.txtRetNetoFisica.EsAutoGenerado = false;
            this.txtRetNetoFisica.EsEditable = true;
            this.txtRetNetoFisica.FiltroBusqueda = "";
            this.txtRetNetoFisica.Location = new System.Drawing.Point(397, 76);
            this.txtRetNetoFisica.Name = "txtRetNetoFisica";
            this.txtRetNetoFisica.NombreTabla = "";
            this.txtRetNetoFisica.Size = new System.Drawing.Size(131, 29);
            this.txtRetNetoFisica.TabIndex = 4;
            this.txtRetNetoFisica.Text = "0.00";
            this.txtRetNetoFisica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetNetoFisica.ValorPorDefecto = "0.00";
            // 
            // txtRetNetoFisicaRegistrada
            // 
            this.txtRetNetoFisicaRegistrada.CampoData = "Ret_Neto_Fisica_Registrada";
            this.txtRetNetoFisicaRegistrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetNetoFisicaRegistrada.DSData = this.DSDatos;
            this.txtRetNetoFisicaRegistrada.EsAutoGenerado = false;
            this.txtRetNetoFisicaRegistrada.EsEditable = true;
            this.txtRetNetoFisicaRegistrada.FiltroBusqueda = "";
            this.txtRetNetoFisicaRegistrada.Location = new System.Drawing.Point(397, 119);
            this.txtRetNetoFisicaRegistrada.Name = "txtRetNetoFisicaRegistrada";
            this.txtRetNetoFisicaRegistrada.NombreTabla = "";
            this.txtRetNetoFisicaRegistrada.Size = new System.Drawing.Size(131, 29);
            this.txtRetNetoFisicaRegistrada.TabIndex = 7;
            this.txtRetNetoFisicaRegistrada.Text = "0.00";
            this.txtRetNetoFisicaRegistrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetNetoFisicaRegistrada.ValorPorDefecto = "0.00";
            // 
            // txtRetItbisFisicaRegistrada
            // 
            this.txtRetItbisFisicaRegistrada.CampoData = "Ret_Itbis_Fisica_Registrada";
            this.txtRetItbisFisicaRegistrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetItbisFisicaRegistrada.DSData = this.DSDatos;
            this.txtRetItbisFisicaRegistrada.EsAutoGenerado = false;
            this.txtRetItbisFisicaRegistrada.EsEditable = true;
            this.txtRetItbisFisicaRegistrada.FiltroBusqueda = "";
            this.txtRetItbisFisicaRegistrada.Location = new System.Drawing.Point(220, 119);
            this.txtRetItbisFisicaRegistrada.Name = "txtRetItbisFisicaRegistrada";
            this.txtRetItbisFisicaRegistrada.NombreTabla = "";
            this.txtRetItbisFisicaRegistrada.Size = new System.Drawing.Size(131, 29);
            this.txtRetItbisFisicaRegistrada.TabIndex = 6;
            this.txtRetItbisFisicaRegistrada.Text = "0.00";
            this.txtRetItbisFisicaRegistrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetItbisFisicaRegistrada.ValorPorDefecto = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Persona Fisica Registrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Persona Juridica";
            // 
            // txtRetNetoJuridica
            // 
            this.txtRetNetoJuridica.CampoData = "Ret_Neto_Juridica";
            this.txtRetNetoJuridica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetNetoJuridica.DSData = this.DSDatos;
            this.txtRetNetoJuridica.EsAutoGenerado = false;
            this.txtRetNetoJuridica.EsEditable = true;
            this.txtRetNetoJuridica.FiltroBusqueda = "";
            this.txtRetNetoJuridica.Location = new System.Drawing.Point(397, 158);
            this.txtRetNetoJuridica.Name = "txtRetNetoJuridica";
            this.txtRetNetoJuridica.NombreTabla = "";
            this.txtRetNetoJuridica.Size = new System.Drawing.Size(131, 29);
            this.txtRetNetoJuridica.TabIndex = 10;
            this.txtRetNetoJuridica.Text = "0.00";
            this.txtRetNetoJuridica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetNetoJuridica.ValorPorDefecto = "0.00";
            // 
            // txtRetItbisJuridica
            // 
            this.txtRetItbisJuridica.CampoData = "Ret_Itbis_Juridica";
            this.txtRetItbisJuridica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetItbisJuridica.DSData = this.DSDatos;
            this.txtRetItbisJuridica.EsAutoGenerado = false;
            this.txtRetItbisJuridica.EsEditable = true;
            this.txtRetItbisJuridica.FiltroBusqueda = "";
            this.txtRetItbisJuridica.Location = new System.Drawing.Point(220, 158);
            this.txtRetItbisJuridica.Name = "txtRetItbisJuridica";
            this.txtRetItbisJuridica.NombreTabla = "";
            this.txtRetItbisJuridica.Size = new System.Drawing.Size(131, 29);
            this.txtRetItbisJuridica.TabIndex = 9;
            this.txtRetItbisJuridica.Text = "0.00";
            this.txtRetItbisJuridica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetItbisJuridica.ValorPorDefecto = "0.00";
            // 
            // FormTipoProductosDGIIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtDescripcion;
            valida1.Mensaje = "Debe Digitar la Descripcion";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtRetItebisFisica;
            valida2.Mensaje = "El Valor debe Estar entre 0 y 100";
            valida2.NombreCampo = "Ret_Itbis_Fisica";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida2.Valor1 = "0";
            valida2.Valor2 = "100";
            valida3.comtrol = this.txtRetNetoFisica;
            valida3.Mensaje = "El Valor debe Estar entre 0 y 100";
            valida3.NombreCampo = "Ret_Neto_Fisica";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida3.Valor1 = "0";
            valida3.Valor2 = "100";
            valida4.comtrol = this.txtRetItbisFisicaRegistrada;
            valida4.Mensaje = "El Valor debe Estar entre 0 y 100";
            valida4.NombreCampo = "Ret_Itbis_Fisica_Registrada";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida4.Valor1 = "0";
            valida4.Valor2 = "100";
            valida5.comtrol = this.txtRetNetoFisicaRegistrada;
            valida5.Mensaje = "El Valor debe Estar entre 0 y 100";
            valida5.NombreCampo = "Ret_Neto_Fisica_Registrada";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida5.Valor1 = "0";
            valida5.Valor2 = "100";
            valida6.comtrol = this.txtRetItbisJuridica;
            valida6.Mensaje = "El Valor debe Estar entre 0 y 100";
            valida6.NombreCampo = "Ret_Itbis_Juridica";
            valida6.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida6.Valor1 = "0";
            valida6.Valor2 = "100";
            valida7.comtrol = this.txtRetNetoJuridica;
            valida7.Mensaje = "El Valor debe Estar entre 0 y 100";
            valida7.NombreCampo = "Ret_Neto_Juridica";
            valida7.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.EnRango;
            valida7.Valor1 = "0";
            valida7.Valor2 = "100";
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5,
        valida6,
        valida7};
            this.ClientSize = new System.Drawing.Size(631, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipoId);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTipoProductosDGIIR";
            this.NombreCampoID = "Tipo_Id";
            this.TablaEncabezado = "TCLASIFICADOR_PRODUCTOS_TIPOS_DGII";
            this.Text = "REGISTRO TIPO PRODUCTO DGII";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTipoId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtTipoId;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtRetNetoJuridica;
        private WinControl_ELR_NET.ELRTextBox txtRetItbisJuridica;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtRetNetoFisicaRegistrada;
        private WinControl_ELR_NET.ELRTextBox txtRetItbisFisicaRegistrada;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtRetNetoFisica;
        private WinControl_ELR_NET.ELRTextBox txtRetItebisFisica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}