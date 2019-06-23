namespace ELRNomina
{
    partial class FormNominaTablaISRR
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
            this.txtHasta = new WinControl_ELR_NET.ELRTextBox();
            this.txtTasaExcedente = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesde = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuotaFija = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 203);
            this.pnBotones.Size = new System.Drawing.Size(449, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(209, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(114, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(19, 39);
            // 
            // txtHasta
            // 
            this.txtHasta.AMostrar = null;
            this.txtHasta.AValidar = null;
            this.txtHasta.CampoBusquedaID = "";
            this.txtHasta.CampoData = "Monto_Hasta";
            this.txtHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHasta.ColumnasBusqGeneral = null;
            this.txtHasta.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtHasta.Decimales = 0;
            this.txtHasta.DSData = this.DSDatos;
            this.txtHasta.EsAutoGenerado = false;
            this.txtHasta.EsBusqueda = false;
            this.txtHasta.EsBusquedaAutoIncremental = false;
            this.txtHasta.EsEditable = true;
            this.txtHasta.FiltroBusqueda = "";
            this.txtHasta.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtHasta.Location = new System.Drawing.Point(130, 63);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.NombreTabla = "";
            this.txtHasta.SepDecimal = '\0';
            this.txtHasta.Size = new System.Drawing.Size(174, 29);
            this.txtHasta.TabIndex = 4;
            this.txtHasta.TablaOVistaBusqueda = "";
            this.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHasta.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtHasta.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtHasta.ValorPorDefecto = "0";
            // 
            // txtTasaExcedente
            // 
            this.txtTasaExcedente.AMostrar = null;
            this.txtTasaExcedente.AValidar = null;
            this.txtTasaExcedente.CampoBusquedaID = "";
            this.txtTasaExcedente.CampoData = "Tasa_Excedente";
            this.txtTasaExcedente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaExcedente.ColumnasBusqGeneral = null;
            this.txtTasaExcedente.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaExcedente.Decimales = 0;
            this.txtTasaExcedente.DSData = this.DSDatos;
            this.txtTasaExcedente.EsAutoGenerado = false;
            this.txtTasaExcedente.EsBusqueda = false;
            this.txtTasaExcedente.EsBusquedaAutoIncremental = false;
            this.txtTasaExcedente.EsEditable = true;
            this.txtTasaExcedente.FiltroBusqueda = "";
            this.txtTasaExcedente.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTasaExcedente.Location = new System.Drawing.Point(130, 133);
            this.txtTasaExcedente.MaxLength = 5;
            this.txtTasaExcedente.Name = "txtTasaExcedente";
            this.txtTasaExcedente.NombreTabla = "";
            this.txtTasaExcedente.SepDecimal = '\0';
            this.txtTasaExcedente.Size = new System.Drawing.Size(174, 29);
            this.txtTasaExcedente.TabIndex = 8;
            this.txtTasaExcedente.TablaOVistaBusqueda = "";
            this.txtTasaExcedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTasaExcedente.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaExcedente.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaExcedente.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // txtDesde
            // 
            this.txtDesde.AMostrar = null;
            this.txtDesde.AValidar = null;
            this.txtDesde.CampoBusquedaID = "";
            this.txtDesde.CampoData = "Monto_Desde";
            this.txtDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesde.ColumnasBusqGeneral = null;
            this.txtDesde.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDesde.Decimales = 0;
            this.txtDesde.DSData = this.DSDatos;
            this.txtDesde.EsAutoGenerado = false;
            this.txtDesde.EsBusqueda = false;
            this.txtDesde.EsBusquedaAutoIncremental = false;
            this.txtDesde.EsEditable = true;
            this.txtDesde.FiltroBusqueda = "";
            this.txtDesde.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDesde.Location = new System.Drawing.Point(130, 28);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.NombreTabla = "";
            this.txtDesde.SepDecimal = '\0';
            this.txtDesde.Size = new System.Drawing.Size(174, 29);
            this.txtDesde.TabIndex = 2;
            this.txtDesde.TablaOVistaBusqueda = "";
            this.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesde.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDesde.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDesde.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // txtCuotaFija
            // 
            this.txtCuotaFija.AMostrar = null;
            this.txtCuotaFija.AValidar = null;
            this.txtCuotaFija.CampoBusquedaID = "";
            this.txtCuotaFija.CampoData = "Cuota_Fija";
            this.txtCuotaFija.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuotaFija.ColumnasBusqGeneral = null;
            this.txtCuotaFija.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCuotaFija.Decimales = 0;
            this.txtCuotaFija.DSData = this.DSDatos;
            this.txtCuotaFija.EsAutoGenerado = false;
            this.txtCuotaFija.EsBusqueda = false;
            this.txtCuotaFija.EsBusquedaAutoIncremental = false;
            this.txtCuotaFija.EsEditable = true;
            this.txtCuotaFija.FiltroBusqueda = "";
            this.txtCuotaFija.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCuotaFija.Location = new System.Drawing.Point(130, 98);
            this.txtCuotaFija.Name = "txtCuotaFija";
            this.txtCuotaFija.NombreTabla = "";
            this.txtCuotaFija.SepDecimal = '\0';
            this.txtCuotaFija.Size = new System.Drawing.Size(174, 29);
            this.txtCuotaFija.TabIndex = 6;
            this.txtCuotaFija.TablaOVistaBusqueda = "";
            this.txtCuotaFija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuotaFija.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuotaFija.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuotaFija.ValorPorDefecto = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuota Fija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "% Excedente:";
            // 
            // FormNominaTablaISRR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtHasta;
            valida1.Mensaje = "Debe Ser Mayor a Cero";
            valida1.NombreCampo = "Monto_Hasta";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtTasaExcedente;
            valida2.Mensaje = "Debe Ser Menor a 100";
            valida2.NombreCampo = "Tasa_Excedente";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida2.Valor1 = "99";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(449, 246);
            this.Controls.Add(this.txtTasaExcedente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuotaFija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormNominaTablaISRR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TNOMINA_TABLA_ISR";
            this.Text = "Tabla ISR (VALORES ANUALES)";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDesde, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtHasta, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCuotaFija, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTasaExcedente, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtDesde;
        private WinControl_ELR_NET.ELRTextBox txtHasta;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtCuotaFija;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtTasaExcedente;
        private System.Windows.Forms.Label label4;
    }
}