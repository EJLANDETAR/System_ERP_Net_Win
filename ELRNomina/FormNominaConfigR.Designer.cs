namespace ELRNomina
{
    partial class FormNominaConfigR
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
            WinControl_ELR_NET.Valida valida5 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida6 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida7 = new WinControl_ELR_NET.Valida();
            this.txtD_ARS = new WinControl_ELR_NET.ELRTextBox();
            this.txtD_AFP = new WinControl_ELR_NET.ELRTextBox();
            this.txtE_ARL = new WinControl_ELR_NET.ELRTextBox();
            this.txtE_ARS = new WinControl_ELR_NET.ELRTextBox();
            this.txtE_AFP = new WinControl_ELR_NET.ELRTextBox();
            this.txtE_INFOTEP = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elrTextBox4 = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD_ARL = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.elrTextBox2 = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIrATablaISR = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 375);
            this.pnBotones.Size = new System.Drawing.Size(510, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(270, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(411, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(175, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(80, 39);
            // 
            // txtD_ARS
            // 
            this.txtD_ARS.AMostrar = null;
            this.txtD_ARS.AValidar = null;
            this.txtD_ARS.CampoBusquedaID = "";
            this.txtD_ARS.CampoData = "D_ARS";
            this.txtD_ARS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtD_ARS.ColumnasBusqGeneral = null;
            this.txtD_ARS.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtD_ARS.Decimales = 0;
            this.txtD_ARS.DSData = this.DSDatos;
            this.txtD_ARS.EsAutoGenerado = false;
            this.txtD_ARS.EsBusqueda = false;
            this.txtD_ARS.EsBusquedaAutoIncremental = false;
            this.txtD_ARS.EsEditable = true;
            this.txtD_ARS.FiltroBusqueda = "";
            this.txtD_ARS.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtD_ARS.Location = new System.Drawing.Point(77, 34);
            this.txtD_ARS.MaxLength = 5;
            this.txtD_ARS.Name = "txtD_ARS";
            this.txtD_ARS.NombreTabla = "";
            this.txtD_ARS.SepDecimal = '\0';
            this.txtD_ARS.Size = new System.Drawing.Size(110, 29);
            this.txtD_ARS.TabIndex = 1;
            this.txtD_ARS.TablaOVistaBusqueda = "";
            this.txtD_ARS.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtD_ARS.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtD_ARS.ValorPorDefecto = "0";
            // 
            // txtD_AFP
            // 
            this.txtD_AFP.AMostrar = null;
            this.txtD_AFP.AValidar = null;
            this.txtD_AFP.CampoBusquedaID = "";
            this.txtD_AFP.CampoData = "D_AFP";
            this.txtD_AFP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtD_AFP.ColumnasBusqGeneral = null;
            this.txtD_AFP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtD_AFP.Decimales = 0;
            this.txtD_AFP.DSData = this.DSDatos;
            this.txtD_AFP.EsAutoGenerado = false;
            this.txtD_AFP.EsBusqueda = false;
            this.txtD_AFP.EsBusquedaAutoIncremental = false;
            this.txtD_AFP.EsEditable = true;
            this.txtD_AFP.FiltroBusqueda = "";
            this.txtD_AFP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtD_AFP.Location = new System.Drawing.Point(77, 69);
            this.txtD_AFP.MaxLength = 5;
            this.txtD_AFP.Name = "txtD_AFP";
            this.txtD_AFP.NombreTabla = "";
            this.txtD_AFP.SepDecimal = '\0';
            this.txtD_AFP.Size = new System.Drawing.Size(110, 29);
            this.txtD_AFP.TabIndex = 3;
            this.txtD_AFP.TablaOVistaBusqueda = "";
            this.txtD_AFP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtD_AFP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtD_AFP.ValorPorDefecto = "0";
            // 
            // txtE_ARL
            // 
            this.txtE_ARL.AMostrar = null;
            this.txtE_ARL.AValidar = null;
            this.txtE_ARL.CampoBusquedaID = "";
            this.txtE_ARL.CampoData = "E_ARL";
            this.txtE_ARL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtE_ARL.ColumnasBusqGeneral = null;
            this.txtE_ARL.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtE_ARL.Decimales = 0;
            this.txtE_ARL.DSData = this.DSDatos;
            this.txtE_ARL.EsAutoGenerado = false;
            this.txtE_ARL.EsBusqueda = false;
            this.txtE_ARL.EsBusquedaAutoIncremental = false;
            this.txtE_ARL.EsEditable = true;
            this.txtE_ARL.FiltroBusqueda = "";
            this.txtE_ARL.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtE_ARL.Location = new System.Drawing.Point(359, 36);
            this.txtE_ARL.MaxLength = 5;
            this.txtE_ARL.Name = "txtE_ARL";
            this.txtE_ARL.NombreTabla = "";
            this.txtE_ARL.SepDecimal = '\0';
            this.txtE_ARL.Size = new System.Drawing.Size(110, 29);
            this.txtE_ARL.TabIndex = 11;
            this.txtE_ARL.TablaOVistaBusqueda = "";
            this.txtE_ARL.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtE_ARL.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtE_ARL.ValorPorDefecto = "0";
            // 
            // txtE_ARS
            // 
            this.txtE_ARS.AMostrar = null;
            this.txtE_ARS.AValidar = null;
            this.txtE_ARS.CampoBusquedaID = "";
            this.txtE_ARS.CampoData = "E_ARS";
            this.txtE_ARS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtE_ARS.ColumnasBusqGeneral = null;
            this.txtE_ARS.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtE_ARS.Decimales = 0;
            this.txtE_ARS.DSData = this.DSDatos;
            this.txtE_ARS.EsAutoGenerado = false;
            this.txtE_ARS.EsBusqueda = false;
            this.txtE_ARS.EsBusquedaAutoIncremental = false;
            this.txtE_ARS.EsEditable = true;
            this.txtE_ARS.FiltroBusqueda = "";
            this.txtE_ARS.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtE_ARS.Location = new System.Drawing.Point(135, 39);
            this.txtE_ARS.MaxLength = 5;
            this.txtE_ARS.Name = "txtE_ARS";
            this.txtE_ARS.NombreTabla = "";
            this.txtE_ARS.SepDecimal = '\0';
            this.txtE_ARS.Size = new System.Drawing.Size(110, 29);
            this.txtE_ARS.TabIndex = 7;
            this.txtE_ARS.TablaOVistaBusqueda = "";
            this.txtE_ARS.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtE_ARS.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtE_ARS.ValorPorDefecto = "0";
            // 
            // txtE_AFP
            // 
            this.txtE_AFP.AMostrar = null;
            this.txtE_AFP.AValidar = null;
            this.txtE_AFP.CampoBusquedaID = "";
            this.txtE_AFP.CampoData = "E_AFP";
            this.txtE_AFP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtE_AFP.ColumnasBusqGeneral = null;
            this.txtE_AFP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtE_AFP.Decimales = 0;
            this.txtE_AFP.DSData = this.DSDatos;
            this.txtE_AFP.EsAutoGenerado = false;
            this.txtE_AFP.EsBusqueda = false;
            this.txtE_AFP.EsBusquedaAutoIncremental = false;
            this.txtE_AFP.EsEditable = true;
            this.txtE_AFP.FiltroBusqueda = "";
            this.txtE_AFP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtE_AFP.Location = new System.Drawing.Point(135, 74);
            this.txtE_AFP.MaxLength = 5;
            this.txtE_AFP.Name = "txtE_AFP";
            this.txtE_AFP.NombreTabla = "";
            this.txtE_AFP.SepDecimal = '\0';
            this.txtE_AFP.Size = new System.Drawing.Size(110, 29);
            this.txtE_AFP.TabIndex = 9;
            this.txtE_AFP.TablaOVistaBusqueda = "";
            this.txtE_AFP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtE_AFP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtE_AFP.ValorPorDefecto = "0";
            // 
            // txtE_INFOTEP
            // 
            this.txtE_INFOTEP.AMostrar = null;
            this.txtE_INFOTEP.AValidar = null;
            this.txtE_INFOTEP.CampoBusquedaID = "";
            this.txtE_INFOTEP.CampoData = "E_INFOTEP";
            this.txtE_INFOTEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtE_INFOTEP.ColumnasBusqGeneral = null;
            this.txtE_INFOTEP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtE_INFOTEP.Decimales = 0;
            this.txtE_INFOTEP.DSData = this.DSDatos;
            this.txtE_INFOTEP.EsAutoGenerado = false;
            this.txtE_INFOTEP.EsBusqueda = false;
            this.txtE_INFOTEP.EsBusquedaAutoIncremental = false;
            this.txtE_INFOTEP.EsEditable = true;
            this.txtE_INFOTEP.FiltroBusqueda = "";
            this.txtE_INFOTEP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtE_INFOTEP.Location = new System.Drawing.Point(359, 74);
            this.txtE_INFOTEP.MaxLength = 5;
            this.txtE_INFOTEP.Name = "txtE_INFOTEP";
            this.txtE_INFOTEP.NombreTabla = "";
            this.txtE_INFOTEP.SepDecimal = '\0';
            this.txtE_INFOTEP.Size = new System.Drawing.Size(110, 29);
            this.txtE_INFOTEP.TabIndex = 13;
            this.txtE_INFOTEP.TablaOVistaBusqueda = "";
            this.txtE_INFOTEP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtE_INFOTEP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtE_INFOTEP.ValorPorDefecto = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIrATablaISR);
            this.groupBox1.Controls.Add(this.elrTextBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtD_ARL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtD_AFP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtD_ARS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento de Ley a Empleados";
            // 
            // elrTextBox4
            // 
            this.elrTextBox4.AMostrar = null;
            this.elrTextBox4.AValidar = null;
            this.elrTextBox4.CampoBusquedaID = "";
            this.elrTextBox4.CampoData = "D_ARS_DEPENDIENTE";
            this.elrTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox4.ColumnasBusqGeneral = null;
            this.elrTextBox4.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox4.Decimales = 0;
            this.elrTextBox4.DSData = this.DSDatos;
            this.elrTextBox4.EsAutoGenerado = false;
            this.elrTextBox4.EsBusqueda = false;
            this.elrTextBox4.EsBusquedaAutoIncremental = false;
            this.elrTextBox4.EsEditable = true;
            this.elrTextBox4.FiltroBusqueda = "";
            this.elrTextBox4.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox4.Location = new System.Drawing.Point(261, 58);
            this.elrTextBox4.Name = "elrTextBox4";
            this.elrTextBox4.NombreTabla = "";
            this.elrTextBox4.SepDecimal = '\0';
            this.elrTextBox4.Size = new System.Drawing.Size(144, 29);
            this.elrTextBox4.TabIndex = 7;
            this.elrTextBox4.TablaOVistaBusqueda = "";
            this.elrTextBox4.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox4.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox4.ValorPorDefecto = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descto. Por Dependiente:";
            // 
            // txtD_ARL
            // 
            this.txtD_ARL.AMostrar = null;
            this.txtD_ARL.AValidar = null;
            this.txtD_ARL.CampoBusquedaID = "";
            this.txtD_ARL.CampoData = "D_ARL";
            this.txtD_ARL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtD_ARL.ColumnasBusqGeneral = null;
            this.txtD_ARL.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtD_ARL.Decimales = 0;
            this.txtD_ARL.DSData = this.DSDatos;
            this.txtD_ARL.EsAutoGenerado = false;
            this.txtD_ARL.EsBusqueda = false;
            this.txtD_ARL.EsBusquedaAutoIncremental = false;
            this.txtD_ARL.EsEditable = true;
            this.txtD_ARL.FiltroBusqueda = "";
            this.txtD_ARL.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtD_ARL.Location = new System.Drawing.Point(77, 103);
            this.txtD_ARL.MaxLength = 5;
            this.txtD_ARL.Name = "txtD_ARL";
            this.txtD_ARL.NombreTabla = "";
            this.txtD_ARL.SepDecimal = '\0';
            this.txtD_ARL.Size = new System.Drawing.Size(110, 29);
            this.txtD_ARL.TabIndex = 5;
            this.txtD_ARL.TablaOVistaBusqueda = "";
            this.txtD_ARL.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtD_ARL.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtD_ARL.ValorPorDefecto = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "% ARL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "% AFP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "% ARS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtE_INFOTEP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtE_ARL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtE_AFP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtE_ARS);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aporte de la Empresa";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(135, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "% INFOTEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "% ARL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "% AFP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "% ARS:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.elrTextBox2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.elrTextBox1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 103);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otras Opciones";
            // 
            // elrTextBox2
            // 
            this.elrTextBox2.AMostrar = null;
            this.elrTextBox2.AValidar = null;
            this.elrTextBox2.CampoBusquedaID = "";
            this.elrTextBox2.CampoData = "Factor_Calculo_Salario";
            this.elrTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox2.ColumnasBusqGeneral = null;
            this.elrTextBox2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox2.Decimales = 0;
            this.elrTextBox2.DSData = this.DSDatos;
            this.elrTextBox2.EsAutoGenerado = false;
            this.elrTextBox2.EsBusqueda = false;
            this.elrTextBox2.EsBusquedaAutoIncremental = false;
            this.elrTextBox2.EsEditable = true;
            this.elrTextBox2.FiltroBusqueda = "";
            this.elrTextBox2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox2.Location = new System.Drawing.Point(228, 60);
            this.elrTextBox2.Name = "elrTextBox2";
            this.elrTextBox2.NombreTabla = "";
            this.elrTextBox2.SepDecimal = '\0';
            this.elrTextBox2.Size = new System.Drawing.Size(144, 29);
            this.elrTextBox2.TabIndex = 21;
            this.elrTextBox2.TablaOVistaBusqueda = "";
            this.elrTextBox2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox2.ValorPorDefecto = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Factor Calculo Salario:";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "Salario_Tope_ARS";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(228, 25);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(144, 29);
            this.elrTextBox1.TabIndex = 19;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Salario Tope ARS:";
            // 
            // btnIrATablaISR
            // 
            this.btnIrATablaISR.Location = new System.Drawing.Point(261, 93);
            this.btnIrATablaISR.Name = "btnIrATablaISR";
            this.btnIrATablaISR.Size = new System.Drawing.Size(178, 31);
            this.btnIrATablaISR.TabIndex = 8;
            this.btnIrATablaISR.Text = "Ir A Tabla ISR";
            this.btnIrATablaISR.UseVisualStyleBackColor = true;
            this.btnIrATablaISR.Click += new System.EventHandler(this.btnIrATablaISR_Click);
            // 
            // FormNominaConfigR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtD_ARS;
            valida1.Mensaje = "No Puede ser Mayor a 100";
            valida1.NombreCampo = "D_ARS";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida1.Valor1 = "99";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtD_AFP;
            valida2.Mensaje = "No Puede ser Mayor a 100";
            valida2.NombreCampo = "D_AFP";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida2.Valor1 = "99";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtE_ARL;
            valida3.Mensaje = "No Puede ser Mayor a 100";
            valida3.NombreCampo = "D_ARL";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida3.Valor1 = "99";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtE_ARS;
            valida4.Mensaje = "No Puede ser Mayor a 100";
            valida4.NombreCampo = "E_ARS";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida4.Valor1 = "99";
            valida4.Valor2 = null;
            valida5.comtrol = this.txtE_AFP;
            valida5.Mensaje = "No Puede ser Mayor a 100";
            valida5.NombreCampo = "E_AFP";
            valida5.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida5.Valor1 = "99";
            valida5.Valor2 = null;
            valida6.comtrol = this.txtE_ARL;
            valida6.Mensaje = "No Puede ser Mayor a 100";
            valida6.NombreCampo = "E_ARL";
            valida6.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida6.Valor1 = "99";
            valida6.Valor2 = null;
            valida7.comtrol = this.txtE_INFOTEP;
            valida7.Mensaje = "No Puede ser Mayor a 100";
            valida7.NombreCampo = "E_INFOTEP";
            valida7.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MenorOIgualA;
            valida7.Valor1 = "99";
            valida7.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4,
        valida5,
        valida6,
        valida7};
            this.ClientSize = new System.Drawing.Size(510, 418);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormNominaConfigR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TNOMINA_CONFIG";
            this.Text = "OPCIONES DE CONFIGURACION DE NOMINA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox elrTextBox4;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtD_ARL;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtD_AFP;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtD_ARS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRTextBox txtE_INFOTEP;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txtE_ARL;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtE_AFP;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtE_ARS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private WinControl_ELR_NET.ELRTextBox elrTextBox2;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIrATablaISR;
    }
}