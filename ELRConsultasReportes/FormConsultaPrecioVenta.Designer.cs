namespace ELRConsultasReportes
{
    partial class FormConsultaPrecioVenta
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
            this.dtgPrecio = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioSinItbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioConItbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(0, 449);
            this.pnTotales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnTotales.Size = new System.Drawing.Size(756, 94);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.lblNombre);
            this.pnBusqSencilla.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBusqSencilla.Location = new System.Drawing.Point(19, 52);
            this.pnBusqSencilla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnBusqSencilla.Size = new System.Drawing.Size(737, 123);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblNombre, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.autoSenTab = false;
            this.txtABuscar.CondicionABuscar = "";
            this.txtABuscar.Location = new System.Drawing.Point(117, 16);
            this.txtABuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtABuscar.Size = new System.Drawing.Size(259, 35);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(393, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.Size = new System.Drawing.Size(137, 52);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.Text = "Codigo";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Location = new System.Drawing.Point(15, 21);
            this.lblCantidadRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(68, 30);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(19, 397);
            // 
            // chkRangoFecha
            // 
            this.chkRangoFecha.Location = new System.Drawing.Point(20, 148);
            this.chkRangoFecha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkRangoFecha.Size = new System.Drawing.Size(152, 34);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(164, 249);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpFechaHasta.Size = new System.Drawing.Size(271, 35);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(164, 197);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpFechaDesde.Size = new System.Drawing.Size(271, 35);
            // 
            // dtgPrecio
            // 
            this.dtgPrecio.AllowUserToAddRows = false;
            this.dtgPrecio.AllowUserToDeleteRows = false;
            this.dtgPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Decripcion,
            this.PrecioSinItbis,
            this.PrecioConItbis});
            this.dtgPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPrecio.Location = new System.Drawing.Point(19, 175);
            this.dtgPrecio.Name = "dtgPrecio";
            this.dtgPrecio.ReadOnly = true;
            this.dtgPrecio.RowHeadersWidth = 30;
            this.dtgPrecio.RowTemplate.Height = 40;
            this.dtgPrecio.Size = new System.Drawing.Size(737, 274);
            this.dtgPrecio.TabIndex = 48;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Red;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(0, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(733, 43);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "     PRODUCTOS Y/O SERVICIOS";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Decripcion
            // 
            this.Decripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Decripcion.DataPropertyName = "Descripcion";
            this.Decripcion.HeaderText = "Descripcion";
            this.Decripcion.Name = "Decripcion";
            this.Decripcion.ReadOnly = true;
            // 
            // PrecioSinItbis
            // 
            this.PrecioSinItbis.DataPropertyName = "PrecioSinItbis";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.PrecioSinItbis.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioSinItbis.HeaderText = "Pre. Sin Itbis";
            this.PrecioSinItbis.Name = "PrecioSinItbis";
            this.PrecioSinItbis.ReadOnly = true;
            this.PrecioSinItbis.Width = 190;
            // 
            // PrecioConItbis
            // 
            this.PrecioConItbis.DataPropertyName = "PrecioConItbis";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.PrecioConItbis.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioConItbis.HeaderText = "Pre. Con Itbis";
            this.PrecioConItbis.Name = "PrecioConItbis";
            this.PrecioConItbis.ReadOnly = true;
            this.PrecioConItbis.Width = 190;
            // 
            // FormConsultaPrecioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 565);
            this.Controls.Add(this.dtgPrecio);
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsModificar = false;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultaPrecioVenta";
            this.Text = "CONSULTA DE PRECIO DE PRODUCTOS Y/O SERVICIOS";
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgPrecio, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioSinItbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioConItbis;
    }
}