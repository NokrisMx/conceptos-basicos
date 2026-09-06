partial class Program
{
    static void Exercise15()
    {
        decimal total = CalcularTotal(100, 5);
        WriteLine($"Total: {total}");
    }

    static decimal CalcularTotal(decimal precio, int cantidad)
    {
        return precio * cantidad;
    }
}