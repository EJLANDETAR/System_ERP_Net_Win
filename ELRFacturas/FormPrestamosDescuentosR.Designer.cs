namespace ELRFacturas
{
    partial class FormPrestamosDescuentosR
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
            this.lblConcepto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtOtros = new WinControl_ELR_NET.ELRTextBox();
            this.txtDemora = new WinControl_ELR_NET.ELRTextBox();
            this.txtInteres = new WinControl_ELR_NET.ELRTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConcepto
            // 
            this.lblConcepto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConcepto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConcepto.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.ForeColor = System.Drawing.Color.Blue;
            this.lblConcepto.Location = new System.Drawing.Point(0, 0);
            this.lblConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(501, 45);
            this.lblConcepto.TabIndex = 0;
            this.lblConcepto.Text = "Cuota 1 de 12";
            this.lblConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Demora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Otros:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 53);
            this.panel1.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrabar.Location = new System.Drawing.Point(273, 0);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(112, 49);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Aceptar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(385, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 49);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtOtros
            // 
            this.txtOtros.AMostrar = null;
            this.txtOtros.AValidar = null;
            this.txtOtros.CampoBusquedaID = "";
            this.txtOtros.CampoData = "";
            this.txtOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtros.ColumnasBusqGeneral = null;
            this.txtOtros.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtOtros.Decimales = 0;
            this.txtOtros.DSData = null;
            this.txtOtros.EsAutoGenerado = false;
            this.txtOtros.EsBusqueda = false;
            this.txtOtros.EsBusquedaAutoIncremental = false;
            this.txtOtros.EsEditable = true;
            this.txtOtros.FiltroBusqueda = "";
            this.txtOtros.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtOtros.Location = new System.Drawing.Point(167, 185);
            this.txtOtros.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.NombreTabla = "";
            this.txtOtros.SepDecimal = '\0';
            this.txtOtros.Size = new System.Drawing.Size(204, 33);
            this.txtOtros.TabIndex = 6;
            this.txtOtros.TablaOVistaBusqueda = "";
            this.txtOtros.Text = "0.00";
            this.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtros.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtOtros.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtOtros.ValorPorDefecto = "";
            // 
            // txtDemora
            // 
            this.txtDemora.AMostrar = null;
            this.txtDemora.AValidar = null;
            this.txtDemora.CampoBusquedaID = "";
            this.txtDemora.CampoData = "";
            this.txtDemora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDemora.ColumnasBusqGeneral = null;
            this.txtDemora.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtDemora.Decimales = 0;
            this.txtDemora.DSData = null;
            this.txtDemora.EsAutoGenerado = false;
            this.txtDemora.EsBusqueda = false;
            this.txtDemora.EsBusquedaAutoIncremental = false;
            this.txtDemora.EsEditable = true;
            this.txtDemora.FiltroBusqueda = "";
            this.txtDemora.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtDemora.Location = new System.Drawing.Point(167, 137);
            this.txtDemora.Margin = new System.Windows.Forms.Padding(4);
            this.txtDemora.Name = "txtDemora";
            this.txtDemora.NombreTabla = "";
            this.txtDemora.SepDecimal = '\0';
            this.txtDemora.Size = new System.Drawing.Size(204, 33);
            this.txtDemora.TabIndex = 4;
            this.txtDemora.TablaOVistaBusqueda = "";
            this.txtDemora.Text = "0.00";
            this.txtDemora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDemora.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtDemora.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtDemora.ValorPorDefecto = "";
            // 
            // txtInteres
            // 
            this.txtInteres.AMostrar = null;
            this.txtInteres.AValidar = null;
            this.txtInteres.CampoBusquedaID = "";
            this.txtInteres.CampoData = "";
            this.txtInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInteres.ColumnasBusqGeneral = null;
            this.txtInteres.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtInteres.Decimales = 0;
            this.txtInteres.DSData = null;
            this.txtInteres.EsAutoGenerado = false;
            this.txtInteres.EsBusqueda = false;
            this.txtInteres.EsBusquedaAutoIncremental = false;
            this.txtInteres.EsEditable = true;
            this.txtInteres.FiltroBusqueda = "";
            this.txtInteres.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtInteres.Location = new System.Drawing.Point(167, 93);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.NombreTabla = "";
            this.txtInteres.SepDecimal = '\0';
            this.txtInteres.Size = new System.Drawing.Size(204, 33);
            this.txtInteres.TabIndex = 2;
            this.txtInteres.TablaOVistaBusqueda = "";
            this.txtInteres.Text = "0.00";
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInteres.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtInteres.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtInteres.ValorPorDefecto = "";
            // 
            // FormPrestamosDescuentosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDemora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConcepto);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrestamosDescuentosR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLICAR DESCUENTO A CUOTA NO.:";
            this.Load += new System.EventHandler(this.FormPrestamosDescuentosR_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox txtInteres;
        private WinControl_ELR_NET.ELRTextBox txtDemora;
        private System.Windows.Forms.Label label3;
        private WinControl_ELR_NET.ELRTextBox txtOtros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
    }
}