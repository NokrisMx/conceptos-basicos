partial class Program
{
    static void Exercise65()
    {
        List<Producto65> productos = new List<Producto65>();

        Producto65 producto1 = new Producto65("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto65 producto2 = new Producto65("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto65 producto3 = new Producto65("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto65 producto4 = new Producto65("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto65 producto5 = new Producto65("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Min(p => p.Precio):C2}");
        }



    }

    class Producto65
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto65(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}