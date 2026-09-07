partial class Program
{
    static void Exercise26()
    {
        List<Producto> productos = new List<Producto>();

        Producto producto1 = new Producto();
        producto1.Nombre = "Laptop";
        producto1.Precio = 15000;
        producto1.Stock = 5;
        productos.Add(producto1);

        Producto producto2 = new Producto();
        producto2.Nombre = "Mouse";
        producto2.Precio = 500;
        producto2.Stock = 20;
        productos.Add(producto2);

        Producto producto3 = new Producto();
        producto3.Nombre = "Teclado";
        producto3.Precio = 1200;
        producto3.Stock = 10;
        productos.Add(producto3);


        for (int i = 0; i < productos.Count; i++)
        {
            WriteLine($"Producto: {productos[i].Nombre}");
            WriteLine($"Precio: {productos[i].Precio:C2}");
            WriteLine($"Stock: {productos[i].Stock}");
            WriteLine("----------------------------------");
        }
        /*   ALTERNATIVA A FOR
                foreach (Producto producto in productos)
                {
                    WriteLine($"Producto: {producto.Nombre}");
                    WriteLine($"Precio: {producto.Precio:C2}");
                    WriteLine($"Stock: {producto.Stock}");
                } */
    }
}