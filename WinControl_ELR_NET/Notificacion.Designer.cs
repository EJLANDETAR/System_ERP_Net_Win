namespace WinControl_ELR_NET
{
    partial class Notificacion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lnkOcultar = new System.Windows.Forms.LinkLabel();
            this.lnkVerMas = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(5, 5);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(379, 154);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje Primera notificacion ok si si";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Click += new System.EventHandler(this.lnkVerMas_Click);
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.lnkOcultar);
            this.pnBottom.Controls.Add(this.lnkVerMas);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(5, 159);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(379, 61);
            this.pnBottom.TabIndex = 3;
            // 
            // lnkOcultar
            // 
            this.lnkOcultar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkOcultar.ForeColor = System.Drawing.Color.White;
            this.lnkOcultar.LinkColor = System.Drawing.Color.White;
            this.lnkOcultar.Location = new System.Drawing.Point(257, 0);
            this.lnkOcultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkOcultar.Name = "lnkOcultar";
            this.lnkOcultar.Size = new System.Drawing.Size(122, 61);
            this.lnkOcultar.TabIndex = 1;
            this.lnkOcultar.TabStop = true;
            this.lnkOcultar.Text = "Ocultar";
            this.lnkOcultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkOcultar.Click += new System.EventHandler(this.lnkOcultar_Click);
            // 
            // lnkVerMas
            // 
            this.lnkVerMas.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkVerMas.ForeColor = System.Drawing.Color.White;
            this.lnkVerMas.LinkColor = System.Drawing.Color.White;
            this.lnkVerMas.Location = new System.Drawing.Point(0, 0);
            this.lnkVerMas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkVerMas.Name = "lnkVerMas";
            this.lnkVerMas.Size = new System.Drawing.Size(122, 61);
            this.lnkVerMas.TabIndex = 0;
            this.lnkVerMas.TabStop = true;
            this.lnkVerMas.Text = "Ver Mas...";
            this.lnkVerMas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkVerMas.Click += new System.EventHandler(this.lnkVerMas_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Notificacion";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(389, 225);
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.LinkLabel lnkOcultar;
        private System.Windows.Forms.LinkLabel lnkVerMas;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
