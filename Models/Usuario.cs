public class Usuario
{
    public string NombreUsuario { get; set; }
    public string Password { get; set; }
    public Cliente Cliente { get; set; }

    // Constructor por defecto
    public Usuario() {}

    // Constructor con parámetros
    public Usuario(string nombreUsuario, string password, Cliente cliente)
    {
        NombreUsuario = nombreUsuario;
        Password = password;
        Cliente = cliente;
    }
}
