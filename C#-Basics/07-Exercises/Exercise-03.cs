/* Crea un programa que:
Cuente cuántas personas son mayores o iguales a 18 años.
Cuente cuántas son menores de 18.
Calcule la suma de las edades de los mayores de edad.
Muestre el promedio de edad de los mayores de edad. */
partial class Program
{
    static void Exercise03()
    {
        List<int> edades = new List<int> { 15, 22, 17, 30, 12, 45, 18, 16, 25, 60 };
        int mayorEdad = 0;
        int menorEdad = 0;
        int suma = 0;
        double promedio = 0;

        foreach (int e in edades)
        {
            if (e >= 18)
            {
                mayorEdad++;
                suma += e;
            }
            if (e < 18)
            {
                menorEdad++;
            }
        }

        promedio = (double)suma / mayorEdad;

        WriteLine($"Lista: {String.Join(", ", edades)}");
        WriteLine($"Mayores de edad: {mayorEdad}");
        WriteLine($"Menores de edad: {menorEdad}");
        WriteLine($"Suma de mayores de edad: {suma}");
        WriteLine($"Promedio mayores de edad: {promedio}");
    }
}