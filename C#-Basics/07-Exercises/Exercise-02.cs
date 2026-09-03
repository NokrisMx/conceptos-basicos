/* Crea un programa que encuentre:
El número mayor.
El número menor.
La suma de todos los números. */
partial class Program
{
    static void Exercise02()
    {
        List<int> numeros = new List<int> { 12, 5, 30, 8, 45, 17, 25, 50 };
        int suma = 0;
        int numMayor = numeros[0];
        int numMenor = numeros[0];

        foreach (int n in numeros)
        {
            if (n > numMayor)
            {
                numMayor = n;
            }
            if (n < numMenor)
            {
                numMenor = n;
            }

            suma += n;
        }
        WriteLine($"Lista: {String.Join(", ", numeros)}");
        WriteLine($"Número Mayor: {numMayor}");
        WriteLine($"Número Menor: {numMenor}");
        WriteLine($"Suma total: {suma}");
    }
}