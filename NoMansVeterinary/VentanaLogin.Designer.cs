namespace NoMansVeterinary
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.pass_lab = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userPassBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.usuario_lab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pass_lab
            // 
            this.pass_lab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pass_lab.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.pass_lab.Location = new System.Drawing.Point(63, 457);
            this.pass_lab.Name = "pass_lab";
            this.pass_lab.Size = new System.Drawing.Size(343, 23);
            this.pass_lab.TabIndex = 10;
            this.pass_lab.Text = "CONTRASEÑA";
            this.pass_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(63, 524);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(343, 59);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "INICIAR SESIÓN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userPassBox
            // 
            this.userPassBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.userPassBox.Location = new System.Drawing.Point(63, 483);
            this.userPassBox.Name = "userPassBox";
            this.userPassBox.Size = new System.Drawing.Size(343, 30);
            this.userPassBox.TabIndex = 8;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.userBox.Location = new System.Drawing.Point(63, 424);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(343, 30);
            this.userBox.TabIndex = 7;
            // 
            // usuario_lab
            // 
            this.usuario_lab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario_lab.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario_lab.Location = new System.Drawing.Point(63, 398);
            this.usuario_lab.Name = "usuario_lab";
            this.usuario_lab.Size = new System.Drawing.Size(343, 23);
            this.usuario_lab.TabIndex = 6;
            this.usuario_lab.Text = "USUARIO";
            this.usuario_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoMansVeterinary.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(101, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(47, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 213);
            this.label1.TabIndex = 12;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 663);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass_lab);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPassBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.usuario_lab);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pass_lab;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userPassBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label usuario_lab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

