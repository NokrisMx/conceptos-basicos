partial class Program
{
    static void Exercise48()
    {
        List<Producto48> productos = new List<Producto48>();

        Producto48 producto1 = new Producto48("Laptop", 15000);
        productos.Add(producto1);
        Producto48 producto2 = new Producto48("Mouse", 500);
        productos.Add(producto2);
        Producto48 producto3 = new Producto48("Teclado", 1200);
        productos.Add(producto3);
        Producto48 producto4 = new Producto48("Monitor", 8000);
        productos.Add(producto4);

        var nombres = productos.Select(n => n.Nombre);

        foreach (var n in nombres)
        {
            WriteLine($"{n}");
        }
    }

    class Producto48
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto48(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}