using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace SoftVentas.Repositories
{
    public class UsuarioRepositorio
    {
        private readonly string connectionString;

        public UsuarioRepositorio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SoftVentas.Properties.Settings.ventas_softConnectionString1"].ConnectionString;
        }

        public bool RegistrarUsuario(string nombreUsuario, string password, string email)
        {
            const string query = "INSERT INTO Usuarios (NombreUsuario, Password, Email) VALUES (@NombreUsuario, @Password, @Email)";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0; // Retorna true si la inserción fue exitosa
                }
                catch (Exception ex)
                {
                    // Para depuración, puedes imprimir el error
                    Console.WriteLine($"Error al registrar el usuario: {ex.Message}");
                    return false;
                }
            }
        }


        public bool AutenticarUsuario(string email, string password)
        {
            const string query = "SELECT COUNT(1) FROM Usuarios WHERE Email = @Email AND Password = @Password";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email); // Corregido el parámetro
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    return (int)command.ExecuteScalar() > 0;
                }
                catch (Exception ex)
                {
                    // Para depuración, puedes imprimir el error
                    MessageBox.Show($"Error al autenticar el usuario: {ex.Message}");
                   // Console.WriteLine($"Error al autenticar el usuario: {ex.Message}");
                    return false;
                }
            }
        }

    }
}
