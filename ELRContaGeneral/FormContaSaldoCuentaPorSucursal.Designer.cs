namespace ELRContaGeneral
{
    partial class FormContaSaldoCuentaPorSucursal
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
            this.lblDescripcionCuenta = new System.Windows.Forms.Label();
            this.lblDescripcionCentroCosto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCentroCosto = new WinControl_ELR_NET.ELRTextBox();
            this.txtAnio = new WinControl_ELR_NET.ELRTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboMes = new WinControl_ELR_NET.ELRCombobox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSaldoMesAnt = new WinControl_ELR_NET.ELRTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSaldoMes = new WinControl_ELR_NET.ELRTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCreditoMes = new WinControl_ELR_NET.ELRTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDebitoMes = new WinControl_ELR_NET.ELRTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSaldoActual = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCreditoAcumulado = new WinControl_ELR_NET.ELRTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDebitoAcum = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSaldoAnioAnt = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscaCuenta = new System.Windows.Forms.Button();
            this.btnBuscarAuxiliar = new System.Windows.Forms.Button();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(14, 440);
            this.pnTotales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTotales.Size = new System.Drawing.Size(877, 52);
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnBuscarAuxiliar);
            this.pnBusqSencilla.Controls.Add(this.btnBuscaCuenta);
            this.pnBusqSencilla.Controls.Add(this.txtAnio);
            this.pnBusqSencilla.Controls.Add(this.label18);
            this.pnBusqSencilla.Controls.Add(this.cboMes);
            this.pnBusqSencilla.Controls.Add(this.label19);
            this.pnBusqSencilla.Controls.Add(this.txtCentroCosto);
            this.pnBusqSencilla.Controls.Add(this.label9);
            this.pnBusqSencilla.Controls.Add(this.lblDescripcionCentroCosto);
            this.pnBusqSencilla.Controls.Add(this.lblDescripcionCuenta);
            this.pnBusqSencilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBusqSencilla.Size = new System.Drawing.Size(877, 149);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblDescripcionCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblDescripcionCentroCosto, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label9, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCentroCosto, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label19, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboMes, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label18, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtAnio, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscaCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarAuxiliar, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(171, 8);
            this.txtABuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtABuscar.Size = new System.Drawing.Size(176, 26);
            this.txtABuscar.Leave += new System.EventHandler(this.txtABuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(419, 72);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Size = new System.Drawing.Size(190, 61);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.Text = "Cuenta Contable:";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.AutoSize = false;
            this.lblCantidadRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidadRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(873, 48);
            this.lblCantidadRegistro.Text = "Diferencia: 0.00";
            this.lblCantidadRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 440);
            // 
            // chkRangoFecha
            // 
            this.chkRangoFecha.Size = new System.Drawing.Size(118, 25);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Size = new System.Drawing.Size(182, 29);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Size = new System.Drawing.Size(182, 29);
            // 
            // lblDescripcionCuenta
            // 
            this.lblDescripcionCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcionCuenta.Location = new System.Drawing.Point(419, 7);
            this.lblDescripcionCuenta.Name = "lblDescripcionCuenta";
            this.lblDescripcionCuenta.Size = new System.Drawing.Size(434, 27);
            this.lblDescripcionCuenta.TabIndex = 6;
            this.lblDescripcionCuenta.Text = "(TODOS)";
            // 
            // lblDescripcionCentroCosto
            // 
            this.lblDescripcionCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcionCentroCosto.Location = new System.Drawing.Point(419, 39);
            this.lblDescripcionCentroCosto.Name = "lblDescripcionCentroCosto";
            this.lblDescripcionCentroCosto.Size = new System.Drawing.Size(434, 26);
            this.lblDescripcionCentroCosto.TabIndex = 7;
            this.lblDescripcionCentroCosto.Text = "(TODOS)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "C. Costo\\Sucursal:";
            // 
            // txtCentroCosto
            // 
            this.txtCentroCosto.AMostrar = null;
            this.txtCentroCosto.AValidar = null;
            this.txtCentroCosto.CampoBusquedaID = "";
            this.txtCentroCosto.CampoData = "";
            this.txtCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCentroCosto.ColumnasBusqGeneral = null;
            this.txtCentroCosto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCentroCosto.Decimales = 0;
            this.txtCentroCosto.DSData = null;
            this.txtCentroCosto.EsAutoGenerado = false;
            this.txtCentroCosto.EsBusqueda = false;
            this.txtCentroCosto.EsBusquedaAutoIncremental = false;
            this.txtCentroCosto.EsEditable = true;
            this.txtCentroCosto.FiltroBusqueda = "";
            this.txtCentroCosto.Formato = WinControl_ELR_NET.tbFormato.NumerosEnterosPositivos;
            this.txtCentroCosto.Location = new System.Drawing.Point(171, 39);
            this.txtCentroCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCentroCosto.Name = "txtCentroCosto";
            this.txtCentroCosto.NombreTabla = "";
            this.txtCentroCosto.SepDecimal = '\0';
            this.txtCentroCosto.Size = new System.Drawing.Size(176, 26);
            this.txtCentroCosto.TabIndex = 66;
            this.txtCentroCosto.TablaOVistaBusqueda = "";
            this.txtCentroCosto.Text = "0";
            this.txtCentroCosto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCentroCosto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCentroCosto.ValorPorDefecto = "";
            this.txtCentroCosto.Leave += new System.EventHandler(this.txtCentroCosto_Leave);
            // 
            // txtAnio
            // 
            this.txtAnio.AMostrar = null;
            this.txtAnio.AValidar = null;
            this.txtAnio.CampoBusquedaID = "";
            this.txtAnio.CampoData = "";
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnio.ColumnasBusqGeneral = null;
            this.txtAnio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAnio.Decimales = 0;
            this.txtAnio.DSData = null;
            this.txtAnio.EsAutoGenerado = false;
            this.txtAnio.EsBusqueda = false;
            this.txtAnio.EsBusquedaAutoIncremental = false;
            this.txtAnio.EsEditable = true;
            this.txtAnio.FiltroBusqueda = "";
            this.txtAnio.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtAnio.Location = new System.Drawing.Point(171, 107);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.NombreTabla = "";
            this.txtAnio.SepDecimal = '\0';
            this.txtAnio.Size = new System.Drawing.Size(224, 26);
            this.txtAnio.TabIndex = 70;
            this.txtAnio.TablaOVistaBusqueda = "";
            this.txtAnio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAnio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAnio.ValorPorDefecto = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 20);
            this.label18.TabIndex = 69;
            this.label18.Text = "Anio:";
            // 
            // cboMes
            // 
            this.cboMes.AValidar = null;
            this.cboMes.CampoData = "";
            this.cboMes.CampoJoinCombobox2 = "";
            this.cboMes.ComboboxAFiltrar = null;
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.DSData = null;
            this.cboMes.EsEditable = true;
            this.cboMes.FiltroBusqueda = "";
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE",
            "MES 13"});
            this.cboMes.Location = new System.Drawing.Point(171, 71);
            this.cboMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMes.Name = "cboMes";
            this.cboMes.NombreTabla = "";
            this.cboMes.Size = new System.Drawing.Size(224, 28);
            this.cboMes.SSQL = "";
            this.cboMes.TabIndex = 68;
            this.cboMes.TablaOVistaConsulta = "";
            this.cboMes.UsaDataGlobal = false;
            this.cboMes.ValorPorDefecto = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 20);
            this.label19.TabIndex = 67;
            this.label19.Text = "Mes Saldo:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSaldoMesAnt);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtSaldoMes);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCreditoMes);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtDebitoMes);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtSaldoActual);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtCreditoAcumulado);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDebitoAcum);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSaldoAnioAnt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(14, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 239);
            this.panel1.TabIndex = 47;
            // 
            // txtSaldoMesAnt
            // 
            this.txtSaldoMesAnt.AMostrar = null;
            this.txtSaldoMesAnt.AValidar = null;
            this.txtSaldoMesAnt.BackColor = System.Drawing.Color.White;
            this.txtSaldoMesAnt.CampoBusquedaID = "";
            this.txtSaldoMesAnt.CampoData = "";
            this.txtSaldoMesAnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoMesAnt.ColumnasBusqGeneral = null;
            this.txtSaldoMesAnt.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSaldoMesAnt.Decimales = 0;
            this.txtSaldoMesAnt.DSData = null;
            this.txtSaldoMesAnt.EsAutoGenerado = false;
            this.txtSaldoMesAnt.EsBusqueda = false;
            this.txtSaldoMesAnt.EsBusquedaAutoIncremental = false;
            this.txtSaldoMesAnt.EsEditable = true;
            this.txtSaldoMesAnt.FiltroBusqueda = "";
            this.txtSaldoMesAnt.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSaldoMesAnt.Location = new System.Drawing.Point(588, 13);
            this.txtSaldoMesAnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldoMesAnt.Name = "txtSaldoMesAnt";
            this.txtSaldoMesAnt.NombreTabla = "";
            this.txtSaldoMesAnt.ReadOnly = true;
            this.txtSaldoMesAnt.SepDecimal = '\0';
            this.txtSaldoMesAnt.Size = new System.Drawing.Size(176, 29);
            this.txtSaldoMesAnt.TabIndex = 126;
            this.txtSaldoMesAnt.TablaOVistaBusqueda = "";
            this.txtSaldoMesAnt.Text = "0.00";
            this.txtSaldoMesAnt.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSaldoMesAnt.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSaldoMesAnt.ValorPorDefecto = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(415, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 21);
            this.label16.TabIndex = 125;
            this.label16.Text = "Saldo Mes Anterior:";
            // 
            // txtSaldoMes
            // 
            this.txtSaldoMes.AMostrar = null;
            this.txtSaldoMes.AValidar = null;
            this.txtSaldoMes.BackColor = System.Drawing.Color.White;
            this.txtSaldoMes.CampoBusquedaID = "";
            this.txtSaldoMes.CampoData = "";
            this.txtSaldoMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoMes.ColumnasBusqGeneral = null;
            this.txtSaldoMes.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSaldoMes.Decimales = 0;
            this.txtSaldoMes.DSData = null;
            this.txtSaldoMes.EsAutoGenerado = false;
            this.txtSaldoMes.EsBusqueda = false;
            this.txtSaldoMes.EsBusquedaAutoIncremental = false;
            this.txtSaldoMes.EsEditable = true;
            this.txtSaldoMes.FiltroBusqueda = "";
            this.txtSaldoMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoMes.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSaldoMes.Location = new System.Drawing.Point(588, 170);
            this.txtSaldoMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldoMes.Name = "txtSaldoMes";
            this.txtSaldoMes.NombreTabla = "";
            this.txtSaldoMes.ReadOnly = true;
            this.txtSaldoMes.SepDecimal = '\0';
            this.txtSaldoMes.Size = new System.Drawing.Size(176, 29);
            this.txtSaldoMes.TabIndex = 124;
            this.txtSaldoMes.TablaOVistaBusqueda = "";
            this.txtSaldoMes.Text = "0.00";
            this.txtSaldoMes.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSaldoMes.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSaldoMes.ValorPorDefecto = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(476, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 21);
            this.label13.TabIndex = 123;
            this.label13.Text = "Saldo Mes:";
            // 
            // txtCreditoMes
            // 
            this.txtCreditoMes.AMostrar = null;
            this.txtCreditoMes.AValidar = null;
            this.txtCreditoMes.BackColor = System.Drawing.Color.White;
            this.txtCreditoMes.CampoBusquedaID = "";
            this.txtCreditoMes.CampoData = "";
            this.txtCreditoMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreditoMes.ColumnasBusqGeneral = null;
            this.txtCreditoMes.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCreditoMes.Decimales = 0;
            this.txtCreditoMes.DSData = null;
            this.txtCreditoMes.EsAutoGenerado = false;
            this.txtCreditoMes.EsBusqueda = false;
            this.txtCreditoMes.EsBusquedaAutoIncremental = false;
            this.txtCreditoMes.EsEditable = true;
            this.txtCreditoMes.FiltroBusqueda = "";
            this.txtCreditoMes.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCreditoMes.Location = new System.Drawing.Point(588, 116);
            this.txtCreditoMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreditoMes.Name = "txtCreditoMes";
            this.txtCreditoMes.NombreTabla = "";
            this.txtCreditoMes.ReadOnly = true;
            this.txtCreditoMes.SepDecimal = '\0';
            this.txtCreditoMes.Size = new System.Drawing.Size(176, 29);
            this.txtCreditoMes.TabIndex = 122;
            this.txtCreditoMes.TablaOVistaBusqueda = "";
            this.txtCreditoMes.Text = "0.00";
            this.txtCreditoMes.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCreditoMes.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCreditoMes.ValorPorDefecto = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(464, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 21);
            this.label14.TabIndex = 121;
            this.label14.Text = "Credito Mes:";
            // 
            // txtDebitoMes
            // 
            this.txtDebitoMes.AMostrar = null;
            this.txtDebitoMes.AValidar = null;
            this.txtDebitoMes.BackColor = System.Drawing.Color.White;
            this.txtDebitoMes.CampoBusquedaID = "";
            this.txtDebitoMes.CampoData = "";
            this.txtDebitoMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebitoMes.ColumnasBusqGeneral = null;
            this.txtDebitoMes.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDebitoMes.Decimales = 0;
            this.txtDebitoMes.DSData = null;
            this.txtDebitoMes.EsAutoGenerado = false;
            this.txtDebitoMes.EsBusqueda = false;
            this.txtDebitoMes.EsBusquedaAutoIncremental = false;
            this.txtDebitoMes.EsEditable = true;
            this.txtDebitoMes.FiltroBusqueda = "";
            this.txtDebitoMes.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDebitoMes.Location = new System.Drawing.Point(588, 66);
            this.txtDebitoMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDebitoMes.Name = "txtDebitoMes";
            this.txtDebitoMes.NombreTabla = "";
            this.txtDebitoMes.ReadOnly = true;
            this.txtDebitoMes.SepDecimal = '\0';
            this.txtDebitoMes.Size = new System.Drawing.Size(176, 29);
            this.txtDebitoMes.TabIndex = 120;
            this.txtDebitoMes.TablaOVistaBusqueda = "";
            this.txtDebitoMes.Text = "0.00";
            this.txtDebitoMes.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDebitoMes.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDebitoMes.ValorPorDefecto = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(469, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 21);
            this.label15.TabIndex = 119;
            this.label15.Text = "Debito Mes:";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.AMostrar = null;
            this.txtSaldoActual.AValidar = null;
            this.txtSaldoActual.BackColor = System.Drawing.Color.White;
            this.txtSaldoActual.CampoBusquedaID = "";
            this.txtSaldoActual.CampoData = "";
            this.txtSaldoActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoActual.ColumnasBusqGeneral = null;
            this.txtSaldoActual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSaldoActual.Decimales = 0;
            this.txtSaldoActual.DSData = null;
            this.txtSaldoActual.EsAutoGenerado = false;
            this.txtSaldoActual.EsBusqueda = false;
            this.txtSaldoActual.EsBusquedaAutoIncremental = false;
            this.txtSaldoActual.EsEditable = true;
            this.txtSaldoActual.FiltroBusqueda = "";
            this.txtSaldoActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoActual.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSaldoActual.Location = new System.Drawing.Point(193, 170);
            this.txtSaldoActual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.NombreTabla = "";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.SepDecimal = '\0';
            this.txtSaldoActual.Size = new System.Drawing.Size(183, 29);
            this.txtSaldoActual.TabIndex = 118;
            this.txtSaldoActual.TablaOVistaBusqueda = "";
            this.txtSaldoActual.Text = "0.00";
            this.txtSaldoActual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSaldoActual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSaldoActual.ValorPorDefecto = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 21);
            this.label12.TabIndex = 117;
            this.label12.Text = "Saldo Actual:";
            // 
            // txtCreditoAcumulado
            // 
            this.txtCreditoAcumulado.AMostrar = null;
            this.txtCreditoAcumulado.AValidar = null;
            this.txtCreditoAcumulado.BackColor = System.Drawing.Color.White;
            this.txtCreditoAcumulado.CampoBusquedaID = "";
            this.txtCreditoAcumulado.CampoData = "";
            this.txtCreditoAcumulado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreditoAcumulado.ColumnasBusqGeneral = null;
            this.txtCreditoAcumulado.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCreditoAcumulado.Decimales = 0;
            this.txtCreditoAcumulado.DSData = null;
            this.txtCreditoAcumulado.EsAutoGenerado = false;
            this.txtCreditoAcumulado.EsBusqueda = false;
            this.txtCreditoAcumulado.EsBusquedaAutoIncremental = false;
            this.txtCreditoAcumulado.EsEditable = true;
            this.txtCreditoAcumulado.FiltroBusqueda = "";
            this.txtCreditoAcumulado.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCreditoAcumulado.Location = new System.Drawing.Point(193, 116);
            this.txtCreditoAcumulado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreditoAcumulado.Name = "txtCreditoAcumulado";
            this.txtCreditoAcumulado.NombreTabla = "";
            this.txtCreditoAcumulado.ReadOnly = true;
            this.txtCreditoAcumulado.SepDecimal = '\0';
            this.txtCreditoAcumulado.Size = new System.Drawing.Size(183, 29);
            this.txtCreditoAcumulado.TabIndex = 116;
            this.txtCreditoAcumulado.TablaOVistaBusqueda = "";
            this.txtCreditoAcumulado.Text = "0.00";
            this.txtCreditoAcumulado.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCreditoAcumulado.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCreditoAcumulado.ValorPorDefecto = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 21);
            this.label11.TabIndex = 115;
            this.label11.Text = "Crédito Acumulado:";
            // 
            // txtDebitoAcum
            // 
            this.txtDebitoAcum.AMostrar = null;
            this.txtDebitoAcum.AValidar = null;
            this.txtDebitoAcum.BackColor = System.Drawing.Color.White;
            this.txtDebitoAcum.CampoBusquedaID = "";
            this.txtDebitoAcum.CampoData = "";
            this.txtDebitoAcum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebitoAcum.ColumnasBusqGeneral = null;
            this.txtDebitoAcum.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDebitoAcum.Decimales = 0;
            this.txtDebitoAcum.DSData = null;
            this.txtDebitoAcum.EsAutoGenerado = false;
            this.txtDebitoAcum.EsBusqueda = false;
            this.txtDebitoAcum.EsBusquedaAutoIncremental = false;
            this.txtDebitoAcum.EsEditable = true;
            this.txtDebitoAcum.FiltroBusqueda = "";
            this.txtDebitoAcum.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDebitoAcum.Location = new System.Drawing.Point(193, 66);
            this.txtDebitoAcum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDebitoAcum.Name = "txtDebitoAcum";
            this.txtDebitoAcum.NombreTabla = "";
            this.txtDebitoAcum.ReadOnly = true;
            this.txtDebitoAcum.SepDecimal = '\0';
            this.txtDebitoAcum.Size = new System.Drawing.Size(183, 29);
            this.txtDebitoAcum.TabIndex = 114;
            this.txtDebitoAcum.TablaOVistaBusqueda = "";
            this.txtDebitoAcum.Text = "0.00";
            this.txtDebitoAcum.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDebitoAcum.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDebitoAcum.ValorPorDefecto = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 21);
            this.label10.TabIndex = 113;
            this.label10.Text = "Debito Acumulado:";
            // 
            // txtSaldoAnioAnt
            // 
            this.txtSaldoAnioAnt.AMostrar = null;
            this.txtSaldoAnioAnt.AValidar = null;
            this.txtSaldoAnioAnt.BackColor = System.Drawing.Color.White;
            this.txtSaldoAnioAnt.CampoBusquedaID = "";
            this.txtSaldoAnioAnt.CampoData = "";
            this.txtSaldoAnioAnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoAnioAnt.ColumnasBusqGeneral = null;
            this.txtSaldoAnioAnt.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtSaldoAnioAnt.Decimales = 0;
            this.txtSaldoAnioAnt.DSData = null;
            this.txtSaldoAnioAnt.EsAutoGenerado = false;
            this.txtSaldoAnioAnt.EsBusqueda = false;
            this.txtSaldoAnioAnt.EsBusquedaAutoIncremental = false;
            this.txtSaldoAnioAnt.EsEditable = true;
            this.txtSaldoAnioAnt.FiltroBusqueda = "";
            this.txtSaldoAnioAnt.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtSaldoAnioAnt.Location = new System.Drawing.Point(193, 16);
            this.txtSaldoAnioAnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaldoAnioAnt.Name = "txtSaldoAnioAnt";
            this.txtSaldoAnioAnt.NombreTabla = "";
            this.txtSaldoAnioAnt.ReadOnly = true;
            this.txtSaldoAnioAnt.SepDecimal = '\0';
            this.txtSaldoAnioAnt.Size = new System.Drawing.Size(183, 29);
            this.txtSaldoAnioAnt.TabIndex = 112;
            this.txtSaldoAnioAnt.TablaOVistaBusqueda = "";
            this.txtSaldoAnioAnt.Text = "0.00";
            this.txtSaldoAnioAnt.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtSaldoAnioAnt.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtSaldoAnioAnt.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 111;
            this.label6.Text = "Saldo Anio Anterior:";
            // 
            // btnBuscaCuenta
            // 
            this.btnBuscaCuenta.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnBuscaCuenta.Location = new System.Drawing.Point(353, 6);
            this.btnBuscaCuenta.Name = "btnBuscaCuenta";
            this.btnBuscaCuenta.Size = new System.Drawing.Size(42, 31);
            this.btnBuscaCuenta.TabIndex = 76;
            this.btnBuscaCuenta.UseVisualStyleBackColor = true;
            this.btnBuscaCuenta.Click += new System.EventHandler(this.btnBuscaCuenta_Click);
            // 
            // btnBuscarAuxiliar
            // 
            this.btnBuscarAuxiliar.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnBuscarAuxiliar.Location = new System.Drawing.Point(353, 40);
            this.btnBuscarAuxiliar.Name = "btnBuscarAuxiliar";
            this.btnBuscarAuxiliar.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarAuxiliar.TabIndex = 77;
            this.btnBuscarAuxiliar.UseVisualStyleBackColor = true;
            this.btnBuscarAuxiliar.Click += new System.EventHandler(this.btnBuscarAuxiliar_Click);
            // 
            // FormContaSaldoCuentaPorSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.panel1);
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormContaSaldoCuentaPorSucursal";
            this.Text = "CONSULTA SALDO POR CUENTA";
            this.Load += new System.EventHandler(this.FormContaSaldoCuentaPorSucursal_Load);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WinControl_ELR_NET.ELRTextBox txtCentroCosto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDescripcionCentroCosto;
        private System.Windows.Forms.Label lblDescripcionCuenta;
        private WinControl_ELR_NET.ELRTextBox txtAnio;
        private System.Windows.Forms.Label label18;
        private WinControl_ELR_NET.ELRCombobox cboMes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRTextBox txtSaldoMesAnt;
        private System.Windows.Forms.Label label16;
        private WinControl_ELR_NET.ELRTextBox txtSaldoMes;
        private System.Windows.Forms.Label label13;
        private WinControl_ELR_NET.ELRTextBox txtCreditoMes;
        private System.Windows.Forms.Label label14;
        private WinControl_ELR_NET.ELRTextBox txtDebitoMes;
        private System.Windows.Forms.Label label15;
        private WinControl_ELR_NET.ELRTextBox txtSaldoActual;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRTextBox txtCreditoAcumulado;
        private System.Windows.Forms.Label label11;
        private WinControl_ELR_NET.ELRTextBox txtDebitoAcum;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRTextBox txtSaldoAnioAnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarAuxiliar;
        private System.Windows.Forms.Button btnBuscaCuenta;
    }
}