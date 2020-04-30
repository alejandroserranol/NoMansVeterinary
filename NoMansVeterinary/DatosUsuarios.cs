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
    public partial class DatosUsuarios : Form
    {
        Conexion conexion = new Conexion();
        public DatosUsuarios(string _datosRequeridos)
        {
            InitializeComponent();
            dataGridViewUsuarios.DataSource = conexion.GetTodosUsuarios(_datosRequeridos);
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
