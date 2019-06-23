namespace ELRContaGeneral
{
    partial class FormContaCatalogoEdit
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
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficina_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsControl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsPresupuesto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsMovimiento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Location = new System.Drawing.Point(14, 466);
            this.pnTotales.Size = new System.Drawing.Size(1057, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1057, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.CondicionABuscar = "Descripcion Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.FiltroBusqueda = "Descripcion Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.Size = new System.Drawing.Size(310, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 6);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 466);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuenta_Contable,
            this.Descripcion,
            this.Oficina_Id,
            this.EsControl,
            this.EsPresupuesto,
            this.EsMovimiento});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 368);
            this.dataGridView1.TabIndex = 48;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.Visible = false;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cuenta Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Oficina_Id
            // 
            this.Oficina_Id.DataPropertyName = "Oficina_Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "0";
            this.Oficina_Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Oficina_Id.HeaderText = "Cod.Oficina";
            this.Oficina_Id.Name = "Oficina_Id";
            // 
            // EsControl
            // 
            this.EsControl.DataPropertyName = "EsControl";
            this.EsControl.HeaderText = "Es Control";
            this.EsControl.Name = "EsControl";
            this.EsControl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EsPresupuesto
            // 
            this.EsPresupuesto.DataPropertyName = "EsPresupuesto";
            this.EsPresupuesto.HeaderText = "Es Presup.";
            this.EsPresupuesto.Name = "EsPresupuesto";
            this.EsPresupuesto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsPresupuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EsMovimiento
            // 
            this.EsMovimiento.DataPropertyName = "EsMovimiento";
            this.EsMovimiento.HeaderText = "P. Mov.";
            this.EsMovimiento.Name = "EsMovimiento";
            this.EsMovimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsMovimiento.Width = 85;
            // 
            // FormContaCatalogoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Cuenta_Contable";
            this.ClientSize = new System.Drawing.Size(1071, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsImprimir = true;
            this.FormularioRegistro = "ELRContaGeneral.FormContaCuentasR";
            this.Name = "FormContaCatalogoEdit";
            this.NombreCampoID = "Unico";
            this.SPCargarATemporal = "SP_CONTA_CATALOGO_ATEMPORAL";
            this.TablaOVista = "TCONTA_CATALOGO";
            this.Text = "CONTABILIDAD GENERAL, EDITAR CATALOGO DE CUENTAS";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficina_Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsControl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsPresupuesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsMovimiento;
    }
}