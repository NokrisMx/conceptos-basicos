partial class Program
{
    static void Exercise47()
    {
        List<Producto47> productos = new List<Producto47>();

        Producto47 producto1 = new Producto47("Laptop", 15000);
        productos.Add(producto1);
        Producto47 producto2 = new Producto47("Mouse", 500);
        productos.Add(producto2);
        Producto47 producto3 = new Producto47("Teclado", 1200);
        productos.Add(producto3);
        Producto47 producto4 = new Producto47("Monitor", 8000);
        productos.Add(producto4);

        var mayor = productos.Where(n => n.Precio > 1000);

        foreach (var m in mayor)
        {
            WriteLine($"{m.Nombre}");
            WriteLine($"{m.Precio:C2}");
        }
    }

    class Producto47
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto47(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}