partial class Program
{
    static void Exercise52()
    {
        List<Producto52> productos = new List<Producto52>();

        Producto52 producto1 = new Producto52("Laptop", 15000);
        productos.Add(producto1);
        Producto52 producto2 = new Producto52("Mouse", 500);
        productos.Add(producto2);
        Producto52 producto3 = new Producto52("Teclado", 1200);
        productos.Add(producto3);
        Producto52 producto4 = new Producto52("Monitor", 8000);
        productos.Add(producto4);

        var filtro = productos.FirstOrDefault(p => p.Precio > 5000);

        WriteLine($"{filtro!.Nombre} - {filtro.Precio:C2}");
    }

    class Producto52
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto52(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}