namespace ELRNomina
{
    partial class FormNominasMovimientosR
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
            WinControl_ELR_NET.Valida valida3 = new WinControl_ELR_NET.Valida();
            WinControl_ELR_NET.Valida valida4 = new WinControl_ELR_NET.Valida();
            this.txtEmpleadoId = new WinControl_ELR_NET.ELRTextBox();
            this.txtCantidad = new WinControl_ELR_NET.ELRTextBox();
            this.txtValor = new WinControl_ELR_NET.ELRTextBox();
            this.txtCodigo = new WinControl_ELR_NET.ELRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCedulaRNC = new WinControl_ELR_NET.ELRTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new WinControl_ELR_NET.ELRTextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new WinControl_ELR_NET.ELRDatePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConcepto = new WinControl_ELR_NET.ELRTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarTipoTrans = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtComentario = new WinControl_ELR_NET.ELRTextBox();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 395);
            this.pnBotones.Size = new System.Drawing.Size(583, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(343, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(484, 0);
            // 
            // btnAnterior
            // 
            this.toolTip1.SetToolTip(this.btnAnterior, "CTRL + A = Anterior ");
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(248, 0);
            this.toolTip1.SetToolTip(this.btnSiguientePage, "CTRL + S = Siguiente ");
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Size = new System.Drawing.Size(153, 39);
            // 
            // txtEmpleadoId
            // 
            this.txtEmpleadoId.AMostrar = null;
            this.txtEmpleadoId.AValidar = null;
            this.txtEmpleadoId.CampoBusquedaID = "";
            this.txtEmpleadoId.CampoData = "Empleado_Id";
            this.txtEmpleadoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleadoId.ColumnasBusqGeneral = null;
            this.txtEmpleadoId.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtEmpleadoId.Decimales = 0;
            this.txtEmpleadoId.DSData = this.DSDatos;
            this.txtEmpleadoId.EsAutoGenerado = false;
            this.txtEmpleadoId.EsBusqueda = false;
            this.txtEmpleadoId.EsBusquedaAutoIncremental = false;
            this.txtEmpleadoId.EsEditable = true;
            this.txtEmpleadoId.FiltroBusqueda = "";
            this.txtEmpleadoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoId.Formato = WinControl_ELR_NET.tbFormato.NumerosEnteros;
            this.txtEmpleadoId.Location = new System.Drawing.Point(92, 28);
            this.txtEmpleadoId.Name = "txtEmpleadoId";
            this.txtEmpleadoId.NombreTabla = "";
            this.txtEmpleadoId.SepDecimal = '\0';
            this.txtEmpleadoId.Size = new System.Drawing.Size(132, 26);
            this.txtEmpleadoId.TabIndex = 11;
            this.txtEmpleadoId.TablaOVistaBusqueda = "";
            this.txtEmpleadoId.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtEmpleadoId.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtEmpleadoId.ValorPorDefecto = "";
            this.txtEmpleadoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpleadoId_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AMostrar = null;
            this.txtCantidad.AValidar = null;
            this.txtCantidad.CampoBusquedaID = "";
            this.txtCantidad.CampoData = "Cantidad";
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.ColumnasBusqGeneral = null;
            this.txtCantidad.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCantidad.Decimales = 0;
            this.txtCantidad.DSData = this.DSDatos;
            this.txtCantidad.EsAutoGenerado = false;
            this.txtCantidad.EsBusqueda = false;
            this.txtCantidad.EsBusquedaAutoIncremental = false;
            this.txtCantidad.EsEditable = true;
            this.txtCantidad.FiltroBusqueda = "";
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCantidad.Location = new System.Drawing.Point(115, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.NombreTabla = "";
            this.txtCantidad.SepDecimal = '\0';
            this.txtCantidad.Size = new System.Drawing.Size(152, 26);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TablaOVistaBusqueda = "";
            this.txtCantidad.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCantidad.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCantidad.ValorPorDefecto = "1";
            // 
            // txtValor
            // 
            this.txtValor.AMostrar = null;
            this.txtValor.AValidar = null;
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.CampoBusquedaID = "";
            this.txtValor.CampoData = "Valor";
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.ColumnasBusqGeneral = null;
            this.txtValor.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtValor.Decimales = 0;
            this.txtValor.DSData = this.DSDatos;
            this.txtValor.EsAutoGenerado = false;
            this.txtValor.EsBusqueda = false;
            this.txtValor.EsBusquedaAutoIncremental = false;
            this.txtValor.EsEditable = true;
            this.txtValor.FiltroBusqueda = "";
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtValor.Location = new System.Drawing.Point(386, 94);
            this.txtValor.Name = "txtValor";
            this.txtValor.NombreTabla = "";
            this.txtValor.ReadOnly = true;
            this.txtValor.SepDecimal = '\0';
            this.txtValor.Size = new System.Drawing.Size(176, 26);
            this.txtValor.TabIndex = 14;
            this.txtValor.TablaOVistaBusqueda = "";
            this.txtValor.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtValor.TituloBusqueda = "BUSQUEDA GENERAL";
            this.toolTip1.SetToolTip(this.txtValor, "Valor o Precio Unitario");
            this.txtValor.ValorPorDefecto = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AMostrar = null;
            this.txtCodigo.AValidar = null;
            this.txtCodigo.CampoBusquedaID = "";
            this.txtCodigo.CampoData = "Codigo";
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ColumnasBusqGeneral = null;
            this.txtCodigo.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCodigo.Decimales = 0;
            this.txtCodigo.DSData = this.DSDatos;
            this.txtCodigo.EsAutoGenerado = false;
            this.txtCodigo.EsBusqueda = false;
            this.txtCodigo.EsBusquedaAutoIncremental = false;
            this.txtCodigo.EsEditable = true;
            this.txtCodigo.FiltroBusqueda = "";
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCodigo.Location = new System.Drawing.Point(115, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.NombreTabla = "";
            this.txtCodigo.SepDecimal = '\0';
            this.txtCodigo.Size = new System.Drawing.Size(152, 26);
            this.txtCodigo.TabIndex = 15;
            this.txtCodigo.TablaOVistaBusqueda = "";
            this.txtCodigo.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCodigo.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCodigo.ValorPorDefecto = "";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCedulaRNC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnBuscarEmpleado);
            this.groupBox1.Controls.Add(this.txtEmpleadoId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.AMostrar = null;
            this.txtCedulaRNC.AValidar = null;
            this.txtCedulaRNC.BackColor = System.Drawing.Color.White;
            this.txtCedulaRNC.CampoBusquedaID = "";
            this.txtCedulaRNC.CampoData = "CedulaRNC";
            this.txtCedulaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaRNC.ColumnasBusqGeneral = null;
            this.txtCedulaRNC.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtCedulaRNC.Decimales = 0;
            this.txtCedulaRNC.DSData = this.DSDatos;
            this.txtCedulaRNC.EsAutoGenerado = false;
            this.txtCedulaRNC.EsBusqueda = false;
            this.txtCedulaRNC.EsBusquedaAutoIncremental = false;
            this.txtCedulaRNC.EsEditable = true;
            this.txtCedulaRNC.FiltroBusqueda = "";
            this.txtCedulaRNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaRNC.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtCedulaRNC.Location = new System.Drawing.Point(412, 26);
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.NombreTabla = "";
            this.txtCedulaRNC.ReadOnly = true;
            this.txtCedulaRNC.SepDecimal = '\0';
            this.txtCedulaRNC.Size = new System.Drawing.Size(150, 26);
            this.txtCedulaRNC.TabIndex = 17;
            this.txtCedulaRNC.TablaOVistaBusqueda = "";
            this.txtCedulaRNC.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtCedulaRNC.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtCedulaRNC.ValorPorDefecto = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cedula\\RNC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.AMostrar = null;
            this.txtNombre.AValidar = null;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CampoBusquedaID = "";
            this.txtNombre.CampoData = "Nombre";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColumnasBusqGeneral = null;
            this.txtNombre.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtNombre.Decimales = 0;
            this.txtNombre.DSData = this.DSDatos;
            this.txtNombre.EsAutoGenerado = false;
            this.txtNombre.EsBusqueda = false;
            this.txtNombre.EsBusquedaAutoIncremental = false;
            this.txtNombre.EsEditable = true;
            this.txtNombre.FiltroBusqueda = "";
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtNombre.Location = new System.Drawing.Point(92, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NombreTabla = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SepDecimal = '\0';
            this.txtNombre.Size = new System.Drawing.Size(470, 26);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TablaOVistaBusqueda = "";
            this.txtNombre.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtNombre.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtNombre.ValorPorDefecto = "";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = global::ELRNomina.Properties.Resources._1378160672_search;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(230, 25);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarEmpleado.TabIndex = 12;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtConcepto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBuscarTipoTrans);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaccion";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AValidar = null;
            this.dtpFecha.CampoData = "";
            this.dtpFecha.DSData = null;
            this.dtpFecha.EsEditable = true;
            this.dtpFecha.FiltroBusqueda = "";
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(115, 126);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NombreTabla = "";
            this.dtpFecha.Size = new System.Drawing.Size(152, 29);
            this.dtpFecha.TabIndex = 20;
            this.dtpFecha.ValorPorDefecto = new System.DateTime(2017, 1, 7, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.AMostrar = null;
            this.txtConcepto.AValidar = null;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.CampoBusquedaID = "";
            this.txtConcepto.CampoData = "Concepto";
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColumnasBusqGeneral = null;
            this.txtConcepto.CondicionABuscar = " Campo_Busqueda Like \'%\' + @aBuscar + \'%\' ";
            this.txtConcepto.Decimales = 0;
            this.txtConcepto.DSData = this.DSDatos;
            this.txtConcepto.EsAutoGenerado = false;
            this.txtConcepto.EsBusqueda = false;
            this.txtConcepto.EsBusquedaAutoIncremental = false;
            this.txtConcepto.EsEditable = true;
            this.txtConcepto.FiltroBusqueda = "";
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtConcepto.Location = new System.Drawing.Point(115, 62);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.NombreTabla = "";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.SepDecimal = '\0';
            this.txtConcepto.Size = new System.Drawing.Size(447, 26);
            this.txtConcepto.TabIndex = 18;
            this.txtConcepto.TablaOVistaBusqueda = "";
            this.txtConcepto.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtConcepto.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtConcepto.ValorPorDefecto = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Descripcion:";
            // 
            // btnBuscarTipoTrans
            // 
            this.btnBuscarTipoTrans.Image = global::ELRNomina.Properties.Resources._1378160672_search;
            this.btnBuscarTipoTrans.Location = new System.Drawing.Point(273, 28);
            this.btnBuscarTipoTrans.Name = "btnBuscarTipoTrans";
            this.btnBuscarTipoTrans.Size = new System.Drawing.Size(42, 31);
            this.btnBuscarTipoTrans.TabIndex = 16;
            this.btnBuscarTipoTrans.UseVisualStyleBackColor = true;
            this.btnBuscarTipoTrans.Click += new System.EventHandler(this.btnBuscarTipoTrans_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor\\P. Unit.:";
            this.toolTip1.SetToolTip(this.label6, "Valor o Precio Unitario");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtComentario);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 122);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comentario";
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
            this.txtComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComentario.DSData = this.DSDatos;
            this.txtComentario.EsAutoGenerado = false;
            this.txtComentario.EsBusqueda = false;
            this.txtComentario.EsBusquedaAutoIncremental = false;
            this.txtComentario.EsEditable = true;
            this.txtComentario.FiltroBusqueda = "";
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Formato = WinControl_ELR_NET.tbFormato.Default;
            this.txtComentario.Location = new System.Drawing.Point(3, 25);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.NombreTabla = "";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComentario.SepDecimal = '\0';
            this.txtComentario.Size = new System.Drawing.Size(577, 94);
            this.txtComentario.TabIndex = 13;
            this.txtComentario.TablaOVistaBusqueda = "";
            this.txtComentario.TipoCampoBusqueda = WinControl_ELR_NET.tbTipoCampoBusqueda.Id;
            this.txtComentario.TituloBusqueda = "BUSQUEDA GENERAL";
            this.txtComentario.ValorPorDefecto = "";
            // 
            // FormNominasMovimientosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            valida1.comtrol = this.txtEmpleadoId;
            valida1.Mensaje = "Debe Seleccionar un Empleado";
            valida1.NombreCampo = "Empleado_Id";
            valida1.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida1.Valor1 = "1";
            valida1.Valor2 = null;
            valida2.comtrol = this.txtCantidad;
            valida2.Mensaje = "La Cantidad debe Ser Mayor a Cero";
            valida2.NombreCampo = "Cantidad";
            valida2.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida2.Valor1 = "1";
            valida2.Valor2 = null;
            valida3.comtrol = this.txtValor;
            valida3.Mensaje = "El Valor o Costo dede ser Mayor a Cero";
            valida3.NombreCampo = "Valor";
            valida3.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.MayorOIgualA;
            valida3.Valor1 = "1";
            valida3.Valor2 = null;
            valida4.comtrol = this.txtCodigo;
            valida4.Mensaje = "Debe Elegir tipo de Transaccion";
            valida4.NombreCampo = "Codigo";
            valida4.TipoValidacion = WinControl_ELR_NET.tbTipoValidacion.NoVacio;
            valida4.Valor1 = null;
            valida4.Valor2 = null;
            this.AValidar = new WinControl_ELR_NET.Valida[] {
        valida1,
        valida2,
        valida3,
        valida4};
            this.ClientSize = new System.Drawing.Size(583, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.EsConTemporal = true;
            this.Name = "FormNominasMovimientosR";
            this.NombreCampoID = "Identificador_Id";
            this.SPGraba = "SP_NOMINA_REGISTRAR_TRANSACCION";
            this.TablaEncabezado = "TTEMPORAL_NOMINAS_MOVIMIENTOS";
            this.Text = "REGISTRAR TRANSACCION DE NOMINA";
            this.Load += new System.EventHandler(this.FormNominasMovimientosR_Load);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControl_ELR_NET.ELRTextBox txtCedulaRNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WinControl_ELR_NET.ELRTextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private WinControl_ELR_NET.ELRTextBox txtEmpleadoId;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinControl_ELR_NET.ELRTextBox txtValor;
        private System.Windows.Forms.Label label6;
        private WinControl_ELR_NET.ELRTextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private WinControl_ELR_NET.ELRTextBox txtComentario;
        private WinControl_ELR_NET.ELRTextBox txtConcepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarTipoTrans;
        private WinControl_ELR_NET.ELRTextBox txtCodigo;
        private WinControl_ELR_NET.ELRDatePicker dtpFecha;
        private System.Windows.Forms.Label label8;
    }
}