namespace WinControl_ELR_NET
{
    partial class ELRFormEditCliente
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new WinControl_ELR_NET.ELRTextBox();
            this.txtTelefono1 = new WinControl_ELR_NET.ELRTextBox();
            this.txtDireccion = new WinControl_ELR_NET.ELRTextBox();
            this.txtApellidos = new WinControl_ELR_NET.ELRTextBox();
            this.txtNombres = new WinControl_ELR_NET.ELRTextBox();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 70);
            this.panel1.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(428, 0);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(148, 66);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(576, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 66);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnBuscarCliente);
            this.gbDatos.Controls.Add(this.txtTelefono2);
            this.gbDatos.Controls.Add(this.txtTelefono1);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtApellidos);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtNombres);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtCedulaRNC);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(0, 0);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDatos.Size = new System.Drawing.Size(728, 379);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS DE ENTIDAD (CLIENTE)";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::WinControl_ELR_NET.Properties.Resources._1378160672_search;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(388, 41);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(156, 41);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefonos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula\\RNC:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.AMostrar = null;
            this.txtTelefono2.autoSenTab = true;
            this.txtTelefono2.AValidar = null;
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.CampoBusquedaID = "";
            this.txtTelefono2.CampoData = "";
            this.txtTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono2.ColumnasBusqGeneral = null;
            this.txtTelefono2.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono2.Decimales = 0;
            this.txtTelefono2.DSData = null;
            this.txtTelefono2.EsAutoGenerado = false;
            this.txtTelefono2.EsBusqueda = false;
            this.txtTelefono2.EsBusquedaAutoIncremental = false;
            this.txtTelefono2.EsEditable = true;
            this.txtTelefono2.FiltroBusqueda = "";
            this.txtTelefono2.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono2.Location = new System.Drawing.Point(459, 298);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.NombreTabla = "";
            this.txtTelefono2.SepDecimal = '\0';
            this.txtTelefono2.Size = new System.Drawing.Size(245, 35);
            this.txtTelefono2.TabIndex = 11;
            this.txtTelefono2.TablaOVistaBusqueda = "";
            this.txtTelefono2.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono2.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono2.ValorPorDefecto = "";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.AMostrar = null;
            this.txtTelefono1.autoSenTab = true;
            this.txtTelefono1.AValidar = null;
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.CampoBusquedaID = "";
            this.txtTelefono1.CampoData = "";
            this.txtTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono1.ColumnasBusqGeneral = null;
            this.txtTelefono1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtTelefono1.Decimales = 0;
            this.txtTelefono1.DSData = null;
            this.txtTelefono1.EsAutoGenerado = false;
            this.txtTelefono1.EsBusqueda = false;
            this.txtTelefono1.EsBusquedaAutoIncremental = false;
            this.txtTelefono1.EsEditable = true;
            this.txtTelefono1.FiltroBusqueda = "";
            this.txtTelefono1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtTelefono1.Location = new System.Drawing.Point(171, 298);
            this.txtTelefono1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.NombreTabla = "";
            this.txtTelefono1.SepDecimal = '\0';
            this.txtTelefono1.Size = new System.Drawing.Size(261, 35);
            this.txtTelefono1.TabIndex = 10;
            this.txtTelefono1.TablaOVistaBusqueda = "";
            this.txtTelefono1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtTelefono1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtTelefono1.ValorPorDefecto = "";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AMostrar = null;
            this.txtDireccion.autoSenTab = true;
            this.txtDireccion.AValidar = null;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.CampoBusquedaID = "";
            this.txtDireccion.CampoData = "";
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColumnasBusqGeneral = null;
            this.txtDireccion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDireccion.Decimales = 0;
            this.txtDireccion.DSData = null;
            this.txtDireccion.EsAutoGenerado = false;
            this.txtDireccion.EsBusqueda = false;
            this.txtDireccion.EsBusquedaAutoIncremental = false;
            this.txtDireccion.EsEditable = true;
            this.txtDireccion.FiltroBusqueda = "";
            this.txtDireccion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDireccion.Location = new System.Drawing.Point(171, 185);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NombreTabla = "";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDireccion.SepDecimal = '\0';
            this.txtDireccion.Size = new System.Drawing.Size(533, 96);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TablaOVistaBusqueda = "";
            this.txtDireccion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDireccion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDireccion.ValorPorDefecto = "";
            // 
            // txtApellidos
            // 
            this.txtApellidos.AMostrar = null;
            this.txtApellidos.autoSenTab = true;
            this.txtApellidos.AValidar = null;
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.CampoBusquedaID = "";
            this.txtApellidos.CampoData = "";
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.ColumnasBusqGeneral = null;
            this.txtApellidos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtApellidos.Decimales = 0;
            this.txtApellidos.DSData = null;
            this.txtApellidos.EsAutoGenerado = false;
            this.txtApellidos.EsBusqueda = false;
            this.txtApellidos.EsBusquedaAutoIncremental = false;
            this.txtApellidos.EsEditable = true;
            this.txtApellidos.FiltroBusqueda = "";
            this.txtApellidos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtApellidos.Location = new System.Drawing.Point(171, 138);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.NombreTabla = "";
            this.txtApellidos.SepDecimal = '\0';
            this.txtApellidos.Size = new System.Drawing.Size(533, 35);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.TablaOVistaBusqueda = "";
            this.txtApellidos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtApellidos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtApellidos.ValorPorDefecto = "";
            // 
            // txtNombres
            // 
            this.txtNombres.AMostrar = null;
            this.txtNombres.autoSenTab = true;
            this.txtNombres.AValidar = null;
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.CampoBusquedaID = "";
            this.txtNombres.CampoData = "";
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.ColumnasBusqGeneral = null;
            this.txtNombres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombres.Decimales = 0;
            this.txtNombres.DSData = null;
            this.txtNombres.EsAutoGenerado = false;
            this.txtNombres.EsBusqueda = false;
            this.txtNombres.EsBusquedaAutoIncremental = false;
            this.txtNombres.EsEditable = true;
            this.txtNombres.FiltroBusqueda = "";
            this.txtNombres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombres.Location = new System.Drawing.Point(171, 95);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.NombreTabla = "";
            this.txtNombres.SepDecimal = '\0';
            this.txtNombres.Size = new System.Drawing.Size(533, 35);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TablaOVistaBusqueda = "";
            this.txtNombres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombres.ValorPorDefecto = "";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.autoSenTab = false;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.BackColor = System.Drawing.Color.White;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = null;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(171, 47);
            this.txtCedulaRNC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(211, 35);
            this.txtCedulaRNC.TabIndex = 1;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            this.txtCedulaRNC.Leave += new System.EventHandler(this.txtCedulaRNC_Leave);
            // 
            // ELRFormEditCliente
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ELRFormEditCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ELRFormEditCliente";
            this.Load += new System.EventHandler(this.ELRFormEditCliente_Load);
            this.panel1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnBuscarCliente;
        private ELRTextBox txtTelefono2;
        private ELRTextBox txtTelefono1;
        private System.Windows.Forms.Label label5;
        private ELRTextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private ELRTextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private ELRTextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label1;
    }
}