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
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridViewUsuarios.DataSource = conexion.getTodosUsuarios();
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }



        //Método para cerrar la aplicación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void nuevoUsuario_Click(object sender, EventArgs e)
        {
            InsertaUsuario u = new InsertaUsuario();
            u.Show();
        }
    }
}
