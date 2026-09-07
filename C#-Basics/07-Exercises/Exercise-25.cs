partial class Program
{
    static void Exercise25()
    {
        Producto producto1 = new Producto();
        producto1.Nombre = "Laptop";
        producto1.Precio = 15000;
        producto1.Stock = 5;

        WriteLine($"Producto: {producto1.Nombre}");
        WriteLine($"Precio: {producto1.Precio:C2}");
        WriteLine($"Stock: {producto1.Stock}");

        Producto producto2 = new Producto();
        producto2.Nombre = "Mouse";
        producto2.Precio = 500;
        producto2.Stock = 20;

        WriteLine($"Producto: {producto2.Nombre}");
        WriteLine($"Precio: {producto2.Precio:C2}");
        WriteLine($"Stock: {producto2.Stock}");

        Producto producto3 = new Producto();
        producto3.Nombre = "Teclado";
        producto3.Precio = 1200;
        producto3.Stock = 10;

        WriteLine($"Producto: {producto3.Nombre}");
        WriteLine($"Precio: {producto3.Precio:C2}");
        WriteLine($"Stock: {producto3.Stock}");
    }

}