partial class Program
{
    static void Exercise33()
    {
        ProductoExercise33 producto1 = new ProductoExercise33("Laptop", 15000, 5);
        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {producto1.Stock}");
        producto1.AgregarStockExercise33(15);
        WriteLine($"Stock: {producto1.Stock}");
        producto1.ReducirStockExercise33(6);
        WriteLine($"Stock: {producto1.Stock}");
        decimal inventario = producto1.ObtenerValorInventarioExercise33();
        WriteLine($"Valor inventario: {inventario:C2}");
    }

    class ProductoExercise33
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; private set; }

        public ProductoExercise33(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public void AgregarStockExercise33(int cantidad)
        {
            Stock += cantidad;
        }

        public void ReducirStockExercise33(int cantidad)
        {
            if (Stock >= cantidad)
            {
                Stock -= cantidad;
            }

        }

        public decimal ObtenerValorInventarioExercise33()
        {
            return Precio * Stock;
        }
    }
}