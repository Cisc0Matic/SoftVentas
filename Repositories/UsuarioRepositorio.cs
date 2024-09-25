using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;

namespace SoftVentas.Repositories
{
    public class UsuarioRepositorio
    {
        private readonly string connectionString;

        public UsuarioRepositorio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SoftVentas.Properties.Settings.ventas_softConnectionString1"].ConnectionString;
        }
        string mensaje = "Lista de Usuarios:\n";

        //public bool RegistrarUsuario(string nombreUsuario, string password, string email)
        //{
        //    const string query = "INSERT INTO Usuarios (NombreUsuario, Password, Email) VALUES (@NombreUsuario, @Password, @Email)";

        //    using (var connection = new SqlConnection(connectionString))
        //    using (var command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
        //        command.Parameters.AddWithValue("@Password", password);
        //        command.Parameters.AddWithValue("@Email", email);

        //        try
        //        {
        //            connection.Open();
        //            int result = command.ExecuteNonQuery();
        //            return result > 0; // Retorna true si la inserción fue exitosa
        //        }
        //        catch (Exception ex)
        //        {
        //            // Para depuración, puedes imprimir el error
        //            Console.WriteLine($"Error al registrar el usuario: {ex.Message}");
        //            return false;
        //        }
        //    }
        //}


        //public bool AutenticarUsuario(string email, string password)
        //{
        //    const string query = "SELECT COUNT(1) FROM Usuarios WHERE Email = @Email AND Password = @Password";

        //    using (var connection = new SqlConnection(connectionString))
        //    using (var command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@Email", email); // Corregido el parámetro
        //        command.Parameters.AddWithValue("@Password", password);

        //        try
        //        {
        //            connection.Open();
        //            return (int)command.ExecuteScalar() > 0;
        //        }
        //        catch (Exception ex)
        //        {
        //            // Para depuración, puedes imprimir el error
        //            MessageBox.Show($"Error al autenticar el usuario: {ex.Message}");
        //           // Console.WriteLine($"Error al autenticar el usuario: {ex.Message}");
        //            return false;
        //        }

        //    }
        //}

        //--------- metodos de prueba sin conexión a bd ---------

        // Lista de usuarios en memoria
        private List<Usuario> usuarios;

        public void UsuarioRepositorioAlternativo(){
            usuarios = new List<Usuario>
            {
                new Usuario { NombreUsuario = "admin", Password = "1234", Email = "admin@mail.com" },
                new Usuario { NombreUsuario = "usuario1", Password = "password1", Email = "user1@mail.com" }
            };
        }

        // Metodo para registrar un nuevo usuario en la lista
        public bool RegistrarUsuario1(string nombreUsuario, string password, string email)
        {
            // Agregar el nuevo usuario a la lista
            usuarios.Add(new Usuario
            {
                NombreUsuario = nombreUsuario, 
                Password = password,           
                Email = email                
            });

            MessageBox.Show("Usuario registrado exitosamente.");

            return true;
        }

        public void mostrarListaUsuarios()
        {
            foreach (var usuario in usuarios)
            {
                mensaje += $"Nombre: {usuario.NombreUsuario}, Email: {usuario.Email}\n";
            }
            MessageBox.Show(mensaje);
        }
        // Método para autenticar un usuario
        public bool AutenticarUsuario(string email, string password)
        {
            // Recorrer arreglo
            foreach (var usuario in usuarios)
            {
                // Condicion para ingreso, se comparan los datos
                if (usuario.Email == email && usuario.Password == password)
                {
                    MessageBox.Show("Bienvenido " + usuario.NombreUsuario);
                    return true;
                }
            }

            // Si no se encuentra el usuario, mostramos un mensaje de error
            MessageBox.Show("Correo o contraseña incorrectos");
            return false;
        }
    }
}
