partial class Program
{
    static void Exercise51()
    {
        List<Producto51> productos = new List<Producto51>();

        Producto51 producto1 = new Producto51("Laptop", 15000);
        productos.Add(producto1);
        Producto51 producto2 = new Producto51("Mouse", 500);
        productos.Add(producto2);
        Producto51 producto3 = new Producto51("Teclado", 1200);
        productos.Add(producto3);
        Producto51 producto4 = new Producto51("Monitor", 8000);
        productos.Add(producto4);

        var filtro = productos.Where(p => p.Precio > 1000).Select(p => p.Nombre);

        foreach (var f in filtro)
        {
            WriteLine($"{f}");

        }
    }

    class Producto51
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto51(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}