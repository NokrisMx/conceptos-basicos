/* El programa debe hacer lo siguiente
1. Mostrar productos disponibles
Solo los que tengan stock mayor a 0.
2. Mostrar productos agotados
Los que tengan stock igual a 0.
3. Mostrar productos caros
Considera caro cualquier producto con precio mayor a $2,000.
4. Buscar productos disponibles y baratos
Considera barato un producto con precio menor a $1,500. */
partial class Program
{
    static void Exercise10()
    {
        List<string> productos = new List<string> { "Laptop", "Mouse", "Teclado", "Monitor", "Audífonos", "Webcam" };

        List<decimal> precios = new List<decimal> { 15000m, 500m, 1200m, 6500m, 800m, 2200m };

        List<int> stock = new List<int> { 5, 0, 10, 3, 0, 7 };

        WriteLine($"PRODUCTOS DISPONIBLES");
        for (int i = 0; i < productos.Count; i++)
        {
            if (stock[i] > 0)
            {
                WriteLine($"Producto: {productos[i]} - Precio: {precios[i]:C2} - Stock: {stock[i]}");
            }
        }

        WriteLine($"PRODUCTOS AGOTADOS");
        for (int i = 0; i < productos.Count; i++)
        {
            if (stock[i] == 0)
            {
                WriteLine($"Producto: {productos[i]} - Precio: {precios[i]:C2} - Stock: {stock[i]}");
            }
        }

        WriteLine($"PRODUCTOS CAROS");
        for (int i = 0; i < productos.Count; i++)
        {
            if (precios[i] > 2000)
            {
                WriteLine($"Producto: {productos[i]} - Precio: {precios[i]:C2} - Stock: {stock[i]}");
            }
        }

        WriteLine($"PRODUCTOS BARATOS");
        for (int i = 0; i < productos.Count; i++)
        {
            if (stock[i] > 0 && precios[i] < 1500)
            {
                WriteLine($"Producto: {productos[i]} - Precio: {precios[i]:C2} - Stock: {stock[i]}");
            }
        }
    }
}