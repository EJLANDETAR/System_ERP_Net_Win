﻿namespace ELRNomina
{
    partial class FormVacacionesR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new WinControl_ELR_NET.ELRTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaRetornar = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreCompleto = new WinControl_ELR_NET.ELRLabel();
            this.lblCodigo = new WinControl_ELR_NET.ELRLabel();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 360);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo o Concepto";
            // 
            // txtMotivo
            // 
            this.txtMotivo.AMostrar = null;
            this.txtMotivo.AValidar = null;
            this.txtMotivo.CampoBusquedaID = "";
            this.txtMotivo.CampoData = "";
            this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivo.ColumnasBusqGeneral = null;
            this.txtMotivo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtMotivo.Decimales = 0;
            this.txtMotivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMotivo.DSData = null;
            this.txtMotivo.EsAutoGenerado = false;
            this.txtMotivo.EsBusqueda = false;
            this.txtMotivo.EsBusquedaAutoIncremental = false;
            this.txtMotivo.EsEditable = true;
            this.txtMotivo.FiltroBusqueda = "";
            this.txtMotivo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtMotivo.Location = new System.Drawing.Point(3, 25);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.NombreTabla = "";
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMotivo.SepDecimal = '\0';
            this.txtMotivo.Size = new System.Drawing.Size(625, 205);
            this.txtMotivo.TabIndex = 0;
            this.txtMotivo.TablaOVistaBusqueda = "";
            this.txtMotivo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtMotivo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtMotivo.ValorPorDefecto = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpFechaRetornar);
            this.panel2.Controls.Add(this.elrLabel2);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.elrLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 55);
            this.panel2.TabIndex = 5;
            // 
            // dtpFechaRetornar
            // 
            this.dtpFechaRetornar.AValidar = null;
            this.dtpFechaRetornar.CampoData = "";
            this.dtpFechaRetornar.DSData = null;
            this.dtpFechaRetornar.EsEditable = true;
            this.dtpFechaRetornar.FiltroBusqueda = "";
            this.dtpFechaRetornar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetornar.Location = new System.Drawing.Point(454, 13);
            this.dtpFechaRetornar.Name = "dtpFechaRetornar";
            this.dtpFechaRetornar.NombreTabla = "";
            this.dtpFechaRetornar.Size = new System.Drawing.Size(149, 29);
            this.dtpFechaRetornar.TabIndex = 5;
            this.dtpFechaRetornar.ValorPorDefecto = new System.DateTime(2016, 12, 26, 0, 0, 0, 0);
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(308, 13);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(140, 21);
            this.elrLabel2.TabIndex = 4;
            this.elrLabel2.Text = "Fecha ARetornar:";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "";
            this.dtpFecha.DSData = null;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(133, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(149, 29);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2016, 12, 26, 0, 0, 0, 0);
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(18, 13);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(109, 21);
            this.elrLabel1.TabIndex = 2;
            this.elrLabel1.Text = "Fecha Salida:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 72);
            this.panel1.TabIndex = 4;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.CampoData = "";
            this.lblNombreCompleto.DSData = null;
            this.lblNombreCompleto.Location = new System.Drawing.Point(11, 32);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.NombreTabla = "";
            this.lblNombreCompleto.Size = new System.Drawing.Size(145, 21);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre Completo";
            this.lblNombreCompleto.ValorPorDefecto = "";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.CampoData = "";
            this.lblCodigo.DSData = null;
            this.lblCodigo.Location = new System.Drawing.Point(11, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.NombreTabla = "";
            this.lblCodigo.Size = new System.Drawing.Size(337, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: 000000              Cedula: 00000000000";
            this.lblCodigo.ValorPorDefecto = "";
            // 
            // FormVacacionesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormVacacionesR";
            this.TablaEncabezado = "Tabla";
            this.Text = "REGISTRAR VACACIONES";
            this.Load += new System.EventHandler(this.FormVacacionesR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtMotivo;
        private System.Windows.Forms.Panel panel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFechaRetornar;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
        private System.Windows.Forms.Panel panel1;
        private WinControl_ELR_NET.ELRLabel lblNombreCompleto;
        private WinControl_ELR_NET.ELRLabel lblCodigo;
    }
}