namespace ELRFacturas
{
    partial class FormAplicarDescuento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorcDescto = new WinControl_ELR_NET.ELRTextBox();
            this.txtDescuento = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoAPagar = new WinControl_ELR_NET.ELRTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(285, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 44);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Location = new System.Drawing.Point(172, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 44);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(0, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(402, 56);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "0.00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMontoAPagar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPorcDescto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "% Descuento:";
            // 
            // txtPorcDescto
            // 
            this.txtPorcDescto.AMostrar = null;
            this.txtPorcDescto.AValidar = null;
            this.txtPorcDescto.CampoBusquedaID = "";
            this.txtPorcDescto.CampoData = "";
            this.txtPorcDescto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcDescto.ColumnasBusqGeneral = null;
            this.txtPorcDescto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPorcDescto.Decimales = 2;
            this.txtPorcDescto.DSData = null;
            this.txtPorcDescto.EsAutoGenerado = false;
            this.txtPorcDescto.EsBusqueda = false;
            this.txtPorcDescto.EsBusquedaAutoIncremental = false;
            this.txtPorcDescto.EsEditable = true;
            this.txtPorcDescto.FiltroBusqueda = "";
            this.txtPorcDescto.Formato = WinControl_ELR_NET.tbFormato.Decimal;
            this.txtPorcDescto.Location = new System.Drawing.Point(209, 42);
            this.txtPorcDescto.MaxLength = 5;
            this.txtPorcDescto.Name = "txtPorcDescto";
            this.txtPorcDescto.NombreTabla = "";
            this.txtPorcDescto.SepDecimal = '\0';
            this.txtPorcDescto.Size = new System.Drawing.Size(172, 31);
            this.txtPorcDescto.TabIndex = 1;
            this.txtPorcDescto.TablaOVistaBusqueda = "";
            this.txtPorcDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPorcDescto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPorcDescto.ValorPorDefecto = "";
            this.txtPorcDescto.Leave += new System.EventHandler(this.txtMontoAPagar_Leave);
            // 
            // txtDescuento
            // 
            this.txtDescuento.AMostrar = null;
            this.txtDescuento.AValidar = null;
            this.txtDescuento.CampoBusquedaID = "";
            this.txtDescuento.CampoData = "";
            this.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescuento.ColumnasBusqGeneral = null;
            this.txtDescuento.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDescuento.Decimales = 2;
            this.txtDescuento.DSData = null;
            this.txtDescuento.EsAutoGenerado = false;
            this.txtDescuento.EsBusqueda = false;
            this.txtDescuento.EsBusquedaAutoIncremental = false;
            this.txtDescuento.EsEditable = true;
            this.txtDescuento.FiltroBusqueda = "";
            this.txtDescuento.Formato = WinControl_ELR_NET.tbFormato.Decimal;
            this.txtDescuento.Location = new System.Drawing.Point(209, 87);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.NombreTabla = "";
            this.txtDescuento.SepDecimal = '\0';
            this.txtDescuento.Size = new System.Drawing.Size(172, 31);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.TablaOVistaBusqueda = "";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDescuento.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDescuento.ValorPorDefecto = "";
            this.txtDescuento.Leave += new System.EventHandler(this.txtMontoAPagar_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descuento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto A Pagar:";
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.AMostrar = null;
            this.txtMontoAPagar.AValidar = null;
            this.txtMontoAPagar.CampoBusquedaID = "";
            this.txtMontoAPagar.CampoData = "";
            this.txtMontoAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoAPagar.ColumnasBusqGeneral = null;
            this.txtMontoAPagar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMontoAPagar.Decimales = 2;
            this.txtMontoAPagar.DSData = null;
            this.txtMontoAPagar.EsAutoGenerado = false;
            this.txtMontoAPagar.EsBusqueda = false;
            this.txtMontoAPagar.EsBusquedaAutoIncremental = false;
            this.txtMontoAPagar.EsEditable = true;
            this.txtMontoAPagar.FiltroBusqueda = "";
            this.txtMontoAPagar.Formato = WinControl_ELR_NET.tbFormato.Decimal;
            this.txtMontoAPagar.Location = new System.Drawing.Point(209, 130);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.NombreTabla = "";
            this.txtMontoAPagar.SepDecimal = '\0';
            this.txtMontoAPagar.Size = new System.Drawing.Size(172, 31);
            this.txtMontoAPagar.TabIndex = 5;
            this.txtMontoAPagar.TablaOVistaBusqueda = "";
            this.txtMontoAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoAPagar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMontoAPagar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMontoAPagar.ValorPorDefecto = "";
            this.txtMontoAPagar.Leave += new System.EventHandler(this.txtMontoAPagar_Leave);
            // 
            // FormAplicarDescuento
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(402, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAplicarDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLICAR DESCUENTO";
            this.Activated += new System.EventHandler(this.FormAplicarDescuento_Activated);
            this.Load += new System.EventHandler(this.FormAplicarDescuento_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtPorcDescto;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtMontoAPagar;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtDescuento;
        private System.Windows.Forms.Label label2;
    }
}