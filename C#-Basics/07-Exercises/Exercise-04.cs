/* El programa debe:
Calcular el subtotal de todos los productos.
Aplicar un descuento del 10% únicamente si el subtotal es mayor o igual a $1,000.
Calcular el total final.
Mostrar si se aplicó descuento. */
partial class Program
{
    static void Exercise04()
    {
        List<decimal> precios = new List<decimal> { 250.50m, 120m, 500.75m, 80m, 320.25m, 150m };
        decimal subtotal = 0;
        decimal descuento = 0;
        decimal total = 0;

        foreach (decimal p in precios)
        {
            subtotal += p;
        }
        if (subtotal >= 1000)
        {
            descuento = 0.10m * subtotal;
        }
        total = subtotal - descuento;

        WriteLine($"Precios: {String.Join(", ", precios)}");
        WriteLine($"Subtotal: {subtotal:C2}");
        WriteLine($"Descuento: {descuento:C2}");
        WriteLine($"Total: {total:C2}");
    }
}

