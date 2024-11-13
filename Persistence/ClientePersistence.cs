using System;
using System.Data;
using System.IO;

namespace SoftVentas.Persistence
{
    public class ClientesPersistence
    {
        public DataTable ClientesTable { get; set; } = new DataTable();

        public ClientesPersistence()
        {
            ClientesTable.TableName = "ListaClientes";
            ClientesTable.Columns.Add("IdCliente", typeof(int));
            ClientesTable.Columns.Add("NombreCompleto");
            ClientesTable.Columns.Add("Telefono1");
            ClientesTable.Columns.Add("Telefono2");
            ClientesTable.Columns.Add("Mail");
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (File.Exists("Clientes.xml"))
            {
                ClientesTable.ReadXml("Clientes.xml");
            }
        }

        public void InsertarCliente(Cliente cliente)
        {
            int id = NuevoId();

            ClientesTable.Rows.Add(); // Agrega un nuevo renglón vacío
            int nuevoRenglon = ClientesTable.Rows.Count - 1;
            ClientesTable.Rows[nuevoRenglon]["IdCliente"] = id;
            ClientesTable.Rows[nuevoRenglon]["NombreCompleto"] = cliente.NombreCompleto;
            ClientesTable.Rows[nuevoRenglon]["Telefono1"] = cliente.Telefono1;
            ClientesTable.Rows[nuevoRenglon]["Telefono2"] = cliente.Telefono2;
            ClientesTable.Rows[nuevoRenglon]["Mail"] = cliente.Mail;

            ClientesTable.WriteXml("Clientes.xml");
        }

        private int NuevoId()
        {
            int nuevoId = 0;

            foreach (DataRow fila in ClientesTable.Rows)
            {
                if (nuevoId < Convert.ToInt32(fila["IdCliente"]))
                {
                    nuevoId = Convert.ToInt32(fila["IdCliente"]);
                }
            }

            nuevoId++;
            return nuevoId;
        }

        public Cliente BuscarCliente(int idCliente)
        {
            Cliente cliente = null;

            foreach (DataRow fila in ClientesTable.Rows)
            {
                if (Convert.ToInt32(fila["IdCliente"]) == idCliente)
                {
                    cliente = new Cliente
                    {
                        idCliente = Convert.ToInt32(fila["IdCliente"]),
                        NombreCompleto = Convert.ToString(fila["NombreCompleto"]),
                        Telefono1 = Convert.ToString(fila["Telefono1"]),
                        Telefono2 = Convert.ToString(fila["Telefono2"]),
                        Mail = Convert.ToString(fila["Mail"])
                    };
                    break;
                }
            }

            return cliente;
        }
    }
}
