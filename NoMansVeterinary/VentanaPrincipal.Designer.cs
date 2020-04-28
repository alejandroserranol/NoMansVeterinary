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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.nuevoUsuario = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
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
            this.home.Size = new System.Drawing.Size(1032, 686);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // usuarios
            // 
            this.usuarios.Controls.Add(this.nuevoUsuario);
            this.usuarios.Controls.Add(this.dataGridViewUsuarios);
            this.usuarios.ImageIndex = 4;
            this.usuarios.Location = new System.Drawing.Point(4, 39);
            this.usuarios.Name = "usuarios";
            this.usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.usuarios.Size = new System.Drawing.Size(1032, 686);
            this.usuarios.TabIndex = 1;
            this.usuarios.Text = "Usuarios";
            this.usuarios.UseVisualStyleBackColor = true;
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
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(8, 99);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1018, 404);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.Location = new System.Drawing.Point(275, 569);
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Size = new System.Drawing.Size(471, 58);
            this.nuevoUsuario.TabIndex = 1;
            this.nuevoUsuario.Text = "Nuevo Usuario";
            this.nuevoUsuario.UseVisualStyleBackColor = true;
            this.nuevoUsuario.Click += new System.EventHandler(this.nuevoUsuario_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage usuarios;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button nuevoUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
    }
}