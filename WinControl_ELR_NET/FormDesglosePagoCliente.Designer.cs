namespace WinControl_ELR_NET
{
    partial class FormDesglosePagoCliente
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.pnDesglose = new System.Windows.Forms.Panel();
            this.txtAPagar = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grbCredito = new System.Windows.Forms.GroupBox();
            this.txtACredito = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtADevolver = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnTarjeta = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnCheques = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnEfectivo = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtTelefono2 = new WinControl_ELR_NET.ELRTextBox();
            this.txtTelefono1 = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAmortizacion = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTasaAnual = new WinControl_ELR_NET.ELRTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCuotaMonto = new WinControl_ELR_NET.ELRTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboMetodo = new WinControl_ELR_NET.ELRCombobox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboFrecuenciaPago = new WinControl_ELR_NET.ELRCombobox();
            this.txtPlazos = new WinControl_ELR_NET.ELRTextBox();
            this.txtTasaMensual = new WinControl_ELR_NET.ELRTextBox();
            this.lblMontoAFinancial = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPagoInicial = new WinControl_ELR_NET.ELRTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.pnDesglose.SuspendLayout();
            this.grbCredito.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpAmortizacion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 626);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(673, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 46);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Siguiente";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(788, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.Black;
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbTotal.Location = new System.Drawing.Point(0, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(907, 60);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "0.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAmortizacion);
            this.tabControl1.Controls.Add(this.tpClientes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 566);
            this.tabControl1.TabIndex = 5;
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.pnDesglose);
            this.tpClientes.Controls.Add(this.groupBox1);
            this.tpClientes.Location = new System.Drawing.Point(4, 33);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(899, 529);
            this.tpClientes.TabIndex = 0;
            this.tpClientes.Text = "Cliente";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // pnDesglose
            // 
            this.pnDesglose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDesglose.Controls.Add(this.txtAPagar);
            this.pnDesglose.Controls.Add(this.label12);
            this.pnDesglose.Controls.Add(this.grbCredito);
            this.pnDesglose.Controls.Add(this.txtADevolver);
            this.pnDesglose.Controls.Add(this.label6);
            this.pnDesglose.Controls.Add(this.txtEnTarjeta);
            this.pnDesglose.Controls.Add(this.label7);
            this.pnDesglose.Controls.Add(this.txtEnCheques);
            this.pnDesglose.Controls.Add(this.label8);
            this.pnDesglose.Controls.Add(this.txtEnEfectivo);
            this.pnDesglose.Controls.Add(this.label9);
            this.pnDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesglose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDesglose.Location = new System.Drawing.Point(3, 291);
            this.pnDesglose.Name = "pnDesglose";
            this.pnDesglose.Size = new System.Drawing.Size(893, 235);
            this.pnDesglose.TabIndex = 3;
            // 
            // txtAPagar
            // 
            this.txtAPagar.AMostrar = null;
            this.txtAPagar.autoSenTab = true;
            this.txtAPagar.AValidar = null;
            this.txtAPagar.BackColor = System.Drawing.Color.White;
            this.txtAPagar.CampoBusquedaID = "";
            this.txtAPagar.CampoData = "";
            this.txtAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAPagar.ColumnasBusqGeneral = null;
            this.txtAPagar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAPagar.Decimales = 2;
            this.txtAPagar.DSData = null;
            this.txtAPagar.EsAutoGenerado = false;
            this.txtAPagar.EsBusqueda = false;
            this.txtAPagar.EsBusquedaAutoIncremental = false;
            this.txtAPagar.EsEditable = true;
            this.txtAPagar.FiltroBusqueda = "";
            this.txtAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPagar.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtAPagar.Location = new System.Drawing.Point(240, 23);
            this.txtAPagar.Name = "txtAPagar";
            this.txtAPagar.NombreTabla = "";
            this.txtAPagar.SepDecimal = '\0';
            this.txtAPagar.Size = new System.Drawing.Size(243, 38);
            this.txtAPagar.TabIndex = 2;
            this.txtAPagar.TablaOVistaBusqueda = "";
            this.txtAPagar.Text = "0.00";
            this.txtAPagar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAPagar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAPagar.ValorPorDefecto = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "A Pagar (Inicial)";
            // 
            // grbCredito
            // 
            this.grbCredito.Controls.Add(this.txtACredito);
            this.grbCredito.Controls.Add(this.label10);
            this.grbCredito.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCredito.Location = new System.Drawing.Point(552, 0);
            this.grbCredito.Name = "grbCredito";
            this.grbCredito.Size = new System.Drawing.Size(337, 231);
            this.grbCredito.TabIndex = 11;
            this.grbCredito.TabStop = false;
            this.grbCredito.Text = "[ CREDITO ]";
            // 
            // txtACredito
            // 
            this.txtACredito.AMostrar = null;
            this.txtACredito.autoSenTab = true;
            this.txtACredito.AValidar = null;
            this.txtACredito.BackColor = System.Drawing.Color.White;
            this.txtACredito.CampoBusquedaID = "";
            this.txtACredito.CampoData = "";
            this.txtACredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtACredito.ColumnasBusqGeneral = null;
            this.txtACredito.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtACredito.Decimales = 2;
            this.txtACredito.DSData = null;
            this.txtACredito.EsAutoGenerado = false;
            this.txtACredito.EsBusqueda = false;
            this.txtACredito.EsBusquedaAutoIncremental = false;
            this.txtACredito.EsEditable = true;
            this.txtACredito.FiltroBusqueda = "";
            this.txtACredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACredito.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtACredito.Location = new System.Drawing.Point(29, 73);
            this.txtACredito.Name = "txtACredito";
            this.txtACredito.NombreTabla = "";
            this.txtACredito.ReadOnly = true;
            this.txtACredito.SepDecimal = '\0';
            this.txtACredito.Size = new System.Drawing.Size(283, 38);
            this.txtACredito.TabIndex = 1;
            this.txtACredito.TablaOVistaBusqueda = "";
            this.txtACredito.Text = "0.00";
            this.txtACredito.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtACredito.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtACredito.ValorPorDefecto = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "A CREDITO";
            // 
            // txtADevolver
            // 
            this.txtADevolver.AMostrar = null;
            this.txtADevolver.autoSenTab = true;
            this.txtADevolver.AValidar = null;
            this.txtADevolver.BackColor = System.Drawing.Color.White;
            this.txtADevolver.CampoBusquedaID = "";
            this.txtADevolver.CampoData = "";
            this.txtADevolver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtADevolver.ColumnasBusqGeneral = null;
            this.txtADevolver.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtADevolver.Decimales = 2;
            this.txtADevolver.DSData = null;
            this.txtADevolver.EsAutoGenerado = false;
            this.txtADevolver.EsBusqueda = false;
            this.txtADevolver.EsBusquedaAutoIncremental = false;
            this.txtADevolver.EsEditable = true;
            this.txtADevolver.FiltroBusqueda = "";
            this.txtADevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADevolver.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtADevolver.Location = new System.Drawing.Point(237, 198);
            this.txtADevolver.Name = "txtADevolver";
            this.txtADevolver.NombreTabla = "";
            this.txtADevolver.ReadOnly = true;
            this.txtADevolver.SepDecimal = '\0';
            this.txtADevolver.Size = new System.Drawing.Size(245, 38);
            this.txtADevolver.TabIndex = 10;
            this.txtADevolver.TablaOVistaBusqueda = "";
            this.txtADevolver.Text = "0.00";
            this.txtADevolver.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtADevolver.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtADevolver.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "A Devolver";
            // 
            // txtEnTarjeta
            // 
            this.txtEnTarjeta.AMostrar = null;
            this.txtEnTarjeta.autoSenTab = true;
            this.txtEnTarjeta.AValidar = null;
            this.txtEnTarjeta.BackColor = System.Drawing.Color.White;
            this.txtEnTarjeta.CampoBusquedaID = "";
            this.txtEnTarjeta.CampoData = "";
            this.txtEnTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnTarjeta.ColumnasBusqGeneral = null;
            this.txtEnTarjeta.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEnTarjeta.Decimales = 2;
            this.txtEnTarjeta.DSData = null;
            this.txtEnTarjeta.EsAutoGenerado = false;
            this.txtEnTarjeta.EsBusqueda = false;
            this.txtEnTarjeta.EsBusquedaAutoIncremental = false;
            this.txtEnTarjeta.EsEditable = true;
            this.txtEnTarjeta.FiltroBusqueda = "";
            this.txtEnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnTarjeta.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtEnTarjeta.Location = new System.Drawing.Point(239, 154);
            this.txtEnTarjeta.Name = "txtEnTarjeta";
            this.txtEnTarjeta.NombreTabla = "";
            this.txtEnTarjeta.SepDecimal = '\0';
            this.txtEnTarjeta.Size = new System.Drawing.Size(243, 38);
            this.txtEnTarjeta.TabIndex = 8;
            this.txtEnTarjeta.TablaOVistaBusqueda = "";
            this.txtEnTarjeta.Text = "0.00";
            this.txtEnTarjeta.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEnTarjeta.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEnTarjeta.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "En Tarjeta";
            // 
            // txtEnCheques
            // 
            this.txtEnCheques.AMostrar = null;
            this.txtEnCheques.autoSenTab = true;
            this.txtEnCheques.AValidar = null;
            this.txtEnCheques.BackColor = System.Drawing.Color.White;
            this.txtEnCheques.CampoBusquedaID = "";
            this.txtEnCheques.CampoData = "";
            this.txtEnCheques.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnCheques.ColumnasBusqGeneral = null;
            this.txtEnCheques.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEnCheques.Decimales = 2;
            this.txtEnCheques.DSData = null;
            this.txtEnCheques.EsAutoGenerado = false;
            this.txtEnCheques.EsBusqueda = false;
            this.txtEnCheques.EsBusquedaAutoIncremental = false;
            this.txtEnCheques.EsEditable = true;
            this.txtEnCheques.FiltroBusqueda = "";
            this.txtEnCheques.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnCheques.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtEnCheques.Location = new System.Drawing.Point(239, 110);
            this.txtEnCheques.Name = "txtEnCheques";
            this.txtEnCheques.NombreTabla = "";
            this.txtEnCheques.SepDecimal = '\0';
            this.txtEnCheques.Size = new System.Drawing.Size(244, 38);
            this.txtEnCheques.TabIndex = 6;
            this.txtEnCheques.TablaOVistaBusqueda = "";
            this.txtEnCheques.Text = "0.00";
            this.txtEnCheques.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEnCheques.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEnCheques.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "En Cheques";
            // 
            // txtEnEfectivo
            // 
            this.txtEnEfectivo.AMostrar = null;
            this.txtEnEfectivo.autoSenTab = true;
            this.txtEnEfectivo.AValidar = null;
            this.txtEnEfectivo.BackColor = System.Drawing.Color.White;
            this.txtEnEfectivo.CampoBusquedaID = "";
            this.txtEnEfectivo.CampoData = "";
            this.txtEnEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnEfectivo.ColumnasBusqGeneral = null;
            this.txtEnEfectivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEnEfectivo.Decimales = 2;
            this.txtEnEfectivo.DSData = null;
            this.txtEnEfectivo.EsAutoGenerado = false;
            this.txtEnEfectivo.EsBusqueda = false;
            this.txtEnEfectivo.EsBusquedaAutoIncremental = false;
            this.txtEnEfectivo.EsEditable = true;
            this.txtEnEfectivo.FiltroBusqueda = "";
            this.txtEnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnEfectivo.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtEnEfectivo.Location = new System.Drawing.Point(240, 66);
            this.txtEnEfectivo.Name = "txtEnEfectivo";
            this.txtEnEfectivo.NombreTabla = "";
            this.txtEnEfectivo.SepDecimal = '\0';
            this.txtEnEfectivo.Size = new System.Drawing.Size(243, 38);
            this.txtEnEfectivo.TabIndex = 4;
            this.txtEnEfectivo.TablaOVistaBusqueda = "";
            this.txtEnEfectivo.Text = "0.00";
            this.txtEnEfectivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEnEfectivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEnEfectivo.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "En Efectivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtTelefono2);
            this.groupBox1.Controls.Add(this.txtTelefono1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCedulaRNC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE ENTIDAD (CLIENTE)";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(357, 39);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(87, 34);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.AMostrar = null;
            this.txtTelefono2.autoSenTab = true;
            this.txtTelefono2.AValidar = null;
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.CampoBusquedaID = "";
            this.txtTelefono2.CampoData = "";
            this.txtTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono2.ColumnasBusqGeneral = null;
            this.txtTelefono2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono2.Decimales = 0;
            this.txtTelefono2.DSData = null;
            this.txtTelefono2.EsAutoGenerado = false;
            this.txtTelefono2.EsBusqueda = false;
            this.txtTelefono2.EsBusquedaAutoIncremental = false;
            this.txtTelefono2.EsEditable = true;
            this.txtTelefono2.FiltroBusqueda = "";
            this.txtTelefono2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono2.Location = new System.Drawing.Point(421, 248);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.NombreTabla = "";
            this.txtTelefono2.SepDecimal = '\0';
            this.txtTelefono2.Size = new System.Drawing.Size(225, 29);
            this.txtTelefono2.TabIndex = 11;
            this.txtTelefono2.TablaOVistaBusqueda = "";
            this.txtTelefono2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono2.ValorPorDefecto = "";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.AMostrar = null;
            this.txtTelefono1.autoSenTab = true;
            this.txtTelefono1.AValidar = null;
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.CampoBusquedaID = "";
            this.txtTelefono1.CampoData = "";
            this.txtTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono1.ColumnasBusqGeneral = null;
            this.txtTelefono1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono1.Decimales = 0;
            this.txtTelefono1.DSData = null;
            this.txtTelefono1.EsAutoGenerado = false;
            this.txtTelefono1.EsBusqueda = false;
            this.txtTelefono1.EsBusquedaAutoIncremental = false;
            this.txtTelefono1.EsEditable = true;
            this.txtTelefono1.FiltroBusqueda = "";
            this.txtTelefono1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono1.Location = new System.Drawing.Point(157, 248);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.NombreTabla = "";
            this.txtTelefono1.SepDecimal = '\0';
            this.txtTelefono1.Size = new System.Drawing.Size(240, 29);
            this.txtTelefono1.TabIndex = 10;
            this.txtTelefono1.TablaOVistaBusqueda = "";
            this.txtTelefono1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono1.ValorPorDefecto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefonos:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AMostrar = null;
            this.txtDireccion.autoSenTab = true;
            this.txtDireccion.AValidar = null;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.CampoBusquedaID = "";
            this.txtDireccion.CampoData = "";
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColumnasBusqGeneral = null;
            this.txtDireccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDireccion.Decimales = 0;
            this.txtDireccion.DSData = null;
            this.txtDireccion.EsAutoGenerado = false;
            this.txtDireccion.EsBusqueda = false;
            this.txtDireccion.EsBusquedaAutoIncremental = false;
            this.txtDireccion.EsEditable = true;
            this.txtDireccion.FiltroBusqueda = "";
            this.txtDireccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDireccion.Location = new System.Drawing.Point(157, 154);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NombreTabla = "";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDireccion.SepDecimal = '\0';
            this.txtDireccion.Size = new System.Drawing.Size(596, 81);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TablaOVistaBusqueda = "";
            this.txtDireccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDireccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDireccion.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.AMostrar = null;
            this.txtApellidos.autoSenTab = true;
            this.txtApellidos.AValidar = null;
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.CampoBusquedaID = "";
            this.txtApellidos.CampoData = "";
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.ColumnasBusqGeneral = null;
            this.txtApellidos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtApellidos.Decimales = 0;
            this.txtApellidos.DSData = null;
            this.txtApellidos.EsAutoGenerado = false;
            this.txtApellidos.EsBusqueda = false;
            this.txtApellidos.EsBusquedaAutoIncremental = false;
            this.txtApellidos.EsEditable = true;
            this.txtApellidos.FiltroBusqueda = "";
            this.txtApellidos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtApellidos.Location = new System.Drawing.Point(157, 115);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.NombreTabla = "";
            this.txtApellidos.SepDecimal = '\0';
            this.txtApellidos.Size = new System.Drawing.Size(596, 29);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.TablaOVistaBusqueda = "";
            this.txtApellidos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtApellidos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtApellidos.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.AMostrar = null;
            this.txtNombres.autoSenTab = true;
            this.txtNombres.AValidar = null;
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.CampoBusquedaID = "";
            this.txtNombres.CampoData = "";
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.ColumnasBusqGeneral = null;
            this.txtNombres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombres.Decimales = 0;
            this.txtNombres.DSData = null;
            this.txtNombres.EsAutoGenerado = false;
            this.txtNombres.EsBusqueda = false;
            this.txtNombres.EsBusquedaAutoIncremental = false;
            this.txtNombres.EsEditable = true;
            this.txtNombres.FiltroBusqueda = "";
            this.txtNombres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombres.Location = new System.Drawing.Point(157, 79);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.NombreTabla = "";
            this.txtNombres.SepDecimal = '\0';
            this.txtNombres.Size = new System.Drawing.Size(596, 29);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TablaOVistaBusqueda = "";
            this.txtNombres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombres.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.autoSenTab = true;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.BackColor = System.Drawing.Color.White;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = null;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(157, 39);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(194, 29);
            this.txtCedulaRNC.TabIndex = 1;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula\\RNC:";
            // 
            // tpAmortizacion
            // 
            this.tpAmortizacion.Controls.Add(this.dtgDetalle);
            this.tpAmortizacion.Controls.Add(this.panel3);
            this.tpAmortizacion.Controls.Add(this.panel2);
            this.tpAmortizacion.Location = new System.Drawing.Point(4, 33);
            this.tpAmortizacion.Name = "tpAmortizacion";
            this.tpAmortizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpAmortizacion.Size = new System.Drawing.Size(899, 529);
            this.tpAmortizacion.TabIndex = 1;
            this.tpAmortizacion.Text = "Amortizacion o Financiamiento";
            this.tpAmortizacion.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtPagoInicial);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtTasaAnual);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtCuotaMonto);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.cboMetodo);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cboFrecuenciaPago);
            this.panel2.Controls.Add(this.txtPlazos);
            this.panel2.Controls.Add(this.txtTasaMensual);
            this.panel2.Controls.Add(this.lblMontoAFinancial);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 250);
            this.panel2.TabIndex = 11;
            // 
            // txtTasaAnual
            // 
            this.txtTasaAnual.AMostrar = null;
            this.txtTasaAnual.autoSenTab = true;
            this.txtTasaAnual.AValidar = null;
            this.txtTasaAnual.BackColor = System.Drawing.Color.White;
            this.txtTasaAnual.CampoBusquedaID = "";
            this.txtTasaAnual.CampoData = "";
            this.txtTasaAnual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaAnual.ColumnasBusqGeneral = null;
            this.txtTasaAnual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaAnual.Decimales = 2;
            this.txtTasaAnual.DSData = null;
            this.txtTasaAnual.EsAutoGenerado = false;
            this.txtTasaAnual.EsBusqueda = false;
            this.txtTasaAnual.EsBusquedaAutoIncremental = false;
            this.txtTasaAnual.EsEditable = true;
            this.txtTasaAnual.FiltroBusqueda = "";
            this.txtTasaAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaAnual.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtTasaAnual.Location = new System.Drawing.Point(677, 99);
            this.txtTasaAnual.Name = "txtTasaAnual";
            this.txtTasaAnual.NombreTabla = "";
            this.txtTasaAnual.ReadOnly = true;
            this.txtTasaAnual.SepDecimal = '\0';
            this.txtTasaAnual.Size = new System.Drawing.Size(133, 38);
            this.txtTasaAnual.TabIndex = 23;
            this.txtTasaAnual.TablaOVistaBusqueda = "";
            this.txtTasaAnual.Text = "0";
            this.txtTasaAnual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaAnual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaAnual.ValorPorDefecto = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(444, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(227, 31);
            this.label17.TabIndex = 22;
            this.label17.Text = "% interes Anual:";
            // 
            // txtCuotaMonto
            // 
            this.txtCuotaMonto.AMostrar = null;
            this.txtCuotaMonto.autoSenTab = true;
            this.txtCuotaMonto.AValidar = null;
            this.txtCuotaMonto.BackColor = System.Drawing.Color.White;
            this.txtCuotaMonto.CampoBusquedaID = "";
            this.txtCuotaMonto.CampoData = "";
            this.txtCuotaMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuotaMonto.ColumnasBusqGeneral = null;
            this.txtCuotaMonto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCuotaMonto.Decimales = 2;
            this.txtCuotaMonto.DSData = null;
            this.txtCuotaMonto.EsAutoGenerado = false;
            this.txtCuotaMonto.EsBusqueda = false;
            this.txtCuotaMonto.EsBusquedaAutoIncremental = false;
            this.txtCuotaMonto.EsEditable = true;
            this.txtCuotaMonto.FiltroBusqueda = "";
            this.txtCuotaMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaMonto.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtCuotaMonto.Location = new System.Drawing.Point(280, 188);
            this.txtCuotaMonto.Name = "txtCuotaMonto";
            this.txtCuotaMonto.NombreTabla = "";
            this.txtCuotaMonto.ReadOnly = true;
            this.txtCuotaMonto.SepDecimal = '\0';
            this.txtCuotaMonto.Size = new System.Drawing.Size(210, 38);
            this.txtCuotaMonto.TabIndex = 21;
            this.txtCuotaMonto.TablaOVistaBusqueda = "";
            this.txtCuotaMonto.Text = "0.00";
            this.txtCuotaMonto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuotaMonto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuotaMonto.ValorPorDefecto = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 31);
            this.label16.TabIndex = 20;
            this.label16.Text = "Cuota a pagar:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(496, 188);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(161, 44);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // cboMetodo
            // 
            this.cboMetodo.AValidar = null;
            this.cboMetodo.CampoData = "";
            this.cboMetodo.CampoJoinCombobox2 = "";
            this.cboMetodo.ComboboxAFiltrar = null;
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.DSData = null;
            this.cboMetodo.EsEditable = true;
            this.cboMetodo.FiltroBusqueda = "";
            this.cboMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "LINEA RECTA (DIRECTO)",
            "AMORTIZADO",
            "SOBRE SALDO INSOLUCTO"});
            this.cboMetodo.Location = new System.Drawing.Point(280, 143);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.NombreTabla = "";
            this.cboMetodo.Size = new System.Drawing.Size(550, 39);
            this.cboMetodo.SSQL = "";
            this.cboMetodo.TabIndex = 18;
            this.cboMetodo.TablaOVistaConsulta = "";
            this.cboMetodo.UsaDataGlobal = false;
            this.cboMetodo.ValorPorDefecto = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 31);
            this.label15.TabIndex = 17;
            this.label15.Text = "Metodo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 31);
            this.label14.TabIndex = 16;
            this.label14.Text = "% interes mensual:";
            // 
            // cboFrecuenciaPago
            // 
            this.cboFrecuenciaPago.AValidar = null;
            this.cboFrecuenciaPago.CampoData = "";
            this.cboFrecuenciaPago.CampoJoinCombobox2 = "";
            this.cboFrecuenciaPago.ComboboxAFiltrar = null;
            this.cboFrecuenciaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrecuenciaPago.DSData = null;
            this.cboFrecuenciaPago.EsEditable = true;
            this.cboFrecuenciaPago.FiltroBusqueda = "";
            this.cboFrecuenciaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrecuenciaPago.FormattingEnabled = true;
            this.cboFrecuenciaPago.Items.AddRange(new object[] {
            "MENSUAL",
            "QUINCENAL",
            "SEMANAL"});
            this.cboFrecuenciaPago.Location = new System.Drawing.Point(392, 54);
            this.cboFrecuenciaPago.Name = "cboFrecuenciaPago";
            this.cboFrecuenciaPago.NombreTabla = "";
            this.cboFrecuenciaPago.Size = new System.Drawing.Size(438, 39);
            this.cboFrecuenciaPago.SSQL = "";
            this.cboFrecuenciaPago.TabIndex = 15;
            this.cboFrecuenciaPago.TablaOVistaConsulta = "";
            this.cboFrecuenciaPago.UsaDataGlobal = false;
            this.cboFrecuenciaPago.ValorPorDefecto = "0";
            // 
            // txtPlazos
            // 
            this.txtPlazos.AMostrar = null;
            this.txtPlazos.autoSenTab = true;
            this.txtPlazos.AValidar = null;
            this.txtPlazos.BackColor = System.Drawing.Color.White;
            this.txtPlazos.CampoBusquedaID = "";
            this.txtPlazos.CampoData = "";
            this.txtPlazos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlazos.ColumnasBusqGeneral = null;
            this.txtPlazos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPlazos.Decimales = 2;
            this.txtPlazos.DSData = null;
            this.txtPlazos.EsAutoGenerado = false;
            this.txtPlazos.EsBusqueda = false;
            this.txtPlazos.EsBusquedaAutoIncremental = false;
            this.txtPlazos.EsEditable = true;
            this.txtPlazos.FiltroBusqueda = "";
            this.txtPlazos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazos.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPlazos.Location = new System.Drawing.Point(280, 54);
            this.txtPlazos.Name = "txtPlazos";
            this.txtPlazos.NombreTabla = "";
            this.txtPlazos.ReadOnly = true;
            this.txtPlazos.SepDecimal = '\0';
            this.txtPlazos.Size = new System.Drawing.Size(106, 38);
            this.txtPlazos.TabIndex = 14;
            this.txtPlazos.TablaOVistaBusqueda = "";
            this.txtPlazos.Text = "0.00";
            this.txtPlazos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPlazos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPlazos.ValorPorDefecto = "";
            // 
            // txtTasaMensual
            // 
            this.txtTasaMensual.AMostrar = null;
            this.txtTasaMensual.autoSenTab = true;
            this.txtTasaMensual.AValidar = null;
            this.txtTasaMensual.BackColor = System.Drawing.Color.White;
            this.txtTasaMensual.CampoBusquedaID = "";
            this.txtTasaMensual.CampoData = "";
            this.txtTasaMensual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaMensual.ColumnasBusqGeneral = null;
            this.txtTasaMensual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTasaMensual.Decimales = 2;
            this.txtTasaMensual.DSData = null;
            this.txtTasaMensual.EsAutoGenerado = false;
            this.txtTasaMensual.EsBusqueda = false;
            this.txtTasaMensual.EsBusquedaAutoIncremental = false;
            this.txtTasaMensual.EsEditable = true;
            this.txtTasaMensual.FiltroBusqueda = "";
            this.txtTasaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaMensual.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtTasaMensual.Location = new System.Drawing.Point(280, 99);
            this.txtTasaMensual.Name = "txtTasaMensual";
            this.txtTasaMensual.NombreTabla = "";
            this.txtTasaMensual.ReadOnly = true;
            this.txtTasaMensual.SepDecimal = '\0';
            this.txtTasaMensual.Size = new System.Drawing.Size(119, 38);
            this.txtTasaMensual.TabIndex = 13;
            this.txtTasaMensual.TablaOVistaBusqueda = "";
            this.txtTasaMensual.Text = "0";
            this.txtTasaMensual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTasaMensual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTasaMensual.ValorPorDefecto = "";
            // 
            // lblMontoAFinancial
            // 
            this.lblMontoAFinancial.AutoSize = true;
            this.lblMontoAFinancial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAFinancial.Location = new System.Drawing.Point(490, 13);
            this.lblMontoAFinancial.Name = "lblMontoAFinancial";
            this.lblMontoAFinancial.Size = new System.Drawing.Size(236, 31);
            this.lblMontoAFinancial.TabIndex = 12;
            this.lblMontoAFinancial.Text = "A Financiar: 0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 31);
            this.label11.TabIndex = 11;
            this.label11.Text = "Plazo o Cuotas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(232, 31);
            this.label18.TabIndex = 24;
            this.label18.Text = "A Pagar (Inicial):";
            // 
            // txtPagoInicial
            // 
            this.txtPagoInicial.AMostrar = null;
            this.txtPagoInicial.autoSenTab = true;
            this.txtPagoInicial.AValidar = null;
            this.txtPagoInicial.BackColor = System.Drawing.Color.White;
            this.txtPagoInicial.CampoBusquedaID = "";
            this.txtPagoInicial.CampoData = "";
            this.txtPagoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagoInicial.ColumnasBusqGeneral = null;
            this.txtPagoInicial.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPagoInicial.Decimales = 2;
            this.txtPagoInicial.DSData = null;
            this.txtPagoInicial.EsAutoGenerado = false;
            this.txtPagoInicial.EsBusqueda = false;
            this.txtPagoInicial.EsBusquedaAutoIncremental = false;
            this.txtPagoInicial.EsEditable = true;
            this.txtPagoInicial.FiltroBusqueda = "";
            this.txtPagoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoInicial.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPagoInicial.Location = new System.Drawing.Point(280, 10);
            this.txtPagoInicial.Name = "txtPagoInicial";
            this.txtPagoInicial.NombreTabla = "";
            this.txtPagoInicial.ReadOnly = true;
            this.txtPagoInicial.SepDecimal = '\0';
            this.txtPagoInicial.Size = new System.Drawing.Size(200, 38);
            this.txtPagoInicial.TabIndex = 25;
            this.txtPagoInicial.TablaOVistaBusqueda = "";
            this.txtPagoInicial.Text = "99,999,999.99";
            this.txtPagoInicial.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPagoInicial.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPagoInicial.ValorPorDefecto = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTotalDetalle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 54);
            this.panel3.TabIndex = 12;
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Id,
            this.Fecha,
            this.Concepto,
            this.Capital,
            this.Interes,
            this.Total});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(3, 253);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.Size = new System.Drawing.Size(893, 219);
            this.dtgDetalle.TabIndex = 13;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Capital
            // 
            this.Capital.DataPropertyName = "Capital";
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Width = 130;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Width = 130;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 130;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDetalle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(889, 50);
            this.lblTotalDetalle.TabIndex = 25;
            this.lblTotalDetalle.Text = "Capital: 0.00            Interes: 0.00   ";
            this.lblTotalDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(0, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(115, 46);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // FormDesglosePagoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(907, 676);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDesglosePagoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DESGLOSE DE PAGO CON CLIENTE";
            this.Activated += new System.EventHandler(this.FormDesglosePagoCliente_Activated);
            this.Load += new System.EventHandler(this.FormDesglosePagoCliente_Load);
            this.Shown += new System.EventHandler(this.FormDesglosePagoCliente_Shown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.pnDesglose.ResumeLayout(false);
            this.pnDesglose.PerformLayout();
            this.grbCredito.ResumeLayout(false);
            this.grbCredito.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpAmortizacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAmortizacion;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public ELRTextBox txtPagoInicial;
        private System.Windows.Forms.Label label18;
        public ELRTextBox txtTasaAnual;
        private System.Windows.Forms.Label label17;
        public ELRTextBox txtCuotaMonto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerar;
        private ELRCombobox cboMetodo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private ELRCombobox cboFrecuenciaPago;
        public ELRTextBox txtPlazos;
        public ELRTextBox txtTasaMensual;
        private System.Windows.Forms.Label lblMontoAFinancial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.Panel pnDesglose;
        public ELRTextBox txtAPagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbCredito;
        public ELRTextBox txtACredito;
        private System.Windows.Forms.Label label10;
        public ELRTextBox txtADevolver;
        private System.Windows.Forms.Label label6;
        public ELRTextBox txtEnTarjeta;
        private System.Windows.Forms.Label label7;
        public ELRTextBox txtEnCheques;
        private System.Windows.Forms.Label label8;
        public ELRTextBox txtEnEfectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private ELRTextBox txtTelefono2;
        private ELRTextBox txtTelefono1;
        private System.Windows.Forms.Label label5;
        private ELRTextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private ELRTextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private ELRTextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.Button btnAnterior;
    }
}