partial class Program
{
    static void Exercise19()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        double promedio = CalcularPromedio(numeros);
        WriteLine($"Numeros: {String.Join(", ", numeros)}");
        WriteLine($"Promedio: {promedio}");
    }

    static double CalcularPromedio(List<int> numeros)
    {
        double suma = 0;

        for (int i = 0; i < numeros.Count; i++)
        {
            suma += numeros[i];
        }

        double promedio = (double)suma / numeros.Count;
        return promedio;
    }
}