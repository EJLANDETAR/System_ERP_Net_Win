namespace ELRMaestros
{
    partial class FormDocTemplatesR
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
            this.elrTextBox2 = new WinControl_ELR_NET.ELRTextBox();
            this.elrCombobox1 = new WinControl_ELR_NET.ELRCombobox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox2 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox3 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox4 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox5 = new WinControl_ELR_NET.ELRCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elrCheckBox6 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox7 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox8 = new WinControl_ELR_NET.ELRCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elrTextBox3 = new WinControl_ELR_NET.ELRTextBox();
            this.cboCodigo = new WinControl_ELR_NET.ELRCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEvento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 401);
            this.pnBotones.Size = new System.Drawing.Size(726, 51);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(486, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(627, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(391, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(296, 47);
            // 
            // elrTextBox2
            // 
            this.elrTextBox2.AMostrar = null;
            this.elrTextBox2.AValidar = null;
            this.elrTextBox2.CampoBusquedaID = "";
            this.elrTextBox2.CampoData = "Descripcion";
            this.elrTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox2.ColumnasBusqGeneral = null;
            this.elrTextBox2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox2.Decimales = 0;
            this.elrTextBox2.DSData = this.DSDatos;
            this.elrTextBox2.EsAutoGenerado = false;
            this.elrTextBox2.EsBusqueda = false;
            this.elrTextBox2.EsBusquedaAutoIncremental = false;
            this.elrTextBox2.EsEditable = true;
            this.elrTextBox2.FiltroBusqueda = "";
            this.elrTextBox2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox2.Location = new System.Drawing.Point(184, 95);
            this.elrTextBox2.Name = "elrTextBox2";
            this.elrTextBox2.NombreTabla = "";
            this.elrTextBox2.SepDecimal = '\0';
            this.elrTextBox2.Size = new System.Drawing.Size(517, 29);
            this.elrTextBox2.TabIndex = 2;
            this.elrTextBox2.TablaOVistaBusqueda = "";
            this.elrTextBox2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox2.ValorPorDefecto = "";
            // 
            // elrCombobox1
            // 
            this.elrCombobox1.AValidar = null;
            this.elrCombobox1.CampoData = "Tipo_Garantia_Id";
            this.elrCombobox1.CampoJoinCombobox2 = "";
            this.elrCombobox1.ComboboxAFiltrar = null;
            this.elrCombobox1.DisplayMember = "Descripcion";
            this.elrCombobox1.DSData = this.DSDatos;
            this.elrCombobox1.EsEditable = true;
            this.elrCombobox1.FiltroBusqueda = "";
            this.elrCombobox1.FormattingEnabled = true;
            this.elrCombobox1.Location = new System.Drawing.Point(184, 58);
            this.elrCombobox1.Name = "elrCombobox1";
            this.elrCombobox1.NombreTabla = "";
            this.elrCombobox1.Size = new System.Drawing.Size(517, 29);
            this.elrCombobox1.SSQL = "";
            this.elrCombobox1.TabIndex = 3;
            this.elrCombobox1.TablaOVistaConsulta = "TPRESTAMOS_TIPO_GARANTIAS";
            this.elrCombobox1.UsaDataGlobal = false;
            this.elrCombobox1.ValorPorDefecto = "0";
            this.elrCombobox1.ValueMember = "Tipo_Garantia_Id";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "ESActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(185, 246);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 4;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // elrCheckBox2
            // 
            this.elrCheckBox2.AutoSize = true;
            this.elrCheckBox2.CampoData = "EsReimprimir";
            this.elrCheckBox2.DSData = this.DSDatos;
            this.elrCheckBox2.EsEditable = true;
            this.elrCheckBox2.EsModificable = true;
            this.elrCheckBox2.FiltroBusqueda = "";
            this.elrCheckBox2.Location = new System.Drawing.Point(185, 277);
            this.elrCheckBox2.Name = "elrCheckBox2";
            this.elrCheckBox2.NombreTabla = "";
            this.elrCheckBox2.Size = new System.Drawing.Size(127, 25);
            this.elrCheckBox2.TabIndex = 5;
            this.elrCheckBox2.Text = "Es Reimprimir";
            this.elrCheckBox2.UseVisualStyleBackColor = true;
            this.elrCheckBox2.ValorPorDefecto = true;
            // 
            // elrCheckBox3
            // 
            this.elrCheckBox3.AutoSize = true;
            this.elrCheckBox3.CampoData = "ConNotario";
            this.elrCheckBox3.DSData = this.DSDatos;
            this.elrCheckBox3.EsEditable = true;
            this.elrCheckBox3.EsModificable = true;
            this.elrCheckBox3.FiltroBusqueda = "";
            this.elrCheckBox3.Location = new System.Drawing.Point(428, 246);
            this.elrCheckBox3.Name = "elrCheckBox3";
            this.elrCheckBox3.NombreTabla = "";
            this.elrCheckBox3.Size = new System.Drawing.Size(114, 25);
            this.elrCheckBox3.TabIndex = 7;
            this.elrCheckBox3.Text = "Con Notario";
            this.elrCheckBox3.UseVisualStyleBackColor = true;
            this.elrCheckBox3.ValorPorDefecto = true;
            // 
            // elrCheckBox4
            // 
            this.elrCheckBox4.AutoSize = true;
            this.elrCheckBox4.CampoData = "ConAbogado";
            this.elrCheckBox4.DSData = this.DSDatos;
            this.elrCheckBox4.EsEditable = true;
            this.elrCheckBox4.EsModificable = true;
            this.elrCheckBox4.FiltroBusqueda = "";
            this.elrCheckBox4.Location = new System.Drawing.Point(428, 277);
            this.elrCheckBox4.Name = "elrCheckBox4";
            this.elrCheckBox4.NombreTabla = "";
            this.elrCheckBox4.Size = new System.Drawing.Size(124, 25);
            this.elrCheckBox4.TabIndex = 6;
            this.elrCheckBox4.Text = "Con Abogado";
            this.elrCheckBox4.UseVisualStyleBackColor = true;
            this.elrCheckBox4.ValorPorDefecto = true;
            // 
            // elrCheckBox5
            // 
            this.elrCheckBox5.AutoSize = true;
            this.elrCheckBox5.CampoData = "ConGerente";
            this.elrCheckBox5.DSData = this.DSDatos;
            this.elrCheckBox5.EsEditable = true;
            this.elrCheckBox5.EsModificable = true;
            this.elrCheckBox5.FiltroBusqueda = "";
            this.elrCheckBox5.Location = new System.Drawing.Point(185, 339);
            this.elrCheckBox5.Name = "elrCheckBox5";
            this.elrCheckBox5.NombreTabla = "";
            this.elrCheckBox5.Size = new System.Drawing.Size(116, 25);
            this.elrCheckBox5.TabIndex = 8;
            this.elrCheckBox5.Text = "Con Gerente";
            this.elrCheckBox5.UseVisualStyleBackColor = true;
            this.elrCheckBox5.ValorPorDefecto = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de Garantia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion:";
            // 
            // elrCheckBox6
            // 
            this.elrCheckBox6.AutoSize = true;
            this.elrCheckBox6.CampoData = "ConAlguacil";
            this.elrCheckBox6.DSData = this.DSDatos;
            this.elrCheckBox6.EsEditable = true;
            this.elrCheckBox6.EsModificable = true;
            this.elrCheckBox6.FiltroBusqueda = "";
            this.elrCheckBox6.Location = new System.Drawing.Point(428, 308);
            this.elrCheckBox6.Name = "elrCheckBox6";
            this.elrCheckBox6.NombreTabla = "";
            this.elrCheckBox6.Size = new System.Drawing.Size(116, 25);
            this.elrCheckBox6.TabIndex = 12;
            this.elrCheckBox6.Text = "Con Alguacil";
            this.elrCheckBox6.UseVisualStyleBackColor = true;
            this.elrCheckBox6.ValorPorDefecto = true;
            // 
            // elrCheckBox7
            // 
            this.elrCheckBox7.AutoSize = true;
            this.elrCheckBox7.CampoData = "ConTestigo";
            this.elrCheckBox7.DSData = this.DSDatos;
            this.elrCheckBox7.EsEditable = true;
            this.elrCheckBox7.EsModificable = true;
            this.elrCheckBox7.FiltroBusqueda = "";
            this.elrCheckBox7.Location = new System.Drawing.Point(428, 339);
            this.elrCheckBox7.Name = "elrCheckBox7";
            this.elrCheckBox7.NombreTabla = "";
            this.elrCheckBox7.Size = new System.Drawing.Size(109, 25);
            this.elrCheckBox7.TabIndex = 13;
            this.elrCheckBox7.Text = "Con Testigo";
            this.elrCheckBox7.UseVisualStyleBackColor = true;
            this.elrCheckBox7.ValorPorDefecto = true;
            // 
            // elrCheckBox8
            // 
            this.elrCheckBox8.AutoSize = true;
            this.elrCheckBox8.CampoData = "EsLegal";
            this.elrCheckBox8.DSData = this.DSDatos;
            this.elrCheckBox8.EsEditable = true;
            this.elrCheckBox8.EsModificable = true;
            this.elrCheckBox8.FiltroBusqueda = "";
            this.elrCheckBox8.Location = new System.Drawing.Point(185, 308);
            this.elrCheckBox8.Name = "elrCheckBox8";
            this.elrCheckBox8.NombreTabla = "";
            this.elrCheckBox8.Size = new System.Drawing.Size(85, 25);
            this.elrCheckBox8.TabIndex = 14;
            this.elrCheckBox8.Text = "Es Legal";
            this.elrCheckBox8.UseVisualStyleBackColor = true;
            this.elrCheckBox8.ValorPorDefecto = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad Deudores:";
            // 
            // elrTextBox3
            // 
            this.elrTextBox3.AMostrar = null;
            this.elrTextBox3.AValidar = null;
            this.elrTextBox3.CampoBusquedaID = "";
            this.elrTextBox3.CampoData = "Cantidad_Deudores";
            this.elrTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox3.ColumnasBusqGeneral = null;
            this.elrTextBox3.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox3.Decimales = 0;
            this.elrTextBox3.DSData = this.DSDatos;
            this.elrTextBox3.EsAutoGenerado = false;
            this.elrTextBox3.EsBusqueda = false;
            this.elrTextBox3.EsBusquedaAutoIncremental = false;
            this.elrTextBox3.EsEditable = true;
            this.elrTextBox3.FiltroBusqueda = "";
            this.elrTextBox3.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox3.Location = new System.Drawing.Point(184, 199);
            this.elrTextBox3.Name = "elrTextBox3";
            this.elrTextBox3.NombreTabla = "";
            this.elrTextBox3.SepDecimal = '\0';
            this.elrTextBox3.Size = new System.Drawing.Size(163, 29);
            this.elrTextBox3.TabIndex = 15;
            this.elrTextBox3.TablaOVistaBusqueda = "";
            this.elrTextBox3.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox3.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox3.ValorPorDefecto = "";
            // 
            // cboCodigo
            // 
            this.cboCodigo.AValidar = null;
            this.cboCodigo.CampoData = "Codigo";
            this.cboCodigo.CampoJoinCombobox2 = "";
            this.cboCodigo.ComboboxAFiltrar = null;
            this.cboCodigo.DisplayMember = "Descripcion";
            this.cboCodigo.DSData = this.DSDatos;
            this.cboCodigo.EsEditable = true;
            this.cboCodigo.FiltroBusqueda = "Nombre_Tabla = \'CODIGO_DOC_TEMPLATES\' and EsActivo = 1";
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(184, 22);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.NombreTabla = "";
            this.cboCodigo.Size = new System.Drawing.Size(517, 29);
            this.cboCodigo.SSQL = "";
            this.cboCodigo.TabIndex = 17;
            this.cboCodigo.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboCodigo.UsaDataGlobal = false;
            this.cboCodigo.ValorPorDefecto = "0";
            this.cboCodigo.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Evento:";
            // 
            // cboEvento
            // 
            this.cboEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvento.FormattingEnabled = true;
            this.cboEvento.Items.AddRange(new object[] {
            "AL REALIZAR SOLICITUD",
            "CON LA APROBACION ",
            "CON EL DESEMBOLSO ",
            "OTROS"});
            this.cboEvento.Location = new System.Drawing.Point(184, 129);
            this.cboEvento.Name = "cboEvento";
            this.cboEvento.Size = new System.Drawing.Size(517, 29);
            this.cboEvento.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Doc. Template:";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "DocTemplate";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(184, 164);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(517, 29);
            this.elrTextBox1.TabIndex = 21;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "";
            // 
            // FormDocTemplatesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 452);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEvento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.elrTextBox3);
            this.Controls.Add(this.elrCheckBox8);
            this.Controls.Add(this.elrCheckBox7);
            this.Controls.Add(this.elrCheckBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elrCheckBox5);
            this.Controls.Add(this.elrCheckBox3);
            this.Controls.Add(this.elrCheckBox4);
            this.Controls.Add(this.elrCheckBox2);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.elrCombobox1);
            this.Controls.Add(this.elrTextBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormDocTemplatesR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TCONFIGURACION_DOC_TEMPLATES";
            this.Text = "REGISTRAR DOCUMENTO TEMPLATES";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.elrTextBox2, 0);
            this.Controls.SetChildIndex(this.elrCombobox1, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.Controls.SetChildIndex(this.elrCheckBox2, 0);
            this.Controls.SetChildIndex(this.elrCheckBox4, 0);
            this.Controls.SetChildIndex(this.elrCheckBox3, 0);
            this.Controls.SetChildIndex(this.elrCheckBox5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.elrCheckBox6, 0);
            this.Controls.SetChildIndex(this.elrCheckBox7, 0);
            this.Controls.SetChildIndex(this.elrCheckBox8, 0);
            this.Controls.SetChildIndex(this.elrTextBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cboCodigo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cboEvento, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WinControl_ELR_NET.ELRTextBox elrTextBox2;
        private WinControl_ELR_NET.ELRCombobox elrCombobox1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox2;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox3;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox4;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox6;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox7;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox8;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox elrTextBox3;
        private WinControl_ELR_NET.ELRCombobox cboCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEvento;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
    }
}