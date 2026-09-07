partial class Program
{
    static void Exercise28()
    {
        ProductoExercise28 producto1 = new ProductoExercise28("Laptop", 15000, 5);

        int stock = producto1.StockExercise28;
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {stock}");

        producto1.AgregarStockExercise28(10);
        stock = producto1.StockExercise28;
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {stock}");

        producto1.ReducirStockExercise28(5);
        stock = producto1.StockExercise28;
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {stock}");
    }

    class ProductoExercise28
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        private int Stock { get; set; }

        public int StockExercise28
        {
            get { return Stock; }
        }

        public ProductoExercise28(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }


        public void AgregarStockExercise28(int cantidad)
        {
            Stock += cantidad;
        }

        public void ReducirStockExercise28(int cantidad)
        {
            if (Stock >= cantidad)
            {
                Stock -= cantidad;
            }

        }

    }
}