partial class Program
{
    static void Exercise64()
    {
        List<Producto64> productos = new List<Producto64>();

        Producto64 producto1 = new Producto64("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto64 producto2 = new Producto64("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto64 producto3 = new Producto64("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto64 producto4 = new Producto64("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto64 producto5 = new Producto64("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Max(p => p.Precio):C2}");
        }



    }

    class Producto64
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto64(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}