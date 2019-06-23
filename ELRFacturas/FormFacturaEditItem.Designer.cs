namespace ELRFacturas
{
    partial class FormFacturaEditItem
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMonto = new WinControl_ELR_NET.ELRLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new WinControl_ELR_NET.ELRTextBox();
            this.txtCantidad = new WinControl_ELR_NET.ELRTextBox();
            this.txtPrecioSinItbis = new WinControl_ELR_NET.ELRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubTotal = new WinControl_ELR_NET.ELRLabel();
            this.lblItbis = new WinControl_ELR_NET.ELRLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 47);
            this.panel1.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrabar.Location = new System.Drawing.Point(421, 0);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(110, 43);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(531, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 43);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 126);
            this.panel2.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(0, 0);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(641, 122);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio final:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.lblItbis);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Totales]";
            // 
            // lblMonto
            // 
            this.lblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonto.CampoData = "";
            this.lblMonto.DSData = null;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(398, 120);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.NombreTabla = "";
            this.lblMonto.Size = new System.Drawing.Size(231, 40);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "0.00";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonto.ValorPorDefecto = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AMostrar = null;
            this.txtPrecio.AValidar = null;
            this.txtPrecio.CampoBusquedaID = "";
            this.txtPrecio.CampoData = "";
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.ColumnasBusqGeneral = null;
            this.txtPrecio.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPrecio.Decimales = 2;
            this.txtPrecio.DSData = null;
            this.txtPrecio.EsAutoGenerado = false;
            this.txtPrecio.EsBusqueda = false;
            this.txtPrecio.EsBusquedaAutoIncremental = false;
            this.txtPrecio.EsEditable = true;
            this.txtPrecio.FiltroBusqueda = "";
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPrecio.Location = new System.Drawing.Point(196, 253);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.NombreTabla = "";
            this.txtPrecio.SepDecimal = '\0';
            this.txtPrecio.Size = new System.Drawing.Size(291, 39);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TablaOVistaBusqueda = "";
            this.txtPrecio.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPrecio.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPrecio.ValorPorDefecto = "";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AMostrar = null;
            this.txtCantidad.AValidar = null;
            this.txtCantidad.CampoBusquedaID = "";
            this.txtCantidad.CampoData = "";
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.ColumnasBusqGeneral = null;
            this.txtCantidad.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCantidad.Decimales = 2;
            this.txtCantidad.DSData = null;
            this.txtCantidad.EsAutoGenerado = false;
            this.txtCantidad.EsBusqueda = false;
            this.txtCantidad.EsBusquedaAutoIncremental = false;
            this.txtCantidad.EsEditable = true;
            this.txtCantidad.FiltroBusqueda = "";
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtCantidad.Location = new System.Drawing.Point(196, 144);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.NombreTabla = "";
            this.txtCantidad.SepDecimal = '\0';
            this.txtCantidad.Size = new System.Drawing.Size(291, 39);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TablaOVistaBusqueda = "";
            this.txtCantidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCantidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCantidad.ValorPorDefecto = "";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtPrecioSinItbis
            // 
            this.txtPrecioSinItbis.AMostrar = null;
            this.txtPrecioSinItbis.AValidar = null;
            this.txtPrecioSinItbis.CampoBusquedaID = "";
            this.txtPrecioSinItbis.CampoData = "";
            this.txtPrecioSinItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioSinItbis.ColumnasBusqGeneral = null;
            this.txtPrecioSinItbis.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtPrecioSinItbis.Decimales = 2;
            this.txtPrecioSinItbis.DSData = null;
            this.txtPrecioSinItbis.EsAutoGenerado = false;
            this.txtPrecioSinItbis.EsBusqueda = false;
            this.txtPrecioSinItbis.EsBusquedaAutoIncremental = false;
            this.txtPrecioSinItbis.EsEditable = true;
            this.txtPrecioSinItbis.FiltroBusqueda = "";
            this.txtPrecioSinItbis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioSinItbis.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtPrecioSinItbis.Location = new System.Drawing.Point(196, 198);
            this.txtPrecioSinItbis.Name = "txtPrecioSinItbis";
            this.txtPrecioSinItbis.NombreTabla = "";
            this.txtPrecioSinItbis.SepDecimal = '\0';
            this.txtPrecioSinItbis.Size = new System.Drawing.Size(291, 39);
            this.txtPrecioSinItbis.TabIndex = 3;
            this.txtPrecioSinItbis.TablaOVistaBusqueda = "";
            this.txtPrecioSinItbis.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtPrecioSinItbis.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtPrecioSinItbis.ValorPorDefecto = "";
            this.txtPrecioSinItbis.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtPrecioSinItbis.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio sin Itbis:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(329, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 29);
            this.label17.TabIndex = 2;
            this.label17.Text = "Itbis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sub Total:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.CampoData = "";
            this.lblSubTotal.DSData = null;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(398, 40);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.NombreTabla = "";
            this.lblSubTotal.Size = new System.Drawing.Size(231, 32);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubTotal.ValorPorDefecto = "";
            // 
            // lblItbis
            // 
            this.lblItbis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItbis.CampoData = "";
            this.lblItbis.DSData = null;
            this.lblItbis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItbis.Location = new System.Drawing.Point(398, 79);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.NombreTabla = "";
            this.lblItbis.Size = new System.Drawing.Size(231, 32);
            this.lblItbis.TabIndex = 3;
            this.lblItbis.Text = "0.00";
            this.lblItbis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblItbis.ValorPorDefecto = "";
            // 
            // FormFacturaEditItem
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(645, 561);
            this.Controls.Add(this.txtPrecioSinItbis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacturaEditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR ITEM DE FACTURA";
            this.Load += new System.EventHandler(this.FormFacturaEditItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRLabel lblMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private WinControl_ELR_NET.ELRTextBox txtPrecioSinItbis;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRLabel lblItbis;
        private WinControl_ELR_NET.ELRLabel lblSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
    }
}