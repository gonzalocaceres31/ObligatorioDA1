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
            this.RegistrarProductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.IngresarProductor.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 852);
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
    }
}

