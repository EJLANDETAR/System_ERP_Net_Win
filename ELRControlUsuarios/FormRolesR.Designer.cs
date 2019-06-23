namespace ELRControlUsuarios
{
    partial class FormRolesR
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
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRolId = new WinControl_ELR_NET.ELRTextBox();
            this.txtComentario = new WinControl_ELR_NET.ELRTextBox();
            this.elrCheckBox1 = new WinControl_ELR_NET.ELRCheckBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 275);
            this.pnBotones.Size = new System.Drawing.Size(613, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(419, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(514, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(324, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(132, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(457, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comentario";
            // 
            // txtRolId
            // 
            this.txtRolId.AMostrar = null;
            this.txtRolId.AValidar = null;
            this.txtRolId.CampoBusquedaID = "";
            this.txtRolId.CampoData = "Rol_Id";
            this.txtRolId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRolId.ColumnasBusqGeneral = null;
            this.txtRolId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtRolId.Decimales = 0;
            this.txtRolId.DSData = this.DSDatos;
            this.txtRolId.EsAutoGenerado = true;
            this.txtRolId.EsBusqueda = false;
            this.txtRolId.EsEditable = true;
            this.txtRolId.FiltroBusqueda = "";
            this.txtRolId.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtRolId.Location = new System.Drawing.Point(132, 22);
            this.txtRolId.Name = "txtRolId";
            this.txtRolId.NombreTabla = "";
            this.txtRolId.SepDecimal = '\0';
            this.txtRolId.Size = new System.Drawing.Size(135, 29);
            this.txtRolId.TabIndex = 4;
            this.txtRolId.TablaOVistaBusqueda = "";
            this.txtRolId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtRolId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtRolId.ValorPorDefecto = "0";
            // 
            // txtComentario
            // 
            this.txtComentario.AMostrar = null;
            this.txtComentario.AValidar = null;
            this.txtComentario.CampoBusquedaID = "";
            this.txtComentario.CampoData = "Comentario";
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.ColumnasBusqGeneral = null;
            this.txtComentario.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtComentario.Decimales = 0;
            this.txtComentario.DSData = this.DSDatos;
            this.txtComentario.EsAutoGenerado = false;
            this.txtComentario.EsBusqueda = false;
            this.txtComentario.EsEditable = true;
            this.txtComentario.FiltroBusqueda = "";
            this.txtComentario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtComentario.Location = new System.Drawing.Point(132, 97);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.NombreTabla = "";
            this.txtComentario.SepDecimal = '\0';
            this.txtComentario.Size = new System.Drawing.Size(457, 124);
            this.txtComentario.TabIndex = 6;
            this.txtComentario.TablaOVistaBusqueda = "";
            this.txtComentario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtComentario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtComentario.ValorPorDefecto = "";
            // 
            // elrCheckBox1
            // 
            this.elrCheckBox1.AutoSize = true;
            this.elrCheckBox1.CampoData = "EsActivo";
            this.elrCheckBox1.DSData = this.DSDatos;
            this.elrCheckBox1.EsEditable = true;
            this.elrCheckBox1.EsModificable = true;
            this.elrCheckBox1.FiltroBusqueda = "";
            this.elrCheckBox1.Location = new System.Drawing.Point(132, 227);
            this.elrCheckBox1.Name = "elrCheckBox1";
            this.elrCheckBox1.NombreTabla = "";
            this.elrCheckBox1.Size = new System.Drawing.Size(91, 25);
            this.elrCheckBox1.TabIndex = 7;
            this.elrCheckBox1.Text = "Es Activo";
            this.elrCheckBox1.UseVisualStyleBackColor = true;
            this.elrCheckBox1.ValorPorDefecto = true;
            // 
            // FormRolesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtNombre;
            valida1.Mensaje = "Debe Digitar El Nombre";
            valida1.NombreCampo = "Nombre";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida1.Valor1 = null;
            valida1.Valor2 = null;
            valida2.comtrol = this.txtNombre;
            valida2.Mensaje = "El Nombre debe Tener un Minimo de 5 Caracteres";
            valida2.NombreCampo = "Nombre";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.LongitudMinima;
            valida2.Valor1 = "5";
            valida2.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2};
            this.ClientSize = new System.Drawing.Size(613, 318);
            this.Controls.Add(this.elrCheckBox1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRolId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormRolesR";
            this.NombreCampoID = "Rol_Id";
            this.TablaEncabezado = "TACCESOS_ROLES";
            this.Text = "REGISTRO DE ROL DEL SISTEMA";
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRolId, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtComentario, 0);
            this.Controls.SetChildIndex(this.elrCheckBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtRolId;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private WinControl_ELR_NET.ELRTextBox txtComentario;
        private WinControl_ELR_NET.ELRCheckBox elrCheckBox1;
    }
}