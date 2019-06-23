namespace ELRCuentasPorPagar
{
    partial class FormOpeCXP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImpFactura = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImpListado = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtABuscar = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipo = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFeHasta = new WinControl_ELR_NET.ELRDatePicker();
            this.dtpFeDesde = new WinControl_ELR_NET.ELRDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF_AModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_APagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CXP_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 466);
            this.pnBotones.Size = new System.Drawing.Size(992, 51);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(716, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(857, 0);
            this.btnCancelar.Size = new System.Drawing.Size(131, 47);
            this.btnCancelar.Text = "&Cerrar";
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(621, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(526, 47);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtABuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFeHasta);
            this.panel1.Controls.Add(this.dtpFeDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 189);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnImpFactura);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnImpListado);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 60);
            this.panel2.TabIndex = 7;
            // 
            // btnImpFactura
            // 
            this.btnImpFactura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImpFactura.Enabled = false;
            this.btnImpFactura.Location = new System.Drawing.Point(393, 0);
            this.btnImpFactura.Name = "btnImpFactura";
            this.btnImpFactura.Size = new System.Drawing.Size(131, 56);
            this.btnImpFactura.TabIndex = 3;
            this.btnImpFactura.Text = "Imprimir Factura";
            this.btnImpFactura.UseVisualStyleBackColor = true;
            this.btnImpFactura.Click += new System.EventHandler(this.btnImpFactura_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcel.Enabled = false;
            this.btnExcel.Location = new System.Drawing.Point(262, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(131, 56);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Exportar  a  Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImpListado
            // 
            this.btnImpListado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImpListado.Enabled = false;
            this.btnImpListado.Location = new System.Drawing.Point(131, 0);
            this.btnImpListado.Name = "btnImpListado";
            this.btnImpListado.Size = new System.Drawing.Size(131, 56);
            this.btnImpListado.TabIndex = 1;
            this.btnImpListado.Text = "Imprimir Listado";
            this.btnImpListado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 56);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtABuscar
            // 
            this.txtABuscar.AMostrar = null;
            this.txtABuscar.autoSenTab = true;
            this.txtABuscar.AValidar = null;
            this.txtABuscar.CampoBusquedaID = "";
            this.txtABuscar.CampoData = "";
            this.txtABuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtABuscar.ColumnasBusqGeneral = null;
            this.txtABuscar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.Decimales = 0;
            this.txtABuscar.DSData = null;
            this.txtABuscar.EsAutoGenerado = false;
            this.txtABuscar.EsBusqueda = false;
            this.txtABuscar.EsBusquedaAutoIncremental = false;
            this.txtABuscar.EsEditable = true;
            this.txtABuscar.FiltroBusqueda = "";
            this.txtABuscar.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtABuscar.Location = new System.Drawing.Point(139, 82);
            this.txtABuscar.Name = "txtABuscar";
            this.txtABuscar.NombreTabla = "";
            this.txtABuscar.SepDecimal = '\0';
            this.txtABuscar.Size = new System.Drawing.Size(532, 29);
            this.txtABuscar.TabIndex = 6;
            this.txtABuscar.TablaOVistaBusqueda = "";
            this.txtABuscar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtABuscar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtABuscar.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "A Buscar:";
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
            this.cboTipo.Location = new System.Drawing.Point(139, 47);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.NombreTabla = "";
            this.cboTipo.Size = new System.Drawing.Size(532, 29);
            this.cboTipo.SSQL = "";
            this.cboTipo.TabIndex = 4;
            this.cboTipo.TablaOVistaConsulta = "";
            this.cboTipo.UsaDataGlobal = false;
            this.cboTipo.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por Tipo:";
            // 
            // dtpFeHasta
            // 
            this.dtpFeHasta.AValidar = null;
            this.dtpFeHasta.CampoData = "";
            this.dtpFeHasta.DSData = null;
            this.dtpFeHasta.EsEditable = true;
            this.dtpFeHasta.FiltroBusqueda = "";
            this.dtpFeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeHasta.Location = new System.Drawing.Point(395, 10);
            this.dtpFeHasta.Name = "dtpFeHasta";
            this.dtpFeHasta.NombreTabla = "";
            this.dtpFeHasta.Size = new System.Drawing.Size(200, 29);
            this.dtpFeHasta.TabIndex = 2;
            this.dtpFeHasta.ValorPorDefecto = new System.DateTime(2018, 7, 9, 0, 0, 0, 0);
            // 
            // dtpFeDesde
            // 
            this.dtpFeDesde.AValidar = null;
            this.dtpFeDesde.CampoData = "";
            this.dtpFeDesde.DSData = null;
            this.dtpFeDesde.EsEditable = true;
            this.dtpFeDesde.FiltroBusqueda = "";
            this.dtpFeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeDesde.Location = new System.Drawing.Point(139, 10);
            this.dtpFeDesde.Name = "dtpFeDesde";
            this.dtpFeDesde.NombreTabla = "";
            this.dtpFeDesde.Size = new System.Drawing.Size(181, 29);
            this.dtpFeDesde.TabIndex = 1;
            this.dtpFeDesde.ValorPorDefecto = new System.DateTime(2018, 7, 9, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "En rango fechas:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 76);
            this.panel3.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(988, 72);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: 0.00                         APagar P.: 0.00     ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.FactNumero,
            this.NCF,
            this.NCF_AModificar,
            this.Fecha_Factura,
            this.Total,
            this.TotalRet,
            this.Monto_APagar,
            this.Monto_Pendiente,
            this.CXP_Id,
            this.CedulaRNC,
            this.Nombre});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 189);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.Size = new System.Drawing.Size(992, 201);
            this.dtgDetalle.TabIndex = 6;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // FactNumero
            // 
            this.FactNumero.DataPropertyName = "Factura_Numero";
            this.FactNumero.HeaderText = "Numero";
            this.FactNumero.Name = "FactNumero";
            this.FactNumero.ReadOnly = true;
            this.FactNumero.Width = 160;
            // 
            // NCF
            // 
            this.NCF.DataPropertyName = "NCF";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF.DefaultCellStyle = dataGridViewCellStyle1;
            this.NCF.HeaderText = "NCF";
            this.NCF.Name = "NCF";
            this.NCF.ReadOnly = true;
            this.NCF.Width = 150;
            // 
            // NCF_AModificar
            // 
            this.NCF_AModificar.DataPropertyName = "NCF_AModificar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF_AModificar.DefaultCellStyle = dataGridViewCellStyle2;
            this.NCF_AModificar.HeaderText = "NCF Mod.";
            this.NCF_AModificar.Name = "NCF_AModificar";
            this.NCF_AModificar.ReadOnly = true;
            this.NCF_AModificar.Width = 150;
            // 
            // Fecha_Factura
            // 
            this.Fecha_Factura.DataPropertyName = "Factura_Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Fecha_Factura.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha_Factura.HeaderText = "Fecha Doc.";
            this.Fecha_Factura.Name = "Fecha_Factura";
            this.Fecha_Factura.ReadOnly = true;
            this.Fecha_Factura.Width = 120;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 165;
            // 
            // TotalRet
            // 
            this.TotalRet.DataPropertyName = "TotalRet";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.TotalRet.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalRet.HeaderText = "- Ret";
            this.TotalRet.Name = "TotalRet";
            this.TotalRet.ReadOnly = true;
            this.TotalRet.Width = 165;
            // 
            // Monto_APagar
            // 
            this.Monto_APagar.DataPropertyName = "Monto_APagar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Monto_APagar.DefaultCellStyle = dataGridViewCellStyle6;
            this.Monto_APagar.HeaderText = "APagar";
            this.Monto_APagar.Name = "Monto_APagar";
            this.Monto_APagar.ReadOnly = true;
            this.Monto_APagar.Visible = false;
            this.Monto_APagar.Width = 165;
            // 
            // Monto_Pendiente
            // 
            this.Monto_Pendiente.DataPropertyName = "Monto_Pendiente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Monto_Pendiente.DefaultCellStyle = dataGridViewCellStyle7;
            this.Monto_Pendiente.HeaderText = "A Pagar P.";
            this.Monto_Pendiente.Name = "Monto_Pendiente";
            this.Monto_Pendiente.ReadOnly = true;
            this.Monto_Pendiente.Width = 165;
            // 
            // CXP_Id
            // 
            this.CXP_Id.DataPropertyName = "CXP_Id";
            this.CXP_Id.HeaderText = "CXP_Id";
            this.CXP_Id.Name = "CXP_Id";
            this.CXP_Id.ReadOnly = true;
            this.CXP_Id.Visible = false;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 140;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Beneficiario\\Suplidor";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FormOpeCXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 517);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.Name = "FormOpeCXP";
            this.Text = "OPERACIONES:  COMPRAS, GASTOS MENORES, PAGO GASTOS FIJOS, RETENCIONES";
            this.Load += new System.EventHandler(this.FormOpeCXP_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRDatePicker dtpFeHasta;
        private WinControl_ELR_NET.ELRDatePicker dtpFeDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImpFactura;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnImpListado;
        private System.Windows.Forms.Button btnBuscar;
        private WinControl_ELR_NET.ELRTextBox txtABuscar;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF_AModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_APagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CXP_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}