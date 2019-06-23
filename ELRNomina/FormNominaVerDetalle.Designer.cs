namespace ELRNomina
{
    partial class FormNominaVerDetalle
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoEmp = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblQuincenaNo = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblNominaId = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDOtros = new WinControl_ELR_NET.ELRTextBox();
            this.txtDARSDep = new WinControl_ELR_NET.ELRTextBox();
            this.txtDPrestamos = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDISR = new WinControl_ELR_NET.ELRTextBox();
            this.txtDARL = new WinControl_ELR_NET.ELRTextBox();
            this.txtDAFP = new WinControl_ELR_NET.ELRTextBox();
            this.txtDARS = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldoBruto = new WinControl_ELR_NET.ELRTextBox();
            this.txtTotalDescto = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new WinControl_ELR_NET.ELRTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalarioMensual = new WinControl_ELR_NET.ELRTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.Location = new System.Drawing.Point(484, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 43);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(589, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(105, 43);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblCodigoEmp);
            this.panel2.Controls.Add(this.lblAnio);
            this.panel2.Controls.Add(this.lblQuincenaNo);
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Controls.Add(this.lblNominaId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 99);
            this.panel2.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(214, 18);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NOMBRE DEL EMPLEADO";
            // 
            // lblCodigoEmp
            // 
            this.lblCodigoEmp.AutoSize = true;
            this.lblCodigoEmp.Location = new System.Drawing.Point(10, 34);
            this.lblCodigoEmp.Name = "lblCodigoEmp";
            this.lblCodigoEmp.Size = new System.Drawing.Size(417, 18);
            this.lblCodigoEmp.TabIndex = 4;
            this.lblCodigoEmp.Text = "Codigo Empleado: 000000          Cedula: 00000000000";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(549, 7);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(83, 18);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año: 2017";
            // 
            // lblQuincenaNo
            // 
            this.lblQuincenaNo.AutoSize = true;
            this.lblQuincenaNo.Location = new System.Drawing.Point(214, 7);
            this.lblQuincenaNo.Name = "lblQuincenaNo";
            this.lblQuincenaNo.Size = new System.Drawing.Size(125, 18);
            this.lblQuincenaNo.TabIndex = 2;
            this.lblQuincenaNo.Text = "Quincena No: 1";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(385, 7);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(135, 18);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes: 1 (ENERO)";
            // 
            // lblNominaId
            // 
            this.lblNominaId.AutoSize = true;
            this.lblNominaId.Location = new System.Drawing.Point(10, 7);
            this.lblNominaId.Name = "lblNominaId";
            this.lblNominaId.Size = new System.Drawing.Size(148, 18);
            this.lblNominaId.TabIndex = 0;
            this.lblNominaId.Text = "Nomina Id: 000000";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 378);
            this.panel3.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDOtros);
            this.groupBox4.Controls.Add(this.txtDARSDep);
            this.groupBox4.Controls.Add(this.txtDPrestamos);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(694, 113);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otros Descuentos";
            // 
            // txtDOtros
            // 
            this.txtDOtros.AMostrar = null;
            this.txtDOtros.AValidar = null;
            this.txtDOtros.BackColor = System.Drawing.Color.White;
            this.txtDOtros.CampoBusquedaID = "";
            this.txtDOtros.CampoData = "";
            this.txtDOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDOtros.ColumnasBusqGeneral = null;
            this.txtDOtros.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDOtros.Decimales = 0;
            this.txtDOtros.DSData = null;
            this.txtDOtros.EsAutoGenerado = false;
            this.txtDOtros.EsBusqueda = false;
            this.txtDOtros.EsBusquedaAutoIncremental = false;
            this.txtDOtros.EsEditable = true;
            this.txtDOtros.FiltroBusqueda = "";
            this.txtDOtros.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDOtros.Location = new System.Drawing.Point(170, 72);
            this.txtDOtros.Name = "txtDOtros";
            this.txtDOtros.NombreTabla = "";
            this.txtDOtros.ReadOnly = true;
            this.txtDOtros.SepDecimal = '\0';
            this.txtDOtros.Size = new System.Drawing.Size(169, 29);
            this.txtDOtros.TabIndex = 28;
            this.txtDOtros.TablaOVistaBusqueda = "";
            this.txtDOtros.Text = "0.00";
            this.txtDOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDOtros.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDOtros.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDOtros.ValorPorDefecto = "";
            // 
            // txtDARSDep
            // 
            this.txtDARSDep.AMostrar = null;
            this.txtDARSDep.AValidar = null;
            this.txtDARSDep.BackColor = System.Drawing.Color.White;
            this.txtDARSDep.CampoBusquedaID = "";
            this.txtDARSDep.CampoData = "";
            this.txtDARSDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDARSDep.ColumnasBusqGeneral = null;
            this.txtDARSDep.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDARSDep.Decimales = 0;
            this.txtDARSDep.DSData = null;
            this.txtDARSDep.EsAutoGenerado = false;
            this.txtDARSDep.EsBusqueda = false;
            this.txtDARSDep.EsBusquedaAutoIncremental = false;
            this.txtDARSDep.EsEditable = true;
            this.txtDARSDep.FiltroBusqueda = "";
            this.txtDARSDep.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDARSDep.Location = new System.Drawing.Point(508, 37);
            this.txtDARSDep.Name = "txtDARSDep";
            this.txtDARSDep.NombreTabla = "";
            this.txtDARSDep.ReadOnly = true;
            this.txtDARSDep.SepDecimal = '\0';
            this.txtDARSDep.Size = new System.Drawing.Size(155, 29);
            this.txtDARSDep.TabIndex = 27;
            this.txtDARSDep.TablaOVistaBusqueda = "";
            this.txtDARSDep.Text = "0.00";
            this.txtDARSDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDARSDep.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDARSDep.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDARSDep.ValorPorDefecto = "";
            // 
            // txtDPrestamos
            // 
            this.txtDPrestamos.AMostrar = null;
            this.txtDPrestamos.AValidar = null;
            this.txtDPrestamos.BackColor = System.Drawing.Color.White;
            this.txtDPrestamos.CampoBusquedaID = "";
            this.txtDPrestamos.CampoData = "";
            this.txtDPrestamos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDPrestamos.ColumnasBusqGeneral = null;
            this.txtDPrestamos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDPrestamos.Decimales = 0;
            this.txtDPrestamos.DSData = null;
            this.txtDPrestamos.EsAutoGenerado = false;
            this.txtDPrestamos.EsBusqueda = false;
            this.txtDPrestamos.EsBusquedaAutoIncremental = false;
            this.txtDPrestamos.EsEditable = true;
            this.txtDPrestamos.FiltroBusqueda = "";
            this.txtDPrestamos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDPrestamos.Location = new System.Drawing.Point(170, 37);
            this.txtDPrestamos.Name = "txtDPrestamos";
            this.txtDPrestamos.NombreTabla = "";
            this.txtDPrestamos.ReadOnly = true;
            this.txtDPrestamos.SepDecimal = '\0';
            this.txtDPrestamos.Size = new System.Drawing.Size(169, 29);
            this.txtDPrestamos.TabIndex = 26;
            this.txtDPrestamos.TablaOVistaBusqueda = "";
            this.txtDPrestamos.Text = "0.00";
            this.txtDPrestamos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDPrestamos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDPrestamos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDPrestamos.ValorPorDefecto = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Prestamos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "ARS Dep.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Otros Descto.:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDISR);
            this.groupBox3.Controls.Add(this.txtDARL);
            this.groupBox3.Controls.Add(this.txtDAFP);
            this.groupBox3.Controls.Add(this.txtDARS);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 118);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descuentos de ley";
            // 
            // txtDISR
            // 
            this.txtDISR.AMostrar = null;
            this.txtDISR.AValidar = null;
            this.txtDISR.BackColor = System.Drawing.Color.White;
            this.txtDISR.CampoBusquedaID = "";
            this.txtDISR.CampoData = "";
            this.txtDISR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDISR.ColumnasBusqGeneral = null;
            this.txtDISR.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDISR.Decimales = 0;
            this.txtDISR.DSData = null;
            this.txtDISR.EsAutoGenerado = false;
            this.txtDISR.EsBusqueda = false;
            this.txtDISR.EsBusquedaAutoIncremental = false;
            this.txtDISR.EsEditable = true;
            this.txtDISR.FiltroBusqueda = "";
            this.txtDISR.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDISR.Location = new System.Drawing.Point(377, 69);
            this.txtDISR.Name = "txtDISR";
            this.txtDISR.NombreTabla = "";
            this.txtDISR.ReadOnly = true;
            this.txtDISR.SepDecimal = '\0';
            this.txtDISR.Size = new System.Drawing.Size(153, 29);
            this.txtDISR.TabIndex = 25;
            this.txtDISR.TablaOVistaBusqueda = "";
            this.txtDISR.Text = "0.00";
            this.txtDISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDISR.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDISR.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDISR.ValorPorDefecto = "";
            // 
            // txtDARL
            // 
            this.txtDARL.AMostrar = null;
            this.txtDARL.AValidar = null;
            this.txtDARL.BackColor = System.Drawing.Color.White;
            this.txtDARL.CampoBusquedaID = "";
            this.txtDARL.CampoData = "";
            this.txtDARL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDARL.ColumnasBusqGeneral = null;
            this.txtDARL.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDARL.Decimales = 0;
            this.txtDARL.DSData = null;
            this.txtDARL.EsAutoGenerado = false;
            this.txtDARL.EsBusqueda = false;
            this.txtDARL.EsBusquedaAutoIncremental = false;
            this.txtDARL.EsEditable = true;
            this.txtDARL.FiltroBusqueda = "";
            this.txtDARL.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDARL.Location = new System.Drawing.Point(82, 69);
            this.txtDARL.Name = "txtDARL";
            this.txtDARL.NombreTabla = "";
            this.txtDARL.ReadOnly = true;
            this.txtDARL.SepDecimal = '\0';
            this.txtDARL.Size = new System.Drawing.Size(152, 29);
            this.txtDARL.TabIndex = 24;
            this.txtDARL.TablaOVistaBusqueda = "";
            this.txtDARL.Text = "0.00";
            this.txtDARL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDARL.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDARL.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDARL.ValorPorDefecto = "";
            // 
            // txtDAFP
            // 
            this.txtDAFP.AMostrar = null;
            this.txtDAFP.AValidar = null;
            this.txtDAFP.BackColor = System.Drawing.Color.White;
            this.txtDAFP.CampoBusquedaID = "";
            this.txtDAFP.CampoData = "";
            this.txtDAFP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDAFP.ColumnasBusqGeneral = null;
            this.txtDAFP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDAFP.Decimales = 0;
            this.txtDAFP.DSData = null;
            this.txtDAFP.EsAutoGenerado = false;
            this.txtDAFP.EsBusqueda = false;
            this.txtDAFP.EsBusquedaAutoIncremental = false;
            this.txtDAFP.EsEditable = true;
            this.txtDAFP.FiltroBusqueda = "";
            this.txtDAFP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDAFP.Location = new System.Drawing.Point(377, 34);
            this.txtDAFP.Name = "txtDAFP";
            this.txtDAFP.NombreTabla = "";
            this.txtDAFP.ReadOnly = true;
            this.txtDAFP.SepDecimal = '\0';
            this.txtDAFP.Size = new System.Drawing.Size(153, 29);
            this.txtDAFP.TabIndex = 23;
            this.txtDAFP.TablaOVistaBusqueda = "";
            this.txtDAFP.Text = "0.00";
            this.txtDAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDAFP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDAFP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDAFP.ValorPorDefecto = "";
            // 
            // txtDARS
            // 
            this.txtDARS.AMostrar = null;
            this.txtDARS.AValidar = null;
            this.txtDARS.BackColor = System.Drawing.Color.White;
            this.txtDARS.CampoBusquedaID = "";
            this.txtDARS.CampoData = "";
            this.txtDARS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDARS.ColumnasBusqGeneral = null;
            this.txtDARS.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDARS.Decimales = 0;
            this.txtDARS.DSData = null;
            this.txtDARS.EsAutoGenerado = false;
            this.txtDARS.EsBusqueda = false;
            this.txtDARS.EsBusquedaAutoIncremental = false;
            this.txtDARS.EsEditable = true;
            this.txtDARS.FiltroBusqueda = "";
            this.txtDARS.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDARS.Location = new System.Drawing.Point(83, 34);
            this.txtDARS.Name = "txtDARS";
            this.txtDARS.NombreTabla = "";
            this.txtDARS.ReadOnly = true;
            this.txtDARS.SepDecimal = '\0';
            this.txtDARS.Size = new System.Drawing.Size(151, 29);
            this.txtDARS.TabIndex = 22;
            this.txtDARS.TablaOVistaBusqueda = "";
            this.txtDARS.Text = "0.00";
            this.txtDARS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDARS.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDARS.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDARS.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "ISR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "ARL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "AFP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "ARS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalarioMensual);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSueldoNeto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotalDescto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSueldoBruto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 143);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo Bruto:";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.AMostrar = null;
            this.txtSueldoBruto.AValidar = null;
            this.txtSueldoBruto.BackColor = System.Drawing.Color.White;
            this.txtSueldoBruto.CampoBusquedaID = "";
            this.txtSueldoBruto.CampoData = "";
            this.txtSueldoBruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSueldoBruto.ColumnasBusqGeneral = null;
            this.txtSueldoBruto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSueldoBruto.Decimales = 0;
            this.txtSueldoBruto.DSData = null;
            this.txtSueldoBruto.EsAutoGenerado = false;
            this.txtSueldoBruto.EsBusqueda = false;
            this.txtSueldoBruto.EsBusquedaAutoIncremental = false;
            this.txtSueldoBruto.EsEditable = true;
            this.txtSueldoBruto.FiltroBusqueda = "";
            this.txtSueldoBruto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSueldoBruto.Location = new System.Drawing.Point(473, 30);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.NombreTabla = "";
            this.txtSueldoBruto.ReadOnly = true;
            this.txtSueldoBruto.SepDecimal = '\0';
            this.txtSueldoBruto.Size = new System.Drawing.Size(190, 31);
            this.txtSueldoBruto.TabIndex = 28;
            this.txtSueldoBruto.TablaOVistaBusqueda = "";
            this.txtSueldoBruto.Text = "0.00";
            this.txtSueldoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldoBruto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSueldoBruto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSueldoBruto.ValorPorDefecto = "";
            // 
            // txtTotalDescto
            // 
            this.txtTotalDescto.AMostrar = null;
            this.txtTotalDescto.AValidar = null;
            this.txtTotalDescto.BackColor = System.Drawing.Color.White;
            this.txtTotalDescto.CampoBusquedaID = "";
            this.txtTotalDescto.CampoData = "";
            this.txtTotalDescto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalDescto.ColumnasBusqGeneral = null;
            this.txtTotalDescto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTotalDescto.Decimales = 0;
            this.txtTotalDescto.DSData = null;
            this.txtTotalDescto.EsAutoGenerado = false;
            this.txtTotalDescto.EsBusqueda = false;
            this.txtTotalDescto.EsBusquedaAutoIncremental = false;
            this.txtTotalDescto.EsEditable = true;
            this.txtTotalDescto.FiltroBusqueda = "";
            this.txtTotalDescto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTotalDescto.Location = new System.Drawing.Point(473, 67);
            this.txtTotalDescto.Name = "txtTotalDescto";
            this.txtTotalDescto.NombreTabla = "";
            this.txtTotalDescto.ReadOnly = true;
            this.txtTotalDescto.SepDecimal = '\0';
            this.txtTotalDescto.Size = new System.Drawing.Size(190, 31);
            this.txtTotalDescto.TabIndex = 30;
            this.txtTotalDescto.TablaOVistaBusqueda = "";
            this.txtTotalDescto.Text = "0.00";
            this.txtTotalDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDescto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTotalDescto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTotalDescto.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "- Total Descto.:";
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.AMostrar = null;
            this.txtSueldoNeto.AValidar = null;
            this.txtSueldoNeto.BackColor = System.Drawing.Color.White;
            this.txtSueldoNeto.CampoBusquedaID = "";
            this.txtSueldoNeto.CampoData = "";
            this.txtSueldoNeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSueldoNeto.ColumnasBusqGeneral = null;
            this.txtSueldoNeto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSueldoNeto.Decimales = 0;
            this.txtSueldoNeto.DSData = null;
            this.txtSueldoNeto.EsAutoGenerado = false;
            this.txtSueldoNeto.EsBusqueda = false;
            this.txtSueldoNeto.EsBusquedaAutoIncremental = false;
            this.txtSueldoNeto.EsEditable = true;
            this.txtSueldoNeto.FiltroBusqueda = "";
            this.txtSueldoNeto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSueldoNeto.Location = new System.Drawing.Point(473, 104);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.NombreTabla = "";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.SepDecimal = '\0';
            this.txtSueldoNeto.Size = new System.Drawing.Size(190, 31);
            this.txtSueldoNeto.TabIndex = 32;
            this.txtSueldoNeto.TablaOVistaBusqueda = "";
            this.txtSueldoNeto.Text = "0.00";
            this.txtSueldoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldoNeto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSueldoNeto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSueldoNeto.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "= Sueldo Neto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Salario Mensual";
            // 
            // txtSalarioMensual
            // 
            this.txtSalarioMensual.AMostrar = null;
            this.txtSalarioMensual.AValidar = null;
            this.txtSalarioMensual.BackColor = System.Drawing.Color.White;
            this.txtSalarioMensual.CampoBusquedaID = "";
            this.txtSalarioMensual.CampoData = "";
            this.txtSalarioMensual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalarioMensual.ColumnasBusqGeneral = null;
            this.txtSalarioMensual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSalarioMensual.Decimales = 0;
            this.txtSalarioMensual.DSData = null;
            this.txtSalarioMensual.EsAutoGenerado = false;
            this.txtSalarioMensual.EsBusqueda = false;
            this.txtSalarioMensual.EsBusquedaAutoIncremental = false;
            this.txtSalarioMensual.EsEditable = true;
            this.txtSalarioMensual.FiltroBusqueda = "";
            this.txtSalarioMensual.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSalarioMensual.Location = new System.Drawing.Point(19, 61);
            this.txtSalarioMensual.Name = "txtSalarioMensual";
            this.txtSalarioMensual.NombreTabla = "";
            this.txtSalarioMensual.ReadOnly = true;
            this.txtSalarioMensual.SepDecimal = '\0';
            this.txtSalarioMensual.Size = new System.Drawing.Size(177, 31);
            this.txtSalarioMensual.TabIndex = 34;
            this.txtSalarioMensual.TablaOVistaBusqueda = "";
            this.txtSalarioMensual.Text = "0.00";
            this.txtSalarioMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalarioMensual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSalarioMensual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSalarioMensual.ValorPorDefecto = "";
            // 
            // FormNominaVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(698, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNominaVerDetalle";
            this.Text = "DETALLE DE NOMINA GENERADA";
            this.Load += new System.EventHandler(this.FormNominaVerDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoEmp;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblQuincenaNo;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblNominaId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private WinControl_ELR_NET.ELRTextBox txtDOtros;
        private WinControl_ELR_NET.ELRTextBox txtDARSDep;
        private WinControl_ELR_NET.ELRTextBox txtDPrestamos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private WinControl_ELR_NET.ELRTextBox txtDISR;
        private WinControl_ELR_NET.ELRTextBox txtDARL;
        private WinControl_ELR_NET.ELRTextBox txtDAFP;
        private WinControl_ELR_NET.ELRTextBox txtDARS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtSueldoNeto;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtTotalDescto;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtSueldoBruto;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtSalarioMensual;
        private System.Windows.Forms.Label label6;
    }
}