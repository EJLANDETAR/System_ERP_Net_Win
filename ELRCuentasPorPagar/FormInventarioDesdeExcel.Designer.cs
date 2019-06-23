namespace ELRCuentasPorPagar
{
    partial class FormInventarioDesdeExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreArchivo = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCargarCon = new WinControl_ELR_NET.ELRCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsInventario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tasa_Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opFD = new System.Windows.Forms.OpenFileDialog();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Size = new System.Drawing.Size(1002, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(762, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(903, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(667, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(572, 39);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNombreArchivo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 90);
            this.panel1.TabIndex = 0;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.AMostrar = null;
            this.txtNombreArchivo.AValidar = null;
            this.txtNombreArchivo.BackColor = System.Drawing.Color.White;
            this.txtNombreArchivo.CampoBusquedaID = "";
            this.txtNombreArchivo.CampoData = "";
            this.txtNombreArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreArchivo.ColumnasBusqGeneral = null;
            this.txtNombreArchivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreArchivo.Decimales = 0;
            this.txtNombreArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreArchivo.DSData = null;
            this.txtNombreArchivo.EsAutoGenerado = false;
            this.txtNombreArchivo.EsBusqueda = false;
            this.txtNombreArchivo.EsBusquedaAutoIncremental = false;
            this.txtNombreArchivo.EsEditable = true;
            this.txtNombreArchivo.FiltroBusqueda = "";
            this.txtNombreArchivo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreArchivo.Location = new System.Drawing.Point(491, 0);
            this.txtNombreArchivo.Multiline = true;
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.NombreTabla = "";
            this.txtNombreArchivo.ReadOnly = true;
            this.txtNombreArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNombreArchivo.SepDecimal = '\0';
            this.txtNombreArchivo.Size = new System.Drawing.Size(507, 86);
            this.txtNombreArchivo.TabIndex = 1;
            this.txtNombreArchivo.TablaOVistaBusqueda = "";
            this.txtNombreArchivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreArchivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreArchivo.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboCargarCon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBuscarArchivo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 86);
            this.panel2.TabIndex = 0;
            // 
            // cboCargarCon
            // 
            this.cboCargarCon.AValidar = null;
            this.cboCargarCon.CampoData = "";
            this.cboCargarCon.CampoJoinCombobox2 = "";
            this.cboCargarCon.ComboboxAFiltrar = null;
            this.cboCargarCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargarCon.DSData = null;
            this.cboCargarCon.EsEditable = true;
            this.cboCargarCon.FiltroBusqueda = "";
            this.cboCargarCon.FormattingEnabled = true;
            this.cboCargarCon.Location = new System.Drawing.Point(120, 10);
            this.cboCargarCon.Name = "cboCargarCon";
            this.cboCargarCon.NombreTabla = "";
            this.cboCargarCon.Size = new System.Drawing.Size(343, 29);
            this.cboCargarCon.SSQL = "";
            this.cboCargarCon.TabIndex = 1;
            this.cboCargarCon.TablaOVistaConsulta = "";
            this.cboCargarCon.UsaDataGlobal = false;
            this.cboCargarCon.ValorPorDefecto = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargar Con:";
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(120, 42);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(155, 38);
            this.btnBuscarArchivo.TabIndex = 2;
            this.btnBuscarArchivo.Text = "Buscar";
            this.btnBuscarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Codigo,
            this.Marca,
            this.Categoria,
            this.Cantidad,
            this.Costo,
            this.Precio_Regular,
            this.Precio_Minimo,
            this.EsInventario,
            this.Tasa_Itbis,
            this.Nombre,
            this.IdentificadorTemp});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 322);
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
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo_Barra";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 120;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "EnExistencia";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 90;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo_Ultima_Compra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Costo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 120;
            // 
            // Precio_Regular
            // 
            this.Precio_Regular.DataPropertyName = "Precio_Regular";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Precio_Regular.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio_Regular.HeaderText = "Pre. Regular";
            this.Precio_Regular.Name = "Precio_Regular";
            this.Precio_Regular.ReadOnly = true;
            this.Precio_Regular.Width = 120;
            // 
            // Precio_Minimo
            // 
            this.Precio_Minimo.DataPropertyName = "Precio_Minimo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Precio_Minimo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio_Minimo.HeaderText = "Pre. Min";
            this.Precio_Minimo.Name = "Precio_Minimo";
            this.Precio_Minimo.ReadOnly = true;
            this.Precio_Minimo.Width = 95;
            // 
            // EsInventario
            // 
            this.EsInventario.DataPropertyName = "EsInventario";
            this.EsInventario.HeaderText = "EsInv.";
            this.EsInventario.Name = "EsInventario";
            this.EsInventario.ReadOnly = true;
            this.EsInventario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsInventario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsInventario.Width = 70;
            // 
            // Tasa_Itbis
            // 
            this.Tasa_Itbis.DataPropertyName = "Tasa_Itbis";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Tasa_Itbis.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tasa_Itbis.HeaderText = "% Itbis";
            this.Tasa_Itbis.Name = "Tasa_Itbis";
            this.Tasa_Itbis.ReadOnly = true;
            this.Tasa_Itbis.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Descripcion";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IdentificadorTemp
            // 
            this.IdentificadorTemp.DataPropertyName = "IdentificadorTemp";
            this.IdentificadorTemp.HeaderText = "IdentificadorTemp";
            this.IdentificadorTemp.Name = "IdentificadorTemp";
            this.IdentificadorTemp.ReadOnly = true;
            this.IdentificadorTemp.Visible = false;
            // 
            // opFD
            // 
            this.opFD.FileName = "openFileDialog1";
            // 
            // FormInventarioDesdeExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridDetalle = this.dataGridView1;
            this.EsConTemporal = true;
            this.Name = "FormInventarioDesdeExcel";
            this.TablaDetalle = "TTEMPORAL_CLASIFICADOR_PRODUCTOS";
            this.TablaEncabezado = "TTEMPORAL_CLASIFICADOR_PRODUCTOS";
            this.Text = "CARGAR INVENTARIO DESDE EXCEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInventarioDesdeExcel_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog opFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Regular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Minimo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorTemp;
        private WinControl_ELR_NET.ELRTextBox txtNombreArchivo;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRCombobox cboCargarCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarArchivo;
    }
}