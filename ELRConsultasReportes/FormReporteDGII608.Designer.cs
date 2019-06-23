namespace ELRConsultasReportes
{
    partial class FormReporteDGII608
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new WinControl_ELR_NET.ELRTextBox();
            this.dtg608 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Anulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg608)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.groupBox1);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(0, 440);
            this.pnTotales.Size = new System.Drawing.Size(1037, 106);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnGenerar);
            this.pnBusqSencilla.Controls.Add(this.panel1);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 55);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.panel1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnGenerar, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(850, 8);
            this.txtABuscar.Size = new System.Drawing.Size(61, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(917, 9);
            this.btnBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(757, 9);
            this.label1.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Size = new System.Drawing.Size(52, 18);
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
            this.panel1.Size = new System.Drawing.Size(472, 51);
            this.panel1.TabIndex = 8;
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
            this.btnGenerar.Size = new System.Drawing.Size(179, 51);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Buscar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 102);
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
            this.txtEstatus.Location = new System.Drawing.Point(3, 20);
            this.txtEstatus.Multiline = true;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.NombreTabla = "";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEstatus.SepDecimal = '\0';
            this.txtEstatus.Size = new System.Drawing.Size(1027, 79);
            this.txtEstatus.TabIndex = 0;
            this.txtEstatus.TablaOVistaBusqueda = "";
            this.txtEstatus.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEstatus.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEstatus.ValorPorDefecto = "";
            // 
            // dtg608
            // 
            this.dtg608.AllowUserToAddRows = false;
            this.dtg608.AllowUserToDeleteRows = false;
            this.dtg608.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg608.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.NCF,
            this.Fecha_Comprobante,
            this.Tipo_Anulacion,
            this.Estatus});
            this.dtg608.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg608.Location = new System.Drawing.Point(14, 107);
            this.dtg608.MultiSelect = false;
            this.dtg608.Name = "dtg608";
            this.dtg608.ReadOnly = true;
            this.dtg608.RowHeadersWidth = 28;
            this.dtg608.RowTemplate.Height = 33;
            this.dtg608.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg608.Size = new System.Drawing.Size(1023, 333);
            this.dtg608.TabIndex = 49;
            this.dtg608.SelectionChanged += new System.EventHandler(this.dtg608_SelectionChanged_1);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // NCF
            // 
            this.NCF.DataPropertyName = "NCF";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCF.DefaultCellStyle = dataGridViewCellStyle1;
            this.NCF.HeaderText = "NCF";
            this.NCF.Name = "NCF";
            this.NCF.ReadOnly = true;
            this.NCF.Width = 165;
            // 
            // Fecha_Comprobante
            // 
            this.Fecha_Comprobante.DataPropertyName = "Fecha_Comprobante";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "yyyyMMdd";
            this.Fecha_Comprobante.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_Comprobante.HeaderText = "Fecha Comprobante";
            this.Fecha_Comprobante.Name = "Fecha_Comprobante";
            this.Fecha_Comprobante.ReadOnly = true;
            this.Fecha_Comprobante.Width = 170;
            // 
            // Tipo_Anulacion
            // 
            this.Tipo_Anulacion.DataPropertyName = "Tipo_Anulacion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Anulacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tipo_Anulacion.HeaderText = "Tipo Anulacion";
            this.Tipo_Anulacion.Name = "Tipo_Anulacion";
            this.Tipo_Anulacion.ReadOnly = true;
            this.Tipo_Anulacion.Width = 300;
            // 
            // Estatus
            // 
            this.Estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estatus.DataPropertyName = "Estatus";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.Estatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // FormReporteDGII608
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dtg608);
            this.DataGridConsulta = this.dtg608;
            this.EsAgregar = false;
            this.EsExcel = true;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.EsTXT = true;
            this.Name = "FormReporteDGII608";
            this.Text = "DGII GENERAR REPORTE 608";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteDGII608_FormClosing);
            this.Load += new System.EventHandler(this.FormReporteDGII608_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtg608, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg608)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtEstatus;
        private System.Windows.Forms.DataGridView dtg608;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Anulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}