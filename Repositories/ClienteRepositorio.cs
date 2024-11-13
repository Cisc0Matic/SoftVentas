using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SoftVentas.Persistence;

namespace SoftVentas.Repositories
{
    internal class ClienteRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>();
        private ClientesPersistence clientesPersistence;

        public ClienteRepositorio()
        {
            clientesPersistence = new ClientesPersistence(); // Instancia de persistencia de clientes
            CargarClientesDesdePersistencia(); // Cargar clientes desde el archivo XML
        }

        // Método para cargar clientes desde ClientesPersistence
        private void CargarClientesDesdePersistencia()
        {
            foreach (DataRow fila in clientesPersistence.ClientesTable.Rows)
            {
                Cliente cliente = new Cliente
                {
                    idCliente = Convert.ToInt32(fila["IdCliente"]),
                    NombreCompleto = fila["NombreCompleto"].ToString(),
                    Telefono1 = fila["Telefono1"].ToString(),
                    Telefono2 = fila["Telefono2"].ToString(),
                    Mail = fila["Mail"].ToString()
                };
                clientes.Add(cliente);
            }
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
                Cliente nuevoCliente = new Cliente
                {
                    idCliente = clientes.Count > 0 ? clientes.Max(c => c.idCliente) + 1 : 1,
                    NombreCompleto = nombreCompleto,
                    Telefono1 = telefono1,
                    Telefono2 = telefono2,
                    Mail = mail
                };

                // Agregar a la lista y a la persistencia
                clientes.Add(nuevoCliente);
                clientesPersistence.InsertarCliente(nuevoCliente); // Guardar en el archivo XML
                MessageBox.Show("Cliente registrado exitosamente en la lista y en el archivo XML.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el cliente: {ex.Message}");
                return false;
            }
        }

        // Método para mostrar los clientes en un MessageBox
        public string MostrarClientes()
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
            return mensaje;
        }
    }
}
