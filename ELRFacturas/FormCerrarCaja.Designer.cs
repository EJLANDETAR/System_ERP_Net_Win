namespace ELRFacturas
{
    partial class FormCerrarCaja
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
            this.lblEfectivo = new WinControl_ELR_NET.ELRLabel();
            this.txtChequesEnCaja = new WinControl_ELR_NET.ELRTextBox();
            this.txtTarjeta = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elrLabel9 = new WinControl_ELR_NET.ELRLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.elrLabel8 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel7 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel6 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel12 = new WinControl_ELR_NET.ELRLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.elrLabel5 = new WinControl_ELR_NET.ELRLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.elrLabel18 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel17 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel16 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel15 = new WinControl_ELR_NET.ELRLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.elrLabel13 = new WinControl_ELR_NET.ELRLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.elrLabel4 = new WinControl_ELR_NET.ELRLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.elrLabel11 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel10 = new WinControl_ELR_NET.ELRLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFaltante = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblSobrante = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotalEnCaja = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblTotalEsperado = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDesgloseCierre = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 578);
            this.pnBotones.Size = new System.Drawing.Size(813, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(573, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(714, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(478, 0);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEfectivo.CampoData = "EnEfectivo_Cierre";
            this.lblEfectivo.DSData = this.DSDatos;
            this.lblEfectivo.Location = new System.Drawing.Point(102, 35);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.NombreTabla = "";
            this.lblEfectivo.Size = new System.Drawing.Size(160, 30);
            this.lblEfectivo.TabIndex = 33;
            this.lblEfectivo.Text = "0.00";
            this.lblEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEfectivo.ValorPorDefecto = "0.00";
            // 
            // txtChequesEnCaja
            // 
            this.txtChequesEnCaja.AMostrar = null;
            this.txtChequesEnCaja.AValidar = null;
            this.txtChequesEnCaja.CampoBusquedaID = "";
            this.txtChequesEnCaja.CampoData = "EnCheques_Cierre";
            this.txtChequesEnCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequesEnCaja.ColumnasBusqGeneral = null;
            this.txtChequesEnCaja.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtChequesEnCaja.Decimales = 0;
            this.txtChequesEnCaja.DSData = this.DSDatos;
            this.txtChequesEnCaja.EsAutoGenerado = false;
            this.txtChequesEnCaja.EsBusqueda = false;
            this.txtChequesEnCaja.EsEditable = true;
            this.txtChequesEnCaja.FiltroBusqueda = "";
            this.txtChequesEnCaja.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtChequesEnCaja.Location = new System.Drawing.Point(102, 71);
            this.txtChequesEnCaja.Name = "txtChequesEnCaja";
            this.txtChequesEnCaja.NombreTabla = "";
            this.txtChequesEnCaja.SepDecimal = '\0';
            this.txtChequesEnCaja.Size = new System.Drawing.Size(205, 29);
            this.txtChequesEnCaja.TabIndex = 35;
            this.txtChequesEnCaja.TablaOVistaBusqueda = "";
            this.txtChequesEnCaja.Text = "0.00";
            this.txtChequesEnCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChequesEnCaja.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtChequesEnCaja.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtChequesEnCaja.ValorPorDefecto = "0.00";
            this.txtChequesEnCaja.Leave += new System.EventHandler(this.txtChequesEnCaja_Leave);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.AMostrar = null;
            this.txtTarjeta.AValidar = null;
            this.txtTarjeta.CampoBusquedaID = "";
            this.txtTarjeta.CampoData = "EnTarjeta_Cierre";
            this.txtTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTarjeta.ColumnasBusqGeneral = null;
            this.txtTarjeta.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTarjeta.Decimales = 0;
            this.txtTarjeta.DSData = this.DSDatos;
            this.txtTarjeta.EsAutoGenerado = false;
            this.txtTarjeta.EsBusqueda = false;
            this.txtTarjeta.EsEditable = true;
            this.txtTarjeta.FiltroBusqueda = "";
            this.txtTarjeta.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTarjeta.Location = new System.Drawing.Point(101, 108);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.NombreTabla = "";
            this.txtTarjeta.SepDecimal = '\0';
            this.txtTarjeta.Size = new System.Drawing.Size(206, 29);
            this.txtTarjeta.TabIndex = 37;
            this.txtTarjeta.TablaOVistaBusqueda = "";
            this.txtTarjeta.Text = "0.00";
            this.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarjeta.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTarjeta.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTarjeta.ValorPorDefecto = "0.00";
            this.txtTarjeta.Leave += new System.EventHandler(this.txtChequesEnCaja_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.elrLabel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.elrLabel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.elrLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 69);
            this.panel1.TabIndex = 1;
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "Fecha_Apertura";
            this.elrLabel3.DSData = this.DSDatos;
            this.elrLabel3.Location = new System.Drawing.Point(517, 11);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(80, 21);
            this.elrLabel3.TabIndex = 5;
            this.elrLabel3.Text = "elrLabel3";
            this.elrLabel3.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Apertura:";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "Usuario_En_Caja";
            this.elrLabel2.DSData = this.DSDatos;
            this.elrLabel2.Location = new System.Drawing.Point(158, 36);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(80, 21);
            this.elrLabel2.TabIndex = 3;
            this.elrLabel2.Text = "elrLabel2";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario en Caja:";
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "Caja_Id";
            this.elrLabel1.DSData = this.DSDatos;
            this.elrLabel1.Location = new System.Drawing.Point(99, 11);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(80, 21);
            this.elrLabel1.TabIndex = 1;
            this.elrLabel1.Text = "elrLabel1";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja No.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elrLabel9);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.elrLabel8);
            this.groupBox1.Controls.Add(this.elrLabel7);
            this.groupBox1.Controls.Add(this.elrLabel6);
            this.groupBox1.Controls.Add(this.elrLabel12);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Desglose de Pago";
            // 
            // elrLabel9
            // 
            this.elrLabel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel9.CampoData = "Monto_Apertura";
            this.elrLabel9.DSData = this.DSDatos;
            this.elrLabel9.Location = new System.Drawing.Point(130, 28);
            this.elrLabel9.Name = "elrLabel9";
            this.elrLabel9.NombreTabla = "";
            this.elrLabel9.Size = new System.Drawing.Size(147, 30);
            this.elrLabel9.TabIndex = 30;
            this.elrLabel9.Text = "elrLabel9";
            this.elrLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel9.ValorPorDefecto = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 21);
            this.label16.TabIndex = 29;
            this.label16.Text = "M. Apertura:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(593, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "TOTAL ESPERADO:";
            // 
            // elrLabel8
            // 
            this.elrLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel8.CampoData = "En_Cheques";
            this.elrLabel8.DSData = this.DSDatos;
            this.elrLabel8.Location = new System.Drawing.Point(130, 61);
            this.elrLabel8.Name = "elrLabel8";
            this.elrLabel8.NombreTabla = "";
            this.elrLabel8.Size = new System.Drawing.Size(147, 30);
            this.elrLabel8.TabIndex = 27;
            this.elrLabel8.Text = "elrLabel8";
            this.elrLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel8.ValorPorDefecto = "0.00";
            // 
            // elrLabel7
            // 
            this.elrLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel7.CampoData = "Total_Esperado";
            this.elrLabel7.DSData = this.DSDatos;
            this.elrLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrLabel7.Location = new System.Drawing.Point(598, 50);
            this.elrLabel7.Name = "elrLabel7";
            this.elrLabel7.NombreTabla = "";
            this.elrLabel7.Size = new System.Drawing.Size(192, 33);
            this.elrLabel7.TabIndex = 26;
            this.elrLabel7.Text = "elrLabel7";
            this.elrLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel7.ValorPorDefecto = "0.00";
            // 
            // elrLabel6
            // 
            this.elrLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel6.CampoData = "En_Tarjetas";
            this.elrLabel6.DSData = this.DSDatos;
            this.elrLabel6.Location = new System.Drawing.Point(413, 61);
            this.elrLabel6.Name = "elrLabel6";
            this.elrLabel6.NombreTabla = "";
            this.elrLabel6.Size = new System.Drawing.Size(157, 30);
            this.elrLabel6.TabIndex = 25;
            this.elrLabel6.Text = "elrLabel6";
            this.elrLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel6.ValorPorDefecto = "0.00";
            // 
            // elrLabel12
            // 
            this.elrLabel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel12.CampoData = "En_Efectivo";
            this.elrLabel12.DSData = this.DSDatos;
            this.elrLabel12.Location = new System.Drawing.Point(413, 28);
            this.elrLabel12.Name = "elrLabel12";
            this.elrLabel12.NombreTabla = "";
            this.elrLabel12.Size = new System.Drawing.Size(157, 30);
            this.elrLabel12.TabIndex = 19;
            this.elrLabel12.Text = "elrLabel12";
            this.elrLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel12.ValorPorDefecto = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "En Tarjeta C.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "En Cheques:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "En Efectivo:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 214);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.elrLabel5);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.elrLabel18);
            this.groupBox2.Controls.Add(this.elrLabel17);
            this.groupBox2.Controls.Add(this.elrLabel16);
            this.groupBox2.Controls.Add(this.elrLabel15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(338, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cobros CXC y/o Prestamos";
            // 
            // elrLabel5
            // 
            this.elrLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel5.CampoData = "Total_Recibos";
            this.elrLabel5.DSData = this.DSDatos;
            this.elrLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrLabel5.Location = new System.Drawing.Point(22, 145);
            this.elrLabel5.Name = "elrLabel5";
            this.elrLabel5.NombreTabla = "";
            this.elrLabel5.Size = new System.Drawing.Size(237, 33);
            this.elrLabel5.TabIndex = 24;
            this.elrLabel5.Text = "elrLabel5";
            this.elrLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel5.ValorPorDefecto = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Total:";
            // 
            // elrLabel18
            // 
            this.elrLabel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel18.CampoData = "Cobro_Otros";
            this.elrLabel18.DSData = this.DSDatos;
            this.elrLabel18.Location = new System.Drawing.Point(328, 75);
            this.elrLabel18.Name = "elrLabel18";
            this.elrLabel18.NombreTabla = "";
            this.elrLabel18.Size = new System.Drawing.Size(133, 26);
            this.elrLabel18.TabIndex = 22;
            this.elrLabel18.Text = "elrLabel18";
            this.elrLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel18.ValorPorDefecto = "0.00";
            // 
            // elrLabel17
            // 
            this.elrLabel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel17.CampoData = "Cobro_Demora";
            this.elrLabel17.DSData = this.DSDatos;
            this.elrLabel17.Location = new System.Drawing.Point(93, 78);
            this.elrLabel17.Name = "elrLabel17";
            this.elrLabel17.NombreTabla = "";
            this.elrLabel17.Size = new System.Drawing.Size(138, 26);
            this.elrLabel17.TabIndex = 21;
            this.elrLabel17.Text = "elrLabel17";
            this.elrLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel17.ValorPorDefecto = "0.00";
            // 
            // elrLabel16
            // 
            this.elrLabel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel16.CampoData = "Cobro_Interes";
            this.elrLabel16.DSData = this.DSDatos;
            this.elrLabel16.Location = new System.Drawing.Point(328, 42);
            this.elrLabel16.Name = "elrLabel16";
            this.elrLabel16.NombreTabla = "";
            this.elrLabel16.Size = new System.Drawing.Size(133, 26);
            this.elrLabel16.TabIndex = 20;
            this.elrLabel16.Text = "elrLabel16";
            this.elrLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel16.ValorPorDefecto = "0.00";
            // 
            // elrLabel15
            // 
            this.elrLabel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel15.CampoData = "Cobro_Capital";
            this.elrLabel15.DSData = this.DSDatos;
            this.elrLabel15.Location = new System.Drawing.Point(93, 42);
            this.elrLabel15.Name = "elrLabel15";
            this.elrLabel15.NombreTabla = "";
            this.elrLabel15.Size = new System.Drawing.Size(138, 26);
            this.elrLabel15.TabIndex = 19;
            this.elrLabel15.Text = "elrLabel15";
            this.elrLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel15.ValorPorDefecto = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Otros:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Demora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Interes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Capital:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elrLabel13);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.elrLabel4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.elrLabel11);
            this.groupBox3.Controls.Add(this.elrLabel10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 210);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Ventas";
            // 
            // elrLabel13
            // 
            this.elrLabel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel13.CampoData = "EnNotaCredito";
            this.elrLabel13.DSData = this.DSDatos;
            this.elrLabel13.Location = new System.Drawing.Point(118, 25);
            this.elrLabel13.Name = "elrLabel13";
            this.elrLabel13.NombreTabla = "";
            this.elrLabel13.Size = new System.Drawing.Size(157, 26);
            this.elrLabel13.TabIndex = 24;
            this.elrLabel13.Text = "elrLabel13";
            this.elrLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel13.ValorPorDefecto = "0.00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 21);
            this.label21.TabIndex = 23;
            this.label21.Text = "En Nota. C.:";
            // 
            // elrLabel4
            // 
            this.elrLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel4.CampoData = "Total_Ventas";
            this.elrLabel4.DSData = this.DSDatos;
            this.elrLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elrLabel4.Location = new System.Drawing.Point(30, 164);
            this.elrLabel4.Name = "elrLabel4";
            this.elrLabel4.NombreTabla = "";
            this.elrLabel4.Size = new System.Drawing.Size(232, 31);
            this.elrLabel4.TabIndex = 22;
            this.elrLabel4.Text = "elrLabel4";
            this.elrLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel4.ValorPorDefecto = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "Total:";
            // 
            // elrLabel11
            // 
            this.elrLabel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel11.CampoData = "Venta_ACredito";
            this.elrLabel11.DSData = this.DSDatos;
            this.elrLabel11.Location = new System.Drawing.Point(118, 94);
            this.elrLabel11.Name = "elrLabel11";
            this.elrLabel11.NombreTabla = "";
            this.elrLabel11.Size = new System.Drawing.Size(157, 26);
            this.elrLabel11.TabIndex = 20;
            this.elrLabel11.Text = "elrLabel11";
            this.elrLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel11.ValorPorDefecto = "0.00";
            // 
            // elrLabel10
            // 
            this.elrLabel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elrLabel10.CampoData = "Venta_AlContado";
            this.elrLabel10.DSData = this.DSDatos;
            this.elrLabel10.Location = new System.Drawing.Point(118, 58);
            this.elrLabel10.Name = "elrLabel10";
            this.elrLabel10.NombreTabla = "";
            this.elrLabel10.Size = new System.Drawing.Size(157, 26);
            this.elrLabel10.TabIndex = 19;
            this.elrLabel10.Text = "elrLabel10";
            this.elrLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elrLabel10.ValorPorDefecto = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "A Credito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Al Contado:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblFaltante);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.lblSobrante);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.lblTotalEnCaja);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.lblTotalEsperado);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 183);
            this.panel3.TabIndex = 4;
            // 
            // lblFaltante
            // 
            this.lblFaltante.AutoSize = true;
            this.lblFaltante.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltante.ForeColor = System.Drawing.Color.Red;
            this.lblFaltante.Location = new System.Drawing.Point(586, 111);
            this.lblFaltante.Name = "lblFaltante";
            this.lblFaltante.Size = new System.Drawing.Size(55, 30);
            this.lblFaltante.TabIndex = 37;
            this.lblFaltante.Text = "0.00";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(406, 111);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(175, 30);
            this.label27.TabIndex = 36;
            this.label27.Text = "Faltante.............:";
            // 
            // lblSobrante
            // 
            this.lblSobrante.AutoSize = true;
            this.lblSobrante.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrante.ForeColor = System.Drawing.Color.Blue;
            this.lblSobrante.Location = new System.Drawing.Point(586, 80);
            this.lblSobrante.Name = "lblSobrante";
            this.lblSobrante.Size = new System.Drawing.Size(55, 30);
            this.lblSobrante.TabIndex = 35;
            this.lblSobrante.Text = "0.00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Location = new System.Drawing.Point(406, 78);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(174, 30);
            this.label25.TabIndex = 34;
            this.label25.Text = "Sobrante...........:";
            // 
            // lblTotalEnCaja
            // 
            this.lblTotalEnCaja.AutoSize = true;
            this.lblTotalEnCaja.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnCaja.Location = new System.Drawing.Point(586, 48);
            this.lblTotalEnCaja.Name = "lblTotalEnCaja";
            this.lblTotalEnCaja.Size = new System.Drawing.Size(55, 30);
            this.lblTotalEnCaja.TabIndex = 33;
            this.lblTotalEnCaja.Text = "0.00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(406, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 30);
            this.label23.TabIndex = 32;
            this.label23.Text = "Total En Caja.....:";
            // 
            // lblTotalEsperado
            // 
            this.lblTotalEsperado.AutoSize = true;
            this.lblTotalEsperado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEsperado.Location = new System.Drawing.Point(586, 18);
            this.lblTotalEsperado.Name = "lblTotalEsperado";
            this.lblTotalEsperado.Size = new System.Drawing.Size(55, 30);
            this.lblTotalEsperado.TabIndex = 31;
            this.lblTotalEsperado.Text = "0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(406, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 30);
            this.label20.TabIndex = 30;
            this.label20.Text = "Total Esperado.:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDesgloseCierre);
            this.groupBox4.Controls.Add(this.txtTarjeta);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtChequesEnCaja);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lblEfectivo);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 179);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desglose Caja";
            // 
            // btnDesgloseCierre
            // 
            this.btnDesgloseCierre.Location = new System.Drawing.Point(268, 35);
            this.btnDesgloseCierre.Name = "btnDesgloseCierre";
            this.btnDesgloseCierre.Size = new System.Drawing.Size(39, 30);
            this.btnDesgloseCierre.TabIndex = 38;
            this.btnDesgloseCierre.Text = "...";
            this.btnDesgloseCierre.UseVisualStyleBackColor = true;
            this.btnDesgloseCierre.Click += new System.EventHandler(this.btnDesgloseCierre_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 21);
            this.label19.TabIndex = 36;
            this.label19.Text = "Tarjeta C.:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 21);
            this.label18.TabIndex = 34;
            this.label18.Text = "Cheques:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 21);
            this.label17.TabIndex = 32;
            this.label17.Text = "Efectivo:";
            // 
            // FormCerrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.lblEfectivo;
            valida1.Mensaje = "El Desglose del Efectivo No Puede Ser Menor a Cero";
            valida1.NombreCampo = "EnEfectivo_Cierre";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "0";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtChequesEnCaja;
            valida2.Mensaje = "El Monto en Cheques No Puede Ser Menor a Cero";
            valida2.NombreCampo = "EnCheques_Cierre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "0";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtTarjeta;
            valida3.Mensaje = "El Monto en Tarjeta No Puede Ser Menor a Cero";
            valida3.NombreCampo = "EnTarjeta_Cierre";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "0";
            valida3.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3};
            this.ClientSize = new System.Drawing.Size(813, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.FormaImprimir = WinControl_ELR_NET.tbTipoImpresion.PreviewRDLC;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImprimirAlGrabar = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCerrarCaja";
            this.NombreCampoID = "Apertura_No";
            this.NombreReporte = "RptCarpetadeCaja";
            this.NombreVistaImprimir = "VCAJAS_CARPETAS";
            this.SPGraba = "SP_CAJAS_REALIZAR_CERRE";
            this.TablaEncabezado = "TTEMPORAL_CAJAS_APERTURA_CIERRE";
            this.Text = "CIERRE DE CAJA";
            this.TituloReporte = "CARPETA DE CAJA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRLabel elrLabel12;
        private WinControl_ELR_NET.ELRLabel elrLabel9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private WinControl_ELR_NET.ELRLabel elrLabel8;
        private WinControl_ELR_NET.ELRLabel elrLabel7;
        private WinControl_ELR_NET.ELRLabel elrLabel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRLabel elrLabel5;
        private System.Windows.Forms.Label label14;
        private WinControl_ELR_NET.ELRLabel elrLabel18;
        private WinControl_ELR_NET.ELRLabel elrLabel17;
        private WinControl_ELR_NET.ELRLabel elrLabel16;
        private WinControl_ELR_NET.ELRLabel elrLabel15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private WinControl_ELR_NET.ELRLabel elrLabel4;
        private System.Windows.Forms.Label label13;
        private WinControl_ELR_NET.ELRLabel elrLabel11;
        private WinControl_ELR_NET.ELRLabel elrLabel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDesgloseCierre;
        private WinControl_ELR_NET.ELRTextBox txtTarjeta;
        private System.Windows.Forms.Label label19;
        private WinControl_ELR_NET.ELRTextBox txtChequesEnCaja;
        private System.Windows.Forms.Label label18;
        private WinControl_ELR_NET.ELRLabel lblEfectivo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblFaltante;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSobrante;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTotalEnCaja;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblTotalEsperado;
        private System.Windows.Forms.Label label20;
        private WinControl_ELR_NET.ELRLabel elrLabel13;
        private System.Windows.Forms.Label label21;
    }
}