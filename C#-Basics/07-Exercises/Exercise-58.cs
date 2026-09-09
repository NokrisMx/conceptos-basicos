partial class Program
{
    static void Exercise58()
    {
        List<Producto58> productos = new List<Producto58>();

        Producto58 producto1 = new Producto58("Laptop", 15000);
        productos.Add(producto1);
        Producto58 producto2 = new Producto58("Mouse", 500);
        productos.Add(producto2);
        Producto58 producto3 = new Producto58("Teclado", 1200);
        productos.Add(producto3);
        Producto58 producto4 = new Producto58("Monitor", 8000);
        productos.Add(producto4);

        var between = productos.Where(p => p.Precio >= 1000 && p.Precio <= 10000).Count();

        WriteLine(between);





    }

    class Producto58
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto58(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}