using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NoMansVeterinary
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pws =; Port = 3306");
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
                    new MySqlCommand("SELECT * FROM usuario WHERE dni = @dni AND pass = @pass", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@pass", pass);

                MySqlDataReader resultado = consulta.ExecuteReader();
                if(resultado.Read())
                {
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public String insertaUsario(String dni, String nombre, String apellidos, String pass, String email, String telefono, String departamento)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuario (id, dni, nombre, apellidos, pass, email, telefono, departamento) " +
                    "VALUES (NULL, @dni, @nombre, @apellidos, @pass, @email, @telefono, @departamento)");
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellidos", dni);
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
    }
}
