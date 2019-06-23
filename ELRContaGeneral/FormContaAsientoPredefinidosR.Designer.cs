namespace ELRContaGeneral
{
    partial class FormContaAsientoPredefinidosR
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
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.txtCuentaDebito = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.txtCuentaCredito = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel4 = new WinControl_ELR_NET.ELRLabel();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.btnCtaDebito = new System.Windows.Forms.Button();
            this.btnCtaCredito = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 367);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(23, 28);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(60, 21);
            this.elrLabel1.TabIndex = 1;
            this.elrLabel1.Text = "Codigo";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Plantilla_Id";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = true;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(116, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(123, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Concepto";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(116, 76);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(469, 119);
            this.txtConcepto.TabIndex = 4;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(23, 76);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(76, 21);
            this.elrLabel2.TabIndex = 3;
            this.elrLabel2.Text = "Concepto";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // txtCuentaDebito
            // 
            this.txtCuentaDebito.AMostrar = null;
            this.txtCuentaDebito.AValidar = null;
            this.txtCuentaDebito.BackColor = System.Drawing.Color.White;
            this.txtCuentaDebito.CampoBusquedaID = "";
            this.txtCuentaDebito.CampoData = "Cuenta_Debito";
            this.txtCuentaDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaDebito.ColumnasBusqGeneral = null;
            this.txtCuentaDebito.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCuentaDebito.Decimales = 0;
            this.txtCuentaDebito.DSData = this.DSDatos;
            this.txtCuentaDebito.EsAutoGenerado = false;
            this.txtCuentaDebito.EsBusqueda = false;
            this.txtCuentaDebito.EsBusquedaAutoIncremental = false;
            this.txtCuentaDebito.EsEditable = true;
            this.txtCuentaDebito.FiltroBusqueda = "";
            this.txtCuentaDebito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaDebito.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCuentaDebito.Location = new System.Drawing.Point(164, 210);
            this.txtCuentaDebito.Name = "txtCuentaDebito";
            this.txtCuentaDebito.NombreTabla = "";
            this.txtCuentaDebito.ReadOnly = true;
            this.txtCuentaDebito.SepDecimal = '\0';
            this.txtCuentaDebito.Size = new System.Drawing.Size(200, 29);
            this.txtCuentaDebito.TabIndex = 6;
            this.txtCuentaDebito.TablaOVistaBusqueda = "";
            this.txtCuentaDebito.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuentaDebito.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuentaDebito.ValorPorDefecto = "";
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "";
            this.elrLabel3.DSData = null;
            this.elrLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrLabel3.Location = new System.Drawing.Point(23, 210);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(120, 21);
            this.elrLabel3.TabIndex = 5;
            this.elrLabel3.Text = "Cuenta Debito";
            this.elrLabel3.ValorPorDefecto = "";
            // 
            // txtCuentaCredito
            // 
            this.txtCuentaCredito.AMostrar = null;
            this.txtCuentaCredito.AValidar = null;
            this.txtCuentaCredito.BackColor = System.Drawing.Color.White;
            this.txtCuentaCredito.CampoBusquedaID = "";
            this.txtCuentaCredito.CampoData = "Cuenta_Credito";
            this.txtCuentaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaCredito.ColumnasBusqGeneral = null;
            this.txtCuentaCredito.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCuentaCredito.Decimales = 0;
            this.txtCuentaCredito.DSData = this.DSDatos;
            this.txtCuentaCredito.EsAutoGenerado = false;
            this.txtCuentaCredito.EsBusqueda = false;
            this.txtCuentaCredito.EsBusquedaAutoIncremental = false;
            this.txtCuentaCredito.EsEditable = true;
            this.txtCuentaCredito.FiltroBusqueda = "";
            this.txtCuentaCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCredito.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCuentaCredito.Location = new System.Drawing.Point(164, 254);
            this.txtCuentaCredito.Name = "txtCuentaCredito";
            this.txtCuentaCredito.NombreTabla = "";
            this.txtCuentaCredito.ReadOnly = true;
            this.txtCuentaCredito.SepDecimal = '\0';
            this.txtCuentaCredito.Size = new System.Drawing.Size(200, 29);
            this.txtCuentaCredito.TabIndex = 8;
            this.txtCuentaCredito.TablaOVistaBusqueda = "";
            this.txtCuentaCredito.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuentaCredito.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuentaCredito.ValorPorDefecto = "";
            // 
            // elrLabel4
            // 
            this.elrLabel4.AutoSize = true;
            this.elrLabel4.CampoData = "";
            this.elrLabel4.DSData = null;
            this.elrLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrLabel4.Location = new System.Drawing.Point(23, 254);
            this.elrLabel4.Name = "elrLabel4";
            this.elrLabel4.NombreTabla = "";
            this.elrLabel4.Size = new System.Drawing.Size(128, 21);
            this.elrLabel4.TabIndex = 7;
            this.elrLabel4.Text = "Cuenta Credito:";
            this.elrLabel4.ValorPorDefecto = "";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(164, 310);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 11;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // btnCtaDebito
            // 
            this.btnCtaDebito.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnCtaDebito.Location = new System.Drawing.Point(370, 210);
            this.btnCtaDebito.Name = "btnCtaDebito";
            this.btnCtaDebito.Size = new System.Drawing.Size(44, 29);
            this.btnCtaDebito.TabIndex = 12;
            this.btnCtaDebito.UseVisualStyleBackColor = true;
            this.btnCtaDebito.Click += new System.EventHandler(this.btnCtaDebito_Click);
            // 
            // btnCtaCredito
            // 
            this.btnCtaCredito.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnCtaCredito.Location = new System.Drawing.Point(370, 253);
            this.btnCtaCredito.Name = "btnCtaCredito";
            this.btnCtaCredito.Size = new System.Drawing.Size(44, 29);
            this.btnCtaCredito.TabIndex = 13;
            this.btnCtaCredito.UseVisualStyleBackColor = true;
            this.btnCtaCredito.Click += new System.EventHandler(this.btnCtaDebito_Click);
            // 
            // FormContaAsientoPredefinidosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtConcepto;
            valida1.Mensaje = "Debe indicar un concepto";
            valida1.NombreCampo = "Concepto";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "5";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtCuentaDebito;
            valida2.Mensaje = "Debe indicar cuenta contable a debitar";
            valida2.NombreCampo = "Cuenta_Debito";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = this.txtCuentaCredito;
            valida3.Mensaje = "Debe indicar la cuenta contable a acreditar";
            valida3.NombreCampo = "Cuenta_Credito";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(631, 410);
            this.Controls.Add(this.btnCtaCredito);
            this.Controls.Add(this.btnCtaDebito);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtCuentaCredito);
            this.Controls.Add(this.elrLabel4);
            this.Controls.Add(this.txtCuentaDebito);
            this.Controls.Add(this.elrLabel3);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.elrLabel2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.elrLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContaAsientoPredefinidosR";
            this.NombreCampoID = "Plantilla_Id";
            this.TablaEncabezado = "TCONTA_ASIENTOS_PREDEFINIDOS";
            this.Text = "REGISTRAR ASIENTOS PREDEFINIDOS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.elrLabel1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.elrLabel2, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.elrLabel3, 0);
            this.Controls.SetChildIndex(this.txtCuentaDebito, 0);
            this.Controls.SetChildIndex(this.elrLabel4, 0);
            this.Controls.SetChildIndex(this.txtCuentaCredito, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.Controls.SetChildIndex(this.btnCtaDebito, 0);
            this.Controls.SetChildIndex(this.btnCtaCredito, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRTextBox txtCuentaDebito;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
        private WinControl_ELR_NET.ELRTextBox txtCuentaCredito;
        private WinControl_ELR_NET.ELRLabel elrLabel4;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.Button btnCtaDebito;
        private System.Windows.Forms.Button btnCtaCredito;
    }
}