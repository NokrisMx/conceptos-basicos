partial class Program
{
    static void Exercise16()
    {
        decimal descuento = CalcularDescuento(1000, 10);
        WriteLine(descuento);
    }

    static decimal CalcularDescuento(decimal precio, decimal porcentaje)
    {
        /* decimal convertirPorcentaje = porcentaje / 100;
        decimal descuento = precio * convertirPorcentaje;
        return descuento; */
        return precio * (porcentaje / 100);
    }
}