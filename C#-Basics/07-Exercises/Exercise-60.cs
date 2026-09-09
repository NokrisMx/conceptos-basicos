partial class Program
{
    static void Exercise60()
    {
        List<Producto60> productos = new List<Producto60>();

        Producto60 producto1 = new Producto60("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto60 producto2 = new Producto60("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto60 producto3 = new Producto60("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto60 producto4 = new Producto60("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto60 producto5 = new Producto60("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        foreach (var cat in categorias)
        {
            WriteLine($"{cat.Key}");
            foreach (var c in cat)
            {
                WriteLine($"{c.Nombre} - {c.Precio}");
            }
        }



    }

    class Producto60
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Producto60(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}