partial class Program
{
    static void Exercise56()
    {
        List<Producto56> productos = new List<Producto56>();

        Producto56 producto1 = new Producto56("Laptop", 15000);
        productos.Add(producto1);
        Producto56 producto2 = new Producto56("Mouse", 500);
        productos.Add(producto2);
        Producto56 producto3 = new Producto56("Teclado", 1200);
        productos.Add(producto3);
        Producto56 producto4 = new Producto56("Monitor", 8000);
        productos.Add(producto4);

        var promedio = productos.Average(p => p.Precio);

        WriteLine($"Promedio: {promedio:C2}");


    }

    class Producto56
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto56(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}