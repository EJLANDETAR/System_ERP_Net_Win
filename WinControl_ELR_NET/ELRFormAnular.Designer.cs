namespace WinControl_ELR_NET
{
    partial class ELRFormAnular
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
            this.pnBotones = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNCF = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblReferenciaNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.pnConcepto = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.cboMotivo = new WinControl_ELR_NET.ELRCombobox();
            this.pnBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnConcepto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBotones.Controls.Add(this.lblNombreUsuario);
            this.pnBotones.Controls.Add(this.btnAnular);
            this.pnBotones.Controls.Add(this.btnCancelar);
            this.pnBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotones.Location = new System.Drawing.Point(0, 489);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(688, 43);
            this.pnBotones.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(10, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(160, 25);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // btnAnular
            // 
            this.btnAnular.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnular.Location = new System.Drawing.Point(494, 0);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(95, 39);
            this.btnAnular.TabIndex = 1;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(589, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNCF);
            this.panel1.Controls.Add(this.lblMontoTotal);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lblReferenciaNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIdentificador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 130);
            this.panel1.TabIndex = 2;
            // 
            // lblNCF
            // 
            this.lblNCF.AutoSize = true;
            this.lblNCF.Location = new System.Drawing.Point(395, 82);
            this.lblNCF.Name = "lblNCF";
            this.lblNCF.Size = new System.Drawing.Size(270, 25);
            this.lblNCF.TabIndex = 32;
            this.lblNCF.Text = "NCF: A000000000000000000";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(176, 77);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(55, 30);
            this.lblMontoTotal.TabIndex = 31;
            this.lblMontoTotal.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 30);
            this.label18.TabIndex = 30;
            this.label18.Text = "Monto Total....:";
            // 
            // lblReferenciaNo
            // 
            this.lblReferenciaNo.AutoSize = true;
            this.lblReferenciaNo.Location = new System.Drawing.Point(512, 42);
            this.lblReferenciaNo.Name = "lblReferenciaNo";
            this.lblReferenciaNo.Size = new System.Drawing.Size(100, 25);
            this.lblReferenciaNo.TabIndex = 21;
            this.lblReferenciaNo.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Referencia.:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(512, 17);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 25);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "00/00/0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha..........:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(176, 42);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 25);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "00000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Numero..............:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(176, 17);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(100, 25);
            this.lblIdentificador.TabIndex = 15;
            this.lblIdentificador.Text = "00000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Identificador Id.:";
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBeneficiario.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiario.Location = new System.Drawing.Point(0, 130);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(688, 50);
            this.lblBeneficiario.TabIndex = 3;
            this.lblBeneficiario.Text = "NOMBRE DEL BENEFICIARIO";
            this.lblBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnConcepto
            // 
            this.pnConcepto.Controls.Add(this.txtConcepto);
            this.pnConcepto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConcepto.Location = new System.Drawing.Point(0, 180);
            this.pnConcepto.Name = "pnConcepto";
            this.pnConcepto.Size = new System.Drawing.Size(688, 123);
            this.pnConcepto.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtComentario);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.cboMotivo);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 186);
            this.panel3.TabIndex = 5;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(139, 56);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(507, 92);
            this.txtComentario.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Comentario:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Motivo:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(0, 0);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.Size = new System.Drawing.Size(688, 123);
            this.txtConcepto.TabIndex = 0;
            // 
            // cboMotivo
            // 
            this.cboMotivo.CampoData = "";
            this.cboMotivo.CampoJoinCombobox2 = "";
            this.cboMotivo.ComboboxAFiltrar = null;
            this.cboMotivo.DisplayMember = "Descripcion";
            this.cboMotivo.DSData = null;
            this.cboMotivo.EsEditable = true;
            this.cboMotivo.FiltroBusqueda = "EsActivo = 1";
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Location = new System.Drawing.Point(138, 17);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.NombreTabla = "";
            this.cboMotivo.Size = new System.Drawing.Size(508, 33);
            this.cboMotivo.SSQL = "";
            this.cboMotivo.TabIndex = 1;
            this.cboMotivo.TablaOVistaConsulta = "TSISTEMA_MOTIVO_ANULACION";
            this.cboMotivo.ValorPorDefecto = "1";
            this.cboMotivo.ValueMember = "Motivo_Id";
            // 
            // ELRFormAnular
            // 
            this.AcceptButton = this.btnAnular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(688, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnConcepto);
            this.Controls.Add(this.lblBeneficiario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBotones);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ELRFormAnular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANULAR REGISTRO";
            this.Load += new System.EventHandler(this.ELRFormAnular_Load);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnConcepto.ResumeLayout(false);
            this.pnConcepto.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnBotones;
        private System.Windows.Forms.Label lblNombreUsuario;
        public System.Windows.Forms.Button btnAnular;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReferenciaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNCF;
        private System.Windows.Forms.Panel pnConcepto;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label20;
        private ELRCombobox cboMotivo;
        private System.Windows.Forms.Label label19;

    }
}