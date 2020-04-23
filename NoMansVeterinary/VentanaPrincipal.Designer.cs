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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.usuarios = new System.Windows.Forms.TabPage();
            this.insertaUsuatio = new System.Windows.Forms.Button();
            this.depBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apellidosBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.home);
            this.tabControl1.Controls.Add(this.usuarios);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.ImageIndex = 1;
            this.home.Location = new System.Drawing.Point(4, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1226, 686);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // usuarios
            // 
            this.usuarios.Controls.Add(this.insertaUsuatio);
            this.usuarios.Controls.Add(this.depBox);
            this.usuarios.Controls.Add(this.label9);
            this.usuarios.Controls.Add(this.telBox);
            this.usuarios.Controls.Add(this.label8);
            this.usuarios.Controls.Add(this.emailBox);
            this.usuarios.Controls.Add(this.label7);
            this.usuarios.Controls.Add(this.passBox);
            this.usuarios.Controls.Add(this.label6);
            this.usuarios.Controls.Add(this.apellidosBox);
            this.usuarios.Controls.Add(this.label5);
            this.usuarios.Controls.Add(this.nombreBox);
            this.usuarios.Controls.Add(this.label4);
            this.usuarios.Controls.Add(this.dniBox);
            this.usuarios.Controls.Add(this.label3);
            this.usuarios.ImageIndex = 3;
            this.usuarios.Location = new System.Drawing.Point(4, 39);
            this.usuarios.Name = "usuarios";
            this.usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.usuarios.Size = new System.Drawing.Size(1032, 686);
            this.usuarios.TabIndex = 1;
            this.usuarios.Text = "Usuarios";
            this.usuarios.UseVisualStyleBackColor = true;
            // 
            // insertaUsuatio
            // 
            this.insertaUsuatio.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaUsuatio.Location = new System.Drawing.Point(161, 421);
            this.insertaUsuatio.Name = "insertaUsuatio";
            this.insertaUsuatio.Size = new System.Drawing.Size(684, 68);
            this.insertaUsuatio.TabIndex = 16;
            this.insertaUsuatio.Text = "INSERTA USUARIO";
            this.insertaUsuatio.UseVisualStyleBackColor = true;
            this.insertaUsuatio.Click += new System.EventHandler(this.insertaUsuatio_Click);
            // 
            // depBox
            // 
            this.depBox.Location = new System.Drawing.Point(293, 352);
            this.depBox.Name = "depBox";
            this.depBox.Size = new System.Drawing.Size(553, 30);
            this.depBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Departamento";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(293, 316);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(553, 30);
            this.telBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Teléfono";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(293, 280);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(553, 30);
            this.emailBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(293, 244);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(553, 30);
            this.passBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contraseña";
            // 
            // apellidosBox
            // 
            this.apellidosBox.Location = new System.Drawing.Point(293, 211);
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Size = new System.Drawing.Size(553, 30);
            this.apellidosBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellidos";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(293, 172);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(553, 30);
            this.nombreBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(293, 139);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(553, 30);
            this.dniBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
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
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.usuarios.ResumeLayout(false);
            this.usuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage usuarios;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox apellidosBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox depBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button insertaUsuatio;
    }
}