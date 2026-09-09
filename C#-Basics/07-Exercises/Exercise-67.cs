partial class Program
{
    static void Exercise67()
    {
        List<Producto67> productos = new List<Producto67>();

        Producto67 producto1 = new Producto67("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto67 producto2 = new Producto67("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto67 producto3 = new Producto67("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto67 producto4 = new Producto67("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto67 producto5 = new Producto67("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.Where(p => p.Precio > 1000).GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Count()}");
        }



    }

    class Producto67
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto67(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}