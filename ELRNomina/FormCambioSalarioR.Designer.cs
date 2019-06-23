namespace ELRNomina
{
    partial class FormCambioSalarioR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreCompleto = new WinControl_ELR_NET.ELRLabel();
            this.lblCodigo = new WinControl_ELR_NET.ELRLabel();
            this.txtSalarioNuevo = new WinControl_ELR_NET.ELRTextBox();
            this.lblSalarioActual = new WinControl_ELR_NET.ELRLabel();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 316);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 155);
            this.groupBox1.TabIndex = 6;
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
            this.txtMotivo.Size = new System.Drawing.Size(625, 127);
            this.txtMotivo.TabIndex = 0;
            this.txtMotivo.TablaOVistaBusqueda = "";
            this.txtMotivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMotivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMotivo.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSalarioNuevo);
            this.panel2.Controls.Add(this.elrLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 55);
            this.panel2.TabIndex = 5;
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(18, 13);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(122, 21);
            this.elrLabel1.TabIndex = 2;
            this.elrLabel1.Text = "Nuevo Salario:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSalarioActual);
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 106);
            this.panel1.TabIndex = 4;
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
            // txtSalarioNuevo
            // 
            this.txtSalarioNuevo.AMostrar = null;
            this.txtSalarioNuevo.AValidar = null;
            this.txtSalarioNuevo.CampoBusquedaID = "";
            this.txtSalarioNuevo.CampoData = "";
            this.txtSalarioNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalarioNuevo.ColumnasBusqGeneral = null;
            this.txtSalarioNuevo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSalarioNuevo.Decimales = 0;
            this.txtSalarioNuevo.DSData = null;
            this.txtSalarioNuevo.EsAutoGenerado = false;
            this.txtSalarioNuevo.EsBusqueda = false;
            this.txtSalarioNuevo.EsBusquedaAutoIncremental = false;
            this.txtSalarioNuevo.EsEditable = true;
            this.txtSalarioNuevo.FiltroBusqueda = "";
            this.txtSalarioNuevo.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtSalarioNuevo.Location = new System.Drawing.Point(147, 13);
            this.txtSalarioNuevo.Name = "txtSalarioNuevo";
            this.txtSalarioNuevo.NombreTabla = "";
            this.txtSalarioNuevo.SepDecimal = '\0';
            this.txtSalarioNuevo.Size = new System.Drawing.Size(203, 29);
            this.txtSalarioNuevo.TabIndex = 3;
            this.txtSalarioNuevo.TablaOVistaBusqueda = "";
            this.txtSalarioNuevo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSalarioNuevo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSalarioNuevo.ValorPorDefecto = "";
            // 
            // lblSalarioActual
            // 
            this.lblSalarioActual.AutoSize = true;
            this.lblSalarioActual.CampoData = "";
            this.lblSalarioActual.DSData = null;
            this.lblSalarioActual.Location = new System.Drawing.Point(11, 65);
            this.lblSalarioActual.Name = "lblSalarioActual";
            this.lblSalarioActual.NombreTabla = "";
            this.lblSalarioActual.Size = new System.Drawing.Size(153, 21);
            this.lblSalarioActual.TabIndex = 2;
            this.lblSalarioActual.Text = "Salario Actual: 0.00";
            this.lblSalarioActual.ValorPorDefecto = "";
            // 
            // FormCambioSalarioR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormCambioSalarioR";
            this.TablaEncabezado = "Tabla";
            this.Text = "REGISTRAR CAMBIO DE SALARIO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtMotivo;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRTextBox txtSalarioNuevo;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRLabel lblSalarioActual;
        private WinControl_ELR_NET.ELRLabel lblNombreCompleto;
        private WinControl_ELR_NET.ELRLabel lblCodigo;
    }
}