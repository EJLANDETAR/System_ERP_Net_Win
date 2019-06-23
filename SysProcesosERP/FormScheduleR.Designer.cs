namespace SysProcesosERP
{
    partial class FormScheduleR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEsActivo = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsDomingo = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsSabado = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsViernes = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsJueves = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsMiercoles = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsMartes = new WinControl_ELR_NET.ELRCheckBox();
            this.chkEsLunes = new WinControl_ELR_NET.ELRCheckBox();
            this.cboTarea = new WinControl_ELR_NET.ELRCombobox();
            this.chkOnlyOnce = new WinControl_ELR_NET.ELRCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elrTextBox1 = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreSP = new WinControl_ELR_NET.ELRTextBox();
            this.dtpHoraFinal = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel2 = new WinControl_ELR_NET.ELRLabel();
            this.dtpHoraInicio = new WinControl_ELR_NET.ELRDatePicker();
            this.elrLabel1 = new WinControl_ELR_NET.ELRLabel();
            this.elrLabel3 = new WinControl_ELR_NET.ELRLabel();
            this.elrNumericUpdDown1 = new WinControl_ELR_NET.ELRNumericUpdDown();
            this.elrNumericUpdDown2 = new WinControl_ELR_NET.ELRNumericUpdDown();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elrNumericUpdDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elrNumericUpdDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 433);
            this.pnBotones.Size = new System.Drawing.Size(652, 53);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(375, 0);
            this.btnGrabar.Size = new System.Drawing.Size(141, 49);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(516, 0);
            this.btnCancelar.Size = new System.Drawing.Size(132, 49);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Size = new System.Drawing.Size(95, 49);
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(280, 0);
            this.btnSiguientePage.Size = new System.Drawing.Size(95, 49);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(185, 49);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarea:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elrNumericUpdDown2);
            this.groupBox1.Controls.Add(this.elrNumericUpdDown1);
            this.groupBox1.Controls.Add(this.elrLabel3);
            this.groupBox1.Controls.Add(this.dtpHoraFinal);
            this.groupBox1.Controls.Add(this.elrLabel2);
            this.groupBox1.Controls.Add(this.dtpHoraInicio);
            this.groupBox1.Controls.Add(this.elrLabel1);
            this.groupBox1.Controls.Add(this.chkEsActivo);
            this.groupBox1.Controls.Add(this.chkEsDomingo);
            this.groupBox1.Controls.Add(this.chkEsSabado);
            this.groupBox1.Controls.Add(this.chkEsViernes);
            this.groupBox1.Controls.Add(this.chkEsJueves);
            this.groupBox1.Controls.Add(this.chkEsMiercoles);
            this.groupBox1.Controls.Add(this.chkEsMartes);
            this.groupBox1.Controls.Add(this.chkEsLunes);
            this.groupBox1.Location = new System.Drawing.Point(27, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.CampoData = "EsActivo";
            this.chkEsActivo.DSData = this.DSDatos;
            this.chkEsActivo.EsEditable = true;
            this.chkEsActivo.EsModificable = true;
            this.chkEsActivo.FiltroBusqueda = "";
            this.chkEsActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEsActivo.Location = new System.Drawing.Point(207, 59);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.NombreTabla = "";
            this.chkEsActivo.Size = new System.Drawing.Size(98, 25);
            this.chkEsActivo.TabIndex = 7;
            this.chkEsActivo.Text = "Es Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            this.chkEsActivo.ValorPorDefecto = true;
            // 
            // chkEsDomingo
            // 
            this.chkEsDomingo.AutoSize = true;
            this.chkEsDomingo.CampoData = "EsDomingo";
            this.chkEsDomingo.DSData = this.DSDatos;
            this.chkEsDomingo.EsEditable = true;
            this.chkEsDomingo.EsModificable = true;
            this.chkEsDomingo.FiltroBusqueda = "";
            this.chkEsDomingo.Location = new System.Drawing.Point(104, 59);
            this.chkEsDomingo.Name = "chkEsDomingo";
            this.chkEsDomingo.NombreTabla = "";
            this.chkEsDomingo.Size = new System.Drawing.Size(94, 25);
            this.chkEsDomingo.TabIndex = 6;
            this.chkEsDomingo.Text = "Domingo";
            this.chkEsDomingo.UseVisualStyleBackColor = true;
            this.chkEsDomingo.ValorPorDefecto = true;
            // 
            // chkEsSabado
            // 
            this.chkEsSabado.AutoSize = true;
            this.chkEsSabado.CampoData = "EsSabado";
            this.chkEsSabado.DSData = this.DSDatos;
            this.chkEsSabado.EsEditable = true;
            this.chkEsSabado.EsModificable = true;
            this.chkEsSabado.FiltroBusqueda = "";
            this.chkEsSabado.Location = new System.Drawing.Point(11, 59);
            this.chkEsSabado.Name = "chkEsSabado";
            this.chkEsSabado.NombreTabla = "";
            this.chkEsSabado.Size = new System.Drawing.Size(81, 25);
            this.chkEsSabado.TabIndex = 5;
            this.chkEsSabado.Text = "Sabado";
            this.chkEsSabado.UseVisualStyleBackColor = true;
            this.chkEsSabado.ValorPorDefecto = true;
            // 
            // chkEsViernes
            // 
            this.chkEsViernes.AutoSize = true;
            this.chkEsViernes.CampoData = "EsViernes";
            this.chkEsViernes.DSData = this.DSDatos;
            this.chkEsViernes.EsEditable = true;
            this.chkEsViernes.EsModificable = true;
            this.chkEsViernes.FiltroBusqueda = "";
            this.chkEsViernes.Location = new System.Drawing.Point(437, 28);
            this.chkEsViernes.Name = "chkEsViernes";
            this.chkEsViernes.NombreTabla = "";
            this.chkEsViernes.Size = new System.Drawing.Size(81, 25);
            this.chkEsViernes.TabIndex = 4;
            this.chkEsViernes.Text = "Viernes";
            this.chkEsViernes.UseVisualStyleBackColor = true;
            this.chkEsViernes.ValorPorDefecto = true;
            // 
            // chkEsJueves
            // 
            this.chkEsJueves.AutoSize = true;
            this.chkEsJueves.CampoData = "EsJueves";
            this.chkEsJueves.DSData = this.DSDatos;
            this.chkEsJueves.EsEditable = true;
            this.chkEsJueves.EsModificable = true;
            this.chkEsJueves.FiltroBusqueda = "";
            this.chkEsJueves.Location = new System.Drawing.Point(325, 28);
            this.chkEsJueves.Name = "chkEsJueves";
            this.chkEsJueves.NombreTabla = "";
            this.chkEsJueves.Size = new System.Drawing.Size(75, 25);
            this.chkEsJueves.TabIndex = 3;
            this.chkEsJueves.Text = "Jueves";
            this.chkEsJueves.UseVisualStyleBackColor = true;
            this.chkEsJueves.ValorPorDefecto = true;
            // 
            // chkEsMiercoles
            // 
            this.chkEsMiercoles.AutoSize = true;
            this.chkEsMiercoles.CampoData = "EsMiercoles";
            this.chkEsMiercoles.DSData = this.DSDatos;
            this.chkEsMiercoles.EsEditable = true;
            this.chkEsMiercoles.EsModificable = true;
            this.chkEsMiercoles.FiltroBusqueda = "";
            this.chkEsMiercoles.Location = new System.Drawing.Point(207, 28);
            this.chkEsMiercoles.Name = "chkEsMiercoles";
            this.chkEsMiercoles.NombreTabla = "";
            this.chkEsMiercoles.Size = new System.Drawing.Size(96, 25);
            this.chkEsMiercoles.TabIndex = 2;
            this.chkEsMiercoles.Text = "Miercoles";
            this.chkEsMiercoles.UseVisualStyleBackColor = true;
            this.chkEsMiercoles.ValorPorDefecto = true;
            // 
            // chkEsMartes
            // 
            this.chkEsMartes.AutoSize = true;
            this.chkEsMartes.CampoData = "ESMartes";
            this.chkEsMartes.DSData = this.DSDatos;
            this.chkEsMartes.EsEditable = true;
            this.chkEsMartes.EsModificable = true;
            this.chkEsMartes.FiltroBusqueda = "";
            this.chkEsMartes.Location = new System.Drawing.Point(104, 28);
            this.chkEsMartes.Name = "chkEsMartes";
            this.chkEsMartes.NombreTabla = "";
            this.chkEsMartes.Size = new System.Drawing.Size(77, 25);
            this.chkEsMartes.TabIndex = 1;
            this.chkEsMartes.Text = "Martes";
            this.chkEsMartes.UseVisualStyleBackColor = true;
            this.chkEsMartes.ValorPorDefecto = true;
            // 
            // chkEsLunes
            // 
            this.chkEsLunes.AutoSize = true;
            this.chkEsLunes.CampoData = "EsLunes";
            this.chkEsLunes.DSData = this.DSDatos;
            this.chkEsLunes.EsEditable = true;
            this.chkEsLunes.EsModificable = true;
            this.chkEsLunes.FiltroBusqueda = "";
            this.chkEsLunes.Location = new System.Drawing.Point(11, 28);
            this.chkEsLunes.Name = "chkEsLunes";
            this.chkEsLunes.NombreTabla = "";
            this.chkEsLunes.Size = new System.Drawing.Size(70, 25);
            this.chkEsLunes.TabIndex = 0;
            this.chkEsLunes.Text = "Lunes";
            this.chkEsLunes.UseVisualStyleBackColor = true;
            this.chkEsLunes.ValorPorDefecto = true;
            // 
            // cboTarea
            // 
            this.cboTarea.AValidar = null;
            this.cboTarea.CampoData = "";
            this.cboTarea.CampoJoinCombobox2 = "";
            this.cboTarea.ComboboxAFiltrar = null;
            this.cboTarea.DisplayMember = "Nombre";
            this.cboTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTarea.DSData = null;
            this.cboTarea.EsEditable = true;
            this.cboTarea.FiltroBusqueda = "";
            this.cboTarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTarea.FormattingEnabled = true;
            this.cboTarea.Location = new System.Drawing.Point(27, 50);
            this.cboTarea.Name = "cboTarea";
            this.cboTarea.NombreTabla = "";
            this.cboTarea.Size = new System.Drawing.Size(602, 29);
            this.cboTarea.SSQL = "";
            this.cboTarea.TabIndex = 12;
            this.cboTarea.TablaOVistaConsulta = "";
            this.cboTarea.UsaDataGlobal = false;
            this.cboTarea.ValorPorDefecto = "0";
            this.cboTarea.ValueMember = "Codigo";
            this.cboTarea.SelectedValueChanged += new System.EventHandler(this.cboTarea_SelectedValueChanged);
            // 
            // chkOnlyOnce
            // 
            this.chkOnlyOnce.AutoSize = true;
            this.chkOnlyOnce.CampoData = "onlyOnce";
            this.chkOnlyOnce.DSData = this.DSDatos;
            this.chkOnlyOnce.EsEditable = true;
            this.chkOnlyOnce.EsModificable = true;
            this.chkOnlyOnce.FiltroBusqueda = "";
            this.chkOnlyOnce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnlyOnce.Location = new System.Drawing.Point(27, 330);
            this.chkOnlyOnce.Name = "chkOnlyOnce";
            this.chkOnlyOnce.NombreTabla = "";
            this.chkOnlyOnce.Size = new System.Drawing.Size(314, 25);
            this.chkOnlyOnce.TabIndex = 13;
            this.chkOnlyOnce.Text = "SOLO EJECUTAR UNA VEZ POR FECHA";
            this.chkOnlyOnce.UseVisualStyleBackColor = true;
            this.chkOnlyOnce.ValorPorDefecto = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "EJECUTAR CADA";
            // 
            // elrTextBox1
            // 
            this.elrTextBox1.AMostrar = null;
            this.elrTextBox1.autoSenTab = true;
            this.elrTextBox1.AValidar = null;
            this.elrTextBox1.CampoBusquedaID = "";
            this.elrTextBox1.CampoData = "CantSegundoRepite";
            this.elrTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.elrTextBox1.ColumnasBusqGeneral = null;
            this.elrTextBox1.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.elrTextBox1.Decimales = 0;
            this.elrTextBox1.DSData = this.DSDatos;
            this.elrTextBox1.EsAutoGenerado = false;
            this.elrTextBox1.EsBusqueda = false;
            this.elrTextBox1.EsBusquedaAutoIncremental = false;
            this.elrTextBox1.EsEditable = true;
            this.elrTextBox1.FiltroBusqueda = "";
            this.elrTextBox1.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.elrTextBox1.Location = new System.Drawing.Point(166, 366);
            this.elrTextBox1.Name = "elrTextBox1";
            this.elrTextBox1.NombreTabla = "";
            this.elrTextBox1.SepDecimal = '\0';
            this.elrTextBox1.Size = new System.Drawing.Size(126, 29);
            this.elrTextBox1.TabIndex = 15;
            this.elrTextBox1.TablaOVistaBusqueda = "";
            this.elrTextBox1.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.elrTextBox1.TituloBusqueda = "BUSQUEDA GENERAL";
            this.elrTextBox1.ValorPorDefecto = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "SEGUNDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Store Procedure:";
            // 
            // txtNombreSP
            // 
            this.txtNombreSP.AMostrar = null;
            this.txtNombreSP.autoSenTab = true;
            this.txtNombreSP.AValidar = null;
            this.txtNombreSP.CampoBusquedaID = "";
            this.txtNombreSP.CampoData = "NombreSP";
            this.txtNombreSP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreSP.ColumnasBusqGeneral = null;
            this.txtNombreSP.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombreSP.Decimales = 0;
            this.txtNombreSP.DSData = this.DSDatos;
            this.txtNombreSP.EsAutoGenerado = false;
            this.txtNombreSP.EsBusqueda = false;
            this.txtNombreSP.EsBusquedaAutoIncremental = false;
            this.txtNombreSP.EsEditable = true;
            this.txtNombreSP.FiltroBusqueda = "";
            this.txtNombreSP.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombreSP.Location = new System.Drawing.Point(166, 89);
            this.txtNombreSP.Name = "txtNombreSP";
            this.txtNombreSP.NombreTabla = "";
            this.txtNombreSP.ReadOnly = true;
            this.txtNombreSP.SepDecimal = '\0';
            this.txtNombreSP.Size = new System.Drawing.Size(463, 29);
            this.txtNombreSP.TabIndex = 18;
            this.txtNombreSP.TablaOVistaBusqueda = "";
            this.txtNombreSP.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombreSP.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombreSP.ValorPorDefecto = "";
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.AValidar = null;
            this.dtpHoraFinal.CampoData = "Hora_Fin";
            this.dtpHoraFinal.DSData = this.DSDatos;
            this.dtpHoraFinal.EsEditable = true;
            this.dtpHoraFinal.FiltroBusqueda = "";
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(395, 99);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.NombreTabla = "";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(148, 29);
            this.dtpHoraFinal.TabIndex = 15;
            this.dtpHoraFinal.ValorPorDefecto = new System.DateTime(2017, 4, 16, 0, 0, 0, 0);
            // 
            // elrLabel2
            // 
            this.elrLabel2.AutoSize = true;
            this.elrLabel2.CampoData = "";
            this.elrLabel2.DSData = null;
            this.elrLabel2.Location = new System.Drawing.Point(308, 99);
            this.elrLabel2.Name = "elrLabel2";
            this.elrLabel2.NombreTabla = "";
            this.elrLabel2.Size = new System.Drawing.Size(81, 21);
            this.elrLabel2.TabIndex = 14;
            this.elrLabel2.Text = "Hora Final";
            this.elrLabel2.ValorPorDefecto = "";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.AValidar = null;
            this.dtpHoraInicio.CampoData = "Hora_Inicio";
            this.dtpHoraInicio.DSData = this.DSDatos;
            this.dtpHoraInicio.EsEditable = true;
            this.dtpHoraInicio.FiltroBusqueda = "";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(118, 98);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.NombreTabla = "";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(173, 29);
            this.dtpHoraInicio.TabIndex = 13;
            this.dtpHoraInicio.ValorPorDefecto = new System.DateTime(2017, 4, 16, 0, 0, 0, 0);
            // 
            // elrLabel1
            // 
            this.elrLabel1.AutoSize = true;
            this.elrLabel1.CampoData = "";
            this.elrLabel1.DSData = null;
            this.elrLabel1.Location = new System.Drawing.Point(10, 99);
            this.elrLabel1.Name = "elrLabel1";
            this.elrLabel1.NombreTabla = "";
            this.elrLabel1.Size = new System.Drawing.Size(88, 21);
            this.elrLabel1.TabIndex = 12;
            this.elrLabel1.Text = "Hora Inicio:";
            this.elrLabel1.ValorPorDefecto = "";
            // 
            // elrLabel3
            // 
            this.elrLabel3.AutoSize = true;
            this.elrLabel3.CampoData = "";
            this.elrLabel3.DSData = null;
            this.elrLabel3.Location = new System.Drawing.Point(10, 133);
            this.elrLabel3.Name = "elrLabel3";
            this.elrLabel3.NombreTabla = "";
            this.elrLabel3.Size = new System.Drawing.Size(102, 21);
            this.elrLabel3.TabIndex = 16;
            this.elrLabel3.Text = "Entre los dias";
            this.elrLabel3.ValorPorDefecto = "";
            // 
            // elrNumericUpdDown1
            // 
            this.elrNumericUpdDown1.AValidar = null;
            this.elrNumericUpdDown1.CampoData = "Dia_Inicio";
            this.elrNumericUpdDown1.DSData = this.DSDatos;
            this.elrNumericUpdDown1.EsEditable = true;
            this.elrNumericUpdDown1.Location = new System.Drawing.Point(118, 133);
            this.elrNumericUpdDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.elrNumericUpdDown1.Name = "elrNumericUpdDown1";
            this.elrNumericUpdDown1.NombreTabla = "";
            this.elrNumericUpdDown1.Size = new System.Drawing.Size(80, 29);
            this.elrNumericUpdDown1.TabIndex = 17;
            this.elrNumericUpdDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.elrNumericUpdDown1.ValorPorDefecto = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // elrNumericUpdDown2
            // 
            this.elrNumericUpdDown2.AValidar = null;
            this.elrNumericUpdDown2.CampoData = "Dia_Fin";
            this.elrNumericUpdDown2.DSData = this.DSDatos;
            this.elrNumericUpdDown2.EsEditable = true;
            this.elrNumericUpdDown2.Location = new System.Drawing.Point(207, 133);
            this.elrNumericUpdDown2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.elrNumericUpdDown2.Name = "elrNumericUpdDown2";
            this.elrNumericUpdDown2.NombreTabla = "";
            this.elrNumericUpdDown2.Size = new System.Drawing.Size(84, 29);
            this.elrNumericUpdDown2.TabIndex = 18;
            this.elrNumericUpdDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.elrNumericUpdDown2.ValorPorDefecto = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // FormScheduleR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AValidar = new WinControl_ELR_NET.Valida[0];
            this.ClientSize = new System.Drawing.Size(652, 486);
            this.Controls.Add(this.txtNombreSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elrTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkOnlyOnce);
            this.Controls.Add(this.cboTarea);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScheduleR";
            this.NombreCampoID = "Tarea_Id";
            this.TablaEncabezado = "TSISTEMA_PROCESOS_SCHEDULE";
            this.Text = "REGISTRAR SCHEDULE (PROGRAMACION)";
            this.Load += new System.EventHandler(this.FormScheduleR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cboTarea, 0);
            this.Controls.SetChildIndex(this.chkOnlyOnce, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.elrTextBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNombreSP, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elrNumericUpdDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elrNumericUpdDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRCheckBox chkEsDomingo;
        private WinControl_ELR_NET.ELRCheckBox chkEsSabado;
        private WinControl_ELR_NET.ELRCheckBox chkEsViernes;
        private WinControl_ELR_NET.ELRCheckBox chkEsJueves;
        private WinControl_ELR_NET.ELRCheckBox chkEsMiercoles;
        private WinControl_ELR_NET.ELRCheckBox chkEsMartes;
        private WinControl_ELR_NET.ELRCheckBox chkEsLunes;
        private WinControl_ELR_NET.ELRCombobox cboTarea;
        private WinControl_ELR_NET.ELRCheckBox chkEsActivo;
        private WinControl_ELR_NET.ELRCheckBox chkOnlyOnce;
        private System.Windows.Forms.Label label2;
        private WinControl_ELR_NET.ELRTextBox elrTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WinControl_ELR_NET.ELRTextBox txtNombreSP;
        private WinControl_ELR_NET.ELRNumericUpdDown elrNumericUpdDown2;
        private WinControl_ELR_NET.ELRNumericUpdDown elrNumericUpdDown1;
        private WinControl_ELR_NET.ELRLabel elrLabel3;
        private WinControl_ELR_NET.ELRDatePicker dtpHoraFinal;
        private WinControl_ELR_NET.ELRLabel elrLabel2;
        private WinControl_ELR_NET.ELRDatePicker dtpHoraInicio;
        private WinControl_ELR_NET.ELRLabel elrLabel1;
    }
}