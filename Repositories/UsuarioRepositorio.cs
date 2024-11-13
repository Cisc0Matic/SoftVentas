using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SoftVentas.Persistence;

namespace SoftVentas.Repositories
{
    public class UsuarioRepositorio
    {
        private readonly List<Usuario> usuarios = new List<Usuario>();
        private UsuariosPersistence usuariosPersistence;

        public UsuarioRepositorio()
        {
            // Instancia de UsuariosPersistence para cargar la lista desde XML
            usuariosPersistence = new UsuariosPersistence();
            CargarUsuariosDesdePersistencia();
        }

        // Cargar usuarios desde UsuariosPersistence
        private void CargarUsuariosDesdePersistencia()
        {
            foreach (DataRow fila in usuariosPersistence.UsuariosTable.Rows)
            {
                Usuario usuario = new Usuario
                {
                    NombreUsuario = fila["NombreUsuario"].ToString(),
                    Password = fila["Password"].ToString(),
                    Email = fila["Email"].ToString()
                };
                usuarios.Add(usuario);
            }
        }

        // Método para registrar un nuevo usuario tanto en la lista como en la persistencia
        public bool RegistrarUsuario1(string nombreUsuario, string password, string email)
        {
            // Crear nuevo usuario y agregarlo a la lista
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Password = password,
                Email = email
            };
            usuarios.Add(nuevoUsuario);

            // Insertar en la persistencia y guardar en el archivo XML
            usuariosPersistence.InsertarUsuario(nuevoUsuario);

            MessageBox.Show("Usuario registrado exitosamente en la lista y en el archivo XML.");
            return true;
        }

        // Mostrar lista de usuarios

        //public void mostrarListaUsuarios()
        //{
        //    string mensaje = "Lista de Usuarios:\n";
        //    foreach (var usuario in usuarios)
        //    {
        //        mensaje += $"Nombre: {usuario.NombreUsuario}, Email: {usuario.Email}\n";
        //    }
        //    MessageBox.Show(mensaje);
        //}

        // Método para autenticar un usuario

        public bool AutenticarUsuario(string email, string password)
        {
            // Buscar el usuario en la lista cargada
            var usuario = usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido " + usuario.NombreUsuario);
                return true;
            }

            MessageBox.Show("Correo o contraseña incorrectos");
            return false;
        }
    }
}
