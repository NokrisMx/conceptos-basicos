partial class Program
{
    static void Exercise32()
    {
        ProductoExercise32 producto1 = new ProductoExercise32("Laptop", 15000, 5);
        WriteLine($"Stock: {producto1.Stock}");
        producto1.AgregarStockExercise32(15);
        WriteLine($"Stock: {producto1.Stock}");
        producto1.ReducirStockExercise32(6);
        WriteLine($"Stock: {producto1.Stock}");
    }

    class ProductoExercise32
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; private set; }

        public ProductoExercise32(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public void AgregarStockExercise32(int cantidad)
        {
            Stock += cantidad;
        }

        public void ReducirStockExercise32(int cantidad)
        {
            if (Stock >= cantidad)
            {
                Stock -= cantidad;
            }

        }
    }
}