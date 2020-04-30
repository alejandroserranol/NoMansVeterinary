namespace NoMansVeterinary
{
    partial class DatosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosUsuarios));
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.usuario_lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(146, 179);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(713, 323);
            this.dataGridViewUsuarios.TabIndex = 1;
            // 
            // usuario_lab
            // 
            this.usuario_lab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario_lab.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario_lab.Location = new System.Drawing.Point(140, 78);
            this.usuario_lab.Name = "usuario_lab";
            this.usuario_lab.Size = new System.Drawing.Size(719, 54);
            this.usuario_lab.TabIndex = 45;
            this.usuario_lab.Text = "Datos De Los Trabajadores De La Empresa";
            this.usuario_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 624);
            this.Controls.Add(this.usuario_lab);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DatosUsuarios";
            this.Text = "DatosUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label usuario_lab;
    }
}