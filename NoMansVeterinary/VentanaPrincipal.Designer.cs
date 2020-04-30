namespace NoMansVeterinary
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.fecha_citaBox = new System.Windows.Forms.TextBox();
            this.usuarioCitaBox = new System.Windows.Forms.TextBox();
            this.nombre_mascotaCitaBox = new System.Windows.Forms.TextBox();
            this.clienteCitaBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insertaCita = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNM = new System.Windows.Forms.Label();
            this.clientCitaLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCitas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.usuarios = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario_lab = new System.Windows.Forms.Label();
            this.departamentoCheck = new System.Windows.Forms.CheckBox();
            this.telefonoCheck = new System.Windows.Forms.CheckBox();
            this.emailCheck = new System.Windows.Forms.CheckBox();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.apellidoCheck = new System.Windows.Forms.CheckBox();
            this.nombreCheck = new System.Windows.Forms.CheckBox();
            this.muestraDatosUsuario = new System.Windows.Forms.Button();
            this.nuevoUsuario = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.muestraDatosCliente = new System.Windows.Forms.Button();
            this.fecha_nacimientoCheck = new System.Windows.Forms.CheckBox();
            this.telefonoClienteCheck = new System.Windows.Forms.CheckBox();
            this.direccionClienteChecxk = new System.Windows.Forms.CheckBox();
            this.emailClienteCheck = new System.Windows.Forms.CheckBox();
            this.apellidoClienteCheck = new System.Windows.Forms.CheckBox();
            this.nombreClienteCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nuevoCliente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewAlmacen = new System.Windows.Forms.DataGridView();
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.cod_productoBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.actualizaStock = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).BeginInit();
            this.usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "caduceus.ico");
            this.imageList1.Images.SetKeyName(1, "clinic.ico");
            this.imageList1.Images.SetKeyName(2, "footprint.ico");
            this.imageList1.Images.SetKeyName(3, "plus.ico");
            this.imageList1.Images.SetKeyName(4, "user.ico");
            this.imageList1.Images.SetKeyName(5, "wolf.ico");
            this.imageList1.Images.SetKeyName(6, "icons8_medical_doctor_1.ico");
            this.imageList1.Images.SetKeyName(7, "icons8_shop.ico");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.home);
            this.tabControl1.Controls.Add(this.usuarios);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco5;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.home.Controls.Add(this.fecha_citaBox);
            this.home.Controls.Add(this.usuarioCitaBox);
            this.home.Controls.Add(this.nombre_mascotaCitaBox);
            this.home.Controls.Add(this.clienteCitaBox);
            this.home.Controls.Add(this.label5);
            this.home.Controls.Add(this.insertaCita);
            this.home.Controls.Add(this.label4);
            this.home.Controls.Add(this.labelNM);
            this.home.Controls.Add(this.clientCitaLabel);
            this.home.Controls.Add(this.label3);
            this.home.Controls.Add(this.dataGridViewCitas);
            this.home.Controls.Add(this.label2);
            this.home.Controls.Add(this.monthCalendar1);
            this.home.ImageIndex = 1;
            this.home.Location = new System.Drawing.Point(4, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1165, 690);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // fecha_citaBox
            // 
            this.fecha_citaBox.Location = new System.Drawing.Point(327, 572);
            this.fecha_citaBox.Name = "fecha_citaBox";
            this.fecha_citaBox.Size = new System.Drawing.Size(354, 30);
            this.fecha_citaBox.TabIndex = 58;
            // 
            // usuarioCitaBox
            // 
            this.usuarioCitaBox.Location = new System.Drawing.Point(327, 461);
            this.usuarioCitaBox.Name = "usuarioCitaBox";
            this.usuarioCitaBox.Size = new System.Drawing.Size(354, 30);
            this.usuarioCitaBox.TabIndex = 55;
            // 
            // nombre_mascotaCitaBox
            // 
            this.nombre_mascotaCitaBox.Location = new System.Drawing.Point(327, 536);
            this.nombre_mascotaCitaBox.Name = "nombre_mascotaCitaBox";
            this.nombre_mascotaCitaBox.Size = new System.Drawing.Size(354, 30);
            this.nombre_mascotaCitaBox.TabIndex = 53;
            // 
            // clienteCitaBox
            // 
            this.clienteCitaBox.Location = new System.Drawing.Point(327, 497);
            this.clienteCitaBox.Name = "clienteCitaBox";
            this.clienteCitaBox.Size = new System.Drawing.Size(354, 30);
            this.clienteCitaBox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fecha Cita";
            // 
            // insertaCita
            // 
            this.insertaCita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertaCita.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaCita.Location = new System.Drawing.Point(736, 461);
            this.insertaCita.Name = "insertaCita";
            this.insertaCita.Size = new System.Drawing.Size(284, 141);
            this.insertaCita.TabIndex = 56;
            this.insertaCita.Text = "INSERTA CITA";
            this.insertaCita.UseVisualStyleBackColor = false;
            this.insertaCita.Click += new System.EventHandler(this.insertaCita_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "Usuario";
            // 
            // labelNM
            // 
            this.labelNM.AutoSize = true;
            this.labelNM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNM.Location = new System.Drawing.Point(171, 539);
            this.labelNM.Name = "labelNM";
            this.labelNM.Size = new System.Drawing.Size(150, 22);
            this.labelNM.TabIndex = 52;
            this.labelNM.Text = "Nombre Mascota";
            // 
            // clientCitaLabel
            // 
            this.clientCitaLabel.AutoSize = true;
            this.clientCitaLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCitaLabel.Location = new System.Drawing.Point(171, 500);
            this.clientCitaLabel.Name = "clientCitaLabel";
            this.clientCitaLabel.Size = new System.Drawing.Size(80, 22);
            this.clientCitaLabel.TabIndex = 50;
            this.clientCitaLabel.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(174, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(846, 54);
            this.label3.TabIndex = 49;
            this.label3.Text = "Añadir Nueva Cita";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCitas
            // 
            this.dataGridViewCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCitas.Location = new System.Drawing.Point(174, 196);
            this.dataGridViewCitas.Name = "dataGridViewCitas";
            this.dataGridViewCitas.Size = new System.Drawing.Size(564, 160);
            this.dataGridViewCitas.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(174, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(846, 54);
            this.label2.TabIndex = 47;
            this.label2.Text = "Próximas citas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(828, 196);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // usuarios
            // 
            this.usuarios.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco3;
            this.usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usuarios.Controls.Add(this.pictureBox1);
            this.usuarios.Controls.Add(this.label1);
            this.usuarios.Controls.Add(this.usuario_lab);
            this.usuarios.Controls.Add(this.departamentoCheck);
            this.usuarios.Controls.Add(this.telefonoCheck);
            this.usuarios.Controls.Add(this.emailCheck);
            this.usuarios.Controls.Add(this.passCheck);
            this.usuarios.Controls.Add(this.apellidoCheck);
            this.usuarios.Controls.Add(this.nombreCheck);
            this.usuarios.Controls.Add(this.muestraDatosUsuario);
            this.usuarios.Controls.Add(this.nuevoUsuario);
            this.usuarios.ImageIndex = 6;
            this.usuarios.Location = new System.Drawing.Point(4, 39);
            this.usuarios.Name = "usuarios";
            this.usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.usuarios.Size = new System.Drawing.Size(1165, 690);
            this.usuarios.TabIndex = 1;
            this.usuarios.Text = "Usuarios";
            this.usuarios.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::NoMansVeterinary.Properties.Resources.Medico_icono_mujer;
            this.pictureBox1.Location = new System.Drawing.Point(175, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(505, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 54);
            this.label1.TabIndex = 46;
            this.label1.Text = "Insertar nuevo usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuario_lab
            // 
            this.usuario_lab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario_lab.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario_lab.Location = new System.Drawing.Point(169, 437);
            this.usuario_lab.Name = "usuario_lab";
            this.usuario_lab.Size = new System.Drawing.Size(823, 54);
            this.usuario_lab.TabIndex = 45;
            this.usuario_lab.Text = "Seleccionar datos de los empleados a mostrar";
            this.usuario_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departamentoCheck
            // 
            this.departamentoCheck.AutoSize = true;
            this.departamentoCheck.Location = new System.Drawing.Point(350, 570);
            this.departamentoCheck.Name = "departamentoCheck";
            this.departamentoCheck.Size = new System.Drawing.Size(149, 26);
            this.departamentoCheck.TabIndex = 8;
            this.departamentoCheck.Text = "Departamento";
            this.departamentoCheck.UseVisualStyleBackColor = true;
            // 
            // telefonoCheck
            // 
            this.telefonoCheck.AutoSize = true;
            this.telefonoCheck.Location = new System.Drawing.Point(350, 538);
            this.telefonoCheck.Name = "telefonoCheck";
            this.telefonoCheck.Size = new System.Drawing.Size(109, 26);
            this.telefonoCheck.TabIndex = 7;
            this.telefonoCheck.Text = "Teléfono";
            this.telefonoCheck.UseVisualStyleBackColor = true;
            // 
            // emailCheck
            // 
            this.emailCheck.AutoSize = true;
            this.emailCheck.Location = new System.Drawing.Point(350, 506);
            this.emailCheck.Name = "emailCheck";
            this.emailCheck.Size = new System.Drawing.Size(79, 26);
            this.emailCheck.TabIndex = 6;
            this.emailCheck.Text = "Email";
            this.emailCheck.UseVisualStyleBackColor = true;
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(235, 570);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(69, 26);
            this.passCheck.TabIndex = 5;
            this.passCheck.Text = "Pass";
            this.passCheck.UseVisualStyleBackColor = true;
            // 
            // apellidoCheck
            // 
            this.apellidoCheck.AutoSize = true;
            this.apellidoCheck.Location = new System.Drawing.Point(235, 538);
            this.apellidoCheck.Name = "apellidoCheck";
            this.apellidoCheck.Size = new System.Drawing.Size(109, 26);
            this.apellidoCheck.TabIndex = 4;
            this.apellidoCheck.Text = "Apellido";
            this.apellidoCheck.UseVisualStyleBackColor = true;
            // 
            // nombreCheck
            // 
            this.nombreCheck.AutoSize = true;
            this.nombreCheck.Location = new System.Drawing.Point(235, 506);
            this.nombreCheck.Name = "nombreCheck";
            this.nombreCheck.Size = new System.Drawing.Size(89, 26);
            this.nombreCheck.TabIndex = 3;
            this.nombreCheck.Text = "Nombre";
            this.nombreCheck.UseVisualStyleBackColor = true;
            // 
            // muestraDatosUsuario
            // 
            this.muestraDatosUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.muestraDatosUsuario.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestraDatosUsuario.Location = new System.Drawing.Point(575, 506);
            this.muestraDatosUsuario.Name = "muestraDatosUsuario";
            this.muestraDatosUsuario.Size = new System.Drawing.Size(337, 90);
            this.muestraDatosUsuario.TabIndex = 2;
            this.muestraDatosUsuario.Text = "Datos Usuarios";
            this.muestraDatosUsuario.UseVisualStyleBackColor = false;
            this.muestraDatosUsuario.Click += new System.EventHandler(this.muestraDatosUsuario_Click);
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nuevoUsuario.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoUsuario.Location = new System.Drawing.Point(575, 205);
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Size = new System.Drawing.Size(337, 194);
            this.nuevoUsuario.TabIndex = 1;
            this.nuevoUsuario.Text = "Nuevo Usuario";
            this.nuevoUsuario.UseVisualStyleBackColor = false;
            this.nuevoUsuario.Click += new System.EventHandler(this.nuevoUsuario_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco6;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.muestraDatosCliente);
            this.tabPage1.Controls.Add(this.fecha_nacimientoCheck);
            this.tabPage1.Controls.Add(this.telefonoClienteCheck);
            this.tabPage1.Controls.Add(this.direccionClienteChecxk);
            this.tabPage1.Controls.Add(this.emailClienteCheck);
            this.tabPage1.Controls.Add(this.apellidoClienteCheck);
            this.tabPage1.Controls.Add(this.nombreClienteCheck);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nuevoCliente);
            this.tabPage1.ImageIndex = 5;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 690);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // muestraDatosCliente
            // 
            this.muestraDatosCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.muestraDatosCliente.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestraDatosCliente.Location = new System.Drawing.Point(627, 380);
            this.muestraDatosCliente.Name = "muestraDatosCliente";
            this.muestraDatosCliente.Size = new System.Drawing.Size(304, 90);
            this.muestraDatosCliente.TabIndex = 3;
            this.muestraDatosCliente.Text = "Datos Clientes";
            this.muestraDatosCliente.UseVisualStyleBackColor = false;
            this.muestraDatosCliente.Click += new System.EventHandler(this.muestraDatosCliente_Click);
            // 
            // fecha_nacimientoCheck
            // 
            this.fecha_nacimientoCheck.AutoSize = true;
            this.fecha_nacimientoCheck.Location = new System.Drawing.Point(742, 323);
            this.fecha_nacimientoCheck.Name = "fecha_nacimientoCheck";
            this.fecha_nacimientoCheck.Size = new System.Drawing.Size(189, 26);
            this.fecha_nacimientoCheck.TabIndex = 55;
            this.fecha_nacimientoCheck.Text = "Fecha nacimiento";
            this.fecha_nacimientoCheck.UseVisualStyleBackColor = true;
            // 
            // telefonoClienteCheck
            // 
            this.telefonoClienteCheck.AutoSize = true;
            this.telefonoClienteCheck.Location = new System.Drawing.Point(742, 259);
            this.telefonoClienteCheck.Name = "telefonoClienteCheck";
            this.telefonoClienteCheck.Size = new System.Drawing.Size(109, 26);
            this.telefonoClienteCheck.TabIndex = 54;
            this.telefonoClienteCheck.Text = "Teléfono";
            this.telefonoClienteCheck.UseVisualStyleBackColor = true;
            // 
            // direccionClienteChecxk
            // 
            this.direccionClienteChecxk.AutoSize = true;
            this.direccionClienteChecxk.Location = new System.Drawing.Point(742, 291);
            this.direccionClienteChecxk.Name = "direccionClienteChecxk";
            this.direccionClienteChecxk.Size = new System.Drawing.Size(119, 26);
            this.direccionClienteChecxk.TabIndex = 53;
            this.direccionClienteChecxk.Text = "Dirección";
            this.direccionClienteChecxk.UseVisualStyleBackColor = true;
            // 
            // emailClienteCheck
            // 
            this.emailClienteCheck.AutoSize = true;
            this.emailClienteCheck.Location = new System.Drawing.Point(627, 323);
            this.emailClienteCheck.Name = "emailClienteCheck";
            this.emailClienteCheck.Size = new System.Drawing.Size(79, 26);
            this.emailClienteCheck.TabIndex = 52;
            this.emailClienteCheck.Text = "Email";
            this.emailClienteCheck.UseVisualStyleBackColor = true;
            // 
            // apellidoClienteCheck
            // 
            this.apellidoClienteCheck.AutoSize = true;
            this.apellidoClienteCheck.Location = new System.Drawing.Point(627, 291);
            this.apellidoClienteCheck.Name = "apellidoClienteCheck";
            this.apellidoClienteCheck.Size = new System.Drawing.Size(109, 26);
            this.apellidoClienteCheck.TabIndex = 51;
            this.apellidoClienteCheck.Text = "Apellido";
            this.apellidoClienteCheck.UseVisualStyleBackColor = true;
            // 
            // nombreClienteCheck
            // 
            this.nombreClienteCheck.AutoSize = true;
            this.nombreClienteCheck.Location = new System.Drawing.Point(627, 259);
            this.nombreClienteCheck.Name = "nombreClienteCheck";
            this.nombreClienteCheck.Size = new System.Drawing.Size(89, 26);
            this.nombreClienteCheck.TabIndex = 50;
            this.nombreClienteCheck.Text = "Nombre";
            this.nombreClienteCheck.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(573, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 54);
            this.label7.TabIndex = 49;
            this.label7.Text = "Seleccionar Datos Clientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(180, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 54);
            this.label6.TabIndex = 48;
            this.label6.Text = "Insertar Nuevo Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nuevoCliente
            // 
            this.nuevoCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nuevoCliente.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCliente.Location = new System.Drawing.Point(243, 276);
            this.nuevoCliente.Name = "nuevoCliente";
            this.nuevoCliente.Size = new System.Drawing.Size(214, 194);
            this.nuevoCliente.TabIndex = 47;
            this.nuevoCliente.Text = "Nuevo Cliente";
            this.nuevoCliente.UseVisualStyleBackColor = false;
            this.nuevoCliente.Click += new System.EventHandler(this.nuevoCliente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco8;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.actualizaStock);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cod_productoBox);
            this.tabPage2.Controls.Add(this.cantidadBox);
            this.tabPage2.Controls.Add(this.dataGridViewAlmacen);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.ImageIndex = 7;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 690);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Tienda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(332, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(537, 54);
            this.label8.TabIndex = 48;
            this.label8.Text = "Productoss En Venta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAlmacen
            // 
            this.dataGridViewAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlmacen.Location = new System.Drawing.Point(338, 247);
            this.dataGridViewAlmacen.Name = "dataGridViewAlmacen";
            this.dataGridViewAlmacen.Size = new System.Drawing.Size(526, 178);
            this.dataGridViewAlmacen.TabIndex = 49;
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(404, 554);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(236, 30);
            this.cantidadBox.TabIndex = 57;
            // 
            // cod_productoBox
            // 
            this.cod_productoBox.Location = new System.Drawing.Point(404, 518);
            this.cod_productoBox.Name = "cod_productoBox";
            this.cod_productoBox.Size = new System.Drawing.Size(236, 30);
            this.cod_productoBox.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(332, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(537, 54);
            this.label9.TabIndex = 59;
            this.label9.Text = "Actualiza Cantidad DLC";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(318, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 30);
            this.label10.TabIndex = 60;
            this.label10.Text = "Código";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(307, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 30);
            this.label11.TabIndex = 61;
            this.label11.Text = "Cantidad";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualizaStock
            // 
            this.actualizaStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actualizaStock.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizaStock.Location = new System.Drawing.Point(651, 517);
            this.actualizaStock.Name = "actualizaStock";
            this.actualizaStock.Size = new System.Drawing.Size(218, 69);
            this.actualizaStock.TabIndex = 62;
            this.actualizaStock.Text = "Actualizar";
            this.actualizaStock.UseVisualStyleBackColor = false;
            this.actualizaStock.Click += new System.EventHandler(this.actualizaStock_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 733);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).EndInit();
            this.usuarios.ResumeLayout(false);
            this.usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button muestraDatosCliente;
        private System.Windows.Forms.CheckBox fecha_nacimientoCheck;
        private System.Windows.Forms.CheckBox telefonoClienteCheck;
        private System.Windows.Forms.CheckBox direccionClienteChecxk;
        private System.Windows.Forms.CheckBox emailClienteCheck;
        private System.Windows.Forms.CheckBox apellidoClienteCheck;
        private System.Windows.Forms.CheckBox nombreClienteCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nuevoCliente;
        private System.Windows.Forms.TabPage usuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario_lab;
        private System.Windows.Forms.CheckBox departamentoCheck;
        private System.Windows.Forms.CheckBox telefonoCheck;
        private System.Windows.Forms.CheckBox emailCheck;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.CheckBox apellidoCheck;
        private System.Windows.Forms.CheckBox nombreCheck;
        private System.Windows.Forms.Button muestraDatosUsuario;
        private System.Windows.Forms.Button nuevoUsuario;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TextBox fecha_citaBox;
        private System.Windows.Forms.TextBox usuarioCitaBox;
        private System.Windows.Forms.TextBox nombre_mascotaCitaBox;
        private System.Windows.Forms.TextBox clienteCitaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insertaCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNM;
        private System.Windows.Forms.Label clientCitaLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewAlmacen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cod_productoBox;
        private System.Windows.Forms.TextBox cantidadBox;
        private System.Windows.Forms.Button actualizaStock;
    }
}