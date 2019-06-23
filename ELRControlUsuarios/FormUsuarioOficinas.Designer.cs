namespace ELRControlUsuarios
{
    partial class FormUsuarioOficinas
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
            this.lblUser = new System.Windows.Forms.Label();
            this.dtgOficinas = new System.Windows.Forms.DataGridView();
            this.Oficina_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOficinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(852, 42);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "USUARIO:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgOficinas
            // 
            this.dtgOficinas.AllowUserToAddRows = false;
            this.dtgOficinas.AllowUserToDeleteRows = false;
            this.dtgOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOficinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oficina_Id,
            this.Nombre,
            this.EsActivo,
            this.EsDefault});
            this.dtgOficinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOficinas.Location = new System.Drawing.Point(0, 42);
            this.dtgOficinas.MultiSelect = false;
            this.dtgOficinas.Name = "dtgOficinas";
            this.dtgOficinas.RowHeadersWidth = 30;
            this.dtgOficinas.RowTemplate.Height = 35;
            this.dtgOficinas.Size = new System.Drawing.Size(852, 402);
            this.dtgOficinas.TabIndex = 2;
            // 
            // Oficina_Id
            // 
            this.Oficina_Id.DataPropertyName = "Oficina_Id";
            this.Oficina_Id.HeaderText = "Oficina Id";
            this.Oficina_Id.Name = "Oficina_Id";
            this.Oficina_Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "Aplica";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsActivo.Width = 130;
            // 
            // EsDefault
            // 
            this.EsDefault.DataPropertyName = "EsDefault";
            this.EsDefault.HeaderText = "Es Default";
            this.EsDefault.Name = "EsDefault";
            this.EsDefault.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsDefault.Width = 130;
            // 
            // FormUsuarioOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.dtgOficinas);
            this.Controls.Add(this.lblUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormUsuarioOficinas";
            this.TablaEncabezado = "Usuarios";
            this.Text = "ASIGNAR OFICINAS A USUARIO";
            this.Load += new System.EventHandler(this.FormUsuarioOficinas_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.Controls.SetChildIndex(this.dtgOficinas, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOficinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dtgOficinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficina_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsDefault;
    }
}