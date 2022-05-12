namespace ObligatorioUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntrarProductor = new System.Windows.Forms.Button();
            this.RegistrarProductor = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.BtnCrearProductor = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CrearProductor = new System.Windows.Forms.Button();
            this.HolaProductor = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.IngresarProductor = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LoginContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.ListaEventos = new System.Windows.Forms.ListBox();
            this.PanelEventos = new System.Windows.Forms.Panel();
            this.PanelCompra = new System.Windows.Forms.Panel();
            this.VolverAEventos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CantidadEntradas = new System.Windows.Forms.NumericUpDown();
            this.BtnTerminarCompra = new System.Windows.Forms.Button();
            this.BtnAgregarACompra = new System.Windows.Forms.Button();
            this.ListaTiposTicket = new System.Windows.Forms.ListBox();
            this.ListaFunciones = new System.Windows.Forms.ListBox();
            this.ComprarEntrada = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DatosCompra = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NombreCompra = new System.Windows.Forms.TextBox();
            this.ApellidoCompra = new System.Windows.Forms.TextBox();
            this.CedulaCompra = new System.Windows.Forms.TextBox();
            this.TerminarCompraFinal = new System.Windows.Forms.Button();
            this.LabelErrorCompra = new System.Windows.Forms.Label();
            this.PanelTickets = new System.Windows.Forms.Panel();
            this.LabelGracias = new System.Windows.Forms.Label();
            this.LabelTickets = new System.Windows.Forms.Label();
            this.ListaTickets = new System.Windows.Forms.Label();
            this.VolverEventos = new System.Windows.Forms.Button();
            this.RegistrarProductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.IngresarProductor.SuspendLayout();
            this.PanelEventos.SuspendLayout();
            this.PanelCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEntradas)).BeginInit();
            this.DatosCompra.SuspendLayout();
            this.PanelTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntrarProductor
            // 
            this.EntrarProductor.Location = new System.Drawing.Point(53, 50);
            this.EntrarProductor.Name = "EntrarProductor";
            this.EntrarProductor.Size = new System.Drawing.Size(235, 73);
            this.EntrarProductor.TabIndex = 0;
            this.EntrarProductor.Text = "Ingresar como productor";
            this.EntrarProductor.UseVisualStyleBackColor = true;
            this.EntrarProductor.Click += new System.EventHandler(this.EntrarProductor_Click);
            // 
            // RegistrarProductor
            // 
            this.RegistrarProductor.Controls.Add(this.ErrorLabel);
            this.RegistrarProductor.Controls.Add(this.BtnCrearProductor);
            this.RegistrarProductor.Controls.Add(this.Contraseña);
            this.RegistrarProductor.Controls.Add(this.label4);
            this.RegistrarProductor.Controls.Add(this.Mail);
            this.RegistrarProductor.Controls.Add(this.label3);
            this.RegistrarProductor.Controls.Add(this.Apellido);
            this.RegistrarProductor.Controls.Add(this.label2);
            this.RegistrarProductor.Controls.Add(this.Nombre);
            this.RegistrarProductor.Controls.Add(this.label1);
            this.RegistrarProductor.Location = new System.Drawing.Point(339, 50);
            this.RegistrarProductor.Name = "RegistrarProductor";
            this.RegistrarProductor.Size = new System.Drawing.Size(892, 460);
            this.RegistrarProductor.TabIndex = 1;
            this.RegistrarProductor.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(431, 371);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(70, 25);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "label5";
            this.ErrorLabel.Visible = false;
            // 
            // BtnCrearProductor
            // 
            this.BtnCrearProductor.Location = new System.Drawing.Point(42, 356);
            this.BtnCrearProductor.Name = "BtnCrearProductor";
            this.BtnCrearProductor.Size = new System.Drawing.Size(203, 41);
            this.BtnCrearProductor.TabIndex = 8;
            this.BtnCrearProductor.Text = "Crear productor";
            this.BtnCrearProductor.UseVisualStyleBackColor = true;
            this.BtnCrearProductor.Click += new System.EventHandler(this.BtnCrearProductor_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(431, 253);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(200, 31);
            this.Contraseña.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(431, 112);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(200, 31);
            this.Mail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(45, 253);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(200, 31);
            this.Apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(45, 112);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(200, 31);
            this.Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // CrearProductor
            // 
            this.CrearProductor.Location = new System.Drawing.Point(53, 162);
            this.CrearProductor.Name = "CrearProductor";
            this.CrearProductor.Size = new System.Drawing.Size(235, 73);
            this.CrearProductor.TabIndex = 2;
            this.CrearProductor.Text = "Registrarse como productor";
            this.CrearProductor.UseVisualStyleBackColor = true;
            this.CrearProductor.Click += new System.EventHandler(this.CrearProductor_Click);
            // 
            // HolaProductor
            // 
            this.HolaProductor.AutoSize = true;
            this.HolaProductor.Location = new System.Drawing.Point(48, 50);
            this.HolaProductor.Name = "HolaProductor";
            this.HolaProductor.Size = new System.Drawing.Size(149, 25);
            this.HolaProductor.TabIndex = 3;
            this.HolaProductor.Text = "HolaProductor";
            this.HolaProductor.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // IngresarProductor
            // 
            this.IngresarProductor.Controls.Add(this.LoginLabel);
            this.IngresarProductor.Controls.Add(this.BtnLogin);
            this.IngresarProductor.Controls.Add(this.LoginContraseña);
            this.IngresarProductor.Controls.Add(this.label5);
            this.IngresarProductor.Controls.Add(this.LoginMail);
            this.IngresarProductor.Controls.Add(this.label6);
            this.IngresarProductor.Location = new System.Drawing.Point(339, 53);
            this.IngresarProductor.Name = "IngresarProductor";
            this.IngresarProductor.Size = new System.Drawing.Size(892, 281);
            this.IngresarProductor.TabIndex = 4;
            this.IngresarProductor.Visible = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(431, 203);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(70, 25);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "label7";
            this.LoginLabel.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(42, 203);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(203, 41);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Ingresar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginContraseña
            // 
            this.LoginContraseña.Location = new System.Drawing.Point(431, 109);
            this.LoginContraseña.Name = "LoginContraseña";
            this.LoginContraseña.Size = new System.Drawing.Size(200, 31);
            this.LoginContraseña.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // LoginMail
            // 
            this.LoginMail.Location = new System.Drawing.Point(45, 109);
            this.LoginMail.Name = "LoginMail";
            this.LoginMail.Size = new System.Drawing.Size(200, 31);
            this.LoginMail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mail";
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(53, 747);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(235, 60);
            this.CerrarSesion.TabIndex = 12;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Visible = false;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // ListaEventos
            // 
            this.ListaEventos.FormattingEnabled = true;
            this.ListaEventos.ItemHeight = 25;
            this.ListaEventos.Location = new System.Drawing.Point(0, 162);
            this.ListaEventos.Name = "ListaEventos";
            this.ListaEventos.Size = new System.Drawing.Size(892, 279);
            this.ListaEventos.TabIndex = 13;
            this.ListaEventos.DoubleClick += new System.EventHandler(this.ListaEventos_DoubleClick);
            // 
            // PanelEventos
            // 
            this.PanelEventos.Controls.Add(this.PanelCompra);
            this.PanelEventos.Controls.Add(this.ComprarEntrada);
            this.PanelEventos.Controls.Add(this.label7);
            this.PanelEventos.Controls.Add(this.ListaEventos);
            this.PanelEventos.Location = new System.Drawing.Point(339, 0);
            this.PanelEventos.Name = "PanelEventos";
            this.PanelEventos.Size = new System.Drawing.Size(892, 570);
            this.PanelEventos.TabIndex = 14;
            // 
            // PanelCompra
            // 
            this.PanelCompra.Controls.Add(this.DatosCompra);
            this.PanelCompra.Controls.Add(this.VolverAEventos);
            this.PanelCompra.Controls.Add(this.label10);
            this.PanelCompra.Controls.Add(this.label9);
            this.PanelCompra.Controls.Add(this.label8);
            this.PanelCompra.Controls.Add(this.CantidadEntradas);
            this.PanelCompra.Controls.Add(this.BtnTerminarCompra);
            this.PanelCompra.Controls.Add(this.BtnAgregarACompra);
            this.PanelCompra.Controls.Add(this.ListaTiposTicket);
            this.PanelCompra.Controls.Add(this.ListaFunciones);
            this.PanelCompra.Location = new System.Drawing.Point(0, 78);
            this.PanelCompra.Name = "PanelCompra";
            this.PanelCompra.Size = new System.Drawing.Size(892, 489);
            this.PanelCompra.TabIndex = 15;
            this.PanelCompra.Visible = false;
            // 
            // VolverAEventos
            // 
            this.VolverAEventos.Location = new System.Drawing.Point(0, 20);
            this.VolverAEventos.Name = "VolverAEventos";
            this.VolverAEventos.Size = new System.Drawing.Size(169, 39);
            this.VolverAEventos.TabIndex = 8;
            this.VolverAEventos.Text = "Volver";
            this.VolverAEventos.UseVisualStyleBackColor = true;
            this.VolverAEventos.Click += new System.EventHandler(this.VolverAEventos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tipos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Funciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad:";
            // 
            // CantidadEntradas
            // 
            this.CantidadEntradas.Location = new System.Drawing.Point(138, 434);
            this.CantidadEntradas.Name = "CantidadEntradas";
            this.CantidadEntradas.Size = new System.Drawing.Size(120, 31);
            this.CantidadEntradas.TabIndex = 4;
            this.CantidadEntradas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnTerminarCompra
            // 
            this.BtnTerminarCompra.Location = new System.Drawing.Point(633, 418);
            this.BtnTerminarCompra.Name = "BtnTerminarCompra";
            this.BtnTerminarCompra.Size = new System.Drawing.Size(256, 60);
            this.BtnTerminarCompra.TabIndex = 3;
            this.BtnTerminarCompra.Text = "Terminar Compra";
            this.BtnTerminarCompra.UseVisualStyleBackColor = true;
            this.BtnTerminarCompra.Click += new System.EventHandler(this.BtnTerminarCompra_Click);
            // 
            // BtnAgregarACompra
            // 
            this.BtnAgregarACompra.Location = new System.Drawing.Point(293, 418);
            this.BtnAgregarACompra.Name = "BtnAgregarACompra";
            this.BtnAgregarACompra.Size = new System.Drawing.Size(256, 60);
            this.BtnAgregarACompra.TabIndex = 2;
            this.BtnAgregarACompra.Text = "Agregar A Compra";
            this.BtnAgregarACompra.UseVisualStyleBackColor = true;
            this.BtnAgregarACompra.Click += new System.EventHandler(this.BtnAgregarACompra_Click);
            // 
            // ListaTiposTicket
            // 
            this.ListaTiposTicket.FormattingEnabled = true;
            this.ListaTiposTicket.ItemHeight = 25;
            this.ListaTiposTicket.Location = new System.Drawing.Point(0, 290);
            this.ListaTiposTicket.Name = "ListaTiposTicket";
            this.ListaTiposTicket.Size = new System.Drawing.Size(892, 79);
            this.ListaTiposTicket.TabIndex = 1;
            // 
            // ListaFunciones
            // 
            this.ListaFunciones.FormattingEnabled = true;
            this.ListaFunciones.ItemHeight = 25;
            this.ListaFunciones.Location = new System.Drawing.Point(0, 140);
            this.ListaFunciones.Name = "ListaFunciones";
            this.ListaFunciones.Size = new System.Drawing.Size(892, 79);
            this.ListaFunciones.TabIndex = 0;
            // 
            // ComprarEntrada
            // 
            this.ComprarEntrada.Location = new System.Drawing.Point(0, 480);
            this.ComprarEntrada.Name = "ComprarEntrada";
            this.ComprarEntrada.Size = new System.Drawing.Size(258, 60);
            this.ComprarEntrada.TabIndex = 15;
            this.ComprarEntrada.Text = "Comprar entradas";
            this.ComprarEntrada.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F);
            this.label7.Location = new System.Drawing.Point(343, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 57);
            this.label7.TabIndex = 14;
            this.label7.Text = "Eventos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DatosCompra
            // 
            this.DatosCompra.Controls.Add(this.PanelTickets);
            this.DatosCompra.Controls.Add(this.LabelErrorCompra);
            this.DatosCompra.Controls.Add(this.TerminarCompraFinal);
            this.DatosCompra.Controls.Add(this.CedulaCompra);
            this.DatosCompra.Controls.Add(this.ApellidoCompra);
            this.DatosCompra.Controls.Add(this.NombreCompra);
            this.DatosCompra.Controls.Add(this.label13);
            this.DatosCompra.Controls.Add(this.label12);
            this.DatosCompra.Controls.Add(this.label11);
            this.DatosCompra.Location = new System.Drawing.Point(0, 3);
            this.DatosCompra.Name = "DatosCompra";
            this.DatosCompra.Size = new System.Drawing.Size(892, 483);
            this.DatosCompra.TabIndex = 15;
            this.DatosCompra.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(304, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cedula (sin puntos ni guiones)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Apellido";
            // 
            // NombreCompra
            // 
            this.NombreCompra.Location = new System.Drawing.Point(31, 67);
            this.NombreCompra.Name = "NombreCompra";
            this.NombreCompra.Size = new System.Drawing.Size(198, 31);
            this.NombreCompra.TabIndex = 3;
            // 
            // ApellidoCompra
            // 
            this.ApellidoCompra.Location = new System.Drawing.Point(433, 67);
            this.ApellidoCompra.Name = "ApellidoCompra";
            this.ApellidoCompra.Size = new System.Drawing.Size(198, 31);
            this.ApellidoCompra.TabIndex = 4;
            // 
            // CedulaCompra
            // 
            this.CedulaCompra.Location = new System.Drawing.Point(30, 169);
            this.CedulaCompra.Name = "CedulaCompra";
            this.CedulaCompra.Size = new System.Drawing.Size(198, 31);
            this.CedulaCompra.TabIndex = 5;
            // 
            // TerminarCompraFinal
            // 
            this.TerminarCompraFinal.Location = new System.Drawing.Point(624, 413);
            this.TerminarCompraFinal.Name = "TerminarCompraFinal";
            this.TerminarCompraFinal.Size = new System.Drawing.Size(256, 60);
            this.TerminarCompraFinal.TabIndex = 16;
            this.TerminarCompraFinal.Text = "Terminar Compra";
            this.TerminarCompraFinal.UseVisualStyleBackColor = true;
            this.TerminarCompraFinal.Click += new System.EventHandler(this.TerminarCompraFinal_Click);
            // 
            // LabelErrorCompra
            // 
            this.LabelErrorCompra.AutoSize = true;
            this.LabelErrorCompra.Location = new System.Drawing.Point(25, 448);
            this.LabelErrorCompra.Name = "LabelErrorCompra";
            this.LabelErrorCompra.Size = new System.Drawing.Size(0, 25);
            this.LabelErrorCompra.TabIndex = 17;
            this.LabelErrorCompra.Visible = false;
            // 
            // PanelTickets
            // 
            this.PanelTickets.Controls.Add(this.VolverEventos);
            this.PanelTickets.Controls.Add(this.ListaTickets);
            this.PanelTickets.Controls.Add(this.LabelTickets);
            this.PanelTickets.Controls.Add(this.LabelGracias);
            this.PanelTickets.Location = new System.Drawing.Point(8, 3);
            this.PanelTickets.Name = "PanelTickets";
            this.PanelTickets.Size = new System.Drawing.Size(886, 486);
            this.PanelTickets.TabIndex = 15;
            this.PanelTickets.Visible = false;
            // 
            // LabelGracias
            // 
            this.LabelGracias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.875F);
            this.LabelGracias.Location = new System.Drawing.Point(23, 18);
            this.LabelGracias.Name = "LabelGracias";
            this.LabelGracias.Size = new System.Drawing.Size(837, 57);
            this.LabelGracias.TabIndex = 0;
            this.LabelGracias.Text = "Gracias por tu compra!";
            this.LabelGracias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelTickets
            // 
            this.LabelTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.LabelTickets.Location = new System.Drawing.Point(216, 78);
            this.LabelTickets.Name = "LabelTickets";
            this.LabelTickets.Size = new System.Drawing.Size(436, 146);
            this.LabelTickets.TabIndex = 1;
            this.LabelTickets.Text = "Tickets:";
            this.LabelTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListaTickets
            // 
            this.ListaTickets.Location = new System.Drawing.Point(211, 179);
            this.ListaTickets.Name = "ListaTickets";
            this.ListaTickets.Size = new System.Drawing.Size(441, 280);
            this.ListaTickets.TabIndex = 2;
            this.ListaTickets.Text = "label16";
            this.ListaTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ListaTickets.Visible = false;
            // 
            // VolverEventos
            // 
            this.VolverEventos.Location = new System.Drawing.Point(4, 412);
            this.VolverEventos.Name = "VolverEventos";
            this.VolverEventos.Size = new System.Drawing.Size(187, 59);
            this.VolverEventos.TabIndex = 3;
            this.VolverEventos.Text = "Volver";
            this.VolverEventos.UseVisualStyleBackColor = true;
            this.VolverEventos.Click += new System.EventHandler(this.VolverEventos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1044);
            this.Controls.Add(this.PanelEventos);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.HolaProductor);
            this.Controls.Add(this.CrearProductor);
            this.Controls.Add(this.EntrarProductor);
            this.Controls.Add(this.IngresarProductor);
            this.Controls.Add(this.RegistrarProductor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RegistrarProductor.ResumeLayout(false);
            this.RegistrarProductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.IngresarProductor.ResumeLayout(false);
            this.IngresarProductor.PerformLayout();
            this.PanelEventos.ResumeLayout(false);
            this.PanelCompra.ResumeLayout(false);
            this.PanelCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEntradas)).EndInit();
            this.DatosCompra.ResumeLayout(false);
            this.DatosCompra.PerformLayout();
            this.PanelTickets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntrarProductor;
        private System.Windows.Forms.Panel RegistrarProductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CrearProductor;
        private System.Windows.Forms.Button BtnCrearProductor;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label HolaProductor;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel IngresarProductor;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox LoginContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.ListBox ListaEventos;
        private System.Windows.Forms.Panel PanelEventos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelCompra;
        private System.Windows.Forms.ListBox ListaFunciones;
        private System.Windows.Forms.Button ComprarEntrada;
        private System.Windows.Forms.Button BtnTerminarCompra;
        private System.Windows.Forms.Button BtnAgregarACompra;
        private System.Windows.Forms.ListBox ListaTiposTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CantidadEntradas;
        private System.Windows.Forms.Button VolverAEventos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel DatosCompra;
        private System.Windows.Forms.Button TerminarCompraFinal;
        private System.Windows.Forms.TextBox CedulaCompra;
        private System.Windows.Forms.TextBox ApellidoCompra;
        private System.Windows.Forms.TextBox NombreCompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelErrorCompra;
        private System.Windows.Forms.Panel PanelTickets;
        private System.Windows.Forms.Label ListaTickets;
        private System.Windows.Forms.Label LabelTickets;
        private System.Windows.Forms.Label LabelGracias;
        private System.Windows.Forms.Button VolverEventos;
    }
}

