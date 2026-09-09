partial class Program
{
    static void Exercise53()
    {
        List<Producto53> productos = new List<Producto53>();

        Producto53 producto1 = new Producto53("Laptop", 15000);
        productos.Add(producto1);
        Producto53 producto2 = new Producto53("Mouse", 500);
        productos.Add(producto2);
        Producto53 producto3 = new Producto53("Teclado", 1200);
        productos.Add(producto3);
        Producto53 producto4 = new Producto53("Monitor", 8000);
        productos.Add(producto4);

        var filtro = productos.Any(p => p.Precio > 10000);

        if (filtro)
        {
            WriteLine("Existe.");
        }
        else
        {
            WriteLine("No existe.");
        }

    }

    class Producto53
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto53(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}