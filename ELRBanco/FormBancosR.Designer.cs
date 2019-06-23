namespace ELRBanco
{
    partial class FormBancosR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new WinControl_ELR_NET.ELRTextBox();
            this.txtTelefono2 = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreContacto = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionWeb = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExt = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEMail = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 376);
            this.pnBotones.Size = new System.Drawing.Size(672, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(432, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(573, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(337, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Banco_Id";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsEditable = false;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(146, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(139, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
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
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(146, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(488, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AMostrar = null;
            this.txtDireccion.AValidar = null;
            this.txtDireccion.CampoBusquedaID = "";
            this.txtDireccion.CampoData = "Direccion";
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColumnasBusqGeneral = null;
            this.txtDireccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDireccion.Decimales = 0;
            this.txtDireccion.DSData = this.DSDatos;
            this.txtDireccion.EsAutoGenerado = false;
            this.txtDireccion.EsBusqueda = false;
            this.txtDireccion.EsEditable = true;
            this.txtDireccion.FiltroBusqueda = "";
            this.txtDireccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDireccion.Location = new System.Drawing.Point(148, 95);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NombreTabla = "";
            this.txtDireccion.SepDecimal = '\0';
            this.txtDireccion.Size = new System.Drawing.Size(486, 70);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TablaOVistaBusqueda = "";
            this.txtDireccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDireccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDireccion.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefonos:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.AMostrar = null;
            this.txtTelefono1.AValidar = null;
            this.txtTelefono1.CampoBusquedaID = "";
            this.txtTelefono1.CampoData = "Telefono1";
            this.txtTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono1.ColumnasBusqGeneral = null;
            this.txtTelefono1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono1.Decimales = 0;
            this.txtTelefono1.DSData = this.DSDatos;
            this.txtTelefono1.EsAutoGenerado = false;
            this.txtTelefono1.EsBusqueda = false;
            this.txtTelefono1.EsEditable = true;
            this.txtTelefono1.FiltroBusqueda = "";
            this.txtTelefono1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono1.Location = new System.Drawing.Point(148, 171);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.NombreTabla = "";
            this.txtTelefono1.SepDecimal = '\0';
            this.txtTelefono1.Size = new System.Drawing.Size(174, 29);
            this.txtTelefono1.TabIndex = 8;
            this.txtTelefono1.TablaOVistaBusqueda = "";
            this.txtTelefono1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono1.ValorPorDefecto = "";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.AMostrar = null;
            this.txtTelefono2.AValidar = null;
            this.txtTelefono2.CampoBusquedaID = "";
            this.txtTelefono2.CampoData = "Telefono2";
            this.txtTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono2.ColumnasBusqGeneral = null;
            this.txtTelefono2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono2.Decimales = 0;
            this.txtTelefono2.DSData = this.DSDatos;
            this.txtTelefono2.EsAutoGenerado = false;
            this.txtTelefono2.EsBusqueda = false;
            this.txtTelefono2.EsEditable = true;
            this.txtTelefono2.FiltroBusqueda = "";
            this.txtTelefono2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono2.Location = new System.Drawing.Point(349, 171);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.NombreTabla = "";
            this.txtTelefono2.SepDecimal = '\0';
            this.txtTelefono2.Size = new System.Drawing.Size(170, 29);
            this.txtTelefono2.TabIndex = 10;
            this.txtTelefono2.TablaOVistaBusqueda = "";
            this.txtTelefono2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono2.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre Contacto:";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.AMostrar = null;
            this.txtNombreContacto.AValidar = null;
            this.txtNombreContacto.CampoBusquedaID = "";
            this.txtNombreContacto.CampoData = "Nombre_Contacto";
            this.txtNombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreContacto.ColumnasBusqGeneral = null;
            this.txtNombreContacto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreContacto.Decimales = 0;
            this.txtNombreContacto.DSData = this.DSDatos;
            this.txtNombreContacto.EsAutoGenerado = false;
            this.txtNombreContacto.EsBusqueda = false;
            this.txtNombreContacto.EsEditable = true;
            this.txtNombreContacto.FiltroBusqueda = "";
            this.txtNombreContacto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreContacto.Location = new System.Drawing.Point(172, 290);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.NombreTabla = "";
            this.txtNombreContacto.SepDecimal = '\0';
            this.txtNombreContacto.Size = new System.Drawing.Size(318, 29);
            this.txtNombreContacto.TabIndex = 12;
            this.txtNombreContacto.TablaOVistaBusqueda = "";
            this.txtNombreContacto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreContacto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreContacto.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Direccion Web:";
            // 
            // txtDireccionWeb
            // 
            this.txtDireccionWeb.AMostrar = null;
            this.txtDireccionWeb.AValidar = null;
            this.txtDireccionWeb.CampoBusquedaID = "";
            this.txtDireccionWeb.CampoData = "DireccionWeb";
            this.txtDireccionWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionWeb.ColumnasBusqGeneral = null;
            this.txtDireccionWeb.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDireccionWeb.Decimales = 0;
            this.txtDireccionWeb.DSData = this.DSDatos;
            this.txtDireccionWeb.EsAutoGenerado = false;
            this.txtDireccionWeb.EsBusqueda = false;
            this.txtDireccionWeb.EsEditable = true;
            this.txtDireccionWeb.FiltroBusqueda = "";
            this.txtDireccionWeb.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDireccionWeb.Location = new System.Drawing.Point(148, 207);
            this.txtDireccionWeb.Name = "txtDireccionWeb";
            this.txtDireccionWeb.NombreTabla = "";
            this.txtDireccionWeb.SepDecimal = '\0';
            this.txtDireccionWeb.Size = new System.Drawing.Size(486, 29);
            this.txtDireccionWeb.TabIndex = 14;
            this.txtDireccionWeb.TablaOVistaBusqueda = "";
            this.txtDireccionWeb.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDireccionWeb.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDireccionWeb.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ext.:";
            // 
            // txtExt
            // 
            this.txtExt.AMostrar = null;
            this.txtExt.AValidar = null;
            this.txtExt.CampoBusquedaID = "";
            this.txtExt.CampoData = "Ext";
            this.txtExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExt.ColumnasBusqGeneral = null;
            this.txtExt.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtExt.Decimales = 0;
            this.txtExt.DSData = this.DSDatos;
            this.txtExt.EsAutoGenerado = false;
            this.txtExt.EsBusqueda = false;
            this.txtExt.EsEditable = true;
            this.txtExt.FiltroBusqueda = "";
            this.txtExt.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtExt.Location = new System.Drawing.Point(553, 293);
            this.txtExt.Name = "txtExt";
            this.txtExt.NombreTabla = "";
            this.txtExt.SepDecimal = '\0';
            this.txtExt.Size = new System.Drawing.Size(81, 29);
            this.txtExt.TabIndex = 16;
            this.txtExt.TablaOVistaBusqueda = "";
            this.txtExt.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtExt.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtExt.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "EMail:";
            // 
            // txtEMail
            // 
            this.txtEMail.AMostrar = null;
            this.txtEMail.AValidar = null;
            this.txtEMail.CampoBusquedaID = "";
            this.txtEMail.CampoData = "EMail";
            this.txtEMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEMail.ColumnasBusqGeneral = null;
            this.txtEMail.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEMail.Decimales = 0;
            this.txtEMail.DSData = this.DSDatos;
            this.txtEMail.EsAutoGenerado = false;
            this.txtEMail.EsBusqueda = false;
            this.txtEMail.EsEditable = true;
            this.txtEMail.FiltroBusqueda = "";
            this.txtEMail.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEMail.Location = new System.Drawing.Point(148, 242);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.NombreTabla = "";
            this.txtEMail.SepDecimal = '\0';
            this.txtEMail.Size = new System.Drawing.Size(486, 29);
            this.txtEMail.TabIndex = 18;
            this.txtEMail.TablaOVistaBusqueda = "";
            this.txtEMail.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEMail.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEMail.ValorPorDefecto = "";
            // 
            // FormBancosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Indicar un Nombre";
            valida1.NombreCampo = "Nombre";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "3";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtDireccion;
            valida2.Mensaje = "Debe Indicar una Direccion";
            valida2.NombreCampo = "Direccion";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtTelefono1;
            valida3.Mensaje = "Debe Indicar el Telefono";
            valida3.NombreCampo = "Telefono1";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(672, 419);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccionWeb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBancosR";
            this.NombreCampoID = "Banco_Id";
            this.TablaEncabezado = "TBANCOS";
            this.Text = "REGISTRAR BANCO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTelefono1, 0);
            this.Controls.SetChildIndex(this.txtTelefono2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNombreContacto, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDireccionWeb, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtExt, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtEMail, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtTelefono1;
        private WinControl_ELR_NET.ELRTextBox txtTelefono2;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtNombreContacto;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtDireccionWeb;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtExt;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txtEMail;
    }
}