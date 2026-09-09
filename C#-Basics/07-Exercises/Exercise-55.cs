partial class Program
{
    static void Exercise55()
    {
        List<Producto55> productos = new List<Producto55>();

        Producto55 producto1 = new Producto55("Laptop", 15000);
        productos.Add(producto1);
        Producto55 producto2 = new Producto55("Mouse", 500);
        productos.Add(producto2);
        Producto55 producto3 = new Producto55("Teclado", 1200);
        productos.Add(producto3);
        Producto55 producto4 = new Producto55("Monitor", 8000);
        productos.Add(producto4);

        var suma = productos.Sum(p => p.Precio);

        WriteLine($"Suma: {suma:C2}");


    }

    class Producto55
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto55(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}