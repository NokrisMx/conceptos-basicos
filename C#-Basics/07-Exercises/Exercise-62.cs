partial class Program
{
    static void Exercise62()
    {
        List<Producto62> productos = new List<Producto62>();

        Producto62 producto1 = new Producto62("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto62 producto2 = new Producto62("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto62 producto3 = new Producto62("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto62 producto4 = new Producto62("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto62 producto5 = new Producto62("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Sum(p => p.Precio):C2}");
        }



    }

    class Producto62
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto62(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}