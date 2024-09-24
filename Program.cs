using SoftVentas.Models;
using SoftVentas.Repositories;
using SoftVentas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftVentas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// Crear una instancia del repositorio
            //UsuarioRepositorio repositorio = new UsuarioRepositorio();

            //// Prueba de autenticación
            //Usuario carlos = new Usuario
            //{
            //    NombreUsuario = "Carlos",
            //    Password = "1234",
            //    Email = "carlos@gmail.com"
            //};

            //bool autenticado = repositorio.AutenticarUsuario(usuario);
            //Console.WriteLine($"Autenticado: {autenticado}");

            //// Prueba de registro
            //Usuario nuevoUsuario = new Usuario
            //{
            //    NombreUsuario = "newuser",
            //    Password = "newpassword",
            //    Email = "newuser@example.com"
            //};

            //bool registroExitoso = repositorio.RegistrarUsuario(nuevoUsuario);
            //Console.WriteLine($"Registro Exitoso: {registroExitoso}");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //Auto auto1 = new Auto();
            //auto1.encenderAuto();

        }
    }
}
