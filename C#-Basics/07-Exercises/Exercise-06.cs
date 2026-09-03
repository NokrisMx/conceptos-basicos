/* 
Crea una variable: string productoBuscado = "Teclado";
Y consigue que el programa muestre: Producto encontrado: Teclado
Stock disponible: 12
Si cambias: string productoBuscado = "Celular";
debería mostrar: Producto no encontrado 
*/
partial class Program
{
    static void Exercise06()
    {
        List<string> productos = new List<string> { "Laptop", "Mouse", "Teclado", "Monitor", "Audífonos" };
        List<int> stock = new List<int> { 5, 0, 12, 3, 0 };
        string productoBuscado = "Celular";
        bool encontrado = false;

        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i] == productoBuscado)
            {
                WriteLine($"Producto encontrado: {productos[i]}");
                WriteLine($"Stock: {stock[i]}");
                encontrado = true;
            }
        }
        if (encontrado != true)
        {
            WriteLine($"Producto no encontrado");
        }
    }
}