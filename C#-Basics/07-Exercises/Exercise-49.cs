partial class Program
{
    static void Exercise49()
    {
        List<Producto49> productos = new List<Producto49>();

        Producto49 producto1 = new Producto49("Laptop", 15000);
        productos.Add(producto1);
        Producto49 producto2 = new Producto49("Mouse", 500);
        productos.Add(producto2);
        Producto49 producto3 = new Producto49("Teclado", 1200);
        productos.Add(producto3);
        Producto49 producto4 = new Producto49("Monitor", 8000);
        productos.Add(producto4);

        var ascendente = productos.OrderBy(p => p.Precio);

        foreach (var a in ascendente)
        {
            WriteLine($"{a.Nombre} - {a.Precio:C2}");
        }
    }

    class Producto49
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto49(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}