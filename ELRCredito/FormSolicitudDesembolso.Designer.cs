namespace ELRCredito
{
    partial class FormSolicitudDesembolso
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
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitud_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(1176, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1176, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Size = new System.Drawing.Size(315, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(447, 6);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Solicitud_Id,
            this.Fecha_Solicitud,
            this.Entidad_Id,
            this.CedulaRNC,
            this.Nombre_Entidad,
            this.Monto_Aprobado,
            this.Tasa_Interes,
            this.Plazo,
            this.Frecuencia_Pago,
            this.Descripcion_Formula,
            this.Monto_Cuota});
            this.dtgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgData.Location = new System.Drawing.Point(14, 98);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 28;
            this.dtgData.RowTemplate.Height = 33;
            this.dtgData.Size = new System.Drawing.Size(1176, 368);
            this.dtgData.TabIndex = 48;
            this.dtgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Solicitud_Id
            // 
            this.Solicitud_Id.DataPropertyName = "Solicitud_Id";
            this.Solicitud_Id.HeaderText = "Solicitud No";
            this.Solicitud_Id.Name = "Solicitud_Id";
            this.Solicitud_Id.ReadOnly = true;
            this.Solicitud_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Solicitud_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Solicitud_Id.Width = 120;
            // 
            // Fecha_Solicitud
            // 
            this.Fecha_Solicitud.DataPropertyName = "Fecha_Solicitud";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha_Solicitud.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha_Solicitud.HeaderText = "Fecha";
            this.Fecha_Solicitud.Name = "Fecha_Solicitud";
            this.Fecha_Solicitud.ReadOnly = true;
            this.Fecha_Solicitud.Width = 90;
            // 
            // Entidad_Id
            // 
            this.Entidad_Id.DataPropertyName = "Entidad_Id";
            this.Entidad_Id.HeaderText = "Entidad Id";
            this.Entidad_Id.Name = "Entidad_Id";
            this.Entidad_Id.ReadOnly = true;
            this.Entidad_Id.Visible = false;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            this.CedulaRNC.HeaderText = "Cedula\\RNC";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 120;
            // 
            // Nombre_Entidad
            // 
            this.Nombre_Entidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Entidad.DataPropertyName = "Nombre";
            this.Nombre_Entidad.HeaderText = "Nombre";
            this.Nombre_Entidad.Name = "Nombre_Entidad";
            this.Nombre_Entidad.ReadOnly = true;
            // 
            // Monto_Aprobado
            // 
            this.Monto_Aprobado.DataPropertyName = "Monto_Aprobado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Monto_Aprobado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto_Aprobado.HeaderText = "Monto";
            this.Monto_Aprobado.Name = "Monto_Aprobado";
            this.Monto_Aprobado.ReadOnly = true;
            this.Monto_Aprobado.Width = 130;
            // 
            // Tasa_Interes
            // 
            this.Tasa_Interes.DataPropertyName = "Tasa_Interes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tasa_Interes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tasa_Interes.HeaderText = "% Int. Anual";
            this.Tasa_Interes.Name = "Tasa_Interes";
            this.Tasa_Interes.ReadOnly = true;
            // 
            // Plazo
            // 
            this.Plazo.DataPropertyName = "Plazo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Plazo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Plazo.HeaderText = "Plazo";
            this.Plazo.Name = "Plazo";
            this.Plazo.ReadOnly = true;
            this.Plazo.Width = 80;
            // 
            // Frecuencia_Pago
            // 
            this.Frecuencia_Pago.DataPropertyName = "Frecuencia_Pago";
            this.Frecuencia_Pago.HeaderText = "Forma Pago";
            this.Frecuencia_Pago.Name = "Frecuencia_Pago";
            this.Frecuencia_Pago.ReadOnly = true;
            this.Frecuencia_Pago.Visible = false;
            this.Frecuencia_Pago.Width = 120;
            // 
            // Descripcion_Formula
            // 
            this.Descripcion_Formula.DataPropertyName = "Descripcion_Formula";
            this.Descripcion_Formula.HeaderText = "Formula";
            this.Descripcion_Formula.Name = "Descripcion_Formula";
            this.Descripcion_Formula.ReadOnly = true;
            this.Descripcion_Formula.Visible = false;
            this.Descripcion_Formula.Width = 220;
            // 
            // Monto_Cuota
            // 
            this.Monto_Cuota.DataPropertyName = "Monto_Cuota";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Monto_Cuota.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto_Cuota.HeaderText = "Monto Cuota";
            this.Monto_Cuota.Name = "Monto_Cuota";
            this.Monto_Cuota.ReadOnly = true;
            this.Monto_Cuota.Width = 120;
            // 
            // FormSolicitudDesembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Solicitud_Id";
            this.ClientSize = new System.Drawing.Size(1190, 540);
            this.Controls.Add(this.dtgData);
            this.DataGridConsulta = this.dtgData;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.FiltroEstatico = "IsNull(Prestamo_Id, 0) = 0";
            this.Name = "FormSolicitudDesembolso";
            this.NombreCampoID = "Solicitud_Id";
            this.TablaOVista = "VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS";
            this.Text = "CREDITO, DESEMBOLSO (GENERAR CREDITO)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dtgData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Solicitud_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Cuota;
    }
}