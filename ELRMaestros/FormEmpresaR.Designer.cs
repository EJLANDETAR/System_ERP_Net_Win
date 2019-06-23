namespace ELRMaestros
{
    partial class FormEmpresaR
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
            this.txtRNC = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiglas = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMoneda = new WinControl_ELR_NET.ELRCombobox();
            this.txtDirecionWeb = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.elrTextBox2 = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 368);
            this.pnBotones.Size = new System.Drawing.Size(575, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(335, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(476, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(240, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(145, 39);
            // 
            // txtRNC
            // 
            this.txtRNC.AMostrar = null;
            this.txtRNC.AValidar = null;
            this.txtRNC.CampoBusquedaID = "";
            this.txtRNC.CampoData = "RNC";
            this.txtRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRNC.ColumnasBusqGeneral = null;
            this.txtRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtRNC.Decimales = 0;
            this.txtRNC.DSData = this.DSDatos;
            this.txtRNC.EsAutoGenerado = false;
            this.txtRNC.EsBusqueda = false;
            this.txtRNC.EsBusquedaAutoIncremental = false;
            this.txtRNC.EsEditable = true;
            this.txtRNC.FiltroBusqueda = "";
            this.txtRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtRNC.Location = new System.Drawing.Point(96, 21);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.NombreTabla = "";
            this.txtRNC.SepDecimal = '\0';
            this.txtRNC.Size = new System.Drawing.Size(154, 29);
            this.txtRNC.TabIndex = 2;
            this.txtRNC.TablaOVistaBusqueda = "";
            this.txtRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtRNC.ValorPorDefecto = "";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
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
            this.txtNombre.Location = new System.Drawing.Point(96, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(447, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "RNC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Siglas";
            // 
            // txtSiglas
            // 
            this.txtSiglas.AMostrar = null;
            this.txtSiglas.AValidar = null;
            this.txtSiglas.CampoBusquedaID = "";
            this.txtSiglas.CampoData = "Siglas";
            this.txtSiglas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSiglas.ColumnasBusqGeneral = null;
            this.txtSiglas.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSiglas.Decimales = 0;
            this.txtSiglas.DSData = this.DSDatos;
            this.txtSiglas.EsAutoGenerado = false;
            this.txtSiglas.EsBusqueda = false;
            this.txtSiglas.EsBusquedaAutoIncremental = false;
            this.txtSiglas.EsEditable = true;
            this.txtSiglas.FiltroBusqueda = "";
            this.txtSiglas.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSiglas.Location = new System.Drawing.Point(340, 21);
            this.txtSiglas.Name = "txtSiglas";
            this.txtSiglas.NombreTabla = "";
            this.txtSiglas.SepDecimal = '\0';
            this.txtSiglas.Size = new System.Drawing.Size(203, 29);
            this.txtSiglas.TabIndex = 6;
            this.txtSiglas.TablaOVistaBusqueda = "";
            this.txtSiglas.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSiglas.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSiglas.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Web";
            // 
            // cboMoneda
            // 
            this.cboMoneda.AValidar = null;
            this.cboMoneda.CampoData = "Moneda_Id";
            this.cboMoneda.CampoJoinCombobox2 = "";
            this.cboMoneda.ComboboxAFiltrar = null;
            this.cboMoneda.DisplayMember = "Descripcion";
            this.cboMoneda.DSData = this.DSDatos;
            this.cboMoneda.EsEditable = true;
            this.cboMoneda.FiltroBusqueda = "EsActivo = 1";
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(96, 127);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.NombreTabla = "";
            this.cboMoneda.Size = new System.Drawing.Size(447, 29);
            this.cboMoneda.SSQL = "";
            this.cboMoneda.TabIndex = 8;
            this.cboMoneda.TablaOVistaConsulta = " TMONEDAS";
            this.cboMoneda.UsaDataGlobal = false;
            this.cboMoneda.ValorPorDefecto = "1";
            this.cboMoneda.ValueMember = "Moneda_Id";
            // 
            // txtDirecionWeb
            // 
            this.txtDirecionWeb.AMostrar = null;
            this.txtDirecionWeb.AValidar = null;
            this.txtDirecionWeb.CampoBusquedaID = "";
            this.txtDirecionWeb.CampoData = "Direccion_Web";
            this.txtDirecionWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirecionWeb.ColumnasBusqGeneral = null;
            this.txtDirecionWeb.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDirecionWeb.Decimales = 0;
            this.txtDirecionWeb.DSData = this.DSDatos;
            this.txtDirecionWeb.EsAutoGenerado = false;
            this.txtDirecionWeb.EsBusqueda = false;
            this.txtDirecionWeb.EsBusquedaAutoIncremental = false;
            this.txtDirecionWeb.EsEditable = true;
            this.txtDirecionWeb.FiltroBusqueda = "";
            this.txtDirecionWeb.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDirecionWeb.Location = new System.Drawing.Point(96, 92);
            this.txtDirecionWeb.Name = "txtDirecionWeb";
            this.txtDirecionWeb.NombreTabla = "";
            this.txtDirecionWeb.SepDecimal = '\0';
            this.txtDirecionWeb.Size = new System.Drawing.Size(447, 29);
            this.txtDirecionWeb.TabIndex = 9;
            this.txtDirecionWeb.TablaOVistaBusqueda = "";
            this.txtDirecionWeb.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDirecionWeb.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDirecionWeb.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Moneda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mensaje:";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Mensaje_Factura";
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
            this.elrTextBox1.Location = new System.Drawing.Point(96, 162);
            this.elrTextBox1.Multiline = true;
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(447, 81);
            this.elrTextBox1.TabIndex = 12;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "";
            // 
            // elrTextBox2
            // 
            this.elrTextBox2.AMostrar = null;
            this.elrTextBox2.AValidar = null;
            this.elrTextBox2.CampoBusquedaID = "";
            this.elrTextBox2.CampoData = "Slogan";
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
            this.elrTextBox2.Location = new System.Drawing.Point(96, 249);
            this.elrTextBox2.Multiline = true;
            this.elrTextBox2.Name = "elrTextBox2";
            this.elrTextBox2.NombreTabla = "";
            this.elrTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.elrTextBox2.SepDecimal = '\0';
            this.elrTextBox2.Size = new System.Drawing.Size(447, 81);
            this.elrTextBox2.TabIndex = 14;
            this.elrTextBox2.TablaOVistaBusqueda = "";
            this.elrTextBox2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox2.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Slogan:";
            // 
            // FormEmpresaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtRNC;
            valida1.Mensaje = "Debe Especificar RNC";
            valida1.NombreCampo = "RNC";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "Debe Especificar Nombre o Razon Social";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(575, 411);
            this.Controls.Add(this.elrTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirecionWeb);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSiglas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRNC);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormEmpresaR";
            this.NombreCampoID = "Empresa_Id";
            this.TablaEncabezado = "TEMPRESAS";
            this.Text = "REGISTRAR EMPRESA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRNC, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtSiglas, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cboMoneda, 0);
            this.Controls.SetChildIndex(this.txtDirecionWeb, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.elrTextBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtRNC;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtSiglas;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRCombobox cboMoneda;
        private WinControl_ELR_NET.ELRTextBox txtDirecionWeb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private WinControl_ELR_NET.ELRTextBox elrTextBox2;
        private System.Windows.Forms.Label label7;
    }
}