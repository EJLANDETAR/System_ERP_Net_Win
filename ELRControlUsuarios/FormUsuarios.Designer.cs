namespace ELRControlUsuarios
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRoles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnOficinas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsCajero = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsBloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tipo_Interop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 455);
            this.pnTotales.Size = new System.Drawing.Size(842, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(842, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 455);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.btnRoles,
            this.btnOficinas,
            this.Nombre_Usuario,
            this.Nombres,
            this.Apellidos,
            this.EsActivo,
            this.EsCajero,
            this.EsBloqueado,
            this.Tipo_Interop});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(842, 357);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // btnRoles
            // 
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.HeaderText = "Roles";
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.ReadOnly = true;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseColumnTextForButtonValue = true;
            // 
            // btnOficinas
            // 
            this.btnOficinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOficinas.HeaderText = "Oficinas";
            this.btnOficinas.Name = "btnOficinas";
            this.btnOficinas.ReadOnly = true;
            this.btnOficinas.Text = "Oficinas";
            this.btnOficinas.UseColumnTextForButtonValue = true;
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.DataPropertyName = "Nombre_Usuario";
            this.Nombre_Usuario.HeaderText = "Usuario";
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.ReadOnly = true;
            this.Nombre_Usuario.Width = 250;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 250;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 250;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "Es Activo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            this.EsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EsCajero
            // 
            this.EsCajero.DataPropertyName = "EsCajero";
            this.EsCajero.HeaderText = "Es Cajero";
            this.EsCajero.Name = "EsCajero";
            this.EsCajero.ReadOnly = true;
            this.EsCajero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsCajero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EsBloqueado
            // 
            this.EsBloqueado.DataPropertyName = "EsBloqueado";
            this.EsBloqueado.HeaderText = "Es Bloqueado";
            this.EsBloqueado.Name = "EsBloqueado";
            this.EsBloqueado.ReadOnly = true;
            this.EsBloqueado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsBloqueado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsBloqueado.Width = 130;
            // 
            // Tipo_Interop
            // 
            this.Tipo_Interop.DataPropertyName = "Tipo_Interop";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Interop.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tipo_Interop.HeaderText = "Interop";
            this.Tipo_Interop.Name = "Tipo_Interop";
            this.Tipo_Interop.ReadOnly = true;
            this.Tipo_Interop.ToolTipText = "MSO= Microsoft Office      OO= Open Office";
            this.Tipo_Interop.Visible = false;
            this.Tipo_Interop.Width = 85;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 529);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRControlUsuarios.FormUsuariosR";
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormUsuarios";
            this.NombreCampoID = "Unico";
            this.TablaOVista = "TACCESOS_USUARIOS";
            this.Text = "USUARIOS DEL SISTEMA";
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewButtonColumn btnRoles;
        private System.Windows.Forms.DataGridViewButtonColumn btnOficinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsCajero;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Interop;
    }
}