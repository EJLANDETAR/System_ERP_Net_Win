namespace ELRContaGeneral
{
    partial class FormContaEstadosGenerados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionado_Por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAnexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboEstado = new WinControl_ELR_NET.ELRCombobox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new WinControl_ELR_NET.ELRDatePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new WinControl_ELR_NET.ELRDatePicker();
            this.btnImprimirCatalogo = new System.Windows.Forms.Button();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Size = new System.Drawing.Size(1106, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnImprimirCatalogo);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha2);
            this.pnBusqSencilla.Controls.Add(this.label8);
            this.pnBusqSencilla.Controls.Add(this.dtpFecha1);
            this.pnBusqSencilla.Controls.Add(this.label7);
            this.pnBusqSencilla.Controls.Add(this.cboEstado);
            this.pnBusqSencilla.Controls.Add(this.label6);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1092, 84);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label6, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboEstado, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label7, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label8, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.dtpFecha2, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnImprimirCatalogo, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(919, 14);
            this.txtABuscar.Size = new System.Drawing.Size(63, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(511, 12);
            this.btnBuscar.Size = new System.Drawing.Size(131, 58);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(835, 12);
            this.label1.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Registro_Id,
            this.Fecha,
            this.Anio,
            this.Nombre_Mes,
            this.Titulo,
            this.Adicionado_Por,
            this.Fecha_Modificado,
            this.EsAnexo,
            this.EsAcumulado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 358);
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
            // Registro_Id
            // 
            this.Registro_Id.DataPropertyName = "Registro_Id";
            this.Registro_Id.HeaderText = "Codigo";
            this.Registro_Id.Name = "Registro_Id";
            this.Registro_Id.ReadOnly = true;
            this.Registro_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Registro_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Registro_Id.Width = 85;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Anio
            // 
            this.Anio.DataPropertyName = "Anio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.Anio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Anio.HeaderText = "Anio";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            this.Anio.Width = 60;
            // 
            // Nombre_Mes
            // 
            this.Nombre_Mes.DataPropertyName = "Nombre_Mes";
            this.Nombre_Mes.HeaderText = "Mes";
            this.Nombre_Mes.Name = "Nombre_Mes";
            this.Nombre_Mes.ReadOnly = true;
            this.Nombre_Mes.Width = 120;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Adicionado_Por
            // 
            this.Adicionado_Por.DataPropertyName = "Modificado_Por";
            this.Adicionado_Por.HeaderText = "Autor";
            this.Adicionado_Por.Name = "Adicionado_Por";
            this.Adicionado_Por.ReadOnly = true;
            this.Adicionado_Por.Width = 150;
            // 
            // Fecha_Modificado
            // 
            this.Fecha_Modificado.DataPropertyName = "Fecha_Modificado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm:ss tt";
            this.Fecha_Modificado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha_Modificado.HeaderText = "Autor Fecha";
            this.Fecha_Modificado.Name = "Fecha_Modificado";
            this.Fecha_Modificado.ReadOnly = true;
            this.Fecha_Modificado.Width = 180;
            // 
            // EsAnexo
            // 
            this.EsAnexo.DataPropertyName = "EsAnexo";
            this.EsAnexo.HeaderText = "EsAnexo";
            this.EsAnexo.Name = "EsAnexo";
            this.EsAnexo.ReadOnly = true;
            this.EsAnexo.Visible = false;
            // 
            // EsAcumulado
            // 
            this.EsAcumulado.DataPropertyName = "EsAcumulado";
            this.EsAcumulado.HeaderText = "EsAcumulado";
            this.EsAcumulado.Name = "EsAcumulado";
            this.EsAcumulado.ReadOnly = true;
            this.EsAcumulado.Visible = false;
            // 
            // cboEstado
            // 
            this.cboEstado.AValidar = null;
            this.cboEstado.CampoData = "";
            this.cboEstado.CampoJoinCombobox2 = "";
            this.cboEstado.ComboboxAFiltrar = null;
            this.cboEstado.DisplayMember = "Descripcion";
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.DSData = null;
            this.cboEstado.EsEditable = true;
            this.cboEstado.FiltroBusqueda = "";
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(95, 12);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.NombreTabla = "";
            this.cboEstado.Size = new System.Drawing.Size(410, 28);
            this.cboEstado.SSQL = "";
            this.cboEstado.TabIndex = 4;
            this.cboEstado.TablaOVistaConsulta = "";
            this.cboEstado.UsaDataGlobal = false;
            this.cboEstado.ValorPorDefecto = "0";
            this.cboEstado.ValueMember = "Estado_Id";
            this.cboEstado.SelectedValueChanged += new System.EventHandler(this.cboEstado_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha Desde:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.AValidar = null;
            this.dtpFecha1.CampoData = "";
            this.dtpFecha1.DSData = null;
            this.dtpFecha1.EsEditable = true;
            this.dtpFecha1.FiltroBusqueda = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(134, 46);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.NombreTabla = "";
            this.dtpFecha1.Size = new System.Drawing.Size(143, 26);
            this.dtpFecha1.TabIndex = 6;
            this.dtpFecha1.ValorPorDefecto = new System.DateTime(2017, 4, 7, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "A:";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.AValidar = null;
            this.dtpFecha2.CampoData = "";
            this.dtpFecha2.DSData = null;
            this.dtpFecha2.EsEditable = true;
            this.dtpFecha2.FiltroBusqueda = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(362, 44);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.NombreTabla = "";
            this.dtpFecha2.Size = new System.Drawing.Size(143, 26);
            this.dtpFecha2.TabIndex = 8;
            this.dtpFecha2.ValorPorDefecto = new System.DateTime(2017, 4, 7, 0, 0, 0, 0);
            // 
            // btnImprimirCatalogo
            // 
            this.btnImprimirCatalogo.Location = new System.Drawing.Point(648, 12);
            this.btnImprimirCatalogo.Name = "btnImprimirCatalogo";
            this.btnImprimirCatalogo.Size = new System.Drawing.Size(157, 58);
            this.btnImprimirCatalogo.TabIndex = 9;
            this.btnImprimirCatalogo.Text = "Imprimir Catalogo";
            this.btnImprimirCatalogo.UseVisualStyleBackColor = true;
            this.btnImprimirCatalogo.Click += new System.EventHandler(this.btnImprimirCatalogo_Click);
            // 
            // FormContaEstadosGenerados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Unico Desc";
            this.ClientSize = new System.Drawing.Size(1106, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.FiltroEstatico = "EsNulo = 0 And Fecha_Deleted Is Null And Registro_Id > 0";
            this.Name = "FormContaEstadosGenerados";
            this.NombreCampoID = "Registro_Id";
            this.TablaOVista = "VCONTA_ESTADOS_GENERADOS";
            this.Text = "ESTADOS FINANCIEROS GENERADOS";
            this.Load += new System.EventHandler(this.FormContaEstadosGenerados_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Registro_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicionado_Por;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Modificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAcumulado;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha2;
        private System.Windows.Forms.Label label8;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha1;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRCombobox cboEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImprimirCatalogo;
    }
}