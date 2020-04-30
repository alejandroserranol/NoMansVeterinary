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
    public partial class DatosCliente : Form
    {
        Conexion conexion = new Conexion();
        public DatosCliente(string _datosRequeridosClientes)
        {
            InitializeComponent();
            dataGridViewClientes.DataSource = conexion.GetTodosClientes(_datosRequeridosClientes);
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
