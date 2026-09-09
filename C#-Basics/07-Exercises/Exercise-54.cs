partial class Program
{
    static void Exercise54()
    {
        List<Producto54> productos = new List<Producto54>();

        Producto54 producto1 = new Producto54("Laptop", 15000);
        productos.Add(producto1);
        Producto54 producto2 = new Producto54("Mouse", 500);
        productos.Add(producto2);
        Producto54 producto3 = new Producto54("Teclado", 1200);
        productos.Add(producto3);
        Producto54 producto4 = new Producto54("Monitor", 8000);
        productos.Add(producto4);

        var filtro = productos.Count(p => p.Precio > 1000);

        WriteLine($"Mayor a $1,000: {filtro}");

    }

    class Producto54
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto54(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}