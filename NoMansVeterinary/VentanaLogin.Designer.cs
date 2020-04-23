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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pass_lab
            // 
            this.pass_lab.Location = new System.Drawing.Point(75, 301);
            this.pass_lab.Name = "pass_lab";
            this.pass_lab.Size = new System.Drawing.Size(226, 23);
            this.pass_lab.TabIndex = 10;
            this.pass_lab.Text = "CONTRASEÑA";
            this.pass_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(75, 367);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(226, 59);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "INICIAR SESIÓN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userPassBox
            // 
            this.userPassBox.Location = new System.Drawing.Point(75, 327);
            this.userPassBox.Name = "userPassBox";
            this.userPassBox.Size = new System.Drawing.Size(226, 20);
            this.userPassBox.TabIndex = 8;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(75, 278);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(226, 20);
            this.userBox.TabIndex = 7;
            // 
            // usuario_lab
            // 
            this.usuario_lab.Location = new System.Drawing.Point(75, 252);
            this.usuario_lab.Name = "usuario_lab";
            this.usuario_lab.Size = new System.Drawing.Size(226, 23);
            this.usuario_lab.TabIndex = 6;
            this.usuario_lab.Text = "USUARIO";
            this.usuario_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoMansVeterinary.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass_lab);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPassBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.usuario_lab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
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
    }
}

