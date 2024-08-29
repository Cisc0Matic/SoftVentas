public class TipoRopa
{
    public string Nombre { get; set; }

    // Constructor por defecto
    public TipoRopa() {}

    // Constructor con parámetros
    public TipoRopa(string nombre)
    {
        Nombre = nombre;
    }
}
