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
    public partial class InsertaCliente : Form
    {
        Conexion conexion = new Conexion();
        public InsertaCliente()
        {
            InitializeComponent();
        }

        private void insertaNuevoCliente_Click(object sender, EventArgs e)
        {
            conexion.InsertaCliente(dniClienteBox.Text, nombreClieenteBox.Text, apellidoClienteBox.Text, emailClienteBox.Text, telefonoClienteBox.Text, dniClienteBox.Text, DateTime.Parse(fecha_nacimientoClienteBox.Text));
        }
    }
}
