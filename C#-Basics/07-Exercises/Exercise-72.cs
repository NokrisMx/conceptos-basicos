partial class Program
{
    static void Exercise72()
    {
        List<Producto72> productos = new List<Producto72>();

        Producto72 producto1 = new Producto72("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto72 producto2 = new Producto72("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto72 producto3 = new Producto72("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto72 producto4 = new Producto72("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto72 producto5 = new Producto72("Webcam", "Accesorio", 2500);
        productos.Add(producto5);


        var resultado = productos.Select(p => p.Categoria).Distinct();

        foreach (var r in resultado)
        {
            WriteLine($"{r}");
        }
    }

    class Producto72
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto72(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}