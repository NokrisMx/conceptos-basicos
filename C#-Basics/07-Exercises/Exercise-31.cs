partial class Program
{
    static void Exercise31()
    {
        ProductoExercise31 producto1 = new ProductoExercise31("Laptop", 15000, 5);
        int stock = producto1.StockExercise31;
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {stock}");

        ProductoExercise31 producto2 = new ProductoExercise31("Laptop", 15000);
        int stock2 = producto2.StockExercise31;
        WriteLine($"Producto: {producto2.Nombre}");
        WriteLine($"Precio: {producto2.Precio:C2}");
        WriteLine($"Stock: {stock2}");


    }

    class ProductoExercise31
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        private int Stock { get; set; }

        public int StockExercise31
        {
            get { return Stock; }
        }

        public ProductoExercise31(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public ProductoExercise31(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

    }
}