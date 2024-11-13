using System;
using System.Data;
using System.IO;

namespace SoftVentas.Persistence
{
    public class UsuariosPersistence
    {
        public DataTable UsuariosTable { get; set; } = new DataTable();

        public UsuariosPersistence()
        {
            UsuariosTable.TableName = "ListaUsuarios";
            UsuariosTable.Columns.Add("NombreUsuario");
            UsuariosTable.Columns.Add("Password");
            UsuariosTable.Columns.Add("Email");
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (File.Exists("Usuarios.xml"))
            {
                UsuariosTable.ReadXml("Usuarios.xml");
            }
        }

        public void InsertarUsuario(Usuario usuario)
        {
            UsuariosTable.Rows.Add(); // Agrega un nuevo renglón vacío
            int nuevoRenglon = UsuariosTable.Rows.Count - 1;
            UsuariosTable.Rows[nuevoRenglon]["NombreUsuario"] = usuario.NombreUsuario;
            UsuariosTable.Rows[nuevoRenglon]["Password"] = usuario.Password;
            UsuariosTable.Rows[nuevoRenglon]["Email"] = usuario.Email;

            UsuariosTable.WriteXml("Usuarios.xml");
        }

        public Usuario BuscarUsuario(string nombreUsuario)
        {
            Usuario usuario = null;

            foreach (DataRow fila in UsuariosTable.Rows)
            {
                if (Convert.ToString(fila["NombreUsuario"]) == nombreUsuario)
                {
                    usuario = new Usuario
                    {
                        NombreUsuario = Convert.ToString(fila["NombreUsuario"]),
                        Password = Convert.ToString(fila["Password"]),
                        Email = Convert.ToString(fila["Email"])
                    };
                    break;
                }
            }

            return usuario;
        }
    }
}
