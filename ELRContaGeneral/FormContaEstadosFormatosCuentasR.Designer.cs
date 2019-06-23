namespace ELRContaGeneral
{
    partial class FormContaEstadosFormatosCuentasR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuentaContable = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescripcion = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elrCombobox1 = new WinControl_ELR_NET.ELRCombobox();
            this.chkEsSuma = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsAbs = new WinControl_ELR_NET.ELRCheckBox();
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 290);
            this.pnBotones.Size = new System.Drawing.Size(542, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(302, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(207, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(112, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta No.:";
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
            this.txtCuentaContable.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCuentaContable.Location = new System.Drawing.Point(125, 35);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.NombreTabla = "";
            this.txtCuentaContable.ReadOnly = true;
            this.txtCuentaContable.SepDecimal = '\0';
            this.txtCuentaContable.Size = new System.Drawing.Size(186, 29);
            this.txtCuentaContable.TabIndex = 1;
            this.txtCuentaContable.TablaOVistaBusqueda = "";
            this.txtCuentaContable.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCuentaContable.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCuentaContable.ValorPorDefecto = "";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AMostrar = null;
            this.txtDescripcion.AValidar = null;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
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
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDescripcion.Location = new System.Drawing.Point(125, 70);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NombreTabla = "";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.SepDecimal = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(386, 69);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.TablaOVistaBusqueda = "";
            this.txtDescripcion.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescripcion.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescripcion.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anexo:";
            // 
            // elrCombobox1
            // 
            this.elrCombobox1.AValidar = null;
            this.elrCombobox1.CampoData = "AnexoNo";
            this.elrCombobox1.CampoJoinCombobox2 = "";
            this.elrCombobox1.ComboboxAFiltrar = null;
            this.elrCombobox1.DisplayMember = "Concepto";
            this.elrCombobox1.DSData = this.DSDatos;
            this.elrCombobox1.EsEditable = true;
            this.elrCombobox1.FiltroBusqueda = "";
            this.elrCombobox1.FormattingEnabled = true;
            this.elrCombobox1.Location = new System.Drawing.Point(125, 145);
            this.elrCombobox1.Name = "elrCombobox1";
            this.elrCombobox1.NombreTabla = "";
            this.elrCombobox1.Size = new System.Drawing.Size(386, 29);
            this.elrCombobox1.SSQL = "";
            this.elrCombobox1.TabIndex = 6;
            this.elrCombobox1.TablaOVistaConsulta = "VCONTA_ESTADOS_ANEXOS";
            this.elrCombobox1.UsaDataGlobal = false;
            this.elrCombobox1.ValorPorDefecto = "0";
            this.elrCombobox1.ValueMember = "Anexo_Id";
            // 
            // chkEsSuma
            // 
            this.chkEsSuma.AutoSize = true;
            this.chkEsSuma.CampoData = "EsSum";
            this.chkEsSuma.DSData = this.DSDatos;
            this.chkEsSuma.EsEditable = true;
            this.chkEsSuma.EsModificable = true;
            this.chkEsSuma.FiltroBusqueda = "";
            this.chkEsSuma.Location = new System.Drawing.Point(127, 189);
            this.chkEsSuma.Name = "chkEsSuma";
            this.chkEsSuma.NombreTabla = "";
            this.chkEsSuma.Size = new System.Drawing.Size(88, 25);
            this.chkEsSuma.TabIndex = 7;
            this.chkEsSuma.Text = "Es Suma";
            this.chkEsSuma.UseVisualStyleBackColor = true;
            this.chkEsSuma.ValorPorDefecto = true;
            // 
            // chkEsAbs
            // 
            this.chkEsAbs.AutoSize = true;
            this.chkEsAbs.CampoData = "EsAbs";
            this.chkEsAbs.DSData = this.DSDatos;
            this.chkEsAbs.EsEditable = true;
            this.chkEsAbs.EsModificable = true;
            this.chkEsAbs.FiltroBusqueda = "";
            this.chkEsAbs.Location = new System.Drawing.Point(252, 189);
            this.chkEsAbs.Name = "chkEsAbs";
            this.chkEsAbs.NombreTabla = "";
            this.chkEsAbs.Size = new System.Drawing.Size(186, 25);
            this.chkEsAbs.TabIndex = 8;
            this.chkEsAbs.Text = "Es Valor Absoluto(Abs)";
            this.chkEsAbs.UseVisualStyleBackColor = true;
            this.chkEsAbs.ValorPorDefecto = false;
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.Image = global::ELRContaGeneral.Properties.Resources._1378160672_search;
            this.btnBuscarCuenta.Location = new System.Drawing.Point(317, 33);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(45, 31);
            this.btnBuscarCuenta.TabIndex = 2;
            this.btnBuscarCuenta.UseVisualStyleBackColor = true;
            this.btnBuscarCuenta.Click += new System.EventHandler(this.btnBuscarCuenta_Click);
            // 
            // FormContaEstadosFormatosCuentasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.btnBuscarCuenta);
            this.Controls.Add(this.chkEsAbs);
            this.Controls.Add(this.chkEsSuma);
            this.Controls.Add(this.elrCombobox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCuentaContable);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormContaEstadosFormatosCuentasR";
            this.NombreCampoID = "Unico";
            this.TablaEncabezado = "TCONTA_ESTADOS_CUENTAS";
            this.Text = "EDITAR CUENTA CUONTABLE EN FORMULA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCuentaContable, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.elrCombobox1, 0);
            this.Controls.SetChildIndex(this.chkEsSuma, 0);
            this.Controls.SetChildIndex(this.chkEsAbs, 0);
            this.Controls.SetChildIndex(this.btnBuscarCuenta, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtCuentaContable;
        private WinControl_ELR_NET.ELRTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRCombobox elrCombobox1;
        private WinControl_ELR_NET.ELRCheckBox chkEsSuma;
        private WinControl_ELR_NET.ELRCheckBox chkEsAbs;
        private System.Windows.Forms.Button btnBuscarCuenta;
    }
}