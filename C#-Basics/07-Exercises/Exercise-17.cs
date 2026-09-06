partial class Program
{
    static void Exercise17()
    {
        decimal precio = 1000;
        decimal porcentaje = 10;

        decimal total = CalcularTotalConDescuento(precio, porcentaje);

        WriteLine($"Precio: {precio:C2}");
        WriteLine($"Descuento: {CalcularDescuento(precio, porcentaje):C2}");
        WriteLine("------------------------------");
        WriteLine($"Total: {total:C2}");
    }

    static decimal CalcularTotalConDescuento(decimal precio, decimal porcentaje)
    {
        decimal descuento = CalcularDescuento(precio, porcentaje);
        decimal total = precio - descuento;

        return total;
    }
}