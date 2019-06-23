namespace ELRCuentasPorPagar
{
    partial class Form1
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreSuplidor = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigoSup = new WinControl_ELR_NET.ELRTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOficina = new WinControl_ELR_NET.ELRCombobox();
            this.btnBuscarSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tipo Gastos:";
            // 
            // txtNombreSuplidor
            // 
            this.txtNombreSuplidor.AMostrar = null;
            this.txtNombreSuplidor.AValidar = null;
            this.txtNombreSuplidor.BackColor = System.Drawing.Color.White;
            this.txtNombreSuplidor.CampoBusquedaID = "";
            this.txtNombreSuplidor.CampoData = "Nombres";
            this.txtNombreSuplidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreSuplidor.ColumnasBusqGeneral = null;
            this.txtNombreSuplidor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreSuplidor.Decimales = 0;
            this.txtNombreSuplidor.DSData = null;
            this.txtNombreSuplidor.EsAutoGenerado = false;
            this.txtNombreSuplidor.EsBusqueda = false;
            this.txtNombreSuplidor.EsEditable = true;
            this.txtNombreSuplidor.FiltroBusqueda = "";
            this.txtNombreSuplidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSuplidor.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreSuplidor.Location = new System.Drawing.Point(307, 180);
            this.txtNombreSuplidor.Name = "txtNombreSuplidor";
            this.txtNombreSuplidor.NombreTabla = "";
            this.txtNombreSuplidor.ReadOnly = true;
            this.txtNombreSuplidor.SepDecimal = '\0';
            this.txtNombreSuplidor.Size = new System.Drawing.Size(558, 29);
            this.txtNombreSuplidor.TabIndex = 36;
            this.txtNombreSuplidor.TablaOVistaBusqueda = "";
            this.txtNombreSuplidor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreSuplidor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreSuplidor.ValorPorDefecto = "";
            // 
            // txtCodigoSup
            // 
            this.txtCodigoSup.AMostrar = null;
            this.txtCodigoSup.AValidar = null;
            this.txtCodigoSup.CampoBusquedaID = "";
            this.txtCodigoSup.CampoData = "Suplidor_Id";
            this.txtCodigoSup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSup.ColumnasBusqGeneral = null;
            this.txtCodigoSup.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigoSup.Decimales = 0;
            this.txtCodigoSup.DSData = null;
            this.txtCodigoSup.EsAutoGenerado = false;
            this.txtCodigoSup.EsBusqueda = false;
            this.txtCodigoSup.EsEditable = true;
            this.txtCodigoSup.FiltroBusqueda = "";
            this.txtCodigoSup.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigoSup.Location = new System.Drawing.Point(141, 180);
            this.txtCodigoSup.Name = "txtCodigoSup";
            this.txtCodigoSup.NombreTabla = "";
            this.txtCodigoSup.SepDecimal = '\0';
            this.txtCodigoSup.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSup.TabIndex = 35;
            this.txtCodigoSup.TablaOVistaBusqueda = "";
            this.txtCodigoSup.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigoSup.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigoSup.ValorPorDefecto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Suplidor:";
            // 
            // cboOficina
            // 
            this.cboOficina.AValidar = null;
            this.cboOficina.CampoData = "Oficina_Id";
            this.cboOficina.CampoJoinCombobox2 = "";
            this.cboOficina.ComboboxAFiltrar = null;
            this.cboOficina.DSData = null;
            this.cboOficina.EsEditable = true;
            this.cboOficina.FiltroBusqueda = "";
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(153, 284);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.NombreTabla = "";
            this.cboOficina.Size = new System.Drawing.Size(712, 21);
            this.cboOficina.SSQL = "";
            this.cboOficina.TabIndex = 33;
            this.cboOficina.TablaOVistaConsulta = "";
            this.cboOficina.UsaDataGlobal = false;
            this.cboOficina.ValorPorDefecto = "0";
            // 
            // btnBuscarSup
            // 
            this.btnBuscarSup.Image = global::ELRCuentasPorPagar.Properties.Resources._1378160672_search;
            this.btnBuscarSup.Location = new System.Drawing.Point(247, 180);
            this.btnBuscarSup.Name = "btnBuscarSup";
            this.btnBuscarSup.Size = new System.Drawing.Size(46, 32);
            this.btnBuscarSup.TabIndex = 37;
            this.btnBuscarSup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 485);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBuscarSup);
            this.Controls.Add(this.txtNombreSuplidor);
            this.Controls.Add(this.txtCodigoSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboOficina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarSup;
        private WinControl_ELR_NET.ELRTextBox txtNombreSuplidor;
        private WinControl_ELR_NET.ELRTextBox txtCodigoSup;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRCombobox cboOficina;
    }
}