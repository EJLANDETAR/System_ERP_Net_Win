namespace ELRConsultasReportes
{
    partial class FormProductosEnReorden
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punto_ReOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSoloInventario = new WinControl_ELR_NET.ELRCheckBox();
            this.btnBuscarEntidad = new System.Windows.Forms.Button();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.btnBuscarEntidad);
            this.pnBusqSencilla.Controls.Add(this.txtNombre);
            this.pnBusqSencilla.Controls.Add(this.txtCodigo);
            this.pnBusqSencilla.Controls.Add(this.chkSoloInventario);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 83);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.chkSoloInventario, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarEntidad, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(830, 14);
            this.txtABuscar.Size = new System.Drawing.Size(101, 26);
            this.txtABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 41);
            this.btnBuscar.Size = new System.Drawing.Size(121, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.Text = "Categoria:";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Producto_Id,
            this.Nombre_Corto,
            this.Codigo_Barra,
            this.Categoria,
            this.EnExistencia,
            this.Punto_ReOrden});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(14, 135);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(1023, 359);
            this.dgvData.TabIndex = 48;
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
            this.Producto_Id.HeaderText = "Id";
            this.Producto_Id.Name = "Producto_Id";
            this.Producto_Id.ReadOnly = true;
            this.Producto_Id.Width = 75;
            // 
            // Nombre_Corto
            // 
            this.Nombre_Corto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Corto.DataPropertyName = "Nombre_Corto";
            this.Nombre_Corto.HeaderText = "Nombre";
            this.Nombre_Corto.Name = "Nombre_Corto";
            this.Nombre_Corto.ReadOnly = true;
            // 
            // Codigo_Barra
            // 
            this.Codigo_Barra.DataPropertyName = "Codigo_Barra";
            this.Codigo_Barra.HeaderText = "Codigo";
            this.Codigo_Barra.Name = "Codigo_Barra";
            this.Codigo_Barra.ReadOnly = true;
            this.Codigo_Barra.Width = 120;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 200;
            // 
            // EnExistencia
            // 
            this.EnExistencia.DataPropertyName = "EnExistencia";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0.00";
            this.EnExistencia.DefaultCellStyle = dataGridViewCellStyle11;
            this.EnExistencia.HeaderText = "EnExistencia";
            this.EnExistencia.Name = "EnExistencia";
            this.EnExistencia.ReadOnly = true;
            // 
            // Punto_ReOrden
            // 
            this.Punto_ReOrden.DataPropertyName = "Punto_ReOrden";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.Punto_ReOrden.DefaultCellStyle = dataGridViewCellStyle12;
            this.Punto_ReOrden.HeaderText = "Re Orden";
            this.Punto_ReOrden.Name = "Punto_ReOrden";
            this.Punto_ReOrden.ReadOnly = true;
            this.Punto_ReOrden.Width = 120;
            // 
            // chkSoloInventario
            // 
            this.chkSoloInventario.AutoSize = true;
            this.chkSoloInventario.CampoData = "";
            this.chkSoloInventario.Checked = true;
            this.chkSoloInventario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloInventario.DSData = null;
            this.chkSoloInventario.EsEditable = true;
            this.chkSoloInventario.EsModificable = true;
            this.chkSoloInventario.FiltroBusqueda = "";
            this.chkSoloInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloInventario.Location = new System.Drawing.Point(14, 44);
            this.chkSoloInventario.Name = "chkSoloInventario";
            this.chkSoloInventario.NombreTabla = "";
            this.chkSoloInventario.Size = new System.Drawing.Size(415, 24);
            this.chkSoloInventario.TabIndex = 3;
            this.chkSoloInventario.Text = "Mostrar Solo Productos Forman Parte Inventario";
            this.chkSoloInventario.UseVisualStyleBackColor = true;
            this.chkSoloInventario.ValorPorDefecto = true;
            this.chkSoloInventario.CheckedChanged += new System.EventHandler(this.chkSoloInventario_CheckedChanged);
            // 
            // btnBuscarEntidad
            // 
            this.btnBuscarEntidad.Image = global::ELRConsultasReportes.Properties.Resources._1378160672_search;
            this.btnBuscarEntidad.Location = new System.Drawing.Point(203, 9);
            this.btnBuscarEntidad.Name = "btnBuscarEntidad";
            this.btnBuscarEntidad.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEntidad.TabIndex = 26;
            this.btnBuscarEntidad.UseVisualStyleBackColor = true;
            this.btnBuscarEntidad.Click += new System.EventHandler(this.btnBuscarEntidad_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = null;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(251, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(358, 26);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.Text = "(TODOS)";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = null;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(98, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(99, 26);
            this.txtCodigo.TabIndex = 24;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.Text = "0";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtCodigo, "Digite Codigo a Buscar y Presione Enter");
            this.txtCodigo.ValorPorDefecto = "";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // FormProductosEnReorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dgvData);
            this.DataGridConsulta = this.dgvData;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.FiltroEstatico = "EsActivo = 1 And IsNull(EnExistencia, 0) <= IsNull(Punto_Reorden, 0) ";
            this.Limite = -1;
            this.Name = "FormProductosEnReorden";
            this.NombreCampoID = "Producto_Id";
            this.TablaOVista = "VCATEGORIA_PRODUCTOS";
            this.Text = "LISTADO DE PRODUCTOS EN REORDEN";
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Corto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto_ReOrden;
        private WinControl_ELR_NET.ELRCheckBox chkSoloInventario;
        private System.Windows.Forms.Button btnBuscarEntidad;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
    }
}