using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftVentas.Repositories
{
    public class UsuarioRepositorio
    {
        private string connectionString;

        public UsuarioRepositorio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SoftVentas.Properties.Settings.ventas_softConnectionString1"].ConnectionString;
        }

        // Método para registrar un usuario
        public bool RegistrarUsuario(Usuario usuario)
        {
            // Consulta para insertar el usuario
            string query = "INSERT INTO Usuarios (NombreUsuario, Password, Email) VALUES (@NombreUsuario, @Password, @Email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Añadir parámetros a la consulta
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Password", usuario.Password); // Contraseña sin hash
                command.Parameters.AddWithValue("@Email", usuario.Email);

                try
                {
                    // Abrir conexión y ejecutar consulta
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0; // Retorna true si la inserción fue exitosa
                }
                catch (Exception)
                {
                    // Manejo de errores simple
                    return false;
                }
            }
        }

        // Método para autenticar un usuario
        public bool AutenticarUsuario(Usuario usuario)
        {
            // Consulta para verificar el usuario
            string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Añadir parámetros a la consulta
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Password", usuario.Password); // Contraseña sin hash

                try
                {
                    // Abrir conexión y ejecutar consulta
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Retorna true si el usuario existe
                }
                catch (Exception)
                {
                    // Manejo de errores simple
                    return false;
                }
            }
        }
    }
}
