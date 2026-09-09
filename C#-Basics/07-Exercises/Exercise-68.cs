partial class Program
{
    static void Exercise68()
    {
        List<Producto68> productos = new List<Producto68>();

        Producto68 producto1 = new Producto68("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto68 producto2 = new Producto68("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto68 producto3 = new Producto68("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto68 producto4 = new Producto68("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto68 producto5 = new Producto68("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.Where(p => p.Precio > 1000).GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Sum(p => p.Precio):C2}");
        }



    }

    class Producto68
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto68(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}