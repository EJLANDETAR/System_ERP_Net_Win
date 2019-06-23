namespace ELRSmartPhones
{
    partial class FormSmartPhonesR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSmartUID = new WinControl_ELR_NET.ELRTextBox();
            this.txtPlatform = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new WinControl_ELR_NET.ELRTextBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpleadoId = new WinControl_ELR_NET.ELRTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpleadoNombre = new WinControl_ELR_NET.ELRTextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 341);
            this.pnBotones.Size = new System.Drawing.Size(622, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(382, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(523, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(287, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(192, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Smart UID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Platform";
            // 
            // txtSmartUID
            // 
            this.txtSmartUID.AMostrar = null;
            this.txtSmartUID.AValidar = null;
            this.txtSmartUID.CampoBusquedaID = "";
            this.txtSmartUID.CampoData = "Smart_UID";
            this.txtSmartUID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSmartUID.ColumnasBusqGeneral = null;
            this.txtSmartUID.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSmartUID.Decimales = 0;
            this.txtSmartUID.DSData = this.DSDatos;
            this.txtSmartUID.EsAutoGenerado = false;
            this.txtSmartUID.EsBusqueda = false;
            this.txtSmartUID.EsBusquedaAutoIncremental = false;
            this.txtSmartUID.EsEditable = false;
            this.txtSmartUID.FiltroBusqueda = "";
            this.txtSmartUID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmartUID.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSmartUID.Location = new System.Drawing.Point(132, 43);
            this.txtSmartUID.Name = "txtSmartUID";
            this.txtSmartUID.NombreTabla = "";
            this.txtSmartUID.SepDecimal = '\0';
            this.txtSmartUID.Size = new System.Drawing.Size(466, 29);
            this.txtSmartUID.TabIndex = 3;
            this.txtSmartUID.TablaOVistaBusqueda = "";
            this.txtSmartUID.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSmartUID.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSmartUID.ValorPorDefecto = "";
            // 
            // txtPlatform
            // 
            this.txtPlatform.AMostrar = null;
            this.txtPlatform.AValidar = null;
            this.txtPlatform.CampoBusquedaID = "";
            this.txtPlatform.CampoData = "Platform";
            this.txtPlatform.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlatform.ColumnasBusqGeneral = null;
            this.txtPlatform.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPlatform.Decimales = 0;
            this.txtPlatform.DSData = this.DSDatos;
            this.txtPlatform.EsAutoGenerado = false;
            this.txtPlatform.EsBusqueda = false;
            this.txtPlatform.EsBusquedaAutoIncremental = false;
            this.txtPlatform.EsEditable = true;
            this.txtPlatform.FiltroBusqueda = "";
            this.txtPlatform.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPlatform.Location = new System.Drawing.Point(132, 84);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.NombreTabla = "";
            this.txtPlatform.SepDecimal = '\0';
            this.txtPlatform.Size = new System.Drawing.Size(466, 29);
            this.txtPlatform.TabIndex = 4;
            this.txtPlatform.TablaOVistaBusqueda = "";
            this.txtPlatform.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPlatform.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPlatform.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AMostrar = null;
            this.txtUsuario.AValidar = null;
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.CampoBusquedaID = "";
            this.txtUsuario.CampoData = "Usuario";
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.ColumnasBusqGeneral = null;
            this.txtUsuario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtUsuario.Decimales = 0;
            this.txtUsuario.DSData = this.DSDatos;
            this.txtUsuario.EsAutoGenerado = false;
            this.txtUsuario.EsBusqueda = false;
            this.txtUsuario.EsBusquedaAutoIncremental = false;
            this.txtUsuario.EsEditable = true;
            this.txtUsuario.FiltroBusqueda = "";
            this.txtUsuario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtUsuario.Location = new System.Drawing.Point(132, 123);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NombreTabla = "";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.SepDecimal = '\0';
            this.txtUsuario.Size = new System.Drawing.Size(270, 29);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TablaOVistaBusqueda = "";
            this.txtUsuario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtUsuario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtUsuario.ValorPorDefecto = "";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(124, 169);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 7;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpleadoNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtEmpleadoId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignado A (Oficial Credito)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo";
            // 
            // txtEmpleadoId
            // 
            this.txtEmpleadoId.AMostrar = null;
            this.txtEmpleadoId.AValidar = null;
            this.txtEmpleadoId.CampoBusquedaID = "";
            this.txtEmpleadoId.CampoData = "";
            this.txtEmpleadoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleadoId.ColumnasBusqGeneral = null;
            this.txtEmpleadoId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEmpleadoId.Decimales = 0;
            this.txtEmpleadoId.DSData = null;
            this.txtEmpleadoId.EsAutoGenerado = false;
            this.txtEmpleadoId.EsBusqueda = false;
            this.txtEmpleadoId.EsBusquedaAutoIncremental = false;
            this.txtEmpleadoId.EsEditable = true;
            this.txtEmpleadoId.FiltroBusqueda = "";
            this.txtEmpleadoId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEmpleadoId.Location = new System.Drawing.Point(16, 58);
            this.txtEmpleadoId.Name = "txtEmpleadoId";
            this.txtEmpleadoId.NombreTabla = "";
            this.txtEmpleadoId.SepDecimal = '\0';
            this.txtEmpleadoId.Size = new System.Drawing.Size(135, 29);
            this.txtEmpleadoId.TabIndex = 1;
            this.txtEmpleadoId.TablaOVistaBusqueda = "";
            this.txtEmpleadoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEmpleadoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEmpleadoId.ValorPorDefecto = "";
            this.txtEmpleadoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpleadoId_KeyDown);
            // 
            // button1
            // 
            this.button1.Image = global::ELRSmartPhones.Properties.Resources._1378160672_search___Copy__2_;
            this.button1.Location = new System.Drawing.Point(157, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 29);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Codigo";
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.AMostrar = null;
            this.txtEmpleadoNombre.AValidar = null;
            this.txtEmpleadoNombre.BackColor = System.Drawing.Color.White;
            this.txtEmpleadoNombre.CampoBusquedaID = "";
            this.txtEmpleadoNombre.CampoData = "";
            this.txtEmpleadoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleadoNombre.ColumnasBusqGeneral = null;
            this.txtEmpleadoNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEmpleadoNombre.Decimales = 0;
            this.txtEmpleadoNombre.DSData = null;
            this.txtEmpleadoNombre.EsAutoGenerado = false;
            this.txtEmpleadoNombre.EsBusqueda = false;
            this.txtEmpleadoNombre.EsBusquedaAutoIncremental = false;
            this.txtEmpleadoNombre.EsEditable = true;
            this.txtEmpleadoNombre.FiltroBusqueda = "";
            this.txtEmpleadoNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(213, 58);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.NombreTabla = "";
            this.txtEmpleadoNombre.ReadOnly = true;
            this.txtEmpleadoNombre.SepDecimal = '\0';
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(385, 29);
            this.txtEmpleadoNombre.TabIndex = 4;
            this.txtEmpleadoNombre.TablaOVistaBusqueda = "";
            this.txtEmpleadoNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEmpleadoNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEmpleadoNombre.ValorPorDefecto = "";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = global::ELRSmartPhones.Properties.Resources._1378160672_search___Copy__2_;
            this.btnUsuario.Location = new System.Drawing.Point(408, 123);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(50, 29);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // FormSmartPhonesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtSmartUID;
            valida1.Mensaje = "Debe indicar el UID";
            valida1.NombreCampo = "Smart_UID";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtUsuario;
            valida2.Mensaje = "Debe indicar un usuario";
            valida2.NombreCampo = "Usuario";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(622, 384);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.txtSmartUID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSmartPhonesR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TSMART_PHONES";
            this.Text = "REGISTRAR SMART PHONES";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSmartUID, 0);
            this.Controls.SetChildIndex(this.txtPlatform, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.chkEsActivo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnUsuario, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtSmartUID;
        private WinControl_ELR_NET.ELRTextBox txtPlatform;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtUsuario;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private WinControl_ELR_NET.ELRTextBox txtEmpleadoId;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtEmpleadoNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUsuario;
    }
}