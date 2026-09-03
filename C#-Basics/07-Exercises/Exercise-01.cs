partial class Program
{
    static void Exercise01()
    {
        List<int> numeros = new List<int> { 10, 15, 22, 7, 8, 31, 40, 13 };
        int pares = 0;
        int impares = 0;

        WriteLine("Numeros de lista:");
        foreach (int n in numeros)
        {
            if (n % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }
        WriteLine($"Numeros pares: {pares}");
        WriteLine($"Numeros impares: {impares}");
    }

}
