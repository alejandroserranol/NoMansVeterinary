namespace NoMansVeterinary
{
    partial class DatosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosCliente));
            this.usuario_lab = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario_lab
            // 
            this.usuario_lab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario_lab.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario_lab.Location = new System.Drawing.Point(158, 87);
            this.usuario_lab.Name = "usuario_lab";
            this.usuario_lab.Size = new System.Drawing.Size(719, 54);
            this.usuario_lab.TabIndex = 47;
            this.usuario_lab.Text = "Datos De Los Clientes De La Empresa";
            this.usuario_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(176, 188);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(684, 323);
            this.dataGridViewClientes.TabIndex = 46;
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NoMansVeterinary.Properties.Resources.marco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 628);
            this.Controls.Add(this.usuario_lab);
            this.Controls.Add(this.dataGridViewClientes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosCliente";
            this.Text = "DatosCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usuario_lab;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}