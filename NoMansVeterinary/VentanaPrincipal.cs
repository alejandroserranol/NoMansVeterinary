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

        List<string> infoUsuarios = new List<string>();
        public string datosRequeridos = "";

        List<string> infoClientes = new List<string>();
        public string datosRequeridosClientes = "";


        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridViewCitas.DataSource = conexion.GetTodasCitas();
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridViewAlmacen.DataSource = conexion.GetProductosAlmacen();
            dataGridViewAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAlmacen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void nuevoUsuario_Click(object sender, EventArgs e)
        {
            InsertaUsuario u = new InsertaUsuario();
            u.Show();
        }

        private void muestraDatosUsuario_Click(object sender, EventArgs e)
        {
            if (nombreCheck.Checked) { infoUsuarios.Add("nombre"); }
            if (apellidoCheck.Checked) { infoUsuarios.Add("apellido"); }
            if (passCheck.Checked) { infoUsuarios.Add("pass"); }
            if (emailCheck.Checked) { infoUsuarios.Add("email"); }
            if (telefonoCheck.Checked) { infoUsuarios.Add("telefono"); }
            if (departamentoCheck.Checked) { infoUsuarios.Add("departamento"); }

            foreach (string dato in infoUsuarios)
            {
                datosRequeridos += (", " + dato);
            }


            

            DatosUsuarios du = new DatosUsuarios(datosRequeridos);
            du.Show();
        }

        private void muestraDatosCliente_Click(object sender, EventArgs e)
        {
            if (nombreClienteCheck.Checked) { infoUsuarios.Add("nombre"); }
            if (apellidoClienteCheck.Checked) { infoUsuarios.Add("apellido"); }
            if (emailClienteCheck.Checked) { infoUsuarios.Add("email"); }
            if (telefonoClienteCheck.Checked) { infoUsuarios.Add("telefono"); }
            if (direccionClienteChecxk.Checked) { infoUsuarios.Add("direccion"); }
            if (fecha_nacimientoCheck.Checked) { infoUsuarios.Add("fecha_nacimiento"); }

            foreach (string dato in infoUsuarios)
            {
                datosRequeridosClientes += (", " + dato);
            }

            DatosCliente dc = new DatosCliente(datosRequeridosClientes);
            dc.Show();
        }



        //Método para cerrar la aplicación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void insertaCita_Click(object sender, EventArgs e)
        {
            Conexion conexionInsertaCita = new Conexion();
            conexionInsertaCita.InsertaCita(usuarioCitaBox.Text, clienteCitaBox.Text, nombre_mascotaCitaBox.Text, DateTime.Parse(fecha_citaBox.Text));

            dataGridViewCitas.DataSource = conexion.GetTodasCitas();
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void nuevoCliente_Click(object sender, EventArgs e)
        {
            InsertaUsuario iu = new InsertaUsuario();
            iu.Show();
        }

        private void actualizaStock_Click(object sender, EventArgs e) //NO FUNCIONA
        {
            Conexion conexionactualizaStock = new Conexion();
            conexionactualizaStock.ActualizaStock(cod_productoBox.Text, cantidadBox.Text);

            dataGridViewAlmacen.DataSource = conexion.GetProductosAlmacen();
            dataGridViewAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAlmacen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
