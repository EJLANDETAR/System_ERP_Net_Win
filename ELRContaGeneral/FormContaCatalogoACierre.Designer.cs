namespace ELRContaGeneral
{
    partial class FormContaCatalogoACierre
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
            this.btnBuscarAuxiliar = new System.Windows.Forms.Button();
            this.btnBuscaCuenta = new System.Windows.Forms.Button();
            this.lblDescripcionCentroCosto = new System.Windows.Forms.Label();
            this.lblDescripcionCuenta = new System.Windows.Forms.Label();
            this.txtAnio = new WinControl_ELR_NET.ELRTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboMes = new WinControl_ELR_NET.ELRCombobox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCentroCosto = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Mes_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito_Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Controls.Add(this.txtAnio);
            this.pnBusqSencilla.Controls.Add(this.label18);
            this.pnBusqSencilla.Controls.Add(this.cboMes);
            this.pnBusqSencilla.Controls.Add(this.label19);
            this.pnBusqSencilla.Controls.Add(this.txtCentroCosto);
            this.pnBusqSencilla.Controls.Add(this.label9);
            this.pnBusqSencilla.Controls.Add(this.btnBuscarAuxiliar);
            this.pnBusqSencilla.Controls.Add(this.btnBuscaCuenta);
            this.pnBusqSencilla.Controls.Add(this.lblDescripcionCentroCosto);
            this.pnBusqSencilla.Controls.Add(this.lblDescripcionCuenta);
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 151);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label1, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtABuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblDescripcionCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.lblDescripcionCentroCosto, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscaCuenta, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.btnBuscarAuxiliar, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label9, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtCentroCosto, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label19, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.cboMes, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.label18, 0);
            this.pnBusqSencilla.Controls.SetChildIndex(this.txtAnio, 0);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(157, 6);
            this.txtABuscar.Size = new System.Drawing.Size(176, 26);
            this.txtABuscar.Leave += new System.EventHandler(this.txtABuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(387, 70);
            this.btnBuscar.Size = new System.Drawing.Size(166, 62);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.Text = "Cuenta Contable:";
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // btnBuscarAuxiliar
            // 
            this.btnBuscarAuxiliar.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnBuscarAuxiliar.Location = new System.Drawing.Point(339, 37);
            this.btnBuscarAuxiliar.Name = "btnBuscarAuxiliar";
            this.btnBuscarAuxiliar.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarAuxiliar.TabIndex = 81;
            this.btnBuscarAuxiliar.UseVisualStyleBackColor = true;
            this.btnBuscarAuxiliar.Click += new System.EventHandler(this.btnBuscarAuxiliar_Click);
            // 
            // btnBuscaCuenta
            // 
            this.btnBuscaCuenta.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnBuscaCuenta.Location = new System.Drawing.Point(339, 4);
            this.btnBuscaCuenta.Name = "btnBuscaCuenta";
            this.btnBuscaCuenta.Size = new System.Drawing.Size(42, 31);
            this.btnBuscaCuenta.TabIndex = 80;
            this.btnBuscaCuenta.UseVisualStyleBackColor = true;
            this.btnBuscaCuenta.Click += new System.EventHandler(this.btnBuscaCuenta_Click);
            // 
            // lblDescripcionCentroCosto
            // 
            this.lblDescripcionCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcionCentroCosto.Location = new System.Drawing.Point(387, 37);
            this.lblDescripcionCentroCosto.Name = "lblDescripcionCentroCosto";
            this.lblDescripcionCentroCosto.Size = new System.Drawing.Size(434, 26);
            this.lblDescripcionCentroCosto.TabIndex = 79;
            this.lblDescripcionCentroCosto.Text = "(TODOS)";
            // 
            // lblDescripcionCuenta
            // 
            this.lblDescripcionCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcionCuenta.Location = new System.Drawing.Point(387, 5);
            this.lblDescripcionCuenta.Name = "lblDescripcionCuenta";
            this.lblDescripcionCuenta.Size = new System.Drawing.Size(434, 27);
            this.lblDescripcionCuenta.TabIndex = 78;
            this.lblDescripcionCuenta.Text = "(TODOS)";
            // 
            // txtAnio
            // 
            this.txtAnio.AMostrar = null;
            this.txtAnio.AValidar = null;
            this.txtAnio.CampoBusquedaID = "";
            this.txtAnio.CampoData = "";
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnio.ColumnasBusqGeneral = null;
            this.txtAnio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAnio.Decimales = 0;
            this.txtAnio.DSData = null;
            this.txtAnio.EsAutoGenerado = false;
            this.txtAnio.EsBusqueda = false;
            this.txtAnio.EsBusquedaAutoIncremental = false;
            this.txtAnio.EsEditable = true;
            this.txtAnio.FiltroBusqueda = "";
            this.txtAnio.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtAnio.Location = new System.Drawing.Point(157, 106);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.NombreTabla = "";
            this.txtAnio.SepDecimal = '\0';
            this.txtAnio.Size = new System.Drawing.Size(224, 26);
            this.txtAnio.TabIndex = 87;
            this.txtAnio.TablaOVistaBusqueda = "";
            this.txtAnio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAnio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAnio.ValorPorDefecto = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 20);
            this.label18.TabIndex = 86;
            this.label18.Text = "Anio:";
            // 
            // cboMes
            // 
            this.cboMes.AValidar = null;
            this.cboMes.CampoData = "";
            this.cboMes.CampoJoinCombobox2 = "";
            this.cboMes.ComboboxAFiltrar = null;
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.DSData = null;
            this.cboMes.EsEditable = true;
            this.cboMes.FiltroBusqueda = "";
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE",
            "MES 13"});
            this.cboMes.Location = new System.Drawing.Point(156, 71);
            this.cboMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMes.Name = "cboMes";
            this.cboMes.NombreTabla = "";
            this.cboMes.Size = new System.Drawing.Size(224, 28);
            this.cboMes.SSQL = "";
            this.cboMes.TabIndex = 85;
            this.cboMes.TablaOVistaConsulta = "";
            this.cboMes.UsaDataGlobal = false;
            this.cboMes.ValorPorDefecto = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 20);
            this.label19.TabIndex = 84;
            this.label19.Text = "Mes Saldo:";
            // 
            // txtCentroCosto
            // 
            this.txtCentroCosto.AMostrar = null;
            this.txtCentroCosto.AValidar = null;
            this.txtCentroCosto.CampoBusquedaID = "";
            this.txtCentroCosto.CampoData = "";
            this.txtCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCentroCosto.ColumnasBusqGeneral = null;
            this.txtCentroCosto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCentroCosto.Decimales = 0;
            this.txtCentroCosto.DSData = null;
            this.txtCentroCosto.EsAutoGenerado = false;
            this.txtCentroCosto.EsBusqueda = false;
            this.txtCentroCosto.EsBusquedaAutoIncremental = false;
            this.txtCentroCosto.EsEditable = true;
            this.txtCentroCosto.FiltroBusqueda = "";
            this.txtCentroCosto.Formato = WinControl_ELR_NET.tbFormato.NumerosEnterosPositivos;
            this.txtCentroCosto.Location = new System.Drawing.Point(156, 39);
            this.txtCentroCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCentroCosto.Name = "txtCentroCosto";
            this.txtCentroCosto.NombreTabla = "";
            this.txtCentroCosto.SepDecimal = '\0';
            this.txtCentroCosto.Size = new System.Drawing.Size(176, 26);
            this.txtCentroCosto.TabIndex = 83;
            this.txtCentroCosto.TablaOVistaBusqueda = "";
            this.txtCentroCosto.Text = "0";
            this.txtCentroCosto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCentroCosto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCentroCosto.ValorPorDefecto = "";
            this.txtCentroCosto.Leave += new System.EventHandler(this.txtCentroCosto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "C. Costo\\Sucursal:";
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
            this.Saldo_Mes_Anterior,
            this.Debito_Mes,
            this.Credito_Mes,
            this.Saldo_Actual});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 291);
            this.dataGridView1.TabIndex = 49;
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
            // Saldo_Mes_Anterior
            // 
            this.Saldo_Mes_Anterior.DataPropertyName = "Saldo_Mes_Anterior";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Saldo_Mes_Anterior.DefaultCellStyle = dataGridViewCellStyle1;
            this.Saldo_Mes_Anterior.HeaderText = "S. Mes Anterior";
            this.Saldo_Mes_Anterior.Name = "Saldo_Mes_Anterior";
            this.Saldo_Mes_Anterior.Width = 130;
            // 
            // Debito_Mes
            // 
            this.Debito_Mes.DataPropertyName = "Debito_Mes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Debito_Mes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Debito_Mes.HeaderText = "Debito Mes";
            this.Debito_Mes.Name = "Debito_Mes";
            this.Debito_Mes.Width = 130;
            // 
            // Credito_Mes
            // 
            this.Credito_Mes.DataPropertyName = "Credito_Mes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Credito_Mes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Credito_Mes.HeaderText = "Credito Mes";
            this.Credito_Mes.Name = "Credito_Mes";
            this.Credito_Mes.Width = 130;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.DataPropertyName = "Saldo_Actual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Saldo_Actual.DefaultCellStyle = dataGridViewCellStyle4;
            this.Saldo_Actual.HeaderText = "Saldo";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.Width = 130;
            // 
            // FormContaCatalogoACierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsFilasAMostrar = false;
            this.EsImprimir = true;
            this.EsModificar = false;
            this.Name = "FormContaCatalogoACierre";
            this.Text = "CONSULTAR CATALOGO EN CIERRE";
            this.Load += new System.EventHandler(this.FormContaCatalogoACierre_Load);
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

        private System.Windows.Forms.Button btnBuscarAuxiliar;
        private System.Windows.Forms.Button btnBuscaCuenta;
        private System.Windows.Forms.Label lblDescripcionCentroCosto;
        private System.Windows.Forms.Label lblDescripcionCuenta;
        private WinControl_ELR_NET.ELRTextBox txtAnio;
        private System.Windows.Forms.Label label18;
        private WinControl_ELR_NET.ELRCombobox cboMes;
        private System.Windows.Forms.Label label19;
        private WinControl_ELR_NET.ELRTextBox txtCentroCosto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Mes_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito_Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
    }
}