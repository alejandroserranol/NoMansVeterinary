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
    public partial class VentanaPrincipal : Form
    {
        MD5 mD5 = MD5.Create();
        Conexion conexion = new Conexion();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void insertaUsuatio_Click(object sender, EventArgs e)
        {
            byte[] b = Encoding.ASCII.GetBytes(passBox.Text);
            byte[] hash = mD5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));

            conexion.insertaUsario(dniBox.Text, nombreBox.Text, apellidosBox.Text, sb.ToString(), emailBox.Text, telBox.Text, depBox.Text);
        }



        //Método para cerrar la aplicación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

     
    }
}
