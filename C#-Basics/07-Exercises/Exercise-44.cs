partial class Program
{
    static void Exercise44()
    {
        Producto44 producto = new Producto44("Laptop", 15000, 5);
        WriteLine($"{producto.Nombre}");
        WriteLine($"{producto.Precio}");
        WriteLine($"{producto.Stock}");

        try
        {
            Producto44 producto2 = new Producto44("", -500, -2);
            WriteLine($"{producto2.Nombre}");
            WriteLine($"{producto2.Precio}");
            WriteLine($"{producto2.Stock}");
        }
        catch (Exception ex)
        {

            WriteLine($"Error: {ex.Message}");
        }


    }

    class Producto44
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto44(string nombre, decimal precio, int stock)
        {
            if (String.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("El nombre es obligatorio.");
            }

            if (precio < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo.");
            }

            if (stock < 0)
            {
                throw new ArgumentException("El stock no puede ser negativo.");
            }

            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }
}