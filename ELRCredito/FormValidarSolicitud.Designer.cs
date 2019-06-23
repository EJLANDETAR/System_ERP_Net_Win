namespace ELRCredito
{
    partial class FormValidarSolicitud
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
            this.lblSolicitudId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuntosAFavor = new System.Windows.Forms.Label();
            this.lblPuntosNegativos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReptValidacion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnReptValidacion);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 54);
            this.panel1.TabIndex = 0;
            // 
            // lblSolicitudId
            // 
            this.lblSolicitudId.AutoSize = true;
            this.lblSolicitudId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudId.ForeColor = System.Drawing.Color.Blue;
            this.lblSolicitudId.Location = new System.Drawing.Point(23, 39);
            this.lblSolicitudId.Name = "lblSolicitudId";
            this.lblSolicitudId.Size = new System.Drawing.Size(307, 29);
            this.lblSolicitudId.TabIndex = 1;
            this.lblSolicitudId.Text = "SOLICITUD NO. 0000000";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Blue;
            this.lblNombre.Location = new System.Drawing.Point(23, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(297, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE DEL CLIENTE";
            // 
            // lblPuntosAFavor
            // 
            this.lblPuntosAFavor.AutoSize = true;
            this.lblPuntosAFavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosAFavor.ForeColor = System.Drawing.Color.Olive;
            this.lblPuntosAFavor.Location = new System.Drawing.Point(23, 149);
            this.lblPuntosAFavor.Name = "lblPuntosAFavor";
            this.lblPuntosAFavor.Size = new System.Drawing.Size(265, 29);
            this.lblPuntosAFavor.TabIndex = 3;
            this.lblPuntosAFavor.Text = "PUNTOS A FAVOR: 0";
            // 
            // lblPuntosNegativos
            // 
            this.lblPuntosNegativos.AutoSize = true;
            this.lblPuntosNegativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosNegativos.ForeColor = System.Drawing.Color.Red;
            this.lblPuntosNegativos.Location = new System.Drawing.Point(23, 188);
            this.lblPuntosNegativos.Name = "lblPuntosNegativos";
            this.lblPuntosNegativos.Size = new System.Drawing.Size(304, 29);
            this.lblPuntosNegativos.TabIndex = 4;
            this.lblPuntosNegativos.Text = "PUNTOS NEGATIVOS: 0";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(483, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReptValidacion
            // 
            this.btnReptValidacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReptValidacion.Location = new System.Drawing.Point(239, 0);
            this.btnReptValidacion.Name = "btnReptValidacion";
            this.btnReptValidacion.Size = new System.Drawing.Size(244, 50);
            this.btnReptValidacion.TabIndex = 4;
            this.btnReptValidacion.Text = "Mostrar Reporte Validacion";
            this.btnReptValidacion.UseVisualStyleBackColor = true;
            this.btnReptValidacion.Click += new System.EventHandler(this.btnReptValidacion_Click);
            // 
            // FormValidarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 347);
            this.Controls.Add(this.lblPuntosNegativos);
            this.Controls.Add(this.lblPuntosAFavor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblSolicitudId);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormValidarSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VALIDAR SOLICITUD";
            this.Activated += new System.EventHandler(this.FormValidarSolicitud_Activated);
            this.Load += new System.EventHandler(this.FormValidarSolicitud_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSolicitudId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntosAFavor;
        private System.Windows.Forms.Label lblPuntosNegativos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReptValidacion;
    }
}