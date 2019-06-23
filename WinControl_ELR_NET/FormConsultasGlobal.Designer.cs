namespace WinControl_ELR_NET
{
    partial class FormConsultasGlobal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultasGlobal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnCentroBuscarMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboBuscarPorMenu = new WinControl_ELR_NET.ELRCombobox();
            this.txtBuscarMenu = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnCentroBuscarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNombreUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1044, 31);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmNombreUsuario
            // 
            this.tsmNombreUsuario.Name = "tsmNombreUsuario";
            this.tsmNombreUsuario.Size = new System.Drawing.Size(152, 26);
            this.tsmNombreUsuario.Text = "NOMBRE.USUARIO";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1459190980_document.png");
            this.imageList1.Images.SetKeyName(1, "report.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpMenu);
            this.splitContainer1.Panel2.Controls.Add(this.pnCentroBuscarMenu);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 391);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 1;
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvMenu.ImageIndex = 0;
            this.trvMenu.ImageList = this.imageList1;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.SelectedImageIndex = 0;
            this.trvMenu.ShowLines = false;
            this.trvMenu.Size = new System.Drawing.Size(346, 391);
            this.trvMenu.TabIndex = 2;
            this.trvMenu.DoubleClick += new System.EventHandler(this.trvMenu_DoubleClick);
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor = System.Drawing.Color.Transparent;
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.Location = new System.Drawing.Point(0, 54);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(694, 337);
            this.flpMenu.TabIndex = 6;
            // 
            // pnCentroBuscarMenu
            // 
            this.pnCentroBuscarMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCentroBuscarMenu.Controls.Add(this.btnCerrar);
            this.pnCentroBuscarMenu.Controls.Add(this.cboBuscarPorMenu);
            this.pnCentroBuscarMenu.Controls.Add(this.txtBuscarMenu);
            this.pnCentroBuscarMenu.Controls.Add(this.label1);
            this.pnCentroBuscarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCentroBuscarMenu.Location = new System.Drawing.Point(0, 0);
            this.pnCentroBuscarMenu.Name = "pnCentroBuscarMenu";
            this.pnCentroBuscarMenu.Size = new System.Drawing.Size(694, 54);
            this.pnCentroBuscarMenu.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(562, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(128, 50);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboBuscarPorMenu
            // 
            this.cboBuscarPorMenu.AValidar = null;
            this.cboBuscarPorMenu.CampoData = "";
            this.cboBuscarPorMenu.CampoJoinCombobox2 = "";
            this.cboBuscarPorMenu.ComboboxAFiltrar = null;
            this.cboBuscarPorMenu.DisplayMember = "Carpeta";
            this.cboBuscarPorMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPorMenu.DSData = null;
            this.cboBuscarPorMenu.EsEditable = true;
            this.cboBuscarPorMenu.FiltroBusqueda = "";
            this.cboBuscarPorMenu.FormattingEnabled = true;
            this.cboBuscarPorMenu.Location = new System.Drawing.Point(315, 5);
            this.cboBuscarPorMenu.Name = "cboBuscarPorMenu";
            this.cboBuscarPorMenu.NombreTabla = "";
            this.cboBuscarPorMenu.Size = new System.Drawing.Size(241, 29);
            this.cboBuscarPorMenu.SSQL = "";
            this.cboBuscarPorMenu.TabIndex = 3;
            this.cboBuscarPorMenu.TablaOVistaConsulta = "";
            this.cboBuscarPorMenu.UsaDataGlobal = false;
            this.cboBuscarPorMenu.ValorPorDefecto = "0";
            this.cboBuscarPorMenu.ValueMember = "Modulo_Id";
            this.cboBuscarPorMenu.SelectedValueChanged += new System.EventHandler(this.cboBuscarPorMenu_SelectedValueChanged);
            // 
            // txtBuscarMenu
            // 
            this.txtBuscarMenu.AMostrar = null;
            this.txtBuscarMenu.autoSenTab = true;
            this.txtBuscarMenu.AValidar = null;
            this.txtBuscarMenu.CampoBusquedaID = "";
            this.txtBuscarMenu.CampoData = "";
            this.txtBuscarMenu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarMenu.ColumnasBusqGeneral = null;
            this.txtBuscarMenu.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtBuscarMenu.Decimales = 0;
            this.txtBuscarMenu.DSData = null;
            this.txtBuscarMenu.EsAutoGenerado = false;
            this.txtBuscarMenu.EsBusqueda = false;
            this.txtBuscarMenu.EsBusquedaAutoIncremental = false;
            this.txtBuscarMenu.EsEditable = true;
            this.txtBuscarMenu.FiltroBusqueda = "";
            this.txtBuscarMenu.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtBuscarMenu.Location = new System.Drawing.Point(69, 5);
            this.txtBuscarMenu.Name = "txtBuscarMenu";
            this.txtBuscarMenu.NombreTabla = "";
            this.txtBuscarMenu.SepDecimal = '\0';
            this.txtBuscarMenu.Size = new System.Drawing.Size(240, 29);
            this.txtBuscarMenu.TabIndex = 1;
            this.txtBuscarMenu.TablaOVistaBusqueda = "";
            this.txtBuscarMenu.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtBuscarMenu.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtBuscarMenu.ValorPorDefecto = "";
            this.txtBuscarMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMenu_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // FormConsultasGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(1044, 422);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConsultasGlobal";
            this.Text = "CONSULTAS DEL SISTEMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormConsultasGlobal_Activated);
            this.Load += new System.EventHandler(this.FormConsultasGlobal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnCentroBuscarMenu.ResumeLayout(false);
            this.pnCentroBuscarMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsmNombreUsuario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnCentroBuscarMenu;
        private ELRCombobox cboBuscarPorMenu;
        private ELRTextBox txtBuscarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        public System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCerrar;
    }
}