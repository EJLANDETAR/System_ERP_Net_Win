namespace ELRContaGeneral
{
    partial class FormContaEstadosAGenerar
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpAFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEstado = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEstadosGenerados = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro_Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionado_Por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAnexo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstadosGenerados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 379);
            this.pnBotones.Size = new System.Drawing.Size(978, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(738, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(879, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(643, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(548, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.dtpAFecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 110);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(311, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(194, 40);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpAFecha
            // 
            this.dtpAFecha.AValidar = null;
            this.dtpAFecha.CampoData = "";
            this.dtpAFecha.DSData = null;
            this.dtpAFecha.EsEditable = true;
            this.dtpAFecha.FiltroBusqueda = "";
            this.dtpAFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAFecha.Location = new System.Drawing.Point(95, 54);
            this.dtpAFecha.Name = "dtpAFecha";
            this.dtpAFecha.NombreTabla = "";
            this.dtpAFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpAFecha.TabIndex = 3;
            this.dtpAFecha.ValorPorDefecto = new System.DateTime(2017, 2, 11, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Fecha:";
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
            this.cboEstado.Location = new System.Drawing.Point(95, 16);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.NombreTabla = "";
            this.cboEstado.Size = new System.Drawing.Size(410, 29);
            this.cboEstado.SSQL = "";
            this.cboEstado.TabIndex = 1;
            this.cboEstado.TablaOVistaConsulta = "";
            this.cboEstado.UsaDataGlobal = false;
            this.cboEstado.ValorPorDefecto = "0";
            this.cboEstado.ValueMember = "Estado_Id";
            this.cboEstado.SelectedValueChanged += new System.EventHandler(this.cboEstado_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // dtgEstadosGenerados
            // 
            this.dtgEstadosGenerados.AllowUserToAddRows = false;
            this.dtgEstadosGenerados.AllowUserToDeleteRows = false;
            this.dtgEstadosGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstadosGenerados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgEstadosGenerados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEstadosGenerados.Location = new System.Drawing.Point(0, 110);
            this.dtgEstadosGenerados.Name = "dtgEstadosGenerados";
            this.dtgEstadosGenerados.ReadOnly = true;
            this.dtgEstadosGenerados.RowHeadersWidth = 28;
            this.dtgEstadosGenerados.RowTemplate.Height = 33;
            this.dtgEstadosGenerados.Size = new System.Drawing.Size(978, 269);
            this.dtgEstadosGenerados.TabIndex = 49;
            this.dtgEstadosGenerados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEstadosGenerados_CellContentClick);
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
            this.Nombre_Mes.Width = 150;
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
            this.Adicionado_Por.Width = 175;
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
            this.Fecha_Modificado.Width = 200;
            // 
            // EsAnexo
            // 
            this.EsAnexo.DataPropertyName = "EsAnexo";
            this.EsAnexo.HeaderText = "EsAnexo";
            this.EsAnexo.Name = "EsAnexo";
            this.EsAnexo.ReadOnly = true;
            this.EsAnexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsAnexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsAnexo.Width = 85;
            // 
            // EsAcumulado
            // 
            this.EsAcumulado.DataPropertyName = "EsAcumulado";
            this.EsAcumulado.HeaderText = "EsAcumulado";
            this.EsAcumulado.Name = "EsAcumulado";
            this.EsAcumulado.ReadOnly = true;
            this.EsAcumulado.Visible = false;
            // 
            // FormContaEstadosAGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 422);
            this.Controls.Add(this.dtgEstadosGenerados);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcluirValidacionCierre = true;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FormContaEstadosAGenerar";
            this.TablaEncabezado = "TCONTA_ESTADOS";
            this.Text = "GENERAR ESTADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormContaEstadosAGenerar_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dtgEstadosGenerados, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstadosGenerados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerar;
        private WinControl_ELR_NET.ELRDatePicker dtpAFecha;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCombobox cboEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgEstadosGenerados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Registro_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicionado_Por;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Modificado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAcumulado;
    }
}