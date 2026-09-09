partial class Program
{
    static void Exercise69()
    {
        List<Producto69> productos = new List<Producto69>();

        Producto69 producto1 = new Producto69("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto69 producto2 = new Producto69("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto69 producto3 = new Producto69("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto69 producto4 = new Producto69("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto69 producto5 = new Producto69("Webcam", "Accesorio", 2500);
        productos.Add(producto5);

        var categorias = productos.GroupBy(p => p.Categoria);

        var resultado = categorias.Select(cat => new
        {
            Categoria = cat.Key,
            CantidadProductos = cat.Count(),
            PrecioPromedio = cat.Average(cat => cat.Precio)
        });

        foreach (var r in resultado)
        {
            WriteLine($"{r.Categoria} - {r.CantidadProductos} productos - Promedio: {r.PrecioPromedio:C2}");
        }


    }

    class Producto69
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto69(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}