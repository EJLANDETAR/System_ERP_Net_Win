namespace ELRCredito
{
    partial class FormPrestamosRechazarR
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
            this.lblPrestamoNo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblANombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComentario = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 279);
            this.pnBotones.Size = new System.Drawing.Size(671, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(431, 0);
            this.btnGrabar.Text = "Rechazar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(572, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(336, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(241, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPrestamoNo);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblANombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 83);
            this.panel1.TabIndex = 17;
            // 
            // lblPrestamoNo
            // 
            this.lblPrestamoNo.AutoSize = true;
            this.lblPrestamoNo.Location = new System.Drawing.Point(167, 7);
            this.lblPrestamoNo.Name = "lblPrestamoNo";
            this.lblPrestamoNo.Size = new System.Drawing.Size(100, 25);
            this.lblPrestamoNo.TabIndex = 11;
            this.lblPrestamoNo.Text = "00000000";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(437, 7);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 25);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Monto:";
            // 
            // lblANombre
            // 
            this.lblANombre.AutoSize = true;
            this.lblANombre.Location = new System.Drawing.Point(167, 41);
            this.lblANombre.Name = "lblANombre";
            this.lblANombre.Size = new System.Drawing.Size(67, 25);
            this.lblANombre.TabIndex = 8;
            this.lblANombre.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "A Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prestamo No.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 196);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.AMostrar = null;
            this.txtComentario.AValidar = null;
            this.txtComentario.CampoBusquedaID = "";
            this.txtComentario.CampoData = "";
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.ColumnasBusqGeneral = null;
            this.txtComentario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtComentario.Decimales = 0;
            this.txtComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComentario.DSData = null;
            this.txtComentario.EsAutoGenerado = false;
            this.txtComentario.EsBusqueda = false;
            this.txtComentario.EsBusquedaAutoIncremental = false;
            this.txtComentario.EsEditable = true;
            this.txtComentario.FiltroBusqueda = "";
            this.txtComentario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtComentario.Location = new System.Drawing.Point(3, 25);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.NombreTabla = "";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComentario.SepDecimal = '\0';
            this.txtComentario.Size = new System.Drawing.Size(665, 168);
            this.txtComentario.TabIndex = 24;
            this.txtComentario.TablaOVistaBusqueda = "";
            this.txtComentario.Text = "CLIENTE YA NO NECESITA EL PRESTAMO";
            this.txtComentario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtComentario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtComentario.ValorPorDefecto = "";
            // 
            // FormPrestamosRechazarR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrestamosRechazarR";
            this.Text = "RECHAZAR PRESTAMO NO.:";
            this.Load += new System.EventHandler(this.FormPrestamosRechazarR_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrestamoNo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblANombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtComentario;
    }
}