namespace ERPGenLicense
{
    partial class FormGenerarLicense
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoActivacion = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroSerial = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerar1 = new System.Windows.Forms.Button();
            this.btnGenerar3 = new System.Windows.Forms.Button();
            this.btnGenerar12 = new System.Windows.Forms.Button();
            this.btnGenerar0 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 508);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 65);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(512, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 508);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(659, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoActivacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 202);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Codigo Activacion]";
            // 
            // txtCodigoActivacion
            // 
            this.txtCodigoActivacion.AMostrar = null;
            this.txtCodigoActivacion.autoSenTab = true;
            this.txtCodigoActivacion.AValidar = null;
            this.txtCodigoActivacion.BackColor = System.Drawing.Color.White;
            this.txtCodigoActivacion.CampoBusquedaID = "";
            this.txtCodigoActivacion.CampoData = "";
            this.txtCodigoActivacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoActivacion.ColumnasBusqGeneral = null;
            this.txtCodigoActivacion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoActivacion.Decimales = 0;
            this.txtCodigoActivacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoActivacion.DSData = null;
            this.txtCodigoActivacion.EsAutoGenerado = false;
            this.txtCodigoActivacion.EsBusqueda = false;
            this.txtCodigoActivacion.EsBusquedaAutoIncremental = false;
            this.txtCodigoActivacion.EsEditable = true;
            this.txtCodigoActivacion.FiltroBusqueda = "";
            this.txtCodigoActivacion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoActivacion.Location = new System.Drawing.Point(3, 31);
            this.txtCodigoActivacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoActivacion.Multiline = true;
            this.txtCodigoActivacion.Name = "txtCodigoActivacion";
            this.txtCodigoActivacion.NombreTabla = "";
            this.txtCodigoActivacion.ReadOnly = true;
            this.txtCodigoActivacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodigoActivacion.SepDecimal = '\0';
            this.txtCodigoActivacion.Size = new System.Drawing.Size(645, 168);
            this.txtCodigoActivacion.TabIndex = 9;
            this.txtCodigoActivacion.TablaOVistaBusqueda = "";
            this.txtCodigoActivacion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoActivacion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoActivacion.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNumeroSerial);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 255);
            this.panel2.TabIndex = 9;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "WIN32",
            "WEB"});
            this.cboTipo.Location = new System.Drawing.Point(10, 49);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(528, 38);
            this.cboTipo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipo:";
            // 
            // txtNumeroSerial
            // 
            this.txtNumeroSerial.AMostrar = null;
            this.txtNumeroSerial.autoSenTab = true;
            this.txtNumeroSerial.AValidar = null;
            this.txtNumeroSerial.CampoBusquedaID = "";
            this.txtNumeroSerial.CampoData = "";
            this.txtNumeroSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroSerial.ColumnasBusqGeneral = null;
            this.txtNumeroSerial.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNumeroSerial.Decimales = 0;
            this.txtNumeroSerial.DSData = null;
            this.txtNumeroSerial.EsAutoGenerado = false;
            this.txtNumeroSerial.EsBusqueda = false;
            this.txtNumeroSerial.EsBusquedaAutoIncremental = false;
            this.txtNumeroSerial.EsEditable = true;
            this.txtNumeroSerial.FiltroBusqueda = "";
            this.txtNumeroSerial.Formato = WinControl_ELR_NET.tbFormato.NoSpace;
            this.txtNumeroSerial.Location = new System.Drawing.Point(7, 134);
            this.txtNumeroSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroSerial.Name = "txtNumeroSerial";
            this.txtNumeroSerial.NombreTabla = "";
            this.txtNumeroSerial.SepDecimal = '\0';
            this.txtNumeroSerial.Size = new System.Drawing.Size(531, 35);
            this.txtNumeroSerial.TabIndex = 13;
            this.txtNumeroSerial.TablaOVistaBusqueda = "";
            this.txtNumeroSerial.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumeroSerial.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumeroSerial.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero Serial:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnGenerar0);
            this.panel3.Controls.Add(this.btnGenerar12);
            this.panel3.Controls.Add(this.btnGenerar3);
            this.panel3.Controls.Add(this.btnGenerar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 61);
            this.panel3.TabIndex = 19;
            // 
            // btnGenerar1
            // 
            this.btnGenerar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar1.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar1.Margin = new System.Windows.Forms.Padding(10);
            this.btnGenerar1.Name = "btnGenerar1";
            this.btnGenerar1.Size = new System.Drawing.Size(150, 57);
            this.btnGenerar1.TabIndex = 15;
            this.btnGenerar1.Text = "1 MES";
            this.btnGenerar1.UseVisualStyleBackColor = true;
            this.btnGenerar1.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGenerar3
            // 
            this.btnGenerar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar3.Location = new System.Drawing.Point(150, 0);
            this.btnGenerar3.Margin = new System.Windows.Forms.Padding(10);
            this.btnGenerar3.Name = "btnGenerar3";
            this.btnGenerar3.Size = new System.Drawing.Size(149, 57);
            this.btnGenerar3.TabIndex = 16;
            this.btnGenerar3.Text = "3 MESES";
            this.btnGenerar3.UseVisualStyleBackColor = true;
            this.btnGenerar3.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGenerar12
            // 
            this.btnGenerar12.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar12.Location = new System.Drawing.Point(299, 0);
            this.btnGenerar12.Margin = new System.Windows.Forms.Padding(10);
            this.btnGenerar12.Name = "btnGenerar12";
            this.btnGenerar12.Size = new System.Drawing.Size(149, 57);
            this.btnGenerar12.TabIndex = 17;
            this.btnGenerar12.Text = "1 ANIO";
            this.btnGenerar12.UseVisualStyleBackColor = true;
            this.btnGenerar12.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGenerar0
            // 
            this.btnGenerar0.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar0.Location = new System.Drawing.Point(448, 0);
            this.btnGenerar0.Margin = new System.Windows.Forms.Padding(10);
            this.btnGenerar0.Name = "btnGenerar0";
            this.btnGenerar0.Size = new System.Drawing.Size(149, 57);
            this.btnGenerar0.TabIndex = 18;
            this.btnGenerar0.Text = "Indefinido";
            this.btnGenerar0.UseVisualStyleBackColor = true;
            this.btnGenerar0.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FormGenerarLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 573);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FormGenerarLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR CODIGO ACTIVACION";
            this.Load += new System.EventHandler(this.FormGenerarLicense_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtCodigoActivacion;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRTextBox txtNumeroSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerar0;
        private System.Windows.Forms.Button btnGenerar12;
        private System.Windows.Forms.Button btnGenerar3;
        private System.Windows.Forms.Button btnGenerar1;
    }
}