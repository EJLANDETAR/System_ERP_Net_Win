namespace WinControl_ELR_NET
{
    partial class ELRFormDesglosePago
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblACredito = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAPagar = new WinControl_ELR_NET.ELRTextBox();
            this.txtADevolver = new WinControl_ELR_NET.ELRTextBox();
            this.txtEnTarjeta = new WinControl_ELR_NET.ELRTextBox();
            this.txtEnCheques = new WinControl_ELR_NET.ELRTextBox();
            this.txtEnEfectivo = new WinControl_ELR_NET.ELRTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 70);
            this.panel1.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(177, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 66);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(343, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(166, 66);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "En Efectivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "En Cheques";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "En Tarjeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "A Devolver";
            // 
            // lblACredito
            // 
            this.lblACredito.BackColor = System.Drawing.Color.Red;
            this.lblACredito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblACredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACredito.ForeColor = System.Drawing.Color.Lime;
            this.lblACredito.Location = new System.Drawing.Point(0, 377);
            this.lblACredito.Name = "lblACredito";
            this.lblACredito.Size = new System.Drawing.Size(513, 75);
            this.lblACredito.TabIndex = 11;
            this.lblACredito.Text = "A Deber: 100,000,000.00";
            this.lblACredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.Black;
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbTotal.Location = new System.Drawing.Point(0, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(513, 66);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "0.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "A Pagar";
            // 
            // txtAPagar
            // 
            this.txtAPagar.AMostrar = null;
            this.txtAPagar.autoSenTab = true;
            this.txtAPagar.AValidar = null;
            this.txtAPagar.BackColor = System.Drawing.Color.White;
            this.txtAPagar.CampoBusquedaID = "";
            this.txtAPagar.CampoData = "";
            this.txtAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAPagar.ColumnasBusqGeneral = null;
            this.txtAPagar.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtAPagar.Decimales = 2;
            this.txtAPagar.DSData = null;
            this.txtAPagar.EsAutoGenerado = false;
            this.txtAPagar.EsBusqueda = false;
            this.txtAPagar.EsBusquedaAutoIncremental = false;
            this.txtAPagar.EsEditable = true;
            this.txtAPagar.FiltroBusqueda = "";
            this.txtAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPagar.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtAPagar.Location = new System.Drawing.Point(206, 85);
            this.txtAPagar.Name = "txtAPagar";
            this.txtAPagar.NombreTabla = "";
            this.txtAPagar.SepDecimal = '\0';
            this.txtAPagar.Size = new System.Drawing.Size(241, 38);
            this.txtAPagar.TabIndex = 2;
            this.txtAPagar.TablaOVistaBusqueda = "";
            this.txtAPagar.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtAPagar.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtAPagar.ValorPorDefecto = "";
            this.txtAPagar.Leave += new System.EventHandler(this.txtEnCheques_Leave);
            // 
            // txtADevolver
            // 
            this.txtADevolver.AMostrar = null;
            this.txtADevolver.autoSenTab = true;
            this.txtADevolver.AValidar = null;
            this.txtADevolver.BackColor = System.Drawing.Color.White;
            this.txtADevolver.CampoBusquedaID = "";
            this.txtADevolver.CampoData = "";
            this.txtADevolver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtADevolver.ColumnasBusqGeneral = null;
            this.txtADevolver.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtADevolver.Decimales = 2;
            this.txtADevolver.DSData = null;
            this.txtADevolver.EsAutoGenerado = false;
            this.txtADevolver.EsBusqueda = false;
            this.txtADevolver.EsBusquedaAutoIncremental = false;
            this.txtADevolver.EsEditable = true;
            this.txtADevolver.FiltroBusqueda = "";
            this.txtADevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADevolver.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtADevolver.Location = new System.Drawing.Point(207, 299);
            this.txtADevolver.Name = "txtADevolver";
            this.txtADevolver.NombreTabla = "";
            this.txtADevolver.SepDecimal = '\0';
            this.txtADevolver.Size = new System.Drawing.Size(243, 38);
            this.txtADevolver.TabIndex = 10;
            this.txtADevolver.TablaOVistaBusqueda = "";
            this.txtADevolver.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtADevolver.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtADevolver.ValorPorDefecto = "";
            // 
            // txtEnTarjeta
            // 
            this.txtEnTarjeta.AMostrar = null;
            this.txtEnTarjeta.autoSenTab = true;
            this.txtEnTarjeta.AValidar = null;
            this.txtEnTarjeta.BackColor = System.Drawing.Color.White;
            this.txtEnTarjeta.CampoBusquedaID = "";
            this.txtEnTarjeta.CampoData = "";
            this.txtEnTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnTarjeta.ColumnasBusqGeneral = null;
            this.txtEnTarjeta.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEnTarjeta.Decimales = 2;
            this.txtEnTarjeta.DSData = null;
            this.txtEnTarjeta.EsAutoGenerado = false;
            this.txtEnTarjeta.EsBusqueda = false;
            this.txtEnTarjeta.EsBusquedaAutoIncremental = false;
            this.txtEnTarjeta.EsEditable = true;
            this.txtEnTarjeta.FiltroBusqueda = "";
            this.txtEnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnTarjeta.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtEnTarjeta.Location = new System.Drawing.Point(206, 244);
            this.txtEnTarjeta.Name = "txtEnTarjeta";
            this.txtEnTarjeta.NombreTabla = "";
            this.txtEnTarjeta.SepDecimal = '\0';
            this.txtEnTarjeta.Size = new System.Drawing.Size(244, 38);
            this.txtEnTarjeta.TabIndex = 8;
            this.txtEnTarjeta.TablaOVistaBusqueda = "";
            this.txtEnTarjeta.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEnTarjeta.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEnTarjeta.ValorPorDefecto = "";
            this.txtEnTarjeta.Leave += new System.EventHandler(this.txtEnCheques_Leave);
            // 
            // txtEnCheques
            // 
            this.txtEnCheques.AMostrar = null;
            this.txtEnCheques.autoSenTab = true;
            this.txtEnCheques.AValidar = null;
            this.txtEnCheques.BackColor = System.Drawing.Color.White;
            this.txtEnCheques.CampoBusquedaID = "";
            this.txtEnCheques.CampoData = "";
            this.txtEnCheques.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnCheques.ColumnasBusqGeneral = null;
            this.txtEnCheques.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEnCheques.Decimales = 2;
            this.txtEnCheques.DSData = null;
            this.txtEnCheques.EsAutoGenerado = false;
            this.txtEnCheques.EsBusqueda = false;
            this.txtEnCheques.EsBusquedaAutoIncremental = false;
            this.txtEnCheques.EsEditable = true;
            this.txtEnCheques.FiltroBusqueda = "";
            this.txtEnCheques.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnCheques.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtEnCheques.Location = new System.Drawing.Point(206, 190);
            this.txtEnCheques.Name = "txtEnCheques";
            this.txtEnCheques.NombreTabla = "";
            this.txtEnCheques.SepDecimal = '\0';
            this.txtEnCheques.Size = new System.Drawing.Size(242, 38);
            this.txtEnCheques.TabIndex = 6;
            this.txtEnCheques.TablaOVistaBusqueda = "";
            this.txtEnCheques.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEnCheques.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEnCheques.ValorPorDefecto = "";
            this.txtEnCheques.Leave += new System.EventHandler(this.txtEnCheques_Leave);
            // 
            // txtEnEfectivo
            // 
            this.txtEnEfectivo.AMostrar = null;
            this.txtEnEfectivo.autoSenTab = true;
            this.txtEnEfectivo.AValidar = null;
            this.txtEnEfectivo.BackColor = System.Drawing.Color.White;
            this.txtEnEfectivo.CampoBusquedaID = "";
            this.txtEnEfectivo.CampoData = "";
            this.txtEnEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnEfectivo.ColumnasBusqGeneral = null;
            this.txtEnEfectivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEnEfectivo.Decimales = 2;
            this.txtEnEfectivo.DSData = null;
            this.txtEnEfectivo.EsAutoGenerado = false;
            this.txtEnEfectivo.EsBusqueda = false;
            this.txtEnEfectivo.EsBusquedaAutoIncremental = false;
            this.txtEnEfectivo.EsEditable = true;
            this.txtEnEfectivo.FiltroBusqueda = "";
            this.txtEnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnEfectivo.Formato = WinControl_ELR_NET.tbFormato.DecimalPositivo;
            this.txtEnEfectivo.Location = new System.Drawing.Point(206, 136);
            this.txtEnEfectivo.Name = "txtEnEfectivo";
            this.txtEnEfectivo.NombreTabla = "";
            this.txtEnEfectivo.SepDecimal = '\0';
            this.txtEnEfectivo.Size = new System.Drawing.Size(241, 38);
            this.txtEnEfectivo.TabIndex = 4;
            this.txtEnEfectivo.TablaOVistaBusqueda = "";
            this.txtEnEfectivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEnEfectivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEnEfectivo.ValorPorDefecto = "";
            this.txtEnEfectivo.Leave += new System.EventHandler(this.txtEnCheques_Leave);
            // 
            // ELRFormDesglosePago
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(513, 522);
            this.Controls.Add(this.txtAPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblACredito);
            this.Controls.Add(this.txtADevolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txtEnTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnCheques);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnEfectivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ELRFormDesglosePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desglose de Pago";
            this.Activated += new System.EventHandler(this.ELRFormDesglosePago_Activated);
            this.Load += new System.EventHandler(this.ELRFormDesglosePago_Load);
            this.Shown += new System.EventHandler(this.ELRFormDesglosePago_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public ELRTextBox txtEnEfectivo;
        public ELRTextBox txtEnCheques;
        public ELRTextBox txtEnTarjeta;
        public ELRTextBox txtADevolver;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblACredito;
        public System.Windows.Forms.Label lbTotal;
        public ELRTextBox txtAPagar;
        private System.Windows.Forms.Label label5;
    }
}