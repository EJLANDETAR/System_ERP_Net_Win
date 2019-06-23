namespace ELRCuentasPorPagar
{
    partial class FormComprasAprobarAnularR
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
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 398);
            this.pnBotones.Size = new System.Drawing.Size(821, 57);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(522, 0);
            this.btnGrabar.Size = new System.Drawing.Size(162, 53);
            this.btnGrabar.Text = "Ctrl+G = &Aprobar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(684, 0);
            this.btnCancelar.Size = new System.Drawing.Size(133, 53);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 53);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(376, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(146, 53);
            this.btnSiguientePage.Text = "&Rechazar";
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            this.btnSiguientePage.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(281, 53);
            // 
            // rpvReporte
            // 
            this.rpvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvReporte.Location = new System.Drawing.Point(0, 0);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.Size = new System.Drawing.Size(821, 398);
            this.rpvReporte.TabIndex = 1;
            // 
            // FormComprasAprobarAnularR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 455);
            this.Controls.Add(this.rpvReporte);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MyReport = this.rpvReporte;
            this.Name = "FormComprasAprobarAnularR";
            this.TablaEncabezado = "TTEMPORAL";
            this.Text = "APROBAR Y/O ANULAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormComprasAprobarAnularR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.rpvReporte, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
    }
}