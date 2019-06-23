namespace ELRContaGeneral
{
    partial class FormContaEstadosFormatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultiplicaPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.txtFormula);
            this.pnTotales.Location = new System.Drawing.Point(0, 440);
            this.pnTotales.Size = new System.Drawing.Size(953, 63);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.txtFormula, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.lblTitulo);
            this.pnBusqSencilla.Controls.Add(this.btnDown);
            this.pnBusqSencilla.Controls.Add(this.btnUp);
            this.pnBusqSencilla.Controls.Add(this.btnEliminar);
            this.pnBusqSencilla.Location = new System.Drawing.Point(12, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(941, 48);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnEliminar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnUp, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnDown, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblTitulo, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.FiltroBusqueda = "Descripcion Like \'%\' + @aBuscar + \'%\' ";
            this.txtABuscar.Location = new System.Drawing.Point(644, 72);
            this.txtABuscar.Size = new System.Drawing.Size(89, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = null;
            this.btnBuscar.Location = new System.Drawing.Point(414, 69);
            this.btnBuscar.Size = new System.Drawing.Size(99, 37);
            this.btnBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(560, 70);
            this.label1.Visible = false;
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(12, 388);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Formula_Id,
            this.LineaNo,
            this.Descripcion,
            this.Formula,
            this.MultiplicaPor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(941, 340);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtFormula
            // 
            this.txtFormula.BackColor = System.Drawing.Color.White;
            this.txtFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(0, 0);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFormula.Size = new System.Drawing.Size(949, 59);
            this.txtFormula.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.Image = global::ELRContaGeneral.Properties.Resources.CancelCircle;
            this.btnEliminar.Location = new System.Drawing.Point(878, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDown
            // 
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDown.Image = global::ELRContaGeneral.Properties.Resources.ArrowDownCircle;
            this.btnDown.Location = new System.Drawing.Point(760, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(59, 44);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUp.Image = global::ELRContaGeneral.Properties.Resources.ArrowUpCircle;
            this.btnUp.Location = new System.Drawing.Point(819, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(59, 44);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 44);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Formula_Id
            // 
            this.Formula_Id.DataPropertyName = "Formula_Id";
            this.Formula_Id.HeaderText = "Codigo";
            this.Formula_Id.Name = "Formula_Id";
            this.Formula_Id.ReadOnly = true;
            this.Formula_Id.Visible = false;
            this.Formula_Id.Width = 90;
            // 
            // LineaNo
            // 
            this.LineaNo.DataPropertyName = "LineaNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LineaNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.LineaNo.HeaderText = "Linea No";
            this.LineaNo.Name = "LineaNo";
            this.LineaNo.ReadOnly = true;
            this.LineaNo.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 400;
            // 
            // Formula
            // 
            this.Formula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Formula.DataPropertyName = "Formula";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formula.DefaultCellStyle = dataGridViewCellStyle2;
            this.Formula.HeaderText = "Formula";
            this.Formula.Name = "Formula";
            this.Formula.ReadOnly = true;
            // 
            // MultiplicaPor
            // 
            this.MultiplicaPor.DataPropertyName = "MultiplicaPor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = "1";
            this.MultiplicaPor.DefaultCellStyle = dataGridViewCellStyle3;
            this.MultiplicaPor.HeaderText = "Multiplica Por";
            this.MultiplicaPor.Name = "MultiplicaPor";
            this.MultiplicaPor.ReadOnly = true;
            this.MultiplicaPor.Width = 120;
            // 
            // FormContaEstadosFormatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "LineaNo, Unico";
            this.ClientSize = new System.Drawing.Size(953, 525);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsPreview = true;
            this.FormularioRegistro = "ELRContaGeneral.FormContaEstadosFormatosR";
            this.Limite = -1;
            this.Name = "FormContaEstadosFormatos";
            this.NombreCampoID = "Formula_Id";
            this.TablaOVista = "TCONTA_ESTADOS_FORMULAS";
            this.Text = "CONFIGURAR FORMATO DE ESTADO FINANCIERO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormContaEstadosFormatos_Load);
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
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn MultiplicaPor;
    }
}