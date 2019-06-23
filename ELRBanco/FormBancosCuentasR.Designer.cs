namespace ELRBanco
{
    partial class FormBancosCuentasR
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
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEsNomina = new WinControl_ELR_NET.ELRCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoCompleto = new WinControl_ELR_NET.ELRTextBox();
            this.chkEsCheques = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.btnBuscarCtaContable = new System.Windows.Forms.Button();
            this.txtCuentaContable = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBanco = new WinControl_ELR_NET.ELRCombobox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecuenciaCheques = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 402);
            this.pnBotones.Size = new System.Drawing.Size(581, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(341, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(482, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(246, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(151, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSecuenciaCheques);
            this.panel1.Controls.Add(this.chkEsNomina);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chkEsCheques);
            this.panel1.Controls.Add(this.chkEsActivo);
            this.panel1.Controls.Add(this.btnBuscarCtaContable);
            this.panel1.Controls.Add(this.txtCuentaContable);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboOficina);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboBanco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 402);
            this.panel1.TabIndex = 0;
            // 
            // chkEsNomina
            // 
            this.chkEsNomina.AutoSize = true;
            this.chkEsNomina.CampoData = "EsNomina";
            this.chkEsNomina.DSData = this.DSDatos;
            this.chkEsNomina.EsEditable = true;
            this.chkEsNomina.EsModificable = true;
            this.chkEsNomina.FiltroBusqueda = "";
            this.chkEsNomina.Location = new System.Drawing.Point(263, 224);
            this.chkEsNomina.Name = "chkEsNomina";
            this.chkEsNomina.NombreTabla = "";
            this.chkEsNomina.Size = new System.Drawing.Size(104, 25);
            this.chkEsNomina.TabIndex = 14;
            this.chkEsNomina.Text = "Es Nomina";
            this.chkEsNomina.UseVisualStyleBackColor = true;
            this.chkEsNomina.ValorPorDefecto = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoCompleto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 67);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo o Numeracion Completo";
            // 
            // txtCodigoCompleto
            // 
            this.txtCodigoCompleto.AMostrar = null;
            this.txtCodigoCompleto.AValidar = null;
            this.txtCodigoCompleto.CampoBusquedaID = "";
            this.txtCodigoCompleto.CampoData = "Codigo_Completo";
            this.txtCodigoCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCompleto.ColumnasBusqGeneral = null;
            this.txtCodigoCompleto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoCompleto.Decimales = 0;
            this.txtCodigoCompleto.DSData = this.DSDatos;
            this.txtCodigoCompleto.EsAutoGenerado = false;
            this.txtCodigoCompleto.EsBusqueda = false;
            this.txtCodigoCompleto.EsBusquedaAutoIncremental = false;
            this.txtCodigoCompleto.EsEditable = true;
            this.txtCodigoCompleto.FiltroBusqueda = "";
            this.txtCodigoCompleto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompleto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoCompleto.Location = new System.Drawing.Point(21, 28);
            this.txtCodigoCompleto.Name = "txtCodigoCompleto";
            this.txtCodigoCompleto.NombreTabla = "";
            this.txtCodigoCompleto.SepDecimal = '\0';
            this.txtCodigoCompleto.Size = new System.Drawing.Size(446, 33);
            this.txtCodigoCompleto.TabIndex = 0;
            this.txtCodigoCompleto.TablaOVistaBusqueda = "";
            this.txtCodigoCompleto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoCompleto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigoCompleto, "Numeracion Usada Para Transferencias Electronicas");
            this.txtCodigoCompleto.ValorPorDefecto = "";
            // 
            // chkEsCheques
            // 
            this.chkEsCheques.AutoSize = true;
            this.chkEsCheques.CampoData = "EsCheques";
            this.chkEsCheques.DSData = this.DSDatos;
            this.chkEsCheques.EsEditable = true;
            this.chkEsCheques.EsModificable = true;
            this.chkEsCheques.FiltroBusqueda = "";
            this.chkEsCheques.Location = new System.Drawing.Point(151, 255);
            this.chkEsCheques.Name = "chkEsCheques";
            this.chkEsCheques.NombreTabla = "";
            this.chkEsCheques.Size = new System.Drawing.Size(187, 25);
            this.chkEsCheques.TabIndex = 15;
            this.chkEsCheques.Text = "Es Cheques, Secuencia:";
            this.chkEsCheques.UseVisualStyleBackColor = true;
            this.chkEsCheques.ValorPorDefecto = true;
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Location = new System.Drawing.Point(151, 224);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(91, 25);
            this.chkEsActivo.TabIndex = 13;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // btnBuscarCtaContable
            // 
            this.btnBuscarCtaContable.Image = global::ELRBanco.Properties.Resources._1378160672_search;
            this.btnBuscarCtaContable.Location = new System.Drawing.Point(319, 172);
            this.btnBuscarCtaContable.Name = "btnBuscarCtaContable";
            this.btnBuscarCtaContable.Size = new System.Drawing.Size(48, 29);
            this.btnBuscarCtaContable.TabIndex = 12;
            this.btnBuscarCtaContable.UseVisualStyleBackColor = true;
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.AMostrar = null;
            this.txtCuentaContable.AValidar = null;
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
            this.txtCuentaContable.Formato = WinControl_ELR_NET.tbFormato.LetrasYNumeros;
            this.txtCuentaContable.Location = new System.Drawing.Point(151, 172);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.NombreTabla = "";
            this.txtCuentaContable.SepDecimal = '\0';
            this.txtCuentaContable.Size = new System.Drawing.Size(162, 29);
            this.txtCuentaContable.TabIndex = 11;
            this.txtCuentaContable.TablaOVistaBusqueda = "";
            this.txtCuentaContable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuentaContable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuentaContable.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cuenta Contable:";
            // 
            // cboOficina
            // 
            this.cboOficina.AValidar = null;
            this.cboOficina.CampoData = "Oficina_Id";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DisplayMember = "Nombre";
            this.cboOficina.DSData = this.DSDatos;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(98, 128);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(446, 29);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 9;
            this.cboOficina.TablaOVistaConsulta = "TEMPRESAS_OFICINAS";
            this.cboOficina.UsaDataGlobal = false;
            this.cboOficina.ValorPorDefecto = "0";
            this.cboOficina.ValueMember = "Oficina_Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oficina:";
            // 
            // cboBanco
            // 
            this.cboBanco.AValidar = null;
            this.cboBanco.CampoData = "Banco_Id";
            this.cboBanco.CampoJoinCombobox2 = "";
            this.cboBanco.ComboboxAFiltrar = null;
            this.cboBanco.DisplayMember = "Nombre";
            this.cboBanco.DSData = this.DSDatos;
            this.cboBanco.EsEditable = true;
            this.cboBanco.FiltroBusqueda = "";
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(98, 93);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.NombreTabla = "";
            this.cboBanco.Size = new System.Drawing.Size(446, 29);
            this.cboBanco.SSQL = "";
            this.cboBanco.TabIndex = 7;
            this.cboBanco.TablaOVistaConsulta = "TBANCOS";
            this.cboBanco.UsaDataGlobal = false;
            this.cboBanco.ValorPorDefecto = "0";
            this.cboBanco.ValueMember = "Banco_Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Banco:";
            // 
            // txtNumero
            // 
            this.txtNumero.AMostrar = null;
            this.txtNumero.AValidar = null;
            this.txtNumero.CampoBusquedaID = "";
            this.txtNumero.CampoData = "Numero";
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.ColumnasBusqGeneral = null;
            this.txtNumero.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumero.Decimales = 0;
            this.txtNumero.DSData = this.DSDatos;
            this.txtNumero.EsAutoGenerado = false;
            this.txtNumero.EsBusqueda = false;
            this.txtNumero.EsBusquedaAutoIncremental = false;
            this.txtNumero.EsEditable = true;
            this.txtNumero.FiltroBusqueda = "";
            this.txtNumero.Formato = WinControl_ELR_NET.tbFormato.LetrasYNumeros;
            this.txtNumero.Location = new System.Drawing.Point(333, 23);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.NombreTabla = "";
            this.txtNumero.SepDecimal = '\0';
            this.txtNumero.Size = new System.Drawing.Size(211, 29);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TablaOVistaBusqueda = "";
            this.txtNumero.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumero.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumero.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero:";
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
            this.txtNombre.Location = new System.Drawing.Point(98, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(446, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Cuenta_Id";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = false;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(98, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(126, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta Id:";
            // 
            // txtSecuenciaCheques
            // 
            this.txtSecuenciaCheques.AMostrar = null;
            this.txtSecuenciaCheques.AValidar = null;
            this.txtSecuenciaCheques.CampoBusquedaID = "";
            this.txtSecuenciaCheques.CampoData = "Secuencia_Cheques";
            this.txtSecuenciaCheques.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSecuenciaCheques.ColumnasBusqGeneral = null;
            this.txtSecuenciaCheques.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSecuenciaCheques.Decimales = 0;
            this.txtSecuenciaCheques.DSData = this.DSDatos;
            this.txtSecuenciaCheques.EsAutoGenerado = false;
            this.txtSecuenciaCheques.EsBusqueda = false;
            this.txtSecuenciaCheques.EsBusquedaAutoIncremental = false;
            this.txtSecuenciaCheques.EsEditable = true;
            this.txtSecuenciaCheques.FiltroBusqueda = "";
            this.txtSecuenciaCheques.Formato = WinControl_ELR_NET.tbFormato.LetrasYNumeros;
            this.txtSecuenciaCheques.Location = new System.Drawing.Point(344, 255);
            this.txtSecuenciaCheques.Name = "txtSecuenciaCheques";
            this.txtSecuenciaCheques.NombreTabla = "";
            this.txtSecuenciaCheques.SepDecimal = '\0';
            this.txtSecuenciaCheques.Size = new System.Drawing.Size(200, 29);
            this.txtSecuenciaCheques.TabIndex = 16;
            this.txtSecuenciaCheques.TablaOVistaBusqueda = "";
            this.txtSecuenciaCheques.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSecuenciaCheques.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSecuenciaCheques.ValorPorDefecto = "1";
            // 
            // FormBancosCuentasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = null;
            valida1.Mensaje = "Debe Indicar Numero de Cuenta";
            valida1.NombreCampo = "Numero";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = null;
            valida2.Mensaje = "Debe Indicar un Nombre";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            valida3.comtrol = null;
            valida3.Mensaje = "Debe Elegir un Banco";
            valida3.NombreCampo = "Banco_Id";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida3.Valor1 = null;
            valida3.Valor2 = null;
            valida4.comtrol = null;
            valida4.Mensaje = "Debe Elegir una Oficina";
            valida4.NombreCampo = "Oficina_Id";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida4.Valor1 = null;
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(581, 445);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBancosCuentasR";
            this.NombreCampoID = "Cuenta_Id";
            this.TablaEncabezado = "TBANCOS_CUENTAS_BANCARIAS";
            this.Text = "REGISTRAR CUENTA BANCARIA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRCheckBox chkEsCheques;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private System.Windows.Forms.Button btnBuscarCtaContable;
        private WinControl_ELR_NET.ELRTextBox txtCuentaContable;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRCombobox cboOficina;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRCombobox cboBanco;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtCodigoCompleto;
        private WinControl_ELR_NET.ELRCheckBox chkEsNomina;
        private WinControl_ELR_NET.ELRTextBox txtSecuenciaCheques;
    }
}