partial class Program
{
    static void Exercise22()
    {
        List<string> productos = new List<string>
{
    "Laptop",
    "Mouse",
    "Teclado",
    "Monitor"
};

        List<decimal> precios = new List<decimal>
{
    15000,
    500,
    1200,
    6500
};
        List<string> resultado = ObtenerProductosCaros(productos, precios);
        WriteLine($"Productos caros: {String.Join(", ", resultado)}");
    }

    static List<string> ObtenerProductosCaros(List<string> productos, List<decimal> precios)
    {
        List<string> resultado = new List<string> { };

        for (int i = 0; i < precios.Count; i++)
        {
            if (precios[i] > 2000)
            {
                resultado.Add(productos[i]);
            }
        }
        return resultado;
    }
}