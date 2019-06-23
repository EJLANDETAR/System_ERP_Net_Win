namespace ELRCredito
{
    partial class FormSolicitudGarantias2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.btnGarantiaPersonal = new System.Windows.Forms.Button();
            this.btnGaramtiaHipotecaria = new System.Windows.Forms.Button();
            this.btnGarantiaVehiculo = new System.Windows.Forms.Button();
            this.btnGarantiaEmpleado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Documento_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtDescripcion);
            this.pnTotales.Location = new System.Drawing.Point(14, 436);
            this.pnTotales.Size = new System.Drawing.Size(1047, 82);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtDescripcion, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnGarantiaEmpleado);
            this.pnBusqSencilla.Controls.Add(this.btnGarantiaVehiculo);
            this.pnBusqSencilla.Controls.Add(this.btnGaramtiaHipotecaria);
            this.pnBusqSencilla.Controls.Add(this.btnGarantiaPersonal);
            this.pnBusqSencilla.Controls.Add(this.lblSolicitud);
            this.pnBusqSencilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1047, 84);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblSolicitud, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnGarantiaPersonal, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnGaramtiaHipotecaria, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnGarantiaVehiculo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnGarantiaEmpleado, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(113, 105);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(382, 105);
            this.btnBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.Visible = false;
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Location = new System.Drawing.Point(4, 12);
            this.lblCantidadRegistro.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitud.Location = new System.Drawing.Point(11, 12);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(588, 24);
            this.lblSolicitud.TabIndex = 3;
            this.lblSolicitud.Text = "Solicitud No.: 000000 - NOMBRE Y APELLIDOS DEL CLIENTE";
            // 
            // btnGarantiaPersonal
            // 
            this.btnGarantiaPersonal.Location = new System.Drawing.Point(13, 40);
            this.btnGarantiaPersonal.Name = "btnGarantiaPersonal";
            this.btnGarantiaPersonal.Size = new System.Drawing.Size(88, 31);
            this.btnGarantiaPersonal.TabIndex = 4;
            this.btnGarantiaPersonal.Text = "Personal";
            this.btnGarantiaPersonal.UseVisualStyleBackColor = true;
            this.btnGarantiaPersonal.Click += new System.EventHandler(this.btnGarantiaPersonal_Click);
            // 
            // btnGaramtiaHipotecaria
            // 
            this.btnGaramtiaHipotecaria.Enabled = false;
            this.btnGaramtiaHipotecaria.Location = new System.Drawing.Point(275, 40);
            this.btnGaramtiaHipotecaria.Name = "btnGaramtiaHipotecaria";
            this.btnGaramtiaHipotecaria.Size = new System.Drawing.Size(124, 31);
            this.btnGaramtiaHipotecaria.TabIndex = 5;
            this.btnGaramtiaHipotecaria.Text = "Hipotecario";
            this.btnGaramtiaHipotecaria.UseVisualStyleBackColor = true;
            // 
            // btnGarantiaVehiculo
            // 
            this.btnGarantiaVehiculo.Location = new System.Drawing.Point(107, 40);
            this.btnGarantiaVehiculo.Name = "btnGarantiaVehiculo";
            this.btnGarantiaVehiculo.Size = new System.Drawing.Size(162, 31);
            this.btnGarantiaVehiculo.TabIndex = 6;
            this.btnGarantiaVehiculo.Text = "Sobre Vehiculo";
            this.btnGarantiaVehiculo.UseVisualStyleBackColor = true;
            this.btnGarantiaVehiculo.Click += new System.EventHandler(this.btnGarantiaVehiculo_Click);
            // 
            // btnGarantiaEmpleado
            // 
            this.btnGarantiaEmpleado.Location = new System.Drawing.Point(405, 40);
            this.btnGarantiaEmpleado.Name = "btnGarantiaEmpleado";
            this.btnGarantiaEmpleado.Size = new System.Drawing.Size(162, 31);
            this.btnGarantiaEmpleado.TabIndex = 7;
            this.btnGarantiaEmpleado.Text = "De Empleado";
            this.btnGarantiaEmpleado.UseVisualStyleBackColor = true;
            this.btnGarantiaEmpleado.Click += new System.EventHandler(this.btnGarantiaEmpleado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.btnEliminar,
            this.Documento_No,
            this.Tipo,
            this.Descripcion,
            this.Valor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 300);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(0, 0);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(1043, 78);
            this.txtDescripcion.TabIndex = 1;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar Garantia";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // Documento_No
            // 
            this.Documento_No.DataPropertyName = "Documento_Id";
            this.Documento_No.HeaderText = "Documento No.";
            this.Documento_No.Name = "Documento_No";
            this.Documento_No.ReadOnly = true;
            this.Documento_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Documento_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Documento_No.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo_Garantia";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 230;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 140;
            // 
            // FormSolicitudGarantias2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CargarDataAlInicio = false;
            this.ClausulaOrderBY = "Unico Desc";
            this.ClientSize = new System.Drawing.Size(1061, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.Name = "FormSolicitudGarantias2";
            this.NombreCampoID = "Unico";
            this.TablaOVista = "VPRESTAMOS_SOLICITUD_GARANTIAS";
            this.Text = "SOLICITUD GARANTIAS, PASO 2";
            this.Load += new System.EventHandler(this.FormSolicitudGarantias2_Load);
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

        private System.Windows.Forms.Button btnGarantiaEmpleado;
        private System.Windows.Forms.Button btnGarantiaVehiculo;
        private System.Windows.Forms.Button btnGaramtiaHipotecaria;
        private System.Windows.Forms.Button btnGarantiaPersonal;
        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewLinkColumn Documento_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}