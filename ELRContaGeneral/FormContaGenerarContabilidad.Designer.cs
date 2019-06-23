namespace ELRContaGeneral
{
    partial class FormContaGenerarContabilidad
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
            this.lblProcesoActual = new System.Windows.Forms.Label();
            this.pgbProcesos = new System.Windows.Forms.ProgressBar();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 72);
            this.pnBotones.Size = new System.Drawing.Size(511, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(271, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            this.btnGrabar.Text = "Ctrl+G = &Generar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.Text = "&Cerrar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(176, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(81, 39);
            this.lblNombreUsuario.Visible = false;
            // 
            // lblProcesoActual
            // 
            this.lblProcesoActual.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProcesoActual.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesoActual.Location = new System.Drawing.Point(0, 0);
            this.lblProcesoActual.Name = "lblProcesoActual";
            this.lblProcesoActual.Size = new System.Drawing.Size(511, 27);
            this.lblProcesoActual.TabIndex = 1;
            this.lblProcesoActual.Text = "PROCESO ACTUAL";
            this.lblProcesoActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProcesos.Location = new System.Drawing.Point(0, 27);
            this.pgbProcesos.Name = "pgbProcesos";
            this.pgbProcesos.Size = new System.Drawing.Size(511, 45);
            this.pgbProcesos.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbProcesos.TabIndex = 2;
            // 
            // FormContaGenerarContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 115);
            this.Controls.Add(this.pgbProcesos);
            this.Controls.Add(this.lblProcesoActual);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcluirValidacionCierre = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContaGenerarContabilidad";
            this.TablaEncabezado = "lo que sea";
            this.Text = "GENERAR CONTABILIDAD";
            this.Activated += new System.EventHandler(this.FormContaGenerarContabilidad_Activated);
            this.Load += new System.EventHandler(this.FormContaGenerarContabilidad_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.lblProcesoActual, 0);
            this.Controls.SetChildIndex(this.pgbProcesos, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProcesoActual;
        private System.Windows.Forms.ProgressBar pgbProcesos;
    }
}