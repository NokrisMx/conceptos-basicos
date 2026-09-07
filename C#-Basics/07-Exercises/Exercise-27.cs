partial class Program
{
    static void Exercise27()
    {
        ProductoExercise27 producto1 = new ProductoExercise27("Laptop", 15000, 5);
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {producto1.Stock}");

        ProductoExercise27 producto2 = new ProductoExercise27("Mouse", 500, 20);
        WriteLine($"Producto: {producto2.Nombre}");
        WriteLine($"Precio: {producto2.Precio:C2}");
        WriteLine($"Stock: {producto2.Stock}");

        ProductoExercise27 producto3 = new ProductoExercise27("Teclado", 1200, 10);
        WriteLine($"Producto: {producto3.Nombre}");
        WriteLine($"Precio: {producto3.Precio:C2}");
        WriteLine($"Stock: {producto3.Stock}");
    }

    class ProductoExercise27
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public ProductoExercise27(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }
}