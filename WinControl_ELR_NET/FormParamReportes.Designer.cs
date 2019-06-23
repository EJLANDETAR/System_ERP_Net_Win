namespace WinControl_ELR_NET
{
    partial class FormParamReportes
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
            WinControl_ELR_NET.MyColumna myColumna5 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna6 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna3 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna4 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna1 = new WinControl_ELR_NET.MyColumna();
            WinControl_ELR_NET.MyColumna myColumna2 = new WinControl_ELR_NET.MyColumna();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnOficina = new System.Windows.Forms.Panel();
            this.chkPorOficina = new System.Windows.Forms.CheckBox();
            this.pnPorEvaluador = new System.Windows.Forms.Panel();
            this.chkPorEvaluador = new System.Windows.Forms.CheckBox();
            this.lblNombreEvaluador = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEvaluadorId = new System.Windows.Forms.Label();
            this.pnPorOficialCredito = new System.Windows.Forms.Panel();
            this.chkPorOficialCredito = new System.Windows.Forms.CheckBox();
            this.lblNombreOficial = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOficialId = new System.Windows.Forms.Label();
            this.pnPorCajaId = new System.Windows.Forms.Panel();
            this.chkPorCajaId = new System.Windows.Forms.CheckBox();
            this.pnVendedor = new System.Windows.Forms.Panel();
            this.chkPorVendedor = new System.Windows.Forms.CheckBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblVendedorId = new System.Windows.Forms.Label();
            this.pnPorRangoFecha = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFechaHasta = new System.Windows.Forms.Panel();
            this.dtpAFecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPorVendedor = new WinControl_ELR_NET.ELRBotonBuscar();
            this.cboCaja = new WinControl_ELR_NET.ELRCombobox();
            this.btnPorOficialCredito = new WinControl_ELR_NET.ELRBotonBuscar();
            this.btnBusquedaEvaluador = new WinControl_ELR_NET.ELRBotonBuscar();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.panel1.SuspendLayout();
            this.pnOficina.SuspendLayout();
            this.pnPorEvaluador.SuspendLayout();
            this.pnPorOficialCredito.SuspendLayout();
            this.pnPorCajaId.SuspendLayout();
            this.pnVendedor.SuspendLayout();
            this.pnPorRangoFecha.SuspendLayout();
            this.pnFechaHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 42);
            this.panel1.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Location = new System.Drawing.Point(442, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 38);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(523, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnOficina
            // 
            this.pnOficina.Controls.Add(this.chkPorOficina);
            this.pnOficina.Controls.Add(this.cboOficina);
            this.pnOficina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOficina.Location = new System.Drawing.Point(0, 0);
            this.pnOficina.Name = "pnOficina";
            this.pnOficina.Size = new System.Drawing.Size(608, 54);
            this.pnOficina.TabIndex = 12;
            // 
            // chkPorOficina
            // 
            this.chkPorOficina.AutoSize = true;
            this.chkPorOficina.Location = new System.Drawing.Point(12, 14);
            this.chkPorOficina.Name = "chkPorOficina";
            this.chkPorOficina.Size = new System.Drawing.Size(109, 25);
            this.chkPorOficina.TabIndex = 15;
            this.chkPorOficina.Text = "Por Oficina:";
            this.chkPorOficina.UseVisualStyleBackColor = true;
            this.chkPorOficina.CheckedChanged += new System.EventHandler(this.Opcion_Cheched);
            // 
            // pnPorEvaluador
            // 
            this.pnPorEvaluador.Controls.Add(this.btnBusquedaEvaluador);
            this.pnPorEvaluador.Controls.Add(this.chkPorEvaluador);
            this.pnPorEvaluador.Controls.Add(this.lblNombreEvaluador);
            this.pnPorEvaluador.Controls.Add(this.label7);
            this.pnPorEvaluador.Controls.Add(this.lblEvaluadorId);
            this.pnPorEvaluador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPorEvaluador.Location = new System.Drawing.Point(0, 54);
            this.pnPorEvaluador.Name = "pnPorEvaluador";
            this.pnPorEvaluador.Size = new System.Drawing.Size(608, 88);
            this.pnPorEvaluador.TabIndex = 13;
            // 
            // chkPorEvaluador
            // 
            this.chkPorEvaluador.AutoSize = true;
            this.chkPorEvaluador.Location = new System.Drawing.Point(12, 13);
            this.chkPorEvaluador.Name = "chkPorEvaluador";
            this.chkPorEvaluador.Size = new System.Drawing.Size(126, 25);
            this.chkPorEvaluador.TabIndex = 14;
            this.chkPorEvaluador.Text = "Por Evaluador";
            this.chkPorEvaluador.UseVisualStyleBackColor = true;
            this.chkPorEvaluador.CheckedChanged += new System.EventHandler(this.Opcion_Cheched);
            // 
            // lblNombreEvaluador
            // 
            this.lblNombreEvaluador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEvaluador.Location = new System.Drawing.Point(175, 48);
            this.lblNombreEvaluador.Name = "lblNombreEvaluador";
            this.lblNombreEvaluador.Size = new System.Drawing.Size(420, 30);
            this.lblNombreEvaluador.TabIndex = 12;
            this.lblNombreEvaluador.Text = "(TODOS)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre:";
            // 
            // lblEvaluadorId
            // 
            this.lblEvaluadorId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEvaluadorId.Location = new System.Drawing.Point(174, 13);
            this.lblEvaluadorId.Name = "lblEvaluadorId";
            this.lblEvaluadorId.Size = new System.Drawing.Size(110, 30);
            this.lblEvaluadorId.TabIndex = 10;
            this.lblEvaluadorId.Text = "000000";
            // 
            // pnPorOficialCredito
            // 
            this.pnPorOficialCredito.Controls.Add(this.btnPorOficialCredito);
            this.pnPorOficialCredito.Controls.Add(this.chkPorOficialCredito);
            this.pnPorOficialCredito.Controls.Add(this.lblNombreOficial);
            this.pnPorOficialCredito.Controls.Add(this.label9);
            this.pnPorOficialCredito.Controls.Add(this.lblOficialId);
            this.pnPorOficialCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPorOficialCredito.Location = new System.Drawing.Point(0, 142);
            this.pnPorOficialCredito.Name = "pnPorOficialCredito";
            this.pnPorOficialCredito.Size = new System.Drawing.Size(608, 88);
            this.pnPorOficialCredito.TabIndex = 14;
            // 
            // chkPorOficialCredito
            // 
            this.chkPorOficialCredito.AutoSize = true;
            this.chkPorOficialCredito.Location = new System.Drawing.Point(12, 13);
            this.chkPorOficialCredito.Name = "chkPorOficialCredito";
            this.chkPorOficialCredito.Size = new System.Drawing.Size(156, 25);
            this.chkPorOficialCredito.TabIndex = 15;
            this.chkPorOficialCredito.Text = "Por Oficial Credito";
            this.chkPorOficialCredito.UseVisualStyleBackColor = true;
            this.chkPorOficialCredito.CheckedChanged += new System.EventHandler(this.Opcion_Cheched);
            // 
            // lblNombreOficial
            // 
            this.lblNombreOficial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreOficial.Location = new System.Drawing.Point(174, 48);
            this.lblNombreOficial.Name = "lblNombreOficial";
            this.lblNombreOficial.Size = new System.Drawing.Size(420, 30);
            this.lblNombreOficial.TabIndex = 12;
            this.lblNombreOficial.Text = "(TODOS)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre:";
            // 
            // lblOficialId
            // 
            this.lblOficialId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOficialId.Location = new System.Drawing.Point(174, 13);
            this.lblOficialId.Name = "lblOficialId";
            this.lblOficialId.Size = new System.Drawing.Size(110, 30);
            this.lblOficialId.TabIndex = 10;
            this.lblOficialId.Text = "000000";
            // 
            // pnPorCajaId
            // 
            this.pnPorCajaId.Controls.Add(this.chkPorCajaId);
            this.pnPorCajaId.Controls.Add(this.cboCaja);
            this.pnPorCajaId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPorCajaId.Location = new System.Drawing.Point(0, 230);
            this.pnPorCajaId.Name = "pnPorCajaId";
            this.pnPorCajaId.Size = new System.Drawing.Size(608, 47);
            this.pnPorCajaId.TabIndex = 15;
            // 
            // chkPorCajaId
            // 
            this.chkPorCajaId.AutoSize = true;
            this.chkPorCajaId.Location = new System.Drawing.Point(12, 8);
            this.chkPorCajaId.Name = "chkPorCajaId";
            this.chkPorCajaId.Size = new System.Drawing.Size(90, 25);
            this.chkPorCajaId.TabIndex = 16;
            this.chkPorCajaId.Text = "Por Caja:";
            this.chkPorCajaId.UseVisualStyleBackColor = true;
            this.chkPorCajaId.CheckedChanged += new System.EventHandler(this.Opcion_Cheched);
            // 
            // pnVendedor
            // 
            this.pnVendedor.Controls.Add(this.btnPorVendedor);
            this.pnVendedor.Controls.Add(this.chkPorVendedor);
            this.pnVendedor.Controls.Add(this.lblNombreVendedor);
            this.pnVendedor.Controls.Add(this.label15);
            this.pnVendedor.Controls.Add(this.lblVendedorId);
            this.pnVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVendedor.Location = new System.Drawing.Point(0, 277);
            this.pnVendedor.Name = "pnVendedor";
            this.pnVendedor.Size = new System.Drawing.Size(608, 88);
            this.pnVendedor.TabIndex = 18;
            // 
            // chkPorVendedor
            // 
            this.chkPorVendedor.AutoSize = true;
            this.chkPorVendedor.Location = new System.Drawing.Point(12, 6);
            this.chkPorVendedor.Name = "chkPorVendedor";
            this.chkPorVendedor.Size = new System.Drawing.Size(128, 25);
            this.chkPorVendedor.TabIndex = 17;
            this.chkPorVendedor.Text = "Por Vendedor:";
            this.chkPorVendedor.UseVisualStyleBackColor = true;
            this.chkPorVendedor.CheckedChanged += new System.EventHandler(this.Opcion_Cheched);
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreVendedor.Location = new System.Drawing.Point(174, 48);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(420, 30);
            this.lblNombreVendedor.TabIndex = 12;
            this.lblNombreVendedor.Text = "(TODOS)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 21);
            this.label15.TabIndex = 11;
            this.label15.Text = "Nombre:";
            // 
            // lblVendedorId
            // 
            this.lblVendedorId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVendedorId.Location = new System.Drawing.Point(174, 12);
            this.lblVendedorId.Name = "lblVendedorId";
            this.lblVendedorId.Size = new System.Drawing.Size(110, 30);
            this.lblVendedorId.TabIndex = 10;
            this.lblVendedorId.Text = "000000";
            // 
            // pnPorRangoFecha
            // 
            this.pnPorRangoFecha.Controls.Add(this.dtpFechaHasta);
            this.pnPorRangoFecha.Controls.Add(this.dtpFechaDesde);
            this.pnPorRangoFecha.Controls.Add(this.label2);
            this.pnPorRangoFecha.Controls.Add(this.label1);
            this.pnPorRangoFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPorRangoFecha.Location = new System.Drawing.Point(0, 449);
            this.pnPorRangoFecha.Name = "pnPorRangoFecha";
            this.pnPorRangoFecha.Size = new System.Drawing.Size(608, 140);
            this.pnPorRangoFecha.TabIndex = 20;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(175, 75);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 29);
            this.dtpFechaHasta.TabIndex = 23;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(174, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(266, 29);
            this.dtpFechaDesde.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Desde:";
            // 
            // pnFechaHasta
            // 
            this.pnFechaHasta.Controls.Add(this.dtpAFecha);
            this.pnFechaHasta.Controls.Add(this.label13);
            this.pnFechaHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFechaHasta.Location = new System.Drawing.Point(0, 365);
            this.pnFechaHasta.Name = "pnFechaHasta";
            this.pnFechaHasta.Size = new System.Drawing.Size(608, 84);
            this.pnFechaHasta.TabIndex = 19;
            // 
            // dtpAFecha
            // 
            this.dtpAFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAFecha.Location = new System.Drawing.Point(174, 24);
            this.dtpAFecha.Name = "dtpAFecha";
            this.dtpAFecha.Size = new System.Drawing.Size(266, 29);
            this.dtpAFecha.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "A Fecha:";
            // 
            // btnPorVendedor
            // 
            this.btnPorVendedor.AMostrar = null;
            myColumna5.Ancho = 100;
            myColumna5.HeaderText = "Id";
            myColumna5.NombreCampo = "Empleado_Id";
            myColumna6.Ancho = 300;
            myColumna6.HeaderText = "Nombre";
            myColumna6.NombreCampo = "Nombre_Completo";
            this.btnPorVendedor.columnas = new WinControl_ELR_NET.MyColumna[] {
        myColumna5,
        myColumna6};
            this.btnPorVendedor.CondicionABuscar = "Campo_Busqueda Like \'%\' + @aBuscar + \'%\'";
            this.btnPorVendedor.CondicionOrderBY = "";
            this.btnPorVendedor.EsAutoIncremental = true;
            this.btnPorVendedor.FiltroEstatico = "";
            this.btnPorVendedor.Limite = 100;
            this.btnPorVendedor.Location = new System.Drawing.Point(290, 12);
            this.btnPorVendedor.Name = "btnPorVendedor";
            this.btnPorVendedor.Size = new System.Drawing.Size(74, 33);
            this.btnPorVendedor.TabIndex = 18;
            this.btnPorVendedor.TablaOVista = "VEMPLEADOS";
            this.btnPorVendedor.Text = "Buscar";
            this.btnPorVendedor.Titulo = "Busqueda General";
            this.btnPorVendedor.UseVisualStyleBackColor = true;
            this.btnPorVendedor.Click += new System.EventHandler(this.btnPorVendedor_Click);
            // 
            // cboCaja
            // 
            this.cboCaja.CampoData = "";
            this.cboCaja.CampoJoinCombobox2 = "";
            this.cboCaja.ComboboxAFiltrar = null;
            this.cboCaja.DisplayMember = "Nombre";
            this.cboCaja.DSData = null;
            this.cboCaja.EsEditable = true;
            this.cboCaja.FiltroBusqueda = "";
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(174, 6);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.NombreTabla = "";
            this.cboCaja.Size = new System.Drawing.Size(381, 29);
            this.cboCaja.SSQL = "";
            this.cboCaja.TabIndex = 0;
            this.cboCaja.TablaOVistaConsulta = "TCajas";
            this.cboCaja.ValorPorDefecto = "0";
            this.cboCaja.ValueMember = "Caja_Id";
            // 
            // btnPorOficialCredito
            // 
            this.btnPorOficialCredito.AMostrar = null;
            myColumna3.Ancho = 100;
            myColumna3.HeaderText = "Id";
            myColumna3.NombreCampo = "Empleado_Id";
            myColumna4.Ancho = 300;
            myColumna4.HeaderText = "Nombre";
            myColumna4.NombreCampo = "Nombre_Completo";
            this.btnPorOficialCredito.columnas = new WinControl_ELR_NET.MyColumna[] {
        myColumna3,
        myColumna4};
            this.btnPorOficialCredito.CondicionABuscar = "Campo_Busqueda Like \'%\' + @aBuscar + \'%\'";
            this.btnPorOficialCredito.CondicionOrderBY = "";
            this.btnPorOficialCredito.EsAutoIncremental = true;
            this.btnPorOficialCredito.FiltroEstatico = "";
            this.btnPorOficialCredito.Limite = 100;
            this.btnPorOficialCredito.Location = new System.Drawing.Point(290, 12);
            this.btnPorOficialCredito.Name = "btnPorOficialCredito";
            this.btnPorOficialCredito.Size = new System.Drawing.Size(74, 33);
            this.btnPorOficialCredito.TabIndex = 16;
            this.btnPorOficialCredito.TablaOVista = "VEMPLEADOS";
            this.btnPorOficialCredito.Text = "Buscar";
            this.btnPorOficialCredito.Titulo = "Busqueda General";
            this.btnPorOficialCredito.UseVisualStyleBackColor = true;
            this.btnPorOficialCredito.Click += new System.EventHandler(this.btnPorOficialCredito_Click);
            // 
            // btnBusquedaEvaluador
            // 
            this.btnBusquedaEvaluador.AMostrar = null;
            myColumna1.Ancho = 100;
            myColumna1.HeaderText = "Id";
            myColumna1.NombreCampo = "Empleado_Id";
            myColumna2.Ancho = 300;
            myColumna2.HeaderText = "Nombre";
            myColumna2.NombreCampo = "Nombre_Completo";
            this.btnBusquedaEvaluador.columnas = new WinControl_ELR_NET.MyColumna[] {
        myColumna1,
        myColumna2};
            this.btnBusquedaEvaluador.CondicionABuscar = "Campo_Busqueda Like \'%\' + @aBuscar + \'%\'";
            this.btnBusquedaEvaluador.CondicionOrderBY = "";
            this.btnBusquedaEvaluador.EsAutoIncremental = true;
            this.btnBusquedaEvaluador.FiltroEstatico = "";
            this.btnBusquedaEvaluador.Limite = 100;
            this.btnBusquedaEvaluador.Location = new System.Drawing.Point(290, 12);
            this.btnBusquedaEvaluador.Name = "btnBusquedaEvaluador";
            this.btnBusquedaEvaluador.Size = new System.Drawing.Size(74, 33);
            this.btnBusquedaEvaluador.TabIndex = 15;
            this.btnBusquedaEvaluador.TablaOVista = "VEMPLEADOS";
            this.btnBusquedaEvaluador.Text = "Buscar";
            this.btnBusquedaEvaluador.Titulo = "Busqueda General";
            this.btnBusquedaEvaluador.UseVisualStyleBackColor = true;
            this.btnBusquedaEvaluador.Click += new System.EventHandler(this.btnBusquedaEvaluador_Click);
            // 
            // cboOficina
            // 
            this.cboOficina.CampoData = "";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DisplayMember = "Nombre";
            this.cboOficina.DSData = null;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(174, 12);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(420, 29);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 0;
            this.cboOficina.TablaOVistaConsulta = "TEMPRESAS_OFICINAS";
            this.cboOficina.ValorPorDefecto = "0";
            this.cboOficina.ValueMember = "Oficina_Id";
            // 
            // FormParamReportes
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(608, 646);
            this.Controls.Add(this.pnPorRangoFecha);
            this.Controls.Add(this.pnFechaHasta);
            this.Controls.Add(this.pnVendedor);
            this.Controls.Add(this.pnPorCajaId);
            this.Controls.Add(this.pnPorOficialCredito);
            this.Controls.Add(this.pnPorEvaluador);
            this.Controls.Add(this.pnOficina);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParamReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELEGIR RANGO FECHA";
            this.Load += new System.EventHandler(this.FormRangoFecha_Load);
            this.panel1.ResumeLayout(false);
            this.pnOficina.ResumeLayout(false);
            this.pnOficina.PerformLayout();
            this.pnPorEvaluador.ResumeLayout(false);
            this.pnPorEvaluador.PerformLayout();
            this.pnPorOficialCredito.ResumeLayout(false);
            this.pnPorOficialCredito.PerformLayout();
            this.pnPorCajaId.ResumeLayout(false);
            this.pnPorCajaId.PerformLayout();
            this.pnVendedor.ResumeLayout(false);
            this.pnVendedor.PerformLayout();
            this.pnPorRangoFecha.ResumeLayout(false);
            this.pnPorRangoFecha.PerformLayout();
            this.pnFechaHasta.ResumeLayout(false);
            this.pnFechaHasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnOficina;
        private System.Windows.Forms.Panel pnPorEvaluador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnPorOficialCredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnPorCajaId;
        private System.Windows.Forms.CheckBox chkPorOficina;
        private System.Windows.Forms.CheckBox chkPorEvaluador;
        private System.Windows.Forms.CheckBox chkPorOficialCredito;
        private System.Windows.Forms.CheckBox chkPorCajaId;
        private System.Windows.Forms.Panel pnVendedor;
        private System.Windows.Forms.CheckBox chkPorVendedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnPorRangoFecha;
        private System.Windows.Forms.Panel pnFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private ELRBotonBuscar btnBusquedaEvaluador;
        private ELRBotonBuscar btnPorOficialCredito;
        private ELRBotonBuscar btnPorVendedor;
        public ELRCombobox cboOficina;
        public System.Windows.Forms.Label lblNombreEvaluador;
        public System.Windows.Forms.Label lblEvaluadorId;
        public System.Windows.Forms.Label lblNombreOficial;
        public System.Windows.Forms.Label lblOficialId;
        public ELRCombobox cboCaja;
        public System.Windows.Forms.Label lblNombreVendedor;
        public System.Windows.Forms.Label lblVendedorId;
        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        public System.Windows.Forms.DateTimePicker dtpAFecha;
    }
}