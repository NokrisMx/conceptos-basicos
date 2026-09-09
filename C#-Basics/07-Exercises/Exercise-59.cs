partial class Program
{
    static void Exercise59()
    {
        List<Producto59> productos = new List<Producto59>();

        Producto59 producto1 = new Producto59("Laptop", 15000, 2);
        productos.Add(producto1);
        Producto59 producto2 = new Producto59("Mouse", 500, 5);
        productos.Add(producto2);
        Producto59 producto3 = new Producto59("Teclado", 1200, 3);
        productos.Add(producto3);
        Producto59 producto4 = new Producto59("Monitor", 8000, 1);
        productos.Add(producto4);

        var calculo = productos.Select(p => new { p.Nombre, Total = p.Precio * p.Cantidad });

        foreach (var c in calculo)
        {
            WriteLine($"{c.Nombre} - {c.Total:C2}");
        }


    }

    class Producto59
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto59(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}