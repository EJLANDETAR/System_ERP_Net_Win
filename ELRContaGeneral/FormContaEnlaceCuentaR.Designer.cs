namespace ELRContaGeneral
{
    partial class FormContaEnlaceCuentaR
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
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.cboEnlace = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuentaContable = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 278);
            this.pnBotones.Size = new System.Drawing.Size(603, 43);
            this.pnBotones.TabIndex = 8;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(363, 0);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(504, 0);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(268, 0);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(173, 39);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Codigo";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(175, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(396, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            // 
            // cboEnlace
            // 
            this.cboEnlace.AValidar = null;
            this.cboEnlace.CampoData = "Enlace_Id";
            this.cboEnlace.CampoJoinCombobox2 = "";
            this.cboEnlace.ComboboxAFiltrar = null;
            this.cboEnlace.DisplayMember = "Descripcion";
            this.cboEnlace.DSData = this.DSDatos;
            this.cboEnlace.EsEditable = true;
            this.cboEnlace.FiltroBusqueda = "";
            this.cboEnlace.FormattingEnabled = true;
            this.cboEnlace.Location = new System.Drawing.Point(175, 56);
            this.cboEnlace.Name = "cboEnlace";
            this.cboEnlace.NombreTabla = "";
            this.cboEnlace.Size = new System.Drawing.Size(396, 29);
            this.cboEnlace.SSQL = "";
            this.cboEnlace.TabIndex = 3;
            this.cboEnlace.TablaOVistaConsulta = "";
            this.cboEnlace.UsaDataGlobal = false;
            this.cboEnlace.ValorPorDefecto = "0";
            this.cboEnlace.ValueMember = "Enlace_Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuenta Contable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Enlace:";
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.AMostrar = null;
            this.txtCuentaContable.AValidar = null;
            this.txtCuentaContable.BackColor = System.Drawing.Color.White;
            this.txtCuentaContable.CampoBusquedaID = "";
            this.txtCuentaContable.CampoData = "Cuenta_Contable";
            this.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContable.ColumnasBusqGeneral = null;
            this.txtCuentaContable.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCuentaContable.Decimales = 0;
            this.txtCuentaContable.DSData = this.DSDatos;
            this.txtCuentaContable.EsAutoGenerado = false;
            this.txtCuentaContable.EsBusqueda = false;
            this.txtCuentaContable.EsBusquedaAutoIncremental = false;
            this.txtCuentaContable.EsEditable = true;
            this.txtCuentaContable.FiltroBusqueda = "";
            this.txtCuentaContable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaContable.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCuentaContable.Location = new System.Drawing.Point(175, 92);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.NombreTabla = "";
            this.txtCuentaContable.ReadOnly = true;
            this.txtCuentaContable.SepDecimal = '\0';
            this.txtCuentaContable.Size = new System.Drawing.Size(267, 29);
            this.txtCuentaContable.TabIndex = 5;
            this.txtCuentaContable.TablaOVistaBusqueda = "";
            this.txtCuentaContable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuentaContable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuentaContable.ValorPorDefecto = "";
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnBuscarCuenta.Location = new System.Drawing.Point(448, 92);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(44, 30);
            this.btnBuscarCuenta.TabIndex = 6;
            this.btnBuscarCuenta.UseVisualStyleBackColor = true;
            this.btnBuscarCuenta.Click += new System.EventHandler(this.btnBuscarCuenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comentario";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AMostrar = null;
            this.txtDescripcion.AValidar = null;
            this.txtDescripcion.CampoBusquedaID = "";
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColumnasBusqGeneral = null;
            this.txtDescripcion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescripcion.Decimales = 0;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsBusqueda = false;
            this.txtDescripcion.EsBusquedaAutoIncremental = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 25);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.SepDecimal = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(597, 111);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.TablaOVistaBusqueda = "";
            this.txtDescripcion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescripcion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // FormContaEnlaceCuentaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtCodigo;
            valida1.Mensaje = "Debe Introducir un Codigo";
            valida1.NombreCampo = "Codigo";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.cboEnlace;
            valida2.Mensaje = "Debe Elegir el Enlace";
            valida2.NombreCampo = "Enlace_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.Mensaje = "Debe Indicar una Descripcion";
            valida3.NombreCampo = "Descripcion";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(603, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarCuenta);
            this.Controls.Add(this.txtCuentaContable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEnlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContaEnlaceCuentaR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TCONTA_ENLACES_CUENTAS";
            this.Text = "ENLACE CUENTA REGISTRO";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboEnlace, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCuentaContable, 0);
            this.Controls.SetChildIndex(this.btnBuscarCuenta, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
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
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboEnlace;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtCuentaContable;
        private System.Windows.Forms.Button btnBuscarCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
    }
}