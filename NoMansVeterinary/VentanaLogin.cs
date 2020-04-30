using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMansVeterinary
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal v = new VentanaPrincipal();
            v.Show();

            if (conexion.LoginVeterinario(userBox.Text, userPassBox.Text))
            {
                //this.Hide();
                //VentanaPrincipal v = new VentanaPrincipal();
                //v.Show();
            }
        }
    }
}
