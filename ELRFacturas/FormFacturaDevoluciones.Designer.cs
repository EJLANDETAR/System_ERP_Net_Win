namespace ELRFacturas
{
    partial class FormFacturaDevoluciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AContado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new WinControl_ELR_NET.ELRLabel();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 472);
            this.pnTotales.Size = new System.Drawing.Size(1092, 46);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.lblMensaje);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1092, 46);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblMensaje, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Factura_No,
            this.Fecha,
            this.CedulaRNC,
            this.ANombre,
            this.Monto,
            this.ACredito,
            this.AContado,
            this.C_Horas,
            this.Identificador_Id});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 374);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Factura_No
            // 
            this.Factura_No.DataPropertyName = "Numero";
            this.Factura_No.HeaderText = "Factura No.";
            this.Factura_No.Name = "Factura_No";
            this.Factura_No.ReadOnly = true;
            this.Factura_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Factura_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Factura_No.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 110;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "CedulaRNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 120;
            // 
            // ANombre
            // 
            this.ANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANombre.DataPropertyName = "Nombre";
            this.ANombre.HeaderText = "ANombre";
            this.ANombre.Name = "ANombre";
            this.ANombre.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 120;
            // 
            // ACredito
            // 
            this.ACredito.DataPropertyName = "Monto_ACredito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.ACredito.DefaultCellStyle = dataGridViewCellStyle2;
            this.ACredito.HeaderText = "A Credito";
            this.ACredito.Name = "ACredito";
            this.ACredito.ReadOnly = true;
            this.ACredito.Width = 120;
            // 
            // AContado
            // 
            this.AContado.DataPropertyName = "Monto_AlContado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.AContado.DefaultCellStyle = dataGridViewCellStyle3;
            this.AContado.HeaderText = "Al Contado";
            this.AContado.Name = "AContado";
            this.AContado.ReadOnly = true;
            this.AContado.Width = 120;
            // 
            // C_Horas
            // 
            this.C_Horas.DataPropertyName = "C_Horas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "00";
            this.C_Horas.DefaultCellStyle = dataGridViewCellStyle4;
            this.C_Horas.HeaderText = "C. Horas";
            this.C_Horas.Name = "C_Horas";
            this.C_Horas.ReadOnly = true;
            // 
            // Identificador_Id
            // 
            this.Identificador_Id.DataPropertyName = "Identificador_Id";
            this.Identificador_Id.HeaderText = "Identificador_Id";
            this.Identificador_Id.Name = "Identificador_Id";
            this.Identificador_Id.ReadOnly = true;
            this.Identificador_Id.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.CampoData = "";
            this.lblMensaje.DSData = null;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(479, 7);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.NombreTabla = "";
            this.lblMensaje.Size = new System.Drawing.Size(89, 24);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mensaje";
            this.toolTip1.SetToolTip(this.lblMensaje, "Mensaje");
            this.lblMensaje.ValorPorDefecto = "";
            // 
            // FormFacturaDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Numero Desc";
            this.ClientSize = new System.Drawing.Size(1106, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.FormularioRegistro = "ELRFacturas.FormFacturaDevolucionesR";
            this.Name = "FormFacturaDevoluciones";
            this.NombreCampoID = "Unico";
            this.SPCargarATemporal = "SP_TEMPORAL_VENTAS_DEVOLUCIONES";
            this.TablaOVista = "VVENTAS";
            this.Text = "SELECCIONE FACTURA A APLICAR DEVOLUCION";
            this.Load += new System.EventHandler(this.FormFacturaDevoluciones_Load);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Factura_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn AContado;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador_Id;
        private WinControl_ELR_NET.ELRLabel lblMensaje;
    }
}