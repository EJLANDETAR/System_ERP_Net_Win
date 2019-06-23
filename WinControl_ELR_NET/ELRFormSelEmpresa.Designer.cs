namespace WinControl_ELR_NET
{
    partial class ELRFormSelEmpresa
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
            this.cboEmpresa = new WinControl_ELR_NET.ELRCombobox();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empesa";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.CampoData = "";
            this.cboEmpresa.CampoJoinCombobox2 = "Empresa_Id";
            this.cboEmpresa.ComboboxAFiltrar = this.cboOficina;
            this.cboEmpresa.DisplayMember = "Nombre";
            this.cboEmpresa.DSData = null;
            this.cboEmpresa.EsEditable = true;
            this.cboEmpresa.FiltroBusqueda = "EsActivo = 1";
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(94, 30);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.NombreTabla = "";
            this.cboEmpresa.Size = new System.Drawing.Size(330, 29);
            this.cboEmpresa.SSQL = "";
            this.cboEmpresa.TabIndex = 1;
            this.cboEmpresa.TablaOVistaConsulta = "TEMPRESAS";
            this.cboEmpresa.ValorPorDefecto = "1";
            this.cboEmpresa.ValueMember = "Empresa_Id";
            // 
            // cboOficina
            // 
            this.cboOficina.CampoData = "";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DisplayMember = "Nombre";
            this.cboOficina.DSData = null;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "EsActivo = 1";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(94, 81);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(330, 29);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 3;
            this.cboOficina.TablaOVistaConsulta = "TEMPRESAS_OFICINAS";
            this.cboOficina.ValorPorDefecto = "100";
            this.cboOficina.ValueMember = "Oficina_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oficina";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 56);
            this.panel1.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIngresar.Location = new System.Drawing.Point(168, 0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(152, 52);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(320, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 52);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ELRFormSelEmpresa
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(436, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboOficina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ELRFormSelEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SELECCIONE EMPRESA Y OFICINA";
            this.Load += new System.EventHandler(this.ELRFormSelEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ELRCombobox cboEmpresa;
        private System.Windows.Forms.Label label2;
        private ELRCombobox cboOficina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCerrar;
    }
}