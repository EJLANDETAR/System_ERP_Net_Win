namespace ELRConsultasReportes
{
    partial class FormActivosFijoVentasRetiros
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
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarOficina = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Visible = true;
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Controls.Add(this.txtCodigo);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarOficina);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 75);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarOficina, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(795, 28);
            this.txtABuscar.Size = new System.Drawing.Size(72, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(530, 5);
            this.btnBuscar.Size = new System.Drawing.Size(141, 62);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.Text = "Tipo";
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.AutoSize = false;
            this.lblCantidadRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidadRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(1033, 48);
            this.lblCantidadRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(394, 41);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(130, 26);
            this.dtpFecha2.TabIndex = 47;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Fecha Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(129, 37);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha1.TabIndex = 45;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha Desde:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = null;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(59, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 43;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.Text = "0";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigo, "Digite Codigo a Buscar y Presione Enter");
            this.txtCodigo.ValorPorDefecto = "";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btnBuscarOficina
            // 
            this.btnBuscarOficina.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarOficina.Location = new System.Drawing.Point(166, 4);
            this.btnBuscarOficina.Name = "btnBuscarOficina";
            this.btnBuscarOficina.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarOficina.TabIndex = 42;
            this.btnBuscarOficina.UseVisualStyleBackColor = true;
            this.btnBuscarOficina.Click += new System.EventHandler(this.btnBuscarOficina_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = null;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(214, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(310, 26);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Activo_Id,
            this.Nombre,
            this.Tipo,
            this.Fecha,
            this.Monto,
            this.Monto_Ganancia});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 367);
            this.dataGridView1.TabIndex = 50;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Activo_Id
            // 
            this.Activo_Id.DataPropertyName = "Activo_Id";
            this.Activo_Id.HeaderText = "Codigo";
            this.Activo_Id.Name = "Activo_Id";
            this.Activo_Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto.HeaderText = "Venta";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 130;
            // 
            // Monto_Ganancia
            // 
            this.Monto_Ganancia.DataPropertyName = "Monto_Ganancia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Monto_Ganancia.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto_Ganancia.HeaderText = "Gan.\\Perdida";
            this.Monto_Ganancia.Name = "Monto_Ganancia";
            this.Monto_Ganancia.ReadOnly = true;
            this.Monto_Ganancia.Width = 130;
            // 
            // FormActivosFijoVentasRetiros
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
            this.Name = "FormActivosFijoVentasRetiros";
            this.Text = "VENTAS Y\\O RETIROS DE ACTIVOS FIJOS";
            this.Load += new System.EventHandler(this.FormActivosFijoVentasRetiros_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscarOficina;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Ganancia;
    }
}