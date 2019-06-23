namespace ELRMaestros
{
    partial class FormTipoEmpresasR
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
            this.label2 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 208);
            this.pnBotones.Size = new System.Drawing.Size(637, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(443, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(538, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(348, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Tipo_Id";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsEditable = false;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Location = new System.Drawing.Point(149, 30);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.ReadOnly = true;
            this.elrTextBox1.Size = new System.Drawing.Size(100, 29);
            this.elrTextBox1.TabIndex = 3;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "0";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AMostrar = null;
            this.txtDescripcion.AValidar = null;
            this.txtDescripcion.CampoBusquedaID = "";
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColumnasBusqGeneral = null;
            this.txtDescripcion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsBusqueda = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Location = new System.Drawing.Point(149, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.Size = new System.Drawing.Size(454, 29);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.TablaOVistaBusqueda = "";
            this.txtDescripcion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescripcion.TituloBusqueda = "BUSQUEDA GENERAL";
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
            this.elrCheckBox1.Location = new System.Drawing.Point(149, 114);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(87, 25);
            this.elrCheckBox1.TabIndex = 5;
            this.elrCheckBox1.Text = "EsActivo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormTipoEmpresasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtDescripcion;
            valida1.Mensaje = "Debe Indicar o una Descripcion, Minimo 5 Caracteres";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "5";
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(637, 251);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTipoEmpresasR";
            this.NombreCampoID = "Tipo_Id";
            this.TablaEncabezado = "TCLASIFICADOR_TIPOS_EMPRESAS";
            this.Text = "REGISTRO DE TIPOS DE EMPRESAS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
    }
}