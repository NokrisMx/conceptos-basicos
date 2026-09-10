partial class Program
{
    static void Exercise71()
    {
        List<Producto71> productos = new List<Producto71>();

        Producto71 producto1 = new Producto71("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto71 producto2 = new Producto71("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto71 producto3 = new Producto71("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto71 producto4 = new Producto71("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto71 producto5 = new Producto71("Webcam", "Accesorio", 2500);
        productos.Add(producto5);


        var resultado = productos.OrderBy(p => p.Categoria).ThenByDescending(p => p.Precio);

        foreach (var r in resultado)
        {
            WriteLine($"{r.Categoria} - {r.Nombre} - {r.Precio:C2}");
        }
    }

    class Producto71
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto71(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}