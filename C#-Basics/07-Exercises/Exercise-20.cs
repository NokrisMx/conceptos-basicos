partial class Program
{
    static void Exercise20()
    {
        List<int> numeros = new List<int> { 10, 15, 20, 25, 30, 35 };

        List<int> pares = ObtenerPares(numeros);

        WriteLine($"Original: {String.Join(", ", numeros)}");
        WriteLine($"Pares: {String.Join(", ", pares)}");
    }

    static List<int> ObtenerPares(List<int> numeros)
    {
        List<int> pares = new List<int> { };

        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares.Add(numeros[i]);
            }
        }

        return pares;
    }
}