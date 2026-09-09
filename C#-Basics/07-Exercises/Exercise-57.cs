partial class Program
{
    static void Exercise57()
    {
        List<Producto57> productos = new List<Producto57>();

        Producto57 producto1 = new Producto57("Laptop", 15000);
        productos.Add(producto1);
        Producto57 producto2 = new Producto57("Mouse", 500);
        productos.Add(producto2);
        Producto57 producto3 = new Producto57("Teclado", 1200);
        productos.Add(producto3);
        Producto57 producto4 = new Producto57("Monitor", 8000);
        productos.Add(producto4);

        var max = productos.Max(p => p.Precio);
        var min = productos.Min(p => p.Precio);


        WriteLine($"Máximo: {max:C2}");
        WriteLine($"Mínimo: {min:C2}");


    }

    class Producto57
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto57(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}