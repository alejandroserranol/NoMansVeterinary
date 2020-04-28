using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace NoMansVeterinary
{
    public partial class InsertaUsuario : Form
    {
        Conexion conexion = new Conexion();
        public InsertaUsuario()
        {
            InitializeComponent();
        }

        private void insertaUsuatio_Click(object sender, EventArgs e)
        {
            String textoPassword = passBox.Text;
            String myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            conexion.insertaUsario(idBox.Text, dniBox.Text, nombreBox.Text, apellidoBox.Text, myHash, emailBox.Text, telefonoBox.Text, tipo_usuarioBox.Text);
        }

    }
}
