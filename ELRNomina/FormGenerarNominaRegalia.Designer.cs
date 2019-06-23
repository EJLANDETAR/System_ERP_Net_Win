namespace ELRNomina
{
    partial class FormGenerarNominaRegalia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNominaId = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new WinControl_ELR_NET.ELRLabel();
            this.dtgNominaDetalle = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_APagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuincenasRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNominaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 503);
            this.pnBotones.Size = new System.Drawing.Size(1011, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(771, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(912, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(676, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(581, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNominaId);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.cboOficina);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 93);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nomina Regalia Pascual";
            // 
            // lblNominaId
            // 
            this.lblNominaId.AutoSize = true;
            this.lblNominaId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominaId.Location = new System.Drawing.Point(290, 50);
            this.lblNominaId.Name = "lblNominaId";
            this.lblNominaId.Size = new System.Drawing.Size(232, 32);
            this.lblNominaId.TabIndex = 8;
            this.lblNominaId.Text = "Nomina: 00000000";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(147, 50);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(128, 35);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(14, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(127, 35);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboOficina
            // 
            this.cboOficina.AValidar = null;
            this.cboOficina.CampoData = "";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DisplayMember = "Nombre";
            this.cboOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficina.DSData = null;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(95, 13);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(427, 29);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 5;
            this.cboOficina.TablaOVistaConsulta = "";
            this.cboOficina.UsaDataGlobal = false;
            this.cboOficina.ValorPorDefecto = "0";
            this.cboOficina.ValueMember = "Oficina_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oficina:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 53);
            this.panel2.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.CampoData = "";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.DSData = null;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.NombreTabla = "";
            this.lblTotal.Size = new System.Drawing.Size(1007, 49);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Acumulado: 0.00        Quincena Pendiente: 0.00              Total: 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.ValorPorDefecto = "";
            // 
            // dtgNominaDetalle
            // 
            this.dtgNominaDetalle.AllowUserToAddRows = false;
            this.dtgNominaDetalle.AllowUserToDeleteRows = false;
            this.dtgNominaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNominaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.IdentificadorTemp,
            this.Empleado_Id,
            this.CedulaRNC,
            this.Nombre,
            this.Salario,
            this.Acumulado,
            this.Pendiente,
            this.Monto_APagar,
            this.QuincenasRest});
            this.dtgNominaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNominaDetalle.Location = new System.Drawing.Point(0, 93);
            this.dtgNominaDetalle.Name = "dtgNominaDetalle";
            this.dtgNominaDetalle.RowHeadersWidth = 28;
            this.dtgNominaDetalle.RowTemplate.Height = 35;
            this.dtgNominaDetalle.Size = new System.Drawing.Size(1011, 357);
            this.dtgNominaDetalle.TabIndex = 4;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // IdentificadorTemp
            // 
            this.IdentificadorTemp.DataPropertyName = "IdentificadorTemp";
            this.IdentificadorTemp.HeaderText = "IdentificadorTemp";
            this.IdentificadorTemp.Name = "IdentificadorTemp";
            this.IdentificadorTemp.ReadOnly = true;
            this.IdentificadorTemp.Visible = false;
            // 
            // Empleado_Id
            // 
            this.Empleado_Id.DataPropertyName = "Empleado_Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado_Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Empleado_Id.HeaderText = "Codigo";
            this.Empleado_Id.Name = "Empleado_Id";
            this.Empleado_Id.ReadOnly = true;
            this.Empleado_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CedulaRNC
            // 
            this.CedulaRNC.DataPropertyName = "CedulaRNC";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaRNC.DefaultCellStyle = dataGridViewCellStyle2;
            this.CedulaRNC.HeaderText = "Cedula";
            this.CedulaRNC.Name = "CedulaRNC";
            this.CedulaRNC.ReadOnly = true;
            this.CedulaRNC.Width = 140;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Salario.DefaultCellStyle = dataGridViewCellStyle4;
            this.Salario.HeaderText = "Salario M.";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Width = 135;
            // 
            // Acumulado
            // 
            this.Acumulado.DataPropertyName = "Acumulado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Acumulado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Acumulado.HeaderText = "Salario Acum.";
            this.Acumulado.Name = "Acumulado";
            this.Acumulado.ReadOnly = true;
            this.Acumulado.Width = 150;
            // 
            // Pendiente
            // 
            this.Pendiente.DataPropertyName = "Pendiente";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Pendiente.DefaultCellStyle = dataGridViewCellStyle6;
            this.Pendiente.HeaderText = "Pendiente";
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.ReadOnly = true;
            this.Pendiente.Width = 150;
            // 
            // Monto_APagar
            // 
            this.Monto_APagar.DataPropertyName = "Monto_APagar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Monto_APagar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Monto_APagar.HeaderText = "Sueldo Neto";
            this.Monto_APagar.Name = "Monto_APagar";
            this.Monto_APagar.Width = 150;
            // 
            // QuincenasRest
            // 
            this.QuincenasRest.DataPropertyName = "QuincenasRest";
            this.QuincenasRest.HeaderText = "QuincenasRest";
            this.QuincenasRest.Name = "QuincenasRest";
            this.QuincenasRest.Visible = false;
            // 
            // FormGenerarNominaRegalia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 546);
            this.Controls.Add(this.dtgNominaDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dtgNominaDetalle;
            this.EsConTemporal = true;
            this.Name = "FormGenerarNominaRegalia";
            this.TablaDetalle = "TTEMPORAL_NOMINAS_DETALLE";
            this.Text = "GENERAR NOMINA REGALIA PASCUAL (SUELDO 13)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGenerarNominaRegalia_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dtgNominaDetalle, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNominaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnGenerar;
        private WinControl_ELR_NET.ELRCombobox cboOficina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgNominaDetalle;
        private WinControl_ELR_NET.ELRLabel lblTotal;
        private System.Windows.Forms.Label lblNominaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_APagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuincenasRest;
    }
}