namespace ELRBanco
{
    partial class FormConsCHK_DEP_Transito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCuentaBanco = new WinControl_ELR_NET.ELRCombobox();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsImpreso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.lblTotal = new WinControl_ELR_NET.ELRLabel();
            this.lblCuentaBancoNumero = new WinControl_ELR_NET.ELRLabel();
            this.lblCuentaContable = new WinControl_ELR_NET.ELRLabel();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.lblTotal);
            this.pnTotales.Controls.Add(this.txtConcepto);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 466);
            this.pnTotales.Size = new System.Drawing.Size(1037, 80);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtConcepto, 0);
            this.pnTotales.Controls.SetChildIndex(this.lblTotal, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.lblCuentaContable);
            this.pnBusqSencilla.Controls.Add(this.lblCuentaBancoNumero);
            this.pnBusqSencilla.Controls.Add(this.cboTipo);
            this.pnBusqSencilla.Controls.Add(this.elrLabel2);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.elrLabel1);
            this.pnBusqSencilla.Controls.Add(this.cboCuentaBanco);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 129);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboCuentaBanco, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrLabel1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.elrLabel2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboTipo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblCuentaBancoNumero, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblCuentaContable, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(746, 79);
            this.txtABuscar.Size = new System.Drawing.Size(112, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(391, 73);
            this.btnBuscar.Size = new System.Drawing.Size(138, 48);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.Text = "Cuenta Bancaria";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Size = new System.Drawing.Size(66, 24);
            this.lblCantidadRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 414);
            // 
            // cboCuentaBanco
            // 
            this.cboCuentaBanco.AValidar = null;
            this.cboCuentaBanco.CampoData = "";
            this.cboCuentaBanco.CampoJoinCombobox2 = "";
            this.cboCuentaBanco.ComboboxAFiltrar = null;
            this.cboCuentaBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaBanco.DSData = null;
            this.cboCuentaBanco.EsEditable = true;
            this.cboCuentaBanco.FiltroBusqueda = "";
            this.cboCuentaBanco.FormattingEnabled = true;
            this.cboCuentaBanco.Location = new System.Drawing.Point(156, 6);
            this.cboCuentaBanco.Name = "cboCuentaBanco";
            this.cboCuentaBanco.NombreTabla = "";
            this.cboCuentaBanco.Size = new System.Drawing.Size(373, 28);
            this.cboCuentaBanco.SSQL = "";
            this.cboCuentaBanco.TabIndex = 3;
            this.cboCuentaBanco.TablaOVistaConsulta = "";
            this.cboCuentaBanco.UsaDataGlobal = false;
            this.cboCuentaBanco.ValorPorDefecto = "0";
            this.cboCuentaBanco.SelectedValueChanged += new System.EventHandler(this.cboCuentaBanco_SelectedValueChanged);
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(14, 73);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(105, 20);
            this.elrLabel1.TabIndex = 4;
            this.elrLabel1.Text = "Hasta Fecha:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(156, 73);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(219, 26);
            this.dtpFecha1.TabIndex = 5;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 6, 11, 0, 0, 0, 0);
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(14, 40);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(133, 20);
            this.elrLabel2.TabIndex = 6;
            this.elrLabel2.Text = "Tipo Transaccion:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // cboTipo
            // 
            this.cboTipo.AValidar = null;
            this.cboTipo.CampoData = "";
            this.cboTipo.CampoJoinCombobox2 = "";
            this.cboTipo.ComboboxAFiltrar = null;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DSData = null;
            this.cboTipo.EsEditable = true;
            this.cboTipo.FiltroBusqueda = "";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "CHEQUES",
            "DEPOSITOS"});
            this.cboTipo.Location = new System.Drawing.Point(156, 40);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(373, 28);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 7;
            this.cboTipo.TablaOVistaConsulta = "";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Numero,
            this.Fecha,
            this.Beneficiario,
            this.Monto,
            this.EsImpreso,
            this.Concepto});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 285);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 115;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Beneficiario
            // 
            this.Beneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Beneficiario.DataPropertyName = "Beneficiario";
            this.Beneficiario.HeaderText = "Beneficiario";
            this.Beneficiario.Name = "Beneficiario";
            this.Beneficiario.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 125;
            // 
            // EsImpreso
            // 
            this.EsImpreso.DataPropertyName = "EsImpreso";
            this.EsImpreso.HeaderText = "Es Impreso";
            this.EsImpreso.Name = "EsImpreso";
            this.EsImpreso.ReadOnly = true;
            this.EsImpreso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsImpreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Visible = false;
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtConcepto.DSData = null;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(0, 0);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(788, 76);
            this.txtConcepto.TabIndex = 1;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // lblTotal
            // 
            this.lblTotal.CampoData = "";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.DSData = null;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(788, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.NombreTabla = "";
            this.lblTotal.Size = new System.Drawing.Size(245, 76);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.ValorPorDefecto = "";
            // 
            // lblCuentaBancoNumero
            // 
            this.lblCuentaBancoNumero.AutoSize = true;
            this.lblCuentaBancoNumero.CampoData = "";
            this.lblCuentaBancoNumero.DSData = null;
            this.lblCuentaBancoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaBancoNumero.Location = new System.Drawing.Point(547, 6);
            this.lblCuentaBancoNumero.Name = "lblCuentaBancoNumero";
            this.lblCuentaBancoNumero.NombreTabla = "";
            this.lblCuentaBancoNumero.Size = new System.Drawing.Size(269, 24);
            this.lblCuentaBancoNumero.TabIndex = 8;
            this.lblCuentaBancoNumero.Text = "Cuenta Banco No.: 0000000";
            this.lblCuentaBancoNumero.ValorPorDefecto = "";
            // 
            // lblCuentaContable
            // 
            this.lblCuentaContable.AutoSize = true;
            this.lblCuentaContable.CampoData = "";
            this.lblCuentaContable.DSData = null;
            this.lblCuentaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaContable.Location = new System.Drawing.Point(547, 36);
            this.lblCuentaContable.Name = "lblCuentaContable";
            this.lblCuentaContable.NombreTabla = "";
            this.lblCuentaContable.Size = new System.Drawing.Size(254, 24);
            this.lblCuentaContable.TabIndex = 9;
            this.lblCuentaContable.Text = "Cuenta Contable: 0000000";
            this.lblCuentaContable.ValorPorDefecto = "";
            // 
            // FormConsCHK_DEP_Transito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormConsCHK_DEP_Transito";
            this.Text = "CONSULTAR CHEQUES Y/O DEPOSITOS EN TRANSITO";
            this.Load += new System.EventHandler(this.FormConsCHK_DEP_Transito_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRCombobox cboCuentaBanco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsImpreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private WinControl_ELR_NET.ELRLabel lblTotal;
        private WinControl_ELR_NET.ELRLabel lblCuentaContable;
        private WinControl_ELR_NET.ELRLabel lblCuentaBancoNumero;
    }
}