namespace ELRContaGeneral
{
    partial class FormContaCuentasR
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
            WinControl_ELR_NET.Valida valida1 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida2 = new WinControl_ELR_NET.Valida();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuentaContable = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEsParaPresupuesto = new WinControl_ELR_NET.ELRCheckBox();
            this.chkPermiteMovimiento = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsControl = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 344);
            this.pnBotones.Size = new System.Drawing.Size(605, 43);
            this.pnBotones.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(365, 0);
            this.btnGrabar.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(506, 0);
            this.btnCancelar.TabIndex = 3;
            // 
            // btnAnterior
            // 
            this.btnAnterior.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(270, 0);
            this.btnSiguientePage.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(175, 39);
            this.lblNombreUsuario.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AMostrar = null;
            this.txtDescripcion.AValidar = null;
            this.txtDescripcion.CampoBusquedaID = "";
            this.txtDescripcion.CampoData = "Descripcion";
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColumnasBusqGeneral = null;
            this.txtDescripcion.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescripcion.Decimales = 0;
            this.txtDescripcion.DSData = this.DSDatos;
            this.txtDescripcion.EsAutoGenerado = false;
            this.txtDescripcion.EsBusqueda = false;
            this.txtDescripcion.EsBusquedaAutoIncremental = false;
            this.txtDescripcion.EsEditable = true;
            this.txtDescripcion.FiltroBusqueda = "";
            this.txtDescripcion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescripcion.Location = new System.Drawing.Point(166, 62);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.SepDecimal = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(408, 84);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TablaOVistaBusqueda = "";
            this.txtDescripcion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescripcion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // cboOficina
            // 
            this.cboOficina.AValidar = null;
            this.cboOficina.CampoData = "Oficina_Id";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DisplayMember = "Nombre";
            this.cboOficina.DSData = this.DSDatos;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(166, 152);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(408, 29);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 5;
            this.cboOficina.TablaOVistaConsulta = "TEMPRESAS_OFICINAS";
            this.cboOficina.UsaDataGlobal = false;
            this.cboOficina.ValorPorDefecto = "0";
            this.cboOficina.ValueMember = "Oficina_Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta Contable:";
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.AMostrar = null;
            this.txtCuentaContable.AValidar = null;
            this.txtCuentaContable.BackColor = System.Drawing.Color.White;
            this.txtCuentaContable.CampoBusquedaID = "";
            this.txtCuentaContable.CampoData = "Cuenta_Contable";
            this.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContable.ColumnasBusqGeneral = null;
            this.txtCuentaContable.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCuentaContable.Decimales = 0;
            this.txtCuentaContable.DSData = this.DSDatos;
            this.txtCuentaContable.EsAutoGenerado = false;
            this.txtCuentaContable.EsBusqueda = false;
            this.txtCuentaContable.EsBusquedaAutoIncremental = false;
            this.txtCuentaContable.EsEditable = true;
            this.txtCuentaContable.FiltroBusqueda = "";
            this.txtCuentaContable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaContable.Formato = WinControl_ELR_NET.tbFormato.NoSpace;
            this.txtCuentaContable.Location = new System.Drawing.Point(166, 27);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.NombreTabla = "";
            this.txtCuentaContable.ReadOnly = true;
            this.txtCuentaContable.SepDecimal = '\0';
            this.txtCuentaContable.Size = new System.Drawing.Size(263, 29);
            this.txtCuentaContable.TabIndex = 1;
            this.txtCuentaContable.TablaOVistaBusqueda = "";
            this.txtCuentaContable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuentaContable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuentaContable.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oficina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEsParaPresupuesto);
            this.groupBox2.Controls.Add(this.chkPermiteMovimiento);
            this.groupBox2.Controls.Add(this.chkEsControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // chkEsParaPresupuesto
            // 
            this.chkEsParaPresupuesto.AutoSize = true;
            this.chkEsParaPresupuesto.CampoData = "EsPresupuesto";
            this.chkEsParaPresupuesto.DSData = this.DSDatos;
            this.chkEsParaPresupuesto.EsEditable = true;
            this.chkEsParaPresupuesto.EsModificable = true;
            this.chkEsParaPresupuesto.FiltroBusqueda = "";
            this.chkEsParaPresupuesto.Location = new System.Drawing.Point(32, 88);
            this.chkEsParaPresupuesto.Name = "chkEsParaPresupuesto";
            this.chkEsParaPresupuesto.NombreTabla = "";
            this.chkEsParaPresupuesto.Size = new System.Drawing.Size(181, 25);
            this.chkEsParaPresupuesto.TabIndex = 2;
            this.chkEsParaPresupuesto.Text = "Es Para Presupuesto";
            this.chkEsParaPresupuesto.UseVisualStyleBackColor = true;
            this.chkEsParaPresupuesto.ValorPorDefecto = false;
            // 
            // chkPermiteMovimiento
            // 
            this.chkPermiteMovimiento.AutoSize = true;
            this.chkPermiteMovimiento.CampoData = "EsMovimiento";
            this.chkPermiteMovimiento.DSData = this.DSDatos;
            this.chkPermiteMovimiento.EsEditable = true;
            this.chkPermiteMovimiento.EsModificable = true;
            this.chkPermiteMovimiento.FiltroBusqueda = "";
            this.chkPermiteMovimiento.Location = new System.Drawing.Point(229, 39);
            this.chkPermiteMovimiento.Name = "chkPermiteMovimiento";
            this.chkPermiteMovimiento.NombreTabla = "";
            this.chkPermiteMovimiento.Size = new System.Drawing.Size(187, 25);
            this.chkPermiteMovimiento.TabIndex = 1;
            this.chkPermiteMovimiento.Text = "Permite Movimiento";
            this.chkPermiteMovimiento.UseVisualStyleBackColor = true;
            this.chkPermiteMovimiento.ValorPorDefecto = true;
            // 
            // chkEsControl
            // 
            this.chkEsControl.AutoSize = true;
            this.chkEsControl.CampoData = "EsControl";
            this.chkEsControl.DSData = this.DSDatos;
            this.chkEsControl.EsEditable = true;
            this.chkEsControl.EsModificable = true;
            this.chkEsControl.FiltroBusqueda = "";
            this.chkEsControl.Location = new System.Drawing.Point(32, 39);
            this.chkEsControl.Name = "chkEsControl";
            this.chkEsControl.NombreTabla = "";
            this.chkEsControl.Size = new System.Drawing.Size(164, 25);
            this.chkEsControl.TabIndex = 0;
            this.chkEsControl.Text = "Es Cuenta Control";
            this.chkEsControl.UseVisualStyleBackColor = true;
            this.chkEsControl.ValorPorDefecto = false;
            // 
            // FormContaCuentasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtDescripcion;
            valida1.Mensaje = "Debe Indicar Descripcion";
            valida1.NombreCampo = "Descripcion";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida1.Valor1 = "4";
            valida1.Valor2 = null;
            valida2.comtrol = this.cboOficina;
            valida2.Mensaje = "Debe Indicar Oficina";
            valida2.NombreCampo = "Oficina_Id";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida2.Valor1 = null;
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(605, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboOficina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuentaContable);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.Name = "FormContaCuentasR";
            this.NombreCampoID = "Unico";
            this.SPGraba = "SP_CONTA_REGISTRAR_CUENTA";
            this.TablaEncabezado = "TTEMPORAL_CONTA_CATALOGO";
            this.Text = "CONTABILIDAD GENERAL, REGISTRO DE CUENTA CONTABLE";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCuentaContable, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboOficina, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCuentaContable;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox cboOficina;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRCheckBox chkEsParaPresupuesto;
        private WinControl_ELR_NET.ELRCheckBox chkPermiteMovimiento;
        private WinControl_ELR_NET.ELRCheckBox chkEsControl;
    }
}