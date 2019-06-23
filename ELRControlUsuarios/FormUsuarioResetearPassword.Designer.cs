namespace ELRControlUsuarios
{
    partial class FormUsuarioResetearPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new WinControl_ELR_NET.ELRTextBox();
            this.txtConfirmar = new WinControl_ELR_NET.ELRTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 183);
            this.pnBotones.Size = new System.Drawing.Size(428, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(179, 0);
            this.btnGrabar.Size = new System.Drawing.Size(150, 39);
            this.btnGrabar.Text = "Resetear Password";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(329, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(84, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PassWord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar:";
            // 
            // txtPassword
            // 
            this.txtPassword.AMostrar = null;
            this.txtPassword.AValidar = null;
            this.txtPassword.CampoBusquedaID = "";
            this.txtPassword.CampoData = "";
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.ColumnasBusqGeneral = null;
            this.txtPassword.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPassword.Decimales = 0;
            this.txtPassword.DSData = null;
            this.txtPassword.EsAutoGenerado = false;
            this.txtPassword.EsBusqueda = false;
            this.txtPassword.EsEditable = true;
            this.txtPassword.FiltroBusqueda = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPassword.Location = new System.Drawing.Point(143, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NombreTabla = "";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SepDecimal = '\0';
            this.txtPassword.Size = new System.Drawing.Size(218, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TablaOVistaBusqueda = "";
            this.txtPassword.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPassword.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPassword.ValorPorDefecto = "";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.AMostrar = null;
            this.txtConfirmar.AValidar = null;
            this.txtConfirmar.CampoBusquedaID = "";
            this.txtConfirmar.CampoData = "";
            this.txtConfirmar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConfirmar.ColumnasBusqGeneral = null;
            this.txtConfirmar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConfirmar.Decimales = 0;
            this.txtConfirmar.DSData = null;
            this.txtConfirmar.EsAutoGenerado = false;
            this.txtConfirmar.EsBusqueda = false;
            this.txtConfirmar.EsEditable = true;
            this.txtConfirmar.FiltroBusqueda = "";
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConfirmar.Location = new System.Drawing.Point(143, 99);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.NombreTabla = "";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.SepDecimal = '\0';
            this.txtConfirmar.Size = new System.Drawing.Size(218, 29);
            this.txtConfirmar.TabIndex = 5;
            this.txtConfirmar.TablaOVistaBusqueda = "";
            this.txtConfirmar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConfirmar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConfirmar.ValorPorDefecto = "";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(139, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(169, 21);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "NOMBRE DE USUARIO";
            // 
            // FormUsuarioResetearPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 226);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarioResetearPassword";
            this.TablaEncabezado = "TACCESOS_USUARIOS";
            this.Text = "RESETEAR PASSWORD DE USUARIO";
            this.Load += new System.EventHandler(this.FormUsuarioResetearPassword_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtConfirmar, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtPassword;
        private WinControl_ELR_NET.ELRTextBox txtConfirmar;
        private System.Windows.Forms.Label lblUsuario;
    }
}