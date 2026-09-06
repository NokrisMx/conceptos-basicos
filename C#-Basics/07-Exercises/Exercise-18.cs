partial class Program
{
    static void Exercise18()
    {
        List<int> numeros = new List<int> { 10, 25, 7, 42, 18 };
        int mayor = ObtenerMayor(numeros);
        WriteLine($"Lista: {String.Join(", ", numeros)}");
        WriteLine($"Número mayor: {mayor}");
    }

    static int ObtenerMayor(List<int> numeros)
    {
        int numero = numeros[0]
        ;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] > numero)
            {
                numero = numeros[i];
            }
        }
        return numero;
    }
}