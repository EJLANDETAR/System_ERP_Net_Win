namespace ELRFacturas
{
    partial class FormPrestamosDescuentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDescontarTodo = new System.Windows.Forms.Button();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblEntidadId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalOtros = new System.Windows.Forms.Label();
            this.lblTotalDemora = new System.Windows.Forms.Label();
            this.lblTotalInteres = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otros_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 520);
            this.pnBotones.Size = new System.Drawing.Size(984, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(744, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(885, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(649, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(554, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDescontarTodo);
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Controls.Add(this.lblEntidadId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 71);
            this.panel1.TabIndex = 1;
            // 
            // btnDescontarTodo
            // 
            this.btnDescontarTodo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDescontarTodo.Location = new System.Drawing.Point(818, 0);
            this.btnDescontarTodo.Name = "btnDescontarTodo";
            this.btnDescontarTodo.Size = new System.Drawing.Size(162, 67);
            this.btnDescontarTodo.TabIndex = 5;
            this.btnDescontarTodo.Text = "Descontar Todo";
            this.btnDescontarTodo.UseVisualStyleBackColor = true;
            this.btnDescontarTodo.Click += new System.EventHandler(this.btnDescontarTodo_Click);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(12, 36);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(316, 25);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "NOMBRE COMPLETO DEL CLIENTE";
            // 
            // lblEntidadId
            // 
            this.lblEntidadId.AutoSize = true;
            this.lblEntidadId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadId.Location = new System.Drawing.Point(125, 11);
            this.lblEntidadId.Name = "lblEntidadId";
            this.lblEntidadId.Size = new System.Drawing.Size(100, 25);
            this.lblEntidadId.TabIndex = 1;
            this.lblEntidadId.Text = "00000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entidad Id:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 180);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Concepto";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(3, 25);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(613, 148);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblTotalOtros);
            this.panel3.Controls.Add(this.lblTotalDemora);
            this.panel3.Controls.Add(this.lblTotalInteres);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(619, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 176);
            this.panel3.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(357, 44);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalOtros
            // 
            this.lblTotalOtros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalOtros.Location = new System.Drawing.Point(178, 85);
            this.lblTotalOtros.Name = "lblTotalOtros";
            this.lblTotalOtros.Size = new System.Drawing.Size(167, 31);
            this.lblTotalOtros.TabIndex = 6;
            this.lblTotalOtros.Text = "0.00";
            this.lblTotalOtros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDemora
            // 
            this.lblTotalDemora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDemora.Location = new System.Drawing.Point(178, 46);
            this.lblTotalDemora.Name = "lblTotalDemora";
            this.lblTotalDemora.Size = new System.Drawing.Size(167, 31);
            this.lblTotalDemora.TabIndex = 5;
            this.lblTotalDemora.Text = "0.00";
            this.lblTotalDemora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalInteres
            // 
            this.lblTotalInteres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalInteres.Location = new System.Drawing.Point(178, 10);
            this.lblTotalInteres.Name = "lblTotalInteres";
            this.lblTotalInteres.Size = new System.Drawing.Size(167, 31);
            this.lblTotalInteres.TabIndex = 4;
            this.lblTotalInteres.Text = "0.00";
            this.lblTotalInteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descto. Otros:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descto. Demora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descto. Interes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuota_No,
            this.Descripcion,
            this.Interes_Pendiente,
            this.Demora_Pendiente,
            this.Otros_Pendiente,
            this.Interes,
            this.Demora,
            this.Otros});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(984, 269);
            this.dataGridView1.TabIndex = 3;
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
            // Cuota_No
            // 
            this.Cuota_No.DataPropertyName = "No";
            this.Cuota_No.HeaderText = "No";
            this.Cuota_No.Name = "Cuota_No";
            this.Cuota_No.ReadOnly = true;
            this.Cuota_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cuota_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cuota_No.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Interes_Pendiente
            // 
            this.Interes_Pendiente.DataPropertyName = "Interes_Pendiente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Interes_Pendiente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Interes_Pendiente.HeaderText = "Interes P.";
            this.Interes_Pendiente.Name = "Interes_Pendiente";
            this.Interes_Pendiente.ReadOnly = true;
            this.Interes_Pendiente.Width = 110;
            // 
            // Demora_Pendiente
            // 
            this.Demora_Pendiente.DataPropertyName = "Demora_Pendiente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Demora_Pendiente.DefaultCellStyle = dataGridViewCellStyle2;
            this.Demora_Pendiente.HeaderText = "Demora P.";
            this.Demora_Pendiente.Name = "Demora_Pendiente";
            this.Demora_Pendiente.ReadOnly = true;
            this.Demora_Pendiente.Width = 110;
            // 
            // Otros_Pendiente
            // 
            this.Otros_Pendiente.DataPropertyName = "Otros_Pendiente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Otros_Pendiente.DefaultCellStyle = dataGridViewCellStyle3;
            this.Otros_Pendiente.HeaderText = "Otros P.";
            this.Otros_Pendiente.Name = "Otros_Pendiente";
            this.Otros_Pendiente.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "D_Interes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Interes.HeaderText = "D. Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // Demora
            // 
            this.Demora.DataPropertyName = "D_Demora";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Demora.DefaultCellStyle = dataGridViewCellStyle5;
            this.Demora.HeaderText = "D. Demora";
            this.Demora.Name = "Demora";
            this.Demora.ReadOnly = true;
            this.Demora.Width = 110;
            // 
            // Otros
            // 
            this.Otros.DataPropertyName = "D_Otros";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otros.DefaultCellStyle = dataGridViewCellStyle6;
            this.Otros.HeaderText = "D. Otros";
            this.Otros.Name = "Otros";
            this.Otros.ReadOnly = true;
            // 
            // FormPrestamosDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.MensajePregunta = "¿Esta Seguro Que Desea Aplicar Este Descuento?";
            this.Name = "FormPrestamosDescuentos";
            this.NombreCampoID = "Unico";
            this.SPCargaATemporal = "SP_TEMPORAL_PRESTAMOS_DESCUENTOS";
            this.SPGraba = "SP_PRESTAMOS_APLICAR_DESCUENTO";
            this.TablaDetalle = "TTEMPORAL_PRESTAMOS_DESCUENTOS_DETALLES";
            this.TablaEncabezado = "TTEMPORAL_PRESTAMOS_DESCUENTOS";
            this.Text = "APLICAR DESCUENTO A CREDITO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblEntidadId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDescontarTodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalOtros;
        private System.Windows.Forms.Label lblTotalDemora;
        private System.Windows.Forms.Label lblTotalInteres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewLinkColumn Cuota_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demora_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otros_Pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otros;
    }
}