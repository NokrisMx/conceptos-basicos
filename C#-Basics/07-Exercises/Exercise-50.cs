partial class Program
{
    static void Exercise50()
    {
        List<Producto50> productos = new List<Producto50>();

        Producto50 producto1 = new Producto50("Laptop", 15000);
        productos.Add(producto1);
        Producto50 producto2 = new Producto50("Mouse", 500);
        productos.Add(producto2);
        Producto50 producto3 = new Producto50("Teclado", 1200);
        productos.Add(producto3);
        Producto50 producto4 = new Producto50("Monitor", 8000);
        productos.Add(producto4);

        var filtro = productos.Where(p => p.Precio > 1000).OrderByDescending(p => p.Precio);

        foreach (var f in filtro)
        {
            WriteLine($"{f.Nombre} - {f.Precio:C2}");

        }
    }

    class Producto50
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto50(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}