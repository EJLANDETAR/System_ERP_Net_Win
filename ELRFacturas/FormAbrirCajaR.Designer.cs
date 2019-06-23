namespace ELRFacturas
{
    partial class FormAbrirCajaR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            this.txtMontoApertura = new WinControl_ELR_NET.ELRTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new WinControl_ELR_NET.ELRLabel();
            this.lblCajaId = new WinControl_ELR_NET.ELRLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesglosar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 229);
            this.pnBotones.Size = new System.Drawing.Size(494, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(300, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(395, 0);
            // 
            // txtMontoApertura
            // 
            this.txtMontoApertura.CampoData = "Monto_Apertura";
            this.txtMontoApertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoApertura.DSData = this.DSDatos;
            this.txtMontoApertura.EsAutoGenerado = false;
            this.txtMontoApertura.EsEditable = true;
            this.txtMontoApertura.FiltroBusqueda = "";
            this.txtMontoApertura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoApertura.Location = new System.Drawing.Point(22, 139);
            this.txtMontoApertura.Name = "txtMontoApertura";
            this.txtMontoApertura.NombreTabla = "";
            this.txtMontoApertura.ReadOnly = true;
            this.txtMontoApertura.Size = new System.Drawing.Size(169, 33);
            this.txtMontoApertura.TabIndex = 2;
            this.txtMontoApertura.ValorPorDefecto = "-1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblCajaId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 81);
            this.panel1.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.CampoData = "Usuario_En_Caja";
            this.lblUsuario.DSData = this.DSDatos;
            this.lblUsuario.Location = new System.Drawing.Point(113, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.NombreTabla = "";
            this.lblUsuario.Size = new System.Drawing.Size(204, 30);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "NOMBRE.USUARIO";
            this.lblUsuario.ValorPorDefecto = "";
            // 
            // lblCajaId
            // 
            this.lblCajaId.AutoSize = true;
            this.lblCajaId.CampoData = "Caja_Id";
            this.lblCajaId.DSData = this.DSDatos;
            this.lblCajaId.Location = new System.Drawing.Point(113, 11);
            this.lblCajaId.Name = "lblCajaId";
            this.lblCajaId.NombreTabla = "";
            this.lblCajaId.Size = new System.Drawing.Size(85, 30);
            this.lblCajaId.TabIndex = 4;
            this.lblCajaId.Text = "000000";
            this.lblCajaId.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja No.";
            // 
            // btnDesglosar
            // 
            this.btnDesglosar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesglosar.Location = new System.Drawing.Point(197, 134);
            this.btnDesglosar.Name = "btnDesglosar";
            this.btnDesglosar.Size = new System.Drawing.Size(108, 40);
            this.btnDesglosar.TabIndex = 3;
            this.btnDesglosar.Text = "Desglosar";
            this.btnDesglosar.UseVisualStyleBackColor = true;
            this.btnDesglosar.Click += new System.EventHandler(this.btnDesglosar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto Apertura";
            // 
            // FormAbrirCajaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtMontoApertura;
            valida1.Mensaje = "El Monto de Apertura No Puede Ser Negativo";
            valida1.NombreCampo = "Monto_Apertura";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "0";
            valida1.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1};
            this.ClientSize = new System.Drawing.Size(494, 272);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDesglosar);
            this.Controls.Add(this.txtMontoApertura);
            this.Controls.Add(this.panel1);
            this.EsConTemporal = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbrirCajaR";
            this.NombreCampoID = "Apertura_No";
            this.SPGraba = "SP_CAJAS_ABRIR";
            this.TablaEncabezado = "TTEMPORAL_CAJAS_APERTURA_CIERRE";
            this.Text = "ABRIR CAJA";
            this.Load += new System.EventHandler(this.FormAbrirCajaR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtMontoApertura, 0);
            this.Controls.SetChildIndex(this.btnDesglosar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtMontoApertura;
        private System.Windows.Forms.Button btnDesglosar;
        private System.Windows.Forms.Label label5;
        private WinControl_ELR_NET.ELRLabel lblUsuario;
        private WinControl_ELR_NET.ELRLabel lblCajaId;
    }
}