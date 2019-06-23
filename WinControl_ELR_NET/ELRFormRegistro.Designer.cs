namespace WinControl_ELR_NET
{
    partial class ELRFormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELRFormRegistro));
            this.pnBotones = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguientePage = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.DSDatos = new System.Data.DataSet();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.BackColor = System.Drawing.SystemColors.Control;
            this.pnBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBotones.Controls.Add(this.btnmenu);
            this.pnBotones.Controls.Add(this.lblNombreUsuario);
            this.pnBotones.Controls.Add(this.btnAnterior);
            this.pnBotones.Controls.Add(this.btnSiguientePage);
            this.pnBotones.Controls.Add(this.btnGrabar);
            this.pnBotones.Controls.Add(this.btnCancelar);
            this.pnBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotones.Location = new System.Drawing.Point(0, 444);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(852, 51);
            this.pnBotones.TabIndex = 0;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(95, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(53, 47);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 7;
            this.btnmenu.TabStop = false;
            this.toolTipInfo.SetToolTip(this.btnmenu, "Mostrar menu lateral Ctrl + M");
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(95, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(422, 47);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(0, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(95, 47);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "&Anterior";
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSiguientePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguientePage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSiguientePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguientePage.ForeColor = System.Drawing.Color.White;
            this.btnSiguientePage.Location = new System.Drawing.Point(517, 0);
            this.btnSiguientePage.Name = "btnSiguientePage";
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 47);
            this.btnSiguientePage.TabIndex = 4;
            this.btnSiguientePage.Text = "&Siguiente";
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            this.btnSiguientePage.UseVisualStyleBackColor = false;
            this.btnSiguientePage.Visible = false;
            this.btnSiguientePage.Click += new System.EventHandler(this.btnSiguientePage_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(612, 0);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(141, 47);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Ctrl+G = &Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(753, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 47);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DSDatos
            // 
            this.DSDatos.DataSetName = "DSDatos";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip1.ToolTipTitle = "Validacion del Sistema";
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ELRFormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.pnBotones);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ELRFormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELRFormRegistro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ELRFormRegistro_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ELRFormRegistro_FormClosed);
            this.Load += new System.EventHandler(this.ELRFormRegistro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ELRFormRegistro_KeyDown);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnBotones;
        public System.Windows.Forms.Button btnGrabar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Data.DataSet DSDatos;
        public System.Windows.Forms.ErrorProvider MyErrorProvider;
        public System.Windows.Forms.Button btnAnterior;
        public System.Windows.Forms.Button btnSiguientePage;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}