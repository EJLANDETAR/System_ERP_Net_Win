namespace ELRConsultasReportes
{
    partial class FormReporteDGII607
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtg607 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF_Modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblConteo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new WinControl_ELR_NET.ELRTextBox();
            this.btnResumenFC = new System.Windows.Forms.Button();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg607)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.groupBox1);
            this.pnTotales.Controls.Add(this.panel2);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 440);
            this.pnTotales.Size = new System.Drawing.Size(1096, 106);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.panel2, 0);
            this.pnTotales.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnResumenFC);
            this.pnBusqSencilla.Controls.Add(this.btnGenerar);
            this.pnBusqSencilla.Controls.Add(this.panel1);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1082, 56);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.panel1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnGenerar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnResumenFC, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(911, 40);
            this.txtABuscar.Size = new System.Drawing.Size(71, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(911, 6);
            this.btnBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(959, 16);
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.Text = "Desde Fecha:";
            this.label1.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Location = new System.Drawing.Point(87, 20);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(46, 18);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 388);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.elrLabel2);
            this.panel1.Controls.Add(this.dtpFecha2);
            this.panel1.Controls.Add(this.elrLabel1);
            this.panel1.Controls.Add(this.dtpFecha1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 52);
            this.panel1.TabIndex = 7;
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(8, 10);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(118, 20);
            this.elrLabel2.TabIndex = 11;
            this.elrLabel2.Text = "Rango Fechas:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(300, 12);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(137, 26);
            this.dtpFecha2.TabIndex = 10;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2016, 11, 29, 0, 0, 0, 0);
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(280, 16);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(14, 20);
            this.elrLabel1.TabIndex = 9;
            this.elrLabel1.Text = "-";
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
            this.dtpFecha1.Location = new System.Drawing.Point(138, 12);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(136, 26);
            this.dtpFecha1.TabIndex = 8;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2016, 11, 29, 0, 0, 0, 0);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar.Location = new System.Drawing.Point(472, 0);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(179, 52);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Buscar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtg607
            // 
            this.dtg607.AllowUserToAddRows = false;
            this.dtg607.AllowUserToDeleteRows = false;
            this.dtg607.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg607.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.CedulaRNC,
            this.Tipo_Identificacion,
            this.NCF,
            this.NCF_Modificado,
            this.Fecha_Comprobante,
            this.Itbis,
            this.Monto,
            this.Estatus});
            this.dtg607.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg607.Location = new System.Drawing.Point(14, 108);
            this.dtg607.MultiSelect = false;
            this.dtg607.Name = "dtg607";
            this.dtg607.ReadOnly = true;
            this.dtg607.RowHeadersWidth = 28;
            this.dtg607.RowTemplate.Height = 33;
            this.dtg607.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg607.Size = new System.Drawing.Size(1082, 332);
            this.dtg607.TabIndex = 47;
            this.dtg607.SelectionChanged += new System.EventHandler(this.dtg607_SelectionChanged);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "RNC o Cedula";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 130;
            // 
            // Tipo_Identificacion
            // 
            this.Tipo_Identificacion.DataPropertyName = "Tipo_Identificacion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Identificacion.DefaultCellStyle = dataGridViewCellStyle7;
            this.Tipo_Identificacion.HeaderText = "Tipo Identificacion";
            this.Tipo_Identificacion.Name = "Tipo_Identificacion";
            this.Tipo_Identificacion.ReadOnly = true;
            this.Tipo_Identificacion.Width = 150;
            // 
            // NCF
            // 
            this.NCF.DataPropertyName = "NCF";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF.DefaultCellStyle = dataGridViewCellStyle8;
            this.NCF.HeaderText = "NCF";
            this.NCF.Name = "NCF";
            this.NCF.ReadOnly = true;
            this.NCF.Width = 165;
            // 
            // NCF_Modificado
            // 
            this.NCF_Modificado.DataPropertyName = "NCF_Modificado";
            this.NCF_Modificado.HeaderText = "NCF Modificado";
            this.NCF_Modificado.Name = "NCF_Modificado";
            this.NCF_Modificado.ReadOnly = true;
            this.NCF_Modificado.Width = 165;
            // 
            // Fecha_Comprobante
            // 
            this.Fecha_Comprobante.DataPropertyName = "Fecha_Comprobante";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "yyyyMMdd";
            this.Fecha_Comprobante.DefaultCellStyle = dataGridViewCellStyle9;
            this.Fecha_Comprobante.HeaderText = "Fecha Comprobante";
            this.Fecha_Comprobante.Name = "Fecha_Comprobante";
            this.Fecha_Comprobante.ReadOnly = true;
            this.Fecha_Comprobante.Width = 170;
            // 
            // Itbis
            // 
            this.Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.Itbis.DefaultCellStyle = dataGridViewCellStyle10;
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.ReadOnly = true;
            this.Itbis.Width = 120;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle11;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 120;
            // 
            // Estatus
            // 
            this.Estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estatus.DataPropertyName = "Estatus";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            this.Estatus.DefaultCellStyle = dataGridViewCellStyle12;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblConteo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 102);
            this.panel2.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(23, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(395, 20);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Valor Calculado: 0.00        ITBIS Calculado: 0.00";
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Location = new System.Drawing.Point(23, 17);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(174, 20);
            this.lblConteo.TabIndex = 2;
            this.lblConteo.Text = "Cantidad Registro: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(693, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus";
            // 
            // txtEstatus
            // 
            this.txtEstatus.AMostrar = null;
            this.txtEstatus.AValidar = null;
            this.txtEstatus.BackColor = System.Drawing.Color.White;
            this.txtEstatus.CampoBusquedaID = "";
            this.txtEstatus.CampoData = "";
            this.txtEstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstatus.ColumnasBusqGeneral = null;
            this.txtEstatus.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEstatus.Decimales = 0;
            this.txtEstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstatus.DSData = null;
            this.txtEstatus.EsAutoGenerado = false;
            this.txtEstatus.EsBusqueda = false;
            this.txtEstatus.EsBusquedaAutoIncremental = false;
            this.txtEstatus.EsEditable = true;
            this.txtEstatus.FiltroBusqueda = "";
            this.txtEstatus.ForeColor = System.Drawing.Color.Red;
            this.txtEstatus.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtEstatus.Location = new System.Drawing.Point(3, 22);
            this.txtEstatus.Multiline = true;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.NombreTabla = "";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEstatus.SepDecimal = '\0';
            this.txtEstatus.Size = new System.Drawing.Size(393, 77);
            this.txtEstatus.TabIndex = 0;
            this.txtEstatus.TablaOVistaBusqueda = "";
            this.txtEstatus.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEstatus.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEstatus.ValorPorDefecto = "";
            // 
            // btnResumenFC
            // 
            this.btnResumenFC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResumenFC.Location = new System.Drawing.Point(651, 0);
            this.btnResumenFC.Name = "btnResumenFC";
            this.btnResumenFC.Size = new System.Drawing.Size(227, 52);
            this.btnResumenFC.TabIndex = 9;
            this.btnResumenFC.Text = "Ver Resumen Factura Consumo";
            this.btnResumenFC.UseVisualStyleBackColor = true;
            this.btnResumenFC.Click += new System.EventHandler(this.btnResumenFC_Click);
            // 
            // FormReporteDGII607
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 568);
            this.Controls.Add(this.dtg607);
            this.EsAgregar = false;
            this.EsExcel = true;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.EsTXT = true;
            this.Name = "FormReporteDGII607";
            this.Text = "DGII GENERAR REPORTE 607";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteDGII607_FormClosing);
            this.Load += new System.EventHandler(this.FormReporteDGII607_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtg607, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg607)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.DataGridView dtg607;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF_Modificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Button btnResumenFC;
    }
}