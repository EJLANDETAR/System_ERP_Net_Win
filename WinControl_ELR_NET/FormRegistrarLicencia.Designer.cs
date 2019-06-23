namespace WinControl_ELR_NET
{
    partial class FormRegistrarLicencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCodigoActivacion = new WinControl_ELR_NET.ELRTextBox();
            this.txtNumeroSerial = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo Activacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero Serial:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 65);
            this.panel1.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrar.Location = new System.Drawing.Point(274, 0);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 61);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(437, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(163, 61);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtCodigoActivacion
            // 
            this.txtCodigoActivacion.AMostrar = null;
            this.txtCodigoActivacion.AValidar = null;
            this.txtCodigoActivacion.BackColor = System.Drawing.Color.White;
            this.txtCodigoActivacion.CampoBusquedaID = "";
            this.txtCodigoActivacion.CampoData = "";
            this.txtCodigoActivacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoActivacion.ColumnasBusqGeneral = null;
            this.txtCodigoActivacion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoActivacion.Decimales = 0;
            this.txtCodigoActivacion.DSData = null;
            this.txtCodigoActivacion.EsAutoGenerado = false;
            this.txtCodigoActivacion.EsBusqueda = false;
            this.txtCodigoActivacion.EsBusquedaAutoIncremental = false;
            this.txtCodigoActivacion.EsEditable = true;
            this.txtCodigoActivacion.FiltroBusqueda = "";
            this.txtCodigoActivacion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoActivacion.Location = new System.Drawing.Point(23, 263);
            this.txtCodigoActivacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoActivacion.Multiline = true;
            this.txtCodigoActivacion.Name = "txtCodigoActivacion";
            this.txtCodigoActivacion.NombreTabla = "";
            this.txtCodigoActivacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodigoActivacion.SepDecimal = '\0';
            this.txtCodigoActivacion.Size = new System.Drawing.Size(575, 144);
            this.txtCodigoActivacion.TabIndex = 8;
            this.txtCodigoActivacion.TablaOVistaBusqueda = "";
            this.txtCodigoActivacion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoActivacion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoActivacion.ValorPorDefecto = "";
            // 
            // txtNumeroSerial
            // 
            this.txtNumeroSerial.AMostrar = null;
            this.txtNumeroSerial.AValidar = null;
            this.txtNumeroSerial.BackColor = System.Drawing.Color.White;
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
            this.txtNumeroSerial.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNumeroSerial.Location = new System.Drawing.Point(19, 126);
            this.txtNumeroSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroSerial.Multiline = true;
            this.txtNumeroSerial.Name = "txtNumeroSerial";
            this.txtNumeroSerial.NombreTabla = "";
            this.txtNumeroSerial.ReadOnly = true;
            this.txtNumeroSerial.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNumeroSerial.SepDecimal = '\0';
            this.txtNumeroSerial.Size = new System.Drawing.Size(575, 83);
            this.txtNumeroSerial.TabIndex = 6;
            this.txtNumeroSerial.TablaOVistaBusqueda = "";
            this.txtNumeroSerial.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNumeroSerial.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNumeroSerial.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 88);
            this.panel2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(600, 84);
            this.textBox1.TabIndex = 0;
            // 
            // FormRegistrarLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCodigoActivacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroSerial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR LICENCIA";
            this.Load += new System.EventHandler(this.FormRegistrarLicencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ELRTextBox txtCodigoActivacion;
        private System.Windows.Forms.Label label2;
        private ELRTextBox txtNumeroSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}