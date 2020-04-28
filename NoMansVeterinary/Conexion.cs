using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Data;

namespace NoMansVeterinary
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public Boolean loginVeterinario(String dni, String pass) 
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

        public string insertaUsario(string id, string dni, string nombre, string apellido, string pass, string email, string telefono, string tipo_usuario)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuario (id, dni, nombre, apellido, pass, email, telefono, tipo_usuario) VALUES (@id, @dni, @nombre, @apellido, @pass, @email, @telefono, @tipo_usuario)", conexion);
                consulta.Parameters.AddWithValue("@id", id);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@pass", pass);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@telefono", telefono);
                consulta.Parameters.AddWithValue("@tipo_usuario", tipo_usuario);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public DataTable getTodosUsuarios()
        {
            try
            { 
            conexion.Open();
            MySqlCommand consulta =
                new MySqlCommand("SELECT * FROM veterinario.usuario", conexion);
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
    }
}
