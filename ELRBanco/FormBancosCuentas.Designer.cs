namespace ELRBanco
{
    partial class FormBancosCuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsCheques = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsNomina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficina_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfCheques = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Size = new System.Drawing.Size(1086, 52);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1072, 46);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Nombre  Like \'%\' + @aBuscar + \'%\' ";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Cuenta_Id,
            this.Numero,
            this.Nombre,
            this.Cuenta_Contable,
            this.EsActivo,
            this.EsCheques,
            this.EsNomina,
            this.Saldo_Actual,
            this.Oficina_Id,
            this.btnConfCheques});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 396);
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
            // Cuenta_Id
            // 
            this.Cuenta_Id.DataPropertyName = "Cuenta_Id";
            this.Cuenta_Id.HeaderText = "Codigo";
            this.Cuenta_Id.Name = "Cuenta_Id";
            this.Cuenta_Id.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 140;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.Cuenta_Contable.HeaderText = "Cta. Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            this.Cuenta_Contable.ReadOnly = true;
            this.Cuenta_Contable.Width = 160;
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
            // EsCheques
            // 
            this.EsCheques.DataPropertyName = "EsCheques";
            this.EsCheques.HeaderText = "Es Cheque";
            this.EsCheques.Name = "EsCheques";
            this.EsCheques.ReadOnly = true;
            this.EsCheques.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsCheques.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EsNomina
            // 
            this.EsNomina.DataPropertyName = "EsNomina";
            this.EsNomina.HeaderText = "EsNomina";
            this.EsNomina.Name = "EsNomina";
            this.EsNomina.ReadOnly = true;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.DataPropertyName = "Saldo_Actual";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Saldo_Actual.DefaultCellStyle = dataGridViewCellStyle1;
            this.Saldo_Actual.HeaderText = "Saldo Actual";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.ReadOnly = true;
            this.Saldo_Actual.Width = 150;
            // 
            // Oficina_Id
            // 
            this.Oficina_Id.DataPropertyName = "Oficina_Id";
            this.Oficina_Id.HeaderText = "Oficina_Id";
            this.Oficina_Id.Name = "Oficina_Id";
            this.Oficina_Id.ReadOnly = true;
            this.Oficina_Id.Visible = false;
            // 
            // btnConfCheques
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfCheques.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnConfCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfCheques.HeaderText = "";
            this.btnConfCheques.Name = "btnConfCheques";
            this.btnConfCheques.ReadOnly = true;
            this.btnConfCheques.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnConfCheques.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnConfCheques.Text = "Conf. Cheques";
            this.btnConfCheques.UseColumnTextForButtonValue = true;
            // 
            // FormBancosCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "ELRBanco.FormBancosCuentasR";
            this.Name = "FormBancosCuentas";
            this.NombreCampoID = "Cuenta_Id";
            this.TablaOVista = "TBANCOS_CUENTAS_BANCARIAS";
            this.Text = "BANCOS, CUENTAS BANCARIAS";
            this.Load += new System.EventHandler(this.FormBancosCuentas_Load);
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsCheques;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficina_Id;
        private System.Windows.Forms.DataGridViewButtonColumn btnConfCheques;
    }
}