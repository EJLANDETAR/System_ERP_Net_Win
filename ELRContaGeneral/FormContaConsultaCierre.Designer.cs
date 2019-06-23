namespace ELRContaGeneral
{
    partial class FormContaConsultaCierre
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
            this.grbTotales = new System.Windows.Forms.GroupBox();
            this.txtCapital = new WinControl_ELR_NET.ELRTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPasivos = new WinControl_ELR_NET.ELRTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGastos = new WinControl_ELR_NET.ELRTextBox();
            this.txtCostos = new WinControl_ELR_NET.ELRTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActivos = new WinControl_ELR_NET.ELRTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionado_Por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Adicionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIngresos = new WinControl_ELR_NET.ELRTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotales
            // 
            this.pnTotales.Controls.Add(this.grbTotales);
            this.pnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTotales.Location = new System.Drawing.Point(14, 315);
            this.pnTotales.Size = new System.Drawing.Size(907, 203);
            this.pnTotales.Visible = true;
            this.pnTotales.Controls.SetChildIndex(this.lblCantidadRegistro, 0);
            this.pnTotales.Controls.SetChildIndex(this.grbTotales, 0);
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(907, 46);
            // 
            // lblCantidadRegistro
            // 
            this.lblCantidadRegistro.Location = new System.Drawing.Point(747, 29);
            this.lblCantidadRegistro.Size = new System.Drawing.Size(57, 20);
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
            this.Fecha,
            this.Tipo_Cierre,
            this.Concepto,
            this.Adicionado_Por,
            this.Fecha_Adicionado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.Size = new System.Drawing.Size(907, 217);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // grbTotales
            // 
            this.grbTotales.Controls.Add(this.txtIngresos);
            this.grbTotales.Controls.Add(this.label9);
            this.grbTotales.Controls.Add(this.lblTotal);
            this.grbTotales.Controls.Add(this.txtCapital);
            this.grbTotales.Controls.Add(this.label10);
            this.grbTotales.Controls.Add(this.txtPasivos);
            this.grbTotales.Controls.Add(this.label11);
            this.grbTotales.Controls.Add(this.txtGastos);
            this.grbTotales.Controls.Add(this.txtCostos);
            this.grbTotales.Controls.Add(this.label8);
            this.grbTotales.Controls.Add(this.label7);
            this.grbTotales.Controls.Add(this.txtActivos);
            this.grbTotales.Controls.Add(this.label6);
            this.grbTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTotales.Location = new System.Drawing.Point(0, 0);
            this.grbTotales.Name = "grbTotales";
            this.grbTotales.Size = new System.Drawing.Size(903, 199);
            this.grbTotales.TabIndex = 1;
            this.grbTotales.TabStop = false;
            this.grbTotales.Text = "Total a Fecha de Corte 00/00/0000";
            // 
            // txtCapital
            // 
            this.txtCapital.AMostrar = null;
            this.txtCapital.AValidar = null;
            this.txtCapital.BackColor = System.Drawing.Color.White;
            this.txtCapital.CampoBusquedaID = "";
            this.txtCapital.CampoData = "";
            this.txtCapital.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCapital.ColumnasBusqGeneral = null;
            this.txtCapital.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCapital.Decimales = 0;
            this.txtCapital.DSData = null;
            this.txtCapital.EsAutoGenerado = false;
            this.txtCapital.EsBusqueda = false;
            this.txtCapital.EsBusquedaAutoIncremental = false;
            this.txtCapital.EsEditable = true;
            this.txtCapital.FiltroBusqueda = "";
            this.txtCapital.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCapital.Location = new System.Drawing.Point(507, 71);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.NombreTabla = "";
            this.txtCapital.ReadOnly = true;
            this.txtCapital.SepDecimal = '\0';
            this.txtCapital.Size = new System.Drawing.Size(209, 29);
            this.txtCapital.TabIndex = 10;
            this.txtCapital.TablaOVistaBusqueda = "";
            this.txtCapital.Text = "0.00";
            this.txtCapital.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCapital.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCapital.ValorPorDefecto = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Capital:";
            // 
            // txtPasivos
            // 
            this.txtPasivos.AMostrar = null;
            this.txtPasivos.AValidar = null;
            this.txtPasivos.BackColor = System.Drawing.Color.White;
            this.txtPasivos.CampoBusquedaID = "";
            this.txtPasivos.CampoData = "";
            this.txtPasivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasivos.ColumnasBusqGeneral = null;
            this.txtPasivos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPasivos.Decimales = 0;
            this.txtPasivos.DSData = null;
            this.txtPasivos.EsAutoGenerado = false;
            this.txtPasivos.EsBusqueda = false;
            this.txtPasivos.EsBusquedaAutoIncremental = false;
            this.txtPasivos.EsEditable = true;
            this.txtPasivos.FiltroBusqueda = "";
            this.txtPasivos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtPasivos.Location = new System.Drawing.Point(507, 36);
            this.txtPasivos.Name = "txtPasivos";
            this.txtPasivos.NombreTabla = "";
            this.txtPasivos.ReadOnly = true;
            this.txtPasivos.SepDecimal = '\0';
            this.txtPasivos.Size = new System.Drawing.Size(209, 29);
            this.txtPasivos.TabIndex = 7;
            this.txtPasivos.TablaOVistaBusqueda = "";
            this.txtPasivos.Text = "0.00";
            this.txtPasivos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPasivos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPasivos.ValorPorDefecto = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Pasivos:";
            // 
            // txtGastos
            // 
            this.txtGastos.AMostrar = null;
            this.txtGastos.AValidar = null;
            this.txtGastos.BackColor = System.Drawing.Color.White;
            this.txtGastos.CampoBusquedaID = "";
            this.txtGastos.CampoData = "";
            this.txtGastos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGastos.ColumnasBusqGeneral = null;
            this.txtGastos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtGastos.Decimales = 0;
            this.txtGastos.DSData = null;
            this.txtGastos.EsAutoGenerado = false;
            this.txtGastos.EsBusqueda = false;
            this.txtGastos.EsBusquedaAutoIncremental = false;
            this.txtGastos.EsEditable = true;
            this.txtGastos.FiltroBusqueda = "";
            this.txtGastos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtGastos.Location = new System.Drawing.Point(118, 109);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.NombreTabla = "";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.SepDecimal = '\0';
            this.txtGastos.Size = new System.Drawing.Size(209, 29);
            this.txtGastos.TabIndex = 5;
            this.txtGastos.TablaOVistaBusqueda = "";
            this.txtGastos.Text = "0.00";
            this.txtGastos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtGastos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtGastos.ValorPorDefecto = "";
            // 
            // txtCostos
            // 
            this.txtCostos.AMostrar = null;
            this.txtCostos.AValidar = null;
            this.txtCostos.BackColor = System.Drawing.Color.White;
            this.txtCostos.CampoBusquedaID = "";
            this.txtCostos.CampoData = "";
            this.txtCostos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCostos.ColumnasBusqGeneral = null;
            this.txtCostos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCostos.Decimales = 0;
            this.txtCostos.DSData = null;
            this.txtCostos.EsAutoGenerado = false;
            this.txtCostos.EsBusqueda = false;
            this.txtCostos.EsBusquedaAutoIncremental = false;
            this.txtCostos.EsEditable = true;
            this.txtCostos.FiltroBusqueda = "";
            this.txtCostos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCostos.Location = new System.Drawing.Point(118, 74);
            this.txtCostos.Name = "txtCostos";
            this.txtCostos.NombreTabla = "";
            this.txtCostos.ReadOnly = true;
            this.txtCostos.SepDecimal = '\0';
            this.txtCostos.Size = new System.Drawing.Size(209, 29);
            this.txtCostos.TabIndex = 4;
            this.txtCostos.TablaOVistaBusqueda = "";
            this.txtCostos.Text = "0.00";
            this.txtCostos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCostos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCostos.ValorPorDefecto = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Gastos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Costos:";
            // 
            // txtActivos
            // 
            this.txtActivos.AMostrar = null;
            this.txtActivos.AValidar = null;
            this.txtActivos.BackColor = System.Drawing.Color.White;
            this.txtActivos.CampoBusquedaID = "";
            this.txtActivos.CampoData = "";
            this.txtActivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActivos.ColumnasBusqGeneral = null;
            this.txtActivos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtActivos.Decimales = 0;
            this.txtActivos.DSData = null;
            this.txtActivos.EsAutoGenerado = false;
            this.txtActivos.EsBusqueda = false;
            this.txtActivos.EsBusquedaAutoIncremental = false;
            this.txtActivos.EsEditable = true;
            this.txtActivos.FiltroBusqueda = "";
            this.txtActivos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtActivos.Location = new System.Drawing.Point(118, 39);
            this.txtActivos.Name = "txtActivos";
            this.txtActivos.NombreTabla = "";
            this.txtActivos.ReadOnly = true;
            this.txtActivos.SepDecimal = '\0';
            this.txtActivos.Size = new System.Drawing.Size(209, 29);
            this.txtActivos.TabIndex = 1;
            this.txtActivos.TablaOVistaBusqueda = "";
            this.txtActivos.Text = "0.00";
            this.txtActivos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtActivos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtActivos.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Activos:";
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // Tipo_Cierre
            // 
            this.Tipo_Cierre.DataPropertyName = "Tipo_Cierre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Cierre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo_Cierre.HeaderText = "Tipo";
            this.Tipo_Cierre.Name = "Tipo_Cierre";
            this.Tipo_Cierre.ReadOnly = true;
            this.Tipo_Cierre.Width = 85;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Adicionado_Por
            // 
            this.Adicionado_Por.DataPropertyName = "Adicionado_Por";
            this.Adicionado_Por.HeaderText = "Autor";
            this.Adicionado_Por.Name = "Adicionado_Por";
            this.Adicionado_Por.ReadOnly = true;
            this.Adicionado_Por.Width = 200;
            // 
            // Fecha_Adicionado
            // 
            this.Fecha_Adicionado.DataPropertyName = "Fecha_Adicionado";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm:ss tt";
            this.Fecha_Adicionado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha_Adicionado.HeaderText = "Autor Fecha";
            this.Fecha_Adicionado.Name = "Fecha_Adicionado";
            this.Fecha_Adicionado.ReadOnly = true;
            this.Fecha_Adicionado.Width = 200;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Location = new System.Drawing.Point(3, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(897, 35);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Activos + Costos + Gastos = 0.00          Pasivos + Capital = 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngresos
            // 
            this.txtIngresos.AMostrar = null;
            this.txtIngresos.AValidar = null;
            this.txtIngresos.BackColor = System.Drawing.Color.White;
            this.txtIngresos.CampoBusquedaID = "";
            this.txtIngresos.CampoData = "";
            this.txtIngresos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIngresos.ColumnasBusqGeneral = null;
            this.txtIngresos.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtIngresos.Decimales = 0;
            this.txtIngresos.DSData = null;
            this.txtIngresos.EsAutoGenerado = false;
            this.txtIngresos.EsBusqueda = false;
            this.txtIngresos.EsBusquedaAutoIncremental = false;
            this.txtIngresos.EsEditable = true;
            this.txtIngresos.FiltroBusqueda = "";
            this.txtIngresos.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtIngresos.Location = new System.Drawing.Point(507, 106);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.NombreTabla = "";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.SepDecimal = '\0';
            this.txtIngresos.Size = new System.Drawing.Size(209, 29);
            this.txtIngresos.TabIndex = 13;
            this.txtIngresos.TablaOVistaBusqueda = "";
            this.txtIngresos.Text = "0.00";
            this.txtIngresos.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtIngresos.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtIngresos.ValorPorDefecto = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ingresos:";
            // 
            // FormContaConsultaCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Fecha Desc, Unico Desc";
            this.ClientSize = new System.Drawing.Size(921, 540);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.EsAgregar = false;
            this.EsModificar = false;
            this.Name = "FormContaConsultaCierre";
            this.NombreCampoID = "Unico";
            this.TablaOVista = "TCONTA_CONTROL_CIERRE";
            this.Text = "CONTABILIDAD GENERAL, CONSULTA CIERRES REALIZADO";
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
            this.grbTotales.ResumeLayout(false);
            this.grbTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbTotales;
        private WinControl_ELR_NET.ELRTextBox txtCapital;
        private System.Windows.Forms.Label label10;
        private WinControl_ELR_NET.ELRTextBox txtPasivos;
        private System.Windows.Forms.Label label11;
        private WinControl_ELR_NET.ELRTextBox txtGastos;
        private WinControl_ELR_NET.ELRTextBox txtCostos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private WinControl_ELR_NET.ELRTextBox txtActivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicionado_Por;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Adicionado;
        private System.Windows.Forms.Label lblTotal;
        private WinControl_ELR_NET.ELRTextBox txtIngresos;
        private System.Windows.Forms.Label label9;
    }
}