public class Usuario
{
    public string NombreUsuario { get; set; }
    public string Password { get; set; }
    //  public Cliente Cliente { get; set; }
    public string Email { get; set; }

    // Constructor por defecto
    public Usuario() {}

    // Constructor con parámetros
    public Usuario(string nombreUsuario, string password , string email)
    {
        NombreUsuario = nombreUsuario;
        Password = password;
        Email = email;
    }
}
