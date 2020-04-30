using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Data;
using System.Windows.Forms;

namespace NoMansVeterinary
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                conexion = new MySqlConnection("Server = 127.0.0.1; Database = noMansVeterinary; Uid = root; Pwd =; Port = 3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public Boolean LoginVeterinario(String dni, String pass) 
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM usuario WHERE dni = @dni", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);

                MySqlDataReader resultado = consulta.ExecuteReader();
                if(resultado.Read())
                {
                    string passwordConHash = resultado.GetString("pass");
                    if(BCrypt.Net.BCrypt.Verify(pass, passwordConHash))
                    {
                        return true;
                    }
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public string InsertaUsuario(string id, string dni, string nombre, string apellido, string pass, string email, string telefono, string departamento)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuario (id, dni, nombre, apellido, pass, email, telefono, departamento) VALUES (@id, @dni, @nombre, @apellido, @pass, @email, @telefono, @departamento)", conexion);
                consulta.Parameters.AddWithValue("@id", id);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@pass", pass);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@telefono", telefono);
                consulta.Parameters.AddWithValue("@departamento", departamento);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public string InsertaCliente(string dni, string nombre, string apellido, string email, string telefono, string direccion, DateTime fecha_nacimiento)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO cliente (dni, nombre, apellido, email, telefono, direccion, fecha_nacimiento) VALUES (@dni, @nombre, @apellido, @email, @telefono, @direccion, @fecha_nacimiento)", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@telefono", telefono);
                consulta.Parameters.AddWithValue("@direccion", direccion);
                consulta.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public string InsertaCita(string usuario, string cliente, string nombre_mascota, DateTime fecha_cita)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO citas (usuario, cliente, nombre_mascota, fecha_cita) VALUES (@usuario, @cliente, @nombre_mascota, @fecha_cita)", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@cliente", cliente);
                consulta.Parameters.AddWithValue("@nombre_mascota", nombre_mascota);
                consulta.Parameters.AddWithValue("@fecha_cita", fecha_cita);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public DataTable GetTodosUsuarios(string _datosRequeridos)
        {

            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT id, dni" + _datosRequeridos + " FROM usuario", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuarios = new DataTable();
                usuarios.Load(resultado);
                conexion.Close();
                return usuarios;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable GetTodosClientes(string _datosRequeridosClientes)
        {

            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT dni" + _datosRequeridosClientes + " FROM cliente", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable GetTodasCitas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM citas", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuarios = new DataTable();
                usuarios.Load(resultado);
                conexion.Close();
                return usuarios;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable GetProductosAlmacen()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM almacen", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuarios = new DataTable();
                usuarios.Load(resultado);
                conexion.Close();
                return usuarios;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public string ActualizaStock(string cod_producto, string cantidad)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("UPDATE almacen SET (cantidad) VALUES (@cantidad) WHERE cod_producto = @cod_producto", conexion);
                consulta.Parameters.AddWithValue("@cantidad", cantidad);
                consulta.Parameters.AddWithValue("@cod_producto", cod_producto);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }

        }
    }
}
