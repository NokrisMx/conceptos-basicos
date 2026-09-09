partial class Program
{
    static void Exercise70()
    {
        List<Producto70> productos = new List<Producto70>();

        Producto70 producto1 = new Producto70("Laptop", "Computadora", 15000);
        productos.Add(producto1);
        Producto70 producto2 = new Producto70("Mouse", "Accesorio", 500);
        productos.Add(producto2);
        Producto70 producto3 = new Producto70("Teclado", "Accesorio", 1200);
        productos.Add(producto3);
        Producto70 producto4 = new Producto70("Monitor", "Computadora", 8000);
        productos.Add(producto4);
        Producto70 producto5 = new Producto70("Webcam", "Accesorio", 2500);
        productos.Add(producto5);


        var resultado = productos.OrderBy(p => p.Categoria).ThenBy(p => p.Precio);

        foreach (var r in resultado)
        {
            WriteLine($"{r.Categoria} - {r.Nombre} - {r.Precio:C2}");
        }
    }

    class Producto70
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto70(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}