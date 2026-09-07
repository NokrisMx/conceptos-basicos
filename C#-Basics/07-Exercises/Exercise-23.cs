partial class Program
{
    static void Exercise23()
    {
        List<int> numeros = new List<int> { 10, 25, 8, 42, 17, 30 };
        WriteLine($"Números: {String.Join(", ", numeros)}");

        int mayor = ConseguirMayor(numeros);
        WriteLine($"Mayor: {mayor}");

        int menor = ConseguirMenor(numeros);
        WriteLine($"Menor: {menor}");

        double promedio = ConseguirPromedio(numeros);
        WriteLine($"Promedio: {promedio}");
    }

    static int ConseguirMayor(List<int> numeros)
    {
        int mayor = numeros[0];
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }
        return mayor;
    }

    static int ConseguirMenor(List<int> numeros)
    {
        int menor = numeros[0];
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        return menor;
    }

    static double ConseguirPromedio(List<int> numeros)
    {
        int suma = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            suma += numeros[i];
        }
        double promedio = (double)suma / numeros.Count;
        return promedio;
    }
}