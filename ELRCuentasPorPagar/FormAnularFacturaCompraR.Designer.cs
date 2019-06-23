namespace ELRCuentasPorPagar
{
    partial class FormAnularFacturaCompraR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.lblMontoPendiente = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblSuplidor = new System.Windows.Forms.Label();
            this.lblNCFModificar = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsExcentoItbis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrecioConItbis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 437);
            this.pnBotones.Size = new System.Drawing.Size(852, 58);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(584, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 54);
            this.btnGrabar.Text = "Ctrl+G = &Anular";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(725, 0);
            this.btnCancelar.Size = new System.Drawing.Size(123, 54);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 54);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(489, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 54);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(394, 54);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblMontoPendiente);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.lblSuplidor);
            this.panel1.Controls.Add(this.lblNCFModificar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 318);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 123);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo o Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.autoSenTab = false;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.DSData = null;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(3, 29);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(842, 91);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // lblMontoPendiente
            // 
            this.lblMontoPendiente.AutoSize = true;
            this.lblMontoPendiente.Location = new System.Drawing.Point(10, 138);
            this.lblMontoPendiente.Name = "lblMontoPendiente";
            this.lblMontoPendiente.Size = new System.Drawing.Size(355, 25);
            this.lblMontoPendiente.TabIndex = 8;
            this.lblMontoPendiente.Text = "MONTO PENDIENTE POR PAGAR:  0.00";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(10, 103);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(506, 25);
            this.lblMonto.TabIndex = 7;
            this.lblMonto.Text = "MONTO TOTAL:  0.00                                      ITBIS:  0.00    ";
            // 
            // lblSuplidor
            // 
            this.lblSuplidor.AutoSize = true;
            this.lblSuplidor.Location = new System.Drawing.Point(10, 64);
            this.lblSuplidor.Name = "lblSuplidor";
            this.lblSuplidor.Size = new System.Drawing.Size(626, 25);
            this.lblSuplidor.TabIndex = 6;
            this.lblSuplidor.Text = "SUPLIDOR:  000-00000000-0      NOMBRE COMPLETO  DEL SUPLIDOR";
            // 
            // lblNCFModificar
            // 
            this.lblNCFModificar.BackColor = System.Drawing.Color.Blue;
            this.lblNCFModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNCFModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNCFModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNCFModificar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCFModificar.ForeColor = System.Drawing.Color.White;
            this.lblNCFModificar.Location = new System.Drawing.Point(0, 0);
            this.lblNCFModificar.Name = "lblNCFModificar";
            this.lblNCFModificar.Size = new System.Drawing.Size(848, 46);
            this.lblNCFModificar.TabIndex = 5;
            this.lblNCFModificar.Text = "FACTURA NO.:  0000000000             NCF A MODIFICAR:  B0100000000";
            this.lblNCFModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Descripcion,
            this.Cantidad,
            this.Itbis,
            this.Importe,
            this.Tasa_Itbis,
            this.EsExcentoItbis,
            this.PrecioConItbis});
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 0);
            this.dtgDetalle.MultiSelect = false;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersWidth = 28;
            this.dtgDetalle.RowTemplate.Height = 35;
            this.dtgDetalle.Size = new System.Drawing.Size(852, 119);
            this.dtgDetalle.TabIndex = 3;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Itbis
            // 
            this.Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Itbis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Itbis.HeaderText = "Itbis";
            this.Itbis.Name = "Itbis";
            this.Itbis.ReadOnly = true;
            this.Itbis.Width = 120;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 130;
            // 
            // Tasa_Itbis
            // 
            this.Tasa_Itbis.DataPropertyName = "Tasa_Itbis";
            this.Tasa_Itbis.HeaderText = "Tasa_Itbis";
            this.Tasa_Itbis.Name = "Tasa_Itbis";
            this.Tasa_Itbis.ReadOnly = true;
            this.Tasa_Itbis.Visible = false;
            // 
            // EsExcentoItbis
            // 
            this.EsExcentoItbis.DataPropertyName = "EsExcentoItbis";
            this.EsExcentoItbis.HeaderText = "EsExcentoItbis";
            this.EsExcentoItbis.Name = "EsExcentoItbis";
            this.EsExcentoItbis.ReadOnly = true;
            this.EsExcentoItbis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsExcentoItbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsExcentoItbis.Visible = false;
            // 
            // PrecioConItbis
            // 
            this.PrecioConItbis.DataPropertyName = "PrecioConItbis";
            this.PrecioConItbis.HeaderText = "PrecioConItbis";
            this.PrecioConItbis.Name = "PrecioConItbis";
            this.PrecioConItbis.ReadOnly = true;
            this.PrecioConItbis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioConItbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrecioConItbis.Visible = false;
            // 
            // FormAnularFacturaCompraR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgDetalle;
            this.Name = "FormAnularFacturaCompraR";
            this.TablaEncabezado = "Tabla";
            this.Text = "ANULAR REGISTRO DE COMPRA";
            this.Activated += new System.EventHandler(this.FormAnularFacturaCompraR_Activated);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dtgDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Label lblMontoPendiente;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblSuplidor;
        private System.Windows.Forms.Label lblNCFModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Itbis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsExcentoItbis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrecioConItbis;
    }
}