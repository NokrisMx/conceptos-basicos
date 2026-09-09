partial class Program
{
    static void Exercise61()
    {
        List<Producto61> productos = new List<Producto61>();

        Producto61 producto1 = new Producto61("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto61 producto2 = new Producto61("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto61 producto3 = new Producto61("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto61 producto4 = new Producto61("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto61 producto5 = new Producto61("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}: {cat.Count()}");
        }



    }

    class Producto61
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto61(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}