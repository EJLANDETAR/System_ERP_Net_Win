namespace ELRBanco
{
    partial class FormImprimirCheques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboImpresora = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtProxNumero = new WinControl_ELR_NET.ELRTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new WinControl_ELR_NET.ELRTextBox();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trans_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsImpreso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtConcepto);
            this.pnTotales.Location = new System.Drawing.Point(0, 483);
            this.pnTotales.Size = new System.Drawing.Size(1030, 63);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtConcepto, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.txtCantidad);
            this.pnBusqSencilla.Controls.Add(this.label12);
            this.pnBusqSencilla.Controls.Add(this.txtProxNumero);
            this.pnBusqSencilla.Controls.Add(this.btnImprimir);
            this.pnBusqSencilla.Controls.Add(this.label10);
            this.pnBusqSencilla.Controls.Add(this.cboImpresora);
            this.pnBusqSencilla.Controls.Add(this.label9);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.cboCuenta);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1016, 139);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label9, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboImpresora, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label10, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnImprimir, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtProxNumero, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label12, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCantidad, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(135, 77);
            this.txtABuscar.Size = new System.Drawing.Size(532, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(548, 11);
            this.btnBuscar.Size = new System.Drawing.Size(119, 60);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 77);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 431);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(402, 45);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(135, 45);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(140, 26);
            this.dtpFecha1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha Desde:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.DisplayMember = "Nombre";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(135, 11);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(407, 28);
            this.cboCuenta.TabIndex = 18;
            this.cboCuenta.ValueMember = "Cuenta_Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Trans_Id,
            this.Numero,
            this.Beneficiario,
            this.Monto,
            this.Estatus,
            this.EsImpreso,
            this.Concepto,
            this.clnImprimir});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 292);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cuenta:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(0, 0);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.Size = new System.Drawing.Size(1026, 59);
            this.txtConcepto.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Impresora:";
            // 
            // cboImpresora
            // 
            this.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora.FormattingEnabled = true;
            this.cboImpresora.Location = new System.Drawing.Point(686, 34);
            this.cboImpresora.Name = "cboImpresora";
            this.cboImpresora.Size = new System.Drawing.Size(298, 28);
            this.cboImpresora.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Numero:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::ELRBanco.Properties.Resources.print;
            this.btnImprimir.Location = new System.Drawing.Point(863, 71);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 59);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtProxNumero
            // 
            this.txtProxNumero.AMostrar = null;
            this.txtProxNumero.AValidar = null;
            this.txtProxNumero.CampoBusquedaID = "";
            this.txtProxNumero.CampoData = "";
            this.txtProxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProxNumero.ColumnasBusqGeneral = null;
            this.txtProxNumero.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtProxNumero.Decimales = 0;
            this.txtProxNumero.DSData = null;
            this.txtProxNumero.EsAutoGenerado = false;
            this.txtProxNumero.EsBusqueda = false;
            this.txtProxNumero.EsBusquedaAutoIncremental = false;
            this.txtProxNumero.EsEditable = true;
            this.txtProxNumero.FiltroBusqueda = "";
            this.txtProxNumero.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtProxNumero.Location = new System.Drawing.Point(757, 73);
            this.txtProxNumero.Name = "txtProxNumero";
            this.txtProxNumero.NombreTabla = "";
            this.txtProxNumero.SepDecimal = '\0';
            this.txtProxNumero.Size = new System.Drawing.Size(100, 26);
            this.txtProxNumero.TabIndex = 29;
            this.txtProxNumero.TablaOVistaBusqueda = "";
            this.txtProxNumero.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtProxNumero.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtProxNumero.ValorPorDefecto = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AMostrar = null;
            this.txtCantidad.AValidar = null;
            this.txtCantidad.CampoBusquedaID = "";
            this.txtCantidad.CampoData = "";
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.ColumnasBusqGeneral = null;
            this.txtCantidad.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCantidad.Decimales = 0;
            this.txtCantidad.DSData = null;
            this.txtCantidad.EsAutoGenerado = false;
            this.txtCantidad.EsBusqueda = false;
            this.txtCantidad.EsBusquedaAutoIncremental = false;
            this.txtCantidad.EsEditable = true;
            this.txtCantidad.FiltroBusqueda = "";
            this.txtCantidad.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtCantidad.Location = new System.Drawing.Point(757, 104);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.NombreTabla = "";
            this.txtCantidad.SepDecimal = '\0';
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 32;
            this.txtCantidad.TablaOVistaBusqueda = "";
            this.txtCantidad.Text = "0";
            this.txtCantidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCantidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCantidad.ValorPorDefecto = "";
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Trans_Id
            // 
            this.Trans_Id.DataPropertyName = "Trans_Id";
            this.Trans_Id.HeaderText = "Id";
            this.Trans_Id.Name = "Trans_Id";
            this.Trans_Id.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 115;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 135;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 200;
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
            // clnImprimir
            // 
            this.clnImprimir.HeaderText = "Imprimir";
            this.clnImprimir.Name = "clnImprimir";
            this.clnImprimir.ReadOnly = true;
            this.clnImprimir.Text = "Imprimir";
            this.clnImprimir.ToolTipText = "Imprimir cheque Individual";
            this.clnImprimir.UseColumnTextForButtonValue = true;
            // 
            // FormImprimirCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Trans_Id";
            this.ClientSize = new System.Drawing.Size(1030, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.FiltroEstatico = "EsNulo = 0 And EsImpreso = 0 And (Tipo = \'CK\' Or Tipo = \'CHK\') ";
            this.Limite = -1;
            this.Name = "FormImprimirCheques";
            this.NombreCampoID = "Trans_Id";
            this.TablaOVista = "TBANCOS_TRANS";
            this.Text = "BANCO IMPRIMIR CHEQUES";
            this.Load += new System.EventHandler(this.FormImprimirCheques_Load);
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
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboImpresora;
        private System.Windows.Forms.Label label9;
        private WinControl_ELR_NET.ELRTextBox txtProxNumero;
        private System.Windows.Forms.Label label12;
        private WinControl_ELR_NET.ELRTextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trans_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsImpreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewButtonColumn clnImprimir;
    }
}