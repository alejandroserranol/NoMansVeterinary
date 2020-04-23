using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NoMansVeterinary
{
    public partial class VentanaLogin : Form
    {
        MD5 mD5 = MD5.Create();
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            byte[] b = Encoding.ASCII.GetBytes(userPassBox.Text);
            byte[] hash = mD5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));
           


            if(conexion.loginVeterinario(userBox.Text, sb.ToString()))
            { 
            this.Hide();
            VentanaPrincipal v = new VentanaPrincipal();
            v.Show();
            }
        }
    }
}
