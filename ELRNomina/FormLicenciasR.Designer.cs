namespace ELRNomina
{
    partial class FormLicenciasR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreCompleto = new WinControl_ELR_NET.ELRLabel();
            this.lblCodigo = new WinControl_ELR_NET.ELRLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaRetornar = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 72);
            this.panel1.TabIndex = 5;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.CampoData = "";
            this.lblNombreCompleto.DSData = null;
            this.lblNombreCompleto.Location = new System.Drawing.Point(11, 32);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.NombreTabla = "";
            this.lblNombreCompleto.Size = new System.Drawing.Size(145, 21);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre Completo";
            this.lblNombreCompleto.ValorPorDefecto = "";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.CampoData = "";
            this.lblCodigo.DSData = null;
            this.lblCodigo.Location = new System.Drawing.Point(11, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.NombreTabla = "";
            this.lblCodigo.Size = new System.Drawing.Size(337, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: 000000              Cedula: 00000000000";
            this.lblCodigo.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.elrLabel3);
            this.panel2.Controls.Add(this.dtpFechaRetornar);
            this.panel2.Controls.Add(this.elrLabel2);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.elrLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 90);
            this.panel2.TabIndex = 6;
            // 
            // dtpFechaRetornar
            // 
            this.dtpFechaRetornar.AValidar = null;
            this.dtpFechaRetornar.CampoData = "";
            this.dtpFechaRetornar.DSData = null;
            this.dtpFechaRetornar.EsEditable = true;
            this.dtpFechaRetornar.FiltroBusqueda = "";
            this.dtpFechaRetornar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetornar.Location = new System.Drawing.Point(418, 44);
            this.dtpFechaRetornar.Name = "dtpFechaRetornar";
            this.dtpFechaRetornar.NombreTabla = "";
            this.dtpFechaRetornar.Size = new System.Drawing.Size(149, 29);
            this.dtpFechaRetornar.TabIndex = 5;
            this.dtpFechaRetornar.ValorPorDefecto = new System.DateTime(2016, 12, 26, 0, 0, 0, 0);
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(272, 46);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(140, 21);
            this.elrLabel2.TabIndex = 4;
            this.elrLabel2.Text = "Fecha ARetornar:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "";
            this.dtpFecha.DSData = null;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(97, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(149, 29);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 12, 26, 0, 0, 0, 0);
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(23, 46);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(58, 21);
            this.elrLabel1.TabIndex = 2;
            this.elrLabel1.Text = "Fecha:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo o Concepto";
            // 
            // txtMotivo
            // 
            this.txtMotivo.AMostrar = null;
            this.txtMotivo.AValidar = null;
            this.txtMotivo.CampoBusquedaID = "";
            this.txtMotivo.CampoData = "";
            this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivo.ColumnasBusqGeneral = null;
            this.txtMotivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMotivo.Decimales = 0;
            this.txtMotivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMotivo.DSData = null;
            this.txtMotivo.EsAutoGenerado = false;
            this.txtMotivo.EsBusqueda = false;
            this.txtMotivo.EsBusquedaAutoIncremental = false;
            this.txtMotivo.EsEditable = true;
            this.txtMotivo.FiltroBusqueda = "";
            this.txtMotivo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMotivo.Location = new System.Drawing.Point(3, 25);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.NombreTabla = "";
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMotivo.SepDecimal = '\0';
            this.txtMotivo.Size = new System.Drawing.Size(625, 222);
            this.txtMotivo.TabIndex = 0;
            this.txtMotivo.TablaOVistaBusqueda = "";
            this.txtMotivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMotivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMotivo.ValorPorDefecto = "";
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "";
            this.elrLabel3.DSData = null;
            this.elrLabel3.Location = new System.Drawing.Point(23, 12);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(48, 21);
            this.elrLabel3.TabIndex = 6;
            this.elrLabel3.Text = "Tipo:";
            this.elrLabel3.ValorPorDefecto = "";
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DSData = null;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(97, 9);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(470, 29);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 7;
            this.cboTipo.TablaOVistaConsulta = "";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "0";
            // 
            // FormLicenciasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormLicenciasR";
            this.TablaEncabezado = "Tabla";
            this.Text = "REGISTRAR LICENCIA PERMISO Y/O SANSION";
            this.Load += new System.EventHandler(this.FormLicenciasR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRLabel lblNombreCompleto;
        private WinControl_ELR_NET.ELRLabel lblCodigo;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFechaRetornar;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtMotivo;
        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
    }
}