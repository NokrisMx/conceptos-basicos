partial class Program
{
    static void Exercise30()
    {
        ProductoExercise30 producto1 = new ProductoExercise30("Laptop", 15000, 5);

        int stock = producto1.StockExercise30;
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {stock}");
    }

    class ProductoExercise30
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        private int Stock { get; set; }

        public int StockExercise30
        {
            get { return Stock; }
        }

        public ProductoExercise30(string nombre, decimal precio, int stock)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Nombre es obligatorio");
            }

            if (precio < 0)
            {
                throw new ArgumentException("Precio no puede ser negativo.");
            }

            if (stock < 0)
            {
                throw new ArgumentException("Stock no puede ser negativo.");
            }

            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

    }
}