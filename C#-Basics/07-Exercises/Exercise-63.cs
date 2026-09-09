partial class Program
{
    static void Exercise63()
    {
        List<Producto63> productos = new List<Producto63>();

        Producto63 producto1 = new Producto63("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto63 producto2 = new Producto63("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto63 producto3 = new Producto63("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto63 producto4 = new Producto63("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto63 producto5 = new Producto63("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Average(p => p.Precio):C2}");
        }



    }

    class Producto63
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto63(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}