public class Ropa
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public TipoRopa Tipo { get; set; }

    // Constructor por defecto
    public Ropa() {}

    // Constructor con parámetros
    public Ropa(string nombre, decimal precio, TipoRopa tipo)
    {
        Nombre = nombre;
        Precio = precio;
        Tipo = tipo;
    }
}
