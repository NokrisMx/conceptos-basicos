/* Encuentra el vendedor que realizó la venta más alta y muestra:
Vendedor con mayor venta: Laura
Venta: $4500 */
partial class Program
{
    static void Exercise07()
    {
        List<string> vendedores = new List<string>
        {
            "Juan", "Ana", "Pedro", "Laura", "Carlos"
        };

        List<decimal> ventas = new List<decimal>
        {
            1500m, 3200m, 1800m, 4500m, 2700m
        };

        decimal ventaMayor = ventas[0];
        int posicionMayor = 0;

        for (int i = 0; i < ventas.Count; i++)
        {
            if (ventas[i] > ventaMayor)
            {
                ventaMayor = ventas[i];
                posicionMayor = i;
            }
        }

        WriteLine($"Vendedor con mayor venta: {vendedores[posicionMayor]}");
        WriteLine($"Venta: {ventaMayor:C2}");
    }
}