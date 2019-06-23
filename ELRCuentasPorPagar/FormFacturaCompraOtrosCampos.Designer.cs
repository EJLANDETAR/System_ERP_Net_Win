namespace ELRCuentasPorPagar
{
    partial class FormFacturaCompraOtrosCampos
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
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoRet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetISR = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAPagar = new WinControl_ELR_NET.ELRLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItbisProp = new WinControl_ELR_NET.ELRTextBox();
            this.txtItbisCosto = new WinControl_ELR_NET.ELRTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItbisPorAdelantar = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItbisPercibido = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtISRPercibido = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImpSel = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOtrosImpuestos = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPropinaLegal = new WinControl_ELR_NET.ELRTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(237, 0);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(141, 52);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(378, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 52);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoRet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRetISR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRetItbis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retenciones";
            // 
            // cboTipoRet
            // 
            this.cboTipoRet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRet.DropDownWidth = 550;
            this.cboTipoRet.FormattingEnabled = true;
            this.cboTipoRet.Location = new System.Drawing.Point(81, 67);
            this.cboTipoRet.Name = "cboTipoRet";
            this.cboTipoRet.Size = new System.Drawing.Size(427, 31);
            this.cboTipoRet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // txtRetISR
            // 
            this.txtRetISR.AMostrar = null;
            this.txtRetISR.AValidar = null;
            this.txtRetISR.CampoBusquedaID = "";
            this.txtRetISR.CampoData = "";
            this.txtRetISR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetISR.ColumnasBusqGeneral = null;
            this.txtRetISR.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtRetISR.Decimales = 2;
            this.txtRetISR.DSData = null;
            this.txtRetISR.EsAutoGenerado = false;
            this.txtRetISR.EsBusqueda = false;
            this.txtRetISR.EsBusquedaAutoIncremental = false;
            this.txtRetISR.EsEditable = true;
            this.txtRetISR.FiltroBusqueda = "";
            this.txtRetISR.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtRetISR.Location = new System.Drawing.Point(345, 29);
            this.txtRetISR.Name = "txtRetISR";
            this.txtRetISR.NombreTabla = "";
            this.txtRetISR.SepDecimal = '\0';
            this.txtRetISR.Size = new System.Drawing.Size(163, 30);
            this.txtRetISR.TabIndex = 3;
            this.txtRetISR.TablaOVistaBusqueda = "";
            this.txtRetISR.Text = "0.00";
            this.txtRetISR.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtRetISR.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtRetISR.ValorPorDefecto = "";
            this.txtRetISR.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISR:";
            // 
            // txtRetItbis
            // 
            this.txtRetItbis.AMostrar = null;
            this.txtRetItbis.AValidar = null;
            this.txtRetItbis.CampoBusquedaID = "";
            this.txtRetItbis.CampoData = "";
            this.txtRetItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetItbis.ColumnasBusqGeneral = null;
            this.txtRetItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtRetItbis.Decimales = 2;
            this.txtRetItbis.DSData = null;
            this.txtRetItbis.EsAutoGenerado = false;
            this.txtRetItbis.EsBusqueda = false;
            this.txtRetItbis.EsBusquedaAutoIncremental = false;
            this.txtRetItbis.EsEditable = true;
            this.txtRetItbis.FiltroBusqueda = "";
            this.txtRetItbis.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtRetItbis.Location = new System.Drawing.Point(81, 29);
            this.txtRetItbis.Name = "txtRetItbis";
            this.txtRetItbis.NombreTabla = "";
            this.txtRetItbis.SepDecimal = '\0';
            this.txtRetItbis.Size = new System.Drawing.Size(157, 30);
            this.txtRetItbis.TabIndex = 1;
            this.txtRetItbis.TablaOVistaBusqueda = "";
            this.txtRetItbis.Text = "0.00";
            this.txtRetItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtRetItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtRetItbis.ValorPorDefecto = "";
            this.txtRetItbis.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itbis:";
            // 
            // lblAPagar
            // 
            this.lblAPagar.BackColor = System.Drawing.Color.Black;
            this.lblAPagar.CampoData = "";
            this.lblAPagar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAPagar.DSData = null;
            this.lblAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPagar.ForeColor = System.Drawing.Color.Lime;
            this.lblAPagar.Location = new System.Drawing.Point(0, 416);
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.NombreTabla = "";
            this.lblAPagar.Size = new System.Drawing.Size(523, 75);
            this.lblAPagar.TabIndex = 6;
            this.lblAPagar.Text = "A Pagar: 999,999,999.00";
            this.lblAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAPagar.ValorPorDefecto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Itbis Proporcionalidad:";
            // 
            // txtItbisProp
            // 
            this.txtItbisProp.AMostrar = null;
            this.txtItbisProp.AValidar = null;
            this.txtItbisProp.CampoBusquedaID = "";
            this.txtItbisProp.CampoData = "";
            this.txtItbisProp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItbisProp.ColumnasBusqGeneral = null;
            this.txtItbisProp.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtItbisProp.Decimales = 2;
            this.txtItbisProp.DSData = null;
            this.txtItbisProp.EsAutoGenerado = false;
            this.txtItbisProp.EsBusqueda = false;
            this.txtItbisProp.EsBusquedaAutoIncremental = false;
            this.txtItbisProp.EsEditable = true;
            this.txtItbisProp.FiltroBusqueda = "";
            this.txtItbisProp.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtItbisProp.Location = new System.Drawing.Point(298, 115);
            this.txtItbisProp.Name = "txtItbisProp";
            this.txtItbisProp.NombreTabla = "";
            this.txtItbisProp.SepDecimal = '\0';
            this.txtItbisProp.Size = new System.Drawing.Size(210, 30);
            this.txtItbisProp.TabIndex = 8;
            this.txtItbisProp.TablaOVistaBusqueda = "";
            this.txtItbisProp.Text = "0.00";
            this.txtItbisProp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItbisProp.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtItbisProp.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtItbisProp.ValorPorDefecto = "";
            this.txtItbisProp.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // txtItbisCosto
            // 
            this.txtItbisCosto.AMostrar = null;
            this.txtItbisCosto.AValidar = null;
            this.txtItbisCosto.CampoBusquedaID = "";
            this.txtItbisCosto.CampoData = "";
            this.txtItbisCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItbisCosto.ColumnasBusqGeneral = null;
            this.txtItbisCosto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtItbisCosto.Decimales = 2;
            this.txtItbisCosto.DSData = null;
            this.txtItbisCosto.EsAutoGenerado = false;
            this.txtItbisCosto.EsBusqueda = false;
            this.txtItbisCosto.EsBusquedaAutoIncremental = false;
            this.txtItbisCosto.EsEditable = true;
            this.txtItbisCosto.FiltroBusqueda = "";
            this.txtItbisCosto.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtItbisCosto.Location = new System.Drawing.Point(298, 151);
            this.txtItbisCosto.Name = "txtItbisCosto";
            this.txtItbisCosto.NombreTabla = "";
            this.txtItbisCosto.SepDecimal = '\0';
            this.txtItbisCosto.Size = new System.Drawing.Size(210, 30);
            this.txtItbisCosto.TabIndex = 10;
            this.txtItbisCosto.TablaOVistaBusqueda = "";
            this.txtItbisCosto.Text = "0.00";
            this.txtItbisCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItbisCosto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtItbisCosto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtItbisCosto.ValorPorDefecto = "";
            this.txtItbisCosto.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Itbis llevado al costo:";
            // 
            // txtItbisPorAdelantar
            // 
            this.txtItbisPorAdelantar.AMostrar = null;
            this.txtItbisPorAdelantar.AValidar = null;
            this.txtItbisPorAdelantar.CampoBusquedaID = "";
            this.txtItbisPorAdelantar.CampoData = "";
            this.txtItbisPorAdelantar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItbisPorAdelantar.ColumnasBusqGeneral = null;
            this.txtItbisPorAdelantar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtItbisPorAdelantar.Decimales = 2;
            this.txtItbisPorAdelantar.DSData = null;
            this.txtItbisPorAdelantar.EsAutoGenerado = false;
            this.txtItbisPorAdelantar.EsBusqueda = false;
            this.txtItbisPorAdelantar.EsBusquedaAutoIncremental = false;
            this.txtItbisPorAdelantar.EsEditable = true;
            this.txtItbisPorAdelantar.FiltroBusqueda = "";
            this.txtItbisPorAdelantar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItbisPorAdelantar.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtItbisPorAdelantar.Location = new System.Drawing.Point(298, 187);
            this.txtItbisPorAdelantar.Name = "txtItbisPorAdelantar";
            this.txtItbisPorAdelantar.NombreTabla = "";
            this.txtItbisPorAdelantar.ReadOnly = true;
            this.txtItbisPorAdelantar.SepDecimal = '\0';
            this.txtItbisPorAdelantar.Size = new System.Drawing.Size(210, 30);
            this.txtItbisPorAdelantar.TabIndex = 12;
            this.txtItbisPorAdelantar.TablaOVistaBusqueda = "";
            this.txtItbisPorAdelantar.Text = "0.00";
            this.txtItbisPorAdelantar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItbisPorAdelantar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtItbisPorAdelantar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtItbisPorAdelantar.ValorPorDefecto = "";
            this.txtItbisPorAdelantar.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Itbis Por Adelantar:";
            // 
            // txtItbisPercibido
            // 
            this.txtItbisPercibido.AMostrar = null;
            this.txtItbisPercibido.AValidar = null;
            this.txtItbisPercibido.CampoBusquedaID = "";
            this.txtItbisPercibido.CampoData = "";
            this.txtItbisPercibido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItbisPercibido.ColumnasBusqGeneral = null;
            this.txtItbisPercibido.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtItbisPercibido.Decimales = 2;
            this.txtItbisPercibido.DSData = null;
            this.txtItbisPercibido.EsAutoGenerado = false;
            this.txtItbisPercibido.EsBusqueda = false;
            this.txtItbisPercibido.EsBusquedaAutoIncremental = false;
            this.txtItbisPercibido.EsEditable = true;
            this.txtItbisPercibido.FiltroBusqueda = "";
            this.txtItbisPercibido.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtItbisPercibido.Location = new System.Drawing.Point(298, 223);
            this.txtItbisPercibido.Name = "txtItbisPercibido";
            this.txtItbisPercibido.NombreTabla = "";
            this.txtItbisPercibido.SepDecimal = '\0';
            this.txtItbisPercibido.Size = new System.Drawing.Size(210, 30);
            this.txtItbisPercibido.TabIndex = 14;
            this.txtItbisPercibido.TablaOVistaBusqueda = "";
            this.txtItbisPercibido.Text = "0.00";
            this.txtItbisPercibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItbisPercibido.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtItbisPercibido.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtItbisPercibido.ValorPorDefecto = "";
            this.txtItbisPercibido.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Itbis Percibido:";
            // 
            // txtISRPercibido
            // 
            this.txtISRPercibido.AMostrar = null;
            this.txtISRPercibido.AValidar = null;
            this.txtISRPercibido.CampoBusquedaID = "";
            this.txtISRPercibido.CampoData = "";
            this.txtISRPercibido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtISRPercibido.ColumnasBusqGeneral = null;
            this.txtISRPercibido.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtISRPercibido.Decimales = 2;
            this.txtISRPercibido.DSData = null;
            this.txtISRPercibido.EsAutoGenerado = false;
            this.txtISRPercibido.EsBusqueda = false;
            this.txtISRPercibido.EsBusquedaAutoIncremental = false;
            this.txtISRPercibido.EsEditable = true;
            this.txtISRPercibido.FiltroBusqueda = "";
            this.txtISRPercibido.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtISRPercibido.Location = new System.Drawing.Point(298, 259);
            this.txtISRPercibido.Name = "txtISRPercibido";
            this.txtISRPercibido.NombreTabla = "";
            this.txtISRPercibido.SepDecimal = '\0';
            this.txtISRPercibido.Size = new System.Drawing.Size(210, 30);
            this.txtISRPercibido.TabIndex = 16;
            this.txtISRPercibido.TablaOVistaBusqueda = "";
            this.txtISRPercibido.Text = "0.00";
            this.txtISRPercibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtISRPercibido.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtISRPercibido.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtISRPercibido.ValorPorDefecto = "";
            this.txtISRPercibido.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "ISR Percibido:";
            // 
            // txtImpSel
            // 
            this.txtImpSel.AMostrar = null;
            this.txtImpSel.AValidar = null;
            this.txtImpSel.CampoBusquedaID = "";
            this.txtImpSel.CampoData = "";
            this.txtImpSel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImpSel.ColumnasBusqGeneral = null;
            this.txtImpSel.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtImpSel.Decimales = 2;
            this.txtImpSel.DSData = null;
            this.txtImpSel.EsAutoGenerado = false;
            this.txtImpSel.EsBusqueda = false;
            this.txtImpSel.EsBusquedaAutoIncremental = false;
            this.txtImpSel.EsEditable = true;
            this.txtImpSel.FiltroBusqueda = "";
            this.txtImpSel.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtImpSel.Location = new System.Drawing.Point(298, 295);
            this.txtImpSel.Name = "txtImpSel";
            this.txtImpSel.NombreTabla = "";
            this.txtImpSel.SepDecimal = '\0';
            this.txtImpSel.Size = new System.Drawing.Size(210, 30);
            this.txtImpSel.TabIndex = 18;
            this.txtImpSel.TablaOVistaBusqueda = "";
            this.txtImpSel.Text = "0.00";
            this.txtImpSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpSel.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtImpSel.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtImpSel.ValorPorDefecto = "";
            this.txtImpSel.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Imp. Selectivo al consumo:";
            // 
            // txtOtrosImpuestos
            // 
            this.txtOtrosImpuestos.AMostrar = null;
            this.txtOtrosImpuestos.AValidar = null;
            this.txtOtrosImpuestos.CampoBusquedaID = "";
            this.txtOtrosImpuestos.CampoData = "";
            this.txtOtrosImpuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtrosImpuestos.ColumnasBusqGeneral = null;
            this.txtOtrosImpuestos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtOtrosImpuestos.Decimales = 2;
            this.txtOtrosImpuestos.DSData = null;
            this.txtOtrosImpuestos.EsAutoGenerado = false;
            this.txtOtrosImpuestos.EsBusqueda = false;
            this.txtOtrosImpuestos.EsBusquedaAutoIncremental = false;
            this.txtOtrosImpuestos.EsEditable = true;
            this.txtOtrosImpuestos.FiltroBusqueda = "";
            this.txtOtrosImpuestos.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtOtrosImpuestos.Location = new System.Drawing.Point(298, 368);
            this.txtOtrosImpuestos.Name = "txtOtrosImpuestos";
            this.txtOtrosImpuestos.NombreTabla = "";
            this.txtOtrosImpuestos.SepDecimal = '\0';
            this.txtOtrosImpuestos.Size = new System.Drawing.Size(210, 30);
            this.txtOtrosImpuestos.TabIndex = 20;
            this.txtOtrosImpuestos.TablaOVistaBusqueda = "";
            this.txtOtrosImpuestos.Text = "0.00";
            this.txtOtrosImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtrosImpuestos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtOtrosImpuestos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtOtrosImpuestos.ValorPorDefecto = "";
            this.txtOtrosImpuestos.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Otros Impuesto:";
            // 
            // txtPropinaLegal
            // 
            this.txtPropinaLegal.AMostrar = null;
            this.txtPropinaLegal.AValidar = null;
            this.txtPropinaLegal.CampoBusquedaID = "";
            this.txtPropinaLegal.CampoData = "";
            this.txtPropinaLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPropinaLegal.ColumnasBusqGeneral = null;
            this.txtPropinaLegal.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPropinaLegal.Decimales = 2;
            this.txtPropinaLegal.DSData = null;
            this.txtPropinaLegal.EsAutoGenerado = false;
            this.txtPropinaLegal.EsBusqueda = false;
            this.txtPropinaLegal.EsBusquedaAutoIncremental = false;
            this.txtPropinaLegal.EsEditable = true;
            this.txtPropinaLegal.FiltroBusqueda = "";
            this.txtPropinaLegal.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPropinaLegal.Location = new System.Drawing.Point(298, 332);
            this.txtPropinaLegal.Name = "txtPropinaLegal";
            this.txtPropinaLegal.NombreTabla = "";
            this.txtPropinaLegal.SepDecimal = '\0';
            this.txtPropinaLegal.Size = new System.Drawing.Size(210, 30);
            this.txtPropinaLegal.TabIndex = 22;
            this.txtPropinaLegal.TablaOVistaBusqueda = "";
            this.txtPropinaLegal.Text = "0.00";
            this.txtPropinaLegal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPropinaLegal.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPropinaLegal.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPropinaLegal.ValorPorDefecto = "";
            this.txtPropinaLegal.Leave += new System.EventHandler(this.txtRetItbis_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Propina legal:";
            // 
            // FormFacturaCompraOtrosCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 547);
            this.Controls.Add(this.txtPropinaLegal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOtrosImpuestos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtImpSel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtISRPercibido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItbisPercibido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItbisPorAdelantar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItbisCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItbisProp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAPagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacturaCompraOtrosCampos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "0.00";
            this.Load += new System.EventHandler(this.FormFacturaCompraOtrosCampos_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtRetItbis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoRet;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtRetISR;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRLabel lblAPagar;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtItbisProp;
        private WinControl_ELR_NET.ELRTextBox txtItbisCosto;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRTextBox txtItbisPorAdelantar;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtItbisPercibido;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtISRPercibido;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRTextBox txtImpSel;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRTextBox txtOtrosImpuestos;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRTextBox txtPropinaLegal;
        private System.Windows.Forms.Label label11;
    }
}