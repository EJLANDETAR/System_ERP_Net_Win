namespace WinControl_ELR_NET
{
    partial class ELRFormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELRFormPrincipal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFechaOperaciones = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFechaLetra = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslNumeroSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCajaNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeOficinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesImpresionDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasYoReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearContrasenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmConfigModulosCarpetas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiOpcionesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRegistrarLicencia = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.tsbNotf = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultas = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbVentas = new System.Windows.Forms.ToolStripButton();
            this.tsbCompras = new System.Windows.Forms.ToolStripButton();
            this.tsbCobros = new System.Windows.Forms.ToolStripButton();
            this.tsbCuentasPagar = new System.Windows.Forms.ToolStripButton();
            this.tsbEntidades = new System.Windows.Forms.ToolStripButton();
            this.tsbProductos = new System.Windows.Forms.ToolStripButton();
            this.tsbProcesos = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbRoles = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.timerNotificaciones = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.tsBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslNombreUsuario,
            this.tslFechaOperaciones,
            this.tslFechaLetra,
            this.tslNumeroSerial,
            this.tslCajaNo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(740, 36);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslNombreUsuario
            // 
            this.tslNombreUsuario.Name = "tslNombreUsuario";
            this.tslNombreUsuario.Size = new System.Drawing.Size(145, 31);
            this.tslNombreUsuario.Text = "NOMBRE.USUARIO";
            // 
            // tslFechaOperaciones
            // 
            this.tslFechaOperaciones.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.tslFechaOperaciones.Name = "tslFechaOperaciones";
            this.tslFechaOperaciones.Size = new System.Drawing.Size(162, 31);
            this.tslFechaOperaciones.Text = "FECHA OPERACIONES";
            // 
            // tslFechaLetra
            // 
            this.tslFechaLetra.Name = "tslFechaLetra";
            this.tslFechaLetra.Size = new System.Drawing.Size(110, 31);
            this.tslFechaLetra.Text = "Fecha en Letra";
            // 
            // tslNumeroSerial
            // 
            this.tslNumeroSerial.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.tslNumeroSerial.Name = "tslNumeroSerial";
            this.tslNumeroSerial.Size = new System.Drawing.Size(227, 31);
            this.tslNumeroSerial.Text = "NUMERO SERIAL: 0000000000";
            // 
            // tslCajaNo
            // 
            this.tslCajaNo.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.tslCajaNo.Name = "tslCajaNo";
            this.tslCajaNo.Size = new System.Drawing.Size(95, 20);
            this.tslCajaNo.Text = "CAJA NO.: 0";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeOficinaToolStripMenuItem,
            this.opcionesImpresionDeCajaToolStripMenuItem,
            this.consultasYoReportesToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.resetearContrasenaToolStripMenuItem,
            this.realizarBackupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmConfigModulosCarpetas,
            this.tsmConfigSistema,
            this.tsmConfiOpcionesMenu,
            this.tsmConfiReportes,
            this.tsmConfigSeparador,
            this.tsmRegistrarLicencia,
            this.acercaDelSistemaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cambiarDeOficinaToolStripMenuItem
            // 
            this.cambiarDeOficinaToolStripMenuItem.Name = "cambiarDeOficinaToolStripMenuItem";
            this.cambiarDeOficinaToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.cambiarDeOficinaToolStripMenuItem.Text = "Cambiar de Oficina";
            this.cambiarDeOficinaToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeOficinaToolStripMenuItem_Click);
            // 
            // opcionesImpresionDeCajaToolStripMenuItem
            // 
            this.opcionesImpresionDeCajaToolStripMenuItem.Name = "opcionesImpresionDeCajaToolStripMenuItem";
            this.opcionesImpresionDeCajaToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.opcionesImpresionDeCajaToolStripMenuItem.Text = "Opciones Impresion de caja";
            this.opcionesImpresionDeCajaToolStripMenuItem.Click += new System.EventHandler(this.opcionesImpresionDeCajaToolStripMenuItem_Click);
            // 
            // consultasYoReportesToolStripMenuItem
            // 
            this.consultasYoReportesToolStripMenuItem.Name = "consultasYoReportesToolStripMenuItem";
            this.consultasYoReportesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.consultasYoReportesToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.consultasYoReportesToolStripMenuItem.Text = "Consultas y/o Reportes";
            this.consultasYoReportesToolStripMenuItem.Click += new System.EventHandler(this.consultasYoReportesToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // resetearContrasenaToolStripMenuItem
            // 
            this.resetearContrasenaToolStripMenuItem.Name = "resetearContrasenaToolStripMenuItem";
            this.resetearContrasenaToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.resetearContrasenaToolStripMenuItem.Text = "Resetear Contrasena";
            // 
            // realizarBackupToolStripMenuItem
            // 
            this.realizarBackupToolStripMenuItem.Name = "realizarBackupToolStripMenuItem";
            this.realizarBackupToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.realizarBackupToolStripMenuItem.Text = "Realizar Backup";
            this.realizarBackupToolStripMenuItem.Click += new System.EventHandler(this.realizarBackupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 6);
            // 
            // tsmConfigModulosCarpetas
            // 
            this.tsmConfigModulosCarpetas.Name = "tsmConfigModulosCarpetas";
            this.tsmConfigModulosCarpetas.Size = new System.Drawing.Size(288, 24);
            this.tsmConfigModulosCarpetas.Text = "Modulos o Carpetas";
            this.tsmConfigModulosCarpetas.Click += new System.EventHandler(this.tsmConfigModulosCarpetas_Click);
            // 
            // tsmConfigSistema
            // 
            this.tsmConfigSistema.Name = "tsmConfigSistema";
            this.tsmConfigSistema.Size = new System.Drawing.Size(288, 24);
            this.tsmConfigSistema.Text = "Configuracion y/o Variables";
            this.tsmConfigSistema.Click += new System.EventHandler(this.tsmConfigSistema_Click);
            // 
            // tsmConfiOpcionesMenu
            // 
            this.tsmConfiOpcionesMenu.Name = "tsmConfiOpcionesMenu";
            this.tsmConfiOpcionesMenu.Size = new System.Drawing.Size(288, 24);
            this.tsmConfiOpcionesMenu.Text = "Opciones o Menu";
            this.tsmConfiOpcionesMenu.Click += new System.EventHandler(this.tsmConfiOpcionesMenu_Click);
            // 
            // tsmConfiReportes
            // 
            this.tsmConfiReportes.Name = "tsmConfiReportes";
            this.tsmConfiReportes.Size = new System.Drawing.Size(288, 24);
            this.tsmConfiReportes.Text = "Archivos de Reportes";
            this.tsmConfiReportes.Click += new System.EventHandler(this.tsmConfiReportes_Click);
            // 
            // tsmConfigSeparador
            // 
            this.tsmConfigSeparador.Name = "tsmConfigSeparador";
            this.tsmConfigSeparador.Size = new System.Drawing.Size(285, 6);
            // 
            // tsmRegistrarLicencia
            // 
            this.tsmRegistrarLicencia.Name = "tsmRegistrarLicencia";
            this.tsmRegistrarLicencia.Size = new System.Drawing.Size(288, 24);
            this.tsmRegistrarLicencia.Text = "Registrar Licencia";
            this.tsmRegistrarLicencia.Click += new System.EventHandler(this.registrarLicenciaToolStripMenuItem_Click);
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            this.acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            this.acercaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.acercaDelSistemaToolStripMenuItem.Text = "Acerca del Sistema";
            this.acercaDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSistemaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(285, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.salirToolStripMenuItem.Text = "Salir (Cerrar Aplicacion)";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuPrincipal.Size = new System.Drawing.Size(740, 30);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // tsBarra
            // 
            this.tsBarra.AutoSize = false;
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNotf,
            this.tsbConsultas,
            this.tsbSalir,
            this.tsbVentas,
            this.tsbCompras,
            this.tsbCobros,
            this.tsbCuentasPagar,
            this.tsbEntidades,
            this.tsbProductos,
            this.tsbProcesos,
            this.tsbUsuarios,
            this.tsbRoles});
            this.tsBarra.Location = new System.Drawing.Point(0, 30);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Size = new System.Drawing.Size(740, 73);
            this.tsBarra.TabIndex = 2;
            this.tsBarra.Text = "Consultas y/o Reportes";
            // 
            // tsbNotf
            // 
            this.tsbNotf.BackColor = System.Drawing.Color.LimeGreen;
            this.tsbNotf.ForeColor = System.Drawing.Color.White;
            this.tsbNotf.Image = global::WinControl_ELR_NET.Properties.Resources.Notification_52px;
            this.tsbNotf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNotf.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.tsbNotf.Name = "tsbNotf";
            this.tsbNotf.Padding = new System.Windows.Forms.Padding(8);
            this.tsbNotf.Size = new System.Drawing.Size(72, 70);
            this.tsbNotf.Text = "( 0 )";
            this.tsbNotf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNotf.ToolTipText = "NOTIFICACIONES";
            this.tsbNotf.Click += new System.EventHandler(this.tsbNotf_Click);
            // 
            // tsbConsultas
            // 
            this.tsbConsultas.Image = global::WinControl_ELR_NET.Properties.Resources.Report_Card_52px;
            this.tsbConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultas.Name = "tsbConsultas";
            this.tsbConsultas.Padding = new System.Windows.Forms.Padding(8);
            this.tsbConsultas.Size = new System.Drawing.Size(79, 70);
            this.tsbConsultas.Text = "Consultas";
            this.tsbConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConsultas.ToolTipText = "Consultas y/o reportes";
            this.tsbConsultas.Click += new System.EventHandler(this.tsbConsultas_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = global::WinControl_ELR_NET.Properties.Resources.Logout_Rounded_Up_52px;
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Padding = new System.Windows.Forms.Padding(8);
            this.tsbSalir.Size = new System.Drawing.Size(72, 70);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.ToolTipText = "Salir (Cerrar Session)";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbVentas
            // 
            this.tsbVentas.Image = global::WinControl_ELR_NET.Properties.Resources.Cash_Register_52px;
            this.tsbVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVentas.Name = "tsbVentas";
            this.tsbVentas.Padding = new System.Windows.Forms.Padding(8);
            this.tsbVentas.Size = new System.Drawing.Size(72, 70);
            this.tsbVentas.Tag = "ELRFacturas.FormFactura";
            this.tsbVentas.Text = "Ventas";
            this.tsbVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVentas.ToolTipText = "Registrar Factura (Venta)";
            this.tsbVentas.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbCompras
            // 
            this.tsbCompras.Image = global::WinControl_ELR_NET.Properties.Resources.Buying_52px;
            this.tsbCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCompras.Name = "tsbCompras";
            this.tsbCompras.Padding = new System.Windows.Forms.Padding(8);
            this.tsbCompras.Size = new System.Drawing.Size(75, 70);
            this.tsbCompras.Tag = "ELRCuentasPorPagar.FormFacturasCompras";
            this.tsbCompras.Text = "Compras";
            this.tsbCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCompras.ToolTipText = "Compras";
            this.tsbCompras.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbCobros
            // 
            this.tsbCobros.Image = global::WinControl_ELR_NET.Properties.Resources.Refund_52px;
            this.tsbCobros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCobros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCobros.Name = "tsbCobros";
            this.tsbCobros.Padding = new System.Windows.Forms.Padding(8);
            this.tsbCobros.Size = new System.Drawing.Size(151, 70);
            this.tsbCobros.Tag = "ELRFacturas.FormFactCobroPorGrupo";
            this.tsbCobros.Text = "Abonar Cuentas Cobrar";
            this.tsbCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCobros.ToolTipText = "Abono o pago Cuentas Cobrar";
            this.tsbCobros.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbCuentasPagar
            // 
            this.tsbCuentasPagar.Image = global::WinControl_ELR_NET.Properties.Resources.Paper_Money_52px;
            this.tsbCuentasPagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCuentasPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCuentasPagar.Name = "tsbCuentasPagar";
            this.tsbCuentasPagar.Padding = new System.Windows.Forms.Padding(8);
            this.tsbCuentasPagar.Size = new System.Drawing.Size(141, 70);
            this.tsbCuentasPagar.Tag = "ELRCuentasPorPagar.FormCXP";
            this.tsbCuentasPagar.Text = "Pago (Cuentas Pagar)";
            this.tsbCuentasPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCuentasPagar.ToolTipText = "Pago de Cuentas Pagar";
            this.tsbCuentasPagar.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbEntidades
            // 
            this.tsbEntidades.Image = global::WinControl_ELR_NET.Properties.Resources.Customer_52px;
            this.tsbEntidades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEntidades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEntidades.Name = "tsbEntidades";
            this.tsbEntidades.Padding = new System.Windows.Forms.Padding(8);
            this.tsbEntidades.Size = new System.Drawing.Size(131, 87);
            this.tsbEntidades.Tag = "ELRMaestros.FormEntidadesIndex";
            this.tsbEntidades.Text = "Entidades (Clientes)";
            this.tsbEntidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEntidades.ToolTipText = "Clientes";
            this.tsbEntidades.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbProductos
            // 
            this.tsbProductos.Image = global::WinControl_ELR_NET.Properties.Resources.Product_52px;
            this.tsbProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductos.Name = "tsbProductos";
            this.tsbProductos.Padding = new System.Windows.Forms.Padding(8);
            this.tsbProductos.Size = new System.Drawing.Size(81, 87);
            this.tsbProductos.Tag = "ELRMaestros.FormProductos";
            this.tsbProductos.Text = "Productos";
            this.tsbProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProductos.ToolTipText = "Registrar Productos y/o Servicios";
            this.tsbProductos.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbProcesos
            // 
            this.tsbProcesos.Image = global::WinControl_ELR_NET.Properties.Resources.Schedule_52px;
            this.tsbProcesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProcesos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProcesos.Name = "tsbProcesos";
            this.tsbProcesos.Padding = new System.Windows.Forms.Padding(8);
            this.tsbProcesos.Size = new System.Drawing.Size(79, 87);
            this.tsbProcesos.Tag = "WinControl_ELR_NET.FormGenerarProcesosSys";
            this.tsbProcesos.Text = "Cerrar Dia";
            this.tsbProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProcesos.ToolTipText = "Cerrar Dia (Realizar Procesos)";
            this.tsbProcesos.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Image = global::WinControl_ELR_NET.Properties.Resources.User_Account_52px;
            this.tsbUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Padding = new System.Windows.Forms.Padding(8);
            this.tsbUsuarios.Size = new System.Drawing.Size(72, 87);
            this.tsbUsuarios.Tag = "ELRControlUsuarios.FormUsuarios";
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUsuarios.ToolTipText = "Administrar Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // tsbRoles
            // 
            this.tsbRoles.Image = global::WinControl_ELR_NET.Properties.Resources.User_Groups_52px;
            this.tsbRoles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRoles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoles.Name = "tsbRoles";
            this.tsbRoles.Padding = new System.Windows.Forms.Padding(8);
            this.tsbRoles.Size = new System.Drawing.Size(72, 87);
            this.tsbRoles.Tag = "ELRControlUsuarios.FormRoles";
            this.tsbRoles.Text = "Roles";
            this.tsbRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRoles.ToolTipText = "Definir Grupo o Roles de Usuarios";
            this.tsbRoles.Click += new System.EventHandler(this.tsbBarraBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 103);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.trvMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackgroundImage = global::WinControl_ELR_NET.Properties.Resources.fondo1;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.btnPrueba);
            this.splitContainer1.Size = new System.Drawing.Size(740, 282);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 3;
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.ShowLines = false;
            this.trvMenu.Size = new System.Drawing.Size(245, 282);
            this.trvMenu.TabIndex = 2;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Image = global::WinControl_ELR_NET.Properties.Resources.ViewEdit_26px;
            this.btnPrueba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba.Location = new System.Drawing.Point(314, 115);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(170, 86);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Este un boton";
            this.btnPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Visible = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // timerNotificaciones
            // 
            this.timerNotificaciones.Interval = 120000;
            this.timerNotificaciones.Tick += new System.EventHandler(this.timerNotificaciones_Tick);
            // 
            // ELRFormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 421);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsBarra);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ELRFormPrincipal";
            this.Text = "ELRFormPrincipal";
            this.Activated += new System.EventHandler(this.ELRFormPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ELRFormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.ELRFormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ELRFormPrincipal_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslNombreUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tslFechaOperaciones;
        private System.Windows.Forms.ToolStripStatusLabel tslFechaLetra;
        private System.Windows.Forms.ToolStripStatusLabel tslNumeroSerial;
        private System.Windows.Forms.ToolStripStatusLabel tslCajaNo;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeOficinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasYoReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearContrasenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigModulosCarpetas;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiOpcionesMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiReportes;
        private System.Windows.Forms.ToolStripSeparator tsmConfigSeparador;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrarLicencia;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.ToolStripButton tsbConsultas;
        private System.Windows.Forms.ToolStripButton tsbProductos;
        private System.Windows.Forms.ToolStripButton tsbVentas;
        private System.Windows.Forms.ToolStripButton tsbCompras;
        private System.Windows.Forms.ToolStripButton tsbEntidades;
        private System.Windows.Forms.ToolStripButton tsbCobros;
        private System.Windows.Forms.ToolStripButton tsbProcesos;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbRoles;
        private System.Windows.Forms.ToolStripButton tsbCuentasPagar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.ToolStripMenuItem opcionesImpresionDeCajaToolStripMenuItem;
        private System.Windows.Forms.Timer timerNotificaciones;
        private System.Windows.Forms.ToolStripButton tsbNotf;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}