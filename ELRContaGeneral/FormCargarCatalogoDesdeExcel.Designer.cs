namespace ELRContaGeneral
{
    partial class FormCargarCatalogoDesdeExcel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreArchivo = new WinControl_ELR_NET.ELRTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboCargarCon = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficina_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opFD = new System.Windows.Forms.OpenFileDialog();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 412);
            this.pnBotones.Size = new System.Drawing.Size(1026, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(786, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            this.btnGrabar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(927, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(691, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.btnSiguientePage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(596, 39);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNombreArchivo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 92);
            this.panel1.TabIndex = 0;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.AMostrar = null;
            this.txtNombreArchivo.autoSenTab = true;
            this.txtNombreArchivo.AValidar = null;
            this.txtNombreArchivo.BackColor = System.Drawing.Color.White;
            this.txtNombreArchivo.CampoBusquedaID = "";
            this.txtNombreArchivo.CampoData = "";
            this.txtNombreArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreArchivo.ColumnasBusqGeneral = null;
            this.txtNombreArchivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreArchivo.Decimales = 0;
            this.txtNombreArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreArchivo.DSData = null;
            this.txtNombreArchivo.EsAutoGenerado = false;
            this.txtNombreArchivo.EsBusqueda = false;
            this.txtNombreArchivo.EsBusquedaAutoIncremental = false;
            this.txtNombreArchivo.EsEditable = true;
            this.txtNombreArchivo.FiltroBusqueda = "";
            this.txtNombreArchivo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreArchivo.Location = new System.Drawing.Point(491, 0);
            this.txtNombreArchivo.Multiline = true;
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.NombreTabla = "";
            this.txtNombreArchivo.ReadOnly = true;
            this.txtNombreArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNombreArchivo.SepDecimal = '\0';
            this.txtNombreArchivo.Size = new System.Drawing.Size(531, 88);
            this.txtNombreArchivo.TabIndex = 3;
            this.txtNombreArchivo.TablaOVistaBusqueda = "";
            this.txtNombreArchivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreArchivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreArchivo.ValorPorDefecto = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cboCargarCon);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnBuscarArchivo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 88);
            this.panel3.TabIndex = 2;
            // 
            // cboCargarCon
            // 
            this.cboCargarCon.AValidar = null;
            this.cboCargarCon.CampoData = "";
            this.cboCargarCon.CampoJoinCombobox2 = "";
            this.cboCargarCon.ComboboxAFiltrar = null;
            this.cboCargarCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargarCon.DSData = null;
            this.cboCargarCon.EsEditable = true;
            this.cboCargarCon.FiltroBusqueda = "";
            this.cboCargarCon.FormattingEnabled = true;
            this.cboCargarCon.Location = new System.Drawing.Point(120, 10);
            this.cboCargarCon.Name = "cboCargarCon";
            this.cboCargarCon.NombreTabla = "";
            this.cboCargarCon.Size = new System.Drawing.Size(343, 29);
            this.cboCargarCon.SSQL = "";
            this.cboCargarCon.TabIndex = 1;
            this.cboCargarCon.TablaOVistaConsulta = "";
            this.cboCargarCon.UsaDataGlobal = false;
            this.cboCargarCon.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargar Con:";
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(120, 42);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(155, 38);
            this.btnBuscarArchivo.TabIndex = 2;
            this.btnBuscarArchivo.Text = "Buscar";
            this.btnBuscarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDiferencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 54);
            this.panel2.TabIndex = 2;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiferencia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Location = new System.Drawing.Point(0, 0);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(1022, 50);
            this.lblDiferencia.TabIndex = 0;
            this.lblDiferencia.Text = "Diferencia: 0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuenta_Contable,
            this.Descripcion,
            this.Oficina_Id,
            this.Saldo_Actual,
            this.IdentificadorTemp});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cta. Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Oficina_Id
            // 
            this.Oficina_Id.DataPropertyName = "Oficina_Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "0";
            this.Oficina_Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Oficina_Id.HeaderText = "Oficina";
            this.Oficina_Id.Name = "Oficina_Id";
            this.Oficina_Id.ReadOnly = true;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.DataPropertyName = "Saldo_Actual";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Saldo_Actual.DefaultCellStyle = dataGridViewCellStyle2;
            this.Saldo_Actual.HeaderText = "Saldo Actual";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.ReadOnly = true;
            this.Saldo_Actual.Width = 140;
            // 
            // IdentificadorTemp
            // 
            this.IdentificadorTemp.DataPropertyName = "IdentificadorTemp";
            this.IdentificadorTemp.HeaderText = "IdentificadorTemp";
            this.IdentificadorTemp.Name = "IdentificadorTemp";
            this.IdentificadorTemp.ReadOnly = true;
            this.IdentificadorTemp.Visible = false;
            // 
            // opFD
            // 
            this.opFD.FileName = "openFileDialog1";
            // 
            // FormCargarCatalogoDesdeExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormCargarCatalogoDesdeExcel";
            this.NombreCampoID = "Unico";
            this.SPGraba = "SP_CONTA_CARGAR_CATALOGO_EXCEL";
            this.TablaDetalle = "TTEMPORAL_CONTA_CATALOGO";
            this.TablaEncabezado = "TTEMPORAL_CONTA_CATALOGO";
            this.Text = "CARGAR CATALOGO DESDE EXCEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCargarCatalogoDesdeExcel_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.OpenFileDialog opFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficina_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorTemp;
        private WinControl_ELR_NET.ELRTextBox txtNombreArchivo;
        private System.Windows.Forms.Panel panel3;
        private WinControl_ELR_NET.ELRCombobox cboCargarCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarArchivo;
    }
}