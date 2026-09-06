/* 
Debes calcular
Para cada producto:
Producto
Precio
Cantidad vendida
Total generado
La fórmula: total generado = precio × cantidad vendida
Al finalizar debes mostrar
1. Total general de ventas
La suma de todo el dinero generado.
2. Producto que generó más dinero
No necesariamente el producto más caro ni el más vendido.
Ejemplo:
Laptop:
$15,000 × 2 = $30,000
Debes comparar el total generado por cada producto.
3. Producto más vendido
El que tenga la mayor cantidad vendida.
4. Productos que generaron menos de $10,000
Debes mostrar todos los que cumplan esa condición. */
partial class Program
{
    static void Exercise11()
    {
        List<string> productos = new List<string>
{
    "Laptop",
    "Mouse",
    "Teclado",
    "Monitor",
    "Audífonos",
    "Webcam"
};

        List<decimal> precios = new List<decimal>
{
    15000m,
    500m,
    1200m,
    6500m,
    800m,
    2200m
};

        List<int> cantidadesVendidas = new List<int>
{
    2,
    15,
    8,
    3,
    20,
    5
};
        decimal totalGenerado = 0;
        decimal productoMasVendido = 0;
        int posicionproductoMasVendido = 0;

        for (int i = 0; i < productos.Count; i++)
        {
            decimal total = precios[i] * cantidadesVendidas[i];
            totalGenerado += total;
            if (total > productoMasVendido)
            {
                productoMasVendido = total;
                posicionproductoMasVendido = i;
            }
            WriteLine($"Producto: {productos[i]} - Precio: {precios[i]:C2} - Cantidad vendidos: {cantidadesVendidas[i]} - Total: {total:C2}");
        }
        WriteLine($"Total generado: {totalGenerado:C2}");
        WriteLine($"Producto más vendido: {productos[posicionproductoMasVendido]} - Total: {productoMasVendido:C2}");
        WriteLine($"Productos que generaron menos de $10,000");
        for (int i = 0; i < productos.Count; i++)
        {
            decimal total = precios[i] * cantidadesVendidas[i];
            if (total < 10000)
            {
                WriteLine($"Producto: {productos[i]}");
            }
        }
    }
}