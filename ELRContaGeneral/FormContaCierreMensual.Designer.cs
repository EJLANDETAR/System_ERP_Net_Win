namespace ELRContaGeneral
{
    partial class FormContaCierreMensual
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCatalogoBalance = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Mes_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAnio = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMes = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaActualizado = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.btnCerrarMes = new System.Windows.Forms.Button();
            this.btnImprimirCatalogo = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogoBalance)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnImprimirCatalogo);
            this.pnBotones.Location = new System.Drawing.Point(0, 420);
            this.pnBotones.Size = new System.Drawing.Size(869, 52);
            this.pnBotones.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnGrabar, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnSiguientePage, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnAnterior, 0);
            this.pnBotones.Controls.SetChildIndex(this.lblNombreUsuario, 0);
            this.pnBotones.Controls.SetChildIndex(this.btnImprimirCatalogo, 0);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(602, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 48);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(743, 0);
            this.btnCancelar.Size = new System.Drawing.Size(122, 48);
            this.btnCancelar.Text = "&Cerrar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(53, 0);
            this.btnAnterior.Size = new System.Drawing.Size(95, 48);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(495, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(107, 48);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(148, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(347, 48);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCatalogoBalance);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalogo Balance";
            // 
            // dtgCatalogoBalance
            // 
            this.dtgCatalogoBalance.AllowUserToAddRows = false;
            this.dtgCatalogoBalance.AllowUserToDeleteRows = false;
            this.dtgCatalogoBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCatalogoBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Saldo_Mes_Anterior,
            this.Debito_Mes,
            this.Credito_Mes,
            this.Saldo_Actual});
            this.dtgCatalogoBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCatalogoBalance.Location = new System.Drawing.Point(3, 25);
            this.dtgCatalogoBalance.Name = "dtgCatalogoBalance";
            this.dtgCatalogoBalance.ReadOnly = true;
            this.dtgCatalogoBalance.RowHeadersWidth = 28;
            this.dtgCatalogoBalance.RowTemplate.Height = 33;
            this.dtgCatalogoBalance.Size = new System.Drawing.Size(863, 233);
            this.dtgCatalogoBalance.TabIndex = 1;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Cuenta";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Saldo_Mes_Anterior
            // 
            this.Saldo_Mes_Anterior.DataPropertyName = "Saldo_Mes_Anterior";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Saldo_Mes_Anterior.DefaultCellStyle = dataGridViewCellStyle5;
            this.Saldo_Mes_Anterior.HeaderText = "S. Mes Anterior";
            this.Saldo_Mes_Anterior.Name = "Saldo_Mes_Anterior";
            this.Saldo_Mes_Anterior.ReadOnly = true;
            this.Saldo_Mes_Anterior.Width = 150;
            // 
            // Debito_Mes
            // 
            this.Debito_Mes.DataPropertyName = "Debito_Mes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Debito_Mes.DefaultCellStyle = dataGridViewCellStyle6;
            this.Debito_Mes.HeaderText = "Debito Mes";
            this.Debito_Mes.Name = "Debito_Mes";
            this.Debito_Mes.ReadOnly = true;
            this.Debito_Mes.Width = 150;
            // 
            // Credito_Mes
            // 
            this.Credito_Mes.DataPropertyName = "Credito_Mes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Credito_Mes.DefaultCellStyle = dataGridViewCellStyle7;
            this.Credito_Mes.HeaderText = "Credito Mes";
            this.Credito_Mes.Name = "Credito_Mes";
            this.Credito_Mes.ReadOnly = true;
            this.Credito_Mes.Width = 150;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.DataPropertyName = "Saldo_Actual";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.Saldo_Actual.DefaultCellStyle = dataGridViewCellStyle8;
            this.Saldo_Actual.HeaderText = "S. Actual";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.ReadOnly = true;
            this.Saldo_Actual.Width = 160;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDiferencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 49);
            this.panel2.TabIndex = 5;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiferencia.ForeColor = System.Drawing.Color.Red;
            this.lblDiferencia.Location = new System.Drawing.Point(0, 0);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(865, 45);
            this.lblDiferencia.TabIndex = 1;
            this.lblDiferencia.Text = "Diferencia: 0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtAnio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboMes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFechaActualizado);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Controls.Add(this.btnCerrarMes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 110);
            this.panel1.TabIndex = 4;
            // 
            // txtAnio
            // 
            this.txtAnio.AMostrar = null;
            this.txtAnio.autoSenTab = true;
            this.txtAnio.AValidar = null;
            this.txtAnio.CampoBusquedaID = "";
            this.txtAnio.CampoData = "";
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnio.ColumnasBusqGeneral = null;
            this.txtAnio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAnio.Decimales = 0;
            this.txtAnio.DSData = null;
            this.txtAnio.EsAutoGenerado = false;
            this.txtAnio.EsBusqueda = false;
            this.txtAnio.EsBusquedaAutoIncremental = false;
            this.txtAnio.EsEditable = true;
            this.txtAnio.FiltroBusqueda = "";
            this.txtAnio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Formato = WinControl_ELR_NET.tbFormato.SoloNumero;
            this.txtAnio.Location = new System.Drawing.Point(313, 22);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.NombreTabla = "";
            this.txtAnio.SepDecimal = '\0';
            this.txtAnio.Size = new System.Drawing.Size(77, 29);
            this.txtAnio.TabIndex = 21;
            this.txtAnio.TablaOVistaBusqueda = "";
            this.txtAnio.Text = "0000";
            this.txtAnio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAnio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAnio.ValorPorDefecto = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Año:";
            // 
            // cboMes
            // 
            this.cboMes.AValidar = null;
            this.cboMes.CampoData = "";
            this.cboMes.CampoJoinCombobox2 = "";
            this.cboMes.ComboboxAFiltrar = null;
            this.cboMes.DisplayMember = "Descripcion";
            this.cboMes.DSData = null;
            this.cboMes.EsEditable = true;
            this.cboMes.FiltroBusqueda = "EsActivo = 1 And Nombre_Tabla = \'MESES\'";
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(58, 22);
            this.cboMes.Name = "cboMes";
            this.cboMes.NombreTabla = "";
            this.cboMes.Size = new System.Drawing.Size(192, 29);
            this.cboMes.SSQL = "";
            this.cboMes.TabIndex = 19;
            this.cboMes.TablaOVistaConsulta = "TSISTEMA_TABLA_AUXILIAR";
            this.cboMes.UsaDataGlobal = true;
            this.cboMes.ValorPorDefecto = "0";
            this.cboMes.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mes:";
            // 
            // lblFechaActualizado
            // 
            this.lblFechaActualizado.AutoSize = true;
            this.lblFechaActualizado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActualizado.Location = new System.Drawing.Point(418, 51);
            this.lblFechaActualizado.Name = "lblFechaActualizado";
            this.lblFechaActualizado.Size = new System.Drawing.Size(116, 25);
            this.lblFechaActualizado.TabIndex = 16;
            this.lblFechaActualizado.Text = "00/00/0000";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.Green;
            this.lblEstatus.Location = new System.Drawing.Point(418, 18);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(378, 30);
            this.lblEstatus.TabIndex = 15;
            this.lblEstatus.Text = "ACTUALIZADO\\POSTEADO A FECHA:";
            // 
            // btnCerrarMes
            // 
            this.btnCerrarMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMes.Location = new System.Drawing.Point(14, 54);
            this.btnCerrarMes.Name = "btnCerrarMes";
            this.btnCerrarMes.Size = new System.Drawing.Size(376, 35);
            this.btnCerrarMes.TabIndex = 14;
            this.btnCerrarMes.Text = "Cerrar Mes";
            this.btnCerrarMes.UseVisualStyleBackColor = true;
            this.btnCerrarMes.Click += new System.EventHandler(this.btnCerrarMes_Click);
            // 
            // btnImprimirCatalogo
            // 
            this.btnImprimirCatalogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimirCatalogo.Location = new System.Drawing.Point(302, 0);
            this.btnImprimirCatalogo.Name = "btnImprimirCatalogo";
            this.btnImprimirCatalogo.Size = new System.Drawing.Size(193, 48);
            this.btnImprimirCatalogo.TabIndex = 8;
            this.btnImprimirCatalogo.Text = "Imprimir Catalogo";
            this.btnImprimirCatalogo.UseVisualStyleBackColor = true;
            this.btnImprimirCatalogo.Click += new System.EventHandler(this.btnImprimirCatalogo_Click);
            // 
            // FormContaCierreMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcluirValidacionCierre = true;
            this.Name = "FormContaCierreMensual";
            this.TablaEncabezado = "TCONTAAAAAA";
            this.Text = "CONTABILIDAD GENERAL, REALIZAR CIERRE MENSUAL";
            this.Load += new System.EventHandler(this.FormContaCierreMensual_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogoBalance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaActualizado;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Button btnCerrarMes;
        private WinControl_ELR_NET.ELRCombobox cboMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgCatalogoBalance;
        private WinControl_ELR_NET.ELRTextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Mes_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.Button btnImprimirCatalogo;
    }
}