namespace ELRContaGeneral
{
    partial class FormContaEstadosR
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
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox2 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 259);
            this.pnBotones.Size = new System.Drawing.Size(574, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(334, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(239, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "Descripcion";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(98, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(451, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.BackColor = System.Drawing.Color.White;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Estado_Id";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.Enabled = false;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsEditable = false;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(97, 34);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(110, 29);
            this.elrTextBox1.TabIndex = 2;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "ESActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(98, 123);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 5;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // elrCheckBox2
            // 
            this.elrCheckBox2.AutoSize = true;
            this.elrCheckBox2.CampoData = "ESConAnexo";
            this.elrCheckBox2.DSData = this.DSDatos;
            this.elrCheckBox2.EsEditable = true;
            this.elrCheckBox2.EsModificable = true;
            this.elrCheckBox2.FiltroBusqueda = "";
            this.elrCheckBox2.Location = new System.Drawing.Point(224, 123);
            this.elrCheckBox2.Name = "elrCheckBox2";
            this.elrCheckBox2.NombreTabla = "";
            this.elrCheckBox2.Size = new System.Drawing.Size(130, 25);
            this.elrCheckBox2.TabIndex = 6;
            this.elrCheckBox2.Text = "Es Con Anexos";
            this.elrCheckBox2.UseVisualStyleBackColor = true;
            this.elrCheckBox2.ValorPorDefecto = true;
            // 
            // FormContaEstadosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Ingresar Nombre";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "4";
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(574, 302);
            this.Controls.Add(this.elrCheckBox2);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContaEstadosR";
            this.NombreCampoID = "Estado_Id";
            this.TablaEncabezado = "TCONTA_ESTADOS";
            this.Text = "REGISTRAR ESTADO FINANCIERO";
            this.Load += new System.EventHandler(this.FormContaEstadosR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.Controls.SetChildIndex(this.elrCheckBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox2;
    }
}