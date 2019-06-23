namespace ELRMaestros
{
    partial class FormZonasR
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
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZonaId = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarOficial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOficialNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtOficialCreditoId = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSupervisor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupervisorNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtSupervisorId = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 385);
            this.pnBotones.Size = new System.Drawing.Size(567, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(327, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(468, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(232, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(137, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkEsActivo);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtZonaId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 129);
            this.panel1.TabIndex = 6;
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(236, 26);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 11;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
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
            this.txtNombre.Location = new System.Drawing.Point(91, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(449, 29);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // txtZonaId
            // 
            this.txtZonaId.AMostrar = null;
            this.txtZonaId.AValidar = null;
            this.txtZonaId.CampoBusquedaID = "";
            this.txtZonaId.CampoData = "Zona_Id";
            this.txtZonaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtZonaId.ColumnasBusqGeneral = null;
            this.txtZonaId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtZonaId.Decimales = 0;
            this.txtZonaId.DSData = this.DSDatos;
            this.txtZonaId.EsAutoGenerado = false;
            this.txtZonaId.EsBusqueda = false;
            this.txtZonaId.EsBusquedaAutoIncremental = false;
            this.txtZonaId.EsEditable = false;
            this.txtZonaId.FiltroBusqueda = "";
            this.txtZonaId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtZonaId.Location = new System.Drawing.Point(91, 24);
            this.txtZonaId.Name = "txtZonaId";
            this.txtZonaId.NombreTabla = "";
            this.txtZonaId.ReadOnly = true;
            this.txtZonaId.SepDecimal = '\0';
            this.txtZonaId.Size = new System.Drawing.Size(100, 29);
            this.txtZonaId.TabIndex = 8;
            this.txtZonaId.TablaOVistaBusqueda = "";
            this.txtZonaId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtZonaId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtZonaId.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zona Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarOficial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOficialNombre);
            this.groupBox1.Controls.Add(this.txtOficialCreditoId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oficial de Credito";
            // 
            // btnBuscarOficial
            // 
            this.btnBuscarOficial.Location = new System.Drawing.Point(270, 35);
            this.btnBuscarOficial.Name = "btnBuscarOficial";
            this.btnBuscarOficial.Size = new System.Drawing.Size(70, 29);
            this.btnBuscarOficial.TabIndex = 23;
            this.btnBuscarOficial.Text = "Buscar";
            this.btnBuscarOficial.UseVisualStyleBackColor = true;
            this.btnBuscarOficial.Click += new System.EventHandler(this.btnBuscarOficialCredito_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre:";
            // 
            // txtOficialNombre
            // 
            this.txtOficialNombre.AMostrar = null;
            this.txtOficialNombre.AValidar = null;
            this.txtOficialNombre.BackColor = System.Drawing.Color.White;
            this.txtOficialNombre.CampoBusquedaID = "";
            this.txtOficialNombre.CampoData = "";
            this.txtOficialNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOficialNombre.ColumnasBusqGeneral = null;
            this.txtOficialNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtOficialNombre.Decimales = 0;
            this.txtOficialNombre.DSData = null;
            this.txtOficialNombre.EsAutoGenerado = false;
            this.txtOficialNombre.EsBusqueda = false;
            this.txtOficialNombre.EsBusquedaAutoIncremental = false;
            this.txtOficialNombre.EsEditable = true;
            this.txtOficialNombre.FiltroBusqueda = "";
            this.txtOficialNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficialNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtOficialNombre.Location = new System.Drawing.Point(97, 70);
            this.txtOficialNombre.Name = "txtOficialNombre";
            this.txtOficialNombre.NombreTabla = "";
            this.txtOficialNombre.ReadOnly = true;
            this.txtOficialNombre.SepDecimal = '\0';
            this.txtOficialNombre.Size = new System.Drawing.Size(445, 29);
            this.txtOficialNombre.TabIndex = 21;
            this.txtOficialNombre.TablaOVistaBusqueda = "";
            this.txtOficialNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtOficialNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtOficialNombre.ValorPorDefecto = "";
            // 
            // txtOficialCreditoId
            // 
            this.txtOficialCreditoId.AMostrar = null;
            this.txtOficialCreditoId.AValidar = null;
            this.txtOficialCreditoId.CampoBusquedaID = "";
            this.txtOficialCreditoId.CampoData = "Evaluador_Id";
            this.txtOficialCreditoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOficialCreditoId.ColumnasBusqGeneral = null;
            this.txtOficialCreditoId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtOficialCreditoId.Decimales = 0;
            this.txtOficialCreditoId.DSData = this.DSDatos;
            this.txtOficialCreditoId.EsAutoGenerado = false;
            this.txtOficialCreditoId.EsBusqueda = false;
            this.txtOficialCreditoId.EsBusquedaAutoIncremental = false;
            this.txtOficialCreditoId.EsEditable = true;
            this.txtOficialCreditoId.FiltroBusqueda = "";
            this.txtOficialCreditoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficialCreditoId.Formato = WinControl_ELR_NET.tbFormato.NumerosEnterosPositivos;
            this.txtOficialCreditoId.Location = new System.Drawing.Point(97, 35);
            this.txtOficialCreditoId.Name = "txtOficialCreditoId";
            this.txtOficialCreditoId.NombreTabla = "";
            this.txtOficialCreditoId.SepDecimal = '\0';
            this.txtOficialCreditoId.Size = new System.Drawing.Size(163, 29);
            this.txtOficialCreditoId.TabIndex = 14;
            this.txtOficialCreditoId.TablaOVistaBusqueda = "";
            this.txtOficialCreditoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtOficialCreditoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtOficialCreditoId, "Digite Codigo o Cedula y Presione Enter");
            this.txtOficialCreditoId.ValorPorDefecto = "0";
            this.txtOficialCreditoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOficialCreditoId_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarSupervisor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSupervisorNombre);
            this.groupBox2.Controls.Add(this.txtSupervisorId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 134);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supervisor";
            // 
            // btnBuscarSupervisor
            // 
            this.btnBuscarSupervisor.Location = new System.Drawing.Point(266, 38);
            this.btnBuscarSupervisor.Name = "btnBuscarSupervisor";
            this.btnBuscarSupervisor.Size = new System.Drawing.Size(70, 29);
            this.btnBuscarSupervisor.TabIndex = 28;
            this.btnBuscarSupervisor.Text = "Buscar";
            this.btnBuscarSupervisor.UseVisualStyleBackColor = true;
            this.btnBuscarSupervisor.Click += new System.EventHandler(this.btnBuscarOficialCredito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nombre:";
            // 
            // txtSupervisorNombre
            // 
            this.txtSupervisorNombre.AMostrar = null;
            this.txtSupervisorNombre.AValidar = null;
            this.txtSupervisorNombre.BackColor = System.Drawing.Color.White;
            this.txtSupervisorNombre.CampoBusquedaID = "";
            this.txtSupervisorNombre.CampoData = "";
            this.txtSupervisorNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSupervisorNombre.ColumnasBusqGeneral = null;
            this.txtSupervisorNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSupervisorNombre.Decimales = 0;
            this.txtSupervisorNombre.DSData = null;
            this.txtSupervisorNombre.EsAutoGenerado = false;
            this.txtSupervisorNombre.EsBusqueda = false;
            this.txtSupervisorNombre.EsBusquedaAutoIncremental = false;
            this.txtSupervisorNombre.EsEditable = true;
            this.txtSupervisorNombre.FiltroBusqueda = "";
            this.txtSupervisorNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisorNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSupervisorNombre.Location = new System.Drawing.Point(97, 73);
            this.txtSupervisorNombre.Name = "txtSupervisorNombre";
            this.txtSupervisorNombre.NombreTabla = "";
            this.txtSupervisorNombre.ReadOnly = true;
            this.txtSupervisorNombre.SepDecimal = '\0';
            this.txtSupervisorNombre.Size = new System.Drawing.Size(445, 29);
            this.txtSupervisorNombre.TabIndex = 26;
            this.txtSupervisorNombre.TablaOVistaBusqueda = "";
            this.txtSupervisorNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSupervisorNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSupervisorNombre.ValorPorDefecto = "";
            // 
            // txtSupervisorId
            // 
            this.txtSupervisorId.AMostrar = null;
            this.txtSupervisorId.AValidar = null;
            this.txtSupervisorId.CampoBusquedaID = "";
            this.txtSupervisorId.CampoData = "Supervisor_Id";
            this.txtSupervisorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSupervisorId.ColumnasBusqGeneral = null;
            this.txtSupervisorId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSupervisorId.Decimales = 0;
            this.txtSupervisorId.DSData = this.DSDatos;
            this.txtSupervisorId.EsAutoGenerado = false;
            this.txtSupervisorId.EsBusqueda = false;
            this.txtSupervisorId.EsBusquedaAutoIncremental = false;
            this.txtSupervisorId.EsEditable = true;
            this.txtSupervisorId.FiltroBusqueda = "";
            this.txtSupervisorId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisorId.Formato = WinControl_ELR_NET.tbFormato.NumerosEnterosPositivos;
            this.txtSupervisorId.Location = new System.Drawing.Point(97, 38);
            this.txtSupervisorId.Name = "txtSupervisorId";
            this.txtSupervisorId.NombreTabla = "";
            this.txtSupervisorId.SepDecimal = '\0';
            this.txtSupervisorId.Size = new System.Drawing.Size(163, 29);
            this.txtSupervisorId.TabIndex = 24;
            this.txtSupervisorId.TablaOVistaBusqueda = "";
            this.txtSupervisorId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSupervisorId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtSupervisorId, "Digite Codigo o Cedula y Presione Enter");
            this.txtSupervisorId.ValorPorDefecto = "0";
            this.txtSupervisorId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOficialCreditoId_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Codigo:";
            // 
            // FormZonasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormZonasR";
            this.NombreCampoID = "Zona_Id";
            this.TablaEncabezado = "TZONAS";
            this.Text = "REGISTRO DE ZONA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtZonaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtOficialNombre;
        private WinControl_ELR_NET.ELRTextBox txtOficialCreditoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtSupervisorNombre;
        private WinControl_ELR_NET.ELRTextBox txtSupervisorId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarOficial;
        private System.Windows.Forms.Button btnBuscarSupervisor;
    }
}