namespace WinControl_ELR_NET
{
    partial class FormSuCambio
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
            this.lblSuCambio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnMatricial = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCerrrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSuCambio
            // 
            this.lblSuCambio.AutoSize = true;
            this.lblSuCambio.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuCambio.Location = new System.Drawing.Point(21, 44);
            this.lblSuCambio.Name = "lblSuCambio";
            this.lblSuCambio.Size = new System.Drawing.Size(237, 40);
            this.lblSuCambio.TabIndex = 1;
            this.lblSuCambio.Text = "Su Cambio: 0.00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnTicket);
            this.panel1.Controls.Add(this.btnMatricial);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnCerrrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 64);
            this.panel1.TabIndex = 2;
            // 
            // btnTicket
            // 
            this.btnTicket.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTicket.Image = global::WinControl_ELR_NET.Properties.Resources.Note_26px;
            this.btnTicket.Location = new System.Drawing.Point(26, 0);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(133, 60);
            this.btnTicket.TabIndex = 7;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnMatricial
            // 
            this.btnMatricial.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMatricial.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMatricial.Image = global::WinControl_ELR_NET.Properties.Resources.print;
            this.btnMatricial.Location = new System.Drawing.Point(159, 0);
            this.btnMatricial.Name = "btnMatricial";
            this.btnMatricial.Size = new System.Drawing.Size(133, 60);
            this.btnMatricial.TabIndex = 6;
            this.btnMatricial.Text = "Matricial";
            this.btnMatricial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatricial.UseVisualStyleBackColor = true;
            this.btnMatricial.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPreview.Image = global::WinControl_ELR_NET.Properties.Resources.preview;
            this.btnPreview.Location = new System.Drawing.Point(292, 0);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(133, 60);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Visualizar";
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrrar
            // 
            this.btnCerrrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrrar.Image = global::WinControl_ELR_NET.Properties.Resources._1379618331_exit;
            this.btnCerrrar.Location = new System.Drawing.Point(425, 0);
            this.btnCerrrar.Name = "btnCerrrar";
            this.btnCerrrar.Size = new System.Drawing.Size(118, 60);
            this.btnCerrrar.TabIndex = 3;
            this.btnCerrrar.Text = "Cerrar";
            this.btnCerrrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrrar.UseVisualStyleBackColor = true;
            this.btnCerrrar.Click += new System.EventHandler(this.btnCerrrar_Click);
            // 
            // FormSuCambio
            // 
            this.AcceptButton = this.btnCerrrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSuCambio);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A DEVOLVER";
            this.Load += new System.EventHandler(this.FormSuCambio_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSuCambio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrrar;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnMatricial;
        private System.Windows.Forms.Button btnTicket;
    }
}