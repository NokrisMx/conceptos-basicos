partial class Program
{
    static void Exercise29()
    {
        ProductoExercise29 producto1 = new ProductoExercise29("Laptop", 15000, 5);

        int stock = producto1.StockExercise29;
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {stock}");
        decimal inventario = producto1.ObtenerValorInventarioExercise29();
        WriteLine($"Valor inventario: {inventario:C2}");
    }


    class ProductoExercise29
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        private int Stock { get; set; }

        public int StockExercise29
        {
            get { return Stock; }
        }

        public ProductoExercise29(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public decimal ObtenerValorInventarioExercise29()
        {
            return Precio * Stock;
        }
    }
}