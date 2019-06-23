namespace ELRControlUsuarios
{
    partial class FormUsuariosR
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
            this.txtNombreUsuario = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elrCheckBox3 = new WinControl_ELR_NET.ELRCheckBox();
            this.elrCheckBox2 = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsBloqueado = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.gbContrasena = new System.Windows.Forms.GroupBox();
            this.txtConfirmarClave = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClave = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbContrasena.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 333);
            this.pnBotones.Size = new System.Drawing.Size(648, 43);
            this.pnBotones.TabIndex = 8;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(408, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            this.btnGrabar.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(549, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.btnAnterior.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(313, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.btnSiguientePage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(218, 39);
            this.lblNombreUsuario.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AMostrar = null;
            this.txtNombreUsuario.autoSenTab = true;
            this.txtNombreUsuario.AValidar = null;
            this.txtNombreUsuario.CampoBusquedaID = "";
            this.txtNombreUsuario.CampoData = "Nombre_Usuario";
            this.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreUsuario.ColumnasBusqGeneral = null;
            this.txtNombreUsuario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreUsuario.Decimales = 0;
            this.txtNombreUsuario.DSData = this.DSDatos;
            this.txtNombreUsuario.EsAutoGenerado = false;
            this.txtNombreUsuario.EsBusqueda = false;
            this.txtNombreUsuario.EsBusquedaAutoIncremental = false;
            this.txtNombreUsuario.EsEditable = true;
            this.txtNombreUsuario.FiltroBusqueda = "";
            this.txtNombreUsuario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreUsuario.Location = new System.Drawing.Point(149, 24);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.NombreTabla = "";
            this.txtNombreUsuario.SepDecimal = '\0';
            this.txtNombreUsuario.Size = new System.Drawing.Size(301, 29);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TablaOVistaBusqueda = "";
            this.txtNombreUsuario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreUsuario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreUsuario.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.AMostrar = null;
            this.txtNombres.autoSenTab = true;
            this.txtNombres.AValidar = null;
            this.txtNombres.CampoBusquedaID = "";
            this.txtNombres.CampoData = "Nombres";
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.ColumnasBusqGeneral = null;
            this.txtNombres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombres.Decimales = 0;
            this.txtNombres.DSData = this.DSDatos;
            this.txtNombres.EsAutoGenerado = false;
            this.txtNombres.EsBusqueda = false;
            this.txtNombres.EsBusquedaAutoIncremental = false;
            this.txtNombres.EsEditable = true;
            this.txtNombres.FiltroBusqueda = "";
            this.txtNombres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombres.Location = new System.Drawing.Point(149, 59);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.NombreTabla = "";
            this.txtNombres.SepDecimal = '\0';
            this.txtNombres.Size = new System.Drawing.Size(301, 29);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TablaOVistaBusqueda = "";
            this.txtNombres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombres.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.AMostrar = null;
            this.txtApellidos.autoSenTab = true;
            this.txtApellidos.AValidar = null;
            this.txtApellidos.CampoBusquedaID = "";
            this.txtApellidos.CampoData = "Apellidos";
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.ColumnasBusqGeneral = null;
            this.txtApellidos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtApellidos.Decimales = 0;
            this.txtApellidos.DSData = this.DSDatos;
            this.txtApellidos.EsAutoGenerado = false;
            this.txtApellidos.EsBusqueda = false;
            this.txtApellidos.EsBusquedaAutoIncremental = false;
            this.txtApellidos.EsEditable = true;
            this.txtApellidos.FiltroBusqueda = "";
            this.txtApellidos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtApellidos.Location = new System.Drawing.Point(149, 94);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.NombreTabla = "";
            this.txtApellidos.SepDecimal = '\0';
            this.txtApellidos.Size = new System.Drawing.Size(301, 29);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.TablaOVistaBusqueda = "";
            this.txtApellidos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtApellidos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtApellidos.ValorPorDefecto = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elrCheckBox3);
            this.groupBox1.Controls.Add(this.elrCheckBox2);
            this.groupBox1.Controls.Add(this.chkEsBloqueado);
            this.groupBox1.Controls.Add(this.chkEsActivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(479, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 333);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // elrCheckBox3
            // 
            this.elrCheckBox3.AutoSize = true;
            this.elrCheckBox3.CampoData = "EsSupervisor";
            this.elrCheckBox3.DSData = this.DSDatos;
            this.elrCheckBox3.EsEditable = true;
            this.elrCheckBox3.EsModificable = true;
            this.elrCheckBox3.FiltroBusqueda = "";
            this.elrCheckBox3.Location = new System.Drawing.Point(14, 127);
            this.elrCheckBox3.Name = "elrCheckBox3";
            this.elrCheckBox3.NombreTabla = "";
            this.elrCheckBox3.Size = new System.Drawing.Size(123, 25);
            this.elrCheckBox3.TabIndex = 3;
            this.elrCheckBox3.Text = "Es Supervisor";
            this.elrCheckBox3.UseVisualStyleBackColor = true;
            this.elrCheckBox3.ValorPorDefecto = true;
            // 
            // elrCheckBox2
            // 
            this.elrCheckBox2.AutoSize = true;
            this.elrCheckBox2.CampoData = "EsCajero";
            this.elrCheckBox2.DSData = this.DSDatos;
            this.elrCheckBox2.EsEditable = true;
            this.elrCheckBox2.EsModificable = true;
            this.elrCheckBox2.FiltroBusqueda = "";
            this.elrCheckBox2.Location = new System.Drawing.Point(15, 96);
            this.elrCheckBox2.Name = "elrCheckBox2";
            this.elrCheckBox2.NombreTabla = "";
            this.elrCheckBox2.Size = new System.Drawing.Size(93, 25);
            this.elrCheckBox2.TabIndex = 2;
            this.elrCheckBox2.Text = "Es Cajero";
            this.elrCheckBox2.UseVisualStyleBackColor = true;
            this.elrCheckBox2.ValorPorDefecto = true;
            // 
            // chkEsBloqueado
            // 
            this.chkEsBloqueado.AutoSize = true;
            this.chkEsBloqueado.CampoData = "EsBloqueado";
            this.chkEsBloqueado.DSData = this.DSDatos;
            this.chkEsBloqueado.EsEditable = true;
            this.chkEsBloqueado.EsModificable = true;
            this.chkEsBloqueado.FiltroBusqueda = "";
            this.chkEsBloqueado.Location = new System.Drawing.Point(15, 59);
            this.chkEsBloqueado.Name = "chkEsBloqueado";
            this.chkEsBloqueado.NombreTabla = "";
            this.chkEsBloqueado.Size = new System.Drawing.Size(122, 25);
            this.chkEsBloqueado.TabIndex = 1;
            this.chkEsBloqueado.Text = "Es Bloqueado";
            this.chkEsBloqueado.UseVisualStyleBackColor = true;
            this.chkEsBloqueado.ValorPorDefecto = false;
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(15, 28);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 0;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // gbContrasena
            // 
            this.gbContrasena.Controls.Add(this.txtConfirmarClave);
            this.gbContrasena.Controls.Add(this.label5);
            this.gbContrasena.Controls.Add(this.txtClave);
            this.gbContrasena.Controls.Add(this.label4);
            this.gbContrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContrasena.Location = new System.Drawing.Point(22, 147);
            this.gbContrasena.Name = "gbContrasena";
            this.gbContrasena.Size = new System.Drawing.Size(428, 158);
            this.gbContrasena.TabIndex = 6;
            this.gbContrasena.TabStop = false;
            this.gbContrasena.Text = "Contrasena";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.AMostrar = null;
            this.txtConfirmarClave.autoSenTab = true;
            this.txtConfirmarClave.AValidar = null;
            this.txtConfirmarClave.CampoBusquedaID = "";
            this.txtConfirmarClave.CampoData = "";
            this.txtConfirmarClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConfirmarClave.ColumnasBusqGeneral = null;
            this.txtConfirmarClave.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConfirmarClave.Decimales = 0;
            this.txtConfirmarClave.DSData = null;
            this.txtConfirmarClave.EsAutoGenerado = false;
            this.txtConfirmarClave.EsBusqueda = false;
            this.txtConfirmarClave.EsBusquedaAutoIncremental = false;
            this.txtConfirmarClave.EsEditable = true;
            this.txtConfirmarClave.FiltroBusqueda = "";
            this.txtConfirmarClave.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConfirmarClave.Location = new System.Drawing.Point(127, 83);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.NombreTabla = "";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.SepDecimal = '\0';
            this.txtConfirmarClave.Size = new System.Drawing.Size(285, 29);
            this.txtConfirmarClave.TabIndex = 3;
            this.txtConfirmarClave.TablaOVistaBusqueda = "";
            this.txtConfirmarClave.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConfirmarClave.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConfirmarClave.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirmar";
            // 
            // txtClave
            // 
            this.txtClave.AMostrar = null;
            this.txtClave.autoSenTab = true;
            this.txtClave.AValidar = null;
            this.txtClave.CampoBusquedaID = "";
            this.txtClave.CampoData = "";
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.ColumnasBusqGeneral = null;
            this.txtClave.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtClave.Decimales = 0;
            this.txtClave.DSData = null;
            this.txtClave.EsAutoGenerado = false;
            this.txtClave.EsBusqueda = false;
            this.txtClave.EsBusquedaAutoIncremental = false;
            this.txtClave.EsEditable = true;
            this.txtClave.FiltroBusqueda = "";
            this.txtClave.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtClave.Location = new System.Drawing.Point(127, 37);
            this.txtClave.Name = "txtClave";
            this.txtClave.NombreTabla = "";
            this.txtClave.PasswordChar = '*';
            this.txtClave.SepDecimal = '\0';
            this.txtClave.Size = new System.Drawing.Size(285, 29);
            this.txtClave.TabIndex = 1;
            this.txtClave.TablaOVistaBusqueda = "";
            this.txtClave.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtClave.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtClave.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clave";
            // 
            // FormUsuariosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombreUsuario;
            valida1.Mensaje = "Debe Indicar el Nombre de Usuario";
            valida1.NombreCampo = "Nombre_Usuario";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombreUsuario;
            valida2.Mensaje = "El Nombre de Usuario Debe Tener Minimo 8 Caracteres";
            valida2.NombreCampo = "Nombre_Usuario";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "6";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.CamposAExcluirEnc = "Clave";
            this.ClientSize = new System.Drawing.Size(648, 376);
            this.Controls.Add(this.gbContrasena);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuariosR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = " TACCESOS_USUARIOS";
            this.Text = "REGISTRO DE USUARIOS";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombreUsuario, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbContrasena, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContrasena.ResumeLayout(false);
            this.gbContrasena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtApellidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRCheckBox chkEsBloqueado;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.GroupBox gbContrasena;
        private WinControl_ELR_NET.ELRTextBox txtConfirmarClave;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtClave;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox3;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox2;
    }
}