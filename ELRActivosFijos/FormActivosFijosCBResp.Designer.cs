namespace ELRActivosFijos
{
    partial class FormActivosFijosCBResp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarActivo = new System.Windows.Forms.Button();
            this.txtActivoId = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vida_Util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Libro_Depreciar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtNombreActivo = new WinControl_ELR_NET.ELRTextBox();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtConcepto);
            this.pnTotales.Location = new System.Drawing.Point(0, 480);
            this.pnTotales.Size = new System.Drawing.Size(991, 66);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtConcepto, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.txtNombreActivo);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarActivo);
            this.pnBusqSencilla.Controls.Add(this.txtActivoId);
            this.pnBusqSencilla.Controls.Add(this.label9);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(977, 101);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label9, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtActivoId, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarActivo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombreActivo, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(804, 14);
            this.txtABuscar.Size = new System.Drawing.Size(74, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = null;
            this.btnBuscar.Location = new System.Drawing.Point(544, 44);
            this.btnBuscar.Size = new System.Drawing.Size(142, 36);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(707, 14);
            this.label1.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 428);
            // 
            // btnBuscarActivo
            // 
            this.btnBuscarActivo.Image = global::ELRActivosFijos.Properties.Resources._1378160672_search;
            this.btnBuscarActivo.Location = new System.Drawing.Point(236, 15);
            this.btnBuscarActivo.Name = "btnBuscarActivo";
            this.btnBuscarActivo.Size = new System.Drawing.Size(44, 26);
            this.btnBuscarActivo.TabIndex = 31;
            this.btnBuscarActivo.UseVisualStyleBackColor = true;
            this.btnBuscarActivo.Click += new System.EventHandler(this.btnBuscarActivo_Click);
            // 
            // txtActivoId
            // 
            this.txtActivoId.AMostrar = null;
            this.txtActivoId.AValidar = null;
            this.txtActivoId.CampoBusquedaID = "";
            this.txtActivoId.CampoData = "";
            this.txtActivoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActivoId.ColumnasBusqGeneral = null;
            this.txtActivoId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtActivoId.Decimales = 0;
            this.txtActivoId.DSData = null;
            this.txtActivoId.EsAutoGenerado = false;
            this.txtActivoId.EsBusqueda = false;
            this.txtActivoId.EsBusquedaAutoIncremental = false;
            this.txtActivoId.EsEditable = true;
            this.txtActivoId.FiltroBusqueda = "";
            this.txtActivoId.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtActivoId.Location = new System.Drawing.Point(124, 15);
            this.txtActivoId.Name = "txtActivoId";
            this.txtActivoId.NombreTabla = "";
            this.txtActivoId.SepDecimal = '\0';
            this.txtActivoId.Size = new System.Drawing.Size(106, 26);
            this.txtActivoId.TabIndex = 30;
            this.txtActivoId.TablaOVistaBusqueda = "";
            this.txtActivoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivoId.ValorPorDefecto = "";
            this.txtActivoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivoId_KeyDown);
            this.txtActivoId.Leave += new System.EventHandler(this.txtActivoId_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Por Activo";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(354, 47);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(128, 26);
            this.dtpFecha2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Hasta:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(124, 47);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(153, 26);
            this.dtpFecha1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha Desde:";
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
            this.Fecha,
            this.Valor_Adquisicion,
            this.Vida_Util,
            this.Valor_Libro_Depreciar,
            this.Tipo,
            this.Concepto,
            this.Descripcion,
            this.btnAnular});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 327);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Valor_Adquisicion
            // 
            this.Valor_Adquisicion.DataPropertyName = "Valor_Adquisicion";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Valor_Adquisicion.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valor_Adquisicion.HeaderText = "Valor Adquisicion";
            this.Valor_Adquisicion.Name = "Valor_Adquisicion";
            this.Valor_Adquisicion.ReadOnly = true;
            this.Valor_Adquisicion.Width = 140;
            // 
            // Vida_Util
            // 
            this.Vida_Util.DataPropertyName = "Vida_Util";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Vida_Util.DefaultCellStyle = dataGridViewCellStyle7;
            this.Vida_Util.HeaderText = "Vida Util";
            this.Vida_Util.Name = "Vida_Util";
            this.Vida_Util.ReadOnly = true;
            this.Vida_Util.Width = 85;
            // 
            // Valor_Libro_Depreciar
            // 
            this.Valor_Libro_Depreciar.DataPropertyName = "Valor_Libro_Depreciar";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.Valor_Libro_Depreciar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Valor_Libro_Depreciar.HeaderText = "Valor Libro";
            this.Valor_Libro_Depreciar.Name = "Valor_Libro_Depreciar";
            this.Valor_Libro_Depreciar.ReadOnly = true;
            this.Valor_Libro_Depreciar.Width = 130;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // btnAnular
            // 
            this.btnAnular.HeaderText = "";
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.ReadOnly = true;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseColumnTextForButtonValue = true;
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
            this.txtConcepto.Size = new System.Drawing.Size(987, 62);
            this.txtConcepto.TabIndex = 3;
            // 
            // txtNombreActivo
            // 
            this.txtNombreActivo.AMostrar = null;
            this.txtNombreActivo.AValidar = null;
            this.txtNombreActivo.BackColor = System.Drawing.Color.White;
            this.txtNombreActivo.CampoBusquedaID = "";
            this.txtNombreActivo.CampoData = "";
            this.txtNombreActivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreActivo.ColumnasBusqGeneral = null;
            this.txtNombreActivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreActivo.Decimales = 0;
            this.txtNombreActivo.DSData = null;
            this.txtNombreActivo.EsAutoGenerado = false;
            this.txtNombreActivo.EsBusqueda = false;
            this.txtNombreActivo.EsBusquedaAutoIncremental = false;
            this.txtNombreActivo.EsEditable = true;
            this.txtNombreActivo.FiltroBusqueda = "";
            this.txtNombreActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActivo.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtNombreActivo.Location = new System.Drawing.Point(296, 14);
            this.txtNombreActivo.Name = "txtNombreActivo";
            this.txtNombreActivo.NombreTabla = "";
            this.txtNombreActivo.ReadOnly = true;
            this.txtNombreActivo.SepDecimal = '\0';
            this.txtNombreActivo.Size = new System.Drawing.Size(390, 26);
            this.txtNombreActivo.TabIndex = 32;
            this.txtNombreActivo.TablaOVistaBusqueda = "";
            this.txtNombreActivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreActivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreActivo.ValorPorDefecto = "";
            // 
            // FormActivosFijosCBResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsModificar = false;
            this.FormularioRegistro = "ELRActivosFijos.FormActivosFijosCBRespR";
            this.Name = "FormActivosFijosCBResp";
            this.Text = "ACTIVOS FIJOS, CAMBIOS DE RESPONSABLE";
            this.Load += new System.EventHandler(this.FormActivosFijosCBResp_Load);
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
        private System.Windows.Forms.Button btnBuscarActivo;
        private WinControl_ELR_NET.ELRTextBox txtActivoId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vida_Util;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Libro_Depreciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn btnAnular;
        private WinControl_ELR_NET.ELRTextBox txtNombreActivo;
    }
}