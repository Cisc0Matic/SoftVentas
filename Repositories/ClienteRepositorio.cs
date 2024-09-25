using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftVentas.Repositories
{
        // Repositorio donde se guardarán los clientes en un arreglo
        internal class ClienteRepositorio
        {
            private List<Cliente> clientes = new List<Cliente>();

            public ClienteRepositorio()
            {
                // Inicializamos con algunos datos de ejemplo
                clientes.Add(new Cliente { idCliente = 1, NombreCompleto = "Juan Perez", Telefono1 = "123456789", Telefono2 = "987654321", Mail = "juan@correo.com" });
                clientes.Add(new Cliente { idCliente = 2, NombreCompleto = "Ana Gómez", Telefono1 = "555666777", Telefono2 = null, Mail = "ana@correo.com" });
            }

            // Método para obtener la lista de clientes
            public List<Cliente> ObtenerClientes()
            {
                return clientes;
            }

            // Método para agregar un cliente
            public bool AgregarCliente(string nombreCompleto, string telefono1, string telefono2, string mail)
            {
                try
                {
                    int nuevoId = clientes.Count > 0 ? clientes.Max(c => c.idCliente) + 1 : 1;
                    var cliente = new Cliente
                    {
                        idCliente = nuevoId,
                        NombreCompleto = nombreCompleto,
                        Telefono1 = telefono1,
                        Telefono2 = telefono2,
                        Mail = mail
                    };
                    clientes.Add(cliente);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al agregar el cliente: {ex.Message}");
                    return false;
                }
            }

            // Método para mostrar los clientes en un MessageBox
            public void MostrarClientes()
            {
                string mensaje = "Lista de Clientes:\n";

                foreach (var cliente in clientes)
                {
                    mensaje += $"ID: {cliente.idCliente}, Nombre: {cliente.NombreCompleto}, " +
                               $"Teléfono 1: {cliente.Telefono1}, " +
                               $"Teléfono 2: {(cliente.Telefono2 ?? "No disponible")}, " +
                               $"Email: {cliente.Mail}\n";
                }

                MessageBox.Show(mensaje, "Clientes Registrados");
            }
        }

        // Programa de prueba

    }

    //internal class ClienteRepositorio
    //{
    //    private readonly string connectionString;

    //    public ClienteRepositorio()
    //    {
    //        connectionString = ConfigurationManager.ConnectionStrings["SoftVentas.Properties.Settings.ventas_softConnectionString1"].ConnectionString;
    //    }
    //    public List<Cliente> ObtenerCliente()
    //    {
    //        var clientes = new List<Cliente>(); // Lista para almacenar los clientes
    //        const string query = "SELECT ClienteId, NombreCompleto, Telefono1, Telefono2, Mail FROM cliente";
    //        try
    //        {
    //            using (var connection = new SqlConnection(connectionString))
    //            using (var command = new SqlCommand(query, connection))
    //            {
    //                connection.Open(); //abrimos conexión 
    //                using (var reader = command.ExecuteReader())
    //                {
    //                    while (reader.Read()) // leer las filas del resultado de la query
    //                    {
    //                        //se crea un objeto de tipo cliente para guardar sus respetivos datos 
    //                        var cliente = new Cliente
    //                        {
    //                            idCliente = reader.GetInt32(reader.GetOrdinal("ClienteId")),
    //                            NombreCompleto = reader.GetString(reader.GetOrdinal("NombreCompleto")),
    //                            Telefono1 = reader.GetString(reader.GetOrdinal("Telefono1")),
    //                            //uso de operador ternario, condicion y dos opciones (si la BD esta vacia, se llena con un null
    //                            //si no, se hace trae la info que haya en la BD
    //                            Telefono2 = reader.IsDBNull(reader.GetOrdinal("Telefono2")) ? null : reader.GetString(reader.GetOrdinal("Telefono2")),
    //                            Mail = reader.GetString(reader.GetOrdinal("Mail"))
    //                        };

    //                        clientes.Add(cliente); // añadir los clientes a la lista 
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Error al obtener los clientes: {ex.Message}");
    //        }

    //        return clientes; // Retornar la lista de clientes
    //    }

    //    public bool AgregarCliente(string nombreCompleto, int telefono1, int telefono2, string mail)
    //    {
    //        const string query = "INSERT INTO cliente (NombreCompleto, Telefono1, Telefono2, Mail) VALUES (@nombreCompleto, @telefono1, @telefono2, @mail)";

    //        try
    //        {
    //            using (var connection = new SqlConnection(connectionString))
    //            {
    //                using (var command = new SqlCommand(query, connection))
    //                {
    //                    command.Parameters.Add(new SqlParameter("@nombreCompleto", nombreCompleto));
    //                    command.Parameters.Add(new SqlParameter("@telefono1", telefono1));
    //                    command.Parameters.Add(new SqlParameter("@telefono2", telefono2));
    //                    command.Parameters.Add(new SqlParameter("@mail", mail));

    //                    connection.Open();
    //                    int result = command.ExecuteNonQuery();
    //                    return result > 0; // Retorna true si la inserción fue exitosa
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            // Para depuración, puedes imprimir el error
    //            Console.WriteLine($"Error al agregar el cliente: {ex.Message}");
    //            return false;
    //        }
    //    }
    //    //pruba en msgbox
    //    public void MostrarClientes()
    //    {
    //        List<Cliente> listaClientes = ObtenerCliente(); // Obtener la lista de clientes
    //        string mensaje = "Lista de Clientes:\n";

    //        foreach (var cliente in listaClientes)
    //        {
    //            mensaje += $"ID: {cliente.idCliente}, Nombre: {cliente.NombreCompleto}, " +
    //                       $"Telefono 1: {cliente.Telefono1}, " +
    //                       $"Telefono 2: {(cliente.Telefono2 ?? "No disponible")}, " +
    //                       $"Email: {cliente.Mail}\n";
    //        }

    //        // Mostrar el mensaje en un MessageBox
    //        MessageBox.Show(mensaje, "Clientes Registrados");
    //    }

    //}



