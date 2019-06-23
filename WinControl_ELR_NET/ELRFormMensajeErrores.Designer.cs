namespace WinControl_ELR_NET
{
    partial class ELRFormMensajeErrores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELRFormMensajeErrores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMostrarSP = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtgMensaje = new System.Windows.Forms.DataGridView();
            this.ImgError = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkMostrarSP);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 46);
            this.panel1.TabIndex = 0;
            // 
            // chkMostrarSP
            // 
            this.chkMostrarSP.AutoSize = true;
            this.chkMostrarSP.Location = new System.Drawing.Point(10, 10);
            this.chkMostrarSP.Name = "chkMostrarSP";
            this.chkMostrarSP.Size = new System.Drawing.Size(168, 22);
            this.chkMostrarSP.TabIndex = 2;
            this.chkMostrarSP.Text = "Mostrar Meta Data";
            this.chkMostrarSP.UseVisualStyleBackColor = true;
            this.chkMostrarSP.CheckedChanged += new System.EventHandler(this.chkMostrarSP_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(479, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 42);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgMensaje
            // 
            this.dtgMensaje.AllowUserToAddRows = false;
            this.dtgMensaje.AllowUserToDeleteRows = false;
            this.dtgMensaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMensaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImgError,
            this.Nombre_SP,
            this.Linea_No,
            this.Mensaje,
            this.Tipo_Error});
            this.dtgMensaje.DataMember = "Busqueda";
            this.dtgMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMensaje.Location = new System.Drawing.Point(0, 0);
            this.dtgMensaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgMensaje.Name = "dtgMensaje";
            this.dtgMensaje.ReadOnly = true;
            this.dtgMensaje.RowHeadersWidth = 25;
            this.dtgMensaje.RowTemplate.Height = 35;
            this.dtgMensaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMensaje.Size = new System.Drawing.Size(585, 304);
            this.dtgMensaje.TabIndex = 7;
            this.dtgMensaje.SelectionChanged += new System.EventHandler(this.dtgMensaje_SelectionChanged);
            // 
            // ImgError
            // 
            this.ImgError.HeaderText = "";
            this.ImgError.Name = "ImgError";
            this.ImgError.ReadOnly = true;
            this.ImgError.Width = 40;
            // 
            // Nombre_SP
            // 
            this.Nombre_SP.DataPropertyName = "Nombre_SP";
            this.Nombre_SP.HeaderText = "Nombre SP";
            this.Nombre_SP.Name = "Nombre_SP";
            this.Nombre_SP.ReadOnly = true;
            this.Nombre_SP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre_SP.Visible = false;
            this.Nombre_SP.Width = 400;
            // 
            // Linea_No
            // 
            this.Linea_No.DataPropertyName = "Linea_No";
            this.Linea_No.HeaderText = "Linea No";
            this.Linea_No.Name = "Linea_No";
            this.Linea_No.ReadOnly = true;
            this.Linea_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Linea_No.Visible = false;
            this.Linea_No.Width = 90;
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mensaje.DataPropertyName = "Mensaje";
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tipo_Error
            // 
            this.Tipo_Error.DataPropertyName = "Tipo_Error";
            this.Tipo_Error.HeaderText = "Tipo_Error";
            this.Tipo_Error.Name = "Tipo_Error";
            this.Tipo_Error.ReadOnly = true;
            this.Tipo_Error.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tipo_Error.Visible = false;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.White;
            this.txtMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(0, 228);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensaje.Size = new System.Drawing.Size(585, 76);
            this.txtMensaje.TabIndex = 8;
            // 
            // ELRFormMensajeErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(585, 350);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.dtgMensaje);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ELRFormMensajeErrores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MENSAJES DEL SISTEMA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ELRFormMensajeErrores_FormClosed);
            this.Load += new System.EventHandler(this.ELRFormMensajeErrores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dtgMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.CheckBox chkMostrarSP;
        private System.Windows.Forms.DataGridViewImageColumn ImgError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Error;
    }
}