namespace WinControl_ELR_NET
{
    partial class FormCambiarContrasena
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtConfirmar = new WinControl_ELR_NET.ELRTextBox();
            this.txtClaveNueva = new WinControl_ELR_NET.ELRTextBox();
            this.txtClaveActual = new WinControl_ELR_NET.ELRTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contrasena Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contasena Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirma  Contasena:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 60);
            this.panel1.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Location = new System.Drawing.Point(295, 0);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 56);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(421, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 56);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.AMostrar = null;
            this.txtConfirmar.autoSenTab = true;
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
            this.txtConfirmar.EsBusquedaAutoIncremental = false;
            this.txtConfirmar.EsEditable = true;
            this.txtConfirmar.FiltroBusqueda = "";
            this.txtConfirmar.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConfirmar.Location = new System.Drawing.Point(233, 141);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.NombreTabla = "";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.SepDecimal = '\0';
            this.txtConfirmar.Size = new System.Drawing.Size(292, 33);
            this.txtConfirmar.TabIndex = 5;
            this.txtConfirmar.TablaOVistaBusqueda = "";
            this.txtConfirmar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConfirmar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConfirmar.ValorPorDefecto = "";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.AMostrar = null;
            this.txtClaveNueva.autoSenTab = true;
            this.txtClaveNueva.AValidar = null;
            this.txtClaveNueva.CampoBusquedaID = "";
            this.txtClaveNueva.CampoData = "";
            this.txtClaveNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveNueva.ColumnasBusqGeneral = null;
            this.txtClaveNueva.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtClaveNueva.Decimales = 0;
            this.txtClaveNueva.DSData = null;
            this.txtClaveNueva.EsAutoGenerado = false;
            this.txtClaveNueva.EsBusqueda = false;
            this.txtClaveNueva.EsBusquedaAutoIncremental = false;
            this.txtClaveNueva.EsEditable = true;
            this.txtClaveNueva.FiltroBusqueda = "";
            this.txtClaveNueva.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtClaveNueva.Location = new System.Drawing.Point(233, 85);
            this.txtClaveNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.NombreTabla = "";
            this.txtClaveNueva.PasswordChar = '*';
            this.txtClaveNueva.SepDecimal = '\0';
            this.txtClaveNueva.Size = new System.Drawing.Size(292, 33);
            this.txtClaveNueva.TabIndex = 3;
            this.txtClaveNueva.TablaOVistaBusqueda = "";
            this.txtClaveNueva.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtClaveNueva.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtClaveNueva.ValorPorDefecto = "";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.AMostrar = null;
            this.txtClaveActual.autoSenTab = true;
            this.txtClaveActual.AValidar = null;
            this.txtClaveActual.CampoBusquedaID = "";
            this.txtClaveActual.CampoData = "";
            this.txtClaveActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveActual.ColumnasBusqGeneral = null;
            this.txtClaveActual.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtClaveActual.Decimales = 0;
            this.txtClaveActual.DSData = null;
            this.txtClaveActual.EsAutoGenerado = false;
            this.txtClaveActual.EsBusqueda = false;
            this.txtClaveActual.EsBusquedaAutoIncremental = false;
            this.txtClaveActual.EsEditable = true;
            this.txtClaveActual.FiltroBusqueda = "";
            this.txtClaveActual.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtClaveActual.Location = new System.Drawing.Point(233, 31);
            this.txtClaveActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.NombreTabla = "";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.SepDecimal = '\0';
            this.txtClaveActual.Size = new System.Drawing.Size(292, 33);
            this.txtClaveActual.TabIndex = 1;
            this.txtClaveActual.TablaOVistaBusqueda = "";
            this.txtClaveActual.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtClaveActual.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtClaveActual.ValorPorDefecto = "";
            // 
            // FormCambiarContrasena
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(551, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR CONTRASENA";
            this.Load += new System.EventHandler(this.FormCambiarContrasena_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ELRTextBox txtClaveActual;
        private System.Windows.Forms.Label label2;
        private ELRTextBox txtClaveNueva;
        private System.Windows.Forms.Label label3;
        private ELRTextBox txtConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}