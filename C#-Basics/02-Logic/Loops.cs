partial class Program
{
    static void Loops()
    {
        //*While
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteración: {counter}");
            counter++;
        }

        //*do while
        int number = 0;
        do
        {
            WriteLine($"Número: {number}");
            number++;
        }
        while (number < 3);

        //*for
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteracción: {i}");
        }

        //*foreach
        //?Arreglos(Arrays)
        string[] fruits = ["Manzana", "Pera", "Piña"];
        foreach (var fruta in fruits)
        {
            WriteLine(fruta);
        }
        //?Listas
        List<string> names = ["pedro", "Luis", "Nancy"];
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }

}