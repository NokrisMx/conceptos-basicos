partial class Program
{
    static void Exercise66()
    {
        List<Producto66> productos = new List<Producto66>();

        Producto66 producto1 = new Producto66("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto66 producto2 = new Producto66("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto66 producto3 = new Producto66("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto66 producto4 = new Producto66("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto66 producto5 = new Producto66("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.Where(p => p.Precio > 1000).GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}");
            foreach (var c in cat)
            {
                WriteLine($"{c.Nombre} - {c.Precio:C2}");
            }
        }



    }

    class Producto66
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto66(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}