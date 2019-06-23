namespace WinControl_ELR_NET
{
    partial class ELRFormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtClave = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombreUsuario = new WinControl_ELR_NET.ELRTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clave o PassWord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre Usuario";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAceptar.Location = new System.Drawing.Point(307, 234);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 39);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(419, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 39);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinControl_ELR_NET.Properties.Resources.Login_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(23, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.AMostrar = null;
            this.txtClave.AValidar = null;
            this.txtClave.CampoBusquedaID = "";
            this.txtClave.CampoData = "";
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.ColumnasBusqGeneral = null;
            this.txtClave.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtClave.Decimales = 0;
            this.txtClave.DSData = null;
            this.txtClave.EsAutoGenerado = false;
            this.txtClave.EsBusqueda = false;
            this.txtClave.EsBusquedaAutoIncremental = false;
            this.txtClave.EsEditable = true;
            this.txtClave.FiltroBusqueda = "";
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtClave.Location = new System.Drawing.Point(240, 176);
            this.txtClave.Name = "txtClave";
            this.txtClave.NombreTabla = "";
            this.txtClave.PasswordChar = '*';
            this.txtClave.SepDecimal = '\0';
            this.txtClave.Size = new System.Drawing.Size(285, 35);
            this.txtClave.TabIndex = 16;
            this.txtClave.TablaOVistaBusqueda = "";
            this.txtClave.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtClave.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtClave.ValorPorDefecto = "";
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AMostrar = null;
            this.txtNombreUsuario.AValidar = null;
            this.txtNombreUsuario.CampoBusquedaID = "";
            this.txtNombreUsuario.CampoData = "";
            this.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreUsuario.ColumnasBusqGeneral = null;
            this.txtNombreUsuario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreUsuario.Decimales = 0;
            this.txtNombreUsuario.DSData = null;
            this.txtNombreUsuario.EsAutoGenerado = false;
            this.txtNombreUsuario.EsBusqueda = false;
            this.txtNombreUsuario.EsBusquedaAutoIncremental = false;
            this.txtNombreUsuario.EsEditable = true;
            this.txtNombreUsuario.FiltroBusqueda = "";
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreUsuario.Location = new System.Drawing.Point(239, 102);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.NombreTabla = "";
            this.txtNombreUsuario.SepDecimal = '\0';
            this.txtNombreUsuario.Size = new System.Drawing.Size(286, 35);
            this.txtNombreUsuario.TabIndex = 15;
            this.txtNombreUsuario.TablaOVistaBusqueda = "";
            this.txtNombreUsuario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreUsuario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreUsuario.ValorPorDefecto = "";
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // ELRFormLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(556, 298);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ELRFormLogin";
            this.Text = "Iniciar Session";
            this.Activated += new System.EventHandler(this.ELRFormLogin_Activated);
            this.Load += new System.EventHandler(this.ELRFormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ELRTextBox txtNombreUsuario;
        private ELRTextBox txtClave;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}