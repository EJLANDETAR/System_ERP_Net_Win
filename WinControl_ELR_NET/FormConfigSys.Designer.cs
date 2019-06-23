namespace WinControl_ELR_NET
{
    partial class FormConfigSys
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCambiarBackGround = new System.Windows.Forms.Button();
            this.ptbBackGround = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnCambiarLogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtComentarioVariable = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarVariable = new System.Windows.Forms.Button();
            this.btnAgregarVariable = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVariables = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unicoVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarVariable = new WinControl_ELR_NET.ELRTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 524);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnCambiarBackGround);
            this.tabPage1.Controls.Add(this.ptbBackGround);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ptbLogo);
            this.tabPage1.Controls.Add(this.btnCambiarLogo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuracion General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 44);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(538, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCambiarBackGround
            // 
            this.btnCambiarBackGround.Location = new System.Drawing.Point(115, 335);
            this.btnCambiarBackGround.Name = "btnCambiarBackGround";
            this.btnCambiarBackGround.Size = new System.Drawing.Size(154, 29);
            this.btnCambiarBackGround.TabIndex = 9;
            this.btnCambiarBackGround.Text = "Cambiar";
            this.btnCambiarBackGround.UseVisualStyleBackColor = true;
            this.btnCambiarBackGround.Click += new System.EventHandler(this.SelectImage);
            // 
            // ptbBackGround
            // 
            this.ptbBackGround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbBackGround.Location = new System.Drawing.Point(115, 209);
            this.ptbBackGround.Name = "ptbBackGround";
            this.ptbBackGround.Size = new System.Drawing.Size(427, 120);
            this.ptbBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBackGround.TabIndex = 7;
            this.ptbBackGround.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "BackGround";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbLogo.Location = new System.Drawing.Point(115, 34);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(154, 125);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 5;
            this.ptbLogo.TabStop = false;
            // 
            // btnCambiarLogo
            // 
            this.btnCambiarLogo.Location = new System.Drawing.Point(115, 165);
            this.btnCambiarLogo.Name = "btnCambiarLogo";
            this.btnCambiarLogo.Size = new System.Drawing.Size(154, 29);
            this.btnCambiarLogo.TabIndex = 4;
            this.btnCambiarLogo.Text = "Cambiar";
            this.btnCambiarLogo.UseVisualStyleBackColor = true;
            this.btnCambiarLogo.Click += new System.EventHandler(this.SelectImage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Variables del Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgVariables);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtComentarioVariable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 484);
            this.panel2.TabIndex = 6;
            // 
            // txtComentarioVariable
            // 
            this.txtComentarioVariable.BackColor = System.Drawing.Color.White;
            this.txtComentarioVariable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtComentarioVariable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioVariable.Location = new System.Drawing.Point(0, 397);
            this.txtComentarioVariable.Multiline = true;
            this.txtComentarioVariable.Name = "txtComentarioVariable";
            this.txtComentarioVariable.ReadOnly = true;
            this.txtComentarioVariable.Size = new System.Drawing.Size(512, 87);
            this.txtComentarioVariable.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditarVariable);
            this.panel3.Controls.Add(this.btnAgregarVariable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(515, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 484);
            this.panel3.TabIndex = 5;
            // 
            // btnEditarVariable
            // 
            this.btnEditarVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarVariable.Location = new System.Drawing.Point(0, 41);
            this.btnEditarVariable.Name = "btnEditarVariable";
            this.btnEditarVariable.Size = new System.Drawing.Size(126, 41);
            this.btnEditarVariable.TabIndex = 1;
            this.btnEditarVariable.Text = "Editar";
            this.btnEditarVariable.UseVisualStyleBackColor = true;
            this.btnEditarVariable.Click += new System.EventHandler(this.EditarVariableClick);
            // 
            // btnAgregarVariable
            // 
            this.btnAgregarVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarVariable.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarVariable.Name = "btnAgregarVariable";
            this.btnAgregarVariable.Size = new System.Drawing.Size(126, 41);
            this.btnAgregarVariable.TabIndex = 0;
            this.btnAgregarVariable.Text = "Agregar";
            this.btnAgregarVariable.UseVisualStyleBackColor = true;
            this.btnAgregarVariable.Click += new System.EventHandler(this.EditarVariableClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtBuscarVariable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 48);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // dtgVariables
            // 
            this.dtgVariables.AllowUserToAddRows = false;
            this.dtgVariables.AllowUserToDeleteRows = false;
            this.dtgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Valor,
            this.unicoVariable,
            this.Comentario});
            this.dtgVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVariables.Location = new System.Drawing.Point(0, 48);
            this.dtgVariables.MultiSelect = false;
            this.dtgVariables.Name = "dtgVariables";
            this.dtgVariables.ReadOnly = true;
            this.dtgVariables.RowHeadersWidth = 28;
            this.dtgVariables.RowTemplate.Height = 33;
            this.dtgVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVariables.Size = new System.Drawing.Size(512, 349);
            this.dtgVariables.TabIndex = 11;
            this.dtgVariables.SelectionChanged += new System.EventHandler(this.dtgVariables_SelectionChanged);
            // 
            // Variable
            // 
            this.Variable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Variable.DataPropertyName = "Variable";
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            this.Variable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Valor.Width = 180;
            // 
            // unicoVariable
            // 
            this.unicoVariable.DataPropertyName = "Unico";
            this.unicoVariable.HeaderText = "Unico";
            this.unicoVariable.Name = "unicoVariable";
            this.unicoVariable.ReadOnly = true;
            this.unicoVariable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unicoVariable.Visible = false;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Visible = false;
            // 
            // txtBuscarVariable
            // 
            this.txtBuscarVariable.AMostrar = null;
            this.txtBuscarVariable.AValidar = null;
            this.txtBuscarVariable.CampoBusquedaID = "";
            this.txtBuscarVariable.CampoData = "";
            this.txtBuscarVariable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarVariable.ColumnasBusqGeneral = null;
            this.txtBuscarVariable.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtBuscarVariable.Decimales = 0;
            this.txtBuscarVariable.DSData = null;
            this.txtBuscarVariable.EsAutoGenerado = false;
            this.txtBuscarVariable.EsBusqueda = false;
            this.txtBuscarVariable.EsBusquedaAutoIncremental = false;
            this.txtBuscarVariable.EsEditable = true;
            this.txtBuscarVariable.FiltroBusqueda = "";
            this.txtBuscarVariable.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtBuscarVariable.Location = new System.Drawing.Point(91, 8);
            this.txtBuscarVariable.Name = "txtBuscarVariable";
            this.txtBuscarVariable.NombreTabla = "";
            this.txtBuscarVariable.SepDecimal = '\0';
            this.txtBuscarVariable.Size = new System.Drawing.Size(395, 33);
            this.txtBuscarVariable.TabIndex = 6;
            this.txtBuscarVariable.TablaOVistaBusqueda = "";
            this.txtBuscarVariable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtBuscarVariable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtBuscarVariable, "Digite Nombre Variable a Buscar y Presione Enter");
            this.txtBuscarVariable.ValorPorDefecto = "";
            this.txtBuscarVariable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarVariable_KeyDown);
            // 
            // FormConfigSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 524);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConfigSys";
            this.Text = "Configuracion del Sistema";
            this.Load += new System.EventHandler(this.FormConfigSys_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVariables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCambiarBackGround;
        private System.Windows.Forms.PictureBox ptbBackGround;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnCambiarLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditarVariable;
        private System.Windows.Forms.Button btnAgregarVariable;
        private System.Windows.Forms.TextBox txtComentarioVariable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private ELRTextBox txtBuscarVariable;
        private System.Windows.Forms.DataGridView dtgVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn unicoVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
    }
}