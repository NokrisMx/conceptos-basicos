partial class Program
{
    static void Exercise24()
    {
        Producto producto = new Producto();

        producto.Nombre = "Laptop";
        producto.Precio = 15000;
        producto.Stock = 5;

        WriteLine($"Producto: {producto.Nombre}");
        WriteLine($"Precio: {producto.Precio:C2}");
        WriteLine($"Stock: {producto.Stock}");
    }

    class Producto
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

    }
}