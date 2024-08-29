public class Cuenta
{
    public Cliente Cliente { get; set; }
    public decimal Saldo { get; set; }
    public DateTime FechaCreacion { get; set; }

    // Constructor por defecto
    public Cuenta() {}

    // Constructor con parámetros
    public Cuenta(Cliente cliente, decimal saldo, DateTime fechaCreacion)
    {
        Cliente = cliente;
        Saldo = saldo;
        FechaCreacion = fechaCreacion;
    }
}
