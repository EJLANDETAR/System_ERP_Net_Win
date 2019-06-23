namespace WinControl_ELR_NET
{
    partial class FormSplash
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tiempoVentana = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblModulos = new System.Windows.Forms.Label();
            this.lnkOcultar = new System.Windows.Forms.LinkLabel();
            this.ptbProcess = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnkOcultar);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(4, 9);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(100, 21);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Cargando....";
            // 
            // tiempoVentana
            // 
            this.tiempoVentana.Tick += new System.EventHandler(this.tiempoVentana_Tick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "  SISTEMA DE GESTION INTEGRADO (ERP)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModulos
            // 
            this.lblModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModulos.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos.Location = new System.Drawing.Point(0, 90);
            this.lblModulos.Name = "lblModulos";
            this.lblModulos.Size = new System.Drawing.Size(625, 328);
            this.lblModulos.TabIndex = 2;
            this.lblModulos.Text = "label2";
            // 
            // lnkOcultar
            // 
            this.lnkOcultar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkOcultar.LinkColor = System.Drawing.Color.White;
            this.lnkOcultar.Location = new System.Drawing.Point(466, 0);
            this.lnkOcultar.Name = "lnkOcultar";
            this.lnkOcultar.Size = new System.Drawing.Size(159, 42);
            this.lnkOcultar.TabIndex = 1;
            this.lnkOcultar.TabStop = true;
            this.lnkOcultar.Text = "Ocultar";
            this.lnkOcultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkOcultar.Visible = false;
            this.lnkOcultar.Click += new System.EventHandler(this.lnkOcultar_Click);
            // 
            // ptbProcess
            // 
            this.ptbProcess.Image = global::WinControl_ELR_NET.Properties.Resources.loading__1_;
            this.ptbProcess.Location = new System.Drawing.Point(18, 76);
            this.ptbProcess.Name = "ptbProcess";
            this.ptbProcess.Size = new System.Drawing.Size(86, 58);
            this.ptbProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProcess.TabIndex = 12;
            this.ptbProcess.TabStop = false;
            this.ptbProcess.Visible = false;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(625, 460);
            this.ControlBox = false;
            this.Controls.Add(this.ptbProcess);
            this.Controls.Add(this.lblModulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSplash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tiempoVentana;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModulos;
        private System.Windows.Forms.LinkLabel lnkOcultar;
        private System.Windows.Forms.PictureBox ptbProcess;
    }
}