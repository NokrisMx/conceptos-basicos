partial class Program
{
    static void Exercise21()
    {
        List<int> edades = new List<int> { 12, 25, 17, 30, 14, 42, 19 };

        List<int> adultos = ObtenerAdultos(edades);

        WriteLine($"Edades: {String.Join(", ", edades)}");
        WriteLine($"Adultos: {String.Join(", ", adultos)}");
    }

    static List<int> ObtenerAdultos(List<int> edades)
    {
        List<int> mayores = new List<int> { };

        for (int i = 0; i < edades.Count; i++)
        {

            if (edades[i] >= 18)
            {
                mayores.Add(edades[i]);
            }
        }
        return mayores;
    }
}