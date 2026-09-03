/* El programa debe:
Mostrar cada producto junto con su stock.
Contar cuántos productos están disponibles.
Contar cuántos productos están agotados.
Mostrar un mensaje para cada producto agotado. 
ejemplo:
Laptop - Stock: 5
Mouse - Stock: 0
Teclado - Stock: 12
Monitor - Stock: 3
Audífonos - Stock: 0
Productos disponibles: 3
Productos agotados: 2
Producto agotado: Mouse
Producto agotado: Audífonos
*/
partial class Program
{
    static void Exercise05()
    {
        List<string> productos = new List<string> { "Laptop", "Mouse", "Teclado", "Monitor", "Audífonos" };
        int disponibles = 0;
        int agotados = 0;

        List<int> stock = new List<int> { 5, 0, 12, 3, 0 };

        for (int i = 0; i < productos.Count; i++)
        {
            WriteLine($"{productos[i]} - Stock: {stock[i]}");

            if (stock[i] != 0)
            {
                disponibles++;
            }
            else
            {
                agotados++;
                WriteLine($"Producto agotado: {productos[i]}");
            }
        }
        WriteLine($"Productos disponibles: {disponibles}");
        WriteLine($"Productos agotados: {agotados}");

    }
}