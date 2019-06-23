namespace ELRCuentasPorPagar
{
    partial class FormInventarioAjuste
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCatCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarCaregoria = new System.Windows.Forms.Button();
            this.txtCategoria = new WinControl_ELR_NET.ELRTextBox();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.chkSoloExistenciaNegativa = new WinControl_ELR_NET.ELRCheckBox();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.txtCodigoprod = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtDescProd = new WinControl_ELR_NET.ELRTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevaExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 434);
            this.pnBotones.Size = new System.Drawing.Size(769, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(529, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 39);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(670, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 39);
            this.btnAnterior.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(434, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 39);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(339, 39);
            // 
            
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCatCodigo);
            this.panel1.Controls.Add(this.btnBuscarCaregoria);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.elrLabel2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.chkSoloExistenciaNegativa);
            this.panel1.Controls.Add(this.elrLabel1);
            this.panel1.Controls.Add(this.txtCodigoprod);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.txtDescProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 137);
            this.panel1.TabIndex = 0;
            // 
            // txtCatCodigo
            // 
            this.txtCatCodigo.AMostrar = null;
            this.txtCatCodigo.AValidar = null;
            this.txtCatCodigo.CampoBusquedaID = "";
            this.txtCatCodigo.CampoData = "";
            this.txtCatCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCatCodigo.ColumnasBusqGeneral = null;
            this.txtCatCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCatCodigo.Decimales = 0;
            this.txtCatCodigo.DSData = null;
            this.txtCatCodigo.EsAutoGenerado = false;
            this.txtCatCodigo.EsBusqueda = false;
            this.txtCatCodigo.EsBusquedaAutoIncremental = false;
            this.txtCatCodigo.EsEditable = true;
            this.txtCatCodigo.FiltroBusqueda = "";
            this.txtCatCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCatCodigo.Location = new System.Drawing.Point(96, 17);
            this.txtCatCodigo.Name = "txtCatCodigo";
            this.txtCatCodigo.NombreTabla = "";
            this.txtCatCodigo.SepDecimal = '\0';
            this.txtCatCodigo.Size = new System.Drawing.Size(100, 29);
            this.txtCatCodigo.TabIndex = 1;
            this.txtCatCodigo.TablaOVistaBusqueda = "";
            this.txtCatCodigo.Text = "0";
            this.txtCatCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCatCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCatCodigo, "Digite Codigo de Producto a Buscar y Presione Enter");
            this.txtCatCodigo.ValorPorDefecto = "";
            this.txtCatCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatCodigo_KeyDown);
            // 
            // btnBuscarCaregoria
            // 
            this.btnBuscarCaregoria.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnBuscarCaregoria.Location = new System.Drawing.Point(202, 15);
            this.btnBuscarCaregoria.Name = "btnBuscarCaregoria";
            this.btnBuscarCaregoria.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarCaregoria.TabIndex = 2;
            this.btnBuscarCaregoria.UseVisualStyleBackColor = true;
            this.btnBuscarCaregoria.Click += new System.EventHandler(this.btnBuscarCaregoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.AMostrar = null;
            this.txtCategoria.AValidar = null;
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.CampoBusquedaID = "";
            this.txtCategoria.CampoData = "";
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.ColumnasBusqGeneral = null;
            this.txtCategoria.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCategoria.Decimales = 0;
            this.txtCategoria.DSData = null;
            this.txtCategoria.EsAutoGenerado = false;
            this.txtCategoria.EsBusqueda = false;
            this.txtCategoria.EsBusquedaAutoIncremental = false;
            this.txtCategoria.EsEditable = true;
            this.txtCategoria.FiltroBusqueda = "";
            this.txtCategoria.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCategoria.Location = new System.Drawing.Point(250, 17);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.NombreTabla = "";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.SepDecimal = '\0';
            this.txtCategoria.Size = new System.Drawing.Size(422, 29);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TablaOVistaBusqueda = "";
            this.txtCategoria.Text = "(TODOS)";
            this.txtCategoria.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCategoria.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCategoria.ValorPorDefecto = "";
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(10, 17);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(80, 21);
            this.elrLabel2.TabIndex = 0;
            this.elrLabel2.Text = "Categoria:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(322, 87);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 34);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(214, 87);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 34);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // chkSoloExistenciaNegativa
            // 
            this.chkSoloExistenciaNegativa.AutoSize = true;
            this.chkSoloExistenciaNegativa.CampoData = "";
            this.chkSoloExistenciaNegativa.Checked = true;
            this.chkSoloExistenciaNegativa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloExistenciaNegativa.DSData = null;
            this.chkSoloExistenciaNegativa.EsEditable = true;
            this.chkSoloExistenciaNegativa.EsModificable = true;
            this.chkSoloExistenciaNegativa.FiltroBusqueda = "";
            this.chkSoloExistenciaNegativa.Location = new System.Drawing.Point(11, 87);
            this.chkSoloExistenciaNegativa.Name = "chkSoloExistenciaNegativa";
            this.chkSoloExistenciaNegativa.NombreTabla = "";
            this.chkSoloExistenciaNegativa.Size = new System.Drawing.Size(197, 25);
            this.chkSoloExistenciaNegativa.TabIndex = 8;
            this.chkSoloExistenciaNegativa.Text = "Solo Existencia Negativa";
            this.chkSoloExistenciaNegativa.UseVisualStyleBackColor = true;
            this.chkSoloExistenciaNegativa.ValorPorDefecto = true;
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(10, 52);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(63, 21);
            this.elrLabel1.TabIndex = 4;
            this.elrLabel1.Text = "Código:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // txtCodigoprod
            // 
            this.txtCodigoprod.AMostrar = null;
            this.txtCodigoprod.AValidar = null;
            this.txtCodigoprod.CampoBusquedaID = "";
            this.txtCodigoprod.CampoData = "";
            this.txtCodigoprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoprod.ColumnasBusqGeneral = null;
            this.txtCodigoprod.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoprod.Decimales = 0;
            this.txtCodigoprod.DSData = null;
            this.txtCodigoprod.EsAutoGenerado = false;
            this.txtCodigoprod.EsBusqueda = false;
            this.txtCodigoprod.EsBusquedaAutoIncremental = false;
            this.txtCodigoprod.EsEditable = true;
            this.txtCodigoprod.FiltroBusqueda = "";
            this.txtCodigoprod.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoprod.Location = new System.Drawing.Point(95, 52);
            this.txtCodigoprod.Name = "txtCodigoprod";
            this.txtCodigoprod.NombreTabla = "";
            this.txtCodigoprod.SepDecimal = '\0';
            this.txtCodigoprod.Size = new System.Drawing.Size(100, 29);
            this.txtCodigoprod.TabIndex = 5;
            this.txtCodigoprod.TablaOVistaBusqueda = "";
            this.txtCodigoprod.Text = "0";
            this.txtCodigoprod.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoprod.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigoprod, "Digite Codigo de Producto a Buscar y Presione Enter");
            this.txtCodigoprod.ValorPorDefecto = "";
            this.txtCodigoprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoprod_KeyDown);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnBuscarProducto.Location = new System.Drawing.Point(201, 50);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtDescProd
            // 
            this.txtDescProd.AMostrar = null;
            this.txtDescProd.AValidar = null;
            this.txtDescProd.BackColor = System.Drawing.Color.White;
            this.txtDescProd.CampoBusquedaID = "";
            this.txtDescProd.CampoData = "";
            this.txtDescProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescProd.ColumnasBusqGeneral = null;
            this.txtDescProd.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescProd.Decimales = 0;
            this.txtDescProd.DSData = null;
            this.txtDescProd.EsAutoGenerado = false;
            this.txtDescProd.EsBusqueda = false;
            this.txtDescProd.EsBusquedaAutoIncremental = false;
            this.txtDescProd.EsEditable = true;
            this.txtDescProd.FiltroBusqueda = "";
            this.txtDescProd.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescProd.Location = new System.Drawing.Point(249, 52);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.NombreTabla = "";
            this.txtDescProd.ReadOnly = true;
            this.txtDescProd.SepDecimal = '\0';
            this.txtDescProd.Size = new System.Drawing.Size(422, 29);
            this.txtDescProd.TabIndex = 7;
            this.txtDescProd.TablaOVistaBusqueda = "";
            this.txtDescProd.Text = "(TODOS)";
            this.txtDescProd.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescProd.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescProd.ValorPorDefecto = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Producto_Id,
            this.Descripcion,
            this.EnExistencia,
            this.NuevaExistencia});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(769, 297);
            this.dataGridView1.TabIndex = 1;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Producto_Id
            // 
            this.Producto_Id.DataPropertyName = "Producto_Id";
            this.Producto_Id.HeaderText = "Código";
            this.Producto_Id.Name = "Producto_Id";
            this.Producto_Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Decripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // EnExistencia
            // 
            this.EnExistencia.DataPropertyName = "EnExistencia";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.EnExistencia.DefaultCellStyle = dataGridViewCellStyle1;
            this.EnExistencia.HeaderText = "Exist. Actual";
            this.EnExistencia.Name = "EnExistencia";
            this.EnExistencia.ReadOnly = true;
            this.EnExistencia.Width = 120;
            // 
            // NuevaExistencia
            // 
            this.NuevaExistencia.DataPropertyName = "NuevaExistencia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.NuevaExistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.NuevaExistencia.HeaderText = "Existencia";
            this.NuevaExistencia.Name = "NuevaExistencia";
            this.NuevaExistencia.Width = 120;
            // 
            // FormInventarioAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.Name = "FormInventarioAjuste";
            this.TablaDetalle = "TTEMPORAL_INVENTARIO_AJUSTES_DETALLES";
            this.Text = "REALIZAR AJUSTE DE INVENTARIO";
            this.Load += new System.EventHandler(this.FormInventarioAjuste_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private WinControl_ELR_NET.ELRTextBox txtDescProd;
        private System.Windows.Forms.Button btnIniciar;
        private WinControl_ELR_NET.ELRCheckBox chkSoloExistenciaNegativa;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private WinControl_ELR_NET.ELRTextBox txtCodigoprod;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinControl_ELR_NET.ELRTextBox txtCatCodigo;
        private System.Windows.Forms.Button btnBuscarCaregoria;
        private WinControl_ELR_NET.ELRTextBox txtCategoria;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevaExistencia;
    }
}